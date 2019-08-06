Imports Entidades
Module EncomiendaTest
    Sub Main()
        Dim cliente1 As New Cliente(23654987, "Alipio")
        'Console.WriteLine("dni: " & cliente1.Dni)
        'Console.WriteLine("nombre: " & cliente1.Nombre)
        'Console.WriteLine("toString: " & cliente1.ToString())

        Dim encomienda1 As New Encomienda(cliente1, 25)
        Console.WriteLine("cliente nombre: " & encomienda1.Cliente.Nombre)
        Console.WriteLine("kilos: " & encomienda1.Kilos)
        Console.WriteLine("tostring: " & encomienda1.ToString())
        Console.ReadKey()
    End Sub
End Module
