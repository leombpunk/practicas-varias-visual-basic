Public Class Cliente
    Private _dni As UInt32
    Private _nombre As String
    Private _encomienda As Encomienda
    Public Sub New(dni As UInt32, nombre As String)
        Me.Dni = dni
        Me.Nombre = nombre
        _encomienda = Nothing
    End Sub
    Public Property Dni As UInt32
        Get
            Return _dni
        End Get
        Set(value As UInt32)
            If value > 0 Then
                _dni = value
            End If
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length >= 3 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Encomienda As Encomienda
        Get
            Return _encomienda
        End Get
        Set(value As Encomienda)
            _encomienda = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre & "(" & Dni & ")"
    End Function
End Class
