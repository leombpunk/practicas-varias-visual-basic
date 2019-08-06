Public Class Espacioso
    Inherits Asiento
    Private Shared _maximoKilosEquipajeLibre As Single
    Public Sub New(fila As Byte, columna As Char)
        MyBase.New(fila, columna)
        '_maximoKilosEquipajeLibre = 0
    End Sub
    Public Shared Property maximoKilosEquipajeLibre As Single
        Get
            Return _maximoKilosEquipajeLibre
        End Get
        Set(value As Single)
            If value > 0 And value <= 30 Then
                _maximoKilosEquipajeLibre = value
            End If
        End Set
    End Property

End Class
