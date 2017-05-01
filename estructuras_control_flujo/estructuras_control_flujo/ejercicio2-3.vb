Module ejercicio2_3
    '    If: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”
    Sub main()
        Dim a, b, c, d, e As Integer
        Console.Write("ingrese un numero: ")
        a = Console.ReadLine()
        Console.Write("ingrese un numero: ")
        b = Console.ReadLine()
        Console.Write("ingrese un numero: ")
        c = Console.ReadLine()
        Console.Write("ingrese un numero: ")
        d = Console.ReadLine()
        Console.Write("ingrese un numero: ")
        e = Console.ReadLine()
        If a >= b And a >= c And a >= d And a >= e Then
            Console.WriteLine("el primer ingresado es el mayor")
        End If
        If b >= a And b >= c And b >= d And b >= e Then
            Console.WriteLine("el segundo ingresado es el mayor")
        End If
        If c >= a And c >= b And c >= d And c >= e Then
            Console.WriteLine("el tercer ingresado es el mayor")
        End If
        If d >= a And d >= b And d >= c And d >= e Then
            Console.WriteLine("el cuarto ingresado es el mayor")
        End If
        If e >= a And e >= b And e >= c And e >= d Then
            Console.WriteLine("el quinto ingresado es el mayor")
        End If
        Console.ReadKey()
    End Sub
End Module
