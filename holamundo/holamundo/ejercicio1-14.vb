Module ejercicio1_14
    '    Crear un programa que muestre en líneas diferentes con sus correspondientes títulos los
    'siguientes valores en el momento de la ejecución: día del año, mes, hora y minuto
    Sub main()
        Console.WriteLine("dia del año: " & Date.Today.DayOfYear)
        Console.WriteLine("mes: " & Date.Today.Month)
        Console.WriteLine("hora y minuto: " & Date.Now.Hour & ":" & Date.Now.Minute)
        Console.ReadKey()
    End Sub
End Module
