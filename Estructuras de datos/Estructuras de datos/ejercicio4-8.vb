Module ejercicio4_8
    '    Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
    'una Hashtable y permita realizar consultas por el nombre de dominio
    ' se introduce el nombre del dominio y se deberá mostrar el nombre del país
    ' Informar si la clave no existe con un mensaje.
    ' Salir cuando el valor ingresado es vacío.
    Sub main()
        Dim lista_paises As New Hashtable
        Dim dominio As String
        cargo_tabla_hash(lista_paises)
        Do
            Console.Write("ingrese un dominio para realizar la busqueda: ")
            dominio = Console.ReadLine()
            Console.WriteLine(busco_pais(lista_paises, dominio))
        Loop Until verif_domin_void(dominio)
        Console.ReadKey()
    End Sub
    Private Sub cargo_tabla_hash(ByRef lista_paises As Hashtable)
        lista_paises.Add("ar", "argentina")
        lista_paises.Add("ch", "chile")
        lista_paises.Add("jp", "japon")
        lista_paises.Add("mx", "mexico")
        lista_paises.Add("br", "brasil")
    End Sub
    Private Function busco_pais(ByRef paises As Hashtable, dominio As String) As String
        If paises.ContainsKey(dominio) Then
            Return paises.Item(dominio)
        Else
            Return "La clave no existe"
        End If
    End Function
    Private Function verif_domin_void(dominio As String) As Boolean
        Return If(dominio = Nothing, True, False)
    End Function
End Module
