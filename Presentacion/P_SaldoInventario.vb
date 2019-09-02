Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Drawing.Printing
Imports DevComponents.DotNetBar
Imports System.IO

Public Class P_SaldoInventario

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5
    Dim _Ds As DataSet

#End Region

#Region "Eventos"

    Private Sub P_SaldoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Bt1Generar_Click(sender As Object, e As EventArgs) Handles Bt1Generar.Click
        P_LlenarDatosGrilla()
    End Sub

    Private Sub Bt2Salir_Click(sender As Object, e As EventArgs) Handles Bt2Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt3Imprimir_Click(sender As Object, e As EventArgs) Handles Bt3Imprimir.Click
        P_GenerarReporte()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabItem2.Visible = False

        P_ArmarGrilla()

    End Sub

#End Region

    Private Sub P_ArmarGrilla()
        DgdDatos.PrimaryGrid.Columns.Clear()
        'Alto de la Fila de Nombres de Columnas
        DgdDatos.PrimaryGrid.ColumnHeader.RowHeight = 25

        'Mostrar u Ocultar la Fila de Filtrado
        DgdDatos.PrimaryGrid.EnableColumnFiltering = True
        DgdDatos.PrimaryGrid.EnableFiltering = True
        DgdDatos.PrimaryGrid.EnableRowFiltering = True
        DgdDatos.PrimaryGrid.Filter.Visible = True

        'Para Mostrar u Ocultar la Columna de Cabesera de las Filas
        DgdDatos.PrimaryGrid.ShowRowHeaders = True

        'Para Mostrar el Indice de la Grilla
        DgdDatos.PrimaryGrid.RowHeaderIndexOffset = 1
        DgdDatos.PrimaryGrid.ShowRowGridIndex = True

        'Alto de las Filas
        DgdDatos.PrimaryGrid.DefaultRowHeight = 22

        'Alternar Colores de las Filas
        DgdDatos.PrimaryGrid.UseAlternateRowStyle = True

        'Para permitir o denegar el cambio de tamaño de la Filas
        DgdDatos.PrimaryGrid.AllowRowResize = False

        'Para que el Tamaño de las Columnas se pongan automaticamente
        'DgdFactura.PrimaryGrid.ColumnAutoSizeMode = ColumnAutoSizeMode.DisplayedCells

        DgdDatos.PrimaryGrid.SelectionGranularity = SelectionGranularity.RowWithCellHighlight

        Dim col As GridColumn

        'Codigo
        col = New GridColumn("Codigo")
        col.EditorType = GetType(GridTextBoxXEditControl)
        col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        col.ReadOnly = True
        col.Visible = True
        col.Width = 80
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
        DgdDatos.PrimaryGrid.Columns.Add(col)

        'Producto
        col = New GridColumn("Producto")
        col.EditorType = GetType(GridTextBoxXEditControl)
        col.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
        col.ReadOnly = True
        col.Visible = True
        col.Width = 150
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
        DgdDatos.PrimaryGrid.Columns.Add(col)

        'Cantidad
        col = New GridColumn("Cantidad")
        col.EditorType = GetType(GridTextBoxXEditControl)
        col.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
        col.ReadOnly = True
        col.Visible = True
        col.Width = 80
        col.CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
        DgdDatos.PrimaryGrid.Columns.Add(col)

        P_LlenarDatosGrilla()
    End Sub

    Private Sub P_LlenarDatosGrilla()
        DgdDatos.PrimaryGrid.Rows.Clear()
        Dim _modo As Integer = 0
        If (Rb1Todos.Checked) Then
            _modo = 1
        ElseIf (Rb2DiferenteCero.Checked) Then
            _modo = 2
        ElseIf (Rb3Positivo.Checked) Then
            _modo = 3
        ElseIf (Rb4Negativo.Checked) Then
            _modo = 4
        End If

        _Ds = New DataSet
        _Ds = L_ObtenerStockInventario(_modo)

        DgdDatos.PrimaryGrid.DataSource = _Ds

        DgdDatos.PrimaryGrid.SetActiveRow(CType(DgdDatos.PrimaryGrid.ActiveRow, GridRow))
    End Sub

    Private Sub P_GenerarReporte()
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        '_Ds1 = L_ObtenerRutaImpresora("1") ' Datos de Impresion
        'If (CInt(_Ds1.Tables(0).Rows(0).Item("ynvp").ToString) = 1) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
        P_Global.Visualizador = New Visualizador 'Comentar
        'End If

        Dim objrep As New R_SaldoInventario
        objrep.SetDataSource(_Ds.Tables(0))

        'If (CInt(_Ds1.Tables(0).Rows(0).Item("ynvp").ToString) = 1) Then 'Vista Previa de la Ventana de Vizualización 1 = True 0 = False
        If (1 = 1) Then
            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.Show() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        End If

        'Dim pd As New PrintDocument()
        ''pd.PrinterSettings.PrinterName = _Ds1.Tables(0).Rows(0).Item("ynrut").ToString
        'If (Not pd.PrinterSettings.IsValid) Then
        '    'ToastNotification.Show(Me, "La Impresora ".ToUpper + _Ds1.Tables(0).Rows(0).Item("ynrut").ToString + Chr(13) + "No Existe".ToUpper,
        '    '                       My.Resources.INFORMATION, _DuracionSms * 1000,
        '    '                       eToastGlowColor.Blue, eToastPosition.BottomLeft)
        'Else
        '    'objrep.PrintOptions.PrinterName = _Ds1.Tables(0).Rows(0).Item("ynrut").ToString '"EPSON TM-T20II Receipt5 (1)"
        '    'objrep.PrintToPrinter(1, False, 1, 1)
        'End If

        'Preguntando si existe el Directorio
        'If (Not Directory.Exists(G_RutaBD + "\LCV")) Then
        '    Directory.CreateDirectory(G_RutaBD + "\LCV")
        'End If
        ''Exportando a Excel el Reporte
        'objrep.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, G_RutaBD + "\LCV\LCV_" + Cb3RazonSocial.Text + ".pdf")
    End Sub

End Class