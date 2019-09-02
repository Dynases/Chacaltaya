Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO

Public Class P_CuentaPagar

#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim DsGeneral As DataSet 'Dataset que contendra a todos los datatable
    Dim DtCabecera As DataTable 'Datatable de la cabecera
    Dim DtDetalle As DataTable 'Datatable del detalle de la cabecera
    Dim Nuevo As Boolean 'Variable en true cuando se presiona el boton nuevo
    Dim Modificar As Boolean 'Variable en true cuando se presiona el boton modificar
    Dim Eliminar As Boolean 'Variable en true cuando se presiona el boton eliminar
    Dim IndexReg As Integer 'Indice de navegación de registro
    Dim CantidadReg As Integer 'Cantidad de registro de la Tabla
    Dim Grabar As Byte 'Variable que ayuda a la secuencia de grabar

    Dim BoFlat As Boolean = True
    Dim BoTpagoI As Boolean = True
    Dim BoTpagoF As Boolean = True
    Private BoNavegar As Boolean = False

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
        If (Dgj1Busqueda.RowCount > 0) Then
            Dgj1Busqueda.MoveFirst()
        End If
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        If (Dgj1Busqueda.RowCount > 0) Then
            Dgj1Busqueda.MovePrevious()
        End If
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        If (Dgj1Busqueda.RowCount > 0) Then
            Dgj1Busqueda.MoveNext()
        End If
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        If (Dgj1Busqueda.RowCount > 0) Then
            Dgj1Busqueda.MoveLast()
        End If
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Dgj1Busqueda_SelectionChanged(sender As Object, e As EventArgs) Handles Dgj1Busqueda.SelectionChanged
        If (Dgj1Busqueda.Row > -1 And (Not Nuevo And Not Modificar)) Then
            P_prLlenarDatos(Dgj1Busqueda.Row)
        End If
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
        SuperTabItem2.Visible = False
        TbObsProveedor.ReadOnly = True

        'Poner titulo al formulario
        Me.Text = "C U E N T A S   P O R   P A G A R"

        'Inizializar Componentes
        Me.WindowState = FormWindowState.Maximized
        SuperTabItem1.Text = "REGISTRO"
        SuperTabControl1.SelectedTabIndex = 0
        'Me.BringToFront()

        'Inhabilitar el boton de grabar
        BBtn_Grabar.Enabled = False

        'Poner texto de salir a boton de cancelar
        BBtn_Cancelar.TooltipText = "SALIR"

        'Deshabilitar componentes
        'Campo del Codigo poner readonly
        TbCodigo.ReadOnly = True
        SbEstado.IsReadOnly = True

        P_Deshabilitar()

        'Armar combos
        P_ArmarCombos()

        'Armar grillas

        P_ArmarGrillas()

        GpDatosFactura.Visible = False
        SbConFactura.IsReadOnly = True
        LblNroNota.Visible = False
        TbiNroNota.Visible = False
        LblTipoProducto.Visible = False
        CbTipoProducto.Visible = False

        'Navegación de registro
        P_prActualizarPaginacion(0)
        P_prLlenarDatos(0)

        Txt_NombreUsu.Text = gs_Usuario
    End Sub

    Private Sub P_Nuevo()
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_Habilitar()
        CbProveedor.Select()
        Grabar = 1
        RlAccion.Text = "NUEVO"
        P_EstadoNueModEli(1)
        P_Limpiar()
    End Sub

    Private Sub P_Modificar()
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_Habilitar()
        CbProveedor.Select()
        Grabar = 3
        RlAccion.Text = "MODIFICAR"
        P_EstadoNueModEli(2)
    End Sub

    Private Sub P_Eliminar()
        Dim info As New TaskDialogInfo("¿esta seguro de eliminar el registro?".ToUpper, eTaskDialogIcon.Delete, "advertencia".ToUpper, "Esta a punto de eliminar una cuenta por pagar con código -> ".ToUpper + TbCodigo.Text + " " + Chr(13) + "Desea continuar?".ToUpper, eTaskDialogButton.Yes Or eTaskDialogButton.Cancel, eTaskDialogBackgroundColor.Blue)
        Dim result As eTaskDialogResult = TaskDialog.Show(info)
        If result = eTaskDialogResult.Yes Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarCuentaPagar(TbCodigo.Text, mensajeError)
            If res Then
                ToastNotification.Show(Me, "Codigo de cuenta por pagar: ".ToUpper + TbCodigo.Text _
                                       + " eliminado con Exito.".ToUpper,
                                       My.Resources.GRABACION_EXITOSA,
                                       Duracion,
                                       eToastGlowColor.Green,
                                       eToastPosition.TopCenter)
                P_ArmarGrillaBusqueda()
                P_prMoverIndexActual()
                P_prLlenarDatos(Dgj1Busqueda.Row)
            Else
                If (mensajeError = String.Empty) Then
                    ToastNotification.Show(Me, "No se pudo eliminar la cuenta por pagar con codigo ".ToUpper + TbCodigo.Text _
                                           + ", intente nuevamente.".ToUpper,
                                           My.Resources.WARNING,
                                           Duracion * 1500,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                Else
                    ToastNotification.Show(Me, mensajeError.ToUpper,
                                           My.Resources.WARNING,
                                           Duracion * 1500,
                                           eToastGlowColor.Red,
                                           eToastPosition.TopCenter)
                End If
            End If
        End If
    End Sub

    Private Sub P_Grabar()
        'Campo de la Tabla
        Dim numi As String
        Dim prov As String
        Dim fdoc As String
        Dim monto As String
        Dim obs As String
        Dim est As String
        Dim fven As String
        Dim tpago As String
        Dim fpro As String
        Dim nota As String
        Dim tpro As String

        Dim tcom As String
        Dim ffec As String
        Dim fnit As String
        Dim frsocial As String
        Dim fnro As String
        Dim fautoriz As String
        Dim fmonto As String
        Dim fccont As String
        Dim fmcfiscal As String
        Dim fdesc As String

        CbProveedor.Select()
        If (Nuevo) Then
            If (P_Validar()) Then
                If (Grabar = 2) Then
                    'Cargar campos
                    numi = TbCodigo.Text.Trim
                    prov = CbProveedor.Value
                    fdoc = DtFecha.Value.ToString("yyyy/MM/dd")
                    monto = TbdMonto.Value.ToString
                    obs = TbObs.Text.Trim
                    est = IIf(SbEstado.Value, "0", "1")
                    fven = DtFechaPagar.Value.ToString("yyyy/MM/dd")
                    tpago = IIf(SbTipoPago.Value, "1", "2")
                    fpro = IIf(SbConFactura.Value, "1", "0")
                    nota = TbiNroNota.Value.ToString
                    If (tpago.Equals("1")) Then
                        tpro = CbTipoProducto.Value.ToString
                    Else
                        tpro = "0"
                    End If

                    tcom = IIf(fpro.Equals("1"), cbTipoCompra.Value.ToString, "")
                    ffec = IIf(fpro.Equals("1"), DtiFechaFactura.Value.ToString("yyyy/MM/dd"), "")
                    fnit = IIf(fpro.Equals("1"), TbNit.Text, "")
                    frsocial = IIf(fpro.Equals("1"), TbRazonSocial.Text, "")
                    fnro = IIf(fpro.Equals("1"), TbiNroFactura.Value.ToString, "")
                    fautoriz = IIf(fpro.Equals("1"), TbNroAutorizacion.Text, "")
                    fmonto = IIf(fpro.Equals("1"), TbdMontoFactura.Value.ToString, "")
                    fccont = IIf(fpro.Equals("1"), TbCodigoControl.Text, "")
                    fmcfiscal = IIf(fpro.Equals("1"), TbdMontoCreditoFiscal.Value.ToString, "")
                    fdesc = IIf(fpro.Equals("1"), TbdDescuento.Value.ToString, "")

                    'Grabar cabecera
                    Dim res As Boolean = L_fnGrabarCuentaPagar(numi, prov, monto, obs, est, fven, fdoc, tpago, fpro, nota, tpro,
                                                               tcom, ffec, fnit, frsocial, fnro, fautoriz, fmonto, fccont, fmcfiscal, fdesc)

                    If (res) Then
                        P_Limpiar()
                        P_ArmarGrillaBusqueda()
                        Dgj1Busqueda.MoveLast()
                        BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                        ToastNotification.Show(Me, "Codigo de la cuenta por pagar ".ToUpper + TbCodigo.Text + " Grabado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA,
                                           Duracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    Else
                        ToastNotification.Show(Me, "No se pudo grabar el codigo de la cuenta por pagar ".ToUpper + TbCodigo.Text + ", intente nuevamente.".ToUpper,
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
                    numi = TbCodigo.Text.Trim
                    prov = CbProveedor.Value
                    fdoc = DtFecha.Value.ToString("yyyy/MM/dd")
                    monto = TbdMonto.Value.ToString
                    obs = TbObs.Text.Trim
                    est = IIf(SbEstado.Value, "0", "1")
                    fven = DtFechaPagar.Value.ToString("yyyy/MM/dd")
                    tpago = IIf(SbTipoPago.Value, "1", "2")
                    fpro = IIf(SbConFactura.Value, "1", "0")
                    nota = TbiNroNota.Value.ToString
                    If (IsNothing(CbTipoProducto.Value)) Then
                        tpro = "0"
                    Else
                        tpro = CbTipoProducto.Value.ToString
                    End If

                    tcom = IIf(fpro.Equals("1"), cbTipoCompra.Value.ToString, "")
                    ffec = IIf(fpro.Equals("1"), DtiFechaFactura.Value.ToString("yyyy/MM/dd"), "")
                    fnit = IIf(fpro.Equals("1"), TbNit.Text, "")
                    frsocial = IIf(fpro.Equals("1"), TbRazonSocial.Text, "")
                    fnro = IIf(fpro.Equals("1"), TbiNroFactura.Value.ToString, "")
                    fautoriz = IIf(fpro.Equals("1"), TbNroAutorizacion.Text, "")
                    fmonto = IIf(fpro.Equals("1"), TbdMontoFactura.Value.ToString, "")
                    fccont = IIf(fpro.Equals("1"), TbCodigoControl.Text, "")
                    fmcfiscal = IIf(fpro.Equals("1"), TbdMontoCreditoFiscal.Value.ToString, "")
                    fdesc = IIf(fpro.Equals("1"), TbdDescuento.Value.ToString, "")

                    'Modificar
                    Dim res As Boolean = L_fnModificarCuentaPagar(numi, prov, monto, obs, est, fven, fdoc, tpago, fpro, nota, tpro,
                                                                  tcom, ffec, fnit, frsocial, fnro, fautoriz, fmonto, fccont, fmcfiscal, fdesc)

                    If (res) Then
                        If (BoTpagoI <> BoTpagoF And Not BoTpagoF) Then
                            res = L_fnEliminarPagoCuentaPagar2(TbCodigo.Text.Trim)
                        End If
                        P_ArmarGrillaBusqueda()
                        P_prMoverIndexActual()
                        BBtn_Cancelar.InvokeClick(eEventSource.Mouse, Windows.Forms.MouseButtons.Left)
                        ToastNotification.Show(Me, "Codigo de la cuenta por pagar ".ToUpper + TbCodigo.Text + " Modificado con Exito.".ToUpper,
                                           My.Resources.GRABACION_EXITOSA,
                                           Duracion * 1000,
                                           eToastGlowColor.Green,
                                           eToastPosition.TopCenter)
                    Else
                        ToastNotification.Show(Me, "No se pudo modificar el codigo de la cuenta por pagar ".ToUpper + TbCodigo.Text + ", intente nuevamente.".ToUpper,
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
    End Sub

    Private Sub P_Cancelar()
        If (Not BBtn_Grabar.Enabled) Then
            Me.Close()
        Else
            P_EstadoNueModEli(4)
            P_Limpiar()
            P_Deshabilitar()
            P_prLlenarDatos(Dgj1Busqueda.Row)
            Grabar = 0
            RlAccion.Text = ""
            BBtn_Grabar.TooltipText = "GRABAR"
            BBtn_Grabar.Image = My.Resources.GRABAR
            BBtn_Grabar.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If
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
    End Sub

    Private Sub P_Habilitar()
        'Componentes a habilitar
        TbObs.ReadOnly = False

        TbNit.ReadOnly = False
        TbRazonSocial.ReadOnly = False
        TbNroAutorizacion.ReadOnly = False
        TbCodigoControl.ReadOnly = False

        'Componente Combo
        CbProveedor.ReadOnly = False
        CbTipoProducto.ReadOnly = False
        cbTipoCompra.ReadOnly = False

        'Componente DatetimeInput
        DtFecha.IsInputReadOnly = False
        DtFecha.ButtonDropDown.Enabled = True
        DtFechaPagar.IsInputReadOnly = False
        DtFechaPagar.ButtonDropDown.Enabled = True

        DtiFechaFactura.IsInputReadOnly = False
        DtiFechaFactura.ButtonDropDown.Enabled = True

        'Componente TextBox Double Input
        TbdMonto.IsInputReadOnly = False

        TbdMontoFactura.IsInputReadOnly = False
        TbdMontoCreditoFiscal.IsInputReadOnly = False
        TbdDescuento.IsInputReadOnly = False

        'Componente TextBox Integer Input
        TbiNroFactura.IsInputReadOnly = False
        TbiNroNota.IsInputReadOnly = False

        'Componente Switch Button
        SbTipoPago.IsReadOnly = False
        SbConFactura.IsReadOnly = False
    End Sub

    Private Sub P_Deshabilitar()
        'Componentes a habilitar
        TbObs.ReadOnly = True

        TbNit.ReadOnly = True
        TbRazonSocial.ReadOnly = True
        TbNroAutorizacion.ReadOnly = True
        TbCodigoControl.ReadOnly = True

        'Componente Combo
        CbProveedor.ReadOnly = True
        CbTipoProducto.ReadOnly = True
        cbTipoCompra.ReadOnly = True

        'Componente DatetimeInput
        DtFecha.IsInputReadOnly = True
        DtFecha.ButtonDropDown.Enabled = False
        DtFechaPagar.IsInputReadOnly = True
        DtFechaPagar.ButtonDropDown.Enabled = False

        DtiFechaFactura.IsInputReadOnly = True
        DtiFechaFactura.ButtonDropDown.Enabled = False

        'Componente TextBox Double Input
        TbdMonto.IsInputReadOnly = True

        TbdMontoFactura.IsInputReadOnly = True
        TbdMontoCreditoFiscal.IsInputReadOnly = True
        TbdDescuento.IsInputReadOnly = True

        'Componente TextBox Integer Input
        TbiNroFactura.IsInputReadOnly = True
        TbiNroNota.IsInputReadOnly = True

        'Componente Switch Button
        SbTipoPago.IsReadOnly = True
        SbConFactura.IsReadOnly = True
    End Sub

    Private Sub P_Limpiar()
        'Componentes a limpiar
        TbCodigo.Clear()
        TbObs.Clear()

        CbProveedor.SelectedIndex = 0
        CbTipoProducto.SelectedIndex = 0
        cbTipoCompra.SelectedIndex = 0

        DtFecha.Value = Now.Date
        DtFechaPagar.Value = Now.Date

        TbdMonto.Value = 0

        SbConFactura.Value = False
        SbTipoPago.Value = False

        SbEstado.Value = False

        DtiFechaFactura.Value = Now.Date

        TbNit.Clear()
        TbRazonSocial.Clear()
        TbNroAutorizacion.Clear()
        TbCodigoControl.Clear()

        TbiNroFactura.Value = 0
        TbiNroNota.Value = 0

        TbdMontoFactura.Value = 0
        TbdMontoCreditoFiscal.Value = 0
        TbdDescuento.Value = 0

        Dgj1Busqueda.RemoveFilters()
    End Sub

    Private Sub P_ArmarCombos()
        P_ArmarComboProveedor()
        P_ArmarComboTipoProducto()
        P_ArmarComboTipoCompra()
    End Sub
    Private Sub P_ArmarGrillas()
        P_ArmarGrillaBusqueda()
    End Sub

    Private Sub P_prActualizarPaginacion(ByVal index As Integer)
        Txt_Paginacion.Text = "Reg. " & index + 1 & " de " & Dgj1Busqueda.GetRows.Count
    End Sub

    Private Sub P_prMoverIndexActual()
        Dim index As Integer = CInt(Txt_Paginacion.Text.Trim.Split(" ")(1).Trim)
        If (index < 0) Then
            index = 0
        End If
        If (index > Dgj1Busqueda.RowCount) Then
            index = Dgj1Busqueda.RowCount
        End If
        Dgj1Busqueda.MoveTo(index - 1)
        P_prLlenarDatos(Dgj1Busqueda.Row)
    End Sub

    Private Sub P_prLlenarDatos(index As Integer)
        If (index <= Dgj1Busqueda.GetRows.Count - 1 And index >= 0) Then
            If (BoNavegar) Then
                With Dgj1Busqueda
                    TbCodigo.Text = .GetValue("numi").ToString
                    CbProveedor.Clear()
                    CbProveedor.SelectedText = .GetValue("desc").ToString
                    DtFecha.Value = .GetValue("fdoc")
                    DtFechaPagar.Value = .GetValue("fven")
                    TbdMonto.Value = .GetValue("monto")

                    SbTipoPago.Value = .GetValue("tpago").ToString.Equals("1")
                    BoTpagoI = .GetValue("tpago").ToString.Equals("1")

                    TbObs.Text = .GetValue("obs").ToString
                    SbEstado.Value = .GetValue("est").ToString.Equals("0")
                    SbConFactura.Value = .GetValue("fpro").ToString.Equals("1")
                    SbConFactura.IsReadOnly = True
                    TbiNroNota.Value = .GetValue("nota")
                    CbTipoProducto.Clear()
                    CbTipoProducto.SelectedText = .GetValue("ntpro").ToString
                End With

                If (SbConFactura.Value) Then
                    Dim dt As DataTable = L_fnCuentasPagarDatosFactura(TbCodigo.Text)
                    If (dt.Rows.Count > 0) Then
                        Dim tc As String = dt.Rows(0).Item("fcatcom").ToString
                        cbTipoCompra.Clear()
                        cbTipoCompra.SelectedText = L_GetDatoTabla("TC0051", "cedesc", "cecon=14 and cenum=" + tc)

                        DtiFechaFactura.Value = dt.Rows(0).Item("fcafdoc")
                        TbNit.Text = dt.Rows(0).Item("fcanit")
                        TbRazonSocial.Text = dt.Rows(0).Item("fcarsocial")
                        TbiNroFactura.Value = dt.Rows(0).Item("fcanfac")
                        TbNroAutorizacion.Text = dt.Rows(0).Item("fcaautoriz")
                        TbdMontoFactura.Value = dt.Rows(0).Item("fcaitc")
                        TbCodigoControl.Text = dt.Rows(0).Item("fcaccont")
                        TbdMontoCreditoFiscal.Value = dt.Rows(0).Item("fcaibcf")
                        TbdDescuento.Value = dt.Rows(0).Item("fcadesc")
                    End If
                End If

                P_prActualizarPaginacion(Dgj1Busqueda.Row)
            End If
        Else
            If (Dgj1Busqueda.GetRows.Count > 0) Then
                Dgj1Busqueda.MoveTo(CInt(Txt_Paginacion.Text.Trim.Split(" ")(1).Trim))
            End If
        End If
    End Sub

    Private Sub P_ArmarComboProveedor()
        Dim DtNombre As DataTable
        DtNombre = L_fnCuentasPagarComboProveedor()
        With CbProveedor.DropDownList
            .Columns.Clear()

            .Columns.Add(DtNombre.Columns("cmnumi").ToString).Width = 60
            .Columns(0).Caption = "Código"
            .Columns(0).CellStyle.TextAlignment = TextAlignment.Far
            .Columns(0).Visible = True

            .Columns.Add(DtNombre.Columns("cmdesc").ToString).Width = 350
            .Columns(1).Caption = "Nombre"
            .Columns(1).Visible = True

            .ValueMember = DtNombre.Columns("cmnumi").ToString
            .DisplayMember = DtNombre.Columns("cmdesc").ToString
            .DataSource = DtNombre
            .Refresh()
        End With

    End Sub

    Private Sub P_ArmarComboTipoProducto()
        Dim DtTipoProdcuto As DataTable
        DtTipoProdcuto = L_LibreriaGeneral("5").Tables(0)
        With CbTipoProducto.DropDownList
            .Columns.Clear()

            .Columns.Add(DtTipoProdcuto.Columns("cenum").ToString).Width = 60
            .Columns(0).Caption = "Código"
            .Columns(0).Visible = True

            .Columns.Add(DtTipoProdcuto.Columns("cedesc").ToString).Width = 200
            .Columns(1).Caption = "Descripción"
            .Columns(1).Visible = True

            .ValueMember = DtTipoProdcuto.Columns("cenum").ToString
            .DisplayMember = DtTipoProdcuto.Columns("cedesc").ToString
            .DataSource = DtTipoProdcuto
            .Refresh()
        End With
    End Sub

    Private Sub P_ArmarComboTipoCompra()
        Dim DtTipoCompra As DataTable
        DtTipoCompra = L_LibreriaGeneral("14").Tables(0)
        With cbTipoCompra.DropDownList
            .Columns.Clear()

            .Columns.Add(DtTipoCompra.Columns("cenum").ToString).Width = 60
            .Columns(0).Caption = "Código"
            .Columns(0).Visible = True

            .Columns.Add(DtTipoCompra.Columns("cedesc").ToString).Width = 250
            .Columns(1).Caption = "Descripción"
            .Columns(1).Visible = True

            .ValueMember = DtTipoCompra.Columns("cenum").ToString
            .DisplayMember = DtTipoCompra.Columns("cedesc").ToString
            .DataSource = DtTipoCompra
            .Refresh()
        End With
    End Sub

    Private Sub P_ArmarGrillaBusqueda()
        BoNavegar = False

        DtCabecera = New DataTable
        DtCabecera = L_fnCuentasPagar()

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
            .Caption = "Nro Factura"
            .Key = "nfac"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "prov"
            .Key = "prov"
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "Nombre"
            .Key = "desc"
            .Width = 200
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = "Fecha"
            .Key = "fdoc"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(5)
            .Caption = "Fecha a Pagar"
            .Key = "fven"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(6)
            .Caption = "Monto"
            .Key = "monto"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
        End With
        With Dgj1Busqueda.RootTable.Columns(7)
            .Caption = ""
            .Key = "tpago"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(8)
            .Caption = "Tipo Pago"
            .Key = "ntpago"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(9)
            .Caption = "Observación"
            .Key = "obs"
            .Width = 400
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(10)
            .Caption = "est"
            .Key = "est"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(11)
            .Caption = "Estado"
            .Key = "estado"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(12)
            .Caption = ""
            .Key = "fpro"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(13)
            .Caption = "Factura Proveedor"
            .Key = "nfpro"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(14)
            .Caption = "Nro Nota"
            .Key = "nota"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(15)
            .Caption = ""
            .Key = "tpro"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(16)
            .Caption = "Tipo Producto"
            .Key = "ntpro"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
        End With
        With Dgj1Busqueda.RootTable.Columns(17)
            .Caption = ""
            .Key = "fact"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(18)
            .Caption = ""
            .Key = "hact"
            .Width = 0
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With Dgj1Busqueda.RootTable.Columns(19)
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

        BoNavegar = True
    End Sub

    Public Overrides Function P_Validar() As Boolean
        Dim sms As String = ""

        If (Not IsNumeric(CbProveedor.Value)) Then
            sms = "debe elegir un proveedor de la lista.".ToUpper
        End If

        If (Not IsDate(DtFechaPagar.Value)) Then
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

        If (TbObs.Text = String.Empty) Then
            TbObs.Text = "S/O"
        End If

        If (SbTipoPago.Value) Then
            If (TbiNroNota.Text = String.Empty) Then
                TbiNroNota.Value = 0
            End If

            If (Not IsNumeric(CbTipoProducto.Value)) Then
                If (sms = String.Empty) Then
                    sms = "debe elegir un tipo de producto de la lista.".ToUpper
                Else
                    sms = sms + Chr(13) + "debe elegir un tipo de producto de la lista.".ToUpper
                End If
            End If
        End If

        If (SbConFactura.Value) Then
            If (Not IsDate(DtiFechaFactura.Value)) Then
                If (sms = String.Empty) Then
                    sms = "debe elegir una fecha de factura valida.".ToUpper
                Else
                    sms = sms + Chr(13) + "debe elegir una fecha factura valida.".ToUpper
                End If
            End If

            If (TbNit.Text = String.Empty Or TbNit.Text.Equals("0")) Then
                If (sms = String.Empty) Then
                    sms = "el nit de la factura no es valido.".ToUpper
                Else
                    sms = sms + Chr(13) + "el nit de la factura no es valido.".ToUpper
                End If
            End If

            If (TbRazonSocial.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "la razon social de la factura no puede quedar vacia.".ToUpper
                Else
                    sms = sms + Chr(13) + "la razon social de la factura no puede quedar vacia.".ToUpper
                End If
            End If

            If (Not TbiNroFactura.Value > 0) Then
                If (sms = String.Empty) Then
                    sms = "nro de la factura no valido.".ToUpper
                Else
                    sms = sms + Chr(13) + "nro de la factura no valido.".ToUpper
                End If
            End If

            If (TbNroAutorizacion.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "nro autorización de la factura no valido.".ToUpper
                Else
                    sms = sms + Chr(13) + "nro autorización de la factura no valido.".ToUpper
                End If
            End If

            If (TbCodigoControl.Text = String.Empty) Then
                If (sms = String.Empty) Then
                    sms = "el código de control no puede quedar vacio.".ToUpper
                Else
                    sms = sms + Chr(13) + "el código de control no puede quedar vacio.".ToUpper
                End If
            End If

            If (Not TbdMontoFactura.Value > 0) Then
                If (sms = String.Empty) Then
                    sms = "debe poner un monto de factura mayor a cero.".ToUpper
                Else
                    sms = sms + Chr(13) + "debe poner un monto de factura mayor a cero.".ToUpper
                End If
            End If

            If (TbdMontoCreditoFiscal.Value.ToString = String.Empty And TbdMontoCreditoFiscal.Value < 0) Then
                TbdMontoCreditoFiscal.Value = 0
            End If

            If (TbdDescuento.Value.ToString = String.Empty And TbdDescuento.Value < 0) Then
                TbdDescuento.Value = 0
            End If

            If (Nuevo) Then
                Dim vf As String = P_ValidarFactura()
                If (Not vf = String.Empty) Then
                    If (sms = String.Empty) Then
                        sms = vf.ToUpper
                    Else
                        sms = sms + Chr(13) + vf.ToUpper
                    End If
                End If
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

    Private Sub SbConFactura_ValueChanged(sender As Object, e As EventArgs) Handles SbConFactura.ValueChanged
        GpDatosFactura.Visible = SbConFactura.Value
        'Traer los datos de la Factura
        If (Nuevo) Then
            TbdMontoFactura.Value = TbdMonto.Value
            Dim dt As DataTable
            dt = L_fnCuentasPagarDatosFacturaRsNit(CbProveedor.Value.ToString)
            If (dt.Rows.Count > 0) Then
                TbNit.Text = dt.Rows(0).Item("cmnit").ToString
                TbRazonSocial.Text = dt.Rows(0).Item("cmrsocial").ToString
            End If
        End If

    End Sub

    Private Sub SbTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles SbTipoPago.ValueChanged
        SbEstado.Value = SbTipoPago.Value
        LblNroNota.Visible = SbTipoPago.Value
        TbiNroNota.Visible = SbTipoPago.Value
        LblTipoProducto.Visible = SbTipoPago.Value
        CbTipoProducto.Visible = SbTipoPago.Value

        If (Modificar) Then
            If (BoFlat) Then
                Dim dt As DataTable
                If (SbTipoPago.Value) Then 'Pasando de Credito a Efectivo 
                    If ((BoTpagoI = BoTpagoF)) Then
                        'No permitir cambiar si es que ya tiene pagos realizados
                        dt = L_fnPagoCuentasPagarProveedorDetalle(TbCodigo.Text.Trim)
                        If (dt.Rows.Count > 0) Then
                            BoFlat = False
                            SbTipoPago.Value = False
                            ToastNotification.Show(Me, "no se puede pasar de crédito a efectivo. ".ToUpper + ChrW(13) _
                                                   + "esta cuenta ya tiene pagos realizados. ".ToUpper + ChrW(13) _
                                                   + "para cambiar a efectivo, primero elimine los pagos de la cuenta.".ToUpper,
                                                   My.Resources.WARNING,
                                                   Duracion * 1500,
                                                   eToastGlowColor.Red,
                                                   eToastPosition.TopCenter)
                        End If
                    End If
                Else 'Pasando de Efectivo a Credito
                    'Borrar los pagos y cambiar el estado a pendiente, Dar avertencia
                    dt = L_fnPagoCuentasPagarProveedorDetalle(TbCodigo.Text.Trim)
                    If (dt.Rows.Count > 0) Then
                        Dim info As New TaskDialogInfo("aviso importante!!!".ToUpper,
                                                   eTaskDialogIcon.Stop,
                                                   "advertencia".ToUpper,
                                                   "al pasar de efectivo a crédito se perderá el pago en efectivo. ".ToUpper + Chr(13) + "Desea continuar?".ToUpper,
                                                   eTaskDialogButton.Yes Or eTaskDialogButton.Cancel,
                                                   eTaskDialogBackgroundColor.Red)
                        Dim result As eTaskDialogResult = TaskDialog.Show(info)
                        If (result = eTaskDialogResult.Yes) Then
                            'Eliminar Pagos
                            BoTpagoF = False
                            'Dim res = L_fnEliminarPagoCuentaPagar2(TbCodigo.Text.Trim)
                        Else
                            BoTpagoF = True
                            BoFlat = False
                            SbTipoPago.Value = True
                        End If
                    End If
                End If
            Else
                BoFlat = True
            End If

        End If

    End Sub

    Private Function P_ValidarFactura() As String
        Dim dt As New DataTable
        Dim sms As String = ""
        dt = L_fnCuentasPagarValidarFactura(TbNit.Text.Trim, TbiNroFactura.Value.ToString, TbCodigoControl.Text.Trim)
        If (dt.Rows.Count > 0) Then
            If (dt.Rows.Count = 1) Then
                sms = sms + "nit, nro. de factura y código de control que quiere grabar, ya esta grabado." _
                    + ChrW(13) + "en la cuenta por pagar con código : " + dt.Rows(0).Item("fcanumi").ToString + ""
            Else
                Dim ccp As String = ""
                For Each f As DataRow In dt.Rows
                    ccp = ccp + f.Item("fcanumi").ToString + ", "
                Next
                ccp = ccp.Substring(0, ccp.Length - 2)
                sms = sms + "nit, nro. de factura y código de control que quiere grabar, ya estan grabados." _
                    + ChrW(13) + "en las cuentas por pagar con códigos : " + ccp + ""
            End If
        End If
        Return sms
    End Function

    'Private Sub TbdMonto_Leave(sender As Object, e As EventArgs) Handles TbdMonto.Leave
    '    'If (Modificar) Then
    '    '    Dim dt As DataTable = L_fnCuentasPagarValidarMontoPagado(TbCodigo.Text.Trim)
    '    '    If (TbdMonto.Value < dt.Rows(0).Item("monto")) Then
    '    '        TbdMonto.Select()
    '    '        Dim info As New TaskDialogInfo("No se puede modificar el monto".ToUpper,
    '    '                                       eTaskDialogIcon.Information,
    '    '                                       "advertencia".ToUpper,
    '    '                                       "el monto actual es menor a la suma de los pagos realizados, ".ToUpper _
    '    '                                       + "si desea continuar vaya al pagos realizados y elimine un pago, ".ToUpper _
    '    '                                       + "o modifique el monto actual para que sea mayor o igual a ".ToUpper _
    '    '                                       + dt.Rows(0).Item("monto").ToString,
    '    '                                       eTaskDialogButton.Ok,
    '    '                                       eTaskDialogBackgroundColor.Red)
    '    '        TaskDialog.Show(info)
    '    '    End If
    '    'End If
    'End Sub

    Private Sub CbProveedor_ValueChanged(sender As Object, e As EventArgs) Handles CbProveedor.ValueChanged
        If (IsNumeric(CbProveedor.Value)) Then
            TbObsProveedor.Text = L_fnCuentasPagarDatosFacturaRsNit(CbProveedor.Value.ToString).Rows(0).Item("cmobs").ToString
        Else
            TbObsProveedor.Clear()
        End If
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TCP001", "cpa", "cpanumi=" + TbCodigo.Text)
            If IsDBNull(dtAud.Rows(0).Item(0)) = True Then
                lbFecha.Text = ""
            Else
                lbFecha.Text = Convert.ToDateTime(dtAud.Rows(0).Item(0)).ToString("dd/MM/yyyy")
            End If
            lbHora.Text = dtAud.Rows(0).Item(1).ToString
            lbUsuario.Text = dtAud.Rows(0).Item(2).ToString
            FlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            FlyoutUsuario.Content = PanelUsuario
        End If

    End Sub

    Private Sub BBtn_Usuario_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Usuario.Click
        FlyoutUsuario_PrepareContent(BubbleBar5, e)
    End Sub


    Private Sub TbdMontoFactura_ValueChanged(sender As Object, e As EventArgs) Handles TbdMontoFactura.ValueChanged
        TbdMontoCreditoFiscal.Value = TbdMontoFactura.Value
    End Sub

    Private Sub CbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles CbProveedor.KeyDown
        If (Nuevo Or Modificar) Then
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