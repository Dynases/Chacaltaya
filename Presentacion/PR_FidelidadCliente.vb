Imports Logica.AccesoLogica
Imports DevComponents.Editors
Imports DevComponents.DotNetBar

Public Class PR_FidelidadCliente

#Region "Variables Globales"

    Dim _DuracionSms As Integer = 5

#End Region

#Region "Eventos"

    Private Sub PR_FidelidadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()

        'L_abrirConexion()

        P_LLenarCombo()
        P_LLenarAnho()
        P_LLenarCriterio()

        If (Cb1Producto.Items.Count > 0) Then
            Cb1Producto.SelectedIndex = 0
        End If
        If (Cb2Desde.Items.Count > 0) Then
            Cb2Desde.SelectedText = Now.Year.ToString
        End If
        If (Cb3Hasta.Items.Count > 0) Then
            Cb3Hasta.SelectedText = Now.Year.ToString
        End If
        Cb4Criterio.SelectedIndex = 0

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

    Private Sub P_LLenarAnho()
        Dim _Ds As DataSet
        _Ds = L_ObtenerAnhoFidelidad()
        Dim item As ComboItem
        Cb2Desde.Items.Clear()
        Cb3Hasta.Items.Clear()
        For Each fil As DataRow In _Ds.Tables(0).Rows
            item = New ComboItem
            item.Value = fil.Item("Anho").ToString
            item.Text = fil.Item("Anho").ToString
            Cb2Desde.Items.Add(item)
            Cb3Hasta.Items.Add(item)
        Next
    End Sub

    Private Sub P_LLenarCriterio()
        Dim item As ComboItem
        Cb4Criterio.Items.Clear()
        item = New ComboItem
        item.Value = 0
        item.Text = "TOTAL"
        Cb4Criterio.Items.Add(item)
        item = New ComboItem
        item.Value = 1
        item.Text = "PROMEDIO DE CONSUMO"
        Cb4Criterio.Items.Add(item)
    End Sub

    Private Sub P_GenerarReporte()
        If (CInt(Cb2Desde.Text) <= Cb3Hasta.Text) Then
            Dim _Ds As DataSet
            _Ds = L_ObtenerFidelidadCliente(Tb1Codigo.Text, Cb2Desde.Text, Cb3Hasta.Text, CType(Cb4Criterio.SelectedItem, ComboItem).Value)
            If (_Ds.Tables(0).Rows.Count > 0) Then
                Dim objrep As New R_FidelidadCliente

                objrep.SetDataSource(_Ds.Tables(0))

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
            ToastNotification.Show(Me, "EL AÑO ''DESDE  TIENE QUE SER MENOR O IGUAL AL AÑO ''HASTA''''..!!!",
                                           My.Resources.INFORMATION, _DuracionSms * 1000,
                                           eToastGlowColor.Blue,
                                           eToastPosition.BottomLeft)
        End If
    End Sub

    Private Sub P_Cancelar()
        Cb1Producto.SelectedIndex = 0
        Cb2Desde.SelectedIndex = 0
        Cb3Hasta.SelectedIndex = 0
    End Sub

#End Region

    Private Sub Cb1Producto_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cb1Producto.SelectedIndexChanged
        Tb1Codigo.Text = CType(Cb1Producto.SelectedItem, ComboItem).Value
    End Sub

    Private Sub Bt1Generar_Click(sender As Object, e As ClickEventArgs) Handles Bt1Generar.Click
        P_GenerarReporte()
    End Sub

    Private Sub Bt2Cancelar_Click(sender As Object, e As ClickEventArgs) Handles Bt2Cancelar.Click
        P_Cancelar()
    End Sub
End Class