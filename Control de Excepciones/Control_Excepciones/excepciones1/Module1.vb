Module Module1
    '    Crear un módulo que implemente una función llamada mayor que reciba dos valores y
    'devuelta como resultado el valor mayor. En el método main crear una estructura
    'repetitiva que itere sobre una variable pívot de 1 a 100 con paso de 10. En cada iteración
    'invocar a la función con un valor determinado por la variable pívot y el otro por un valor
    'aleatorio entre 0 y 100 (Random Class, Next method) e imprimir su resultado. Probar el
    'programa con el debugger (depurador) siguiendo la secuencia del programa, observando
    'los valores y determinando si cumple con lo esperado.
    Sub Main()
        Const cien As Int32 = 100
        Console.WriteLine("Ejemplo 1")
        For x = 1 To cien Step 10
            Dim randiom As New Random(x) 'con el propio for le paso la x como semilla
            Dim y As Int32 = randiom.Next(0, cien)
            Console.WriteLine("El mayor entre {0} y {1} es: {2}", x, y, Mayor(x, y))
        Next
        Console.ReadKey()
    End Sub
    Function Mayor(valor1 As Int32, valor2 As Int32) As Int32
        Return If(valor1 > valor2, valor1, valor2)
    End Function
End Module
