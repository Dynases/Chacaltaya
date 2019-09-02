Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports System.Threading
Public Class F1_MapaCLientes
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim _Punto As Integer
    Dim _ListPuntos As List(Of PointLatLng)
    Dim _Overlay As GMapOverlay
    Dim _latitud As Double = 0
    Dim _longitud As Double = 0
    Dim TableCliente As DataTable
    Dim Markers As GMapMarker
    Dim cont As Integer = 0



    Private Sub _IniciarTodo()
        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)

        _prInicarMapa()
        _prObtenerDatatableClientes()
        _prCargarClientesJanus(TableCliente)

        slpanelInfo.Width = 0
        Panel1.Visible = True
        btnz1.Visible = True
        btnz2.Visible = True
        pbmap.Visible = True
        lbmap.Visible = True

        Gmc_Cliente.Zoom = Gmc_Cliente.Zoom - 2


    End Sub

    Public Sub _prCargarClientesJanus(Cliente As DataTable)
        Dim dt As New DataTable
        dt = Cliente
        ''''janosssssssss''''''
        grCliente.DataSource = dt
        grCliente.RetrieveStructure()
        grCliente.AlternatingColors = True
        grCliente.RowFormatStyle.Font = New Font("arial", 9)
        'dar formato a las columnas
        ''a.ccnumi ,a.ccdesc ,a.cctelf2 ,a.ccobs ,a.cclat ,a.cclongi 

        With grCliente.RootTable.Columns("ccnumi")
            .Width = 60
            .Caption = "CODIGO"

            .Visible = False

        End With

        With grCliente.RootTable.Columns("ccdesc")
            .Width = 327
            .Caption = "DESCRIPCION"
            .Visible = True
        End With
        With grCliente.RootTable.Columns("cctelf2")
            .Width = 90
            .Caption = "TELEFONO"

            .Visible = False
        End With
        With grCliente.RootTable.Columns("ccobs")
            .Width = 90
            .Caption = "OBSERVACION"
            .Visible = False
        End With
        With grCliente.RootTable.Columns("cclat")
            .Width = 90

            .Visible = False
        End With
        With grCliente.RootTable.Columns("cclongi")
            .Caption = "NOMBRE"

            .Width = 110
            .Visible = False


        End With
       

        With grCliente
            .GroupByBoxVisible = False
            'diseño de la grilla
          
            '.CardSpacing = 50
            .CardHeaders = True
            .CollapseCards()

            .CardWidth = grCliente.Width - 25

            '.CardCaptionFormatStyle.FontBold = TriState.True
            .CardColumnHeaderFormatStyle.FontBold = TriState.True
            .CardColumnHeaderFormatStyle.ForeColor = Color.FromArgb(0, 85, 139)
            .VisualStyle = VisualStyle.Office2007
            '.View = View.CardView

            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .CardViewGridlines = CardViewGridlines.Vertical
        End With


        grCliente.RowHeaderFormatStyle.FontBold = TriState.True
        grCliente.RowHeaderFormatStyle.FontSize = 12

        'grCliente.CardViewGridlines = CardViewGridlines.Vertical


    End Sub
    Public Sub _prObtenerDatatableClientes()
        TableCliente = L_prMapaCLienteGeneral()
        _CargarPunto(TableCliente)
        ''  _prDibujarMarketCliente(TableCliente.Rows.Count - 1, TableCliente)
    End Sub

    Public Sub _CargarPunto(Cliente As DataTable)
        For i As Integer = 0 To Cliente.Rows.Count - 1 Step 1
            Dim lat As Double = IIf(IsDBNull(Cliente.Rows(i).Item("cclat")), 0, Cliente.Rows(i).Item("cclat"))
            Dim longitud As Double = IIf(IsDBNull(Cliente.Rows(i).Item("cclongi")), 0, Cliente.Rows(i).Item("cclongi"))
            If (lat <> 0 And longitud <> 0) Then
                Dim plg As PointLatLng = New PointLatLng(lat, longitud)

                _latitud = plg.Lat
                _longitud = plg.Lng


                P_AgregarPunto(plg, "", "", Cliente.Rows(i))
            End If

        Next

    End Sub
    Public Sub _prDibujarMarketCliente(n As Integer, Cliente As DataTable)
        If (n < 0) Then
            Return

        Else
            Dim lat As Double = IIf(IsDBNull(Cliente.Rows(n).Item("cclat")), 0, Cliente.Rows(n).Item("cclat"))
            Dim longitud As Double = IIf(IsDBNull(Cliente.Rows(n).Item("cclongi")), 0, Cliente.Rows(n).Item("cclongi"))
            If (lat <> 0 And longitud <> 0) Then
                Dim plg As PointLatLng = New PointLatLng(lat, longitud)

                _latitud = plg.Lat
                _longitud = plg.Lng
              
                cont += 1
                P_AgregarPunto(plg, "", "", Cliente.Rows(n))
            End If
         

            _prDibujarMarketCliente(n - 1, Cliente)
           

        End If

    End Sub
    Private Sub P_IniciarMap()
        Gmc_Cliente.DragButton = MouseButtons.Left
        Gmc_Cliente.CanDragMap = True
        Gmc_Cliente.MapProvider = GMapProviders.GoogleMap
        If (_latitud <> 0 And _longitud <> 0) Then

            Gmc_Cliente.Position = New PointLatLng(_latitud, _longitud)
        Else

            _Overlay.Markers.Clear()
            Gmc_Cliente.Position = New PointLatLng(-17.782814, -63.182386)
        End If

        Gmc_Cliente.MinZoom = 0
        Gmc_Cliente.MaxZoom = 24
        Gmc_Cliente.Zoom = 15.5
        Gmc_Cliente.AutoScroll = True

        GMapProvider.Language = LanguageType.Spanish
    End Sub
    Public Sub _prInicarMapa()

        _Punto = 0
        '_ListPuntos = New List(Of PointLatLng)
        _Overlay = New GMapOverlay("points")
        Gmc_Cliente.Overlays.Add(_Overlay)

        P_IniciarMap()

    End Sub
    Private Sub F1_MapaCLientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        _IniciarTodo()

    End Sub

   

    Private Sub P_AgregarPunto(pointLatLng As PointLatLng, _nombre As String, _ci As String, data As System.Data.DataRow)

        If (Not IsNothing(_Overlay)) Then
            'añadir puntos
            'Dim markersOverlay As New GMapOverlay("markers")
            Dim marker As New GMarkerGoogle(pointLatLng, My.Resources.mark)

            'añadir tooltip
            Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
            marker.ToolTip = New GMapBaloonToolTip(marker)
            marker.ToolTipMode = mode
            Dim ToolTipBackColor As New SolidBrush(Color.Blue)
            marker.ToolTip.Fill = ToolTipBackColor
            marker.ToolTip.Foreground = Brushes.White
            marker.Tag = data


            _Overlay.Markers.Add(marker)
            'mapa.Overlays.Add(markersOverlay)


        End If



    End Sub

    Private Sub Gmc_Cliente_OnMarkerClick(item As GMapMarker, e As MouseEventArgs) Handles Gmc_Cliente.OnMarkerClick
        If (Not IsNothing(Markers)) Then
            _Overlay.Markers.Remove(Markers)

        End If
        Panel1.Visible = False
        slpanelInfo.Visible = True
        Dim i As DataRow = CType(item.Tag, DataRow)
        Dim lat As String = i.Item("cclat")
        Dim tags As Object = item.Tag
        Dim longit As String = i.Item("cclongi")
        lbcliente.Text = i.Item("ccdesc")


        If (IsDBNull(i.Item("ccobs")) Or IsNothing(i.Item("ccobs"))) Then
            lbobs.Text = ""

        Else
            lbobs.Text = i.Item("ccobs")
        End If



        lbtel.Text = i.Item("cctelf2")






        'Dim markersOverlay As New GMapOverlay("markers")
        Dim marker As New GMarkerGoogle(New PointLatLng(lat, longit), My.Resources.markerA)

        'añadir tooltip
        Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
        marker.ToolTip = New GMapBaloonToolTip(marker)
        marker.ToolTipMode = mode
        Dim ToolTipBackColor As New SolidBrush(Color.Blue)
        marker.ToolTip.Fill = ToolTipBackColor
        marker.ToolTip.Foreground = Brushes.White
        marker.Tag = tags

        Markers = marker

        _Overlay.Markers.Add(marker)

        Gmc_Cliente.Position = New PointLatLng(lat, longit)
        While (slpanelInfo.Width < 358)
            slpanelInfo.Width += 1
            Thread.Sleep(0.1)
        End While

        _prHabilitarLAbel()









    End Sub
    Public Sub _prHabilitarLAbel()
        lb1.Visible = True
        lb2.Visible = True
        lb3.Visible = True
        lb4.Visible = True
        lbcliente.Visible = True
        lbobs.Visible = True
        lbtel.Visible = True
        btn1.Visible = True

    End Sub

    Public Sub _prInhabilitarHabilitarLAbel()
        lb1.Visible = False
        lb2.Visible = False
        lb3.Visible = False
        lb4.Visible = False
        lbcliente.Visible = False
        lbobs.Visible = False
        lbtel.Visible = False
        btn1.Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Panel1.Visible = True
        While (slpanelInfo.Width > 0)
            slpanelInfo.Width -= 1
            Thread.Sleep(0.2)
        End While
        _prInhabilitarHabilitarLAbel()
        If (Not IsNothing(Markers)) Then
            _Overlay.Markers.Remove(Markers)

        End If
        grCliente.RemoveFilters()
        Gmc_Cliente.Position = New PointLatLng(-17.782814, -63.182386)
        Gmc_Cliente.Zoom = 13

    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles btnz1.Click
        If (Gmc_Cliente.Zoom <= Gmc_Cliente.MaxZoom) Then
            Gmc_Cliente.Zoom = Gmc_Cliente.Zoom + 1
        End If
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles btnz2.Click
        If (Gmc_Cliente.Zoom >= Gmc_Cliente.MinZoom) Then
            Gmc_Cliente.Zoom = Gmc_Cliente.Zoom - 1
        End If
    End Sub

   
    Private Sub grCliente_DoubleClick(sender As Object, e As EventArgs) Handles grCliente.DoubleClick
        Dim _MPos As Integer
        If grCliente.Row >= 0 Then
            _MPos = grCliente.Row
            Panel1.Visible = False
            slpanelInfo.Visible = True
         
            Dim longit As String = grCliente.GetValue("cclongi")
            lbcliente.Text = grCliente.GetValue("ccdesc").ToString
            If (IsDBNull(grCliente.GetValue("ccobs")) Or IsNothing(grCliente.GetValue("ccobs"))) Then
                lbobs.Text = ""

            Else
                lbobs.Text = grCliente.GetValue("ccobs").ToString
            End If

            lbtel.Text = grCliente.GetValue("cctelf2")


            While (slpanelInfo.Width < 358)
                slpanelInfo.Width += 1
                Thread.Sleep(0.1)
            End While
            _prHabilitarLAbel()
            Dim gma As GMapMarker
            _prRecorreMArket(grCliente.GetValue("cclat"), grCliente.GetValue("cclongi"), gma)
            If (Not IsNothing(gma)) Then

                Dim marker As New GMarkerGoogle(New PointLatLng(grCliente.GetValue("cclat"), grCliente.GetValue("cclongi")), My.Resources.markerA)

                'añadir tooltip
                Dim mode As MarkerTooltipMode = MarkerTooltipMode.OnMouseOver
                marker.ToolTip = New GMapBaloonToolTip(marker)
                marker.ToolTipMode = mode
                Dim ToolTipBackColor As New SolidBrush(Color.Blue)
                marker.ToolTip.Fill = ToolTipBackColor
                marker.ToolTip.Foreground = Brushes.White
                marker.Tag = gma.Tag

                Markers = marker

                _Overlay.Markers.Add(marker)
                Gmc_Cliente.Position = New PointLatLng(grCliente.GetValue("cclat"), grCliente.GetValue("cclongi"))
            Else


                ToastNotification.Show(Me, "NO EXISTE UBICACION PARA ESTE CLIENTE", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.MiddleCenter)
            End If

        End If
    End Sub
    Public Sub _prRecorreMArket(latitud As String, longitud As String, ByRef ma As GMapMarker)
        Dim a As List(Of GMapMarker) = _Overlay.Markers.ToList
        For k = 0 To a.Count - 1 Step 1
            Dim mark As GMapMarker = a(k)
            Dim i As DataRow = CType(mark.Tag, DataRow)
            Dim lat As String = i.Item("cclat")
            Dim longit As String = i.Item("cclongi")
            If (lat.Equals(latitud) And longit.Equals(longitud)) Then
                ma = mark
                Return

            End If
        Next


        '    Dim length As Integer = a.Length


    End Sub


End Class