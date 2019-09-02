<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Movimientos
    Inherits Modelos.ModeloHor

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DgjDetalle_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim JCb_Concepto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim JCb_Prod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Movimientos))
        Me.Ep1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Tb_Id = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rb_Inac = New System.Windows.Forms.RadioButton()
        Me.Rb_Act = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DgjDetalle = New Janus.Windows.GridEX.GridEX()
        Me.CmDetalleMov = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tb_Observacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tb_CodConcepto = New System.Windows.Forms.TextBox()
        Me.JCb_Concepto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Bt_AyudaNuevo = New System.Windows.Forms.Button()
        Me.Tb_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.JCb_Prod = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Lbl_SmsDown = New DevComponents.DotNetBar.LabelX()
        Me.BubbleBar6 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab6 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbtNuevo = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtModificar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtEliminar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtGrabar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtSalir = New DevComponents.DotNetBar.BubbleButton()
        Me.GpBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DgjBusqueda = New Janus.Windows.GridEX.GridEX()
        Me.Rl1Accion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabControl1.SuspendLayout()
        Me.SuperTabControlPanel2.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx5.SuspendLayout()
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgjDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmDetalleMov.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.JCb_Concepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JCb_Prod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBusqueda.SuspendLayout()
        CType(Me.DgjBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.SuperTabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabControl1.SelectedTabIndex = 1
        Me.SuperTabControl1.Size = New System.Drawing.Size(936, 676)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.GpBusqueda)
        Me.SuperTabControlPanel2.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanel2.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(936, 648)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(5)
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(936, 648)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.Rl1Accion)
        Me.PanelEx1.Controls.Add(Me.BubbleBar6)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx1.Size = New System.Drawing.Size(936, 79)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar1, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar2, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar6, 0)
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
        Me.BubbleBar1.Location = New System.Drawing.Point(775, 4)
        Me.BubbleBar1.Margin = New System.Windows.Forms.Padding(5)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(68, 75)
        Me.BubbleBar1.Visible = False
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
        Me.BubbleBar2.Location = New System.Drawing.Point(851, 0)
        Me.BubbleBar2.Margin = New System.Windows.Forms.Padding(5)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Controls.Add(Me.Lbl_SmsDown)
        Me.PanelEx2.Location = New System.Drawing.Point(0, 604)
        Me.PanelEx2.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx2.Size = New System.Drawing.Size(936, 44)
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
        Me.PanelEx2.Controls.SetChildIndex(Me.Lbl_SmsDown, 0)
        '
        'PanelEx3
        '
        Me.PanelEx3.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx3.Size = New System.Drawing.Size(936, 525)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx3.Style.BorderColor.Color = System.Drawing.Color.DarkSeaGreen
        Me.PanelEx3.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.PanelEx3.Style.BorderWidth = 2
        Me.PanelEx3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.Style.LineAlignment = System.Drawing.StringAlignment.Near
        Me.PanelEx3.TabIndex = 0
        '
        'PanelEx4
        '
        Me.PanelEx4.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx4.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelEx4.Size = New System.Drawing.Size(936, 648)
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
        Me.BubbleBar4.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBar4.Margin = New System.Windows.Forms.Padding(5)
        Me.BubbleBar4.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar4.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'Txt_Paginacion
        '
        Me.Txt_Paginacion.Location = New System.Drawing.Point(195, 7)
        Me.Txt_Paginacion.Margin = New System.Windows.Forms.Padding(5)
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
        Me.BubbleBar3.Dock = System.Windows.Forms.DockStyle.None
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
        Me.PanelEx5.Location = New System.Drawing.Point(669, 0)
        Me.PanelEx5.Margin = New System.Windows.Forms.Padding(5)
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
        'Ep1
        '
        Me.Ep1.ContainerControl = Me
        '
        'Tb_Id
        '
        Me.Tb_Id.Location = New System.Drawing.Point(144, 6)
        Me.Tb_Id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tb_Id.Name = "Tb_Id"
        Me.Tb_Id.ReadOnly = True
        Me.Tb_Id.Size = New System.Drawing.Size(132, 26)
        Me.Tb_Id.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rb_Inac)
        Me.GroupBox2.Controls.Add(Me.Rb_Act)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 113)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(111, 98)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado"
        Me.GroupBox2.Visible = False
        '
        'Rb_Inac
        '
        Me.Rb_Inac.AutoSize = True
        Me.Rb_Inac.Checked = True
        Me.Rb_Inac.Enabled = False
        Me.Rb_Inac.Location = New System.Drawing.Point(5, 55)
        Me.Rb_Inac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rb_Inac.Name = "Rb_Inac"
        Me.Rb_Inac.Size = New System.Drawing.Size(87, 24)
        Me.Rb_Inac.TabIndex = 1
        Me.Rb_Inac.TabStop = True
        Me.Rb_Inac.Text = "Inactivo"
        Me.Rb_Inac.UseVisualStyleBackColor = True
        '
        'Rb_Act
        '
        Me.Rb_Act.AutoSize = True
        Me.Rb_Act.Enabled = False
        Me.Rb_Act.Location = New System.Drawing.Point(5, 25)
        Me.Rb_Act.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Rb_Act.Name = "Rb_Act"
        Me.Rb_Act.Size = New System.Drawing.Size(76, 24)
        Me.Rb_Act.TabIndex = 0
        Me.Rb_Act.Text = "Activo"
        Me.Rb_Act.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DgjDetalle
        '
        Me.DgjDetalle.ContextMenuStrip = Me.CmDetalleMov
        DgjDetalle_DesignTimeLayout.LayoutString = resources.GetString("DgjDetalle_DesignTimeLayout.LayoutString")
        Me.DgjDetalle.DesignTimeLayout = DgjDetalle_DesignTimeLayout
        Me.DgjDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgjDetalle.Enabled = False
        Me.DgjDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgjDetalle.Location = New System.Drawing.Point(0, 0)
        Me.DgjDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DgjDetalle.Name = "DgjDetalle"
        Me.DgjDetalle.Size = New System.Drawing.Size(928, 281)
        Me.DgjDetalle.TabIndex = 0
        '
        'CmDetalleMov
        '
        Me.CmDetalleMov.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmDetalleMov.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem})
        Me.CmDetalleMov.Name = "CmDetalleMov"
        Me.CmDetalleMov.Size = New System.Drawing.Size(134, 40)
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.MENU_QUITAR
        Me.QuitarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(133, 36)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'Tb_Observacion
        '
        Me.Tb_Observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Tb_Observacion.Location = New System.Drawing.Point(144, 78)
        Me.Tb_Observacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Tb_Observacion.MaxLength = 40
        Me.Tb_Observacion.Name = "Tb_Observacion"
        Me.Tb_Observacion.ReadOnly = True
        Me.Tb_Observacion.Size = New System.Drawing.Size(665, 26)
        Me.Tb_Observacion.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tb_CodConcepto)
        Me.GroupBox1.Controls.Add(Me.JCb_Concepto)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.Bt_AyudaNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(277, 98)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Concepto"
        '
        'Tb_CodConcepto
        '
        Me.Tb_CodConcepto.Location = New System.Drawing.Point(55, 22)
        Me.Tb_CodConcepto.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_CodConcepto.Name = "Tb_CodConcepto"
        Me.Tb_CodConcepto.ReadOnly = True
        Me.Tb_CodConcepto.Size = New System.Drawing.Size(132, 26)
        Me.Tb_CodConcepto.TabIndex = 3
        '
        'JCb_Concepto
        '
        JCb_Concepto_DesignTimeLayout.LayoutString = resources.GetString("JCb_Concepto_DesignTimeLayout.LayoutString")
        Me.JCb_Concepto.DesignTimeLayout = JCb_Concepto_DesignTimeLayout
        Me.JCb_Concepto.Enabled = False
        Me.JCb_Concepto.Location = New System.Drawing.Point(8, 58)
        Me.JCb_Concepto.Margin = New System.Windows.Forms.Padding(4)
        Me.JCb_Concepto.Name = "JCb_Concepto"
        Me.JCb_Concepto.SelectedIndex = -1
        Me.JCb_Concepto.SelectedItem = Nothing
        Me.JCb_Concepto.Size = New System.Drawing.Size(180, 26)
        Me.JCb_Concepto.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX4.Location = New System.Drawing.Point(8, 22)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(39, 28)
        Me.LabelX4.TabIndex = 2
        Me.LabelX4.Text = "Cod."
        '
        'Bt_AyudaNuevo
        '
        Me.Bt_AyudaNuevo.BackgroundImage = CType(resources.GetObject("Bt_AyudaNuevo.BackgroundImage"), System.Drawing.Image)
        Me.Bt_AyudaNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bt_AyudaNuevo.Location = New System.Drawing.Point(204, 22)
        Me.Bt_AyudaNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Bt_AyudaNuevo.Name = "Bt_AyudaNuevo"
        Me.Bt_AyudaNuevo.Size = New System.Drawing.Size(59, 63)
        Me.Bt_AyudaNuevo.TabIndex = 1
        Me.Bt_AyudaNuevo.UseVisualStyleBackColor = True
        '
        'Tb_Fecha
        '
        Me.Tb_Fecha.Location = New System.Drawing.Point(144, 42)
        Me.Tb_Fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb_Fecha.Name = "Tb_Fecha"
        Me.Tb_Fecha.Size = New System.Drawing.Size(332, 26)
        Me.Tb_Fecha.TabIndex = 0
        '
        'JCb_Prod
        '
        JCb_Prod_DesignTimeLayout.LayoutString = resources.GetString("JCb_Prod_DesignTimeLayout.LayoutString")
        Me.JCb_Prod.DesignTimeLayout = JCb_Prod_DesignTimeLayout
        Me.JCb_Prod.Enabled = False
        Me.JCb_Prod.Location = New System.Drawing.Point(405, 113)
        Me.JCb_Prod.Margin = New System.Windows.Forms.Padding(4)
        Me.JCb_Prod.Name = "JCb_Prod"
        Me.JCb_Prod.SelectedIndex = -1
        Me.JCb_Prod.SelectedItem = Nothing
        Me.JCb_Prod.Size = New System.Drawing.Size(161, 26)
        Me.JCb_Prod.TabIndex = 4
        Me.JCb_Prod.Visible = False
        '
        'Lbl_SmsDown
        '
        '
        '
        '
        Me.Lbl_SmsDown.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Lbl_SmsDown.Location = New System.Drawing.Point(375, 5)
        Me.Lbl_SmsDown.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbl_SmsDown.Name = "Lbl_SmsDown"
        Me.Lbl_SmsDown.Size = New System.Drawing.Size(100, 28)
        Me.Lbl_SmsDown.TabIndex = 106
        Me.Lbl_SmsDown.Text = "Lbl_SmsDown"
        '
        'BubbleBar6
        '
        Me.BubbleBar6.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar6.AntiAlias = True
        Me.BubbleBar6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.BubbleBar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar6.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBar6.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar6.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar6.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar6.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar6.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar6.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar6.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar6.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar6.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar6.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar6.Dock = System.Windows.Forms.DockStyle.Left
        Me.BubbleBar6.ImageSizeLarge = New System.Drawing.Size(64, 64)
        Me.BubbleBar6.ImageSizeNormal = New System.Drawing.Size(48, 48)
        Me.BubbleBar6.Location = New System.Drawing.Point(0, 0)
        Me.BubbleBar6.Margin = New System.Windows.Forms.Padding(4)
        Me.BubbleBar6.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar6.Name = "BubbleBar6"
        Me.BubbleBar6.SelectedTab = Me.BubbleBarTab6
        Me.BubbleBar6.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar6.Size = New System.Drawing.Size(355, 79)
        Me.BubbleBar6.TabIndex = 6
        Me.BubbleBar6.Tabs.Add(Me.BubbleBarTab6)
        Me.BubbleBar6.TabsVisible = False
        Me.BubbleBar6.Text = "BubbleBar6"
        '
        'BubbleBarTab6
        '
        Me.BubbleBarTab6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab6.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bbtNuevo, Me.bbtModificar, Me.bbtEliminar, Me.bbtGrabar, Me.bbtSalir})
        Me.BubbleBarTab6.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab6.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab6.Name = "BubbleBarTab6"
        Me.BubbleBarTab6.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab6.Text = "BubbleBarTab1"
        Me.BubbleBarTab6.TextColor = System.Drawing.Color.Black
        '
        'bbtNuevo
        '
        Me.bbtNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bbtNuevo.Image = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.bbtNuevo.ImageLarge = Global.Presentacion.My.Resources.Resources.NUEVO
        Me.bbtNuevo.Name = "bbtNuevo"
        Me.bbtNuevo.TooltipText = "NUEVO"
        '
        'bbtModificar
        '
        Me.bbtModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bbtModificar.Image = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.bbtModificar.ImageLarge = Global.Presentacion.My.Resources.Resources.EDITAR
        Me.bbtModificar.Name = "bbtModificar"
        Me.bbtModificar.TooltipText = "MODIFICAR"
        '
        'bbtEliminar
        '
        Me.bbtEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bbtEliminar.Image = CType(resources.GetObject("bbtEliminar.Image"), System.Drawing.Image)
        Me.bbtEliminar.ImageLarge = CType(resources.GetObject("bbtEliminar.ImageLarge"), System.Drawing.Image)
        Me.bbtEliminar.Name = "bbtEliminar"
        Me.bbtEliminar.TooltipText = "ELIMINAR"
        '
        'bbtGrabar
        '
        Me.bbtGrabar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bbtGrabar.Enabled = False
        Me.bbtGrabar.Image = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.bbtGrabar.ImageLarge = Global.Presentacion.My.Resources.Resources.GRABAR
        Me.bbtGrabar.Name = "bbtGrabar"
        Me.bbtGrabar.TooltipText = "GRABAR"
        '
        'bbtSalir
        '
        Me.bbtSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bbtSalir.Image = CType(resources.GetObject("bbtSalir.Image"), System.Drawing.Image)
        Me.bbtSalir.ImageLarge = CType(resources.GetObject("bbtSalir.ImageLarge"), System.Drawing.Image)
        Me.bbtSalir.Name = "bbtSalir"
        Me.bbtSalir.TooltipText = "CANCELAR"
        '
        'GpBusqueda
        '
        Me.GpBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpBusqueda.Controls.Add(Me.DgjBusqueda)
        Me.GpBusqueda.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.GpBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.GpBusqueda.Name = "GpBusqueda"
        Me.GpBusqueda.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.GpBusqueda.Size = New System.Drawing.Size(936, 648)
        '
        '
        '
        Me.GpBusqueda.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpBusqueda.Style.BackColorGradientAngle = 90
        Me.GpBusqueda.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpBusqueda.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpBusqueda.Style.BorderBottomWidth = 1
        Me.GpBusqueda.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpBusqueda.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpBusqueda.Style.BorderLeftWidth = 1
        Me.GpBusqueda.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpBusqueda.Style.BorderRightWidth = 1
        Me.GpBusqueda.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpBusqueda.Style.BorderTopWidth = 1
        Me.GpBusqueda.Style.CornerDiameter = 4
        Me.GpBusqueda.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpBusqueda.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpBusqueda.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpBusqueda.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpBusqueda.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpBusqueda.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpBusqueda.TabIndex = 0
        Me.GpBusqueda.Text = "Busqueda"
        '
        'DgjBusqueda
        '
        Me.DgjBusqueda.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.DgjBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgjBusqueda.Location = New System.Drawing.Point(7, 6)
        Me.DgjBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.DgjBusqueda.Name = "DgjBusqueda"
        Me.DgjBusqueda.Size = New System.Drawing.Size(916, 613)
        Me.DgjBusqueda.TabIndex = 0
        '
        'Rl1Accion
        '
        '
        '
        '
        Me.Rl1Accion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Rl1Accion.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rl1Accion.ForeColor = System.Drawing.Color.White
        Me.Rl1Accion.Location = New System.Drawing.Point(400, 2)
        Me.Rl1Accion.Margin = New System.Windows.Forms.Padding(4)
        Me.Rl1Accion.Name = "Rl1Accion"
        Me.Rl1Accion.Size = New System.Drawing.Size(400, 74)
        Me.Rl1Accion.TabIndex = 8
        Me.Rl1Accion.Text = "<b><font size=""+10""><font color=""#FF0000""></font></font></b>"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX1.Location = New System.Drawing.Point(4, 6)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(133, 28)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Código Interno:"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX2.Location = New System.Drawing.Point(4, 42)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(133, 28)
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Fecha:"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelX3.Location = New System.Drawing.Point(4, 78)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(133, 28)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Observación:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 525)
        Me.TableLayoutPanel1.TabIndex = 107
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelX2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Tb_Id)
        Me.Panel1.Controls.Add(Me.JCb_Prod)
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Tb_Observacion)
        Me.Panel1.Controls.Add(Me.LabelX1)
        Me.Panel1.Controls.Add(Me.Tb_Fecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 228)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DgjDetalle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(4, 240)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(928, 281)
        Me.Panel2.TabIndex = 5
        '
        'P_Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 676)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "P_Movimientos"
        Me.Text = "Movimientos"
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
        CType(Me.BubbleBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        CType(Me.Ep1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgjDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmDetalleMov.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.JCb_Concepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JCb_Prod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBusqueda.ResumeLayout(False)
        CType(Me.DgjBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ep1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Tb_Id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Inac As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Act As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DgjDetalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents Tb_Observacion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_CodConcepto As System.Windows.Forms.TextBox
    Friend WithEvents JCb_Concepto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Bt_AyudaNuevo As System.Windows.Forms.Button
    Friend WithEvents Tb_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents JCb_Prod As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Lbl_SmsDown As DevComponents.DotNetBar.LabelX
    Protected WithEvents BubbleBar6 As DevComponents.DotNetBar.BubbleBar
    Protected WithEvents BubbleBarTab6 As DevComponents.DotNetBar.BubbleBarTab
    Protected WithEvents bbtNuevo As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtModificar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtEliminar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtGrabar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtSalir As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents GpBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DgjBusqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents Rl1Accion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents CmDetalleMov As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
