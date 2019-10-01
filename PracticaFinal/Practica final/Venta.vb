Public Class Venta
    Private _fecha As Date
    Private _cliente As Cliente
    Public Sub New()
        _fecha = Nothing
    End Sub
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            value.addVentas(Me)
            _cliente = value
        End Set
    End Property
    Public Function montoTotal() As Single
        Return 0
    End Function
    Public Overrides Function ToString() As String
        Return Cliente.Nombre & "(" & Fecha & ")"
    End Function
End Class
