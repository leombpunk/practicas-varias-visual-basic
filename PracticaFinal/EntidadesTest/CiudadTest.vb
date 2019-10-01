Imports Entidades
Module CiudadTest
    Sub Main()
        Dim city1 As New Ciudad("mamerto landia")
        Console.WriteLine("nombre: " & city1.Nombre)
        Console.WriteLine("toString: " & city1.ToString())
        Console.ReadKey()
    End Sub
End Module
