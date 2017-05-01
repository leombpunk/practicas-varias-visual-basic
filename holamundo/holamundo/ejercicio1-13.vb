Module ejercicio1_13
    'Elabore un programa que lea tres números y muestre el mayor
    Sub main()
        Dim a, b, c, maxm As Short
        Console.Write("a: ")
        a = Console.ReadLine()
        Console.Write("b: ")
        b = Console.ReadLine()
        Console.Write("c: ")
        c = Console.ReadLine()
        maxm = Math.Max(a, b)
        maxm = Math.Max(maxm, c)
        Console.WriteLine("Mayor: " & maxm)
        Console.ReadKey()
    End Sub
End Module
