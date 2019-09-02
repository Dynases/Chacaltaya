Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar.SuperGrid
Imports DevComponents.DotNetBar

Public Class P_Producto

#Region "Variables Globales"

    Dim _Nuevo As Boolean
    Dim _Mofificar As Boolean
    Dim _Eliminar As Boolean

    Dim _Grabar As Integer '1,2 Nuevo; 3,4 Modificar; 5,6 Eliminar
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim _ruta As String = RutaGlobal + "\Imagenes\Imagenes Producto\"
    Dim G_Usuario As String = P_Global.gs_usuario

    Dim _CodigoCategoria As Integer = 0
    Dim _Bimage As Boolean = False

    Dim _DuracionSms As Integer = 5
    Dim _Cont As Integer = 0

    Dim _DsProducto As DataSet

    Dim _MaxReg As Integer
    Dim _NavegadorReg As Integer

#End Region

#Region "Eventos"

    Private Sub P_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Inicio()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Nuevo.Click
        P_NuevoRegistro()
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Modificar.Click
        P_ModificarRegistro()
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Eliminar.Click
        P_EliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Grabar.Click
        P_GrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Cancelar.Click
        P_CancelarRegistro()
    End Sub

    Private Sub Cbx_Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbx_Categoria.SelectedIndexChanged
        P_GetCodigoCategoria(Cbx_Categoria.SelectedIndex)
    End Sub

#End Region

#Region "Metodos"

    Private Sub P_Inicio()
        'L_abrirConexion()

        P_ValidacionInicial()

        Ti_Productos.Start()

        BBtn_Imprimir.Visible = False
        BBtn_Error.Visible = False
        DtiFechaIngreso.Visible = False

        P_HabilitarComponentes(False)

        P_ArmarGrilla()
        P_ArmarCombo()

        P_ActualizarPuterosNavegacion()

        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)
        _pCambiarFuente()
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

    Private Sub P_NuevoRegistro()
        P_Limpiar()
        _Nuevo = True
        _Mofificar = False
        _Eliminar = False
        'Txt_Codigo.Text = L_GetLastIdTablas("TC001", "canumi") + 1
        BBtn_Grabar.TooltipText = "GRABAR NUEVO REGISTRO"
        P_HabilitarComponentes(_Nuevo)
        Txt_Nombre.Select()
        _Grabar = 1
    End Sub

    Private Sub P_ModificarRegistro()
        _Nuevo = False
        _Mofificar = True
        _Eliminar = False
        BBtn_Grabar.TooltipText = "GRABAR MODIFICACIÓN DE REGISTRO"
        P_HabilitarComponentes(_Mofificar)
        Txt_Nombre.SelectAll()
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

    Private Sub P_GrabarRegistro()
        If (_Nuevo) Then
            If (_Grabar = 2) Then
                If (Not Txt_Nombre.Text.Equals("")) Then
                    Dim numi As String = L_GetLastIdTablas("TC001", "canumi") + 1
                    Dim cod As String = numi
                    Dim desc As String = Txt_Nombre.Text.Trim
                    Dim desc2 As String = IIf(Txt_NombreCorto.Text.Trim.Equals(""), "", Txt_NombreCorto.Text.Trim)
                    Dim cat As String = _CodigoCategoria
                    Dim img As String = IIf(_Bimage, "IMG" + numi + ".JPG", "")
                    Dim stc As String = IIf(Sb_Stock.Value, "1", "0")
                    Dim est As String = IIf(Sb_Estado.Value, "1", "0")
                    Dim serie As String = IIf(SbEsEquipo.Value, "1", "0") '"0" 'Por apuro esta estatico
                    Dim pcom As String = "0" 'Por apuro esta estatico
                    Dim fing As String = DtiFechaIngreso.Value.ToString("yyyy/MM/dd")
                    Dim fact As String = Date.Now.Date.ToString("yyyy/MM/dd")
                    Dim hact As String = TimeOfDay.Hour.ToString("00") + ":" + TimeOfDay.Minute.ToString("00")
                    Dim uact As String = G_Usuario

                    L_GrabarNuevoProducto(
                                       numi + ", " _
                                     + "'" + cod + "', " _
                                     + "'" + desc + "', " _
                                     + "'" + desc2 + "', " _
                                     + "" + cat + ", " _
                                     + "'" + img + "', " _
                                     + "" + stc + ", " _
                                     + "" + est + ", " _
                                     + "" + serie + ", " _
                                     + "" + pcom + ", " _
                                     + "'" + fing + "', " _
                                     + "'" + fact + "', " _
                                     + "'" + hact + "', " _
                                     + "'" + uact + "'"
                                     )
                    If (_Bimage) Then
                        P_prGuardarImagen(_ruta + "IMG" + numi + ".JPG")
                    End If

                    P_Limpiar()
                    Txt_Codigo.Text = L_GetLastIdTablas("TC001", "canumi") + 1
                    Txt_Nombre.Select()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA GUARDADO EXITOSAMENTE..!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "SE HA GUARDADO EXITOSAMENTE"
                    _Cont = 0

                    P_ArmarGrilla()
                    P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
                Else
                    Hl_Producto.SetHighlightColor(Txt_Nombre, DevComponents.DotNetBar.Validator.eHighlightColor.Red)

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
                If (Not Txt_Nombre.Text.Equals("")) Then
                    Dim numi As String = Txt_Codigo.Text.Trim
                    Dim cod As String = "S/C"
                    Dim desc As String = Txt_Nombre.Text.Trim
                    Dim desc2 As String = IIf(Txt_NombreCorto.Text.Trim.Equals(""), "", Txt_NombreCorto.Text.Trim)
                    Dim cat As String = _CodigoCategoria
                    Dim img As String = IIf(_Bimage, "IMG" + numi + ".JPG", _DsProducto.Tables(0).Rows(_NavegadorReg).Item("caimg").ToString)
                    Dim stc As String = IIf(Sb_Stock.Value, "1", "0")
                    Dim est As String = IIf(Sb_Estado.Value, "1", "0")
                    Dim serie As String = IIf(SbEsEquipo.Value, "1", "0")
                    Dim pcom As String = "0" 'Por apuro esta estatico
                    Dim fing As String = DtiFechaIngreso.Value.ToString("yyyy/MM/dd")
                    Dim fact As String = Date.Now.Date.ToString("yyyy/MM/dd")
                    Dim hact As String = TimeOfDay.Hour.ToString("00") + ":" + TimeOfDay.Minute.ToString("00")
                    Dim uact As String = G_Usuario

                    L_GrabarModificarProducto(
                                       "cadesc = '" + desc + "', " _
                                     + "cadesc2 = '" + desc2 + "', " _
                                     + "cacat = " + cat + ", " _
                                     + "caimg = '" + img + "', " _
                                     + "castc = " + stc + ", " _
                                     + "caest = " + est + ", " _
                                     + "caserie = " + serie + ", " _
                                     + "capcom = " + pcom + ", " _
                                     + "cafing = '" + fing + "', " _
                                     + "cafact = '" + fact + "', " _
                                     + "cahact = '" + hact + "', " _
                                     + "cauact = '" + uact + "'",
                                     "canumi = " + numi
                                     )
                    If (_Bimage) Then
                        P_prGuardarImagen(_ruta + "IMG" + numi + ".JPG")
                    End If

                    _Bimage = False
                    Txt_Nombre.Select()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA MODIFICADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Green, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "SE HA MODIFICADO EXITOSAMENTE"
                    _Cont = 0

                    P_ArmarGrilla()
                    P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
                Else
                    Hl_Producto.SetHighlightColor(Txt_Nombre, DevComponents.DotNetBar.Validator.eHighlightColor.Red)

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
                If (Not Txt_Nombre.Text.Equals("")) Then

                    Dim numi As String = Txt_Codigo.Text.Trim

                    L_GrabarEliminarProducto("canumi = " + numi)

                    P_Limpiar()
                    BBtn_Grabar.TooltipText = "GRABAR"

                    ToastNotification.Show(Me, "SE HA ELIMINADO EXITOSAMENTE...!!!", My.Resources.GRABACION_EXITOSA, _DuracionSms * 1000, eToastGlowColor.Red, eToastPosition.BottomRight)
                    'Lbl_Sms.Text = "SE HA ELIMINADO EXITOSAMENTE"
                    _Cont = 0

                    P_ArmarGrilla()
                    P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)
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

    Private Sub P_CancelarRegistro()
        P_Limpiar()
        P_HabilitarComponentes(False)
        P_LlenarDatos(_NavegadorReg)
    End Sub

    Private Sub P_ArmarGrilla()
        _DsProducto = New DataSet
        _DsProducto = L_GetProductos("")

        'canumi, cacod, cadesc, cadesc2, cacat, cedesc, caimg, castc, caest, caserie

        Dim incre As Integer = 0
        With Dgs_Productos.PrimaryGrid
            .Columns(incre).Name = "numi" '1
            .Columns(incre).HeaderText = "CÓDIGO"
            .Columns(incre).Width = 80
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "cod" '2
            .Columns(incre).HeaderText = "CÓDIGO"
            .Columns(incre).Width = 80
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "desc" '3
            .Columns(incre).HeaderText = "NOMBRE LARGO"
            .Columns(incre).Width = 250
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "desc2" '4
            .Columns(incre).HeaderText = "NOMBRE CORTO"
            .Columns(incre).Width = 200
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "cat" '5
            .Columns(incre).HeaderText = "COD CAT"
            .Columns(incre).Width = 80
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "nomCat" '6
            .Columns(incre).HeaderText = "CATEGORÍA"
            .Columns(incre).Width = 150
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "img" '7
            .Columns(incre).HeaderText = "IMAGEN"
            .Columns(incre).Width = 120
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "stc" '8
            .Columns(incre).HeaderText = "STOCK!"
            .Columns(incre).Width = 100
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "est" '9
            .Columns(incre).HeaderText = "ESTADO!"
            .Columns(incre).Width = 100
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "serie" '10
            .Columns(incre).HeaderText = "ES EQUIPO?"
            .Columns(incre).Width = 80
            .Columns(incre).Visible = True
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "pcom" '11
            .Columns(incre).HeaderText = ""
            .Columns(incre).Width = 0
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "fing" '12
            .Columns(incre).HeaderText = ""
            .Columns(incre).Width = 0
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "fact" '13
            .Columns(incre).HeaderText = ""
            .Columns(incre).Width = 0
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "hact" '14
            .Columns(incre).HeaderText = ""
            .Columns(incre).Width = 0
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
            incre += 1

            .Columns(incre).Name = "uact" '15
            .Columns(incre).HeaderText = ""
            .Columns(incre).Width = 0
            .Columns(incre).Visible = False
            .Columns(incre).EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            .Columns(incre).ReadOnly = True
            .Columns(incre).CellStyles.Default.Font = New Font("Arial", gi_fuenteTamano)
        End With

        P_LlenarDatosGrid(_DsProducto.Tables(0))

    End Sub

    Private Sub P_LlenarDatosGrid(dt As Object)
        Dgs_Productos.PrimaryGrid.Rows.Clear()

        Dim _fil As GridRow
        Dim _cel As GridCell

        'canumi, cacod, cadesc, cadesc2, cacat, cedesc, caimg, castc, caest, caserie, capcom, cafact, cahact, cauact
        For Each _f As DataRow In dt.Rows
            _fil = New GridRow
            _fil.RowHeight = 50

            _cel = New GridCell '1
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("canumi").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _fil.Cells.Add(_cel)

            _cel = New GridCell '2
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("cacod").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _fil.Cells.Add(_cel)

            _cel = New GridCell '3
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("cadesc").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _fil.Cells.Add(_cel)

            _cel = New GridCell '4
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("cadesc2").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _fil.Cells.Add(_cel)

            _cel = New GridCell '5
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("cacat").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight
            _fil.Cells.Add(_cel)

            _cel = New GridCell '6
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("cedesc").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleLeft
            _fil.Cells.Add(_cel)


            _cel = New GridCell '7
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridTextBoxXEditControl)
            _cel.Value = _f.Item("caimg").ToString

            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleRight

            Dim img As Bitmap
            Dim img2 As Bitmap
            If (IO.File.Exists(_ruta + _f.Item("caimg").ToString)) Then
                img = New Bitmap(_ruta + _f.Item("caimg").ToString)
                img2 = New Bitmap(img, 40, 40)
                _cel.CellStyles.Default.Image = img2
            End If
            _fil.Cells.Add(_cel)

            _cel = New GridCell '8
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("castc").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '9
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("caest").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '10
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("caserie").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '11
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("capcom").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '12
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("cafact").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '13
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("cahact").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            _cel = New GridCell '14
            _cel.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxEditControl)
            _cel.Value = _f.Item("cauact").ToString
            _cel.CellStyles.Default.Alignment = Style.Alignment.MiddleCenter
            _fil.Cells.Add(_cel)

            'Dim img As New Bitmap(My.Resources.GRABACION_EXITOSA)
            'Dim img2 As New Bitmap(img, 15, 15)
            '_f.Cells.Item("fdev").CellStyles.Default.Image = img2

            Dgs_Productos.PrimaryGrid.Rows.Add(_fil)
        Next
    End Sub

    Private Sub P_ArmarCombo()

        Dim _Ds As New DataSet
        _Ds = L_GetItemsConceptoLibreria("5")

        Cbx_Categoria.Items.Clear()

        Cbx_Categoria.DropDownWidth = Cbx_Categoria.Width * 1.5
        Cbx_Categoria.DropDownHeight = 100

        Cbx_Categoria.DropDownColumns = _Ds.Tables(0).Columns(0).ToString + "," + _Ds.Tables(0).Columns(1).ToString
        Cbx_Categoria.DropDownColumnsHeaders = "CÓDIGO" + Chr(13) + "DESCRIPCIÓN"

        Cbx_Categoria.ValueMember = _Ds.Tables(0).Columns(0).ToString
        Cbx_Categoria.DisplayMember = _Ds.Tables(0).Columns(1).ToString
        Cbx_Categoria.DataSource = _Ds.Tables(0)
        Cbx_Categoria.Refresh()

    End Sub

    Private Sub P_GetCodigoCategoria(ByVal _index As Integer)
        _CodigoCategoria = CInt(CType(Cbx_Categoria.Items(_index), DataRowView).Item("cenum").ToString)
    End Sub

    Private Sub P_Limpiar()
        Txt_Codigo.Clear()
        Txt_Nombre.Clear()
        Txt_NombreCorto.Clear()
        Cbx_Categoria.SelectedIndex = 0
        Sb_Stock.Value = True
        Sb_Estado.Value = True
        SbEsEquipo.Value = False
        DtiFechaIngreso.Value = Now.Date

        P_PonerHighLigh(DevComponents.DotNetBar.Validator.eHighlightColor.None)

        Ptb_Imagen.Image = My.Resources._DEFAULT
        Lbl_NombreImagen.Text = ""
        _Bimage = False

        _Nuevo = False
        _Mofificar = False
        _Eliminar = False

        BBtn_Grabar.TooltipText = "GRABAR"
    End Sub

#End Region

    Private Sub Btnx_BuscarImagen_Click(sender As Object, e As EventArgs) Handles Btnx_BuscarImagen.Click
        Ofd_Producto.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        Ofd_Producto.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg"
        Ofd_Producto.FilterIndex = 1
        If (Ofd_Producto.ShowDialog() = DialogResult.OK) Then
            Ptb_Imagen.Image = Image.FromFile(Ofd_Producto.FileName)
            Ptb_Imagen.SizeMode = PictureBoxSizeMode.StretchImage
            _Bimage = True
            Lbl_NombreImagen.Text = "IMG" + Txt_Codigo.Text + ".JPG"
        End If
    End Sub

    Private Sub P_Producto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Ti_Productos.Stop()
    End Sub

    Private Sub P_LlenarDatos(ByVal _index As Integer)
        If (_index <= _MaxReg And _index >= 0) Then
            Me.Txt_Codigo.Text = _DsProducto.Tables(0).Rows(_index).Item("canumi").ToString
            Me.Txt_Nombre.Text = _DsProducto.Tables(0).Rows(_index).Item("cadesc").ToString
            Me.Txt_NombreCorto.Text = _DsProducto.Tables(0).Rows(_index).Item("cadesc2").ToString
            Me.Cbx_Categoria.SelectedValue = CInt(_DsProducto.Tables(0).Rows(_index).Item("cacat").ToString)
            Dim s As String = _DsProducto.Tables(0).Rows(_index).Item("castc").ToString.Equals("1")
            Me.Sb_Stock.Value = _DsProducto.Tables(0).Rows(_index).Item("castc").ToString.Equals("True")
            Me.Sb_Estado.Value = _DsProducto.Tables(0).Rows(_index).Item("caest").ToString.Equals("True")
            Me.SbEsEquipo.Value = _DsProducto.Tables(0).Rows(_index).Item("caserie").ToString.Equals("True")
            Me.DtiFechaIngreso.Value = _DsProducto.Tables(0).Rows(_index).Item("cafing")
            If (_DsProducto.Tables(0).Rows(_index).Item("caimg").ToString.Equals("")) Then
                Ptb_Imagen.Image = Nothing
                Lbl_NombreImagen.Text = ""
            Else
                Dim rutaimg As String = _ruta + _DsProducto.Tables(0).Rows(_index).Item("caimg").ToString
                If (IO.File.Exists(rutaimg)) Then
                    Ptb_Imagen.Image = Image.FromFile(rutaimg)
                    Lbl_NombreImagen.Text = _DsProducto.Tables(0).Rows(_index).Item("caimg").ToString
                Else
                    Ptb_Imagen.Image = Nothing
                    Lbl_NombreImagen.Text = ""
                End If
            End If
        Else
            If (_NavegadorReg < 0) Then
                _NavegadorReg = 0
            Else
                _NavegadorReg = _MaxReg
            End If
        End If
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Inicio.Click
        _NavegadorReg = 0
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Anterior.Click
        _NavegadorReg -= 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Siguiente.Click
        _NavegadorReg += 1
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles BBtn_Ultimo.Click
        _NavegadorReg = _MaxReg
        P_LlenarDatos(_NavegadorReg)
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_ActualizarPuterosNavegacion()
        _MaxReg = _DsProducto.Tables(0).Rows.Count - 1
        If (_NavegadorReg > _MaxReg) Then
            _NavegadorReg = _MaxReg
        End If
        P_ActualizarPaginacion(_NavegadorReg)
    End Sub

    Private Sub P_HabilitarComponentes(ByVal _Bool As Boolean)
        Txt_Codigo.ReadOnly = Not _Bool
        Txt_Nombre.ReadOnly = Not _Bool
        Txt_NombreCorto.ReadOnly = Not _Bool
        Cbx_Categoria.Enabled = _Bool
        Sb_Stock.IsReadOnly = Not _Bool
        Sb_Estado.IsReadOnly = Not _Bool
        SbEsEquipo.IsReadOnly = Not _Bool
        Btnx_BuscarImagen.Enabled = _Bool
    End Sub

    Private Sub P_ActualizarPaginacion(ByVal _index As Integer)
        Txt_Paginacion.Text = "Reg. " & _index + 1 & " de " & _MaxReg + 1
    End Sub

    Private Sub P_PonerHighLigh(ByVal eHighlightColor As DevComponents.DotNetBar.Validator.eHighlightColor)
        Hl_Producto.SetHighlightColor(Txt_Codigo, eHighlightColor)
        Hl_Producto.SetHighlightColor(Txt_Nombre, eHighlightColor)
        Hl_Producto.SetHighlightColor(Txt_NombreCorto, eHighlightColor)
        Hl_Producto.SetHighlightColor(Cbx_Categoria, eHighlightColor)
        Hl_Producto.SetHighlightColor(Sb_Stock, eHighlightColor)
        Hl_Producto.SetHighlightColor(Sb_Estado, eHighlightColor)
        Hl_Producto.SetHighlightColor(Btnx_BuscarImagen, eHighlightColor)
    End Sub

    Private Sub Dgs_Productos_CellClick(sender As Object, e As GridCellClickEventArgs) Handles Dgs_Productos.CellClick
        If (e.GridCell.RowIndex >= 0) Then
            P_LlenarDatos(Dgs_Productos.PrimaryGrid.ActiveRow.RowIndex)
            P_ActualizarPaginacion(Dgs_Productos.ActiveRow.RowIndex)
            _NavegadorReg = Dgs_Productos.ActiveRow.RowIndex + 1
        End If
    End Sub

    Private Sub Txt_Nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Nombre.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Txt_NombreCorto_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_NombreCorto.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Cbx_Categoria_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbx_Categoria.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Sb_Stock_KeyDown(sender As Object, e As KeyEventArgs) Handles Sb_Stock.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Sb_Estado_KeyDown(sender As Object, e As KeyEventArgs) Handles Sb_Estado.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Btnx_BuscarImagen_KeyDown(sender As Object, e As KeyEventArgs) Handles Btnx_BuscarImagen.KeyDown
        If (e.KeyCode = Keys.Enter And Not Lbl_NombreImagen.Text.Equals("")) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TC001", "ca", "canumi=" + Txt_Codigo.Text)
            If IsDBNull(dtAud.Rows(0).Item(0)) = True Then
                lbFecha.Text = ""
            Else
                lbFecha.Text = Convert.ToDateTime(dtAud.Rows(0).Item(0)).ToString("dd/MM/yyyy")
            End If
            lbHora.Text = dtAud.Rows(0).Item(1).ToString
            lbUsuario.Text = dtAud.Rows(0).Item(2).ToString
            FlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            FlyoutUsuario.Content = PanelUsuario
        End If

    End Sub

    Private Sub BBtn_Usuario_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Usuario.Click
        FlyoutUsuario_PrepareContent(BubbleBar5, e)
    End Sub

    Private Sub P_prGuardarImagen(img As String)
        Ptb_Imagen.Image.Save(img, Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub P_ValidacionInicial()
        P_ValidarCarpetaImagenes()
    End Sub

    Private Sub P_ValidarCarpetaImagenes()
        Dim rutaDestino As String = _ruta
        If (System.IO.Directory.Exists(rutaDestino) = False) Then
            System.IO.Directory.CreateDirectory(rutaDestino)
        End If
    End Sub

End Class
