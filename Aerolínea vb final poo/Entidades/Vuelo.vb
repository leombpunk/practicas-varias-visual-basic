Public Class Vuelo
    Private _numero As UInt32
    Private _origen As Ciudad
    Private _destino As Ciudad
    Private _asientos As List(Of Asiento)
    Private _encomiendas As List(Of Encomienda)
    Private _equipajes As List(Of Equipaje)
    Private _pasajeros As List(Of Pasajero)
    Public Sub New(numero As UInt32, origen As Ciudad, destino As Ciudad)
        Me.Numero = numero
        Me.Origen = origen
        Me.Destino = destino
        _asientos = New List(Of Asiento)
        _encomiendas = New List(Of Encomienda)
        _equipajes = New List(Of Equipaje)
        _pasajeros = New List(Of Pasajero)
    End Sub
    Public Property Numero As UInt32
        Get
            Return _numero
        End Get
        Set(value As UInt32)
            _numero = value
        End Set
    End Property
    Public Property Origen As Ciudad
        Get
            Return _origen
        End Get
        Set(value As Ciudad)
            _origen = value
        End Set
    End Property
    Public Property Destino As Ciudad
        Get
            Return _destino
        End Get
        Set(value As Ciudad)
            _destino = value
        End Set
    End Property
    Public Sub addAsiento(asiento As Asiento)
        _asientos.Add(asiento)
        _pasajeros.Add(asiento.Pasajero)
    End Sub
    Public Sub addEncomienda(encomienda As Encomienda)
        _encomiendas.Add(encomienda)
    End Sub
    Public Function getAllEncomiendas() As List(Of Encomienda)
        Return _encomiendas
    End Function
    Public Sub removeEncomienda(encomienda As Encomienda)
        _encomiendas.Remove(encomienda)
    End Sub
    Friend Sub addEquipaje(equipaje As Equipaje)
        _equipajes.Add(equipaje)
    End Sub
    Friend Sub removeEquipaje(equipaje As Equipaje)
        _equipajes.Remove(equipaje)
    End Sub
    Public Function getTotalKilosBultos() As Double
        Dim totalKilosBultos As Double = 0
        For Each Encomienda As Encomienda In getAllEncomiendas()
            totalKilosBultos += Encomienda.Kilos
        Next
        Return totalKilosBultos
    End Function
    Public Overrides Function ToString() As String
        Return Numero & "(" & Origen.Nombre & "-" & Destino.Nombre & ")"
    End Function
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
    Public Function getPasajeroByDni(dni As UInt32) As Pasajero
        For Each Pasajero As Pasajero In getAllPasajeros()
            If Pasajero.Dni = dni Then
                Return Pasajero
            End If
        Next
        'Return "pasajero no encontrado"
    End Function
End Class
