Imports Entidades

Public Class Hotel
    Implements IProducto
    Private _habitaciones As Byte
    Private _noches As Byte
    Private _montoDiaria As Single
    Private _descripcion As String
    Private _fecha As Date
    Private _ciudad As Ciudad
    Public Sub New(descripcion As String, fecha As Date, ciudad As Ciudad, noches As Byte, montodiaria As Single)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.Ciudad = ciudad
        Me.Noches = noches
        Me.MontoDiaria = montodiaria
        _habitaciones = 0
    End Sub
    Public Property Ciudad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
    End Property
    Public Property Habitaciones As Byte
        Get
            Return _habitaciones
        End Get
        Set(value As Byte)
            _habitaciones = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Public Property MontoDiaria As Single
        Get
            Return _montoDiaria
        End Get
        Set(value As Single)
            _montoDiaria = value
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
        Return MontoDiaria * Noches
    End Function
End Class
