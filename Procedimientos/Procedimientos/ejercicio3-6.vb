Module ejercicio3_6
    '    Elaborar un algoritmo que lea un número N, que imprima la sumatoria de los cuadrados de los
    'enteros entre 1 y N. Utilizar un método para el cálculo de la sumatoria vía parámetro por
    'referencia. Utilizar un método para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato
    Private num_N As Single
    Sub main()
        ingreso()
        Dim auxi As Integer = num_N
        For i = 1 To auxi
            Console.WriteLine("{0}^2 = {1}  y la sumatoria es de: {2}", i, calc_al_cuadrado(num_N, i), num_N)
        Next
        'Console.WriteLine("la sumatoria de cuadrados es: " & calc_sumatoria(num_N))
        Console.ReadKey()
    End Sub
    Private Function calc_al_cuadrado(ByRef acumulado As Integer, num1 As Integer) As Integer
        'Dim auxi As Integer
        'auxi = num_N
        'num_N = 0 'alta negreada¿?
        'For x = 1 To auxi Step 1
        '    valor1 += Math.Pow(x, 2)
        '    Console.WriteLine("{0}^2: " & valor1, x)
        'Next
        acumulado += (num1 ^ 2)
        Return num1 ^ 2
    End Function
    Private Sub valido_ingreso()
        'Console.WriteLine("inteado {1} sin interar {0}", num_N, Int(num_N)) 'comprobando campos a lo grone
        Do While num_N < 1 Xor Int(num_N) <> num_N
            ingreso()
        Loop
    End Sub
    Private Sub ingreso()
        Console.Write("Ingrese un numero: ")
        num_N = Console.ReadLine()
        valido_ingreso()
    End Sub
End Module
