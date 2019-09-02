Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_Pagos
    Private Sub _prInicio()
        Me.Text = "reporte de pagos".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        Dtp_FechaIni.Text = Now.Date
        Dtp_FechaFin.Text = Now.Date

    End Sub
    Private Sub _prCargarReporte()
        Dim _Ds As New DataSet
        _Ds = L_VistaPagos(Dtp_FechaIni.Value.ToString("yyyy/MM/dd"), Dtp_FechaFin.Value.ToString("yyyy/MM/dd"))
        If (_Ds.Tables(0).Rows.Count > 0) Then
            Dim objrep As New R_Pagos

            objrep.SetDataSource(_Ds.Tables(0))

            objrep.SetParameterValue("Param_Del", Dtp_FechaIni.Value.ToShortDateString)
            objrep.SetParameterValue("Param_Al", Dtp_FechaFin.Value.ToShortDateString)

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

    Private Sub PR_Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub
End Class