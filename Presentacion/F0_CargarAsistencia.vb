Imports Janus.Windows.GridEX
Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class F0_CargarAsistencia

#Region "Metodos Privados"
    Private Sub _prIniciarTodo()
        Me.Text = "c a r g a r    d a t o s    d e    a s i s t e n c i a s".ToUpper
        btGrabar.Enabled = False
    End Sub
    Private Sub _prCargarDatosAsistencia()
        Dim ruta As String = ""
        Dim nombre As String = ""
        If _fnsObtenerRuta(ruta, nombre) = True Then
            Try
                IO.File.Move(ruta + nombre + ".dat", ruta + nombre + ".txt")
            Catch ex As Exception

            End Try

            Dim listaFilas() As String = IO.File.ReadAllLines(ruta + "\" + nombre + ".txt")
            Dim numiP, fecha, hora As String

            Dim dtDatos As New DataTable
            dtDatos.Columns.Add("zaline")
            dtDatos.Columns.Add("zacper")
            dtDatos.Columns.Add("zafecha")
            dtDatos.Columns.Add("zahora")
            dtDatos.Columns.Add("zaest")

            For Each fila As String In listaFilas.ToArray
                Dim listaStrings As String() = fila.Split(New Char() {" ", vbTab}, StringSplitOptions.RemoveEmptyEntries)

                numiP = listaStrings(0)
                fecha = listaStrings(1)
                hora = listaStrings(2).Remove(listaStrings(2).Count - 3)
                dtDatos.Rows.Add(1, numiP, fecha, hora, 0)
            Next
            _prCargarGridDatos(dtDatos)
            btGrabar.Enabled = True
        End If

    End Sub
    Private Sub _prCargarGridDatos(dt As DataTable)

        grDatos.DataSource = dt
        grDatos.RetrieveStructure()

        'dar formato a las columnas
        'With grDatos.RootTable.Columns("cnnumi")
        '    .Caption = "Codigo"
        '    .Width = 70
        '    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '    .CellStyle.FontSize = gi_fuenteTamano
        '    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        'End With

        'With grDatos.RootTable.Columns("cnobs")
        '    .Caption = "OBSERVACION"
        '    .Width = 150
        '    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '    .CellStyle.FontSize = gi_fuenteTamano
        'End With

        'With grDatos.RootTable.Columns("cnfdoc")
        '    .Caption = "FECHA"
        '    .Width = 70
        '    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '    .CellStyle.FontSize = gi_fuenteTamano
        '    .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        'End With

        'With grDatos.RootTable.Columns("cnest")
        '    .Visible = False
        'End With

        'With grDatos.RootTable.Columns("cnest2")
        '    .Caption = "ESTADO"
        '    .Width = 70
        '    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '    .CellStyle.FontSize = gi_fuenteTamano
        'End With

        'With grDatos.RootTable.Columns("cnfact")
        '    .Visible = False
        'End With
        'With grDatos.RootTable.Columns("cnhact")
        '    .Visible = False
        'End With
        'With grDatos.RootTable.Columns("cnuact")
        '    .Visible = False
        'End With

        'Habilitar Filtradores
        With grDatos
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            '.FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub

    Private Sub _prGrabarDatos()
        Dim res As Boolean = L_prInterfazMarcadorGrabar(CType(grDatos.DataSource, DataTable))
        If res = True Then
            btGrabar.Enabled = False
            ToastNotification.Show(Me, "Se grabaron: ".ToUpper + grDatos.RowCount.ToString + " registros con Exito.".ToUpper, My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)

            _prGrabarDatosEnTablaTP0071()
        End If


    End Sub


    Private Function _fnsObtenerRuta(ByRef ruta As String, ByRef nombre As String) As Boolean

        'OFile.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        OFile.Filter = "|*.dat;*.txt"
        If OFile.ShowDialog() = DialogResult.OK Then
            nombre = IO.Path.GetFileNameWithoutExtension(OFile.FileName)
            ruta = IO.Path.GetDirectoryName(OFile.FileName)
            OFile.CheckFileExists = True
            Return True
        End If
        Return False
    End Function

    Private Sub _prGrabarDatosEnTablaTP0071()
        Dim dtFechas As DataTable
        Dim dtReg As DataTable
        Dim dtEmpleados As DataTable = L_prInterfazMarcadorGetEmpleados()
        Dim codPer As String
        Dim fecha As String

        Dim dtTP007 As New DataTable
        dtTP007.Columns.Add("pjturno")
        dtTP007.Columns.Add("pjcper")
        dtTP007.Columns.Add("pjent")
        dtTP007.Columns.Add("pjsal")
        dtTP007.Columns.Add("pjfecha")

        Dim dtTZ001Grabados As New DataTable
        dtTZ001Grabados.Columns.Add("zaline")
        dtTZ001Grabados.Columns.Add("zacper")
        dtTZ001Grabados.Columns.Add("zafecha")
        dtTZ001Grabados.Columns.Add("zahora")
        dtTZ001Grabados.Columns.Add("zaest")

        For i = 0 To dtEmpleados.Rows.Count - 1
            codPer = dtEmpleados.Rows(i).Item("zacper")
            dtFechas = L_prInterfazMarcadorGetFechas(codPer)
            If dtFechas.Rows.Count > 0 Then
                For j = 0 To dtFechas.Rows.Count - 1
                    fecha = CType(dtFechas.Rows(j).Item("zafecha"), Date).ToString("yyyy-MM-dd")
                    dtReg = L_prInterfazMarcadorGetHoras(fecha, codPer)
                    Dim tam As Integer = dtReg.Rows.Count
                    If tam = 1 Then
                        dtTP007.Rows.Add(1, codPer, dtReg.Rows(0).Item("zahora"), "", fecha)

                        dtTZ001Grabados.Rows.Add(dtReg.Rows(0).Item("zaline"))
                    End If

                    If tam = 2 Then
                        dtTP007.Rows.Add(1, codPer, dtReg.Rows(0).Item("zahora"), dtReg.Rows(1).Item("zahora"), fecha)

                        dtTZ001Grabados.Rows.Add(dtReg.Rows(0).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(1).Item("zaline"))

                    End If

                    If tam = 3 Then
                        dtTP007.Rows.Add(1, codPer, dtReg.Rows(0).Item("zahora"), dtReg.Rows(1).Item("zahora"), fecha)
                        dtTP007.Rows.Add(2, codPer, dtReg.Rows(2).Item("zahora"), "", fecha)

                        dtTZ001Grabados.Rows.Add(dtReg.Rows(0).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(1).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(2).Item("zaline"))

                    End If

                    If tam = 4 Then
                        dtTP007.Rows.Add(1, codPer, dtReg.Rows(0).Item("zahora"), dtReg.Rows(1).Item("zahora"), fecha)
                        dtTP007.Rows.Add(2, codPer, dtReg.Rows(2).Item("zahora"), dtReg.Rows(3).Item("zahora"), fecha)

                        dtTZ001Grabados.Rows.Add(dtReg.Rows(0).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(1).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(2).Item("zaline"))
                        dtTZ001Grabados.Rows.Add(dtReg.Rows(3).Item("zaline"))

                    End If
                Next
            End If

        Next

        'grabar todos los registros
        Dim res As Boolean = L_prAsistenciaGrabarTablaDetalle(dtTP007)

        If res = True Then
            Dim res2 As Boolean = L_prInterfazMarcadorModificarEstados(dtTZ001Grabados)
            If res2 = True Then

            End If

        End If

    End Sub

#End Region


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles btCargar.Click
        _prCargarDatosAsistencia()
    End Sub

    Private Sub btGrabar_Click(sender As Object, e As EventArgs) Handles btGrabar.Click
        _prGrabarDatos()
    End Sub

    Private Sub F0_ControlAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub
End Class