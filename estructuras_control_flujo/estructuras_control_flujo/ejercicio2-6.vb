Module ejercicio2_6
    '    CASE: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descu de 5%, si es entre 51 y 250 el
    'descu es del 10% y si es 251 o más el descu es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descu aplicado, monto descontado y el total (subtotal –
    'monto descontado)
    Sub main()
        Dim cantpe As UShort
        Dim peunit As UShort
        Dim descu, subttl As UInteger
        Console.Write("ingrese cantidad: ")
        cantpe = Console.ReadLine()
        Console.Write("precio unitario: ")
        peunit = Console.ReadLine()
        Select Case cantpe
            Case 10 To 50
                descu = peunit * 0.05
                Console.WriteLine("descu del 5% aplicado")
            Case 51 To 250
                descu = peunit * 0.1
                Console.WriteLine("descu del 10% aplicado")
            Case < 251
                descu = peunit * 0.2
                Console.WriteLine("descu del 20% aplicado")
        End Select
        subttl = cantpe * peunit
        Console.WriteLine("subtotal: " & subttl & "$")
        Console.WriteLine("descuento: " & descu & "$")
        Console.WriteLine("total: " & subttl - descu & "$")
        Console.ReadKey()
    End Sub
End Module
