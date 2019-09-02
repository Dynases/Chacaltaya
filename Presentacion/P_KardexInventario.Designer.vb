<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_KardexInventario
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
        Me.Tb1CodEquipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Bt1BuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.Dti1FechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Bt2ActualizarSaldo = New DevComponents.DotNetBar.ButtonX()
        Me.Tb3Saldo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Bt4Imprimir = New DevComponents.DotNetBar.ButtonX()
        Me.Bt3Generar = New DevComponents.DotNetBar.ButtonX()
        Me.Dti2FechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Tb2DescEquipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Datos = New Janus.Windows.GridEX.GridEX()
        Me.Gp1Equipos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj2Busqueda = New Janus.Windows.GridEX.GridEX()
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
        CType(Me.Dti1FechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Dti2FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Dgj1Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp1Equipos.SuspendLayout()
        CType(Me.Dgj2Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabControl1.Size = New System.Drawing.Size(634, 561)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel2, 0)
        Me.SuperTabControl1.Controls.SetChildIndex(Me.SuperTabControlPanel1, 0)
        '
        'SuperTabControlPanel2
        '
        Me.SuperTabControlPanel2.Controls.Add(Me.Gp1Equipos)
        Me.SuperTabControlPanel2.Size = New System.Drawing.Size(584, 536)
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(634, 536)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx1, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx2, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx3, 0)
        Me.SuperTabControlPanel1.Controls.SetChildIndex(Me.PanelEx4, 0)
        '
        'PanelEx1
        '
        Me.PanelEx1.Size = New System.Drawing.Size(634, 64)
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
        Me.BubbleBar2.Location = New System.Drawing.Point(570, 0)
        Me.BubbleBar2.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar2.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelEx2
        '
        Me.PanelEx2.Size = New System.Drawing.Size(634, 36)
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
        Me.PanelEx3.Size = New System.Drawing.Size(634, 152)
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
        Me.PanelEx4.Size = New System.Drawing.Size(634, 284)
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
        Me.PanelEx5.Location = New System.Drawing.Point(434, 0)
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
        Me.LabelX1.Text = "Equipo"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Tb1CodEquipo
        '
        '
        '
        '
        Me.Tb1CodEquipo.Border.Class = "TextBoxBorder"
        Me.Tb1CodEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb1CodEquipo.Location = New System.Drawing.Point(69, 6)
        Me.Tb1CodEquipo.Name = "Tb1CodEquipo"
        Me.Tb1CodEquipo.PreventEnterBeep = True
        Me.Tb1CodEquipo.Size = New System.Drawing.Size(76, 20)
        Me.Tb1CodEquipo.TabIndex = 0
        '
        'Bt1BuscarCliente
        '
        Me.Bt1BuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt1BuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt1BuscarCliente.Image = Global.Presentacion.My.Resources.Resources.BUSQUEDA
        Me.Bt1BuscarCliente.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Bt1BuscarCliente.Location = New System.Drawing.Point(142, 6)
        Me.Bt1BuscarCliente.Name = "Bt1BuscarCliente"
        Me.Bt1BuscarCliente.Size = New System.Drawing.Size(27, 20)
        Me.Bt1BuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt1BuscarCliente.TabIndex = 1
        Me.Bt1BuscarCliente.Tooltip = "Buscar Cliente"
        '
        'Dti1FechaIni
        '
        '
        '
        '
        Me.Dti1FechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dti1FechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dti1FechaIni.ButtonDropDown.Visible = True
        Me.Dti1FechaIni.IsPopupCalendarOpen = False
        Me.Dti1FechaIni.Location = New System.Drawing.Point(69, 35)
        '
        '
        '
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dti1FechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.Dti1FechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.TodayButtonVisible = True
        Me.Dti1FechaIni.Name = "Dti1FechaIni"
        Me.Dti1FechaIni.Size = New System.Drawing.Size(100, 20)
        Me.Dti1FechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti1FechaIni.TabIndex = 2
        Me.Dti1FechaIni.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Bt2ActualizarSaldo)
        Me.GroupPanel1.Controls.Add(Me.Tb3Saldo)
        Me.GroupPanel1.Controls.Add(Me.Bt4Imprimir)
        Me.GroupPanel1.Controls.Add(Me.Bt3Generar)
        Me.GroupPanel1.Controls.Add(Me.Dti2FechaFin)
        Me.GroupPanel1.Controls.Add(Me.Tb2DescEquipo)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.Dti1FechaIni)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.Bt1BuscarCliente)
        Me.GroupPanel1.Controls.Add(Me.Tb1CodEquipo)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(634, 152)
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
        'Bt2ActualizarSaldo
        '
        Me.Bt2ActualizarSaldo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt2ActualizarSaldo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt2ActualizarSaldo.Image = Global.Presentacion.My.Resources.Resources.ACTUALIZAR
        Me.Bt2ActualizarSaldo.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt2ActualizarSaldo.Location = New System.Drawing.Point(175, 64)
        Me.Bt2ActualizarSaldo.Name = "Bt2ActualizarSaldo"
        Me.Bt2ActualizarSaldo.Size = New System.Drawing.Size(120, 60)
        Me.Bt2ActualizarSaldo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt2ActualizarSaldo.TabIndex = 13
        Me.Bt2ActualizarSaldo.Text = "Actualizar Saldo"
        '
        'Tb3Saldo
        '
        '
        '
        '
        Me.Tb3Saldo.Border.Class = "TextBoxBorder"
        Me.Tb3Saldo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb3Saldo.Location = New System.Drawing.Point(69, 64)
        Me.Tb3Saldo.Name = "Tb3Saldo"
        Me.Tb3Saldo.PreventEnterBeep = True
        Me.Tb3Saldo.ReadOnly = True
        Me.Tb3Saldo.Size = New System.Drawing.Size(100, 20)
        Me.Tb3Saldo.TabIndex = 12
        '
        'Bt4Imprimir
        '
        Me.Bt4Imprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt4Imprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt4Imprimir.Image = Global.Presentacion.My.Resources.Resources.IMPRIMIR
        Me.Bt4Imprimir.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt4Imprimir.Location = New System.Drawing.Point(489, 64)
        Me.Bt4Imprimir.Name = "Bt4Imprimir"
        Me.Bt4Imprimir.Size = New System.Drawing.Size(130, 60)
        Me.Bt4Imprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt4Imprimir.TabIndex = 6
        Me.Bt4Imprimir.Text = "Imprimir"
        '
        'Bt3Generar
        '
        Me.Bt3Generar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt3Generar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt3Generar.Image = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bt3Generar.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt3Generar.Location = New System.Drawing.Point(301, 64)
        Me.Bt3Generar.Name = "Bt3Generar"
        Me.Bt3Generar.Size = New System.Drawing.Size(130, 60)
        Me.Bt3Generar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt3Generar.TabIndex = 5
        Me.Bt3Generar.Text = "Generar"
        '
        'Dti2FechaFin
        '
        '
        '
        '
        Me.Dti2FechaFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dti2FechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dti2FechaFin.ButtonDropDown.Visible = True
        Me.Dti2FechaFin.IsPopupCalendarOpen = False
        Me.Dti2FechaFin.Location = New System.Drawing.Point(203, 35)
        '
        '
        '
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dti2FechaFin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.Dti2FechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.TodayButtonVisible = True
        Me.Dti2FechaFin.Name = "Dti2FechaFin"
        Me.Dti2FechaFin.Size = New System.Drawing.Size(100, 20)
        Me.Dti2FechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti2FechaFin.TabIndex = 3
        Me.Dti2FechaFin.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'Tb2DescEquipo
        '
        '
        '
        '
        Me.Tb2DescEquipo.Border.Class = "TextBoxBorder"
        Me.Tb2DescEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb2DescEquipo.Location = New System.Drawing.Point(175, 6)
        Me.Tb2DescEquipo.Name = "Tb2DescEquipo"
        Me.Tb2DescEquipo.PreventEnterBeep = True
        Me.Tb2DescEquipo.ReadOnly = True
        Me.Tb2DescEquipo.Size = New System.Drawing.Size(444, 20)
        Me.Tb2DescEquipo.TabIndex = 8
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
        Me.GroupPanel2.Controls.Add(Me.Dgj1Datos)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(634, 284)
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
        'Dgj1Datos
        '
        Me.Dgj1Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Datos.Location = New System.Drawing.Point(0, 0)
        Me.Dgj1Datos.Name = "Dgj1Datos"
        Me.Dgj1Datos.Size = New System.Drawing.Size(628, 263)
        Me.Dgj1Datos.TabIndex = 0
        '
        'Gp1Equipos
        '
        Me.Gp1Equipos.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp1Equipos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp1Equipos.Controls.Add(Me.Dgj2Busqueda)
        Me.Gp1Equipos.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp1Equipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp1Equipos.Location = New System.Drawing.Point(0, 0)
        Me.Gp1Equipos.Name = "Gp1Equipos"
        Me.Gp1Equipos.Padding = New System.Windows.Forms.Padding(5)
        Me.Gp1Equipos.Size = New System.Drawing.Size(584, 536)
        '
        '
        '
        Me.Gp1Equipos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp1Equipos.Style.BackColorGradientAngle = 90
        Me.Gp1Equipos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp1Equipos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderBottomWidth = 1
        Me.Gp1Equipos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp1Equipos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderLeftWidth = 1
        Me.Gp1Equipos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderRightWidth = 1
        Me.Gp1Equipos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderTopWidth = 1
        Me.Gp1Equipos.Style.CornerDiameter = 4
        Me.Gp1Equipos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp1Equipos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp1Equipos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp1Equipos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp1Equipos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp1Equipos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp1Equipos.TabIndex = 0
        Me.Gp1Equipos.Text = "Equipos"
        '
        'Dgj2Busqueda
        '
        Me.Dgj2Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj2Busqueda.Location = New System.Drawing.Point(5, 5)
        Me.Dgj2Busqueda.Name = "Dgj2Busqueda"
        Me.Dgj2Busqueda.Size = New System.Drawing.Size(568, 505)
        Me.Dgj2Busqueda.TabIndex = 1
        '
        'P_KardexInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 561)
        Me.Name = "P_KardexInventario"
        Me.Text = "KARDEX DE INVENTARIO"
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
        CType(Me.Dti1FechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Dti2FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Dgj1Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp1Equipos.ResumeLayout(False)
        CType(Me.Dgj2Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dti1FechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Bt1BuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Tb1CodEquipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Bt2ActualizarSaldo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bt4Imprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bt3Generar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dti2FechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Tb2DescEquipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Gp1Equipos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj2Busqueda As Janus.Windows.GridEX.GridEX
    Friend WithEvents Dgj1Datos As Janus.Windows.GridEX.GridEX
    Friend WithEvents Tb3Saldo As DevComponents.DotNetBar.Controls.TextBoxX
End Class
