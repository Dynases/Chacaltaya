Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO

Public Class F3_LibroCompra

#Region "Atributos"

    Private inDuracion As Byte = 5
    Dim ftTitulo As Font = New Font("Arial", gi_fuenteTamano + 1)
    Dim ftNormal As Font = New Font("Arial", gi_fuenteTamano)

#End Region

#Region "Propiedades"



#End Region

#Region "Eventos"

    Private Sub F3_LibroCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_prInicio()
    End Sub

    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        P_prArmarGrillaLibroCompra(cbMes.Value.ToString, cbAno.Value.ToString)
        If (dgjLibroCompra.GetRows.Count = 0) Then
            ToastNotification.Show(Me,
                                   "No hay compras para el año y mes seleccionados.".ToUpper,
                                   My.Resources.INFORMATION, inDuracion * 1000,
                                   eToastGlowColor.Blue,
                                   eToastPosition.TopCenter)

        End If
    End Sub

    Private Sub btExcel_Click(sender As Object, e As EventArgs) Handles btExcel.Click
        If (P_prExportarExcel()) Then
            ToastNotification.Show(Me, "Exportación de libro de compras exitosa.".ToUpper,
                                       My.Resources.OK, inDuracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
        Else
            ToastNotification.Show(Me, "Fallo la esporatación de el libro de compras.".ToUpper,
                                       My.Resources.WARNING, inDuracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_prInicio()
        'Abrir conexion
        'L_prAbrirConexion("localhost", "sersolinf", "321", "BDDist")

        Me.Text = "L I B R O   D E   C O M P R A"
        Me.WindowState = FormWindowState.Maximized
        MRlAccion.Text = "L I B R O   D E   C O M P R A"
        SupTabItemBusqueda.Visible = False

        btnNuevo.Visible = False
        btnModificar.Visible = False
        btnEliminar.Visible = False
        btnGrabar.Visible = False
        btnImprimir.Visible = False
        btnPrimero.Visible = False
        btnAnterior.Visible = False
        btnSiguiente.Visible = False
        btnUltimo.Visible = False
        LblPaginacion.Visible = False
        btReporte.Visible = False
        btTxt.Visible = False
        CpExportarExcel.Visible = False

        P_prArmarCombos()

        P_prArmarGrillas()

    End Sub

    Private Sub P_prArmarCombos()
        P_prArmarComboAno()
        P_prArmarComboMes()
    End Sub

    Private Sub P_prArmarGrillas()
        P_prArmarGrillaLibroCompra("-1", "-1")
    End Sub

    Private Sub P_prArmarComboAno()
        Dim dt As New DataTable
        dt = L_GetTabla("VR_GO_LibroCompra", "Distinct(year(fcafdoc)) AS anho", "1 = 1 ORDER BY year(fcafdoc)")

        With cbAno.DropDownList
            .Columns.Clear()

            .Columns.Add(dt.Columns("anho").ToString).Width = 100
            .Columns(0).Caption = "Año"
            .Columns(0).Visible = True

            .ValueMember = dt.Columns("anho").ToString
            .DisplayMember = dt.Columns("anho").ToString
            .DataSource = dt
            .Refresh()
        End With

        cbAno.SelectedIndex = dt.Rows.Count - 1
    End Sub

    Private Sub P_prArmarComboMes()
        Dim dt As New DataTable

        dt.Columns.Add("nro", Type.GetType("System.Int32"))
        dt.Columns.Add("mes", Type.GetType("System.String"))

        Dim fil As DataRow
        For i = 1 To 12
            fil = dt.NewRow
            fil(0) = i
            fil(1) = MonthName(i)
            dt.Rows.Add(fil)
        Next

        With cbMes.DropDownList
            .Columns.Clear()

            .Columns.Add(dt.Columns("nro").ToString).Width = 60
            .Columns(0).Caption = "Nro."
            .Columns(0).Visible = True

            .Columns.Add(dt.Columns("mes").ToString).Width = 140
            .Columns(1).Caption = "Mes"
            .Columns(1).Visible = True

            .ValueMember = dt.Columns("nro").ToString
            .DisplayMember = dt.Columns("mes").ToString
            .DataSource = dt
            .Refresh()
        End With

        cbMes.SelectedIndex = Month(Now.Date) - 1
    End Sub

    Private Sub P_prArmarGrillaLibroCompra(mes As String, ano As String)
        Dim dt As New DataTable
        dt = L_GetTabla("VR_GO_LibroCompra",
                        "1 as esp, ROW_NUMBER() OVER(ORDER BY fcafdoc ASC) AS [row], fcanumi, fcafdoc, fcanit, fcarsocial, " _
                        + "fcanfac, fcandui, fcaautoriz, fcaitc, fcanscf, fcasubtotal, fcadesc, fcaibcf, fcacfiscal, " _
                        + "fcaccont, fcatcom",
                        "MONTH(fcafdoc)=" + mes + " and YEAR(fcafdoc)=" + ano)

        dgjLibroCompra.BoundMode = Janus.Data.BoundMode.Bound
        dgjLibroCompra.DataSource = dt
        dgjLibroCompra.RetrieveStructure()

        'dar formato a las columnas
        With dgjLibroCompra.RootTable.Columns("esp")
            .Caption = "ESP"
            .Width = 40
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("row")
            .Caption = "Nro"
            .Width = 80
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcanumi")
            .Visible = False
        End With

        With dgjLibroCompra.RootTable.Columns("fcafdoc")
            .Caption = "Fecha"
            .Width = 100
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcanit")
            .Caption = "NIT"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcarsocial")
            .Caption = "Razon Social"
            .Width = 200
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcanfac")
            .Caption = "Nro. Factura"
            .Width = 100
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcandui")
            .Caption = "Nro. DUI"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcaautoriz")
            .Caption = "Nro. Autorización"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With dgjLibroCompra.RootTable.Columns("fcaitc")
            .Caption = "Importe Total de la Compra"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcanscf")
            .Caption = "No Sujeto a Crédito Fiscal"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcasubtotal")
            .Caption = "Sub Total"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcadesc")
            .Caption = "Descuento, Bonificaciónes, Rebajas Obtenidas"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcaibcf")
            .Caption = "Importe Base para Crédito Fiscal"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcacfiscal")
            .Caption = "Crédito Fiscal"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With dgjLibroCompra.RootTable.Columns("fcaccont")
            .Caption = "Código de Control"
            .Width = 120
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With dgjLibroCompra.RootTable.Columns("fcatcom")
            .Caption = "Tipo de Compra"
            .Width = 100
            .HeaderStyle.Font = ftTitulo
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.Font = ftNormal
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With dgjLibroCompra
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.MultipleSelection
            .AlternatingColors = True
            .RecordNavigator = True
        End With
    End Sub

    Private Function P_prExportarExcel() As Boolean
        Dim rutaArchivo As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            rutaArchivo = gs_RutaArchivos + "\Compras\Libro de Compras"
            If (Not Directory.Exists(gs_RutaArchivos + "\Compras\Libro de Compras")) Then
                Directory.CreateDirectory(gs_RutaArchivos + "\Compras\Libro de Compras")
            End If
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = dgjLibroCompra.RowCount
                Dim _columna As Integer = dgjLibroCompra.RootTable.Columns.Count
                Dim _archivo As String = rutaArchivo & "\Libro_Compra_" & "_" & Now.Date.Day & _
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In dgjLibroCompra.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                CpExportarExcel.Visible = True
                CpExportarExcel.Minimum = 1
                CpExportarExcel.Maximum = dgjLibroCompra.RowCount
                CpExportarExcel.Value = 1

                For Each _fil As GridEXRow In dgjLibroCompra.GetRows
                    For Each _col As GridEXColumn In dgjLibroCompra.RootTable.Columns
                        If (_col.Visible) Then
                            _linea = _linea & CStr(_fil.Cells(_col.Key).Value) & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    CpExportarExcel.Value += 1
                Next
                _escritor.Close()
                CpExportarExcel.Visible = False
                Try
                    Dim info As New TaskDialogInfo("¿desea abrir el libro de compra?".ToUpper,
                                                   eTaskDialogIcon.Exclamation,
                                                   "pregunta".ToUpper,
                                                   "Desea continuar?".ToUpper,
                                                   eTaskDialogButton.Yes Or eTaskDialogButton.Cancel,
                                                   eTaskDialogBackgroundColor.Blue)
                    Dim result As eTaskDialogResult = TaskDialog.Show(info)
                    If result = eTaskDialogResult.Yes Then
                        Process.Start(_archivo)
                    End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function

#End Region

End Class