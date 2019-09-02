Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Public Class F0_MarcacionCorrecion


#Region "Atributos privados"
    Dim _dtsMarcaciones As DataSet
    Dim _dtsTurnos As DataSet
    Dim _datosCargados As Boolean
    Dim _listaCorregir As List(Of List(Of Integer))
    Dim _dtRegistros As DataTable
#End Region
#Region "Metodos privados"
    Private Sub _prIniciarTodo()
        Me.Text = "C o r r e c i ó n    d e    m a r c a d o    d e l    p e r s o n a l".ToUpper
        Me.WindowState = FormWindowState.Maximized

        tbAnio.Value = Now.Year
        tbMes.Value = Now.Month
        _dtsMarcaciones = New DataSet
        _dtsTurnos = New DataSet
        _dtRegistros = New DataTable
        _datosCargados = False
        _listaCorregir = New List(Of List(Of Integer))

        '_prCargarGridPersonal()
        '_prCargarGrillaMarcaciones()
    End Sub
    Private Sub _prCargarGridPersonal()
        Dim dt As New DataTable
        dt = L_prPersonaAyudaTodosGeneralCorrMarcado()

        grPersonal.DataSource = dt
        grPersonal.RetrieveStructure()


        'dar formato a las columnas
        With grPersonal.RootTable.Columns("panumi")
            .Visible = False
        End With

        With grPersonal.RootTable.Columns("panom1")
            .Caption = "Nombre"
            .Width = 250
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .AllowSort = False
        End With


        With grPersonal.RootTable.Columns("estado")
            .Visible = True
        End With

        'Habilitar Filtradores
        With grPersonal
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            grPersonal.VisualStyle = VisualStyle.Office2007
        End With
        grPersonal.SelectionMode = SelectionMode.SingleSelection


        'cargar condicion
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(grPersonal.RootTable.Columns("estado"), ConditionOperator.Equal, 1)
        fc.FormatStyle.BackColor = Color.IndianRed
        grPersonal.RootTable.FormatConditions.Add(fc)

        grPersonal.Row = dt.Rows.Count - 1
    End Sub
    Private Sub _prCargarGrillaMarcaciones(pos As Integer)
        Dim fecha As DateTime = New DateTime(tbAnio.Value, tbMes.Value, 1)
        Dim ultDia As Integer = DateSerial(Year(fecha), Month(fecha) + 1, 0).Day

        Dim dt As DataTable
        dt = _dtsMarcaciones.Tables(pos) 'L_prAsistenciaCorreccionEstructura()
        grHorario.DataSource = dt

        Dim dtCabecera As DataTable = L_prAsistenciaCorreccionEstructura()
        grCabecera.DataSource = dtCabecera

        Dim diasCorreciones As List(Of Integer) = _listaCorregir.Item(pos)
        Dim fuente As New Font("Tahoma", 10, FontStyle.Regular)
        For i = 1 To 31
            Dim col As String = "d" + Str(i).Trim
            With grHorario.Columns(col) '"d" + Str(i)
                .DefaultCellStyle.BackColor = Color.White
                If fecha.DayOfWeek = DayOfWeek.Sunday Then
                    .DefaultCellStyle.BackColor = Color.OrangeRed
                End If
                If fecha.DayOfWeek = DayOfWeek.Saturday Then
                    .DefaultCellStyle.BackColor = Color.Yellow
                End If
                If diasCorreciones.Contains(i) Then
                    .DefaultCellStyle.BackColor = Color.LightBlue
                End If

                fecha = fecha.AddDays(-1)
                .HeaderText = Str(i) '+ "(" + WeekdayName(Weekday(fecha), True, FirstDayOfWeek.Monday) + ")"
                grCabecera.Columns(col).HeaderText = WeekdayName(Weekday(fecha), True, FirstDayOfWeek.Monday)
                fecha = fecha.AddDays(1)
                .HeaderCell.Style.Font = fuente
                .Width = 40
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                fecha = fecha.AddDays(1)
                .Visible = True

                grCabecera.Columns(col).HeaderCell.Style.Font = fuente
                grCabecera.Columns(col).Width = 40
                grCabecera.Columns(col).Visible = True
                If i > ultDia Then
                    .Visible = False
                    grCabecera.Columns(col).Visible = False
                End If

            End With
        Next
        grHorario.AllowUserToAddRows = False
        grHorario.Refresh()

        'pongo el menu
        grHorario.ContextMenuStrip = msOpsHorario
        grHorario.AllowDrop = False
        grHorario.AllowUserToOrderColumns = False
        For Each col As DataGridViewColumn In grHorario.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
    Private Sub _prCargarMarcacion()
        _prCargarGridPersonal()
        grHorario.DataSource = Nothing
        btnGrabar.Enabled = False

        _dtsMarcaciones.Tables.Clear()
        _dtsTurnos.Tables.Clear()
        _dtRegistros.Rows.Clear()
        _listaCorregir = New List(Of List(Of Integer))
        Dim dtTurnoFin As DataTable

        Dim fecha As DateTime = New Date(tbAnio.Value, tbMes.Value, 1)
        Dim dt, dtGrabados, dtFin, dtPlantilla As DataTable
        Dim dtReg As DataTable = L_prAsistenciaCorreccionGetTZ001(fecha.ToString("yyyy/MM/dd"))
        _dtRegistros = dtReg
        Dim ultDia As Integer = DateSerial(Year(fecha), Month(fecha) + 1, 0).Day
        dtPlantilla = L_prAsistenciaCorreccionEstructura() 'CType(grHorario.DataSource, DataTable)
        dtPlantilla.Rows.Clear()
        Dim dtPersonal As DataTable = CType(grPersonal.DataSource, DataTable)
        Dim numiPer As String
        If dtReg.Rows.Count = 0 Then
            ToastNotification.Show(Me, "no existen marcaciones en el mes y año seleccionados ".ToUpper, My.Resources.INFORMATION, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
        End If

        For Each fila As DataRow In dtPersonal.Rows
            _listaCorregir.Add(New List(Of Integer))

            numiPer = fila.Item("panumi")
            dtFin = New DataTable
            dtFin = dtPlantilla.Copy

            dtTurnoFin = L_prAsistenciaCorreccionGetTurnoPorPersona(New DateTime(fecha.Year, fecha.Month, 1).ToString("yyyy/MM/dd"), numiPer)
            If dtTurnoFin.Rows.Count = 0 Then
                dtTurnoFin = L_prAsistenciaCorreccionGetTurnoPorPersonaAnteriorMeses(New DateTime(fecha.Year, fecha.Month, 1).ToString("yyyy/MM/dd"), numiPer)
            End If

            'dtFin.Rows.Clear()
            If dtReg.Rows.Count > 0 Then
                Dim filasFiltradas2 As DataRow()
                filasFiltradas2 = dtReg.Select("zacper=" + numiPer, "zahora asc")
                If filasFiltradas2.Count > 0 And dtTurnoFin.Rows.Count > 0 Then
                    dt = filasFiltradas2.CopyToDataTable
                    If dt.Rows.Count > 0 Then
                        For i = 0 To ultDia - 1
                            Dim fechaDia As String = New DateTime(fecha.Year, fecha.Month, i + 1).ToString("yyyy/MM/dd")

                            'dtGrabados = dtReg.Select("zacper=" + numiPer + " and zafecha='" + fechaDia + "'", "zahora asc").CopyToDataTable
                            Dim filasFiltradas As DataRow()
                            filasFiltradas = dtReg.Select("zacper=" + numiPer + " and zafecha='" + fechaDia + "'", "zahora asc")

                            If filasFiltradas.Count > 0 Then
                                dtGrabados = filasFiltradas.CopyToDataTable
                                Dim cantMarcaciones As Integer
                                If dtTurnoFin.Rows.Count = 1 Then
                                    cantMarcaciones = dtTurnoFin.Rows(0).Item("nTurnos") * 2
                                Else
                                    Dim q As Integer = 0
                                    While fechaDia <= CType(dtTurnoFin.Rows(q).Item("pifdoc"), Date) And q < dtTurnoFin.Rows.Count
                                        q = q + 1
                                    End While
                                    cantMarcaciones = dtTurnoFin.Rows(q).Item("nTurnos") * 2
                                End If

                                If dtGrabados.Rows.Count <> cantMarcaciones Then
                                    fila.Item("estado") = 1
                                    'cargo a la lista de dias que faltan corregir
                                    _listaCorregir.Last.Add(i + 1)

                                    'incremento filas en el caso que la cantidad de filas que ya hay en el datatble final sean menores a la cantidad de marciones que debe haber
                                    If dtFin.Rows.Count < cantMarcaciones Then
                                        Dim diferencia2 As Integer = cantMarcaciones - dtFin.Rows.Count
                                        For jj = 1 To diferencia2
                                            dtFin.Rows.Add()
                                        Next
                                    End If
                                End If

                                If dtFin.Rows.Count < dtGrabados.Rows.Count Then
                                    Dim diferencia As Integer = dtGrabados.Rows.Count - dtFin.Rows.Count
                                    For j = 1 To diferencia
                                        dtFin.Rows.Add()
                                    Next
                                End If

                                For k = 0 To dtGrabados.Rows.Count - 1
                                    dtFin.Rows(k).Item(i) = dtGrabados.Rows(k).Item("zahora")
                                Next
                            End If

                        Next
                    End If
                End If

            End If

            _dtsMarcaciones.Tables.Add(dtFin)
            _dtsTurnos.Tables.Add(dtTurnoFin)
        Next

        _datosCargados = True
    End Sub

    Private Sub _prGrabarMarcacion()
        Const conMañana As Integer = 1
        Const conTarde As Integer = 2
        Dim dtGrabacion As DataTable
        dtGrabacion = New DataTable
        dtGrabacion.Columns.Add("pjturno", GetType(Integer))
        dtGrabacion.Columns.Add("pjcper", GetType(Integer))
        dtGrabacion.Columns.Add("pjent", GetType(String))
        dtGrabacion.Columns.Add("pjsal", GetType(String))
        dtGrabacion.Columns.Add("pjfecha", GetType(Date))
        Dim dtPersonal As DataTable = CType(grPersonal.DataSource, DataTable)
        Dim fecha As DateTime = New Date(tbAnio.Value, tbMes.Value, 1)
        Dim ultDia As Integer = DateSerial(Year(fecha), Month(fecha) + 1, 0).Day
        Dim ii As Integer = 0
        For Each fila As DataRow In dtPersonal.Rows
            Dim tabla As DataTable = _dtsMarcaciones.Tables(ii)
            Dim numiPer As String = fila.Item("panumi")
            If tabla.Rows.Count > 0 Then
                For i = 0 To ultDia - 1
                    Dim fechaDia As String = New DateTime(fecha.Year, fecha.Month, i + 1).ToString("yyyy/MM/dd")
                    If IsDBNull(tabla.Rows(0).Item(i)) = False Then
                        If tabla.Rows(0).Item(i) <> String.Empty Then
                            For j = 0 To tabla.Rows.Count - 1 Step +2
                                If IsDBNull(tabla.Rows(j).Item(i)) Then
                                    Exit For
                                Else
                                    If tabla.Rows(j).Item(i) = String.Empty Then
                                        Exit For
                                    Else
                                        Dim entrada As String = tabla.Rows(j).Item(i)
                                        Dim salida As String = tabla.Rows(j + 1).Item(i)
                                        If j = 0 Then
                                            dtGrabacion.Rows.Add(conMañana, numiPer, entrada, salida, fechaDia)
                                        Else
                                            dtGrabacion.Rows.Add(conTarde, numiPer, entrada, salida, fechaDia)
                                        End If
                                    End If
                                End If

                            Next
                        End If
                    End If
                Next
            End If
            ii = ii + 1
        Next

        Dim resp As Boolean = L_prAsistenciaGrabarTablaMarcaciones(dtGrabacion, _dtRegistros)
        If resp Then
            ToastNotification.Show(Me, "se grabo correctamente las marcaciones del mes y año seleccionados".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            grPersonal.DataSource = Nothing
            grHorario.DataSource = Nothing
            btnGrabar.Enabled = False
        End If

    End Sub

    Private Sub _prVerificarTodoCorrecto()
        Dim cant As Integer = grPersonal.GetTotal(grPersonal.RootTable.Columns("estado"), AggregateFunction.Max)
        If cant = 0 Then
            btnGrabar.Enabled = True
        End If

    End Sub
#End Region

    Private Sub F0_MarcadoCorreccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub tbAnio_ValueChanged(sender As Object, e As EventArgs) Handles tbAnio.ValueChanged
        '_prCargarGrillaMarcaciones()
    End Sub

    Private Sub tbMes_ValueChanged(sender As Object, e As EventArgs) Handles tbMes.ValueChanged
        '_prCargarGrillaMarcaciones()
    End Sub

    Private Sub grPersonal_SelectionChanged(sender As Object, e As EventArgs) Handles grPersonal.SelectionChanged
        If grPersonal.Row >= 0 And _datosCargados Then
            lbPersonal.Text = grPersonal.GetValue("panom1").ToString
            Dim dtTurno As DataTable = _dtsTurnos.Tables(grPersonal.Row)
            If dtTurno.Rows.Count > 0 Then
                _prCargarGrillaMarcaciones(grPersonal.Row)
            Else
                ToastNotification.Show(Me, "este personal no cuenta con turno asignado".ToUpper, My.Resources.INFORMATION, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
                grHorario.DataSource = Nothing
            End If
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        _prCargarMarcacion()
        _prVerificarTodoCorrecto()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub ELIMINARREGISTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARREGISTROToolStripMenuItem.Click
        Dim f, c As Integer
        f = grHorario.CurrentCell.RowIndex
        c = grHorario.CurrentCell.ColumnIndex
        Dim dt As DataTable = _dtsMarcaciones.Tables(grPersonal.Row)
        'Dim i As Integer = f
        'While i <= dt.Rows.Count - 2 And
        '    dt.Rows(f).Item(c) = dt.Rows(f + 1).Item(c)
        'End While
        For i = f To dt.Rows.Count - 2
            dt.Rows(i).Item(c) = dt.Rows(i + 1).Item(c)
        Next
        dt.Rows(dt.Rows.Count - 1).Item(c) = Nothing

        'ahora pregunto si es que ya son iguales la cantidad de marcaciones que se hizo con los que debe haber
        Dim ii As Integer = 0
        While ii < dt.Rows.Count
            If IsNothing(dt.Rows(ii).Item(c)) Or IsDBNull(dt.Rows(ii).Item(c)) Then
                Exit While
                'Else
                '    If dt.Rows(ii).Item(c) = String.Empty Then
                '        Exit While
                '    End If
            End If
            ii = ii + 1
        End While

        Dim fechaDia As Date = New Date(tbAnio.Value, tbMes.Value, c + 1)
        Dim cantMarcaciones As Integer
        If _dtsTurnos.Tables(grPersonal.Row).Rows.Count = 1 Then
            cantMarcaciones = _dtsTurnos.Tables(grPersonal.Row).Rows(0).Item("nTurnos") * 2
        Else
            Dim q As Integer = 0
            While fechaDia <= CType(_dtsTurnos.Tables(grPersonal.Row).Rows(q).Item("pifdoc"), Date) And q < _dtsTurnos.Tables(grPersonal.Row).Rows.Count
                q = q + 1
            End While
            cantMarcaciones = _dtsTurnos.Tables(grPersonal.Row).Rows(q).Item("nTurnos") * 2
        End If

        If ii = cantMarcaciones Then
            Dim pos As Integer = _listaCorregir.Item(grPersonal.Row).IndexOf(c + 1)
            _listaCorregir.Item(grPersonal.Row).RemoveAt(pos)
            grHorario.Columns(c).DefaultCellStyle.BackColor = Color.White
            If _listaCorregir.Item(grPersonal.Row).Count = 0 Then
                grPersonal.GetRow(grPersonal.Row).BeginEdit()
                grPersonal.CurrentRow.Cells.Item("estado").Value = 0
                grPersonal.Refresh()
            End If
        End If

    End Sub

    Private Sub grHorario_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grHorario.CellEndEdit
        Dim f, c As Integer
        f = grHorario.CurrentCell.RowIndex
        c = grHorario.CurrentCell.ColumnIndex
        Dim dt As DataTable = _dtsMarcaciones.Tables(grPersonal.Row)

        'ahora pregunto si es que ya son iguales la cantidad de marcaciones que se hizo con los que debe haber
        Dim ii As Integer = 0
        While ii < dt.Rows.Count
            If IsNothing(dt.Rows(ii).Item(c)) Or IsDBNull(dt.Rows(ii).Item(c)) Then
                Exit While
                'Else
                '    If dt.Rows(ii).Item(c) = String.Empty Then
                '        Exit While
                '    End If
            End If
            ii = ii + 1
        End While

        Dim fechaDia As Date = New Date(tbAnio.Value, tbMes.Value, c + 1)
        Dim cantMarcaciones As Integer
        If _dtsTurnos.Tables(grPersonal.Row).Rows.Count = 1 Then
            cantMarcaciones = _dtsTurnos.Tables(grPersonal.Row).Rows(0).Item("nTurnos") * 2
        Else
            Dim q As Integer = 0
            While fechaDia <= CType(_dtsTurnos.Tables(grPersonal.Row).Rows(q).Item("pifdoc"), Date) And q < _dtsTurnos.Tables(grPersonal.Row).Rows.Count
                q = q + 1
            End While
            cantMarcaciones = _dtsTurnos.Tables(grPersonal.Row).Rows(q).Item("nTurnos") * 2
        End If

        If ii = cantMarcaciones Then
            Dim pos As Integer = _listaCorregir.Item(grPersonal.Row).IndexOf(c + 1)
            _listaCorregir.Item(grPersonal.Row).RemoveAt(pos)
            grHorario.Columns(c).DefaultCellStyle.BackColor = Color.White
            If _listaCorregir.Item(grPersonal.Row).Count = 0 Then
                grPersonal.GetRow(grPersonal.Row).BeginEdit()
                grPersonal.CurrentRow.Cells.Item("estado").Value = 0
                grPersonal.Refresh()
                _prVerificarTodoCorrecto()
            End If

        End If
    End Sub

    Private Sub grHorario_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grHorario.CellBeginEdit

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        _prGrabarMarcacion()
    End Sub

End Class