Module ejercicio3_6
    '    Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
    'enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
    'referencia. Utilizar un método para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato
    Private num_N As Integer
    Sub main()
        'Dim num_N As Integer
        'Console.Write("ingrese un numero: ")
        'num_N = Console.ReadLine()
        ingreso()
        'Console.WriteLine("paso la wea")
        Console.WriteLine("la sumatoria de cuadrados es: " & calc_sumatoria(num_N))
        Console.ReadKey()
    End Sub
    Private Function calc_sumatoria(ByRef valor1 As Integer) As Integer
        Dim auxi As Integer
        auxi = num_N
        num_N = 0 'alta negreada¿?
        For x = 1 To auxi Step 1
            valor1 += Math.Pow(x, 2)
            Console.WriteLine("{0}^2: " & valor1, x)
        Next
        Return valor1
    End Function
    Private Sub valido_ingreso()
        Do While num_N < 1
            ingreso()
        Loop
    End Sub
    Private Sub ingreso()
        'Dim num_N As Integer
        Console.Write("ingrese un numero: ")
        num_N = Console.ReadLine()
        valido_ingreso()
    End Sub
End Module
