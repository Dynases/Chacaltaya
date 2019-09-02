Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.Editors.DateTimeAdv

Public Class P_Feriados
#Region "Variables Lcales"
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
#End Region

#Region "Metodos Privados"

    Private Sub _PCargarFeriadosAlCalendario()
        Dim dtFechas As DataTable = L_Feriado_General(0).Tables(0)

        For i = 0 To dtFechas.Rows.Count - 1
            Dim fecha As DateTime = dtFechas.Rows(i).Item("pfflib")
            Dim desc As String = dtFechas.Rows(i).Item("pfdes")

            Dim dia As DayLabel = Calendario.GetDay(fecha)
            If Not dia Is Nothing Then
                dia.Image = My.Resources.Resources.FERIADO
                dia.ImageAlign = eLabelPartAlignment.MiddleRight
                dia.TextAlign = eLabelPartAlignment.MiddleLeft
                dia.Tooltip = "Click en la imagen para ver la descripcion"

                dia.SubItems.Add(New ButtonItem("Descripcion", desc))

                dia.BackgroundStyle.BackColor = Color.OrangeRed

            End If

        Next
    End Sub

    Private Sub _PCargarBuscador()
        Dim dt As New DataTable
        dt = L_Feriado_General(0).Tables(0)

        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("pfnumi")
            .Caption = "Cod"
            .Width = 40
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("pfflib")
            .Caption = "Fecha"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("pfdes")
            .Caption = "Descipcion"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        'Habilitar Filtradores
        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            JGr_Buscador.VisualStyle = VisualStyle.Office2007
        End With

    End Sub

    Private Sub _PHabilitar()
        Tb_Fecha.Enabled = True
        Tb_Desc.Enabled = True

        BBtn_Nuevo.Enabled = False
        BBtn_Modificar.Enabled = False
        BBtn_Eliminar.Enabled = False
        BBtn_Grabar.Enabled = True

        JGr_Buscador.Enabled = False
    End Sub
    Private Sub _PInhabilitar()
        Tb_Id.Enabled = False
        Tb_Fecha.Enabled = False
        Tb_Desc.Enabled = False

        BBtn_Nuevo.Enabled = True
        BBtn_Modificar.Enabled = True
        BBtn_Eliminar.Enabled = True
        BBtn_Grabar.Enabled = False

        BBtn_Grabar.Image = My.Resources.GRABAR
        BBtn_Grabar.ImageLarge = My.Resources.GRABAR

        _PLimpiarErrores()

        JGr_Buscador.Enabled = True
    End Sub
    Private Sub _PLimpiarErrores()
        EP1.Clear()
        Tb_Fecha.BackColor = Color.White
        Tb_Desc.BackColor = Color.White
    End Sub
    Private Sub _PLimpiar()
        Tb_Id.Text = ""
        Tb_Desc.Text = ""

        'aumentado 
        Txt_Paginacion.Text = ""

    End Sub
    Private Sub _PHabilitarFocus()

        HighLigthter_Focus.SetHighlightOnFocus(Tb_Fecha, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Desc, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)

        Tb_Fecha.TabIndex = 1
        Tb_Desc.TabIndex = 2

    End Sub


    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "F E R I A D O S"
        Me.WindowState = FormWindowState.Maximized

        'iniciar variables
        SuperTabItem2.Visible = False

        _PFiltrar()
        _PInhabilitar()

        _PHabilitarFocus()

        _PCargarBuscador()

        'cargar feriados en el calendario
        '_PCargarFeriadosAlCalendario()
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

    Private Sub _PFiltrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_Feriado_General(0)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                BBtn_Inicio.Visible = True
                BBtn_Anterior.Visible = True
                BBtn_Siguiente.Visible = True
                BBtn_Ultimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)

        With _Dsencabezado.Tables(0).Rows(_N)
            Tb_Id.Text = .Item("pfnumi").ToString
            If IsDBNull(.Item("pfflib")) = False Then
                Tb_Fecha.Value = .Item("pfflib").ToString
            End If
            Tb_Desc.Text = .Item("pfdes").ToString
        End With

    End Sub

    Public Overrides Function P_Validar() As Boolean
        Return Not _PValidar()
    End Function
    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False
        EP1.Clear()
        If Tb_Desc.Text = "" Then
            Tb_Desc.BackColor = Color.Red
            EP1.SetError(Tb_Desc, "Ingrese la descripcion del feriado!")
            _Error = True
        Else
            Tb_Desc.BackColor = Color.White
            EP1.SetError(Tb_Desc, "")
        End If


        HighLigthter_Focus.UpdateHighlights()
        Return _Error
    End Function

    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        If P_Validar() = False Then
            Exit Sub
        End If
        If BBtn_Grabar.Enabled = False Then
            Exit Sub
        End If

        If BBtn_Grabar.Tag = 0 Then
            BBtn_Grabar.Tag = 1
            'BBtn_Grabar.Image = My.Resources.CONFIRMACION
            'BBtn_Grabar.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar1.Refresh()
            Exit Sub
        Else
            BBtn_Grabar.Tag = 0
            'BBtn_Grabar.Image = My.Resources.GRABAR
            'BBtn_Grabar.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If


        If _Nuevo Then
            L_Feriado_Grabar(Tb_Id.Text, Tb_Fecha.Value.ToString("yyyy/MM/dd"), Tb_Desc.Text)

            'actualizar el grid de buscador
            _Dsencabezado = L_Feriado_General(0)
            _PCargarBuscador()

            Tb_Fecha.Focus()
            ToastNotification.Show(Me, "Codigo de Feriado " + Tb_Id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            _PLimpiar()

            'actualizar el calendario
            _PCargarFeriadosAlCalendario()
        Else
            L_Feriado_Modificar(Tb_Id.Text, Tb_Fecha.Value.ToString("yyyy/MM/dd"), Tb_Desc.Text)

            ToastNotification.Show(Me, "Codigo de Feriado " + Tb_Id.Text + " Modificado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)

            'actualizar el grid de buscador
            _PCargarBuscador()

            _Nuevo = False 'aumentado danny
            _PInhabilitar()
            _PFiltrar()

            'actualizar el calendario
            _PCargarFeriadosAlCalendario()
        End If
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()
        BBtn_Nuevo.Enabled = True

        _PLimpiar()
        Tb_Fecha.Focus()
        _Nuevo = True
    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        '_Modificar = True
        _PHabilitar()
        BBtn_Modificar.Enabled = True 'aumentado para q funcione con el modelo de guido
    End Sub

    Private Sub _PEliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("Esta seguro de Eliminar el Registro?", MsgBoxStyle.YesNo, "Advertencia")
        If _Result = MsgBoxResult.Yes Then
            L_Feriado_Borrar(Tb_Id.Text)
            _PFiltrar()

            'mi codigo, actualizo el sub
            _Pos = 0
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub _PSalirRegistro()
        If BBtn_Grabar.Enabled = True Then
            _PInhabilitar()
            _PFiltrar()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub _PPrimerRegistro()
        _Pos = 0
        _PMostrarRegistro(_Pos)
        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _PMostrarRegistro(_Pos)
        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub

#End Region

    Private Sub P_Feriados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click
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

    Private Sub JGr_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Buscador.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGr_Buscador_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Buscador.SelectionChanged
        If JGr_Buscador.Row >= 0 Then
            _Pos = JGr_Buscador.Row
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub Calendario_MonthChanged(sender As Object, e As EventArgs) Handles Calendario.MonthChanged
        'L_abrirConexion()
        _PCargarFeriadosAlCalendario()
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TP005", "pf", "pfnumi=" + Tb_Id.Text)
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