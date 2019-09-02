Public Class Celda
    Public titulo As String
    Public tamano As Integer
    Public visible As Boolean
    Public formato As String = String.Empty
    Public Sub New(vis As Integer, Optional tit As String = "", Optional tam As Integer = 0, Optional formato1 As String = "")
        titulo = tit
        tamano = tam
        visible = vis
        formato = formato1
    End Sub
End Class
