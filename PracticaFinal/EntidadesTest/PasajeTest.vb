Imports Entidades
Module PasajeTest
    Sub Main()
        Dim city1 As New Ciudad("mamerto landia")
        Dim city2 As New Ciudad("wea landia")
        Dim pasajesinho As New Pasaje("pasaje a algun lado", #2/28/2017#, 986.53, city1, city2)
        Console.WriteLine("descripcion: " & pasajesinho.Descripcion)
        Console.WriteLine("fecha: " & pasajesinho.Fecha)
        Console.WriteLine("valor costo: " & pasajesinho.costo())
        Console.WriteLine("origen: " & pasajesinho.Origen.Nombre)
        Console.WriteLine("destino: " & pasajesinho.Destino.Nombre)
        Console.ReadKey()
    End Sub
End Module
