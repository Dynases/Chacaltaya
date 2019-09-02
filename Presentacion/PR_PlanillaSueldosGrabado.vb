Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_PlanillaSueldosGrabado


#Region "Atributos"
    Private _dtR As New DataTable
#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "H I S T O R I A L    D E    P L A N I L L A    D E    S U E L D O S"
        Me.WindowState = FormWindowState.Maximized

        Dim mes As Integer = Now.Month
        Dim anio As Integer = Now.Year
        tbMes.Text = mes
        tbAnio.Text = anio

        _PCargarComboEmpleados()

        JMc_Persona.Enabled = False
    End Sub
    Private Sub _prReporteResumenTodos()
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldosResumenGrabado

        Dim dt As New DataTable
        'Dim da As New SqlDataAdapter("PlanillaSueldo", "Data Source=localhost; Initial Catalog=BDDist;Integrated Security= True")
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        'da.Fill(dt)
        dt = L_PAPlanillaSueldosGrabados(tbAnio.Value, tbMes.Value, IIf(tbPlanilla.Value = True, 1, 0))
        objrep.SetDataSource(dt)

        '_Ds = L_Vista_PlanillaSueldos(0)

        'objrep.SetDataSource(_Ds.Tables(0))
        Dim mes As Integer = tbMes.Value
        Dim anio As Integer = tbAnio.Value
        'mes = IIf(mes = 1, 12, mes - 1)
        'anio = IIf(mes = 12, anio - 1, anio)
        'objrep.SetParameterValue("@fecha", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))
        objrep.SetParameterValue("periodo", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))

        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub
    Private Sub _PCargarReporte(codPer As Integer)
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldoGrabado

        ''Dim _dtR As New DataTable

        _dtR = L_PAPlanillaSueldosGrabados(tbAnio.Value, tbMes.Value, IIf(tbPlanilla.Value = True, 1, 0))

        If _dtR.Rows.Count = 0 Then
            ToastNotification.Show(Me, "no existe planilla grabada en este mes y año..!!!".ToUpper,
                                           My.Resources.INFORMATION, 3000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            CrystalReportViewer1.ReportSource = Nothing
            Exit Sub
        End If


        If codPer > 0 Then
            _dtR.Select("pkper=" + Str(codPer))

            Dim rows As DataRow()

            Dim _dtRNew As DataTable

            ' copy table structure
            _dtRNew = _dtR.Clone()

            ' sort and filter data
            rows = _dtR.Select("pkper=" + Str(codPer))

            ' fill _dtRNew with selected rows

            For Each dr As DataRow In rows
                _dtRNew.ImportRow(dr)
            Next
            objrep.SetDataSource(_dtRNew)
        Else
            objrep.SetDataSource(_dtR)
        End If

        '_Ds = L_Vista_PlanillaSueldos(0)

        'objrep.SetDataSource(_Ds.Tables(0))
        Dim mes As Integer = tbMes.Value
        Dim anio As Integer = tbAnio.Value
        'mes = IIf(mes = 1, 12, mes - 1)
        'anio = IIf(mes = 12, anio - 1, anio)
        'objrep.SetParameterValue("@fecha", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))
        objrep.SetParameterValue("periodo", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))

        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub

    Private Sub _PCargarComboEmpleados()
        Dim _Ds As New DataSet
        _Ds = L_Empleado_General(-1, " AND cbest=1 AND cbplan=1")

        JMc_Persona.DropDownList.Columns.Clear()

        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbnumi").ToString).Width = 50
        JMc_Persona.DropDownList.Columns(0).Caption = "Código"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbci").ToString).Width = 70
        JMc_Persona.DropDownList.Columns(1).Caption = "CI"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbdesc").ToString).Width = 250
        JMc_Persona.DropDownList.Columns(2).Caption = "Descripcion"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbsal").ToString).Width = 100
        JMc_Persona.DropDownList.Columns(3).Caption = "Salario"

        JMc_Persona.ValueMember = _Ds.Tables(0).Columns("cbnumi").ToString
        JMc_Persona.DisplayMember = _Ds.Tables(0).Columns("cbdesc").ToString
        JMc_Persona.DataSource = _Ds.Tables(0)
        JMc_Persona.Refresh()
    End Sub

    
#End Region
    Private Sub PR_PlanillaSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles Sw_Filtrar.ValueChanged

        JMc_Persona.Enabled = Sw_Filtrar.Value

    End Sub

    Private Sub BubbleButton7_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton7.Click
        If Sw_Filtrar.Value = True Then
            If JMc_Persona.SelectedIndex >= 0 Then
                Dim codPer As Integer
                codPer = JMc_Persona.Value
                _PCargarReporte(codPer)
            Else
                ToastNotification.Show(Me, "SELECCIONE ALGUN EMPLEADO", My.Resources._ERROR, 5000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            End If

        Else
            _PCargarReporte(0)
        End If

    End Sub

    Private Sub BubbleButton5_Click(sender As Object, e As ClickEventArgs) Handles BubbleButton5.Click
        Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        _prReporteResumenTodos()
    End Sub

    
End Class