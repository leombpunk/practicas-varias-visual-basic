Imports Entidades
Module HotelTest
    Sub Main()
        Dim city1 As New Ciudad("mamerto landia")
        Dim hotel1 As New Hotel("hotel feo 20 stars", #12/03/2017#, city1, 10, 3000)
        hotel1.Habitaciones = 3
        Console.WriteLine("descripcion: " & hotel1.Descripcion)
        Console.WriteLine("fecha: " & hotel1.Fecha)
        Console.WriteLine("ciudad: " & hotel1.Ciudad.Nombre)
        Console.WriteLine("noches: " & hotel1.Noches)
        Console.WriteLine("monto diario: " & hotel1.MontoDiaria)
        Console.WriteLine("habitaciones: " & hotel1.Habitaciones)
        Console.WriteLine("costo: " & hotel1.costo() & "$ -PD: me duelen los bolsillos")
        Console.ReadKey()
    End Sub
End Module
