Public Class Cliente
    Inherits Pasajero
    Private _cuit_cuil As String
    Private _ventas As List(Of Venta)
    Public Sub New(pasajero As Pasajero, cuit_cuil As String)
        MyBase.New(pasajero.Dni, pasajero.Nombre)
        Me.Cuit_Cuil = cuit_cuil
        _ventas = New List(Of Venta)
    End Sub
    Public Property Cuit_Cuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            _cuit_cuil = value
        End Set
    End Property
    Friend Sub addVentas(venta As Venta)
        _ventas.Add(venta)
    End Sub
    Public Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
    Public Overrides Function ToString() As String
        Return Nombre & "(" & Cuit_Cuil & ")"
    End Function
End Class
