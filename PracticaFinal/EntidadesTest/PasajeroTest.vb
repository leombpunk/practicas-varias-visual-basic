Imports Entidades
Module PasajeroTest
    Sub Main()
        Dim pa1 As New Pasajero(12345678, "rotin")
        Console.WriteLine("test de pasajero")
        Console.WriteLine("dni: " & pa1.Dni)
        Console.WriteLine("nombre: " & pa1.Nombre)
        Console.WriteLine("toString: " & pa1.ToString())
        Console.ReadKey()
    End Sub
End Module
