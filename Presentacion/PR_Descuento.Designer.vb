<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PR_Descuento
    Inherits System.Windows.Forms.Form

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
        Dim cbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim cbTipo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PR_Descuento))
        Me.Gp_Filtros = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.swTodos = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmpleados = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtAño = New DevComponents.Editors.IntegerInput()
        Me.cbMes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.Bbtn_GenerarReporte = New DevComponents.DotNetBar.BubbleButton()
        Me.Bbtn_Cancelar = New DevComponents.DotNetBar.BubbleButton()
        Me.Crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbTipo = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.Gp_Filtros.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.txtAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gp_Filtros
        '
        Me.Gp_Filtros.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp_Filtros.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel1)
        Me.Gp_Filtros.Controls.Add(Me.GroupPanel2)
        Me.Gp_Filtros.Controls.Add(Me.BubbleBar1)
        Me.Gp_Filtros.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp_Filtros.Dock = System.Windows.Forms.DockStyle.Left
        Me.Gp_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.Gp_Filtros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Gp_Filtros.Name = "Gp_Filtros"
        Me.Gp_Filtros.Size = New System.Drawing.Size(303, 553)
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
        Me.GroupPanel1.Controls.Add(Me.cbTipo)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.swTodos)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.txtEmpleados)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 97)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(297, 149)
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
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(4, 78)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(93, 28)
        Me.LabelX3.TabIndex = 15
        Me.LabelX3.Text = "Tipo:"
        '
        'swTodos
        '
        '
        '
        '
        Me.swTodos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swTodos.Location = New System.Drawing.Point(119, 4)
        Me.swTodos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.swTodos.Name = "swTodos"
        Me.swTodos.OffText = "TODOS"
        Me.swTodos.OnText = "UNO"
        Me.swTodos.Size = New System.Drawing.Size(160, 27)
        Me.swTodos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swTodos.TabIndex = 13
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(0, 2)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(111, 28)
        Me.LabelX4.TabIndex = 12
        Me.LabelX4.Text = "FILTRAR POR :"
        '
        'txtEmpleados
        '
        '
        '
        '
        Me.txtEmpleados.Border.Class = "TextBoxBorder"
        Me.txtEmpleados.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmpleados.Enabled = False
        Me.txtEmpleados.Location = New System.Drawing.Point(0, 36)
        Me.txtEmpleados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmpleados.Name = "txtEmpleados"
        Me.txtEmpleados.PreventEnterBeep = True
        Me.txtEmpleados.Size = New System.Drawing.Size(279, 22)
        Me.txtEmpleados.TabIndex = 11
        Me.txtEmpleados.WatermarkText = "Empleados (Crtl + Enter )"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.txtAño)
        Me.GroupPanel2.Controls.Add(Me.cbMes)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(297, 97)
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
        Me.GroupPanel2.Text = "FECHA"
        '
        'txtAño
        '
        '
        '
        '
        Me.txtAño.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAño.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtAño.Location = New System.Drawing.Point(132, 4)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAño.MaxValue = 2099
        Me.txtAño.MinValue = 2000
        Me.txtAño.Name = "txtAño"
        Me.txtAño.ShowUpDown = True
        Me.txtAño.Size = New System.Drawing.Size(147, 22)
        Me.txtAño.TabIndex = 14
        Me.txtAño.Value = 2000
        Me.txtAño.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        Me.txtAño.WatermarkText = "Año"
        '
        'cbMes
        '
        cbMes_DesignTimeLayout.LayoutString = resources.GetString("cbMes_DesignTimeLayout.LayoutString")
        Me.cbMes.DesignTimeLayout = cbMes_DesignTimeLayout
        Me.cbMes.Location = New System.Drawing.Point(135, 34)
        Me.cbMes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.SelectedIndex = -1
        Me.cbMes.SelectedItem = Nothing
        Me.cbMes.Size = New System.Drawing.Size(144, 22)
        Me.cbMes.TabIndex = 15
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(43, 28)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 28)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "MES:"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(45, 0)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(83, 28)
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "AÑO:"
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
        Me.BubbleBar1.Location = New System.Drawing.Point(20, 398)
        Me.BubbleBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(263, 98)
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
        'Crv
        '
        Me.Crv.ActiveViewIndex = -1
        Me.Crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.Crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Crv.Location = New System.Drawing.Point(303, 0)
        Me.Crv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Crv.Name = "Crv"
        Me.Crv.Size = New System.Drawing.Size(560, 553)
        Me.Crv.TabIndex = 5
        Me.Crv.ToolPanelWidth = 267
        '
        'cbTipo
        '
        cbTipo_DesignTimeLayout.LayoutString = resources.GetString("cbTipo_DesignTimeLayout.LayoutString")
        Me.cbTipo.DesignTimeLayout = cbTipo_DesignTimeLayout
        Me.cbTipo.Location = New System.Drawing.Point(119, 80)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.SelectedIndex = -1
        Me.cbTipo.SelectedItem = Nothing
        Me.cbTipo.Size = New System.Drawing.Size(160, 22)
        Me.cbTipo.TabIndex = 6
        '
        'PR_Descuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 553)
        Me.Controls.Add(Me.Crv)
        Me.Controls.Add(Me.Gp_Filtros)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PR_Descuento"
        Me.Text = "PR_Clientes"
        Me.Gp_Filtros.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        CType(Me.txtAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gp_Filtros As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents swTodos As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEmpleados As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents Bbtn_GenerarReporte As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Bbtn_Cancelar As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAño As DevComponents.Editors.IntegerInput
    Friend WithEvents cbMes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbTipo As Janus.Windows.GridEX.EditControls.MultiColumnCombo
End Class
