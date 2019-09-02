Imports Logica.AccesoLogica
Public Class PR_Asistencia
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable

        Dim objrep As New R_PlanillaAsistencia

        _dt = L_prAsistenciaReportePlanilla()

        objrep.SetDataSource(_dt)
        CrystalReportViewer1.ReportSource = objrep

    End Sub
    Private Sub PR_StockActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "a s i s t e n c i a    d e    p e r s o n a l"
        _prCargarReporte()
    End Sub
End Class