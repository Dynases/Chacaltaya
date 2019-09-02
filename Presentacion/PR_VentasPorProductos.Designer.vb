<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PR_VentasPorProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim cbProducto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PR_VentasPorProductos))
        Me.Gp_Filtros = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cbProducto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.swFiltro = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dtFecha1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.dtFecha2 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Gp_Filtros.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dtFecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel1)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel2)
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Filtros.Name = "Gp_Filtros"
        Me.Gp_Filtros.Size = New System.Drawing.Size(237, 449)
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
        Me.Gp_Filtros.TabIndex = 4
        Me.Gp_Filtros.Text = "FILTROS"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.cbProducto)
        Me.GroupPanel1.Controls.Add(Me.swFiltro)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 121)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(231, 121)
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
        Me.GroupPanel1.Text = "TIPO DE PRODUCTO"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(6, 41)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(78, 23)
        Me.LabelX2.TabIndex = 15
        Me.LabelX2.Text = "PRODUCTO:"
        '
        'cbProducto
        '
        cbProducto_DesignTimeLayout.LayoutString = resources.GetString("cbProducto_DesignTimeLayout.LayoutString")
        Me.cbProducto.DesignTimeLayout = cbProducto_DesignTimeLayout
        Me.cbProducto.Enabled = False
        Me.cbProducto.Location = New System.Drawing.Point(86, 43)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.SelectedIndex = -1
        Me.cbProducto.SelectedItem = Nothing
        Me.cbProducto.Size = New System.Drawing.Size(136, 20)
        Me.cbProducto.TabIndex = 14
        '
        'swFiltro
        '
        '
        '
        '
        Me.swFiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swFiltro.Location = New System.Drawing.Point(86, 12)
        Me.swFiltro.Name = "swFiltro"
        Me.swFiltro.OffText = "TODOS"
        Me.swFiltro.OnText = "UNO"
        Me.swFiltro.Size = New System.Drawing.Size(80, 22)
        Me.swFiltro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swFiltro.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 12)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 23)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "MOSTRAR:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.dtFecha1)
        Me.GroupPanel2.Controls.Add(Me.dtFecha2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(231, 121)
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
        Me.GroupPanel2.Text = "FECHAS"
        '
        'dtFecha1
        '
        '
        '
        '
        Me.dtFecha1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFecha1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFecha1.ButtonDropDown.Visible = True
        Me.dtFecha1.IsPopupCalendarOpen = False
        Me.dtFecha1.Location = New System.Drawing.Point(83, 17)
        '
        '
        '
        '
        '
        '
        Me.dtFecha1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha1.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFecha1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFecha1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha1.MonthCalendar.DisplayMonth = New Date(2018, 3, 1, 0, 0, 0, 0)
        Me.dtFecha1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtFecha1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFecha1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecha1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFecha1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha1.MonthCalendar.TodayButtonVisible = True
        Me.dtFecha1.Name = "dtFecha1"
        Me.dtFecha1.Size = New System.Drawing.Size(119, 20)
        Me.dtFecha1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFecha1.TabIndex = 15
        '
        'dtFecha2
        '
        '
        '
        '
        Me.dtFecha2.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFecha2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha2.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFecha2.ButtonDropDown.Visible = True
        Me.dtFecha2.IsPopupCalendarOpen = False
        Me.dtFecha2.Location = New System.Drawing.Point(83, 55)
        '
        '
        '
        '
        '
        '
        Me.dtFecha2.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha2.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtFecha2.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFecha2.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha2.MonthCalendar.DisplayMonth = New Date(2018, 3, 1, 0, 0, 0, 0)
        Me.dtFecha2.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtFecha2.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFecha2.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFecha2.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFecha2.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFecha2.MonthCalendar.TodayButtonVisible = True
        Me.dtFecha2.Name = "dtFecha2"
        Me.dtFecha2.Size = New System.Drawing.Size(119, 20)
        Me.dtFecha2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFecha2.TabIndex = 14
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 55)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(72, 23)
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "FECHA AL:"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 14)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(72, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "FECHA DEL:"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(15, 323)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(197, 80)
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
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(237, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.Size = New System.Drawing.Size(410, 449)
        Me.Crv.TabIndex = 5
        '
        'PR_VentasPorProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 449)
        Me.Controls.Add(Me.Crv)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_VentasPorProductos"
        Me.Text = "PR_Clientes"
        Me.Gp_Filtros.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.cbProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dtFecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swFiltro As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbProducto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents dtFecha1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents dtFecha2 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
End Class
