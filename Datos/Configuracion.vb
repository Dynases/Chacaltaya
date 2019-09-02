Imports System.IO

Public Class Configuracion
    Shared _cadenaConexionSQLServer As String = "Data Source=localhost;" _
                                                + "Initial Catalog=BDDist;" _
                                                + "User ID=sa;" _
                                                + "Password=123"
    'Shared _cadenaConexionSQLServer As String = "Data Source=192.168.0.2;" _
    '                                            + "Initial Catalog=BDDist;" _
    '                                            + "User ID=sa;" _
    '                                            + "Password=123" 'Chacaltaya

    Public Shared ReadOnly Property CadenaConexion(Optional Ip As String = "", Optional UsuarioSql As String = "", Optional ClaveSql As String = "", Optional NombreBD As String = "") As String
        Get
            If (Ip = String.Empty Or UsuarioSql = String.Empty Or ClaveSql = String.Empty Or NombreBD = String.Empty) Then
                Return _cadenaConexionSQLServer
            Else
                Return "Data Source=" + Ip + ";Initial Catalog=" + NombreBD + ";User ID=" + UsuarioSql + ";Password=" + ClaveSql
            End If
        End Get
    End Property

End Class
