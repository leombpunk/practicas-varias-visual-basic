Module ejercicio2_11
    '    Utilizando la estructura de repetición más adecuada elaborar un programa que se ingresen
    'valores enteros hasta que se ingrese cero (descartar negativos). Luego informar cuantos son
    'pares y cuantos impares. Si todos son pares o todos son impares informar esta situación
    'particular en lugar de la consigna anterior
    Sub main()
        Dim par, impar, num As Integer
        Console.Write("ingrese un numero para la wea: ")
        Do
            num = Console.ReadLine()
            If num >= 1 Then
                If Math.Pow(-1, num) = 1 Then 'dice que es par
                    par += 1
                ElseIf Math.Pow(-1, num) = -1 Then 'dice que es impar
                    impar += 1
                End If
            End If
            If num <> 0 Then
                Console.Write("another one: ")
            End If
        Loop Until num = 0
        If par > 0 And impar = 0 Then
            Console.WriteLine("todos los cosos son pares")
        ElseIf impar > 0 And par = 0 Then
            Console.WriteLine("todos los cosos son impares")
        Else
            Console.WriteLine("Cantidad de pares: " & par & vbCrLf & "Cantidad de impares: " & impar)
        End If
        Console.ReadKey()
    End Sub
End Module
