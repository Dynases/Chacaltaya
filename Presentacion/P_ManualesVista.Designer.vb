<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_ManualesVista
    Inherits Modelos.ModeloF0

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ManualesVista))
        Me.RlAccion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.Gp3Privilegios = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.TbManual = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx7 = New DevComponents.DotNetBar.PanelEx()
        Me.Gp3PDF = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Pdf1Manual = New AxAcroPDFLib.AxAcroPDF()
        Me.CmBlock = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpcionDeshabilitadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.BtAbajo = New DevComponents.DotNetBar.ButtonX()
        Me.BtArriba = New DevComponents.DotNetBar.ButtonX()
        Me.BtZoomMenos = New DevComponents.DotNetBar.ButtonX()
        Me.BtZoomMas = New DevComponents.DotNetBar.ButtonX()
        Me.BtPagSiguiente = New DevComponents.DotNetBar.ButtonX()
        Me.BtPagAnterior = New DevComponents.DotNetBar.ButtonX()
        Me.OfdPDF = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        Me.Gp3Privilegios.SuspendLayout()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx7.SuspendLayout()
        Me.Gp3PDF.SuspendLayout()
        CType(Me.Pdf1Manual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmBlock.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuperTabControl1
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabControl1.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabControl1.ControlBox.MenuBox.Name = ""
        Me.SuperTabControl1.ControlBox.Name = ""
        Me.SuperTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabControl1.ControlBox.MenuBox, Me.SuperTabControl1.ControlBox.CloseBox})
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(984, 661)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(984, 636)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx7)
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx6)
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(984, 636)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx6, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx7, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.RlAccion)
        Me.PanelEx1.Size = New System.Drawing.Size(984, 64)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar1, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar2, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.RlAccion, 0)
        '
        'BubbleBar1
        '
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
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BBtn_Grabar
        '
        Me.BBtn_Grabar.Enabled = False
        '
        'BBtn_Cancelar
        '
        Me.BBtn_Cancelar.TooltipText = "SALIR"
        '
        'BubbleBar2
        '
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
        Me.BubbleBar2.Location = New System.Drawing.Point(920, 0)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Location = New System.Drawing.Point(0, 600)
        Me.PanelEx2.Size = New System.Drawing.Size(984, 36)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.Controls.SetChildIndex(Me.BubbleBar3, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.PanelEx5, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.BubbleBar4, 0)
        Me.PanelEx2.Controls.SetChildIndex(Me.Txt_Paginacion, 0)
        '
        'PanelEx3
        '
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.None
        Me.PanelEx3.Size = New System.Drawing.Size(50, 200)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        '
        'PanelEx4
        '
        Me.PanelEx4.Dock = System.Windows.Forms.DockStyle.None
        Me.PanelEx4.Size = New System.Drawing.Size(50, 236)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        '
        'BubbleBar4
        '
        '
        '
        '
        Me.BubbleBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar4.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar4.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar4.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar4.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar4.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar4.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar4.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BubbleBar3
        '
        '
        '
        '
        Me.BubbleBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar3.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar3.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar3.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar3.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar3.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar3.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar3.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'BubbleBar5
        '
        '
        '
        '
        Me.BubbleBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar5.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar5.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar5.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar5.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar5.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar5.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar5.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx5
        '
        Me.PanelEx5.Location = New System.Drawing.Point(784, 0)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        '
        'Txt_NombreUsu
        '
        Me.Txt_NombreUsu.Text = "DEFAULT"
        '
        'RlAccion
        '
        '
        '
        '
        Me.RlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RlAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RlAccion.ForeColor = System.Drawing.Color.White
        Me.RlAccion.Location = New System.Drawing.Point(287, 2)
        Me.RlAccion.Name = "RlAccion"
        Me.RlAccion.Size = New System.Drawing.Size(200, 60)
        Me.RlAccion.TabIndex = 9
        Me.RlAccion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.Gp3Privilegios)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx6.Location = New System.Drawing.Point(0, 64)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(320, 536)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 16
        '
        'Gp3Privilegios
        '
        Me.Gp3Privilegios.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp3Privilegios.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp3Privilegios.Controls.Add(Me.Dgj1Busqueda)
        Me.Gp3Privilegios.Controls.Add(Me.TbManual)
        Me.Gp3Privilegios.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp3Privilegios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp3Privilegios.Location = New System.Drawing.Point(0, 0)
        Me.Gp3Privilegios.Name = "Gp3Privilegios"
        Me.Gp3Privilegios.Padding = New System.Windows.Forms.Padding(5)
        Me.Gp3Privilegios.Size = New System.Drawing.Size(320, 536)
        '
        '
        '
        Me.Gp3Privilegios.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp3Privilegios.Style.BackColorGradientAngle = 90
        Me.Gp3Privilegios.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp3Privilegios.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Privilegios.Style.BorderBottomWidth = 1
        Me.Gp3Privilegios.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp3Privilegios.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Privilegios.Style.BorderLeftWidth = 1
        Me.Gp3Privilegios.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Privilegios.Style.BorderRightWidth = 1
        Me.Gp3Privilegios.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3Privilegios.Style.BorderTopWidth = 1
        Me.Gp3Privilegios.Style.CornerDiameter = 4
        Me.Gp3Privilegios.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp3Privilegios.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp3Privilegios.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp3Privilegios.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp3Privilegios.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp3Privilegios.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp3Privilegios.TabIndex = 1
        Me.Gp3Privilegios.Text = "Asignación de Visualización"
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(5, 81)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(304, 429)
        Me.Dgj1Busqueda.TabIndex = 1
        '
        'TbManual
        '
        Me.TbManual.BackColor = System.Drawing.Color.MistyRose
        '
        '
        '
        Me.TbManual.Border.Class = "TextBoxBorder"
        Me.TbManual.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbManual.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbManual.Location = New System.Drawing.Point(5, 5)
        Me.TbManual.Multiline = True
        Me.TbManual.Name = "TbManual"
        Me.TbManual.PreventEnterBeep = True
        Me.TbManual.Size = New System.Drawing.Size(304, 76)
        Me.TbManual.TabIndex = 2
        '
        'PanelEx7
        '
        Me.PanelEx7.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx7.Controls.Add(Me.Gp3PDF)
        Me.PanelEx7.Controls.Add(Me.GroupPanel1)
        Me.PanelEx7.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx7.Location = New System.Drawing.Point(320, 64)
        Me.PanelEx7.Name = "PanelEx7"
        Me.PanelEx7.Size = New System.Drawing.Size(664, 536)
        Me.PanelEx7.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx7.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx7.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx7.Style.GradientAngle = 90
        Me.PanelEx7.TabIndex = 20
        '
        'Gp3PDF
        '
        Me.Gp3PDF.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp3PDF.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp3PDF.Controls.Add(Me.Pdf1Manual)
        Me.Gp3PDF.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp3PDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp3PDF.Location = New System.Drawing.Point(76, 0)
        Me.Gp3PDF.Name = "Gp3PDF"
        Me.Gp3PDF.Padding = New System.Windows.Forms.Padding(5)
        Me.Gp3PDF.Size = New System.Drawing.Size(588, 536)
        '
        '
        '
        Me.Gp3PDF.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp3PDF.Style.BackColorGradientAngle = 90
        Me.Gp3PDF.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp3PDF.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3PDF.Style.BorderBottomWidth = 1
        Me.Gp3PDF.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp3PDF.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3PDF.Style.BorderLeftWidth = 1
        Me.Gp3PDF.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3PDF.Style.BorderRightWidth = 1
        Me.Gp3PDF.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp3PDF.Style.BorderTopWidth = 1
        Me.Gp3PDF.Style.CornerDiameter = 4
        Me.Gp3PDF.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp3PDF.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp3PDF.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp3PDF.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp3PDF.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp3PDF.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp3PDF.TabIndex = 2
        Me.Gp3PDF.Text = "Visualizador de Doc"
        '
        'Pdf1Manual
        '
        Me.Pdf1Manual.ContextMenuStrip = Me.CmBlock
        Me.Pdf1Manual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pdf1Manual.Enabled = True
        Me.Pdf1Manual.Location = New System.Drawing.Point(5, 5)
        Me.Pdf1Manual.Name = "Pdf1Manual"
        Me.Pdf1Manual.OcxState = CType(resources.GetObject("Pdf1Manual.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Pdf1Manual.Size = New System.Drawing.Size(572, 505)
        Me.Pdf1Manual.TabIndex = 0
        '
        'CmBlock
        '
        Me.CmBlock.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionDeshabilitadaToolStripMenuItem})
        Me.CmBlock.Name = "CmBlock"
        Me.CmBlock.Size = New System.Drawing.Size(188, 26)
        '
        'OpcionDeshabilitadaToolStripMenuItem
        '
        Me.OpcionDeshabilitadaToolStripMenuItem.Name = "OpcionDeshabilitadaToolStripMenuItem"
        Me.OpcionDeshabilitadaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.OpcionDeshabilitadaToolStripMenuItem.Text = "Opcion Deshabilitada"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.BtAbajo)
        Me.GroupPanel1.Controls.Add(Me.BtArriba)
        Me.GroupPanel1.Controls.Add(Me.BtZoomMenos)
        Me.GroupPanel1.Controls.Add(Me.BtZoomMas)
        Me.GroupPanel1.Controls.Add(Me.BtPagSiguiente)
        Me.GroupPanel1.Controls.Add(Me.BtPagAnterior)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(76, 536)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Controles"
        '
        'BtAbajo
        '
        Me.BtAbajo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtAbajo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtAbajo.Image = Global.Presentacion.My.Resources.Resources.BT_ABAJO
        Me.BtAbajo.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtAbajo.Location = New System.Drawing.Point(5, 201)
        Me.BtAbajo.Name = "BtAbajo"
        Me.BtAbajo.Size = New System.Drawing.Size(60, 60)
        Me.BtAbajo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtAbajo.TabIndex = 5
        Me.BtAbajo.Tooltip = "Bajar"
        '
        'BtArriba
        '
        Me.BtArriba.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtArriba.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtArriba.Image = Global.Presentacion.My.Resources.Resources.BT_ARRIBA
        Me.BtArriba.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtArriba.Location = New System.Drawing.Point(5, 135)
        Me.BtArriba.Name = "BtArriba"
        Me.BtArriba.Size = New System.Drawing.Size(60, 60)
        Me.BtArriba.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtArriba.TabIndex = 4
        Me.BtArriba.Tooltip = "Subir"
        '
        'BtZoomMenos
        '
        Me.BtZoomMenos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtZoomMenos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtZoomMenos.Image = Global.Presentacion.My.Resources.Resources.BT_ZOOM_MENOS
        Me.BtZoomMenos.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtZoomMenos.Location = New System.Drawing.Point(5, 333)
        Me.BtZoomMenos.Name = "BtZoomMenos"
        Me.BtZoomMenos.Size = New System.Drawing.Size(60, 60)
        Me.BtZoomMenos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtZoomMenos.TabIndex = 3
        Me.BtZoomMenos.Tooltip = "Disminuir Zoom"
        '
        'BtZoomMas
        '
        Me.BtZoomMas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtZoomMas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtZoomMas.Image = Global.Presentacion.My.Resources.Resources.BT_ZOOM_MAS
        Me.BtZoomMas.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtZoomMas.Location = New System.Drawing.Point(5, 267)
        Me.BtZoomMas.Name = "BtZoomMas"
        Me.BtZoomMas.Size = New System.Drawing.Size(60, 60)
        Me.BtZoomMas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtZoomMas.TabIndex = 2
        Me.BtZoomMas.Tooltip = "Aumentar Zoom"
        '
        'BtPagSiguiente
        '
        Me.BtPagSiguiente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtPagSiguiente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtPagSiguiente.Image = Global.Presentacion.My.Resources.Resources.BT_SIGUIENTE
        Me.BtPagSiguiente.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtPagSiguiente.Location = New System.Drawing.Point(5, 69)
        Me.BtPagSiguiente.Name = "BtPagSiguiente"
        Me.BtPagSiguiente.Size = New System.Drawing.Size(60, 60)
        Me.BtPagSiguiente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtPagSiguiente.TabIndex = 1
        Me.BtPagSiguiente.Tooltip = "Pagina Siguiente"
        '
        'BtPagAnterior
        '
        Me.BtPagAnterior.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtPagAnterior.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtPagAnterior.Image = Global.Presentacion.My.Resources.Resources.BT_ANTERIOR
        Me.BtPagAnterior.ImageFixedSize = New System.Drawing.Size(60, 60)
        Me.BtPagAnterior.Location = New System.Drawing.Point(5, 3)
        Me.BtPagAnterior.Name = "BtPagAnterior"
        Me.BtPagAnterior.Size = New System.Drawing.Size(60, 60)
        Me.BtPagAnterior.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtPagAnterior.TabIndex = 0
        Me.BtPagAnterior.Tooltip = "Pagina Anterior"
        '
        'OfdPDF
        '
        Me.OfdPDF.FileName = "OpenFileDialog1"
        '
        'P_ManualesVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Name = "P_ManualesVista"
        Me.Text = "P_Manuales"
        Me.Controls.SetChildIndex(Me.SuperTabControl1, 0)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        Me.PanelEx6.ResumeLayout(False)
        Me.Gp3Privilegios.ResumeLayout(False)
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx7.ResumeLayout(False)
        Me.Gp3PDF.ResumeLayout(False)
        CType(Me.Pdf1Manual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmBlock.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RlAccion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents PanelEx7 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Gp3PDF As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Pdf1Manual As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Gp3Privilegios As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents OfdPDF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmBlock As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpcionDeshabilitadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents BtZoomMenos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtZoomMas As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtPagSiguiente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtPagAnterior As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtAbajo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtArriba As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents TbManual As DevComponents.DotNetBar.Controls.TextBoxX
End Class
