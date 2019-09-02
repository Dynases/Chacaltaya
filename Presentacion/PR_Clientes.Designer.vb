<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PR_Clientes
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
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.tbCatCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swCategoria = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.tbCatDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbCatId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.swZona = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.tbZonaDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbZonaCod = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.Gp_Fechas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.rbTodos = New System.Windows.Forms.RadioButton()
        Me.rbPasivo = New System.Windows.Forms.RadioButton()
        Me.rbAct = New System.Windows.Forms.RadioButton()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Gp_Filtros.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Fechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel1)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel2)
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.Controls.Add(Me.Gp_Fechas)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Filtros.Name = "Gp_Filtros"
        Me.Gp_Filtros.Size = New System.Drawing.Size(227, 449)
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
        Me.Gp_Filtros.TabIndex = 4
        Me.Gp_Filtros.Text = "FILTROS"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.tbCatCod)
        Me.GroupPanel1.Controls.Add(Me.swCategoria)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.tbCatDesc)
        Me.GroupPanel1.Controls.Add(Me.tbCatId)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 186)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(221, 121)
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
        Me.GroupPanel1.TabIndex = 12
        Me.GroupPanel1.Text = "CATEGORIA"
        '
        'tbCatCod
        '
        '
        '
        '
        Me.tbCatCod.Border.Class = "TextBoxBorder"
        Me.tbCatCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCatCod.Location = New System.Drawing.Point(79, 38)
        Me.tbCatCod.Name = "tbCatCod"
        Me.tbCatCod.PreventEnterBeep = True
        Me.tbCatCod.Size = New System.Drawing.Size(62, 20)
        Me.tbCatCod.TabIndex = 14
        '
        'swCategoria
        '
        '
        '
        '
        Me.swCategoria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swCategoria.Location = New System.Drawing.Point(75, 4)
        Me.swCategoria.Name = "swCategoria"
        Me.swCategoria.Size = New System.Drawing.Size(66, 22)
        Me.swCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swCategoria.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(6, 3)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(62, 23)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "FILTRAR:"
        '
        'tbCatDesc
        '
        '
        '
        '
        Me.tbCatDesc.Border.Class = "TextBoxBorder"
        Me.tbCatDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCatDesc.Location = New System.Drawing.Point(6, 64)
        Me.tbCatDesc.Name = "tbCatDesc"
        Me.tbCatDesc.PreventEnterBeep = True
        Me.tbCatDesc.Size = New System.Drawing.Size(135, 20)
        Me.tbCatDesc.TabIndex = 11
        '
        'tbCatId
        '
        '
        '
        '
        Me.tbCatId.Border.Class = "TextBoxBorder"
        Me.tbCatId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCatId.Location = New System.Drawing.Point(6, 38)
        Me.tbCatId.Name = "tbCatId"
        Me.tbCatId.PreventEnterBeep = True
        Me.tbCatId.Size = New System.Drawing.Size(62, 20)
        Me.tbCatId.TabIndex = 10
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.swZona)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.tbZonaDesc)
        Me.GroupPanel2.Controls.Add(Me.tbZonaCod)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 65)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(221, 121)
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
        Me.GroupPanel2.TabIndex = 13
        Me.GroupPanel2.Text = "ZONA"
        '
        'swZona
        '
        '
        '
        '
        Me.swZona.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swZona.Location = New System.Drawing.Point(75, 4)
        Me.swZona.Name = "swZona"
        Me.swZona.Size = New System.Drawing.Size(66, 22)
        Me.swZona.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swZona.TabIndex = 13
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(6, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(62, 23)
        Me.LabelX5.TabIndex = 12
        Me.LabelX5.Text = "FILTRAR:"
        '
        'tbZonaDesc
        '
        '
        '
        '
        Me.tbZonaDesc.Border.Class = "TextBoxBorder"
        Me.tbZonaDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbZonaDesc.Location = New System.Drawing.Point(6, 64)
        Me.tbZonaDesc.Name = "tbZonaDesc"
        Me.tbZonaDesc.PreventEnterBeep = True
        Me.tbZonaDesc.Size = New System.Drawing.Size(135, 20)
        Me.tbZonaDesc.TabIndex = 11
        '
        'tbZonaCod
        '
        '
        '
        '
        Me.tbZonaCod.Border.Class = "TextBoxBorder"
        Me.tbZonaCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbZonaCod.Location = New System.Drawing.Point(6, 38)
        Me.tbZonaCod.Name = "tbZonaCod"
        Me.tbZonaCod.PreventEnterBeep = True
        Me.tbZonaCod.Size = New System.Drawing.Size(62, 20)
        Me.tbZonaCod.TabIndex = 10
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
        Me.BubbleBar1.Location = New System.Drawing.Point(15, 323)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(197, 80)
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
        'Gp_Fechas
        '
        Me.Gp_Fechas.BackColor = System.Drawing.Color.Transparent
        Me.Gp_Fechas.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Fechas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Fechas.Controls.Add(Me.rbTodos)
        Me.Gp_Fechas.Controls.Add(Me.rbPasivo)
        Me.Gp_Fechas.Controls.Add(Me.rbAct)
        Me.Gp_Fechas.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Fechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gp_Fechas.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Fechas.Name = "Gp_Fechas"
        Me.Gp_Fechas.Size = New System.Drawing.Size(221, 65)
        '
        '
        '
        Me.Gp_Fechas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp_Fechas.Style.BackColorGradientAngle = 90
        Me.Gp_Fechas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp_Fechas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderBottomWidth = 1
        Me.Gp_Fechas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp_Fechas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderLeftWidth = 1
        Me.Gp_Fechas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderRightWidth = 1
        Me.Gp_Fechas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp_Fechas.Style.BorderTopWidth = 1
        Me.Gp_Fechas.Style.CornerDiameter = 4
        Me.Gp_Fechas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp_Fechas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp_Fechas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp_Fechas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp_Fechas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp_Fechas.TabIndex = 9
        Me.Gp_Fechas.Text = "ESTADO"
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.ForeColor = System.Drawing.Color.Navy
        Me.rbTodos.Location = New System.Drawing.Point(146, 12)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(63, 17)
        Me.rbTodos.TabIndex = 2
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "TODOS"
        Me.rbTodos.UseVisualStyleBackColor = True
        '
        'rbPasivo
        '
        Me.rbPasivo.AutoSize = True
        Me.rbPasivo.ForeColor = System.Drawing.Color.Navy
        Me.rbPasivo.Location = New System.Drawing.Point(76, 12)
        Me.rbPasivo.Name = "rbPasivo"
        Me.rbPasivo.Size = New System.Drawing.Size(64, 17)
        Me.rbPasivo.TabIndex = 1
        Me.rbPasivo.TabStop = True
        Me.rbPasivo.Text = "PASIVO"
        Me.rbPasivo.UseVisualStyleBackColor = True
        '
        'rbAct
        '
        Me.rbAct.AutoSize = True
        Me.rbAct.ForeColor = System.Drawing.Color.Navy
        Me.rbAct.Location = New System.Drawing.Point(6, 12)
        Me.rbAct.Name = "rbAct"
        Me.rbAct.Size = New System.Drawing.Size(64, 17)
        Me.rbAct.TabIndex = 0
        Me.rbAct.TabStop = True
        Me.rbAct.Text = "ACTIVO"
        Me.rbAct.UseVisualStyleBackColor = True
        '
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(227, 0)
        Me.Crv.Name = "Crv"
        Me.Crv.Size = New System.Drawing.Size(420, 449)
        Me.Crv.TabIndex = 5
        '
        'PR_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 449)
        Me.Controls.Add(Me.Crv)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Name = "PR_Clientes"
        Me.Text = "PR_Clientes"
        Me.Gp_Filtros.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Fechas.ResumeLayout(False)
        Me.Gp_Fechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swZona As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbZonaDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbZonaCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swCategoria As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCatDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbCatId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Gp_Fechas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbPasivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbAct As System.Windows.Forms.RadioButton
    Friend WithEvents tbCatCod As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
