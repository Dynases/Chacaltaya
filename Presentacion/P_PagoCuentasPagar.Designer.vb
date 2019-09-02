<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PagoCuentasPagar
    Inherits Modelos.ModeloF0

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim CbProveedor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_PagoCuentasPagar))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RlAccion = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.DgdCuentasPagar = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.DgvCuentasPagar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CmsCuentasPagarME = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmiModificarEliminarDetalleCuentasPagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiVerPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gp1Datos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btComenzarPago = New DevComponents.DotNetBar.ButtonX()
        Me.GpVerCuentas = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RbAmbos = New System.Windows.Forms.RadioButton()
        Me.RbPagados = New System.Windows.Forms.RadioButton()
        Me.RbPendientes = New System.Windows.Forms.RadioButton()
        Me.BtHabilitar = New DevComponents.DotNetBar.ButtonX()
        Me.TbdCambio = New DevComponents.Editors.DoubleInput()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.BtObtenerCuentas = New DevComponents.DotNetBar.ButtonX()
        Me.TbdMonto = New DevComponents.Editors.DoubleInput()
        Me.DtFecha = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.CbProveedor = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.OfdPDF = New System.Windows.Forms.OpenFileDialog()
        Me.GpBusqueda = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Busqueda = New Janus.Windows.GridEX.GridEX()
        Me.GpTotales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TbSaldo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TbTotalPagado = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TbTotalPagar = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.StcCuentasPagar = New DevComponents.DotNetBar.SuperTabControl()
        Me.StcPnCuentasPagar = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.StiCuentasPagar = New DevComponents.DotNetBar.SuperTabItem()
        Me.StcPnDetalleCuentasPagar = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.DgvDetalleCuentasPagar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CmsDetalleCP = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsmiModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgdDetalleCuentasPagar = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.StiDetalleCuentasPagar = New DevComponents.DotNetBar.SuperTabItem()
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
        CType(Me.DgvCuentasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsCuentasPagarME.SuspendLayout()
        Me.Gp1Datos.SuspendLayout()
        Me.GpVerCuentas.SuspendLayout()
        CType(Me.TbdCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbdMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBusqueda.SuspendLayout()
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpTotales.SuspendLayout()
        CType(Me.StcCuentasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StcCuentasPagar.SuspendLayout()
        Me.StcPnCuentasPagar.SuspendLayout()
        Me.StcPnDetalleCuentasPagar.SuspendLayout()
        CType(Me.DgvDetalleCuentasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsDetalleCP.SuspendLayout()
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(884, 661)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.GpBusqueda)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(884, 636)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(884, 636)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Controls.Add(Me.RlAccion)
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
        Me.BubbleBar1.Size = New System.Drawing.Size(200, 61)
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
        Me.PanelEx2.Location = New System.Drawing.Point(0, 600)
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
        Me.PanelEx3.Controls.Add(Me.Gp1Datos)
        Me.PanelEx3.Size = New System.Drawing.Size(884, 140)
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
        Me.PanelEx4.Controls.Add(Me.StcCuentasPagar)
        Me.PanelEx4.Controls.Add(Me.GpTotales)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 204)
        Me.PanelEx4.Size = New System.Drawing.Size(884, 396)
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
        'DgdCuentasPagar
        '
        Me.DgdCuentasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgdCuentasPagar.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DgdCuentasPagar.Location = New System.Drawing.Point(5, 5)
        Me.DgdCuentasPagar.Name = "DgdCuentasPagar"
        Me.DgdCuentasPagar.Size = New System.Drawing.Size(874, 251)
        Me.DgdCuentasPagar.TabIndex = 1
        Me.DgdCuentasPagar.Text = "SuperGridControl1"
        '
        'DgvCuentasPagar
        '
        Me.DgvCuentasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentasPagar.ContextMenuStrip = Me.CmsCuentasPagarME
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCuentasPagar.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCuentasPagar.Dock = System.Windows.Forms.DockStyle.Left
        Me.DgvCuentasPagar.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DgvCuentasPagar.Location = New System.Drawing.Point(5, 5)
        Me.DgvCuentasPagar.Name = "DgvCuentasPagar"
        Me.DgvCuentasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCuentasPagar.Size = New System.Drawing.Size(638, 251)
        Me.DgvCuentasPagar.TabIndex = 0
        '
        'CmsCuentasPagarME
        '
        Me.CmsCuentasPagarME.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmiModificarEliminarDetalleCuentasPagar, Me.TsmiVerPagos})
        Me.CmsCuentasPagarME.Name = "CmsCuentasPagarME"
        Me.CmsCuentasPagarME.Size = New System.Drawing.Size(209, 48)
        '
        'TsmiModificarEliminarDetalleCuentasPagar
        '
        Me.TsmiModificarEliminarDetalleCuentasPagar.Name = "TsmiModificarEliminarDetalleCuentasPagar"
        Me.TsmiModificarEliminarDetalleCuentasPagar.Size = New System.Drawing.Size(208, 22)
        Me.TsmiModificarEliminarDetalleCuentasPagar.Text = "Modificar/Eliminar Pagos"
        '
        'TsmiVerPagos
        '
        Me.TsmiVerPagos.Name = "TsmiVerPagos"
        Me.TsmiVerPagos.Size = New System.Drawing.Size(208, 22)
        Me.TsmiVerPagos.Text = "Ver Pagos"
        '
        'Gp1Datos
        '
        Me.Gp1Datos.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp1Datos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp1Datos.Controls.Add(Me.btComenzarPago)
        Me.Gp1Datos.Controls.Add(Me.GpVerCuentas)
        Me.Gp1Datos.Controls.Add(Me.BtHabilitar)
        Me.Gp1Datos.Controls.Add(Me.TbdCambio)
        Me.Gp1Datos.Controls.Add(Me.LabelX7)
        Me.Gp1Datos.Controls.Add(Me.BtObtenerCuentas)
        Me.Gp1Datos.Controls.Add(Me.TbdMonto)
        Me.Gp1Datos.Controls.Add(Me.DtFecha)
        Me.Gp1Datos.Controls.Add(Me.CbProveedor)
        Me.Gp1Datos.Controls.Add(Me.LabelX6)
        Me.Gp1Datos.Controls.Add(Me.LabelX4)
        Me.Gp1Datos.Controls.Add(Me.LabelX2)
        Me.Gp1Datos.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp1Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp1Datos.Location = New System.Drawing.Point(0, 0)
        Me.Gp1Datos.Name = "Gp1Datos"
        Me.Gp1Datos.Size = New System.Drawing.Size(884, 140)
        '
        '
        '
        Me.Gp1Datos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp1Datos.Style.BackColorGradientAngle = 90
        Me.Gp1Datos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp1Datos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Datos.Style.BorderBottomWidth = 1
        Me.Gp1Datos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp1Datos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Datos.Style.BorderLeftWidth = 1
        Me.Gp1Datos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Datos.Style.BorderRightWidth = 1
        Me.Gp1Datos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Datos.Style.BorderTopWidth = 1
        Me.Gp1Datos.Style.CornerDiameter = 4
        Me.Gp1Datos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp1Datos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp1Datos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp1Datos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp1Datos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp1Datos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp1Datos.TabIndex = 2
        Me.Gp1Datos.Text = "Cuenta por Pagar"
        '
        'btComenzarPago
        '
        Me.btComenzarPago.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btComenzarPago.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btComenzarPago.Image = Global.Presentacion.My.Resources.Resources.REPORTE1
        Me.btComenzarPago.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btComenzarPago.Location = New System.Drawing.Point(461, 61)
        Me.btComenzarPago.Name = "btComenzarPago"
        Me.btComenzarPago.Size = New System.Drawing.Size(200, 50)
        Me.btComenzarPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btComenzarPago.TabIndex = 5
        Me.btComenzarPago.Text = "Iniciar Pagos"
        '
        'GpVerCuentas
        '
        Me.GpVerCuentas.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpVerCuentas.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpVerCuentas.Controls.Add(Me.RbAmbos)
        Me.GpVerCuentas.Controls.Add(Me.RbPagados)
        Me.GpVerCuentas.Controls.Add(Me.RbPendientes)
        Me.GpVerCuentas.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpVerCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpVerCuentas.Location = New System.Drawing.Point(667, 3)
        Me.GpVerCuentas.Name = "GpVerCuentas"
        Me.GpVerCuentas.Size = New System.Drawing.Size(137, 108)
        '
        '
        '
        Me.GpVerCuentas.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpVerCuentas.Style.BackColorGradientAngle = 90
        Me.GpVerCuentas.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpVerCuentas.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpVerCuentas.Style.BorderBottomWidth = 1
        Me.GpVerCuentas.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpVerCuentas.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpVerCuentas.Style.BorderLeftWidth = 1
        Me.GpVerCuentas.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpVerCuentas.Style.BorderRightWidth = 1
        Me.GpVerCuentas.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpVerCuentas.Style.BorderTopWidth = 1
        Me.GpVerCuentas.Style.CornerDiameter = 4
        Me.GpVerCuentas.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpVerCuentas.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpVerCuentas.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpVerCuentas.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpVerCuentas.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpVerCuentas.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpVerCuentas.TabIndex = 17
        Me.GpVerCuentas.Text = "Ver Cuentas"
        '
        'RbAmbos
        '
        Me.RbAmbos.AutoSize = True
        Me.RbAmbos.Location = New System.Drawing.Point(3, 49)
        Me.RbAmbos.Name = "RbAmbos"
        Me.RbAmbos.Size = New System.Drawing.Size(69, 21)
        Me.RbAmbos.TabIndex = 18
        Me.RbAmbos.TabStop = True
        Me.RbAmbos.Text = "Ambos"
        Me.RbAmbos.UseVisualStyleBackColor = True
        '
        'RbPagados
        '
        Me.RbPagados.AutoSize = True
        Me.RbPagados.Location = New System.Drawing.Point(3, 26)
        Me.RbPagados.Name = "RbPagados"
        Me.RbPagados.Size = New System.Drawing.Size(82, 21)
        Me.RbPagados.TabIndex = 17
        Me.RbPagados.TabStop = True
        Me.RbPagados.Text = "Pagados"
        Me.RbPagados.UseVisualStyleBackColor = True
        '
        'RbPendientes
        '
        Me.RbPendientes.AutoSize = True
        Me.RbPendientes.Location = New System.Drawing.Point(3, 3)
        Me.RbPendientes.Name = "RbPendientes"
        Me.RbPendientes.Size = New System.Drawing.Size(97, 21)
        Me.RbPendientes.TabIndex = 16
        Me.RbPendientes.TabStop = True
        Me.RbPendientes.Text = "Pendientes"
        Me.RbPendientes.UseVisualStyleBackColor = True
        '
        'BtHabilitar
        '
        Me.BtHabilitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtHabilitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtHabilitar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtHabilitar.Image = Global.Presentacion.My.Resources.Resources.CANDADO_ABIERTO
        Me.BtHabilitar.ImageFixedSize = New System.Drawing.Size(65, 65)
        Me.BtHabilitar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BtHabilitar.Location = New System.Drawing.Point(808, 0)
        Me.BtHabilitar.Name = "BtHabilitar"
        Me.BtHabilitar.Size = New System.Drawing.Size(70, 119)
        Me.BtHabilitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtHabilitar.TabIndex = 15
        Me.BtHabilitar.Text = "Habilitar"
        '
        'TbdCambio
        '
        '
        '
        '
        Me.TbdCambio.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TbdCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbdCambio.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TbdCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbdCambio.Increment = 1.0R
        Me.TbdCambio.Location = New System.Drawing.Point(561, 32)
        Me.TbdCambio.MinValue = 0R
        Me.TbdCambio.Name = "TbdCambio"
        Me.TbdCambio.Size = New System.Drawing.Size(100, 23)
        Me.TbdCambio.TabIndex = 4
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(461, 32)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(94, 23)
        Me.LabelX7.TabIndex = 14
        Me.LabelX7.Text = "Cambio:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BtObtenerCuentas
        '
        Me.BtObtenerCuentas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtObtenerCuentas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtObtenerCuentas.Image = Global.Presentacion.My.Resources.Resources.DESCARGAR
        Me.BtObtenerCuentas.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.BtObtenerCuentas.Location = New System.Drawing.Point(109, 61)
        Me.BtObtenerCuentas.Name = "BtObtenerCuentas"
        Me.BtObtenerCuentas.Size = New System.Drawing.Size(200, 50)
        Me.BtObtenerCuentas.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtObtenerCuentas.TabIndex = 2
        Me.BtObtenerCuentas.Text = "Obtener Cuentas"
        '
        'TbdMonto
        '
        '
        '
        '
        Me.TbdMonto.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.TbdMonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbdMonto.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.TbdMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbdMonto.Increment = 1.0R
        Me.TbdMonto.Location = New System.Drawing.Point(561, 3)
        Me.TbdMonto.MinValue = 0R
        Me.TbdMonto.Name = "TbdMonto"
        Me.TbdMonto.Size = New System.Drawing.Size(100, 23)
        Me.TbdMonto.TabIndex = 3
        '
        'DtFecha
        '
        '
        '
        '
        Me.DtFecha.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DtFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.DtFecha.ButtonDropDown.Visible = True
        Me.DtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFecha.IsPopupCalendarOpen = False
        Me.DtFecha.Location = New System.Drawing.Point(109, 32)
        '
        '
        '
        '
        '
        '
        Me.DtFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtFecha.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.DtFecha.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.DtFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtFecha.MonthCalendar.DisplayMonth = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DtFecha.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.DtFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.DtFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.DtFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.DtFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DtFecha.MonthCalendar.TodayButtonVisible = True
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(100, 23)
        Me.DtFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.DtFecha.TabIndex = 1
        '
        'CbProveedor
        '
        CbProveedor_DesignTimeLayout.LayoutString = resources.GetString("CbProveedor_DesignTimeLayout.LayoutString")
        Me.CbProveedor.DesignTimeLayout = CbProveedor_DesignTimeLayout
        Me.CbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbProveedor.Location = New System.Drawing.Point(109, 3)
        Me.CbProveedor.Name = "CbProveedor"
        Me.CbProveedor.SelectedIndex = -1
        Me.CbProveedor.SelectedItem = Nothing
        Me.CbProveedor.Size = New System.Drawing.Size(350, 23)
        Me.CbProveedor.TabIndex = 0
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(461, 3)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(94, 23)
        Me.LabelX6.TabIndex = 11
        Me.LabelX6.Text = "Monto:"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(9, 32)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(94, 23)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Fecha:"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(9, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(94, 23)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "Proveedor:"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'OfdPDF
        '
        Me.OfdPDF.FileName = "OpenFileDialog1"
        '
        'GpBusqueda
        '
        Me.GpBusqueda.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpBusqueda.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpBusqueda.Controls.Add(Me.Dgj1Busqueda)
        Me.GpBusqueda.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.GpBusqueda.Name = "GpBusqueda"
        Me.GpBusqueda.Size = New System.Drawing.Size(884, 636)
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
        Me.GpBusqueda.Text = "Datos Busqueda"
        '
        'Dgj1Busqueda
        '
        Me.Dgj1Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Busqueda.Location = New System.Drawing.Point(0, 0)
        Me.Dgj1Busqueda.Name = "Dgj1Busqueda"
        Me.Dgj1Busqueda.RecordNavigator = True
        Me.Dgj1Busqueda.Size = New System.Drawing.Size(878, 615)
        Me.Dgj1Busqueda.TabIndex = 1
        '
        'GpTotales
        '
        Me.GpTotales.CanvasColor = System.Drawing.SystemColors.Control
        Me.GpTotales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GpTotales.Controls.Add(Me.TbSaldo)
        Me.GpTotales.Controls.Add(Me.LabelX5)
        Me.GpTotales.Controls.Add(Me.TbTotalPagado)
        Me.GpTotales.Controls.Add(Me.LabelX3)
        Me.GpTotales.Controls.Add(Me.TbTotalPagar)
        Me.GpTotales.Controls.Add(Me.LabelX1)
        Me.GpTotales.DisabledBackColor = System.Drawing.Color.Empty
        Me.GpTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GpTotales.Location = New System.Drawing.Point(0, 286)
        Me.GpTotales.Name = "GpTotales"
        Me.GpTotales.Size = New System.Drawing.Size(884, 110)
        '
        '
        '
        Me.GpTotales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GpTotales.Style.BackColorGradientAngle = 90
        Me.GpTotales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GpTotales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpTotales.Style.BorderBottomWidth = 1
        Me.GpTotales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GpTotales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpTotales.Style.BorderLeftWidth = 1
        Me.GpTotales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpTotales.Style.BorderRightWidth = 1
        Me.GpTotales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GpTotales.Style.BorderTopWidth = 1
        Me.GpTotales.Style.CornerDiameter = 4
        Me.GpTotales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GpTotales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GpTotales.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GpTotales.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GpTotales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GpTotales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GpTotales.TabIndex = 2
        Me.GpTotales.Text = "Totales"
        '
        'TbSaldo
        '
        Me.TbSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TbSaldo.Border.Class = "TextBoxBorder"
        Me.TbSaldo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbSaldo.Location = New System.Drawing.Point(625, 61)
        Me.TbSaldo.Name = "TbSaldo"
        Me.TbSaldo.PreventEnterBeep = True
        Me.TbSaldo.Size = New System.Drawing.Size(100, 23)
        Me.TbSaldo.TabIndex = 5
        Me.TbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(519, 61)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(100, 23)
        Me.LabelX5.TabIndex = 4
        Me.LabelX5.Text = "Saldo:"
        Me.LabelX5.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TbTotalPagado
        '
        Me.TbTotalPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TbTotalPagado.Border.Class = "TextBoxBorder"
        Me.TbTotalPagado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalPagado.Location = New System.Drawing.Point(625, 32)
        Me.TbTotalPagado.Name = "TbTotalPagado"
        Me.TbTotalPagado.PreventEnterBeep = True
        Me.TbTotalPagado.Size = New System.Drawing.Size(100, 23)
        Me.TbTotalPagado.TabIndex = 3
        Me.TbTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(519, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(100, 23)
        Me.LabelX3.TabIndex = 2
        Me.LabelX3.Text = "Total Pagado:"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TbTotalPagar
        '
        Me.TbTotalPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TbTotalPagar.Border.Class = "TextBoxBorder"
        Me.TbTotalPagar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TbTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalPagar.Location = New System.Drawing.Point(625, 3)
        Me.TbTotalPagar.Name = "TbTotalPagar"
        Me.TbTotalPagar.PreventEnterBeep = True
        Me.TbTotalPagar.Size = New System.Drawing.Size(100, 23)
        Me.TbTotalPagar.TabIndex = 1
        Me.TbTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(519, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(100, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Monto Total:"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'StcCuentasPagar
        '
        '
        '
        '
        '
        '
        '
        Me.StcCuentasPagar.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.StcCuentasPagar.ControlBox.MenuBox.Name = ""
        Me.StcCuentasPagar.ControlBox.Name = ""
        Me.StcCuentasPagar.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.StcCuentasPagar.ControlBox.MenuBox, Me.StcCuentasPagar.ControlBox.CloseBox})
        Me.StcCuentasPagar.Controls.Add(Me.StcPnCuentasPagar)
        Me.StcCuentasPagar.Controls.Add(Me.StcPnDetalleCuentasPagar)
        Me.StcCuentasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StcCuentasPagar.Location = New System.Drawing.Point(0, 0)
        Me.StcCuentasPagar.Name = "StcCuentasPagar"
        Me.StcCuentasPagar.ReorderTabsEnabled = True
        Me.StcCuentasPagar.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.StcCuentasPagar.SelectedTabIndex = 0
        Me.StcCuentasPagar.Size = New System.Drawing.Size(884, 286)
        Me.StcCuentasPagar.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StcCuentasPagar.TabIndex = 2
        Me.StcCuentasPagar.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.StiCuentasPagar, Me.StiDetalleCuentasPagar})
        Me.StcCuentasPagar.Text = "SuperTabControl2"
        '
        'StcPnCuentasPagar
        '
        Me.StcPnCuentasPagar.Controls.Add(Me.DgvCuentasPagar)
        Me.StcPnCuentasPagar.Controls.Add(Me.DgdCuentasPagar)
        Me.StcPnCuentasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StcPnCuentasPagar.Location = New System.Drawing.Point(0, 25)
        Me.StcPnCuentasPagar.Name = "StcPnCuentasPagar"
        Me.StcPnCuentasPagar.Padding = New System.Windows.Forms.Padding(5)
        Me.StcPnCuentasPagar.Size = New System.Drawing.Size(884, 261)
        Me.StcPnCuentasPagar.TabIndex = 1
        Me.StcPnCuentasPagar.TabItem = Me.StiCuentasPagar
        '
        'StiCuentasPagar
        '
        Me.StiCuentasPagar.AttachedControl = Me.StcPnCuentasPagar
        Me.StiCuentasPagar.GlobalItem = False
        Me.StiCuentasPagar.Name = "StiCuentasPagar"
        Me.StiCuentasPagar.Text = "Cuentas por Pagar"
        '
        'StcPnDetalleCuentasPagar
        '
        Me.StcPnDetalleCuentasPagar.Controls.Add(Me.DgvDetalleCuentasPagar)
        Me.StcPnDetalleCuentasPagar.Controls.Add(Me.DgdDetalleCuentasPagar)
        Me.StcPnDetalleCuentasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StcPnDetalleCuentasPagar.Location = New System.Drawing.Point(0, 25)
        Me.StcPnDetalleCuentasPagar.Name = "StcPnDetalleCuentasPagar"
        Me.StcPnDetalleCuentasPagar.Padding = New System.Windows.Forms.Padding(5)
        Me.StcPnDetalleCuentasPagar.Size = New System.Drawing.Size(884, 261)
        Me.StcPnDetalleCuentasPagar.TabIndex = 0
        Me.StcPnDetalleCuentasPagar.TabItem = Me.StiDetalleCuentasPagar
        '
        'DgvDetalleCuentasPagar
        '
        Me.DgvDetalleCuentasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleCuentasPagar.ContextMenuStrip = Me.CmsDetalleCP
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDetalleCuentasPagar.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDetalleCuentasPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDetalleCuentasPagar.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DgvDetalleCuentasPagar.Location = New System.Drawing.Point(5, 5)
        Me.DgvDetalleCuentasPagar.Name = "DgvDetalleCuentasPagar"
        Me.DgvDetalleCuentasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalleCuentasPagar.Size = New System.Drawing.Size(874, 251)
        Me.DgvDetalleCuentasPagar.TabIndex = 3
        '
        'CmsDetalleCP
        '
        Me.CmsDetalleCP.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsmiModificar, Me.TsmiEliminar})
        Me.CmsDetalleCP.Name = "CmsCuentasPagarME"
        Me.CmsDetalleCP.Size = New System.Drawing.Size(126, 48)
        '
        'TsmiModificar
        '
        Me.TsmiModificar.Name = "TsmiModificar"
        Me.TsmiModificar.Size = New System.Drawing.Size(125, 22)
        Me.TsmiModificar.Text = "Modificar"
        '
        'TsmiEliminar
        '
        Me.TsmiEliminar.Name = "TsmiEliminar"
        Me.TsmiEliminar.Size = New System.Drawing.Size(125, 22)
        Me.TsmiEliminar.Text = "Eliminar"
        '
        'DgdDetalleCuentasPagar
        '
        Me.DgdDetalleCuentasPagar.ContextMenuStrip = Me.CmsCuentasPagarME
        Me.DgdDetalleCuentasPagar.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.DgdDetalleCuentasPagar.Location = New System.Drawing.Point(275, 5)
        Me.DgdDetalleCuentasPagar.Name = "DgdDetalleCuentasPagar"
        Me.DgdDetalleCuentasPagar.Size = New System.Drawing.Size(604, 251)
        Me.DgdDetalleCuentasPagar.TabIndex = 2
        Me.DgdDetalleCuentasPagar.Text = "SuperGridControl1"
        '
        'StiDetalleCuentasPagar
        '
        Me.StiDetalleCuentasPagar.AttachedControl = Me.StcPnDetalleCuentasPagar
        Me.StiDetalleCuentasPagar.GlobalItem = False
        Me.StiDetalleCuentasPagar.Name = "StiDetalleCuentasPagar"
        Me.StiDetalleCuentasPagar.Text = "Detalle de Cuentas por Pagar"
        '
        'P_PagoCuentasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Name = "P_PagoCuentasPagar"
        Me.Text = "P_PagoCuentasPagar"
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
        CType(Me.DgvCuentasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsCuentasPagarME.ResumeLayout(False)
        Me.Gp1Datos.ResumeLayout(False)
        Me.Gp1Datos.PerformLayout()
        Me.GpVerCuentas.ResumeLayout(False)
        Me.GpVerCuentas.PerformLayout()
        CType(Me.TbdCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbdMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBusqueda.ResumeLayout(False)
        CType(Me.Dgj1Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpTotales.ResumeLayout(False)
        CType(Me.StcCuentasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StcCuentasPagar.ResumeLayout(False)
        Me.StcPnCuentasPagar.ResumeLayout(False)
        Me.StcPnDetalleCuentasPagar.ResumeLayout(False)
        CType(Me.DgvDetalleCuentasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsDetalleCP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RlAccion As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Gp1Datos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents OfdPDF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbdMonto As DevComponents.Editors.DoubleInput
    Friend WithEvents DtFecha As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents CbProveedor As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents GpBusqueda As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj1Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents GpTotales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DgvCuentasPagar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TbSaldo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbTotalPagado As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbTotalPagar As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TbdCambio As DevComponents.Editors.DoubleInput
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents BtObtenerCuentas As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BtHabilitar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GpVerCuentas As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents RbAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents RbPagados As System.Windows.Forms.RadioButton
    Friend WithEvents RbPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents DgdCuentasPagar As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents StcCuentasPagar As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents StcPnCuentasPagar As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents StiCuentasPagar As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents StcPnDetalleCuentasPagar As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents DgdDetalleCuentasPagar As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Friend WithEvents StiDetalleCuentasPagar As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents CmsCuentasPagarME As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TsmiModificarEliminarDetalleCuentasPagar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmsDetalleCP As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TsmiModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DgvDetalleCuentasPagar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TsmiVerPagos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btComenzarPago As DevComponents.DotNetBar.ButtonX
End Class
