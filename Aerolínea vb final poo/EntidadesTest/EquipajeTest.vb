Imports Entidades
Module EquipajeTest
    Sub Main()
        Dim equipaje1 As New Equipaje
        equipaje1.Kilos = 2.5
        equipaje1.deMano = True
        Console.WriteLine("test equipaje")
        Console.WriteLine("kilos: " & equipaje1.Kilos)
        Console.WriteLine("Es de Mano: " & equipaje1.deMano)
        Console.WriteLine("toString: " & equipaje1.ToString())
        Console.ReadKey()
    End Sub
End Module
