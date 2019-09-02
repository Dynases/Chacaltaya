<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_DiferenciaPedidoNota
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbTodo = New System.Windows.Forms.RadioButton()
        Me.RbDifPositiva = New System.Windows.Forms.RadioButton()
        Me.RbDifNegativa = New System.Windows.Forms.RadioButton()
        Me.GpFecha = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SbFiltroFecha = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.DtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GpFiltroUsuarioRepartidor = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TbDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtBuscar = New DevComponents.DotNetBar.ButtonX()
        Me.CrReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SbUsuarioRepartidor = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Gp_Filtros.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.GpFecha.SuspendLayout()
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpFiltroUsuarioRepartidor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel1)
        Me.Gp_Filtros.Controls.Add(Me.GpFecha)
        Me.Gp_Filtros.Controls.Add(Me.GpFiltroUsuarioRepartidor)
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
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 357)
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
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.RbTodo)
        Me.GroupPanel1.Controls.Add(Me.RbDifPositiva)
        Me.GroupPanel1.Controls.Add(Me.RbDifNegativa)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 248)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(300, 109)
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
        Me.GroupPanel1.TabIndex = 16
        Me.GroupPanel1.Text = "FILTRO CRITERIO"
        '
        'RbTodo
        '
        Me.RbTodo.AutoSize = True
        Me.RbTodo.BackColor = System.Drawing.Color.Transparent
        Me.RbTodo.Location = New System.Drawing.Point(64, 57)
        Me.RbTodo.Name = "RbTodo"
        Me.RbTodo.Size = New System.Drawing.Size(59, 21)
        Me.RbTodo.TabIndex = 2
        Me.RbTodo.TabStop = True
        Me.RbTodo.Text = "Todo"
        Me.RbTodo.UseVisualStyleBackColor = False
        '
        'RbDifPositiva
        '
        Me.RbDifPositiva.AutoSize = True
        Me.RbDifPositiva.BackColor = System.Drawing.Color.Transparent
        Me.RbDifPositiva.Location = New System.Drawing.Point(64, 30)
        Me.RbDifPositiva.Name = "RbDifPositiva"
        Me.RbDifPositiva.Size = New System.Drawing.Size(143, 21)
        Me.RbDifPositiva.TabIndex = 1
        Me.RbDifPositiva.TabStop = True
        Me.RbDifPositiva.Text = "Diferencia Positiva"
        Me.RbDifPositiva.UseVisualStyleBackColor = False
        '
        'RbDifNegativa
        '
        Me.RbDifNegativa.AutoSize = True
        Me.RbDifNegativa.BackColor = System.Drawing.Color.Transparent
        Me.RbDifNegativa.Location = New System.Drawing.Point(64, 3)
        Me.RbDifNegativa.Name = "RbDifNegativa"
        Me.RbDifNegativa.Size = New System.Drawing.Size(150, 21)
        Me.RbDifNegativa.TabIndex = 0
        Me.RbDifNegativa.TabStop = True
        Me.RbDifNegativa.Text = "Diferencia Negativa"
        Me.RbDifNegativa.UseVisualStyleBackColor = False
        '
        'GpFecha
        '
        Me.GpFecha.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpFecha.Controls.Add(Me.SbFiltroFecha)
        Me.GpFecha.Controls.Add(Me.LabelX3)
        Me.GpFecha.Controls.Add(Me.LabelX2)
        Me.GpFecha.Controls.Add(Me.LabelX1)
        Me.GpFecha.Controls.Add(Me.DtiHasta)
        Me.GpFecha.Controls.Add(Me.DtiDesde)
        Me.GpFecha.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpFecha.Location = New System.Drawing.Point(0, 123)
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
        Me.GpFecha.Text = "FILTRO FECHAS"
        '
        'SbFiltroFecha
        '
        '
        '
        '
        Me.SbFiltroFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbFiltroFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbFiltroFecha.Location = New System.Drawing.Point(64, 12)
        Me.SbFiltroFecha.Name = "SbFiltroFecha"
        Me.SbFiltroFecha.OffText = "NO"
        Me.SbFiltroFecha.OnText = "SI"
        Me.SbFiltroFecha.Size = New System.Drawing.Size(100, 22)
        Me.SbFiltroFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbFiltroFecha.TabIndex = 4
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
        Me.LabelX3.Text = "FILTRAR:"
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
        'GpFiltroUsuarioRepartidor
        '
        Me.GpFiltroUsuarioRepartidor.BackColor = System.Drawing.Color.Transparent
        Me.GpFiltroUsuarioRepartidor.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpFiltroUsuarioRepartidor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpFiltroUsuarioRepartidor.Controls.Add(Me.SbUsuarioRepartidor)
        Me.GpFiltroUsuarioRepartidor.Controls.Add(Me.LabelX4)
        Me.GpFiltroUsuarioRepartidor.Controls.Add(Me.TbDescripcion)
        Me.GpFiltroUsuarioRepartidor.Controls.Add(Me.TbCodigo)
        Me.GpFiltroUsuarioRepartidor.Controls.Add(Me.BtBuscar)
        Me.GpFiltroUsuarioRepartidor.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpFiltroUsuarioRepartidor.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpFiltroUsuarioRepartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpFiltroUsuarioRepartidor.Location = New System.Drawing.Point(0, 0)
        Me.GpFiltroUsuarioRepartidor.Name = "GpFiltroUsuarioRepartidor"
        Me.GpFiltroUsuarioRepartidor.Size = New System.Drawing.Size(300, 123)
        '
        '
        '
        Me.GpFiltroUsuarioRepartidor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpFiltroUsuarioRepartidor.Style.BackColorGradientAngle = 90
        Me.GpFiltroUsuarioRepartidor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpFiltroUsuarioRepartidor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFiltroUsuarioRepartidor.Style.BorderBottomWidth = 1
        Me.GpFiltroUsuarioRepartidor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpFiltroUsuarioRepartidor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFiltroUsuarioRepartidor.Style.BorderLeftWidth = 1
        Me.GpFiltroUsuarioRepartidor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFiltroUsuarioRepartidor.Style.BorderRightWidth = 1
        Me.GpFiltroUsuarioRepartidor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpFiltroUsuarioRepartidor.Style.BorderTopWidth = 1
        Me.GpFiltroUsuarioRepartidor.Style.CornerDiameter = 4
        Me.GpFiltroUsuarioRepartidor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpFiltroUsuarioRepartidor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpFiltroUsuarioRepartidor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpFiltroUsuarioRepartidor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpFiltroUsuarioRepartidor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpFiltroUsuarioRepartidor.TabIndex = 14
        Me.GpFiltroUsuarioRepartidor.Text = "FILTRO USUARIO/REPARTIDOR"
        '
        'TbDescripcion
        '
        '
        '
        '
        Me.TbDescripcion.Border.Class = "TextBoxBorder"
        Me.TbDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbDescripcion.Location = New System.Drawing.Point(6, 70)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.PreventEnterBeep = True
        Me.TbDescripcion.Size = New System.Drawing.Size(285, 23)
        Me.TbDescripcion.TabIndex = 11
        '
        'TbCodigo
        '
        '
        '
        '
        Me.TbCodigo.Border.Class = "TextBoxBorder"
        Me.TbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigo.Location = New System.Drawing.Point(6, 41)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.PreventEnterBeep = True
        Me.TbCodigo.Size = New System.Drawing.Size(62, 23)
        Me.TbCodigo.TabIndex = 10
        '
        'BtBuscar
        '
        Me.BtBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.BtBuscar.Image = Global.Presentacion.My.Resources.Resources.buscar
        Me.BtBuscar.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.BtBuscar.Location = New System.Drawing.Point(75, 34)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(38, 34)
        Me.BtBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtBuscar.TabIndex = 15
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
        'SbUsuarioRepartidor
        '
        '
        '
        '
        Me.SbUsuarioRepartidor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbUsuarioRepartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbUsuarioRepartidor.Location = New System.Drawing.Point(64, 3)
        Me.SbUsuarioRepartidor.Name = "SbUsuarioRepartidor"
        Me.SbUsuarioRepartidor.OffText = "USUARIO"
        Me.SbUsuarioRepartidor.OnText = "REPARTIDOR"
        Me.SbUsuarioRepartidor.Size = New System.Drawing.Size(150, 22)
        Me.SbUsuarioRepartidor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbUsuarioRepartidor.TabIndex = 16
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.LabelX4.Location = New System.Drawing.Point(6, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 23)
        Me.LabelX4.TabIndex = 17
        Me.LabelX4.Text = "FILTRAR:"
        '
        'PR_DiferenciaPedidoNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 558)
        Me.Controls.Add(Me.CrReporte)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_DiferenciaPedidoNota"
        Me.Gp_Filtros.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GpFecha.ResumeLayout(False)
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpFiltroUsuarioRepartidor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CrReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GpFiltroUsuarioRepartidor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TbDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtBuscar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GpFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents DtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents SbFiltroFecha As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbTodo As System.Windows.Forms.RadioButton
    Friend WithEvents RbDifPositiva As System.Windows.Forms.RadioButton
    Friend WithEvents RbDifNegativa As System.Windows.Forms.RadioButton
    Friend WithEvents SbUsuarioRepartidor As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
End Class
