Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar

Public Class P_Inicio
    Dim _DuracionSms As Integer = 2

    Private Sub P_Inicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ''If G_Nivel = 0 Then
        ''    End
        ''End If
    End Sub
    Private Sub P_Seguridad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            _MoverEnfoque()
        End If
    End Sub
    Private Sub _MoverEnfoque()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub Bt1_Ingresa_Click(sender As Object, e As EventArgs) Handles Bt1_Ingresa.Click
        If Tb1_Pass.Text.ToUpper = gs_llaveDinases.ToUpper Then
            L_ConfSistemaModificar(Tb1_Nom.Text)
            gs_usuario = "RESTAR"
            Tb1_Nom.Text = ""
            Tb1_Pass.Text = ""
            Close()
            Exit Sub
        End If

        If Tb1_Nom.Text = "" Then
            'MsgBox("No Puede Dejar Nombre en Blanco.")
            ToastNotification.Show(Me, "No Puede Dejar Nombre en Blanco..!!!".ToUpper, My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            Exit Sub
        End If
        If Tb1_Pass.Text = "" Then
            'MsgBox("No Puede Dejar Password en Blanco.")
            ToastNotification.Show(Me, "No Puede Dejar Password en Blanco..!!!".ToUpper, My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
            Exit Sub
        End If
        Dim dtUsuario As DataTable = L_Validar_Usuario(Tb1_Nom.Text, Tb1_Pass.Text)
        If dtUsuario.Rows.Count = 0 Then
            'MsgBox("Codigo de Usuario y Password Incorrecto.", MsgBoxStyle.Critical)
            ToastNotification.Show(Me, "Codigo de Usuario y Password Incorrecto..!!!".ToUpper, My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomLeft)
        Else
            gs_usuario = Tb1_Nom.Text
            gi_fuenteTamano = dtUsuario.Rows(0).Item("ydfontsize")
            gi_userNumi = dtUsuario.Rows(0).Item("ydnumi")

            Pb1_1.Visible = False
            Pb1_2.Visible = True
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Dim Frm As New Principal
        'Frm.Show()
        'Frm.BringToFront()
        Me.Close()
    End Sub

    Private Sub P_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _pCambiarFuente()
    End Sub

    Private Sub _pCambiarFuente()
        Dim fuente As New Font("Tahoma", 12, FontStyle.Regular)
        Dim xCtrl As Control
        For Each xCtrl In Me.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

    End Sub
End Class