Imports DevComponents.DotNetBar.SuperGrid
Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar


Public Class P_Notas

#Region "Variables Globales"

    Dim _Nuevo As Boolean
    Dim _Modificar As Boolean
    Dim _Eliminar As Boolean

    Dim _Grabar As Integer '1,2 Nuevo; 3,4 Modificar; 5,6 Eliminar

    Dim G_Usuario As String = P_Global.gs_usuario

    Dim _DuracionSms As Integer = 5
    Dim _Cont As Integer = 0

    Dim _DsNota As DataSet
    Dim _DsNota1 As DataSet
    Dim _DsNota2 As DataSet
    Dim DtClientePendiente As DataTable
    Dim DtEquipo As DataTable
    Dim DtPagos As DataTable
    Dim DtGastos As DataTable

    Dim _MaxReg As Integer
    Dim _NavegadorReg As Integer

    Dim _NroColumnasTP As Integer = 0

    Dim _ContadorDMA = 0

    Dim _Bool As Boolean = True

    Dim _CodZona As String = ""

    Dim BoolCliente As Byte

    Dim FiltroZona As String = ""

    Dim DtTO0023 As DataTable

    Dim inCodRepPrecioFijo As Integer = 31
#End Region


#Region "Eventos"

    Private Sub P_Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Nuevo.Click, Bt1Nuevo.Click
        P_NuevoRegistro()
        Bt1Nuevo.Enabled = False
        Bt2Modificar.Enabled = False
        Bt3Eliminar.Enabled = False
        Bt4Grabar.Enabled = True
        Bt5Cancelar.TooltipText = "CANCELAR"

        BBtn_Inicio.Enabled = False
        BBtn_Anterior.Enabled = False
        BBtn_Siguiente.Enabled = False
        BBtn_Ultimo.Enabled = False
        BubbleBar4.Refresh()

        Rl1Accion.Text = "NUEVO"
        DtTO0023 = L_fnGeneralTO0023("-1")
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Modificar.Click, Bt2Modificar.Click
        P_ModificarRegistro()
        Bt1Nuevo.Enabled = False
        Bt2Modificar.Enabled = False
        Bt3Eliminar.Enabled = False
        Bt4Grabar.Enabled = True
        Bt5Cancelar.TooltipText = "CANCELAR"

        BBtn_Inicio.Enabled = False
        BBtn_Anterior.Enabled = False
        BBtn_Siguiente.Enabled = False
        BBtn_Ultimo.Enabled = False
        BubbleBar4.Refresh()

        Rl1Accion.Text = "MODIFICAR"
        DtTO0023 = L_fnGeneralTO0023("-1")
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Eliminar.Click, Bt3Eliminar.Click
        P_EliminarRegistro()
        Bt1Nuevo.Enabled = False
        Bt2Modificar.Enabled = False
        Bt3Eliminar.Enabled = False
        Bt4Grabar.Enabled = True
        Bt5Cancelar.TooltipText = "CANCELAR"

        BBtn_Inicio.Enabled = False
        BBtn_Anterior.Enabled = False
        BBtn_Siguiente.Enabled = False
        BBtn_Ultimo.Enabled = False
        BubbleBar4.Refresh()

        Rl1Accion.Text = "ELIMINAR"
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Grabar.Click, Bt4Grabar.Click
        P_GrabarRegistro()
        If (_Grabar Mod 2 = 0) Then
            Bt4Grabar.Image = My.Resources.CONFIRMACION
            Bt4Grabar.ImageLarge = My.Resources.CONFIRMACION
            Bt4Grabar.TooltipText = "CONFIRMAR GRABACIÓN"
        Else
            If (_Cont = 1) Then
                Bt4Grabar.Image = My.Resources.GRABAR
                Bt4Grabar.ImageLarge = My.Resources.GRABAR
                Bt4Grabar.TooltipText = "GRABAR"
                Bt5Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
            End If
        End If
        Bb1Aciones.Refresh()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Cancelar.Click, Bt5Cancelar.Click
        P_CancelarRegistro()

        If (_Grabar = 0 And Bt5Cancelar.TooltipText.Equals("SALIR")) Then
            Me.Close()
            Me.Dispose()
        End If

        Bt1Nuevo.Enabled = True
        Bt2Modificar.Enabled = True
        Bt3Eliminar.Enabled = True
        Bt4Grabar.Enabled = False
        Bt5Cancelar.TooltipText = "SALIR"

        Bt4Grabar.Image = My.Resources.GRABAR
        Bt4Grabar.ImageLarge = My.Resources.GRABAR
        Bt4Grabar.TooltipText = "GRABAR"

        BBtn_Inicio.Enabled = True
        BBtn_Anterior.Enabled = True
        BBtn_Siguiente.Enabled = True
        BBtn_Ultimo.Enabled = True
        BubbleBar4.Refresh()

        Rl1Accion.Text = ""
        Dge_Repartidor.BringToFront()
    End Sub

    Private Sub Dge_CategoriaProducto_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dge_CategoriaProducto.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dge_Repartidor_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dge_Repartidor.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dge_CategoriaProducto_SelectionChanged(sender As Object, e As EventArgs) Handles Dge_CategoriaProducto.SelectionChanged
        If (Dge_CategoriaProducto.RowCount > 0 And Dge_Repartidor.CurrentRow.RowIndex > -1) Then
            If (DgdNota.PrimaryGrid.Rows.Count > 1) Then
                If (MessageBox.Show("SE PERDERA LA INFORACIÓN DE LA TABLA NOTAS" + Chr(13) + "DESEA CONTINUAR ?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No) Then
                    Exit Sub
                End If
            End If
            Txt_CodTipoProducto.Text = Dge_CategoriaProducto.CurrentRow.Cells(0).Value 'He puesto el indice de la columna por que el seteo de las se realiza despes de este evento
            Txt_TipoProducto.Text = Dge_CategoriaProducto.CurrentRow.Cells(1).Value 'He puesto el indice de la columna por que el seteo de las se realiza despes de este evento
            For Each _fil As Janus.Windows.GridEX.GridEXRow In Dge_CategoriaProducto.GetRows
                Dim _estiloFila As New GridEXFormatStyle()
                If (_fil.RowIndex = Dge_CategoriaProducto.CurrentRow.RowIndex) Then
                    _estiloFila.BackColor = Color.LightGreen
                    _fil.RowStyle = _estiloFila
                Else
                    _fil.RowStyle = _estiloFila
                End If
            Next
        End If
    End Sub

    Private Sub Dge_Repartidor_SelectionChanged(sender As Object, e As EventArgs) Handles Dge_Repartidor.SelectionChanged
        If (Dge_Repartidor.RowCount > 0 And Dge_Repartidor.CurrentRow.RowIndex > -1) Then
            Txt_CodRepartidor.Text = Dge_Repartidor.CurrentRow.Cells(0).Value 'He puesto el indice de la columna por que el seteo de las se realiza despes de este evento
            Txt_Repartidor.Text = Dge_Repartidor.CurrentRow.Cells(1).Value 'He puesto el indice de la columna por que el seteo de las se realiza despes de este evento
            For Each _fil As Janus.Windows.GridEX.GridEXRow In Dge_Repartidor.GetRows
                Dim _estiloFila As New GridEXFormatStyle()
                If (_fil.RowIndex = Dge_Repartidor.CurrentRow.RowIndex) Then
                    _estiloFila.BackColor = Color.LightGreen
                    _fil.RowStyle = _estiloFila
                Else
                    _fil.RowStyle = _estiloFila
                End If
            Next
        End If
    End Sub

    Private Sub Txt_CodTipoProducto_TextChanged(sender As Object, e As EventArgs) Handles Txt_CodTipoProducto.TextChanged
        If (Txt_CodTipoProducto.Text.Length > 0 And Not Txt_CodTipoProducto.Text.Equals("0")) Then
            P_LlenarDgsNota("0", Txt_CodTipoProducto.Text)
        End If
    End Sub

    Private Sub Txt_CodRepartidor_TextChanged(sender As Object, e As EventArgs) Handles Txt_CodRepartidor.TextChanged
        If (Bt4Grabar.Enabled = True) Then
            P_prPonerMovimientosDia()
        End If
    End Sub

    Private Sub Dti_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Dti_Fecha.ValueChanged
        If (Bt4Grabar.Enabled = True) Then
            P_prPonerMovimientosDia()
        End If
    End Sub

#End Region

#Region "Medotos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabControl1.SelectedTabIndex = 0

        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False

        Bt4Grabar.Enabled = False

        Txt_Pagos.Text = "0"
        Txt_Equipos.Text = "0"
        Txt_Contado.Text = "0"
        Txt_Credito.Text = "0"
        Txt_TotalEfectivo.Text = "0"
        Txt_Tapas.Text = "0"
        Txt_TotalRecibido.Text = "0"
        Txt_Decuentos.Text = "0"

        TbdGastos.Value = 0


        P_HabilitarComponentes(False)

        P_CargarGridRepartidor(Dge_Repartidor)
        P_CargarGridCatProducto(Dge_CategoriaProducto)

        _DsNota = L_GetNotas()

        _NavegadorReg = 1
        P_ActualizarPuterosNavegacion()
        P_LlenarDatos(_NavegadorReg)

        P_ArmarGridEquipoPago()

        P_ArmaGrillaAyuda()

        DtTO0023 = L_fnGeneralTO0023("-1")

        'activar los permisos del rol
        _PAsignarPermisos()
        _pCambiarFuente()

    End Sub

    Private Sub _pCambiarFuente()
        Dim fuente As New Font("Tahoma", gi_fuenteTamano, FontStyle.Regular)
        Dim xCtrl As Control
        For Each xCtrl In PanelEx3.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next
        For Each xCtrl In PanelEx4.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub _PAsignarPermisos()
        Dim idRolUsu As String = L_Usuario_General(-1, " AND yduser='" + P_Global.gs_usuario + "' ").Tables(0).Rows(0).Item("ybnumi")
        Dim dtRolUsu As DataTable = L_RolDetalle_General2(-1, idRolUsu, "ycyanumi=27")
        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            Bt1Nuevo.Visible = False
        End If
        If modif = False Then
            Bt2Modificar.Visible = False
        End If
        If del = False Then
            Bt3Eliminar.Visible = False
        End If

    End Sub

    Private Sub P_NuevoRegistro()

        P_Limpiar()
        _Nuevo = True
        _Modificar = False
        _Eliminar = False

        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_HabilitarComponentes(_Nuevo)

        Dge_Repartidor.Select()
        Dge_Repartidor.MoveTo(Dge_Repartidor.FilterRow)
        SendKeys.Send("{DOWN}")
        P_SelecionarRepartidor()
        P_SelecionarTipoProducto()

        Txt_CodTipoProducto.Text = 1
        Txt_TipoProducto.Text = "AGUA"

        For Each fil As GridEXRow In Dge_CategoriaProducto.GetRows
            Dim _estiloFila As New GridEXFormatStyle()
            _estiloFila.BackColor = Color.LightGreen
            fil.RowStyle = _estiloFila
            Exit For
        Next

        _Grabar = 1
    End Sub

    Private Sub P_ModificarRegistro()
        _Nuevo = False
        _Modificar = True
        _Eliminar = False
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_HabilitarComponentes(_Modificar)
        Txt_NroNota.SelectAll()
        _Grabar = 3
        P_SelecionarRepartidor()
        P_SelecionarTipoProducto()
    End Sub

    Private Sub P_EliminarRegistro()
        _Nuevo = False
        _Modificar = False
        _Eliminar = True
        BBtn_Grabar.TooltipText = "GRABAR ELIMINACIÓN DE REGISTRO"
        P_HabilitarComponentes(False)
        _Grabar = 5
    End Sub

    Private Sub P_GrabarRegistro()
        'TO002
        Dim numi As String
        Dim nota As String
        Dim fdoc As String
        Dim tprod As String
        Dim repa As String
        Dim tap As String
        Dim des As String
        Dim fact As String = Now.Date.ToString("yyyy/MM/dd")
        Dim hact As String = TimeOfDay.Hour.ToString("00") + ":" + TimeOfDay.Minute.ToString("00")
        Dim uact As String = G_Usuario

        'TO0021
        Dim lin As String
        Dim ncli As String
        Dim efec As String
        Dim cred As String
        Dim nrec As String
        Dim nfac As String
        Dim nped As String
        Dim tipo As String

        'TO0022
        Dim lin2 As String
        Dim ccli As String
        Dim cprod As String
        Dim cant As String

        Txt_NroNota.Select()

        Dim inserts As String = ""

        If (_Nuevo) Then
            If (_Grabar = 2) Then
                If (P_ValidarNota()) Then

                    P_Recalcular()

                    numi = L_GetLastIdTablas("TO002", "odnumi") + 1
                    nota = Txt_NroNota.Text.Trim
                    fdoc = Dti_Fecha.Value.ToString("yyyy/MM/dd")
                    tprod = Txt_CodTipoProducto.Text.Trim
                    repa = Txt_CodRepartidor.Text.Trim
                    tap = Txt_Tapas.Text.Trim
                    des = Txt_Decuentos.Text.Trim

                    'TO002
                    L_GrabarNuevoNota(
                                       "" + numi + ", " _
                                     + "" + nota + ", " _
                                     + "'" + fdoc + "', " _
                                     + "" + tprod + ", " _
                                     + "" + repa + ", " _
                                     + "" + tap + ", " _
                                     + "" + des + ", " _
                                     + "'" + fact + "', " _
                                     + "'" + hact + "', " _
                                     + "'" + uact + "'"
                                     )

                    'TO0021
                    inserts = ""
                    Dim i As Integer = 1
                    For Each _f As GridRow In DgdNota.PrimaryGrid.Rows
                        lin = i
                        ncli = _f.GetCell("codC").Value
                        efec = _f.GetCell("con").Value
                        cred = _f.GetCell("cre").Value
                        nrec = _f.GetCell("not").Value
                        nfac = _f.GetCell("fac").Value
                        nped = _f.GetCell("ped").Value
                        tipo = _f.GetCell("tip").Value

                        inserts = inserts + "(" _
                                     + "" + numi + ", " _
                                     + "" + lin + ", " _
                                     + "" + ncli + ", " _
                                     + "" + efec + ", " _
                                     + "" + cred + ", " _
                                     + "" + nrec + ", " _
                                     + "" + nfac + ", " _
                                     + "" + nped + ", " _
                                     + "'" + tipo + "'),"
                        i += 1
                        'Actualiza la tabla de estados de 2=Dictados a 4=Entregado
                        L_ActualizarEstadoPedido("oaest = 4, oarepa = " + Txt_CodRepartidor.Text, "oanumi = " + nped)

                        'Grabar registro historico de pedido
                        L_PedidoEstados_Grabar(nped, "4", fact, hact, uact)
                    Next

                    'Va a grabar los datos en una sola cadena de Inserción
                    If (DgdNota.PrimaryGrid.Rows.Count > 0) Then
                        inserts = inserts.Substring(1, inserts.Length - 3)
                        If (inserts.Length > 0) Then
                            L_GrabarNuevoNotaDetalle(inserts)
                        End If
                    End If
                    P_ActSaldo(True)

                    'TO0022
                    i = 1
                    inserts = ""
                    For Each _f As GridRow In DgdNota.PrimaryGrid.Rows
                        lin2 = i
                        For ii As Integer = 3 To 3 + _NroColumnasTP - 1
                            ccli = _f.GetCell("codC").Value
                            cprod = DgdNota.PrimaryGrid.Columns(ii).Name
                            cant = _f.GetCell(ii).Value

                            inserts = inserts + "(" _
                                         + "" + numi + ", " _
                                         + "" + lin2 + ", " _
                                         + "" + ccli + ", " _
                                         + "'" + cprod + "', " _
                                         + "" + cant + "),"
                        Next
                        i += 1
                    Next

                    'Va a grabar los datos en una sola cadena de Inserción
                    If (DgdNota.PrimaryGrid.Rows.Count > 0) Then
                        inserts = inserts.Substring(1, inserts.Length - 3)
                        If (inserts.Length > 0) Then
                            L_GrabarNuevoNotaDetalle2(inserts)
                        End If
                    End If

                    'Preguntar si el descuento es mayor cero(0)
                    If (Txt_Decuentos.Text.Length > 0) Then
                        If (IsNumeric(Txt_Decuentos.Text)) Then
                            If (CDbl(Txt_Decuentos.Text) > 0) Then
                                'Grabar descuento
                                If (Not L_ExisteDescuento(Dti_Fecha.Value.Date.Year.ToString, Dti_Fecha.Value.Date.Month.ToString, Txt_CodRepartidor.Text)) Then
                                    'insertar cabecera
                                    numi = CStr(CInt(L_GetLastIdTablas("TP002", "pbnumi").ToString) + 1)
                                    L_InsertarCabeceraDescuendo(numi + ", " _
                                                                + Txt_CodRepartidor.Text + ", " _
                                                                + Dti_Fecha.Value.Date.Year.ToString + ", " _
                                                                + Dti_Fecha.Value.Date.Month.ToString + ", " _
                                                                + "'" + fact + "', " _
                                                                + "'" + hact + "', " _
                                                                + "'" + uact + "' "
                                                                )
                                Else
                                    numi = L_ObtenerDato("pbnumi",
                                                         "TP002",
                                                         "pbcper = " + Txt_CodRepartidor.Text + " and pbano = " + Dti_Fecha.Value.Date.Year.ToString + " and pbmes = " + Dti_Fecha.Value.Date.Month.ToString)
                                End If
                                'Grabar detalle descuento
                                L_InsertarDetalleDescuendo(numi + ", " _
                                                            + "0, " _
                                                            + Txt_Decuentos.Text.Trim + ", " _
                                                            + "'Nota " + Txt_NroNota.Text.Trim + "', " _
                                                            + "1, " _
                                                            + "0, " _
                                                            + "'" + Dti_Fecha.Value.Date.ToString("yyyy/MM/dd") + "'"
                                                            )
                            End If
                        End If
                    End If

                    If (DtTO0023.Rows.Count > 0) Then
                        For Each fil As DataRow In DtTO0023.Rows
                            fil.Item("ojto2") = CInt(numi)
                            L_fnGrabarTO0023(fil.Item("ojnumi"), fil.Item("ojtc1"), fil.Item("ojtc4"), fil.Item("ojcant"),
                                             fil.Item("ojest"), fil.Item("ojdif"), fil.Item("ojto1"), fil.Item("ojto2"))
                        Next

                    End If

                    P_Limpiar()
                    ToastNotification.Show(Me, "SE HA GUARDADO EXITOSAMENTE..!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                    _Cont = 1

                    _DsNota = L_GetNotas()
                    P_ActualizarPuterosNavegacion()
                    P_ArmaGrillaAyuda()
                Else
                    _Cont = 0
                End If
                _Grabar = 1
            Else
                _Grabar = 2
            End If
        ElseIf (_Modificar) Then
            If (_Grabar = 4) Then
                If (P_ValidarNota()) Then

                    P_Recalcular()

                    numi = Txt_Codigo.Text.Trim
                    nota = Txt_NroNota.Text.Trim
                    fdoc = Dti_Fecha.Value.ToString("yyyy/MM/dd")
                    tprod = Txt_CodTipoProducto.Text.Trim
                    repa = Txt_CodRepartidor.Text.Trim
                    tap = Txt_Tapas.Text.Trim
                    des = Txt_Decuentos.Text.Trim

                    'TO002
                    L_GrabarModificarNota(
                                       "odnumi = " + numi + ", " _
                                     + "odnota = " + nota + ", " _
                                     + "odfdoc = '" + fdoc + "', " _
                                     + "odtprod = " + tprod + ", " _
                                     + "odrepa = " + repa + ", " _
                                     + "odtap = " + tap + ", " _
                                     + "oddes = " + des + ", " _
                                     + "odfact = '" + fact + "', " _
                                     + "odhact = '" + hact + "', " _
                                     + "oduact = '" + uact + "'",
                                     "odnumi = " + numi
                                     )


                    'TO0021
                    'Obtiene los clientes que tienen credito para devolver sus saldo
                    P_ActSaldo(False, L_NotasDetalle1_ClienteCredito("a.oenumi =" + numi))

                    'Elimina el Detalle 1
                    L_GrabarEliminarNotaDetalle("oenumi = " + numi)

                    inserts = ""
                    Dim i As Integer = 1
                    For Each _f As GridRow In DgdNota.PrimaryGrid.Rows
                        lin = i
                        ncli = _f.GetCell("codC").Value
                        efec = _f.GetCell("con").Value
                        cred = _f.GetCell("cre").Value
                        nrec = _f.GetCell("not").Value
                        nfac = _f.GetCell("fac").Value
                        nped = _f.GetCell("ped").Value
                        tipo = _f.GetCell("tip").Value

                        inserts = inserts + "(" _
                                     + "" + numi + ", " _
                                     + "" + lin + ", " _
                                     + "" + ncli + ", " _
                                     + "" + efec + ", " _
                                     + "" + cred + ", " _
                                     + "" + nrec + ", " _
                                     + "" + nfac + ", " _
                                     + "" + nped + ", " _
                                     + "'" + tipo + "'),"
                        i += 1
                        'Actualiza la tabla de estados de 2=Dictados a 4=Entregado
                        L_ActualizarEstadoPedido("oaest = 4", "oanumi = " + nped)

                        'Grabar registro historico de pedido
                        L_PedidoEstados_Grabar(nped, "4", fact, hact, uact)
                    Next

                    'Va a grabar los datos en una sola cadena de Inserción
                    If (DgdNota.PrimaryGrid.Rows.Count > 0) Then
                        inserts = inserts.Substring(1, inserts.Length - 3)
                        If (inserts.Length > 0) Then
                            L_GrabarNuevoNotaDetalle(inserts)
                        End If
                    End If

                    'Actualiza los Saldos según el Grid Notas
                    P_ActSaldo(True)

                    'TO0022
                    'Elimina el detalle 2
                    L_GrabarEliminarNotaDetalle2("ofnumi = " + numi)
                    i = 1
                    inserts = ""
                    For Each _f As GridRow In DgdNota.PrimaryGrid.Rows
                        lin2 = i
                        For ii As Integer = 3 To 3 + _NroColumnasTP - 1
                            ccli = _f.GetCell("codC").Value
                            cprod = DgdNota.PrimaryGrid.Columns(ii).Name
                            cant = _f.GetCell(ii).Value

                            inserts = inserts + "(" _
                                         + "" + numi + ", " _
                                         + "" + lin2 + ", " _
                                         + "" + ccli + ", " _
                                         + "'" + cprod + "', " _
                                         + "" + cant + "),"
                        Next
                        i += 1
                    Next

                    'Va a grabar los datos en una sola cadena de Inserción
                    If (DgdNota.PrimaryGrid.Rows.Count > 0) Then
                        inserts = inserts.Substring(1, inserts.Length - 3)
                        If (inserts.Length > 0) Then
                            L_GrabarNuevoNotaDetalle2(inserts)
                        End If
                    End If

                    If (DtTO0023.Rows.Count > 0) Then
                        For Each fil As DataRow In DtTO0023.Rows
                            L_fnGrabarTO0023(fil.Item("ojnumi"), fil.Item("ojtc1"), fil.Item("ojtc4"), fil.Item("ojcant"),
                                             fil.Item("ojest"), fil.Item("ojdif"), fil.Item("ojto1"), fil.Item("ojto2"))
                        Next

                    End If

                    ToastNotification.Show(Me, "SE HA MODIFICADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                    _Cont = 1

                    P_Limpiar()
                    _DsNota = L_GetNotas()
                    P_ActualizarPuterosNavegacion()
                    P_LlenarDatos(_NavegadorReg)

                    P_ArmaGrillaAyuda()
                Else
                    _Cont = 0
                End If
                _Grabar = 3
            Else
                _Grabar = 4
            End If

        ElseIf (_Eliminar) Then
            If (_Grabar = 6) Then
                If (True) Then
                    'Devolver saldo de los cliente
                    P_ActSaldo(False)

                    'Cambiar los estados de los pedidos a 2=Dictado
                    For Each fil As GridRow In DgdNota.PrimaryGrid.Rows
                        If (Not fil.Cells("ped").Value.ToString.Trim.Equals("0")) Then
                            L_ActualizarEstadoPedido("oaest = 2", "oanumi = " + fil.Cells("ped").Value.ToString)
                            L_PedidoEstados_Grabar(fil.Cells("ped").Value.ToString, "2", fact, hact, uact)
                        End If
                    Next

                    numi = Txt_Codigo.Text.Trim

                    'TO002
                    L_GrabarEliminarNota("odnumi = " + numi)

                    'TO0021
                    L_GrabarEliminarNotaDetalle("oenumi = " + numi)

                    'TO0022
                    L_GrabarEliminarNotaDetalle2("ofnumi = " + numi)

                    P_Limpiar()

                    ToastNotification.Show(Me, "SE HA ELIMINADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomRight)
                    _Cont = 1

                    _DsNota = L_GetNotas()
                    P_ActualizarPuterosNavegacion()
                    P_LlenarDatos(_NavegadorReg)

                    P_ArmaGrillaAyuda()
                Else
                    _Cont = 0
                    ToastNotification.Show(Me, "DEBE ELEGIR UN REGISTRO...!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                End If
                _Grabar = 5
            Else
                _Grabar = 6
            End If
        End If
    End Sub

    Private Sub P_CancelarRegistro()
        _Nuevo = False
        _Modificar = False
        _Eliminar = False
        P_Limpiar()
        P_HabilitarComponentes(False)
        P_LlenarDatos(_NavegadorReg)

        _Grabar = 0
    End Sub

    Private Sub P_ActSaldo(bool As Boolean, Optional dt As DataTable = Nothing)
        Dim _Tabla As New DataTable
        _Tabla.Columns.Add("codC")
        _Tabla.Columns.Add("mon")
        _Tabla.Columns.Add("sto")
        If (dt Is Nothing) Then
            For Each _fila As GridRow In DgdNota.PrimaryGrid.Rows
                If (Not _fila.Cells("tip").Value.ToString.Trim.Equals("ENTREGA")) Then
                    _Tabla.Rows.Add(_fila.Cells("codC").Value, _fila.Cells("cre").Value, "0")
                End If
            Next
        Else 'Cuando se recibe un datatable con los datos de creditos de cliente sin los que tienen tipo= ENTREGA
            For Each fil As DataRow In dt.Rows
                _Tabla.Rows.Add(fil.Item("codC").ToString, fil.Item("cre").ToString, "0")
            Next
        End If
        G_ActStock(_Tabla, bool)
    End Sub

    Private Sub P_CargarGridRepartidor(ByRef objGrid As Janus.Windows.GridEX.GridEX)
        Dim dt As New DataTable
        dt = L_Empleado_GeneralSimple(0).Tables(0)

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dt
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns("cbnumi")
            .Caption = "Cod."
            .Key = "CodRepartidor"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns("cbdesc")
            .Caption = "Repartidor"
            .Key = "Repartidor"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
        End With
        objGrid.Dock = DockStyle.Fill
        objGrid.BringToFront()

    End Sub

    Private Sub P_CargarGridCatProducto(objGrid As GridEX)
        Dim dt As New DataTable
        dt = L_GetItemsConceptoLibreriaEquipo("5").Tables(0)

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = dt
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Caption = "cod".ToUpper
            .Key = "cod"
            .Width = 40
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns(1)
            .Caption = "tipo de producto".ToUpper
            .Key = "tipP"
            .Width = 185
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

#End Region

    Private Sub P_LlenarDgsNota(_codRepatidor As String, _codTipoProducto As String)
        P_ArmarGrillaColumnas()
        P_ArmarGrillaColumnasResumen()
        P_prArmarGrillaColumnasMovimiento()
        P_LlenarDatosFilas()
        P_Resumen()
        P_prPonerMovimientosDia()
    End Sub

    Private Sub P_ArmarGrillaColumnas()
        DgdNota.PrimaryGrid.Columns.Clear()
        Dim col As GridColumn

        'Columna Orden
        col = New GridColumn()
        col.Name = "ord"
        col.HeaderText = "or.".ToUpper
        col.Width = 40
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Código de Cliente
        col = New GridColumn()
        col.Name = "codC"
        col.HeaderText = "código".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Nombre Cliente
        col = New GridColumn()
        col.Name = "cli"
        col.HeaderText = "nombre cliente".ToUpper
        col.Width = 200
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)
        Dim fechaNota As Date
        If (Not Bt4Grabar.Enabled) Then 'Esta navegando
            fechaNota = CDate(Dti_Fecha.Value)
        Else 'Esta en Nuevo o Modificación
            fechaNota = CDate(Now.Date)
        End If

        Dim _Dt As DataTable = L_GetProductosCategoria("a.cacat = " + Txt_CodTipoProducto.Text)
        _NroColumnasTP = _Dt.Rows.Count

        For Each _fil As DataRow In _Dt.Rows
            Dim fechaProducto As Date = CDate(_fil.Item("cafing"))
            'fechaProducto = fechaProducto
            If (fechaProducto < fechaNota) Then 'Desde la creacion del producto al dia siguiente se podra meter las notas
                'Agregar Columnas de un tipo de producto derterminado
                col = New GridColumn()
                col.Name = _fil.Item("cacod").ToString
                col.HeaderText = _fil.Item("cadesc2").ToString.ToUpper
                col.Width = _fil.Item("cadesc2").ToString.Length * 10
                col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
                col.Visible = True
                col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

                DgdNota.PrimaryGrid.Columns.Add(col)
            End If
        Next

        'Columna Contado
        col = New GridColumn()
        col.Name = "con"
        col.HeaderText = "contado".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Credito
        col = New GridColumn()
        col.Name = "cre"
        col.HeaderText = "credito".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
        'col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDoubleInputEditControl)
        col.DataType = Type.GetType("System.Double")

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Nota
        col = New GridColumn()
        col.Name = "not"
        col.HeaderText = "nota".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Factura
        col = New GridColumn()
        col.Name = "fac"
        col.HeaderText = "factura".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Pedido
        col = New GridColumn()
        col.Name = "ped"
        col.HeaderText = "pedido".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

        'Columna Tipo
        col = New GridColumn()
        col.Name = "tip"
        col.HeaderText = "tipo".ToUpper
        col.Width = 120
        col.EditorType = GetType(GridImageCombo)
        col.EditorParams = New Object() {ilTipoNota, ilTipoNota.Images(0).Height}
        'col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)

        DgdNota.PrimaryGrid.Columns.Add(col)

    End Sub

    Private Sub P_ArmarGrillaColumnasResumen()
        Dgd2Resumen.PrimaryGrid.Columns.Clear()
        Dim col As GridColumn

        'Columna Orden
        col = New GridColumn()
        col.Name = "ord"
        col.HeaderText = "or.".ToUpper
        col.Width = 40
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Código de Cliente
        col = New GridColumn()
        col.Name = "codC"
        col.HeaderText = "código".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Nombre Cliente
        col = New GridColumn()
        col.Name = "cli"
        col.HeaderText = "nombre cliente".ToUpper
        col.Width = 200
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)
        Dim fechaNota As Date
        If (Not Bt4Grabar.Enabled) Then 'Esta navegando
            fechaNota = CDate(Dti_Fecha.Value)
        Else 'Esta en Nuevo o Modificación
            fechaNota = CDate(Now.Date)
        End If
        Dim _Dt As DataTable = L_GetProductosCategoria("a.cacat = " + Txt_CodTipoProducto.Text)
        _NroColumnasTP = _Dt.Rows.Count

        For Each _fil As DataRow In _Dt.Rows
            Dim fechaProducto As Date = CDate(_fil.Item("cafing"))
            'fechaProducto = fechaProducto
            If (fechaProducto < fechaNota) Then
                'Agregar Columnas de un tipo de producto derterminado
                col = New GridColumn()
                col.Name = _fil.Item("cacod").ToString
                col.HeaderText = _fil.Item("cadesc2").ToString.ToUpper
                col.Width = _fil.Item("cadesc2").ToString.Length * 10
                col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
                col.Visible = True

                Dgd2Resumen.PrimaryGrid.Columns.Add(col)
            End If
        Next

        'Columna Contado
        col = New GridColumn()
        col.Name = "con"
        col.HeaderText = "contado".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Credito
        col = New GridColumn()
        col.Name = "cre"
        col.HeaderText = "credito".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Nota
        col = New GridColumn()
        col.Name = "not"
        col.HeaderText = "nota".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Factura
        col = New GridColumn()
        col.Name = "fac"
        col.HeaderText = "factura".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Pedido
        col = New GridColumn()
        col.Name = "ped"
        col.HeaderText = "pedido".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)

        'Columna Tipo
        col = New GridColumn()
        col.Name = "tip"
        col.HeaderText = "tipo".ToUpper
        col.Width = 120
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        Dgd2Resumen.PrimaryGrid.Columns.Add(col)
    End Sub

    Private Sub P_prArmarGrillaColumnasMovimiento()
        DgdMovimiento.PrimaryGrid.Columns.Clear()
        Dim col As GridColumn

        'Columna Orden
        col = New GridColumn()
        col.Name = "ord"
        col.HeaderText = "or.".ToUpper
        col.Width = 40
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Código de Cliente
        col = New GridColumn()
        col.Name = "codC"
        col.HeaderText = "código".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Nombre Cliente
        col = New GridColumn()
        col.Name = "cli"
        col.HeaderText = "nombre cliente".ToUpper
        col.Width = 200
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)
        Dim fechaNota As Date
        If (Not Bt4Grabar.Enabled) Then 'Esta navegando
            fechaNota = CDate(Dti_Fecha.Value)
        Else 'Esta en Nuevo o Modificación
            fechaNota = CDate(Now.Date)
        End If
        Dim _Dt As DataTable = L_GetProductosCategoria("a.cacat = " + Txt_CodTipoProducto.Text)
        _NroColumnasTP = _Dt.Rows.Count

        For Each _fil As DataRow In _Dt.Rows
            Dim fechaProducto As Date = CDate(_fil.Item("cafing"))
            'fechaProducto = fechaProducto
            If (fechaProducto < fechaNota) Then
                'Agregar Columnas de un tipo de producto derterminado
                col = New GridColumn()
                col.Name = _fil.Item("cacod").ToString
                col.HeaderText = _fil.Item("cadesc2").ToString.ToUpper
                col.Width = _fil.Item("cadesc2").ToString.Length * 10
                col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
                col.Visible = True

                DgdMovimiento.PrimaryGrid.Columns.Add(col)
            End If
        Next

        'Columna Contado
        col = New GridColumn()
        col.Name = "con"
        col.HeaderText = "contado".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Credito
        col = New GridColumn()
        col.Name = "cre"
        col.HeaderText = "credito".ToUpper
        col.Width = 100
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Nota
        col = New GridColumn()
        col.Name = "not"
        col.HeaderText = "nota".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Factura
        col = New GridColumn()
        col.Name = "fac"
        col.HeaderText = "factura".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Pedido
        col = New GridColumn()
        col.Name = "ped"
        col.HeaderText = "pedido".ToUpper
        col.Width = 80
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)

        'Columna Tipo
        col = New GridColumn()
        col.Name = "tip"
        col.HeaderText = "tipo".ToUpper
        col.Width = 120
        col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
        col.Visible = True

        DgdMovimiento.PrimaryGrid.Columns.Add(col)
    End Sub

    Private Sub P_LlenarDatosFilas(Optional _Dtable As DataTable = Nothing)
        Dim _fil As GridRow
        Dim _cel As GridCell
        Dim _colorNuevaFila As Color

        DgdNota.PrimaryGrid.Rows.Clear()

        Dim _Dt As DataTable
        If (_Dtable Is Nothing) Then
            _Dt = L_GetDatosNota("a.oarepa = 0 and c.cacat = " + Txt_CodTipoProducto.Text)
        Else
            _Dt = _Dtable
        End If

        _Bool = True
        For Each _f As DataRow In _Dt.Rows
            If (_Bool) Then
                _colorNuevaFila = ColorTranslator.FromHtml("#FFFFFF")
                _Bool = False
            Else
                _colorNuevaFila = ColorTranslator.FromHtml("#EEEEEE")
                _Bool = True
            End If
            _fil = New GridRow()

            'Orden
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = True
            _cel.Value = IIf(_Dtable Is Nothing, _f.Item("or").ToString(), _f.Item("or").ToString())
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Código Cliente
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = True
            _cel.Value = IIf(_Dtable Is Nothing, _f.Item("cod").ToString(), _f.Item("cod").ToString())
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Nombre del Cliente
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _cel.ReadOnly = True
            _cel.Value = IIf(_Dtable Is Nothing, _f.Item("cli").ToString(), _f.Item("cli").ToString())
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            For i As Integer = 1 To _NroColumnasTP
                'A que producto pertenece
                _cel = New GridCell
                _cel.EditorType = GetType(GridTextBoxXEditControl)
                _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
                _cel.ReadOnly = True
                _cel.Value = 0
                _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
                _fil.Cells.Add(_cel)
                'Buscar he insertar, 
            Next

            'Contado
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = True
            If (_Dtable Is Nothing) Then
                _cel.Value = _f.Item("tot").ToString()
            Else
                _cel.Value = _f.Item("con").ToString()
            End If
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Credito
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = False
            If (_Dtable Is Nothing) Then
                _cel.Value = 0
            Else
                _cel.Value = _f.Item("cre").ToString()
            End If
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)


            'Nota
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = False
            If (_Dtable Is Nothing) Then
                _cel.Value = 0
            Else
                _cel.Value = _f.Item("not").ToString()
            End If
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Factura
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = False
            If (_Dtable Is Nothing) Then
                _cel.Value = 0
            Else
                _cel.Value = _f.Item("fac").ToString()
            End If
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Pedido
            _cel = New GridCell
            _cel.EditorType = GetType(GridTextBoxXEditControl)
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = True
            _cel.Value = IIf(_Dtable Is Nothing, _f.Item("ped").ToString(), _f.Item("ped").ToString())
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            'Tipo
            _cel = New GridCell
            _cel.EditorType = GetType(GridImageCombo)
            _cel.EditorParams = New Object() {ilTipoNota, ilTipoNota.Images(0).Height}
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _cel.ReadOnly = False
            If (_Dtable Is Nothing) Then
                '_cel.Value = "."
                _cel.Value = ilTipoNota.Images.Keys(0)
            Else
                Select Case _f.Item("tip").ToString()
                    Case "NORMAL"
                        _cel.Value = ilTipoNota.Images.Keys(0)
                    Case "ENTREGA"
                        _cel.Value = ilTipoNota.Images.Keys(1)
                    Case "CORTESIA"
                        _cel.Value = ilTipoNota.Images.Keys(2)
                    Case "CAMBIO"
                        _cel.Value = ilTipoNota.Images.Keys(3)
                End Select
            End If
            _cel.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _fil.Cells.Add(_cel)

            DgdNota.PrimaryGrid.Rows.Add(_fil)
        Next
        If (_Dtable Is Nothing) Then
            P_SetDatosClientesProductos(_Dt)
        End If

    End Sub

    Private Sub P_SetDatosClientesProductos(_Dt As DataTable)
        Dim i As Integer = 0
        For Each _fil As DataRow In _Dt.Rows
            Dim c As GridCell = CType(DgdNota.PrimaryGrid.GetCell(i, DgdNota.PrimaryGrid.Columns(_fil.Item("codP").ToString).ColumnIndex), GridCell)
            c.Value = _fil.Item("can").ToString
            i += 1
        Next
    End Sub

    Private Sub P_Resumen()
        Dgd2Resumen.PrimaryGrid.Rows.Clear()
        Dim _fil As New GridRow
        Dim _cel As GridCell
        For i As Integer = 0 To DgdNota.PrimaryGrid.Columns.Count - 1
            _cel = New GridCell
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _cel.ReadOnly = True
            _cel.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano + 2, FontStyle.Bold)
            _cel.CellStyles.Default.Background.Color1 = ColorTranslator.FromHtml("#66FFFF")
            If (i = 2) Then
                _cel.Value = "TOTALES"
                _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            ElseIf (i > 2 And i < _NroColumnasTP + 3) Then
                _cel.Value = P_SumarColumna(DgdNota.PrimaryGrid.Columns(i).Name)
            ElseIf (DgdNota.PrimaryGrid.Columns(i).Name.Equals("con") Or DgdNota.PrimaryGrid.Columns(i).Name.Equals("cre")) Then
                _cel.Value = P_SumarColumna(DgdNota.PrimaryGrid.Columns(i).Name)
                If (DgdNota.PrimaryGrid.Columns(i).Name.Equals("con")) Then
                    Txt_Contado.Text = _cel.Value
                ElseIf (DgdNota.PrimaryGrid.Columns(i).Name.Equals("cre")) Then
                    Txt_Credito.Text = _cel.Value
                End If
            Else
                _cel.Value = ""
                _cel.CellStyles.Default.Background.Color1 = ColorTranslator.FromHtml("#BBBBBB")
            End If
            _fil.Cells.Add(_cel)
        Next
        Dgd2Resumen.PrimaryGrid.Rows.Add(_fil)

    End Sub

    Public Sub P_prPonerMovimientosDia()

        DgdMovimiento.PrimaryGrid.Rows.Clear()
        Dim fil As New GridRow
        Dim cel As GridCell
        For i As Integer = 0 To DgdNota.PrimaryGrid.Columns.Count - 1
            cel = New GridCell
            cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            cel.ReadOnly = True
            cel.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano + 2, FontStyle.Bold)
            cel.CellStyles.Default.Background.Color1 = ColorTranslator.FromHtml("#FF9933")
            If (i = 2) Then
                cel.Value = "Movimento S/E"
                cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            ElseIf (i > 2 And i < _NroColumnasTP + 3) Then
                If (IsNumeric(DgdNota.PrimaryGrid.Columns(i).Name)) Then
                    cel.Value = P_fnObtenerMovimientoChofer(DgdNota.PrimaryGrid.Columns(i).Name)
                End If
            Else
                cel.Value = ""
                cel.CellStyles.Default.Background.Color1 = ColorTranslator.FromHtml("#BBBBBB")
            End If
            fil.Cells.Add(cel)
        Next
        DgdMovimiento.PrimaryGrid.Rows.Add(fil)
    End Sub

    Private Function P_fnObtenerMovimientoChofer(codProd As String) As Double
        Dim cantSalida As Double = 0
        Dim cantDevolucion As Double = 0
        If (Not Txt_CodRepartidor.Text = String.Empty And Not Txt_NroNota.Text = String.Empty And Not Txt_CodTipoProducto.Text = String.Empty) Then
            Dim dtSalida As DataTable = L_GetTabla("TM001 a inner join TM0012 b on a.ibidconcil=b.ieid 
                                                    and a.ibidchof=" + Txt_CodRepartidor.Text.Trim + " 
                                                    /*and a.ibfdoc='" + Dti_Fecha.Value.ToString("yyyy-MM-dd") + "'*/ 
                                                    and a.ibnota=" + Txt_NroNota.Text.Trim + " 
                                                    and a.ibtprod=" + Txt_CodTipoProducto.Text.Trim + " 
                                                    left join TM0011 c on a.ibid=c.icibid and c.iccprod=" + codProd,
                                                    "sum(c.iccant) as salida",
                                                    "1=1")
            Dim dtDevolucion As DataTable = L_GetTabla("TM001 a inner join TM0011 b on a.ibid=b.icibid 
                                                       and a.ibidconcil=0 and a.ibidchof=" + Txt_CodRepartidor.Text.Trim + " 
                                                       /*and a.ibfdoc='" + Dti_Fecha.Value.ToString("yyyy-MM-dd") + "'*/ and b.iccprod=" + codProd + " and a.ibnota=" + Txt_NroNota.Text.Trim,
                                                       "sum(b.iccant) as devolucion",
                                                       "1=1")
            If (Not IsDBNull(dtSalida.Rows(0).Item("salida"))) Then
                cantSalida = CDbl(dtSalida.Rows(0).Item("salida"))
            End If
            If (Not IsDBNull(dtDevolucion.Rows(0).Item("devolucion"))) Then
                cantDevolucion = CDbl(dtDevolucion.Rows(0).Item("devolucion"))
            End If
        End If
        Return cantSalida - cantDevolucion
    End Function

    Private Function P_SumarColumna(col As String) As Object
        Dim totPro As Double = 0

        For Each _fil As GridRow In DgdNota.PrimaryGrid.Rows
            If (Not _fil.Cells("tip").Value.ToString.Equals("ENTREGA")) Then
                totPro = totPro + CDbl(_fil.Cells(col).Value)
            End If
        Next
        Return totPro
    End Function

    Private Sub P_SumarColumnaContadoCredito(col As String)
        Dim conT As GridCell = CType(Dgd2Resumen.PrimaryGrid.GetCell(0, Dgd2Resumen.PrimaryGrid.Columns("con").ColumnIndex), GridCell)
        Dim creT As GridCell = CType(Dgd2Resumen.PrimaryGrid.GetCell(0, Dgd2Resumen.PrimaryGrid.Columns("cre").ColumnIndex), GridCell)
        Dim proT As GridCell = CType(Dgd2Resumen.PrimaryGrid.GetCell(0, Dgd2Resumen.PrimaryGrid.Columns(col).ColumnIndex), GridCell)
        Dim totPro As Double = 0
        Dim totCon As Double = 0
        Dim totCre As Double = 0

        For Each _fil As GridRow In DgdNota.PrimaryGrid.Rows
            If (Not _fil.Cells("tip").Value.ToString.Equals("ENTREGA")) Then
                totCon = totCon + CDbl(_fil.Cells("con").Value)
                totCre = totCre + CDbl(_fil.Cells("cre").Value)
                If (Not col.Equals("cre")) Then
                    totPro = totPro + CDbl(_fil.Cells(col).Value)
                End If
            End If
        Next
        conT.Value = totCon
        creT.Value = totCre
        If (Not col.Equals("cre")) Then
            proT.Value = totPro
        End If

        Txt_Contado.Text = totCon.ToString("0.00")
        Txt_Credito.Text = totCre.ToString("0.00")
    End Sub

    Private Sub DgdNota_CellValidating(sender As Object, e As GridCellValidatingEventArgs) Handles DgdNota.CellValidating
        'Valida que la grilla tenga filas
        If (DgdNota.PrimaryGrid.Rows.Count = 0) Then
            Exit Sub
        End If

        'Valida que lo que se ponga en la columna de cantidad de producto sean numeros y mayores a cero (0)
        If (e.GridCell.ColumnIndex > 2 And e.GridCell.ColumnIndex <= 2 + _NroColumnasTP) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 9
                        e.Value = 0
                    Case 0
                        e.Value = 0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If

        Dim cel As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, e.GridCell.ColumnIndex), GridCell)

        'Valida que el monto de contado sea numero, que sea numero, de longitud menor a 18, que no este vacio
        If (cel.GridColumn.Name.Equals("con")) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 18
                        e.Value = 0.0
                    Case 0
                        e.Value = 0.0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If

        'Valida que el monto de credito sea numero, que sea numero, de longitud menor a 18, que no este vacio
        If (cel.GridColumn.Name.Equals("cre")) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 18
                        e.Value = 0.0
                    Case 0
                        e.Value = 0.0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If

        'Valida que el nro de recibo sea numero, que sea numero, de longitud menor a 12, que no este vacio
        If (cel.GridColumn.Name.Equals("not")) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 12
                        e.Value = 0
                    Case 0
                        e.Value = 0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If

        'Valida que el nro de factura sea numero, que sea numero, de longitud menor a 12, que no este vacio
        If (cel.GridColumn.Name.Equals("fac")) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 12
                        e.Value = 0
                    Case 0
                        e.Value = 0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If

        'Valida que el nro de pedido sea numero, que sea numero, de longitud menor a 9, que no este vacio
        If (cel.GridColumn.Name.Equals("ped")) Then
            'Si no es numero
            If (Not IsNumeric(e.Value)) Then
                e.Value = 0
            Else 'Es numero
                Select Case e.Value.ToString.Length
                    Case Is > 9
                        e.Value = 0
                    Case 0
                        e.Value = 0
                    Case Else
                        'Si es numero negativo
                        If (CDbl(e.Value) < 0) Then
                            e.Value = e.Value * -1
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub DgdNota_EndEdit(sender As Object, e As GridEditEventArgs) Handles DgdNota.EndEdit
        'Validar que la grilla tenga filas
        If (DgdNota.PrimaryGrid.Rows.Count = 0) Then
            Exit Sub
        End If

        Dim con As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("con").ColumnIndex), GridCell)
        Dim cre As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("cre").ColumnIndex), GridCell)
        Dim contado As Decimal = 0
        Dim credito As Decimal = 0
        'Columnas de producto
        If (e.GridCell.ColumnIndex > 2 And e.GridCell.ColumnIndex <= 2 + _NroColumnasTP) Then
            contado = P_PonerPrecio(e.GridCell.RowIndex)
            credito = cre.Value

            Dim tip As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("tip").ColumnIndex), GridCell)
            If (tip.Value.ToString.Equals("NORMAL")) Then 'Si es tipo=NORMAL
                'Si el credito es mayor que el contado, credito=contado y contado=0
                If (credito > contado) Then
                    credito = contado
                    contado = 0
                Else
                    contado = contado - credito
                End If
            ElseIf (tip.Value.ToString.Equals("ENTREGA")) Then 'Si es tipo=ENTREGA
                e.GridCell.Value = 0
                contado = 0
                credito = cre.Value
            ElseIf (tip.Value.ToString.Equals("CORTESIA") Or tip.Value.ToString.Equals("CAMBIO")) Then 'Si es tipo=CORTESIA ó CAMBIO
                contado = 0
                credito = 0
            End If

            con.Value = contado
            cre.Value = credito

            P_SumarColumnaContadoCredito(e.GridCell.GridColumn.Name)

            'Diferencia de pedido
            Dim nped As String = DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("ped").ColumnIndex).Value.ToString
            If (IsNumeric(nped)) Then
                If (L_fnTO0023ValidarPedido(nped).Rows.Count > 0) Then
                    Dim numi, tc1, tc4, cant, est, dif, to1, to2 As Integer
                    numi = 0
                    tc1 = CInt(e.GridCell.GridColumn.Name)
                    tc4 = CInt(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("codC").ColumnIndex).Value.ToString)
                    cant = CInt(e.GridCell.Value)
                    est = IIf(_Nuevo, 1, 2)
                    dif = 0
                    to1 = CInt(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("ped").ColumnIndex).Value.ToString)
                    If (_Nuevo) Then
                        to2 = 0
                    Else
                        to2 = CInt(Txt_Codigo.Text.Trim)
                    End If

                    DtTO0023.Rows.Add(numi, tc1, tc4, cant, est, dif, to1, to2, Now.Date, "00:00", Txt_NombreUsu.Text.Trim)
                End If
            End If
        End If

        Dim cel As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, e.GridCell.ColumnIndex), GridCell)
        'Columna de credito
        If (cel.GridColumn.Name.Equals("cre")) Then
            contado = P_PonerPrecio(e.GridCell.RowIndex)
            credito = cre.Value

            Dim tip As GridCell = CType(DgdNota.PrimaryGrid.GetCell(e.GridCell.RowIndex, DgdNota.PrimaryGrid.Columns("tip").ColumnIndex), GridCell)
            If (tip.Value.ToString.Equals("NORMAL")) Then 'Si es tipo=NORMAL
                'Si el credito es mayor que el contado, credito=contado y contado=0
                If (credito > contado) Then
                    Dim info As New TaskDialogInfo("leer con atención!!!".ToUpper,
                                                   eTaskDialogIcon.Information, "información".ToUpper,
                                                   "crédito mayor que contado".ToUpper _
                                                   + vbCrLf + "monto crédito: ".ToUpper + credito.ToString + " > " _
                                                   + "monto contado: ".ToUpper + contado.ToString _
                                                   + vbCrLf + "desea cambiar el tipo a ''entrega''?".ToUpper,
                                                   eTaskDialogButton.Yes Or eTaskDialogButton.No,
                                                   eTaskDialogBackgroundColor.Blue)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    If (result = eTaskDialogResult.Yes) Then
                        contado = 0
                        P_prPonerCantidadProductoCero(cel.RowIndex)
                        tip.Value = "ENTREGA"

                        For i As Integer = 3 To _NroColumnasTP + 2
                            P_SumarColumnaContadoCredito(DgdNota.PrimaryGrid.Columns(i).Name)
                        Next
                    Else
                        credito = contado
                        contado = 0
                    End If
                Else
                    contado = contado - credito
                End If
            ElseIf (tip.Value.ToString.Equals("ENTREGA")) Then 'Si es tipo=ENTREGA
                contado = 0
                P_prPonerCantidadProductoCero(cel.RowIndex)
            ElseIf (tip.Value.ToString.Equals("CORTESIA") Or tip.Value.ToString.Equals("CAMBIO")) Then 'Si es tipo=CORTESIA ó CAMBIO
                contado = 0
                credito = 0
            End If

            con.Value = contado
            cre.Value = credito

            P_SumarColumnaContadoCredito(e.GridCell.GridColumn.Name)
        End If

        'Columna tipo
        If (cel.GridColumn.Name.Equals("tip")) Then
            'NORMAL
            If (e.GridCell.Value.ToString.Equals("NORMAL")) Then
                contado = P_PonerPrecio(e.GridCell.RowIndex)
                credito = cre.Value

                If (credito > contado) Then
                    credito = contado
                    contado = 0
                Else
                    contado = contado - credito
                End If

                con.Value = contado
                cre.Value = credito
            End If
            'ENTREGA
            If (e.GridCell.Value.ToString.Equals("ENTREGA")) Then
                contado = 0
                credito = cre.Value

                con.Value = contado
                cre.Value = credito

                P_prPonerCantidadProductoCero(cel.RowIndex)
            End If
            'CORTESIA o CAMBIO
            If (e.GridCell.Value.ToString.Equals("CORTESIA") Or e.GridCell.Value.ToString.Equals("CAMBIO")) Then
                contado = 0
                credito = 0

                con.Value = contado
                cre.Value = credito
            End If

            For i As Integer = 3 To _NroColumnasTP + 2
                P_SumarColumnaContadoCredito(DgdNota.PrimaryGrid.Columns(i).Name)
            Next
        End If
    End Sub

    Private Sub P_Limpiar()
        Txt_Codigo.Clear()
        Txt_NroNota.Clear()
        Dti_Fecha.Text = Now.Date.ToShortDateString
        Txt_CodRepartidor.Clear()
        Txt_Repartidor.Clear()
        Txt_CodTipoProducto.Clear()
        Txt_TipoProducto.Clear()

        DgdNota.PrimaryGrid.Rows.Clear()
        Txt_Pagos.Text = "0"
        Txt_Equipos.Text = "0"
        Txt_Contado.Text = "0"
        Txt_Credito.Text = "0"
        Txt_TotalEfectivo.Text = "0"
        Txt_Tapas.Text = "0"
        Txt_Decuentos.Text = "0"
        TbdGastos.Value = 0

        LabelX16.Text = ""

        Dgd3Equipo.PrimaryGrid.Rows.Clear()
        Dgd4Pagos.PrimaryGrid.Rows.Clear()
        DgdGastos.PrimaryGrid.Rows.Clear()
    End Sub

    Private Sub P_HabilitarComponentes(_bool As Boolean)
        Txt_NroNota.ReadOnly = Not _bool
        Dti_Fecha.Enabled = _bool

        Dge_Repartidor.Enabled = _bool
        Dge_CategoriaProducto.Enabled = _bool
        DgdNota.PrimaryGrid.ReadOnly = Not _bool

        Txt_Tapas.IsInputReadOnly = Not _bool
        Txt_Decuentos.IsInputReadOnly = Not _bool

        Bt1AddPendientes.Enabled = _bool
        Bt2InsClientes.Enabled = _bool

        Bt6Recalcular.Enabled = _bool

        SuperTabItem2.Visible = Not _bool
    End Sub

    Private Sub P_ActualizarPuterosNavegacion()
        _MaxReg = _DsNota.Tables(0).Rows.Count - 1
        If (_NavegadorReg > _MaxReg) Then
            _NavegadorReg = _MaxReg
        End If
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_CargarGridCliente(objGrid As GridEX, tipo As Integer) 'tipo 1 = trae todo los cliente, 2 = trae los cliente con pedidos de ese tipo de producto y ese repartidor
        Dim DtClientePendiente As New DataTable
        If (tipo = 1) Then
            DtClientePendiente = L_GetClientesSimple(_CodZona, Txt_CodRepartidor.Text.Trim).Tables(0) 'No esta mirando la Zona
        ElseIf (tipo = 2) Then
            DtClientePendiente = L_GetClientesPedido(Txt_CodTipoProducto.Text, Txt_CodRepartidor.Text.Trim).Tables(0)
        End If

        objGrid.BoundMode = BoundMode.Bound
        objGrid.DataSource = DtClientePendiente
        objGrid.RetrieveStructure()

        'dar formato a las columnas
        With objGrid.RootTable.Columns(0)
            .Caption = "COD."
            .Key = "cod"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns(1)
            .Caption = "NRO DOC"
            .Key = "nroD"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.FontSize = gi_fuenteTamano
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With objGrid.RootTable.Columns(2)
            .Caption = "CLIENTE"
            .Key = "cli"
            .Width = 220
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With objGrid.RootTable.Columns(3)
            .Caption = "DIRECCIÓN"
            .Key = "dir"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With objGrid.RootTable.Columns(4)
            .Caption = ""
            .Key = "zon"
            .Width = 0
            .Visible = False
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        With objGrid.RootTable.Columns(5)
            .Caption = "ZONA"
            .Key = "nzon"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        End With

        If (tipo = 2) Then
            With objGrid.RootTable.Columns(6)
                .Key = "codP"
                .Visible = False
            End With

            With objGrid.RootTable.Columns(7)
                .Key = "can"
                .Visible = False
            End With

            With objGrid.RootTable.Columns(8)
                .Key = "tot"
                .Visible = False
            End With

            With objGrid.RootTable.Columns(9)
                .Key = "ped"
                .Visible = False
            End With
        End If

        'Habilitar Filtradores
        With objGrid
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.SingleSelection
            .AlternatingColors = True
        End With
        objGrid.Dock = DockStyle.Fill
        objGrid.BringToFront()
        objGrid.Select()

        objGrid.MoveTo(objGrid.FilterRow)
        objGrid.Col = 2
        objGrid.AlternatingColors = True
        GroupPanel1.Text = "cliente".ToUpper
    End Sub

    Private Sub Dge_Clientes_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dge_Clientes.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dge_Clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Dge_Clientes.KeyDown
        If (e.KeyCode = Keys.Enter And Dge_Clientes.CurrentRow.RowIndex > -1) Then
            Dim _ultimaFila As Integer = DgdNota.PrimaryGrid.Rows.Count - 1
            Dim _colorNuevaFila As Color
            Dim _colorBorde As Color = ColorTranslator.FromHtml("#FF5722")

            If (_Bool) Then
                _colorNuevaFila = ColorTranslator.FromHtml("#FFFFFF")
                _Bool = False
            Else
                _colorNuevaFila = ColorTranslator.FromHtml("#EEEEEE")
                _Bool = True
            End If
            Dim _nf As New GridRow
            Dim _nc As GridCell

            _nc = New GridCell

            'Orden
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = True
            _nc.Value = DgdNota.PrimaryGrid.Rows.Count + 1
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Código Cliente
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = True
            '_nc.Value = _fil.Cells.Item("cod").Value
            _nc.Value = Dge_Clientes.GetValue("cod")
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Nombre del Cliente
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _nc.ReadOnly = True
            '_nc.Value = _fil.Cells.Item("cli").Value
            _nc.Value = Dge_Clientes.GetValue("cli")
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            For i As Integer = 1 To _NroColumnasTP
                'A que producto pertenece
                _nc = New GridCell
                _nc.EditorType = GetType(GridTextBoxXEditControl)
                _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
                _nc.ReadOnly = False
                If (Dge_Clientes.RootTable.Columns.Count > 6) Then
                    Dim ss As String = ""
                    If (Dge_Clientes.CurrentRow.RowIndex = -1) Then
                        ss = Dge_Clientes.GetRow(0).Cells("codP").Value.ToString
                    Else
                        ss = Dge_Clientes.GetValue("codP").ToString
                    End If
                    If (DgdNota.PrimaryGrid.Columns(2 + i).Name.Equals(ss)) Then
                        _nc.Value = Dge_Clientes.GetValue("can")
                    Else
                        _nc.Value = 0
                    End If
                Else
                    _nc.Value = 0
                End If
                _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
                _nc.CellStyles.Default.BorderColor.All = _colorBorde
                _nf.Cells.Add(_nc)
            Next

            'Contado
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = True
            If (Dge_Clientes.RootTable.Columns.Count > 6) Then
                _nc.Value = Dge_Clientes.GetValue("tot")
            Else
                _nc.Value = 0
            End If
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Credito
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = False
            _nc.Value = 0.0
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Nota
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = False
            _nc.Value = 0
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Factura
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = False
            _nc.Value = 0
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Pedido
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = False
            If (Dge_Clientes.RootTable.Columns.Count > 6) Then
                _nc.Value = Dge_Clientes.GetValue("ped")
            Else
                _nc.Value = 0
            End If
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            'Tipo
            _nc = New GridCell
            _nc.EditorType = GetType(GridImageCombo)
            _nc.EditorParams = New Object() {ilTipoNota, ilTipoNota.Images(0).Height}
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _nc.ReadOnly = False
            _nc.Value = ilTipoNota.Images.Keys(0)
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)

            FiltroZona = Dge_Clientes.GetValue("nzon")
            LabelX16.Text = FiltroZona

            DgdNota.PrimaryGrid.Rows.Add(_nf)

            P_Recalcular()
            DgdNota.PrimaryGrid.FirstOnScreenRowIndex = DgdNota.PrimaryGrid.Rows.Count - 2

            If (BoolCliente = 2) Then
                DtClientePendiente = New DataTable
                DtClientePendiente = CType(Dge_Clientes.DataSource, DataTable)

                Dim foundRows() As Data.DataRow
                Dim ss As String = ""
                If (Dge_Clientes.CurrentRow.RowIndex = -1) Then
                    ss = Dge_Clientes.GetRow(0).Cells("ped").Value.ToString
                Else
                    ss = Dge_Clientes.GetValue("ped")
                End If
                foundRows = DtClientePendiente.Select("ped = " + ss)
                Dim ped As Integer = CInt(foundRows(0).Item("ped").ToString)
                For i As Integer = 0 To DtClientePendiente.Rows.Count - 1
                    If ((DtClientePendiente.Rows(i).Item("ped").ToString) = ped) Then
                        DtClientePendiente.Rows.RemoveAt(i)
                        Exit For
                    End If
                Next
                Dge_Clientes.DataSource = DtClientePendiente
                Dge_Clientes.RetrieveStructure()

                With Dge_Clientes.RootTable.Columns(0)
                    .Caption = "COD."
                    .Key = "cod"
                    .Width = 50
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = gi_fuenteTamano
                    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                    '.CellStyle.BackColor = Color.AliceBlue
                End With

                With Dge_Clientes.RootTable.Columns(1)
                    .Caption = "NRO DOC"
                    .Key = "nroD"
                    .Width = 70
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Far
                    .CellStyle.FontSize = gi_fuenteTamano
                    '.CellStyle.BackColor = Color.AliceBlue
                End With

                With Dge_Clientes.RootTable.Columns(2)
                    .Caption = "CLIENTE"
                    .Key = "cli"
                    .Width = 220
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = gi_fuenteTamano
                    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                End With

                With Dge_Clientes.RootTable.Columns(3)
                    .Caption = "DIRECCIÓN"
                    .Key = "dir"
                    .Width = 250
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = gi_fuenteTamano
                    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                End With

                With Dge_Clientes.RootTable.Columns(4)
                    .Caption = ""
                    .Key = "zon"
                    .Width = 0
                    .Visible = False
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = gi_fuenteTamano
                    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                End With

                With Dge_Clientes.RootTable.Columns(5)
                    .Caption = "ZONA"
                    .Key = "nzon"
                    .Width = 100
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = gi_fuenteTamano
                    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
                End With

                With Dge_Clientes.RootTable.Columns(6)
                    .Key = "codP"
                    .Visible = False
                End With

                With Dge_Clientes.RootTable.Columns(7)
                    .Key = "can"
                    .Visible = False
                End With

                With Dge_Clientes.RootTable.Columns(8)
                    .Key = "tot"
                    .Visible = False
                End With

                With Dge_Clientes.RootTable.Columns(9)
                    .Key = "ped"
                    .Visible = False
                End With

                'Habilitar Filtradores
                With Dge_Clientes
                    .GroupByBoxVisible = False
                    '.FilterRowFormatStyle.BackColor = Color.Blue
                    .DefaultFilterRowComparison = FilterConditionOperator.Contains
                    .FilterMode = FilterMode.Automatic
                    .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
                    'Diseño de la tabla
                    .VisualStyle = VisualStyle.Office2007
                    .SelectionMode = SelectionMode.SingleSelection
                    .AlternatingColors = True
                End With

                Dge_Clientes.Refresh()
            End If

            Dge_Clientes.RemoveFilters()
            Dge_Clientes.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(Dge_Clientes.RootTable.Columns("nzon"), Janus.Windows.GridEX.ConditionOperator.Equal, FiltroZona))
            Dge_Clientes.MoveTo(Dge_Clientes.FilterRow)
            Dge_Clientes.Col = 2
        End If
        If (e.KeyCode = Keys.Escape) Then
            P_GridClientesEnviarFondo()
        End If
    End Sub

    Private Sub P_InsertarFila(array() As Object)
        Dim _ultimaFila As Integer = DgdNota.PrimaryGrid.Rows.Count - 1
        Dim _colorNuevaFila As Color
        Dim _colorBorde As Color = ColorTranslator.FromHtml("#FF5722")
        If (_Bool) Then
            _colorNuevaFila = ColorTranslator.FromHtml("#FFFFFF")
            _Bool = False
        Else
            _colorNuevaFila = ColorTranslator.FromHtml("#EEEEEE")
            _Bool = True
        End If
        Dim i As Integer = 0
        Dim _nf As New GridRow
        Dim _nc As GridCell
        _nc = New GridCell

        'Orden
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = True
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Código Cliente
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = True
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Nombre del Cliente
        _nc = New GridCell
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
        _nc.ReadOnly = True
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        For ii As Integer = 1 To _NroColumnasTP
            'A que producto pertenece
            _nc = New GridCell
            _nc.EditorType = GetType(GridTextBoxXEditControl)
            _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _nc.ReadOnly = False
            _nc.Value = array(i)
            _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
            _nc.CellStyles.Default.BorderColor.All = _colorBorde
            _nf.Cells.Add(_nc)
            i += 1
        Next

        'Contado
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = True
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Credito
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = False
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Nota
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = False
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Factura
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = False
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Pedido
        _nc = New GridCell
        _nc.EditorType = GetType(GridTextBoxXEditControl)
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        _nc.ReadOnly = False
        _nc.Value = array(i)
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)
        i += 1

        'Tipo
        _nc = New GridCell
        _nc.EditorType = GetType(GridImageCombo)
        _nc.EditorParams = New Object() {ilTipoNota, ilTipoNota.Images(0).Height}
        _nc.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
        _nc.ReadOnly = False

        Select Case array(i).ToString()
            Case "NORMAL"
                _nc.Value = ilTipoNota.Images.Keys(0)
            Case "ENTREGA"
                _nc.Value = ilTipoNota.Images.Keys(1)
            Case "CORTESIA"
                _nc.Value = ilTipoNota.Images.Keys(2)
            Case "CAMBIO"
                _nc.Value = ilTipoNota.Images.Keys(3)
        End Select
        _nc.CellStyles.Default.Background.Color1 = _colorNuevaFila
        _nc.CellStyles.Default.BorderColor.All = _colorBorde
        _nf.Cells.Add(_nc)

        DgdNota.PrimaryGrid.Rows.Add(_nf)
    End Sub

    Private Sub Dge_Repartidor_KeyDown(sender As Object, e As KeyEventArgs) Handles Dge_Repartidor.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.Handled = True
            Dge_CategoriaProducto.Select()
        End If
    End Sub

    Private Sub Dge_CategoriaProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles Dge_CategoriaProducto.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.Handled = True
            Txt_NroNota.Select()
            Txt_NroNota.SelectAll()
        End If
    End Sub

    Private Sub Txt_NroNota_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_NroNota.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Dti_Fecha.Select()
        End If
    End Sub

    Private Sub Dti_Fecha_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles Dti_Fecha.PreviewKeyDown
        If (e.KeyCode = Keys.Enter And _ContadorDMA = 2) Then
            Bt1AddPendientes.Select()
            _ContadorDMA = 0
        Else
            _ContadorDMA += 1
        End If
    End Sub

    Private Sub DgdNota_CellClick(sender As Object, e As GridCellClickEventArgs) Handles DgdNota.CellClick
        P_GridClientesEnviarFondo()
    End Sub

    Private Sub Txt_Pagos_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Pagos.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Txt_Equipos.Select()
            Txt_Equipos.SelectAll()
        End If
    End Sub

    Private Sub Txt_Equipos_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Equipos.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Txt_TotalEfectivo.Select()
            Txt_TotalEfectivo.SelectAll()
        End If
    End Sub

    Private Sub Txt_TotalEfectivo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_TotalEfectivo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Txt_Tapas.Select()
            Txt_Tapas.Select()
        End If
    End Sub

    Private Sub P_LlenarDatos(_index As Integer)
        If (_index <= _MaxReg And _index >= 0 And _DsNota.Tables(0).Rows.Count > 0) Then
            DgdNota.PrimaryGrid.Rows.Clear()
            P_Resumen()
            'Limpiar textbox
            Txt_Pagos.Text = "0"
            Txt_Equipos.Text = "0"
            Txt_Contado.Text = "0"
            Txt_Credito.Text = "0"
            Txt_Tapas.Value = 0
            TbdGastos.Value = 0
            Txt_TotalEfectivo.Text = "0"
            Txt_TotalRecibido.Text = "0"
            Txt_Decuentos.Value = 0
            With _DsNota.Tables(0).Rows(_index)

                Me.Txt_NroNota.Text = .Item("odnota").ToString
                Me.Dti_Fecha.Value = .Item("odfdoc")
                Me.Txt_CodRepartidor.Text = .Item("odrepa").ToString
                Me.Txt_Repartidor.Text = .Item("cbdesc").ToString
                Me.Txt_CodTipoProducto.Text = .Item("odtprod").ToString
                Me.Txt_TipoProducto.Text = .Item("cedesc").ToString
                Me.Txt_Tapas.Text = .Item("odtap").ToString
                Me.Txt_Codigo.Text = .Item("odnumi").ToString

            End With

            P_prPonerMovimientosDia()

            P_LlenarGridEP()

            _DsNota1 = L_GetNotas1("a.oenumi = " + Txt_Codigo.Text.Trim)
            _DsNota2 = L_GetNotas2("a.ofnumi = " + Txt_Codigo.Text)

            Dim codProductos As DataRowCollection = Nothing
            If (_DsNota2.Tables(0).Rows.Count > 0) Then
                Dim nlin As Integer = 0
                Dim npro As Integer = 0
                nlin = _DsNota2.Tables(0).Select("oflin=1").Length
                npro = _DsNota2.Tables(0).DefaultView.ToTable(True, "ofcprod").Rows.Count
                codProductos = _DsNota2.Tables(0).DefaultView.ToTable(True, "ofcprod").Rows
                _NroColumnasTP = npro
                If (nlin <> npro) Then
                    Dim lin As Integer = 1
                    Dim aux As Integer = 0
                    For Each f As DataRow In _DsNota2.Tables(0).Rows
                        f.Item("oflin") = lin
                        aux += 1
                        If (npro = aux) Then
                            aux = 0
                            lin += 1
                        End If
                    Next
                End If
            End If

            Dim TotalCol As Integer = _NroColumnasTP + _DsNota1.Tables(0).Columns.Count
            Dim i2 As Integer = 1
            Dim items(TotalCol - 1) As Object
            For Each fil As DataRow In _DsNota1.Tables(0).Rows
                For i As Integer = 0 To TotalCol - 1
                    If (i < 3) Then
                        items(i) = fil.Item(i).ToString
                    ElseIf (i > 2 + _NroColumnasTP) Then
                        items(i) = fil.Item(i - _NroColumnasTP).ToString
                    Else
                        For Each fil2 As DataRow In _DsNota2.Tables(0).Rows
                            Dim cont As Integer = 0
                            For ii As Integer = 0 To codProductos.Count - 1
                                If (i2 = CInt(fil2.Item("oflin").ToString) And codProductos.Item(ii).Item("ofcprod").ToString.Equals(fil2.Item("ofcprod").ToString)) Then
                                    items(i) = fil2.Item("ofcant").ToString
                                    i += 1
                                    cont += 1
                                    Exit For
                                End If
                            Next
                            If (cont = codProductos.Count) Then
                                Exit For
                            End If
                        Next
                        i2 += 1
                        i -= 1
                    End If
                Next
                P_InsertarFila(items)
            Next
            P_Recalcular()
            Me.Txt_Decuentos.Text = _DsNota.Tables(0).Rows(_index).Item("oddes").ToString
            P_SelecionarRepartidor()
            P_SelecionarTipoProducto()
        Else
            If (_NavegadorReg < 0) Then
                _NavegadorReg = 0
            Else
                _NavegadorReg = _MaxReg
            End If
        End If
    End Sub

    Private Sub P_ActualizarPaginacion(_index As Integer)
        Txt_Paginacion.Text = "Reg. " & _index + 1 & " de " & _MaxReg + 1
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        _NavegadorReg -= 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        _NavegadorReg += 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        _NavegadorReg = _MaxReg
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_ArmarGridEquipoPago()
        'Grilla de Equipo
        If (Not Dgd3Equipo.PrimaryGrid.Columns.Count > 0) Then 'Si NO tiene columnas se creará
            Dim _col As New GridColumn
            _col.Name = "numi"
            _col.HeaderText = ""
            _col.Width = 0
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = False
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd3Equipo.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "fec"
            _col.HeaderText = ""
            _col.Width = 0
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = False
            _col.EditorType = GetType(GridDateTimeInputEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd3Equipo.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "cli"
            _col.HeaderText = "CLIENTE"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 7
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _col.ReadOnly = True
            Dgd3Equipo.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "mon"
            _col.HeaderText = "MONTO"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 2.2
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd3Equipo.PrimaryGrid.Columns.Add(_col)

            Dgd3Equipo.PrimaryGrid.ShowRowHeaders = False
            Dgd3Equipo.PrimaryGrid.ColumnHeader.RowHeight = 25
            Dgd3Equipo.PrimaryGrid.UseAlternateRowStyle = True
        End If

        'Grilla de Pagos
        If (Not Dgd4Pagos.PrimaryGrid.Columns.Count > 0) Then 'Si NO tiene columnas se creará
            Dim _col As New GridColumn
            _col.Name = "numi"
            _col.HeaderText = ""
            _col.Width = 0
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = False
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd4Pagos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "fec"
            _col.HeaderText = ""
            _col.Width = 0
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = False
            _col.EditorType = GetType(GridDateTimeInputEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd4Pagos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "cli"
            _col.HeaderText = "CLIENTE"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 7
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _col.ReadOnly = True
            Dgd4Pagos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "mon"
            _col.HeaderText = "MONTO"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 2.2
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _col.ReadOnly = True
            Dgd4Pagos.PrimaryGrid.Columns.Add(_col)

            Dgd4Pagos.PrimaryGrid.ShowRowHeaders = False
            Dgd4Pagos.PrimaryGrid.ColumnHeader.RowHeight = 25
            Dgd4Pagos.PrimaryGrid.UseAlternateRowStyle = True
        End If

        'Grilla de Gastos
        If (Not DgdGastos.PrimaryGrid.Columns.Count > 0) Then 'Si NO tiene columnas se creará
            Dim _col As New GridColumn
            _col.Name = "numi"
            _col.Visible = False
            DgdGastos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "pro"
            _col.Visible = False
            DgdGastos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "fec"
            _col.Visible = False
            DgdGastos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "obs"
            _col.HeaderText = "OBSERVACIÓN"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 7
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _col.ReadOnly = True
            DgdGastos.PrimaryGrid.Columns.Add(_col)

            _col = New GridColumn
            _col.Name = "mon"
            _col.HeaderText = "MONTO"
            _col.Width = (Stc_EquipoPagos.Width / 10) * 2.2
            _col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            _col.Visible = True
            _col.EditorType = GetType(GridTextBoxXEditControl)
            _col.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _col.ReadOnly = True
            DgdGastos.PrimaryGrid.Columns.Add(_col)

            DgdGastos.PrimaryGrid.ShowRowHeaders = False
            DgdGastos.PrimaryGrid.ColumnHeader.RowHeight = 25
            DgdGastos.PrimaryGrid.UseAlternateRowStyle = True
        End If
    End Sub

    Private Sub P_LlenarGridEquipo(numi As String)
        Dgd3Equipo.PrimaryGrid.Rows.Clear()
        DtEquipo = New DataTable
        DtEquipo = L_GetNotasEquipos(numi)
        Dgd3Equipo.PrimaryGrid.DataSource = DtEquipo
    End Sub

    Private Sub P_LlenarGridPagos(numi As String)
        Dgd4Pagos.PrimaryGrid.Rows.Clear()
        DtPagos = New DataTable()
        DtPagos = L_GetNotasPagos(numi, Txt_CodTipoProducto.Text)
        Dgd4Pagos.PrimaryGrid.DataSource = DtPagos
    End Sub

    Private Sub P_LlenarGridGastos(numi As String)
        DgdGastos.PrimaryGrid.Rows.Clear()
        DtGastos = New DataTable()
        DtGastos = L_GetNotasGastos(numi, Txt_CodTipoProducto.Text)
        DgdGastos.PrimaryGrid.DataSource = DtGastos
    End Sub

    Private Function P_GetCodClientes() As List(Of Integer)
        Dim _cod As New List(Of Integer)
        Dim _vc As String = ""
        For Each _fs As GridRow In DgdNota.PrimaryGrid.Rows
            If (Not _fs.Item("codC").Value.ToString.Equals("")) Then
                If (Not _vc.Contains(_fs.Item("codC").Value.ToString)) Then
                    _cod.Add(_fs.Item("codC").Value)
                    _vc = _vc + _fs.Item("codC").Value.ToString & ","
                End If
            End If
        Next
        Return _cod
    End Function

    Private Sub P_ResumenEquipoPago()
        Txt_Equipos.Text = "0"
        Txt_Pagos.Text = "0"
        TbdGastos.Value = 0
        If (DtEquipo.Rows.Count > 0) Then
            Txt_Equipos.Text = DtEquipo.Compute("Sum(mon)", "1=1")
        End If
        If (DtPagos.Rows.Count > 0) Then
            Txt_Pagos.Text = DtPagos.Compute("Sum(mon)", "1=1")
        End If
        If (DtGastos.Rows.Count > 0) Then
            TbdGastos.Value = DtGastos.Compute("Sum(mon)", "1=1")
        End If
    End Sub

    Private Sub P_Totales()
        If (Txt_Credito.Text.Trim.Length > 0) Then
            Txt_TotalEfectivo.Text = CDbl(Txt_Pagos.Text) + CDbl(Txt_Equipos.Text) + CDbl(Txt_Contado.Text) - TbdGastos.Value '- CDbl(Txt_Credito.Text)
            Txt_TotalRecibido.Text = Txt_TotalEfectivo.Text
        End If
    End Sub

    Private Sub Txt_Credito_TextChanged(sender As Object, e As EventArgs) Handles Txt_Credito.TextChanged
        P_Totales()
    End Sub

    Private Sub Btnx_InsClientes_Click(sender As Object, e As EventArgs) Handles Bt2InsClientes.Click
        LabelX16.Text = ""
        P_CargarGridCliente(Dge_Clientes, 1)
        BoolCliente = 1
    End Sub

    Private Sub Bt1AddPendientes_Click(sender As Object, e As EventArgs) Handles Bt1AddPendientes.Click
        LabelX16.Text = ""
        P_CargarGridCliente(Dge_Clientes, 2)
        BoolCliente = 2
    End Sub

    Private Function P_ValidarNota() As Boolean
        If (Txt_NroNota.Text.Trim.Length = 0) Then
            ToastNotification.Show(Me, "El Nro. de nota NO puedo quedar vacio",
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.TopCenter)
            Return False
            Exit Function
        End If
        If (Txt_CodRepartidor.Text.Trim.Length = 0) Then
            ToastNotification.Show(Me, "Debe elejir un Repartidor",
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.TopCenter)
            Return False
            Exit Function
        End If
        If (Txt_NroNota.Text.Trim.Length = 0) Then
            ToastNotification.Show(Me, "Debe elejir un Tipo de Producto",
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.TopCenter)
            Return False
            Exit Function
        End If

        If (Not L_ValidarNroNota(Txt_NroNota.Text, Txt_CodTipoProducto.Text) And Not _Modificar) Then
            ToastNotification.Show(Me, "El nro de nota " + Txt_NroNota.Text + ", ya esta regsitrado para el tipo de producto " + Txt_TipoProducto.Text,
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.TopCenter)
            MessageBox.Show("El nro de nota " + Txt_NroNota.Text + ", " + ChrW(13) + " ya esta registrado para el tipo de producto " + Txt_TipoProducto.Text, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
            Exit Function
        End If

        Dim sms As String = ""
        For Each fil As GridRow In DgdNota.PrimaryGrid.Rows
            If (fil.Cells("tip").Value.ToString.Equals("ENTREGA") And fil.Cells("cre").Value = 0) Then
                sms = sms + "en la fila " + (fil.RowIndex + 1).ToString + " el crédito no puede quedar en cero porque es de tipo ''entrega''" + vbCrLf
            End If
        Next

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me, sms.ToUpper,
                                   My.Resources.INFORMATION,
                                   _DuracionSms * 1200,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            Return False
        End If

        Return True
    End Function

    Private Sub Txt_Contado_TextChanged(sender As Object, e As EventArgs) Handles Txt_Contado.TextChanged
        P_Totales()
    End Sub

    Private Sub P_LlenarGridEP()
        If (Txt_CodTipoProducto.Text = "1") Then
            P_LlenarGridEquipo(Txt_NroNota.Text)
        Else
            P_LlenarGridEquipo(-1)
        End If
        P_LlenarGridPagos(Txt_NroNota.Text)
        P_LlenarGridGastos(Txt_NroNota.Text)
        P_ResumenEquipoPago()
    End Sub

    Private Sub Tsm1Quitar_Click(sender As Object, e As EventArgs) Handles Tsm1Quitar.Click
        If (DgdNota.PrimaryGrid.GetSelectedCells Is Nothing) Then
            Exit Sub
        End If
        If (_Nuevo Or _Modificar) Then
            If (_Modificar) Then
                Dim cel As GridCell = CType(DgdNota.PrimaryGrid.GetCell(DgdNota.PrimaryGrid.ActiveCell.RowIndex, DgdNota.PrimaryGrid.Columns("ped").ColumnIndex), GridCell)
                If (Not cel.Value.ToString.Trim.Equals("0")) Then
                    L_ActualizarEstadoPedido("oaest = 2", "oanumi = " + cel.Value.ToString)
                    L_PedidoEstados_Grabar(cel.Value.ToString.Trim, "2", Now.Date.ToString("yyyy/MM/dd"), TimeOfDay.ToShortTimeString, Txt_NombreUsu.Text)
                End If
            End If

            DgdNota.PrimaryGrid.Rows.RemoveAt(DgdNota.PrimaryGrid.ActiveCell.RowIndex)

            Dim i As Integer = 1
            For Each f As GridRow In DgdNota.PrimaryGrid.Rows
                f.Cells("ord").Value = i
                i += 1
            Next
            P_Recalcular()
        ElseIf (_Modificar) Then
            ToastNotification.Show(Me, "No esta permitido Borrar un registro Cuando se esta Modificando",
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub Tsm1Ocultar_Click(sender As Object, e As EventArgs) Handles Tsm1Ocultar.Click
        P_GridClientesEnviarFondo()
    End Sub

    Private Sub P_GridClientesEnviarFondo()
        Dge_Repartidor.BringToFront()
        GroupPanel1.Text = "repartidor".ToUpper
        LabelX16.Text = ""
    End Sub

    Private Sub P_Recalcular()
        If (DgdNota.PrimaryGrid.Rows.Count > 0) Then
            For i As Integer = 3 To _NroColumnasTP + 2
                P_SumarColumnaContadoCredito(DgdNota.PrimaryGrid.Columns(i).Name)
            Next
        End If
    End Sub

    Private Sub P_RecalcularTodo()
        If (DgdNota.PrimaryGrid.Rows.Count > 0) Then

            Dim tip As GridCell
            Dim con As GridCell
            Dim cre As GridCell
            Dim conT As Double
            Dim creT As Double
            For Each fil As GridRow In DgdNota.PrimaryGrid.Rows
                tip = fil.GetCell("tip")
                con = fil.GetCell("con")
                cre = fil.GetCell("cre")
                conT = con.Value
                creT = cre.Value

                If (tip.Value.ToString.Equals("NORMAL")) Then
                    conT = P_PonerPrecio(fil.RowIndex)
                    If (con.Value = 0) Then
                        cre.Value = conT
                    ElseIf (cre.Value = 0) Then
                        con.Value = conT
                    Else
                        con.Value = conT - creT
                    End If
                ElseIf (tip.Value.ToString.Equals("ENTREGA")) Then
                    con.Value = 0
                ElseIf (tip.Value.ToString.Equals("CORTESIA") Or tip.Value.ToString.Equals("CAMBIO")) Then
                    con.Value = 0
                    cre.Value = 0
                End If
            Next

            For i As Integer = 3 To _NroColumnasTP + 2
                P_SumarColumnaContadoCredito(DgdNota.PrimaryGrid.Columns(i).Name)
            Next
        End If
    End Sub

    Private Sub P_VisibleEP(bool As Boolean)
        Stc_EquipoPagos.Visible = bool
    End Sub

    Private Sub P_ArmaGrillaAyuda()
        Dim _DsNotasAyuda As New DataSet
        _DsNotasAyuda = L_GetNotasAyuda()

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = _DsNotasAyuda.Tables(0)
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "odnumi"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = "Nro. Nota"
            .Key = "odnota"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "Fecha"
            .Key = "odfdoc"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "Cod Tipo Producto"
            .Key = "odtprod"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = "Tipo Producto"
            .Key = "cedesc"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(5)
            .Caption = "Cod Repartidor"
            .Key = "odrepa"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(6)
            .Caption = "Repartidor"
            .Key = "cbdesc"
            .Width = 350
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(7)
            .Caption = "Usuario"
            .Key = "oduact"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With Dgj1Busqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007

        End With
        'Dgj1Busqueda.Dock = DockStyle.Fill
        Dgj1Busqueda.BringToFront()
    End Sub

    Private Sub Txt_Codigo_TextChanged(sender As Object, e As EventArgs) Handles Txt_Codigo.TextChanged
        If (Txt_CodTipoProducto.Text.Length > 0) Then
            P_LlenarDgsNota("0", Txt_CodTipoProducto.Text)
        End If
    End Sub

    Private Sub Txt_TotalRecibido_TextChanged(sender As Object, e As EventArgs) Handles Txt_TotalRecibido.TextChanged
        If (Txt_TotalRecibido.Text.Length > 0 And Txt_TotalRecibido.Visible) Then
            If (CDbl(Txt_TotalRecibido.Text) > 0) Then
                Txt_Decuentos.Text = CDbl(Txt_TotalEfectivo.Text) - CDbl(Txt_TotalRecibido.Text)
            Else
                Txt_TotalRecibido.Text = Txt_TotalEfectivo.Text
                Txt_Decuentos.Text = "0"
            End If
        End If
    End Sub

    Private Sub Txt_TotalRecibido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_TotalRecibido.KeyPress
        G_ValidarTextBox(3, e)
    End Sub

    Private Sub Txt_NroNota_Leave(sender As Object, e As EventArgs) Handles Txt_NroNota.Leave
        If (Txt_NroNota.Text.Length > 0) Then
            'Validar que si hay equipo en clientes las fechas sean las misma
            If (Txt_CodTipoProducto.Text = "1") Then
                Dim dt As DataTable = L_GetTabla("TC0041",
                                                         "chnumi, chfec, chnota, chlin",
                                                         "chnota=" + Txt_NroNota.Text.Trim)
                If (dt.Rows.Count > 0) Then
                    Dim dtCopy As DataTable
                    dtCopy = dt.Clone()
                    For Each fil As DataRow In dt.Rows
                        If (fil.Item("chfec") <> Dti_Fecha.Value) Then
                            dtCopy.ImportRow(fil)
                        End If
                    Next

                    If (dtCopy.Rows.Count > 0) Then
                        Dim info As New TaskDialogInfo("Información Importante".ToUpper,
                                                       eTaskDialogIcon.Information2, "Leer con atención".ToUpper,
                                                       "algunos equipos que estan registrados con el nro de nota ".ToUpper + Txt_NroNota.Text _
                                                       + vbCrLf + "están con fechas diferentes a la fecha de la nota".ToUpper _
                                                       + vbCrLf + "tome su debida precaución!".ToUpper,
                                                       eTaskDialogButton.Ok,
                                                       eTaskDialogBackgroundColor.Orange)
                        Dim result As eTaskDialogResult = TaskDialog.Show(info)
                        'If (result = eTaskDialogResult.Yes) Then
                        '    For Each fil As DataRow In dtCopy.Rows
                        '        L_GrabarModificarClienteEquipo("chfec='" + Dti_Fecha.Value.ToString("yyyy/MM/dd") + "'",
                        '                                       "chnumi=" + fil.Item("chnumi").ToString + " and chlin=" + fil.Item("chlin").ToString)
                        '    Next
                        'End If
                    End If
                End If
            End If

            If (Not L_ValidarNroNota(Txt_NroNota.Text, Txt_CodTipoProducto.Text) And _Nuevo) Then
                ToastNotification.Show(Me, "El nro de nota " + Txt_NroNota.Text + vbCrLf + "ya esta registrado para el tipo de producto " + Txt_TipoProducto.Text,
                           My.Resources.INFORMATION,
                           _DuracionSms * 1000,
                           eToastGlowColor.Blue,
                           eToastPosition.TopCenter)

                Dim info As New TaskDialogInfo("Información Importante".ToUpper,
                                               eTaskDialogIcon.Information2, "AVISO".ToUpper,
                                               "El nro de nota ".ToUpper + Txt_NroNota.Text _
                                               + vbCrLf + "ya esta registrado para el tipo de producto ".ToUpper + Txt_TipoProducto.Text _
                                               + vbCrLf + "Desea continuar?".ToUpper,
                                               eTaskDialogButton.Yes Or eTaskDialogButton.No,
                                               eTaskDialogBackgroundColor.Blue)
                Dim result As eTaskDialogResult = TaskDialog.Show(info)
                If (Not result = eTaskDialogResult.Yes) Then
                    Txt_NroNota.Select()
                End If
            Else
                P_LlenarGridEP()
            End If
        End If
    End Sub

    Private Function P_PonerPrecio(index As Integer) As Double
        Dim acu As Double = 0
        Dim flat As Boolean = True
        For i As Integer = 3 To _NroColumnasTP + 3 - 1
            Dim precio As Double = 0

            'Si es oficina, el precio lo toma de la categoria fija cinumi=0
            If (CInt(Txt_CodRepartidor.Text) = inCodRepPrecioFijo) Then
                Dim precioCat As Double = L_GetPrecioCategoriaCliente(DgdNota.PrimaryGrid.GetCell(index, 1).Value,
                                                                      DgdNota.PrimaryGrid.Columns(i).Name, flat)
                Dim precioOfi As Double = L_GetPrecioCategoriaOficina(DgdNota.PrimaryGrid.Columns(i).Name, flat)
                If (precioCat < precioOfi) Then
                    precio = precioCat
                Else
                    precio = precioOfi
                End If
            Else
                precio = L_GetPrecioCategoriaCliente(DgdNota.PrimaryGrid.GetCell(index, 1).Value,
                                                     DgdNota.PrimaryGrid.Columns(i).Name, flat)
            End If

            Dim cant As Double = DgdNota.PrimaryGrid.GetCell(index, i).Value
            acu = acu + (precio * cant)
            If (Not flat) Then
                ToastNotification.Show(Me, "El producto ''".ToUpper + DgdNota.PrimaryGrid.Columns(i).HeaderText _
                                       + "'' no tiene configurado su precio, el precio por defecto es 0.".ToUpper,
                                       My.Resources.INFORMATION,
                                       _DuracionSms * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
            End If
            flat = True
        Next
        Return acu
    End Function

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dgj1Busqueda_DoubleClick(sender As Object, e As EventArgs) Handles Dgj1Busqueda.DoubleClick
        If (Dgj1Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerIndiceBusqueda()
            SuperTabControl1.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub Dgj1Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgj1Busqueda.KeyDown
        If (e.KeyData = Keys.Enter And Dgj1Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerIndiceBusqueda()
            SuperTabControl1.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub P_PonerIndiceBusqueda()
        Dim foundRows() As Data.DataRow
        foundRows = _DsNota.Tables(0).Select("odnumi = " + Dgj1Busqueda.GetValue("odnumi").ToString)
        _NavegadorReg = CInt(foundRows(0).Item("fil").ToString) - 1
    End Sub

    Private Sub Bt6Recalcular_Click(sender As Object, e As EventArgs) Handles Bt6Recalcular.Click
        P_RecalcularTodo()
        ToastNotification.Show(Me, "ACTUALIZACIÓN DE NOTA EXITOSA!!!".ToUpper,
                       My.Resources.OK,
                       _DuracionSms * 200,
                       eToastGlowColor.Green,
                       eToastPosition.MiddleCenter)
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If (SuperTabControl1.SelectedTabIndex = 1) Then
            Dgj1Busqueda.BringToFront()
            Dgj1Busqueda.RemoveFilters()
            Dgj1Busqueda.Focus()
            Dgj1Busqueda.MoveTo(Dgj1Busqueda.FilterRow)
            Dgj1Busqueda.Col = 1
        End If
        If (SuperTabControl1.SelectedTabIndex = 0 And Not _DsNota Is Nothing) Then
            P_LlenarDatos(_NavegadorReg)
        End If
    End Sub

    Private Sub P_SelecionarRepartidor()
        For Each fil As GridEXRow In Dge_Repartidor.GetRows
            Dim _estiloFila As New GridEXFormatStyle()
            If (fil.Cells("CodRepartidor").Value.ToString.Equals(Txt_CodRepartidor.Text)) Then
                _estiloFila.BackColor = Color.LightGreen
                fil.RowStyle = _estiloFila
                If (_Nuevo Or _Modificar) Then
                    Txt_CodRepartidor.Text = fil.Cells("CodRepartidor").Value.ToString
                    Txt_Repartidor.Text = fil.Cells("Repartidor").Value.ToString
                End If
            Else
                fil.RowStyle = _estiloFila
            End If
        Next
    End Sub

    Private Sub P_SelecionarTipoProducto()
        For Each fil As GridEXRow In Dge_CategoriaProducto.GetRows
            Dim _estiloFila As New GridEXFormatStyle()
            If (fil.Cells("cod").Value.ToString.Equals(Txt_CodTipoProducto.Text)) Then
                _estiloFila.BackColor = Color.LightGreen
                fil.RowStyle = _estiloFila
                If (_Nuevo Or _Modificar) Then
                    Txt_CodTipoProducto.Text = fil.Cells("cod").Value.ToString
                    Txt_TipoProducto.Text = fil.Cells("tipP").Value.ToString
                End If
            Else
                fil.RowStyle = _estiloFila
            End If
        Next
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And Bt4Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TO002", "od", "odnumi=" + Txt_Codigo.Text)
            If IsDBNull(dtAud.Rows(0).Item(0)) = True Then
                lbFecha.Text = ""
            Else
                lbFecha.Text = Convert.ToDateTime(dtAud.Rows(0).Item(0)).ToString("dd/MM/yyyy")
            End If
            lbHora.Text = dtAud.Rows(0).Item(1).ToString
            lbUsuario.Text = dtAud.Rows(0).Item(2).ToString
            FlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            FlyoutUsuario.Content = PanelUsuario
        End If

    End Sub

    Private Sub BBtn_Usuario_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Usuario.Click
        FlyoutUsuario_PrepareContent(BubbleBar5, e)
    End Sub

    Private Sub Dge_Clientes_ClearFilterButtonClick(sender As Object, e As ColumnActionEventArgs) Handles Dge_Clientes.ClearFilterButtonClick
        If (e.Column.Index = 5) Then
            LabelX16.Text = ""
        End If
    End Sub

    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click
        P_ArmaGrillaAyuda()
        P_LlenarDatos(_NavegadorReg)
        Dim info As New TaskDialogInfo("sincronización de notas.".ToUpper, eTaskDialogIcon.Information, "información".ToUpper, "notas sincronizada correctamente.".ToUpper, eTaskDialogButton.Ok, eTaskDialogBackgroundColor.Blue)
    End Sub

    Private Sub Dti_Fecha_Leave(sender As Object, e As EventArgs) Handles Dti_Fecha.Leave
        If (Dti_Fecha.Value > Now.Date) Then
            ToastNotification.Show(Me, "La fecha de la nota tiene que ser menor o igual a la fecha actual.".ToUpper,
                                   My.Resources.WARNING, _DuracionSms * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            Dti_Fecha.Select()
        End If

        'Validar que si hay equipo en clientes las fechas sean las misma
        If (Txt_CodTipoProducto.Text = "1") Then
            Dim dt As DataTable = L_GetTabla("TC0041",
                                                     "chnumi, chfec, chnota, chlin",
                                                     "chnota=" + IIf(Txt_NroNota.Text.Trim = String.Empty, "-1", Txt_NroNota.Text.Trim))
            If (dt.Rows.Count > 0) Then
                Dim dtCopy As DataTable
                dtCopy = dt.Clone()
                For Each fil As DataRow In dt.Rows
                    If (fil.Item("chfec") <> Dti_Fecha.Value) Then
                        dtCopy.ImportRow(fil)
                    End If
                Next

                If (dtCopy.Rows.Count > 0) Then
                    Dim info As New TaskDialogInfo("Información Importante".ToUpper,
                                                   eTaskDialogIcon.Information2, "Leer con atención".ToUpper,
                                                   "algunos equipos que estan registrados con el nro de nota ".ToUpper + Txt_NroNota.Text _
                                                   + vbCrLf + "están con fechas diferentes a la fecha de la nota".ToUpper _
                                                   + vbCrLf + "tome su debida precaución!".ToUpper,
                                                   eTaskDialogButton.Ok,
                                                   eTaskDialogBackgroundColor.Orange)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    'If (result = eTaskDialogResult.Yes) Then
                    '    For Each fil As DataRow In dtCopy.Rows
                    '        L_GrabarModificarClienteEquipo("chfec='" + Dti_Fecha.Value.ToString("yyyy/MM/dd") + "'",
                    '                                       "chnumi=" + fil.Item("chnumi").ToString + " and chlin=" + fil.Item("chlin").ToString)
                    '    Next
                    'End If
                End If
            End If
        End If
    End Sub

    Private Sub P_prPonerCantidadProductoCero(rowIndex As Integer)
        Dim celProducto As GridCell
        For i As Integer = 3 To 2 + _NroColumnasTP
            celProducto = CType(DgdNota.PrimaryGrid.GetCell(rowIndex, i), GridCell)
            celProducto.Value = 0
        Next
    End Sub

    Private Sub Txt_NroNota_TextChanged(sender As Object, e As EventArgs) Handles Txt_NroNota.TextChanged
        If (Bt4Grabar.Enabled = True) Then
            P_prPonerMovimientosDia()
        End If
    End Sub
End Class



#Region "GridImageCombo"

Public Class GridImageCombo
    Inherits GridComboBoxExEditControl
    Private _ImageList As ImageList

    Public Sub New(ByVal imageList As ImageList, ByVal itemHeight As Integer)
        _ImageList = imageList

        DisableInternalDrawing = True
        DropDownStyle = ComboBoxStyle.DropDownList
        ItemHeight = itemHeight

        For i As Integer = 0 To imageList.Images.Count - 1
            Items.Add(imageList.Images.Keys(i))
        Next i

        AddHandler DrawItem, AddressOf GridImageComboDrawItem
    End Sub

#Region "CellRender"

    Public Overrides Sub CellRender(ByVal g As Graphics)
        Dim r As Rectangle = EditorCell.Bounds
        r.X += 4
        r.Width -= 4

        RenderItem(g, r, Text)
    End Sub

#End Region

#Region "GridImageComboDrawItem"

    Private Sub GridImageComboDrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        If e.Index >= 0 Then
            e.DrawBackground()

            RenderItem(e.Graphics, e.Bounds, _ImageList.Images.Keys(e.Index))
        End If
    End Sub

#End Region

#Region "RenderItem"

    Private Sub RenderItem(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal key As String)
        Dim image As Image = _ImageList.Images(key)

        If image IsNot Nothing Then
            Dim r As Rectangle = bounds
            r.Size = image.Size
            r.X += 2
            r.Y += (bounds.Height - r.Height) \ 2

            g.DrawImageUnscaled(image, r)

            r = bounds
            r.X += image.Width + 2
            r.Width -= image.Width + 2

            Using sf As New StringFormat()
                sf.LineAlignment = StringAlignment.Center

                g.DrawString(key, Font, Brushes.Black, r, sf)
            End Using
        End If
    End Sub

#End Region

End Class

#End Region
