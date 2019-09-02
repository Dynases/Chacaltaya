Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class P_Zonas
#Region "Variables"
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean

    Dim _poligono As Integer
    Dim _listPuntos As List(Of PointLatLng)
    Dim _overlay As GMapOverlay

#End Region

#Region "Recursos"
    'Google Maps Satélite.
    'Google Maps Callejero.
    'Google Maps Híbrido.
    'OpenStreetMap.
    'OpenClycleMap.
#End Region

#Region "Metodos Privados"
    Private Sub _CargarListaEmpleados()
        Dim dt As DataTable = L_Empleado_General_ProgramaZona(-1, "and cbcat=1 and cbest=1").Tables(0)

        dgjRepartidor.DataSource = dt
        dgjRepartidor.RetrieveStructure()

        With dgjRepartidor.RootTable.Columns("cbnumi")
            .Visible = False
        End With
        With dgjRepartidor.RootTable.Columns("cbdesc")
            .Caption = "Usuario"
            .CellStyle.TextAlignment = TextAlignment.Near
            .Width = 250
            .HeaderStyle.TextAlignment = TextAlignment.Center
            .HeaderStyle.Font = New Font("Arial", gi_fuenteTamano + 2)
            .CellStyle.Font = New Font("Arial", gi_fuenteTamano + 1)
            .AllowSort = False
        End With
        With dgjRepartidor.RootTable.Columns("check")
            .Caption = "Check"
            .CellStyle.TextAlignment = TextAlignment.Near
            .Width = 80
            .HeaderStyle.TextAlignment = TextAlignment.Center
            .HeaderStyle.Font = New Font("Arial", gi_fuenteTamano + 2)
            .CellStyle.Font = New Font("Arial", gi_fuenteTamano + 1)
            .AllowSort = False
        End With

        With dgjRepartidor
            .GroupByBoxVisible = False
            .FilterMode = FilterMode.None
            .AlternatingColors = True
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub
    Private Sub _cargarMapa()
        GM_mapa.DragButton = MouseButtons.Left
        GM_mapa.CanDragMap = True
        GM_mapa.MapProvider = GMapProviders.GoogleMap
        GM_mapa.Position = New PointLatLng(-17.782814, -63.182386)
        GM_mapa.MinZoom = 0
        GM_mapa.MaxZoom = 24
        GM_mapa.Zoom = 14
        GM_mapa.AutoScroll = True
        GMapProvider.Language = LanguageType.Spanish

        'GM_mapa.Manager.Mode = AccessMode.CacheOnly
        'GM_mapa.CacheLocation = ""

        'añadir puntos
        'Dim markersOverlay As New GMapOverlay("markers")
        'Dim marker As New GMarkerGoogle(New PointLatLng(-17.782814, -63.182386), GMarkerGoogleType.green)
        ''añadir tooltip
        'Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
        'marker.ToolTip = New GMapBaloonToolTip(marker)
        'marker.ToolTipMode = mode
        'Dim ToolTipBackColor As New SolidBrush(Color.Red)
        'marker.ToolTip.Fill = ToolTipBackColor
        'marker.ToolTipText = "Cliente 1"

        'markersOverlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)

        'añadir poligono

        'Dim points As New List(Of PointLatLng)
        'points.Add(New PointLatLng(-17.78596, -63.216289))
        'points.Add(New PointLatLng(-17.785321, -63.204572))
        'points.Add(New PointLatLng(-17.7942, -63.204268))
        'points.Add(New PointLatLng(-17.797033, -63.215597))
        'Dim polygon As New GMapPolygon(points, "mypolygon")
        'polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Red))
        'polygon.Stroke = New Pen(Color.Red, 1)
        '_overlay.Polygons.Add(polygon)
        'GM_mapa.Overlays.Add(_overlay)
    End Sub
    Private Sub _AgregarPunto(pointLatLng As PointLatLng, Optional etiqueta As String = "")

        'añadir puntos
        ''Dim markersOverlay As New GMapOverlay("markers")
        Dim marker As New GMarkerGoogle(pointLatLng, GMarkerGoogleType.blue)
        'añadir tooltip
        If etiqueta <> "" Then
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.Red)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTipText = etiqueta
        End If
        _overlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)
    End Sub

    Private Sub _LlenarComboLibreria(ByVal cb As Janus.Windows.GridEX.EditControls.MultiColumnCombo, ByVal concep As Integer)
        Dim _Ds As New DataSet
        _Ds = L_General_LibreriaDetalle(-1, concep)

        cb.DropDownList.Columns.Clear()

        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cenum").ToString).Width = 50
        cb.DropDownList.Columns(0).Caption = "Código"
        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc").ToString).Width = 250
        cb.DropDownList.Columns(1).Caption = "Descripcion"

        cb.ValueMember = _Ds.Tables(0).Columns("cenum").ToString
        cb.DisplayMember = _Ds.Tables(0).Columns("cedesc").ToString
        cb.DataSource = _Ds.Tables(0)
        cb.Refresh()

    End Sub

    Private Sub _CargarComboCiudad()
        Dim _Ds As New DataSet
        _Ds = L_General_LibreriaDetalle(-1, 13)

        J_Cb_Ciudad.DropDownList.Columns.Clear()
        J_Cb_Ciudad.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cenum").ToString).Width = 50
        J_Cb_Ciudad.DropDownList.Columns(0).Caption = "Código"
        J_Cb_Ciudad.DropDownList.Columns.Add(_Ds.Tables(0).Columns(1).ToString).Width = 250
        J_Cb_Ciudad.DropDownList.Columns(1).Caption = "Descripcion"

        J_Cb_Ciudad.ValueMember = _Ds.Tables(0).Columns(0).ToString
        J_Cb_Ciudad.DisplayMember = _Ds.Tables(0).Columns(1).ToString
        J_Cb_Ciudad.DataSource = _Ds.Tables(0)
        J_Cb_Ciudad.Refresh()

    End Sub

    Private Sub _Habilitar()


        BBt_1.Enabled = False
        BBt_2.Enabled = False
        BBt_3.Enabled = False
        BBt_4.Enabled = True

        ButtonX1.Enabled = True


        J_Cb_Ciudad.Enabled = True
        J_Cb_Provincia.Enabled = True
        J_Cb_Zona.Enabled = True

        dgjRepartidor.AllowEdit = InheritableBoolean.True

    End Sub
    Private Sub _Inhabilitar()
        Tb_Id.Enabled = False

        BBt_1.Enabled = True
        BBt_2.Enabled = True
        BBt_3.Enabled = True
        BBt_4.Enabled = False

        ButtonX1.Enabled = False

        Lb_CantReg.Text = ""

        Pan_Dialogo.Visible = False

        J_Cb_Ciudad.Enabled = False
        J_Cb_Provincia.Enabled = False
        J_Cb_Zona.Enabled = False

        BBt_4.Image = My.Resources.GRABAR
        BBt_4.ImageLarge = My.Resources.GRABAR

        _overlay.Markers.Clear()
        _overlay.Polygons.Clear()

        _LimpiarErrores()

        dgjRepartidor.AllowEdit = InheritableBoolean.False

        ButtonX1.Text = "Marcar Zona"

        btAgregarCiudad.Visible = False
        btAgregarProv.Visible = False
        btAgregarZona.Visible = False
    End Sub
    Private Sub _LimpiarErrores()
        Ep1.Clear()
        Ep2.Clear()
        J_Cb_Ciudad.BackColor = Color.White
        J_Cb_Provincia.BackColor = Color.White
        J_Cb_Zona.BackColor = Color.White
        ButtonX1.BackColor = Color.White
    End Sub
    Private Sub _Limpiar()
        Tb_Id.Text = ""
        Tb_color.Text = ""

        'aumentado 
        Lb_CantReg.Text = ""
        _listPuntos.Clear()
        _overlay.Polygons.Clear()
        _overlay.Markers.Clear()

        _CargarListaEmpleados()

        btAgregarCiudad.Visible = False
        btAgregarProv.Visible = False
        btAgregarZona.Visible = False
    End Sub
    'Private Sub _LlenarFiltrador()
    '    Dim _Ds As New DataSet
    '    _Ds = L_General_LibreriaCabecera(0)
    '    J_Mc_LibCabecera.DropDownList.Columns.Clear()

    '    J_Mc_LibCabecera.DropDownList.Columns.Add(_Ds.Tables(0).Columns(0).ToString).Width = 50
    '    J_Mc_LibCabecera.DropDownList.Columns(0).Caption = "Código"
    '    J_Mc_LibCabecera.DropDownList.Columns.Add(_Ds.Tables(0).Columns(2).ToString).Width = 250
    '    J_Mc_LibCabecera.DropDownList.Columns(1).Caption = "Descripcion"

    '    J_Mc_LibCabecera.ValueMember = _Ds.Tables(0).Columns(0).ToString
    '    J_Mc_LibCabecera.DisplayMember = _Ds.Tables(0).Columns(2).ToString
    '    J_Mc_LibCabecera.DataSource = _Ds.Tables(0)
    '    J_Mc_LibCabecera.Refresh()

    '    'J_Mc_LibCabecera.SelectedIndex = 0


    'End Sub
    Private Sub _IniciarTodo()

        'abrir conexion
        'L_abrirConexion()

        'cargar configuracion de mapas
        If gb_mostrarMapa = False Then
            GM_mapa.Visible = False
            PanelEx6.Visible = False
        End If

        _CargarListaEmpleados()
        _poligono = 0
        _listPuntos = New List(Of PointLatLng)
        _overlay = New GMapOverlay("polygons")
        GM_mapa.Overlays.Add(_overlay)


        _cargarMapa()
        _LlenarComboLibreria(J_Cb_Ciudad, 4)
        _LlenarComboLibreria(J_Cb_Provincia, 3)
        _LlenarComboLibreria(J_Cb_Zona, 2)


        _Filtrar()
        _Inhabilitar()


    End Sub

    Private Sub _Filtrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_ZonaCabecera_General(0)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _MostrarRegistro(_Pos)
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                BBt_First.Visible = True
                BBt_Back.Visible = True
                BBt_Next.Visible = True
                BBt_Last.Visible = True
            End If
        End If

    End Sub
    Private Sub _MostrarRegistro(_N As Integer)

        Tb_Id.Text = _Dsencabezado.Tables(0).Rows(_N).Item(0)

        Dim codCiudad As String = _Dsencabezado.Tables(0).Rows(_N).Item(1)
        J_Cb_Ciudad.Text = L_Validar_LibreriasDetalle(4, codCiudad)

        Dim codProv As String = _Dsencabezado.Tables(0).Rows(_N).Item(2)
        J_Cb_Provincia.Text = L_Validar_LibreriasDetalle(3, codProv)

        Dim codZona As String = _Dsencabezado.Tables(0).Rows(_N).Item(3)
        J_Cb_Zona.Text = L_Validar_LibreriasDetalle(2, codZona)

        'cargar zona en mapa
        Dim tPuntos As DataTable = L_ZonaDetallePuntos_General(-1, Tb_Id.Text).Tables(0)
        Dim i As Integer
        Dim lati, longi As Double
        _listPuntos.Clear()
        For i = 0 To tPuntos.Rows.Count - 1
            lati = tPuntos.Rows(i).Item(1)
            longi = tPuntos.Rows(i).Item(2)
            Dim plg As PointLatLng = New PointLatLng(lati, longi)
            _listPuntos.Add(plg)
        Next

        If (GM_mapa.Visible) Then 'AUMENTADO PARA QUE SI ESTA VISIBLE EL MAPA DIBUJE LA ZONA
            If tPuntos.Rows.Count > 0 Then
                'posicionar en la zona
                Dim latiZona, longiZona As Double
                latiZona = tPuntos.Rows(0).Item(1)
                longiZona = tPuntos.Rows(0).Item(2)
                GM_mapa.Position = New PointLatLng(latiZona, longiZona)

                Dim colorZona As String = _Dsencabezado.Tables(0).Rows(_N).Item(4)
                ColorDialog1.Color = ColorTranslator.FromHtml(colorZona)

                Tb_color.Text = colorZona

                Dim polygon As New GMapPolygon(_listPuntos, "mypolygon")
                'agregar color
                polygon.Fill = New SolidBrush(Color.FromArgb(50, ColorDialog1.Color))
                polygon.Stroke = New Pen(Color.Red, 1)
                _overlay.Polygons.Clear()
                _overlay.Polygons.Add(polygon)
            Else
                _overlay.Polygons.Clear()
            End If

        End If

        'cargar lista repartidores
        Dim tRep As DataTable = L_ZonaDetalleRepartidor_General(-1, Tb_Id.Text).Tables(0)
        For Each fil1 As DataRow In tRep.Rows
            For Each fil2 As GridEXRow In dgjRepartidor.GetRows
                If (fil1.Item("lccbnumi") = fil2.Cells("cbnumi").Value) Then
                    fil2.BeginEdit()
                    fil2.Cells("check").Value = True
                    fil2.EndEdit()
                Else
                    fil2.BeginEdit()
                    fil2.Cells("check").Value = False
                    fil2.EndEdit()
                End If
            Next
        Next
    End Sub

    Private Function _Validar() As Boolean
        Dim _Error As Boolean = False
        If J_Cb_Ciudad.SelectedIndex < 0 Then
            J_Cb_Ciudad.BackColor = Color.Red   'error de validacion
            Ep1.SetError(J_Cb_Ciudad, "tiene que elegir ciudad".ToUpper)
            _Error = True
        Else
            J_Cb_Ciudad.BackColor = Color.White
            Ep1.SetError(J_Cb_Ciudad, "")
        End If

        If J_Cb_Provincia.SelectedIndex < 0 Then
            J_Cb_Provincia.BackColor = Color.Red   'error de validacion
            Ep1.SetError(J_Cb_Provincia, "tiene que elegir provincia".ToUpper)
            _Error = True
        Else
            J_Cb_Provincia.BackColor = Color.White
            Ep1.SetError(J_Cb_Provincia, "")
        End If

        If J_Cb_Zona.SelectedIndex < 0 Then
            J_Cb_Zona.BackColor = Color.Red   'error de validacion
            Ep1.SetError(J_Cb_Zona, "tiene que elegir zona".ToUpper)
            _Error = True
        Else
            J_Cb_Zona.BackColor = Color.White
            Ep1.SetError(J_Cb_Zona, "")
        End If

        'Comentado Para que no Grabe los mapas
        'If _listPuntos.Count < 3 And Tb_color.Text = "" Then
        '    ButtonX1.BackColor = Color.Red   'error de validacion
        '    Ep1.SetError(ButtonX1, "Tiene que marcar la Zona")
        '    _Error = True
        'Else
        '    ButtonX1.BackColor = Color.White
        '    Ep1.SetError(ButtonX1, "")
        'End If

        Return _Error
    End Function

    Private Function _ValidarCombos() As Boolean
        Dim mensaje As String = "No existe los siguientes datos: " + vbCrLf
        Dim _Error As Boolean = False
        If J_Cb_Ciudad.SelectedIndex < 0 Then
            J_Cb_Ciudad.BackColor = Color.Yellow   'error de validacion
            Ep2.SetError(J_Cb_Ciudad, "No Existe la Ciudad")
            _Error = True
            mensaje = mensaje + "-Ciudad: " + J_Cb_Ciudad.Text + vbCrLf
        Else
            J_Cb_Ciudad.BackColor = Color.White
            Ep2.SetError(J_Cb_Ciudad, "")
        End If

        If J_Cb_Provincia.SelectedIndex < 0 Then
            J_Cb_Provincia.BackColor = Color.Yellow  'error de validacion
            Ep2.SetError(J_Cb_Provincia, "No Existe la Provincia")
            _Error = True
            mensaje = mensaje + "-Provincia: " + J_Cb_Provincia.Text + vbCrLf
        Else
            J_Cb_Provincia.BackColor = Color.White
            Ep2.SetError(J_Cb_Provincia, "")
        End If

        If J_Cb_Zona.SelectedIndex < 0 Then
            J_Cb_Zona.BackColor = Color.Yellow  'error de validacion
            Ep2.SetError(J_Cb_Zona, "No Existe la Zona")
            _Error = True
            mensaje = mensaje + "-Zona: " + J_Cb_Zona.Text + vbCrLf
        Else
            J_Cb_Zona.BackColor = Color.White
            Ep2.SetError(J_Cb_Zona, "")
        End If

        If _Error = True Then
            Pan_Dialogo.Visible = True
            mensaje = mensaje + "¿Desea insertar los nuevos datos mencionados?"
            Lb_MensajeDialog.Text = mensaje
            Btn_OpcionOK.Focus()
        End If

        Return _Error
    End Function

    Private Sub _GrabarRegistro()
        Dim _Error As Boolean = False
        J_Cb_Ciudad.Select()
        If _Validar() Then
            Exit Sub
        End If
        If BBt_4.Enabled = False Then
            Exit Sub
        End If
        'validar los combos
        'If _ValidarCombos() = True Then
        '    Exit Sub
        'Else
        '    Pan_Dialogo.Visible = False
        'End If

        'If Lb_Mensaje.Text = "" Then
        '    Lb_Mensaje.Text = "Esta Seguro de Grabar?"
        '    Exit Sub
        'Else
        '    Lb_Mensaje.Text = ""
        'End If
        If BBt_4.Tag = 0 Then
            BBt_4.Tag = 1
            BBt_4.Image = My.Resources.CONFIRMACION
            BBt_4.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar1.Refresh()
            Exit Sub
        Else
            BBt_4.Tag = 0
            BBt_4.Image = My.Resources.GRABAR
            BBt_4.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If


        If _Nuevo Then
            L_ZonaCabecera_Grabar(Tb_Id.Text, J_Cb_Ciudad.Value, J_Cb_Provincia.Value, J_Cb_Zona.Value, Tb_color.Text)
            'grabar detalle
            Dim i As Integer
            Dim lati, longi As Double
            For i = 0 To _listPuntos.Count - 1
                lati = _listPuntos.Item(i).Lat
                longi = _listPuntos.Item(i).Lng
                L_ZonaDetallePuntos_Grabar(Tb_Id.Text, lati, longi)
            Next

            'grabar detalle repartidores
            For Each fil As GridEXRow In dgjRepartidor.GetRows
                If (fil.Cells("check").Value) Then
                    L_ZonaDetalleRepartidor_Grabar(Tb_Id.Text, fil.Cells("cbnumi").Value.ToString)
                End If
            Next

            J_Cb_Ciudad.Focus()
            ''Lb_Mensaje.Text = "Codigo de Movimiento " + Tb_Id.Text + " Grabado con Exito."
            'ToastNotification.Show(Me, "Codigo de Movimiento " + Tb_Id.Text + " Grabado con Exito.", Nothing, 500, eToastGlowColor.Blue, eToastPosition.BottomLeft)
            ToastNotification.Show(Me, "Codigo de Movimiento " + Tb_Id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            'Tsbl0_Mensaje.Text = ""
            _Limpiar()
        Else
            L_ZonaCabacera_Modificar(Tb_Id.Text, J_Cb_Ciudad.Value, J_Cb_Provincia.Value, J_Cb_Zona.Value, Tb_color.Text)
            'grabar detalle
            L_ZonaDetallePuntos_Borrar(Tb_Id.Text)
            Dim i As Integer
            Dim lati, longi As Double
            For i = 0 To _listPuntos.Count - 1
                lati = _listPuntos.Item(i).Lat
                longi = _listPuntos.Item(i).Lng
                L_ZonaDetallePuntos_Grabar(Tb_Id.Text, lati, longi)
            Next

            'grabar detalle repartidores
            L_ZonaDetalleRepartidor_Borrar(Tb_Id.Text)
            For Each fil As GridEXRow In dgjRepartidor.GetRows
                If (fil.Cells("check").Value) Then
                    L_ZonaDetalleRepartidor_Grabar(Tb_Id.Text, fil.Cells("cbnumi").Value.ToString)
                End If
            Next

            ToastNotification.Show(Me, "Codigo de Movimiento " + Tb_Id.Text + " Modificado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            '_Deshabilitar()

            'TSB0_5.PerformClick()
            _Nuevo = False 'aumentado danny
            '_Modificar = False 'aumentado danny
            _Inhabilitar()
            _Filtrar()
        End If
    End Sub

    Private Sub _NuevoRegistro()
        _Habilitar()
        _Limpiar()
        J_Cb_Ciudad.Focus()
        _Nuevo = True

        GM_mapa.Position = New PointLatLng(-17.380941, -66.15976)
        GM_mapa.Zoom = 13
    End Sub

    Private Sub _ModificarRegistro()
        _Nuevo = False
        '_Modificar = True
        _Habilitar()
    End Sub

    Private Sub _EliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("Esta seguro de Eliminar el Registro?", MsgBoxStyle.YesNo, "Advertencia")
        If _Result = MsgBoxResult.Yes Then
            L_ZonaCabecera_Borrar(Tb_Id.Text)
            L_ZonaDetallePuntos_Borrar(Tb_Id.Text)
            L_ZonaDetalleRepartidor_Borrar(Tb_Id.Text)

            _Filtrar()

            'mi codigo, actualizo el sub
            _Pos = 0
            Lb_CantReg.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub _SalirRegistro()
        If BBt_4.Enabled = True Then
            _Inhabilitar()
            _Filtrar()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _GrabarNuevasLibrerias()
        Dim codCiu, codProv, codZona As Integer
        If J_Cb_Ciudad.SelectedIndex < 0 Then
            L_Grabar_LibreriaDetalle(4, 4, codCiu, J_Cb_Ciudad.Text)
            _LlenarComboLibreria(J_Cb_Ciudad, 4)
            J_Cb_Ciudad.Value = codCiu
            Ep2.SetError(J_Cb_Ciudad, "")
        End If

        If J_Cb_Provincia.SelectedIndex < 0 Then
            L_Grabar_LibreriaDetalle(3, 3, codProv, J_Cb_Provincia.Text)
            _LlenarComboLibreria(J_Cb_Provincia, 3)
            J_Cb_Provincia.Value = codProv
            Ep2.SetError(J_Cb_Provincia, "")
        End If

        If J_Cb_Zona.SelectedIndex < 0 Then
            L_Grabar_LibreriaDetalle(2, 2, codZona, J_Cb_Zona.Text)
            _LlenarComboLibreria(J_Cb_Zona, 2)
            J_Cb_Zona.Value = codZona
            Ep2.SetError(J_Cb_Zona, "")
        End If
        Pan_Dialogo.Visible = False
    End Sub
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        ''Dim gm As GMapControl = CType(sender, GMapControl)
        ''Dim hj As MouseEventArgs = CType(e, MouseEventArgs)
        ''Dim plg As New PointLatLng(TextBox1.Text, TextBox2.Text)
        ''_agregarPunto(plg)

        'If ButtonX1.Text = "Terminar" Then
        '    'GM_mapa.Refresh()
        '    'mapa.PolygonsEnabled = True
        '    'Dim polyOverlay As New GMapOverlay("polygons")
        '    Dim polygon As New GMapPolygon(_listPuntos, "mypolygon")
        '    'agregar color
        '    If ColorDialog1.ShowDialog() = DialogResult.OK Then
        '        polygon.Fill = New SolidBrush(Color.FromArgb(50, ColorDialog1.Color))
        '        Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
        '        Tb_color.Text = hexa
        '    Else
        '        polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Blue))
        '        Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
        '        Tb_color.Text = hexa
        '    End If

        '    'polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Black))
        '    polygon.Stroke = New Pen(Color.Red, 1)
        '    _overlay.Polygons.Clear()
        '    _overlay.Polygons.Add(polygon)
        '    'añadir tooltip a poligono

        '    ''mapa.Overlays.Add(polyOverlay)

        '    _listPuntos.Clear()
        '    _overlay.Markers.Clear()
        '    _poligono = 0

        '    ButtonX1.Text = "Crear"
        'Else
        '    ButtonX1.Text = "Terminar"
        '    _poligono = 1
        'End If

    End Sub

    Private Sub P_Mapas2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub


    Private Sub mapa_MouseClick(sender As Object, e As MouseEventArgs) Handles GM_mapa.MouseClick
        If _poligono = 1 Then
            Dim gm As GMapControl = CType(sender, GMapControl)
            Dim hj As MouseEventArgs = CType(e, MouseEventArgs)
            Dim plg As PointLatLng = gm.FromLocalToLatLng(hj.X, hj.Y)
            _AgregarPunto(plg)
            _listPuntos.Add(plg)
        End If


        '_agregarPunto(plg)
        'Refresh()
        '_agregarPunto(mapa.FromLocalToLatLng(e.X, e.Y))
    End Sub


    Private Sub mapa_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GM_mapa.MouseDoubleClick
        If e.Button = MouseButtons.Left Then

            'Cursor.Current = Cursors.WaitCursor

            Dim latLng As PointLatLng = GM_mapa.FromLocalToLatLng(e.X, e.Y)
            _AgregarPunto(latLng)


        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        If ButtonX1.Text = "Terminar" Then
            'GM_mapa.Refresh()
            'mapa.PolygonsEnabled = True
            'Dim polyOverlay As New GMapOverlay("polygons")
            Dim polygon As New GMapPolygon(_listPuntos, "mypolygon")
            'agregar color
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                polygon.Fill = New SolidBrush(Color.FromArgb(50, ColorDialog1.Color))
                Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
                Tb_color.Text = hexa
            Else
                polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Blue))
                Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
                Tb_color.Text = hexa
            End If

            'polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Black))
            polygon.Stroke = New Pen(Color.Red, 1)
            _overlay.Polygons.Clear()
            _overlay.Polygons.Add(polygon)
            'añadir tooltip a poligono

            ''mapa.Overlays.Add(polyOverlay)

            _overlay.Markers.Clear()
            _poligono = 0

            ButtonX1.Text = "Marcar Zona"
        Else
            ButtonX1.Text = "Terminar"
            _poligono = 1
            _listPuntos.Clear()
        End If
    End Sub

    Private Sub J_Cb_Ciudad_ValueChanged(sender As Object, e As EventArgs) Handles J_Cb_Ciudad.ValueChanged
        If J_Cb_Ciudad.SelectedIndex >= 0 Then
            Dim ciudad As String = J_Cb_Ciudad.Text
            Select Case ciudad
                Case "COCHABAMBA"
                    GM_mapa.Position = New PointLatLng(-17.380941, -66.15976)
                Case "ORURO"
                    GM_mapa.Position = New PointLatLng(-17.967867, -67.117933)
                Case "SANTA CRUZ"
                    GM_mapa.Position = New PointLatLng(-17.782814, -63.182386)
            End Select

            Ep2.SetError(J_Cb_Ciudad, "")
            J_Cb_Ciudad.BackColor = Color.White
        Else
            If J_Cb_Ciudad.Value <> Nothing Then
                btAgregarCiudad.Visible = True
            Else
                btAgregarCiudad.Visible = False
            End If

            'Ep2.SetError(J_Cb_Ciudad, "No existe la ciudad")
            'J_Cb_Ciudad.BackColor = Color.Yellow
        End If



    End Sub

    Private Sub BBt_1_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs)
        _NuevoRegistro()
    End Sub

    Private Sub BBt_2_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs)
        _ModificarRegistro()
    End Sub

    Private Sub BBt_3_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs)
        _EliminarRegistro()
    End Sub

    Private Sub BBt_4_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_4.Click
        _GrabarRegistro()
    End Sub

    Private Sub BBt_5_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_5.Click
        _SalirRegistro()
    End Sub

    Private Sub BBt_First_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_First.Click
        _Pos = 0
        _MostrarRegistro(_Pos)
        Lb_CantReg.Text = "Reg: " + Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub

    Private Sub BBt_Back_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_Back.Click
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _MostrarRegistro(_Pos)
            Lb_CantReg.Text = "Reg: " + Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub BBt_Next_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_Next.Click
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _MostrarRegistro(_Pos)
            Lb_CantReg.Text = "Reg: " + Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub BBt_Last_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_Last.Click
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _MostrarRegistro(_Pos)
        Lb_CantReg.Text = "Reg: " + Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub

    Private Sub J_Cb_Provincia_ValueChanged(sender As Object, e As EventArgs) Handles J_Cb_Provincia.ValueChanged
        If J_Cb_Provincia.SelectedIndex >= 0 Then
            Ep2.SetError(J_Cb_Provincia, "")
            J_Cb_Provincia.BackColor = Color.White
        Else
            If J_Cb_Provincia.Value <> Nothing Then
                btAgregarProv.Visible = True
            Else
                btAgregarProv.Visible = False
            End If
            'Ep2.SetError(J_Cb_Provincia, "No existe la provincia")
            'J_Cb_Provincia.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub J_Cb_Zona_ValueChanged(sender As Object, e As EventArgs) Handles J_Cb_Zona.ValueChanged
        If J_Cb_Zona.SelectedIndex >= 0 Then
            Ep2.SetError(J_Cb_Zona, "")
            J_Cb_Zona.BackColor = Color.White
        Else
            If J_Cb_Zona.Value <> Nothing Then
                btAgregarZona.Visible = True
            Else
                btAgregarZona.Visible = False
            End If
            'Ep2.SetError(J_Cb_Zona, "No existe la zona")
            'J_Cb_Zona.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub BBt_1_Click_1(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_1.Click
        _NuevoRegistro()
    End Sub

    Private Sub BBt_2_Click_1(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBt_2.Click
        _ModificarRegistro()
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If ButtonX1.Text = "Terminar" Then
            'GM_mapa.Refresh()
            'mapa.PolygonsEnabled = True
            'Dim polyOverlay As New GMapOverlay("polygons")
            Dim polygon As New GMapPolygon(_listPuntos, "mypolygon")
            'agregar color
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                polygon.Fill = New SolidBrush(Color.FromArgb(50, ColorDialog1.Color))
                Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
                Tb_color.Text = hexa
            Else
                polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Blue))
                Dim hexa As String = String.Format("#{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
                Tb_color.Text = hexa
            End If

            'polygon.Fill = New SolidBrush(Color.FromArgb(50, Color.Black))
            polygon.Stroke = New Pen(Color.Red, 1)
            _overlay.Polygons.Clear()
            _overlay.Polygons.Add(polygon)
            'añadir tooltip a poligono

            ''mapa.Overlays.Add(polyOverlay)

            _overlay.Markers.Clear()
            _poligono = 0

            ButtonX1.Text = "Marcar Zona"
        Else
            ButtonX1.Text = "Terminar"
            _poligono = 1
            _listPuntos.Clear()
        End If
    End Sub

    Private Sub Btn_OpcionOK_Click(sender As Object, e As EventArgs) Handles Btn_OpcionOK.Click
        _GrabarNuevasLibrerias()
        'grabar el registro
        If _Nuevo Then
            L_ZonaCabecera_Grabar(Tb_Id.Text, J_Cb_Ciudad.Value, J_Cb_Provincia.Value, J_Cb_Zona.Value, Tb_color.Text)
            'grabar detalle
            Dim i As Integer
            Dim lati, longi As Double
            For i = 0 To _listPuntos.Count - 1
                lati = _listPuntos.Item(i).Lat
                longi = _listPuntos.Item(i).Lng
                L_ZonaDetallePuntos_Grabar(Tb_Id.Text, lati, longi)
            Next

            J_Cb_Ciudad.Focus()
            ''Lb_Mensaje.Text = "Codigo de Movimiento " + Tb_Id.Text + " Grabado con Exito."
            ToastNotification.Show(Me, "Codigo de Movimiento " + Tb_Id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            'Tsbl0_Mensaje.Text = ""
            _Limpiar()
        Else
            L_ZonaCabacera_Modificar(Tb_Id.Text, J_Cb_Ciudad.Value, J_Cb_Provincia.Value, J_Cb_Zona.Value, Tb_color.Text)
            '_Deshabilitar()

            'TSB0_5.PerformClick()
            _Nuevo = False 'aumentado danny
            '_Modificar = False 'aumentado danny
            _Inhabilitar()
            _Filtrar()
        End If
    End Sub

    Private Sub Btn_OpcionCancel_Click(sender As Object, e As EventArgs) Handles Btn_OpcionCancel.Click
        Pan_Dialogo.Visible = False

    End Sub

    Private Sub BBt_3_Click_1(sender As Object, e As ClickEventArgs) Handles BBt_3.Click
        _EliminarRegistro()
    End Sub

    Private Sub ListB_Empleados_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListB_Empleados_ItemClick(sender As Object, e As EventArgs)
        'Try
        '    Dim item As ListBoxItem = CType(sender, ListBoxItem)
        '    If item.IsSelected = True Then
        '        item.CheckState = CheckState.Checked
        '    Else
        '        item.CheckState = CheckState.Unchecked
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub P_Mapas2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub Btn_ZoomMas_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMas.Click
        If GM_mapa.Zoom <> GM_mapa.MaxZoom Then
            GM_mapa.Zoom = GM_mapa.Zoom + 1
        End If
    End Sub

    Private Sub Btn_ZoomMenos_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMenos.Click
        If GM_mapa.Zoom <> GM_mapa.MinZoom Then
            GM_mapa.Zoom = GM_mapa.Zoom - 1
        End If
    End Sub

    Private Sub btAgregarCiudad_Click(sender As Object, e As EventArgs) Handles btAgregarCiudad.Click
        Dim num As Integer = 0
        L_Grabar_Libreria(gi_LibCiudad, num, J_Cb_Ciudad.Value.ToString, gs_Usuario) 'le mando num para recuperar su numero del nuevo tipo
        _LlenarComboLibreria(J_Cb_Ciudad, gi_LibCiudad)
        J_Cb_Ciudad.SelectedIndex = CType(J_Cb_Ciudad.DataSource, DataTable).Rows.Count - 1
        J_Cb_Ciudad.Focus()
    End Sub

    Private Sub btAgregarProv_Click(sender As Object, e As EventArgs) Handles btAgregarProv.Click
        Dim num As Integer = 0
        L_Grabar_Libreria(gi_LibProv, num, J_Cb_Provincia.Value.ToString, gs_Usuario) 'le mando num para recuperar su numero del nuevo tipo
        _LlenarComboLibreria(J_Cb_Provincia, gi_LibProv)
        J_Cb_Provincia.SelectedIndex = CType(J_Cb_Provincia.DataSource, DataTable).Rows.Count - 1
        J_Cb_Provincia.Focus()
    End Sub

    Private Sub btAgregarZona_Click(sender As Object, e As EventArgs) Handles btAgregarZona.Click
        Dim num As Integer = 0
        L_Grabar_Libreria(gi_LibZona, num, J_Cb_Zona.Value.ToString, gs_Usuario) 'le mando num para recuperar su numero del nuevo tipo
        _LlenarComboLibreria(J_Cb_Zona, gi_LibZona)
        J_Cb_Zona.SelectedIndex = CType(J_Cb_Zona.DataSource, DataTable).Rows.Count - 1
        J_Cb_Zona.Focus()
    End Sub

    Private Sub J_Cb_Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles J_Cb_Ciudad.KeyPress, J_Cb_Provincia.KeyPress, J_Cb_Zona.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub dgjRepartidor_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles dgjRepartidor.CellValueChanged
        If (e.Column.Index = dgjRepartidor.RootTable.Columns("check").Index) Then
            Dim index As Integer = dgjRepartidor.Row
            For Each fil2 As GridEXRow In dgjRepartidor.GetRows
                If (fil2.Cells.Row.RowIndex = Index) Then
                    fil2.BeginEdit()
                    fil2.Cells("check").Value = True
                    fil2.EndEdit()
                Else
                    fil2.BeginEdit()
                    fil2.Cells("check").Value = False
                    fil2.EndEdit()
                End If
            Next
        End If
    End Sub
End Class