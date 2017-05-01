Module tabla_de_verdad
    Sub main()
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        Console.WriteLine("Tabla de verdad AND")
        Console.WriteLine("{0} and {1}: " & (verdadero And falso), verdadero, falso)
        Console.WriteLine("{0} and {1}: " & (verdadero And verdadero), verdadero, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso And verdadero), falso, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso And falso), falso, falso)

        Console.WriteLine(vbCrLf & "Tabla de verdad OR")
        Console.WriteLine("{0} and {1}: " & (verdadero Or falso), verdadero, falso)
        Console.WriteLine("{0} and {1}: " & (verdadero Or verdadero), verdadero, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso Or verdadero), falso, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso Or falso), falso, falso)

        Console.WriteLine(vbCrLf & "Tabla de verdad XOR")
        Console.WriteLine("{0} and {1}: " & (verdadero Xor falso), verdadero, falso)
        Console.WriteLine("{0} and {1}: " & (verdadero Xor verdadero), verdadero, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso Xor verdadero), falso, verdadero)
        Console.WriteLine("{0} and {1}: " & (falso Xor falso), falso, falso)

        Console.WriteLine(vbCrLf & "Tabla de verdad NOT")
        Console.WriteLine("NOT {0}: " & (Not verdadero), verdadero)
        Console.WriteLine("NOT {0}: " & (Not falso), falso)
        Console.ReadKey()
    End Sub
End Module
