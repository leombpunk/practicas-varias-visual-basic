Public Class Equipaje
    Implements Bulto
    Private _deMano As Boolean
    Private _kilos As Single
    Public Sub New()
        _kilos = 0
        _deMano = False
    End Sub
    Public Property Kilos As Single Implements Bulto.Kilos
        Get
            Return _kilos
        End Get
        Set(value As Single)
            If value >= 0 And value <= 25 Then
                _kilos = value
            End If
        End Set
    End Property
    Public Property deMano As Boolean
        Get
            Return _deMano
        End Get
        Set(value As Boolean)
            _deMano = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        If deMano Then
            Return "(" & Kilos & "kilos - De mano)"
        Else
            Return "(" & Kilos & "kilos)"
        End If
    End Function
End Class
