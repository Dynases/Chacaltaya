Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_Mensajeria

#Region "Variables Lcales"
    'Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Public _lectura As Boolean = False
#End Region

#Region "Metodos Privados"

    Private Sub _PIniciarTodo()

        Me.Text = "MENSAJERIA"
        Me.WindowState = FormWindowState.Maximized

        SuperTabItem1.Text = "REGISTRO DE MENSAJES"
        SuperTabItem2.Text = "MENSAJES ENVIADOS"

        _PCargarListaUsuarios()

        _PFiltrar()
        _PInhabilitar()

        _PHabilitarFocus()

        SuperTabControl1.SelectedTabIndex = 0

        _pCambiarFuente()

        If _lectura = True Then
            SuperTabControl1.SelectedTabIndex = 2
        End If
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
        For Each xCtrl In GroupPanel1.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

        For Each xCtrl In GroupPanel3.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

        Txt_Paginacion.Font = fuente
        Txt_NombreUsu.Font = fuente
        jgrBuscador.Font = fuente
        GroupPanel3.Font = fuente
        GroupPanel5.Font = fuente
        tbMensaje2.Font = fuente
    End Sub

    Private Sub _PCargarGridBuscador()
        Dim dt As New DataTable
        dt = L_MensajeriaGeneral("cjusuario=" + gi_userNumi.ToString)

        jgrBuscador.BoundMode = BoundMode.Bound
        jgrBuscador.DataSource = dt
        jgrBuscador.RetrieveStructure()

        'dar formato a las columnas
        With jgrBuscador.RootTable.Columns("cjnumi")
            .Caption = "cod"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrBuscador.RootTable.Columns("cjusuario")
            .Visible = False
            .Caption = "Cod. Persona"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrBuscador.RootTable.Columns("yduser1")
            .Caption = "Origen"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With jgrBuscador.RootTable.Columns("cjpara")
            .Visible = False
            .Caption = "Año"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrBuscador.RootTable.Columns("yduser2")
            .Caption = "Destino"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With jgrBuscador.RootTable.Columns("cjnota")
            .Caption = "Mensaje"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With jgrBuscador.RootTable.Columns("cjfecha")
            .Caption = "Fecha"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrBuscador.RootTable.Columns("cjhora")
            .Caption = "Hora"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrBuscador.RootTable.Columns("cjleido")
            .Caption = "Leido"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With jgrBuscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            jgrBuscador.VisualStyle = VisualStyle.Office2007
        End With


    End Sub

    Private Sub _PCargarGridMensajes(Optional where As String = "")
        Dim dt As New DataTable
        dt = L_MensajeriaGeneral("cjpara=" + gi_userNumi.ToString + where)

        jgrMensajes.BoundMode = BoundMode.Bound
        jgrMensajes.DataSource = dt
        jgrMensajes.RetrieveStructure()

        'dar formato a las columnas
        With jgrMensajes.RootTable.Columns("cjnumi")
            .Caption = "Cod"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrMensajes.RootTable.Columns("cjusuario")
            .Visible = False
            .Caption = "Cod. Persona"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrMensajes.RootTable.Columns("yduser1")
            .Caption = "Origen"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With jgrMensajes.RootTable.Columns("cjpara")
            .Visible = False
            .Caption = "Año"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrMensajes.RootTable.Columns("yduser2")
            .Visible = False
            .Caption = "Destino"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With jgrMensajes.RootTable.Columns("cjnota")
            .Caption = "Mensaje"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With jgrMensajes.RootTable.Columns("cjfecha")
            .Caption = "Fecha"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrMensajes.RootTable.Columns("cjhora")
            .Caption = "Hora"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With jgrMensajes.RootTable.Columns("cjleido")
            .Visible = False
            .Caption = "Leido"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With jgrMensajes
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            jgrMensajes.VisualStyle = VisualStyle.Office2007
        End With

        jgrMensajes.MoveTo(jgrMensajes.FilterRow)

    End Sub
    Private Sub _PCargarListaUsuarios()
        Dim dt As New DataTable
        dt = L_Usuario_General3(0).Tables(0)

        dgjUsuarios.DataSource = dt
        dgjUsuarios.RetrieveStructure()

        With dgjUsuarios.RootTable.Columns("ydnumi")
            .Visible = False
        End With
        With dgjUsuarios.RootTable.Columns("yduser")
            .Caption = "Usuario"
            .CellStyle.TextAlignment = TextAlignment.Near
            .Width = 150
            .HeaderStyle.Font = New Font("Arial", gi_fuenteTamano + 3)
            .CellStyle.Font = New Font("Arial", gi_fuenteTamano + 2)
            .AllowSort = False
        End With
        With dgjUsuarios.RootTable.Columns("check")
            .Caption = "Check"
            .CellStyle.TextAlignment = TextAlignment.Near
            .Width = 80
            .HeaderStyle.Font = New Font("Arial", gi_fuenteTamano + 3)
            .CellStyle.Font = New Font("Arial", gi_fuenteTamano + 2)
            .AllowSort = False
        End With

        With dgjUsuarios
            .GroupByBoxVisible = False
            .FilterMode = FilterMode.None
            .AlternatingColors = True
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub
    Private Sub _PHabilitar()
        tbMensaje.ReadOnly = False

        bbtNuevo.Enabled = False
        bbtModificar.Enabled = False
        bbtEliminar.Enabled = False
        bbtGrabar.Enabled = True

        dgjUsuarios.AllowEdit = InheritableBoolean.True
        btSeleccionarTodos.Enabled = True

    End Sub
    Private Sub _PInhabilitar()
        tbNumi.ReadOnly = True
        tbHora.ReadOnly = True
        tbMensaje.ReadOnly = True
        tbFecha.ReadOnly = True
        tbDestinoUsuario.ReadOnly = True

        bbtNuevo.Enabled = True
        bbtModificar.Enabled = True
        bbtEliminar.Enabled = True
        bbtGrabar.Enabled = False

        dgjUsuarios.AllowEdit = InheritableBoolean.False

        btSeleccionarTodos.Enabled = False

        bbtGrabar.Image = My.Resources.GRABAR
        bbtGrabar.ImageLarge = My.Resources.GRABAR

        _PLimpiarErrores()
    End Sub
    Private Sub _PLimpiarErrores()
        EP1.Clear()
        tbMensaje.BackColor = Color.White
    End Sub
    Private Sub _PLimpiar()
        tbFecha.Text = ""
        tbMensaje.Text = ""
        tbHora.Text = ""
        tbNumi.Text = ""
        tbDestinoUsuario.Text = ""

        _PCargarListaUsuarios()

        'aumentado 
        Txt_Paginacion.Text = ""

    End Sub
    Private Sub _PHabilitarFocus()

        HighLigthter_Focus.SetHighlightOnFocus(tbFecha, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(tbHora, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(tbMensaje, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(tbNumi, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(tbDestinoUsuario, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(dgjUsuarios, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)


    End Sub


    

    Private Sub _PFiltrar()
        '_Dsencabezado = New DataSet
        '_Dsencabezado = L_BonosDescuentosCabecera_General(0)
        '_First = False
        _PCargarGridBuscador()
        If jgrBuscador.RowCount <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            If jgrBuscador.RowCount > 0 Then
                BBtn_Inicio.Visible = True
                BBtn_Anterior.Visible = True
                BBtn_Siguiente.Visible = True
                BBtn_Ultimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)
        jgrBuscador.Row = _N
        With jgrBuscador
            tbNumi.Text = .GetValue("cjnumi").ToString

            tbOrigenUsuarioID.Text = .GetValue("cjusuario").ToString

            tbDestinoUsuarioID.Text = .GetValue("cjpara").ToString
            tbDestinoUsuario.Text = .GetValue("yduser2").ToString

            tbMensaje.Text = .GetValue("cjnota").ToString
            tbFecha.Text = CType(.GetValue("cjfecha"), Date).ToString("dd/MM/yyyy")
            tbHora.Text = .GetValue("cjhora").ToString
        End With

        'cargar lista repartidores
        _PCargarListaUsuarios()
        Dim codUserDestino, j As Integer
        For j = 0 To CType(dgjUsuarios.DataSource, DataTable).Rows.Count - 1
            codUserDestino = CType(dgjUsuarios.DataSource, DataTable).Rows(j).Item(0)
            If codUserDestino = tbDestinoUsuarioID.Text Then
                CType(dgjUsuarios.DataSource, DataTable).Rows(j).Item("check") = 1
                Exit For
            End If
        Next

        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + jgrBuscador.RowCount.ToString
    End Sub

    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False

        If tbMensaje.Text = "" Then
            tbMensaje.BackColor = Color.Red
            EP1.SetError(tbMensaje, "Ingrese el mensaje".ToUpper)
            _Error = True
        Else
            tbMensaje.BackColor = Color.White
            EP1.SetError(tbMensaje, "")
        End If

        Dim flat As Boolean = False
        For Each fil As GridEXRow In dgjUsuarios.GetRows
            If (CBool(fil.Cells("check").Value)) Then
                flat = True
                Exit For
            End If
        Next

        If (Not flat) Then
            ToastNotification.Show(Me, "seleccione algun destinatario".ToUpper, My.Resources.WARNING, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            _Error = True
        End If

        Return _Error
    End Function

    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        tbMensaje.Select()
        If _PValidar() Then
            Exit Sub
        End If
        If bbtGrabar.Enabled = False Then
            Exit Sub
        End If

        If False Then 'bbtGrabar.Tag = 0
            bbtGrabar.Tag = 1
            bbtGrabar.Image = My.Resources.CONFIRMACION
            bbtGrabar.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar6.Refresh()
            Exit Sub
        Else
            bbtGrabar.Tag = 0
            bbtGrabar.Image = My.Resources.GRABAR
            bbtGrabar.ImageLarge = My.Resources.GRABAR
            BubbleBar6.Refresh()
        End If

        If _Nuevo Then

            'grabar detalle repartidores
            Dim codUser, j, iSelec As Integer
            For Each fil As GridEXRow In dgjUsuarios.GetRows
                If (CBool(fil.Cells("check").Value)) Then
                    codUser = CInt(fil.Cells("ydnumi").Value)
                    L_MensajeriaGrabar(tbNumi.Text, gi_userNumi.ToString, codUser, tbMensaje.Text, Now.Date.ToString("yyyy/MM/dd"), Now.Hour.ToString("00") + ":" + Now.Minute.ToString("00"), "0")
                End If
            Next

            tbMensaje.Focus()
            ToastNotification.Show(Me, "Codigo " + tbNumi.Text + " Grabado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            _PLimpiar()
        Else

            L_MensajeriaModificar(tbNumi.Text, tbOrigenUsuarioID.Text, tbDestinoUsuarioID.Text, tbMensaje.Text, Now.Date.ToString("yyyy/MM/dd"), Now.Hour.ToString("00:00"), "0")

            ToastNotification.Show(Me, "Codigo " + tbNumi.Text + " Modificado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)

            _Nuevo = False 'aumentado danny
            '_Modificar = False 'aumentado danny
            _PInhabilitar()
            _PFiltrar()
        End If
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()
        bbtNuevo.Enabled = True

        _PLimpiar()
        tbMensaje.Focus()
        _Nuevo = True

    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        '_Modificar = True
        _PHabilitar()
    End Sub

    Private Sub _PEliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("¿Esta seguro de Eliminar el Registro?".ToUpper, MsgBoxStyle.YesNo, "Advertencia".ToUpper)
        If _Result = MsgBoxResult.Yes Then
            L_MensajeriaBorrar(tbNumi.Text)

            _PFiltrar()

        End If
    End Sub

    Private Sub _PSalirRegistro()
        If bbtGrabar.Enabled = True Then
            Dim _Result As MsgBoxResult
            _Result = MsgBox("¿ESTA SEGURO DE SALIR SIN GUARDAR?", MsgBoxStyle.YesNo, "Advertencia".ToUpper)
            If _Result = MsgBoxResult.Yes Then
                _PInhabilitar()
                _PFiltrar()
                bbtGrabar.Tag = 0
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _PPrimerRegistro()
        If jgrBuscador.RowCount > 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
        End If

    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < jgrBuscador.RowCount - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        If jgrBuscador.RowCount > 0 Then
            _Pos = jgrBuscador.RowCount - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
#End Region

    Private Sub P_Mensajeria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub bbtNuevo_Click(sender As Object, e As ClickEventArgs) Handles bbtNuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub bbtModificar_Click(sender As Object, e As ClickEventArgs) Handles bbtModificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub bbtEliminar_Click(sender As Object, e As ClickEventArgs) Handles bbtEliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub bbtGrabar_Click(sender As Object, e As ClickEventArgs) Handles bbtGrabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub bbtSalir_Click(sender As Object, e As ClickEventArgs) Handles bbtSalir.Click
        _PSalirRegistro()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        _PPrimerRegistro()
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        _PAnteriorRegistro()
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        _PSiguienteRegistro()
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        _PUltimoRegistro()
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If e.NewValue.ToString = "RESGITRO" And _Nuevo = False Then
            If jgrBuscador.RowCount > 0 Then
                _Pos = 0
                _PMostrarRegistro(0)
            Else
                Txt_Paginacion.Text = 0
            End If
        End If

        If e.NewValue.ToString = "RECEPCION DE MENSAJES" And _Nuevo = False Then
            swTipoMensaje.Value = False
            GroupPanel3.Text = "m e n s a j e s    n o    l e i d o s".ToUpper
            _PCargarGridMensajes(" and cjleido=0")
        End If
    End Sub

    
    Private Sub swTipoMensaje_ValueChanged(sender As Object, e As EventArgs) Handles swTipoMensaje.ValueChanged
        tbFecha2.Text = ""
        tbMensaje2.Text = ""
        tbHora2.Text = ""
        tbNumi2.Text = ""
        tbDestinoUsuario2.Text = ""

        If swTipoMensaje.Value Then
            GroupPanel3.Text = "m e n s a j e s    l e i d o s".ToUpper
            _PCargarGridMensajes(" and cjleido=1")
        Else
            GroupPanel3.Text = "m e n s a j e s    n o    l e i d o s".ToUpper
            _PCargarGridMensajes(" and cjleido=0")
        End If
    End Sub

    Private Sub jgrMensajes_SelectionChanged(sender As Object, e As EventArgs) Handles jgrMensajes.SelectionChanged
        If jgrMensajes.Row >= 0 Then
            With jgrMensajes
                tbNumi2.Text = .GetValue("cjnumi").ToString

                tbOrigenUsuarioID2.Text = .GetValue("cjusuario").ToString

                tbDestinoUsuarioID2.Text = .GetValue("cjpara").ToString
                tbDestinoUsuario2.Text = .GetValue("yduser2").ToString

                tbMensaje2.Text = .GetValue("cjnota").ToString
                tbFecha2.Text = CType(.GetValue("cjfecha"), Date).ToString("dd/MM/yyyy")
                tbHora2.Text = .GetValue("cjhora").ToString

                'actualizar el estado a no leido
                Dim leido As Integer = .GetValue("cjleido").ToString
                If leido = 0 And SuperTabControl1.SelectedTabIndex = 2 Then
                    L_MensajeriaModificarLeido(tbNumi2.Text, "1")
                    Dim _estiloFila As New GridEXFormatStyle()
                    _estiloFila.BackColor = Color.LightGreen
                    .GetRow.RowStyle = _estiloFila
                End If

            End With
        End If
    End Sub

    Private Sub btSeleccionarTodos_Click(sender As Object, e As EventArgs) Handles btSeleccionarTodos.Click
        _PCargarListaUsuarios()
        For j = 0 To CType(dgjUsuarios.DataSource, DataTable).Rows.Count - 1
            CType(dgjUsuarios.DataSource, DataTable).Rows(j).Item("check") = 1
        Next
    End Sub

    Private Sub jgrMensajes_EditingCell(sender As Object, e As EditingCellEventArgs) Handles jgrMensajes.EditingCell
        e.Cancel = True
    End Sub

    Private Sub dgjUsuarios_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjUsuarios.EditingCell
        If (e.Column.Key = "check") Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class