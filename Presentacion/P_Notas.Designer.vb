<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Notas
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
        Dim Background1 As DevComponents.DotNetBar.SuperGrid.Style.Background = New DevComponents.DotNetBar.SuperGrid.Style.Background()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Notas))
        Me.DgdNota = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Cm1Notas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Tsm1Quitar = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx6 = New DevComponents.DotNetBar.PanelEx()
        Me.TbdGastos = New DevComponents.Editors.DoubleInput()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Decuentos = New DevComponents.Editors.IntegerInput()
        Me.Txt_Tapas = New DevComponents.Editors.IntegerInput()
        Me.Txt_TotalRecibido = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_TotalEfectivo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txt_Credito = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Contado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Equipos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Pagos = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_NroNota = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Dge_Repartidor = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dge_Clientes = New Janus.Windows.GridEX.GridEX()
        Me.Cm2Clientes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Tsm1Ocultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dge_CategoriaProducto = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Bt6Recalcular = New DevComponents.DotNetBar.ButtonX()
        Me.Txt_Codigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Dti_Fecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_CodRepartidor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Txt_CodTipoProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_TipoProducto = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Txt_Repartidor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Hl_Notas = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Stc_EquipoPagos = New DevComponents.DotNetBar.SuperTabControl()
        Me.SuperTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Dgd4Pagos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Sti_Pagos = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.Dgd3Equipo = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.Sti_Equipos = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel5 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgdGastos = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.StiGastos = New DevComponents.DotNetBar.SuperTabItem()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgd2Resumen = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.DgdMovimiento = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Bt1AddPendientes = New DevComponents.DotNetBar.ButtonX()
        Me.Btnx_BajarCli = New DevComponents.DotNetBar.ButtonX()
        Me.Btnx_Quitar = New DevComponents.DotNetBar.ButtonX()
        Me.Bt2InsClientes = New DevComponents.DotNetBar.ButtonX()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.Bb1Aciones = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab6 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bt1Nuevo = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt2Modificar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt3Eliminar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt4Grabar = New DevComponents.DotNetBar.BubbleButton()
        Me.Bt5Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.Rl1Accion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.FlyoutUsuario = New DevComponents.DotNetBar.Controls.Flyout(Me.components)
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.BtActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.ilTipoNota = New System.Windows.Forms.ImageList(Me.components)
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
        Me.Cm1Notas.SuspendLayout()
        Me.PanelEx6.SuspendLayout()
        CType(Me.TbdGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Decuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Tapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dge_Repartidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        CType(Me.Dge_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cm2Clientes.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Dge_CategoriaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        CType(Me.Dti_Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stc_EquipoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stc_EquipoPagos.SuspendLayout()
        Me.SuperTabControlPanel4.SuspendLayout()
        Me.SuperTabControlPanel3.SuspendLayout()
        Me.SuperTabControlPanel5.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bb1Aciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(1284, 561)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Dgj1Busqueda)
        Me.SuperTabControlPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(1284, 536)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(1284, 536)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.BtActualizar)
        Me.PanelEx1.Controls.Add(Me.LabelX16)
        Me.PanelEx1.Controls.Add(Me.Rl1Accion)
        Me.PanelEx1.Controls.Add(Me.Bb1Aciones)
        Me.PanelEx1.Size = New System.Drawing.Size(1284, 64)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar1, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.Bb1Aciones, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.Rl1Accion, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.LabelX16, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BtActualizar, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar2, 0)
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
        Me.BubbleBar1.Location = New System.Drawing.Point(633, 0)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Visible = False
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
        Me.BubbleBar2.Location = New System.Drawing.Point(1145, 0)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Size = New System.Drawing.Size(1284, 36)
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
        Me.PanelEx3.Controls.Add(Me.Stc_EquipoPagos)
        Me.PanelEx3.Controls.Add(Me.GroupPanel3)
        Me.PanelEx3.Controls.Add(Me.GroupPanel2)
        Me.PanelEx3.Controls.Add(Me.GroupPanel1)
        Me.PanelEx3.Size = New System.Drawing.Size(1284, 187)
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
        Me.PanelEx4.Controls.Add(Me.GroupPanel4)
        Me.PanelEx4.Controls.Add(Me.GroupPanel5)
        Me.PanelEx4.Controls.Add(Me.PanelEx6)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 251)
        Me.PanelEx4.Size = New System.Drawing.Size(1284, 249)
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
        Me.PanelEx5.Location = New System.Drawing.Point(1084, 0)
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
        'DgdNota
        '
        Me.DgdNota.ContextMenuStrip = Me.Cm1Notas
        Me.DgdNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgdNota.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DgdNota.Location = New System.Drawing.Point(0, 0)
        Me.DgdNota.Name = "DgdNota"
        Me.DgdNota.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.DgdNota.PrimaryGrid.AllowRowInsert = True
        '
        '
        '
        Me.DgdNota.PrimaryGrid.Footer.Text = ""
        Me.DgdNota.Size = New System.Drawing.Size(1178, 108)
        Me.DgdNota.TabIndex = 0
        Me.DgdNota.Text = "SuperGridControl1"
        '
        'Cm1Notas
        '
        Me.Cm1Notas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsm1Quitar})
        Me.Cm1Notas.Name = "CmNotas"
        Me.Cm1Notas.Size = New System.Drawing.Size(108, 26)
        '
        'Tsm1Quitar
        '
        Me.Tsm1Quitar.Name = "Tsm1Quitar"
        Me.Tsm1Quitar.Size = New System.Drawing.Size(107, 22)
        Me.Tsm1Quitar.Text = "Quitar"
        '
        'PanelEx6
        '
        Me.PanelEx6.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx6.Controls.Add(Me.TbdGastos)
        Me.PanelEx6.Controls.Add(Me.LabelX17)
        Me.PanelEx6.Controls.Add(Me.Txt_Decuentos)
        Me.PanelEx6.Controls.Add(Me.Txt_Tapas)
        Me.PanelEx6.Controls.Add(Me.Txt_TotalRecibido)
        Me.PanelEx6.Controls.Add(Me.LabelX15)
        Me.PanelEx6.Controls.Add(Me.LabelX14)
        Me.PanelEx6.Controls.Add(Me.LabelX13)
        Me.PanelEx6.Controls.Add(Me.Txt_TotalEfectivo)
        Me.PanelEx6.Controls.Add(Me.Txt_Credito)
        Me.PanelEx6.Controls.Add(Me.LabelX11)
        Me.PanelEx6.Controls.Add(Me.Txt_Contado)
        Me.PanelEx6.Controls.Add(Me.LabelX10)
        Me.PanelEx6.Controls.Add(Me.Txt_Equipos)
        Me.PanelEx6.Controls.Add(Me.LabelX9)
        Me.PanelEx6.Controls.Add(Me.Txt_Pagos)
        Me.PanelEx6.Controls.Add(Me.LabelX8)
        Me.PanelEx6.Controls.Add(Me.LabelX12)
        Me.PanelEx6.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx6.Location = New System.Drawing.Point(0, 179)
        Me.PanelEx6.Name = "PanelEx6"
        Me.PanelEx6.Size = New System.Drawing.Size(1284, 70)
        Me.PanelEx6.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx6.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx6.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx6.Style.GradientAngle = 90
        Me.PanelEx6.TabIndex = 1
        '
        'TbdGastos
        '
        '
        '
        '
        Me.TbdGastos.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TbdGastos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbdGastos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TbdGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbdGastos.Increment = 1.0R
        Me.TbdGastos.IsInputReadOnly = True
        Me.TbdGastos.Location = New System.Drawing.Point(1120, 7)
        Me.TbdGastos.Name = "TbdGastos"
        Me.TbdGastos.Size = New System.Drawing.Size(100, 24)
        Me.TbdGastos.TabIndex = 19
        '
        'LabelX17
        '
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX17.Location = New System.Drawing.Point(1048, 7)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(75, 23)
        Me.LabelX17.TabIndex = 18
        Me.LabelX17.Text = "GASTOS...."
        '
        'Txt_Decuentos
        '
        '
        '
        '
        Me.Txt_Decuentos.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Txt_Decuentos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Decuentos.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Txt_Decuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Decuentos.Location = New System.Drawing.Point(591, 35)
        Me.Txt_Decuentos.Name = "Txt_Decuentos"
        Me.Txt_Decuentos.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Decuentos.TabIndex = 17
        '
        'Txt_Tapas
        '
        '
        '
        '
        Me.Txt_Tapas.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Txt_Tapas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Tapas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Txt_Tapas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Tapas.IsInputReadOnly = True
        Me.Txt_Tapas.Location = New System.Drawing.Point(942, 7)
        Me.Txt_Tapas.Name = "Txt_Tapas"
        Me.Txt_Tapas.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Tapas.TabIndex = 16
        '
        'Txt_TotalRecibido
        '
        '
        '
        '
        Me.Txt_TotalRecibido.Border.Class = "TextBoxBorder"
        Me.Txt_TotalRecibido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_TotalRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalRecibido.Location = New System.Drawing.Point(385, 36)
        Me.Txt_TotalRecibido.Name = "Txt_TotalRecibido"
        Me.Txt_TotalRecibido.Size = New System.Drawing.Size(100, 24)
        Me.Txt_TotalRecibido.TabIndex = 15
        Me.Txt_TotalRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txt_TotalRecibido.Visible = False
        '
        'LabelX15
        '
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX15.Location = New System.Drawing.Point(255, 37)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(135, 23)
        Me.LabelX15.TabIndex = 14
        Me.LabelX15.Text = "TOTAL RECIBIDO...."
        Me.LabelX15.Visible = False
        '
        'LabelX14
        '
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX14.Location = New System.Drawing.Point(491, 36)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(107, 23)
        Me.LabelX14.TabIndex = 12
        Me.LabelX14.Text = "DESCUENTOS...."
        '
        'LabelX13
        '
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX13.Location = New System.Drawing.Point(882, 7)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(75, 23)
        Me.LabelX13.TabIndex = 10
        Me.LabelX13.Text = "TAPAS...."
        '
        'Txt_TotalEfectivo
        '
        '
        '
        '
        Me.Txt_TotalEfectivo.Border.Class = "TextBoxBorder"
        Me.Txt_TotalEfectivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_TotalEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalEfectivo.Location = New System.Drawing.Point(149, 37)
        Me.Txt_TotalEfectivo.Name = "Txt_TotalEfectivo"
        Me.Txt_TotalEfectivo.ReadOnly = True
        Me.Txt_TotalEfectivo.Size = New System.Drawing.Size(100, 24)
        Me.Txt_TotalEfectivo.TabIndex = 9
        Me.Txt_TotalEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Credito
        '
        '
        '
        '
        Me.Txt_Credito.Border.Class = "TextBoxBorder"
        Me.Txt_Credito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Credito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Credito.Location = New System.Drawing.Point(776, 7)
        Me.Txt_Credito.Name = "Txt_Credito"
        Me.Txt_Credito.ReadOnly = True
        Me.Txt_Credito.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Credito.TabIndex = 7
        Me.Txt_Credito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX11
        '
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX11.Location = New System.Drawing.Point(697, 7)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(96, 23)
        Me.LabelX11.TabIndex = 6
        Me.LabelX11.Text = "CREDITO............."
        '
        'Txt_Contado
        '
        '
        '
        '
        Me.Txt_Contado.Border.Class = "TextBoxBorder"
        Me.Txt_Contado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Contado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contado.Location = New System.Drawing.Point(591, 7)
        Me.Txt_Contado.Name = "Txt_Contado"
        Me.Txt_Contado.ReadOnly = True
        Me.Txt_Contado.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Contado.TabIndex = 5
        Me.Txt_Contado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX10
        '
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX10.Location = New System.Drawing.Point(491, 7)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(107, 23)
        Me.LabelX10.TabIndex = 4
        Me.LabelX10.Text = "CONTADO................"
        '
        'Txt_Equipos
        '
        '
        '
        '
        Me.Txt_Equipos.Border.Class = "TextBoxBorder"
        Me.Txt_Equipos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Equipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Equipos.Location = New System.Drawing.Point(385, 7)
        Me.Txt_Equipos.Name = "Txt_Equipos"
        Me.Txt_Equipos.ReadOnly = True
        Me.Txt_Equipos.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Equipos.TabIndex = 3
        Me.Txt_Equipos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(255, 7)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(135, 23)
        Me.LabelX9.TabIndex = 2
        Me.LabelX9.Text = "EQUIPOS...................."
        '
        'Txt_Pagos
        '
        '
        '
        '
        Me.Txt_Pagos.Border.Class = "TextBoxBorder"
        Me.Txt_Pagos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Pagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pagos.Location = New System.Drawing.Point(149, 7)
        Me.Txt_Pagos.Name = "Txt_Pagos"
        Me.Txt_Pagos.ReadOnly = True
        Me.Txt_Pagos.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Pagos.TabIndex = 1
        Me.Txt_Pagos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(12, 7)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(140, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "PAGOS............................."
        '
        'LabelX12
        '
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX12.Location = New System.Drawing.Point(12, 36)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(140, 23)
        Me.LabelX12.TabIndex = 8
        Me.LabelX12.Text = "TOTAL EFECTIVO...."
        '
        'Txt_NroNota
        '
        '
        '
        '
        Me.Txt_NroNota.Border.Class = "TextBoxBorder"
        Me.Txt_NroNota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_NroNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NroNota.Location = New System.Drawing.Point(82, 32)
        Me.Txt_NroNota.Name = "Txt_NroNota"
        Me.Txt_NroNota.PreventEnterBeep = True
        Me.Txt_NroNota.Size = New System.Drawing.Size(80, 21)
        Me.Txt_NroNota.TabIndex = 3
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(3, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(79, 23)
        Me.LabelX2.TabIndex = 4
        Me.LabelX2.Text = "NRO. NOTA......."
        '
        'Dge_Repartidor
        '
        Me.Dge_Repartidor.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Dge_Repartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dge_Repartidor.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.Dge_Repartidor.Location = New System.Drawing.Point(0, 0)
        Me.Dge_Repartidor.Name = "Dge_Repartidor"
        Me.Dge_Repartidor.RowFormatStyle.BackColor = System.Drawing.Color.DarkGray
        Me.Dge_Repartidor.Size = New System.Drawing.Size(246, 166)
        Me.Dge_Repartidor.TabIndex = 8
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelUsuario)
        Me.GroupPanel1.Controls.Add(Me.Dge_Clientes)
        Me.GroupPanel1.Controls.Add(Me.Dge_Repartidor)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(520, 187)
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
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "REPARTIDOR"
        '
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.Label3)
        Me.PanelUsuario.Controls.Add(Me.Label2)
        Me.PanelUsuario.Controls.Add(Me.Label1)
        Me.PanelUsuario.Location = New System.Drawing.Point(252, 32)
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
        'Dge_Clientes
        '
        Me.Dge_Clientes.ContextMenuStrip = Me.Cm2Clientes
        Me.Dge_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dge_Clientes.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.Dge_Clientes.Location = New System.Drawing.Point(265, 0)
        Me.Dge_Clientes.Name = "Dge_Clientes"
        Me.Dge_Clientes.Size = New System.Drawing.Size(246, 166)
        Me.Dge_Clientes.TabIndex = 9
        '
        'Cm2Clientes
        '
        Me.Cm2Clientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tsm1Ocultar})
        Me.Cm2Clientes.Name = "CmNotas"
        Me.Cm2Clientes.Size = New System.Drawing.Size(156, 26)
        '
        'Tsm1Ocultar
        '
        Me.Tsm1Ocultar.Name = "Tsm1Ocultar"
        Me.Tsm1Ocultar.Size = New System.Drawing.Size(155, 22)
        Me.Tsm1Ocultar.Text = "Enviar al Fondo"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Dge_CategoriaProducto)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel2.Location = New System.Drawing.Point(520, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(250, 187)
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
        Me.GroupPanel2.TabIndex = 10
        Me.GroupPanel2.Text = "PRODUCTO"
        '
        'Dge_CategoriaProducto
        '
        Me.Dge_CategoriaProducto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Dge_CategoriaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dge_CategoriaProducto.Location = New System.Drawing.Point(0, 0)
        Me.Dge_CategoriaProducto.Name = "Dge_CategoriaProducto"
        Me.Dge_CategoriaProducto.RowFormatStyle.BackColor = System.Drawing.Color.DarkGray
        Me.Dge_CategoriaProducto.Size = New System.Drawing.Size(244, 166)
        Me.Dge_CategoriaProducto.TabIndex = 8
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Bt6Recalcular)
        Me.GroupPanel3.Controls.Add(Me.Txt_Codigo)
        Me.GroupPanel3.Controls.Add(Me.LabelX7)
        Me.GroupPanel3.Controls.Add(Me.Dti_Fecha)
        Me.GroupPanel3.Controls.Add(Me.LabelX6)
        Me.GroupPanel3.Controls.Add(Me.Txt_CodRepartidor)
        Me.GroupPanel3.Controls.Add(Me.Txt_CodTipoProducto)
        Me.GroupPanel3.Controls.Add(Me.LabelX4)
        Me.GroupPanel3.Controls.Add(Me.Txt_TipoProducto)
        Me.GroupPanel3.Controls.Add(Me.LabelX3)
        Me.GroupPanel3.Controls.Add(Me.Txt_Repartidor)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.Controls.Add(Me.Txt_NroNota)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.LabelX5)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupPanel3.Location = New System.Drawing.Point(770, 0)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(250, 187)
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
        Me.GroupPanel3.TabIndex = 11
        Me.GroupPanel3.Text = "DATOS SELECCIONADOS"
        '
        'Bt6Recalcular
        '
        Me.Bt6Recalcular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt6Recalcular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt6Recalcular.Image = Global.Presentacion.My.Resources.Resources.ACTUALIZAR
        Me.Bt6Recalcular.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Bt6Recalcular.Location = New System.Drawing.Point(201, 3)
        Me.Bt6Recalcular.Name = "Bt6Recalcular"
        Me.Bt6Recalcular.Size = New System.Drawing.Size(40, 40)
        Me.Bt6Recalcular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt6Recalcular.TabIndex = 17
        '
        'Txt_Codigo
        '
        '
        '
        '
        Me.Txt_Codigo.Border.Class = "TextBoxBorder"
        Me.Txt_Codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Codigo.Location = New System.Drawing.Point(82, 3)
        Me.Txt_Codigo.Name = "Txt_Codigo"
        Me.Txt_Codigo.PreventEnterBeep = True
        Me.Txt_Codigo.ReadOnly = True
        Me.Txt_Codigo.Size = New System.Drawing.Size(80, 21)
        Me.Txt_Codigo.TabIndex = 15
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(3, 3)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(79, 23)
        Me.LabelX7.TabIndex = 16
        Me.LabelX7.Text = "CÓDIGO..........."
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
        Me.Dti_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dti_Fecha.IsPopupCalendarOpen = False
        Me.Dti_Fecha.Location = New System.Drawing.Point(82, 61)
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
        Me.Dti_Fecha.MonthCalendar.DisplayMonth = New Date(2016, 6, 1, 0, 0, 0, 0)
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
        Me.Dti_Fecha.Size = New System.Drawing.Size(100, 21)
        Me.Dti_Fecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti_Fecha.TabIndex = 14
        Me.Dti_Fecha.Value = New Date(2016, 6, 17, 16, 7, 6, 0)
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(3, 61)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(79, 23)
        Me.LabelX6.TabIndex = 13
        Me.LabelX6.Text = "FECHA.............."
        '
        'Txt_CodRepartidor
        '
        '
        '
        '
        Me.Txt_CodRepartidor.Border.Class = "TextBoxBorder"
        Me.Txt_CodRepartidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_CodRepartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CodRepartidor.Location = New System.Drawing.Point(3, 99)
        Me.Txt_CodRepartidor.Name = "Txt_CodRepartidor"
        Me.Txt_CodRepartidor.PreventEnterBeep = True
        Me.Txt_CodRepartidor.ReadOnly = True
        Me.Txt_CodRepartidor.Size = New System.Drawing.Size(50, 21)
        Me.Txt_CodRepartidor.TabIndex = 7
        Me.Txt_CodRepartidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_CodTipoProducto
        '
        '
        '
        '
        Me.Txt_CodTipoProducto.Border.Class = "TextBoxBorder"
        Me.Txt_CodTipoProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_CodTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CodTipoProducto.Location = New System.Drawing.Point(3, 143)
        Me.Txt_CodTipoProducto.Name = "Txt_CodTipoProducto"
        Me.Txt_CodTipoProducto.PreventEnterBeep = True
        Me.Txt_CodTipoProducto.ReadOnly = True
        Me.Txt_CodTipoProducto.Size = New System.Drawing.Size(50, 21)
        Me.Txt_CodTipoProducto.TabIndex = 11
        Me.Txt_CodTipoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(3, 79)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(50, 23)
        Me.LabelX4.TabIndex = 10
        Me.LabelX4.Text = "COD"
        '
        'Txt_TipoProducto
        '
        '
        '
        '
        Me.Txt_TipoProducto.Border.Class = "TextBoxBorder"
        Me.Txt_TipoProducto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_TipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TipoProducto.Location = New System.Drawing.Point(61, 143)
        Me.Txt_TipoProducto.Name = "Txt_TipoProducto"
        Me.Txt_TipoProducto.PreventEnterBeep = True
        Me.Txt_TipoProducto.ReadOnly = True
        Me.Txt_TipoProducto.Size = New System.Drawing.Size(180, 21)
        Me.Txt_TipoProducto.TabIndex = 8
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(61, 123)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(180, 23)
        Me.LabelX3.TabIndex = 9
        Me.LabelX3.Text = "TIPO DE PRODUCTO"
        '
        'Txt_Repartidor
        '
        '
        '
        '
        Me.Txt_Repartidor.Border.Class = "TextBoxBorder"
        Me.Txt_Repartidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Txt_Repartidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Repartidor.Location = New System.Drawing.Point(61, 99)
        Me.Txt_Repartidor.Name = "Txt_Repartidor"
        Me.Txt_Repartidor.PreventEnterBeep = True
        Me.Txt_Repartidor.ReadOnly = True
        Me.Txt_Repartidor.Size = New System.Drawing.Size(180, 21)
        Me.Txt_Repartidor.TabIndex = 5
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(61, 79)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(180, 23)
        Me.LabelX1.TabIndex = 6
        Me.LabelX1.Text = "REPARTIDOR"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(5, 123)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(50, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "COD"
        '
        'Hl_Notas
        '
        Me.Hl_Notas.ContainerControl = Me
        '
        'Stc_EquipoPagos
        '
        '
        '
        '
        '
        '
        '
        Me.Stc_EquipoPagos.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.Stc_EquipoPagos.ControlBox.MenuBox.Name = ""
        Me.Stc_EquipoPagos.ControlBox.Name = ""
        Me.Stc_EquipoPagos.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Stc_EquipoPagos.ControlBox.MenuBox, Me.Stc_EquipoPagos.ControlBox.CloseBox})
        Me.Stc_EquipoPagos.Controls.Add(Me.SuperTabControlPanel4)
        Me.Stc_EquipoPagos.Controls.Add(Me.SuperTabControlPanel3)
        Me.Stc_EquipoPagos.Controls.Add(Me.SuperTabControlPanel5)
        Me.Stc_EquipoPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Stc_EquipoPagos.Location = New System.Drawing.Point(1020, 0)
        Me.Stc_EquipoPagos.Name = "Stc_EquipoPagos"
        Me.Stc_EquipoPagos.ReorderTabsEnabled = True
        Me.Stc_EquipoPagos.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Stc_EquipoPagos.SelectedTabIndex = 0
        Me.Stc_EquipoPagos.Size = New System.Drawing.Size(264, 187)
        Me.Stc_EquipoPagos.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stc_EquipoPagos.TabIndex = 12
        Me.Stc_EquipoPagos.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Sti_Pagos, Me.Sti_Equipos, Me.StiGastos})
        Me.Stc_EquipoPagos.Text = "SuperTabControl2"
        '
        'SuperTabControlPanel4
        '
        Me.SuperTabControlPanel4.Controls.Add(Me.Dgd4Pagos)
        Me.SuperTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel4.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel4.Name = "SuperTabControlPanel4"
        Me.SuperTabControlPanel4.Padding = New System.Windows.Forms.Padding(3)
        Me.SuperTabControlPanel4.Size = New System.Drawing.Size(264, 162)
        Me.SuperTabControlPanel4.TabIndex = 0
        Me.SuperTabControlPanel4.TabItem = Me.Sti_Pagos
        '
        'Dgd4Pagos
        '
        Background1.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Background1.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Dgd4Pagos.DefaultVisualStyles.RowStyles.Default.Background = Background1
        Me.Dgd4Pagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgd4Pagos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Dgd4Pagos.Location = New System.Drawing.Point(3, 3)
        Me.Dgd4Pagos.Name = "Dgd4Pagos"
        Me.Dgd4Pagos.Size = New System.Drawing.Size(258, 156)
        Me.Dgd4Pagos.TabIndex = 0
        Me.Dgd4Pagos.Text = "SuperGridControl1"
        '
        'Sti_Pagos
        '
        Me.Sti_Pagos.AttachedControl = Me.SuperTabControlPanel4
        Me.Sti_Pagos.GlobalItem = False
        Me.Sti_Pagos.Name = "Sti_Pagos"
        Me.Sti_Pagos.Text = "PAGOS"
        '
        'SuperTabControlPanel3
        '
        Me.SuperTabControlPanel3.Controls.Add(Me.Dgd3Equipo)
        Me.SuperTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel3.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel3.Name = "SuperTabControlPanel3"
        Me.SuperTabControlPanel3.Padding = New System.Windows.Forms.Padding(3)
        Me.SuperTabControlPanel3.Size = New System.Drawing.Size(264, 162)
        Me.SuperTabControlPanel3.TabIndex = 1
        Me.SuperTabControlPanel3.TabItem = Me.Sti_Equipos
        '
        'Dgd3Equipo
        '
        Me.Dgd3Equipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgd3Equipo.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Dgd3Equipo.Location = New System.Drawing.Point(3, 3)
        Me.Dgd3Equipo.Name = "Dgd3Equipo"
        '
        '
        '
        Me.Dgd3Equipo.PrimaryGrid.ColumnGroupHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.None
        Me.Dgd3Equipo.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.Dgd3Equipo.Size = New System.Drawing.Size(258, 156)
        Me.Dgd3Equipo.TabIndex = 1
        Me.Dgd3Equipo.Text = "SuperGridControl1"
        '
        'Sti_Equipos
        '
        Me.Sti_Equipos.AttachedControl = Me.SuperTabControlPanel3
        Me.Sti_Equipos.GlobalItem = False
        Me.Sti_Equipos.Name = "Sti_Equipos"
        Me.Sti_Equipos.Text = "EQUIPOS"
        '
        'SuperTabControlPanel5
        '
        Me.SuperTabControlPanel5.Controls.Add(Me.DgdGastos)
        Me.SuperTabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel5.Location = New System.Drawing.Point(0, 25)
        Me.SuperTabControlPanel5.Name = "SuperTabControlPanel5"
        Me.SuperTabControlPanel5.Padding = New System.Windows.Forms.Padding(3)
        Me.SuperTabControlPanel5.Size = New System.Drawing.Size(264, 162)
        Me.SuperTabControlPanel5.TabIndex = 0
        Me.SuperTabControlPanel5.TabItem = Me.StiGastos
        '
        'DgdGastos
        '
        Me.DgdGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgdGastos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DgdGastos.Location = New System.Drawing.Point(3, 3)
        Me.DgdGastos.Name = "DgdGastos"
        '
        '
        '
        Me.DgdGastos.PrimaryGrid.ColumnGroupHeaderClickBehavior = DevComponents.DotNetBar.SuperGrid.ColumnHeaderClickBehavior.None
        Me.DgdGastos.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.DgdGastos.Size = New System.Drawing.Size(258, 156)
        Me.DgdGastos.TabIndex = 2
        Me.DgdGastos.Text = "SuperGridControl1"
        '
        'StiGastos
        '
        Me.StiGastos.AttachedControl = Me.SuperTabControlPanel5
        Me.StiGastos.GlobalItem = False
        Me.StiGastos.Name = "StiGastos"
        Me.StiGastos.Text = "GASTOS"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.DgdNota)
        Me.GroupPanel4.Controls.Add(Me.Dgd2Resumen)
        Me.GroupPanel4.Controls.Add(Me.DgdMovimiento)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1184, 179)
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
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
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
        Me.GroupPanel4.Text = "NOTA"
        '
        'Dgd2Resumen
        '
        Me.Dgd2Resumen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgd2Resumen.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.Dgd2Resumen.HScrollBarVisible = False
        Me.Dgd2Resumen.Location = New System.Drawing.Point(0, 108)
        Me.Dgd2Resumen.Name = "Dgd2Resumen"
        Me.Dgd2Resumen.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.Dgd2Resumen.PrimaryGrid.AllowRowInsert = True
        '
        '
        '
        Me.Dgd2Resumen.PrimaryGrid.ColumnHeader.Visible = False
        '
        '
        '
        Me.Dgd2Resumen.PrimaryGrid.Footer.Text = ""
        Me.Dgd2Resumen.PrimaryGrid.ShowColumnHeader = False
        Me.Dgd2Resumen.Size = New System.Drawing.Size(1178, 25)
        Me.Dgd2Resumen.TabIndex = 1
        Me.Dgd2Resumen.Text = "SuperGridControl1"
        Me.Dgd2Resumen.VScrollBarVisible = False
        '
        'DgdMovimiento
        '
        Me.DgdMovimiento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgdMovimiento.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DgdMovimiento.HScrollBarVisible = False
        Me.DgdMovimiento.Location = New System.Drawing.Point(0, 133)
        Me.DgdMovimiento.Name = "DgdMovimiento"
        Me.DgdMovimiento.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.DgdMovimiento.PrimaryGrid.AllowRowInsert = True
        '
        '
        '
        Me.DgdMovimiento.PrimaryGrid.ColumnHeader.Visible = False
        '
        '
        '
        Me.DgdMovimiento.PrimaryGrid.Footer.Text = ""
        Me.DgdMovimiento.PrimaryGrid.ShowColumnHeader = False
        Me.DgdMovimiento.Size = New System.Drawing.Size(1178, 25)
        Me.DgdMovimiento.TabIndex = 2
        Me.DgdMovimiento.Text = "SuperGridControl1"
        Me.DgdMovimiento.VScrollBarVisible = False
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.Bt1AddPendientes)
        Me.GroupPanel5.Controls.Add(Me.Btnx_BajarCli)
        Me.GroupPanel5.Controls.Add(Me.Btnx_Quitar)
        Me.GroupPanel5.Controls.Add(Me.Bt2InsClientes)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupPanel5.Location = New System.Drawing.Point(1184, 0)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(100, 179)
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
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
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
        Me.GroupPanel5.TabIndex = 6
        Me.GroupPanel5.Text = "ACCIÓN"
        '
        'Bt1AddPendientes
        '
        Me.Bt1AddPendientes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt1AddPendientes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt1AddPendientes.Location = New System.Drawing.Point(0, 0)
        Me.Bt1AddPendientes.Name = "Bt1AddPendientes"
        Me.Bt1AddPendientes.Size = New System.Drawing.Size(92, 50)
        Me.Bt1AddPendientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt1AddPendientes.TabIndex = 4
        Me.Bt1AddPendientes.Text = "ADICIONAR PENDIENTES"
        '
        'Btnx_BajarCli
        '
        Me.Btnx_BajarCli.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btnx_BajarCli.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btnx_BajarCli.Location = New System.Drawing.Point(10, 110)
        Me.Btnx_BajarCli.Name = "Btnx_BajarCli"
        Me.Btnx_BajarCli.Size = New System.Drawing.Size(75, 15)
        Me.Btnx_BajarCli.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btnx_BajarCli.TabIndex = 3
        Me.Btnx_BajarCli.Text = "BAJAR"
        Me.Btnx_BajarCli.Visible = False
        '
        'Btnx_Quitar
        '
        Me.Btnx_Quitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btnx_Quitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btnx_Quitar.Location = New System.Drawing.Point(10, 132)
        Me.Btnx_Quitar.Name = "Btnx_Quitar"
        Me.Btnx_Quitar.Size = New System.Drawing.Size(75, 15)
        Me.Btnx_Quitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Btnx_Quitar.TabIndex = 1
        Me.Btnx_Quitar.Text = "QUITAR"
        Me.Btnx_Quitar.Visible = False
        '
        'Bt2InsClientes
        '
        Me.Bt2InsClientes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt2InsClientes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt2InsClientes.Location = New System.Drawing.Point(0, 54)
        Me.Bt2InsClientes.Name = "Bt2InsClientes"
        Me.Bt2InsClientes.Size = New System.Drawing.Size(92, 50)
        Me.Bt2InsClientes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt2InsClientes.TabIndex = 0
        Me.Bt2InsClientes.Text = "INSERTAR CLIENTES"
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(5, 5)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(1274, 526)
        Me.Dgj1Busqueda.TabIndex = 1
        '
        'Bb1Aciones
        '
        Me.Bb1Aciones.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.Bb1Aciones.AntiAlias = True
        Me.Bb1Aciones.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Bb1Aciones.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Bb1Aciones.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.Bb1Aciones.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.Bb1Aciones.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Bb1Aciones.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.Bb1Aciones.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.Bb1Aciones.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.Bb1Aciones.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Bb1Aciones.ButtonBackAreaStyle.PaddingBottom = 3
        Me.Bb1Aciones.ButtonBackAreaStyle.PaddingLeft = 3
        Me.Bb1Aciones.ButtonBackAreaStyle.PaddingRight = 3
        Me.Bb1Aciones.ButtonBackAreaStyle.PaddingTop = 3
        Me.Bb1Aciones.ImageSizeLarge = New System.Drawing.Size(64, 64)
        Me.Bb1Aciones.ImageSizeNormal = New System.Drawing.Size(48, 48)
        Me.Bb1Aciones.Location = New System.Drawing.Point(2, 2)
        Me.Bb1Aciones.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Bb1Aciones.Name = "Bb1Aciones"
        Me.Bb1Aciones.SelectedTab = Me.BubbleBarTab6
        Me.Bb1Aciones.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.Bb1Aciones.Size = New System.Drawing.Size(266, 61)
        Me.Bb1Aciones.TabIndex = 5
        Me.Bb1Aciones.Tabs.Add(Me.BubbleBarTab6)
        Me.Bb1Aciones.TabsVisible = False
        Me.Bb1Aciones.Text = "BubbleBar6"
        '
        'BubbleBarTab6
        '
        Me.BubbleBarTab6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab6.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.Bt1Nuevo, Me.Bt2Modificar, Me.Bt3Eliminar, Me.Bt4Grabar, Me.Bt5Cancelar})
        Me.BubbleBarTab6.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab6.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab6.Name = "BubbleBarTab6"
        Me.BubbleBarTab6.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab6.Text = "BubbleBarTab1"
        Me.BubbleBarTab6.TextColor = System.Drawing.Color.Black
        '
        'Bt1Nuevo
        '
        Me.Bt1Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt1Nuevo.Image = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.Bt1Nuevo.ImageLarge = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.Bt1Nuevo.Name = "Bt1Nuevo"
        Me.Bt1Nuevo.TooltipText = "NUEVO"
        '
        'Bt2Modificar
        '
        Me.Bt2Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt2Modificar.Image = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.Bt2Modificar.ImageLarge = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.Bt2Modificar.Name = "Bt2Modificar"
        Me.Bt2Modificar.TooltipText = "MODIFICAR"
        '
        'Bt3Eliminar
        '
        Me.Bt3Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt3Eliminar.Image = CType(resources.GetObject("Bt3Eliminar.Image"), System.Drawing.Image)
        Me.Bt3Eliminar.ImageLarge = CType(resources.GetObject("Bt3Eliminar.ImageLarge"), System.Drawing.Image)
        Me.Bt3Eliminar.Name = "Bt3Eliminar"
        Me.Bt3Eliminar.TooltipText = "ELIMINAR"
        '
        'Bt4Grabar
        '
        Me.Bt4Grabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt4Grabar.Image = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.Bt4Grabar.ImageLarge = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.Bt4Grabar.Name = "Bt4Grabar"
        Me.Bt4Grabar.TooltipText = "GRABAR"
        '
        'Bt5Cancelar
        '
        Me.Bt5Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt5Cancelar.Image = CType(resources.GetObject("Bt5Cancelar.Image"), System.Drawing.Image)
        Me.Bt5Cancelar.ImageLarge = CType(resources.GetObject("Bt5Cancelar.ImageLarge"), System.Drawing.Image)
        Me.Bt5Cancelar.Name = "Bt5Cancelar"
        Me.Bt5Cancelar.TooltipText = "SALIR"
        '
        'Rl1Accion
        '
        '
        '
        '
        Me.Rl1Accion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Rl1Accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rl1Accion.ForeColor = System.Drawing.Color.White
        Me.Rl1Accion.Location = New System.Drawing.Point(290, 2)
        Me.Rl1Accion.Name = "Rl1Accion"
        Me.Rl1Accion.Size = New System.Drawing.Size(200, 60)
        Me.Rl1Accion.TabIndex = 6
        Me.Rl1Accion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'FlyoutUsuario
        '
        Me.FlyoutUsuario.DropShadow = False
        Me.FlyoutUsuario.TargetControl = Me.BubbleBar5
        '
        'LabelX16
        '
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX16.ForeColor = System.Drawing.Color.White
        Me.LabelX16.Location = New System.Drawing.Point(496, 35)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(140, 23)
        Me.LabelX16.TabIndex = 7
        '
        'BtActualizar
        '
        Me.BtActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtActualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtActualizar.Image = Global.Presentacion.My.Resources.Resources.BT_ACTUALIZAR
        Me.BtActualizar.ImageFixedSize = New System.Drawing.Size(45, 45)
        Me.BtActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtActualizar.Location = New System.Drawing.Point(1209, 0)
        Me.BtActualizar.Name = "BtActualizar"
        Me.BtActualizar.Size = New System.Drawing.Size(75, 64)
        Me.BtActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtActualizar.TabIndex = 10
        Me.BtActualizar.Text = "Actualizar"
        '
        'ilTipoNota
        '
        Me.ilTipoNota.ImageStream = CType(resources.GetObject("ilTipoNota.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilTipoNota.TransparentColor = System.Drawing.Color.Transparent
        Me.ilTipoNota.Images.SetKeyName(0, "NORMAL")
        Me.ilTipoNota.Images.SetKeyName(1, "ENTREGA")
        Me.ilTipoNota.Images.SetKeyName(2, "CORTESIA")
        Me.ilTipoNota.Images.SetKeyName(3, "CAMBIO")
        '
        'P_Notas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Name = "P_Notas"
        Me.Text = "N O T A S"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.SuperTabControl1, 0)
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
        Me.PanelEx4.ResumeLayout(False)
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        Me.Cm1Notas.ResumeLayout(False)
        Me.PanelEx6.ResumeLayout(False)
        CType(Me.TbdGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Decuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Tapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dge_Repartidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        CType(Me.Dge_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cm2Clientes.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Dge_CategoriaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        CType(Me.Dti_Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stc_EquipoPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stc_EquipoPagos.ResumeLayout(False)
        Me.SuperTabControlPanel4.ResumeLayout(False)
        Me.SuperTabControlPanel3.ResumeLayout(False)
        Me.SuperTabControlPanel5.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bb1Aciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgdNota As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Txt_NroNota As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx6 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Dge_Repartidor As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dge_CategoriaProducto As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_TipoProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Txt_CodRepartidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Txt_Repartidor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_CodTipoProducto As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Codigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dti_Fecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_TotalEfectivo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Credito As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Contado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Equipos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_Pagos As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Hl_Notas As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Dge_Clientes As Janus.Windows.GridEX.GridEX
    Friend WithEvents Stc_EquipoPagos As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents SuperTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Dgd3Equipo As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Sti_Equipos As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents SuperTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents Dgd4Pagos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Sti_Pagos As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Btnx_BajarCli As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Btnx_Quitar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bt2InsClientes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bt1AddPendientes As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Cm1Notas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Tsm1Quitar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cm2Clientes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Tsm1Ocultar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Txt_TotalRecibido As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents Txt_Tapas As DevComponents.Editors.IntegerInput
    Friend WithEvents Dgd2Resumen As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents Bt6Recalcular As DevComponents.DotNetBar.ButtonX
    Protected WithEvents Bb1Aciones As DevComponents.DotNetBar.BubbleBar
    Protected WithEvents BubbleBarTab6 As DevComponents.DotNetBar.BubbleBarTab
    Protected WithEvents Bt1Nuevo As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents Bt2Modificar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents Bt3Eliminar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents Bt4Grabar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents Bt5Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Rl1Accion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Txt_Decuentos As DevComponents.Editors.IntegerInput
    Friend WithEvents PanelUsuario As System.Windows.Forms.Panel
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SuperTabControlPanel5 As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents DgdGastos As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents StiGastos As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbdGastos As DevComponents.Editors.DoubleInput
    Friend WithEvents BtActualizar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ilTipoNota As System.Windows.Forms.ImageList
    Friend WithEvents DgdMovimiento As DevComponents.DotNetBar.SuperGrid.SuperGridControl
End Class
