Module ejercicio3_1
    '    Crear un módulo que imprima la fecha y hora actual con sus respectivas leyendas según las
    'siguientes condiciones : 
    ' Utilizar una sub para imprimir la fecha actual.
    ' Utilizar una function para obtener la hora actual.
    ' Llamar a los métodos desde el método Main.
    Sub Main()
        fecha_actual()
        Console.WriteLine("Hora: " & getHora())
        Console.ReadKey()
    End Sub
    Private Sub fecha_actual()
        Console.WriteLine("Fecha: " & Date.Today)
    End Sub
    Private Function getHora() As String
        Return (TimeOfDay)
    End Function
End Module
