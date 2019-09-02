Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX.EditControls

Module P_Global

    Public gs_Ip As String = "127.0.0.1"
    Public gs_UsuarioSql As String = "sa"
    Public gs_ClaveSql As String = "123"
    Public gs_NombreBD As String = "DBDist"
    Public gs_CarpetaRaiz As String = "C:\BD"
    Public gs_FtpIp As String = "127.0.0.1"
    Public gs_FtpUsuario As String = "UserFtp"
    Public gs_FtpPassword As String = "123456"

    Public gs_RutaImagenes As String = gs_CarpetaRaiz + "\Imagenes"
    Public gs_RutaArchivos As String = "C:\Doc"
    Public gs_RutaManuales As String = "C:\BD"
    Public gs_Usuario As String = "DEFAULT"
    Public gs_CodigoUsuario As String = "0"


    Public gt_Cliente As DataTable
    Public gb_DtClienteEstado As Boolean = False

    Public gt_Productos As DataTable

    Public gb_ConexionAbierta As Boolean = False

#Region "Variables"

    Public G_SeparadorDecimal As Char = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    Public Visualizador As Visualizador

#End Region

#Region "Librerias"
    Public gi_LibCiudad As Integer = 4
    Public gi_LibProv As Integer = 3
    Public gi_LibZona As Integer = 2
    Public gi_LibMovimientoInv As Integer = 12
    Public gi_CategoriaEquipo As Integer = 1
    Public gi_TipoMovimiento As Integer = 10
    Public gi_ConceptoReclamo As Integer = 13

#End Region

#Region "Clientes"

    Public G_CodProducto As String = ""
    Public G_NroLinea As String = ""

#End Region

#Region "Metodos"

    'Tipos de Modos
    '1 Valida que sea solo Numeros
    '2 Valida que sea solo Letras
    '3 Valida que sea Numeros y el Separador de Decimales
    '4 Valida que sea Numeros y el guion (-)
    Public Sub G_ValidarTextBox(ByVal _Modo As Byte, ByRef ee As KeyPressEventArgs)
        Select Case _Modo
            Case 1
                If (Char.IsNumber(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (Char.IsControl(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (Char.IsPunctuation(ee.KeyChar)) Then
                    ee.Handled = False
                Else
                    ee.Handled = True
                End If
            Case 2
                If (Char.IsLetter(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (Char.IsControl(ee.KeyChar)) Then
                    ee.Handled = False
                Else
                    ee.Handled = True
                End If
            Case 3
                If (Char.IsNumber(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (ee.KeyChar.Equals(G_SeparadorDecimal)) Then
                    ee.Handled = False
                ElseIf (Char.IsControl(ee.KeyChar)) Then
                    ee.Handled = False
                Else
                    ee.Handled = True
                End If
            Case 4
                If (Char.IsNumber(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (ee.KeyChar.Equals(Convert.ToChar("-"))) Then
                    ee.Handled = False
                ElseIf (Char.IsControl(ee.KeyChar)) Then
                    ee.Handled = False
                Else
                    ee.Handled = True
                End If
            Case 5
                If (Char.IsNumber(ee.KeyChar)) Then
                    ee.Handled = False
                ElseIf (ee.KeyChar.Equals(G_SeparadorDecimal)) Then
                    ee.Handled = False
                ElseIf (ee.KeyChar.Equals(Convert.ToChar("-"))) Then
                    ee.Handled = False
                ElseIf (Char.IsControl(ee.KeyChar)) Then
                    ee.Handled = False
                Else
                    ee.Handled = True
                End If
        End Select
    End Sub

    Public Sub G_ActStock(_Tabla As DataTable, _Signo As Boolean) 'True=Signo (+), False=Signo(-)
        For Each _fila As DataRow In _Tabla.Rows
            Dim codC As String = _fila.Item("codC").ToString
            Dim mon As String = IIf(_Signo, "", "-") + _fila.Item("mon").ToString
            L_Actualizar_Saldo(codC, mon)
        Next
    End Sub

    Public Sub G_ActStock(_Tabla As DataTable, _Signo As Boolean, _almacen As String) 'True=Signo (+), False=Signo(-)
        For Each _fila As DataRow In _Tabla.Rows
            Dim codP As String = _fila.Item("codP").ToString
            Dim cant As String = IIf(_Signo, "", "-") + _fila.Item("can").ToString
            L_Actualizar_StockMovimiento(codP, cant, _almacen)
        Next
    End Sub

    Public Sub g_prArmarCombo(cbj As MultiColumnCombo, dtCombo As DataTable,
                              Optional anchoCodigo As Integer = 60, Optional anchoDesc As Integer = 200,
                              Optional nombreCodigo As String = "Código", Optional nombreDescripción As String = "Nombre")
        With cbj.DropDownList
            .Columns.Clear()

            .Columns.Add(dtCombo.Columns("cod").ToString).Width = anchoCodigo
            '.Columns(0).Key =dtCombo.Columns(0).Caption
            .Columns(0).Caption = nombreCodigo
            .Columns(0).Visible = True

            .Columns.Add(dtCombo.Columns("desc").ToString).Width = anchoDesc
            '.Columns(1).Key =dtCombo.Columns(1).Caption
            .Columns(1).Caption = nombreDescripción
            .Columns(1).Visible = True

            .ValueMember = dtCombo.Columns("cod").ToString
            .DisplayMember = dtCombo.Columns("desc").ToString
            .DataSource = dtCombo
            .Refresh()
        End With
    End Sub


#End Region

#Region "Configuracion del sistema"
    Public gs_llaveDinases As String = "carlosdinases123"
    Public gb_mostrarMapa As Boolean = True
    Public gi_fuenteTamano As Integer = 8
    Public gi_userNumi As Integer = 0
    Public gi_bloqueoManuales As Integer = 0 '0=No esta bloqueado, 1=Si esta bloqueado
    Public gi_notiPed As Integer = 0 '0=noe envia notificacion de pedidos,1=si envia notificacion
    Public gi_expcli As Byte = 0 '0=no exporta cliente (el boton exportar cliente estará invisible), 1=exporta cliente (el boton exportar cliente estará visible)
    Public gs_color As String = "#0040FF" 'obtiene el color de las ventanas
#End Region

End Module
