Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar

Public Class P_ComparaSaldoProducto

#Region "Variables Globales"
    Dim M As Integer
    Public Property Tipo
        Get
            Return M
        End Get
        Set(value)
            M = value
        End Set
    End Property

    Dim Duracion As Integer = 5 'Duracion es segundo de los mensajes tipo (Toast)
    Dim DtSaldos As DataTable

#End Region

#Region "Eventos"

    Private Sub P_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Dgj1Busqueda_EditingCell(sender As Object, e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Dgj1Busqueda.EditingCell
        e.Cancel = True
    End Sub

    Private Sub Bt1Compara_Click(sender As Object, e As EventArgs) Handles Bt1Compara.Click
        P_GenerarProdutos()
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
        Dim nom As String
        If M = 0 Then
            nom = " P R O D U C T O S"
        Else
            nom = " E Q U I P O S"
        End If
        Me.Text = "C O M P A R A R  S A L D O V S " + nom
        SuperTabItem1.Text = "REGISTRO"
    End Sub

    Private Sub P_GenerarProdutos()
        DtSaldos = New DataTable

        DtSaldos = L_prTraerDesiguales(M)

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = DtSaldos
        Dgj1Busqueda.RetrieveStructure()

        EstructuraGrilla()

        If DtSaldos.Rows.Count = 0 Then
            ToastNotification.Show(Me, "No hay registros para actualizar!!!".ToUpper,
                     My.Resources.INFORMATION,
                     Duracion * 1000,
                     eToastGlowColor.Blue,
                     eToastPosition.BottomLeft)
        End If

    End Sub


    Private Sub ActualizarGrilla()
        DtSaldos = New DataTable

        DtSaldos = L_prTraerDesiguales(M)

        Dgj1Busqueda.BoundMode = Janus.Data.BoundMode.Bound
        Dgj1Busqueda.DataSource = DtSaldos
        Dgj1Busqueda.RetrieveStructure()

        EstructuraGrilla()

    End Sub

    Private Sub EstructuraGrilla()
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
            .Caption = "Producto"
            .Key = "prod"
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

        With Dgj1Busqueda.RootTable.Columns(4)
            .Visible = False
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
        If Dgj1Busqueda.RowCount > 0 Then
            If (MessageBox.Show("Se actualizaran todos los registros de la tabla!!!" + Chr(13) + "Desea continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim dt As DataTable = CType(Dgj1Busqueda.DataSource, DataTable)
                Dim dt2 = L_prActualizarSaldos(dt)
                If dt2.Rows.Count > 0 Then
                    ToastNotification.Show(Me, "Saldo actualizados correctamente!!!".ToUpper,
                           My.Resources.OK,
                           Duracion * 300,
                           eToastGlowColor.Green,
                           eToastPosition.MiddleCenter)
                End If
                ActualizarGrilla()
            Else
                Exit Sub
            End If
        End If
    End Sub



End Class