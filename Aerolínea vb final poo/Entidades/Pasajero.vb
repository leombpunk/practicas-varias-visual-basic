Public Class Pasajero
    Inherits Cliente
    Private _equipaje As List(Of Equipaje)
    Private _asiento As Asiento
    Public Sub New(dni As UInt32, nombre As String)
        MyBase.New(dni, nombre)
        _equipaje = New List(Of Equipaje)
        _asiento = Nothing
    End Sub
    Public Property Asiento As Asiento
        Get
            Return _asiento
        End Get
        Set(value As Asiento)
            value.Pasajero = Me
            _asiento = value
        End Set
    End Property
    Public Function getTotalKilosEquipaje() As Single
        Dim _totalKilos As Single = 0
        For Each equipaje As Equipaje In getAllEquipajes()
            _totalKilos += equipaje.Kilos
        Next
        Return _totalKilos
    End Function
    Public Sub addEquipaje(equipaje As Equipaje)
        If _equipaje.Count < 3 Then
            _equipaje.Add(equipaje)
        End If
    End Sub
    Public Function getAllEquipajes() As List(Of Equipaje)
        Return _equipaje
    End Function
    Public Sub removeEquipaje(equipaje As Equipaje)
        If _equipaje.Count > 0 Then
            _equipaje.Remove(equipaje)
        End If
    End Sub
End Class
