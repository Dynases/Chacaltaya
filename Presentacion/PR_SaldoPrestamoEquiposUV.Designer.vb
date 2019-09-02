<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_SaldoPrestamoEquiposUV
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DtiDesde = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GpDatos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TbDescripcion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BtBuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.CrReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Gp_Filtros.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpFecha.SuspendLayout()
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.GpFecha)
        Me.Gp_Filtros.Controls.Add(Me.GpDatos)
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
        Me.Gp_Filtros.Text = "Filtros"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 198)
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
        Me.GpFecha.Controls.Add(Me.LabelX1)
        Me.GpFecha.Controls.Add(Me.DtiDesde)
        Me.GpFecha.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpFecha.Location = New System.Drawing.Point(0, 135)
        Me.GpFecha.Name = "GpFecha"
        Me.GpFecha.Size = New System.Drawing.Size(300, 63)
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
        Me.GpFecha.Text = "Fecha máxima"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(6, 8)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(52, 23)
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Fecha:"
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
        Me.DtiDesde.Location = New System.Drawing.Point(64, 8)
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
        'GpDatos
        '
        Me.GpDatos.BackColor = System.Drawing.Color.Transparent
        Me.GpDatos.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpDatos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpDatos.Controls.Add(Me.TbDescripcion)
        Me.GpDatos.Controls.Add(Me.TbCodigo)
        Me.GpDatos.Controls.Add(Me.BtBuscarCliente)
        Me.GpDatos.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDatos.Location = New System.Drawing.Point(0, 0)
        Me.GpDatos.Name = "GpDatos"
        Me.GpDatos.Size = New System.Drawing.Size(300, 135)
        '
        '
        '
        Me.GpDatos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpDatos.Style.BackColorGradientAngle = 90
        Me.GpDatos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpDatos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatos.Style.BorderBottomWidth = 1
        Me.GpDatos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpDatos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatos.Style.BorderLeftWidth = 1
        Me.GpDatos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatos.Style.BorderRightWidth = 1
        Me.GpDatos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpDatos.Style.BorderTopWidth = 1
        Me.GpDatos.Style.CornerDiameter = 4
        Me.GpDatos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpDatos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpDatos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpDatos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpDatos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpDatos.TabIndex = 14
        Me.GpDatos.Text = "Zona"
        '
        'TbDescripcion
        '
        '
        '
        '
        Me.TbDescripcion.Border.Class = "TextBoxBorder"
        Me.TbDescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbDescripcion.Location = New System.Drawing.Point(6, 41)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.PreventEnterBeep = True
        Me.TbDescripcion.Size = New System.Drawing.Size(285, 66)
        Me.TbDescripcion.TabIndex = 11
        '
        'TbCodigo
        '
        '
        '
        '
        Me.TbCodigo.Border.Class = "TextBoxBorder"
        Me.TbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbCodigo.Location = New System.Drawing.Point(6, 12)
        Me.TbCodigo.Name = "TbCodigo"
        Me.TbCodigo.PreventEnterBeep = True
        Me.TbCodigo.Size = New System.Drawing.Size(62, 23)
        Me.TbCodigo.TabIndex = 10
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
        'PR_SaldoPrestamoEquiposUV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 558)
        Me.Controls.Add(Me.CrReporte)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_SaldoPrestamoEquiposUV"
        Me.Text = "PR_SaldoPrestamoEquiposUV"
        Me.Gp_Filtros.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpFecha.ResumeLayout(False)
        CType(Me.DtiDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CrReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GpDatos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TbDescripcion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BtBuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GpFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiDesde As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
