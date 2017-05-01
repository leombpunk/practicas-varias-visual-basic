Module ejercicio1_15
    '    Crear un programa que lea separadamente un número de día (1 a 31) y una hh (0 a 24).
    'Con esos valores crea una variable de tipo Date usando el mes y año actual y mostrarla
    Sub main()
        Dim dd, hh, aaaa, mm, min, ss As Integer
        Dim fecho As Date
        Console.Write("n. de dia (1-31): ")
        dd = Console.ReadLine()
        Console.Write("hora (0-23): ")
        hh = Console.ReadLine()
        aaaa = Date.Now.Year
        mm = Date.Now.Month
        'min = Date.Now.Minute
        'ss = Date.Now.Second
        'DateSerial    Compone una fecha a partir de parámetros relativos
        'TimeSerial   Compone una hora a partir de parámetros relativos
        fecho = DateSerial(aaaa, mm, dd) 'TimeSerial(hh, min, ss)
        Console.WriteLine("la wea salio: " & fecho)
        Console.ReadKey()
    End Sub
End Module
