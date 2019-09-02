Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar.SuperGrid
Imports System.IO
Imports System.Drawing.Printing
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class P_LibroVentasChacaltaya

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5

    Dim _DsLV As DataSet

#End Region

#Region "Eventos"

    Private Sub P_LibroVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabItem2.Visible = False
        BBtn_Grabar.Enabled = False
        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False

        Dt1FechaIni.Value = Now.Date
        Dt2FechaFin.Value = Now.Date

        'P_ArmarGrilla()
    End Sub

#End Region

    Private Sub P_ArmarGrilla()
        If (Dt1FechaIni.Value > Dt2FechaFin.Value) Then
            ToastNotification.Show(Me, "'AL' TIENE QUE SER MAYOR QUE 'DEL'",
                                       My.Resources.INFORMATION, _DuracionSms * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomLeft)
            Exit Sub
        End If
        'Busqueda
        Dim dt As New DataTable
        dt = L_ObtenerLibroVenta(Dt1FechaIni.Value.Date.ToString("yyyy/MM/dd"), Dt2FechaFin.Value.Date.ToString("yyyy/MM/dd"))

        P_IndiceDataTable(dt)

        Dgj1Datos.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Datos.DataSource = dt
        Dgj1Datos.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Datos.RootTable.Columns(0)
            .Caption = "Esp"
            .Key = "esp"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(1)
            .Caption = "Nro"
            .Key = "nro"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(2)
            .Caption = "Fecha"
            .Key = "fec"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(3)
            .Caption = "Factura"
            .Key = "fac"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(4)
            .Caption = "Autorización"
            .Key = "aut"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(5)
            .Caption = "Estado"
            .Key = "est"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(6)
            .Caption = "NIT"
            .Key = "nit"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Datos.RootTable.Columns(7)
            .Caption = "Nombre"
            .Key = "nom"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(8)
            .Caption = "Nombre Factura"
            .Key = "nfac"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(9)
            .Caption = "A"
            .Key = "a"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(10)
            .Caption = "B"
            .Key = "b"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(11)
            .Caption = "C"
            .Key = "c"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(12)
            .Caption = "D"
            .Key = "d"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(13)
            .Caption = "E"
            .Key = "e"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(14)
            .Caption = "F"
            .Key = "f"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(15)
            .Caption = "G"
            .Key = "g"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(16)
            .Caption = "H"
            .Key = "h"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With
        With Dgj1Datos.RootTable.Columns(17)
            .Caption = "Código Control"
            .Key = "ccon"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        'Habilitar Filtradores
        With Dgj1Datos
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            'Para alternar la filas de el Grid
            .AlternatingColors = True
        End With
        Dgj1Datos.BringToFront()
    End Sub

    Private Sub Bt3Excel_Click(sender As Object, e As EventArgs) Handles Bt3Excel.Click
        P_GenerarExcel()
    End Sub

    Private Sub Bt4Txt_Click(sender As Object, e As EventArgs) Handles Bt4Txt.Click
        P_GenerarTxt()
    End Sub

    Private Sub P_GenerarExcel()
        If (P_Exportar(".csv")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRECIOS EXITOSA..!!!",
                                       My.Resources.OK, _DuracionSms * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomLeft)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRECIOS..!!!",
                                       My.Resources.WARNING, _DuracionSms * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_GenerarTxt()
        If (P_Exportar(".txt")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE PRECIOS EXITOSA..!!!",
                                       My.Resources.OK, _DuracionSms * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomLeft)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE PRECIOS..!!!",
                                       My.Resources.WARNING, _DuracionSms * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Function P_Exportar(ext As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = gs_rutaArchivos
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = Dgj1Datos.GetRows.Count - 1
                Dim _columna As Integer = Dgj1Datos.RootTable.Columns.Count - 1
                Dim _archivo As String = _ubicacion & "\LCV_" & Now.Date.Day & _
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ext
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0

                If (Not Directory.Exists(_ubicacion)) Then
                    Directory.CreateDirectory(_ubicacion)
                End If

                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                If (Not ext.Equals(".txt")) Then
                    For Each _col As GridEXColumn In Dgj1Datos.RootTable.Columns
                        If (_col.Visible) Then
                            _linea = _linea & _col.Caption & IIf(ext.Equals(".txt"), "|", ";")
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                End If
                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In Dgj1Datos.GetRows
                    For Each _col As GridEXColumn In Dgj1Datos.RootTable.Columns
                        If (_col.Visible) Then
                            _linea = _linea & CStr(_fil.Cells(_col.Key).Value) & IIf(ext.Equals(".txt"), "|", ";")
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    If (MessageBox.Show("DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
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

    Private Sub Bt1Generar_Click(sender As Object, e As EventArgs) Handles Bt1Generar.Click
        P_ArmarGrilla()
    End Sub

    Private Sub Dgj1Datos_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Datos.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_IndiceDataTable(ByRef dt As DataTable)
        Dim i As Integer = 1
        For Each f As DataRow In dt.Rows
            f.Item("nro") = i
            i += 1
        Next
    End Sub

End Class