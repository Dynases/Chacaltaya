<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_FacturaVsVenta
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
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.GpFecha = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SbFiltroFecha = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GpDatosCliente = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TbNombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbCodigoCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtBuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.CrReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GpCriterio = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbFactura = New System.Windows.Forms.RadioButton()
        Me.RbTodo = New System.Windows.Forms.RadioButton()
        Me.Gp_Filtros.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpFecha.SuspendLayout()
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpDatosCliente.SuspendLayout()
        Me.GpCriterio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.GpCriterio)
        Me.Gp_Filtros.Controls.Add(Me.GpFecha)
        Me.Gp_Filtros.Controls.Add(Me.GpDatosCliente)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 343)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(300, 80)
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
        'GpFecha
        '
        Me.GpFecha.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpFecha.Controls.Add(Me.SbFiltroFecha)
        Me.GpFecha.Controls.Add(Me.LabelX2)
        Me.GpFecha.Controls.Add(Me.LabelX1)
        Me.GpFecha.Controls.Add(Me.DtiHasta)
        Me.GpFecha.Controls.Add(Me.DtiDesde)
        Me.GpFecha.Controls.Add(Me.LabelX3)
        Me.GpFecha.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpFecha.Location = New System.Drawing.Point(0, 135)
        Me.GpFecha.Name = "GpFecha"
        Me.GpFecha.Size = New System.Drawing.Size(300, 125)
        '
        '
        '
        Me.GpFecha.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpFecha.Style.BackColorGradientAngle = 90
        Me.GpFecha.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpFecha.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFecha.Style.BorderBottomWidth = 1
        Me.GpFecha.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpFecha.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFecha.Style.BorderLeftWidth = 1
        Me.GpFecha.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFecha.Style.BorderRightWidth = 1
        Me.GpFecha.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFecha.Style.BorderTopWidth = 1
        Me.GpFecha.Style.CornerDiameter = 4
        Me.GpFecha.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpFecha.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpFecha.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpFecha.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpFecha.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpFecha.TabIndex = 15
        Me.GpFecha.Text = "FECHAS"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX3.Location = New System.Drawing.Point(6, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 23)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Filtrar:"
        '
        'SbFiltroFecha
        '
        '
        '
        '
        Me.SbFiltroFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbFiltroFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbFiltroFecha.Location = New System.Drawing.Point(64, 13)
        Me.SbFiltroFecha.Name = "SbFiltroFecha"
        Me.SbFiltroFecha.OffText = "NO"
        Me.SbFiltroFecha.OnText = "SI"
        Me.SbFiltroFecha.Size = New System.Drawing.Size(100, 22)
        Me.SbFiltroFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbFiltroFecha.TabIndex = 4
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX2.Location = New System.Drawing.Point(6, 70)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(52, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Hasta:"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX1.Location = New System.Drawing.Point(6, 41)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(52, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Desde:"
        '
        'DtiHasta
        '
        '
        '
        '
        Me.DtiHasta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtiHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtiHasta.ButtonDropDown.Visible = True
        Me.DtiHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtiHasta.IsPopupCalendarOpen = False
        Me.DtiHasta.Location = New System.Drawing.Point(64, 70)
        '
        '
        '
        '
        '
        '
        Me.DtiHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiHasta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtiHasta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtiHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiHasta.MonthCalendar.DisplayMonth = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.DtiHasta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtiHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiHasta.MonthCalendar.TodayButtonVisible = True
        Me.DtiHasta.Name = "DtiHasta"
        Me.DtiHasta.Size = New System.Drawing.Size(227, 23)
        Me.DtiHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiHasta.TabIndex = 1
        '
        'DtiDesde
        '
        '
        '
        '
        Me.DtiDesde.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtiDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtiDesde.ButtonDropDown.Visible = True
        Me.DtiDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtiDesde.IsPopupCalendarOpen = False
        Me.DtiDesde.Location = New System.Drawing.Point(64, 41)
        '
        '
        '
        '
        '
        '
        Me.DtiDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiDesde.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtiDesde.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtiDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiDesde.MonthCalendar.DisplayMonth = New Date(2017, 4, 1, 0, 0, 0, 0)
        Me.DtiDesde.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtiDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiDesde.MonthCalendar.TodayButtonVisible = True
        Me.DtiDesde.Name = "DtiDesde"
        Me.DtiDesde.Size = New System.Drawing.Size(227, 23)
        Me.DtiDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiDesde.TabIndex = 0
        '
        'GpDatosCliente
        '
        Me.GpDatosCliente.BackColor = System.Drawing.Color.Transparent
        Me.GpDatosCliente.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpDatosCliente.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpDatosCliente.Controls.Add(Me.TbNombreCliente)
        Me.GpDatosCliente.Controls.Add(Me.TbCodigoCliente)
        Me.GpDatosCliente.Controls.Add(Me.BtBuscarCliente)
        Me.GpDatosCliente.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpDatosCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpDatosCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDatosCliente.Location = New System.Drawing.Point(0, 0)
        Me.GpDatosCliente.Name = "GpDatosCliente"
        Me.GpDatosCliente.Size = New System.Drawing.Size(300, 135)
        '
        '
        '
        Me.GpDatosCliente.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpDatosCliente.Style.BackColorGradientAngle = 90
        Me.GpDatosCliente.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpDatosCliente.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosCliente.Style.BorderBottomWidth = 1
        Me.GpDatosCliente.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpDatosCliente.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosCliente.Style.BorderLeftWidth = 1
        Me.GpDatosCliente.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosCliente.Style.BorderRightWidth = 1
        Me.GpDatosCliente.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatosCliente.Style.BorderTopWidth = 1
        Me.GpDatosCliente.Style.CornerDiameter = 4
        Me.GpDatosCliente.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpDatosCliente.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpDatosCliente.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpDatosCliente.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpDatosCliente.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpDatosCliente.TabIndex = 14
        Me.GpDatosCliente.Text = "CLIENTE"
        '
        'TbNombreCliente
        '
        '
        '
        '
        Me.TbNombreCliente.Border.Class = "TextBoxBorder"
        Me.TbNombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbNombreCliente.Location = New System.Drawing.Point(6, 41)
        Me.TbNombreCliente.Multiline = True
        Me.TbNombreCliente.Name = "TbNombreCliente"
        Me.TbNombreCliente.PreventEnterBeep = True
        Me.TbNombreCliente.Size = New System.Drawing.Size(285, 66)
        Me.TbNombreCliente.TabIndex = 11
        '
        'TbCodigoCliente
        '
        '
        '
        '
        Me.TbCodigoCliente.Border.Class = "TextBoxBorder"
        Me.TbCodigoCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigoCliente.Location = New System.Drawing.Point(6, 12)
        Me.TbCodigoCliente.Name = "TbCodigoCliente"
        Me.TbCodigoCliente.PreventEnterBeep = True
        Me.TbCodigoCliente.Size = New System.Drawing.Size(62, 23)
        Me.TbCodigoCliente.TabIndex = 10
        '
        'BtBuscarCliente
        '
        Me.BtBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtBuscarCliente.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.BtBuscarCliente.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.BtBuscarCliente.Location = New System.Drawing.Point(75, 5)
        Me.BtBuscarCliente.Name = "BtBuscarCliente"
        Me.BtBuscarCliente.Size = New System.Drawing.Size(38, 34)
        Me.BtBuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtBuscarCliente.TabIndex = 15
        '
        'CrReporte
        '
        Me.CrReporte.ActiveViewIndex = -1
        Me.CrReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrReporte.Location = New System.Drawing.Point(306, 0)
        Me.CrReporte.Name = "CrReporte"
        Me.CrReporte.Size = New System.Drawing.Size(356, 558)
        Me.CrReporte.TabIndex = 4
        '
        'GpCriterio
        '
        Me.GpCriterio.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpCriterio.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpCriterio.Controls.Add(Me.RbTodo)
        Me.GpCriterio.Controls.Add(Me.RbFactura)
        Me.GpCriterio.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpCriterio.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpCriterio.Location = New System.Drawing.Point(0, 260)
        Me.GpCriterio.Name = "GpCriterio"
        Me.GpCriterio.Size = New System.Drawing.Size(300, 83)
        '
        '
        '
        Me.GpCriterio.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpCriterio.Style.BackColorGradientAngle = 90
        Me.GpCriterio.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpCriterio.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpCriterio.Style.BorderBottomWidth = 1
        Me.GpCriterio.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpCriterio.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpCriterio.Style.BorderLeftWidth = 1
        Me.GpCriterio.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpCriterio.Style.BorderRightWidth = 1
        Me.GpCriterio.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpCriterio.Style.BorderTopWidth = 1
        Me.GpCriterio.Style.CornerDiameter = 4
        Me.GpCriterio.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpCriterio.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpCriterio.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpCriterio.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpCriterio.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpCriterio.TabIndex = 16
        Me.GpCriterio.Text = "CRITERIO"
        '
        'RbFactura
        '
        Me.RbFactura.AutoSize = True
        Me.RbFactura.BackColor = System.Drawing.Color.Transparent
        Me.RbFactura.Location = New System.Drawing.Point(64, 3)
        Me.RbFactura.Name = "RbFactura"
        Me.RbFactura.Size = New System.Drawing.Size(135, 21)
        Me.RbFactura.TabIndex = 0
        Me.RbFactura.TabStop = True
        Me.RbFactura.Text = "Solo Con Factura"
        Me.RbFactura.UseVisualStyleBackColor = False
        '
        'RbTodo
        '
        Me.RbTodo.AutoSize = True
        Me.RbTodo.BackColor = System.Drawing.Color.Transparent
        Me.RbTodo.Location = New System.Drawing.Point(64, 30)
        Me.RbTodo.Name = "RbTodo"
        Me.RbTodo.Size = New System.Drawing.Size(139, 21)
        Me.RbTodo.TabIndex = 1
        Me.RbTodo.TabStop = True
        Me.RbTodo.Text = "Con ó Sin Factura"
        Me.RbTodo.UseVisualStyleBackColor = False
        '
        'PR_FacturaVsVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 558)
        Me.Controls.Add(Me.CrReporte)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_FacturaVsVenta"
        Me.Gp_Filtros.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpFecha.ResumeLayout(False)
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpDatosCliente.ResumeLayout(False)
        Me.GpCriterio.ResumeLayout(False)
        Me.GpCriterio.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CrReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GpDatosCliente As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TbNombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbCodigoCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtBuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GpFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SbFiltroFecha As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents GpCriterio As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbTodo As System.Windows.Forms.RadioButton
    Friend WithEvents RbFactura As System.Windows.Forms.RadioButton
End Class
