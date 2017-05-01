Module concatenacion
    Sub main()
        Dim empresa As String = "Empresa tal"
        Dim calle As String = "calle falsa 123"
        Dim fech_ini_activ As Date = Today
        Console.WriteLine("conversion explicita: " + empresa + calle + Convert.ToString(fech_ini_activ))
        Console.WriteLine("conversion implicita: " & empresa & calle & fech_ini_activ)
        Console.ReadKey()
    End Sub
End Module
