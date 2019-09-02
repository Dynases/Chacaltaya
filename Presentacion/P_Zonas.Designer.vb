<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Zonas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim J_Cb_Zona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Zonas))
        Dim J_Cb_Provincia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim J_Cb_Ciudad_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GM_mapa = New GMap.NET.WindowsForms.GMapControl()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btAgregarZona = New DevComponents.DotNetBar.ButtonX()
        Me.btAgregarProv = New DevComponents.DotNetBar.ButtonX()
        Me.btAgregarCiudad = New DevComponents.DotNetBar.ButtonX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.J_Cb_Zona = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.J_Cb_Provincia = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.J_Cb_Ciudad = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Tb_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_color = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Btn_ZoomMenos = New DevComponents.DotNetBar.ButtonX()
        Me.Btn_ZoomMas = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.Pan_Dialogo = New System.Windows.Forms.Panel()
        Me.Btn_OpcionOK = New System.Windows.Forms.Button()
        Me.Btn_OpcionCancel = New System.Windows.Forms.Button()
        Me.Lb_MensajeDialog = New System.Windows.Forms.Label()
        Me.Pan_ToolBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lb_Mensaje = New System.Windows.Forms.Label()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BBt_1 = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_2 = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_3 = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_4 = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_5 = New DevComponents.DotNetBar.BubbleButton()
        Me.Pan_Navegador = New System.Windows.Forms.Panel()
        Me.Lb_CantReg = New System.Windows.Forms.Label()
        Me.BubbleBar3 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab3 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BBt_First = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_Back = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_Next = New DevComponents.DotNetBar.BubbleButton()
        Me.BBt_Last = New DevComponents.DotNetBar.BubbleButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Ep1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Ep2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgjRepartidor = New Janus.Windows.GridEX.GridEX()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.J_Cb_Zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.J_Cb_Provincia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.J_Cb_Ciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.Pan_Dialogo.SuspendLayout()
        Me.Pan_ToolBar.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Navegador.SuspendLayout()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ep2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgjRepartidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GM_mapa
        '
        Me.GM_mapa.Bearing = 0!
        Me.GM_mapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GM_mapa.CanDragMap = True
        Me.GM_mapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GM_mapa.EmptyTileColor = System.Drawing.Color.Navy
        Me.GM_mapa.GrayScaleMode = False
        Me.GM_mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GM_mapa.LevelsKeepInMemmory = 5
        Me.GM_mapa.Location = New System.Drawing.Point(0, 0)
        Me.GM_mapa.MarkersEnabled = True
        Me.GM_mapa.MaxZoom = 2
        Me.GM_mapa.MinZoom = 2
        Me.GM_mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GM_mapa.Name = "GM_mapa"
        Me.GM_mapa.NegativeMode = False
        Me.GM_mapa.PolygonsEnabled = True
        Me.GM_mapa.RetryLoadTile = 0
        Me.GM_mapa.RoutesEnabled = True
        Me.GM_mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GM_mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GM_mapa.ShowTileGridLines = False
        Me.GM_mapa.Size = New System.Drawing.Size(341, 690)
        Me.GM_mapa.TabIndex = 0
        Me.GM_mapa.Zoom = 0R
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(745, 741)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Pan_Dialogo)
        Me.TabPage1.Controls.Add(Me.Pan_ToolBar)
        Me.TabPage1.Controls.Add(Me.Pan_Navegador)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(718, 733)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.GroupPanel1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Tb_Id)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Tb_color)
        Me.Panel1.Location = New System.Drawing.Point(4, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 549)
        Me.Panel1.TabIndex = 116
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgjRepartidor)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 179)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(370, 367)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 0
        Me.GroupPanel1.Text = "Repartidores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btAgregarZona)
        Me.GroupBox1.Controls.Add(Me.btAgregarProv)
        Me.GroupBox1.Controls.Add(Me.btAgregarCiudad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.J_Cb_Zona)
        Me.GroupBox1.Controls.Add(Me.J_Cb_Provincia)
        Me.GroupBox1.Controls.Add(Me.J_Cb_Ciudad)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 118)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zona"
        '
        'btAgregarZona
        '
        Me.btAgregarZona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarZona.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarZona.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.btAgregarZona.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btAgregarZona.Location = New System.Drawing.Point(321, 84)
        Me.btAgregarZona.Name = "btAgregarZona"
        Me.btAgregarZona.Size = New System.Drawing.Size(30, 25)
        Me.btAgregarZona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarZona.TabIndex = 8
        '
        'btAgregarProv
        '
        Me.btAgregarProv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarProv.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarProv.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.btAgregarProv.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btAgregarProv.Location = New System.Drawing.Point(321, 50)
        Me.btAgregarProv.Name = "btAgregarProv"
        Me.btAgregarProv.Size = New System.Drawing.Size(30, 25)
        Me.btAgregarProv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarProv.TabIndex = 7
        '
        'btAgregarCiudad
        '
        Me.btAgregarCiudad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btAgregarCiudad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btAgregarCiudad.Image = Global.Presentacion.My.Resources.Resources.ADICIONAR
        Me.btAgregarCiudad.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.btAgregarCiudad.Location = New System.Drawing.Point(321, 16)
        Me.btAgregarCiudad.Name = "btAgregarCiudad"
        Me.btAgregarCiudad.Size = New System.Drawing.Size(30, 25)
        Me.btAgregarCiudad.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btAgregarCiudad.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Zona:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Provincia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ciudad:"
        '
        'J_Cb_Zona
        '
        J_Cb_Zona_DesignTimeLayout.LayoutString = resources.GetString("J_Cb_Zona_DesignTimeLayout.LayoutString")
        Me.J_Cb_Zona.DesignTimeLayout = J_Cb_Zona_DesignTimeLayout
        Me.J_Cb_Zona.Location = New System.Drawing.Point(66, 86)
        Me.J_Cb_Zona.Name = "J_Cb_Zona"
        Me.J_Cb_Zona.SelectedIndex = -1
        Me.J_Cb_Zona.SelectedItem = Nothing
        Me.J_Cb_Zona.Size = New System.Drawing.Size(249, 20)
        Me.J_Cb_Zona.TabIndex = 2
        '
        'J_Cb_Provincia
        '
        J_Cb_Provincia_DesignTimeLayout.LayoutString = resources.GetString("J_Cb_Provincia_DesignTimeLayout.LayoutString")
        Me.J_Cb_Provincia.DesignTimeLayout = J_Cb_Provincia_DesignTimeLayout
        Me.J_Cb_Provincia.Location = New System.Drawing.Point(66, 53)
        Me.J_Cb_Provincia.Name = "J_Cb_Provincia"
        Me.J_Cb_Provincia.SelectedIndex = -1
        Me.J_Cb_Provincia.SelectedItem = Nothing
        Me.J_Cb_Provincia.Size = New System.Drawing.Size(249, 20)
        Me.J_Cb_Provincia.TabIndex = 1
        '
        'J_Cb_Ciudad
        '
        J_Cb_Ciudad_DesignTimeLayout.LayoutString = resources.GetString("J_Cb_Ciudad_DesignTimeLayout.LayoutString")
        Me.J_Cb_Ciudad.DesignTimeLayout = J_Cb_Ciudad_DesignTimeLayout
        Me.J_Cb_Ciudad.Location = New System.Drawing.Point(67, 19)
        Me.J_Cb_Ciudad.Name = "J_Cb_Ciudad"
        Me.J_Cb_Ciudad.SelectedIndex = -1
        Me.J_Cb_Ciudad.SelectedItem = Nothing
        Me.J_Cb_Ciudad.Size = New System.Drawing.Size(249, 20)
        Me.J_Cb_Ciudad.TabIndex = 0
        '
        'Tb_Id
        '
        Me.Tb_Id.Location = New System.Drawing.Point(49, 19)
        Me.Tb_Id.Name = "Tb_Id"
        Me.Tb_Id.Size = New System.Drawing.Size(100, 20)
        Me.Tb_Id.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "ID:"
        '
        'Tb_color
        '
        Me.Tb_color.Location = New System.Drawing.Point(161, 19)
        Me.Tb_color.Name = "Tb_color"
        Me.Tb_color.Size = New System.Drawing.Size(90, 20)
        Me.Tb_color.TabIndex = 112
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PanelEx6)
        Me.Panel2.Controls.Add(Me.ButtonX1)
        Me.Panel2.Controls.Add(Me.GM_mapa)
        Me.Panel2.Location = New System.Drawing.Point(374, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 690)
        Me.Panel2.TabIndex = 115
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMenos)
        Me.PanelEx6.Controls.Add(Me.Btn_ZoomMas)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Location = New System.Drawing.Point(17, 11)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(46, 87)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 5
        '
        'Btn_ZoomMenos
        '
        Me.Btn_ZoomMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMenos.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMenos.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MENOS_ORI
        Me.Btn_ZoomMenos.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMenos.Location = New System.Drawing.Point(3, 45)
        Me.Btn_ZoomMenos.Name = "Btn_ZoomMenos"
        Me.Btn_ZoomMenos.Size = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMenos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMenos.TabIndex = 1
        '
        'Btn_ZoomMas
        '
        Me.Btn_ZoomMas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_ZoomMas.BackgroundImage = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_ZoomMas.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.Btn_ZoomMas.Image = Global.Presentacion.My.Resources.Resources.ZOOM_MAS_ORI
        Me.Btn_ZoomMas.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMas.Location = New System.Drawing.Point(3, 3)
        Me.Btn_ZoomMas.Name = "Btn_ZoomMas"
        Me.Btn_ZoomMas.Size = New System.Drawing.Size(40, 40)
        Me.Btn_ZoomMas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btn_ZoomMas.TabIndex = 0
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Image = Global.Presentacion.My.Resources.Resources.MARCARZONA
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(52, 52)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(79, 11)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(86, 73)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 114
        Me.ButtonX1.Text = "Marcar Zona"
        '
        'Pan_Dialogo
        '
        Me.Pan_Dialogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_Dialogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Pan_Dialogo.Controls.Add(Me.Btn_OpcionOK)
        Me.Pan_Dialogo.Controls.Add(Me.Btn_OpcionCancel)
        Me.Pan_Dialogo.Controls.Add(Me.Lb_MensajeDialog)
        Me.Pan_Dialogo.Location = New System.Drawing.Point(0, 614)
        Me.Pan_Dialogo.Name = "Pan_Dialogo"
        Me.Pan_Dialogo.Size = New System.Drawing.Size(374, 76)
        Me.Pan_Dialogo.TabIndex = 113
        '
        'Btn_OpcionOK
        '
        Me.Btn_OpcionOK.BackgroundImage = Global.Presentacion.My.Resources.Resources.OPCION_OK
        Me.Btn_OpcionOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_OpcionOK.FlatAppearance.BorderSize = 0
        Me.Btn_OpcionOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OpcionOK.Location = New System.Drawing.Point(119, 16)
        Me.Btn_OpcionOK.Name = "Btn_OpcionOK"
        Me.Btn_OpcionOK.Size = New System.Drawing.Size(48, 48)
        Me.Btn_OpcionOK.TabIndex = 8
        Me.Btn_OpcionOK.UseVisualStyleBackColor = True
        '
        'Btn_OpcionCancel
        '
        Me.Btn_OpcionCancel.BackgroundImage = Global.Presentacion.My.Resources.Resources.OPCION_CANCEL
        Me.Btn_OpcionCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_OpcionCancel.FlatAppearance.BorderSize = 0
        Me.Btn_OpcionCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_OpcionCancel.Location = New System.Drawing.Point(195, 16)
        Me.Btn_OpcionCancel.Name = "Btn_OpcionCancel"
        Me.Btn_OpcionCancel.Size = New System.Drawing.Size(48, 48)
        Me.Btn_OpcionCancel.TabIndex = 7
        Me.Btn_OpcionCancel.UseVisualStyleBackColor = True
        '
        'Lb_MensajeDialog
        '
        Me.Lb_MensajeDialog.AutoSize = True
        Me.Lb_MensajeDialog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_MensajeDialog.Location = New System.Drawing.Point(10, 19)
        Me.Lb_MensajeDialog.Name = "Lb_MensajeDialog"
        Me.Lb_MensajeDialog.Size = New System.Drawing.Size(0, 13)
        Me.Lb_MensajeDialog.TabIndex = 0
        '
        'Pan_ToolBar
        '
        Me.Pan_ToolBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pan_ToolBar.BackColor = System.Drawing.Color.Blue
        Me.Pan_ToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pan_ToolBar.Controls.Add(Me.Label2)
        Me.Pan_ToolBar.Controls.Add(Me.Lb_Mensaje)
        Me.Pan_ToolBar.Controls.Add(Me.BubbleBar1)
        Me.Pan_ToolBar.Location = New System.Drawing.Point(3, 3)
        Me.Pan_ToolBar.Name = "Pan_ToolBar"
        Me.Pan_ToolBar.Size = New System.Drawing.Size(382, 51)
        Me.Pan_ToolBar.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(246, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 106
        '
        'Lb_Mensaje
        '
        Me.Lb_Mensaje.AutoSize = True
        Me.Lb_Mensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Mensaje.ForeColor = System.Drawing.Color.Red
        Me.Lb_Mensaje.Location = New System.Drawing.Point(246, 16)
        Me.Lb_Mensaje.Name = "Lb_Mensaje"
        Me.Lb_Mensaje.Size = New System.Drawing.Size(0, 13)
        Me.Lb_Mensaje.TabIndex = 1
        '
        'BubbleBar1
        '
        Me.BubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar1.AntiAlias = True
        Me.BubbleBar1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.BubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BubbleBar1.ImageSizeLarge = New System.Drawing.Size(60, 60)
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(40, 40)
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(239, 49)
        Me.BubbleBar1.TabIndex = 0
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.TabsVisible = False
        Me.BubbleBar1.Text = "BubbleBar1"
        Me.BubbleBar1.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BBt_1, Me.BBt_2, Me.BBt_3, Me.BBt_4, Me.BBt_5})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'BBt_1
        '
        Me.BBt_1.Image = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.BBt_1.ImageLarge = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.BBt_1.Name = "BBt_1"
        Me.BBt_1.TooltipText = "Nuevo"
        '
        'BBt_2
        '
        Me.BBt_2.Image = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.BBt_2.ImageLarge = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.BBt_2.Name = "BBt_2"
        Me.BBt_2.TooltipText = "Modificar"
        '
        'BBt_3
        '
        Me.BBt_3.Image = Global.Presentacion.My.Resources.Resources.ELIMINAR
        Me.BBt_3.ImageLarge = Global.Presentacion.My.Resources.Resources.ELIMINAR
        Me.BBt_3.Name = "BBt_3"
        Me.BBt_3.TooltipText = "Eliminar"
        '
        'BBt_4
        '
        Me.BBt_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_4.Image = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.BBt_4.ImageLarge = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.BBt_4.Name = "BBt_4"
        Me.BBt_4.TooltipText = "Grabar"
        '
        'BBt_5
        '
        Me.BBt_5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_5.Image = Global.Presentacion.My.Resources.Resources.CANCELAR
        Me.BBt_5.ImageLarge = Global.Presentacion.My.Resources.Resources.CANCELAR
        Me.BBt_5.Name = "BBt_5"
        Me.BBt_5.TooltipText = "Salir"
        '
        'Pan_Navegador
        '
        Me.Pan_Navegador.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Pan_Navegador.Controls.Add(Me.Lb_CantReg)
        Me.Pan_Navegador.Controls.Add(Me.BubbleBar3)
        Me.Pan_Navegador.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pan_Navegador.Location = New System.Drawing.Point(3, 690)
        Me.Pan_Navegador.Name = "Pan_Navegador"
        Me.Pan_Navegador.Size = New System.Drawing.Size(712, 40)
        Me.Pan_Navegador.TabIndex = 107
        '
        'Lb_CantReg
        '
        Me.Lb_CantReg.AutoSize = True
        Me.Lb_CantReg.Location = New System.Drawing.Point(402, 16)
        Me.Lb_CantReg.Name = "Lb_CantReg"
        Me.Lb_CantReg.Size = New System.Drawing.Size(0, 13)
        Me.Lb_CantReg.TabIndex = 2
        '
        'BubbleBar3
        '
        Me.BubbleBar3.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar3.AntiAlias = True
        Me.BubbleBar3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.BubbleBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar3.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar3.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar3.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar3.ButtonSpacing = 2
        Me.BubbleBar3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BubbleBar3.ImageSizeLarge = New System.Drawing.Size(45, 45)
        Me.BubbleBar3.ImageSizeNormal = New System.Drawing.Size(30, 30)
        Me.BubbleBar3.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBar3.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar3.Name = "BubbleBar3"
        Me.BubbleBar3.SelectedTab = Me.BubbleBarTab3
        Me.BubbleBar3.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar3.Size = New System.Drawing.Size(712, 40)
        Me.BubbleBar3.TabIndex = 0
        Me.BubbleBar3.Tabs.Add(Me.BubbleBarTab3)
        Me.BubbleBar3.TabsVisible = False
        Me.BubbleBar3.Text = "BubbleBar3"
        Me.BubbleBar3.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BubbleBarTab3
        '
        Me.BubbleBarTab3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab3.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.BBt_First, Me.BBt_Back, Me.BBt_Next, Me.BBt_Last})
        Me.BubbleBarTab3.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab3.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab3.Name = "BubbleBarTab3"
        Me.BubbleBarTab3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab3.Text = "BubbleBarTab1"
        Me.BubbleBarTab3.TextColor = System.Drawing.Color.Black
        '
        'BBt_First
        '
        Me.BBt_First.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_First.Image = Global.Presentacion.My.Resources.Resources.INICIO
        Me.BBt_First.ImageLarge = Global.Presentacion.My.Resources.Resources.INICIO
        Me.BBt_First.Name = "BBt_First"
        Me.BBt_First.TooltipText = "Primero"
        '
        'BBt_Back
        '
        Me.BBt_Back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_Back.Image = Global.Presentacion.My.Resources.Resources.ANTERIOR
        Me.BBt_Back.ImageLarge = Global.Presentacion.My.Resources.Resources.ANTERIOR
        Me.BBt_Back.Name = "BBt_Back"
        Me.BBt_Back.TooltipText = "Atras"
        '
        'BBt_Next
        '
        Me.BBt_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_Next.Image = Global.Presentacion.My.Resources.Resources.SIGUIENTE
        Me.BBt_Next.ImageLarge = Global.Presentacion.My.Resources.Resources.SIGUIENTE
        Me.BBt_Next.Name = "BBt_Next"
        Me.BBt_Next.TooltipText = "Adelante"
        '
        'BBt_Last
        '
        Me.BBt_Last.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBt_Last.Image = Global.Presentacion.My.Resources.Resources.ULTIMO
        Me.BBt_Last.ImageLarge = Global.Presentacion.My.Resources.Resources.ULTIMO
        Me.BBt_Last.Name = "BBt_Last"
        Me.BBt_Last.TooltipText = "Ultimo"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(718, 733)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Ep1
        '
        Me.Ep1.ContainerControl = Me
        '
        'Ep2
        '
        Me.Ep2.ContainerControl = Me
        Me.Ep2.Icon = CType(resources.GetObject("Ep2.Icon"), System.Drawing.Icon)
        '
        'dgjRepartidor
        '
        Me.dgjRepartidor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjRepartidor.Location = New System.Drawing.Point(0, 0)
        Me.dgjRepartidor.Name = "dgjRepartidor"
        Me.dgjRepartidor.Size = New System.Drawing.Size(364, 346)
        Me.dgjRepartidor.TabIndex = 116
        '
        'P_Zonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 741)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "P_Zonas"
        Me.Text = "ZONAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.J_Cb_Zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.J_Cb_Provincia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.J_Cb_Ciudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        Me.Pan_Dialogo.ResumeLayout(False)
        Me.Pan_Dialogo.PerformLayout()
        Me.Pan_ToolBar.ResumeLayout(False)
        Me.Pan_ToolBar.PerformLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Navegador.ResumeLayout(False)
        Me.Pan_Navegador.PerformLayout()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ep2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgjRepartidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GM_mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Pan_ToolBar As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lb_Mensaje As System.Windows.Forms.Label
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BBt_4 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BBt_5 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_Id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents J_Cb_Zona As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents J_Cb_Provincia As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents J_Cb_Ciudad As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Pan_Navegador As System.Windows.Forms.Panel
    Friend WithEvents Lb_CantReg As System.Windows.Forms.Label
    Friend WithEvents BubbleBar3 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab3 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BBt_First As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BBt_Back As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BBt_Next As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BBt_Last As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Tb_color As System.Windows.Forms.TextBox
    Friend WithEvents Pan_Dialogo As System.Windows.Forms.Panel
    Friend WithEvents Btn_OpcionCancel As System.Windows.Forms.Button
    Friend WithEvents Lb_MensajeDialog As System.Windows.Forms.Label
    Friend WithEvents BBt_1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BBt_2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents Btn_OpcionOK As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Ep2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BBt_3 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Btn_ZoomMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btn_ZoomMas As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAgregarCiudad As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAgregarZona As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btAgregarProv As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgjRepartidor As Janus.Windows.GridEX.GridEX
End Class
