Module aritmetica
    Sub main()
        Dim a As Short = 34
        Dim b As Short = 458
        Dim c As Single = 15.9
        Dim d As Single = 109.9999
        'suma
        Console.WriteLine("entero+entero :" & a + b)
        Console.WriteLine("entero+flotante: " & b + d)
        Console.WriteLine("flotante+flotante: " & c + d)
        'resta
        Console.WriteLine("entero-entero :" & a - b)
        Console.WriteLine("entero-flotante: " & b - d)
        Console.WriteLine("flotante-flotante: " & c - d)
        'multiplicacin
        Console.WriteLine("entero*entero :" & a * b)
        Console.WriteLine("entero*flotante: " & b * d)
        Console.WriteLine("flotante*flotante: " & c * d)
        'division
        Console.WriteLine("entero/entero :" & a / b)
        Console.WriteLine("entero/flotante: " & b / d)
        Console.WriteLine("flotante/flotante: " & c / d)
        Console.ReadKey()
    End Sub
End Module
