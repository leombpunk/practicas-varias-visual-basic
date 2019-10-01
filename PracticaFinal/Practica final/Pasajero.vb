Public Class Pasajero
    Private _dni As UInt32
    Private _nombre As String
    Public Sub New(dni As UInt32, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
    End Sub
    Public Property Dni As UInt32
        Get
            Return _dni
        End Get
        Set(value As UInt32)
            _dni = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre & "(" & Dni & ")"
    End Function
End Class
