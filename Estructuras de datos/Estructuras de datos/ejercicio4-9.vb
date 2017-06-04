Module ejercicio4_9
    'Crear un programa para dar tunos a los compradores de una tienda por orden de llegada.
    ' Cuando los compradores ingresan al local dan su nombre y quedan esperando ser llamados
    'por un empleado.
    ' Un empleado llama al próximo cliente para ser atendido el programa muestra su nombre y
    'este sale de la lista
    ' Tener en cuenta que estos procesos pueden ser en cualquier orden.
    ' En todo momento informar la cantidad de clientes en espera y el nombre de los dos
    'siguientes clientes a ser atendidos. Si no hay compradores en espera informar “Sin
    'clientes”.
    Enum accion As SByte
        entrada = 1
        salida = 2
    End Enum
    Sub main()
        Dim turnos As New Queue
        Dim opc As SByte
        Do
            Console.Clear()
            muestro2sgtes(turnos)
            Console.Write("Accion" & vbCrLf & "0.Salir  1.Dar Turno   2.Llamar siguiente: ")
            opc = Console.ReadLine()
            Select Case opc
                Case accion.entrada
                    doy_turnos(turnos)
                Case accion.salida
                    llamo_siguiente(turnos)
                Case Else
                    Exit Do
            End Select
            Console.ReadKey()
        Loop While True
        Console.ReadKey()
    End Sub
    Private Sub doy_turnos(ByRef turno As Queue)
        Dim nombre As String
        Console.Write("Nombre: ")
        nombre = Console.ReadLine()
        turno.Enqueue(nombre)
    End Sub
    Private Sub llamo_siguiente(ByRef lista As Queue)
        If verif_vacio(lista) Then
            Dim cliente As String = lista.Dequeue()
            Console.WriteLine("Siguiente! {0}", cliente)
        Else
            Console.WriteLine("No se puede realizar la accion")
        End If
    End Sub
    Private Sub cliente_en_espera(ByRef cola As Queue)
        Console.WriteLine("En espera {0} clientes", cola.Count)
    End Sub
    Private Function verif_vacio(ByRef cola As Queue) As Boolean
        Return If(cola.Count > 0, True, False)
    End Function
    Private Sub muestro2sgtes(ByRef cola As Queue)
        cliente_en_espera(cola)
        Dim acu As Byte = 0
        If cola.Count > 0 Then
            Console.WriteLine("Los siguientes seran: ")
            For Each elem In cola
                Console.WriteLine(elem)
                acu += 1
                If acu = 2 Then
                    Exit For
                End If
            Next
        Else
            Console.WriteLine("Sin clientes en espera")
        End If
    End Sub
End Module
