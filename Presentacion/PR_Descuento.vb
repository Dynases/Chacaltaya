Imports DevComponents.DotNetBar
Imports Logica.AccesoLogica
Public Class PR_Descuento

    Dim numitc2 As Integer

#Region "Metodos privados"
    Private Sub _prInicio()
        Me.Text = "R E P O R T E S  D E  B O N O S   Y   D E SC U E N T O S ".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        txtAño.Text = ""


        _PCargarComboLibreria()

    End Sub
    Private Sub _PCargarComboLibreria()
        Dim dt As New DataTable
        dt.Columns.Add("numi", GetType(Integer))
        dt.Columns.Add("desc", GetType(String))

        dt.Rows.Add(1, "ENERO")
        dt.Rows.Add(2, "FEBRERO")
        dt.Rows.Add(3, "MARZO")
        dt.Rows.Add(4, "ABRIL")
        dt.Rows.Add(5, "MAYO")
        dt.Rows.Add(6, "JUNIO")
        dt.Rows.Add(7, "JULIO")
        dt.Rows.Add(8, "AGOSTO")
        dt.Rows.Add(9, "SEPTIEMBRE")
        dt.Rows.Add(10, "OCTUBRE")
        dt.Rows.Add(11, "NOVIEMBRE")
        dt.Rows.Add(12, "DICIEMBRE")

        Dim dtTip As New DataTable
        dtTip.Columns.Add("numi", GetType(Integer))
        dtTip.Columns.Add("desc", GetType(String))
        dtTip.Rows.Add(1, "MULTA")
        dtTip.Rows.Add(2, "BONO")
        dtTip.Rows.Add(3, "DESCUENTO")
        'dtTip.Rows.Add(4, "TODOS LOS TIPOS")

        cbTipo.DropDownList.Columns.Clear()

        cbTipo.DropDownList.Columns.Add(dtTip.Columns("numi").ToString).Width = 50
        cbTipo.DropDownList.Columns(0).Caption = "Código"
        cbTipo.DropDownList.Columns.Add(dtTip.Columns("desc").ToString).Width = 250
        cbTipo.DropDownList.Columns(1).Caption = "Descripcion"

        cbTipo.ValueMember = dtTip.Columns("numi").ToString
        cbTipo.DisplayMember = dtTip.Columns("desc").ToString
        cbTipo.DataSource = dtTip
        cbTipo.Refresh()

        cbMes.DropDownList.Columns.Clear()

        cbMes.DropDownList.Columns.Add(dt.Columns("numi").ToString).Width = 50
        cbMes.DropDownList.Columns(0).Caption = "Código"
        cbMes.DropDownList.Columns.Add(dt.Columns("desc").ToString).Width = 250
        cbMes.DropDownList.Columns(1).Caption = "Descripcion"

        cbMes.ValueMember = dt.Columns("numi").ToString
        cbMes.DisplayMember = dt.Columns("desc").ToString
        cbMes.DataSource = dt
        cbMes.Refresh()

    End Sub

    Private Sub _prCargarReporte()
        If txtAño.Text <> Nothing And cbMes.Value <> Nothing Then
            Dim _dt As New DataTable
            Dim objrep1 As New R_BonosDesc()
            If swTodos.Value = False Then


                _dt = L_fnListarBonosYDescuentos(1, txtAño.Text, cbMes.Value, cbTipo.Value)

            Else
                _dt = L_fnListarBonosYDescuentosPorEmpleado(3, txtAño.Text, cbMes.Value, cbTipo.Value, numitc2)

            End If

            If _dt.Rows.Count > 0 Then
                objrep1.SetDataSource(_dt)
                Crv.ReportSource = objrep1

            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.INFORMATION, 2000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
                Crv.ReportSource = Nothing
            End If

        ElseIf txtAño.Text = "" Then
            txtAño.BackColor = Color.Red
            ToastNotification.Show(Me, "Campos obligatorio." + txtAño.Text.ToUpper,
                                      My.Resources.WARNING, 2000,
                                      eToastGlowColor.Red,
                                      eToastPosition.TopCenter
                                      )
        ElseIf cbMes.Value = "" Then
            cbMes.BackColor = Color.Red
            ToastNotification.Show(Me, "Campo obligatorio." + cbMes.Text.ToUpper,
                                      My.Resources.WARNING, 2000,
                                      eToastGlowColor.Red,
                                      eToastPosition.TopCenter
                                      )

        End If

    End Sub
#End Region

    Private Sub PR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub swZona_ValueChanged(sender As Object, e As EventArgs)
        'txtAño.Enabled = swZona.Value
        'txtMes.Enabled = swZona.Value
    End Sub

    Private Sub swCategoria_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbZonaCod_KeyDown(sender As Object, e As KeyEventArgs)
        'If e.KeyData = Keys.Control + Keys.Enter Then
        '    Dim frmAyuda As Modelos.ModeloAyuda
        '    Dim dt As DataTable = L_ZonaCabecera_GeneralCompleto1(0).Tables(0)
        '    Dim listEstCeldas As New List(Of Modelos.Celda)
        '    listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
        '    listEstCeldas.Add(New Modelos.Celda(False))
        '    listEstCeldas.Add(New Modelos.Celda(True, "Ciudad", 100))
        '    listEstCeldas.Add(New Modelos.Celda(False))
        '    listEstCeldas.Add(New Modelos.Celda(True, "Provincia", 100))
        '    listEstCeldas.Add(New Modelos.Celda(False))
        '    listEstCeldas.Add(New Modelos.Celda(True, "Zona", 100))
        '    listEstCeldas.Add(New Modelos.Celda(False))

        '    frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione concepto".ToUpper, listEstCeldas)
        '    frmAyuda.ShowDialog()

        '    If frmAyuda.seleccionado = True Then
        '        Dim id As String = frmAyuda.filaSelect.Cells("lanumi").Value
        '        Dim descr As String = frmAyuda.filaSelect.Cells("cedesc2").Value

        '        txtAño.Text = id
        '        txtMes.Text = descr
        '    End If

        'End If
    End Sub

    Private Sub tbCatId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpleados.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            Dim frmAyuda As Modelos.ModeloAyuda
            Dim dt As DataTable = L_fnListarEmpleados()
            Dim listEstCeldas As New List(Of Modelos.Celda)
            listEstCeldas.Add(New Modelos.Celda(True, "Id", 70))
            listEstCeldas.Add(New Modelos.Celda(True, "Nombre", 200))
            'listEstCeldas.Add(New Modelos.Celda(True, "Descripcion", 150))

            frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione el personal".ToUpper, listEstCeldas)
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim id As String = frmAyuda.filaSelect.Cells("cbnumi").Value
                Dim nom As String = frmAyuda.filaSelect.Cells("cbdesc").Value
                'Dim descr As String = frmAyuda.filaSelect.Cells("cidesc").Value

                numitc2 = id
                txtEmpleados.Text = nom
                'txtEmpleados.Text = descr
            End If

        End If
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub

    Private Sub swTodos_ValueChanged(sender As Object, e As EventArgs) Handles swTodos.ValueChanged

        txtEmpleados.Enabled = swTodos.Value
    End Sub

    Private Sub cbMes_ValueChanged(sender As Object, e As EventArgs) Handles cbMes.ValueChanged
        If cbMes.Value <> Nothing Then
            cbMes.BackColor = Color.White
        End If

    End Sub
End Class