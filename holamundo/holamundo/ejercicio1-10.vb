Module ejercicio10
    Sub main()
        Dim monto As Single
        Dim interes As Single
        Dim tiempo As Integer
        Dim i_formula As Single
        Console.Write("ingrese un monto: ")
        monto = Console.ReadLine()
        Console.Write("ingrese un interes: ")
        interes = Console.ReadLine()
        Console.Write("ingrese tiempo(dias): ")
        tiempo = Console.ReadLine()
        i_formula = (monto * interes * tiempo) / (360 * 100)
        Console.WriteLine("el interes sera de: " & i_formula)
        Console.ReadKey()
    End Sub
End Module
