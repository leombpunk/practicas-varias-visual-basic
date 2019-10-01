Public Class mayor1000Exception
    Inherits Exception
    Private _valor As Int16
    Public Sub New()
        _valor = 1000
    End Sub
    Public Sub New(numero As Int16)
        Me.Valor = numero

    End Sub
    Private WriteOnly Property Valor As Int16
        Set(value As Int16)
            Try
                _valor = value
            Catch ex As InvalidCastException
                'algun codigo
            Catch ee As OverflowException
                'algun codigo
            Finally
                _valor = Nothing
            End Try
        End Set
    End Property
End Class
