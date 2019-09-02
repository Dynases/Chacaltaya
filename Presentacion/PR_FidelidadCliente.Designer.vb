<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_FidelidadCliente
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
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Cr1Reporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Cb4Criterio = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Cb1Producto = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Tb1Codigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Cb3Hasta = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Cb2Desde = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bt1Generar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt2Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cr1Reporte.Location = New System.Drawing.Point(250, 0)
        Me.Cr1Reporte.Name = "Cr1Reporte"
        Me.Cr1Reporte.Size = New System.Drawing.Size(634, 661)
        Me.Cr1Reporte.TabIndex = 0
        Me.Cr1Reporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.BubbleBar1)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel5)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel3)
        Me.GroupPanel1.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(250, 661)
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
        Me.GroupPanel1.TabIndex = 2
        Me.GroupPanel1.Text = "Filtros"
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.Cb4Criterio)
        Me.GroupPanel5.Controls.Add(Me.LabelX5)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 206)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(244, 61)
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
        Me.GroupPanel5.TabIndex = 9
        Me.GroupPanel5.Text = "Ordenado Por"
        '
        'Cb4Criterio
        '
        Me.Cb4Criterio.DisplayMember = "Text"
        Me.Cb4Criterio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cb4Criterio.FormattingEnabled = True
        Me.Cb4Criterio.ItemHeight = 14
        Me.Cb4Criterio.Location = New System.Drawing.Point(47, 6)
        Me.Cb4Criterio.Name = "Cb4Criterio"
        Me.Cb4Criterio.Size = New System.Drawing.Size(121, 20)
        Me.Cb4Criterio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cb4Criterio.TabIndex = 2
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Criterio:"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Cb1Producto)
        Me.GroupPanel3.Controls.Add(Me.Tb1Codigo)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(-1, 6)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(244, 83)
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
        Me.GroupPanel3.TabIndex = 8
        Me.GroupPanel3.Text = "Tipo Producto"
        '
        'Cb1Producto
        '
        Me.Cb1Producto.DisplayMember = "Text"
        Me.Cb1Producto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cb1Producto.FormattingEnabled = True
        Me.Cb1Producto.ItemHeight = 14
        Me.Cb1Producto.Location = New System.Drawing.Point(59, 32)
        Me.Cb1Producto.Name = "Cb1Producto"
        Me.Cb1Producto.Size = New System.Drawing.Size(176, 20)
        Me.Cb1Producto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cb1Producto.TabIndex = 2
        '
        'Tb1Codigo
        '
        '
        '
        '
        Me.Tb1Codigo.Border.Class = "TextBoxBorder"
        Me.Tb1Codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb1Codigo.Location = New System.Drawing.Point(3, 32)
        Me.Tb1Codigo.Name = "Tb1Codigo"
        Me.Tb1Codigo.PreventEnterBeep = True
        Me.Tb1Codigo.ReadOnly = True
        Me.Tb1Codigo.Size = New System.Drawing.Size(50, 20)
        Me.Tb1Codigo.TabIndex = 1
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
        Me.LabelX1.Text = "Tipo de Producto:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Cb3Hasta)
        Me.GroupPanel4.Controls.Add(Me.Cb2Desde)
        Me.GroupPanel4.Controls.Add(Me.LabelX3)
        Me.GroupPanel4.Controls.Add(Me.LabelX2)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 102)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(244, 91)
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
        Me.GroupPanel4.TabIndex = 5
        Me.GroupPanel4.Text = "Fechas"
        '
        'Cb3Hasta
        '
        Me.Cb3Hasta.DisplayMember = "Text"
        Me.Cb3Hasta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cb3Hasta.FormattingEnabled = True
        Me.Cb3Hasta.ItemHeight = 14
        Me.Cb3Hasta.Location = New System.Drawing.Point(47, 35)
        Me.Cb3Hasta.Name = "Cb3Hasta"
        Me.Cb3Hasta.Size = New System.Drawing.Size(121, 20)
        Me.Cb3Hasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cb3Hasta.TabIndex = 3
        '
        'Cb2Desde
        '
        Me.Cb2Desde.DisplayMember = "Text"
        Me.Cb2Desde.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cb2Desde.FormattingEnabled = True
        Me.Cb2Desde.ItemHeight = 14
        Me.Cb2Desde.Location = New System.Drawing.Point(47, 6)
        Me.Cb2Desde.Name = "Cb2Desde"
        Me.Cb2Desde.Size = New System.Drawing.Size(121, 20)
        Me.Cb2Desde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Cb2Desde.TabIndex = 2
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(3, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 1
        Me.LabelX3.Text = "Hasta:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Desde:"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(22, 291)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(197, 80)
        Me.BubbleBar1.TabIndex = 10
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
        'PR_FidelidadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "PR_FidelidadCliente"
        Me.Text = "REPORTE DE FIDELIDAD DE CLIENTES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cr1Reporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cb3Hasta As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Cb2Desde As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cb1Producto As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Tb1Codigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Cb4Criterio As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bt1Generar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bt2Cancelar As DevComponents.DotNetBar.BubbleButton
End Class
