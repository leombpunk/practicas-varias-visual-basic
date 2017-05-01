Module ejercicio2_15
    '    Dado el siguiente planteo: se deposita un capital a un plazo de n meses, con una tasa de
    'interés de 36% anual (es una constante), capitalizable cada mes, es decir, se suman los intereses
    'ganados al capital. Elaborar un algoritmo que ingrese el capital inicial, la cantidad de meses y
    'luego imprima el siguiente reporte
    'Donde:
    'MES: es el número de mes.
    'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
    'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2, deberá
    'tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
    'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor que
    'gana en el mes correspondiente.
    'SALDO: es el el capital sumado el interés.
    'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales
    Sub main()
        'formula interes simple: I= C*r*t/(100=años,1200=meses,36000=dias)
        Dim capital, acuinteres, saldo, interes As Single
        Const c_interes As Byte = 36
        Dim tiempo As Byte
        Console.Write("Capital: ")
        capital = Console.ReadLine()
        Console.Write("Tiempo (meses): ")
        tiempo = Console.ReadLine()
        Console.WriteLine(vbCrLf & "    MES   " & "  CAPITAL  " & "  INTERES  " & "  SALDO  ")
        For x As UShort = 1 To tiempo
            interes = (capital * c_interes * tiempo) / 1200
            saldo = capital + interes
            acuinteres += interes
            Console.WriteLine("      " & x & "       " & capital & "        " & interes & "        " & saldo)
            capital = saldo
        Next
        Console.WriteLine(vbCrLf & "TOTAL INTERESES GANADOS: " & acuinteres & "$")
        Console.ReadKey()
    End Sub
End Module
