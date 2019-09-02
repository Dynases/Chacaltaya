Imports System.Runtime.Serialization

<DataContractAttribute()> _
Public Class RequestDetail
    <DataMember()> Public obnumi As Integer
    <DataMember()> Public obcprod As String
    <DataMember()> Public obpcant As Integer
    <DataMember()> Public obpbase As Integer
    <DataMember()> Public obptot As Integer

    <DataMember()> Private product As Product

    Public Sub New(numi As Integer, cprod As String, cant As Integer, pbase As Integer, total As Integer, _producto As Product)
        obnumi = numi
        obcprod = cprod
        obpcant = cant
        obpbase = pbase
        obptot = total
        product = _producto
    End Sub
End Class
