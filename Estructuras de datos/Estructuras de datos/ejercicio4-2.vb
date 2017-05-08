Module ejercicio4_2
    '    Se tiene tres arrays cargados programáticamente con una lista de productos: el primero tiene el
    'código, el segundo el nombre y el tercero el precio unitario. Repetitivamente se ingresa un
    'código de producto y el programa muestra su descripción y precio, luego el usuario ingresa la
    'cantidad. Esto sucede hasta que el código sea cero.
    Sub main()
        Dim codigo As Short
        Dim codigo_producto() As Integer = {1, 2, 3, 4, 5}
        Dim nombre_producto() As String = {"papa", "chicle", "manteca", "pan", "preguntar"}
        Dim precio_producto() As Single = {25.1, 10.3, 45, 60, 5.5}
        Do
            Console.Write("Ingrese un codigo de producto: ")
            codigo = Console.ReadLine()
            If codigo = 0 Then
                Console.WriteLine("Sali por cero")
                Exit Do
            ElseIf codigo < 1 Or codigo > 5 Then
                Console.WriteLine("El producto no existe.")
            End If
            Console.WriteLine("Descripcion: " & nombre_producto(codigo - 1) & vbCrLf & "Precio unitario: " & precio_producto(codigo - 1) & "$")
        Loop Until codigo = 0
        Console.ReadKey()
    End Sub
End Module
