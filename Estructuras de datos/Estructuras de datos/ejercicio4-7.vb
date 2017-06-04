Module ejercicio4_7
    '    Crear un algoritmo que utilice arrayList para almacenar las notas (0 a 10) de una serie de
    'alumnos.
    ' Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un
    'máximo de 40 alumnos y 4 notas.
    ' Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre
    'y que no sea repetido y el rango de la nota.
    ' Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó
    'teniendo en cuenta que aprueba con 6 o más.
    ' También informar quien es el mejor alumno (puede haber más de uno).
    ' Implementar procedimientos para resolver al menos las siguientes tareas:
    ' Uno para validad el nombre no sea vacío
    ' uno que valide la inexistencia de un nombre igual
    ' uno que valide el rango de la nota
    ' uno que determine el promedio
    ' uno que escriba si el alumno aprobó o no
    ' uno que devuelva la lista de mejores alumnos
    Sub main()
        Dim c_alum, c_notas As Integer
        IngresoCant_Alum_Nota(c_alum, c_notas)
        Dim a_alumnos(c_alum - 1) As String 'arreglo de alumnos
        Dim a_notas(c_alum - 1, c_notas - 1) As Integer 'arreglo multidimencional de notas
        Dim a_promedio(c_alum - 1) As Single 'arreglo de promedios
        Dim mejor As Single = 6.0
        For x = 0 To c_alum - 1
            Do
                Dim alumnito As String
                Console.Write("Nombre del alumno: ")
                alumnito = Console.ReadLine()
                If valido_nombre_vacio(alumnito) Then
                    Console.WriteLine("el campo esta vacio")
                ElseIf valido_nombre_repetido(alumnito, a_alumnos) Then
                    Console.WriteLine("el nombre esta repetido")
                    a_alumnos(x) = Nothing
                Else
                    a_alumnos(x) = alumnito
                End If
            Loop Until Not (valido_nombre_vacio(a_alumnos(x)))
            For y = 0 To c_notas - 1
                Do
                    Console.Write("Nota {0}: ", y + 1)
                    a_notas(x, y) = Console.ReadLine()
                Loop Until valido_cantidad(a_notas(x, y), 0, 10)
            Next
        Next
        'Console.Clear()
        'promedio y compruebo si aprobo o desaprobo
        For alumno = 0 To a_alumnos.GetLength(0) - 1
            Console.Write("Alumno: {0} --> ", a_alumnos(alumno))
            Dim promedio As Integer
            For nota = 0 To a_notas.GetLength(1) - 1
                promedio += a_notas(alumno, nota)
                a_promedio(alumno) = calculo_promedio_notas(promedio, c_notas)
            Next
            Console.Write("Promedio: {0} = ", calculo_promedio_notas(promedio, c_notas))
            If aprob_desaprob(calculo_promedio_notas(promedio, c_notas)) Then
                Console.WriteLine("APROBÓ")
            Else
                Console.WriteLine("DESAPROBÓ")
            End If
            promedio = 0
        Next

        For x = 0 To c_alum - 1
            mejor_promedio(mejor, a_promedio(x))
        Next
        Console.WriteLine("***Alumnos con Mejores Promedios***" & vbCrLf & "Promedio: " & mejor)
        For z = 0 To c_alum - 1
            Console.WriteLine(mejores_alumnos(mejor, a_promedio(z), a_alumnos(z)))
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
    Private Function calculo_promedio_notas(acu_promedio As Integer, cant_notas As Integer) As Single
        Return acu_promedio / cant_notas
    End Function
    Private Function valido_nombre_vacio(nombre As String) As Boolean
        Return If(nombre = Nothing, True, False)
    End Function
    Private Function valido_nombre_repetido(nombre As String, arreglo_alum() As String) As Boolean
        Return If(arreglo_alum.Contains(nombre), True, False)
    End Function
    Private Function aprob_desaprob(promedio As Single) As Boolean
        Return If(promedio >= 6, True, False)
    End Function
    Private Function mejores_alumnos(mejor_promedio As Single, a_promedios As Single, alumno As String) As String
        If mejor_promedio = a_promedios Then
            Return alumno
        Else
            Return Nothing
        End If
    End Function
    Private Sub mejor_promedio(ByRef mejor As Single, arraydepromedios As Single)
        If arraydepromedios > mejor Then
            mejor = arraydepromedios
        End If
    End Sub
End Module
