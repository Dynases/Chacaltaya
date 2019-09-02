Imports GMap.NET.WindowsForms
Imports Logica.AccesoLogica
Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms.ToolTips
Imports Janus.Windows.GridEX

Public Class P_MonitoreoPedidos
#Region "Atributos"
    'cantidad de colores en el marker son 37
    Dim _overlay As New GMapOverlay
    Dim _listRepAct As New List(Of DataRow)
    Dim _RutaImagenes As String
#End Region
#Region "Metodos Privados"
    Private Sub _PIniciarTodo()
        'L_abrirConexion()
        _RutaImagenes = gs_RutaImagenes + "\"

        Me.Text = " M O N I T O R E O   D E   P E D I D O S "
        Me.WindowState = FormWindowState.Maximized
        SuperTabControl1.SelectedTabIndex = 0
        SuperTabItem2.Visible = False
        PanelEx1.Visible = False

        'cargar mapas
        _PCargarMapa(GM_Mapa, _overlay)
        _PCargarZonas()

        ''_PCargarPedidos()

        'cargar ruta
        ''_prCargarRuta(GM_Mapa)

        'bloquear todos los botones
        BubbleBar1.Enabled = False
        TimerRuta.Interval = 2000
        _prCargarGridPersonal()
        _prCargarComboCiudades()
    End Sub
    Private Sub _prCargarComboCiudades()
        J_Cb_Ciudad.Items.Add("SANTA CRUZ")
        J_Cb_Ciudad.Items.Add("COCHABAMBA")
        J_Cb_Ciudad.Items.Add("LA PAZ")
        J_Cb_Ciudad.SelectedIndex = 0
    End Sub

    Private Sub _prCargarGridPersonal()
        Dim dt As New DataTable
        dt = L_Empleado_GeneralRepartidorSimple(-1, "and cbcat=1 and cbest=1").Tables(0)

        dt.Columns.Add("estado", Type.GetType("System.Boolean"))
        dt.Columns.Add("color", Type.GetType("System.Int32"))

        grRepartidores.DataSource = dt
        grRepartidores.RetrieveStructure()

        'dar formato a las columnas
        With grRepartidores.RootTable.Columns("cbnumi")
            .Caption = "Cod".ToUpper
            .Width = 40
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With grRepartidores.RootTable.Columns("cbdesc")
            .Caption = "NOMBRE"
            .Width = 230
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With grRepartidores.RootTable.Columns("estado")
            .Caption = "S"
            .Width = 30
        End With

        With grRepartidores.RootTable.Columns("cbfot")
            .Visible = False
        End With

        With grRepartidores.RootTable.Columns("color")
            .Visible = False
        End With

        Dim i As Integer = 0
        For Each fila As DataRow In dt.Rows
            Dim _color As Integer = _prGetColorByPos(i)
            fila.Item("estado") = 0
            fila.Item("color") = _color

            'Dim _estiloFila As New GridEXFormatStyle()
            'Dim _fil As Janus.Windows.GridEX.GridEXRow
            '_fil = grRepartidores.GetRow(i)
            '_estiloFila.BackColor = _prGetoColor(color)
            '_fil.RowStyle = _estiloFila

            Dim fc As GridEXFormatCondition
            fc = New GridEXFormatCondition(grRepartidores.RootTable.Columns("color"), ConditionOperator.Equal, _color)
            fc.FormatStyle.BackColor = _prGetoColor(_color)
            grRepartidores.RootTable.FormatConditions.Add(fc)

            i = i + 1
        Next


        'Habilitar Filtradores
        With grRepartidores
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Function _prGetoColor(i As Integer) As Color
        Select Case i
            Case GMarkerGoogleType.blue
                Return Color.Blue
            Case GMarkerGoogleType.red
                Return Color.Red
            Case GMarkerGoogleType.yellow
                Return Color.Yellow
            Case GMarkerGoogleType.green
                Return Color.Green
            Case GMarkerGoogleType.orange
                Return Color.Orange
            Case GMarkerGoogleType.pink
                Return Color.Pink
            Case GMarkerGoogleType.brown_small
                Return Color.Brown
            Case GMarkerGoogleType.gray_small
                Return Color.Gray
            Case GMarkerGoogleType.lightblue
                Return Color.LightBlue
        End Select
    End Function

    Private Function _prGetColorByPos(i As Integer) As Integer
        Select Case i
            Case 0
                Return GMarkerGoogleType.blue
            Case 1
                Return GMarkerGoogleType.red
            Case 2
                Return GMarkerGoogleType.yellow
            Case 3
                Return GMarkerGoogleType.green
            Case 4
                Return GMarkerGoogleType.orange
            Case 5
                Return GMarkerGoogleType.gray_small
            Case 6
                Return GMarkerGoogleType.pink
            Case 7
                Return GMarkerGoogleType.brown_small
            Case 8
                Return GMarkerGoogleType.lightblue
            Case 9
                Return GMarkerGoogleType.blue
            Case 10
                Return GMarkerGoogleType.blue
            Case 11
                Return GMarkerGoogleType.blue
            Case 12
                Return GMarkerGoogleType.blue
            Case 13
                Return GMarkerGoogleType.blue




        End Select
    End Function
    Private Sub _prDibujarPunto(ByRef objOverlay As GMapOverlay, pointLatLng As PointLatLng, Optional etiqueta As String = "")

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
        objOverlay.Markers.Clear()
        objOverlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)
    End Sub

    Private Sub _prCargarRuta(ByRef objMapa As GMapControl)
        Dim route As New List(Of PointLatLng)
        Dim dtRuta As DataTable = L_RutaGeneral("ldchof=32")
        For Each fila As DataRow In dtRuta.Rows
            route.Add(New PointLatLng(fila.Item("lblat"), fila.Item("lblongi")))
        Next

        Dim ruta As GMapRoute = New GMapRoute(route.ToArray, "My route")

        ruta.Stroke.Width = 2
        ruta.Stroke.Color = Color.SeaGreen

        'codigo de cargar el mapa
        Dim routesOverlay As GMapOverlay = New GMapOverlay("routes")
        routesOverlay.Routes.Add(ruta)
        objMapa.Overlays.Add(routesOverlay)

        'objMapa.Overlays.Add(objOverlay)

        'Dim routesOverlay As GMapOverlay = New GMapOverlay("routes")
        '_overlay.Routes.Add(ruta)
        'objMapa.Overlays.Add(_overlay)
    End Sub
    Private Sub _PCargarMapa(ByRef objMapa As GMapControl, ByRef objOverlay As GMapOverlay)

        objOverlay = New GMapOverlay("polygons")
        objMapa.Overlays.Add(objOverlay)

        objMapa.DragButton = MouseButtons.Left
        objMapa.CanDragMap = True
        objMapa.MapProvider = GMapProviders.GoogleMap
        'objMapa.Position = New PointLatLng(-17.380941, -66.15976)
        objMapa.Position = New PointLatLng(-17.782814, -63.182386)
        objMapa.MinZoom = 0
        objMapa.MaxZoom = 24
        objMapa.Zoom = 13
        objMapa.AutoScroll = True
        GMapProvider.Language = LanguageType.Spanish
    End Sub
    Private Sub _PDibujarZona(idZona As Integer, ByRef objOverlay As GMapOverlay, colorZona As String)
        'cargar zona en mapa
        Dim tPuntos As DataTable = L_ZonaDetallePuntos_General(-1, idZona).Tables(0)
        Dim i As Integer
        Dim lati, longi As Double
        Dim listPuntos As New List(Of PointLatLng)
        For i = 0 To tPuntos.Rows.Count - 1
            lati = tPuntos.Rows(i).Item(1)
            longi = tPuntos.Rows(i).Item(2)
            Dim plg As PointLatLng = New PointLatLng(lati, longi)
            listPuntos.Add(plg)
        Next

        'Dim color1 As String = JGr_Zonas1.CurrentRow.Cells(7).Value
        Dim colorFinal As Color = ColorTranslator.FromHtml(colorZona)

        Dim polygon As New GMapPolygon(listPuntos, "mypolygon")
        'agregar color
        polygon.Fill = New SolidBrush(Color.FromArgb(50, colorFinal))
        polygon.Stroke = New Pen(Color.Red, 1)
        'objOverlay.Polygons.Clear()
        objOverlay.Polygons.Add(polygon)
    End Sub

    Private Sub _PDibujarPunto(ByRef objOverlay As GMapOverlay, pointLatLng As PointLatLng, _color As Integer, _foto As String, Optional etiqueta As String = "")

        'añadir puntos
        ''Dim markersOverlay As New GMapOverlay("markers")
        Dim marker As GMarkerGoogle
        If _foto = String.Empty Then
            marker = New GMarkerGoogle(pointLatLng, _color) '_color
        Else
            Dim _imagen As New Bitmap(New Bitmap(_RutaImagenes + _foto), 50, 50)
            marker = New GMarkerGoogle(pointLatLng, _imagen) '_color
        End If
        'añadir tooltip
        If etiqueta <> "" Then 'etiqueta <> ""
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.Red)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTipText = etiqueta
        End If
        'objOverlay.Markers.Clear()
        objOverlay.Markers.Add(marker)
        'mapa.Overlays.Add(markersOverlay)
    End Sub

    Private Sub _PCargarPedidos()
        Dim dtPedidos, dtZonas As DataTable
        Dim i, j As Integer
        'DIBUJAR ZONAS
        dtZonas = L_ZonaCabecera_GeneralCompleto1(0).Tables(0)
        Dim colorZona As String
        Dim idRegZona As Integer
        For i = 0 To dtZonas.Rows.Count - 1
            idRegZona = dtZonas.Rows(i).Item("lanumi")
            colorZona = dtZonas.Rows(i).Item("lacolor")
            'dibujar zona
            _PDibujarZona(idRegZona, _overlay, colorZona)

            'DIBUJAR PEDIDOS
            Dim estado As String
            estado = "1"
            dtPedidos = L_PedidoCabecera_General(-1, " AND oaest=" + estado + " AND oazona= " + Str(idRegZona))
            For j = 0 To dtPedidos.Rows.Count - 1
                Dim idReg As Integer = dtPedidos.Rows(j).Item("oanumi")
                Dim latitud As Double = dtPedidos.Rows(j).Item("cclat")
                Dim longitud As Double = dtPedidos.Rows(j).Item("cclongi")
                Dim nombre As String = dtPedidos.Rows(j).Item("ccdesc")
                Dim obsPedido As String = dtPedidos.Rows(j).Item("oaobs")
                Dim fechaPedido As String = dtPedidos.Rows(j).Item("oafdoc")
                Dim horaPedido As String = dtPedidos.Rows(j).Item("oahora")

                'dibujar etiqueta del cliente en el mapa
                Dim plg As New PointLatLng(latitud, longitud)
                _PDibujarPunto(_overlay, plg, nombre + vbCrLf + _
                                        "Hora Pedido: " + fechaPedido + " - " + horaPedido, "")
            Next

        Next

    End Sub

    Private Sub _PCargarZonas()
        Dim dtZonas As DataTable
        Dim i As Integer
        'DIBUJAR ZONAS
        dtZonas = L_ZonaCabecera_GeneralCompleto1(0).Tables(0)
        Dim colorZona As String
        Dim idRegZona As Integer
        For i = 0 To dtZonas.Rows.Count - 1
            idRegZona = dtZonas.Rows(i).Item("lanumi")
            colorZona = dtZonas.Rows(i).Item("lacolor")
            'dibujar zona
            _PDibujarZona(idRegZona, _overlay, colorZona)
        Next

    End Sub

    Private Sub _prDibujarPuntosEnMapa()
        'limpio los puntos en el mapa
        _overlay.Markers.Clear()

        Dim dtRuta As DataTable
        For Each elem As DataRow In _listRepAct.ToArray
            dtRuta = L_RutaUltimoPunto("ldchof=" + elem.Item("cbnumi").ToString.Trim)
            If dtRuta.Rows.Count > 0 Then
                Dim color As Integer = elem.Item("color")
                Dim nombre As String = elem.Item("cbdesc")
                _PDibujarPunto(_overlay, New PointLatLng(dtRuta.Rows(0).Item("lblat"), dtRuta.Rows(0).Item("lblongi")), color, elem.Item("cbfot").ToString, nombre)
            End If
        Next


    End Sub
#End Region

    Private Sub P_MonitoreoPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub


    Private Sub Btn_ZoomMas_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMas.Click
        If GM_Mapa.Zoom <> GM_Mapa.MaxZoom Then
            GM_Mapa.Zoom = GM_Mapa.Zoom + 1
        End If
    End Sub

    Private Sub Btn_ZoomMenos_Click(sender As Object, e As EventArgs) Handles Btn_ZoomMenos.Click
        If GM_Mapa.Zoom <> GM_Mapa.MinZoom Then
            GM_Mapa.Zoom = GM_Mapa.Zoom - 1
        End If
    End Sub

    Private Sub TimerRuta_Tick(sender As Object, e As EventArgs) Handles TimerRuta.Tick
        '_prCargarRuta(GM_Mapa)
        _prDibujarPuntosEnMapa()
    End Sub

    Private Sub tbTracking_ValueChanged(sender As Object, e As EventArgs) Handles tbTracking.ValueChanged
        If tbTracking.Value = True Then
            TimerRuta.Start()
            
        Else
            TimerRuta.Stop()
        End If

    End Sub

    Private Sub grRepartidores_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grRepartidores.CellEdited
        'If grRepartidores.Row >= 0 And e.Column.Key = "estado" Then
        '    If grRepartidores.GetValue("estado").ToString = "True" Then
        '        _listRepAct.Add(CType(grRepartidores.DataSource, DataTable).Rows(grRepartidores.Row))
        '        tbTracking.Focus()
        '    Else
        '        Dim i As Integer = _listRepAct.IndexOf(grRepartidores.GetValue("cbnumi"))
        '        _listRepAct.RemoveAt(i)
        '        tbTracking.Focus()
        '    End If

        'End If

    End Sub

    Private Sub grRepartidores_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grRepartidores.CellValueChanged
        If grRepartidores.Row >= 0 And e.Column.Key = "estado" Then
            If grRepartidores.GetValue("estado").ToString = "True" Then
                _listRepAct.Add(CType(grRepartidores.DataSource, DataTable).Rows(grRepartidores.Row))
                tbTracking.Focus()
            Else
                Dim i As Integer = _listRepAct.IndexOf(CType(grRepartidores.DataSource, DataTable).Rows(grRepartidores.Row))
                _listRepAct.RemoveAt(i)
                tbTracking.Focus()
            End If

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles J_Cb_Ciudad.SelectedIndexChanged
        Dim ciudad As String = J_Cb_Ciudad.Text
        Select Case ciudad
            Case "COCHABAMBA"
                GM_Mapa.Position = New PointLatLng(-17.380941, -66.15976)
            Case "LA PAZ"
                GM_Mapa.Position = New PointLatLng(-16.499225, -68.122866)
            Case "SANTA CRUZ"
                GM_Mapa.Position = New PointLatLng(-17.782814, -63.182386)
        End Select
    End Sub
End Class