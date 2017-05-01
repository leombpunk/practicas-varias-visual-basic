Module ejercicio2_8
    '    Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    ' El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    ' En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400.
    Enum meses
        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12
    End Enum
    Sub main()
        Dim dias, mes As SByte
        Dim anho As UShort
        Console.Write("numero de mes: ")
        mes = Console.ReadLine()
        Select Case mes
            Case meses.enero
                Console.WriteLine("enero tiene 31 dias")
            Case meses.febrero
                Console.Write("año: ")
                anho = Console.ReadLine()
                'evalua año bisiesto
                If (anho Mod 4 = 0 And anho Mod 100 <> 0) Or anho Mod 400 = 0 Then
                    dias = 29
                Else
                    dias = 28
                End If
                Console.WriteLine("febrero tiene " & dias & " dias")
            Case meses.marzo
                Console.WriteLine("marzo tiene 31 dias")
            Case meses.abril
                Console.WriteLine("abril tiene 30 dias")
            Case meses.mayo
                Console.WriteLine("mayo tiene 31 dias")
            Case meses.junio
                Console.WriteLine("junio tiene 30 dias")
            Case meses.julio
                Console.WriteLine("julio tiene 30 dias")
            Case meses.agosto
                Console.WriteLine("agosto tiene 31 dias")
            Case meses.septiembre
                Console.WriteLine("septiembre tiene 30 dias")
            Case meses.octubre
                Console.WriteLine("octubre tiene 31 dias")
            Case meses.noviembre
                Console.WriteLine("noviembre tiene 30 dias")
            Case meses.diciembre
                Console.WriteLine("diciembre tiene 31 dias")
            Case Else
                Console.WriteLine("no corresponde la wea")
        End Select
        Console.ReadKey()
    End Sub
End Module
