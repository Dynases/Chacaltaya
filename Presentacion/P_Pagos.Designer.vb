<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Pagos
    Inherits Modelos.ModeloHor

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
        Dim Cb1TipoProducto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Pagos))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Codigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txt_NroNota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_CodCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Monto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Dti_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Txt_NombreCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Lbl_Saldo = New DevComponents.DotNetBar.LabelX()
        Me.Dgs_Pagos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Hl_Pagos = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Bt1BuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.Txt_NroDoc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Rl1Accion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Cb1TipoProducto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
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
        Me.SuperTabControlPanel2.SuspendLayout()
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
        CType(Me.Dti_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cb1TipoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(934, 561)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Dgj1Busqueda)
        Me.SuperTabControlPanel2.Padding = New System.Windows.Forms.Padding(5)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(934, 536)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.Rl1Accion)
        Me.PanelEx1.Size = New System.Drawing.Size(934, 64)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar1, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar2, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.Rl1Accion, 0)
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
        Me.BubbleBar2.Location = New System.Drawing.Point(870, 0)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Size = New System.Drawing.Size(934, 36)
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
        Me.PanelEx3.Controls.Add(Me.LabelX8)
        Me.PanelEx3.Controls.Add(Me.Cb1TipoProducto)
        Me.PanelEx3.Controls.Add(Me.Txt_NroDoc)
        Me.PanelEx3.Controls.Add(Me.Bt1BuscarCliente)
        Me.PanelEx3.Controls.Add(Me.Lbl_Saldo)
        Me.PanelEx3.Controls.Add(Me.LabelX7)
        Me.PanelEx3.Controls.Add(Me.Txt_NombreCliente)
        Me.PanelEx3.Controls.Add(Me.LabelX6)
        Me.PanelEx3.Controls.Add(Me.Dti_Fecha)
        Me.PanelEx3.Controls.Add(Me.Txt_Monto)
        Me.PanelEx3.Controls.Add(Me.Txt_CodCliente)
        Me.PanelEx3.Controls.Add(Me.Txt_NroNota)
        Me.PanelEx3.Controls.Add(Me.Txt_Codigo)
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.Controls.Add(Me.LabelX3)
        Me.PanelEx3.Controls.Add(Me.LabelX2)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.Size = New System.Drawing.Size(934, 158)
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
        Me.PanelEx4.Controls.Add(Me.Dgs_Pagos)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 222)
        Me.PanelEx4.Padding = New System.Windows.Forms.Padding(5)
        Me.PanelEx4.Size = New System.Drawing.Size(934, 278)
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
        Me.PanelEx5.Location = New System.Drawing.Point(734, 0)
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
        Me.LabelX1.Location = New System.Drawing.Point(12, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(108, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Txt_Codigo
        '
        '
        '
        '
        Me.Txt_Codigo.Border.Class = "TextBoxBorder"
        Me.Txt_Codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Codigo.Location = New System.Drawing.Point(126, 9)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.PreventEnterBeep = True
        Me.Txt_Codigo.ReadOnly = True
        Me.Txt_Codigo.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Codigo.TabIndex = 7
        Me.Txt_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_NroNota
        '
        '
        '
        '
        Me.Txt_NroNota.Border.Class = "TextBoxBorder"
        Me.Txt_NroNota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_NroNota.Location = New System.Drawing.Point(126, 38)
        Me.Txt_NroNota.Name = "Txt_NroNota"
        Me.Txt_NroNota.PreventEnterBeep = True
        Me.Txt_NroNota.Size = New System.Drawing.Size(173, 20)
        Me.Txt_NroNota.TabIndex = 0
        Me.Txt_NroNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 35)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(108, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Nro. Nota:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Txt_CodCliente
        '
        '
        '
        '
        Me.Txt_CodCliente.Border.Class = "TextBoxBorder"
        Me.Txt_CodCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_CodCliente.Location = New System.Drawing.Point(126, 67)
        Me.Txt_CodCliente.Name = "Txt_CodCliente"
        Me.Txt_CodCliente.PreventEnterBeep = True
        Me.Txt_CodCliente.Size = New System.Drawing.Size(149, 20)
        Me.Txt_CodCliente.TabIndex = 2
        Me.Txt_CodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(12, 64)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(108, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Cliente:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Txt_Monto
        '
        '
        '
        '
        Me.Txt_Monto.Border.Class = "TextBoxBorder"
        Me.Txt_Monto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Monto.Location = New System.Drawing.Point(126, 96)
        Me.Txt_Monto.Name = "Txt_Monto"
        Me.Txt_Monto.PreventEnterBeep = True
        Me.Txt_Monto.Size = New System.Drawing.Size(173, 20)
        Me.Txt_Monto.TabIndex = 4
        Me.Txt_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(12, 93)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(108, 23)
        Me.LabelX4.TabIndex = 6
        Me.LabelX4.Text = "Monto:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(12, 122)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(105, 23)
        Me.LabelX5.TabIndex = 8
        Me.LabelX5.Text = "Fecha:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Dti_Fecha
        '
        '
        '
        '
        Me.Dti_Fecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dti_Fecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti_Fecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dti_Fecha.ButtonDropDown.Visible = True
        Me.Dti_Fecha.IsPopupCalendarOpen = False
        Me.Dti_Fecha.Location = New System.Drawing.Point(126, 125)
        '
        '
        '
        '
        '
        '
        Me.Dti_Fecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti_Fecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dti_Fecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dti_Fecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti_Fecha.MonthCalendar.DisplayMonth = New Date(2016, 7, 1, 0, 0, 0, 0)
        Me.Dti_Fecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dti_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dti_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti_Fecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dti_Fecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti_Fecha.MonthCalendar.TodayButtonVisible = True
        Me.Dti_Fecha.Name = "Dti_Fecha"
        Me.Dti_Fecha.Size = New System.Drawing.Size(173, 20)
        Me.Dti_Fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti_Fecha.TabIndex = 5
        '
        'Txt_NombreCliente
        '
        '
        '
        '
        Me.Txt_NombreCliente.Border.Class = "TextBoxBorder"
        Me.Txt_NombreCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_NombreCliente.Location = New System.Drawing.Point(308, 67)
        Me.Txt_NombreCliente.Name = "Txt_NombreCliente"
        Me.Txt_NombreCliente.PreventEnterBeep = True
        Me.Txt_NombreCliente.Size = New System.Drawing.Size(386, 20)
        Me.Txt_NombreCliente.TabIndex = 7
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(345, 35)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(157, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Nro Recibo:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(345, 6)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(157, 23)
        Me.LabelX7.TabIndex = 13
        Me.LabelX7.Text = "Saldo de Deuda:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Lbl_Saldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_Saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Saldo.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Saldo.Location = New System.Drawing.Point(533, 6)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(161, 23)
        Me.Lbl_Saldo.TabIndex = 14
        Me.Lbl_Saldo.Text = "00"
        Me.Lbl_Saldo.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Dgs_Pagos
        '
        Me.Dgs_Pagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgs_Pagos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Dgs_Pagos.Location = New System.Drawing.Point(5, 5)
        Me.Dgs_Pagos.Name = "Dgs_Pagos"
        '
        '
        '
        '
        '
        '
        Me.Dgs_Pagos.PrimaryGrid.Filter.Visible = True
        Me.Dgs_Pagos.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Dgs_Pagos.PrimaryGrid.UseAlternateRowStyle = True
        Me.Dgs_Pagos.Size = New System.Drawing.Size(924, 268)
        Me.Dgs_Pagos.TabIndex = 0
        Me.Dgs_Pagos.Text = "SuperGridControl1"
        '
        'Hl_Pagos
        '
        Me.Hl_Pagos.ContainerControl = Me
        '
        'Bt1BuscarCliente
        '
        Me.Bt1BuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt1BuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt1BuscarCliente.Image = Global.Presentacion.My.Resources.Resources.BUSQUEDA
        Me.Bt1BuscarCliente.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Bt1BuscarCliente.Location = New System.Drawing.Point(273, 67)
        Me.Bt1BuscarCliente.Name = "Bt1BuscarCliente"
        Me.Bt1BuscarCliente.Size = New System.Drawing.Size(26, 20)
        Me.Bt1BuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt1BuscarCliente.TabIndex = 3
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(5, 5)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(874, 526)
        Me.Dgj1Busqueda.TabIndex = 1
        '
        'Txt_NroDoc
        '
        '
        '
        '
        Me.Txt_NroDoc.Border.Class = "TextBoxBorder"
        Me.Txt_NroDoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_NroDoc.Location = New System.Drawing.Point(508, 38)
        Me.Txt_NroDoc.Name = "Txt_NroDoc"
        Me.Txt_NroDoc.PreventEnterBeep = True
        Me.Txt_NroDoc.Size = New System.Drawing.Size(186, 20)
        Me.Txt_NroDoc.TabIndex = 1
        Me.Txt_NroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Rl1Accion
        '
        '
        '
        '
        Me.Rl1Accion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Rl1Accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rl1Accion.ForeColor = System.Drawing.Color.White
        Me.Rl1Accion.Location = New System.Drawing.Point(297, 2)
        Me.Rl1Accion.Name = "Rl1Accion"
        Me.Rl1Accion.Size = New System.Drawing.Size(200, 60)
        Me.Rl1Accion.TabIndex = 7
        Me.Rl1Accion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'Cb1TipoProducto
        '
        Cb1TipoProducto_DesignTimeLayout.LayoutString = resources.GetString("Cb1TipoProducto_DesignTimeLayout.LayoutString")
        Me.Cb1TipoProducto.DesignTimeLayout = Cb1TipoProducto_DesignTimeLayout
        Me.Cb1TipoProducto.Location = New System.Drawing.Point(508, 93)
        Me.Cb1TipoProducto.Name = "Cb1TipoProducto"
        Me.Cb1TipoProducto.SelectedIndex = -1
        Me.Cb1TipoProducto.SelectedItem = Nothing
        Me.Cb1TipoProducto.Size = New System.Drawing.Size(186, 20)
        Me.Cb1TipoProducto.TabIndex = 6
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(345, 93)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(157, 23)
        Me.LabelX8.TabIndex = 16
        Me.LabelX8.Text = "Tipo de Producto:"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.Label3)
        Me.PanelUsuario.Controls.Add(Me.Label2)
        Me.PanelUsuario.Controls.Add(Me.Label1)
        Me.PanelUsuario.Location = New System.Drawing.Point(714, 35)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(220, 100)
        Me.PanelUsuario.TabIndex = 7
        Me.PanelUsuario.TabStop = True
        Me.PanelUsuario.Visible = False
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.Location = New System.Drawing.Point(115, 65)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(79, 18)
        Me.lbHora.TabIndex = 6
        Me.lbHora.Text = "USUARIO:"
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(115, 42)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(79, 18)
        Me.lbFecha.TabIndex = 5
        Me.lbFecha.Text = "USUARIO:"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(115, 19)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(79, 18)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.Text = "USUARIO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "HORA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO:"
        '
        'FlyoutUsuario
        '
        Me.FlyoutUsuario.DropShadow = False
        Me.FlyoutUsuario.TargetControl = Me.BubbleBar5
        '
        'P_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Name = "P_Pagos"
        Me.Text = "PAGOS"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
        Me.SuperTabControlPanel2.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        CType(Me.Dti_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cb1TipoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Lbl_Saldo As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_NombreCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dti_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Monto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_CodCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_NroNota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Codigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Dgs_Pagos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Hl_Pagos As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Bt1BuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents Txt_NroDoc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Rl1Accion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Cb1TipoProducto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents PanelUsuario As System.Windows.Forms.Panel
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
End Class
