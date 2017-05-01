Module ejercicio3_5
    '    El volumen de un cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el
    'cuadrado del radio de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h.
    'Elaborar una función que lea el radio de la base y la altura de un cilindro, que calcule y
    'devuelva el volumen. Ingresar los valores por teclado y mostrar el resultado en consola. Utilizar
    'un procedimiento para validar los valores ingresados sean positivos, si no cumple esta condición
    'pedir el reingreso del dato
    Const pi As Double = Math.PI
    'Const pi As Double = 3.14159265
    Sub main()
        Dim radio, altura As Single
        Console.Write("Radio de la base: ")
        radio = Console.ReadLine()
        Console.Write("Altura: ")
        altura = Console.ReadLine()
        Console.WriteLine("El volumen es: " & cal_Volumen(radio, altura))
        Console.ReadKey()
    End Sub
    Private Function cal_Volumen(valor1 As Single, valor2 As Single) As Double
        Return pi * Math.Pow(valor1, 2) * valor2
        'Dim V As Double
        'V = pi * Math.Pow(valor1, 2) * valor2
        'Return V
    End Function
End Module
