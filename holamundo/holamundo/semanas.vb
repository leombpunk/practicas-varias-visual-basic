Module semanas
    Sub main()
        Const ddanho As UShort = 365
        Const dlaborales As UShort = 250
        Const dsemana As UShort = 7
        Dim x As UShort = ddanho / dsemana
        Dim y As UShort = dlaborales / dsemana
        Console.WriteLine("El año tiene: " & x & " semanas;")
        Console.WriteLine("y " & y & " semanas laborales.")
        Console.ReadKey()
    End Sub
End Module
