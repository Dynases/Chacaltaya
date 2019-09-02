Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_UltimosPedidos

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5
    Dim StTextoReporte As String = ""

#End Region

#Region "Eventos"

    Private Sub PR_EntregaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()

        'L_abrirConexion()

        Dt1Desde.Value = Now.Date

        P_LLenarCombos()
        If (CType(CbZona.DataSource, DataTable).Rows.Count > 0) Then
            CbZona.SelectedIndex = 0
        End If
        If (CType(CbCliente.DataSource, DataTable).Rows.Count > 0) Then
            CbCliente.SelectedIndex = 0
        End If
        If (CType(CbEquipo.DataSource, DataTable).Rows.Count > 0) Then
            CbEquipo.SelectedIndex = 0
        End If
        CbZona.Select()
    End Sub

    Private Sub P_LLenarCombos()
        Dim Dt As New DataTable
        Dim item As ComboItem

        'Zona

        Dim _Ds As New DataSet
        _Ds = L_ObtenerZona()

        'lccbnumi, cbdesc, lanumi, lacity, c.cedesc, laprovi, cc.cedesc, lazona, ccc.cedesc, lacolor
        Dim f As DataRow
        f = _Ds.Tables(0).NewRow
        f.Item(0) = 0
        f.Item(1) = "TODOS"
        f.Item(2) = 0
        f.Item(3) = 0
        f.Item(4) = "TODOS"
        f.Item(5) = 0
        f.Item(6) = "TODOS"
        f.Item(7) = 0
        f.Item(8) = "TODOS"
        f.Item(9) = ""
        _Ds.Tables(0).Rows.InsertAt(f, 0)

        With CbZona.DropDownList
            .Columns.Clear()
            .Columns.Add(_Ds.Tables(0).Columns(1).ToString).Width = 300
            .Columns(0).Caption = "Repartidor"

            .Columns.Add(_Ds.Tables(0).Columns(4).ToString).Width = 120
            .Columns(1).Caption = "Dpto."

            .Columns.Add(_Ds.Tables(0).Columns(6).ToString).Width = 120
            .Columns(2).Caption = "Provincia"

            .Columns.Add(_Ds.Tables(0).Columns(8).ToString).Width = 120
            .Columns(2).Caption = "Zona"

        End With
        
        With CbZona
            .ValueMember = _Ds.Tables(0).Columns(2).ToString
            .DisplayMember = _Ds.Tables(0).Columns(8).ToString
            .DataSource = _Ds.Tables(0)
            .Refresh()
        End With

        'Cliente
        _Ds = New DataSet
        _Ds = L_ObtenerCliente()

        Dim f1 As DataRow
        f1 = _Ds.Tables(0).NewRow
        f1.Item(0) = 0
        f1.Item(1) = "TODOS"
        _Ds.Tables(0).Rows.InsertAt(f1, 0)

        With CbCliente.DropDownList
            .Columns.Clear()
            .Columns.Add(_Ds.Tables(0).Columns(0).ToString).Width = 80
            .Columns(0).Caption = "Código"

            .Columns.Add(_Ds.Tables(0).Columns(1).ToString).Width = 300
            .Columns(1).Caption = "Nombre"

        End With

        With CbCliente
            .ValueMember = _Ds.Tables(0).Columns(0).ToString
            .DisplayMember = _Ds.Tables(0).Columns(1).ToString
            .DataSource = _Ds.Tables(0)
            .Refresh()
        End With

        'Equipo
        _Ds = New DataSet
        _Ds = L_ObtenerEquipo()

        Dim f2 As DataRow
        f2 = _Ds.Tables(0).NewRow
        f2.Item(0) = 0
        f2.Item(1) = "TODOS"
        _Ds.Tables(0).Rows.InsertAt(f2, 0)

        With CbEquipo.DropDownList
            .Columns.Clear()
            .Columns.Add(_Ds.Tables(0).Columns(0).ToString).Width = 80
            .Columns(0).Caption = "Código"

            .Columns.Add(_Ds.Tables(0).Columns(1).ToString).Width = 200
            .Columns(1).Caption = "Nombre"
        End With

        With CbEquipo
            .ValueMember = _Ds.Tables(0).Columns(0).ToString
            .DisplayMember = _Ds.Tables(0).Columns(1).ToString
            .DataSource = _Ds.Tables(0)
            .Refresh()
        End With

    End Sub

    Private Sub P_GenerarReporte()
        Dim _Ds As DataSet
        _Ds = L_ObtenerUltimosPedidos(Tb1CodZona.Text, Tb2CodCliente.Text, Tb3CodEquipo.Text, Dt1Desde.Value.Date.ToString("yyyy/MM/dd"))
        If (_Ds.Tables(0).Rows.Count > 0) Then
            Dim objrep As New R_UltimosPedidos

            objrep.SetDataSource(_Ds.Tables(0))


            objrep.SetParameterValue("Fecha", Dt1Desde.Value.ToShortDateString)
            objrep.SetParameterValue("Zona", StTextoReporte)

            Cr1Reporte.ReportSource = objrep

            Cr1Reporte.Show()
            Cr1Reporte.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, _DuracionSms * 1000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_Cancelar()
        If (CbZona.SelectedIndex = 0 And CbCliente.SelectedIndex = 0 And CbEquipo.SelectedIndex = 0) Then
            Me.Dispose()
            Me.Close()
        Else
            Dt1Desde.Value = Now.Date
            CbZona.SelectedIndex = 0
            CbCliente.SelectedIndex = 0
            CbEquipo.SelectedIndex = 0
        End If
    End Sub

#End Region

    Private Sub Bt1Generar_Click(sender As Object, e As ClickEventArgs) Handles Bt1Generar.Click
        P_GenerarReporte()
    End Sub

    Private Sub Bt2Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bt2Cancelar.Click
        P_Cancelar()
    End Sub

    Private Sub CbZona_ValueChanged(sender As Object, e As EventArgs) Handles CbZona.ValueChanged
        If (IsNumeric(CbZona.Value)) Then
            Tb1CodZona.Text = CbZona.Value.ToString
            Dim dt As DataTable = CType(CbZona.DataSource, DataTable)
            If (CbZona.Value = 0) Then
                StTextoReporte = "TODOS"
            Else
                StTextoReporte = dt.Select("lanumi=" + CbZona.Value.ToString)(0).Item("cedesc").ToString _
                             + " - " + dt.Select("lanumi=" + CbZona.Value.ToString)(0).Item("cedesc1").ToString _
                             + " - " + dt.Select("lanumi=" + CbZona.Value.ToString)(0).Item("cedesc2").ToString
            End If
        End If
    End Sub

    Private Sub CbCliente_ValueChanged(sender As Object, e As EventArgs) Handles CbCliente.ValueChanged
        If (IsNumeric(CbCliente.Value)) Then
            Tb2CodCliente.Text = CbCliente.Value.ToString
        End If
    End Sub

    Private Sub CbEquipo_ValueChanged(sender As Object, e As EventArgs) Handles CbEquipo.ValueChanged
        If (IsNumeric(CbEquipo.Value)) Then
            Tb3CodEquipo.Text = CbEquipo.Value.ToString
        End If

    End Sub
End Class