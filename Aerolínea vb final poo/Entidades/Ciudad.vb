Public Class Ciudad
    Private _nombre As String
    Private _code As String
    Public Sub New(nombre As String, code As String)
        Me.Nombre = nombre
        Me.Code = code
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length >= 3 And value.Length <= 30 Then
                _nombre = value
            Else
                Throw New ValorInvalidoTipoStringException("El nombre ingresado no cumple con el rango establecido")
            End If
        End Set
    End Property
    Public Property Code As String
        Get
            Return _code
        End Get
        Set(value As String)
            If value.Length = 3 Then
                _code = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return "Cod.: " & Code
    End Function
End Class
