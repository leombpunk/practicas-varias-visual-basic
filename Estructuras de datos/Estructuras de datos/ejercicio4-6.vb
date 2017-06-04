Module ejercicio4_6
    '    Se tiene la producción de los 7 días de la semana de una planta de chipas con varios empleados.
    'Escribir un algoritmo que permita ingresar cantidad de productos producidos por cada empleado
    'en un día especificado. La producción de cada empleado puede ser ingresadas varias veces por
    'día. Luego de cada ingreso totalizar los ingresos por empleado y por día. Los empleados están
    'cargados programáticamente e identificados por una clave que es su nombre abreviado. Utilizar
    'ArrayList y Collection.
    Enum dias_semanas As Byte
        domingo = 1
        lunes = 2
        martes = 3
        miercoles = 4
        jueves = 5
        viernes = 6
        sabado = 7
    End Enum
    Sub main()
        Dim lista_empleados As New Collection
        Dim produccion_x_dia As New ArrayList
        Dim d_domingo, d_lunes, d_martes, d_miercoles, d_jueves, d_viernes, d_sabado As New ArrayList 'uso dias porque son constantes ponele
        Dim clave_emple As String
        Dim cant_productos, dia, emple As UShort
        lista_empleados.Add("Juan S.", "js")
        lista_empleados.Add("Pancracio N.", "pn")
        lista_empleados.Add("Laura H.", "lh")

        Dim cont_dias As New ArrayList 'probando un arraylist anidado
        cont_dias.Add(d_domingo)
        cont_dias.Add(d_lunes)
        cont_dias.Add(d_martes)
        cont_dias.Add(d_miercoles)
        cont_dias.Add(d_jueves)
        cont_dias.Add(d_viernes)
        cont_dias.Add(d_sabado)

        Console.WriteLine("Agregar Produccion")
        Do
            'Console.Clear()
            Do
                Console.Write("clave empleado: ")
                clave_emple = Console.ReadLine()
            Loop Until lista_empleados.Contains(clave_emple) 'hasta que encuentre la clave del empleado
            Do
                Console.Write("Dia: ")
                dia = Console.ReadLine()
            Loop Until dia >= 1 And dia <= 7
            Console.Write("Produccion: ")
            cant_productos = Console.ReadLine()
            If cant_productos = 0 Then
                Console.WriteLine("Produccion cero, procedo a informar")
                Exit Do
            End If
            Select Case dia
                Case dias_semanas.domingo
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_domingo, cant_productos)
                    informo_x_dia(d_domingo, "domingo")

                Case dias_semanas.lunes
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_lunes, cant_productos)
                    informo_x_dia(d_lunes, "lunes")

                Case dias_semanas.martes
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_martes, cant_productos)
                    informo_x_dia(d_martes, "martes")

                Case dias_semanas.miercoles
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_miercoles, cant_productos)
                    informo_x_dia(d_miercoles, "miercoles")

                Case dias_semanas.jueves
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_jueves, cant_productos)
                    informo_x_dia(d_jueves, "jueves")

                Case dias_semanas.viernes
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_viernes, cant_productos)
                    informo_x_dia(d_viernes, "viernes")

                Case dias_semanas.sabado
                    agrego_Produccion(emple, lista_empleados, clave_emple, d_sabado, cant_productos)
                    informo_x_dia(d_sabado, "sabado")

                Case Else
                    Console.WriteLine("EPA!!!")
            End Select
            informo_x_empleado(lista_empleados, cont_dias)
        Loop While True

        Console.ReadKey()
    End Sub
    Private Sub agrego_Produccion(ByRef emple As UShort, ByRef lista_emple As Collection, clav_emple As String, ByRef dia_arrayli As ArrayList, cant_productos As UShort)
        posicion_empleado(emple, lista_emple, clav_emple)
        If dia_arrayli.Count() = 0 And emple = 1 Then
            dia_arrayli.Add(cant_productos) 'insert de una si no hay nada
        ElseIf dia_arrayli.Contains(emple - 1) Then
            cant_productos += Int(dia_arrayli.Item(emple - 1))
            dia_arrayli.RemoveAt(emple - 1)
        Else
            dia_arrayli.Add(cant_productos)
        End If
        emple = 0
    End Sub
    Private Function posicion_empleado(ByRef emple As UShort, ByRef lista_emple As Collection, clav_emple As String) As UShort
        For Each empleado As String In lista_emple 'me dice la posicion del empleado segun el orden de la collection
            emple += 1
            If lista_emple.Item(clav_emple) = empleado Then
                Exit For
            End If
        Next
        Return emple
    End Function
    Private Sub informo_x_dia(ByRef dia_semana As ArrayList, dia As String)
        Dim dia_ac As Integer
        For Each ddia In dia_semana
            dia_ac += ddia
        Next
        Console.WriteLine("El dia {0} se produjeron {1} chipas.", dia, dia_ac)
        dia_ac = 0
    End Sub
    Private Sub informo_x_empleado(ByRef collection_emple As Collection, ByRef array_cont_dias As ArrayList)
        Dim emple_ac, oemp As Integer
        For Each empleado In collection_emple
            oemp += 1
            For Each dia As ArrayList In array_cont_dias
                For Each wea In dia.Item(oemp)
                    emple_ac += wea
                Next
                Console.WriteLine()
            Next
        Next
    End Sub
End Module
