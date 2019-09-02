<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_KardexPrestamos
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
        Me.Gp_Filtros = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.swZona = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbZonaDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbZonaCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscarZona = New DevComponents.DotNetBar.ButtonX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.swCliente = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbCliNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbCliCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.Gp_Fechas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btBuscarConcepto = New DevComponents.DotNetBar.ButtonX()
        Me.tbConCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbConDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Dtp_FechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Gp_Filtros.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Fechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel2)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel1)
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.Gp_Fechas)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Filtros.Name = "Gp_Filtros"
        Me.Gp_Filtros.Size = New System.Drawing.Size(306, 558)
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
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.swZona)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.tbZonaDesc)
        Me.GroupPanel2.Controls.Add(Me.tbZonaCod)
        Me.GroupPanel2.Controls.Add(Me.btBuscarZona)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 242)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(300, 121)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 13
        Me.GroupPanel2.Text = "ZONA"
        '
        'swZona
        '
        '
        '
        '
        Me.swZona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swZona.Location = New System.Drawing.Point(75, 4)
        Me.swZona.Name = "swZona"
        Me.swZona.Size = New System.Drawing.Size(66, 22)
        Me.swZona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swZona.TabIndex = 13
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(6, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "FILTRAR:"
        '
        'tbZonaDesc
        '
        '
        '
        '
        Me.tbZonaDesc.Border.Class = "TextBoxBorder"
        Me.tbZonaDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbZonaDesc.Location = New System.Drawing.Point(6, 64)
        Me.tbZonaDesc.Name = "tbZonaDesc"
        Me.tbZonaDesc.PreventEnterBeep = True
        Me.tbZonaDesc.Size = New System.Drawing.Size(135, 20)
        Me.tbZonaDesc.TabIndex = 11
        '
        'tbZonaCod
        '
        '
        '
        '
        Me.tbZonaCod.Border.Class = "TextBoxBorder"
        Me.tbZonaCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbZonaCod.Location = New System.Drawing.Point(6, 38)
        Me.tbZonaCod.Name = "tbZonaCod"
        Me.tbZonaCod.PreventEnterBeep = True
        Me.tbZonaCod.Size = New System.Drawing.Size(62, 20)
        Me.tbZonaCod.TabIndex = 10
        '
        'btBuscarZona
        '
        Me.btBuscarZona.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarZona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscarZona.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btBuscarZona.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btBuscarZona.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btBuscarZona.Location = New System.Drawing.Point(75, 31)
        Me.btBuscarZona.Name = "btBuscarZona"
        Me.btBuscarZona.Size = New System.Drawing.Size(38, 34)
        Me.btBuscarZona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarZona.TabIndex = 16
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.swCliente)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.tbCliNombre)
        Me.GroupPanel1.Controls.Add(Me.tbCliCod)
        Me.GroupPanel1.Controls.Add(Me.btBuscarCliente)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 121)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(300, 121)
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
        Me.GroupPanel1.TabIndex = 12
        Me.GroupPanel1.Text = "CLIENTE"
        '
        'swCliente
        '
        '
        '
        '
        Me.swCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swCliente.Location = New System.Drawing.Point(75, 4)
        Me.swCliente.Name = "swCliente"
        Me.swCliente.Size = New System.Drawing.Size(66, 22)
        Me.swCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swCliente.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 23)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "FILTRAR:"
        '
        'tbCliNombre
        '
        '
        '
        '
        Me.tbCliNombre.Border.Class = "TextBoxBorder"
        Me.tbCliNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCliNombre.Location = New System.Drawing.Point(6, 64)
        Me.tbCliNombre.Name = "tbCliNombre"
        Me.tbCliNombre.PreventEnterBeep = True
        Me.tbCliNombre.Size = New System.Drawing.Size(285, 20)
        Me.tbCliNombre.TabIndex = 11
        '
        'tbCliCod
        '
        '
        '
        '
        Me.tbCliCod.Border.Class = "TextBoxBorder"
        Me.tbCliCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCliCod.Location = New System.Drawing.Point(6, 38)
        Me.tbCliCod.Name = "tbCliCod"
        Me.tbCliCod.PreventEnterBeep = True
        Me.tbCliCod.Size = New System.Drawing.Size(62, 20)
        Me.tbCliCod.TabIndex = 10
        '
        'btBuscarCliente
        '
        Me.btBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btBuscarCliente.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btBuscarCliente.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btBuscarCliente.Location = New System.Drawing.Point(75, 31)
        Me.btBuscarCliente.Name = "btBuscarCliente"
        Me.btBuscarCliente.Size = New System.Drawing.Size(38, 34)
        Me.btBuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarCliente.TabIndex = 15
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
        Me.BubbleBar1.ImageSizeLarge = New System.Drawing.Size(72, 72)
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(64, 64)
        Me.BubbleBar1.Location = New System.Drawing.Point(3, 369)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(268, 80)
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
        'Gp_Fechas
        '
        Me.Gp_Fechas.BackColor = System.Drawing.Color.Transparent
        Me.Gp_Fechas.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Fechas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Fechas.Controls.Add(Me.btBuscarConcepto)
        Me.Gp_Fechas.Controls.Add(Me.tbConCod)
        Me.Gp_Fechas.Controls.Add(Me.tbConDesc)
        Me.Gp_Fechas.Controls.Add(Me.LabelX3)
        Me.Gp_Fechas.Controls.Add(Me.LabelX2)
        Me.Gp_Fechas.Controls.Add(Me.LabelX1)
        Me.Gp_Fechas.Controls.Add(Me.Dtp_FechaIni)
        Me.Gp_Fechas.Controls.Add(Me.Dtp_FechaFin)
        Me.Gp_Fechas.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Fechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gp_Fechas.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Fechas.Name = "Gp_Fechas"
        Me.Gp_Fechas.Size = New System.Drawing.Size(300, 121)
        '
        '
        '
        Me.Gp_Fechas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp_Fechas.Style.BackColorGradientAngle = 90
        Me.Gp_Fechas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp_Fechas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderBottomWidth = 1
        Me.Gp_Fechas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp_Fechas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderLeftWidth = 1
        Me.Gp_Fechas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderRightWidth = 1
        Me.Gp_Fechas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderTopWidth = 1
        Me.Gp_Fechas.Style.CornerDiameter = 4
        Me.Gp_Fechas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp_Fechas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp_Fechas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp_Fechas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp_Fechas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp_Fechas.TabIndex = 9
        Me.Gp_Fechas.Text = "FECHA Y CONCEPTO"
        '
        'btBuscarConcepto
        '
        Me.btBuscarConcepto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarConcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscarConcepto.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btBuscarConcepto.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.btBuscarConcepto.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btBuscarConcepto.Location = New System.Drawing.Point(249, 53)
        Me.btBuscarConcepto.Name = "btBuscarConcepto"
        Me.btBuscarConcepto.Size = New System.Drawing.Size(38, 36)
        Me.btBuscarConcepto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarConcepto.TabIndex = 14
        '
        'tbConCod
        '
        '
        '
        '
        Me.tbConCod.Border.Class = "TextBoxBorder"
        Me.tbConCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbConCod.Location = New System.Drawing.Point(75, 61)
        Me.tbConCod.Name = "tbConCod"
        Me.tbConCod.PreventEnterBeep = True
        Me.tbConCod.Size = New System.Drawing.Size(36, 20)
        Me.tbConCod.TabIndex = 13
        '
        'tbConDesc
        '
        '
        '
        '
        Me.tbConDesc.Border.Class = "TextBoxBorder"
        Me.tbConDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbConDesc.Location = New System.Drawing.Point(117, 61)
        Me.tbConDesc.Name = "tbConDesc"
        Me.tbConDesc.PreventEnterBeep = True
        Me.tbConDesc.Size = New System.Drawing.Size(130, 20)
        Me.tbConDesc.TabIndex = 12
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(3, 58)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "CONCEPTO:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 29)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(38, 23)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "AL:"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(38, 23)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "DEL:"
        '
        'Dtp_FechaIni
        '
        Me.Dtp_FechaIni.Location = New System.Drawing.Point(47, 3)
        Me.Dtp_FechaIni.Name = "Dtp_FechaIni"
        Me.Dtp_FechaIni.Size = New System.Drawing.Size(200, 20)
        Me.Dtp_FechaIni.TabIndex = 0
        Me.Dtp_FechaIni.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'Dtp_FechaFin
        '
        Me.Dtp_FechaFin.Location = New System.Drawing.Point(47, 29)
        Me.Dtp_FechaFin.Name = "Dtp_FechaFin"
        Me.Dtp_FechaFin.Size = New System.Drawing.Size(200, 20)
        Me.Dtp_FechaFin.TabIndex = 1
        '
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(306, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.Size = New System.Drawing.Size(356, 558)
        Me.Crv.TabIndex = 4
        '
        'PR_KardexPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 558)
        Me.Controls.Add(Me.Crv)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_KardexPrestamos"
        Me.Text = "PR_KardexPrestamos"
        Me.Gp_Filtros.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Fechas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Gp_Fechas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dtp_FechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbCliNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbCliCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swZona As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbZonaDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbZonaCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents swCliente As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbConDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbConCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btBuscarZona As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btBuscarConcepto As DevComponents.DotNetBar.ButtonX
End Class
