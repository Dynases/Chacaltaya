Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_Compara

#Region "Variables Globales"

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim DsGeneral As DataSet 'Dataset que contendra a todos los datatable
    Dim DtCabecera As DataTable 'Datatable de la cabecera
    Dim DtDetalle As DataTable 'Datatable del detalle de la cabecera

    Dim Dt1Saldos As DataTable
    Dim Dt2General As DataTable
    Dim Dt3KardexTotal As DataTable
    Dim Dt4Compara As DataTable
#End Region

#Region "Eventos"

    Private Sub P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Bt1Compara_Click(sender As Object, e As EventArgs) Handles Bt1Compara.Click
        If (MessageBox.Show("Esta acción puede tardar varios minutos!!!" + Chr(13) + "Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            P_GenerarKardexCliente()
        End If
    End Sub

    Private Sub Bt2ActualizarSaldos_Click(sender As Object, e As EventArgs) Handles Bt2ActualizarSaldos.Click
        P_ActualizarSaldos()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        SuperTabItem2.Visible = False
        PanelEx1.Visible = False
        PanelEx2.Visible = False

        Pb1Comparando.Visible = False

        Me.Text = "C O M P A R A R   S A L D O S   V S   K A R D E X"
        SuperTabItem1.Text = "REGISTRO"
    End Sub

    Private Sub P_GenerarKardexCliente()
        Dt1Saldos = New DataTable
        Dt2General = New DataTable
        Dt3KardexTotal = New DataTable
        Dt4Compara = New DataTable
        Dim filas As DataRow()

        Dt1Saldos = L_ObtenerSaldoCliente(1, "").Tables(0)

        Dt2General = Dt1Saldos.Clone
        Dt2General.Columns(0).ColumnName = "cod"
        Dt2General.Columns(1).ColumnName = "nom"
        Dt2General.Columns(2).ColumnName = "sal"
        Dt2General.Columns.Add("kar")
        Dt2General.Columns("kar").DataType = System.Type.GetType("System.Double")

        Dim creT As Double = 0
        Dim pagT As Double = 0
        Pb1Comparando.Maximum = 0
        Pb1Comparando.Maximum = Dt1Saldos.Rows.Count
        Pb1Comparando.Visible = True
        For Each fil As DataRow In Dt1Saldos.Rows
            Dt3KardexTotal = L_VistaKadexClienteTodo(fil.Item("idcodcli").ToString).Tables(0)

            creT = 0
            pagT = 0
            If (Dt3KardexTotal.Rows.Count > 0) Then
                If (Not IsDBNull(Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'"))) Then
                    creT = Dt3KardexTotal.Compute("Sum(cre)", "ccli = " + fil.Item("idcodcli").ToString + " and tipo <>'ENTREGA'")
                End If
                pagT = Dt3KardexTotal.Compute("Sum(pago)", "ccli = " + fil.Item("idcodcli").ToString)
            End If

            Dt2General.Rows.Add({fil.Item("idcodcli"), fil.Item("ccdesc"), fil.Item("idsaldo"), creT - pagT})
            Pb1Comparando.Value = Pb1Comparando.Value + 1
        Next
        Pb1Comparando.Visible = False

        Dt4Compara = Dt2General.Clone
        filas = Dt2General.Select(" sal<>kar ", " kar ")
        For Each fil As DataRow In filas
            If (Math.Round(CDbl(fil.Item("sal")), 2) <> Math.Round(CDbl(fil.Item("kar")), 2)) Then
                Dt4Compara.ImportRow(fil)
            End If
        Next
        Dt4Compara.DefaultView.Sort = "kar DESC"


        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = Dt4Compara.DefaultView
        Dgj1Busqueda.RetrieveStructure()

        'dar formato a las columnas
        With Dgj1Busqueda.RootTable.Columns(0)
            .Caption = "Código"
            .Key = "cod"
            .Width = 120
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(1)
            .Caption = "Razon Social"
            .Key = "nom"
            .Width = 400
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(2)
            .Caption = "Saldo"
            .Key = "sal"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
        End With

        With Dgj1Busqueda.RootTable.Columns(3)
            .Caption = "Saldo Kardex"
            .Key = "kar"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            '.CellStyle.BackColor = Color.AliceBlue
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

    Private Sub P_ActualizarSaldos()
        If (Dgj1Busqueda.GetRows.Count > 0) Then
            If (MessageBox.Show("Se actualizaran todos los registros de la tabla!!!" + Chr(13) + "Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If
            Pb1Comparando.Visible = True
            Pb1Comparando.Minimum = 0
            Pb1Comparando.Maximum = Dgj1Busqueda.GetRows.Count
            For Each fil As GridEXRow In Dgj1Busqueda.GetRows
                L_Actualizar_SaldoTotal(fil.Cells("cod").Value.ToString, fil.Cells("kar").Value.ToString)
                Pb1Comparando.Value = Pb1Comparando.Value + 1
            Next
            Pb1Comparando.Visible = False
            Dt4Compara = New DataTable
            Dgj1Busqueda.DataSource = Dt4Compara
            ToastNotification.Show(Me, "Saldo actualizados correctamente!!!".ToUpper,
                       My.Resources.OK,
                       Duracion * 300,
                       eToastGlowColor.Green,
                       eToastPosition.MiddleCenter)
        Else
            ToastNotification.Show(Me, "No hay registros para actualizar!!!".ToUpper,
                       My.Resources.INFORMATION,
                       Duracion * 1000,
                       eToastGlowColor.Blue,
                       eToastPosition.BottomLeft)
        End If
    End Sub



End Class