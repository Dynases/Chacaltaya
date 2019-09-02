Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_PrestamoEquipoDetallado

#Region "Variables Globales"



#End Region

#Region "Eventos"

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub


    Private Sub TbCodigoCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TbCodigoCliente.KeyDown
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

        Me.Text = "D E T A L L E   P R E S T A M O   D E   E Q U I P O S".ToUpper
        Me.WindowState = FormWindowState.Maximized
        CrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        TbCodigoCliente.ReadOnly = True
        TbNombreCliente.ReadOnly = True

        DtiDesde.IsInputReadOnly = True
        DtiDesde.ButtonDropDown.Enabled = False
        DtiHasta.IsInputReadOnly = True
        DtiHasta.ButtonDropDown.Enabled = False

        DtiDesde.Value = Now.Date
        DtiHasta.Value = Now.Date

    End Sub

    Private Sub P_prCargarReporte()
        Dim dt As New DataTable
        Dim cliente As String = ""
        'Filtro un cliente
        If (Not TbCodigoCliente.Text.Trim = String.Empty) Then
            'Se elijio un cliente
            cliente = TbNombreCliente.Text.Trim
            dt = L_VistaPrestamoEquiposDetalle(TbCodigoCliente.Text.Trim,
                                               IIf(SbFiltroFecha.Value, DtiDesde.Value.ToString("yyyy/MM/dd"), ""),
                                               IIf(SbFiltroFecha.Value, DtiHasta.Value.ToString("yyyy/MM/dd"), ""))
        Else
            'No ha eligido un cliente
            ToastNotification.Show(Me, "el código de cliente no es valido, coloque un código valido..".ToUpper,
                                   My.Resources.INFORMATION, 2000,
                                   eToastGlowColor.Blue,
                                   eToastPosition.BottomLeft)
            Exit Sub
        End If

        P_prQuitarProductosCompuesto(dt)

        If (dt.Rows.Count > 0) Then
            Dim objrep As New R_PrestamoEquiposDetallado

            objrep.SetDataSource(dt)

            objrep.SetParameterValue("FechaIni", IIf(SbFiltroFecha.Value, DtiDesde.Value.ToString("yyyy/MM/dd"), L_ObtenerDato("ccfecing", "TC004", "ccnumi=" + TbCodigoCliente.Text.Trim)))
            objrep.SetParameterValue("FechaFin", IIf(SbFiltroFecha.Value, DtiHasta.Value.ToString("yyyy/MM/dd"), Now.Date.ToString("dd/MM/yyyy")))

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
    End Sub

    Private Sub P_prCargarAyudaCliente()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_GetClientesSimple2().Tables(0)
        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 80))
        listEstCeldas.Add(New Modelos.Celda(True, "CI", 100))
        listEstCeldas.Add(New Modelos.Celda(True, "Nombre", 300))
        listEstCeldas.Add(New Modelos.Celda(True, "Direccion", 200))

        frmAyuda = New Modelos.ModeloAyuda(750, 400, dt, "Seleccione un cliente".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("ccnumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("ccdesc").Value

            TbCodigoCliente.Text = id
            TbNombreCliente.Text = descr
        End If
    End Sub

#End Region

    Private Sub P_prQuitarProductosCompuesto(ByRef dt As DataTable)

    End Sub

    Private Sub SbFiltroFecha_ValueChanged(sender As Object, e As EventArgs) Handles SbFiltroFecha.ValueChanged
        DtiDesde.IsInputReadOnly = Not SbFiltroFecha.Value
        DtiDesde.ButtonDropDown.Enabled = SbFiltroFecha.Value
        DtiHasta.IsInputReadOnly = Not SbFiltroFecha.Value
        DtiHasta.ButtonDropDown.Enabled = SbFiltroFecha.Value
        If (Not SbFiltroFecha.Value) Then
            DtiDesde.Value = Now.Date
            DtiHasta.Value = Now.Date
        End If
    End Sub

End Class