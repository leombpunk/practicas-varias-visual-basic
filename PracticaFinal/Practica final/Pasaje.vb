Imports Entidades

Public Class Pasaje
    Implements IProducto
    Private _valor As Single
    Private _descripcion As String
    Private _fecha As Date
    Private _ciudadOrigen As Ciudad
    Private _ciudadDestino As Ciudad
    Public Sub New(descripcion As String, fecha As Date, valor As Single, origen As Ciudad, destino As Ciudad)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.Valor = valor
        Me.Origen = origen
        Me.Destino = destino
    End Sub
    Public Property Valor As Single 'writeonly
        Get
            Return _valor
        End Get
        Set(value As Single)
            _valor = value
        End Set
    End Property
    Public Property Origen As Ciudad
        Get
            Return _ciudadOrigen
        End Get
        Set(value As Ciudad)
            _ciudadOrigen = value
        End Set
    End Property
    Public Property Destino As Ciudad
        Get
            Return _ciudadDestino
        End Get
        Set(value As Ciudad)
            _ciudadDestino = value
        End Set
    End Property
    Public Property Descripcion As String Implements IProducto.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha As Date Implements IProducto.Fecha
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Function costo() As Single Implements IProducto.costo
        Return _valor
    End Function
End Class
