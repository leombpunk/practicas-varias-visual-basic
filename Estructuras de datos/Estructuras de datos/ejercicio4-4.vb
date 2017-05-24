Module ejercicio4_4
    '    Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
    'una Collection. A continuación, debe permitir realizar consultas, se introduce el nombre del
    'dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.
    Sub main()
        Dim lista_paises As New Collection
        Dim dominio_p As String
        lista_paises.Add("Argentina", "ar")
        lista_paises.Add("Peru", "pe")
        lista_paises.Add("Paraguay", "py")
        lista_paises.Add("Chile", "ch")
        Do
            Console.Write("Dominio del pais a consultar: ")
            dominio_p = Console.ReadLine()
            If dominio_p = Nothing Then
                Exit Do
            End If
            Console.WriteLine(lista_paises.Item(dominio_p))
        Loop While True
        Console.ReadKey()
    End Sub
End Module
