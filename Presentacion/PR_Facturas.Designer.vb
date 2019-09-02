<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_Facturas
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
        Me.GroupPanelFiltro = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BubbleBar2 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab2 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.btExportarExcel = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.GroupPanelFecha = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Dtp_FechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_FechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupPanelRango = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbiFacturaInicial = New DevComponents.Editors.IntegerInput()
        Me.tbiFacturaFinal = New DevComponents.Editors.IntegerInput()
        Me.sbFiltrar = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.GroupPanelFiltro.SuspendLayout()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelFecha.SuspendLayout()
        Me.GroupPanelRango.SuspendLayout()
        CType(Me.tbiFacturaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbiFacturaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupPanelFiltro
        '
        Me.GroupPanelFiltro.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFiltro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelFiltro.Controls.Add(Me.GroupPanelRango)
        Me.GroupPanelFiltro.Controls.Add(Me.BubbleBar2)
        Me.GroupPanelFiltro.Controls.Add(Me.BubbleBar1)
        Me.GroupPanelFiltro.Controls.Add(Me.GroupPanelFecha)
        Me.GroupPanelFiltro.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelFiltro.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanelFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelFiltro.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelFiltro.Name = "GroupPanelFiltro"
        Me.GroupPanelFiltro.Size = New System.Drawing.Size(300, 567)
        '
        '
        '
        Me.GroupPanelFiltro.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelFiltro.Style.BackColorGradientAngle = 90
        Me.GroupPanelFiltro.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelFiltro.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFiltro.Style.BorderBottomWidth = 1
        Me.GroupPanelFiltro.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelFiltro.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFiltro.Style.BorderLeftWidth = 1
        Me.GroupPanelFiltro.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFiltro.Style.BorderRightWidth = 1
        Me.GroupPanelFiltro.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFiltro.Style.BorderTopWidth = 1
        Me.GroupPanelFiltro.Style.CornerDiameter = 4
        Me.GroupPanelFiltro.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelFiltro.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelFiltro.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelFiltro.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelFiltro.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelFiltro.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelFiltro.TabIndex = 3
        Me.GroupPanelFiltro.Text = "FILTROS"
        '
        'BubbleBar2
        '
        Me.BubbleBar2.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar2.AntiAlias = True
        Me.BubbleBar2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.BubbleBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar2.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar2.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar2.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar2.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar2.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar2.ImageSizeLarge = New System.Drawing.Size(72, 72)
        Me.BubbleBar2.ImageSizeNormal = New System.Drawing.Size(64, 64)
        Me.BubbleBar2.Location = New System.Drawing.Point(0, 195)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.Name = "BubbleBar2"
        Me.BubbleBar2.SelectedTab = Me.BubbleBarTab2
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar2.Size = New System.Drawing.Size(89, 80)
        Me.BubbleBar2.TabIndex = 10
        Me.BubbleBar2.Tabs.Add(Me.BubbleBarTab2)
        Me.BubbleBar2.TabsVisible = False
        Me.BubbleBar2.Text = "BubbleBar2"
        '
        'BubbleBarTab2
        '
        Me.BubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab2.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.btExportarExcel})
        Me.BubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab2.Name = "BubbleBarTab2"
        Me.BubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab2.Text = "BubbleBarTab1"
        Me.BubbleBarTab2.TextColor = System.Drawing.Color.Black
        '
        'btExportarExcel
        '
        Me.btExportarExcel.Image = Global.Presentacion.My.Resources.Resources.EXCEL
        Me.btExportarExcel.ImageLarge = Global.Presentacion.My.Resources.Resources.EXCEL
        Me.btExportarExcel.Name = "btExportarExcel"
        Me.btExportarExcel.TooltipText = "GENERAR"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(113, 195)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(158, 80)
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
        'GroupPanelFecha
        '
        Me.GroupPanelFecha.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanelFecha.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelFecha.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelFecha.Controls.Add(Me.Label3)
        Me.GroupPanelFecha.Controls.Add(Me.Dtp_FechaIni)
        Me.GroupPanelFecha.Controls.Add(Me.Dtp_FechaFin)
        Me.GroupPanelFecha.Controls.Add(Me.Label4)
        Me.GroupPanelFecha.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelFecha.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelFecha.Name = "GroupPanelFecha"
        Me.GroupPanelFecha.Size = New System.Drawing.Size(294, 81)
        '
        '
        '
        Me.GroupPanelFecha.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelFecha.Style.BackColorGradientAngle = 90
        Me.GroupPanelFecha.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelFecha.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFecha.Style.BorderBottomWidth = 1
        Me.GroupPanelFecha.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelFecha.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFecha.Style.BorderLeftWidth = 1
        Me.GroupPanelFecha.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFecha.Style.BorderRightWidth = 1
        Me.GroupPanelFecha.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelFecha.Style.BorderTopWidth = 1
        Me.GroupPanelFecha.Style.CornerDiameter = 4
        Me.GroupPanelFecha.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelFecha.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelFecha.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelFecha.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelFecha.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelFecha.TabIndex = 9
        Me.GroupPanelFecha.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESDE:"
        '
        'Dtp_FechaIni
        '
        Me.Dtp_FechaIni.Location = New System.Drawing.Point(56, 3)
        Me.Dtp_FechaIni.Name = "Dtp_FechaIni"
        Me.Dtp_FechaIni.Size = New System.Drawing.Size(229, 21)
        Me.Dtp_FechaIni.TabIndex = 0
        Me.Dtp_FechaIni.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'Dtp_FechaFin
        '
        Me.Dtp_FechaFin.Location = New System.Drawing.Point(56, 29)
        Me.Dtp_FechaFin.Name = "Dtp_FechaFin"
        Me.Dtp_FechaFin.Size = New System.Drawing.Size(229, 21)
        Me.Dtp_FechaFin.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HASTA:"
        '
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(300, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.Size = New System.Drawing.Size(446, 567)
        Me.Crv.TabIndex = 4
        '
        'GroupPanelRango
        '
        Me.GroupPanelRango.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanelRango.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelRango.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelRango.Controls.Add(Me.sbFiltrar)
        Me.GroupPanelRango.Controls.Add(Me.tbiFacturaFinal)
        Me.GroupPanelRango.Controls.Add(Me.tbiFacturaInicial)
        Me.GroupPanelRango.Controls.Add(Me.Label5)
        Me.GroupPanelRango.Controls.Add(Me.Label1)
        Me.GroupPanelRango.Controls.Add(Me.Label2)
        Me.GroupPanelRango.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelRango.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelRango.Location = New System.Drawing.Point(0, 81)
        Me.GroupPanelRango.Name = "GroupPanelRango"
        Me.GroupPanelRango.Size = New System.Drawing.Size(294, 108)
        '
        '
        '
        Me.GroupPanelRango.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelRango.Style.BackColorGradientAngle = 90
        Me.GroupPanelRango.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelRango.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRango.Style.BorderBottomWidth = 1
        Me.GroupPanelRango.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelRango.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRango.Style.BorderLeftWidth = 1
        Me.GroupPanelRango.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRango.Style.BorderRightWidth = 1
        Me.GroupPanelRango.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelRango.Style.BorderTopWidth = 1
        Me.GroupPanelRango.Style.CornerDiameter = 4
        Me.GroupPanelRango.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelRango.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelRango.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelRango.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelRango.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelRango.TabIndex = 11
        Me.GroupPanelRango.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NRO. FACTURA INICIAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "NRO. FACTURA FINAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FILTRAR RANGO DE FACTURA:"
        '
        'tbiFacturaInicial
        '
        '
        '
        '
        Me.tbiFacturaInicial.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbiFacturaInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbiFacturaInicial.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbiFacturaInicial.Location = New System.Drawing.Point(191, 31)
        Me.tbiFacturaInicial.MinValue = 0
        Me.tbiFacturaInicial.Name = "tbiFacturaInicial"
        Me.tbiFacturaInicial.Size = New System.Drawing.Size(94, 21)
        Me.tbiFacturaInicial.TabIndex = 5
        '
        'tbiFacturaFinal
        '
        '
        '
        '
        Me.tbiFacturaFinal.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbiFacturaFinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbiFacturaFinal.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbiFacturaFinal.Location = New System.Drawing.Point(191, 58)
        Me.tbiFacturaFinal.MinValue = 0
        Me.tbiFacturaFinal.Name = "tbiFacturaFinal"
        Me.tbiFacturaFinal.Size = New System.Drawing.Size(94, 21)
        Me.tbiFacturaFinal.TabIndex = 6
        '
        'sbFiltrar
        '
        '
        '
        '
        Me.sbFiltrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sbFiltrar.Location = New System.Drawing.Point(191, 3)
        Me.sbFiltrar.Name = "sbFiltrar"
        Me.sbFiltrar.OffText = "NO"
        Me.sbFiltrar.OnText = "SI"
        Me.sbFiltrar.Size = New System.Drawing.Size(94, 22)
        Me.sbFiltrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sbFiltrar.TabIndex = 7
        '
        'PR_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 567)
        Me.Controls.Add(Me.Crv)
        Me.Controls.Add(Me.GroupPanelFiltro)
        Me.Name = "PR_Facturas"
        Me.Text = "PR_Facturas"
        Me.GroupPanelFiltro.ResumeLayout(False)
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelFecha.ResumeLayout(False)
        Me.GroupPanelFecha.PerformLayout()
        Me.GroupPanelRango.ResumeLayout(False)
        Me.GroupPanelRango.PerformLayout()
        CType(Me.tbiFacturaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbiFacturaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelFiltro As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents GroupPanelFecha As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Dtp_FechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BubbleBar2 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab2 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents btExportarExcel As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents GroupPanelRango As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sbFiltrar As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents tbiFacturaFinal As DevComponents.Editors.IntegerInput
    Friend WithEvents tbiFacturaInicial As DevComponents.Editors.IntegerInput
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
