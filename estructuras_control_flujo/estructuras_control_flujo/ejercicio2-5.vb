Module ejercicio2_5
    '    Case .Crear un programa con una enumeración para los meses del año. Ingresar un valor
    'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
    'correspondiente
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre=9
        octubre = 10
        noviembre=11
        diciembre = 12
    End Enum
    Sub main()
        Dim x As Byte
        Console.Write("ingrese un numero: ")
        x = Console.ReadLine()
        Select Case x
            Case meses.enero
                Console.WriteLine("enero")
            Case meses.febrero
                Console.WriteLine("febrero")
            Case meses.marzo
                Console.WriteLine("marzo")
            Case meses.abril
                Console.WriteLine("abril")
            Case meses.mayo
                Console.WriteLine("mayo")
            Case meses.junio
                Console.WriteLine("junio")
            Case meses.julio
                Console.WriteLine("julio")
            Case meses.agosto
                Console.WriteLine("agosto")
            Case meses.septiembre
                Console.WriteLine("septiembre")
            Case meses.octubre
                Console.WriteLine("octubre")
            Case meses.noviembre
                Console.WriteLine("noviembre")
            Case meses.diciembre
                Console.WriteLine("diciembre")
            Case Else
                Console.WriteLine("no se pibe flasheaste mal")
        End Select
        Console.ReadKey()
    End Sub
End Module
