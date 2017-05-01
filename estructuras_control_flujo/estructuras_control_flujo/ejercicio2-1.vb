Module ejercicio2_1
    '    If: Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
    'la relación entre ambos: mayor, menor o igual
    Sub Main()
        Dim a As UShort
        Dim b As UShort
        Console.Write("ingrese un numero: ")
        a = Console.ReadLine()
        Console.Write("ingrese otro numero: ")
        b = Console.ReadLine()
        If a > b Then
            Console.WriteLine(a & " es mayor que " & b)
        ElseIf a < b Then
            Console.WriteLine(a & " es menor que " & b)
        Else
            Console.WriteLine("son iguales")
        End If
        Console.ReadKey()
    End Sub

End Module
