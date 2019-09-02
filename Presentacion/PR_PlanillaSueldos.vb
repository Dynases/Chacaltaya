Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_PlanillaSueldos

#Region "Atributos"
    Private _dtR As New DataTable
#End Region

#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "G E N E R A C I O N    D E    P L A N I L L A    D E    S U E L D O S"
        Me.WindowState = FormWindowState.Maximized

        Dim mes As Integer = Now.Month
        Dim anio As Integer = Now.Year
        tbMes.Text = mes
        tbAnio.Text = anio

        _PCargarComboEmpleados()

        JMc_Persona.Enabled = False

        tbAnio.Value = Now.Year
        tbMes.Value = Now.Month
    End Sub
    Private Sub _prReporteResumenTodos()
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldosResumen

        Dim dt As New DataTable
        'Dim da As New SqlDataAdapter("PlanillaSueldo", "Data Source=localhost; Initial Catalog=BDDist;Integrated Security= True")
        'da.SelectCommand.CommandType = CommandType.StoredProcedure
        'da.Fill(dt)
        dt = L_PAPlanillaSueldos(New Date(tbAnio.Value, tbMes.Value, 1).ToString("yyyy/MM/dd")) ', IIf(tbPlanilla.Value = True, 1, 0)
        objrep.SetDataSource(dt)
        
        '_Ds = L_Vista_PlanillaSueldos(0)

        'objrep.SetDataSource(_Ds.Tables(0))
        Dim mes As Integer = tbMes.Value
        Dim anio As Integer = tbAnio.Value
        'mes = IIf(mes = 1, 12, mes - 1)
        'anio = IIf(mes = 12, anio - 1, anio)
        objrep.SetParameterValue("@fecha", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))
        objrep.SetParameterValue("Periodo", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))

        CrystalReportViewer1.ReportSource = objrep
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

    End Sub
    Private Sub _PCargarReporte(codPer As Integer)
        Dim _Ds As New DataSet

        Dim objrep As New R_PlanillaSueldo

        ''Dim _dtR As New DataTable

        _dtR = L_PAPlanillaSueldos(New Date(tbAnio.Value, tbMes.Value, 1).ToString("yyyy/MM/dd")) ', IIf(tbPlanilla.Value = True, 1, 0)

        If _dtR.Rows.Count = 0 Then
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.INFORMATION, 3000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            CrystalReportViewer1.ReportSource = Nothing
            _dtR.Rows.Clear()
            Exit Sub
        End If


        If codPer > 0 Then
            _dtR.Select("codPer=" + Str(codPer))

            Dim rows As DataRow()

            Dim _dtRNew As DataTable

            ' copy table structure
            _dtRNew = _dtR.Clone()

            ' sort and filter data
            rows = _dtR.Select("codPer=" + Str(codPer))

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
        objrep.SetParameterValue("@fecha", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))
        objrep.SetParameterValue("Periodo", New Date(anio, mes, 1).ToString("yyyy/MM/dd"))

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

    Private Sub _prGrabarPlanilla()


        If _dtR.Rows.Count = 0 Then '_dtR.Rows.Count = 0
            ToastNotification.Show(Me, "debe generar primero una planilla..!!!".ToUpper,
                                                       My.Resources.INFORMATION, 3000,
                                                       eToastGlowColor.Blue,
                                                       eToastPosition.BottomLeft)
        Else
            If Sw_Filtrar.Value = True Then 'significa que esta filtrando por empleado
                If _prVerficarExistenciaRegistro(JMc_Persona.Value, tbMes.Value, tbAnio.Text) Then
                    Dim info As New TaskDialogInfo("planilla existente".ToUpper, eTaskDialogIcon.Delete, "¿Desea eliminar las planillas ya grabadas del mes " + tbMes.Text + "/" + tbAnio.Text + " del personal " + JMc_Persona.Text.ToUpper + "?", "Ya existen la planilla del personal en el mes y año mencionado", eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    If result = eTaskDialogResult.Yes Then
                        L_prPlanillaSueldoEliminarPorNumiPersonalMesAnio(JMc_Persona.Value, tbMes.Value, tbAnio.Value)
                    Else
                        Exit Sub
                    End If
                End If
            Else
                If L_prPlanillaSueldoVerificarExistenciaReg2(tbMes.Text, tbAnio.Text).Rows.Count > 0 Then
                    Dim info As New TaskDialogInfo("planilla existente".ToUpper, eTaskDialogIcon.Delete, "¿Desea eliminar las planillas ya grabadas del mes " + tbMes.Text + "/" + tbAnio.Text + "?".ToUpper, "Ya existen planillas en el mes y año mencionado", eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    If result = eTaskDialogResult.Yes Then
                        L_prPlanillaSueldoEliminarPorMesYAnio(tbMes.Value, tbAnio.Value)
                    Else
                        Exit Sub
                    End If
                End If

                
            End If



            Dim dt As DataTable
            Dim dtDetalle As DataTable = L_prPlanillaSueldoGetDetalle(-1)

            If Sw_Filtrar.Value = True And JMc_Persona.SelectedIndex >= 0 Then
                Dim rows As DataRow()
                rows = _dtR.Select("codPer=" + Str(JMc_Persona.Value))
                dt = rows.CopyToDataTable
            Else
                Dim foundRows As DataRow() = _dtR.Select("1=1", "codPer ASC")
                dt = foundRows.CopyToDataTable()
            End If

            'recorro toda la tabla para ir preparando las tablas de insercion
            Dim codPer, mes, anio, concepto, concepto2, desc, monto, numiBonoDesc As String
            mes = tbMes.Text
            anio = tbAnio.Text
            codPer = dt.Rows(0).Item("codPer")
            For Each fila As DataRow In dt.Rows

                If codPer <> fila.Item("codPer") Then 'realizar la grabacion de la cabecera y detalle
                    If _prVerficarExistenciaRegistro(codPer, mes, anio) = False Then
                        L_prPlanillaSueldoGrabar(codPer, mes, anio, dtDetalle)

                        ToastNotification.Show(Me, "se grabo correctamente la planilla generada".ToUpper,
                                                       My.Resources.GRABACION_EXITOSA, 3000,
                                                       eToastGlowColor.Green,
                                                       eToastPosition.BottomLeft)
                        
                    End If
                    dtDetalle.Rows.Clear()
                Else 'insertar al detalle

                End If

                concepto = fila.Item("orden")
                monto = fila.Item("pavalor")
                If concepto = -1 Then
                    monto = fila.Item("cbsal")
                End If
                If concepto = 0 Then
                    monto = fila.Item("TotalMulBon")
                End If

                If concepto = 3 Or concepto = 1 Then
                    numiBonoDesc = fila.Item("pcnumi")
                    desc = fila.Item("pcobs")
                    monto = fila.Item("TotalMulBon")
                Else
                    numiBonoDesc = 0
                    desc = fila.Item("paobs")
                End If
                If concepto >= 2 Then 'egreso
                    concepto2 = 2
                Else
                    concepto2 = 1 'ingreso
                End If
                'plline,plnumi,plcon,pldesc,plmonto,plnumibd,1 as estado
                dtDetalle.Rows.Add(0, 0, concepto2, desc, monto, numiBonoDesc, 1)

                codPer = fila.Item("codPer")
            Next
            'grabo el ultimo que no pude grabar en el foreach
            If _prVerficarExistenciaRegistro(codPer, mes, anio) = False Then
                L_prPlanillaSueldoGrabar(codPer, mes, anio, dtDetalle)

                ToastNotification.Show(Me, "se grabo correctamente la planilla generada".ToUpper,
                                               My.Resources.GRABACION_EXITOSA, 3000,
                                               eToastGlowColor.Green,
                                               eToastPosition.BottomLeft)
            End If


        End If
    End Sub

    Private Function _prVerficarExistenciaRegistro(numiPer As String, mes As String, anio As String)
        Dim dt As DataTable = L_prPlanillaSueldoVerificarExistenciaReg(numiPer, mes, anio)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
#End Region
    Private Sub PR_PlanillaSueldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles Sw_Filtrar.ValueChanged
        CrystalReportViewer1.ReportSource = Nothing
        _dtR.Rows.Clear()
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        _prReporteResumenTodos()
    End Sub

    Private Sub BubbleButton2_Click(sender As Object, e As ClickEventArgs) Handles BubbleButton2.Click
        _prGrabarPlanilla()
    End Sub

    Private Sub JMc_Persona_ValueChanged(sender As Object, e As EventArgs) Handles JMc_Persona.ValueChanged
        If JMc_Persona.SelectedIndex > 0 Then
            CrystalReportViewer1.ReportSource = Nothing
            _dtR.Rows.Clear()
        End If

    End Sub

    Private Sub tbAnio_ValueChanged(sender As Object, e As EventArgs) Handles tbAnio.ValueChanged
        CrystalReportViewer1.ReportSource = Nothing
        _dtR.Rows.Clear()
    End Sub

    Private Sub tbMes_ValueChanged(sender As Object, e As EventArgs) Handles tbMes.ValueChanged
        CrystalReportViewer1.ReportSource = Nothing
        _dtR.Rows.Clear()
    End Sub
End Class