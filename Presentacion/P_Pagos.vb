Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.SuperGrid
Imports Janus.Data
Imports Janus.Windows.GridEX

Public Class P_Pagos

#Region "Variables Globales"

    Dim _Nuevo As Boolean
    Dim _Mofificar As Boolean
    Dim _Eliminar As Boolean

    Dim _Grabar As Integer '1,2 Nuevo; 3,4 Modificar; 5,6 Eliminar

    Dim G_Usuario As String = P_Global.gs_usuario

    Dim _DuracionSms As Integer = 5
    Dim _Cont As Integer = 0

    Dim _DsPagos As DataSet
    Dim _DsCliente As DataSet

    Dim _MaxReg As Integer
    Dim _NavegadorReg As Integer

#End Region

#Region "Eventos"
    Private Sub P_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Nuevo.Click
        P_NuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Modificar.Click
        P_ModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Eliminar.Click
        P_EliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Grabar.Click
        P_GrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Cancelar.Click
        P_CancelarRegistro()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Inicio.Click
        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Anterior.Click
        _NavegadorReg -= 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Siguiente.Click
        _NavegadorReg += 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Ultimo.Click
        _NavegadorReg = _MaxReg
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub Txt_CodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CodCliente.KeyPress
        G_ValidarTextBox(1, e)
    End Sub
    Private Sub Txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Codigo.KeyPress
        G_ValidarTextBox(1, e)
    End Sub

    Private Sub Txt_NroNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NroNota.KeyPress
        G_ValidarTextBox(1, e)
    End Sub

    Private Sub Txt_Monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Monto.KeyPress
        G_ValidarTextBox(3, e)
    End Sub

    Private Sub Txt_NombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs)
        G_ValidarTextBox(1, e)
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabControl1.SelectedTab = SuperTabItem1
        SuperTabItem2.Visible = False

        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False

        P_HabilitarComponentes(False)

        P_ArmarGrilla()
        P_ArmarGrillaClientes()
        P_ArmarCombo()

        P_ActualizarPuterosNavegacion()

        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)

        BBtn_Grabar.Enabled = False
        Txt_NroNota.Select()

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
        Dim dtRolUsu As DataTable = L_RolDetalle_General2(-1, idRolUsu, "ycyanumi=28")
        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            BBtn_Nuevo.Visible = False
        End If
        If modif = False Then
            BBtn_Modificar.Visible = False
        End If
        If del = False Then
            BBtn_Eliminar.Visible = False
        End If

    End Sub

    Private Sub P_NuevoRegistro()
        P_Limpiar()
        _Nuevo = True
        _Mofificar = False
        _Eliminar = False
        'Txt_Codigo.Text = L_GetLastIdTablas("TO003", "ognumi") + 1
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_HabilitarComponentes(_Nuevo)
        Txt_NroNota.Select()
        _Grabar = 1

        Rl1Accion.Text = "NUEVO"
    End Sub

    Private Sub P_ModificarRegistro()
        _Nuevo = False
        _Mofificar = True
        _Eliminar = False
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_HabilitarComponentes(_Mofificar)
        Txt_NroNota.SelectAll()
        _Grabar = 3

        Rl1Accion.Text = "MODIFICAR"
    End Sub

    Private Sub P_EliminarRegistro()
        'P_Limpiar()
        _Nuevo = False
        _Mofificar = False
        _Eliminar = True
        BBtn_Grabar.TooltipText = "GRABAR ELIMINACIÓN DE REGISTRO"
        P_HabilitarComponentes(False)
        ToastNotification.Show(Me, "ELIJA EL REGISTRO A ELIMINAR...!!!", My.Resources.INFORMATION, _DuracionSms * 1000, eToastGlowColor.Blue, eToastPosition.BottomRight)
        _Grabar = 5

        Rl1Accion.Text = "ELIMINAR"
    End Sub

    Private Sub P_GrabarRegistro()
        Dim ognumi As String
        Dim ogrec As String
        Dim ogfdoc As String
        Dim ogcli As String
        Dim ogmon As String
        Dim ognota As String
        Dim ogtprod As String
        Dim ogfact As String = Date.Now.Date.ToString("yyyy/MM/dd")
        Dim oghact As String = TimeOfDay.Hour.ToString("00") + ":" + TimeOfDay.Minute.ToString("00")
        Dim oguact As String = G_Usuario

        If (_Nuevo) Then
            If (_Grabar = 2) Then
                If (P_Validar()) Then
                    ognumi = L_GetLastIdTablas("TO003", "ognumi") + 1
                    ognota = Txt_NroNota.Text.Trim
                    ogcli = Txt_CodCliente.Text.Trim
                    ogmon = Txt_Monto.Text.Trim
                    ogfdoc = Dti_Fecha.Value.Date.ToString("yyyy/MM/dd")
                    ogrec = Txt_NroDoc.Text.Trim
                    ogtprod = Cb1TipoProducto.Value.ToString

                    L_GrabarNuevoPago(
                                       "" + ognumi + ", " _
                                     + "" + ogrec + ", " _
                                     + "'" + ogfdoc + "', " _
                                     + "" + ogcli + ", " _
                                     + "" + ogmon + ", " _
                                     + "" + ognota + ", " _
                                     + "" + ogtprod + ", " _
                                     + "'" + ogfact + "', " _
                                     + "'" + oghact + "', " _
                                     + "'" + oguact + "'"
                                     )

                    P_Actsaldo(False)

                    P_Limpiar()
                    Txt_Codigo.Text = L_GetLastIdTablas("TO003", "ognumi") + 1
                    Txt_NroNota.Select()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA GUARDADO EXITOSAMENTE..!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)

                    P_ArmarGrilla()
                    'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
                    BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                Else
                    'Hl_Pagos.SetHighlightColor(Txt_NroNota, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                    'ToastNotification.Show(Me, "FALTAN DATOS..!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                End If
                _Grabar = 1
            Else
                'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Green)
                BBtn_Grabar.TooltipText = "CONFIRMAR GRABADO DE REGISTRO"
                _Grabar = 2
            End If
        ElseIf (_Mofificar) Then
            If (_Grabar = 4) Then
                If (P_Validar()) Then

                    P_Actsaldo(True)

                    ognumi = Txt_Codigo.Text.Trim
                    ognota = Txt_NroNota.Text.Trim
                    ogcli = Txt_CodCliente.Text.Trim
                    ogmon = Txt_Monto.Text.Trim
                    ogfdoc = Dti_Fecha.Value.Date.ToString("yyyy/MM/dd")
                    ogrec = Txt_NroDoc.Text.Trim
                    ogtprod = Cb1TipoProducto.Value.ToString

                    L_GrabarModificarPago(
                                       "ognota = " + ognota + ", " _
                                     + "ogcli = " + ogcli + ", " _
                                     + "ogmon = " + ogmon + ", " _
                                     + "ogfdoc = '" + ogfdoc + "', " _
                                     + "ogrec = " + ogrec + ", " _
                                     + "ogtprod = " + ogtprod + ", " _
                                     + "ogfact = '" + ogfact + "', " _
                                     + "oghact = '" + oghact + "', " _
                                     + "oguact = '" + oguact + "' ",
                                     "ognumi = " + ognumi
                                     )

                    P_Actsaldo(False)

                    Txt_NroNota.Select()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA MODIFICADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)

                    P_ArmarGrilla()
                    'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

                    BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                Else
                    'Hl_Pagos.SetHighlightColor(Txt_NroNota, DevComponents.DotNetBar.Validator.eHighlightColor.Red)

                    'ToastNotification.Show(Me, "DEBE ELEGIR UN REGISTRO...!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                End If
                _Grabar = 3
            Else
                'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
                BBtn_Grabar.TooltipText = "CONFIRMAR MODIFICACIÓN DE REGISTRO"
                _Grabar = 4
            End If

        ElseIf (_Eliminar) Then
            If (_Grabar = 6) Then
                If (P_Validar()) Then

                    P_Actsaldo(True)

                    ognumi = Txt_Codigo.Text.Trim

                    L_GrabarEliminarPago("ognumi = " + ognumi)

                    P_Limpiar()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA ELIMINADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomRight)

                    P_ArmarGrilla()
                    'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
                    P_ActualizarPuterosNavegacion()
                    P_LlenarDatos(_NavegadorReg)
                Else
                    ToastNotification.Show(Me, "DEBE ELEGIR UN REGISTRO...!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                End If
                _Grabar = 5
            Else
                'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                BBtn_Grabar.TooltipText = "CONFIRMAR ELIMINACIÓN DE REGISTRO"
                _Grabar = 6
            End If

        End If
        P_ActualizarPuterosNavegacion()
    End Sub

    Private Sub P_CancelarRegistro()
        P_Limpiar()
        P_HabilitarComponentes(False)
        P_LlenarDatos(_NavegadorReg)

        Rl1Accion.Text = ""
    End Sub

    Public Overrides Function P_Validar() As Boolean
        If (Not IsNumeric(Txt_NroNota.Text)) Then
            ToastNotification.Show(Me, "El Nro de Nota no puede estar vacio".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        If (Txt_NroDoc.Text.Trim.Equals("")) Then
            ToastNotification.Show(Me, "El Nro de Documento no puede estar vacio".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        If (Not IsNumeric(Txt_CodCliente.Text)) Then
            ToastNotification.Show(Me, "El Código de Cliente no puede estar vacio".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        If (Txt_NombreCliente.Text.Trim.Equals("")) Then
            ToastNotification.Show(Me, "El Nombre del Cliente no puede estar vacio".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        If (Not IsNumeric(Txt_Monto.Text)) Then
            ToastNotification.Show(Me, "El Monto tiene que ser Número".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        If (Not IsNumeric(Cb1TipoProducto.Value)) Then
            ToastNotification.Show(Me, "El Tipo de Producto no puede estar vacio, Elija uno".ToUpper,
                       My.Resources.WARNING,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.BottomLeft)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub P_Actsaldo(bool As Boolean)
        Dim _Tabla As New DataTable
        _Tabla.Columns.Add("codC")
        _Tabla.Columns.Add("mon")
        _Tabla.Columns.Add("sto")
        If (bool) Then
            _Tabla.Rows.Add(Txt_CodCliente.Text, L_GetPagos(" ogcli = " + Txt_CodCliente.Text + " and ognumi = " + Txt_Codigo.Text).Tables(0).Rows(0).Item("ogmon").ToString, "0")
        Else
            _Tabla.Rows.Add(Txt_CodCliente.Text, Txt_Monto.Text, "0")
        End If
        G_ActStock(_Tabla, bool)
    End Sub

    Private Sub P_LlenarDatos(_index As Integer)
        If (_index <= _MaxReg And _index >= 0) Then
            Me.Txt_Codigo.Text = _DsPagos.Tables(0).Rows(_index).Item("ognumi").ToString
            Me.Txt_NroNota.Text = _DsPagos.Tables(0).Rows(_index).Item("ognota").ToString
            Me.Txt_CodCliente.Text = _DsPagos.Tables(0).Rows(_index).Item("ogcli").ToString
            Me.Txt_NombreCliente.Text = _DsPagos.Tables(0).Rows(_index).Item("nombre").ToString
            Me.Txt_Monto.Text = _DsPagos.Tables(0).Rows(_index).Item("ogmon").ToString
            Me.Dti_Fecha.Text = _DsPagos.Tables(0).Rows(_index).Item("ogfdoc").ToString
            Me.Txt_NroDoc.Text = _DsPagos.Tables(0).Rows(_index).Item("ogrec").ToString
            Me.Lbl_Saldo.Text = _DsPagos.Tables(0).Rows(_index).Item("saldo").ToString
            If (IsDBNull(_DsPagos.Tables(0).Rows(_index).Item("ogtprod"))) Then
                Me.Cb1TipoProducto.Text = ""
            Else
                Me.Cb1TipoProducto.SelectedIndex = CInt(_DsPagos.Tables(0).Rows(_index).Item("ogtprod").ToString) - 1
            End If
        Else
            If (_NavegadorReg < 0) Then
                _NavegadorReg = 0
            Else
                _NavegadorReg = _MaxReg
            End If
        End If
    End Sub

    Private Sub P_ActualizarPuterosNavegacion(NavegadorReg As Integer)
        _MaxReg = _DsPagos.Tables(0).Rows.Count - 1
        If (_NavegadorReg > _MaxReg) Then
            _NavegadorReg = _MaxReg
        End If
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_ActualizarPaginacion(ByVal _index As Integer)
        Txt_Paginacion.Text = "Reg. " & _index + 1 & " de " & _MaxReg + 1
    End Sub

#End Region

    Private Sub P_HabilitarComponentes(_Bool As Boolean)
        'Txt_Codigo.Enabled = _Bool
        Txt_NroNota.Enabled = _Bool
        Txt_CodCliente.Enabled = _Bool
        Txt_Monto.Enabled = _Bool
        Dti_Fecha.Enabled = _Bool
        Txt_NroDoc.Enabled = _Bool
        Txt_NombreCliente.Enabled = _Bool
        Bt1BuscarCliente.Enabled = _Bool
        Cb1TipoProducto.Enabled = _Bool
    End Sub

    Private Sub P_ArmarGrilla()
        _DsPagos = New DataSet
        _DsPagos = L_GetPagos()
        Dgs_Pagos.PrimaryGrid.Columns.Clear()

        With Dgs_Pagos.PrimaryGrid
            'Alto de la Fila de Nombres de Columnas
            .ColumnHeader.RowHeight = 25

            'Mostrar u Ocultar la Fila de Filtrado
            .EnableColumnFiltering = True
            .EnableFiltering = True
            .EnableRowFiltering = True
            .Filter.Visible = True

            'Para Mostrar u Ocultar la Columna de Cabesera de las Filas
            .ShowRowHeaders = True

            'Para Mostrar el Indice de la Grilla
            .RowHeaderIndexOffset = 1
            .ShowRowGridIndex = True

            'Alto de las Filas
            .DefaultRowHeight = 22

            'Alternar Colores de las Filas
            .UseAlternateRowStyle = True

            'Para permitir o denegar el cambio de tamaño de la Filas
            .AllowRowResize = False

            'Para que el Tamaño de las Columnas se pongan automaticamente
            'DgdFactura.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.DisplayedCells

            .SelectionGranularity = SelectionGranularity.RowWithCellHighlight
        End With

        'a.ognumi, a.ognota, a.ogcli, b.ccdesc as [nombre], a.ogmon,  ISNULL(c.idsaldo, 0)  as saldo,  a.ogfdoc, a.ogrec "
        Dim col As GridColumn
        With Dgs_Pagos.PrimaryGrid
            col = New GridColumn()
            col.Name = "ognumi" '1
            col.HeaderText = "Código Pago"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 80
            col.Visible = False
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ognota" '2
            col.HeaderText = "Nota"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 80
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ogcli" '3
            col.HeaderText = "Código"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 80
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "nombre" '4
            col.HeaderText = "Nombre"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            col.Width = 200
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ogmon" '5
            col.HeaderText = "Monto"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 100
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "saldo" '6
            col.HeaderText = "Saldo"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 100
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ogfdoc" '7
            col.HeaderText = "Fecha"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 80
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimePickerEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ogrec" '8
            col.HeaderText = "Nro Recibo"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 100
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "ogtprod" '8
            col.HeaderText = ""
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleRight
            col.Width = 0
            col.Visible = False
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

            col = New GridColumn()
            col.Name = "cedesc" '8
            col.HeaderText = "Procducto"
            col.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
            col.Width = 100
            col.Visible = True
            col.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            .Columns.Add(col)

        End With

        P_LlenarDatosGrid(_DsPagos.Tables(0))
    End Sub

    Private Sub P_ActualizarPuterosNavegacion()
        _MaxReg = _DsPagos.Tables(0).Rows.Count - 1
        If (_NavegadorReg > _MaxReg) Then
            _NavegadorReg = _MaxReg
        End If
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_LlenarDatosGrid(dt As Object)
        Dgs_Pagos.PrimaryGrid.Rows.Clear()
        Dgs_Pagos.PrimaryGrid.DataSource = dt
    End Sub

    Private Sub P_Limpiar()
        Txt_Codigo.Clear()
        Txt_NroNota.Clear()
        Txt_CodCliente.Clear()
        Txt_Monto.Clear()
        Dti_Fecha.Text = Now.Date.ToShortDateString
        Lbl_Saldo.Text = 0.0
        Txt_NroDoc.Clear()
        Txt_NombreCliente.Clear()

        'P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

        _Nuevo = False
        _Mofificar = False
        _Eliminar = False

        BBtn_Grabar.TooltipText = "GRABAR"
        _Grabar = 0
    End Sub

    Private Sub P_PonerHighLigh(eHighlightColor As Validator.eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_Codigo, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_NroNota, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_CodCliente, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_Monto, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Dti_Fecha, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_NroDoc, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Txt_NombreCliente, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Dgs_Pagos, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Lbl_Saldo, eHighlightColor)
        Hl_Pagos.SetHighlightColor(Cb1TipoProducto, eHighlightColor)
    End Sub

    Private Sub Txt_CodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_CodCliente.KeyDown
        'If (Txt_CodCliente.Text.Length > 0 And (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up)) Then
        '    If (Dgs_Combo.PrimaryGrid.Rows.Count = 1) Then
        '        Dgs_Combo.Select()
        '        Dgs_Combo.PrimaryGrid.SetActiveCell(Dgs_Combo.PrimaryGrid.GetCell(0, 0))
        '    ElseIf (Dgs_Combo.PrimaryGrid.Rows.Count > 1) Then
        '        Dgs_Combo.Select()
        '        Dgs_Combo.PrimaryGrid.SetActiveCell(Dgs_Combo.PrimaryGrid.GetCell(1, 0))
        '    End If
        'End If

        'If (e.KeyCode = Keys.Enter) Then
        '    If (Dgs_Combo.PrimaryGrid.Rows.Count > 0) Then
        '        Txt_CodCliente.Text = Dgs_Combo.PrimaryGrid.GetCell(0, 0).Value
        '        Txt_NombreCliente.Text = Dgs_Combo.PrimaryGrid.GetCell(0, 1).Value
        '    Else
        '        'Lbl_CodCliente.Text = "EL CÓDIGO DE CLIENTE NO EXISTE"
        '    End If
        '    Dgs_Combo.Visible = False
        '    Txt_CodCliente.SelectAll()
        'End If
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_FiltrarGridBusqueda()
        End If
    End Sub

    Private Sub Txt_NombreCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_NombreCliente.KeyDown
        'If (Txt_NombreCliente.Text.Length > 0 And (e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up)) Then
        '    If (Dgs_Combo.PrimaryGrid.Rows.Count = 1) Then
        '        Dgs_Combo.Select()
        '        Dgs_Combo.PrimaryGrid.SetActiveCell(Dgs_Combo.PrimaryGrid.GetCell(0, 0))
        '    ElseIf (Dgs_Combo.PrimaryGrid.Rows.Count > 1) Then
        '        Dgs_Combo.Select()
        '        Dgs_Combo.PrimaryGrid.SetActiveCell(Dgs_Combo.PrimaryGrid.GetCell(1, 0))
        '    End If
        'End If

        'If (e.KeyCode = Keys.Enter) Then
        '    If (Dgs_Combo.PrimaryGrid.Rows.Count > 0) Then
        '        Txt_CodCliente.Text = Dgs_Combo.PrimaryGrid.GetCell(0, 0).Value
        '        Txt_NombreCliente.Text = Dgs_Combo.PrimaryGrid.GetCell(0, 1).Value
        '    Else
        '        'Lbl_CodCliente.Text = "EL CÓDIGO DE CLIENTE NO EXISTE"
        '    End If
        '    Dgs_Combo.Visible = False
        '    Txt_CodCliente.SelectAll()
        'End If
    End Sub

    Private Sub Dgs_Pagos_CellClick(sender As Object, e As GridCellClickEventArgs) Handles Dgs_Pagos.CellClick
        If (Not BBtn_Grabar.Enabled) Then
            If (e.GridCell.RowIndex > -1) Then
                P_LlenarDatos(e.GridCell.RowIndex)
                P_ActualizarPaginacion(e.GridCell.RowIndex)
                _NavegadorReg = e.GridCell.RowIndex
            End If
        End If
    End Sub

    Private Sub P_ArmarGrillaClientes()
        Dim dt As New DataTable
        dt = L_GetClientes()

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = dt
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "ccnumi"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = ""
            .Key = "cccod"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "Nombre"
            .Key = "ccdesc"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "Dirección"
            .Key = "ccdirec"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = "Teléfono 1"
            .Key = "cctelf1"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(5)
            .Caption = "Teléfono 2"
            .Key = "cctelf2"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(6)
            .Caption = ""
            .Key = "numZona"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(7)
            .Caption = "Zona"
            .Key = "descZona"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(8)
            .Caption = ""
            .Key = "numDct"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(9)
            .Caption = "Tipo de Documento"
            .Key = "descDct"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(10)
            .Caption = "Nro Documento"
            .Key = "ccdctnum"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(11)
            .Caption = ""
            .Key = "numCat"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(12)
            .Caption = "Categoria"
            .Key = "descCat"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(13)
            .Caption = "Estado"
            .Key = "ccest"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(14)
            .Caption = "Latitud"
            .Key = "cclat"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(15)
            .Caption = "Longitud"
            .Key = "cclongi"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(16)
            .Caption = "Eventual"
            .Key = "cceven"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(17)
            .Caption = "Observación"
            .Key = "ccobs"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(18)
            .Caption = "Fecha de Nac"
            .Key = "ccfnac"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(19)
            .Caption = "Nombre Factura"
            .Key = "ccnomfac"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(20)
            .Caption = "NIT"
            .Key = "ccnit"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(21)
            .Caption = "Fecha de Ingreso"
            .Key = "ccfecing"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Busqueda.RootTable.Columns(22)
            .Caption = "Fecha de Ultimo Pedido"
            .Key = "ccultped"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(23)
            .Caption = "Usuario"
            .Key = "ccuact"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
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
            .AutomaticSort = False 'Deshabilita la ordenación de las columnas
            .RecordNavigator = True
            .RecordNavigatorText = "Cliente: "
            .BringToFront()
        End With
    End Sub

    Private Sub P_Pagos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            _MoverEnfoque()
        End If
    End Sub

    Private Sub _MoverEnfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Bt1BuscarCliente_Click(sender As Object, e As EventArgs) Handles Bt1BuscarCliente.Click
        P_FiltrarGridBusqueda()
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dgj1Busqueda_DoubleClick(sender As Object, e As EventArgs) Handles Dgj1Busqueda.DoubleClick
        If (Dgj1Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerDatosBusqueda()
        End If
    End Sub

    Private Sub P_FiltrarGridBusqueda()
        SuperTabItem2.Visible = True
        SuperTabControl1.SelectedTabIndex = 1
        Dgj1Busqueda.RemoveFilters()
        Dgj1Busqueda.Select()
        Dgj1Busqueda.MoveTo(Dgj1Busqueda.FilterRow)
        Dgj1Busqueda.Col = 2
        Dgj1Busqueda.AlternatingColors = True
    End Sub

    Private Sub Dgj1Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgj1Busqueda.KeyDown
        If (e.KeyData = Keys.Enter And Dgj1Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerDatosBusqueda()
        End If
    End Sub

    Private Sub P_PonerDatosBusqueda()
        Txt_CodCliente.Text = Dgj1Busqueda.GetValue("ccnumi").ToString
        Txt_NombreCliente.Text = Dgj1Busqueda.GetValue("ccdesc").ToString
        If (L_ObtenerSaldoCliente(1, Txt_CodCliente.Text).Tables(0).Rows.Count > 0) Then
            Lbl_Saldo.Text = L_ObtenerSaldoCliente(1, Txt_CodCliente.Text).Tables(0).Rows(0).Item("idsaldo").ToString
        Else
            Lbl_Saldo.Text = "0"
        End If

        SuperTabControl1.SelectedTabIndex = 0
        Txt_Monto.Select()
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        'Cuando se cambia de Tab, si va al Tab Registro el Tab Busqueda se pone visible=false
        SuperTabItem2.Visible = Not SuperTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub P_ArmarCombo()
        Dim _Ds As New DataSet
        '_Ds = L_GetZonas()
        _Ds = L_LibreriaGeneral("5")

        Cb1TipoProducto.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cenum").ToString).Width = 50
        Cb1TipoProducto.DropDownList.Columns(0).Caption = "Nro."

        Cb1TipoProducto.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc").ToString).Width = 150
        Cb1TipoProducto.DropDownList.Columns(1).Caption = "Descripción"

        Cb1TipoProducto.ValueMember = _Ds.Tables(0).Columns("cenum").ToString
        Cb1TipoProducto.DisplayMember = _Ds.Tables(0).Columns("cedesc").ToString
        Cb1TipoProducto.DataSource = _Ds.Tables(0)
        Cb1TipoProducto.Refresh()
    End Sub

    Private Sub Txt_NroNota_Leave(sender As Object, e As EventArgs) Handles Txt_NroNota.Leave
        If ((_Nuevo Or _Mofificar) And Not Txt_NroNota.Text.Trim.Equals("")) Then
            If (Not L_ValidarNroNotaPagos(Txt_NroNota.Text.Trim)) Then
                ToastNotification.Show(Me, "El Nro de Nota ".ToUpper + Txt_NroNota.Text + " NO exite!!!".ToUpper,
                           My.Resources.WARNING,
                           _DuracionSms * 1000,
                           eToastGlowColor.Red,
                           eToastPosition.BottomLeft)
            End If
        End If
        
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TO003", "og", "ognumi=" + Txt_Codigo.Text)
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
End Class