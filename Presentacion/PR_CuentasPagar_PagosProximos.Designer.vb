<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_CuentasPagar_PagosProximos
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
        Dim CbProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PR_CuentasPagar_PagosProximos))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Cr1Reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.SbTodosUno = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bt1Generar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt2Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DtiHasta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.GpProveedor = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.CbProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpProveedor.SuspendLayout()
        CType(Me.CbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cr1Reporte.Location = New System.Drawing.Point(350, 0)
        Me.Cr1Reporte.Name = "Cr1Reporte"
        Me.Cr1Reporte.Size = New System.Drawing.Size(534, 661)
        Me.Cr1Reporte.TabIndex = 0
        Me.Cr1Reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.SbTodosUno)
        Me.GroupPanel1.Controls.Add(Me.BubbleBar1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.Controls.Add(Me.GpProveedor)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(350, 661)
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
        'SbTodosUno
        '
        '
        '
        '
        Me.SbTodosUno.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SbTodosUno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbTodosUno.Location = New System.Drawing.Point(102, 3)
        Me.SbTodosUno.Name = "SbTodosUno"
        Me.SbTodosUno.OffText = "TODOS"
        Me.SbTodosUno.OnText = "UNO"
        Me.SbTodosUno.Size = New System.Drawing.Size(135, 22)
        Me.SbTodosUno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbTodosUno.TabIndex = 3
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
        Me.BubbleBar1.Location = New System.Drawing.Point(76, 256)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(197, 80)
        Me.BubbleBar1.TabIndex = 4
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
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.DtiHasta)
        Me.GroupPanel4.Controls.Add(Me.LabelX3)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 148)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(341, 85)
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
        Me.GroupPanel4.Text = "Fechas Limite"
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
        Me.DtiHasta.Format = DevComponents.Editors.eDateTimePickerFormat.[Long]
        Me.DtiHasta.IsPopupCalendarOpen = False
        Me.DtiHasta.Location = New System.Drawing.Point(3, 32)
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
        Me.DtiHasta.MonthCalendar.DisplayMonth = New Date(2016, 8, 1, 0, 0, 0, 0)
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
        Me.DtiHasta.Size = New System.Drawing.Size(329, 23)
        Me.DtiHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiHasta.TabIndex = 3
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(3, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Hasta:"
        '
        'GpProveedor
        '
        Me.GpProveedor.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpProveedor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpProveedor.Controls.Add(Me.LabelX2)
        Me.GpProveedor.Controls.Add(Me.CbProveedor)
        Me.GpProveedor.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpProveedor.Location = New System.Drawing.Point(0, 42)
        Me.GpProveedor.Name = "GpProveedor"
        Me.GpProveedor.Size = New System.Drawing.Size(341, 88)
        '
        '
        '
        Me.GpProveedor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpProveedor.Style.BackColorGradientAngle = 90
        Me.GpProveedor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpProveedor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpProveedor.Style.BorderBottomWidth = 1
        Me.GpProveedor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpProveedor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpProveedor.Style.BorderLeftWidth = 1
        Me.GpProveedor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpProveedor.Style.BorderRightWidth = 1
        Me.GpProveedor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpProveedor.Style.BorderTopWidth = 1
        Me.GpProveedor.Style.CornerDiameter = 4
        Me.GpProveedor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpProveedor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpProveedor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpProveedor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpProveedor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpProveedor.TabIndex = 0
        Me.GpProveedor.Text = "Proveedor"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 2)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(100, 23)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Elija un Proveedor:"
        '
        'CbProveedor
        '
        CbProveedor_DesignTimeLayout.LayoutString = resources.GetString("CbProveedor_DesignTimeLayout.LayoutString")
        Me.CbProveedor.DesignTimeLayout = CbProveedor_DesignTimeLayout
        Me.CbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProveedor.Location = New System.Drawing.Point(3, 31)
        Me.CbProveedor.Name = "CbProveedor"
        Me.CbProveedor.SelectedIndex = -1
        Me.CbProveedor.SelectedItem = Nothing
        Me.CbProveedor.Size = New System.Drawing.Size(329, 23)
        Me.CbProveedor.TabIndex = 2
        '
        'PR_CuentasPagar_PagosProximos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "PR_CuentasPagar_PagosProximos"
        Me.Text = "CUENTAS POR PAGAR - REPORTE DE PAGOS PROXIMOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.DtiHasta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpProveedor.ResumeLayout(False)
        Me.GpProveedor.PerformLayout()
        CType(Me.CbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cr1Reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DtiHasta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GpProveedor As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bt1Generar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bt2Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents SbTodosUno As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CbProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
