Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO

Public Class P_PagoCuentasPagar

#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim GrDatos As GridEXRow() 'Arreglo que tiene las filas actuales de la grilla de datos
    'Dim DsGeneral As DataSet 'Dataset que contendra a todos los datatable
    Dim DtCabecera As DataTable 'Datatable de la cabecera
    Dim DtDetalle As DataTable 'Datatable del detalle de la cabecera
    Dim Nuevo As Boolean 'Variable en true cuando se presiona el boton nuevo
    Dim Modificar As Boolean 'Variable en true cuando se presiona el boton modificar
    'Dim Eliminar As Boolean 'Variable en true cuando se presiona el boton eliminar
    Dim IndexReg As Integer 'Indice de navegación de registro
    Dim CantidadReg As Integer 'Cantidad de registro de la Tabla
    Dim Grabar As Byte 'Variable que ayuda a la secuencia de grabar

    Dim Bool As Boolean = False

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

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_CuentaPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (BBtn_Grabar.Enabled) Then
            Dim info As New TaskDialogInfo("¿esta seguro de salir?".ToUpper, eTaskDialogIcon.Delete, "advertencia".ToUpper, "esta a punto de salir sin guardar cambios".ToUpper + vbCrLf + "Desea continuar?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            Dim result As eTaskDialogResult = TaskDialog.Show(info)
            If (result = eTaskDialogResult.Yes) Then
                Me.Dispose()
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'Abrir la conexion de la base de datos
        'L_prAbrirConexion()

        'Poner visible=false, los componente que no se ocuparan
        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False
        'BBtn_Modificar.Visible = False
        BBtn_Eliminar.Visible = False

        'Poner titulo al formulario
        Me.Text = "P A G O   D E   C U E N T A S   P O R   P A G A R"

        'Inizializar Componentes
        Me.WindowState = FormWindowState.Maximized
        SuperTabItem1.Text = "REGISTRO"
        SuperTabControl1.SelectedTabIndex = 0
        'Me.BringToFront()

        'Poner visible = false los componentes que estaran inicialmente ocultos
        BtHabilitar.Visible = False

        'Inhabilitar el boton de grabar
        BBtn_Grabar.Enabled = False

        'Poner texto de salir a boton de cancelar
        BBtn_Cancelar.TooltipText = "SALIR"

        'Deshabilitar componentes
        'Campo del Codigo poner readonly
        TbdCambio.IsInputReadOnly = True
        TbTotalPagar.ReadOnly = True
        TbTotalPagado.ReadOnly = True
        TbSaldo.ReadOnly = True

        'Inicializar componentes
        RbPendientes.Checked = True
        StiDetalleCuentasPagar.Visible = False
        StcCuentasPagar.SelectedTabIndex = 0
        Bool = True
        TsmiModificarEliminarDetalleCuentasPagar.Visible = False
        TsmiModificar.Visible = False

        P_Deshabilitar()

        DgvCuentasPagar.Dock = DockStyle.Fill
        'Armar grillas
        P_ArmarGrillas()

        'Armar combos
        P_ArmarCombos()

        'Navegación de registro
        P_ActualizarPuterosNavegacion()
        IndexReg = 0
        P_LlenarDatos(IndexReg)

        Txt_NombreUsu.Text = gs_Usuario
    End Sub

    Private Sub P_Nuevo()
        P_Limpiar()
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_Habilitar()
        CbProveedor.Select()
        Grabar = 1
        RlAccion.Text = "NUEVO"
        P_EstadoNueModEli(1)
        TsmiVerPagos.Visible = False
    End Sub

    Private Sub P_Modificar()
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_Habilitar()
        CbProveedor.Select()
        Grabar = 3
        RlAccion.Text = "MODIFICAR"
        P_EstadoNueModEli(2)
        P_BloquearCabecera(True)
        StiDetalleCuentasPagar.Visible = False
        TsmiVerPagos.Visible = False
    End Sub

    Private Sub P_Eliminar()
        'Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper, eTaskDialogIcon.Delete, "advertencia".ToUpper, "Esta a punto de eliminar una cuenta por pagar con código -> ".ToUpper + TbCodigo.Text + " " + Chr(13) + "Desea continuar?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        'Dim result As eTaskDialogResult = TaskDialog.Show(info)
        'If result = eTaskDialogResult.Yes Then
        'Dim res As Boolean = L_fnEliminarCuentaPagar(TbCodigo.Text)
        'If res Then
        '    ToastNotification.Show(Me, "Codigo de cuenta por pagar: ".ToUpper + TbCodigo.Text + " eliminado con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
        '    Bool = False
        '    P_ArmarGrillaBusqueda()
        '    Bool = True
        '    GrDatos = Nothing
        '    P_ActualizarPuterosNavegacion()
        '    P_LlenarDatos(IndexReg)
        'Else
        '    ToastNotification.Show(Me, "", My.Resources.WARNING, 8000, eToastGlowColor.Red, eToastPosition.TopCenter)
        'End If
        'End If
    End Sub

    Private Sub P_Grabar()
        'Campo de la Tabla
        Dim numi As String

        CbProveedor.Select()
        If (Nuevo) Then
            If (P_Validar()) Then
                If (Grabar = 2) Then
                    'Campos
                    numi = CbProveedor.Value.ToString

                    'Preparar detalle
                    Dim dt As DataTable = CType(DgvCuentasPagar.DataSource, DataTable).DefaultView.ToTable(True, "cpanumi", "pagado")
                    dt.Columns.Add("cpbfdoc", Type.GetType("System.String"))
                    dt.Columns.Add("cpblin", Type.GetType("System.Int32"))
                    dt.Columns.Add("estado", Type.GetType("System.Int32"))

                    For Each fil As DataRow In dt.Rows
                        fil.Item("cpbfdoc") = DtFecha.Value.ToString("yyyy/MM/dd")
                        fil.Item("cpblin") = 0
                        fil.Item("estado") = 0
                    Next

                    For Each fil As DataGridViewRow In DgvCuentasPagar.Rows 'Ver la forma de hacerlo con trigger
                        If (fil.Cells("saldo").Value <= 0) Then
                            L_fnModificarCuentaPagar(fil.Cells("numi").Value.ToString, CbProveedor.Value.ToString,
                                                     fil.Cells("monto").Value.ToString, fil.Cells("obs").Value.ToString,
                                                     "0", CType(fil.Cells("fven").Value, Date).ToString("yyyy/MM/dd"),
                                                     CType(fil.Cells("fdoc").Value, Date).ToString("yyyy/MM/dd"))
                        End If
                    Next

                    'Grabar cabecera
                    Dim res As Boolean = L_fnGrabarPagoCuentaPagar(numi, dt)

                    If (res) Then
                        P_Limpiar()
                        P_ArmarGrillaBusqueda()
                        BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                        ToastNotification.Show(Me, "Pagos del proveedor con codigo ".ToUpper + CbProveedor.Value.ToString + " Grabados con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA,
                                           Duracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                        BtHabilitar.Visible = False
                    Else
                        ToastNotification.Show(Me, "No se pudo grabar los pagos del proveedor con el codigo ".ToUpper + CbProveedor.Value.ToString + ", intente nuevamente.".ToUpper,
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
            'If (P_Validar()) Then
            If (Grabar = 4) Then
                'Cargar variables
                numi = CbProveedor.Value.ToString

                'Modificar
                Dim res As Boolean = L_fnEliminarPagoCuentaPagar(numi, CType(DgvDetalleCuentasPagar.DataSource, DataTable))

                If (res) Then
                    P_ArmarGrillaBusqueda()
                    BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                    ToastNotification.Show(Me, "Pagos del proveedor con codigo ".ToUpper + CbProveedor.Value.ToString + " Modificado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       Duracion * 1000,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, "No se pudo modificar los pagos del proveedor con codigo ".ToUpper + CbProveedor.Value.ToString + ", intente nuevamente.".ToUpper,
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
            'End If
        End If
        P_ActualizarPuterosNavegacion()
    End Sub

    Private Sub P_Cancelar()
        If (Not BBtn_Grabar.Enabled) Then
            Me.Close()
        Else
            P_BloquearCabecera(False)
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
        'Eliminar = (val = 3)

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
        TsmiModificarEliminarDetalleCuentasPagar.Visible = (val = 2)
        StcCuentasPagar.SelectedTabIndex = 0
        TsmiVerPagos.Visible = True
    End Sub

    Private Sub P_Habilitar()
        'Componente Textbox
        TbdMonto.IsInputReadOnly = False

        'Componente Combo
        CbProveedor.ReadOnly = False

        'Componente DatetimeInput
        DtFecha.IsInputReadOnly = False
        DtFecha.ButtonDropDown.Enabled = True

        'Componente TextBox Double Input
        TbdMonto.IsInputReadOnly = False

        'Componentes Boton
        BtObtenerCuentas.Enabled = True
        btComenzarPago.Enabled = True

        'GroupBox
        GpVerCuentas.Enabled = False
    End Sub

    Private Sub P_Deshabilitar()
        'Componente Textbox
        TbdMonto.IsInputReadOnly = True

        'Componente Combo
        CbProveedor.ReadOnly = True

        'Componente DatetimeInput
        DtFecha.IsInputReadOnly = True
        DtFecha.ButtonDropDown.Enabled = False

        'Componente TextBox Double Input
        TbdMonto.IsInputReadOnly = True

        'Componentes Boton
        BtObtenerCuentas.Enabled = False
        btComenzarPago.Enabled = False

        'GroupBox
        GpVerCuentas.Enabled = True
    End Sub

    Private Sub P_Limpiar()
        'Componentes a limpiar
        CbProveedor.SelectedIndex = 0
        DtFecha.Value = Now.Date
        TbdMonto.Value = 0
        TbdCambio.Value = 0

        'Grilla de Cuentas por Pagar
        P_ArmarGrillaCuentasPagar("0")

        'RabioButton
        RbPendientes.Checked = True
    End Sub

    Private Sub P_ArmarCombos()
        P_ArmarComboProveedor()
    End Sub
    Private Sub P_ArmarGrillas()
        P_ArmarGrillaBusqueda()
        P_ArmarGrillaCuentasPagar("0")
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

    Private Sub P_ActualizarPaginacion(index As Integer)
        Txt_Paginacion.Text = "Reg. " & index + 1 & " de " & CantidadReg + 1
    End Sub

    Private Sub P_LlenarDatos(index As Integer)
        If (index <= CantidadReg And index >= 0 And GrDatos.Count > 0) Then
            'Llenar los datos a los componentes
            With GrDatos(index)
                'Campos
                CbProveedor.Clear()
                CbProveedor.SelectedText = .Cells("desc").Value.ToString
                DtFecha.Value = Now.Date
                TbdMonto.Value = 0
                TbdCambio.Value = 0

                P_ArmarGrillaCuentasPagar(.Cells("prov").Value.ToString)
            End With

        Else
            If (IndexReg < 0) Then
                IndexReg = 0
            Else
                IndexReg = CantidadReg
            End If
        End If
    End Sub

    Private Sub P_ArmarComboProveedor()
        Dim DtNombre As DataTable
        DtNombre = L_fnCuentasPagarComboProveedor()
        With CbProveedor.DropDownList
            .Columns.Clear()

            .Columns.Add(DtNombre.Columns("cmnumi").ToString).Width = 70
            .Columns(0).Caption = "Código"
            .Columns(0).Visible = True

            .Columns.Add(DtNombre.Columns("cmdesc").ToString).Width = 300
            .Columns(1).Caption = "Nombre"
            .Columns(1).Visible = True

            .ValueMember = DtNombre.Columns("cmnumi").ToString
            .DisplayMember = DtNombre.Columns("cmdesc").ToString
            .DataSource = DtNombre
            .Refresh()
        End With
    End Sub

    Private Sub P_ArmarGrillaBusqueda()
        DtCabecera = New DataTable
        DtCabecera = L_fnPagoCuentasPagar()

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = DtCabecera
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "prov"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = "Nombre"
            .Key = "desc"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "Teléfono"
            .Key = "telf"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "E-Mail"
            .Key = "email"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = "Obs"
            .Key = "obs"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
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

    Public Overrides Function P_Validar() As Boolean
        Dim sms As String = ""

        If (Not IsNumeric(CbProveedor.Value)) Then
            sms = "debe elegir un proveedor de la lista.".ToUpper
        End If

        If (Not IsDate(DtFecha.Value)) Then
            If (sms = String.Empty) Then
                sms = "debe elegir una fecha valida.".ToUpper
            Else
                sms = sms + Chr(13) + "debe elegir una fecha valida.".ToUpper
            End If
        End If

        If (Not TbdMonto.Value > 0) Then
            If (sms = String.Empty) Then
                sms = "debe poner un monto mayor a cero.".ToUpper
            Else
                sms = sms + Chr(13) + "debe poner un monto mayor a cero.".ToUpper
            End If
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

#End Region

    Private Sub P_ArmarGrillaCuentasPagar(prov As String)
        Dim ancho As Integer
        Dim est As String = ""
        If (RbPendientes.Checked) Then
            est = "1"
        ElseIf (RbPagados.Checked) Then
            est = "0"
        ElseIf (RbAmbos.Checked) Then
            est = ""
        End If
        DtDetalle = L_fnPagoCuentasPagarProveedor(prov, est)

        'Cambio de Grilla del DotNetbar
        'DgdCuentasPagar.PrimaryGrid.DataSource = DtDetalle

        With DgvCuentasPagar
            'Con esto no aparece la ultima Fila Vacia (No damos la opcion para que el usuario agrege filas)
            .AllowUserToAddRows = False

            'Con esto no aparece la primera columna con el * (Ocultamos la cabecera de las filas)
            .RowHeadersVisible = False

            'Con esto alineamos los titulos de las columnas
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Con esto aplicamos fuentes al Datagrid y a las cabeceras de las columnas
            .DefaultCellStyle.Font = New Font("Arial", gi_fuenteTamano, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

            '.RowTemplate.Height = 20

            'Le asignamos el datatable a la grilla
            .DataSource = DtDetalle

            ancho = .Width
        End With

        With DgvCuentasPagar.Columns(0)
            .HeaderText = "Código"
            .Width = (ancho / 100) * 5.6 '3
            .ReadOnly = True
            .Name = "numi"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(1)
            .HeaderText = "Observaciones"
            .Width = (ancho / 100) * 41
            .ReadOnly = True
            .Name = "obs"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(2)
            .HeaderText = "Fecha de Factura"
            .Width = (ancho / 100) * 8.1 '5
            .ReadOnly = True
            .Name = "fdoc"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(3)
            .HeaderText = "Fecha de Vencimiento"
            .Width = (ancho / 100) * 8.1 '5
            .ReadOnly = True
            .Name = "fven"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(4)
            .HeaderText = "Monto Total"
            .Width = (ancho / 100) * 10.3 '8
            .ReadOnly = True
            .Name = "monto"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(5)
            .HeaderText = "Saldo"
            .Width = (ancho / 100) * 10.3 '8
            .ReadOnly = True
            .Name = "saldo"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(6)
            '.HeaderText = "Total Pagado"
            .HeaderText = "Total a Pagar"
            .Width = (ancho / 100) * 10.3 '8
            .ReadOnly = True
            .Name = "pagado"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With
        With DgvCuentasPagar.Columns(7)
            .HeaderText = "Pagar!"
            .Width = (ancho / 100) * 4.2 '4
            .Name = "check1"
            .ReadOnly = True 'IIf(CInt(Txt_MontoPagar.Text) > 0, False, True)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Visible = True
            .SortMode = DataGridViewColumnSortMode.NotSortable
        End With

        'Sumar Totales
        P_SumarTotales()

    End Sub

    Private Sub BtObtenerCuentas_Click(sender As Object, e As EventArgs) Handles BtObtenerCuentas.Click
        If (IsNumeric(CbProveedor.Value)) Then
            P_ArmarGrillaCuentasPagar(CbProveedor.Value.ToString)
            If (DgvCuentasPagar.RowCount > 0) Then
                TbdMonto.Select()
            Else
                CbProveedor.Select()
                ToastNotification.Show(Me, "el proveedor: ".ToUpper + CbProveedor.Text + ", no tiene cuentas pendientes.".ToUpper,
                                       My.Resources.INFORMATION,
                                       Duracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
            End If
        Else
            ToastNotification.Show(Me, "Debe elegir un proveedor valido.".ToUpper,
                                   My.Resources.WARNING,
                                   Duracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
        End If
    End Sub

    Private Sub P_HabilitarFilas()
        DgvCuentasPagar.Columns("check1").ReadOnly = False
    End Sub

    Private Sub DgvCuentasPagar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCuentasPagar.CellContentClick
        'If (e.ColumnIndex = DgvCuentasPagar.Columns("check1").Index) Then
        P_MarcarFactura(DgvCuentasPagar.Columns(e.ColumnIndex).Name, e.RowIndex)
        'End If
    End Sub

    Private Sub P_MarcarFactura(colIndex As String, filIndex As Integer)
        If (Nuevo) Then
            If (filIndex = -1 Or TbdMonto.Value = 0) Then
                ToastNotification.Show(Me, "Debe poner un monto mayor a cero.".ToUpper,
                                       My.Resources.INFORMATION,
                                       Duracion * 1000,
                                       eToastGlowColor.Red,
                                       eToastPosition.TopCenter)
            Else
                DgvCuentasPagar.CommitEdit(DataGridViewDataErrorContexts.Commit)
                If (DgvCuentasPagar.Columns(colIndex).Name.Equals("check1")) Then
                    Dim fila As DataGridViewRow = DgvCuentasPagar.Rows(filIndex)
                    Dim celda As DataGridViewCheckBoxCell = fila.Cells("check1")

                    Dim b As Boolean = Convert.ToBoolean(celda.Value)
                    Dim monto As Double = fila.Cells("monto").Value
                    Dim saldo As Double = fila.Cells("saldo").Value
                    Dim pagado As Double = fila.Cells("pagado").Value
                    If (Convert.ToBoolean(celda.Value)) Then
                        fila.DefaultCellStyle.BackColor = Color.Green
                        If (TbdCambio.Value > 0 And TbdCambio.Value >= saldo) Then
                            fila.Cells("saldo").Value = 0
                            fila.Cells("pagado").Value = pagado + saldo
                            TbdCambio.Value = TbdCambio.Value - saldo
                        ElseIf (TbdCambio.Value > 0 And TbdCambio.Value < saldo) Then
                            fila.Cells("saldo").Value = saldo - TbdCambio.Value
                            fila.Cells("pagado").Value = pagado + TbdCambio.Value
                            TbdCambio.Value = 0
                        Else
                            fila.DefaultCellStyle.BackColor = Color.White
                            celda.Value = False
                        End If
                    Else
                        fila.DefaultCellStyle.BackColor = Color.White
                        fila.Cells("saldo").Value = saldo + pagado
                        fila.Cells("pagado").Value = 0
                        TbdCambio.Value = TbdCambio.Value + pagado
                    End If
                    P_SumarTotales()
                End If
                DgvCuentasPagar.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub

    Private Sub TbdMonto_ValueChanged(sender As Object, e As EventArgs) Handles TbdMonto.ValueChanged
        TbdCambio.Value = TbdMonto.Value
    End Sub

    Private Sub P_SumarTotales()
        TbTotalPagar.Text = DtDetalle.Compute("Sum(cpamonto)", "1=1").ToString
        TbTotalPagado.Text = DtDetalle.Compute("Sum(pagado)", "1=1").ToString
        TbSaldo.Text = DtDetalle.Compute("Sum(saldo)", "1=1").ToString
        'TbTotalPagado.Text = CDbl(TbTotalPagar.Text) - CDbl(TbSaldo.Text)
    End Sub

    Private Sub P_BloquearCabecera(bool As Boolean)
        CbProveedor.ReadOnly = bool
        DtFecha.IsInputReadOnly = bool
        DtFecha.ButtonDropDown.Enabled = Not bool
        TbdMonto.IsInputReadOnly = bool
        TbdCambio.IsInputReadOnly = bool
        BtObtenerCuentas.Enabled = Not bool
        BtHabilitar.Visible = False
        btComenzarPago.Enabled = Not bool
        'GpVerCuentas.Enabled = Not bool
    End Sub

    Private Sub BtHabilitar_Click(sender As Object, e As EventArgs) Handles BtHabilitar.Click
        If (DgvCuentasPagar.RowCount > 0) Then
            Dim info As New TaskDialogInfo("pago de cuentas por pagar".ToUpper, eTaskDialogIcon.Stop, "advertencia".ToUpper, "si continua se perderan los datos de la grilla cuenta por pagar.".ToUpper + vbCrLf + "Desea continuar?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
            Dim result As eTaskDialogResult = TaskDialog.Show(info)
            If (result = eTaskDialogResult.Yes) Then
                P_BloquearCabecera(False)
                BtHabilitar.Refresh()
                P_ArmarGrillaCuentasPagar("0")
                CbProveedor.Select()
            End If
        End If
    End Sub

    Private Sub RbPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles RbPendientes.CheckedChanged
        If (Bool And IsNumeric(CbProveedor.Value)) Then
            P_ArmarGrillaCuentasPagar(CbProveedor.Value.ToString)
        End If
    End Sub

    Private Sub RbPagados_CheckedChanged(sender As Object, e As EventArgs) Handles RbPagados.CheckedChanged
        If (Bool And IsNumeric(CbProveedor.Value)) Then
            P_ArmarGrillaCuentasPagar(CbProveedor.Value.ToString)
        End If
    End Sub

    Private Sub RbAmbos_CheckedChanged(sender As Object, e As EventArgs) Handles RbAmbos.CheckedChanged
        If (Bool And IsNumeric(CbProveedor.Value)) Then
            P_ArmarGrillaCuentasPagar(CbProveedor.Value.ToString)
        End If
    End Sub

    Private Sub TsmiModificarEliminarDetalleCuentasPagar_Click(sender As Object, e As EventArgs) Handles TsmiModificarEliminarDetalleCuentasPagar.Click
        If (DgvCuentasPagar.CurrentRow.Index > -1 And Modificar) Then
            TsmiEliminar.Visible = Modificar
            StiDetalleCuentasPagar.Visible = True
            StcCuentasPagar.SelectedTabIndex = 1
            P_ArmarGrillaCuentasPagarDetalle(DgvCuentasPagar.CurrentRow.Cells("numi").Value.ToString)
        End If
    End Sub

    Private Sub TsmiModificar_Click(sender As Object, e As EventArgs) Handles TsmiModificar.Click

    End Sub

    Private Sub TsmiEliminar_Click(sender As Object, e As EventArgs) Handles TsmiEliminar.Click
        If (Not DgvDetalleCuentasPagar.CurrentRow Is Nothing) Then
            Dim filIndex As Integer = DgvDetalleCuentasPagar.CurrentRow.Index
            If (filIndex > -1) Then
                DgvDetalleCuentasPagar.Rows(filIndex).Cells("estado").Value = -1
                DgvDetalleCuentasPagar.CurrentCell = Nothing
                DgvDetalleCuentasPagar.Rows(filIndex).Visible = False
            End If
        End If
        
    End Sub

    Private Sub StcCuentasPagar_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles StcCuentasPagar.SelectedTabChanged
        StiDetalleCuentasPagar.Visible = StcCuentasPagar.SelectedTabIndex = 1
    End Sub

    Private Sub P_ArmarGrillaCuentasPagarDetalle(numi As String)
        Dim ancho As Integer
        
        DtDetalle = L_fnPagoCuentasPagarProveedorDetalle(numi)

        'Cambio de Grilla del DotNetbar
        'DgdCuentasPagar.PrimaryGrid.DataSource = DtDetalle

        With DgvDetalleCuentasPagar
            'Con esto no aparece la ultima Fila Vacia (No damos la opcion para que el usuario agrege filas)
            .AllowUserToAddRows = False

            'Con esto no aparece la primera columna con el * (Ocultamos la cabecera de las filas)
            .RowHeadersVisible = False

            'Con esto alineamos los titulos de las columnas
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            'Con esto aplicamos fuentes al Datagrid y a las cabeceras de las columnas
            .DefaultCellStyle.Font = New Font("Arial", gi_fuenteTamano, FontStyle.Regular)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

            '.RowTemplate.Height = 20

            'Le asignamos el datatable a la grilla
            .DataSource = DtDetalle

            ancho = .Width
        End With

        With DgvDetalleCuentasPagar.Columns(0)
            .HeaderText = "Código"
            .Width = 100
            .ReadOnly = True
            .Name = "numi"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
        End With
        With DgvDetalleCuentasPagar.Columns(1)
            .HeaderText = "Monto"
            .Width = 150
            .ReadOnly = True
            .Name = "monto"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = True
        End With
        With DgvDetalleCuentasPagar.Columns(2)
            .HeaderText = "Fecha de Pago"
            .Width = 100
            .ReadOnly = True
            .Name = "fdoc"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Visible = True
        End With
        With DgvDetalleCuentasPagar.Columns(3)
            .HeaderText = "lin"
            .Width = 100
            .ReadOnly = True
            .Name = "lin"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With
        With DgvDetalleCuentasPagar.Columns(4)
            .HeaderText = "estado"
            .Width = 100
            .ReadOnly = True
            .Name = "estado"
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Visible = False
        End With

    End Sub

    Private Sub DgvCuentasPagar_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCuentasPagar.CellContentDoubleClick
        If (DgvCuentasPagar.CurrentRow.Index > -1 And Not Nuevo And Not Modificar) Then
            TsmiEliminar.Visible = Modificar
            StiDetalleCuentasPagar.Visible = True
            StcCuentasPagar.SelectedTabIndex = 1
            P_ArmarGrillaCuentasPagarDetalle(DgvCuentasPagar.CurrentRow.Cells("numi").Value.ToString)
        End If
    End Sub

    Private Sub TsmiVerPagos_Click(sender As Object, e As EventArgs) Handles TsmiVerPagos.Click
        If (DgvCuentasPagar.CurrentRow.Index > -1 And Not Nuevo And Not Modificar) Then
            TsmiEliminar.Visible = Modificar
            StiDetalleCuentasPagar.Visible = True
            StcCuentasPagar.SelectedTabIndex = 1
            P_ArmarGrillaCuentasPagarDetalle(DgvCuentasPagar.CurrentRow.Cells("numi").Value.ToString)
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

    Private Sub Dgj1Busqueda_DoubleClick(sender As Object, e As EventArgs) Handles Dgj1Busqueda.DoubleClick
        SuperTabControl1.SelectedTabIndex = 0
    End Sub

    Private Sub Dgj1Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgj1Busqueda.KeyDown
        If (e.KeyData = Keys.Enter) Then
            SuperTabControl1.SelectedTabIndex = 0
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

    Private Sub btComenzarPago_Click(sender As Object, e As EventArgs) Handles btComenzarPago.Click
        If (TbdMonto.Value > 0) Then
            P_HabilitarFilas()
            P_BloquearCabecera(True)
            BtHabilitar.Visible = True
        Else
            ToastNotification.Show(Me,
                                   "el monto a pagar tiene que ser mayor a cero.".ToUpper,
                                   My.Resources.WARNING,
                                   Duracion * 1000,
                                   eToastGlowColor.Red,
                                   eToastPosition.TopCenter)
            TbdMonto.Select()
        End If
    End Sub

    Private Sub CbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles CbProveedor.KeyDown
        If (Nuevo) Then
            If (e.KeyData = Keys.Control + Keys.Enter) Then
                P_prArmarAyudaProveedor()
            End If
        End If
    End Sub

    Private Sub P_prArmarAyudaProveedor()
        Dim frmAyuda As Modelos.ModeloAyuda
        Dim dt As DataTable = L_fnCuentasPagarComboProveedor()

        Dim listEstCeldas As New List(Of Modelos.Celda)
        listEstCeldas.Add(New Modelos.Celda(True, "Codigo", 80))
        listEstCeldas.Add(New Modelos.Celda(True, "Nombre", 300))

        frmAyuda = New Modelos.ModeloAyuda(500, 400, dt, "Seleccione un proveedor".ToUpper, listEstCeldas)
        frmAyuda.StartPosition = FormStartPosition.CenterScreen
        frmAyuda.ShowDialog()

        If frmAyuda.seleccionado = True Then
            Dim id As String = frmAyuda.filaSelect.Cells("cmnumi").Value
            Dim descr As String = frmAyuda.filaSelect.Cells("cmdesc").Value

            CbProveedor.Clear()
            CbProveedor.SelectedText = descr
        End If

    End Sub
End Class