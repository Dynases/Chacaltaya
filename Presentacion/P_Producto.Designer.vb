<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Producto
    Inherits Modelos.ModeloHor

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Sb_Stock = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Txt_Codigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txt_Nombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txt_NombreCorto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Hl_Producto = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Cbx_Categoria = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Ptb_Imagen = New System.Windows.Forms.PictureBox()
        Me.Btnx_BuscarImagen = New DevComponents.DotNetBar.ButtonX()
        Me.Sb_Estado = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.SbEsEquipo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Ofd_Producto = New System.Windows.Forms.OpenFileDialog()
        Me.Ti_Productos = New System.Windows.Forms.Timer(Me.components)
        Me._Bs_Productos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lbl_NombreImagen = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Dgs_Productos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GridColumn1 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn2 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn3 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn4 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn5 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn6 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn7 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn8 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn9 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn10 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn11 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn12 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn13 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn14 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GridColumn15 = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DtiFechaIngreso = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlyoutUsuario = New DevComponents.DotNetBar.Controls.Flyout(Me.components)
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        CType(Me.Ptb_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Bs_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DtiFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
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
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1179, 662)
        '
        'SuperTabItem2
        '
        Me.SuperTabItem2.Visible = False
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1179, 662)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
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
        Me.BubbleBar1.TabIndex = 0
        '
        'BBtn_Modificar
        '
        '
        'BBtn_Eliminar
        '
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
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Location = New System.Drawing.Point(0, 618)
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
        Me.PanelEx3.Controls.Add(Me.PanelUsuario)
        Me.PanelEx3.Controls.Add(Me.GroupPanel1)
        Me.Hl_Producto.SetHighlightOnFocus(Me.PanelEx3, True)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PanelEx3.Size = New System.Drawing.Size(1179, 279)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 0
        '
        'PanelEx4
        '
        Me.PanelEx4.Controls.Add(Me.GroupPanel2)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 358)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PanelEx4.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.PanelEx4.Size = New System.Drawing.Size(1179, 260)
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
        'BBtn_Usuario
        '
        '
        'PanelEx5
        '
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
        'BBtn_Nuevo
        '
        '
        'BBtn_Siguiente
        '
        '
        'BBtn_Ultimo
        '
        '
        'BBtn_Inicio
        '
        '
        'BBtn_Anterior
        '
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 0)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(133, 28)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Código:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 43)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(133, 28)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "Nombre:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 75)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(133, 28)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "Nombre Corto:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(4, 107)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(133, 28)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "Categoria:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(4, 142)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(133, 28)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Stock:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Sb_Stock
        '
        '
        '
        '
        Me.Sb_Stock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.Sb_Stock, True)
        Me.Sb_Stock.Location = New System.Drawing.Point(145, 143)
        Me.Sb_Stock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sb_Stock.Name = "Sb_Stock"
        Me.Sb_Stock.OffText = "NO"
        Me.Sb_Stock.OffTextColor = System.Drawing.Color.Red
        Me.Sb_Stock.OnText = "SI"
        Me.Sb_Stock.OnTextColor = System.Drawing.Color.Green
        Me.Sb_Stock.Size = New System.Drawing.Size(175, 27)
        Me.Sb_Stock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sb_Stock.TabIndex = 4
        Me.Sb_Stock.ValueFalse = "0"
        Me.Sb_Stock.ValueTrue = "1"
        '
        'Txt_Codigo
        '
        '
        '
        '
        Me.Txt_Codigo.Border.Class = "TextBoxBorder"
        Me.Txt_Codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.Txt_Codigo, True)
        Me.Txt_Codigo.Location = New System.Drawing.Point(145, 4)
        Me.Txt_Codigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.PreventEnterBeep = True
        Me.Txt_Codigo.ReadOnly = True
        Me.Txt_Codigo.Size = New System.Drawing.Size(175, 22)
        Me.Txt_Codigo.TabIndex = 0
        Me.Txt_Codigo.WatermarkText = "EJ. 1"
        '
        'Txt_Nombre
        '
        '
        '
        '
        Me.Txt_Nombre.Border.Class = "TextBoxBorder"
        Me.Txt_Nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.Txt_Nombre, True)
        Me.Txt_Nombre.Location = New System.Drawing.Point(145, 43)
        Me.Txt_Nombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Nombre.MaxLength = 30
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.PreventEnterBeep = True
        Me.Txt_Nombre.Size = New System.Drawing.Size(375, 22)
        Me.Txt_Nombre.TabIndex = 1
        Me.Txt_Nombre.WatermarkText = "EJ. AGUA DE 20 LITROS"
        '
        'Txt_NombreCorto
        '
        '
        '
        '
        Me.Txt_NombreCorto.Border.Class = "TextBoxBorder"
        Me.Txt_NombreCorto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.Txt_NombreCorto, True)
        Me.Txt_NombreCorto.Location = New System.Drawing.Point(145, 79)
        Me.Txt_NombreCorto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_NombreCorto.MaxLength = 15
        Me.Txt_NombreCorto.Name = "Txt_NombreCorto"
        Me.Txt_NombreCorto.PreventEnterBeep = True
        Me.Txt_NombreCorto.Size = New System.Drawing.Size(375, 22)
        Me.Txt_NombreCorto.TabIndex = 2
        Me.Txt_NombreCorto.WatermarkText = "EJ. AGUA 20L"
        '
        'Hl_Producto
        '
        Me.Hl_Producto.ContainerControl = Me
        '
        'Cbx_Categoria
        '
        Me.Cbx_Categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Cbx_Categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Cbx_Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Cbx_Categoria.FormattingEnabled = True
        Me.Hl_Producto.SetHighlightOnFocus(Me.Cbx_Categoria, True)
        Me.Cbx_Categoria.ItemHeight = 14
        Me.Cbx_Categoria.Location = New System.Drawing.Point(145, 111)
        Me.Cbx_Categoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cbx_Categoria.Name = "Cbx_Categoria"
        Me.Cbx_Categoria.Size = New System.Drawing.Size(373, 20)
        Me.Cbx_Categoria.TabIndex = 3
        '
        'Ptb_Imagen
        '
        Me.Ptb_Imagen.BackColor = System.Drawing.Color.Transparent
        Me.Ptb_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Hl_Producto.SetHighlightOnFocus(Me.Ptb_Imagen, True)
        Me.Ptb_Imagen.Image = Global.Presentacion.My.Resources.Resources._DEFAULT
        Me.Ptb_Imagen.Location = New System.Drawing.Point(663, 4)
        Me.Ptb_Imagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Ptb_Imagen.Name = "Ptb_Imagen"
        Me.Ptb_Imagen.Size = New System.Drawing.Size(159, 147)
        Me.Ptb_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ptb_Imagen.TabIndex = 11
        Me.Ptb_Imagen.TabStop = False
        '
        'Btnx_BuscarImagen
        '
        Me.Btnx_BuscarImagen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btnx_BuscarImagen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Hl_Producto.SetHighlightOnFocus(Me.Btnx_BuscarImagen, True)
        Me.Btnx_BuscarImagen.Location = New System.Drawing.Point(663, 185)
        Me.Btnx_BuscarImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnx_BuscarImagen.Name = "Btnx_BuscarImagen"
        Me.Btnx_BuscarImagen.Size = New System.Drawing.Size(160, 37)
        Me.Btnx_BuscarImagen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btnx_BuscarImagen.TabIndex = 6
        Me.Btnx_BuscarImagen.Text = "CARGAR IMAGEN"
        '
        'Sb_Estado
        '
        '
        '
        '
        Me.Sb_Estado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.Sb_Estado, True)
        Me.Sb_Estado.Location = New System.Drawing.Point(145, 177)
        Me.Sb_Estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sb_Estado.Name = "Sb_Estado"
        Me.Sb_Estado.OffText = "INACTIVO"
        Me.Sb_Estado.OffTextColor = System.Drawing.Color.Red
        Me.Sb_Estado.OnText = "ACTIVO"
        Me.Sb_Estado.OnTextColor = System.Drawing.Color.Green
        Me.Sb_Estado.Size = New System.Drawing.Size(175, 27)
        Me.Sb_Estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Sb_Estado.TabIndex = 5
        Me.Sb_Estado.ValueFalse = "0"
        Me.Sb_Estado.ValueTrue = "1"
        '
        'SbEsEquipo
        '
        '
        '
        '
        Me.SbEsEquipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Hl_Producto.SetHighlightOnFocus(Me.SbEsEquipo, True)
        Me.SbEsEquipo.Location = New System.Drawing.Point(145, 212)
        Me.SbEsEquipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbEsEquipo.Name = "SbEsEquipo"
        Me.SbEsEquipo.OffText = "NO"
        Me.SbEsEquipo.OffTextColor = System.Drawing.Color.Red
        Me.SbEsEquipo.OnText = "SI"
        Me.SbEsEquipo.OnTextColor = System.Drawing.Color.Green
        Me.SbEsEquipo.Size = New System.Drawing.Size(175, 27)
        Me.SbEsEquipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SbEsEquipo.TabIndex = 15
        Me.SbEsEquipo.ValueFalse = "0"
        Me.SbEsEquipo.ValueTrue = "1"
        '
        'Ofd_Producto
        '
        Me.Ofd_Producto.Title = "CARGAR IMAGEN DE PRODUCTO"
        '
        'Ti_Productos
        '
        Me.Ti_Productos.Interval = 1000
        '
        'Lbl_NombreImagen
        '
        '
        '
        '
        Me.Lbl_NombreImagen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_NombreImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreImagen.ForeColor = System.Drawing.Color.Black
        Me.Lbl_NombreImagen.Location = New System.Drawing.Point(663, 146)
        Me.Lbl_NombreImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Lbl_NombreImagen.Name = "Lbl_NombreImagen"
        Me.Lbl_NombreImagen.Size = New System.Drawing.Size(160, 28)
        Me.Lbl_NombreImagen.TabIndex = 14
        Me.Lbl_NombreImagen.Text = "IMG0.JPG"
        Me.Lbl_NombreImagen.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(4, 176)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(133, 28)
        Me.LabelX6.TabIndex = 12
        Me.LabelX6.Text = "Estado:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Dgs_Productos
        '
        Me.Dgs_Productos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgs_Productos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Dgs_Productos.Location = New System.Drawing.Point(7, 6)
        Me.Dgs_Productos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dgs_Productos.Name = "Dgs_Productos"
        '
        '
        '
        Me.Dgs_Productos.PrimaryGrid.AllowEdit = False
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn1)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn2)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn3)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn4)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn5)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn6)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn7)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn8)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn9)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn10)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn11)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn12)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn13)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn14)
        Me.Dgs_Productos.PrimaryGrid.Columns.Add(Me.GridColumn15)
        Me.Dgs_Productos.PrimaryGrid.EnableColumnFiltering = True
        Me.Dgs_Productos.PrimaryGrid.EnableFiltering = True
        Me.Dgs_Productos.PrimaryGrid.EnableRowFiltering = True
        '
        '
        '
        Me.Dgs_Productos.PrimaryGrid.Filter.ShowPanelFilterExpr = True
        Me.Dgs_Productos.PrimaryGrid.Filter.Visible = True
        Me.Dgs_Productos.PrimaryGrid.FilterMatchType = DevComponents.DotNetBar.SuperGrid.FilterMatchType.RegularExpressions
        Me.Dgs_Productos.PrimaryGrid.MultiSelect = False
        Me.Dgs_Productos.PrimaryGrid.RowHeaderIndexOffset = 1
        Me.Dgs_Productos.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.RowWithCellHighlight
        Me.Dgs_Productos.PrimaryGrid.ShowRowGridIndex = True
        Me.Dgs_Productos.PrimaryGrid.UseAlternateRowStyle = True
        Me.Dgs_Productos.Size = New System.Drawing.Size(1145, 213)
        Me.Dgs_Productos.TabIndex = 1
        Me.Dgs_Productos.Text = "SuperGridControl1"
        '
        'GridColumn1
        '
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DtiFechaIngreso)
        Me.GroupPanel1.Controls.Add(Me.SbEsEquipo)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.Ptb_Imagen)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.Sb_Estado)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.Lbl_NombreImagen)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.Sb_Stock)
        Me.GroupPanel1.Controls.Add(Me.Btnx_BuscarImagen)
        Me.GroupPanel1.Controls.Add(Me.Txt_Codigo)
        Me.GroupPanel1.Controls.Add(Me.Cbx_Categoria)
        Me.GroupPanel1.Controls.Add(Me.Txt_Nombre)
        Me.GroupPanel1.Controls.Add(Me.Txt_NombreCorto)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(843, 279)
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
        Me.GroupPanel1.TabIndex = 15
        Me.GroupPanel1.Text = "Datos de Producto"
        '
        'DtiFechaIngreso
        '
        '
        '
        '
        Me.DtiFechaIngreso.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtiFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIngreso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtiFechaIngreso.ButtonDropDown.Visible = True
        Me.DtiFechaIngreso.IsPopupCalendarOpen = False
        Me.DtiFechaIngreso.Location = New System.Drawing.Point(328, 210)
        Me.DtiFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        '
        '
        '
        '
        '
        Me.DtiFechaIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIngreso.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtiFechaIngreso.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtiFechaIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIngreso.MonthCalendar.DisplayMonth = New Date(2017, 6, 1, 0, 0, 0, 0)
        Me.DtiFechaIngreso.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtiFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtiFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtiFechaIngreso.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtiFechaIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtiFechaIngreso.MonthCalendar.TodayButtonVisible = True
        Me.DtiFechaIngreso.Name = "DtiFechaIngreso"
        Me.DtiFechaIngreso.Size = New System.Drawing.Size(133, 22)
        Me.DtiFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtiFechaIngreso.TabIndex = 17
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(4, 210)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(133, 28)
        Me.LabelX7.TabIndex = 16
        Me.LabelX7.Text = "Es Equipo?:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Dgs_Productos)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(7, 6)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GroupPanel2.Size = New System.Drawing.Size(1165, 248)
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
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
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
        Me.GroupPanel2.TabIndex = 2
        Me.GroupPanel2.Text = "Tabla de Datos"
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.Label3)
        Me.PanelUsuario.Controls.Add(Me.Label2)
        Me.PanelUsuario.Controls.Add(Me.Label1)
        Me.PanelUsuario.Location = New System.Drawing.Point(912, 65)
        Me.PanelUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(293, 123)
        Me.PanelUsuario.TabIndex = 7
        Me.PanelUsuario.TabStop = True
        Me.PanelUsuario.Visible = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(153, 80)
        Me.lbHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(98, 24)
        Me.lbHora.TabIndex = 6
        Me.lbHora.Text = "USUARIO:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(153, 52)
        Me.lbFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(98, 24)
        Me.lbFecha.TabIndex = 5
        Me.lbFecha.Text = "USUARIO:"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(153, 23)
        Me.lbUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(98, 24)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HORA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO:"
        '
        'FlyoutUsuario
        '
        Me.FlyoutUsuario.DropShadow = False
        Me.FlyoutUsuario.TargetControl = Me.BubbleBar5
        '
        'P_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1179, 690)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "P_Producto"
        Me.Text = "PRODUCTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        CType(Me.Ptb_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Bs_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DtiFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sb_Stock As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_NombreCorto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Txt_Nombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Txt_Codigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Hl_Producto As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Cbx_Categoria As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Btnx_BuscarImagen As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Ptb_Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents Ofd_Producto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Ti_Productos As System.Windows.Forms.Timer
    Friend WithEvents _Bs_Productos As System.Windows.Forms.BindingSource
    Friend WithEvents Lbl_NombreImagen As DevComponents.DotNetBar.LabelX
    Friend WithEvents Sb_Estado As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dgs_Productos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn7 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn8 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn9 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn10 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelUsuario As System.Windows.Forms.Panel
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
    Friend WithEvents GridColumn11 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn12 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn13 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents GridColumn14 As DevComponents.DotNetBar.SuperGrid.GridColumn
    Friend WithEvents SbEsEquipo As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DtiFechaIngreso As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents GridColumn15 As DevComponents.DotNetBar.SuperGrid.GridColumn

End Class
