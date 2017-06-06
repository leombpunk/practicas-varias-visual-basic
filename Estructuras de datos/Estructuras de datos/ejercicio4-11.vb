Module ejercicio4_11
    '    Crear un algoritmo que lea valores reales en forma consecutiva y los vaya agregando a
    'una pila de tipo real.
    ' Si el valor ingresado es cero se quita un elemento.
    ' En todo momento informar la sumatoria total de los valores.
    Private acum As Int32
    Sub main()
        Dim pila_tipo_real As New Stack(Of Int32)
        Console.WriteLine("Agrego Numeros Reales a una Pila")
        cargo_pila(pila_tipo_real)
        Console.ReadKey()
    End Sub
    Private Sub cargo_pila(ByRef pila As Stack(Of Int32))
        Dim elemento As Int32
        Console.Write("Agregar Valores: ")
        elemento = Console.ReadLine()
        If valido_valor(elemento) Then
            pila.Push(elemento)
            Console.WriteLine("Sumatoria1: {0}", sumatoria(elemento))
            cargo_pila(pila)
        ElseIf Not valido_valor(elemento) And pila.Count > 0 Then
            Console.WriteLine("Sumatoria2: {0}", actualizo_sumatoria(pila.Peek()))
            pila.Pop()
            cargo_pila(pila)
        Else
            Console.WriteLine("Sin elementos, no se puede extraer, adios")
        End If
    End Sub
    Private Function valido_valor(value As Int32) As Boolean
        Return If(value <> 0, True, False)
    End Function
    Private Function sumatoria(value As Int32) As Int32
        acum += value
        Return acum
    End Function
    Private Function actualizo_sumatoria(value As Int32) As Int32
        acum -= value
        Return acum
    End Function
End Module