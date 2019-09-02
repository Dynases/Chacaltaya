Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class PR_PrestamoEquiposAgrupado

#Region "Variables Globales"

    Dim DtConcepto As DataTable
    Dim FtTitulo As Font = New Font("Arial", gi_fuenteTamano + 1)
    Dim FtNormal As Font = New Font("Arial", gi_fuenteTamano)
    Dim InDuracion As Byte = 5

#End Region

#Region "Eventos"

    Private Sub PR_KardexPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub SbFiltroCliente_ValueChanged(sender As Object, e As EventArgs) Handles SbFiltroCliente.ValueChanged
        BtBuscarCliente.Enabled = SbFiltroCliente.Value
        'TbCodigoCliente.Enabled = SbFiltroCliente.Value
        If (Not SbFiltroCliente.Value) Then
            TbCodigoCliente.Clear()
            TbNombreCliente.Clear()
        End If
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

        Me.Text = "K A R D E X   P R E S T A M O   A G R U P A D O".ToUpper
        Me.WindowState = FormWindowState.Maximized
        CrReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        P_prArmarCombo()

        P_prArmarGrilla()

        TbCodigoCliente.ReadOnly = True
        TbNombreCliente.ReadOnly = True
        BtBuscarCliente.Enabled = False
    End Sub

    Private Sub P_prCargarReporte()
        Dim dt As New DataTable
        TbCodigoCliente.Select()
        If (Not P_fnValidar()) Then
            Exit Sub
        End If

        Dim cliente As String = ""
        Dim where As String = ""

        where = where + IIf(CbEquipo.Value = 0, "", " and 1=IIF(chcod=0,1,IIF(chcod=" + CbEquipo.Value.ToString + ",1,0))")

        Dim where2 As String = " and chtmov in ( "
        If (SbConcepto.Value) Then
            For Each fil As DataRow In DtConcepto.Rows
                If (fil.Item("check")) Then
                    where2 = where2 + fil.Item("numi").ToString + ","
                End If
            Next
            If (where2.Contains(",")) Then
                where2 = where2.Substring(0, where2.Length - 1) + ")"
                where = where + where2
            End If
        End If

        If (Not SbFiltroCliente.Value) Then
            'Todos
            cliente = "TODOS"
            dt = L_VistaPrestamoEquiposAgrupado("", where)
        Else
            'Se elijio un cliente
            cliente = TbNombreCliente.Text.Trim
            dt = L_VistaPrestamoEquiposAgrupado(TbCodigoCliente.Text.Trim, where)
        End If

        P_prQuitarProductosCompuesto(dt)

        If (dt.Rows.Count > 0) Then
            Dim objrep As New R_PrestamoEquiposAgrupado
            objrep.SetDataSource(dt)

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
        If (SbFiltroCliente.Value) Then
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
        End If
    End Sub

#End Region

    Private Sub P_prQuitarProductosCompuesto(ByRef dt As DataTable)

    End Sub

    Private Sub P_prArmarCombo()
        P_prArmarComboEquipo()
    End Sub

    Private Sub P_prArmarGrilla()
        P_prArmarGrillaConcepto()
    End Sub

    Private Sub P_prArmarComboEquipo()
        Dim dt As New DataTable
        dt = L_GetTabla("TC001", "canumi as [cod], cadesc as [desc]", "caserie=1 and caest=1")

        Dim f As DataRow
        f = dt.NewRow
        f.Item("cod") = 0
        f.Item("desc") = "TODOS"

        dt.Rows.InsertAt(f, 0)

        g_prArmarCombo(CbEquipo, dt, 60, 200, "Código", "Equipo")

        If (dt.Rows.Count > 0) Then
            CbEquipo.SelectedIndex = 0
        End If
    End Sub

    Private Sub P_prArmarGrillaConcepto()
        DtConcepto = New DataTable
        DtConcepto = L_GetTabla("TCI001", "cpnumi as [numi], cpdesc as [desc], cast(1 as bit) as [check]", "cptipo=1")

        DgjConcepto.BoundMode = Janus.Data.BoundMode.Bound
        DgjConcepto.DataSource = DtConcepto
        DgjConcepto.RetrieveStructure()

        'dar formato a las columnas
        With DgjConcepto.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "numi"
            .Width = 55
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With DgjConcepto.RootTable.Columns(1)
            .Caption = "Concepto"
            .Key = "desc"
            .Width = 160
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With DgjConcepto.RootTable.Columns(2)
            .Caption = "Check"
            .Key = "check"
            .Width = 55
            .HeaderStyle.Font = FtTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = FtNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With

        'Habilitar Filtradores
        With DgjConcepto
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
            .AllowEdit=InheritableBoolean.False
        End With
    End Sub

    Private Sub SbConcepto_ValueChanged(sender As Object, e As EventArgs) Handles SbConcepto.ValueChanged
        If (SbConcepto.Value) Then
            For Each fil As DataRow In DtConcepto.Rows
                fil.Item("check") = False
            Next
            DgjConcepto.AllowEdit = InheritableBoolean.True
        Else
            For Each fil As DataRow In DtConcepto.Rows
                fil.Item("check") = True
            Next
            DgjConcepto.AllowEdit = InheritableBoolean.False
        End If
    End Sub

    Private Function P_fnValidar() As Boolean
        Dim sms As String = ""
        If (SbFiltroCliente.Value) Then
            If (TbCodigoCliente.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "debe elegir un cliente.".ToUpper
                Else
                    sms = sms + vbCrLf + "debe elegir un cliente.".ToUpper
                End If
            End If
        End If

        If (Not IsNumeric(CbEquipo.Value.ToString)) Then
            If (sms = String.Empty) Then
                sms = "debe elegir un equipo de la lista.".ToUpper
            Else
                sms = sms + vbCrLf + "debe elegir un equipo de la lista.".ToUpper
            End If
        End If

        If (SbConcepto.Value) Then
            Dim cont As Integer = 0
            For Each fil As DataRow In DtConcepto.Rows
                If (fil.Item("check")) Then
                    cont += 1
                End If
            Next
            If (cont = 0) Then
                If (sms = String.Empty) Then
                    sms = "debe chekear uno o varios conceptos de la lista.".ToUpper
                Else
                    sms = sms + vbCrLf + "debe chekear uno o varios conceptos de la lista.".ToUpper
                End If
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me, sms.ToUpper,
                                   My.Resources.INFORMATION,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return (sms = String.Empty)
    End Function

End Class