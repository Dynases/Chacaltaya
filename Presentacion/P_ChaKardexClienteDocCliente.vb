Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.SuperGrid
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_ChaKardexClienteDocCliente

#Region "Variables Globales"

    Private dtKardex As DataTable
    Private dtKardexTotal As DataTable
    Private dtPrecio As DataTable
    Private inDuracion As Integer = 5

#End Region

#Region "Eventos"

    Private Sub My_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub btBuscarCliente_Click(sender As Object, e As EventArgs) Handles btBuscarCliente.Click
        P_prFiltrarGridBusqueda()
    End Sub

    Private Sub btActualizarSaldo_Click(sender As Object, e As EventArgs) Handles btActualizarSaldo.Click
        If (dtKardex.Rows.Count > 0) Then
            If (Now.Date.ToString("yyyy/MM/dd").Equals(dtiFechaFin.Value.ToString("yyyy/MM/dd"))) Then
                L_Actualizar_SaldoTotal(tbCodCliente.Text, dtKardex.Rows(dtKardex.Rows.Count - 1).Item("monSaldo").ToString)
                tbSaldo.Text = dtKardex.Rows(dtKardex.Rows.Count - 1).Item("monSaldo").ToString
                ToastNotification.Show(Me, "Saldo actualizado Correctamente!!!".ToUpper,
                       My.Resources.OK,
                       inDuracion * 200,
                       eToastGlowColor.Green,
                       eToastPosition.MiddleCenter)
            Else
                ToastNotification.Show(Me, "Para actualizar el saldo, la fecha final tiene que ser la de hoy!!!".ToUpper,
                       My.Resources.INFORMATION,
                       inDuracion * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.MiddleCenter)

            End If
        End If
    End Sub

    Private Sub btGenerarKardex_Click(sender As Object, e As EventArgs) Handles btGenerarKardex.Click
        P_prGenerarKardexCliente()
    End Sub

    Private Sub btImprimirKardex_Click(sender As Object, e As EventArgs) Handles btImprimirKardex.Click
        If (dgjKardex.GetRows.Count > 0) Then
            P_prGenerarReporte()
        Else
            ToastNotification.Show(Me, "No hay kardex para el rango de fecha".ToUpper,
                       My.Resources.INFORMATION,
                       inDuracion * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub tbCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles tbCodCliente.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_prFiltrarGridBusqueda()
        End If
    End Sub

    Private Sub dgjBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles dgjBusqueda.DoubleClick
        If (dgjBusqueda.CurrentRow.RowIndex > -1) Then
            P_prPonerDatosBusqueda()
        End If
    End Sub

    Private Sub dgjBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles dgjBusqueda.KeyDown
        If (e.KeyData = Keys.Enter And dgjBusqueda.CurrentRow.RowIndex > -1) Then
            P_prPonerDatosBusqueda()
        End If
    End Sub

    Private Sub dgjBusqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjBusqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        'Cuando se cambia de Tab, si va al Tab Registro el Tab Busqueda se pone visible=false
        SuperTabItem2.Visible = Not SuperTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub dgjKardex_EditingCell(sender As Object, e As EditingCellEventArgs) Handles dgjKardex.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_KadexCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            P_prMoverEnfoque()
        End If
    End Sub

    Private Sub tbCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCodCliente.KeyPress
        G_ValidarTextBox(1, e)
    End Sub

#End Region

#Region "Medotos"

    Private Sub P_prInicio()
        'L_prAbrirConexion("localhost", "sersolinf", "321", "BDDist")

        Me.Text = "K A R D E X   D E   C L I E N T E   -   D O C   C L I E N T E"
        Me.WindowState = FormWindowState.Maximized

        PanelEx1.Visible = False
        PanelEx2.Visible = False
        SuperTabItem2.Visible = False

        SuperTabControl1.SelectedTabIndex = 0
        dtiFechaIni.Value = Now.Date
        dtiFechaFin.Value = Now.Date

        P_prArmarGrillaKardex()
        P_prArmarGrillaAyuda()

        btBuscarCliente.Select()

    End Sub

    Private Sub P_prMoverEnfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub P_prArmarGrillaKardex() 'Para los datos de Kardex de Cliente
        'Datos
        dtKardex = New DataTable
        dtKardexTotal = New DataTable
        dtPrecio = New DataTable
        If (tbCodCliente.Text.Length > 0) Then
            dtKardexTotal = L_fnVistaChaKadexClienteDocClienteTodo(tbCodCliente.Text, dtiFechaFin.Value.ToString("yyyy/MM/dd"))
            dtKardex = L_fnVistaChaKadexClienteDocClienteUltimo(tbCodCliente.Text, dtiFechaIni.Value.ToString("yyyy/MM/dd"), dtiFechaFin.Value.ToString("yyyy/MM/dd"))
            dtPrecio = L_fnVistaChaKadexClienteDocClientePrecio(tbCodCliente.Text, dtiFechaIni.Value.ToString("yyyy/MM/dd"))
            If (dtKardex.Rows.Count > 0) Then
                P_prArmarKardex()
            Else
                ToastNotification.Show(Me, "No hay kardex para el rango de fecha".ToUpper,
                       My.Resources.INFORMATION,
                       inDuracion * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
            End If
        Else
            dtKardex = L_fnVistaChaKadexClienteDocClienteUltimo("-1", dtiFechaIni.Value.ToString("yyyy/MM/dd"), dtiFechaFin.Value.ToString("yyyy/MM/dd"))
        End If

        dgjKardex.BoundMode = Janus.Data.BoundMode.Bound
        dgjKardex.DataSource = dtKardex
        dgjKardex.RetrieveStructure()

        'dar formato a las columnas
        '1
        With dgjKardex.RootTable.Columns("codGruProducto")
            .Visible = False
        End With
        '2
        With dgjKardex.RootTable.Columns("gruProducto")
            .Caption = "Grupo"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        '3
        With dgjKardex.RootTable.Columns("nroNota")
            .Visible = False
        End With
        '4
        With dgjKardex.RootTable.Columns("codCliente")
            .Visible = False
        End With
        '5
        With dgjKardex.RootTable.Columns("nomCliente")
            .Visible = False
        End With
        '6
        With dgjKardex.RootTable.Columns("fecha")
            .Caption = "Fecha"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        '7
        With dgjKardex.RootTable.Columns("concepto")
            .Visible = False
        End With
        '8
        With dgjKardex.RootTable.Columns("monContado")
            .Caption = "Contado"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '9
        With dgjKardex.RootTable.Columns("monCredito")
            .Caption = "Crédito"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '10
        With dgjKardex.RootTable.Columns("monPago")
            .Caption = "Pago"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '11
        With dgjKardex.RootTable.Columns("monSaldo")
            .Caption = "Saldo"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '12
        With dgjKardex.RootTable.Columns("nroRecibo")
            .Caption = "Recibo"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0"
        End With
        '13
        With dgjKardex.RootTable.Columns("nroFactura")
            .Caption = "N° Factura"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        '14
        With dgjKardex.RootTable.Columns("tipoNota")
            .Caption = "Concepto"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        '15
        With dgjKardex.RootTable.Columns("precioNormal")
            .Visible = False
        End With
        '16
        With dgjKardex.RootTable.Columns("catCliente")
            .Visible = False
        End With
        '17
        With dgjKardex.RootTable.Columns("precioCliente")
            .Visible = False
        End With
        '18
        With dgjKardex.RootTable.Columns("codProducto")
            .Visible = False
        End With
        '19
        With dgjKardex.RootTable.Columns("nomProductoL")
            .Caption = "Producto"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        '20
        With dgjKardex.RootTable.Columns("nomProductoC")
            .Visible = False
        End With
        '21
        With dgjKardex.RootTable.Columns("cantVenta")
            .Caption = "Cantidad"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0"
        End With
        '22
        With dgjKardex.RootTable.Columns("nroLinea")
            .Visible = False
        End With
        '23
        With dgjKardex.RootTable.Columns("totVenNormal")
            .Caption = "Total Venta"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '24
        With dgjKardex.RootTable.Columns("totDesc")
            .Caption = "Descuento"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        '25
        With dgjKardex.RootTable.Columns("totVenta")
            .Caption = "Total"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        'Posiciones columna visibles
        '0
        With dgjKardex.RootTable.Columns("fecha")
            .Position = 0
        End With
        '1
        With dgjKardex.RootTable.Columns("tipoNota")
            .Position = 1
        End With
        '2
        With dgjKardex.RootTable.Columns("nroFactura")
            .Position = 2
        End With
        '3
        With dgjKardex.RootTable.Columns("nroRecibo")
            .Position = 3
        End With
        '4
        With dgjKardex.RootTable.Columns("gruProducto")
            .Position = 4
        End With
        '5 
        With dgjKardex.RootTable.Columns("nomProductoL")
            .Position = 5
        End With
        '6
        With dgjKardex.RootTable.Columns("cantVenta")
            .Position = 6
        End With
        '7
        With dgjKardex.RootTable.Columns("totVenNormal")
            .Position = 7
        End With
        '8
        With dgjKardex.RootTable.Columns("totDesc")
            .Position = 8
        End With
        '9
        With dgjKardex.RootTable.Columns("totVenta")
            .Position = 9
        End With
        '10
        With dgjKardex.RootTable.Columns("monContado")
            .Position = 10
        End With
        '11
        With dgjKardex.RootTable.Columns("monCredito")
            .Position = 11
        End With
        '12
        With dgjKardex.RootTable.Columns("monPago")
            .Position = 12
        End With
        '13
        With dgjKardex.RootTable.Columns("monSaldo")
            .Position = 13
        End With

        'Habilitar Filtradores
        With dgjKardex
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .AlternatingColors = True
            .RecordNavigator = True
        End With
    End Sub

    Private Sub P_prFiltrarGridBusqueda()
        SuperTabItem2.Visible = True
        SuperTabControl1.SelectedTabIndex = 1
        dgjBusqueda.Select()

        dgjBusqueda.RemoveFilters()

        dgjBusqueda.MoveTo(dgjBusqueda.FilterRow)
        dgjBusqueda.Col = 2
        dgjBusqueda.AlternatingColors = True
    End Sub

    Private Sub P_prPonerDatosBusqueda()
        tbCodCliente.Text = dgjBusqueda.GetValue("ccnumi").ToString
        tbNomCliente.Text = dgjBusqueda.GetValue("ccdesc").ToString
        SuperTabControl1.SelectedTabIndex = 0

        'Ponemos el Saldo Total
        If (L_ObtenerSaldoCliente(1, tbCodCliente.Text).Tables(0).Rows.Count > 0) Then
            tbSaldo.Text = L_ObtenerSaldoCliente(1, tbCodCliente.Text).Tables(0).Rows(0).Item("idsaldo").ToString
        Else
            tbSaldo.Text = "0"
        End If

        dtiFechaIni.Select()
    End Sub

    Private Sub P_prGenerarKardexCliente()
        P_prArmarGrillaKardex()
    End Sub

    Private Sub P_prArmarGrillaAyuda() 'Grilla para Buscar Clientes
        'Busqueda
        Dim dt As New DataTable
        dt = L_GetClientes()

        dgjBusqueda.BoundMode = Janus.Data.BoundMode.Bound
        dgjBusqueda.DataSource = dt
        dgjBusqueda.RetrieveStructure()

        'dar formato a las columnas
        With dgjBusqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "ccnumi"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(1)
            .Caption = ""
            .Key = "cccod"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(2)
            .Caption = "Nombre"
            .Key = "ccdesc"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(3)
            .Caption = "Dirección"
            .Key = "ccdirec"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(4)
            .Caption = "Teléfono 1"
            .Key = "cctelf1"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(5)
            .Caption = "Teléfono 2"
            .Key = "cctelf2"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(6)
            .Caption = ""
            .Key = "numZona"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(7)
            .Caption = "Zona"
            .Key = "descZona"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(8)
            .Caption = ""
            .Key = "numDct"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(9)
            .Caption = "Tipo de Documento"
            .Key = "descDct"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(10)
            .Caption = "Nro Documento"
            .Key = "ccdctnum"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(11)
            .Caption = ""
            .Key = "numCat"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(12)
            .Caption = "Categoria"
            .Key = "descCat"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(13)
            .Caption = "Estado"
            .Key = "ccest"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(14)
            .Caption = "Latitud"
            .Key = "cclat"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(15)
            .Caption = "Longitud"
            .Key = "cclongi"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(16)
            .Caption = "Eventual"
            .Key = "cceven"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(17)
            .Caption = "Observación"
            .Key = "ccobs"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(18)
            .Caption = "Fecha de Nac"
            .Key = "ccfnac"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(19)
            .Caption = "Nombre Factura"
            .Key = "ccnomfac"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(20)
            .Caption = "NIT"
            .Key = "ccnit"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(21)
            .Caption = "Fecha de Ingreso"
            .Key = "ccfecing"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjBusqueda.RootTable.Columns(22)
            .Caption = "Fecha de Ultimo Pedido"
            .Key = "ccultped"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjBusqueda.RootTable.Columns(23)
            .Caption = "Usuario"
            .Key = "ccuact"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With dgjBusqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
        End With
        'Dgj1Busqueda.Dock = DockStyle.Fill
        dgjBusqueda.BringToFront()
    End Sub

    Private Sub P_prArmarKardex()

        Dim saldo As Double = 0
        Dim creT As Double = 0
        Dim pagT As Double = 0

        If (Not IsDBNull(dtKardexTotal.Compute("Sum(monCredito)", "codCliente=" + tbCodCliente.Text + " and tipoNota<>'ENTREGA'"))) Then
            creT = dtKardexTotal.Compute("Sum(monCredito)", "codCliente=" + tbCodCliente.Text + " and tipoNota<>'ENTREGA'")
        End If
        pagT = dtKardexTotal.Compute("Sum(monPago)", "codCliente=" + tbCodCliente.Text)

        saldo = creT - pagT
        Dim con As Double = 0
        Dim cre As Double = 0
        Dim pago As Double = 0
        Dim saldoInicial As Double = 0
        'Sumar Contado
        con = dtKardex.Compute("Sum(monContado)", "codCliente=" + tbCodCliente.Text)
        'Sumar Credito
        cre = dtKardex.Compute("Sum(monCredito)", "codCliente=" + tbCodCliente.Text + " and tipoNota<>'ENTREGA'")
        'Sumar Pago
        pago = dtKardex.Compute("Sum(monPago)", "codCliente=" + tbCodCliente.Text)
        'Saldo inicial al partir de la fecha indicada
        saldoInicial = saldo + pago - cre
        'Insertamos la primera fila con el saldo Inicial
        Dim f As DataRow
        f = dtKardex.NewRow
        f.Item(0) = 0
        f.Item(1) = "."
        f.Item(2) = 0
        f.Item(3) = CInt(tbCodCliente.Text)
        f.Item(4) = tbNomCliente.Text
        f.Item(5) = dtiFechaIni.Value.ToShortDateString
        f.Item(6) = "VENCIDA"
        f.Item(7) = 0.0
        f.Item(8) = 0.0
        f.Item(9) = 0.0
        f.Item(10) = saldoInicial
        f.Item(11) = 0
        f.Item(12) = 0
        f.Item(13) = "VENCIDA"
        f.Item(14) = 0.0
        f.Item(15) = 0
        f.Item(16) = 0.0
        f.Item(17) = 0
        f.Item(18) = ""
        f.Item(19) = ""
        f.Item(20) = 0
        f.Item(21) = 0
        f.Item(22) = 0.0
        f.Item(23) = 0.0
        f.Item(24) = 0.0
        dtKardex.Rows.InsertAt(f, 0)

        For Each fil As DataRow In dtKardex.Rows
            If (fil.Item("tipoNota").Equals("NORMAL") And fil.Item("concepto").Equals("VENTA")) Then
                fil.Item("totVenNormal") = IIf(IsDBNull(dtPrecio.Compute("SUM(subTotVenta)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString)), 0, dtPrecio.Compute("SUM(subTotVenta)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString))
                fil.Item("totDesc") = IIf(IsDBNull(dtPrecio.Compute("SUM(totDescuento)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString)), 0, dtPrecio.Compute("SUM(totDescuento)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString))
                fil.Item("totVenta") = IIf(IsDBNull(dtPrecio.Compute("SUM(totVenta)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString)), 0, dtPrecio.Compute("SUM(totVenta)", "nroNota=" + fil.Item("nroNota").ToString + " and nroLinea=" + fil.Item("nroLinea").ToString))
            Else
                fil.Item("totVenNormal") = 0.0
                fil.Item("totDesc") = 0.0
                fil.Item("totVenta") = 0.0
            End If

            If (fil.Item("tipoNota").Equals("ENTREGA")) Then
                fil.Item("monContado") = 0
            End If

            If (fil.Item("tipoNota").Equals("NORMAL") And fil.Item("concepto").Equals("VENTA")) Then
                saldoInicial = saldoInicial + CDbl(fil.Item("monCredito"))
                fil.Item("monSaldo") = saldoInicial
                fil.Item("tipoNota") = "VENTA"
            ElseIf (fil.Item("tipoNota").Equals("NORMAL") And fil.Item("concepto").Equals("PAGO")) Then
                saldoInicial = saldoInicial - CDbl(fil.Item("monPago"))
                fil.Item("monSaldo") = saldoInicial
                fil.Item("tipoNota") = "PAGO"
            Else
                fil.Item("monSaldo") = saldoInicial
            End If
        Next

    End Sub

    Private Sub P_prGenerarReporte()
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        P_Global.Visualizador = New Visualizador

        Dim objrep As New R_ChaKardexClienteDocCliente
        objrep.SetDataSource(dtKardex)
        objrep.SetParameterValue("FechaIni", dtiFechaIni.Value.ToShortDateString)
        objrep.SetParameterValue("FechaFin", dtiFechaFin.Value.ToShortDateString)
        objrep.SetParameterValue("Saldo", CDbl(dtKardex.Rows(dtKardex.Rows.Count - 1).Item("monSaldo").ToString))

        P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
        P_Global.Visualizador.Show() 'Comentar
        P_Global.Visualizador.BringToFront() 'Comentar
    End Sub

#End Region

End Class