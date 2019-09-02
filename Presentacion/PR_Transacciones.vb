Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_Transacciones

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "R E P O R T E    D E    T R A N S A C C I O N E S"
        Me.WindowState = FormWindowState.Maximized

        _PCargarComboZonas()

        JMc_Usuario.Enabled = False

        Tb_FechaDel.Value = Now.Date
        Tb_FechaAl.Value = Now.Date
    End Sub
    Private Sub _PCargarReporte()
        Dim _Dt As New DataTable

        Dim objrep As New R_Transacciones
        Dim where As String = " fdoc>='" + Tb_FechaDel.Value.Date.ToString("yyyy/MM/dd") + _
                              "' AND fdoc<='" + Tb_FechaAl.Value.Date.ToString("yyyy/MM/dd") + "' "

        If Sw_Filtrar.Value = True Then
            If JMc_Usuario.SelectedIndex >= 0 Then
                where = where + " AND uact='" + JMc_Usuario.Text + "'"
            Else
                ToastNotification.Show(Me, "SELECCIONE ALGUN USUARIO", My.Resources._ERROR, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
                CrystalReportViewer1.ReportSource = Nothing
                Exit Sub
            End If
        End If


        _Dt = L_VistaTransacciones(where)


        objrep.SetDataSource(_Dt)

        objrep.SetParameterValue("Param_Al", Tb_FechaAl.Value.ToShortDateString)
        objrep.SetParameterValue("Param_Del", Tb_FechaDel.Value.ToShortDateString)

        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub

    Private Sub _PCargarComboZonas()
        Dim _Ds As New DataSet
        _Ds = L_Usuario_General(0)

        JMc_Usuario.DropDownList.Columns.Clear()

        JMc_Usuario.DropDownList.Columns.Add(_Ds.Tables(0).Columns("ydnumi").ToString).Width = 50
        JMc_Usuario.DropDownList.Columns(0).Caption = "Código"
        JMc_Usuario.DropDownList.Columns.Add(_Ds.Tables(0).Columns("yduser").ToString).Width = 100
        JMc_Usuario.DropDownList.Columns(1).Caption = "usuario"

        JMc_Usuario.ValueMember = _Ds.Tables(0).Columns("yduser").ToString
        JMc_Usuario.DisplayMember = _Ds.Tables(0).Columns("yduser").ToString
        JMc_Usuario.DataSource = _Ds.Tables(0)
        JMc_Usuario.Refresh()
    End Sub
#End Region

    Private Sub PR_Transacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub BubbleButton7_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton7.Click
        _PCargarReporte()
    End Sub

    Private Sub Sw_Filtrar_ValueChanged(sender As Object, e As EventArgs) Handles Sw_Filtrar.ValueChanged
        JMc_Usuario.Enabled = Sw_Filtrar.Value
    End Sub

    Private Sub BubbleButton5_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton5.Click
        Me.Close()
    End Sub
End Class