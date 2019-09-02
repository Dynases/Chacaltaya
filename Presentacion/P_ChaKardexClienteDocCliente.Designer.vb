<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_ChaKardexClienteDocCliente
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbCodCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btBuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.dtiFechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.sbTipo = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btActualizarSaldo = New DevComponents.DotNetBar.ButtonX()
        Me.tbSaldo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btImprimirKardex = New DevComponents.DotNetBar.ButtonX()
        Me.btGenerarKardex = New DevComponents.DotNetBar.ButtonX()
        Me.dtiFechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.tbNomCliente = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjKardex = New Janus.Windows.GridEX.GridEX()
        Me.Gp1Clientes = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgjBusqueda = New Janus.Windows.GridEX.GridEX()
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
        CType(Me.dtiFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtiFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgjKardex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp1Clientes.SuspendLayout()
        CType(Me.dgjBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(784, 561)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Gp1Clientes)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(584, 536)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(784, 536)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'SuperTabItem1
        '
        Me.SuperTabItem1.Text = "REGISTRO"
        '
        'PanelEx1
        '
        Me.PanelEx1.Size = New System.Drawing.Size(784, 64)
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
        Me.BubbleBar2.Location = New System.Drawing.Point(720, 0)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Size = New System.Drawing.Size(784, 36)
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
        Me.PanelEx3.Controls.Add(Me.GroupPanel1)
        Me.PanelEx3.Size = New System.Drawing.Size(784, 152)
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
        Me.PanelEx4.Controls.Add(Me.GroupPanel2)
        Me.PanelEx4.Location = New System.Drawing.Point(0, 216)
        Me.PanelEx4.Size = New System.Drawing.Size(784, 284)
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
        Me.PanelEx5.Location = New System.Drawing.Point(584, 0)
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
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(60, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Cliente"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'tbCodCliente
        '
        '
        '
        '
        Me.tbCodCliente.Border.Class = "TextBoxBorder"
        Me.tbCodCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodCliente.Location = New System.Drawing.Point(69, 6)
        Me.tbCodCliente.Name = "tbCodCliente"
        Me.tbCodCliente.PreventEnterBeep = True
        Me.tbCodCliente.Size = New System.Drawing.Size(76, 20)
        Me.tbCodCliente.TabIndex = 0
        '
        'btBuscarCliente
        '
        Me.btBuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btBuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btBuscarCliente.Image = Global.Presentacion.My.Resources.Resources.BUSQUEDA
        Me.btBuscarCliente.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.btBuscarCliente.Location = New System.Drawing.Point(142, 6)
        Me.btBuscarCliente.Name = "btBuscarCliente"
        Me.btBuscarCliente.Size = New System.Drawing.Size(27, 20)
        Me.btBuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btBuscarCliente.TabIndex = 1
        Me.btBuscarCliente.Tooltip = "Buscar Cliente"
        '
        'dtiFechaIni
        '
        '
        '
        '
        Me.dtiFechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaIni.ButtonDropDown.Visible = True
        Me.dtiFechaIni.IsPopupCalendarOpen = False
        Me.dtiFechaIni.Location = New System.Drawing.Point(69, 35)
        '
        '
        '
        '
        '
        '
        Me.dtiFechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaIni.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiFechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaIni.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaIni.Name = "dtiFechaIni"
        Me.dtiFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.dtiFechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaIni.TabIndex = 2
        Me.dtiFechaIni.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'sbTipo
        '
        '
        '
        '
        Me.sbTipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.sbTipo.Location = New System.Drawing.Point(309, 36)
        Me.sbTipo.Name = "sbTipo"
        Me.sbTipo.OffText = "VENTA"
        Me.sbTipo.OnText = "ENTREGA"
        Me.sbTipo.Size = New System.Drawing.Size(130, 22)
        Me.sbTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sbTipo.TabIndex = 4
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btActualizarSaldo)
        Me.GroupPanel1.Controls.Add(Me.tbSaldo)
        Me.GroupPanel1.Controls.Add(Me.btImprimirKardex)
        Me.GroupPanel1.Controls.Add(Me.btGenerarKardex)
        Me.GroupPanel1.Controls.Add(Me.dtiFechaFin)
        Me.GroupPanel1.Controls.Add(Me.tbNomCliente)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.sbTipo)
        Me.GroupPanel1.Controls.Add(Me.dtiFechaIni)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.btBuscarCliente)
        Me.GroupPanel1.Controls.Add(Me.tbCodCliente)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(784, 152)
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
        Me.GroupPanel1.TabIndex = 5
        Me.GroupPanel1.Text = "Datos"
        '
        'btActualizarSaldo
        '
        Me.btActualizarSaldo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btActualizarSaldo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btActualizarSaldo.Image = Global.Presentacion.My.Resources.Resources.ACTUALIZAR
        Me.btActualizarSaldo.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btActualizarSaldo.Location = New System.Drawing.Point(175, 64)
        Me.btActualizarSaldo.Name = "btActualizarSaldo"
        Me.btActualizarSaldo.Size = New System.Drawing.Size(120, 60)
        Me.btActualizarSaldo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btActualizarSaldo.TabIndex = 13
        Me.btActualizarSaldo.Text = "Actualizar Saldo"
        '
        'tbSaldo
        '
        '
        '
        '
        Me.tbSaldo.Border.Class = "TextBoxBorder"
        Me.tbSaldo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSaldo.Location = New System.Drawing.Point(69, 64)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.PreventEnterBeep = True
        Me.tbSaldo.ReadOnly = True
        Me.tbSaldo.Size = New System.Drawing.Size(100, 20)
        Me.tbSaldo.TabIndex = 12
        '
        'btImprimirKardex
        '
        Me.btImprimirKardex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btImprimirKardex.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btImprimirKardex.Image = Global.Presentacion.My.Resources.Resources.IMPRIMIR
        Me.btImprimirKardex.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btImprimirKardex.Location = New System.Drawing.Point(445, 64)
        Me.btImprimirKardex.Name = "btImprimirKardex"
        Me.btImprimirKardex.Size = New System.Drawing.Size(130, 60)
        Me.btImprimirKardex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btImprimirKardex.TabIndex = 6
        Me.btImprimirKardex.Text = "Imprimir"
        '
        'btGenerarKardex
        '
        Me.btGenerarKardex.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btGenerarKardex.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btGenerarKardex.Image = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.btGenerarKardex.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.btGenerarKardex.Location = New System.Drawing.Point(301, 64)
        Me.btGenerarKardex.Name = "btGenerarKardex"
        Me.btGenerarKardex.Size = New System.Drawing.Size(130, 60)
        Me.btGenerarKardex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btGenerarKardex.TabIndex = 5
        Me.btGenerarKardex.Text = "Generar"
        '
        'dtiFechaFin
        '
        '
        '
        '
        Me.dtiFechaFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtiFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtiFechaFin.ButtonDropDown.Visible = True
        Me.dtiFechaFin.IsPopupCalendarOpen = False
        Me.dtiFechaFin.Location = New System.Drawing.Point(203, 35)
        '
        '
        '
        '
        '
        '
        Me.dtiFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtiFechaFin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtiFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFin.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtiFechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.dtiFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtiFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtiFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtiFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtiFechaFin.MonthCalendar.TodayButtonVisible = True
        Me.dtiFechaFin.Name = "dtiFechaFin"
        Me.dtiFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.dtiFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtiFechaFin.TabIndex = 3
        Me.dtiFechaFin.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'tbNomCliente
        '
        '
        '
        '
        Me.tbNomCliente.Border.Class = "TextBoxBorder"
        Me.tbNomCliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNomCliente.Location = New System.Drawing.Point(175, 6)
        Me.tbNomCliente.Name = "tbNomCliente"
        Me.tbNomCliente.PreventEnterBeep = True
        Me.tbNomCliente.ReadOnly = True
        Me.tbNomCliente.Size = New System.Drawing.Size(400, 20)
        Me.tbNomCliente.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(3, 61)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(60, 23)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Saldo"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(175, 32)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(22, 23)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Al"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(3, 32)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(60, 23)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Fecha del"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.dgjKardex)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(784, 284)
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
        Me.GroupPanel2.TabIndex = 6
        Me.GroupPanel2.Text = "Kardex"
        '
        'dgjKardex
        '
        Me.dgjKardex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjKardex.Location = New System.Drawing.Point(0, 0)
        Me.dgjKardex.Name = "dgjKardex"
        Me.dgjKardex.Size = New System.Drawing.Size(778, 263)
        Me.dgjKardex.TabIndex = 0
        '
        'Gp1Clientes
        '
        Me.Gp1Clientes.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp1Clientes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp1Clientes.Controls.Add(Me.dgjBusqueda)
        Me.Gp1Clientes.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp1Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp1Clientes.Location = New System.Drawing.Point(0, 0)
        Me.Gp1Clientes.Name = "Gp1Clientes"
        Me.Gp1Clientes.Padding = New System.Windows.Forms.Padding(5)
        Me.Gp1Clientes.Size = New System.Drawing.Size(584, 536)
        '
        '
        '
        Me.Gp1Clientes.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp1Clientes.Style.BackColorGradientAngle = 90
        Me.Gp1Clientes.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp1Clientes.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Clientes.Style.BorderBottomWidth = 1
        Me.Gp1Clientes.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp1Clientes.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Clientes.Style.BorderLeftWidth = 1
        Me.Gp1Clientes.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Clientes.Style.BorderRightWidth = 1
        Me.Gp1Clientes.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Clientes.Style.BorderTopWidth = 1
        Me.Gp1Clientes.Style.CornerDiameter = 4
        Me.Gp1Clientes.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp1Clientes.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp1Clientes.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp1Clientes.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp1Clientes.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp1Clientes.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp1Clientes.TabIndex = 0
        Me.Gp1Clientes.Text = "Clientes"
        '
        'dgjBusqueda
        '
        Me.dgjBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgjBusqueda.Location = New System.Drawing.Point(5, 5)
        Me.dgjBusqueda.Name = "dgjBusqueda"
        Me.dgjBusqueda.Size = New System.Drawing.Size(568, 505)
        Me.dgjBusqueda.TabIndex = 1
        '
        'P_ChaKardexClienteDocCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Name = "P_ChaKardexClienteDocCliente"
        Me.Text = ""
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
        CType(Me.dtiFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dtiFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgjKardex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp1Clientes.ResumeLayout(False)
        CType(Me.dgjBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents sbTipo As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents dtiFechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btBuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbCodCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btActualizarSaldo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btImprimirKardex As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btGenerarKardex As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtiFechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents tbNomCliente As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Gp1Clientes As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgjBusqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents dgjKardex As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbSaldo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
