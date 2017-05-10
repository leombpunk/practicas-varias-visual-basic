Module ejercicio3_7
    '    Crear una función sobrecargada capaz de operar dos, tres y cuatro valores de acuerdo a un
    'argumento que debe ser una enumeración para las siguientes operaciones: suma, resta,
    'multiplicación y división. También debe haber una versión de la función que no reciba la
    'enumeración y como operación predeterminada resuelva con una suma. Invocarla desde el
    'módulo main probando las diferentes alternativas y mostrando los resultados por consola. Ej.:
    'calcular(operaciones.suma, 5, 8). Minimizar la repetición de código.
    Enum operaciones
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub main()
        Console.WriteLine("Suma(sin enum): " & operacion(3, 9))
        Console.WriteLine("Suma: " & Operacion(operaciones.suma, 5, 15))
        Console.WriteLine("Multiplicacion: " & Operacion(operaciones.multiplicacion, 5, 6))
        Console.WriteLine("Division: " & Operacion(operaciones.division, 20, 5))
        Console.ReadKey()
    End Sub
    Private Function operacion(valor1 As Single, valor2 As Single) As Single
        Return valor1 + valor2
    End Function
    Private Function Operacion(operando As operaciones, valor1 As Single, valor2 As Single) As Single
        Return calculoelCalculo(operando, valor1, valor2, Nothing, Nothing)
    End Function
    Private Function Operacion(operando As operaciones, valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return calculoelCalculo(operando, valor1, valor2, valor3, Nothing)
    End Function
    Private Function Operacion(operando As operaciones, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Return calculoelCalculo(operando, valor1, valor2, valor3, valor4)
    End Function

    Private Function calculoelCalculo(signo As operaciones, valor1 As Single, valor2 As Single, valor3 As Single, valor4 As Single) As Single
        Select Case signo
            Case operaciones.suma
                Return valor1 + valor2 + valor3 + valor4
            Case operaciones.resta
                Return (((valor1 - valor2) - valor3) - valor4)
            Case operaciones.multiplicacion
                If valor3 = 0 And valor4 = 0 Then
                    Return valor1 * valor2
                ElseIf valor4 = 0 Then
                    Return ((valor1 * valor2) * valor3)
                Else
                    Return (((valor1 * valor2) * valor3) * valor4)
                End If
            Case operaciones.division
                If valor3 = 0 And valor4 = 0 Then
                    Return valor1 / valor2
                ElseIf valor4 = 0 Then
                    Return ((valor1 / valor2) / valor3)
                Else
                    Return (((valor1 / valor2) / valor3) / valor4)
                End If
            Case Else
                Return 0
        End Select
    End Function
End Module
