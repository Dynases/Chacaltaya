Imports Logica.AccesoLogica
Imports Modelos.M_Global
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports System.Threading
Imports DevComponents.DotNetBar.Rendering

Public Class P_Principal

#Region "Atributos"

    Dim tiempoMensaje As Integer = 5000
    Dim ThCliente As Thread

#End Region

#Region "Metodos Privados"
    Public Sub New()
        _prCambiarStyle()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub _PIniciarTodo()
        If (Not Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator = ".") Then
            Dim info As New TaskDialogInfo("leer con atención!!!".ToUpper,
                                           eTaskDialogIcon.Information, "información".ToUpper,
                                           "la configuración de separador de decimal tiene que ser punto (.)".ToUpper _
                                           + vbCrLf + "Porfavor cambiar la configuración regional de números y monedas".ToUpper,
                                           eTaskDialogButton.Ok,
                                           eTaskDialogBackgroundColor.Blue)
            Dim result As eTaskDialogResult = TaskDialog.Show(info)
            Me.Close()
        End If

        'Leer Archivo de Configuración
        _prLeerArchivoConfig()
        _prCargarLogo()


        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)

        Me.WindowState = FormWindowState.Maximized

        _PIniciarPedidosPeriodicosAtomaticamente()
        '_PPasivarClientes()

        '------------------------------------------Ocultando para DisoftBHF----------------------------------------------
        'FP_Ventas.Visible = False
        'FP_RecursosHumanos.Visible = False
        'FP_Compras.Visible = False

        'Cargar Clientes global
        ThCliente = New Thread(AddressOf Me.prCargarClientes)
        ThCliente.Start()

        'iniciar login de usuario
        _PLogin()
        'btConfClientes.Enabled = False


        'configuracion para mapaiso
        Dim mapaiso As Boolean = False
        If mapaiso = True Then
            FP_RecursosHumanos.Text = "PERSONAL"
            FP_Compras.Visible = False
        End If
    End Sub
    Private Sub _prCambiarStyle()
        'tratar de cambiar estilo
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eStyle.VisualStudio2012Dark)
        'RibbonPredefinedColorSchemes.ChangeStyle(eStyle.VisualStudio2012Dark)

        'cambio de otros colores
        Dim table As Office2007ColorTable = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable
        Dim ct As SideNavColorTable = table.SideNav
        ct.TitleBackColor = Color.Black
        'ct.SideNavItem.MouseOver.BackColors = New Color() {Color.Red, Color.Yellow}
        ct.SideNavItem.MouseOver.BorderColors = New Color() {Color.Black} ' No border
        ct.SideNavItem.Selected.BackColors = New Color() {Color.Yellow}
        ct.BorderColors = New Color() {Color.Black} ' Control border color

        ct.PanelBackColor = Color.Black
    End Sub
    Private Sub _prCargarLogo()
        'gs_CarpetaRaiz
        Dim exists As Boolean
        exists = System.IO.File.Exists(gs_CarpetaRaiz + "\imagenlogo.jpg")
        If exists = True Then
            'cargar imagen
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage

            PictureBox1.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox2.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox3.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox4.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox5.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox6.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            PictureBox7.Load(gs_CarpetaRaiz + "\imagenlogo.jpg")
            Me.Refresh()

        End If

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True

        'cargar el fondo de pantalla
        Dim ruta As String = gs_CarpetaRaiz + "\imagenfondo.jpg"
        exists = System.IO.File.Exists(ruta)
        If exists = True Then
            'cargar imagen
            'MetroTilePanel1.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
            'PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage

            MetroTilePanel1.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel2.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel3.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel4.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel5.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel6.BackgroundImage = Image.FromFile(ruta)
            MetroTilePanel7.BackgroundImage = Image.FromFile(ruta)

            Me.Refresh()

        End If

        PictureBox1.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox7.Visible = True
        Me.Refresh()
    End Sub

    Private Sub _PLogin()
        Dim Frm As New P_Inicio
        Frm.ShowDialog()
        While gs_Usuario = "RESTAR"
            Frm.ShowDialog()
        End While

        L_Usuario = gs_Usuario
        Modelos.M_Global.G_Usuario = gs_Usuario

        lbUsuario.Text = gs_Usuario
        lbUsuario.Font = New Font("Tahoma", 12, FontStyle.Bold)

        If gs_Usuario = "DEFAULT" Then
            SideNav1.Enabled = False
        Else
            _PCargarPrivilegios2()
            SideNav1.Enabled = True
        End If

        'mostrar o no mapas
        Dim dtConfSistema As DataTable = L_ConfSistemaGeneral()
        If dtConfSistema.Rows(0).Item("cccmapa") = 0 Then
            gb_mostrarMapa = False
        Else
            gb_mostrarMapa = True
        End If

        'Bloquear o no manuales
        gi_bloqueoManuales = dtConfSistema.Rows(0).Item("cccblma")
        gi_notiPed = dtConfSistema.Rows(0).Item("cccnotiped")
        gi_expcli = dtConfSistema.Rows(0).Item("cccexpcli")
        gs_color = IIf(IsDBNull(dtConfSistema.Rows(0).Item("ccccolor")) = True, gs_color, dtConfSistema.Rows(0).Item("ccccolor"))
        Modelos.M_Global.gs_color = gs_color

        'iniciar timer de mensajeria
        TimerMensajeria.Start()
        TimerMensajeria.Interval = 5000
    End Sub

    Private Sub _PPasivarClientes()
        Dim dtClienteCarlos As DataTable = L_GetCliente2("12467").Tables(0)
        Dim estado As Boolean = dtClienteCarlos.Rows(0).Item("ccest")

        If estado = True Then
            L_GrabarModificarCliente("ccest=0", "ccnumi=12467")

            Dim dtClientes As DataTable = L_GetClientes()
            For i = 0 To dtClientes.Rows.Count - 1
                Dim dtPed As DataTable = L_PedidoCabecera_GeneralTop10(-1, " AND oaccli=" + dtClientes.Rows(i).Item("ccnumi").ToString() + " AND oaest>=1 AND oaest<=4 and oaap=1 ")
                If dtPed.Rows.Count > 0 And dtClientes.Rows(i).Item("ccest") = 1 Then
                    Dim fecha As DateTime = dtPed.Rows(0).Item("oafdoc")
                    Dim diasTrans As Integer = DateDiff(DateInterval.Day, fecha, Today.Date)
                    If diasTrans >= 90 Then
                        L_GrabarModificarCliente("ccest=0", "ccnumi=" + dtClientes.Rows(i).Item("ccnumi").ToString())
                    End If

                End If

            Next

        End If

    End Sub

    Private Sub _PIniciarPedidosPeriodicosAtomaticamente()
        Dim dtFechaFrecPed = L_PedidoDetalleFechaFrecPedido_General2(Today.Date.ToString("yyyy-MM-dd"))
        If dtFechaFrecPed.Rows.Count = 0 Then 'significa que no se genero pedidos automaticamente en el dia asi que hay que verificar los que halla
            Dim dtPedidosBase As DataTable = L_PedidoCabecera_General(-1, " AND oaest=10")
            For i = 0 To dtPedidosBase.Rows.Count - 1
                Dim numi As String = dtPedidosBase.Rows(i).Item("oanumi").ToString()
                _PGenerarPedidosPeriodicamente(numi, dtPedidosBase.Rows(i))
            Next

        End If
    End Sub

    Private Sub _PGenerarPedidosPeriodicamente(numi As String, fila As DataRow)
        Dim dtFechaFrecPed = L_PedidoDetalleFechaFrecPedido_General(numi, Today.Date.ToString("yyyy-MM-dd"))
        If dtFechaFrecPed.Rows.Count > 0 Then 'significa que ya se genero un pedido en el dia
            'ToastNotification.Show(Me, "ya se genero pedidos hoy a partir de esta base periodica".ToUpper, My.Resources.WARNING, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            Exit Sub
        End If

        Dim dt As DataTable = L_PedidoDetalleFrecuencia_General(-1, numi)
        If dt.Rows.Count > 0 Then
            Dim diasSem As String = dt.Rows(0).Item("ohdiassem")

            Dim grabar As Boolean = False
            Dim fecha As Date = Today.Date
            If diasSem <> "0" Then 'geerar pedidos automaticamente
                Select Case Today.DayOfWeek
                    Case DayOfWeek.Monday
                        grabar = IIf(diasSem(6) = "1", True, False)
                    Case DayOfWeek.Tuesday
                        grabar = IIf(diasSem(5) = "1", True, False)
                    Case DayOfWeek.Wednesday
                        grabar = IIf(diasSem(4) = "1", True, False)
                    Case DayOfWeek.Thursday
                        grabar = IIf(diasSem(3) = "1", True, False)
                    Case DayOfWeek.Friday
                        grabar = IIf(diasSem(2) = "1", True, False)
                    Case DayOfWeek.Saturday
                        grabar = IIf(diasSem(1) = "1", True, False)
                    Case DayOfWeek.Sunday
                        grabar = IIf(diasSem(0) = "1", True, False)
                End Select
            Else
                Dim cadaDias As Integer = dt.Rows(0).Item("ohdias")
                If cadaDias <> 0 Then

                Else
                    Dim diaMes As Integer = dt.Rows(0).Item("ohdiames")

                    If fecha.Day = diaMes Then
                        Dim dtFeriados As DataTable = L_Feriado_General(0).Tables(0)
                        Dim listFeriados As New List(Of DateTime)
                        For i = 0 To dtFeriados.Rows.Count - 1
                            Dim fs As String = dtFeriados.Rows(i).Item("pfflib").ToString
                            Dim f As DateTime = Convert.ToDateTime(fs)
                            listFeriados.Add(f)
                        Next

                        'recorrer la fecha hasta un dia que no sea feriado o fin de semana
                        While listFeriados.Contains(fecha) = True Or (fecha.DayOfWeek = DayOfWeek.Sunday Or fecha.DayOfWeek = DayOfWeek.Saturday) = True
                            fecha = DateAdd(DateInterval.Day, 1, fecha)
                        End While
                        grabar = True
                    End If
                End If
            End If

            If grabar = True Then
                'GRABAR PEDIDO
                Dim idPedido As String = ""
                L_PedidoCabecera_Grabar(idPedido, fecha, Now.Hour.ToString + ":" + Now.Minute.ToString, fila.Item("oaccli"), fila.Item("oazona"), fila.Item("oaobs"), "1", "1", "1")

                'grabar detalle
                Dim codProd, cant, precio, subTotal As String
                Dim dtDetallePed As DataTable = L_PedidoDetalle_General(-1, numi)
                For i = 0 To dtDetallePed.Rows.Count - 1
                    codProd = dtDetallePed.Rows(i).Item("obcprod").ToString
                    cant = dtDetallePed.Rows(i).Item("obpcant").ToString
                    precio = dtDetallePed.Rows(i).Item("obpbase").ToString
                    subTotal = dtDetallePed.Rows(i).Item("obptot").ToString
                    L_PedidoDetalle_Grabar(idPedido, codProd, cant, precio, subTotal)
                Next
                'grabar estado del pedido
                L_PedidoEstados_Grabar(idPedido, "11", Date.Now.Date.ToString("yyyy/MM/dd"), Now.Hour.ToString + ":" + Now.Minute.ToString, fila.Item("oaobs"))

                L_PedidoDetalleFechaFrecPedido_Grabar(numi, Today.Date.ToString("yyyy-MM-dd"))
                'ToastNotification.Show(Me, "Codigo de Pedido " + idPedido + " Generado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            Else
                'ToastNotification.Show(Me, "No hay ningun pedido programado para hoy", My.Resources._ERROR, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            End If
        End If
    End Sub
    Private Sub _PCargarPrivilegios()
        Dim idRolUsu As String = L_Usuario_General(-1, " AND yduser='" + gs_Usuario + "' ").Tables(0).Rows(0).Item("ybnumi")

        Dim dtModulos As DataTable = L_General_LibreriaDetalle(-1, "11").Tables(0)
        Dim listFormsModulo As New List(Of String)
        For i = 0 To dtModulos.Rows.Count - 1
            Dim dtDetRol As DataTable = L_RolDetalle_General(-1, idRolUsu, dtModulos.Rows(i).Item("cenum"))
            listFormsModulo = New List(Of String)

            If dtDetRol.Rows.Count > 0 Then
                For Each fila As DataRow In dtDetRol.Rows
                    listFormsModulo.Add(fila.Item("yaprog"))
                Next
                '////////////
                For Each _item As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.MetroTilePanel3.Items, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, Me.MetroTilePanel6.Items)))))
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        If listFormsModulo.Contains(btn.Name) Then
                            Dim Texto As String = btn.Text
                            Dim TTexto As String = btn.TitleText
                            Dim f As Integer = listFormsModulo.IndexOf(btn.Name)
                            If Texto = "" Then 'esta usando el Title Text
                                btn.TitleText = dtDetRol.Rows(f).Item("yatit")
                            Else 'esta usando el Text
                                btn.Text = dtDetRol.Rows(f).Item("yatit")
                            End If

                            If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                btn.Visible = True
                            Else
                                btn.Visible = False
                            End If
                        Else
                            btn.Visible = False
                        End If
                    End If
                Next
            Else ' no exiten formulario registrados en el modulo pero igual hay que ocultarlos
                For Each _item As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.MetroTilePanel3.Items, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, Me.MetroTilePanel6.Items)))))
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        btn.Visible = False
                    Else
                        For Each _subitem As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.ItemContainer1.SubItems, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, Me.ItemContainer2.SubItems)))))
                            If TypeOf (_subitem) Is DevComponents.DotNetBar.Metro.MetroTileItem Then
                                Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_subitem, DevComponents.DotNetBar.Metro.MetroTileItem)
                                btn.Visible = False
                            End If
                        Next
                    End If
                Next

            End If

        Next

        'refrescar el formulario
        Me.Refresh()

    End Sub

    Private Sub _PCargarPrivilegios2()
        Dim DtUsuario As DataTable = L_Usuario_General(-1, " AND yduser='" + gs_Usuario + "' ").Tables(0)
        gs_CodigoUsuario = DtUsuario.Rows(0).Item("ydnumi")

        Dim idRolUsu As String = DtUsuario.Rows(0).Item("ybnumi")

        Dim dtModulos As DataTable = L_General_LibreriaDetalle(-1, "11").Tables(0)
        Dim listFormsModulo As New List(Of String)

        For i = 0 To dtModulos.Rows.Count - 1
            Dim dtDetRol As DataTable = L_RolDetalle_General(-1, idRolUsu, dtModulos.Rows(i).Item("cenum"))
            listFormsModulo = New List(Of String)

            If dtDetRol.Rows.Count > 0 Then
                'cargo los nombres de los programas(botones) del modulo
                For Each fila As DataRow In dtDetRol.Rows
                    listFormsModulo.Add(fila.Item("yaprog").ToString.ToUpper)
                Next
                'recorro el modulo(tab) que corresponde
                For Each _item As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.MetroTilePanel3.Items, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, IIf(i = 5, Me.MetroTilePanel6.Items, Me.MetroTilePanel7.Items))))))
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        If listFormsModulo.Contains(btn.Name.ToUpper) Then 'si el nombre del boton pertenece a la lista de formularios del modulo
                            Dim Texto As String = btn.Text
                            Dim TTexto As String = btn.TitleText
                            Dim f As Integer = listFormsModulo.IndexOf(btn.Name.ToUpper)
                            If Texto = "" Then 'esta usando el Title Text
                                btn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            Else 'esta usando el Text
                                btn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            End If

                            If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                btn.Visible = True
                            Else
                                btn.Visible = False
                            End If
                        Else 'si no pertenece lo oculto
                            btn.Visible = False
                        End If
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                If listFormsModulo.Contains(_subBtn.Name.ToUpper) Then
                                    Dim Texto As String = _subBtn.Text
                                    Dim TTexto As String = _subBtn.TitleText
                                    Dim f As Integer = listFormsModulo.IndexOf(_subBtn.Name.ToUpper)
                                    If Texto = "" Then 'esta usando el Title Text
                                        _subBtn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    Else 'esta usando el Text
                                        _subBtn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    End If

                                    If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                        _subBtn.Visible = True
                                    Else
                                        _subBtn.Visible = False
                                    End If
                                Else
                                    _subBtn.Visible = False
                                End If
                            Next
                        End If

                    End If
                Next
            Else ' no exiten formulario registrados en el modulo pero igual hay que ocultar los botones y los subbotones que tenga
                For Each _item As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.MetroTilePanel3.Items, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, IIf(i = 5, Me.MetroTilePanel6.Items, Me.MetroTilePanel7.Items))))))
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        btn.Visible = False
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                _subBtn.Visible = False
                            Next
                        End If
                        ''
                        'For Each _subitem As DevComponents.DotNetBar.BaseItem In IIf(i = 0, Me.MetroTilePanel1.Items, IIf(i = 1, Me.MetroTilePanel2.Items, IIf(i = 2, Me.ItemContainer1.SubItems, IIf(i = 3, Me.MetroTilePanel4.Items, IIf(i = 4, Me.MetroTilePanel5.Items, Me.ItemContainer2.SubItems)))))
                        '    If TypeOf (_subitem) Is DevComponents.DotNetBar.Metro.MetroTileItem Then
                        '        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_subitem, DevComponents.DotNetBar.Metro.MetroTileItem)
                        '        btn.Visible = False
                        '    End If
                        'Next
                    End If
                Next

            End If

        Next

        'refrescar el formulario
        Me.Refresh()
    End Sub

    Private Sub AlertClicked(ByVal alertId As Long)

        'L_MensajeriaModificarLeido(alertId.ToString(), "1")
        Dim form As New P_Mensajeria()
        form._lectura = True
        form.Show()

        TimerMensajeria.Interval = (60 * 1000 * 2) + 666
    End Sub

#End Region

    Private Sub P_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub btConfClientes_Click(sender As Object, e As EventArgs) Handles btConfClientes.Click
        Dim form As New P_Clientes
        form.Show()
    End Sub

    Private Sub btLogiZonas_Click(sender As Object, e As EventArgs) Handles btLogiZonas.Click
        Dim form As New P_Zonas
        form.Show()
    End Sub


    Private Sub btPediPedidos_Click(sender As Object, e As EventArgs) Handles btPediPedidos.Click
        Dim form As New P_Pedidos
        form.Show()
    End Sub

    Private Sub btPediControlPedidos_Click(sender As Object, e As EventArgs) Handles btPediControlPedidos.Click
        Dim form As New P_PedidosAsignacion
        form.Show()
    End Sub

    Private Sub btConfProductos_Click(sender As Object, e As EventArgs) Handles btConfProductos.Click
        Dim form As New P_Producto
        form.Show()
    End Sub

    Private Sub btConfPrecioProductos_Click(sender As Object, e As EventArgs) Handles btConfPrecioProductos.Click
        Dim form As New P_PrecioProductos
        form.Show()
    End Sub

    Private Sub btVentNotas_Click(sender As Object, e As EventArgs) Handles btVentNotas.Click
        Dim form As New P_Notas
        form.Show()
    End Sub

    Private Sub btRRHHPersonal_Click(sender As Object, e As EventArgs) Handles btRRHHPersonal.Click
        Dim form As New P_EmpleadosCOPY
        form.Show()
    End Sub

    Private Sub btRRHHDescFijos_Click(sender As Object, e As EventArgs) Handles btRRHHDescFijos.Click
        Dim form As New P_DescuentosFijos
        form.Show()
    End Sub

    Private Sub btRRHHAntigueVacaciones_Click(sender As Object, e As EventArgs) Handles btRRHHAntigueVacaciones.Click
        Dim form As New P_Bonos
        form.Show()
    End Sub

    Private Sub btRRHHBonosDesc_Click(sender As Object, e As EventArgs) Handles btRRHHBonosDesc.Click
        Dim form As New P_BonosDescuentos
        form.Show()
    End Sub

    Private Sub btPediMonitoreoPed_Click(sender As Object, e As EventArgs) Handles btPediMonitoreoPed.Click
        Dim form As New P_MonitoreoPedidos
        form.Show()
    End Sub

    Private Sub btRRHHRepPlanillaSueldos_Click(sender As Object, e As EventArgs) Handles btRRHHRepPlanillaSueldos.Click
        Dim form As New PR_PlanillaSueldos
        form.Show()
    End Sub

    Private Sub btRRHHFeriados_Click(sender As Object, e As EventArgs) Handles btRRHHFeriados.Click
        Dim form As New P_Feriados
        form.Show()
    End Sub

    Private Sub btRRHHPedidoVacacion_Click(sender As Object, e As EventArgs) Handles btRRHHPedidoVacacion.Click
        Dim form As New P_PedidoVacacion
        form.Show()
    End Sub

    Private Sub btPediControlReclamos_Click(sender As Object, e As EventArgs) Handles btPediControlReclamos.Click
        Dim form As New P_ControlReclamos
        form.Show()
    End Sub

    Private Sub btVentPagos_Click(sender As Object, e As EventArgs) Handles btVentPagos.Click
        Dim form As New P_Pagos
        form.Show()
    End Sub

    Private Sub btPediRepEntregaPedidos_Click(sender As Object, e As EventArgs) Handles btPediRepEntregaPedidos.Click
        Dim form As New PR_EntregaPedidos
        form.Show()
    End Sub

    Private Sub btVentRepFidelidadCliente_Click(sender As Object, e As EventArgs) Handles btVentRepFidelidadCliente.Click
        Dim form As New PR_FidelidadCliente
        form.Show()
    End Sub

    Private Sub btVentRepResumenNotas_Click(sender As Object, e As EventArgs) Handles btVentRepResumenNotas.Click
        Dim form As New PR_ResumenNotas
        form.Show()
    End Sub

    Private Sub btPediRepUltimosPedidos_Click(sender As Object, e As EventArgs) Handles btPediRepUltimosPedidos.Click
        Dim form As New PR_UltimosPedidos
        form.Show()
    End Sub

    Private Sub btPediRepTransacciones_Click(sender As Object, e As EventArgs) Handles btPediRepTransacciones.Click
        Dim form As New PR_Transacciones
        form.Show()
    End Sub

    Private Sub btPediRepPromConsumo_Click(sender As Object, e As EventArgs) Handles btPediRepPromConsumo.Click
        Dim form As New PR_PromConsumo
        form.Show()
    End Sub

    Private Sub btConfFormularios_Click(sender As Object, e As EventArgs) Handles btConfFormularios.Click
        Dim form As New P_Formularios
        form.Show()
    End Sub

    Private Sub btConfRoles_Click(sender As Object, e As EventArgs) Handles btConfRoles.Click
        Dim form As New P_Roles
        form.Show()
    End Sub

    Private Sub btConfUsuarios_Click(sender As Object, e As EventArgs) Handles btConfUsuarios.Click
        Dim form As New P_Usuarios
        form.Show()
    End Sub

    Private Sub btPediPedidoPeriodico_Click(sender As Object, e As EventArgs) Handles btPediPedidoPeriodico.Click
        Dim form As New P_Pedidos
        form._nuevoBasePeriodico = True
        form.Show()
    End Sub

    Private Sub P_Principal_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If gs_Usuario = "DEFAULT" Then
            Dim Frm As New P_Inicio
            Frm.ShowDialog()

            L_Usuario = gs_Usuario
            If gs_Usuario = "DEFAULT" Then
                SideNav1.Enabled = False
            Else
                _PCargarPrivilegios2()
                SideNav1.Enabled = True
            End If
        End If
    End Sub

    Private Sub P_Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If gs_Usuario = "DEFAULT" Then
            Dim Frm As New P_Inicio
            Frm.ShowDialog()

            L_Usuario = gs_Usuario
            If gs_Usuario = "DEFAULT" Then
                SideNav1.Enabled = False
            Else
                _PCargarPrivilegios2()
                SideNav1.Enabled = True
            End If
        End If
    End Sub

    Private Sub rmSesion_ItemClick(sender As Object, e As EventArgs) Handles rmSesion.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Select Case item.Name
                Case "btCerrarSesion"
                    P_Global.gs_Usuario = "DEFAULT"
                    _PLogin()
                Case "btSalir"
                    Close()
                Case "btAbout"
                    Dim frm As New P_Acerca
                    frm.ShowDialog()
            End Select

        End If
    End Sub


    Private Sub btVentRepSaldoClientes1_Click(sender As Object, e As EventArgs) Handles btVentRepSaldoClientes1.Click
        Dim form As New P_SaldoClientes
        form.Show()
    End Sub

    Private Sub btVentRepPagos_Click(sender As Object, e As EventArgs) Handles btVentRepPagos.Click
        Dim form As New PR_Pagos
        form.Show()
    End Sub

    Private Sub btVentRepFacturas_Click(sender As Object, e As EventArgs) Handles btVentRepFacturas.Click
        Dim form As New PR_Facturas
        form.Show()
    End Sub

    Private Sub btVentRepKardexPrestamos_Click(sender As Object, e As EventArgs) Handles btVentRepKardexPrestamos.Click
        Dim form As New PR_KardexPrestamos
        form.Show()
    End Sub

    Private Sub btVentRepKardexClientes_Click(sender As Object, e As EventArgs) Handles btVentRepKardexClientes.Click
        Dim form As New P_KardexCliente
        form.Show()
    End Sub

    Private Sub btVentRepGraficoVentas_Click(sender As Object, e As EventArgs) Handles btVentRepGraficoVentas.Click
        Dim form As New PR_GraficasLinealVentas
        form.Show()
    End Sub

    Private Sub btConfRepClientes_Click(sender As Object, e As EventArgs) Handles btConfRepClientes.Click
        Dim form As New PR_Clientes
        form.Show()
    End Sub

    Private Sub btVentRepLibroVentas_Click(sender As Object, e As EventArgs) Handles btVentRepLibroVentas.Click
        Dim form As New P_LibroVentasChacaltaya
        form.Show()
    End Sub

    Private Sub btConfLibrerias_Click(sender As Object, e As EventArgs) Handles btConfLibrerias.Click
        Dim form As New P_Librerias
        form.Show()
    End Sub

    Private Sub btVentRepCompara_Click(sender As Object, e As EventArgs) Handles btVentRepCompara.Click
        Dim form As New P_Compara
        form.Show()
    End Sub

    Private Sub btConfMensajeria_Click(sender As Object, e As EventArgs) Handles btConfMensajeria.Click
        Dim form As New P_Mensajeria
        form.Show()
    End Sub

    Private Sub TimerMensajeria_Tick(sender As Object, e As EventArgs) Handles TimerMensajeria.Tick
        If TimerMensajeria.Interval = (60 * 1000 * 2) + 666 Then
            TimerMensajeria.Interval = 5000
            Exit Sub
        End If

        Dim dt As New DataTable
        dt = L_MensajeriaGeneral("cjpara=" + gi_userNumi.ToString + " and cjleido=0")
        If dt.Rows.Count > 0 Then
            Dim mensaje, usuario As String
            Dim numi As Long
            numi = dt.Rows(0).Item("cjnumi")
            mensaje = dt.Rows(0).Item("cjnota")
            usuario = dt.Rows(0).Item("yduser1")

            'Dim mensajeCompleto As String = mensaje + ". " + vbCrLf + "<b>" + usuario + "</b>."
            Dim mensajeCompleto As String = "<b>" + "tiene un mensaje nuevo del usuario : " + usuario + "</b>"
            DesktopAlert.Show(mensajeCompleto, ChrW(&HF005).ToString(), eSymbolSet.Awesome, System.Drawing.Color.Empty, eDesktopAlertColor.Blue, eAlertPosition.TopRight, tiempoMensaje \ 1000, numi, AddressOf AlertClicked)
            tiempoMensaje = tiempoMensaje + (1000 * 60 * 1)
            TimerMensajeria.Interval = tiempoMensaje

        End If
    End Sub


    Private Sub btVentSaldoMensuales_Click(sender As Object, e As EventArgs) Handles btVentSaldoMensuales.Click
        Dim form As New P_SaldoMensuales
        form.Show()
    End Sub

#Region "INVENTARIOS"

#Region "EQUIPOS"

    Private Sub btInveEquiISInventario_Click(sender As Object, e As EventArgs) Handles btInveEquiISInventario.Click
        Dim form As New P_Movimientos
        form.pTitulo = "M O V I M I E N T O   D E   E Q U I P O S"
        form.pTipo = 1
        form.Show()
    End Sub

    Private Sub btInveEquiSaldoAlmacen_Click(sender As Object, e As EventArgs) Handles btInveEquiSaldoAlmacen.Click
        Dim form As New PR_StockActualEquipoProducto
        form.pTitulo = "S A L D O   A C T U A L   D E   E Q U I P O S"
        form.pTipo = 1
        form.Show()
    End Sub

    Private Sub btInveEquiKadexEquipo_Click(sender As Object, e As EventArgs) Handles btInveEquiKadexEquipo.Click
        Dim form As New P_KardexInventario
        form.pTitulo = "K A R D E X   D E   E Q U I P O S"
        form.pTipo = 1
        form.Show()
    End Sub

    Private Sub btInveEquiConceptoInvePresEquiCliente_Click(sender As Object, e As EventArgs) Handles btInveEquiConceptoInvePresEquiCliente.Click
        Dim form As New F0_ConceptoInventario
        form.pStTitulo = "C O N C E P T O S   D E   P R E S T A M O   D E   E Q U I P O S   E N   C L I E N T E S"
        form.pInTipo = 1
        form.Show()
    End Sub

    Private Sub btInveConceptoInventario_Click(sender As Object, e As EventArgs) Handles btInveEquiConceptoInventarioEquipo.Click
        Dim form As New F0_ConceptoInventario
        form.pStTitulo = "C O N C E P T O S   D E   I N V E N T A R I O   D E   E Q U I P O S"
        form.pInTipo = 2
        form.Show()
    End Sub

#Region "EQUIPOS REPORTES"

    Private Sub btInveRepPrestamosEquipoDetallado_Click(sender As Object, e As EventArgs) Handles btInveRepPrestamoEquiposDetallado.Click
        Dim form As New PR_PrestamoEquipoDetallado
        form.Show()
    End Sub

    Private Sub btInveRepPrestamosEquipoAgrupados_Click(sender As Object, e As EventArgs) Handles btInveRepPrestamoEquiposAgrupados.Click
        Dim form As New PR_PrestamoEquiposAgrupado
        form.Show()
    End Sub

#End Region

#End Region

#Region "PRODUCTOS"

    Private Sub btInveProdISInventario_Click(sender As Object, e As EventArgs) Handles btInveProdISInventario.Click
        Dim form As New P_Movimientos
        form.pTitulo = "M O V I M I E N T O   D E   P R O D U C T O S"
        form.pTipo = 2
        form.Show()
    End Sub

    Private Sub btInveProdSaldoAlmacen_Click(sender As Object, e As EventArgs) Handles btInveProdSaldoAlmacen.Click
        Dim form As New PR_StockActualEquipoProducto
        form.pTitulo = "S A L D O   A C T U A L   D E   P R O D U C T O S"
        form.pTipo = 2
        form.Show()
    End Sub

    Private Sub btInveProdKadexProducto_Click(sender As Object, e As EventArgs) Handles btInveProdKadexProducto.Click
        Dim form As New P_KardexInventario
        form.pTitulo = "K A R D E X   D E   P R O D U C T O S"
        form.pTipo = 2
        form.Show()
    End Sub

    Private Sub btInveEquiConceptoInventarioProducto_Click(sender As Object, e As EventArgs) Handles btInveEquiConceptoInventarioProducto.Click
        Dim form As New F0_ConceptoInventario
        form.pStTitulo = "C O N C E P T O S   D E   I N V E N T A R I O   D E   P R O D U C T O S"
        form.pInTipo = 3
        form.Show()
    End Sub

#End Region

#End Region


    Private Sub btConfManuales_Click(sender As Object, e As EventArgs) Handles btConfManuales.Click
        Dim form As New P_Manuales
        form.Show()
    End Sub

    Private Sub btConfMisManuales_Click(sender As Object, e As EventArgs) Handles btConfMisManuales.Click
        Dim form As New P_ManualesVista
        form.Show()
    End Sub

    Private Sub _prLeerArchivoConfig()
        Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIG.TXT")
        gs_Ip = Archivo(0).Split("=")(1).Trim
        gs_UsuarioSql = Archivo(1).Split("=")(1).Trim
        gs_ClaveSql = Archivo(2).Split("=")(1).Trim
        gs_NombreBD = Archivo(3).Split("=")(1).Trim
        gs_CarpetaRaiz = Archivo(4).Split("=")(1).Trim
        gs_RutaManuales = Archivo(5).Split("=")(1).Trim
        gs_FtpIp = Archivo(6).Split("=")(1).Trim
        gs_FtpUsuario = Archivo(7).Split("=")(1).Trim
        gs_FtpPassword = Archivo(8).Split("=")(1).Trim


        If (Not IO.Directory.Exists(gs_CarpetaRaiz)) Then
            IO.Directory.CreateDirectory(gs_CarpetaRaiz)
        End If
        If (Not IO.Directory.Exists(gs_RutaManuales)) Then
            IO.Directory.CreateDirectory(gs_RutaManuales)
        End If
    End Sub

    Private Sub btRRHHTurnos_Click(sender As Object, e As EventArgs) Handles btRRHHTurnos.Click
        Dim form As New F0_Turnos
        form.Show()
    End Sub

    Private Sub btRRHHAsistencia_Click(sender As Object, e As EventArgs) Handles btRRHHCargarAsistencia.Click
        Dim form As New F0_Asistencia
        form.Show()
    End Sub

    Private Sub btCompProveedor_Click(sender As Object, e As EventArgs) Handles btCompProveedor.Click
        Dim form As New P_Proveedor
        form.Show()
    End Sub

    Private Sub btCompCuentasPagar_Click(sender As Object, e As EventArgs) Handles btCompCuentasPagar.Click
        Dim form As New P_CuentaPagar
        form.Show()
    End Sub

    Private Sub btCompPagoCuentasPagar_Click(sender As Object, e As EventArgs) Handles btCompPagoCuentasPagar.Click
        Dim form As New P_PagoCuentasPagar
        form.Show()
    End Sub

    Private Sub btCompRepCuentasPagarProximosPagos_Click(sender As Object, e As EventArgs) Handles btCompRepCuentasPagarProximosPagos.Click
        Dim form As New PR_CuentasPagar_PagosProximos
        form.Show()
    End Sub

    Private Sub btCompRepCuentasPagarPagosRealizados_Click(sender As Object, e As EventArgs) Handles btCompRepCuentasPagarPagosRealizados.Click
        Dim form As New PR_CuentasPagar_PagosRealizados
        form.Show()
    End Sub

    Private Sub btRRHHPlanillaTurnos_Click(sender As Object, e As EventArgs) Handles btRRHHPlanillaTurnos.Click
        Dim form As New F0_PlanillaTurnos
        form.Show()
    End Sub

    Private Sub btRRHHRepAsistencia_Click(sender As Object, e As EventArgs) Handles btRRHHRepAsistencia.Click
        Dim form As New PR_Asistencia
        form.Show()
    End Sub

    Private Sub prCargarClientes()
        P_Global.gt_Cliente = New DataTable
        P_Global.gt_Cliente = L_fnClientes()
        P_Global.gb_DtClienteEstado = True
        'btConfClientes.Enabled = True
        'btConfClientes.Refresh()
        ThCliente.Abort()
    End Sub

    Private Sub P_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btVentRepLibroVentas2_Click(sender As Object, e As EventArgs) Handles btVentRepLibroVentas2.Click
        Dim form As New P_LibroVentas
        form.Show()
    End Sub


    Private Sub btPediMonitoreoClientes_Click(sender As Object, e As EventArgs) Handles btPediMonitoreoClientes.Click
        Dim form As New F1_MapaCLientes
        form.Show()
    End Sub

    Private Sub btPediRepReclamos_Click(sender As Object, e As EventArgs) Handles btPediRepReclamos.Click
        Dim form As New PR_Reclamos
        form.Show()
    End Sub

    Private Sub btVentRepFaltanteTapas_Click(sender As Object, e As EventArgs) Handles btVentRepFaltanteTapas.Click
        Dim form As New PR_FaltanteTapas
        form.Show()
    End Sub

    Private Sub btVentRepUltimaVentaCliente_Click(sender As Object, e As EventArgs) Handles btVentRepUltimaVentaCliente.Click
        Dim form As New PR_UltimaVentaCliente
        form.Show()
    End Sub

    Private Sub btVentRepSaldoPrestamoEquiposUV_Click(sender As Object, e As EventArgs) Handles btVentRepSaldoPrestamoEquiposUV.Click
        Dim form As New PR_SaldoPrestamoEquiposUV
        form.Show()
    End Sub

    Private Sub btRRHHRepPlanillaSueldosG_Click(sender As Object, e As EventArgs) Handles btRRHHRepPlanillaSueldosG.Click
        Dim form As New PR_PlanillaSueldosGrabado
        form.Show()
    End Sub

    Private Sub btRRHHMarcacionCorr_Click(sender As Object, e As EventArgs) Handles btRRHHMarcacionCorr.Click
        Dim form As New F0_MarcacionCorrecion
        form.Show()
    End Sub

    Private Sub btRRHHRepMensualMarc_Click(sender As Object, e As EventArgs) Handles btRRHHRepMensualMarc.Click
        Dim form As New PR_PlanillaMensualMarcacion
        form.Show()
    End Sub

    Private Sub btVentRepDiferenciaPedidoNota_Click(sender As Object, e As EventArgs) Handles btVentRepDiferenciaPedidoNota.Click
        Dim form As New PR_DiferenciaPedidoNota
        form.Show()
    End Sub

    Private Sub btVentRepFacturaVsVenta_Click(sender As Object, e As EventArgs) Handles btVentRepFacturaVsVenta.Click
        Dim form As New PR_FacturaVsVenta
        form.Show()
    End Sub

    Private Sub btCompRepLibroCompra_Click(sender As Object, e As EventArgs) Handles btCompRepLibroCompra.Click
        Dim form As New F3_LibroCompra
        form.Show()
    End Sub

    Private Sub btVentRepKardexDocCliente_Click(sender As Object, e As EventArgs) Handles btVentRepKardexDocCliente.Click
        Dim form As New P_ChaKardexClienteDocCliente
        form.Show()
    End Sub

    Private Sub btPediRepProductoPenDicEntregar_Click(sender As Object, e As EventArgs) Handles btPediRepProductoPenDicEntregar.Click
        Dim form As New PR_ProductoPendienteDictado_Resumido
        form.Show()
    End Sub

    Private Sub btLogiMovChoferSalida_Click(sender As Object, e As EventArgs) Handles btLogiMovChoferSalida.Click
        Dim form As New F0G_MovimientoChoferSalida
        form.Show()
    End Sub

    Private Sub btLogiMovChoferConciliacion_Click(sender As Object, e As EventArgs) Handles btLogiMovChoferConciliacion.Click
        Dim form As New F0G_MovimientoChoferEntrada
        form.Show()
    End Sub

    Private Sub btVentRepVentasProducto_Click(sender As Object, e As EventArgs) Handles btVentRepVentasProducto.Click
        Dim form As New PR_VentasPorProductos
        form.Show()
    End Sub

    Private Sub btnBono_Descuento_Click(sender As Object, e As EventArgs) Handles btnBono_Descuento.Click
        Dim form As New PR_Descuento
        form.Show()
    End Sub

    Private Sub btInvSaldoVsProd_CheckedChanged(sender As Object, e As EventArgs) Handles btInvComparaProd.CheckedChanged

    End Sub

    Private Sub btInvSaldoVsProd_Click(sender As Object, e As EventArgs) Handles btInvComparaProd.Click
        Dim form As New P_ComparaSaldoProducto
        form.Tipo = 0
        form.Show()
    End Sub

    Private Sub btInvComparaEquipo_Click(sender As Object, e As EventArgs) Handles btInvComparaEquipo.Click
        Dim form As New P_ComparaSaldoProducto
        form.Tipo = 1
        form.Show()
    End Sub

    Private Sub btConfCategoria_Click(sender As Object, e As EventArgs) Handles btConfCategoria.Click
        Dim form As New F_Categoria
        form.Show()
    End Sub

    Private Sub btInveRepPrestamoEquiposRepartidor_Click(sender As Object, e As EventArgs) Handles btInveRepPrestamoEquiposRepartidor.Click
        Dim form As New Pr_EquiposAgrupadoChofer
        form.Show()
    End Sub
End Class