Public Class Encomienda
    Implements Bulto
    Private _cliente As Cliente
    Private _kilos As Single
    Public Sub New(cliente As Cliente, kilos As Single)
        Me.Kilos = kilos
        Me.Cliente = cliente
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
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Kilos & "k."
    End Function
End Class
