Module ejercicio4_12
    'En los ejercicios anteriores con queue y stack establecer el género de las listas.
    Sub main()
        '*****STACK*****
        '    Enum opc As SByte
        '    ingreso = 1
        '    egreso = 2
        'End Enum
        'Private pila_sin_nombre As New Stack(Of String)
        'Sub main()
        '    Console.WriteLine("Tenga en cuenta que la pila ahora esta vacia")
        '    Do
        '        'Console.Clear()
        '        Dim opcion As SByte
        '        Console.WriteLine("Opcion 1-Agregar nombre" & vbCrLf & "Opcion 2-Extraer nombre: ")
        '        opcion = Console.ReadLine()
        '        Select Case opcion
        '            Case opc.ingreso
        '                Console.Write("Nombre: ")
        '                Dim name As String = Console.ReadLine()
        '                agrego_ala_pila(pila_sin_nombre, name)
        '            Case opc.egreso
        '                quito_dela_pila(pila_sin_nombre)
        '        End Select
        '    Loop While pila_sin_nombre.Count > 0
        '    Console.ReadKey()
        'End Sub
        'Private Sub agrego_ala_pila(ByRef pila As Stack(Of String), item As String)
        '    pila.Push(item)
        'End Sub
        'Private Sub quito_dela_pila(ByRef pila As Stack(Of String))
        '    If pila.Count > 0 Then
        '        Dim saco_ele As String = pila.Pop
        '        Console.WriteLine("Se extrajo de la pila: {0}", saco_ele)
        '    Else
        '        Console.WriteLine("No se puede realizar, adios.")
        '    End If
        'End Sub


        '*****QUEUE*****
        'Enum accion As SByte
        '    entrada = 1
        '    salida = 2
        'End Enum
        'Sub main()
        '    Dim turnos As New Queue(Of String)
        '    Dim opc As SByte
        '    Do
        '        Console.Clear()
        '        muestro2sgtes(turnos)
        '        Console.Write("Accion" & vbCrLf & "0.Salir  1.Dar Turno   2.Llamar siguiente: ")
        '        opc = Console.ReadLine()
        '        Select Case opc
        '            Case accion.entrada
        '                doy_turnos(turnos)
        '            Case accion.salida
        '                llamo_siguiente(turnos)
        '            Case Else
        '                Exit Do
        '        End Select
        '        Console.ReadKey()
        '    Loop While True
        '    Console.ReadKey()
        'End Sub
        'Private Sub doy_turnos(ByRef turno As Queue(Of String))
        '    Dim nombre As String
        '    Console.Write("Nombre: ")
        '    nombre = Console.ReadLine()
        '    turno.Enqueue(nombre)
        'End Sub
        'Private Sub llamo_siguiente(ByRef lista As Queue(Of String))
        '    If verif_vacio(lista) Then
        '        Dim cliente As String = lista.Dequeue()
        '        Console.WriteLine("Siguiente! {0}", cliente)
        '    Else
        '        Console.WriteLine("No se puede realizar la accion")
        '    End If
        'End Sub
        'Private Sub cliente_en_espera(ByRef cola As Queue(Of String))
        '    Console.WriteLine("En espera {0} clientes", cola.Count)
        'End Sub
        'Private Function verif_vacio(ByRef cola As Queue) As Boolean
        '    Return If(cola.Count > 0, True, False)
        'End Function
        'Private Sub muestro2sgtes(ByRef cola As Queue(Of String))
        '    cliente_en_espera(cola)
        '    Dim acu As Byte = 0
        '    If cola.Count > 0 Then
        '        Console.WriteLine("Los siguientes seran: ")
        '        For Each elem In cola
        '            Console.WriteLine(elem)
        '            acu += 1
        '            If acu = 2 Then
        '                Exit For
        '            End If
        '        Next
        '    Else
        '        Console.WriteLine("Sin clientes en espera")
        '    End If
        'End Sub
    End Sub
End Module
