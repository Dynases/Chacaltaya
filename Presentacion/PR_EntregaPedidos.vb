Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_EntregaPedidos

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5

#End Region

#Region "Eventos"

    Private Sub PR_EntregaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub Cb1Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb1Producto.SelectedIndexChanged
        Tb1Codigo.Text = CType(Cb1Producto.SelectedItem, ComboItem).Value
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()

        'L_abrirConexion()

        Dt1Desde.Value = Now.Date
        Dt2Hasta.Value = Now.Date

        P_LLenarCombo()
        If (Cb1Producto.Items.Count > 0) Then
            Cb1Producto.SelectedIndex = 0
        End If

    End Sub

    Private Sub P_LLenarCombo()
        Dim _Ds As DataSet
        _Ds = L_ObtenerTipoProducto("5")
        Dim item As ComboItem
        Cb1Producto.Items.Clear()
        For Each fil As DataRow In _Ds.Tables(0).Rows
            item = New ComboItem
            item.Value = fil.Item("odtprod").ToString
            item.Text = fil.Item("cedesc").ToString
            Cb1Producto.Items.Add(item)
        Next
        item = New ComboItem
        item.Value = "0"
        item.Text = "Todos".ToUpper
        Cb1Producto.Items.Add(item)
    End Sub

    Private Sub P_GenerarReporte()
        If (Dt1Desde.Value <= Dt2Hasta.Value) Then
            Dim Dt As DataTable
            Dim DtAux As DataTable
            Dim DrAux As DataRow()
            DtAux = L_ObtenerEntregaPedidos(Tb1Codigo.Text,
                                          Dt1Desde.Value.Date.ToString("yyyy/MM/dd"),
                                          Dt2Hasta.Value.Date.ToString("yyyy/MM/dd"))
            DrAux = DtAux.Select("1 = 1", "Total")
            Dt = DtAux.Clone
            Dim i As Integer = DrAux.Count
            For Each fil As DataRow In DrAux
                fil.Item("Nro") = i
                Dt.ImportRow(fil)
                i -= 1
            Next

            If (Dt.Rows.Count > 0) Then
                Dim objrep As New R_EntregaPedidos

                objrep.SetDataSource(Dt)


                objrep.SetParameterValue("FechaIni", Dt1Desde.Value.Date.ToShortDateString)
                objrep.SetParameterValue("FechaFin", Dt2Hasta.Value.Date.ToShortDateString)
                objrep.SetParameterValue("Grupo", Cb1Producto.Text)

                Cr1Reporte.ReportSource = objrep

                Cr1Reporte.Show()
                Cr1Reporte.BringToFront()
            Else
                ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
            End If
        Else
            ToastNotification.Show(Me, "LA FECHA ''DESDE  TIENE QUE SER MENOR O IGUAL A LA FECHA ''HASTA''''..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_Cancelar()
        Dt1Desde.Value = Now.Date
        Dt2Hasta.Value = Now.Date
        Cb1Producto.SelectedIndex = 0
    End Sub

#End Region

    Private Sub Bt1Generar_Click(sender As Object, e As ClickEventArgs) Handles Bt1Generar.Click
        P_GenerarReporte()
    End Sub

    Private Sub Bt2Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bt2Cancelar.Click
        P_Cancelar()
    End Sub
End Class