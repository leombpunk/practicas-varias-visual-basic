Module ejercicio1_12
    '    Ingresar un número real por teclado y mostrar su valor aproximado por exceso, su valor
    'aproximado por defecto y su valor redondeado
    Sub main()
        Dim num_real As Single
        Console.Write("ingresar un numero real: ")
        num_real = Console.ReadLine()
        Console.WriteLine("redondeo: " & Math.Round(num_real))
        Console.WriteLine("valor aporx por defecto: " & Math.Round(num_real, 1))
        Console.WriteLine("valor aprox por exceso: " & Math.Floor(num_real))
        Console.ReadKey()
    End Sub
End Module
