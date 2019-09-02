Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports DevComponents.Editors.DateTimeAdv

Public Class P_PedidoVacacion

#Region "Variables Lcales"
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _Modificar As Boolean
#End Region

#Region "Metodos Privados"

    Private Sub _PCargarDetalleFechas(numiEmpleado As String)
        Dim dt As New DataTable
        dt = L_PedidoVacacionDetalleFechas(numiEmpleado)

        'llenar la tabla con los dias de vacacion de acuerdo a la antiguedad-------------------------------
        Dim dtDiasVacacion As DataTable = L_Vacacion_General(0).Tables(0)
        Dim fechaIni As Date = dt.Rows(0).Item("cbfing")
        Dim diasTotal As Integer = 0
        Dim diasUsadosTotal As Integer = 0
        Dim diasLibresTotal As Integer = 0

        dt.Clear()
        Dim row As DataRow
        ''Dim cantAños As Integer = DateDiff(DateInterval.Year, fechaIni, Today)
        Dim cantAños As Integer = DateDiff(DateInterval.DayOfYear, fechaIni, Today) \ 365
        Dim mesesRestantes As Integer = DateDiff(DateInterval.Month, fechaIni, Today) - (12 * cantAños)

        Dim dias As Integer
        Dim fechaFin As Date
        Dim i As Integer
        Dim diasUsadosEnGestion As Integer

        Dim diasUsados As Integer = L_PedidoVacacion_ObtenerDiasUsados(JMc_Persona.Value)
        If cantAños >= 1 Then
            For i = 1 To cantAños

                'Dim meses As Integer = dtDiasVacacion.Rows(i).Item("pemeses")
                'Dim dias As Integer = dtDiasVacacion.Rows(i).Item("pedias")
                dias = L_PedidoVacacion_ObtenerDiasVacacion(12 * i)

                ''Dim fechaFin As Date = DateAdd(DateInterval.Month, meses, fechaIni)
                fechaFin = DateAdd(DateInterval.Year, 1, fechaIni)

                'calcular cuantos dias se usaron en esta gestion
                diasUsadosEnGestion = 0
                If diasUsados > 0 Then
                    If diasUsados > dias Then
                        diasUsadosEnGestion = dias
                        diasUsados = diasUsados - dias
                    Else
                        diasUsadosEnGestion = diasUsados
                        diasUsados = 0
                    End If
                End If

                'agregar fila
                row = dt.NewRow()
                row("cbfing") = fechaIni
                row("fechaFin") = fechaFin
                row("diasLibres") = dias
                row("diasUsados") = diasUsadosEnGestion
                row("saldo") = dias - diasUsadosEnGestion

                dt.Rows.Add(row)

                diasTotal = diasTotal + dias
                diasUsadosTotal = diasUsadosTotal + diasUsadosEnGestion
                diasLibresTotal = diasLibresTotal + dias - diasUsadosEnGestion

                fechaIni = fechaFin

            Next

            'cargar los ultimos dias que le corresponden con los meses restantes
            dias = L_PedidoVacacion_ObtenerDiasVacacion(12 * (i - 1))
            Dim diasFinales As Integer = (mesesRestantes * dias) / 12
            'dias = L_PedidoVacacion_ObtenerDiasVacacion(mesesRestantes)
            fechaFin = Today
            'agregar fila
            row = dt.NewRow()
            row("cbfing") = fechaIni
            row("fechaFin") = fechaFin
            row("diasLibres") = diasFinales
            ''''row("diasUsados") = diasUsadosEnGestion 'CORRECCION DANNY
            row("diasUsados") = diasUsados
            ''''row("saldo") = diasFinales - diasUsadosEnGestion 'CORRECCION DANNY
            row("saldo") = diasFinales - diasUsados
            dt.Rows.Add(row)
            diasTotal = diasTotal + dias
            ''''diasUsadosTotal = diasUsadosTotal + diasUsadosEnGestion
            ''''diasLibresTotal = diasLibresTotal + diasFinales - diasUsadosEnGestion
            diasUsadosTotal = diasUsadosTotal + diasUsados
            diasLibresTotal = diasLibresTotal + diasFinales - diasUsados

        Else 'por el caso de que no halla pasado ni un año
            'cargar los ultimos dias que le corresponden con los meses restantes
            dias = L_PedidoVacacion_ObtenerDiasVacacion(12)
            Dim diasFinales As Integer = (mesesRestantes * dias) / 12
            'dias = L_PedidoVacacion_ObtenerDiasVacacion(mesesRestantes)
            fechaFin = Today
            'agregar fila
            row = dt.NewRow()
            row("cbfing") = fechaIni
            row("fechaFin") = fechaFin
            row("diasLibres") = diasFinales
            row("diasUsados") = diasUsados
            row("saldo") = diasFinales - diasUsados
            dt.Rows.Add(row)
            diasLibresTotal = diasFinales - diasUsados

        End If


        'cargar los dias permitidos o saldo de dias
        Tb_DiasPermitidos.Text = diasLibresTotal
        Tb_DiasPedidos.MaxValue = diasLibresTotal
        Tb_DiasPedidos.MinValue = 1
        Tb_DiasPedidos.Text = 1
        _PCargarDiaVacacionCalendario(Tb_FechaSalida.Value)
        Calendario.Refresh()

        JGr_DetalleFechas.DataSource = dt
        JGr_DetalleFechas.RetrieveStructure()

        'dar formato a las columnas
        With JGr_DetalleFechas.RootTable.Columns("cbfing")
            .Caption = "Fecha Ini"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_DetalleFechas.RootTable.Columns("fechaFin")
            .Caption = "Fecha Fin"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_DetalleFechas.RootTable.Columns("diasLibres")
            .Caption = "Dias Libres"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_DetalleFechas.RootTable.Columns("diasUsados")
            .Caption = "Dias Usados"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_DetalleFechas.RootTable.Columns("saldo")
            .Caption = "Saldo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With JGr_DetalleFechas
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
            '.AllowAddNew = InheritableBoolean.True
        End With


    End Sub

    Private Sub _PCargarBuscador()
        Dim dt As New DataTable
        dt = L_PedidoVacacionCabecera_General(0).Tables(0)

        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("pgnumi")
            .Caption = "Codigo"
            .Width = 60
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("pgcper")
            .Caption = "Cod Persona"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbdesc")
            .Caption = "Nombre"
            .Width = 180
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("pgfdoc")
            .Caption = "Fecha"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        'Habilitar Filtradores
        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub

    Private Sub _PCargarComboEmpleados()
        Dim _Ds As New DataSet
        _Ds = L_Empleado_General(0)

        JMc_Persona.DropDownList.Columns.Clear()

        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbnumi").ToString).Width = 50
        JMc_Persona.DropDownList.Columns(0).Caption = "Código"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbci").ToString).Width = 70
        JMc_Persona.DropDownList.Columns(1).Caption = "CI"
        JMc_Persona.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cbdesc").ToString).Width = 250
        JMc_Persona.DropDownList.Columns(2).Caption = "Descripcion"

        JMc_Persona.ValueMember = _Ds.Tables(0).Columns("cbnumi").ToString
        JMc_Persona.DisplayMember = _Ds.Tables(0).Columns("cbdesc").ToString
        JMc_Persona.DataSource = _Ds.Tables(0)
        JMc_Persona.Refresh()
    End Sub

    Private Sub _PHabilitar()
        Tb_Fecha.Enabled = True
        Tb_Estado.Enabled = True
        Tb_Obs.Enabled = True
        Tb_DiasPedidos.Enabled = True
        Tb_FechaSalida.Enabled = True

        JMc_Persona.Enabled = True

        BBtn_Nuevo.Enabled = False
        BBtn_Modificar.Enabled = False
        BBtn_Eliminar.Enabled = False
        BBtn_Grabar.Enabled = True

        JGr_Buscador.Enabled = False
    End Sub
    Private Sub _PInhabilitar()
        Tb_Id.Enabled = False
        Tb_Fecha.Enabled = False
        Tb_Estado.Enabled = False
        Tb_Obs.Enabled = False
        Tb_DiasPedidos.Enabled = False
        Tb_DiasPermitidos.Enabled = False
        Tb_FechaIngreso.Enabled = False
        Tb_FechaSalida.Enabled = False

        JMc_Persona.Enabled = False

        BBtn_Nuevo.Enabled = True
        BBtn_Modificar.Enabled = True
        BBtn_Eliminar.Enabled = True
        BBtn_Grabar.Enabled = False

        BBtn_Grabar.Image = My.Resources.GRABAR
        BBtn_Grabar.ImageLarge = My.Resources.GRABAR

        _PLimpiarErrores()

        JGr_Buscador.Enabled = True

        _Nuevo = False
        _Modificar = False
    End Sub
    Private Sub _PLimpiarErrores()
        EP1.Clear()
        Tb_Fecha.BackColor = Color.White
        Tb_Fecha.BackColor = Color.White
        Tb_Obs.BackColor = Color.White
    End Sub
    Private Sub _PLimpiar()
        Tb_Id.Text = ""
        Tb_Obs.Text = ""
        Tb_DiasPedidos.Text = ""
        Tb_DiasPermitidos.Text = ""
        Tb_Estado.Value = True
        _PLimpiarCalendario()

        JMc_Persona.SelectedIndex = -1

        JGr_DetalleFechas.ClearStructure()

        'aumentado 
        Txt_Paginacion.Text = ""

    End Sub
    Private Sub _PHabilitarFocus()

        HighLigthter_Focus.SetHighlightOnFocus(Tb_Fecha, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Estado, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Obs, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(JMc_Persona, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)


        Tb_Estado.TabIndex = 1
        JMc_Persona.TabIndex = 2
        Tb_Fecha.TabIndex = 3
        Tb_Obs.TabIndex = 4

    End Sub


    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "F E R I A D O S"
        Me.WindowState = FormWindowState.Maximized

        'iniciar variables
        SuperTabItem2.Visible = False

        _PCargarComboEmpleados()

        _PInhabilitar()
        _PFiltrar()

        _PHabilitarFocus()

        _PCargarBuscador()



    End Sub

    Private Sub _PFiltrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_PedidoVacacionCabecera_General(0)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                BBtn_Inicio.Visible = True
                BBtn_Anterior.Visible = True
                BBtn_Siguiente.Visible = True
                BBtn_Ultimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)

        With _Dsencabezado.Tables(0).Rows(_N)
            Tb_Id.Text = .Item("pgnumi").ToString

            JMc_Persona.Text = .Item("cbdesc").ToString()
            _PCargarDetalleFechas(JMc_Persona.Value)
            _PCargarFeriadosAlCalendario()

            Tb_Fecha.Value = IIf(IsDBNull(.Item("pgfdoc")), Today, .Item("pgfdoc"))
            Tb_Obs.Text = .Item("pgobs").ToString
            Tb_FechaSalida.Value = IIf(IsDBNull(.Item("pgfsal")), Today, .Item("pgfsal"))
            Tb_FechaIngreso.Value = IIf(IsDBNull(.Item("pgfing")), Today, .Item("pgfing"))
            Tb_DiasPedidos.Value = .Item("pgdias")
        End With

    End Sub

    Public Overrides Function P_Validar() As Boolean
        Return Not _PValidar()
    End Function
    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False
        EP1.Clear()
        If Tb_Obs.Text = "" Then
            Tb_Obs.BackColor = Color.Red
            EP1.SetError(Tb_Obs, "Ingrese una observacion!")
            _Error = True
        Else
            Tb_Obs.BackColor = Color.White
            EP1.SetError(Tb_Obs, "")
        End If

        If Tb_DiasPedidos.Text = "" Then
            Tb_DiasPedidos.BackColor = Color.Red
            EP1.SetError(Tb_DiasPedidos, "Ingrese la cantidad de dias de vacacion!")
            _Error = True
        Else
            Tb_DiasPedidos.BackColor = Color.White
            EP1.SetError(Tb_DiasPedidos, "")
        End If

        If JMc_Persona.SelectedIndex < 0 Then
            JMc_Persona.BackColor = Color.Red
            EP1.SetError(JMc_Persona, "Seleccione una persona!")
            _Error = True
        Else
            JMc_Persona.BackColor = Color.White
            EP1.SetError(JMc_Persona, "")
        End If

        HighLigthter_Focus.UpdateHighlights()
        Return _Error
    End Function

    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        If P_Validar() = False Then
            Exit Sub
        End If
        If BBtn_Grabar.Enabled = False Then
            Exit Sub
        End If

        If BBtn_Grabar.Tag = 0 Then
            BBtn_Grabar.Tag = 1
            'BBtn_Grabar.Image = My.Resources.CONFIRMACION
            'BBtn_Grabar.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar1.Refresh()
            Exit Sub
        Else
            BBtn_Grabar.Tag = 0
            'BBtn_Grabar.Image = My.Resources.GRABAR
            'BBtn_Grabar.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If


        If _Nuevo Then
            L_PedidoVacacionCabecera_Grabar(Tb_Id.Text, JMc_Persona.Value, Tb_Fecha.Value.ToString("yyyy/MM/dd"), IIf(Tb_Estado.Value, "1", "0"), Tb_Obs.Text, Tb_FechaSalida.Value.ToString("yyyy/MM/dd"), Tb_FechaIngreso.Value.ToString("yyyy/MM/dd"), Tb_DiasPedidos.Text)

            'actualizar el grid de buscador
            _PCargarBuscador()

            Tb_Fecha.Focus()
            ToastNotification.Show(Me, "Pedido de Vacacion " + Tb_Id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            _PLimpiar()

        Else
            L_PedidoVacacionCabecera_Modificar(Tb_Id.Text, JMc_Persona.Value, Tb_Fecha.Value.ToString("yyyy/MM/dd"), IIf(Tb_Estado.Value, "1", "0"), Tb_Obs.Text, Tb_FechaSalida.Value.ToString("yyyy/MM/dd"), Tb_FechaIngreso.Value.ToString("yyyy/MM/dd"), Tb_DiasPedidos.Text)

            ToastNotification.Show(Me, "Pedido de Vacacion " + Tb_Id.Text + " Modificado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)

            'actualizar el grid de buscador
            _PCargarBuscador()

            _Nuevo = False 'aumentado danny
            _PInhabilitar()
            _PFiltrar()

        End If
    End Sub

    Private Sub _PCalcularFechaRegreso()
        Dim i As Integer
        'obtener dias feriados
        Dim dtFeriados As DataTable = L_Feriado_General(0).Tables(0)
        Dim listFeriados As New List(Of DateTime)
        For i = 0 To dtFeriados.Rows.Count - 1
            Dim fs As String = dtFeriados.Rows(i).Item("pfflib").ToString
            Dim f As DateTime = Convert.ToDateTime(fs)
            listFeriados.Add(f)
        Next

        'calcular la fecha de regreso sin tomar en cuenta los feriados y los sabados y domingos 
        i = 1
        Dim fecha As New DateTime
        fecha = Tb_FechaSalida.Value.ToShortDateString()

        'Limpiar calendario
        _PLimpiarCalendario()
        _PCargarDiaVacacionCalendario(fecha)
        Calendario.Refresh()

        While i <= Tb_DiasPedidos.Text
            If listFeriados.Contains(fecha) = False And (fecha.DayOfWeek = DayOfWeek.Sunday Or fecha.DayOfWeek = DayOfWeek.Saturday) = False Then
                i = i + 1
                _PCargarDiaVacacionCalendario(fecha)
            End If
            fecha = DateAdd(DateInterval.Day, 1, fecha)
        End While

        While listFeriados.Contains(fecha) Or fecha.DayOfWeek = DayOfWeek.Sunday Or fecha.DayOfWeek = DayOfWeek.Saturday
            fecha = DateAdd(DateInterval.Day, 1, fecha)
        End While
        Calendario.Refresh()
        '_PCargarDiaVacacionCalendario(fecha)
        Tb_FechaIngreso.Value = fecha
    End Sub

    Private Sub _PCargarFeriadosAlCalendario()
        Dim dtFechas As DataTable = L_Feriado_General(0).Tables(0)

        For i = 0 To dtFechas.Rows.Count - 1
            Dim fecha As DateTime = dtFechas.Rows(i).Item("pfflib")
            Dim desc As String = dtFechas.Rows(i).Item("pfdes")

            Dim dia As DayLabel = Calendario.GetDay(fecha)
            If Not dia Is Nothing Then
                dia.Image = My.Resources.Resources.FERIADO
                dia.ImageAlign = eLabelPartAlignment.MiddleRight
                dia.TextAlign = eLabelPartAlignment.MiddleLeft
                dia.Tooltip = "Click en la imagen para ver la descripcion"

                dia.SubItems.Add(New ButtonItem("Descripcion", desc))
            End If

        Next
    End Sub

    Private Sub _PCargarDiaVacacionCalendario(fecha As Date)
        Dim dia As DayLabel = Calendario.GetDay(fecha)
        If Not dia Is Nothing Then
            dia.TextAlign = eLabelPartAlignment.MiddleLeft
            dia.Tooltip = "Dia Pedido"
            dia.BackgroundStyle.BackColor = Color.LightGreen
        End If
        Calendario.Refresh()
    End Sub

    Private Sub _PLimpiarCalendario()
        'Dim primerDia As Date = Tb_FechaSalida.Value
        Dim primerDia As New Date(Tb_FechaSalida.Value.Year, Tb_FechaSalida.Value.Month, 1)
        Dim i As Integer
        For i = 1 To 31
            Dim dia As DayLabel = Calendario.GetDay(primerDia)
            If Not dia Is Nothing Then
                dia.TextAlign = eLabelPartAlignment.MiddleLeft
                dia.Tooltip = ""
                dia.BackgroundStyle.BackColor = Color.White
            End If
            primerDia = DateAdd(DateInterval.Day, 1, primerDia)
        Next

    End Sub


    Private Sub _PNuevoRegistro()
        _PHabilitar()
        BBtn_Nuevo.Enabled = True

        _PLimpiar()
        Tb_Fecha.Focus()
        _Nuevo = True
    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        _Modificar = True
        '_Modificar = True
        _PHabilitar()
        BBtn_Modificar.Enabled = True 'aumentado para q funcione con el modelo de guido
    End Sub

    Private Sub _PEliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("Esta seguro de Eliminar el Registro?", MsgBoxStyle.YesNo, "Advertencia")
        If _Result = MsgBoxResult.Yes Then
            'L_Feriado_Borrar(Tb_Id.Text)
            _PFiltrar()

            'mi codigo, actualizo el sub
            _Pos = 0
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub _PSalirRegistro()
        If BBtn_Grabar.Enabled = True Then
            _PInhabilitar()
            _PFiltrar()
        Else
            Me.Close()
        End If
    End Sub


    Private Sub _PPrimerRegistro()
        _Pos = 0
        _PMostrarRegistro(_Pos)
        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < _Dsencabezado.Tables(0).Rows.Count - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        _Pos = _Dsencabezado.Tables(0).Rows.Count - 1
        _PMostrarRegistro(_Pos)
        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
    End Sub

#End Region

    Private Sub JMc_Persona_ValueChanged(sender As Object, e As EventArgs) Handles JMc_Persona.ValueChanged
        If _Nuevo = True Or _Modificar = True Then
            If JMc_Persona.SelectedIndex >= 0 Then
                _PCargarDetalleFechas(JMc_Persona.Value)
                _PCargarFeriadosAlCalendario()
            End If
        End If


    End Sub

    Private Sub P_PedidoVacacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub Tb_DiasPedidos_TextChanged(sender As Object, e As EventArgs)
        'If IsNumeric(Tb_DiasPermitidos.Text) Then
        '    If Tb_DiasPedidos.Text > Tb_DiasPermitidos.Text Then
        '        Tb_DiasPedidos.Text = 0
        '    End If
        'Else
        '    Tb_DiasPedidos.Text = 0
        'End If

    End Sub

    Private Sub Tb_FechaSalida_ValueChanged(sender As Object, e As EventArgs) Handles Tb_FechaSalida.ValueChanged
        If _Nuevo = True Or _Modificar = True Then
            'actualizar el calendario
            Calendario.DisplayMonth = Tb_FechaSalida.Value

            'Tb_FechaIngreso.Value = DateAdd(DateInterval.Day, Int(Tb_DiasPedidos.Text), Tb_FechaSalida.Value)
            _PCalcularFechaRegreso()
        End If
    End Sub

    Private Sub Tb_DiasPedidos_ValueChanged(sender As Object, e As EventArgs) Handles Tb_DiasPedidos.ValueChanged
        If _Nuevo = True Or _Modificar = True Then
            If IsNumeric(Tb_DiasPedidos.Text) Then
                'Tb_FechaIngreso.Value = DateAdd(DateInterval.Day, Int(Tb_DiasPedidos.Text), Tb_FechaSalida.Value)
                _PCalcularFechaRegreso()
            Else
                Tb_FechaIngreso.Value = Tb_FechaSalida.Value
            End If
        End If


    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click
        _PNuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click
        _PModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click
        _PSalirRegistro()
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

    Private Sub Calendario_MonthChanged(sender As Object, e As EventArgs) Handles Calendario.MonthChanged
        _PCargarFeriadosAlCalendario()
    End Sub

    Private Sub JGr_DetalleFechas_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_DetalleFechas.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGr_Buscador_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Buscador.SelectionChanged
        If JGr_Buscador.Row >= 0 Then
            _Pos = JGr_Buscador.Row
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False And Tb_Id.Text <> String.Empty Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TP006", "pg", "pgnumi=" + Tb_Id.Text)
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
End Class