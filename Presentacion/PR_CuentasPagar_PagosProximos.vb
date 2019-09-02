Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_CuentasPagar_PagosProximos

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

        'L_prAbrirConexion()

        DtiHasta.Value = Now.Date

        P_ArmarComboProveedor()

        GpProveedor.Enabled = False
    End Sub

    Private Sub P_ArmarComboProveedor()
        Dim DtNombre As DataTable
        DtNombre = L_fnCuentasPagarComboProveedor()
        With CbProveedor.DropDownList
            .Columns.Clear()

            .Columns.Add(DtNombre.Columns("cmnumi").ToString).Width = 60
            .Columns(0).Caption = "Código"
            .Columns(0).Visible = True

            .Columns.Add(DtNombre.Columns("cmdesc").ToString).Width = 200
            .Columns(1).Caption = "Nombre"
            .Columns(1).Visible = True

            .ValueMember = DtNombre.Columns("cmnumi").ToString
            .DisplayMember = DtNombre.Columns("cmdesc").ToString
            .DataSource = DtNombre
            .Refresh()
        End With

    End Sub

    Private Sub P_GenerarReporte()
        If (Not P_Validar) Then
            Exit Sub
        End If
        Dim Dt As DataTable
        Dim prov As String = ""
        If (SbTodosUno.Value) Then
            prov = CbProveedor.Value.ToString
        End If
        Dt = L_fnCuentasPagar_ReportePagosProximos(prov, DtiHasta.Value.ToString("yyyy/MM/dd"))

        If (Dt.Rows.Count > 0) Then
            Dim objrep As New R_CuentasPagar_PagosProximos
            objrep.SetDataSource(Dt)
            objrep.SetParameterValue("FechaFin", DtiHasta.Value.Date.ToShortDateString)

            Cr1Reporte.ReportSource = objrep
            Cr1Reporte.Show()
            Cr1Reporte.BringToFront()
        Else
            ToastNotification.Show(Me, "No hay pagos proximos para los criterios seleccionados.".ToUpper,
                                       My.Resources.INFORMATION, _DuracionSms * 1000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.TopCenter)
        End If
    End Sub

    Private Sub P_Cancelar()
        DtiHasta.Value = Now.Date
        SbTodosUno.Value = False
    End Sub

#End Region

    Private Sub Bt1Generar_Click(sender As Object, e As ClickEventArgs) Handles Bt1Generar.Click
        P_GenerarReporte()
    End Sub

    Private Sub Bt2Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bt2Cancelar.Click
        P_Cancelar()
    End Sub

    Private Sub SbTodosUno_ValueChanged(sender As Object, e As EventArgs) Handles SbTodosUno.ValueChanged
        GpProveedor.Enabled = SbTodosUno.Value
        CbProveedor.Clear()
    End Sub

    Private Function P_Validar() As Boolean
        Dim res As Boolean = True
        If (SbTodosUno.Value) Then
            If (Not IsNumeric(CbProveedor.Value)) Then
                ToastNotification.Show(Me, "Elija un proveedor valido.".ToUpper,
                                       My.Resources.WARNING, _DuracionSms * 1000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.TopCenter)
                Return False
            End If
        End If
        Return res
    End Function

    Private Sub CbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles CbProveedor.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prArmarAyudaProveedor()
        End If
    End Sub

    Private Sub P_prArmarAyudaProveedor()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_fnCuentasPagarComboProveedor()

        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 80))
        listEstCeldas.Add(New Modelos.Celda(True, "Nombre", 300))

        frmAyuda = New Modelos.ModeloAyuda(500, 400, dt, "Seleccione un proveedor".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("cmnumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("cmdesc").Value

            CbProveedor.Clear()
            CbProveedor.SelectedText = descr
        End If

    End Sub

End Class