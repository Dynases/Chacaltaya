﻿Imports Janus.Windows.GridEX

Public Class ModeloAyuda

#Region "ATRIBUTOS"
    Public dtBuscador As DataTable
    Public nombreVista As String
    Public posX As Integer
    Public posY As Integer
    Public seleccionado As Boolean

    Public filaSelect As Janus.Windows.GridEX.GridEXRow

    Public listEstrucGrilla As List(Of Celda)
#End Region

#Region "METODOS PRIVADOS"
    Public Sub New(ByVal x As Integer, y As Integer, dt1 As DataTable, titulo As String, listEst As List(Of Celda))
        dtBuscador = dt1
        posX = x
        posY = y
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(posX, posY)
        GPPanelP.Text = titulo

        listEstrucGrilla = listEst

        seleccionado = False

        _PMCargarBuscador()
        'grJBuscador.Row = grJBuscador.FilterRow.RowIndex
        'grJBuscador.Col = 1

    End Sub

    Private Sub _PMCargarBuscador()

        Dim anchoVentana As Integer = 0

        grJBuscador.DataSource = dtBuscador
        grJBuscador.RetrieveStructure()


        For i = 0 To dtBuscador.Columns.Count - 1
            With grJBuscador.RootTable.Columns(i)
                If listEstrucGrilla.Item(i).visible = True Then
                    .Caption = listEstrucGrilla.Item(i).titulo
                    .Width = listEstrucGrilla.Item(i).tamano
                    .HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .CellStyle.FontSize = 9

                    Dim col As DataColumn = dtBuscador.Columns(i)
                    Dim tipo As Type = col.DataType
                    If tipo.ToString = "System.Int32" Or tipo.ToString = "System.Decimal" Then
                        .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                    End If
                    If listEstrucGrilla.Item(i).formato = String.Empty Then
                        .FormatString = listEstrucGrilla.Item(i).formato
                    End If

                    anchoVentana = anchoVentana + listEstrucGrilla.Item(i).tamano
                Else
                    .Visible = False
                End If
            End With
        Next

        'Habilitar Filtradores
        With grJBuscador
            .DefaultFilterRowComparison = FilterConditionOperator.Contains
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            'diseño de la grilla
            .GroupByBoxVisible = False
            .VisualStyle = VisualStyle.Office2007
        End With

        'adaptar el tamaño de la ventana
        Me.Width = anchoVentana + 50
    End Sub
#End Region

    Private Sub ModeloAyuda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If (e.KeyChar = ChrW(Keys.Escape)) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub grJBuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles grJBuscador.KeyDown

        If e.KeyData = Keys.Escape Then
            Me.Close()
        End If

        If e.KeyData = Keys.Enter Then
            P_prDevolverFila()
        End If
    End Sub

    Private Sub grJBuscador_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grJBuscador.EditingCell
        e.Cancel = True
    End Sub

    Private Sub P_prDevolverFila()
        filaSelect = grJBuscador.GetRow()
        seleccionado = True
        Me.Close()
    End Sub

    Private Sub grJBuscador_DoubleClick(sender As Object, e As EventArgs) Handles grJBuscador.DoubleClick
        If (grJBuscador.Col > -1) Then
            P_prDevolverFila()
        End If
    End Sub
End Class