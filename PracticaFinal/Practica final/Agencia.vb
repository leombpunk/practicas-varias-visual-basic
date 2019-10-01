Public Class Agencia
    Private Shared _ventas As List(Of Venta)
    Public Sub New()
        _ventas = New List(Of Venta)
    End Sub
    Public Shared Sub addVenta(venta As Venta)
        _ventas.Add(venta)
    End Sub
    Public Shared Sub removeVenta(venta As Venta)
        _ventas.Remove(venta)
    End Sub
    Public Shared Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
End Class
