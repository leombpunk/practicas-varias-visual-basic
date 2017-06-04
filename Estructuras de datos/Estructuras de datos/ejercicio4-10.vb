Module ejercicio4_10
    '    Crear un algoritmo que tenga una colección de stack de manera tal que pueda ser
    'accedida en todo el módulo. Con un menú permite efectuar 2 acciones: ingresar nombres a la
    'colección desde teclado y la segunda permita extraerlo y mostrarlo en la pantalla. El programa
    'debe finalizar cuando se quitan todos los elementos de la colección.
    Enum opc As SByte
        ingreso = 1
        egreso = 2
    End Enum
    Private pila_sin_nombre As New Stack
    Sub main()
        Console.WriteLine("Tenga en cuenta que la pila ahora esta vacia")
        Do
            'Console.Clear()
            Dim opcion As SByte
            Console.WriteLine("Opcion 1-Agregar nombre" & vbCrLf & "Opcion 2-Extraer nombre: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case opc.ingreso
                    Console.Write("Nombre: ")
                    Dim name As String = Console.ReadLine()
                    agrego_ala_pila(pila_sin_nombre, name)
                Case opc.egreso
                    quito_dela_pila(pila_sin_nombre)
            End Select
        Loop While pila_sin_nombre.Count > 0
        Console.ReadKey()
    End Sub
    Private Sub agrego_ala_pila(ByRef pila As Stack, item As String)
        pila.Push(item)
    End Sub
    Private Sub quito_dela_pila(ByRef pila As Stack)
        If pila.Count > 0 Then
            Dim saco_ele As String = pila.Pop
            Console.WriteLine("Se extrajo de la pila: {0}", saco_ele)
        Else
            Console.WriteLine("No se puede realizar, adios.")
        End If
    End Sub
End Module
