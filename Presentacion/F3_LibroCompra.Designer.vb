<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F3_LibroCompra
    Inherits Modelos.ModeloF3

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
        Dim cbMes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F3_LibroCompra))
        Dim cbAno_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GroupPanelLibroCompra = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjLibroCompra = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanelDatosGenerales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbMes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.cbAno = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanelAccion = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.CpExportarExcel = New DevComponents.DotNetBar.Controls.CircularProgress()
        Me.btTxt = New DevComponents.DotNetBar.ButtonX()
        Me.btExcel = New DevComponents.DotNetBar.ButtonX()
        Me.btReporte = New DevComponents.DotNetBar.ButtonX()
        Me.btGenerar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelLibroCompra.SuspendLayout()
        CType(Me.dgjLibroCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelDatosGenerales.SuspendLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanelAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Blue
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Blue
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.GroupPanelLibroCompra)
        Me.PanelPrincipal.Controls.Add(Me.GroupPanelDatosGenerales)
        Me.PanelPrincipal.Controls.Add(Me.GroupPanelAccion)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.GroupPanelAccion, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.GroupPanelDatosGenerales, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.GroupPanelLibroCompra, 0)
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MRlAccion.Location = New System.Drawing.Point(275, 6)
        Me.MRlAccion.Size = New System.Drawing.Size(500, 60)
        '
        'GroupPanelLibroCompra
        '
        Me.GroupPanelLibroCompra.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelLibroCompra.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelLibroCompra.Controls.Add(Me.dgjLibroCompra)
        Me.GroupPanelLibroCompra.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelLibroCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanelLibroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelLibroCompra.Location = New System.Drawing.Point(0, 59)
        Me.GroupPanelLibroCompra.Name = "GroupPanelLibroCompra"
        Me.GroupPanelLibroCompra.Size = New System.Drawing.Size(695, 369)
        '
        '
        '
        Me.GroupPanelLibroCompra.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelLibroCompra.Style.BackColorGradientAngle = 90
        Me.GroupPanelLibroCompra.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelLibroCompra.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelLibroCompra.Style.BorderBottomWidth = 1
        Me.GroupPanelLibroCompra.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelLibroCompra.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelLibroCompra.Style.BorderLeftWidth = 1
        Me.GroupPanelLibroCompra.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelLibroCompra.Style.BorderRightWidth = 1
        Me.GroupPanelLibroCompra.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelLibroCompra.Style.BorderTopWidth = 1
        Me.GroupPanelLibroCompra.Style.CornerDiameter = 4
        Me.GroupPanelLibroCompra.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelLibroCompra.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelLibroCompra.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelLibroCompra.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelLibroCompra.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelLibroCompra.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelLibroCompra.TabIndex = 21
        Me.GroupPanelLibroCompra.Text = "LIBRO DE COMPRA"
        '
        'dgjLibroCompra
        '
        Me.dgjLibroCompra.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dgjLibroCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjLibroCompra.Location = New System.Drawing.Point(0, 0)
        Me.dgjLibroCompra.Name = "dgjLibroCompra"
        Me.dgjLibroCompra.Size = New System.Drawing.Size(689, 347)
        Me.dgjLibroCompra.TabIndex = 0
        '
        'GroupPanelDatosGenerales
        '
        Me.GroupPanelDatosGenerales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelDatosGenerales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelDatosGenerales.Controls.Add(Me.cbMes)
        Me.GroupPanelDatosGenerales.Controls.Add(Me.cbAno)
        Me.GroupPanelDatosGenerales.Controls.Add(Me.LabelX3)
        Me.GroupPanelDatosGenerales.Controls.Add(Me.LabelX2)
        Me.GroupPanelDatosGenerales.Controls.Add(Me.LabelX1)
        Me.GroupPanelDatosGenerales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupPanelDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanelDatosGenerales.Name = "GroupPanelDatosGenerales"
        Me.GroupPanelDatosGenerales.Size = New System.Drawing.Size(695, 59)
        '
        '
        '
        Me.GroupPanelDatosGenerales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelDatosGenerales.Style.BackColorGradientAngle = 90
        Me.GroupPanelDatosGenerales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelDatosGenerales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderBottomWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelDatosGenerales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderLeftWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderRightWidth = 1
        Me.GroupPanelDatosGenerales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelDatosGenerales.Style.BorderTopWidth = 1
        Me.GroupPanelDatosGenerales.Style.CornerDiameter = 4
        Me.GroupPanelDatosGenerales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelDatosGenerales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelDatosGenerales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelDatosGenerales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelDatosGenerales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelDatosGenerales.TabIndex = 20
        Me.GroupPanelDatosGenerales.Text = "DATOS GENERALES"
        '
        'cbMes
        '
        cbMes_DesignTimeLayout.LayoutString = resources.GetString("cbMes_DesignTimeLayout.LayoutString")
        Me.cbMes.DesignTimeLayout = cbMes_DesignTimeLayout
        Me.cbMes.DisplayMember = "sdfg"
        Me.cbMes.Location = New System.Drawing.Point(314, 5)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.SelectedIndex = -1
        Me.cbMes.SelectedItem = Nothing
        Me.cbMes.Size = New System.Drawing.Size(200, 21)
        Me.cbMes.TabIndex = 6
        Me.cbMes.ValueMember = "sdfg"
        '
        'cbAno
        '
        cbAno_DesignTimeLayout.LayoutString = resources.GetString("cbAno_DesignTimeLayout.LayoutString")
        Me.cbAno.DesignTimeLayout = cbAno_DesignTimeLayout
        Me.cbAno.Location = New System.Drawing.Point(167, 5)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.SelectedIndex = -1
        Me.cbAno.SelectedItem = Nothing
        Me.cbAno.Size = New System.Drawing.Size(100, 21)
        Me.cbAno.TabIndex = 5
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.BackgroundStyle.BackColor2 = System.Drawing.Color.Transparent
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(233, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 23)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "Mes:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.BackgroundStyle.BackColor2 = System.Drawing.Color.Transparent
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(86, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Año:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.BackgroundStyle.BackColor2 = System.Drawing.Color.Transparent
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(5, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Periodo:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanelAccion
        '
        Me.GroupPanelAccion.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanelAccion.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanelAccion.Controls.Add(Me.CpExportarExcel)
        Me.GroupPanelAccion.Controls.Add(Me.btTxt)
        Me.GroupPanelAccion.Controls.Add(Me.btExcel)
        Me.GroupPanelAccion.Controls.Add(Me.btReporte)
        Me.GroupPanelAccion.Controls.Add(Me.btGenerar)
        Me.GroupPanelAccion.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanelAccion.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupPanelAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelAccion.Location = New System.Drawing.Point(695, 0)
        Me.GroupPanelAccion.Name = "GroupPanelAccion"
        Me.GroupPanelAccion.Size = New System.Drawing.Size(189, 428)
        '
        '
        '
        Me.GroupPanelAccion.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanelAccion.Style.BackColorGradientAngle = 90
        Me.GroupPanelAccion.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanelAccion.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelAccion.Style.BorderBottomWidth = 1
        Me.GroupPanelAccion.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanelAccion.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelAccion.Style.BorderLeftWidth = 1
        Me.GroupPanelAccion.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelAccion.Style.BorderRightWidth = 1
        Me.GroupPanelAccion.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelAccion.Style.BorderTopWidth = 1
        Me.GroupPanelAccion.Style.CornerDiameter = 4
        Me.GroupPanelAccion.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelAccion.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelAccion.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanelAccion.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelAccion.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelAccion.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelAccion.TabIndex = 22
        Me.GroupPanelAccion.Text = "ACCION"
        '
        'CpExportarExcel
        '
        '
        '
        '
        Me.CpExportarExcel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CpExportarExcel.Location = New System.Drawing.Point(18, 229)
        Me.CpExportarExcel.Name = "CpExportarExcel"
        Me.CpExportarExcel.PieBorderLight = System.Drawing.Color.Yellow
        Me.CpExportarExcel.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Spoke
        Me.CpExportarExcel.ProgressColor = System.Drawing.Color.Green
        Me.CpExportarExcel.ProgressText = "Trabajando"
        Me.CpExportarExcel.ProgressTextColor = System.Drawing.Color.Black
        Me.CpExportarExcel.ProgressTextVisible = True
        Me.CpExportarExcel.Size = New System.Drawing.Size(150, 150)
        Me.CpExportarExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CpExportarExcel.TabIndex = 4
        '
        'btTxt
        '
        Me.btTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btTxt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btTxt.Image = Global.Presentacion.My.Resources.Resources.TXT
        Me.btTxt.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btTxt.Location = New System.Drawing.Point(18, 173)
        Me.btTxt.Name = "btTxt"
        Me.btTxt.Size = New System.Drawing.Size(150, 50)
        Me.btTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btTxt.TabIndex = 3
        Me.btTxt.Text = "Archivo de Txt"
        '
        'btExcel
        '
        Me.btExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btExcel.Image = Global.Presentacion.My.Resources.Resources.EXCEL
        Me.btExcel.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btExcel.Location = New System.Drawing.Point(18, 61)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(150, 50)
        Me.btExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btExcel.TabIndex = 2
        Me.btExcel.Text = "Excel"
        '
        'btReporte
        '
        Me.btReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btReporte.Image = Global.Presentacion.My.Resources.Resources.BARRAS
        Me.btReporte.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btReporte.Location = New System.Drawing.Point(18, 117)
        Me.btReporte.Name = "btReporte"
        Me.btReporte.Size = New System.Drawing.Size(150, 50)
        Me.btReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btReporte.TabIndex = 1
        Me.btReporte.Text = "Reporte"
        '
        'btGenerar
        '
        Me.btGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGenerar.Image = Global.Presentacion.My.Resources.Resources.generarReporte2
        Me.btGenerar.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.btGenerar.Location = New System.Drawing.Point(18, 5)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(150, 50)
        Me.btGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGenerar.TabIndex = 0
        Me.btGenerar.Text = "Generar"
        '
        'F3_LibroCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Name = "F3_LibroCompra"
        Me.Text = "F3_LibroCompra"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelLibroCompra.ResumeLayout(False)
        CType(Me.dgjLibroCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelDatosGenerales.ResumeLayout(False)
        Me.GroupPanelDatosGenerales.PerformLayout()
        CType(Me.cbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanelAccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanelLibroCompra As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanelDatosGenerales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanelAccion As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btTxt As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btExcel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btReporte As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgjLibroCompra As Janus.Windows.GridEX.GridEX
    Friend WithEvents cbMes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents cbAno As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents CpExportarExcel As DevComponents.DotNetBar.Controls.CircularProgress
End Class
