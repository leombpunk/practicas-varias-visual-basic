Module ejercicio2_12
    '    Utilizando la estructura de repetición más adecuada elaborar Los números de Fibonacci
    'constituyen una secuencia que empieza con 0 y 1; el número que sigue a éstos se calcula
    'sumando los dos anteriores y así sucesivamente. Utilizando la estructura de repetición más
    'adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia
    Sub main()
        Dim inic As UInteger = 0
        Dim ennd As UInteger = 1
        Dim wea As UInteger
        For x As UInteger = 0 To 20
            wea = inic + ennd
            Console.WriteLine(inic & "+" & ennd & "=" & wea)
            inic = ennd
            ennd = wea
        Next
        Console.ReadKey()
    End Sub
End Module
