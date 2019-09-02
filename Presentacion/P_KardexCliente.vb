Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.SuperGrid
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_KardexCliente


#Region "Variables Globales"

    Dim Dt1Kardex As DataTable
    Dim Dt2KardexTotal As DataTable
    Dim _DuracionSms As Integer = 5

#End Region

#Region "Eventos"

    Private Sub P_KadexCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Bt1BuscarCliente_Click(sender As Object, e As EventArgs) Handles Bt1BuscarCliente.Click
        P_FiltrarGridBusqueda()
    End Sub

    Private Sub Bt2ActualizarSaldo_Click(sender As Object, e As EventArgs) Handles Bt2ActualizarSaldo.Click
        If (Dt1Kardex.Rows.Count > 0) Then
            If (Now.Date.ToString("yyyy/MM/dd").Equals(Dti2FechaFin.Value.ToString("yyyy/MM/dd"))) Then
                L_Actualizar_SaldoTotal(Tb1CodCliente.Text, Dt1Kardex.Rows(Dt1Kardex.Rows.Count - 1).Item("saldo").ToString)
                Tb3Saldo.Text = Dt1Kardex.Rows(Dt1Kardex.Rows.Count - 1).Item("saldo").ToString
                ToastNotification.Show(Me, "Saldo actualizado Correctamente!!!".ToUpper,
                       My.Resources.OK,
                       _DuracionSms * 200,
                       eToastGlowColor.Green,
                       eToastPosition.MiddleCenter)
            Else
                ToastNotification.Show(Me, "Para actualizar el saldo, la fecha final tiene que ser la de hoy!!!".ToUpper,
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.MiddleCenter)

            End If
        End If
    End Sub

    Private Sub Bt3Generar_Click(sender As Object, e As EventArgs) Handles Bt3Generar.Click
        P_GenerarKardexCliente()
    End Sub

    Private Sub Bt4Imprimir_Click(sender As Object, e As EventArgs) Handles Bt4Imprimir.Click
        If (Dgj1Datos.GetRows.Count > 0) Then
            P_GenerarReporte()
        Else
            ToastNotification.Show(Me, "No hay kardex para el rango de fecha".ToUpper,
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
        End If

    End Sub

#End Region

#Region "Medotos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        PanelEx1.Visible = False
        PanelEx2.Visible = False
        SuperTabItem2.Visible = False

        SuperTabControl1.SelectedTabIndex = 0
        Dti1FechaIni.Value = Now.Date
        Dti2FechaFin.Value = Now.Date

        P_ArmarGrillaDatos()
        P_ArmarGrillaAyuda()

        Bt1BuscarCliente.Select()

    End Sub

#End Region

    Private Sub P_ArmarGrillaDatos() 'Para los datos de Kardex de Cliente
        'Datos
        Dt1Kardex = New DataTable
        Dt2KardexTotal = New DataTable
        If (Tb1CodCliente.Text.Length > 0) Then
            Dt2KardexTotal = L_VistaKadexClienteTodo(Tb1CodCliente.Text, Dti2FechaFin.Value.ToString("yyyy/MM/dd")).Tables(0)
            Dt1Kardex = L_VistaKadexClienteUltimo(Tb1CodCliente.Text, Dti1FechaIni.Value.ToString("yyyy/MM/dd"), Dti2FechaFin.Value.ToString("yyyy/MM/dd")).Tables(0)
            If (Dt1Kardex.Rows.Count > 0) Then
                P_ArmarKardex()
            Else
                ToastNotification.Show(Me, "No hay kardex para el rango de fecha".ToUpper,
                       My.Resources.INFORMATION,
                       _DuracionSms * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
            End If
        Else
            Dt1Kardex = L_VistaKadexClienteUltimo("-1", Dti1FechaIni.Value.ToString("yyyy/MM/dd"), Dti2FechaFin.Value.ToString("yyyy/MM/dd")).Tables(0)
        End If

        Dgj1Datos.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Datos.DataSource = Dt1Kardex
        Dgj1Datos.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Datos.RootTable.Columns(0)
            .Caption = ""
            .Key = "tprod"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(1)
            .Caption = ""
            .Key = "grupo"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(2)
            .Caption = ""
            .Key = "nnota"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(3)
            .Caption = ""
            .Key = "ccli"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(4)
            .Caption = ""
            .Key = "nombre"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(5)
            .Caption = "Fecha"
            .Key = "fecha"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(6)
            .Caption = "Concepto"
            .Key = "concepto"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(7)
            .Caption = "Contado"
            .Key = "con"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With Dgj1Datos.RootTable.Columns(8)
            .Caption = "Crédito"
            .Key = "cre"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With Dgj1Datos.RootTable.Columns(9)
            .Caption = "Pago"
            .Key = "pago"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With Dgj1Datos.RootTable.Columns(10)
            .Caption = "Saldo"
            .Key = "saldo"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With
        With Dgj1Datos.RootTable.Columns(11)
            .Caption = ""
            .Key = "nota"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(12)
            .Caption = ""
            .Key = "tipo"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(13)
            .Caption = ""
            .Key = "factura"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With Dgj1Datos
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
        'Dgj1Datos.Dock = DockStyle.Fill

    End Sub

    Private Sub P_FiltrarGridBusqueda()
        SuperTabItem2.Visible = True
        SuperTabControl1.SelectedTabIndex = 1
        Dgj2Busqueda.Select()

        Dgj2Busqueda.RemoveFilters()

        Dgj2Busqueda.MoveTo(Dgj2Busqueda.FilterRow)
        Dgj2Busqueda.Col = 2
        Dgj2Busqueda.AlternatingColors = True
    End Sub

    Private Sub Tb1CodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Tb1CodCliente.KeyDown
        If (e.KeyData = Keys.Control + Keys.Enter) Then
            P_FiltrarGridBusqueda()
        End If
    End Sub

    Private Sub Dgj2Busqueda_DoubleClick(sender As Object, e As EventArgs) Handles Dgj2Busqueda.DoubleClick
        If (Dgj2Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerDatosBusqueda()
        End If
    End Sub

    Private Sub Dgj2Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgj2Busqueda.KeyDown
        If (e.KeyData = Keys.Enter And Dgj2Busqueda.CurrentRow.RowIndex > -1) Then
            P_PonerDatosBusqueda()
        End If
    End Sub

    Private Sub P_PonerDatosBusqueda()
        Tb1CodCliente.Text = Dgj2Busqueda.GetValue("ccnumi").ToString
        Tb2Cliente.Text = Dgj2Busqueda.GetValue("ccdesc").ToString
        SuperTabControl1.SelectedTabIndex = 0

        'Ponemos el Saldo Total
        If (L_ObtenerSaldoCliente(1, Tb1CodCliente.Text).Tables(0).Rows.Count > 0) Then
            Tb3Saldo.Text = L_ObtenerSaldoCliente(1, Tb1CodCliente.Text).Tables(0).Rows(0).Item("idsaldo").ToString
        Else
            Tb3Saldo.Text = "0"
        End If

        Dti1FechaIni.Select()
    End Sub

    Private Sub Dgj2Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj2Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        'Cuando se cambia de Tab, si va al Tab Registro el Tab Busqueda se pone visible=false
        SuperTabItem2.Visible = Not SuperTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub P_GenerarKardexCliente()
        P_ArmarGrillaDatos()
    End Sub

    Private Sub P_ArmarGrillaAyuda() 'Grilla para Buscar Clientes
        'Busqueda
        Dim dt As New DataTable
        dt = L_GetClientes()

        Dgj2Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj2Busqueda.DataSource = dt
        Dgj2Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj2Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "ccnumi"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(1)
            .Caption = ""
            .Key = "cccod"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(2)
            .Caption = "Nombre"
            .Key = "ccdesc"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(3)
            .Caption = "Dirección"
            .Key = "ccdirec"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(4)
            .Caption = "Teléfono 1"
            .Key = "cctelf1"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(5)
            .Caption = "Teléfono 2"
            .Key = "cctelf2"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(6)
            .Caption = ""
            .Key = "numZona"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(7)
            .Caption = "Zona"
            .Key = "descZona"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(8)
            .Caption = ""
            .Key = "numDct"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(9)
            .Caption = "Tipo de Documento"
            .Key = "descDct"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(10)
            .Caption = "Nro Documento"
            .Key = "ccdctnum"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(11)
            .Caption = ""
            .Key = "numCat"
            .Width = 10
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(12)
            .Caption = "Categoria"
            .Key = "descCat"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(13)
            .Caption = "Estado"
            .Key = "ccest"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(14)
            .Caption = "Latitud"
            .Key = "cclat"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(15)
            .Caption = "Longitud"
            .Key = "cclongi"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(16)
            .Caption = "Eventual"
            .Key = "cceven"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(17)
            .Caption = "Observación"
            .Key = "ccobs"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(18)
            .Caption = "Fecha de Nac"
            .Key = "ccfnac"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(19)
            .Caption = "Nombre Factura"
            .Key = "ccnomfac"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(20)
            .Caption = "NIT"
            .Key = "ccnit"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(21)
            .Caption = "Fecha de Ingreso"
            .Key = "ccfecing"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj2Busqueda.RootTable.Columns(22)
            .Caption = "Fecha de Ultimo Pedido"
            .Key = "ccultped"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj2Busqueda.RootTable.Columns(23)
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
        With Dgj2Busqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
        End With
        'Dgj1Busqueda.Dock = DockStyle.Fill
        Dgj2Busqueda.BringToFront()
    End Sub

    Private Sub Dgj1Datos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Datos.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_ArmarKardex()

        Dim saldo As Double = 0
        Dim creT As Double = 0
        Dim pagT As Double = 0

        If (Not IsDBNull(Dt2KardexTotal.Compute("Sum(cre)", "ccli = " + Tb1CodCliente.Text + " and tipo <>'ENTREGA'"))) Then
            creT = Dt2KardexTotal.Compute("Sum(cre)", "ccli = " + Tb1CodCliente.Text + " and tipo <>'ENTREGA'")
        End If
        pagT = Dt2KardexTotal.Compute("Sum(pago)", "ccli = " + Tb1CodCliente.Text)

        saldo = creT - pagT
        Dim con As Double = 0
        Dim cre As Double = 0
        Dim pago As Double = 0
        Dim saldoInicial As Double = 0
        'Sumar Contado
        con = Dt1Kardex.Compute("Sum(con)", "ccli = " + Tb1CodCliente.Text)
        'Sumar Credito
        cre = IIf(IsDBNull(Dt1Kardex.Compute("Sum(cre)", "ccli = " + Tb1CodCliente.Text + " and tipo <>'ENTREGA'")), 0, Dt1Kardex.Compute("Sum(cre)", "ccli = " + Tb1CodCliente.Text + " and tipo <>'ENTREGA'"))
        'Sumar Pago
        pago = Dt1Kardex.Compute("Sum(pago)", "ccli = " + Tb1CodCliente.Text)
        'Saldo inicial al partir de la fecha indicada
        saldoInicial = saldo + pago - cre
        'Insertamos la primera fila con el saldo Inicial
        Dim f As DataRow
        Dim st As System.Type
        f = Dt1Kardex.NewRow
        f.Item(0) = 0
        f.Item(1) = "."
        f.Item(2) = 0
        f.Item(3) = CInt(Tb1CodCliente.Text)
        f.Item(4) = Tb2Cliente.Text
        f.Item(5) = Dti1FechaIni.Value.ToShortDateString
        f.Item(6) = "FACTURA"
        f.Item(7) = 0.0
        f.Item(8) = 0.0
        f.Item(9) = 0.0
        f.Item(10) = saldoInicial
        f.Item(11) = 0
        f.Item(12) = "VENCIDA"
        f.Item(13) = 0
        Dt1Kardex.Rows.InsertAt(f, 0)

        For Each fil As DataRow In Dt1Kardex.Rows
            If (fil.Item("tipo").Equals("NORMAL") And fil.Item("concepto").Equals("VENTAS")) Then
                saldoInicial = saldoInicial + CDbl(fil.Item("cre"))
                fil.Item("saldo") = saldoInicial
            ElseIf (fil.Item("tipo").Equals("NORMAL") And fil.Item("concepto").Equals("PAGO")) Then
                saldoInicial = saldoInicial - CDbl(fil.Item("pago"))
                fil.Item("saldo") = saldoInicial
            Else
                fil.Item("saldo") = saldoInicial
            End If

            If (fil.Item("tipo").Equals("ENTREGA")) Then
                fil.Item("con") = 0
            End If
        Next

    End Sub

    Private Sub P_GenerarReporte()
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        P_Global.Visualizador = New Visualizador

        Dim objrep As New R_KardexCliente
        objrep.SetDataSource(Dt1Kardex)
        objrep.SetParameterValue("FechaIni", Dti1FechaIni.Value)
        objrep.SetParameterValue("FechaFin", Dti2FechaFin.Value)
        objrep.SetParameterValue("Saldo", CDbl(Dt1Kardex.Rows(Dt1Kardex.Rows.Count - 1).Item("saldo").ToString))

        P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
        P_Global.Visualizador.Show() 'Comentar
        P_Global.Visualizador.BringToFront() 'Comentar
    End Sub

    Private Sub P_KadexCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            _MoverEnfoque()
        End If
    End Sub

    Private Sub _MoverEnfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Private Sub Tb1CodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tb1CodCliente.KeyPress
        G_ValidarTextBox(1, e)
    End Sub
End Class