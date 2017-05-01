Module ejercicio3_2
    '    Crear una función que reciba una fecha y un entero que representa una cantidad de días a sumar
    'a la fecha. Desde el módulo principal ingresar una fecha y la cantidad de días e invocar a esta
    'función pasándole los parámetros: fecha actual y días, mostrar el valor obtenido.
    Sub main()
        Dim dias_a As UShort
        Dim fecha_s As Date
        Console.Write("Ingresar una fecha(dd/mm/aaaa): ")
        fecha_s = Console.ReadLine()
        Console.Write("Ingresar dias: ")
        dias_a = Console.ReadLine()
        Console.WriteLine("la nueva fecha es: " & mod_Fecha(fecha_s, dias_a))
        Console.ReadKey()
    End Sub
    Private Function mod_Fecha(valor1 As Date, valor2 As UShort) As String
        valor1 = valor1.AddDays(valor2)
        Return valor1
    End Function
End Module
