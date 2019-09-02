Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Public Class PR_Clientes

#Region "Metodos privados"
    Private Sub _prInicio()
        Me.Text = "reporte de clientes".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        tbCatCod.Enabled = False
        tbCatId.Enabled = False
        tbCatDesc.Enabled = False
        tbZonaCod.Enabled = False
        tbZonaDesc.Enabled = False

        tbCatCod.ReadOnly = True
        tbCatId.ReadOnly = True
        tbCatDesc.ReadOnly = True
        tbZonaCod.ReadOnly = True
        tbZonaDesc.ReadOnly = True

    End Sub

    Private Sub _prCargarReporte()

        Dim _Ds As New DataSet
        Dim where As String = " "
        If rbAct.Checked = True Then
            where = "ccest=1"
        Else
            If rbPasivo.Checked = True Then
                where = "ccest=0"
            Else
                where = "1=1"
            End If

        End If


        If swZona.Value Then
            where = where + " and cczona=" + tbZonaCod.Text
        End If

        If swCategoria.Value Then
            where = where + " and cccat=" + tbCatId.Text
        End If

        _Ds = L_VistaClientes(where)
        If (_Ds.Tables(0).Rows.Count > 0) Then
            Dim objrep As New R_Clientes

            objrep.SetDataSource(_Ds.Tables(0))
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
#End Region

    Private Sub PR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub swZona_ValueChanged(sender As Object, e As EventArgs) Handles swZona.ValueChanged
        tbZonaCod.Enabled = swZona.Value
        tbZonaDesc.Enabled = swZona.Value
    End Sub

    Private Sub swCategoria_ValueChanged(sender As Object, e As EventArgs) Handles swCategoria.ValueChanged
        tbCatCod.Enabled = swCategoria.Value
        tbCatDesc.Enabled = swCategoria.Value
        tbCatId.Enabled = swCategoria.Value
    End Sub

    Private Sub tbZonaCod_KeyDown(sender As Object, e As KeyEventArgs) Handles tbZonaCod.KeyDown, tbZonaDesc.KeyDown
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

                tbZonaCod.Text = id
                tbZonaDesc.Text = descr
            End If

        End If
    End Sub

    Private Sub tbCatId_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCatId.KeyDown, tbCatDesc.KeyDown, tbCatCod.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim frmAyuda As Modelos.ModeloAyuda
            Dim dt As DataTable = L_CategoriaPrecioGeneral()
            Dim listEstCeldas As New List(Of Modelos.Celda)
            listEstCeldas.Add(New Modelos.Celda(True, "Id", 70))
            listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
            listEstCeldas.Add(New Modelos.Celda(True, "Descripcion", 150))

            frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione categoria".ToUpper, listEstCeldas)
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim id As String = frmAyuda.filaSelect.Cells("cinumi").Value
                Dim cod As String = frmAyuda.filaSelect.Cells("cicod").Value
                Dim descr As String = frmAyuda.filaSelect.Cells("cidesc").Value

                tbCatId.Text = id
                tbCatCod.Text = cod
                tbCatDesc.Text = descr
            End If

        End If
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub
End Class