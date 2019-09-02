Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_GraficasLinealVentas

#Region "Metodos privados"
    Private Sub _prInicio()
        Me.Text = "reporte de pagos".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        tbAnioIni.MinValue = 2000
        tbAnioFin.MinValue = 2000

        _prCargarCombosMeses()

        tbAnioIni.Value = Now.Year
        tbAnioFin.Value = Now.Year

        tbMesIni.SelectedIndex = Now.Month - 1
        tbMesFin.SelectedIndex = Now.Month - 1
    End Sub

    Private Sub _prCargarCombosMeses()
        tbMesIni.Items.Clear()
        tbMesIni.Items.Add("ENERO")
        tbMesIni.Items.Add("FEBRERO")
        tbMesIni.Items.Add("MARZO")
        tbMesIni.Items.Add("ABRIL")
        tbMesIni.Items.Add("MAYO")
        tbMesIni.Items.Add("JUNIO")
        tbMesIni.Items.Add("JULIO")
        tbMesIni.Items.Add("AGOSTO")
        tbMesIni.Items.Add("SEPTIEMBRE")
        tbMesIni.Items.Add("OCTUBRE")
        tbMesIni.Items.Add("NOVIEMBRE")
        tbMesIni.Items.Add("DICIEMBRE")

        tbMesFin.Items.Clear()
        tbMesFin.Items.Add("ENERO")
        tbMesFin.Items.Add("FEBRERO")
        tbMesFin.Items.Add("MARZO")
        tbMesFin.Items.Add("ABRIL")
        tbMesFin.Items.Add("MAYO")
        tbMesFin.Items.Add("JUNIO")
        tbMesFin.Items.Add("JULIO")
        tbMesFin.Items.Add("AGOSTO")
        tbMesFin.Items.Add("SEPTIEMBRE")
        tbMesFin.Items.Add("OCTUBRE")
        tbMesFin.Items.Add("NOVIEMBRE")
        tbMesFin.Items.Add("DICIEMBRE")

    End Sub
    Private Sub _prCargarReporte()
        Dim _Ds As New DataSet
        Dim mesIni, mesFin As Integer
        mesIni = tbMesIni.SelectedIndex + 1
        mesFin = tbMesFin.SelectedIndex + 1
        Dim ultimoDiaFin As Integer = DateSerial(tbAnioFin.Value, mesFin + 1, 0).Day

        Dim fechaIni1 As New Date(tbAnioIni.Value, mesIni, 1)
        Dim fechaFin1 As New Date(tbAnioIni.Value, mesFin, ultimoDiaFin)
        Dim fechaIni2 As New Date(tbAnioFin.Value, mesIni, 1)
        Dim fechaFin2 As New Date(tbAnioFin.Value, mesFin, ultimoDiaFin)

        Dim where As String = "(oafdoc>='" + fechaIni1.ToString("yyyy/MM/dd") + "' And oafdoc<='" + fechaFin1.ToString("yyyy/MM/dd") + "') or (" + _
                              "oafdoc>='" + fechaIni2.ToString("yyyy/MM/dd") + "' And oafdoc<='" + fechaFin2.ToString("yyyy/MM/dd") + "')"

        _Ds = L_VistaGraficasVentasVs(where)
        If (_Ds.Tables(0).Rows.Count > 0) Then
            Dim objrep As New R_GraficaVentasVs

            objrep.SetDataSource(_Ds.Tables(0))
            Crv.ReportSource = objrep

            'objrep.SetParameterValue("Param_Del", Dtp_FechaIni.Value.ToShortDateString)
            'objrep.SetParameterValue("Param_Al", Dtp_FechaFin.Value.ToShortDateString)

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


    Private Sub PR_GraficasLinealVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub
End Class