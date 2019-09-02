Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_Reclamos

#Region "Atributos"

#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "R E P O R T E    D E    R E C L A M O S"
        Me.WindowState = FormWindowState.Maximized

        _PCargarComboEmpleados()

        JMc_Persona.Enabled = False
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub
  
    Private Sub _PCargarReporte(codPer As Integer)


        Dim objrep As New R_Reclamos

        Dim dt As New DataTable

        If Sw_Filtrar.Value Then
            dt = L_PedidoReclamosVistaReporte(-1, tbDel.Value.ToString("yyyy/MM/dd"), tbAl.Value.ToString("yyyy/MM/dd"), JMc_Persona.Value)
        Else
            dt = L_PedidoReclamosVistaReporte(0, tbDel.Value.ToString("yyyy/MM/dd"), tbAl.Value.ToString("yyyy/MM/dd"))
        End If

        objrep.SetDataSource(dt)

        objrep.SetParameterValue("FechaIni", tbDel.Value.ToString("dd/MM/yyyy"))
        objrep.SetParameterValue("FechaFin", tbAl.Value.ToString("dd/MM/yyyy"))

        CrystalReportViewer1.ReportSource = objrep


    End Sub

    Private Sub _PCargarComboEmpleados()
        Dim _Ds As New DataSet
        _Ds = L_Empleado_General(-1, " AND cbest=1 and cbcat=1")

        JMc_Persona.DropDownList.Columns.Clear()

        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbnumi").ToString).Width = 50
        JMc_Persona.DropDownList.Columns(0).Caption = "Código"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbci").ToString).Width = 70
        JMc_Persona.DropDownList.Columns(1).Caption = "CI"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbdesc").ToString).Width = 250
        JMc_Persona.DropDownList.Columns(2).Caption = "Descripcion"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbsal").ToString).Width = 100
        JMc_Persona.DropDownList.Columns(3).Caption = "Salario"
        JMc_Persona.DropDownList.Columns(3).Visible = False

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

   
End Class