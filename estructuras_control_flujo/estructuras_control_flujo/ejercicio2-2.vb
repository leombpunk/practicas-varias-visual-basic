Module ejercicio2_2
    'IF: ingresar tres valores y mostrar el menor
    Sub main()
        Dim a, b, c, menor As Integer
        Console.Write("a: ")
        a = Console.ReadLine()
        Console.Write("b: ")
        b = Console.ReadLine()
        Console.Write("c: ")
        c = Console.ReadLine()
        If a < b Then
            menor = a
        Else
            menor = b
        End If
        If menor < c Then
            menor = menor 'lel
        Else
            menor = c
        End If
        Console.WriteLine("la wea menor es: " & menor)
        Console.ReadKey()

    End Sub
End Module
