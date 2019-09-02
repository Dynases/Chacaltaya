Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX

Public Class P_Empleados

#Region "Variables Lcales"
    Dim _Dsencabezado As DataSet
    Dim _Pos As Integer
    Dim _Nuevo As Boolean
    Dim _RutaImagenes As String

#End Region

#Region "Metodos Privados"

    Private Sub _PCargarBuscador()
        Dim dt As New DataTable
        dt = L_Empleado_General(0, , "cbfing").Tables(0)

        JGr_Buscador.BoundMode = BoundMode.Bound
        JGr_Buscador.DataSource = dt
        JGr_Buscador.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Buscador.RootTable.Columns("cbnumi")
            .Caption = "Codigo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbdesc")
            .Caption = "Nombre"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbdirec")
            .Caption = "Direccion"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbtelef")
            .Caption = "Telefono"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbcat")
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("cedesc")
            .Caption = "Categoria"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbsal")
            .Caption = "Salario"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Buscador.RootTable.Columns("cbci")
            .Caption = "CI"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbobs")
            .Caption = "Observacion"
            .Width = 150
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbfnac")
            .Caption = "Fecha Nac"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbfing")
            .Caption = "Fecha Ing"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbfret")
            .Caption = "Fecha Retiro"
            .Width = 100
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Buscador.RootTable.Columns("cbfot")
            .Visible = False
        End With

        With JGr_Buscador.RootTable.Columns("cbest")
            .Caption = "Estado"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbeciv")
            .Caption = "Est. Civil"
            .Width = 130
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        With JGr_Buscador.RootTable.Columns("cbplan")
            .Caption = "Planilla"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
        End With

        'Habilitar Filtradores
        With JGr_Buscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False

            'diseño de la grilla
            JGr_Buscador.VisualStyle = VisualStyle.Office2007
        End With


    End Sub

    Private Sub _PCargarGridSueldos(idCabecera As String)
        Dim dt As New DataTable
        dt = L_EmpleadoDetalleSueldos_General(-1, idCabecera)

        JGr_Sueldos.BoundMode = BoundMode.Bound
        JGr_Sueldos.DataSource = dt
        JGr_Sueldos.RetrieveStructure()

        'dar formato a las columnas
        With JGr_Sueldos.RootTable.Columns("chnumi")
            .Caption = "Codigo"
            .Visible = False
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Sueldos.RootTable.Columns("chano")
            .Caption = "Año"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Sueldos.RootTable.Columns("chmes")
            .Caption = "Mes"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        End With

        With JGr_Sueldos.RootTable.Columns("chsueldo")
            .Caption = "Sueldo"
            .Width = 70
            .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .CellStyle.FontSize = gi_fuenteTamano
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .FormatString = "0.00"
        End With

        With JGr_Sueldos
            .GroupByBoxVisible = False

            'diseño de la grilla
            JGr_Sueldos.VisualStyle = VisualStyle.Office2007
            .AllowAddNew = InheritableBoolean.False
        End With


    End Sub

    Private Sub _PCargarComboLibreria(ByVal cb As Janus.Windows.GridEX.EditControls.MultiColumnCombo, ByVal concep As Integer)
        Dim _Ds As New DataSet
        _Ds = L_General_LibreriaDetalle(-1, concep)

        cb.DropDownList.Columns.Clear()

        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cenum").ToString).Width = 50
        cb.DropDownList.Columns(0).Caption = "Código"
        cb.DropDownList.Columns.Add(_Ds.Tables(0).Columns("cedesc").ToString).Width = 250
        cb.DropDownList.Columns(1).Caption = "Descripcion"

        cb.ValueMember = _Ds.Tables(0).Columns("cenum").ToString
        cb.DisplayMember = _Ds.Tables(0).Columns("cedesc").ToString
        cb.DataSource = _Ds.Tables(0)
        cb.Refresh()

    End Sub

    Private Sub _PHabilitar()
        'Tb_Nombre.Enabled = True
        'Tb_Direccion.Enabled = True
        'Tb_Telef.Enabled = True
        'Tb_Ci.Enabled = True
        'Tb_Estado.Enabled = True
        'Tb_FechaNac.Enabled = True
        'Tb_Obs.Enabled = True
        'Tb_FechaRetiro.Enabled = True
        'Tb_FechaIngreso.Enabled = True
        'Tb_EstadoCivil.Enabled = True

        Tb_Nombre.ReadOnly = False
        Tb_Direccion.ReadOnly = False
        Tb_Telef.ReadOnly = False
        Tb_Ci.ReadOnly = False
        Tb_Estado.Enabled = True
        Tb_FechaNac.Enabled = True
        Tb_Obs.ReadOnly = False
        Tb_FechaRetiro.Enabled = True
        Tb_FechaIngreso.Enabled = True
        Tb_EstadoCivil.ReadOnly = False
        tbPlanilla.Enabled = True

        Btn_SelecFoto.Enabled = True

        BBtn_Nuevo.Enabled = False
        BBtn_Modificar.Enabled = False
        BBtn_Eliminar.Enabled = False
        BBtn_Grabar.Enabled = True

        JMC_Categoria.Enabled = True

        OpenFileDialog1.CheckFileExists = False 'para decir que no selecciono nada PREGUNTAR QUE HAGO CON LA IMAGEN

        'habilitar adicion de nuevas filas en el grid de sueldos
        JGr_Sueldos.AllowAddNew = InheritableBoolean.True
        JGr_Sueldos.Enabled = True
    End Sub
    Private Sub _PInhabilitar()
        'Tb_Id.Enabled = False
        'Tb_Nombre.Enabled = False
        'Tb_Direccion.Enabled = False
        'Tb_Telef.Enabled = False
        'Tb_Ci.Enabled = False
        'Tb_Estado.Enabled = False
        'Tb_FechaNac.Enabled = False
        'Tb_Obs.Enabled = False
        'Tb_Salario.Enabled = False
        'Tb_FechaRetiro.Enabled = False
        'Tb_FechaIngreso.Enabled = False
        'Tb_EstadoCivil.Enabled = False

        Tb_Id.ReadOnly = True
        Tb_Nombre.ReadOnly = True
        Tb_Direccion.ReadOnly = True
        Tb_Telef.ReadOnly = True
        Tb_Ci.ReadOnly = True
        Tb_Estado.Enabled = False
        Tb_FechaNac.Enabled = False
        Tb_Obs.ReadOnly = True
        Tb_Salario.ReadOnly = True
        Tb_FechaRetiro.Enabled = False
        Tb_FechaIngreso.Enabled = False
        Tb_EstadoCivil.ReadOnly = True
        tbPlanilla.Enabled = False

        Btn_SelecFoto.Enabled = False

        BBtn_Nuevo.Enabled = True
        BBtn_Modificar.Enabled = True
        BBtn_Eliminar.Enabled = True
        BBtn_Grabar.Enabled = False

        'Txt_Paginacion.Text = ""

        JMC_Categoria.Enabled = False

        BBtn_Grabar.Image = My.Resources.GRABAR
        BBtn_Grabar.ImageLarge = My.Resources.GRABAR

        JGr_Sueldos.Enabled = False

        _PLimpiarErrores()

        JGr_Buscador.Enabled = True
    End Sub
    Private Sub _PLimpiarErrores()
        EP1.Clear()
        Tb_Nombre.BackColor = Color.White
        Tb_Direccion.BackColor = Color.White
        Tb_Telef.BackColor = Color.White
        Tb_Ci.BackColor = Color.White
        Tb_Obs.BackColor = Color.White
        Tb_Salario.BackColor = Color.White
        JMC_Categoria.BackColor = Color.White
        Tb_EstadoCivil.BackColor = Color.White
    End Sub
    Private Sub _PLimpiar()
        Tb_Id.Text = ""
        Tb_Nombre.Text = ""
        Tb_Direccion.Text = ""
        Tb_Telef.Text = ""
        Tb_Ci.Text = ""
        Tb_Estado.Value = True
        Tb_Obs.Text = ""
        Tb_Salario.Text = ""
        Tb_FechaRetiro.Value = Today.Date
        Tb_FechaIngreso.Value = Today.Date
        Tb_EstadoCivil.Text = ""
        tbPlanilla.Value = True

        'aumentado 
        Txt_Paginacion.Text = ""

        OpenFileDialog1.CheckFileExists = False 'para decir que no selecciono nada PREGUNTAR QUE HAGO CON LA IMAGEN
        Pb_Foto.Image = Nothing
        Tb_Imagen.Text = ""

        _PCargarGridSueldos(-1)
        JGr_Sueldos.AllowAddNew = InheritableBoolean.True
    End Sub
    Private Sub _PHabilitarFocus()

        HighLigthter_Focus.SetHighlightOnFocus(Tb_Ci, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Nombre, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Direccion, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Telef, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_FechaNac, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Estado, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(JMC_Categoria, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Salario, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_FechaRetiro, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_FechaIngreso, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_Obs, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(Tb_EstadoCivil, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)
        HighLigthter_Focus.SetHighlightOnFocus(tbPlanilla, DevComponents.DotNetBar.Validator.eHighlightColor.Blue)

        Tb_Ci.TabIndex = 1
        Tb_Nombre.TabIndex = 2
        Tb_Direccion.TabIndex = 3
        Tb_Telef.TabIndex = 4
        Tb_FechaNac.TabIndex = 5
        Tb_EstadoCivil.TabIndex = 6
        Tb_Estado.TabIndex = 7
        JMC_Categoria.TabIndex = 8
        'Tb_Salario.TabIndex = 8
        Tb_FechaRetiro.TabIndex = 9
        Tb_Obs.TabIndex = 10
        JGr_Sueldos.TabIndex = 11

    End Sub


    Private Sub _PIniciarTodo()
        'abrir conexion
        'L_abrirConexion()

        Me.Text = "E M P L E A D O S"
        Me.WindowState = FormWindowState.Maximized

        'iniciar variables
        '_RutaImagenes = "C:\BD\Imagenes\"
        _RutaImagenes = gs_rutaImagenes + "\"

        _PCargarComboLibreria(JMC_Categoria, 7)

        _PCargarBuscador()
        _PFiltrar()
        _PInhabilitar()

        _PHabilitarFocus()

        _pCambiarFuente()

        SuperTabItem2.Visible = False
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

    Private Sub _PFiltrar()
        _Dsencabezado = New DataSet
        _Dsencabezado = L_Empleado_General(0)
        '_First = False
        If _Dsencabezado.Tables(0).Rows.Count <> 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
            If _Dsencabezado.Tables(0).Rows.Count > 0 Then
                BBtn_Inicio.Visible = True
                BBtn_Anterior.Visible = True
                BBtn_Siguiente.Visible = True
                BBtn_Ultimo.Visible = True
            End If
        End If

    End Sub
    Private Sub _PMostrarRegistro(_N As Integer)

        JGr_Buscador.Row = _Pos
        With JGr_Buscador
            Tb_Id.Text = .GetValue("cbnumi").ToString
            Tb_Nombre.Text = .GetValue("cbdesc").ToString
            Tb_Direccion.Text = .GetValue("cbdirec").ToString
            Tb_Telef.Text = .GetValue("cbtelef").ToString

            Dim codZona As String = .GetValue("cbcat").ToString
            JMC_Categoria.Text = .GetValue("cedesc").ToString

            Tb_Salario.Text = .GetValue("cbsal").ToString
            Tb_Ci.Text = .GetValue("cbci").ToString
            Tb_Obs.Text = .GetValue("cbobs").ToString.Trim
            If .GetValue("cbfnac").ToString <> "" Then
                Tb_FechaNac.Value = .GetValue("cbfnac").ToString
            End If

            If .GetValue("cbfing").ToString <> "" Then
                Tb_FechaIngreso.Value = .GetValue("cbfing").ToString
            End If

            If .GetValue("cbfret").ToString <> "" Then
                Tb_FechaRetiro.Value = .GetValue("cbfret").ToString
            End If

            Tb_Estado.Value = IIf(IsDBNull(.GetValue("cbest")), False, .GetValue("cbest"))
            Tb_EstadoCivil.Text = IIf(IsDBNull(.GetValue("cbeciv")), "", .GetValue("cbeciv"))
            tbPlanilla.Value = IIf(IsDBNull(.GetValue("cbplan")), False, .GetValue("cbplan"))

            Tb_Imagen.Text = .GetValue("cbfot").ToString
            'cargar imagen
            Pb_Foto.SizeMode = PictureBoxSizeMode.StretchImage
            Try
                'PictureBox1.Load("C:\BD\Imagenes\" + nomIma)
                Pb_Foto.Load(_RutaImagenes + Tb_Imagen.Text)
            Catch ex As Exception
                Pb_Foto.Image = Nothing
            End Try
        End With

        'mostrar detalle de sueldos del empleado
        _PCargarGridSueldos(Tb_Id.Text)

        Txt_Paginacion.Text = Str(_Pos + 1) + "/" + JGr_Buscador.RowCount.ToString
    End Sub

    Public Overrides Function P_Validar() As Boolean
        Return Not _PValidar()
    End Function
    Private Function _PValidar() As Boolean
        Dim _Error As Boolean = False
        EP1.Clear()
        If Tb_Nombre.Text = "" Then
            Tb_Nombre.BackColor = Color.Red
            EP1.SetError(Tb_Nombre, "Ingrese el nombre del empleado!")
            _Error = True
        Else
            Tb_Nombre.BackColor = Color.White
            EP1.SetError(Tb_Nombre, "")
        End If

        If Tb_Direccion.Text = "" Then
            Tb_Direccion.BackColor = Color.Red
            EP1.SetError(Tb_Direccion, "Ingrese la direccion del empleado!")
            _Error = True
        Else
            Tb_Direccion.BackColor = Color.White
            EP1.SetError(Tb_Direccion, "")
        End If

        If Tb_Telef.Text = "" Then
            Tb_Telef.BackColor = Color.Red
            EP1.SetError(Tb_Telef, "Ingrese el telefono del empleado!")
            _Error = True
        Else
            Tb_Telef.BackColor = Color.White
            EP1.SetError(Tb_Telef, "")
        End If

        If Tb_Ci.Text = "" Then
            Tb_Ci.BackColor = Color.Red
            EP1.SetError(Tb_Ci, "Ingrese el CI del empleado!")
            _Error = True
        Else
            Tb_Ci.BackColor = Color.White
            EP1.SetError(Tb_Ci, "")
        End If

        'If Tb_Salario.Text = "" Then
        '    Tb_Salario.BackColor = Color.Red
        '    EP1.SetError(Tb_Salario, "Ingrese el salario del empleado!")
        '    _Error = True
        'Else
        '    Tb_Salario.BackColor = Color.White
        '    EP1.SetError(Tb_Salario, "")
        'End If

        If JMC_Categoria.SelectedIndex < 0 Then
            JMC_Categoria.BackColor = Color.Red   'error de validacion
            EP1.SetError(JMC_Categoria, "Seleccione la categoria del empleado!")
            _Error = True
        Else
            JMC_Categoria.BackColor = Color.White
            EP1.SetError(JMC_Categoria, "")
        End If

        If Tb_EstadoCivil.Text = "" Then
            Tb_EstadoCivil.BackColor = Color.Red
            EP1.SetError(Tb_EstadoCivil, "Ingrese el estado civil del empleado!")
            _Error = True
        Else
            Tb_EstadoCivil.BackColor = Color.White
            EP1.SetError(Tb_EstadoCivil, "")
        End If

        HighLigthter_Focus.UpdateHighlights()
        Return _Error
    End Function

    Private Sub _PGrabarRegistro()
        Dim _Error As Boolean = False
        If P_Validar() = False Then
            Exit Sub
        End If
        If BBtn_Grabar.Enabled = False Then
            Exit Sub
        End If

        'If Lb_Mensaje.Text = "" Then
        '    Lb_Mensaje.Text = "Esta Seguro de Grabar?"
        '    Exit Sub
        'Else
        '    Lb_Mensaje.Text = ""
        'End If
        If BBtn_Grabar.Tag = 0 Then
            BBtn_Grabar.Tag = 1
            'BBtn_Grabar.Image = My.Resources.CONFIRMACION
            'BBtn_Grabar.ImageLarge = My.Resources.CONFIRMACION
            BubbleBar1.Refresh()
            Exit Sub
        Else
            BBtn_Grabar.Tag = 0
            'BBtn_Grabar.Image = My.Resources.GRABAR
            'BBtn_Grabar.ImageLarge = My.Resources.GRABAR
            BubbleBar1.Refresh()
        End If


        If _Nuevo Then
            Dim estado As String
            If Tb_Estado.Value = True Then
                estado = "1"
            Else
                estado = "0"
            End If

            L_Empleado_Grabar(Tb_Id.Text, Tb_Nombre.Text, Tb_Direccion.Text, Tb_Telef.Text, JMC_Categoria.Value, 0, Tb_Ci.Text, Tb_Obs.Text, Tb_FechaNac.Value.ToString("yyyy/MM/dd"), Tb_FechaIngreso.Value.ToString("yyyy/MM/dd"), Tb_FechaRetiro.Value.ToString("yyyy/MM/dd"), Tb_Imagen.Text, estado, Tb_EstadoCivil.Text, IIf(tbPlanilla.Value = True, "1", "0"), 0) ''0=estado del reloj

            'copio la imagen en la carpeta del sistema
            Dim ruta As String = OpenFileDialog1.FileName
            'Dim nombre As String = OpenFileDialog1.SafeFileName
            If OpenFileDialog1.CheckFileExists = True Then
                'FileCopy(ruta, "C:\BD\Imagenes\" + Tb_Imagen.Text) 'CONSULTAR POR LA EXTENCION ya que si no la pongo no se puede ver por el explador, pero sirve
                FileCopy(ruta, _RutaImagenes + Tb_Imagen.Text) 'CONSULTAR POR LA EXTENCION ya que si no la pongo no se puede ver por el explador, pero sirve
            End If

            'grabar el detalle de sueldos
            Dim i As Integer
            Dim anio, mes, sueldo As String
            sueldo = "0"
            With JGr_Sueldos
                For i = 0 To .RowCount - 1
                    .Row = i
                    anio = .GetValue("chano")
                    mes = .GetValue("chmes")
                    sueldo = .GetValue("chsueldo")
                    L_EmpleadoDetalleSueldos_Grabar(Tb_Id.Text, anio, mes, sueldo)
                Next
            End With
            L_Empleado_ModificarSalario(Tb_Id.Text, sueldo) 'actualizo el salario del empleado al ultimo ingresado

            'actualizar el grid de buscador
            _PCargarBuscador()

            Tb_Ci.Focus()
            ToastNotification.Show(Me, "Codigo de Empleado " + Tb_Id.Text + " Grabado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)
            _PLimpiar()
        Else
            Dim estado As String
            If Tb_Estado.Value = True Then
                estado = "1"
            Else
                estado = "0"
            End If
            L_Empleado_Modificar(Tb_Id.Text, Tb_Nombre.Text, Tb_Direccion.Text, Tb_Telef.Text, JMC_Categoria.Value, Tb_Salario.Text, Tb_Ci.Text, Tb_Obs.Text, Tb_FechaNac.Value.ToString("yyyy/MM/dd"), Tb_FechaIngreso.Value.ToString("yyyy/MM/dd"), Tb_FechaRetiro.Value.ToString("yyyy/MM/dd"), Tb_Imagen.Text, estado, Tb_EstadoCivil.Text, IIf(tbPlanilla.Value = True, "1", "0"))

            'copio la imagen en la carpeta del sistema
            Dim ruta As String = OpenFileDialog1.FileName
            'Dim nombre As String = OpenFileDialog1.SafeFileName
            Dim nombre As String = "im" + Tb_Id.Text
            If OpenFileDialog1.CheckFileExists = True Then
                'FileCopy(ruta, "C:\BD\Imagenes\" + Tb_Imagen.Text) 'CONSULTAR POR LA EXTENCION ya que si no la pongo no se puede ver por el explador, pero sirve
                FileCopy(ruta, _RutaImagenes + Tb_Imagen.Text) 'CONSULTAR POR LA EXTENCION ya que si no la pongo no se puede ver por el explador, pero sirve
            End If

            'grabar el detalle de sueldos
            Dim i As Integer
            Dim anio, mes, sueldo As String
            L_EmpleadoDetalleSueldos_Borrar(Tb_Id.Text)
            sueldo = "0"
            With JGr_Sueldos
                For i = 0 To .RowCount - 1
                    .Row = i
                    anio = .GetValue("chano")
                    mes = .GetValue("chmes")
                    sueldo = .GetValue("chsueldo")
                    L_EmpleadoDetalleSueldos_Grabar(Tb_Id.Text, anio, mes, sueldo)
                Next
            End With
            L_Empleado_ModificarSalario(Tb_Id.Text, sueldo) 'actualizo el salario del empleado al ultimo ingresado

            ToastNotification.Show(Me, "Codigo de Empleado " + Tb_Id.Text + " Modificado con Exito.", My.Resources.GRABACION_EXITOSA, 5000, eToastGlowColor.Green, eToastPosition.TopCenter)

            'actualizar el grid de buscador
            _PCargarBuscador()

            _Nuevo = False 'aumentado danny
            _PInhabilitar()
            _PFiltrar()
        End If
    End Sub

    Private Sub _PNuevoRegistro()
        _PHabilitar()
        BBtn_Nuevo.Enabled = True

        _PLimpiar()
        Tb_Ci.Focus()
        _Nuevo = True
    End Sub

    Private Sub _PModificarRegistro()
        _Nuevo = False
        '_Modificar = True
        _PHabilitar()
        BBtn_Modificar.Enabled = True 'aumentado para q funcione con el modelo de guido
    End Sub

    Private Sub _PEliminarRegistro()
        Dim _Result As MsgBoxResult
        _Result = MsgBox("Esta seguro de Eliminar el Registro?", MsgBoxStyle.YesNo, "Advertencia")
        If _Result = MsgBoxResult.Yes Then
            L_Empleado_Borrar(Tb_Id.Text)
            'borro el detalle del encabezado
            'L_Borrar_LibreriasDetalle(Tb_Id.Text)
            _PFiltrar()

            'mi codigo, actualizo el sub
            _Pos = 0
            Txt_Paginacion.Text = Str(_Pos + 1) + "/" + _Dsencabezado.Tables(0).Rows.Count.ToString
        End If
    End Sub

    Private Sub _PSalirRegistro()
        If BBtn_Grabar.Enabled = True Then
            _PInhabilitar()
            _PFiltrar()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub _PGrabarNuevasLibrerias()
        ''Dim codCiu, codProv, codZona As Integer
        ''If J_Cb_Ciudad.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(13, 13, codCiu, J_Cb_Ciudad.Text)
        ''    _LlenarComboLibreria(J_Cb_Ciudad, 13)
        ''    J_Cb_Ciudad.Value = codCiu
        ''    Ep2.SetError(J_Cb_Ciudad, "")
        ''End If

        ''If J_Cb_Provincia.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(4, 4, codProv, J_Cb_Provincia.Text)
        ''    _LlenarComboLibreria(J_Cb_Provincia, 4)
        ''    J_Cb_Provincia.Value = codProv
        ''    Ep2.SetError(J_Cb_Provincia, "")
        ''End If

        ''If J_Cb_Zona.SelectedIndex < 0 Then
        ''    L_Grabar_LibreriaDetalle(2, 2, codZona, J_Cb_Zona.Text)
        ''    _LlenarComboLibreria(J_Cb_Zona, 2)
        ''    J_Cb_Zona.Value = codZona
        ''    Ep2.SetError(J_Cb_Zona, "")
        ''End If
        ''Pan_Dialogo.Visible = False
    End Sub

    Private Sub _PPrimerRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = 0
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PAnteriorRegistro()
        If _Pos > 0 Then
            _Pos = _Pos - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PSiguienteRegistro()
        If _Pos < JGr_Buscador.RowCount - 1 Then
            _Pos = _Pos + 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub
    Private Sub _PUltimoRegistro()
        If JGr_Buscador.RowCount > 0 Then
            _Pos = JGr_Buscador.RowCount - 1
            _PMostrarRegistro(_Pos)
        End If
    End Sub

    Private Sub _PCargarImagen()

        Dim ruta As String
        OpenFileDialog1.InitialDirectory = "C:\Users\" + Environment.UserName + "\Pictures"
        OpenFileDialog1.Filter = "Imagen|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ruta = OpenFileDialog1.FileName
            Dim nombre As String = OpenFileDialog1.SafeFileName
            'FileCopy(ruta, "C:\BD\Imagenes\" + nombre)
            'Tb_ExtIma.Text = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            Tb_Imagen.Text = nombre
            Pb_Foto.SizeMode = PictureBoxSizeMode.StretchImage
            Pb_Foto.Load(ruta)
            OpenFileDialog1.CheckFileExists = True
        End If
    End Sub

#End Region
    Private Sub P_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _PIniciarTodo()
    End Sub

    Private Sub BBtn_Nuevo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Nuevo.Click
        _PNuevoRegistro()
        JGr_Buscador.Enabled = False
    End Sub

    Private Sub BBtn_Modificar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Modificar.Click
        _PModificarRegistro()
        JGr_Buscador.Enabled = False
    End Sub

    Private Sub BBtn_Eliminar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Eliminar.Click
        _PEliminarRegistro()
    End Sub

    Private Sub BBtn_Grabar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Grabar.Click
        _PGrabarRegistro()
    End Sub

    Private Sub BBtn_Cancelar_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Cancelar.Click
        _PSalirRegistro()
    End Sub

    Private Sub BBtn_Inicio_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Inicio.Click
        _PPrimerRegistro()
    End Sub

    Private Sub BBtn_Anterior_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Anterior.Click
        _PAnteriorRegistro()
    End Sub

    Private Sub BBtn_Siguiente_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Siguiente.Click
        _PSiguienteRegistro()
    End Sub

    Private Sub BBtn_Ultimo_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Ultimo.Click
        _PUltimoRegistro()
    End Sub

    Private Sub P_Empleados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If BBtn_Grabar.Enabled = True Then
            Dim _Result = MessageBox.Show("¿Esta seguro de salir sin guardar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If _Result = Windows.Forms.DialogResult.OK Then
                e.Cancel = False
                Me.Dispose()
            Else
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_SelecFoto.Click
        _PCargarImagen()
    End Sub

    Private Sub JGr_Buscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles JGr_Buscador.EditingCell
        e.Cancel = True
    End Sub

    Private Sub JGr_Buscador_SelectionChanged(sender As Object, e As EventArgs) Handles JGr_Buscador.SelectionChanged
        If JGr_Buscador.Row >= 0 Then
            _Pos = JGr_Buscador.Row
            _PMostrarRegistro(_Pos)
        End If

    End Sub

    Private Sub P_Empleados_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BBtn_Usuario_Click(sender As Object, e As ClickEventArgs) Handles BBtn_Usuario.Click
       FlyoutUsuario_PrepareContent(BubbleBar5, e)
    End Sub

    Private Sub FlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles FlyoutUsuario.PrepareContent
        If sender Is BubbleBar5 And BBtn_Grabar.Enabled = False Then
            Dim dtAud As DataTable = L_ObtenerAuditoria("TC002", "cb", "cbnumi=" + Tb_Id.Text)
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
End Class
