Module ejercicio4_3
    '    Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de
    'alumnos.
    ' Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno
    'con un máximo de 40 alumnos y 4 notas. (hecho)
    ' Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un
    'nombre y que no sea repetido y el rango de la nota. (hecho)
    ' Al completar la iteración informar por cada alumno el promedio, si aprobó o
    'desaprobó teniendo en cuenta que aprueba con 6 o más. (hecho)
    ' También informar quien es el mejor alumno (puede haber más de uno).

    'Implementar procedimientos para resolver al menos las siguientes tareas:
    ' Uno para validad el nombre no sea vacío (hecho)
    ' uno que valide la inexistencia de un nombre igual (hecho)
    ' uno que valide el rango de la nota (hecho)
    ' uno que determine el promedio
    ' uno que escriba si el alumno aprobó o no
    ' uno que devuelva la lista de mejores alumnos
    Sub main()
        Dim cant_alum, cant_notas As Short
        Dim acumulador_notas, mej_prome As Double
        pido_cantalum_cantnotas(cant_alum, cant_notas)
        Dim alumnos(cant_alum - 1) As String
        Dim notas_alum(cant_alum - 1, cant_notas - 1) As Short
        Dim promedio(cant_alum - 1) As Double
        For x = 0 To cant_alum - 1
            Dim alu As String
            Dim nota As Short
            Do
                Console.Write("Nombre: ")
                alu = Console.ReadLine()
            Loop Until Not nombre_vacio(alu) Xor nombre_repe(alu, alumnos)
            alumnos(x) = alu
            For y = 0 To cant_notas - 1
                Do
                    Console.Write("Nota {0}: ", y + 1)
                    nota = Console.ReadLine()
                Loop Until valido_rango(nota, 0, 10)
                notas_alum(x, y) = nota
                acumulador_notas += nota
            Next
            promedio(x) = calculo_promedio(acumulador_notas, cant_notas)
            acumulador_notas = 0
        Next
        'listo los alumnos, sus promedios y si aprobaron o desaprobaron
        For x = 0 To alumnos.Count - 1
            Console.WriteLine("Alumno: {0}  Promedio: {1}, {2}", alumnos(x), promedio(x), condicion_aprobado(promedio(x), 6.0))
        Next
        mej_prome = mejor_promedio(promedio)
        listo_mejores_alumnos(alumnos, promedio, mej_prome)
        Console.ReadKey()
    End Sub
    Private Sub pido_cantalum_cantnotas(ByRef alum As Short, ByRef nota As Short)
        Do
            Console.Write("Cantidad alumnos(max 40): ")
            alum = Console.ReadLine()
        Loop Until valido_rango(alum, 1, 40)
        Do
            Console.Write("Cantidad de notas(max 4): ")
            nota = Console.ReadLine()
        Loop Until valido_rango(nota, 1, 4)
    End Sub
    Private Function valido_rango(valor As Short, desde As Short, hasta As Short) As Boolean
        Return If(valor >= desde And valor <= hasta, True, False)
    End Function
    Private Function nombre_vacio(nombre As String) As Boolean
        Return If(nombre = Nothing, True, False)
    End Function
    Private Function nombre_repe(nombre As String, ByRef alumno_array() As String) As Boolean
        Return alumno_array.Contains(nombre)
    End Function
    Private Function calculo_promedio(ByRef value As Short, cant_notas As Short) As Double
        Return value / cant_notas
    End Function
    Private Function mejor_promedio(ByRef promedio_array() As Double) As Double
        Dim alto_prome As Double = 0
        For Each nota In promedio_array
            If nota > alto_prome Then
                alto_prome = nota
            End If
        Next
        Return alto_prome
    End Function
    Private Sub listo_mejores_alumnos(ByRef alumnos_array() As String, ByRef promedios_array() As Double, promedio As Double)
        Console.WriteLine("***Mejor/es alumno/s***" & vbCrLf & "Promedio: {0}", promedio)
        For x = 0 To promedios_array.Count - 1
            If promedio = promedios_array(x) Then
                Console.WriteLine("Alumno: {0}", alumnos_array(x))
            End If
        Next
    End Sub
    Private Function condicion_aprobado(ByRef promedio As Double, condicion_aprobar As Double) As String
        If promedio >= condicion_aprobar Then
            Return "Aprobo"
        Else
            Return "Desaprobo"
        End If
    End Function
End Module
