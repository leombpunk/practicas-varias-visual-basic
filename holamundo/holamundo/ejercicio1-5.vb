Module ejercicio5
    Sub main()
        'ecuacion x=((b^2)-(4*a*c))/(2*a)
        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2
        Dim x As Single = ((b ^ 2) - (4 * a * c)) / (2 * a)
        'resultado x=25-8/2
        'x=17/2
        'x=8.5
        Console.WriteLine("Resultado de la ecuacion: " & x)
        Console.ReadKey()
    End Sub
End Module
