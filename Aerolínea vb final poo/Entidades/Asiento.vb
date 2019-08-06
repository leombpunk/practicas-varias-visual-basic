Public MustInherit Class Asiento
    Private _fila As Byte
    Private _columna As Char
    Private _pasajero As Pasajero
    Public Sub New(fila As Byte, columna As Char)
        Me.Fila = fila
        Me.Columna = columna
    End Sub
    Public Property Pasajero As Pasajero
        Get
            Return _pasajero
        End Get
        Friend Set(value As Pasajero)
            _pasajero = value
        End Set
    End Property
    Public Property Fila As Byte
        Get
            Return _fila
        End Get
        Set(value As Byte)
            If value >= 1 And value <= 30 Then
                _fila = value
            End If
        End Set
    End Property
    Public Property Columna As Char
        Get
            Return _columna
        End Get
        Set(value As Char)
            If Asc(value) >= 65 And Asc(value) <= 68 Then
                '      If value >= "A" And value <= "D" Then
                _columna = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return "C:" & Columna & "F:" & Fila
    End Function
End Class
