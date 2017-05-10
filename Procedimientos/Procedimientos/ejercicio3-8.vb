Module ejercicio3_8
    '    En base al ejercicio anterior (copy+paste): agregar una subrutina sobrecargada para mostrar por
    'consola las operaciones realizadas. Esta subrutina se invoca desde el método main y ella invoca
    'las funciones de cálculo. Ej.: resultado(operaciones.suma, 5, 8) imprimiría en
    'consola 5 + 8 = 13.
    Enum operaciones
        suma
        resta
        multiplicacion
        division
    End Enum
    Sub main()
        'Console.WriteLine("Suma(sin enum): " & operacion(3, 9))
        'Console.WriteLine("Suma: " & Operacion(operaciones.suma, 5, 15))
        'Console.WriteLine("Multiplicacion: " & Operacion(operaciones.multiplicacion, 5, 6))
        'Console.WriteLine("Division: " & Operacion(operaciones.division, 20, 5))
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