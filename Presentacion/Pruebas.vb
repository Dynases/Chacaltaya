Imports DevComponents.DotNetBar.Metro

Public Class Pruebas


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SlidePanel1.IsOpen = Not SlidePanel1.IsOpen
    End Sub

    Private Sub MonthCalendarAdv1_ItemClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelEx4.Visible = False
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Nuevo.Click
        

    End Sub

    Private Sub GroupPanel2_Click(sender As Object, e As EventArgs) Handles GroupPanel2.Click
        
    End Sub

    Private Sub GroupPanel2_DoubleClick(sender As Object, e As EventArgs) Handles GroupPanel2.DoubleClick

        If TableLayoutPanel1.ColumnStyles(0).Width = 100 Then
            TableLayoutPanel1.ColumnStyles(0).Width = 50
            TableLayoutPanel1.RowStyles(0).Height = 50
            TableLayoutPanel1.ColumnStyles(1).Width = 50
            TableLayoutPanel1.RowStyles(1).Height = 50
        Else

            TableLayoutPanel1.ColumnStyles(0).Width = 100
            TableLayoutPanel1.RowStyles(0).Height = 100
            TableLayoutPanel1.ColumnStyles(1).Width = 0
            TableLayoutPanel1.RowStyles(1).Height = 0
        End If

    End Sub
End Class