Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar.Controls

Public Class F_Categoria
#Region "Variables Globales"
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim stRutaImagenes As String = RutaGlobal + "\Imagenes\Imagenes Categoria\"
    Dim RutaTemporal As String = "C:\Temporal\"
    Dim Modificado As Boolean = False
    Dim nameImg As String = "Default.jpg"
    Dim vlImagen As CImagen = Nothing

    Dim _Nuevo As Boolean
    Dim _Mofificar As Boolean
    Dim _Eliminar As Boolean

    Dim _Grabar As Integer '1,2 Nuevo; 3,4 Modificar; 5,6 Eliminar

    Dim _ruta As String = gs_RutaImagenes + "\Producto\"
    Dim G_Usuario As String = P_Global.gs_Usuario

    Dim _CodigoCategoria As Integer = 0
    Dim _Bimage As Boolean = False

    Dim _DuracionSms As Integer = 5
    Dim _Cont As Integer = 0

    Dim _DsProducto As DataSet

    Dim _MaxReg As Integer
    Dim _NavegadorReg As Integer

#End Region
#Region "Metodos Privados"

    Private Sub _prCrearCarpetaImagenes()
        Dim rutaDestino As String = stRutaImagenes

        If System.IO.Directory.Exists(stRutaImagenes) = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Imagenes") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes")
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Categoria") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Categoria")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Imagenes\Imagenes Categoria") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Imagenes\Imagenes Categoria")

                End If
            End If
        End If
    End Sub

    Private Sub _fnMoverImagenRuta(Folder As String, name As String)
        'copio la imagen en la carpeta del sistema
        If (Not name.Equals("Default.jpg") And File.Exists(RutaTemporal + name)) Then

            Dim img As New Bitmap(New Bitmap(RutaTemporal + name), 200, 300)

            pbImage.Image.Dispose()
            pbImage.Image = Nothing
            Try
                My.Computer.FileSystem.CopyFile(RutaTemporal + name,
     Folder + name, overwrite:=True)

            Catch ex As System.IO.IOException


            End Try



        End If
    End Sub
    Private Sub _prCrearCarpetaTemporal()

        If System.IO.Directory.Exists(RutaTemporal) = False Then
            System.IO.Directory.CreateDirectory(RutaTemporal)
        Else
            Try
                My.Computer.FileSystem.DeleteDirectory(RutaTemporal, FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(RutaTemporal)


            Catch ex As Exception

            End Try

        End If

    End Sub
    Private Sub P_prGuardarImagen(Folder As String, name As String)
        Dim rutaDestino As String = Folder

        Dim rutaOrigen As String
        Try
            rutaOrigen = vlImagen.getImagen()
            'Pb1FotoSocio.Image = Nothing
        Catch ex As Exception

        End Try

        If (Not name.Equals("Default.jpg") And File.Exists(rutaOrigen)) Then
            Dim finalImg As New Bitmap(pbImage.Image, 300, 200)


            finalImg.Save(rutaDestino + name + ".jpg")


        End If
        'FileCopy(rutaOrigen, rutaDestino + vlImagen.nombre + ".jpg")
    End Sub
    Private Sub P_prCargarImagen(pbimg As PictureBox)
        OfdProducto.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        OfdProducto.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp"
        OfdProducto.FilterIndex = 1
        If (OfdProducto.ShowDialog() = DialogResult.OK) Then
            vlImagen = New CImagen(OfdProducto.SafeFileName, OfdProducto.FileName, 0)
            pbimg.SizeMode = PictureBoxSizeMode.StretchImage
            Dim mayor As Integer
            mayor = grBuscador.GetTotal(grBuscador.RootTable.Columns("canumi"), AggregateFunction.Max)
            nameImg = P_fnObtenerID()
            pbimg.Load(vlImagen.getImagen())
            Modificado = True
        End If
    End Sub
    Private Function P_fnObtenerID() As String
        Dim res As String = ""
        res = res + Now.Hour.ToString("00") + Now.Minute.ToString("00") + Now.Second.ToString("00") + "_" _
            + Now.Day.ToString("00") + Now.Month.ToString("00") + Now.Year.ToString("0000")
        Return res
    End Function


    Private Sub P_PonerHighLigh(ByVal eHighlightColor As DevComponents.DotNetBar.Validator.eHighlightColor)
        Hl_Producto.SetHighlightColor(tbcodigo, eHighlightColor)
        Hl_Producto.SetHighlightColor(tbnombre, eHighlightColor)
        Hl_Producto.SetHighlightColor(tbobservacion, eHighlightColor)
    End Sub
    Private Sub P_Limpiar()
        tbcodigo.Clear()
        tbnombre.Clear()
        tbobservacion.Clear()
        pbImage.Image = My.Resources.pantalla1

        P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
        _Nuevo = False
        _Mofificar = False
        _Eliminar = False

        BBtn_Grabar.TooltipText = "GRABAR"
    End Sub
    Private Sub P_HabilitarComponentes(ByVal _Bool As Boolean)
        tbcodigo.ReadOnly = True
        tbnombre.ReadOnly = Not _Bool
        tbobservacion.ReadOnly = Not _Bool
        BtAdicionar.Visible = True
        If (_Bool = False) Then
            _prCrearCarpetaImagenes()
            _prCrearCarpetaTemporal()
        End If
    End Sub
    Private Sub P_NuevoRegistro()
        P_Limpiar()
        _Nuevo = True
        _Mofificar = False
        _Eliminar = False
        'Txt_Codigo.Text = L_GetLastIdTablas("TC001", "canumi") + 1
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_HabilitarComponentes(_Nuevo)
        tbnombre.Select()
        _Grabar = 1
    End Sub
    Private Sub P_ModificarRegistro()
        _Nuevo = False
        _Mofificar = True
        _Eliminar = False
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_HabilitarComponentes(_Mofificar)
        tbnombre.SelectAll()
        _Grabar = 3
    End Sub
    Private Sub P_EliminarRegistro()
        'P_Limpiar()
        _Nuevo = False
        _Mofificar = False
        _Eliminar = True
        BBtn_Grabar.TooltipText = "GRABAR ELIMINACIÓN DE REGISTRO"
        P_HabilitarComponentes(False)
        '_Cont = 0
        'Lbl_Sms.Text = "ELIJA EL REGISTRO A ELIMINAR..."

        _Grabar = 5
    End Sub

    Public Sub P_LlenarDatos(_N As Integer)

        If (_N <= _MaxReg And _N >= 0) Then
            'a.canumi ,a.canombre ,a.cadesc ,a.caimg ,a.cafact,a.cahact,a.cauact
            With grBuscador
                tbcodigo.Text = .GetValue("canumi")
                tbnombre.Text = .GetValue("canombre")
                tbobservacion.Text = .GetValue("cadesc")

                'MLblFecha.Text = CType(.GetValue("cafact"), Date).ToString("dd/MM/yyyy")
                'MLblHora.Text = .GetValue("cahact").ToString
                'MLblUsuario.Text = .GetValue("cauact").ToString
                Dim caest As Object = .GetValue("caest")

            End With

            Dim name As String = grBuscador.GetValue("caimg")
            Dim ruta As String = stRutaImagenes + name + ".jpg"
            If name.Equals("Default.jpg") Or Not File.Exists(ruta) Then

                Dim im As New Bitmap(My.Resources.pantalla1)
                pbImage.Image = im
            Else
                If (File.Exists(stRutaImagenes + name + ".jpg")) Then
                    Dim Bin As New MemoryStream
                    Dim im As New Bitmap(New Bitmap(stRutaImagenes + name + ".jpg"))
                    im.Save(Bin, System.Drawing.Imaging.ImageFormat.Jpeg)
                    pbImage.SizeMode = PictureBoxSizeMode.StretchImage
                    pbImage.Image = Image.FromStream(Bin)
                    Bin.Dispose()

                End If
            End If
            'MLbPaginacion.Text = Str(grBuscador.Row + 1) + "/" + grBuscador.RowCount.ToString
        Else

            If (_NavegadorReg < 0) Then
                _NavegadorReg = 0
            Else
                _NavegadorReg = _MaxReg
            End If
        End If
        P_ActualizarPaginacion(_N)
    End Sub
    Private Sub P_CancelarRegistro()
        P_Limpiar()
        P_HabilitarComponentes(False)
        P_LlenarDatos(_NavegadorReg)
    End Sub

    Private Sub P_Inicio()
        'L_abrirConexion()


        'L_prAbrirConexion("Localhost", "sa", "123", "BDDist")


        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False


        P_HabilitarComponentes(False)

        P_ArmarGrilla()
        P_ActualizarPuterosNavegacion()

        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)
        _pCambiarFuente()
    End Sub
    Private Sub P_ArmarGrilla()
        Dim dt As New DataTable
        dt = L_prGeneralCategoria()
        grBuscador.DataSource = dt
        grBuscador.RetrieveStructure()
        grBuscador.AlternatingColors = True

        'a.canumi ,a.canombre ,a.cadesc ,a.caimg ,a.cafact,a.cahact,a.cauact
        With grBuscador.RootTable.Columns("canumi")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = True

        End With
        With grBuscador.RootTable.Columns("canombre")
            .Width = 300
            .Caption = "NOMBRE CATEGORIA"
            .Visible = True
        End With


        With grBuscador.RootTable.Columns("cadesc")
            .Width = 350
            .Visible = True
            .Caption = "DESCRIPCION"
        End With
        With grBuscador.RootTable.Columns("caimg")
            .Width = 150
            .Visible = False
        End With
        With grBuscador.RootTable.Columns("caest")
            .Width = 150
            .Visible = False
        End With

        With grBuscador.RootTable.Columns("cafact")
            .Width = 120
            .Visible = True
            .Caption = "FECHA"
            .FormatString = "dd/MM/yyyy"
        End With


        With grBuscador.RootTable.Columns("cahact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grBuscador.RootTable.Columns("cauact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With

        With grBuscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

    End Sub
    Private Sub P_ActualizarPaginacion(ByVal _index As Integer)
        Txt_Paginacion.Text = "Reg. " & _index + 1 & " de " & _MaxReg + 1
    End Sub
    Private Sub P_ActualizarPuterosNavegacion()
        _MaxReg = CType(grBuscador.DataSource, DataTable).Rows.Count - 1
        If (_NavegadorReg > _MaxReg) Then
            _NavegadorReg = _MaxReg
        End If
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub
    Private Sub _pCambiarFuente()
        Dim fuente As New Font("Tahoma", gi_fuenteTamano, FontStyle.Regular)
        Dim xCtrl As Control
        For Each xCtrl In PanelEx3.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next
        For Each xCtrl In PanelEx4.Controls
            Try
                xCtrl.Font = fuente
            Catch ex As Exception
            End Try
        Next

    End Sub
#End Region

    Private Sub BBtn_Nuevo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Nuevo.Click
        P_NuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Modificar.Click
        P_ModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Eliminar.Click
        P_EliminarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Cancelar.Click
        P_CancelarRegistro()
    End Sub

    Private Sub F_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        Dim _pos As Integer = grBuscador.Row
        If _pos < grBuscador.RowCount - 1 Then
            _pos = grBuscador.Row + 1
            '' _prMostrarRegistro(_pos)
            grBuscador.Row = _pos
        End If
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        Dim _pos As Integer = grBuscador.Row
        If grBuscador.RowCount > 0 Then
            _pos = grBuscador.RowCount - 1
            ''  _prMostrarRegistro(_pos)
            grBuscador.Row = _pos
        End If
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        Dim _MPos As Integer = grBuscador.Row
        If _MPos > 0 And grBuscador.RowCount > 0 Then
            _MPos = _MPos - 1
            ''  _prMostrarRegistro(_MPos)
            grBuscador.Row = _MPos
        End If
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        Dim _MPos As Integer
        If grBuscador.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grBuscador.Row = _MPos
        End If
    End Sub

    Private Sub BtAdicionar_Click(sender As Object, e As EventArgs) Handles BtAdicionar.Click
        P_prCargarImagen(pbImage)
        'BBtn_Grabar.Focus()
    End Sub
    Private Sub P_GrabarRegistro()
        If (_Nuevo) Then
            If (_Grabar = 2) Then
                If (Not tbnombre.Text.Equals("")) Then

                    Dim fact As String = Date.Now.Date.ToString("yyyy/MM/dd")
                    Dim hact As String = TimeOfDay.Hour.ToString("00") + ":" + TimeOfDay.Minute.ToString("00")
                    Dim uact As String = G_Usuario

                    Dim numi As String = ""

                    Dim res As Boolean = L_prCategoriaGrabar(numi, tbnombre.Text, tbobservacion.Text, nameImg, 1)

                    If res Then
                        Modificado = False
                        '' _fnMoverImagenRuta(stRutaImagenes, nameImg)
                        P_prGuardarImagen(stRutaImagenes, nameImg)

                        nameImg = "Default.jpg"
                        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                        ToastNotification.Show(Me, "Código de Caja ".ToUpper + tbcodigo.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )

                        P_Limpiar()

                        BBtn_Grabar.TooltipText = "GRABAR"

                        ToastNotification.Show(Me, "SE HA GUARDADO EXITOSAMENTE..!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                        'Lbl_Sms.Text = "SE HA GUARDADO EXITOSAMENTE"
                        _Cont = 0

                        P_ArmarGrilla()
                        P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

                    Else
                        Dim img As Bitmap = New Bitmap(My.Resources.CANCEL, 50, 50)
                        ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

                    End If


                Else
                    Hl_Producto.SetHighlightColor(tbnombre, DevComponents.DotNetBar.Validator.eHighlightColor.Red)

                    _Cont = 0
                    ToastNotification.Show(Me, "FALTAN DATOS..!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "FALTAN DATOS..."
                End If
                _Grabar = 1
            Else
                P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Green)
                BBtn_Grabar.TooltipText = "CONFIRMAR GRABADO DE REGISTRO"
                _Grabar = 2
            End If
        ElseIf (_Mofificar) Then
            If (_Grabar = 4) Then
                If (Not tbnombre.Text.Equals("")) Then

                    Dim numi As String = ""
                    Dim nameImage As String = grBuscador.GetValue("caimg")
                    Dim Res As Boolean
                    If (Modificado = False) Then
                        Res = L_prCategoriaModificar(tbcodigo.Text, tbnombre.Text, tbobservacion.Text, nameImage, 1)
                    Else
                        Res = L_prCategoriaModificar(tbcodigo.Text, tbnombre.Text, tbobservacion.Text, nameImg, 1)
                    End If

                    If Res Then
                        If (Modificado = True) Then

                            P_prGuardarImagen(stRutaImagenes, nameImg)

                            '' _fnMoverImagenRuta(stRutaImagenes, nameImg)
                            Modificado = False
                        End If
                        nameImg = "Default.jpg"
                        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
                        ToastNotification.Show(Me, "Código de Caja ".ToUpper + tbcodigo.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )

                        tbnombre.Select()
                        BBtn_Grabar.TooltipText = "GRABAR"

                        ToastNotification.Show(Me, "SE HA MODIFICADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                        'Lbl_Sms.Text = "SE HA MODIFICADO EXITOSAMENTE"
                        _Cont = 0

                        P_ArmarGrilla()
                        P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

                    Else
                        Dim img As Bitmap = New Bitmap(My.Resources.CANCEL, 50, 50)
                        ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

                    End If




                Else
                    Hl_Producto.SetHighlightColor(tbnombre, DevComponents.DotNetBar.Validator.eHighlightColor.Red)

                    _Cont = 0
                    ToastNotification.Show(Me, "DEBE ELEGIR UN REGISTRO...!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "DEBE ELEGIR UN REGISTRO..."
                End If
                _Grabar = 3
            Else
                P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
                BBtn_Grabar.TooltipText = "CONFIRMAR MODIFICACIÓN DE REGISTRO"
                _Grabar = 4
            End If

        ElseIf (_Eliminar) Then
            If (_Grabar = 6) Then
                If (Not tbnombre.Text.Equals("")) Then

                    Dim numi As String = tbcodigo.Text.Trim

                    Dim res As Boolean = L_fnCategoriaEliminar(tbcodigo.Text)
                    If res Then


                        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                        ToastNotification.Show(Me, "Código de Categoria ".ToUpper + tbcodigo.Text + " eliminado con Exito.".ToUpper,
                                              img, 2000,
                                              eToastGlowColor.Green,
                                              eToastPosition.TopCenter)

                        P_Limpiar()
                        BBtn_Grabar.TooltipText = "GRABAR"

                        ToastNotification.Show(Me, "SE HA ELIMINADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomRight)
                        'Lbl_Sms.Text = "SE HA ELIMINADO EXITOSAMENTE"
                        _Cont = 0

                        P_ArmarGrilla()
                        P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

                    Else
                        Dim img As Bitmap = New Bitmap(My.Resources.CANCEL, 50, 50)
                        ToastNotification.Show(Me, "EL REGISTRO NO PUDO SER ELIMINADO", img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                    End If


                Else
                    _Cont = 0
                    ToastNotification.Show(Me, "DEBE ELEGIR UN REGISTRO...!!!", My.Resources.WARNING, _DuracionSms * 1000, eToastGlowColor.Orange, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "DEBE ELEGIR UN REGISTRO..."
                End If
                _Grabar = 5
            Else
                P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                BBtn_Grabar.TooltipText = "CONFIRMAR ELIMINACIÓN DE REGISTRO"
                _Grabar = 6
            End If

        End If
        P_ActualizarPuterosNavegacion()
    End Sub
    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        P_GrabarRegistro()
    End Sub

    Private Sub grBuscador_SelectionChanged(sender As Object, e As EventArgs) Handles grBuscador.SelectionChanged
        If (grBuscador.RowCount >= 0 And grBuscador.Row >= 0) Then

            P_LlenarDatos(grBuscador.Row)
        End If
    End Sub
End Class