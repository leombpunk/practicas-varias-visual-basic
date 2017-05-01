Module ejercicio1_16
    '    Crear un programa que se ingrese una fecha y un número dados de días, Mostrar como
    'resultado la fecha obtenida de sumar la cantidad de días a la fecha dada
    Sub main()
        Dim deas As UShort
        Dim fercha As Date
        Console.Write("fecha (dd/mm/aaaa): ")
        fercha = Console.ReadLine()
        Console.Write("cantidad de dias a agregar: ")
        deas = Console.ReadLine()
        fercha = fercha.AddDays(deas)
        Console.WriteLine("la wea resulto: " & fercha)
        Console.ReadKey()
    End Sub
End Module
