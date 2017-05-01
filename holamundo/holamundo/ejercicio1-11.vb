Module ejercicio1_11
    Sub main()
        Dim num_random As Short
        Dim num_random1 As UShort
        Dim poten As UInteger
        Dim rcuadra As Single
        Console.Write("ingrese un numero: ")
        num_random = Console.ReadLine()
        num_random1 = Math.Abs(num_random)
        rcuadra = Math.Sqrt(num_random1)
        poten = Math.Pow(num_random1, 10)
        Console.WriteLine("el valor absoludo de " & num_random & " es " & num_random1)
        Console.WriteLine("la raiz cuadrada es: " & rcuadra)
        Console.WriteLine("la decima potencia es: " & poten)
        Console.ReadKey()
    End Sub
End Module
