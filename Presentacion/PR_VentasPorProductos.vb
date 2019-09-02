Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Public Class PR_VentasPorProductos

#Region "Metodos privados"
    Private Sub _prInicio()
        Me.Text = "reporte de ventas por productos".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        _prCargarComboProducto(cbProducto)
    End Sub

    Private Sub _prCargarReporte()

        Dim dt As New DataTable
        If swFiltro.Value = True Then
            dt = L_prReporteProductos(dtFecha1.Value.ToString("yyyy/MM/dd"), dtFecha2.Value.ToString("yyyy/MM/dd"), cbProducto.Value)
        Else
            dt = L_prReporteProductos(dtFecha1.Value.ToString("yyyy/MM/dd"), dtFecha2.Value.ToString("yyyy/MM/dd"), -1)
        End If

        If (dt.Rows.Count > 0) Then
            Dim objrep As New R_VentasProductos

            objrep.SetDataSource(dt)

            objrep.SetParameterValue("fecha1", dtFecha1.Value.ToString("dd/MM/yyyy"))
            objrep.SetParameterValue("fecha2", dtFecha2.Value.ToString("dd/MM/yyyy"))

            Crv.ReportSource = objrep

            Crv.Show()
            Crv.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            Crv.ReportSource = Nothing
        End If

    End Sub

    Private Sub _prCargarComboProducto(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_prListarTipo()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("cenum").Width = 60
            .DropDownList.Columns("cenum").Caption = "COD"
            .DropDownList.Columns.Add("cedesc").Width = 500
            .DropDownList.Columns("cedesc").Caption = "CATEGORIA"
            .ValueMember = "cenum"
            .DisplayMember = "cedesc"
            .DataSource = dt
            .Refresh()
        End With
        If (CType(mCombo.DataSource, DataTable).Rows.Count > 0) Then
            mCombo.SelectedIndex = 0
        End If
    End Sub
#End Region

    Private Sub PR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub swZona_ValueChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub swCategoria_ValueChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub tbZonaCod_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim frmAyuda As Modelos.ModeloAyuda
            Dim dt As DataTable = L_ZonaCabecera_GeneralCompleto1(0).Tables(0)
            Dim listEstCeldas As New List(Of Modelos.Celda)
            listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
            listEstCeldas.Add(New Modelos.Celda(False))
            listEstCeldas.Add(New Modelos.Celda(True, "Ciudad", 100))
            listEstCeldas.Add(New Modelos.Celda(False))
            listEstCeldas.Add(New Modelos.Celda(True, "Provincia", 100))
            listEstCeldas.Add(New Modelos.Celda(False))
            listEstCeldas.Add(New Modelos.Celda(True, "Zona", 100))
            listEstCeldas.Add(New Modelos.Celda(False))

            frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione concepto".ToUpper, listEstCeldas)
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim id As String = frmAyuda.filaSelect.Cells("lanumi").Value
                Dim descr As String = frmAyuda.filaSelect.Cells("cedesc2").Value

            End If

        End If
    End Sub


    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub

    Private Sub swFiltro_ValueChanged(sender As Object, e As EventArgs) Handles swFiltro.ValueChanged
        cbProducto.Enabled = swFiltro.Value
    End Sub
End Class