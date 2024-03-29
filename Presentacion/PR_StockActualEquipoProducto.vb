﻿Imports Logica.AccesoLogica
Public Class PR_StockActualEquipoProducto

#Region "Atributos"

    Private Titulo As String
    Private Tipo As Byte

    Public Property pTitulo() As String
        Get
            Return Titulo
        End Get
        Set(ByVal valor As String)
            Titulo = valor
        End Set
    End Property

    Public Property pTipo() As Byte
        Get
            Return Tipo
        End Get
        Set(ByVal valor As Byte)
            Tipo = valor
        End Set
    End Property

#End Region

    Private Sub _prCargarReporte()
        Dim _dt As New DataTable

        Dim objrep As New R_StockActual()

        _dt = L_VistaStockActual(IIf(pTipo = 1, "cenum=11", "cenum<>11"))

        objrep.SetDataSource(_dt)
        CrystalReportViewer1.ReportSource = objrep

    End Sub
    Private Sub PR_StockActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = pTitulo
        _prCargarReporte()
    End Sub
End Class