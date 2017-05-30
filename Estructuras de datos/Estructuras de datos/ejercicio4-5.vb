Module ejercicio4_5
    '    Al ejercicio anterior agregarle las funcionalidades que permita interactivamente agregar, editar,
    'eliminar y mostrar el nombre de país y su dominio. También informar la cantidad de países
    'cargados.
    Sub main()
        Dim lista_paises As New Collection
        Dim dominio_p, pais As String
        Dim opcion As Byte
        lista_paises.Add("Argentina", "ar")
        lista_paises.Add("Peru", "pe")
        lista_paises.Add("Paraguay", "py")
        lista_paises.Add("Chile", "ch")
        'Do
        '    Console.Write("Dominio del pais a consultar: ")
        '    dominio_p = Console.ReadLine()
        '    If dominio_p = Nothing Then
        '        Exit Do
        '    End If
        '    Console.WriteLine(lista_paises.Item(dominio_p))
        'Loop While True
        Do
            Console.Clear()
            Console.WriteLine("***Opciones***" & vbCrLf & "1.Agregar Pais    2.Editar" & vbCrLf & "3.Eliminar        4.Listar")
            opcion = Console.ReadLine()
            Select Case opcion
                Case 1
                    Console.Write("Agregar: " & vbCrLf & "Pais: ")
                    pais = Console.ReadLine()
                    Console.Write("Dominio: ")
                    dominio_p = Console.ReadLine()
                    lista_paises.Add(pais, dominio_p)
                Case 2
                    Console.Write("Editar:" & vbCrLf & "Dominio del pais a editar: ")
                    dominio_p = Console.ReadLine()
                    lista_paises.Remove(dominio_p)
                    Console.WriteLine("Listo")
                    Console.Write("Cambio por: " & vbCrLf & "Pais: ")
                    pais = Console.ReadLine()
                    Console.Write("Dominio: ")
                    dominio_p = Console.ReadLine()
                    lista_paises.Add(pais, dominio_p)
                    Console.WriteLine("Hecho")
                Case 3
                    Console.Write("Eliminar: " & vbCrLf & "Dominio: ")
                    dominio_p = Console.ReadLine()
                    lista_paises.Remove(dominio_p)
                Case 4
                    Console.WriteLine("Listado de paises y sus dominios: ")
                    For Each country In lista_paises
                        Console.WriteLine(country & ", ") 'ni idea de como poner el dominio
                    Next
                    Console.WriteLine("Cantidad de paises: " & lista_paises.Count())
                Case 0
                    Exit Do
            End Select
            Console.WriteLine("Para salir opcion 0")

            Console.ReadKey()
        Loop While True
        Console.ReadKey()
    End Sub
End Module
