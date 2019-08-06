Imports Entidades
Module PasajeroTest
    Sub Main()
        Dim pasajero1 As New Pasajero(12654987, "Rusty")

        Dim equipaje1 As New Equipaje
        equipaje1.Kilos = 2.5
        equipaje1.deMano = True
        Console.WriteLine("test equipaje")
        Console.WriteLine("kilos: " & equipaje1.Kilos)
        Console.WriteLine("Es de Mano: " & equipaje1.deMano)
        Console.WriteLine("toString: " & equipaje1.ToString())

        Dim equipaje2 As New Equipaje
        equipaje2.Kilos = 5
        equipaje2.deMano = False

        Dim equipaje3 As New Equipaje
        equipaje3.Kilos = 2.8
        equipaje3.deMano = True

        Dim equipaje4 As New Equipaje
        equipaje4.Kilos = 50
        equipaje4.deMano = False

        Console.WriteLine("dni: " & pasajero1.Dni)
        Console.WriteLine("nombre: " & pasajero1.Nombre)
        Console.WriteLine("tostring: " & pasajero1.ToString())
        pasajero1.addEquipaje(equipaje1)
        pasajero1.addEquipaje(equipaje2)
        pasajero1.addEquipaje(equipaje3)
        pasajero1.addEquipaje(equipaje4)
        Console.WriteLine("for each 1 getallequipajes")
        For Each Equipaje As Equipaje In pasajero1.getAllEquipajes()
            Console.WriteLine(Equipaje.ToString())
        Next
        Console.WriteLine("total kilos: " & pasajero1.getTotalKilosEquipaje())
        Console.WriteLine("elimino el 2do equipaje")
        pasajero1.removeEquipaje(equipaje2)
        Console.WriteLine("total kilos: " & pasajero1.getTotalKilosEquipaje())
        Console.WriteLine("for each 2 getallequipajes")
        For Each Equipaje As Equipaje In pasajero1.getAllEquipajes()
            Console.WriteLine(Equipaje.ToString())
        Next
        Console.WriteLine("total kilos: " & pasajero1.getTotalKilosEquipaje())
        Console.WriteLine("agrego equipaje4")
        pasajero1.addEquipaje(equipaje4)
        Console.WriteLine("total kilos: " & pasajero1.getTotalKilosEquipaje())
        Console.WriteLine("for each 3 getallequipajes")
        For Each Equipaje As Equipaje In pasajero1.getAllEquipajes()
            Console.WriteLine(Equipaje.ToString())
        Next
        Console.WriteLine("total kilos: " & pasajero1.getTotalKilosEquipaje())
        Console.ReadKey()
    End Sub
End Module
