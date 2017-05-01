Module variables
    'punto 1.2
    'el nombre de la persona para que sea accesible en cualquier parte de la solución
    'el tipo y número documento y fecha de nacimiento para que sean accesibles solamente al proyecto “Hola Mundo”
    'Edad es local.
    'El resto que sean solo accesibles en todo el módulo.
    Public nombre As String = "el weon challa"
    Friend t_documento As String = "dni"
    Friend n_documento As UInteger = 123456789
    Friend f_nacimiento As Date = #12/19/1991# ' formato fecha mm/dd/aaaa
    Private altura_c_metros As Single = 1.72 'en metros tambien se puede espresar en cm
    Private altura_c_cm As Byte = 172 'tambien podria usar ushort para alguien de 3 metros
    Private est_civil As String = "castrado"
    Private argentino As Boolean = True 'o false segun corresponda, lel
    Private localidad As String = "calle falsa nº 123"
    Sub main()
        'punto 1.3
        'Dim n_documento1 As UInteger = 12345loco
        Dim edad As Byte = 19 'quizas tambien ushort valga
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo de Documento: " & t_documento)
        Console.WriteLine("Numero de Documento: " & n_documento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de Nacimiento: " & f_nacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura m/cm: " & altura_c_metros & "/" & altura_c_cm)
        Console.WriteLine("Estado Civil: " & est_civil)
        Console.WriteLine("Es argentino?: " & argentino)
        Console.ReadKey()
    End Sub
End Module
