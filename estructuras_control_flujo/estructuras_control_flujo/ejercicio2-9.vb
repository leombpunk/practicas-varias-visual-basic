Module ejercicio2_9
    '    Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros,
    'centímetros, yardas, pies y pulgadas:
    ' Presentar un menú y preguntar que unidad de medida desea convertir, el valor a convertir y
    'después mostrar las equivalencias.
    ' Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
    'pulgada = 2.54 cm, 1 metro = 100 cm.
    ' Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
    'imprimir la equivalencia en centímetros, pies, yardas y pulgadas. 
    Sub main()
        Dim opc As Byte
        Console.WriteLine("MENU")
        Console.WriteLine("Ingrese un valor en; ")
        Console.WriteLine("OPCIONES: " & vbCrLf & "1-centimetros" & vbCrLf & "2-pies" & vbCrLf & "3-yardas" & vbCrLf & "4-pulgadas" & vbCrLf & "5-metros")
        opc = Console.ReadLine()
        Dim cm, mts, yrd, pulg, pie As Single
        Console.WriteLine("valor: ")
        Dim evaluar As Single = Console.ReadLine()
        Select Case opc
            Case 1 'centimetros
                mts = evaluar / 100
                pulg = evaluar / 2.54
                pie = pulg / 12
                yrd = pie / 3
                Console.WriteLine(mts & " metros")
                Console.WriteLine(pulg & " pulgadas")
                Console.WriteLine(pie & " pies")
                Console.WriteLine(yrd & " yardas")
            Case 2 'pies
                pulg = evaluar * 12
                yrd = evaluar / 3
                cm = pulg * 2.54
                mts = cm / 100
                Console.WriteLine(pulg & " pulgadas")
                Console.WriteLine(yrd & " yardas")
                Console.WriteLine(cm & " centimetros")
                Console.WriteLine(mts & " metros")
            Case 3 'yardas
                pie = evaluar * 3
                pulg = pie * 12
                cm = pulg * 2.54
                mts = cm / 100
                Console.WriteLine(pie & " pies")
                Console.WriteLine(pulg & " pulgadas")
                Console.WriteLine(cm & " centimetros")
                Console.WriteLine(mts & " metros")
            Case 4 'pulgadas
                cm = evaluar * 2.54
                mts = cm / 100
                pie = evaluar / 12
                yrd = evaluar / 3
                Console.WriteLine(cm & " centimetros")
                Console.WriteLine(mts & " metros")
                Console.WriteLine(pie & " pies")
                Console.WriteLine(yrd & " yardas")
            Case 5 'metros
                cm = evaluar * 100
                pulg = cm / 2.54
                pie = pulg / 12
                yrd = pie / 3
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
                Console.WriteLine()
            Case Else
                Console.WriteLine("la MANQUEASTE como un campeon")
        End Select
        Console.ReadKey()
    End Sub
End Module
