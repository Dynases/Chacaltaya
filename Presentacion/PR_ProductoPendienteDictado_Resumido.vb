Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_ProductoPendienteDictado_Resumido

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

        Me.Text = "Producto pendiente/dictado por entregar".ToUpper

        dtDesde.Value = Now.Date
        dtHasta.Value = Now.Date
        btPendienteDictado.Value = True

    End Sub

    Private Sub P_GenerarReporte()
        If (dtDesde.Value <= dtHasta.Value) Then
            Dim dt As DataTable
            dt = L_GetTabla("vr_go_productoPendienteDictado_Resumido",
                            "*",
                            "fdoc>='" + dtDesde.Value.ToString("yyyy/MM/dd") _
                            + "' and fdoc<='" + dtHasta.Value.ToString("yyyy/MM/dd") + "'" _
                            + " and est=" + IIf(btPendienteDictado.Value, "1", "2"))

            If (dt.Rows.Count > 0) Then
                Dim objrep As New R_ProductoPendienteDictado_Resumido

                objrep.SetDataSource(dt)

                objrep.SetParameterValue("tipo", IIf(btPendienteDictado.Value, "PENDIENTES", "DISTADOS"))
                objrep.SetParameterValue("fechaIni", dtDesde.Value.Date.ToShortDateString)
                objrep.SetParameterValue("fechaFin", dtHasta.Value.Date.ToShortDateString)

                crReporte.ReportSource = objrep

                crReporte.Show()
                crReporte.BringToFront()
            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            End If
        Else
            ToastNotification.Show(Me, "LA FECHA ''DESDE  TIENE QUE SER MENOR O IGUAL A LA FECHA ''HASTA''..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_Cancelar()
        dtDesde.Value = Now.Date
        dtHasta.Value = Now.Date
        btPendienteDictado.Value = True
    End Sub

#End Region

    Private Sub btGenerar_Click(sender As Object, e As ClickEventArgs) Handles btGenerar.Click
        P_GenerarReporte()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As ClickEventArgs) Handles btCancelar.Click
        P_Cancelar()
    End Sub

End Class