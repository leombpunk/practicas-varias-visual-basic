Module ejercicio1_17
    '    Al programa anterior, utilizando una enumeración para los días de la semana en español,
    'mostrar que día que corresponde al resultado
    Enum semana
        domingo
        lunes
        martes
        miercoles
        jueves
        viernes
        sabado
    End Enum
    Sub main()
        Dim deas As UShort
        Dim fercha As Date
        Console.Write("fecha (dd/mm/aaaa): ")
        fercha = Console.ReadLine()
        Console.Write("cantidad de dias a agregar: ")
        deas = Console.ReadLine()
        fercha = fercha.AddDays(deas)

        Console.WriteLine("la wea resulto: " & fercha)
        Select Case fercha.DayOfWeek
            Case semana.domingo
                Console.WriteLine("domingo")
            Case semana.lunes
                Console.WriteLine("lunes")
            Case semana.martes
                Console.WriteLine("martes")
            Case semana.miercoles
                Console.WriteLine("miercoles")
            Case semana.jueves
                Console.WriteLine("jueves")
            Case semana.viernes
                Console.WriteLine("viernes")
            Case semana.sabado
                Console.WriteLine("sabado")
            Case Else
                Console.WriteLine("no se la wea")
        End Select
        Console.ReadKey()
    End Sub
End Module
