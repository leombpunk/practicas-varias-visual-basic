Imports Entidades
Module ClienteTest
    Sub Main()
        Dim cliente1 As New Cliente(23654987, "Alipio")
        Console.WriteLine("dni: " & cliente1.Dni)
        Console.WriteLine("nombre: " & cliente1.Nombre)
        Console.WriteLine("toString: " & cliente1.ToString())
        Console.ReadKey()
    End Sub
End Module
