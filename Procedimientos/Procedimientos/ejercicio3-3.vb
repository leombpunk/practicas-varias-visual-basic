Module ejercicio3_3
    '    Mostrar las 5 primeras potencias de un valor numérico ingresado por teclado del mismo.
    'Implementar una función que retornará una potencia cada vez que se invoque, la primera vez el
    'exponente será 2, la segunda vez 3 y así sucesivamente
    Sub main()
        Dim num1 As Integer
        Console.Write("Ingrese un numero: ")
        num1 = Console.ReadLine()
        For x = 2 To 6 Step 1
            Console.WriteLine("Potencia de {0}^{1}: " & five_Pow(num1, x), num1, x)
        Next
        Console.ReadKey()
    End Sub
    Private Function five_Pow(valor1 As Integer, valor2 As Integer) As Integer
        Return Math.Pow(valor1, valor2)
    End Function
End Module
