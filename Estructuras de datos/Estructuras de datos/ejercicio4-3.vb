Module ejercicio4_3
    '    Crear un algoritmo para operar las notas (0 a 10) de una serie de alumnos. Primero ingresar la
    'cantidad de alumnos y la cantidad de notas que tiene cada uno con un máximo de 40 alumnos y
    '4 notas. Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un
    'nombre que no sea repetido y el rango de la nota. Al completar la iteración informar por cada
    'alumno el promedio, si aprobó o desaprobó teniendo en cuenta que aprueba con 6 o más.
    'Además, informar quien es el mejor alumno (puede haber más de uno). Implementar
    'procedimientos para resolver cada tarea.
    Sub main()
        Dim c_alum, c_notas As Integer
        IngresoCant_Alum_Nota(c_alum, c_notas)
        Dim a_alumnos(c_alum - 1) As String
        Dim a_notas(c_alum - 1, c_notas - 1) As Integer
        For x = 0 To c_alum - 1
            Do
                Dim alumnito As String
                Console.Write("Nombre del alumno: ")
                alumnito = Console.ReadLine()
                If a_alumnos.Contains(alumnito) Then
                    Console.WriteLine("Ese nombre esta en uso")
                    a_alumnos(x) = Nothing
                Else
                    a_alumnos(x) = alumnito
                End If
            Loop Until a_alumnos(x) <> Nothing
            For y = 0 To c_notas - 1
                Do
                    Console.Write("Nota {0}: ", y + 1)
                    a_notas(x, y) = Console.ReadLine()
                Loop Until valido_cantidad(a_notas(x, y), 0, 10)
            Next
        Next
        'Console.Clear()
        For alumno = 0 To a_alumnos.GetLength(0) - 1
            Console.Write("Alumno: {0} --> ", a_alumnos(alumno))
            Dim promedio As Integer
            For nota = 0 To a_notas.GetLength(1) - 1
                promedio += a_notas(alumno, nota)
            Next
            Console.Write("Promedio: {0} = ", Math.Round(promedio / c_notas))
            If (promedio / c_notas) >= 6 Then
                Console.WriteLine("APROBÓ")
            Else
                Console.WriteLine("DESAPROBÓ")
            End If
            promedio = 0
        Next
        Console.ReadKey()
    End Sub
    Private Sub IngresoCant_Alum_Nota(ByRef valor1 As Integer, ByRef valor2 As Integer)
        Do
            Console.Write("Cantidad de alumnos: ")
            valor1 = Console.ReadLine()
        Loop Until valido_cantidad(valor1, 1, 40)
        Do
            Console.Write("Cantidad de notas: ")
            valor2 = Console.ReadLine()
        Loop Until valido_cantidad(valor2, 1, 4)
    End Sub
    Private Function valido_cantidad(cantidad As Integer, desde As SByte, hasta As SByte) As Boolean
        Return If(cantidad <= hasta And cantidad >= desde, True, False)
    End Function
End Module
