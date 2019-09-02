<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_UltimosPedidos
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
        Dim CbZona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PR_UltimosPedidos))
        Dim CbCliente_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim CbEquipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Cr1Reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bt1Generar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt2Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.GroupPanel6 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CbZona = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Tb1CodZona = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CbCliente = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Tb2CodCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dt1Desde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CbEquipo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Tb3CodEquipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel6.SuspendLayout()
        CType(Me.CbZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.CbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.Dt1Desde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.CbEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Cr1Reporte)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(884, 661)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Cr1Reporte
        '
        Me.Cr1Reporte.ActiveViewIndex = -1
        Me.Cr1Reporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cr1Reporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cr1Reporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cr1Reporte.Location = New System.Drawing.Point(300, 0)
        Me.Cr1Reporte.Name = "Cr1Reporte"
        Me.Cr1Reporte.Size = New System.Drawing.Size(584, 661)
        Me.Cr1Reporte.TabIndex = 0
        Me.Cr1Reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.BubbleBar1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel6)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel5)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(300, 661)
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
        Me.GroupPanel1.Text = "Filtros"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(44, 390)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(197, 80)
        Me.BubbleBar1.TabIndex = 12
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.TabsVisible = False
        Me.BubbleBar1.Text = "BubbleBar1"
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.Bt1Generar, Me.Bt2Cancelar})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'Bt1Generar
        '
        Me.Bt1Generar.Image = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bt1Generar.ImageLarge = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bt1Generar.Name = "Bt1Generar"
        Me.Bt1Generar.TooltipText = "GENERAR"
        '
        'Bt2Cancelar
        '
        Me.Bt2Cancelar.Image = Global.Presentacion.My.Resources.Resources.CANCEL
        Me.Bt2Cancelar.ImageLarge = Global.Presentacion.My.Resources.Resources.CANCEL
        Me.Bt2Cancelar.Name = "Bt2Cancelar"
        Me.Bt2Cancelar.TooltipText = "CANCELAR"
        '
        'GroupPanel6
        '
        Me.GroupPanel6.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel6.Controls.Add(Me.CbZona)
        Me.GroupPanel6.Controls.Add(Me.Tb1CodZona)
        Me.GroupPanel6.Controls.Add(Me.LabelX5)
        Me.GroupPanel6.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel6.Location = New System.Drawing.Point(0, 4)
        Me.GroupPanel6.Name = "GroupPanel6"
        Me.GroupPanel6.Size = New System.Drawing.Size(294, 83)
        '
        '
        '
        Me.GroupPanel6.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel6.Style.BackColorGradientAngle = 90
        Me.GroupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderBottomWidth = 1
        Me.GroupPanel6.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderLeftWidth = 1
        Me.GroupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderRightWidth = 1
        Me.GroupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel6.Style.BorderTopWidth = 1
        Me.GroupPanel6.Style.CornerDiameter = 4
        Me.GroupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel6.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel6.TabIndex = 5
        Me.GroupPanel6.Text = "Zona"
        '
        'CbZona
        '
        CbZona_DesignTimeLayout.LayoutString = resources.GetString("CbZona_DesignTimeLayout.LayoutString")
        Me.CbZona.DesignTimeLayout = CbZona_DesignTimeLayout
        Me.CbZona.Location = New System.Drawing.Point(49, 31)
        Me.CbZona.Name = "CbZona"
        Me.CbZona.SelectedIndex = -1
        Me.CbZona.SelectedItem = Nothing
        Me.CbZona.Size = New System.Drawing.Size(236, 20)
        Me.CbZona.TabIndex = 3
        '
        'Tb1CodZona
        '
        '
        '
        '
        Me.Tb1CodZona.Border.Class = "TextBoxBorder"
        Me.Tb1CodZona.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb1CodZona.Location = New System.Drawing.Point(3, 32)
        Me.Tb1CodZona.Name = "Tb1CodZona"
        Me.Tb1CodZona.PreventEnterBeep = True
        Me.Tb1CodZona.Size = New System.Drawing.Size(40, 20)
        Me.Tb1CodZona.TabIndex = 1
        Me.Tb1CodZona.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(93, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Elija la Zona:"
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.CbCliente)
        Me.GroupPanel5.Controls.Add(Me.Tb2CodCliente)
        Me.GroupPanel5.Controls.Add(Me.LabelX4)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 97)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(294, 83)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 4
        Me.GroupPanel5.Text = "Cliente"
        '
        'CbCliente
        '
        CbCliente_DesignTimeLayout.LayoutString = resources.GetString("CbCliente_DesignTimeLayout.LayoutString")
        Me.CbCliente.DesignTimeLayout = CbCliente_DesignTimeLayout
        Me.CbCliente.Location = New System.Drawing.Point(49, 32)
        Me.CbCliente.Name = "CbCliente"
        Me.CbCliente.SelectedIndex = -1
        Me.CbCliente.SelectedItem = Nothing
        Me.CbCliente.Size = New System.Drawing.Size(236, 20)
        Me.CbCliente.TabIndex = 4
        '
        'Tb2CodCliente
        '
        '
        '
        '
        Me.Tb2CodCliente.Border.Class = "TextBoxBorder"
        Me.Tb2CodCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb2CodCliente.Location = New System.Drawing.Point(3, 32)
        Me.Tb2CodCliente.Name = "Tb2CodCliente"
        Me.Tb2CodCliente.PreventEnterBeep = True
        Me.Tb2CodCliente.Size = New System.Drawing.Size(40, 20)
        Me.Tb2CodCliente.TabIndex = 1
        Me.Tb2CodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(4, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(93, 23)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Elija el Cliente:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Dt1Desde)
        Me.GroupPanel4.Controls.Add(Me.LabelX2)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 284)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(294, 81)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 1
        Me.GroupPanel4.Text = "Fecha"
        '
        'Dt1Desde
        '
        '
        '
        '
        Me.Dt1Desde.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dt1Desde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dt1Desde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dt1Desde.ButtonDropDown.Visible = True
        Me.Dt1Desde.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.Dt1Desde.IsPopupCalendarOpen = False
        Me.Dt1Desde.Location = New System.Drawing.Point(4, 32)
        '
        '
        '
        '
        '
        '
        Me.Dt1Desde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dt1Desde.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dt1Desde.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dt1Desde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dt1Desde.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
        Me.Dt1Desde.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dt1Desde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dt1Desde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dt1Desde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dt1Desde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dt1Desde.MonthCalendar.TodayButtonVisible = True
        Me.Dt1Desde.Name = "Dt1Desde"
        Me.Dt1Desde.Size = New System.Drawing.Size(231, 20)
        Me.Dt1Desde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dt1Desde.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(93, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Fecha Maxima:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.CbEquipo)
        Me.GroupPanel3.Controls.Add(Me.Tb3CodEquipo)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(0, 190)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(294, 83)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 0
        Me.GroupPanel3.Text = "Equipo"
        '
        'CbEquipo
        '
        CbEquipo_DesignTimeLayout.LayoutString = resources.GetString("CbEquipo_DesignTimeLayout.LayoutString")
        Me.CbEquipo.DesignTimeLayout = CbEquipo_DesignTimeLayout
        Me.CbEquipo.Location = New System.Drawing.Point(49, 31)
        Me.CbEquipo.Name = "CbEquipo"
        Me.CbEquipo.SelectedIndex = -1
        Me.CbEquipo.SelectedItem = Nothing
        Me.CbEquipo.Size = New System.Drawing.Size(236, 20)
        Me.CbEquipo.TabIndex = 5
        '
        'Tb3CodEquipo
        '
        '
        '
        '
        Me.Tb3CodEquipo.Border.Class = "TextBoxBorder"
        Me.Tb3CodEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb3CodEquipo.Location = New System.Drawing.Point(3, 32)
        Me.Tb3CodEquipo.Name = "Tb3CodEquipo"
        Me.Tb3CodEquipo.PreventEnterBeep = true
        Me.Tb3CodEquipo.Size = New System.Drawing.Size(40, 20)
        Me.Tb3CodEquipo.TabIndex = 1
        Me.Tb3CodEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(93, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Elija el Equipo:"
        '
        'PR_UltimosPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "PR_UltimosPedidos"
        Me.Text = "REPORTE DE ULTIMOS PEDIDOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(false)
        Me.GroupPanel1.ResumeLayout(false)
        CType(Me.BubbleBar1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupPanel6.ResumeLayout(false)
        Me.GroupPanel6.PerformLayout
        CType(Me.CbZona,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupPanel5.ResumeLayout(false)
        Me.GroupPanel5.PerformLayout
        CType(Me.CbCliente,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupPanel4.ResumeLayout(false)
        CType(Me.Dt1Desde,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupPanel3.ResumeLayout(false)
        Me.GroupPanel3.PerformLayout
        CType(Me.CbEquipo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cr1Reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dt1Desde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb3CodEquipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel6 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb1CodZona As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Tb2CodCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bt1Generar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bt2Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CbZona As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents CbCliente As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents CbEquipo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
