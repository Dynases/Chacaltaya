Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_ResumenNotas

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5

#End Region

#Region "Eventos"

    Private Sub PR_EntregaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()

        'L_abrirConexion()

        Dt1Desde.Value = Now.Date
        Dt2Hasta.Value = Now.Date

    End Sub

    Private Sub P_GenerarReporte()
        If (Dt1Desde.Value <= Dt2Hasta.Value) Then
            Dim _Ds As DataSet
            _Ds = L_ObtenerResumenNotas(Dt1Desde.Value.Date.ToString("yyyy/MM/dd"), Dt2Hasta.Value.Date.ToString("yyyy/MM/dd"))
            If (_Ds.Tables(0).Rows.Count > 0) Then
                Dim objrep As New R_ResumenNotas

                objrep.SetDataSource(_Ds.Tables(0))


                objrep.SetParameterValue("FechaIni", Dt1Desde.Value.ToShortDateString)
                objrep.SetParameterValue("FechaFin", Dt2Hasta.Value.ToShortDateString)

                Cr1Reporte.ReportSource = objrep

                Cr1Reporte.Show()
                Cr1Reporte.BringToFront()
            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            End If
        Else
            ToastNotification.Show(Me, "LA FECHA ''DESDE  TIENE QUE SER MENOR O IGUAL A LA FECHA ''HASTA''''..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_Cancelar()
        If (Dt1Desde.Value = Now.Date And Dt2Hasta.Value = Now.Date) Then
            Me.Dispose()
            Me.Close()
        Else
            Dt1Desde.Value = Now.Date
            Dt2Hasta.Value = Now.Date
        End If
    End Sub

#End Region

    Private Sub Bt1Generar_Click(sender As Object, e As ClickEventArgs) Handles Bt1Generar.Click
        P_GenerarReporte()
    End Sub

    Private Sub Bt2Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bt2Cancelar.Click
        P_Cancelar()
    End Sub
End Class