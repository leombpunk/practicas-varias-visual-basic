Module ejercicio2_4
    '    If: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado)
    Sub main()
        Dim cantidadp As UShort
        Dim punitario As UInteger
        Dim descuento, subtotal As UInteger
        Console.Write("cantidad del producto: ")
        cantidadp = Console.ReadLine()
        Console.Write("precio unitario: ")
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
        Else
            descuento = punitario * 0.2
            Console.WriteLine("descuento del 20% aplicado")
        End If
        subtotal = cantidadp * punitario
        Console.WriteLine("subtotal: " & subtotal & "$")
        Console.WriteLine("descuento: " & descuento & "$")
        Console.WriteLine("total: " & subtotal - descuento & "$")
        Console.ReadKey()
    End Sub
End Module
