Imports Entidades
Module ClienteTest
    Sub Main()
        Dim pa1 As New Pasajero(12365478, "olor a asado")
        Dim clie1 As New Cliente(pa1, "xd654987dd")
        Dim vent1 As New Venta()
        vent1.Fecha = #06/02/2017#
        vent1.Cliente = clie1
        Dim vent2 As New Venta()
        vent2.Fecha = #05/12/2017#
        vent2.Cliente = clie1
        Dim vent3 As New Venta()
        vent3.Fecha = #10/10/2017#
        vent3.Cliente = clie1

        Console.WriteLine("nombre: " & clie1.Nombre)
        Console.WriteLine("dni: " & clie1.Dni)
        Console.WriteLine("cuit o cuil: " & clie1.Cuit_Cuil)
        Console.WriteLine("toString: " & clie1.ToString())
        Console.WriteLine("lsita de ventas")
        For Each venta As Venta In clie1.getAllVentas
            Console.WriteLine(venta.ToString)
        Next
        Console.ReadKey()
    End Sub
End Module
