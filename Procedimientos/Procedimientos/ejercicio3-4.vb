Module ejercicio3_4
    '    Dados los lados A y B de un triángulo rectángulo, según el teorema de Pitágoras, el cuadrado de
    'la hipotenusa(C), es igual a la suma del cuadrado de los catetos (lados) de lo que se da la
    'siguiente fórmula :  c² = a² + b². Elaborar una función que reciba el tamaño de los lados A y B,
    'calcule y devuelva C (hipotenusa). Ingresar los valores por teclado y mostrar el resultado en
    'consola. Utilizar una función para validar los valores ingresados sean enteros positivos, si no
    'cumple esta condición pedir el reingreso del dato
    Sub main()
        Dim lado_a, lado_b As Single
        Console.Write("lado A: ")
        lado_a = Console.ReadLine()
        Console.Write("lado B: ")
        lado_b = Console.ReadLine()
        Console.WriteLine("C: " & Pitagoras_TR(lado_a, lado_b))
        Console.ReadKey()
    End Sub
    Private Function Pitagoras_TR(valor1 As Single, valor2 As Single) As Single
        'https://es.wikipedia.org/wiki/Teorema_de_Pit%C3%A1goras
        'Dim C As Single
        'C = Math.Sqrt(Math.Pow(valor1, 2) + Math.Pow(valor2, 2))
        'Return C
        'O tambien
        'Return Math.Sqrt(Math.Pow(valor1, 2) + Math.Pow(valor2, 2))
    End Function
End Module
