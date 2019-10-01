Imports Entidades
Module VentaTest
    Sub Main()
        Dim pasa1 As New Pasajero(6549875, "el pasajero pe")
        Dim vent1 As New Venta()
        Dim clie1 As New Cliente(pasa1, "2-65456897-12")
        vent1.Fecha = #12/12/2017#
        vent1.Cliente = clie1
        Console.WriteLine("fecha venta: " & vent1.Fecha)
        Console.WriteLine("cliente atributos:")
        Console.WriteLine("nombre: {0}, dni: {1}, cuil: {2}", vent1.Cliente.Nombre, vent1.Cliente.Dni, vent1.Cliente.Cuit_Cuil)
        For Each pe As Venta In vent1.Cliente.getAllVentas
            Console.WriteLine(pe)
        Next
        Console.WriteLine("toString: " & vent1.ToString())
        Console.ReadKey()
    End Sub
End Module
