﻿Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class F0_Turnos

#Region "VARIABLES LOCALES"
    Public _MPos As Integer
    Public _MNuevo As Boolean
    Public _MModificar As Boolean

#End Region


#Region "METODOS PRIVADOS"

    Public Sub _prIniciarTodo()

        Me.Text = "´t u r n o s".ToUpper

        Txt_NombreUsu.Text = P_Global.gs_Usuario
        Txt_NombreUsu.ReadOnly = True

        Me.WindowState = FormWindowState.Maximized
        Me.SuperTabItem2.Visible = False

        _prFiltrar()
        _prInhabilitar()

        _PMOHabilitarFocus()

        AddHandler JGrM_Buscador.SelectionChanged, AddressOf JGrM_Buscador_SelectionChanged

    End Sub

    Private Sub JGrM_Buscador_SelectionChanged(sender As Object, e As EventArgs)
        If JGrM_Buscador.Row >= 0 Then
            _MPos = JGrM_Buscador.Row
            _PMOMostrarRegistro(_MPos)
        End If
    End Sub

    Private Sub _prCargarBuscador()

        Dim dtBuscador As DataTable = _PMOGetTablaBuscador()

        JGrM_Buscador.DataSource = dtBuscador
        JGrM_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGrM_Buscador.RootTable.Columns("cnnumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGrM_Buscador.RootTable.Columns("cnobs")
            .Caption = "OBSERVACION"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGrM_Buscador.RootTable.Columns("cnfdoc")
            .Caption = "FECHA"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGrM_Buscador.RootTable.Columns("cnest")
            .Visible = False
        End With

        With JGrM_Buscador.RootTable.Columns("cnest2")
            .Caption = "ESTADO"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGrM_Buscador.RootTable.Columns("cnfact")
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("cnhact")
            .Visible = False
        End With
        With JGrM_Buscador.RootTable.Columns("cnuact")
            .Visible = False
        End With

        'Habilitar Filtradores
        With JGrM_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub

    Private Sub _prCargarGridDetalle(numi As String)
        Dim dt As New DataTable
        dt = L_prTurnoDetalle(numi)

        grDetalle.DataSource = dt

        'dar formato a las columnas
        With grDetalle.Columns("coline")
            .Width = 50
            .Visible = False
        End With

        With grDetalle.Columns("conumi")
            .Width = 60
            .Visible = False
        End With

        With grDetalle.Columns("coing1")
            .HeaderText = "Entrada 1".ToUpper
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.BackColor = Color.Green
        End With
        With grDetalle.Columns("cosal1")
            .HeaderText = "salida 1".ToUpper
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.BackColor = Color.Green
        End With

        With grDetalle.Columns("coing2")
            .HeaderText = "Entrada 2".ToUpper
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.BackColor = Color.IndianRed
        End With
        With grDetalle.Columns("cosal2")
            .HeaderText = "salida 2".ToUpper
            .Width = 70
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .DefaultCellStyle.BackColor = Color.IndianRed
        End With

        With grDetalle.Columns("estado")
            .ReadOnly = True
            .Visible = False
        End With

        With grDetalle
            .AllowUserToAddRows = False
        End With

    End Sub

    Private Sub _prInhabilitar()
        BBtn_Nuevo.Enabled = True
        BBtn_Modificar.Enabled = True
        BBtn_Eliminar.Enabled = True
        BBtn_Grabar.Enabled = False
        BubbleBar4.Enabled = True
        JGrM_Buscador.Enabled = True
        'MRlAccion.Text = ""

        _PMOLimpiarErrores()

        _PMOInhabilitar()
    End Sub

    Private Sub _prHabilitar()
        JGrM_Buscador.Enabled = False
        _PMOHabilitar()
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        _prCargarBuscador()
        If JGrM_Buscador.RowCount > 0 Then
            _MPos = 0
            _PMOMostrarRegistro(_MPos)
        Else
            _PMOLimpiar()
            Txt_Paginacion.Text = "0/0"
        End If
    End Sub

    Private Sub _prPrimerRegistro()
        If JGrM_Buscador.RowCount > 0 Then
            _MPos = 0
            _PMOMostrarRegistro(_MPos)
        End If
    End Sub
    Private Sub _prAnteriorRegistro()
        If _MPos > 0 And JGrM_Buscador.RowCount > 0 Then
            _MPos = _MPos - 1
            _PMOMostrarRegistro(_MPos)
        End If
    End Sub
    Private Sub _prSiguienteRegistro()
        If _MPos < JGrM_Buscador.RowCount - 1 Then
            _MPos = _MPos + 1
            _PMOMostrarRegistro(_MPos)
        End If
    End Sub
    Private Sub _prUltimoRegistro()
        If JGrM_Buscador.RowCount > 0 Then
            _MPos = JGrM_Buscador.RowCount - 1
            _PMOMostrarRegistro(_MPos)
        End If
    End Sub

    Private Sub _prNuevo()
        _MNuevo = True
        _MModificar = False

        _PMOLimpiar()
        _prHabilitar()

        BBtn_Nuevo.Enabled = False
        BBtn_Modificar.Enabled = False
        BBtn_Eliminar.Enabled = False
        BBtn_Grabar.Enabled = True
        BubbleBar4.Enabled = False

        'MRlAccion.Text = "NUEVO"

        '_PMOLimpiar() no lo estaba tomando en cuenta

    End Sub

    Private Sub _prModificar()
        If JGrM_Buscador.Row >= 0 Then
            _MNuevo = False
            _MModificar = True

            _prHabilitar()
            BBtn_Nuevo.Enabled = False
            BBtn_Modificar.Enabled = False
            BBtn_Eliminar.Enabled = False
            BBtn_Grabar.Enabled = True

            BubbleBar4.Enabled = False

            'MRlAccion.Text = "MODIFICAR"
        End If
    End Sub

    Private Sub _prEliminar()
        'Dim _Result As MsgBoxResult
        '_Result = MsgBox("¿Esta seguro de Eliminar el Registro?".ToUpper, MsgBoxStyle.YesNo, "Advertencia".ToUpper)
        'If _Result = MsgBoxResult.Yes Then
        '    _PMOEliminarRegistro()
        '    _PMFiltrar()

        'End If
        _PMOEliminarRegistro()
    End Sub

    Private Sub _prGuardar()

        If _PMOValidarCampos() = False Then
            Exit Sub
        End If

        If _MNuevo Then
            If _PMOGrabarRegistro() = True Then
                'actualizar el grid de buscador
                _prCargarBuscador()

                _PMOLimpiar()

            Else
                Exit Sub
            End If

        Else
            _PMOModificarRegistro()

            'actualizar el grid de buscador
            _prCargarBuscador()

            _prSalir()
        End If
    End Sub

    Private Sub _prSalir()
        If BBtn_Grabar.Enabled = True Then
            _prInhabilitar()
            _prPrimerRegistro()

        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "METODOS OVERRIDABLES"

    Private Sub _PMOMostrarRegistro(_N As Integer)
        JGrM_Buscador.Row = _MPos

        With JGrM_Buscador
            tbNumi.Text = .GetValue("cnnumi").ToString
            tbObs.Text = .GetValue("cnobs").ToString
            tbFecha.Value = .GetValue("cnfdoc")
            tbEstado.Value = IIf(.GetValue("cnest") = 1, True, False)

            'lbFecha.Text = CType(.GetValue("cbfact"), Date).ToString("dd/MM/yyyy")
            'lbHora.Text = .GetValue("cbhact").ToString
            'lbUsuario.Text = .GetValue("cbuact").ToString

            'CARGAR DETALLE
            _prCargarGridDetalle(tbNumi.Text)
        End With

        Txt_Paginacion.Text = Str(_MPos + 1) + "/" + JGrM_Buscador.RowCount.ToString
    End Sub

    Private Function _PMOGetTablaBuscador() As DataTable
        Dim dtBuscador As DataTable = L_prTurnoGeneral()
        Return dtBuscador
    End Function

    Private Function _PMOGetListEstructuraBuscador() As List(Of Modelos.Celda)
        'Dim listEstCeldas As New List(Of Modelos.Celda)
        'listEstCeldas.Add(New Modelos.Celda("cnnumi", True, "COD", 70))
        'listEstCeldas.Add(New Modelos.Celda("cnfdoc", True, "FECHA", 70))
        'listEstCeldas.Add(New Modelos.Celda("cnobs", True, "OBSERVACION", 200))
        'listEstCeldas.Add(New Modelos.Celda("cnest", False))
        'listEstCeldas.Add(New Modelos.Celda("cnest2", True, "ESTADO", 70))
        'listEstCeldas.Add(New Modelos.Celda("cnfact", False))
        'listEstCeldas.Add(New Modelos.Celda("cnhact", False))
        'listEstCeldas.Add(New Modelos.Celda("cnuact", False))
        'Return listEstCeldas
    End Function


    Private Sub _PMOHabilitarFocus()
        With MHighlighterFocus
            .SetHighlightOnFocus(tbObs, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
            .SetHighlightOnFocus(tbFecha, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
            .SetHighlightOnFocus(tbEstado, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        End With
    End Sub

    Private Sub _PMOInhabilitar()
        tbNumi.ReadOnly = True
        tbObs.ReadOnly = True
        tbFecha.Enabled = False
        tbEstado.IsReadOnly = True

        grDetalle.Enabled = False
    End Sub

    Private Sub _PMOHabilitar()
        tbObs.ReadOnly = False
        tbEstado.IsReadOnly = False
        tbFecha.Enabled = True

        grDetalle.Enabled = True
    End Sub

    Private Sub _PMOLimpiar()
        tbObs.Text = ""
        tbNumi.Text = ""
        tbFecha.Value = Now.Date
        tbEstado.Value = True

        'VACIO EL DETALLE
        _prCargarGridDetalle(-1)
        'agrego la unica fila
        CType(grDetalle.DataSource, DataTable).Rows.Add(1)
    End Sub

    Private Sub _PMOLimpiarErrores()
        MEP.Clear()
        tbObs.BackColor = Color.White
    End Sub

    Private Function _PMOValidarCampos() As Boolean
        Dim _ok As Boolean = True
        MEP.Clear()

        If tbObs.Text = String.Empty Then
            tbObs.BackColor = Color.Red
            MEP.SetError(tbObs, "ingrese la observacion del horario!".ToUpper)
            _ok = False
        Else
            tbObs.BackColor = Color.White
            MEP.SetError(tbObs, "")
        End If

        MHighlighterFocus.UpdateHighlights()
        Return _ok
    End Function

    Private Function _PMOGrabarRegistro() As Boolean
        Dim res As Boolean = L_prTurnoGrabar(tbNumi.Text, tbFecha.Value.ToString("yyyy-MM-dd"), tbObs.Text, IIf(tbEstado.Value = True, 1, 0), CType(grDetalle.DataSource, DataTable))
        If res Then
            ToastNotification.Show(Me, "Codigo de turno ".ToUpper + tbNumi.Text + " Grabado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            tbFecha.Focus()
        End If
        Return res
    End Function

    Private Function _PMOModificarRegistro() As Boolean
        Dim res As Boolean = L_prTurnoModificar(tbNumi.Text, tbFecha.Value.ToString("yyyy-MM-dd"), tbObs.Text, IIf(tbEstado.Value = True, 1, 0), CType(grDetalle.DataSource, DataTable))
        If res Then
            ToastNotification.Show(Me, "Codigo de turno ".ToUpper + tbNumi.Text + " modificado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
        End If
        Return res
    End Function

    Private Sub _PMOEliminarRegistro()
        Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper, eTaskDialogIcon.Delete, "advertencia".ToUpper, "mensaje principal".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_prTurnoEliminar(tbNumi.Text)
            If res Then
                ToastNotification.Show(Me, "Codigo de turno ".ToUpper + tbNumi.Text + " eliminado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                _prFiltrar()
            Else
                ToastNotification.Show(Me, mensajeError, My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

#End Region


    Private Sub F0_Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click
        _prNuevo()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click
        _prModificar()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click
        _prEliminar()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        _prGuardar()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click
        _prSalir()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        _prPrimerRegistro()
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        _prAnteriorRegistro()
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        _prSiguienteRegistro()
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        _prUltimoRegistro()
    End Sub

    Private Sub JGrM_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGrM_Buscador.EditingCell
        e.Cancel = True
    End Sub
End Class