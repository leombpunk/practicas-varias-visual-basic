Public Class ValorInvalidoTipoStringException
    Inherits Exception
    Public Sub New()
        MyBase.New("Valor inválido")
    End Sub
    Public Sub New(ByVal Mensaje As String)
        MyBase.New(Mensaje)
    End Sub
    Public Sub New(ByVal Mensaje As String, ByVal Clave As String, ByVal Valor As String)
        MyBase.New(Mensaje)
        Data.Add(Clave, Valor)
    End Sub
    Public Sub New(ByVal Mensaje As String, ByVal Clave1 As String, ByVal Valor1 As String, ByVal Clave2 As String, ByVal Valor2 As String)
        MyBase.New(Mensaje)
        Data.Add(Clave1, Valor1)
        Data.Add(Clave2, Valor2)
    End Sub
End Class
