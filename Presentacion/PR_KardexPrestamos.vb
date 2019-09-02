Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_KardexPrestamos
#Region "Metodos privados"
    Private Sub _prInicio()

        Me.Text = "kardex de prestamos".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        Dtp_FechaIni.Text = Now.Date
        Dtp_FechaFin.Text = Now.Date

        tbCliCod.Enabled = False
        tbCliNombre.Enabled = False
        tbZonaCod.Enabled = False
        tbZonaDesc.Enabled = False
        btBuscarCliente.Enabled = False
        btBuscarZona.Enabled = False

        tbConCod.ReadOnly = True
        tbConDesc.ReadOnly = True
        tbCliCod.ReadOnly = True
        tbConDesc.ReadOnly = True
        tbZonaCod.ReadOnly = True
        tbZonaDesc.ReadOnly = True

    End Sub

    Private Function _prValidar() As Boolean
        Dim _Error As Boolean = True
        If tbConCod.Text = "" Then
            ToastNotification.Show(Me, "seleccione concepto",
                                       My.Resources.WARNING, 1000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            _Error = False
        End If

        Return _Error
    End Function
    Private Sub _prCargarReporte()
        If _prValidar() = False Then
            Exit Sub
        End If

        Dim _Ds As New DataSet
        Dim where As String = " chtmov=" + tbConCod.Text
        If swCliente.Value Then
            where = where + " and chnumi=" + tbCliCod.Text
        End If

        If swZona.Value Then
            where = where + " and cczona=" + tbZonaCod.Text
        End If

        _Ds = L_VistaKardexPrestamos(Dtp_FechaIni.Value.ToString("yyyy/MM/dd"), Dtp_FechaFin.Value.ToString("yyyy/MM/dd"), where)
        If (_Ds.Tables(0).Rows.Count > 0) Then
            Dim objrep As New R_KardexPrestamos

            objrep.SetDataSource(_Ds.Tables(0))

            objrep.SetParameterValue("Param_Del", Dtp_FechaIni.Value.ToShortDateString)
            objrep.SetParameterValue("Param_Al", Dtp_FechaFin.Value.ToShortDateString)

            Crv.ReportSource = objrep
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

    Private Sub _prCargarAyudaConcepto()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_GetTabla("TCI001", "cpnumi, cpdesc", "cptipo=1 and cpest=1") 'L_LibreriaGeneral(10).Tables(0)
        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
        listEstCeldas.Add(New Modelos.Celda(True, "Descripcion", 200))

        frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione concepto".ToUpper, listEstCeldas)
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("cpnumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("cpdesc").Value

            tbConCod.Text = id
            tbConDesc.Text = descr
        End If
    End Sub

    Private Sub _prCargarAyudaCliente()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_GetClientesSimple2().Tables(0)
        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
        listEstCeldas.Add(New Modelos.Celda(True, "CI", 100))
        listEstCeldas.Add(New Modelos.Celda(True, "Nombre", 150))
        listEstCeldas.Add(New Modelos.Celda(True, "Direccion", 150))

        frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione concepto".ToUpper, listEstCeldas)
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("ccnumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("ccdesc").Value

            tbCliCod.Text = id
            tbCliNombre.Text = descr
        End If
    End Sub

    Private Sub _prCargarAyudaZona()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_ZonaCabecera_GeneralCompleto1(0).Tables(0)
        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 70))
        listEstCeldas.Add(New Modelos.Celda(False))
        listEstCeldas.Add(New Modelos.Celda(True, "Ciudad", 100))
        listEstCeldas.Add(New Modelos.Celda(False))
        listEstCeldas.Add(New Modelos.Celda(True, "Provincia", 100))
        listEstCeldas.Add(New Modelos.Celda(False))
        listEstCeldas.Add(New Modelos.Celda(True, "Zona", 100))
        listEstCeldas.Add(New Modelos.Celda(False))

        frmAyuda = New Modelos.ModeloAyuda(600, 300, dt, "Seleccione concepto".ToUpper, listEstCeldas)
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("lanumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("cedesc2").Value

            tbZonaCod.Text = id
            tbZonaDesc.Text = descr
        End If
    End Sub
#End Region

    Private Sub Gp_Fechas_Click(sender As Object, e As EventArgs) Handles Gp_Fechas.Click

    End Sub

    Private Sub swCliente_ValueChanged(sender As Object, e As EventArgs) Handles swCliente.ValueChanged
        tbCliCod.Enabled = swCliente.Value
        tbCliNombre.Enabled = swCliente.Value
        btBuscarCliente.Enabled = swCliente.Value
    End Sub

    Private Sub swZona_ValueChanged(sender As Object, e As EventArgs) Handles swZona.ValueChanged
        tbZonaCod.Enabled = swZona.Value
        tbZonaDesc.Enabled = swZona.Value
        btBuscarZona.Enabled = swZona.Value
    End Sub

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub tbConCod_KeyDown(sender As Object, e As KeyEventArgs) Handles tbConCod.KeyDown, tbConDesc.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prCargarAyudaConcepto()
        End If
    End Sub

    Private Sub tbCliCod_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCliCod.KeyDown, tbCliNombre.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prCargarAyudaCliente()
        End If
    End Sub

    Private Sub tbZonaCod_KeyDown(sender As Object, e As KeyEventArgs) Handles tbZonaCod.KeyDown, tbZonaDesc.KeyDown
        If e.KeyData = Keys.Control + Keys.Enter Then
            _prCargarAyudaZona()
        End If
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub btBuscarConcepto_Click(sender As Object, e As EventArgs) Handles btBuscarConcepto.Click
        _prCargarAyudaConcepto()
    End Sub

    Private Sub btBuscarCliente_Click(sender As Object, e As EventArgs) Handles btBuscarCliente.Click
        _prCargarAyudaCliente()
    End Sub

    Private Sub btBuscarZona_Click(sender As Object, e As EventArgs) Handles btBuscarZona.Click
        _prCargarAyudaZona()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Me.Close()
    End Sub
End Class