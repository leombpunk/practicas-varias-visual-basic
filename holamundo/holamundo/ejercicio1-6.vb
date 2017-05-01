Module ejercicio6
    Sub main()
        Dim a, b, c, d, suma, lamedia As Integer
        Console.Write("Ingrese valor para A: ")
        a = Console.ReadLine()
        Console.Write("Ingrese valor para B: ")
        b = Console.ReadLine()
        Console.Write("Ingrese valor para C: ")
        c = Console.ReadLine()
        Console.Write("Ingrese valor para D: ")
        d = Console.ReadLine()
        suma = a + b + c + d
        lamedia = suma / 4
        Console.WriteLine("la suma total es: " & suma)
        Console.WriteLine("la media es: " & lamedia)
        Console.ReadKey()
    End Sub
End Module
