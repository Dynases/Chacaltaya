<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_PrestamoEquiposAgrupado
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
        Dim CbEquipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PR_PrestamoEquiposAgrupado))
        Me.Gp_Filtros = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.GroupPanelConcepto = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SbConcepto = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.DgjConcepto = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanelEquipo = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CbEquipo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanelCliente = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SbFiltroCliente = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TbNombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbCodigoCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtBuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.CrReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Gp_Filtros.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelConcepto.SuspendLayout()
        CType(Me.DgjConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelEquipo.SuspendLayout()
        CType(Me.CbEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanelConcepto)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanelEquipo)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanelCliente)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Filtros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Gp_Filtros.Name = "Gp_Filtros"
        Me.Gp_Filtros.Size = New System.Drawing.Size(408, 687)
        '
        '
        '
        Me.Gp_Filtros.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp_Filtros.Style.BackColorGradientAngle = 90
        Me.Gp_Filtros.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp_Filtros.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Filtros.Style.BorderBottomWidth = 1
        Me.Gp_Filtros.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp_Filtros.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Filtros.Style.BorderLeftWidth = 1
        Me.Gp_Filtros.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Filtros.Style.BorderRightWidth = 1
        Me.Gp_Filtros.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Filtros.Style.BorderTopWidth = 1
        Me.Gp_Filtros.Style.CornerDiameter = 4
        Me.Gp_Filtros.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp_Filtros.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp_Filtros.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp_Filtros.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp_Filtros.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp_Filtros.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp_Filtros.TabIndex = 3
        Me.Gp_Filtros.Text = "FILTROS"
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
        Me.BubbleBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BubbleBar1.ImageSizeLarge = New System.Drawing.Size(72, 72)
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(64, 64)
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 563)
        Me.BubbleBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(402, 98)
        Me.BubbleBar1.TabIndex = 2
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.TabsVisible = False
        Me.BubbleBar1.Text = "BubbleBar1"
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.Bbtn_GenerarReporte, Me.Bbtn_Cancelar})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'Bbtn_GenerarReporte
        '
        Me.Bbtn_GenerarReporte.Image = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bbtn_GenerarReporte.ImageLarge = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bbtn_GenerarReporte.Name = "Bbtn_GenerarReporte"
        Me.Bbtn_GenerarReporte.TooltipText = "GENERAR"
        '
        'Bbtn_Cancelar
        '
        Me.Bbtn_Cancelar.Image = Global.Presentacion.My.Resources.Resources.CANCEL
        Me.Bbtn_Cancelar.ImageLarge = Global.Presentacion.My.Resources.Resources.CANCEL
        Me.Bbtn_Cancelar.Name = "Bbtn_Cancelar"
        Me.Bbtn_Cancelar.TooltipText = "CANCELAR"
        '
        'GroupPanelConcepto
        '
        Me.GroupPanelConcepto.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanelConcepto.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelConcepto.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelConcepto.Controls.Add(Me.SbConcepto)
        Me.GroupPanelConcepto.Controls.Add(Me.LabelX2)
        Me.GroupPanelConcepto.Controls.Add(Me.DgjConcepto)
        Me.GroupPanelConcepto.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelConcepto.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelConcepto.Location = New System.Drawing.Point(0, 277)
        Me.GroupPanelConcepto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelConcepto.Name = "GroupPanelConcepto"
        Me.GroupPanelConcepto.Size = New System.Drawing.Size(402, 286)
        '
        '
        '
        Me.GroupPanelConcepto.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelConcepto.Style.BackColorGradientAngle = 90
        Me.GroupPanelConcepto.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelConcepto.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelConcepto.Style.BorderBottomWidth = 1
        Me.GroupPanelConcepto.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelConcepto.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelConcepto.Style.BorderLeftWidth = 1
        Me.GroupPanelConcepto.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelConcepto.Style.BorderRightWidth = 1
        Me.GroupPanelConcepto.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelConcepto.Style.BorderTopWidth = 1
        Me.GroupPanelConcepto.Style.CornerDiameter = 4
        Me.GroupPanelConcepto.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelConcepto.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelConcepto.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelConcepto.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelConcepto.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelConcepto.TabIndex = 16
        Me.GroupPanelConcepto.Text = "FILTRO CONCEPTO"
        '
        'SbConcepto
        '
        '
        '
        '
        Me.SbConcepto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbConcepto.Location = New System.Drawing.Point(100, 5)
        Me.SbConcepto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbConcepto.Name = "SbConcepto"
        Me.SbConcepto.OffText = "TODOS"
        Me.SbConcepto.OnText = "VARIOS"
        Me.SbConcepto.Size = New System.Drawing.Size(133, 27)
        Me.SbConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbConcepto.TabIndex = 15
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(8, 4)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 28)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Filtrar:"
        '
        'DgjConcepto
        '
        Me.DgjConcepto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgjConcepto.Location = New System.Drawing.Point(0, 42)
        Me.DgjConcepto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgjConcepto.Name = "DgjConcepto"
        Me.DgjConcepto.Size = New System.Drawing.Size(396, 217)
        Me.DgjConcepto.TabIndex = 0
        '
        'GroupPanelEquipo
        '
        Me.GroupPanelEquipo.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanelEquipo.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelEquipo.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelEquipo.Controls.Add(Me.CbEquipo)
        Me.GroupPanelEquipo.Controls.Add(Me.LabelX1)
        Me.GroupPanelEquipo.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelEquipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelEquipo.Location = New System.Drawing.Point(0, 197)
        Me.GroupPanelEquipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelEquipo.Name = "GroupPanelEquipo"
        Me.GroupPanelEquipo.Size = New System.Drawing.Size(402, 80)
        '
        '
        '
        Me.GroupPanelEquipo.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelEquipo.Style.BackColorGradientAngle = 90
        Me.GroupPanelEquipo.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelEquipo.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelEquipo.Style.BorderBottomWidth = 1
        Me.GroupPanelEquipo.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelEquipo.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelEquipo.Style.BorderLeftWidth = 1
        Me.GroupPanelEquipo.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelEquipo.Style.BorderRightWidth = 1
        Me.GroupPanelEquipo.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelEquipo.Style.BorderTopWidth = 1
        Me.GroupPanelEquipo.Style.CornerDiameter = 4
        Me.GroupPanelEquipo.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelEquipo.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelEquipo.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelEquipo.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelEquipo.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelEquipo.TabIndex = 15
        Me.GroupPanelEquipo.Text = "FILTRO EQUIPO"
        '
        'CbEquipo
        '
        CbEquipo_DesignTimeLayout.LayoutString = resources.GetString("CbEquipo_DesignTimeLayout.LayoutString")
        Me.CbEquipo.DesignTimeLayout = CbEquipo_DesignTimeLayout
        Me.CbEquipo.Location = New System.Drawing.Point(100, 4)
        Me.CbEquipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbEquipo.Name = "CbEquipo"
        Me.CbEquipo.SelectedIndex = -1
        Me.CbEquipo.SelectedItem = Nothing
        Me.CbEquipo.Size = New System.Drawing.Size(288, 26)
        Me.CbEquipo.TabIndex = 0
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(8, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 28)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Equipo:"
        '
        'GroupPanelCliente
        '
        Me.GroupPanelCliente.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanelCliente.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelCliente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelCliente.Controls.Add(Me.SbFiltroCliente)
        Me.GroupPanelCliente.Controls.Add(Me.LabelX4)
        Me.GroupPanelCliente.Controls.Add(Me.TbNombreCliente)
        Me.GroupPanelCliente.Controls.Add(Me.TbCodigoCliente)
        Me.GroupPanelCliente.Controls.Add(Me.BtBuscarCliente)
        Me.GroupPanelCliente.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelCliente.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanelCliente.Name = "GroupPanelCliente"
        Me.GroupPanelCliente.Size = New System.Drawing.Size(402, 197)
        '
        '
        '
        Me.GroupPanelCliente.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelCliente.Style.BackColorGradientAngle = 90
        Me.GroupPanelCliente.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelCliente.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelCliente.Style.BorderBottomWidth = 1
        Me.GroupPanelCliente.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelCliente.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelCliente.Style.BorderLeftWidth = 1
        Me.GroupPanelCliente.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelCliente.Style.BorderRightWidth = 1
        Me.GroupPanelCliente.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelCliente.Style.BorderTopWidth = 1
        Me.GroupPanelCliente.Style.CornerDiameter = 4
        Me.GroupPanelCliente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelCliente.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelCliente.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelCliente.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelCliente.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelCliente.TabIndex = 14
        Me.GroupPanelCliente.Text = "FILTRO CLIENTE"
        '
        'SbFiltroCliente
        '
        '
        '
        '
        Me.SbFiltroCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbFiltroCliente.Location = New System.Drawing.Point(100, 5)
        Me.SbFiltroCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbFiltroCliente.Name = "SbFiltroCliente"
        Me.SbFiltroCliente.OffText = "TODOS"
        Me.SbFiltroCliente.OnText = "UNO"
        Me.SbFiltroCliente.Size = New System.Drawing.Size(133, 27)
        Me.SbFiltroCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbFiltroCliente.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(8, 4)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(83, 28)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "Filtrar:"
        '
        'TbNombreCliente
        '
        '
        '
        '
        Me.TbNombreCliente.Border.Class = "TextBoxBorder"
        Me.TbNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombreCliente.Location = New System.Drawing.Point(8, 82)
        Me.TbNombreCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNombreCliente.Multiline = True
        Me.TbNombreCliente.Name = "TbNombreCliente"
        Me.TbNombreCliente.PreventEnterBeep = True
        Me.TbNombreCliente.Size = New System.Drawing.Size(380, 81)
        Me.TbNombreCliente.TabIndex = 11
        '
        'TbCodigoCliente
        '
        '
        '
        '
        Me.TbCodigoCliente.Border.Class = "TextBoxBorder"
        Me.TbCodigoCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigoCliente.Location = New System.Drawing.Point(8, 47)
        Me.TbCodigoCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCodigoCliente.Name = "TbCodigoCliente"
        Me.TbCodigoCliente.PreventEnterBeep = True
        Me.TbCodigoCliente.Size = New System.Drawing.Size(83, 26)
        Me.TbCodigoCliente.TabIndex = 10
        '
        'BtBuscarCliente
        '
        Me.BtBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtBuscarCliente.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.BtBuscarCliente.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.BtBuscarCliente.Location = New System.Drawing.Point(100, 38)
        Me.BtBuscarCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtBuscarCliente.Name = "BtBuscarCliente"
        Me.BtBuscarCliente.Size = New System.Drawing.Size(51, 42)
        Me.BtBuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtBuscarCliente.TabIndex = 15
        '
        'CrReporte
        '
        Me.CrReporte.ActiveViewIndex = -1
        Me.CrReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrReporte.Location = New System.Drawing.Point(408, 0)
        Me.CrReporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CrReporte.Name = "CrReporte"
        Me.CrReporte.Size = New System.Drawing.Size(475, 687)
        Me.CrReporte.TabIndex = 4
        Me.CrReporte.ToolPanelWidth = 267
        '
        'PR_PrestamoEquiposAgrupado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 687)
        Me.Controls.Add(Me.CrReporte)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PR_PrestamoEquiposAgrupado"
        Me.Gp_Filtros.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelConcepto.ResumeLayout(False)
        CType(Me.DgjConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelEquipo.ResumeLayout(False)
        Me.GroupPanelEquipo.PerformLayout()
        CType(Me.CbEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelCliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CrReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanelCliente As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents SbFiltroCliente As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbNombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbCodigoCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtBuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupPanelEquipo As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanelConcepto As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DgjConcepto As Janus.Windows.GridEX.GridEX
    Friend WithEvents CbEquipo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SbConcepto As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class
