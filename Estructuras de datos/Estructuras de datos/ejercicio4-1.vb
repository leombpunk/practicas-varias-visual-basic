Module ejercicio4_1
    '    Elaborar un algoritmo que permita cargar 5 números en un arreglo de 5 elementos; calcular la
    'media y luego imprimir cada elemento del arreglo y la desviación que tiene respecto a la media.
    'La MEDIA se obtiene la sumatoria de los todos elementos del arreglo y se divide por la cantidad
    'de los mismos. La DESVIACION de cada elemento se obtiene restándole al elemento la
    'MEDIA.
    Private arreglode5(4) As Integer
    Sub Main()
        'Dim arreglode5(5) As Integer
        For x = 0 To 4 Step 1
            Console.Write("ingrese un numero: ")
            arreglode5(x) = Console.ReadLine()
        Next
        muestroArreglo()
        Console.WriteLine("La media del arreglo es: " & calc_Media(arreglode5) & vbCrLf & "Redondeado a: " & Math.Round(calc_Media(arreglode5)))
        Console.WriteLine("La desviacion es: " & calc_Desviacion(arreglode5) & vbCrLf & "Redondeado a: " & Math.Round(calc_Desviacion(arreglode5)))
        Console.ReadKey()
    End Sub
    Private Function calc_Media(arreglo() As Integer) As Single
        Dim media As Single
        For Each wea As Integer In arreglo
            media += wea
        Next
        Return media / 5
    End Function
    Private Function calc_Desviacion(arreglo() As Integer) As Single
        Dim desviacion As Integer
        For Each lawea As Integer In arreglo
            desviacion += lawea - calc_Media(arreglode5)
        Next
        Return desviacion / 5
    End Function
    Private Sub muestroArreglo()
        Console.WriteLine("Muestro el arreglo: ")
        For Each mienbro As Integer In arreglode5
            Console.Write(mienbro & ", ")
        Next
    End Sub
End Module
