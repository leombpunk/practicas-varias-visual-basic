Imports ClassLibrary1
Module Module2
    '    Capturar excepciones en un modulo donde se introducen 2 valores numéricos y luego son
    'operados en una división. Generar una excepción si algunos de los campos no es un valor
    'numérico entre 0 y 1000. Mostrar mensajes adecuados según cada situación.
    Sub Main()
        Dim valor1 As UInt16
        Dim valor2 As UInt16
        Try
            Console.Write("1er Numero: ")
            valor1 = Console.ReadLine()
            Console.Write("2do Numero: ")
            valor2 = Console.ReadLine()
        Catch ex As mayor1000Exception
            Console.WriteLine("es mayor a 1000")
        Catch ax As OverflowException
            Console.WriteLine("fuera de rango, overflow")
        Catch ss As InvalidCastException
            Console.WriteLine("no ingreso un numero,ese tipo de dato no es valido")
        End Try
        Console.ReadKey()
    End Sub
End Module
