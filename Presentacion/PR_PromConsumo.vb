Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_PromConsumo

#Region "Atributos"

#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "P R O M E D I O    D E    C O N S U M O    D E     L O S     C L I E N T E S"
        Me.WindowState = FormWindowState.Maximized

        _PCargarComboZonas()

        JMc_Zonas.Enabled = False

        Tb_Fecha.Value = Now.Date
    End Sub
    Private Sub _PCargarReporte()
        Dim _Dt As New DataTable

        If IsNothing(Tb_dias.Text) Or IsNumeric(Tb_dias.Text) = False Or Tb_dias.Text = String.Empty Then
            ToastNotification.Show(Me, "Ingrese dias".ToUpper, My.Resources._ERROR, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            Exit Sub
        End If


        Dim objrep As New R_PromConsumo
        Dim where As String = "ccprconsu<=" + Tb_dias.Text
        If Sw_Filtrar.Value = True Then
            where = where + "AND cczona=" + JMc_Zonas.Value.ToString
        End If

        If Sw_IgualAFecha.Value = True Then
            where = where + " AND fTentativa='" + Tb_Fecha.Value.Date.ToString("yyyy/MM/dd") + "'"
        Else
            where = where + " AND fTentativa<='" + Tb_Fecha.Value.Date.ToString("yyyy/MM/dd") + "'"
        End If

        _Dt = L_VistaClientesPromedios2(where)


        objrep.SetDataSource(_Dt)

        objrep.SetParameterValue(0, Tb_Fecha.Value.ToShortDateString)
        objrep.SetParameterValue(1, IIf(JMc_Zonas.SelectedIndex >= 0, JMc_Zonas.Text, "TODAS"))

        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub

    Private Sub _PCargarComboZonas()
        Dim _Ds As New DataSet
        _Ds = L_ZonaCabecera_GeneralCompleto1(0)

        JMc_Zonas.DropDownList.Columns.Clear()

        JMc_Zonas.DropDownList.Columns.Add(_Ds.Tables(0).Columns("lanumi").ToString).Width = 50
        JMc_Zonas.DropDownList.Columns(0).Caption = "Código"
        JMc_Zonas.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc").ToString).Width = 100
        JMc_Zonas.DropDownList.Columns(1).Caption = "Ciudad"
        JMc_Zonas.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc1").ToString).Width = 100
        JMc_Zonas.DropDownList.Columns(2).Caption = "Provincia"
        JMc_Zonas.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc2").ToString).Width = 100
        JMc_Zonas.DropDownList.Columns(3).Caption = "Zona"

        JMc_Zonas.ValueMember = _Ds.Tables(0).Columns("lanumi").ToString
        JMc_Zonas.DisplayMember = _Ds.Tables(0).Columns("cedesc2").ToString
        JMc_Zonas.DataSource = _Ds.Tables(0)
        JMc_Zonas.Refresh()
    End Sub
#End Region

    Private Sub Sw_Filtrar_ValueChanged(sender As Object, e As EventArgs) Handles Sw_Filtrar.ValueChanged
        JMc_Zonas.Enabled = Sw_Filtrar.Value
    End Sub

    Private Sub BubbleButton7_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton7.Click
        If Sw_Filtrar.Value = True Then
            If JMc_Zonas.SelectedIndex >= 0 Then
                _PCargarReporte()
            Else
                ToastNotification.Show(Me, "SELECCIONE ALGUNA ZONA", My.Resources._ERROR, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            End If

        Else
            _PCargarReporte()
        End If
    End Sub

    Private Sub PR_PromConsumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub
End Class