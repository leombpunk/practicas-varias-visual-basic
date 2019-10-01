Imports Entidades
Public Class Paquete
    Implements IProducto
    Private _pasajeros As List(Of Pasajero)
    Private _iproducto As List(Of IProducto)
    Private _fechaFinal As Date
    Private _numeroDias As UShort
    Private _numeroPasajeros As UShort
    Private _descripcion As String
    Private _fecha As Date
    Private _costo As Single
    Public Sub New(descripcion As String, fecha As Date, fechaFinal As Date)
        _iproducto = New List(Of IProducto)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.fechaFinal = fechaFinal
        _numeroDias = 0
        _numeroPasajeros = 0
        _costo = 0
        _pasajeros = New List(Of Pasajero)
    End Sub
    Public ReadOnly Property numeroDias As UShort
        Get
            Return DateDiff(DateInterval.DayOfYear, Fecha, fechaFinal)
        End Get
    End Property
    Public ReadOnly Property numeroPasajeros As UShort
        Get
            Return _numeroPasajeros
        End Get
    End Property
    Public Property fechaFinal As Date
        Get
            Return _fechaFinal
        End Get
        Set(value As Date)
            _fechaFinal = value
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
        Dim total_sumatoria_costos As Single = 0
        For Each productio As IProducto In getAllProductos()
            total_sumatoria_costos += productio.costo
        Next
        Return total_sumatoria_costos
    End Function
    Public Sub addPasajero(pasajero As Pasajero)
        _pasajeros.Add(pasajero)
        _numeroPasajeros += 1
    End Sub
    Public Sub removePasajero(pasajero As Pasajero)
        _pasajeros.Remove(pasajero)
        _numeroPasajeros -= 1
    End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
    Public Sub addProducto(producto As IProducto)
        _iproducto.Add(producto)
        _costo = Modifico_costo_aleatorio()
    End Sub
    Public Sub removeProducto(producto As IProducto)
        _iproducto.Remove(producto)
        _costo = Modifico_costo_aleatorio()
    End Sub
    Public Function getAllProductos() As List(Of IProducto)
        Return _iproducto
    End Function
    Public Overrides Function ToString() As String
        Dim lista_productos As String = ""
        For Each producto As IProducto In getAllProductos()
            lista_productos += producto.Descripcion & " "
        Next
        Return lista_productos
    End Function
    Private Function Modifico_costo_aleatorio() As Single
        Dim numAleatorio1 As New Random()
        Dim valorAleatorio1 As Integer = numAleatorio1.Next(100, 1000)
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Single = numAleatorio.NextDouble
        Return valorAleatorio1 + valorAleatorio
    End Function
End Class
