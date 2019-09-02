<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_DescuentosFijos
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
        Dim JMc_Persona_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_DescuentosFijos))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Id = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_TipoMov = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Tb_Valor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Tb_Observacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.JMc_Persona = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.HighLigthter_Focus = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.JGr_Buscador = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tbFechaVenci = New System.Windows.Forms.DateTimePicker()
        Me.tbVencimiento = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.BubbleBar6 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab6 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbtNuevo = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtModificar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtEliminar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtGrabar = New DevComponents.DotNetBar.BubbleButton()
        Me.bbtSalir = New DevComponents.DotNetBar.BubbleButton()
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
        CType(Me.JMc_Persona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.BubbleBar6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.BubbleBar6)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar2, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar6, 0)
        Me.PanelEx1.Controls.SetChildIndex(Me.BubbleBar1, 0)
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
        Me.BubbleBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BubbleBar1.Location = New System.Drawing.Point(266, 0)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(266, 64)
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
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
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
        Me.PanelEx3.Controls.Add(Me.JMc_Persona)
        Me.PanelEx3.Controls.Add(Me.Tb_Observacion)
        Me.PanelEx3.Controls.Add(Me.LabelX4)
        Me.PanelEx3.Controls.Add(Me.LabelX3)
        Me.PanelEx3.Controls.Add(Me.Tb_Valor)
        Me.PanelEx3.Controls.Add(Me.Tb_TipoMov)
        Me.PanelEx3.Controls.Add(Me.LabelX2)
        Me.PanelEx3.Controls.Add(Me.Tb_Id)
        Me.PanelEx3.Controls.Add(Me.LabelX1)
        Me.PanelEx3.Size = New System.Drawing.Size(884, 258)
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
        Me.PanelEx4.Controls.Add(Me.JGr_Buscador)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 322)
        Me.PanelEx4.Size = New System.Drawing.Size(884, 178)
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
        Me.Txt_NombreUsu.ReadOnly = True
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
        Me.LabelX1.Location = New System.Drawing.Point(50, 30)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(104, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "CODIGO:"
        '
        'Tb_Id
        '
        '
        '
        '
        Me.Tb_Id.Border.Class = "TextBoxBorder"
        Me.Tb_Id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Id.Location = New System.Drawing.Point(161, 30)
        Me.Tb_Id.Name = "Tb_Id"
        Me.Tb_Id.PreventEnterBeep = True
        Me.Tb_Id.Size = New System.Drawing.Size(112, 20)
        Me.Tb_Id.TabIndex = 2
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(50, 69)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(104, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "MOVIMIENTO:"
        '
        'Tb_TipoMov
        '
        '
        '
        '
        Me.Tb_TipoMov.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_TipoMov.Location = New System.Drawing.Point(162, 69)
        Me.Tb_TipoMov.Name = "Tb_TipoMov"
        Me.Tb_TipoMov.OffText = "PORCENTAJE"
        Me.Tb_TipoMov.OnText = "MONTO"
        Me.Tb_TipoMov.Size = New System.Drawing.Size(155, 22)
        Me.Tb_TipoMov.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Tb_TipoMov.TabIndex = 4
        '
        'Tb_Valor
        '
        '
        '
        '
        Me.Tb_Valor.Border.Class = "TextBoxBorder"
        Me.Tb_Valor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Valor.Location = New System.Drawing.Point(323, 72)
        Me.Tb_Valor.Name = "Tb_Valor"
        Me.Tb_Valor.PreventEnterBeep = True
        Me.Tb_Valor.Size = New System.Drawing.Size(137, 20)
        Me.Tb_Valor.TabIndex = 5
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(50, 107)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(104, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "PERSONA:"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(50, 145)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(104, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "OBS.:"
        '
        'Tb_Observacion
        '
        '
        '
        '
        Me.Tb_Observacion.Border.Class = "TextBoxBorder"
        Me.Tb_Observacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb_Observacion.Location = New System.Drawing.Point(161, 145)
        Me.Tb_Observacion.Name = "Tb_Observacion"
        Me.Tb_Observacion.PreventEnterBeep = True
        Me.Tb_Observacion.Size = New System.Drawing.Size(299, 20)
        Me.Tb_Observacion.TabIndex = 8
        '
        'JMc_Persona
        '
        JMc_Persona_DesignTimeLayout.LayoutString = resources.GetString("JMc_Persona_DesignTimeLayout.LayoutString")
        Me.JMc_Persona.DesignTimeLayout = JMc_Persona_DesignTimeLayout
        Me.JMc_Persona.Location = New System.Drawing.Point(162, 109)
        Me.JMc_Persona.Name = "JMc_Persona"
        Me.JMc_Persona.SelectedIndex = -1
        Me.JMc_Persona.SelectedItem = Nothing
        Me.JMc_Persona.Size = New System.Drawing.Size(298, 20)
        Me.JMc_Persona.TabIndex = 9
        '
        'HighLigthter_Focus
        '
        Me.HighLigthter_Focus.ContainerControl = Me
        '
        'JGr_Buscador
        '
        Me.JGr_Buscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JGr_Buscador.Location = New System.Drawing.Point(0, 0)
        Me.JGr_Buscador.Name = "JGr_Buscador"
        Me.JGr_Buscador.Size = New System.Drawing.Size(884, 178)
        Me.JGr_Buscador.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.tbFechaVenci)
        Me.GroupPanel1.Controls.Add(Me.tbVencimiento)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(50, 175)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(262, 57)
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
        Me.GroupPanel1.TabIndex = 10
        Me.GroupPanel1.Text = "VENCIMIENTO"
        '
        'tbFechaVenci
        '
        Me.tbFechaVenci.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tbFechaVenci.Location = New System.Drawing.Point(99, 8)
        Me.tbFechaVenci.Name = "tbFechaVenci"
        Me.tbFechaVenci.Size = New System.Drawing.Size(147, 20)
        Me.tbFechaVenci.TabIndex = 1
        '
        'tbVencimiento
        '
        '
        '
        '
        Me.tbVencimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbVencimiento.Location = New System.Drawing.Point(3, 5)
        Me.tbVencimiento.Name = "tbVencimiento"
        Me.tbVencimiento.Size = New System.Drawing.Size(86, 25)
        Me.tbVencimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbVencimiento.TabIndex = 0
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
        Me.BubbleBar6.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar6.Name = "BubbleBar6"
        Me.BubbleBar6.SelectedTab = Me.BubbleBarTab6
        Me.BubbleBar6.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar6.Size = New System.Drawing.Size(266, 64)
        Me.BubbleBar6.TabIndex = 5
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
        'PanelUsuario
        '
        Me.PanelUsuario.Controls.Add(Me.lbHora)
        Me.PanelUsuario.Controls.Add(Me.lbFecha)
        Me.PanelUsuario.Controls.Add(Me.lbUsuario)
        Me.PanelUsuario.Controls.Add(Me.Label3)
        Me.PanelUsuario.Controls.Add(Me.Label2)
        Me.PanelUsuario.Controls.Add(Me.Label1)
        Me.PanelUsuario.Location = New System.Drawing.Point(564, 65)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(220, 100)
        Me.PanelUsuario.TabIndex = 6
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
        'P_DescuentosFijos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Name = "P_DescuentosFijos"
        Me.Text = "P_DescuentosFijos"
        CType(Me.SuperTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabControl1.ResumeLayout(False)
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
        CType(Me.JMc_Persona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JGr_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.BubbleBar6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents JMc_Persona As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents Tb_Observacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Valor As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Tb_TipoMov As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Tb_Id As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents HighLigthter_Focus As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents JGr_Buscador As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tbFechaVenci As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbVencimiento As DevComponents.DotNetBar.Controls.SwitchButton
    Protected WithEvents BubbleBar6 As DevComponents.DotNetBar.BubbleBar
    Protected WithEvents BubbleBarTab6 As DevComponents.DotNetBar.BubbleBarTab
    Protected WithEvents bbtNuevo As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtModificar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtEliminar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtGrabar As DevComponents.DotNetBar.BubbleButton
    Protected WithEvents bbtSalir As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents PanelUsuario As System.Windows.Forms.Panel
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlyoutUsuario As DevComponents.DotNetBar.Controls.Flyout
End Class
