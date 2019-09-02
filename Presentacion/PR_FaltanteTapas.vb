Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_FaltanteTapas

#Region "Variables Globales"

    Dim InDuracion As Byte = 5

#End Region

#Region "Eventos"

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub


    Private Sub TbCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TbCodigo.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prCargarAyudaCliente()
        End If
    End Sub

    Private Sub BtBuscarCliente_Click_1(sender As Object, e As EventArgs) Handles BtBuscarCliente.Click
        P_prCargarAyudaCliente()
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        P_prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        'L_prAbrirConexion()

        Me.Text = "F A L T A N T E   T A P A S".ToUpper
        Me.WindowState = FormWindowState.Maximized
        CrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        TbCodigo.ReadOnly = True
        TbDescripcion.ReadOnly = True

        TbCodigo.Text = "0"
        TbDescripcion.Text = "TODOS"

        DtiDesde.Value = Now.Date
        DtiHasta.Value = Now.Date

        RbTodo.Checked = True
    End Sub

    Private Sub P_prCargarReporte()
        If (P_fnValidar()) Then
            Dim dt As New DataTable
            Dim criterio As String = ""

            If (RbTodo.Checked) Then
                criterio = ""
            ElseIf (RbDistintoCero.Checked) Then
                criterio = " and tapas<>0 "
            ElseIf (RbPositivo.Checked) Then
                criterio = " and tapas>0 "
            ElseIf (RbNegativo.Checked) Then
                criterio = " and tapas<0 "
            End If

            dt = L_VistaFaltanteTapas(DtiDesde.Value.ToString("yyyy/MM/dd"), DtiHasta.Value.ToString("yyyy/MM/dd"), TbCodigo.Text, criterio)

            If (dt.Rows.Count > 0) Then
                Dim objrep As New R_FaltanteTapas

                objrep.SetDataSource(dt)

                objrep.SetParameterValue("FechaIni", DtiDesde.Value.ToString("dd/MM/yyyy"))
                objrep.SetParameterValue("FechaFin", DtiHasta.Value.ToString("dd/MM/yyyy"))
                objrep.SetParameterValue("Filtro", IIf(TbCodigo.Text.Trim.Equals("0"), "TODOS", ""))

                CrReporte.ReportSource = objrep
                CrReporte.Show()
                CrReporte.BringToFront()
            Else
                ToastNotification.Show(Me, "no hay datos para los parametros seleccionados.".ToUpper,
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
                CrReporte.ReportSource = Nothing
            End If
        End If
    End Sub

    Private Sub P_prCargarAyudaCliente()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_Empleado_GeneralSimple(1, " AND cbest=1").Tables(0)
        Dim row As DataRow = dt.NewRow
        row.Item(0) = 0
        row.Item(1) = "TODOS"
        dt.Rows.InsertAt(row, 0)
        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Código", 80))
        listEstCeldas.Add(New Modelos.Celda(True, "Nombres y Apellidos", 300)) 'cbnumi,cbdesc

        frmAyuda = New Modelos.ModeloAyuda(400, 400, dt, "Seleccione un repartidor".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            TbCodigo.Text = frmAyuda.filaSelect.Cells("cbnumi").Value
            TbDescripcion.Text = frmAyuda.filaSelect.Cells("cbdesc").Value.ToString
        End If
    End Sub

#End Region

    Private Function P_fnValidar() As Boolean
        Dim sms As String = ""

        If (TbCodigo.Text.Trim = String.Empty) Then
            sms = "Para generar el reporte debe elegir un repartidor".ToUpper
        End If

        If (DtiHasta.Value > Now.Date) Then
            If (sms = String.Empty) Then
                sms = "La fecha hasta tiene que ser menor o igual a la fecha actual.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha hasta tiene que ser menor o igual a la fecha actual.".ToUpper
            End If
        End If

        If (DtiDesde.Value > DtiHasta.Value) Then
            If (sms = String.Empty) Then
                sms = "La fecha desde tiene que ser menor o igual a l afecha hasta.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha desde tiene que ser menor o igual a la fecha hasta.".ToUpper
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   sms.ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return (sms = String.Empty)
    End Function

End Class