Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class P_BonosDescuentos

#Region "Variables Lcales"
    'Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
#End Region

#Region "Metodos Privados"

    Private Sub _PCargarGridBuscador(Optional _todos As Boolean = False)
        Dim dt As New DataTable

        If _todos Then
            dt = L_BonosDescuentosCabecera_General(0).Tables(0)
        Else
            dt = L_BonosDescuentosCabecera_General(-1, " and pbano=" + Now.Year.ToString + " and pbmes=" + Now.Month.ToString).Tables(0)
        End If

        JGr_Buscador.BoundMode = BoundMode.Bound
        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("pbnumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = 7
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("pbcper")
            .Caption = "Cod. Persona"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = 7
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With JGr_Buscador.RootTable.Columns("cbdesc")
            .Caption = "Nombre"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = 7
            .CellStyle.BackColor = Color.AliceBlue
        End With

        With JGr_Buscador.RootTable.Columns("pbano")
            .Caption = "Año"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = 7
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("pbmes")
            .Caption = "Mes"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = 7
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            JGr_Buscador.VisualStyle = VisualStyle.Office2007
        End With

        'poner en filtrador
        'JGr_Buscador.Row = JGr_Buscador.FilterRow.RowIndex
        'JGr_Buscador.FilterRow.PreviewRowText = "2016"

        'JGr_Buscador.FilterRow.Cells("pbano").Text = Now.Year.ToString
        'JGr_Buscador.FilterRow.Cells("pbmes").Text = Now.Month.ToString
        'JGr_Buscador.Refresh()
        'JGr_Buscador.FilterRow.BeginEdit()
        'JGr_Buscador.FilterRow.Cells("pbmes").Value = 2016
        'JGr_Buscador.SetValue(4, "32")

    End Sub

    Private Sub _PCargarGridDetalle(idCabecera As String)
        Dim dt As New DataTable
        dt = L_BonosDescuentosDetalle_General2(-1, idCabecera)

        JGr_Detalle.BoundMode = BoundMode.Bound
        JGr_Detalle.DataSource = dt
        JGr_Detalle.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Detalle.RootTable.Columns("pcnumi")
            .Visible = False
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Detalle.RootTable.Columns("pcdias")
            .Caption = "Dias"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .DefaultValue = 0
        End With

        With JGr_Detalle.RootTable.Columns("pcmonto")
            .Caption = "Monto"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Detalle.RootTable.Columns("pcobs")
            .Caption = "Observacion"
            .Width = 400
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        End With

        With JGr_Detalle.RootTable.Columns("pcmul")
            .Caption = "Multa"
            .Visible = True
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = False
            .CheckBoxTrueValue = True
            .Visible = False
        End With

        With JGr_Detalle.RootTable.Columns("pcbode")
            .Caption = "Bode"
            .Visible = True
            .Width = 50
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.CheckBox
            .ColumnType = ColumnType.CheckBox
            .CheckBoxFalseValue = False
            .CheckBoxTrueValue = True
            .Visible = False
        End With

        With JGr_Detalle.RootTable.Columns("tipo")
            .Caption = "Tipo"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .EditType = EditType.MultiColumnDropDown
            .DropDown = mcBonoDesc.DropDownList
            .EmptyStringValue = ""
            .DefaultValue = "DESCUENTO"
        End With

        With JGr_Detalle.RootTable.Columns("pcfecha")
            .Caption = "Fecha"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .DefaultValue = Today.Date.ToString("dd/MM/yyyy")
        End With

        'Habilitar Filtradores
        With JGr_Detalle
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007

            .AllowAddNew = InheritableBoolean.False
        End With

        JGr_Detalle.ContextMenuStrip = msDetalle
    End Sub

    Public Sub _PCargarComboBonoDesc()
        Dim dtBonoDesc As New DataTable
        dtBonoDesc.Columns.Add("tipobd")
        dtBonoDesc.Rows.Add("BONO")
        dtBonoDesc.Rows.Add("DESCUENTO")
        dtBonoDesc.Rows.Add("MULTA")

        mcBonoDesc.DropDownList.Columns.Clear()

        mcBonoDesc.DropDownList.Columns.Add(dtBonoDesc.Columns("tipobd").ToString).Width = 150
        mcBonoDesc.DropDownList.Columns(0).Caption = "TIPO"

        mcBonoDesc.ValueMember = dtBonoDesc.Columns("tipobd").ToString
        mcBonoDesc.DisplayMember = dtBonoDesc.Columns("tipobd").ToString
        mcBonoDesc.DataSource = dtBonoDesc
        mcBonoDesc.Refresh()

    End Sub
    Private Sub _PCargarComboEmpleados()
        Dim _Ds As New DataSet
        _Ds = L_Empleado_General(-1, " AND cbest=1")

        JMc_Persona.DropDownList.Columns.Clear()

        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbnumi").ToString).Width = 50
        JMc_Persona.DropDownList.Columns(0).Caption = "Código"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbci").ToString).Width = 70
        JMc_Persona.DropDownList.Columns(1).Caption = "CI"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbdesc").ToString).Width = 250
        JMc_Persona.DropDownList.Columns(2).Caption = "Descripcion"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbsal").ToString).Width = 100
        JMc_Persona.DropDownList.Columns(3).Caption = "Salario"

        JMc_Persona.ValueMember = _Ds.Tables(0).Columns("cbnumi").ToString
        JMc_Persona.DisplayMember = _Ds.Tables(0).Columns("cbdesc").ToString
        JMc_Persona.DataSource = _Ds.Tables(0)
        JMc_Persona.Refresh()
    End Sub
    Private Sub _PHabilitar()
        Tb_Anio.Enabled = True
        Tb_Mes.Enabled = True

        bbtNuevo.Enabled = False
        bbtModificar.Enabled = False
        bbtEliminar.Enabled = False
        bbtGrabar.Enabled = True

        JMc_Persona.Enabled = True

        'habilitar adicion de nuevas filas en el grid de sueldos
        JGr_Detalle.AllowAddNew = InheritableBoolean.True
        'JGr_Detalle.Enabled = True

    End Sub
    Private Sub _PInhabilitar()
        Tb_id.Enabled = False
        Tb_Anio.Enabled = False
        Tb_Mes.Enabled = False

        Tb_Sueldo.ReadOnly = True
        Tb_BonoDesc.ReadOnly = True
        Tb_descFijos.ReadOnly = True
        Tb_SaldoSueldo.ReadOnly = True

        bbtNuevo.Enabled = True
        bbtModificar.Enabled = True
        bbtEliminar.Enabled = True
        bbtGrabar.Enabled = False

        JMc_Persona.Enabled = False
        'JGr_Detalle.Enabled = False

        bbtGrabar.Image = My.Resources.GRABAR
        bbtGrabar.ImageLarge = My.Resources.GRABAR

        _PLimpiarErrores()
    End Sub
    Private Sub _PLimpiarErrores()
        EP1.Clear()
        Tb_Anio.BackColor = Color.White
        Tb_Mes.BackColor = Color.White
    End Sub
    Private Sub _PLimpiar()
        Tb_id.Text = ""
        Tb_Anio.Text = Now.Year.ToString
        Tb_Mes.Text = Now.Month.ToString

        Tb_BonoDesc.Text = ""
        Tb_descFijos.Text = ""
        Tb_SaldoSueldo.Text = ""
        Tb_Sueldo.Text = ""
        JMc_Persona.SelectedIndex = -1
        'aumentado 
        Txt_Paginacion.Text = ""

        'limpiar grid detalle
        _PCargarGridDetalle(-1)
        'permitir adicion de nuevas columnas
        JGr_Detalle.AllowAddNew = InheritableBoolean.True

    End Sub
    Private Sub _PHabilitarFocus()

        HighLigthter_Focus.SetHighlightOnFocus(Tb_Anio, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Mes, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(JMc_Persona, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)

        'JMc_Persona.TabIndex = 1
        'Tb_Anio.TabIndex = 2
        'Tb_Mes.TabIndex = 3
        'PanelEx4.TabIndex = 4
        'JGr_Detalle.TabIndex = 1
    End Sub


    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "B O N O S    D E S C U E N T O S"
        Me.WindowState = FormWindowState.Maximized

        _PCargarComboBonoDesc()

        _PCargarComboEmpleados()

        _PFiltrar()
        _PInhabilitar()

        _PHabilitarFocus()

        ''_PCargarGridBuscador()

        SuperTabControl1.SelectedTabIndex = 0

        _pCambiarFuente()
    End Sub

    Private Sub _pCambiarFuente()
        Dim fuente As New Font("Tahoma", gi_fuenteTamano, FontStyle.Regular)
        Dim xCtrl As Control
        For Each xCtrl In PanelEx3.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

        For Each xCtrl In PanelEx4.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next
        For Each xCtrl In GroupPanel1.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub _PFiltrar()
        '_Dsencabezado = New DataSet
        '_Dsencabezado = L_BonosDescuentosCabecera_General(0)
        '_First = False
        _PCargarGridBuscador()
        If JGr_Buscador.RowCount <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            If JGr_Buscador.RowCount > 0 Then
                BBtn_Inicio.Visible = True
                BBtn_Anterior.Visible = True
                BBtn_Siguiente.Visible = True
                BBtn_Ultimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)
        JGr_Buscador.Row = _N
        With JGr_Buscador
            Tb_id.Text = .GetValue("pbnumi").ToString
            JMc_Persona.Text = .GetValue("cbdesc").ToString
            Tb_Anio.Text = .GetValue("pbano").ToString
            Tb_Mes.Text = .GetValue("pbmes").ToString
        End With

        'cargar detalle
        _PCargarGridDetalle(Tb_id.Text)
        Tb_BonoDesc.Text = _FCalcularBonosDesc()
        Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()

        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + JGr_Buscador.RowCount.ToString
    End Sub
    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False

        If Tb_Anio.Text = "" Then
            Tb_Anio.BackColor = Color.Red
            EP1.SetError(Tb_Anio, "Ingrese Año!")
            _Error = True
        Else
            Tb_Anio.BackColor = Color.White
            EP1.SetError(Tb_Anio, "")
        End If

        If Tb_Mes.Text = "" Then
            Tb_Mes.BackColor = Color.Red
            EP1.SetError(Tb_Mes, "Ingrese Mes!")
            _Error = True
        Else
            Tb_Mes.BackColor = Color.White
            EP1.SetError(Tb_Mes, "")
        End If

        If JMc_Persona.SelectedIndex < 0 Then
            JMc_Persona.BackColor = Color.Red   'error de validacion
            EP1.SetError(JMc_Persona, "Seleccione la Persona!")
            _Error = True
        Else
            JMc_Persona.BackColor = Color.White
            EP1.SetError(JMc_Persona, "")
        End If

        If JGr_Detalle.RowCount = 0 Then
            ToastNotification.Show(Me, "ingrese por lo menos 1 fila en el detalle".ToUpper, My.Resources.WARNING, 3000, eToastGlowColor.Green, eToastPosition.BottomCenter)
            _Error = True
        Else
            Dim i As Integer
            With JGr_Detalle
                For i = 0 To .RowCount - 1
                    .Row = i
                    If .GetValue("pcdias").ToString = String.Empty Or .GetValue("pcmonto").ToString = String.Empty Or .GetValue("tipo").ToString = String.Empty Or .GetValue("pcfecha").ToString = String.Empty Then
                        ToastNotification.Show(Me, "falta ingresar datos en el detalle".ToUpper, My.Resources.WARNING, 3000, eToastGlowColor.Green, eToastPosition.BottomCenter)
                        _Error = True
                        Exit For
                    End If

                Next
            End With
        End If

        Return _Error
    End Function

    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        If _PValidar() Then
            Exit Sub
        End If
        If bbtGrabar.Enabled = False Then
            Exit Sub
        End If

        If bbtGrabar.Tag = 0 Then
            bbtGrabar.Tag = 1
            bbtGrabar.Image = My.Resources.CONFIRMACION
            bbtGrabar.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar6.Refresh()
            Exit Sub
        Else
            bbtGrabar.Tag = 0
            bbtGrabar.Image = My.Resources.GRABAR
            bbtGrabar.ImageLarge = My.Resources.GRABAR
            BubbleBar6.Refresh()
        End If


        If _Nuevo Then

            L_BonosDescuentosCabecera_Grabar(Tb_id.Text, JMc_Persona.Value, Tb_Anio.Text, Tb_Mes.Text)

            'grabar detalle
            Dim i As Integer
            Dim dias, monto, obs, multa, bode, tipo, fecha As String
            multa = 0
            bode = 0
            With JGr_Detalle
                For i = 0 To .RowCount - 1
                    .Row = i
                    dias = .GetValue("pcdias")
                    monto = .GetValue("pcmonto")
                    obs = .GetValue("pcobs").ToString
                    tipo = .GetValue("tipo").ToString
                    fecha = CType(.GetValue("pcfecha"), Date).ToString("yyyy/MM/dd")
                    Select Case tipo
                        Case "MULTA"
                            bode = "0"
                            multa = "1"
                        Case "BONO"
                            bode = "1"
                            multa = "0"
                        Case "DESCUENTO"
                            bode = "0"
                            multa = "0"
                    End Select
                   
                    'If .GetValue("pcmul").ToString = "True" Then
                    '    multa = "1"
                    'Else
                    '    multa = "0"
                    'End If

                    'If .GetValue("pcbode").ToString = "True" Then
                    '    bode = "1"
                    'Else
                    '    bode = "0"
                    'End If

                    L_BonosDescuentosDetalle_Grabar(Tb_id.Text, dias, monto, obs, multa, bode, fecha)
                Next
            End With

            'actualizar el grid de buscador
            '_PCargarGridBuscador()
            '_PFiltrar()

            JMc_Persona.Focus()
            ToastNotification.Show(Me, "Codigo " + Tb_id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)
            'Tsbl0_Mensaje.Text = ""
            _PLimpiar()
        Else

            L_BonosDescuentosCabecera_Modificar(Tb_id.Text, JMc_Persona.Value, Tb_Anio.Text, Tb_Mes.Text)

            'grabar detalle
            L_BonosDescuentosDetalle_Borrar(Tb_id.Text)
            Dim i As Integer
            Dim dias, monto, obs, multa, bode, tipo, fecha As String
            multa = 0
            bode = 0
            With JGr_Detalle
                For i = 0 To .RowCount - 1
                    .Row = i
                    dias = .GetValue("pcdias")
                    monto = .GetValue("pcmonto")
                    obs = .GetValue("pcobs").ToString
                    tipo = .GetValue("tipo").ToString
                    fecha = CType(.GetValue("pcfecha"), Date).ToString("yyyy/MM/dd")
                    Select Case tipo
                        Case "MULTA"
                            bode = "0"
                            multa = "1"
                        Case "BONO"
                            bode = "1"
                            multa = "0"
                        Case "DESCUENTO"
                            bode = "0"
                            multa = "0"
                    End Select
                    L_BonosDescuentosDetalle_Grabar(Tb_id.Text, dias, monto, obs, multa, bode,fecha)
                Next
            End With

            ToastNotification.Show(Me, "Codigo " + Tb_id.Text + " Modificado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.BottomLeft)

            _Nuevo = False 'aumentado danny
            '_Modificar = False 'aumentado danny
            _PInhabilitar()
            _PFiltrar()
        End If
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()
        bbtNuevo.Enabled = True

        _PLimpiar()
        Tb_Anio.Focus()
        _Nuevo = True

        Tb_Sueldo.Text = 0
        JMc_Persona.SelectedIndex = -1
    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        '_Modificar = True
        _PHabilitar()
    End Sub

    Private Sub _PEliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("¿Esta seguro de Eliminar el Registro?".ToUpper, MsgBoxStyle.YesNo, "Advertencia".ToUpper)
        If _Result = MsgBoxResult.Yes Then
            L_BonosDescuentosCabecera_Borrar(Tb_id.Text)
            'borro el detalle del encabezado
            L_BonosDescuentosDetalle_Borrar(Tb_id.Text)

            _PFiltrar()

            'mi codigo, actualizo el sub
            '_Pos = 0
            'Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub _PSalirRegistro()
        If bbtGrabar.Enabled = True Then
            Dim _Result As MsgBoxResult
            _Result = MsgBox("¿ESTA SEGURO DE SALIR SIN GUARDAR?", MsgBoxStyle.YesNo, "Advertencia".ToUpper)
            If _Result = MsgBoxResult.Yes Then
                _PInhabilitar()
                _PFiltrar()
                bbtGrabar.Tag = 0
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _PGrabarNuevasLibrerias()
        ''Dim codCiu, codProv, codZona As Integer
        ''If J_Cb_Ciudad.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(13, 13, codCiu, J_Cb_Ciudad.Text)
        ''    _LlenarComboLibreria(J_Cb_Ciudad, 13)
        ''    J_Cb_Ciudad.Value = codCiu
        ''    Ep2.SetError(J_Cb_Ciudad, "")
        ''End If

        ''If J_Cb_Provincia.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(4, 4, codProv, J_Cb_Provincia.Text)
        ''    _LlenarComboLibreria(J_Cb_Provincia, 4)
        ''    J_Cb_Provincia.Value = codProv
        ''    Ep2.SetError(J_Cb_Provincia, "")
        ''End If

        ''If J_Cb_Zona.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(2, 2, codZona, J_Cb_Zona.Text)
        ''    _LlenarComboLibreria(J_Cb_Zona, 2)
        ''    J_Cb_Zona.Value = codZona
        ''    Ep2.SetError(J_Cb_Zona, "")
        ''End If
        ''Pan_Dialogo.Visible = False
    End Sub

    Private Sub _PPrimerRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
        End If

    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < JGr_Buscador.RowCount - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = JGr_Buscador.RowCount - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub


    Private Function _FCalcularBonosDescOri() As Double
        Dim i As Integer
        Dim montoT As Double = 0
        Dim valor As String
        For i = 0 To JGr_Detalle.RowCount - 1
            JGr_Detalle.Row = i
            valor = JGr_Detalle.GetValue("pcmonto").ToString
            If IsNumeric(valor) = True Then
                If JGr_Detalle.GetValue("pcmul").ToString = "True" Then
                    montoT = montoT - valor
                Else
                    If JGr_Detalle.GetValue("pcbode").ToString = "True" Then
                        montoT = montoT + valor
                    End If
                End If
            End If
        Next
        Return montoT
    End Function
    Private Function _FCalcularBonosDesc() As Double
        Dim i As Integer
        Dim montoT As Double = 0
        Dim valor As String
        Dim tipo As String
        'For i = 0 To JGr_Detalle.RowCount - 1
        '    JGr_Detalle.Row = i
        '    valor = JGr_Detalle.GetValue("pcmonto").ToString
        '    tipo = JGr_Detalle.GetValue("tipo").ToString
        '    If IsNumeric(valor) = True And tipo <> String.Empty Then
        '        If tipo = "DESCUENTO" Or tipo = "MULTA" Then
        '            montoT = montoT - valor
        '        Else
        '            If tipo = "BONO" Then
        '                montoT = montoT + valor
        '            End If
        '        End If
        '    End If
        'Next
        If JGr_Detalle.RowCount > 0 Then
            Dim dt As DataTable = CType(JGr_Detalle.DataSource, DataTable)
            For Each fila As DataRow In dt.Rows
                If Not fila.RowState = DataRowState.Deleted Then
                    valor = fila.Item("pcmonto").ToString
                    tipo = fila.Item("tipo").ToString
                    If IsNumeric(valor) = True And tipo <> String.Empty Then
                        If tipo = "DESCUENTO" Or tipo = "MULTA" Then
                            montoT = montoT - valor
                        Else
                            If tipo = "BONO" Then
                                montoT = montoT + valor
                            End If
                        End If
                    End If
                End If

                
            Next
            Return montoT
        End If

    End Function
    Private Function _FCalcularSaldoSueldo() As Double
        Dim saldoSueldo As Double
        saldoSueldo = Convert.ToDouble(Tb_Sueldo.Text) + Convert.ToDouble(Tb_BonoDesc.Text) + Convert.ToDouble(Tb_descFijos.Text)
        Return saldoSueldo
    End Function

    Private Sub _prEliminarFila()
        Dim fila As Integer = JGr_Detalle.Row
        'Dim dtDetalle As DataTable = CType(JGr_Detalle.DataSource, DataTable)
        'dtDetalle.Rows.RemoveAt(fila)

        'JGr_Detalle.GetRow(JGr_Detalle.Row).BeginEdit()
        'JGr_Detalle.GetRow(JGr_Detalle.Row).Delete()
        'JGr_Detalle.GetRow(JGr_Detalle.Row).EndEdit()

        JGr_Detalle.CurrentRow.EndEdit()
        JGr_Detalle.CurrentRow.Delete()
        JGr_Detalle.Refetch()
        JGr_Detalle.Refresh()

    End Sub
#End Region


    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click, bbtNuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click, bbtModificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click, bbtEliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click, bbtGrabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click, bbtSalir.Click
        _PSalirRegistro()
    End Sub

    Private Sub P_BonosDescuentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        _PPrimerRegistro()
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        _PAnteriorRegistro()
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        _PSiguienteRegistro()
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        _PUltimoRegistro()
    End Sub

    Private Sub JMc_Persona_ValueChanged(sender As Object, e As EventArgs) Handles JMc_Persona.ValueChanged
        If JMc_Persona.SelectedIndex >= 0 Then
            If bbtGrabar.Enabled = True Then
                'verifico si ya existe el registro
                Dim dt As DataTable = L_BonosDescuentosCabecera_General(-1, " and pbcper=" + JMc_Persona.Value.ToString + " and pbano=" + Tb_Anio.Text + " and pbmes=" + Tb_Mes.Text).Tables(0)
                If dt.Rows.Count > 0 And bbtGrabar.Enabled = True Then
                    Tb_id.Text = dt.Rows(0).Item("pbnumi")
                    _Nuevo = False
                    _PCargarGridDetalle(Tb_id.Text)
                    JGr_Detalle.AllowAddNew = InheritableBoolean.True
                Else
                    Tb_id.Text = ""
                    _Nuevo = True
                    'limpiar grid detalle
                    _PCargarGridDetalle(-1)
                    JGr_Detalle.AllowAddNew = InheritableBoolean.True
                End If
            End If


            Dim sueldo As String
            Dim _Dt As New DataTable
            Dim codPersona As String = JMc_Persona.Value.ToString
            _Dt = L_Empleado_General(-1, " AND cbnumi=" + codPersona).Tables(0)
            If IsDBNull(_Dt.Rows(0).Item("cbsal")) Then
                sueldo = 0
            Else
                sueldo = _Dt.Rows(0).Item("cbsal")
            End If

            Tb_Sueldo.Text = sueldo

            'traer los fijos, si es true el tipo es por valor,si es false es porcentaje
            Dim dtFijos As DataTable
            dtFijos = L_DescuentoFijo_General(-1, " AND cbnumi=" + codPersona).Tables(0)
            If dtFijos.Rows.Count > 0 Then
                Dim tipo As String
                Dim descFijo As Double
                tipo = dtFijos.Rows(0).Item("patipo")
                descFijo = dtFijos.Rows(0).Item("pavalor")
                If tipo = False Then 'por porcentaje
                    descFijo = Tb_Sueldo.Text * (descFijo / 100)
                End If
                Tb_descFijos.Text = (descFijo * (-1)).ToString("0.00")
            Else 'no tiene descuentos
                Tb_descFijos.Text = 0.ToString("0.00")
            End If

            'Tb_SaldoSueldo.Text = (Convert.ToDouble(Tb_Sueldo.Text) - Convert.ToDouble(Tb_descFijos.Text)).ToString("0.00")
            Tb_BonoDesc.Text = _FCalcularBonosDesc()
            Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()

        End If


    End Sub

   
    Private Sub JGr_Detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles JGr_Detalle.CellEdited
        If JGr_Detalle.Row >= 0 Then
            If e.Column.Key = "pcmul" Then
                Dim valor As String = JGr_Detalle.GetValue("pcmul").ToString
                If valor = "True" Then
                    JGr_Detalle.SetValue("pcbode", 0)
                End If
                Tb_BonoDesc.Text = _FCalcularBonosDesc()
                Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()
            End If

            If e.Column.Key = "pcbode" Then
                Dim valor As String = JGr_Detalle.GetValue("pcbode").ToString
                If valor = "True" Then
                    JGr_Detalle.SetValue("pcmul", 0)
                End If
                Tb_BonoDesc.Text = _FCalcularBonosDesc()
                Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()
            End If

            If e.Column.Key = "pcmonto" Then
                Dim dias As Integer = JGr_Detalle.GetValue("pcdias")
                If dias > 0 Then
                    Dim monto As Double = (Tb_Sueldo.Text / 30) * dias
                    JGr_Detalle.SetValue("pcmonto", monto)
                End If
                Tb_BonoDesc.Text = _FCalcularBonosDesc()
                Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()
            End If

            If e.Column.Key = "pcdias" Then
                Dim dias As Integer = JGr_Detalle.GetValue("pcdias")
                Dim monto As Double
                If dias > 0 Then
                    monto = FormatNumber((Tb_Sueldo.Text / 30) * dias, 2)
                Else
                    monto = 0
                End If
                JGr_Detalle.SetValue("pcmonto", monto)

            End If
        End If

        If JGr_Detalle.Row = -1 Then
            If e.Column.Key = "pcdias" Then
                Dim dias As Integer = JGr_Detalle.GetValue("pcdias")
                Dim monto As Double
                If dias > 0 Then
                    monto = FormatNumber((Tb_Sueldo.Text / 30) * dias, 2)
                Else
                    monto = 0
                End If
                JGr_Detalle.SetValue("pcmonto", monto)
            End If

        End If
    End Sub


    Private Sub JGr_Detalle_LoadingRow(sender As Object, e As RowLoadEventArgs) Handles JGr_Detalle.LoadingRow
        If JGr_Detalle.Focused = True Then
            Tb_BonoDesc.Text = _FCalcularBonosDesc()
            Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()

        End If

    End Sub

    Private Sub P_BonosDescuentos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And bbtGrabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TP002", "pb", "pbnumi=" + Tb_id.Text)
            If IsDBNull(dtAud.Rows(0).Item(0)) = True Then
                lbFecha.Text = ""
            Else
                lbFecha.Text = Convert.ToDateTime(dtAud.Rows(0).Item(0)).ToString("dd/MM/yyyy")
            End If
            lbHora.Text = dtAud.Rows(0).Item(1).ToString
            lbUsuario.Text = dtAud.Rows(0).Item(2).ToString
            FlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            FlyoutUsuario.Content = PanelUsuario
        End If

    End Sub

    Private Sub BBtn_Usuario_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Usuario.Click
        FlyoutUsuario_PrepareContent(BubbleBar5, e)
    End Sub

    Private Sub JGr_Detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles JGr_Detalle.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Tb_Mes_KeyDown(sender As Object, e As KeyEventArgs) Handles Tb_Mes.KeyDown

        'If (e.KeyCode = Keys.Enter) Then
        '    PanelEx4.Focus()
        '    JGr_Detalle.Focus()
        '    JGr_Detalle.MoveTo(0) 'JGr_Detalle.NewRowPosition
        '    JGr_Detalle.Col = -1
        'End If
    End Sub

    Private Sub P_BonosDescuentos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If bbtGrabar.Enabled = True Then
            If (MessageBox.Show("ESTA SEGURO DE SALIR SIN GUARDAR?", "AVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Me.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If e.NewValue.ToString = "RESGITRO" Then
            If JGr_Buscador.RowCount > 0 Then
                _Pos = 0
                _PMostrarRegistro(0)
            Else
                Txt_Paginacion.Text = 0
            End If

        End If
    End Sub

    ''Private Sub Tb_Anio_Leave(sender As Object, e As EventArgs) Handles Tb_Anio.Leave
    ''    If bbtGrabar.Enabled = True Then
    ''        'verifico si ya existe el registro
    ''        Dim dt As DataTable = L_BonosDescuentosCabecera_General(-1, " and pbcper=" + JMc_Persona.Value.ToString + " and pbano=" + Tb_Anio.Text + " and pbmes=" + Tb_Mes.Text).Tables(0)
    ''        If dt.Rows.Count > 0 And bbtGrabar.Enabled = True Then
    ''            Tb_id.Text = dt.Rows(0).Item("pbnumi")
    ''            _Nuevo = False
    ''            _PCargarGridDetalle(Tb_id.Text)
    ''            JGr_Detalle.AllowAddNew = InheritableBoolean.True
    ''        Else
    ''            Tb_id.Text = ""
    ''            _Nuevo = True
    ''            'limpiar grid detalle
    ''            _PCargarGridDetalle(-1)
    ''            JGr_Detalle.AllowAddNew = InheritableBoolean.True
    ''        End If
    ''    End If
    ''End Sub

    ''Private Sub Tb_Mes_Leave(sender As Object, e As EventArgs) Handles Tb_Mes.Leave
    ''    If bbtGrabar.Enabled = True Then
    ''        'verifico si ya existe el registro
    ''        Dim dt As DataTable = L_BonosDescuentosCabecera_General(-1, " and pbcper=" + JMc_Persona.Value.ToString + " and pbano=" + Tb_Anio.Text + " and pbmes=" + Tb_Mes.Text).Tables(0)
    ''        If dt.Rows.Count > 0 And bbtGrabar.Enabled = True Then
    ''            Tb_id.Text = dt.Rows(0).Item("pbnumi")
    ''            _Nuevo = False
    ''            _PCargarGridDetalle(Tb_id.Text)
    ''            JGr_Detalle.AllowAddNew = InheritableBoolean.True
    ''        Else
    ''            Tb_id.Text = ""
    ''            _Nuevo = True
    ''            'limpiar grid detalle
    ''            _PCargarGridDetalle(-1)
    ''            JGr_Detalle.AllowAddNew = InheritableBoolean.True
    ''        End If
    ''    End If
    ''End Sub

    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btnMostrarTodos.Click
        _PCargarGridBuscador(True)
        _PPrimerRegistro()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        _PCargarGridBuscador()
        _PPrimerRegistro()
    End Sub

    Private Sub Tb_Anio_TextChanged(sender As Object, e As EventArgs) Handles Tb_Anio.TextChanged
        If bbtGrabar.Enabled = True Then
            JMc_Persona.SelectedIndex = -1
        End If

    End Sub

    Private Sub Tb_Mes_TextChanged(sender As Object, e As EventArgs) Handles Tb_Mes.TextChanged
        If bbtGrabar.Enabled = True Then
            JMc_Persona.SelectedIndex = -1
        End If
    End Sub

    Private Sub JGr_Detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Detalle.EditingCell
        If bbtGrabar.Enabled = False Then
            e.Cancel = True
        End If

    End Sub

    Private Sub JGr_Detalle_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles JGr_Detalle.CellUpdated
        'If JGr_Detalle.Focused = True And bbtGrabar.Enabled = True Then
        '    JGr_Detalle.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
        '    Tb_BonoDesc.Text = _FCalcularBonosDesc()
        '    Tb_SaldoSueldo.Text = _FCalcularSaldoSueldo()

        'End If
    End Sub

    Private Sub JMc_Persona_KeyDown(sender As Object, e As KeyEventArgs) Handles JMc_Persona.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            PanelEx4.Focus()
            JGr_Detalle.Focus()
            'JGr_Detalle.MoveTo(JGr_Detalle.MoveFirst) 'JGr_Detalle.NewRowPosition
            JGr_Detalle.MoveToNewRecord()
            JGr_Detalle.Col = -1 'JGr_Detalle.RootTable.Columns("pcdias").Index
        End If
    End Sub

    Private Sub ELIMINARFILAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARFILAToolStripMenuItem.Click
        If JGr_Detalle.Row >= 0 And bbtGrabar.Enabled = True Then
            _prEliminarFila()
        End If

    End Sub
End Class