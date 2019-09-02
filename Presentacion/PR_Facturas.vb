Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports System.IO

Public Class PR_Facturas
    Private dtOrigen As DataTable
    Private InDuracion As Byte = 5
#Region "Metodos privados"
    Private Sub _prInicio()
        Me.Text = "reporte de facturas".ToUpper
        Me.WindowState = FormWindowState.Maximized
        Crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        Dtp_FechaIni.Text = Now.Date
        Dtp_FechaFin.Text = Now.Date
        btExportarExcel.Enabled = False

        tbiFacturaInicial.Value = 0
        tbiFacturaFinal.Value = 0
        tbiFacturaInicial.IsInputReadOnly = True
        tbiFacturaFinal.IsInputReadOnly = True
    End Sub
    Private Sub _prCargarReporte()
        If (P_fnValidar()) Then
            Dim _Ds As New DataSet
            _Ds = L_VistaFacturas(Dtp_FechaIni.Value.ToString("yyyy/MM/dd"), Dtp_FechaFin.Value.ToString("yyyy/MM/dd"), tbiFacturaInicial.Value.ToString, tbiFacturaFinal.Value.ToString)
            If (_Ds.Tables(0).Rows.Count > 0) Then
                Dim objrep As New R_Facturas

                dtOrigen = _Ds.Tables(0)
                btExportarExcel.Enabled = True

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
                btExportarExcel.Enabled = False
            End If
        End If
    End Sub

    Private Sub P_GenerarExcel()
        If (P_Exportar(".csv")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE REPORTE EXITOSA..!!!",
                                       My.Resources.OK, 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.BottomLeft)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTAR EL REPORTE..!!!",
                                       My.Resources.WARNING, 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Function P_Exportar(ext As String) As Boolean
        Dim _ubicacion As String
        Dim _directorio As New FolderBrowserDialog

        If (_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then 'If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            _ubicacion = _directorio.SelectedPath
            '_ubicacion = G_RutaImagenes
            Try
                dtOrigen.Columns(0).Caption = "FECHA"
                dtOrigen.Columns(1).Caption = "CODIGO"
                dtOrigen.Columns(2).Caption = "NOMBRE"
                dtOrigen.Columns(3).Caption = "NIT"
                dtOrigen.Columns(4).Caption = "NOTA"
                dtOrigen.Columns(5).Caption = "FACTURA"
                dtOrigen.Columns(6).Caption = "MONTO"

                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = dtOrigen.Rows.Count
                Dim _columna As Integer = dtOrigen.Columns.Count
                Dim _archivo As String = _ubicacion & "\FACTURAS_" & Now.Date.Day & _
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ext
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For i = 0 To dtOrigen.Columns.Count - 1
                    If (True) Then '_col.Visible
                        _linea = _linea & dtOrigen.Columns(i).Caption & IIf(ext.Equals(".txt"), "|", ";")
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For j = 0 To dtOrigen.Rows.Count - 1
                    For i = 0 To dtOrigen.Columns.Count - 1
                        If (True) Then '_col.Visible
                            _linea = _linea & CStr(dtOrigen.Rows(j).Item(i) & IIf(ext.Equals(".txt"), "|", ";")) 'dtOrigen.Columns(i).Caption
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

#End Region

    Private Sub PR_Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prInicio()
    End Sub

    Private Sub Bbtn_GenerarReporte_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_GenerarReporte.Click
        _prCargarReporte()
    End Sub

    Private Sub Bbtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bbtn_Cancelar.Click
        Close()
    End Sub

    Private Sub btExportarExcel_Click(sender As Object, e As ClickEventArgs) Handles btExportarExcel.Click
        P_GenerarExcel()
    End Sub

    Private Sub sbFiltrar_ValueChanged(sender As Object, e As EventArgs) Handles sbFiltrar.ValueChanged
        If (sbFiltrar.Value) Then
            tbiFacturaInicial.IsInputReadOnly = False
            tbiFacturaFinal.IsInputReadOnly = False
        Else
            tbiFacturaInicial.IsInputReadOnly = True
            tbiFacturaFinal.IsInputReadOnly = True
        End If
        tbiFacturaInicial.Value = 0
        tbiFacturaFinal.Value = 0
    End Sub

    Private Function P_fnValidar() As Boolean
        Dim sms As String = ""

        If (Dtp_FechaIni.Value > Dtp_FechaFin.Value) Then
            If (sms = String.Empty) Then
                sms = "La fecha inicial tiene que ser menor a la fecha final.".ToUpper
            Else
                sms = sms + vbCrLf + "La fecha inicial tiene que ser menor a la fecha final.".ToUpper
            End If
        End If

        If (sbFiltrar.Value) Then
            If (tbiFacturaInicial.Value > tbiFacturaFinal.Value) Then
                If (sms = String.Empty) Then
                    sms = "El nro. de factura inicial tiene que ser menor al nro. de factura final.".ToUpper
                Else
                    sms = sms + vbCrLf + "El nro. de factura inicial tiene que ser menor al nro. de factura final.".ToUpper
                End If
            End If
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me,
                                   sms.ToUpper,
                                   My.Resources.WARNING,
                                   InDuracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If

        Return (sms = String.Empty)
    End Function

End Class