Imports Entidades
Module EspaciosoTest
    Sub Main()
        Dim espacioso1 As New Espacioso(31, "a")
        Dim espacioso2 As New Espacioso(15, "C")
        Console.WriteLine("fila: " & espacioso1.Fila)
        Console.WriteLine("columna: " & espacioso1.Columna)
        Console.WriteLine("fila: " & espacioso2.Fila)
        Console.WriteLine("columna: " & espacioso2.Columna)
        Espacioso.maximoKilosEquipajeLibre = 150
        Console.WriteLine("kilo equipaje: " & Espacioso.maximoKilosEquipajeLibre)

        Espacioso.maximoKilosEquipajeLibre = 15
        Console.WriteLine("kilo equipaje: " & Espacioso.maximoKilosEquipajeLibre)
        Console.ReadKey()
    End Sub
End Module
