Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_SaldoMensuales

#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim DsGeneral As DataSet 'Dataset que contendra a todos los datatable
    Dim DtCabecera As DataTable 'Datatable de la cabecera
    Dim DtDetalle As DataTable 'Datatable del detalle de la cabecera

    Dim Dt1Saldos As DataTable
    Dim Dt2General As DataTable
    Dim Dt3KardexTotal As DataTable
    Dim Dt4Compara As DataTable

    Dim m1 As Byte
    Dim m2 As Byte
    Dim m3 As Byte
    Dim a1 As Int16
    Dim a2 As Int16
    Dim a3 As Int16
#End Region

#Region "Eventos"

    Private Sub P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Bt1Compara_Click(sender As Object, e As EventArgs) Handles Bt1Inicio.Click
        If (MessageBox.Show("Esta acción puede tardar varios minutos!!!" + Chr(13) + "Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            P_GenerarKardexCliente()
        End If
    End Sub

    Private Sub Bt2Imprimir_Click(sender As Object, e As EventArgs) Handles Bt2Imprimir.Click
        P_GenerarReporte()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabItem2.Visible = False
        PanelEx1.Visible = False
        PanelEx2.Visible = False

        Pb1Progreso.Visible = False

        Me.Text = "S A L D O S   M E N S U A L E S"
        SuperTabItem1.Text = "REGISTRO"

        P_ArmarCombos()
    End Sub

    Private Sub P_GenerarKardexCliente()
        Dt1Saldos = New DataTable
        Dt2General = New DataTable
        Dt3KardexTotal = New DataTable

        L_EliminarSaldoMensual("1 = 1")

        Dt1Saldos = L_ObtenerSaldoCliente(1, "").Tables(0)
        'Dt2General = L_ObtenerSaldosMensuales("hanumi = -1")

        Dim creT As Double = 0
        Dim pagT As Double = 0

        Dim cre1 As Double = 0
        Dim pag1 As Double = 0

        Dim cre2 As Double = 0
        Dim pag2 As Double = 0

        Dim cre3 As Double = 0
        Dim pag3 As Double = 0

        Pb1Progreso.Minimum = 0
        Pb1Progreso.Maximum = Dt1Saldos.Rows.Count
        Pb1Progreso.Visible = True
        Me.Refresh()
        Dim fecLim As New Date(a3, m3, 1)
        fecLim = fecLim.AddMonths(1).AddDays(-1)
        Dim numi As Integer = 0
        Dim desc As String = ""
        Dim mes1 As Double = 0
        Dim mes2 As Double = 0
        Dim mes3 As Double = 0
        Dim saldo As Double = 0

        For Each fil As DataRow In Dt1Saldos.Rows
            numi = CInt(fil.Item("idcodcli"))
            desc = fil.Item("ccdesc").ToString

            'Calculo de saldo a la fecha limite
            Dt3KardexTotal = L_VistaKadexClienteTodo(numi.ToString, fecLim.ToString("yyyy/MM/dd")).Tables(0)
            creT = 0
            pagT = 0
            If (Dt3KardexTotal.Rows.Count > 0) Then
                If (Not IsDBNull(Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'"))) Then
                    creT = Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'")
                End If
                pagT = Dt3KardexTotal.Compute("Sum(pago)", "ccli = " + fil.Item("idcodcli").ToString)
            End If
            saldo = creT - pagT

            'Calculo de saldo del mes 3
            Dt3KardexTotal = L_VistaKadexClienteMes(numi.ToString, m3.ToString, m3.ToString, a3.ToString, a3.ToString).Tables(0)
            cre3 = 0
            pag3 = 0
            If (Dt3KardexTotal.Rows.Count > 0) Then
                If (Not IsDBNull(Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'"))) Then
                    cre3 = Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'")
                End If
                pag3 = Dt3KardexTotal.Compute("Sum(pago)", "ccli = " + fil.Item("idcodcli").ToString)
            End If
            mes3 = cre3 - pag3

            'Calculo de saldo del mes 2
            Dt3KardexTotal = L_VistaKadexClienteMes(numi.ToString, m2.ToString, m2.ToString, a2.ToString, a2.ToString).Tables(0)
            cre2 = 0
            pag2 = 0
            If (Dt3KardexTotal.Rows.Count > 0) Then
                If (Not IsDBNull(Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'"))) Then
                    cre2 = Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'")
                End If
                pag2 = Dt3KardexTotal.Compute("Sum(pago)", "ccli = " + fil.Item("idcodcli").ToString)
            End If
            mes2 = cre2 - pag2

            'Calculo de saldo del mes 1 y anterior
            mes1 = saldo - mes3 - mes2
            mes2 = cre2
            mes3 = cre3

            pagT = pag3 + pag2

            'Descontar los pagos empesando del mes 1
            If (mes1 <= pagT) Then
                pagT = pagT - mes1
                mes1 = 0
            Else
                mes1 = mes1 - pagT
                pagT = 0
            End If

            If (mes2 <= pagT) Then
                pagT = pagT - mes2
                mes2 = 0
            Else
                mes2 = mes2 - pagT
                pagT = 0
            End If

            If (mes3 <= pagT) Then
                pagT = pagT - mes3
                mes3 = 0
            Else
                mes3 = mes3 - pagT
                pagT = 0
            End If

            L_GrabarSaldoMensual(
                                   "" + numi.ToString + ", " _
                                 + "'" + desc + "', " _
                                 + "" + mes1.ToString("0.00") + ", " _
                                 + "" + mes2.ToString("0.00") + ", " _
                                 + "" + mes3.ToString("0.00") + ", " _
                                 + "" + saldo.ToString("0.00") + ""
                                     )

            'Dt2General.Rows.Add({numi, desc, mes1, mes2, mes3, saldo})
            Pb1Progreso.Value = Pb1Progreso.Value + 1
        Next
        Pb1Progreso.Visible = False

        'Dt2General.DefaultView.Sort = "hasaldo DESC"
        'Dt2General = L_ObtenerSaldosMensuales("hasaldo <> 0 and hames1 <> 0 and hames2 <> 0 and hames3 <> 0")
        'Dt2General = L_ObtenerSaldosMensuales("hames1 <> 0 or hames2 <> 0 or hames3 <> 0")
        Dt2General = L_ObtenerSaldosMensuales("hasaldo <> 0")

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = Dt2General
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "numi"
            .Width = 80
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = "Razon Social"
            .Key = "desc"
            .Width = 300
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = MonthName(m1, False)
            .Key = "mes1"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = MonthName(m2, False)
            .Key = "mes2"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With Dgj1Busqueda.RootTable.Columns(4)
            .Caption = MonthName(m3, False)
            .Key = "mes3"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With

        With Dgj1Busqueda.RootTable.Columns(5)
            .Caption = "Saldo Kardex"
            .Key = "kar"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
            .FormatString = "0.00"
        End With


        'Habilitar Filtradores
        With Dgj1Busqueda
            .GroupByBoxVisible = False
            '.FilterRowFormatStyle.BackColor = Color.Blue
            '.DefaultFilterRowComparison = FilterConditionOperator.Contains
            '.FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'Diseño de la tabla
            .VisualStyle = VisualStyle.Office2007
            .AlternatingColors = True
        End With

    End Sub

#End Region

    Private Sub P_GenerarReporte()
        If (Dgj1Busqueda.GetRows.Count > 0) Then
            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If

            P_Global.Visualizador = New Visualizador

            Dim objrep As New R_SaldoMensuales
            objrep.SetDataSource(Dt2General)
            objrep.SetParameterValue("Mes1", MonthName(m1, False))
            objrep.SetParameterValue("Mes2", MonthName(m2, False))
            objrep.SetParameterValue("Mes3", MonthName(m3, False))

            P_Global.Visualizador.CRV1.ReportSource = objrep 'Comentar
            P_Global.Visualizador.Show() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar
        Else
            ToastNotification.Show(Me, "No hay registros para generar reporte".ToUpper,
                       My.Resources.INFORMATION,
                       Duracion * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_ArmarCombos()
        P_ArmarComboMeses()
        P_ArmarComboAnos()
    End Sub

    Private Sub P_ArmarComboMeses()
        Dim DtMeses As New DataTable
        DtMeses.Columns.Add("nro", Type.GetType("System.Int32"))
        DtMeses.Columns.Add("mes", Type.GetType("System.String"))

        For i = 1 To 12
            DtMeses.Rows.Add({i, MonthName(i, False)})
        Next

        With Cb1Meses.DropDownList
            .Columns.Clear()

            .Columns.Add(DtMeses.Columns("nro").ToString).Width = 60
            .Columns(0).Caption = "Nro."
            .Columns(0).Visible = True

            .Columns.Add(DtMeses.Columns("mes").ToString).Width = 120
            .Columns(1).Caption = "Mes"
            .Columns(1).Visible = True

            .ValueMember = DtMeses.Columns("nro").ToString
            .DisplayMember = DtMeses.Columns("mes").ToString
            .DataSource = DtMeses
            .Refresh()
        End With

        Cb1Meses.SelectedIndex = Now.Month - 1

    End Sub

    Private Sub Cb1Meses_ValueChanged(sender As Object, e As EventArgs) Handles Cb1Meses.ValueChanged
        If (Cb1Meses.SelectedIndex <> -1) Then
            Dim mes As Integer = Cb1Meses.SelectedIndex + 1
            Dim ano As Integer = Now.Year
            If (Not Cb2Ano.Text.Equals("")) Then
                ano = CInt(Cb2Ano.Text)
            End If
            Dim ffin As New Date(ano, mes, 1)
            Dim fini As Date = ffin.AddMonths(-2)
            Tb1Info.Clear()
            Tb1Info.Text = "Desde : " _
                           + MonthName(fini.Month, False) + " del " + fini.Year.ToString + vbCrLf _
                           + "Hasta : " _
                           + MonthName(ffin.Month, False) + " del " + ffin.Year.ToString
            m1 = fini.Month
            m2 = fini.AddMonths(1).Month
            m3 = ffin.Month
            a1 = fini.Year
            a2 = fini.AddMonths(1).Year
            a3 = ffin.Year
        End If
    End Sub

    Private Sub P_ArmarComboAnos()
        Dim DtAno As New DataTable
        DtAno.Columns.Add("ano", Type.GetType("System.Int32"))

        For i = 2016 To Now.Year
            DtAno.Rows.Add({i})
        Next

        With Cb2Ano.DropDownList
            .Columns.Clear()

            .Columns.Add(DtAno.Columns("ano").ToString).Width = 100
            .Columns(0).Caption = "Año"
            .Columns(0).Visible = True

            .ValueMember = DtAno.Columns("ano").ToString
            .DisplayMember = DtAno.Columns("ano").ToString
            .DataSource = DtAno
            .Refresh()
        End With

        Cb2Ano.SelectedIndex = Now.Year - 2016

    End Sub

    Private Sub Cb2Ano_ValueChanged(sender As Object, e As EventArgs) Handles Cb2Ano.ValueChanged
        If (Cb2Ano.SelectedIndex <> -1) Then
            Dim mes As Integer = Cb1Meses.SelectedIndex + 1
            Dim ffin As New Date(CInt(Cb2Ano.Text), mes, 1)
            Dim fini As Date = ffin.AddMonths(-2)
            Tb1Info.Clear()
            Tb1Info.Text = "Desde : " _
                           + MonthName(fini.Month, False) + " del " + fini.Year.ToString + vbCrLf _
                           + "Hasta : " _
                           + MonthName(ffin.Month, False) + " del " + ffin.Year.ToString
            m1 = fini.Month
            m2 = fini.AddMonths(1).Month
            m3 = ffin.Month
            a1 = fini.Year
            a2 = fini.AddMonths(1).Year
            a3 = ffin.Year
        End If
    End Sub
End Class