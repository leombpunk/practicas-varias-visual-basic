Module ejercicio2_13
    '    Obtener los números primos menores a mil. En matemáticas, un número primo es un
    'número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.
    Sub main()
        Dim c As Integer = 0
        Console.WriteLine("Numeros primos:")
        For x As UShort = 2 To 1000
            'Console.WriteLine("x: " & x)
            For y As Byte = 1 To x
                If (x Mod y = 0) Then 'And (x Mod 1 = 0) Then
                    c += 1
                    'Console.WriteLine("mod: " & x Mod y)
                End If
            Next
            If c = 2 Then
                Console.WriteLine("wea: " & x)
                Console.ReadKey()
            End If
            c = 0
        Next
        Console.ReadKey()
    End Sub
End Module
