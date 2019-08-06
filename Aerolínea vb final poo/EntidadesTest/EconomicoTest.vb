Imports Entidades
Module EconomicoTest
    Sub Main()
        Dim economico1 As New Economico(31, "a")
        Dim economico2 As New Economico(15, "C")
        Console.WriteLine("fila: " & economico1.Fila)
        Console.WriteLine("columna: " & economico1.Columna)
        Console.WriteLine("fila: " & economico2.Fila)
        Console.WriteLine("columna: " & economico2.Columna)
        Economico.maximoKilosEquipajeLibre = 150
        Console.WriteLine("kilo equipaje: " & Economico.maximoKilosEquipajeLibre)

        Economico.maximoKilosEquipajeLibre = 15
        Console.WriteLine("kilo equipaje: " & Economico.maximoKilosEquipajeLibre)
        Console.ReadKey()
    End Sub
End Module
