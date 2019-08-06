Imports Entidades
Module CiudadTest
    Sub Main()
        Dim ciudad1 As New Ciudad("algo city", "asd")
        Console.WriteLine("nombre: " & ciudad1.Nombre)
        Console.WriteLine("tostring: " & ciudad1.ToString())
        'Try
        '    ciudad1.Nombre = "algo cityasdasdsadsadddsadsaddsadadadsasaddadsadasasad"
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        Dim ciudad2 As New Ciudad("algo cityasdasdsadsadddsadsaddsadadadsasaddadsadasasad", "asdf")
        Console.WriteLine("nombre: " & ciudad2.Nombre)
        Console.WriteLine("tostring: " & ciudad2.ToString())
        Console.ReadKey()
    End Sub
End Module
