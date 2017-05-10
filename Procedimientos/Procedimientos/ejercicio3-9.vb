Module ejercicio3_9
    '    Crear un programa para calcular la superficie de una figura. Los valores se ingresan por consola
    'Usar una función sobrecargada para resolver el área y según el número de parámetros será:
    ' 1 = cuadrado area=lado*lado
    ' 2 = rectángulo area=base*altura
    ' 3 = trapecio area=((Base+base)/2)*h ----> altura
    Sub main()
        Dim opc As SByte
        Dim lado, base1, base2, altura As Single
        Do
            Console.WriteLine("Opcion: 1-cuadrado 2-rectangulo 3-trapecio")
            opc = Console.ReadLine()
            Select Case opc
                Case 1
                    Console.Write("lado: ")
                    lado = Console.ReadLine()
                    Console.WriteLine("area del cuadrado: " & calcArea(lado))
                Case 2
                    Console.Write("base: ")
                    base1 = Console.ReadLine()
                    Console.Write("altura: ")
                    altura = Console.ReadLine()
                    Console.WriteLine("area del rectangulo: " & calcArea(base1, altura))
                Case 3
                    Console.Write("Base: ")
                    base1 = Console.ReadLine()
                    Console.Write("base: ")
                    base2 = Console.ReadLine()
                    Console.Write("altura: ")
                    altura = Console.ReadLine()
                    Console.WriteLine("area del trapecio: " & calcArea(base1, base2, altura))
                Case Else
                    Exit Do
            End Select
        Loop While True

    End Sub
    Private Function calcArea(valor1 As Single) As Single
        Return Math.Pow(valor1, 2)
    End Function
    Private Function calcArea(valor1 As Single, valor2 As Single) As Single
        Return valor1 * valor2
    End Function
    Private Function calcArea(valor1 As Single, valor2 As Single, valor3 As Single) As Single
        Return ((valor1 + valor2) / 2) * valor3
    End Function
End Module
