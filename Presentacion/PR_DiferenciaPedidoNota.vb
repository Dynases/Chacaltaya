Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class PR_DiferenciaPedidoNota

#Region "Variables Globales"



#End Region

#Region "Eventos"

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub


    Private Sub TbCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TbCodigo.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prCargarAyuda(SbUsuarioRepartidor.Value)
        End If
    End Sub

    Private Sub BtBuscar_Click_1(sender As Object, e As EventArgs) Handles BtBuscar.Click
        P_prCargarAyuda(SbUsuarioRepartidor.Value)
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        P_prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Me.Close()
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

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        'L_prAbrirConexion()

        Me.Text = "D I F E R E N C I A   P E D I D O - N O T A".ToUpper
        Me.WindowState = FormWindowState.Maximized
        CrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        TbCodigo.ReadOnly = True
        TbCodigo.Text = "0"
        TbDescripcion.ReadOnly = True
        TbDescripcion.Text = "TODOS"

        DtiDesde.IsInputReadOnly = True
        DtiDesde.ButtonDropDown.Enabled = False
        DtiHasta.IsInputReadOnly = True
        DtiHasta.ButtonDropDown.Enabled = False

        DtiDesde.Value = Now.Date
        DtiHasta.Value = Now.Date

        RbDifNegativa.Checked = True

    End Sub

    Private Sub P_prCargarReporte()
        Dim dt As New DataTable
        'Filtro un cliente
        If (Not TbCodigo.Text.Trim = String.Empty) Then
            Dim usuario As String = ""
            Dim criterio As Byte = 0
            If (RbDifNegativa.Checked) Then
                criterio = 1
            ElseIf (RbDifPositiva.Checked) Then
                criterio = 2
            ElseIf (RbTodo.Checked) Then
                criterio = 3
            End If
            'Se elijio un cliente
            If (SbUsuarioRepartidor.Value) Then
                usuario = IIf(TbCodigo.Text.Trim.Equals("0"), "", TbCodigo.Text.Trim)
            Else
                usuario = IIf(TbCodigo.Text.Trim.Equals("0"), "", TbDescripcion.Text.Trim)
            End If
            dt = L_VistaDiferenciaPedidoNota(usuario,
                                             IIf(SbFiltroFecha.Value, DtiDesde.Value.ToString("yyyy/MM/dd"), ""),
                                             IIf(SbFiltroFecha.Value, DtiHasta.Value.ToString("yyyy/MM/dd"), ""),
                                             criterio, SbUsuarioRepartidor.Value)
        Else
            'No ha eligido un cliente
            ToastNotification.Show(Me, "el código de ".ToUpper + IIf(SbUsuarioRepartidor.Value, "repartidor".ToUpper, "usuario".ToUpper) + " no es valido, coloque un código valido.".ToUpper,
                                   My.Resources.INFORMATION, 2000,
                                   eToastGlowColor.Blue,
                                   eToastPosition.BottomLeft)
            Exit Sub
        End If

        If (dt.Rows.Count > 0) Then
            Dim objrep As Object = Nothing
            If (SbUsuarioRepartidor.Value) Then
                objrep = New R_DiferenciaPedidoNotaRepartidor
            Else
                objrep = New R_DiferenciaPedidoNotaUsuario
            End If

            objrep.SetDataSource(dt)

            objrep.SetParameterValue("FechaIni", IIf(SbFiltroFecha.Value, DtiDesde.Value.ToString("dd/MM/yyyy"), "TODO"))
            objrep.SetParameterValue("FechaFin", IIf(SbFiltroFecha.Value, DtiHasta.Value.ToString("dd/MM/yyyy"), "TODO"))
            objrep.SetParameterValue("Filtro", TbDescripcion.Text.Trim)

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

    Private Sub P_prCargarAyuda(flat As Boolean)
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim listEstCeldas As New List(Of Modelos.Celda)
        If (flat) Then
            Dim dt As DataTable = L_GetTabla("TC002", "cbnumi as [numi], cbdesc as [desc]", "cbcat=1 and cbest=1")

            Dim fil As DataRow
            fil = dt.NewRow
            fil.Item(0) = 0
            fil.Item(1) = "TODOS"

            dt.Rows.InsertAt(fil, 0)

            listEstCeldas.Add(New Modelos.Celda(True, "Código", 60))
            listEstCeldas.Add(New Modelos.Celda(True, "Repartidor", 250))

            frmAyuda = New Modelos.ModeloAyuda(250, 250, dt, "Seleccione un repartidor.".ToUpper, listEstCeldas)
            frmAyuda.StartPosition = FormStartPosition.CenterScreen
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim id As String = frmAyuda.filaSelect.Cells("numi").Value
                Dim descr As String = frmAyuda.filaSelect.Cells("desc").Value

                TbCodigo.Text = id
                TbDescripcion.Text = descr
            End If
        Else
            Dim dt As DataTable = L_Usuario_General(0).Tables(0)

            Dim fil As DataRow
            fil = dt.NewRow
            fil.Item(0) = 0
            fil.Item(1) = "TODOS"
            fil.Item(2) = "0"
            fil.Item(3) = 0
            fil.Item(4) = "0"
            fil.Item(5) = "0"
            fil.Item(6) = "0"

            dt.Rows.InsertAt(fil, 0)

            listEstCeldas.Add(New Modelos.Celda(True, "Código", 100))
            listEstCeldas.Add(New Modelos.Celda(True, "Usuario", 150))
            listEstCeldas.Add(New Modelos.Celda(False, "", 0))
            listEstCeldas.Add(New Modelos.Celda(False, "", 0))
            listEstCeldas.Add(New Modelos.Celda(False, "", 0))
            listEstCeldas.Add(New Modelos.Celda(False, "", 0))
            listEstCeldas.Add(New Modelos.Celda(False, "", 0))

            frmAyuda = New Modelos.ModeloAyuda(250, 250, dt, "Seleccione un usuario.".ToUpper, listEstCeldas)
            frmAyuda.StartPosition = FormStartPosition.CenterScreen
            frmAyuda.ShowDialog()

            If frmAyuda.seleccionado = True Then
                Dim id As String = frmAyuda.filaSelect.Cells("ydnumi").Value
                Dim descr As String = frmAyuda.filaSelect.Cells("yduser").Value

                TbCodigo.Text = id
                TbDescripcion.Text = descr
            End If
        End If
    End Sub

#End Region

    Private Sub SbUsuarioRepartidor_ValueChanged(sender As Object, e As EventArgs) Handles SbUsuarioRepartidor.ValueChanged
        TbCodigo.Text = "0"
        TbDescripcion.Text = "TODOS"
    End Sub
End Class