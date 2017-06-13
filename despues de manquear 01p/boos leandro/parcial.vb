Module parcial
    Enum opciones
        alta_alumnos = 1
        lista_alumnos = 2
        alta_notas = 3
        resultados = 4
        salir = 0
    End Enum
    Sub Main()
        Dim opc As Int16
        Dim lista_d_alumnos As New Dictionary(Of String, String)
        Dim lista_d_notas As New List(Of Double)
        Console.WriteLine("valido {0}", valido_caracter("rs"))
        Console.WriteLine("invalido {0}", valido_caracter("asd"))
        Console.WriteLine("valido {0}", valido_caracter_menor5("rambomax"))
        Console.WriteLine("invalido {0}", valido_caracter_menor5("nope"))
        Console.WriteLine("valido {0}", valido_valor_real(5.45))
        Console.WriteLine("invalido {0}", valido_valor_real(15.256))
        Do
            menu(opc)
            Select Case opc
                Case opciones.alta_alumnos
                    Malta_alumnos(lista_d_alumnos)
                Case opciones.lista_alumnos
                    Mlistado_alumnos(lista_d_alumnos)
                Case opciones.alta_notas
                    Malta_notas(lista_d_notas, lista_d_alumnos)', alu_auxi)
                Case opciones.resultados
                    Mresultados(lista_d_notas, lista_d_alumnos)
                Case opciones.salir
                    Console.WriteLine("Adios")
                    Exit Do
                Case Else
                    Console.WriteLine("Opcion no valida (0-4)")
                    'Exit Do
            End Select
        Loop While True
        Console.ReadKey()
    End Sub
    Private Function valido_caracter(caracter As String) As Boolean
        Return If(caracter.Length = 2, True, False)
    End Function
    Private Function valido_caracter_menor5(caracter As String) As Boolean
        Return If(caracter.Length > 5, True, False)
    End Function
    Private Function valido_valor_real(valor As Double) As Boolean
        valor = Math.Round(valor, 1)
        Return If(valor > 0.0 And valor < 10.0, True, False)
    End Function
    Private Sub menu(ByRef opc As Int16)
        Console.WriteLine("---Menu---")
        Console.WriteLine("1.alta alumnos" & vbCrLf & "2.lista alumnos" & vbCrLf & "3.alta notas" & vbCrLf & "4.resultados" & vbCrLf & "0.salir")
        opc = Console.ReadLine()
    End Sub
    Private Sub Malta_alumnos(ByRef lista_alum As Dictionary(Of String, String))
        Dim legajo, nombre As String
        Console.WriteLine("***Alta alumnos***")
        Do
            Console.Write("Legajo: ")
            legajo = Console.ReadLine()
            If legajo = Nothing Then
                Exit Sub
            End If
        Loop Until valido_caracter(legajo) And Not lista_alum.ContainsKey(legajo)
        Do
            Console.Write("Nombre: ")
            nombre = Console.ReadLine()
            If nombre = Nothing Then
                Exit Sub
            End If
        Loop Until valido_caracter_menor5(nombre)
        lista_alum.Add(legajo, nombre)
    End Sub
    Private Sub Mlistado_alumnos(ByRef lista_alum As Dictionary(Of String, String))
        Console.WriteLine("---Lista de alumnos---")
        For Each elemento In lista_alum
            Console.WriteLine("Legajo: {0}, Alumno: {1}", elemento.Key, elemento.Value)
        Next
    End Sub
    Private Sub Malta_notas(ByRef lista_notas As List(Of Double), ByRef lista_alum As Dictionary(Of String, String))
        Dim desde As Int32 = 0, hasta As Int32 = 2
        Dim nota As Double
        For Each elemento In lista_alum
            Console.WriteLine("Alumno: {0}", elemento.Value)
            For y = desde To hasta
                Do
                    Console.Write("Nota: ")
                    nota = Console.ReadLine()
                    If valido_valor_real(nota) Then
                        Try
                            lista_notas.Item(y) = nota
                        Catch
                            lista_notas.Add(nota)
                        End Try

                        Exit Do
                    End If
                Loop While True
            Next
            desde += 3
            hasta += 3
        Next
    End Sub
    Private Sub Mresultados(ByRef lista_notas As List(Of Double), ByRef lista_alumnos As Dictionary(Of String, String))
        Dim acum As Byte = 3
        Dim desde As Int32 = 0, hasta As Int32 = 2
        For Each alumno In lista_alumnos
            Console.WriteLine("Alumno: {0}", alumno.Value)
            For y = desde To hasta
                Console.WriteLine("Nota: {0}", lista_notas.Item(y))
                If lista_notas.Item(y) < 7 Then
                    acum -= 1
                End If
            Next
            If acum = 3 Then
                Console.WriteLine("Aprobado")
            ElseIf acum = 2 Then
                Console.WriteLine("Recupera")
            ElseIf acum = 1 Then
                Console.WriteLine("Desaprobado")
            End If
            acum = 3
            desde += 3
            hasta += 3
        Next
    End Sub
End Module
