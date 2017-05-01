Module ejercicio2_14
    '    Se ingresan repetitivamente dos valores relativos a un producto en venta: cantidad y
    'precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es
    'entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. Informar por
    'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
    'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
    'cero, informar el total de pesos descontados y el total a cobrar
    Sub main()
        Dim cantidadp As UShort
        Dim punitario As UInteger
        Dim descuento, subtotal, acudes, acusubt As UInteger
        Do
            Console.Write("Cantidad del producto: ")
            cantidadp = Console.ReadLine()
            If cantidadp = 0 Then
                Exit Do
            End If
            Console.Write("Precio unitario: ")
            punitario = Console.ReadLine()
            'evalua descuento 5%
            If cantidadp >= 10 And cantidadp <= 50 Then
                descuento = punitario * 0.05
                Console.WriteLine("descuento del 5% aplicado")
                'evalua descuento 10%
            ElseIf cantidadp >= 51 And cantidadp <= 250 Then
                descuento = punitario * 0.1
                Console.WriteLine("descuento del 10% aplicado")
                'por descarte aplica descuento del 20%
            ElseIf cantidadp > 250 Then
                descuento = punitario * 0.2
                Console.WriteLine("descuento del 20% aplicado")
            Else
                Console.WriteLine("sin descuento")
            End If
            subtotal = cantidadp * punitario
            acudes += descuento
            acusubt += subtotal
            Console.WriteLine(vbCrLf & "Detalle por producto: ")
            Console.WriteLine("Subtotal: " & subtotal & "$")
            Console.WriteLine("Descuento: " & descuento & "$")
            Console.WriteLine("Total: " & subtotal - descuento & "$" & vbCrLf)
        Loop While cantidadp <> 0
        Console.WriteLine(vbCrLf & "Detalle final: ")
        Console.WriteLine("Total Descontado: " & acudes & "$")
        Console.WriteLine("Total a garpar: " & acusubt - acudes & "$")
        Console.ReadKey()
    End Sub
End Module
