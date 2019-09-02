Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO

Public Class P_Manuales
#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim GrDatos As GridEXRow() 'Arreglo que tiene las filas actuales de la grilla de datos
    Dim DsGeneral As DataSet 'Dataset que contendra a todos los datatable
    Dim DtCabecera As DataTable 'Datatable de la cabecera
    Dim DtDetalle As DataTable 'Datatable del detalle de la cabecera
    Dim Nuevo As Boolean 'Variable en true cuando se presiona el boton nuevo
    Dim Modificar As Boolean 'Variable en true cuando se presiona el boton modificar
    Dim Eliminar As Boolean 'Variable en true cuando se presiona el boton eliminar
    Dim IndexReg As Integer 'Indice de navegación de registro
    Dim CantidadReg As Integer 'Cantidad de registro de la Tabla
    Dim Grabar As Byte 'Variable que ayuda a la secuencia de grabar

    Dim RutaManuales = gs_RutaManuales
    Dim RutaTemporal = "C:\Temporal\Manuales\"

    Dim RutaPDF As String = ""
    Dim Zoom As Integer = 75
    Dim Left1 As Integer = 0
    Dim Top1 As Integer = 0
    Dim GridPrivilegios As Boolean = False

    Public encrypt As New Encrypt

#End Region

#Region "Eventos"

    Private Sub P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click
        P_Nuevo()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click
        P_Modificar()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click
        P_Eliminar()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        P_Grabar()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click
        P_Cancelar()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        IndexReg = 0
        P_LlenarDatos(IndexReg)
        P_ActualizarPaginacion(IndexReg)
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        IndexReg -= 1
        P_LlenarDatos(IndexReg)
        P_ActualizarPaginacion(IndexReg)
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        IndexReg += 1
        P_LlenarDatos(IndexReg)
        P_ActualizarPaginacion(IndexReg)
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        IndexReg = CantidadReg
        P_LlenarDatos(IndexReg)
        P_ActualizarPaginacion(IndexReg)
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'Abrir la conexion de la base de datos
        'L_abrirConexion()

        'Poner visible=false, los componente que no se ocuparan
        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False

        'Poner titulo al formulario
        Me.Text = "M A N U A L E S"

        'Inizializar Componentes
        Me.WindowState = FormWindowState.Maximized
        SuperTabItem1.Text = "REGISTRO"
        SuperTabControl1.SelectedTabIndex = 0

        'Inhabilitar el boton de grabar
        BBtn_Grabar.Enabled = False

        'Poner texto de salir a boton de cancelar
        BBtn_Cancelar.TooltipText = "SALIR"

        'Deshabilitar componentes
        'Campo del Codigo poner readonly
        Tb1Codigo.ReadOnly = True
        Tb3PDF.ReadOnly = True

        P_Deshabilitar()

        'Armar grillas
        P_ArmarGrillas()

        'Navegación de registro
        P_ActualizarPuterosNavegacion()
        IndexReg = 0
        P_LlenarDatos(IndexReg)

        Txt_NombreUsu.Text = gs_Usuario

        Me.BringToFront()
    End Sub

    Private Sub P_Nuevo()
        P_Limpiar()
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_Habilitar()
        Tb2Nombre.Select()
        Grabar = 1
        RlAccion.Text = "NUEVO"
        P_EstadoNueModEli(1)
        P_ArmarGrillaPrivilegios("-1")
    End Sub

    Private Sub P_Modificar()
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_Habilitar()
        Tb2Nombre.Select()
        Grabar = 3
        RlAccion.Text = "MODIFICAR"
        P_EstadoNueModEli(2)
    End Sub

    Private Sub P_Eliminar()
        Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper, eTaskDialogIcon.Delete, "advertencia".ToUpper, "Esta a punto de eliminar el manual con código -> ".ToUpper + Tb1Codigo.Text + " " + Chr(13) + "Desea continuar?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim res As Boolean = L_fnEliminarManual(Tb1Codigo.Text)
            If res Then
                Try
                    My.Computer.FileSystem.DeleteFile(RutaManuales + "\Manuales\" + Tb3PDF.Text,
                                                   Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                                   Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                                                   Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                Catch ex As Exception

                End Try

                ToastNotification.Show(Me, "Codigo de manual: ".ToUpper + Tb1Codigo.Text + " eliminado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                P_ArmarGrillaBusqueda()
                GrDatos = Nothing
                P_ActualizarPuterosNavegacion()
                P_LlenarDatos(IndexReg)
            Else
                ToastNotification.Show(Me, "", My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
            End If
        End If
    End Sub

    Private Sub P_Grabar()
        'Campo de la Tabla
        Dim numi As String
        Dim desc As String
        Dim est As String
        Dim pdf As String
        Dim obs As String

        Tb2Nombre.Select()
        If (Nuevo) Then
            If (P_Validar()) Then
                If (Grabar = 2) Then
                    'Cargar campos
                    numi = Tb1Codigo.Text.Trim
                    desc = Tb2Nombre.Text.Trim
                    If (Sb1Estado.Value) Then
                        est = "1"
                    Else
                        est = "0"
                    End If
                    pdf = Tb3PDF.Text
                    obs = Tb4Obs.Text

                    'Detalle
                    Dim dt As DataTable = CType(Dgj2Privilegios.DataSource, DataTable).DefaultView.ToTable(True, "clnumi", "clcodu", "clshow", "cllin", "clcopy", "estado")

                    'Grabar cabecera
                    Dim res As Boolean = L_fnGrabarManual(numi, desc, est, pdf, obs, dt)

                    If (res) Then
                        'P_CopiarPDFTemporal(pdf)

                        'IO.File.WriteAllBytes(RutaTemporal + pdf, encrypt.EncryptKey(IO.File.ReadAllBytes(RutaTemporal + pdf)))

                        'Subir el archivo al servido ftp
                        Try
                            My.Computer.Network.UploadFile(RutaPDF, "ftp://" + gs_FtpIp + "/Manuales/" + pdf, gs_FtpUsuario, gs_FtpPassword)
                        Catch ex As Exception
                            MsgBox("Error al conectarse al servidor FTP, Form Manuales: " + ex.Message)
                        End Try

                        P_Limpiar()
                        P_ArmarGrillaBusqueda()
                        BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                        ToastNotification.Show(Me, "Codigo de manual ".ToUpper + Tb1Codigo.Text + " Grabado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA,
                                           Duracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    Else
                        ToastNotification.Show(Me, "No se pudo grabar el codigo de manual ".ToUpper + Tb1Codigo.Text + ", intente nuevamente.".ToUpper,
                                           My.Resources.WARNING,
                                           Duracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                    End If
                    Grabar = 1
                Else
                    BBtn_Grabar.TooltipText = "CONFIRMAR GRABADO DE REGISTRO"
                    BBtn_Grabar.Image = My.Resources.CONFIRMACION
                    BBtn_Grabar.ImageLarge = My.Resources.CONFIRMACION
                    BubbleBar1.Refresh()
                    Grabar = 2
                End If
            End If
        ElseIf (Modificar) Then
            If (P_Validar()) Then
                If (Grabar = 4) Then
                    'Cargar variables
                    numi = Tb1Codigo.Text.Trim
                    desc = Tb2Nombre.Text.Trim
                    If (Sb1Estado.Value) Then
                        est = "1"
                    Else
                        est = "0"
                    End If
                    pdf = Tb3PDF.Text
                    obs = Tb4Obs.Text

                    'Detalles
                    Dim dt As DataTable = CType(Dgj2Privilegios.DataSource, DataTable).DefaultView.ToTable(True, "clnumi", "clcodu", "clshow", "cllin", "clcopy", "estado")

                    'Modificar
                    Dim res As Boolean = L_fnModificarManual(numi, desc, est, pdf, obs, dt)

                    If (res) Then
                        If (Not RutaPDF = String.Empty) Then
                            'P_CopiarPDF(pdf)

                            My.Computer.FileSystem.DeleteFile(RutaManuales + "\Manuales\" + pdf,
                                                   Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                                   Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                                                   Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

                            'Subir el archivo al servido ftp
                            Try
                                My.Computer.Network.UploadFile(RutaPDF, "ftp://" + gs_FtpIp + "/Manuales/" + pdf, gs_FtpUsuario, gs_FtpPassword)
                            Catch ex As Exception
                                MsgBox("Error al conectarse al servidor FTP, Form Manuales: " + ex.Message)
                            End Try

                            L_fnModificarManualUsuario(numi)

                        End If
                        P_ArmarGrillaBusqueda()
                        BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                        ToastNotification.Show(Me, "Codigo de manual ".ToUpper + Tb1Codigo.Text + " Modificado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA,
                                           Duracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    Else
                        ToastNotification.Show(Me, "No se pudo modificar el codigo de manual ".ToUpper + Tb1Codigo.Text + ", intente nuevamente.".ToUpper,
                                           My.Resources.WARNING,
                                           Duracion * 1000,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                    End If

                    Grabar = 3
                Else
                    BBtn_Grabar.TooltipText = "CONFIRMAR MODIFICACIÓN DE REGISTRO"
                    BBtn_Grabar.Image = My.Resources.CONFIRMACION
                    BBtn_Grabar.ImageLarge = My.Resources.CONFIRMACION
                    BubbleBar1.Refresh()
                    Grabar = 4
                End If
            End If
        End If
        P_ActualizarPuterosNavegacion()
    End Sub

    Private Sub P_Cancelar()
        If (Not BBtn_Grabar.Enabled) Then
            Pdf1Manual.Dispose()
            Me.Close()
        Else
            P_Limpiar()
            P_Deshabilitar()
            GrDatos = Dgj1Busqueda.GetRows
            P_LlenarDatos(IndexReg)
            Grabar = 0
            RlAccion.Text = ""
            BBtn_Grabar.TooltipText = "GRABAR"
            BBtn_Grabar.Image = My.Resources.GRABAR
            BBtn_Grabar.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If
        P_EstadoNueModEli(4)
    End Sub

    Private Sub P_EstadoNueModEli(val As Integer)
        Nuevo = (val = 1)
        Modificar = (val = 2)
        Eliminar = (val = 3)

        BBtn_Nuevo.Enabled = (val = 4)
        BBtn_Modificar.Enabled = (val = 4)
        BBtn_Eliminar.Enabled = (val = 4)
        BBtn_Grabar.Enabled = Not (val = 4)

        If (val = 4) Then
            BBtn_Cancelar.TooltipText = "SALIR"
        Else
            BBtn_Cancelar.TooltipText = "CANCELAR"
        End If

        BBtn_Inicio.Enabled = (val = 4)
        BBtn_Anterior.Enabled = (val = 4)
        BBtn_Siguiente.Enabled = (val = 4)
        BBtn_Ultimo.Enabled = (val = 4)
        SuperTabItem2.Visible = (val = 4)
    End Sub

    Private Sub P_Habilitar()
        'Componentes a habilitar
        Tb2Nombre.ReadOnly = False
        Tb4Obs.ReadOnly = False

        Sb1Estado.IsReadOnly = False

        'Grillas
        GridPrivilegios = True
    End Sub

    Private Sub P_Deshabilitar()
        'Componentes a deshabilitar
        Tb2Nombre.ReadOnly = True
        Tb4Obs.ReadOnly = True

        Sb1Estado.IsReadOnly = True

        'Grillas
        GridPrivilegios = False
    End Sub

    Private Sub P_Limpiar()
        'Componentes a limpiar
        Tb1Codigo.Clear()
        Tb2Nombre.Clear()
        Tb3PDF.Clear()
        Tb4Obs.Clear()

        Sb1Estado.Value = True

        'Limpiar el PDF
        Zoom = 50
        RutaPDF = ""
        P_CargarPDF("")
        'Pdf1Manual.Hide()
    End Sub

    Private Sub P_ArmarGrillas()
        P_ArmarGrillaBusqueda()
        P_ArmarGrillaPrivilegios("0")
    End Sub

    Private Sub P_ActualizarPuterosNavegacion()
        If (GrDatos Is Nothing) Then
            GrDatos = Dgj1Busqueda.GetRows
        End If
        CantidadReg = Dgj1Busqueda.GetRows.Count - 1
        If (IndexReg > CantidadReg) Then
            IndexReg = CantidadReg
        End If
        P_ActualizarPaginacion(IndexReg)
    End Sub

    Private Sub P_LlenarDatos(index As Integer)
        If (index <= CantidadReg And index >= 0 And GrDatos.Count > 0) Then
            'Llenar los datos a los componentes
            With GrDatos(index)
                'Campos
                Tb1Codigo.Text = .Cells("numi").Value.ToString
                Tb2Nombre.Text = .Cells("desc").Value.ToString
                Sb1Estado.Value = (.Cells("est").Value.ToString.Equals("1"))
                Tb3PDF.Text = .Cells("pdf").Value.ToString
                Tb4Obs.Text = .Cells("obs").Value.ToString
            End With

            ' Detalle
            P_ArmarGrillaPrivilegios(Tb1Codigo.Text)
            P_CargarPDF(RutaManuales + "\Manuales\" + Tb3PDF.Text)
        Else
            If (IndexReg < 0) Then
                IndexReg = 0
            Else
                IndexReg = CantidadReg
            End If
            If (GrDatos.Count = 0) Then
                P_ArmarGrillaPrivilegios("0")
            End If
        End If
    End Sub

    Private Sub P_ActualizarPaginacion(index As Integer)
        Txt_Paginacion.Text = "Reg. " & index + 1 & " de " & CantidadReg + 1
    End Sub

#End Region

    Public Overrides Function P_Validar() As Boolean
        Dim sms As String = ""

        If (Tb2Nombre.Text = String.Empty) Then
            sms = "el nombre del documento no puede quedar vacio."
        End If

        If (Tb4Obs.Text = String.Empty) Then
            Tb4Obs.Text = "S/O"
        End If

        If (RutaPDF = String.Empty And Not Modificar) Then
            sms = sms + Chr(13) + "debe cargar un manual en formato pdf."
        End If

        If (Not sms = String.Empty) Then
            ToastNotification.Show(Me, sms.ToUpper,
                       My.Resources.WARNING,
                       Duracion * 1000,
                       eToastGlowColor.Red,
                       eToastPosition.MiddleCenter)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs)
        e.Cancel = True
    End Sub

    Private Sub P_ArmarGrillaBusqueda()
        DtCabecera = New DataTable
        DtCabecera = L_fnManuales()

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = DtCabecera
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "numi"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = "Nombre"
            .Key = "desc"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "Estado"
            .Key = "est"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "PDF"
            .Key = "pdf"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = "Observación"
            .Key = "obs"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(5)
            .Caption = ""
            .Key = "fact"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(6)
            .Caption = ""
            .Key = "hact"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(7)
            .Caption = ""
            .Key = "uact"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With

        'Habilitar Filtradores
        With Dgj1Busqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.SingleSelection
            .AlternatingColors = True
        End With

    End Sub

    Private Sub Dgj1Busqueda_EditingCell_1(sender As Object, e As EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_ArmarGrillaPrivilegios(numi As String)
        DtDetalle = New DataTable
        DtDetalle = L_fnManualesDetalle(numi)

        P_PrepararDetalle()

        Dgj2Privilegios.BoundMode = Janus.Data.BoundMode.Bound
        Dgj2Privilegios.DataSource = DtDetalle
        Dgj2Privilegios.RetrieveStructure()

        'dar formato a las columnas
        With Dgj2Privilegios.RootTable.Columns(0)
            .Caption = ""
            .Key = "numi"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(1)
            .Caption = "Código"
            .Key = "codu"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj2Privilegios.RootTable.Columns(2)
            .Caption = "Nombre Usuario"
            .Key = "user"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj2Privilegios.RootTable.Columns(3)
            .Caption = ""
            .Key = "rol"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(4)
            .Caption = "Rol Usuario"
            .Key = "rol2"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj2Privilegios.RootTable.Columns(5)
            .Caption = "show"
            .Key = "show"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(6)
            .Caption = "lin"
            .Key = "lin"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(7)
            .Caption = "copy"
            .Key = "copy"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(8)
            .Caption = "est"
            .Key = "estado"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj2Privilegios.RootTable.Columns(9)
            .Caption = "Ver!"
            .Key = "bool"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .Visible = True
        End With

        'Habilitar Filtradores
        With Dgj2Privilegios
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
            .SelectionMode = SelectionMode.SingleSelection
            .AlternatingColors = True
        End With
    End Sub

    Private Sub P_PrepararDetalle()
        DtDetalle.Columns.Add("bool", Type.GetType("System.Boolean"))
        For Each fil As DataRow In DtDetalle.Rows
            fil.Item("bool") = fil.Item("clshow").ToString.Equals("1")
        Next
    End Sub

    Private Sub Dgj2Privilegios_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj2Privilegios.EditingCell
        If (GridPrivilegios) Then
            If (Not e.Column.Key.Equals("bool")) Then
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Dgj2Privilegios_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles Dgj2Privilegios.CellEdited
        If (e.Column.Key.Equals("bool")) Then
            Dim indexfil As Integer = Dgj2Privilegios.CurrentRow.RowIndex
            If (Dgj2Privilegios.GetValue("bool")) Then
                Dgj2Privilegios.GetRow(indexfil).Cells("show").Value = 1
            Else
                Dgj2Privilegios.GetRow(indexfil).Cells("show").Value = 0
            End If
            If (Not Dgj2Privilegios.GetValue("lin").ToString.Equals("-1")) Then
                Dgj2Privilegios.GetRow(indexfil).Cells("estado").Value = 2
            End If
        End If
    End Sub

    Private Sub BtCargarManual_Click(sender As Object, e As EventArgs) Handles BtCargarManual.Click
        P_AbrirDialogo()
    End Sub

    Private Sub P_AbrirDialogo()
        OfdPDF.InitialDirectory = "C:\Users\" + Environment.UserName + "\Documents"
        OfdPDF.FileName = ""
        OfdPDF.Filter = "Documento|*.pdf"
        OfdPDF.FilterIndex = 1
        If (OfdPDF.ShowDialog() = DialogResult.OK) Then
            RutaPDF = OfdPDF.FileName
            P_CargarPDF(RutaPDF)
        End If
    End Sub

    Private Sub P_CargarPDF(ruta As String)
        If (Not ruta = String.Empty) Then
            If (Not IO.File.Exists(ruta)) Then
                Dim nombreArch As String = ruta.Split("\")(ruta.Split("\").Length - 1)
                Dim rutaDest As String = RutaManuales + "\Manuales"

                'Descargar el archivo al servido ftp
                Try
                    My.Computer.Network.DownloadFile("ftp://" + gs_FtpIp + "/Manuales/" + nombreArch, rutaDest + "\" + nombreArch, gs_FtpUsuario, gs_FtpPassword)
                Catch ex As Exception
                    MsgBox("Error al conectarse al servidor FTP, Descarga, Form Manuales: " + ex.Message)
                End Try
            End If
        End If
        Pdf1Manual.LoadFile(IIf(ruta = String.Empty, "C:\CC\NM.pdf", ruta))
        Pdf1Manual.gotoFirstPage()
        Pdf1Manual.setZoomScroll(Zoom, 0, 0)
        Pdf1Manual.goForwardStack()
        Pdf1Manual.setShowScrollbars(True)
        Pdf1Manual.setShowToolbar(True)
        Pdf1Manual.goBackwardStack()
        Top1 = 0
    End Sub

    Private Sub BtPagAnterior_Click(sender As Object, e As EventArgs) Handles BtPagAnterior.Click
        Pdf1Manual.gotoPreviousPage()
        Top1 = 0
    End Sub

    Private Sub BtPagSiguiente_Click(sender As Object, e As EventArgs) Handles BtPagSiguiente.Click
        Pdf1Manual.gotoNextPage()
        Top1 = 0
    End Sub

    Private Sub BtZoomMas_Click(sender As Object, e As EventArgs) Handles BtZoomMas.Click
        If (Zoom < 200) Then
            Zoom = Zoom + 5
            Pdf1Manual.setZoom(Zoom)
        Else
            Zoom = 200
        End If
    End Sub

    Private Sub BtZoomMenos_Click(sender As Object, e As EventArgs) Handles BtZoomMenos.Click
        If (Zoom > 0) Then
            Zoom = Zoom - 5
            Pdf1Manual.setZoom(Zoom)
        Else
            Zoom = 0
        End If
    End Sub

    Private Sub BtArriba_Click(sender As Object, e As EventArgs) Handles BtArriba.Click
        If (Top1 > 0) Then
            Top1 = Top1 - 48
            Pdf1Manual.setZoomScroll(Zoom, Left1, Top1)
        Else
            Pdf1Manual.gotoPreviousPage()
            Top1 = 480
        End If
    End Sub

    Private Sub BtAbajo_Click(sender As Object, e As EventArgs) Handles BtAbajo.Click
        If (Top1 < 480) Then
            Top1 = Top1 + 48
            Pdf1Manual.setZoomScroll(Zoom, Left1, Top1)
        Else
            Pdf1Manual.gotoNextPage()
            Top1 = 0
        End If
    End Sub

    Private Sub P_CopiarPDFTemporal(nombre As String)
        If (Not Directory.Exists(RutaTemporal)) Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
            Dim folerInfo As DirectoryInfo = My.Computer.FileSystem.GetDirectoryInfo(RutaTemporal)
            'folerInfo.Attributes = FileAttributes.Hidden
        End If
        My.Computer.FileSystem.CopyFile(RutaPDF, RutaTemporal + nombre,
                                        Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        'Dim fileInfo1 As FileInfo = My.Computer.FileSystem.GetFileInfo(RutaTemporal + nombre)
        'fileInfo1.IsReadOnly = False
        'fileInfo1.Attributes = fileInfo1.Attributes Or FileAttributes.Hidden
    End Sub

    Private Sub Dgj1Busqueda_DoubleClick(sender As Object, e As EventArgs) Handles Dgj1Busqueda.DoubleClick
        SuperTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub Dgj1Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgj1Busqueda.KeyDown
        If (e.KeyData = Keys.Enter) Then
            SuperTabControl1.SelectedTabIndex = 0
        End If
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If (SuperTabControl1.SelectedTabIndex = 0 And Not DtCabecera Is Nothing) Then
            GrDatos = Dgj1Busqueda.GetRows
            P_ActualizarPuterosNavegacion()
            IndexReg = P_ObtenerIndexFila()
            P_LlenarDatos(IndexReg)
            P_ActualizarPaginacion(IndexReg)
        End If
    End Sub

    Private Function P_ObtenerIndexFila() As Integer
        Dim res As Integer
        If (Dgj1Busqueda.CurrentRow.RowIndex = -1) Then
            res = 0
        Else
            For Each fil As GridEXRow In Dgj1Busqueda.GetRows
                If (fil.Selected) Then
                    Exit For
                Else
                    res += 1
                End If
            Next
        End If
        Return res
    End Function

    Private Sub P_Manuales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (BBtn_Grabar.Enabled) Then
            Dim info As New TaskDialogInfo("¿esta seguro de salir?".ToUpper, eTaskDialogIcon.Delete,
                                           "advertencia".ToUpper, "esta a punto de salir sin guardar cambios".ToUpper + vbCrLf + "Desea continuar?".ToUpper,
                                           eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            Dim result As eTaskDialogResult = TaskDialog.Show(info)
            If (result = eTaskDialogResult.Yes) Then
                Me.Dispose()
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class