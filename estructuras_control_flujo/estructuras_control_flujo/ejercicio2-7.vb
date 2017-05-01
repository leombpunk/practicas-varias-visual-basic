Module ejercicio2_7
    '    Case: Elaborar un algoritmo que lea el tamaño de un ángulo en grados e imprimir el mensaje
    'correspondiente según la siguiente tabla:
    'Agudo si es menor a 90°
    'Recto si es igual a 90°
    'Obtuso si es mayor que 90° pero menor que 180°
    'Llano si es igual a 180°
    'Cóncavo si es mayor que 180° pero menor que 360°
    'Error Si el valor es menor a 0º o mayor de 360º
    Sub main()
        Dim angulo As Short
        Console.Write("ingrese un angulo: ")
        angulo = Console.ReadLine()
        Select Case angulo
            Case 1 To 89
                Console.WriteLine("agudo")
            Case 90
                Console.WriteLine("recto")
            Case 91 To 179
                Console.WriteLine("obtuso")
            Case 180
                Console.WriteLine("llano")
            Case 181 To 359
                Console.WriteLine("concavo")
                'Case < 0, > 360
                '    Console.WriteLine("ERROR")
            Case Else
                Console.WriteLine("ERROR")
        End Select
        Console.ReadKey()
    End Sub
End Module
