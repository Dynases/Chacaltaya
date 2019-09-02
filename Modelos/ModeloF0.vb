Public Class ModeloF0

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Pink
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Pink

    End Sub

    Private Sub ModeloHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            P_Moverenfoque()
        End If
    End Sub

    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
    End Sub

    Public Overridable Function P_Validar() As Boolean
        Return True
    End Function

End Class