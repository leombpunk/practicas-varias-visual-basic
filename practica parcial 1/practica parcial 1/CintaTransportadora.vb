Module CintaTransportadora
    Enum opciones
        salir = 0
        alta = 1
        baja = 2
        vercinta = 3
    End Enum
    Sub Main()
        '***----PASO 1----***
        '    Crear una función llamada “ValidarPeso” que acepte como parámetro un número entero mayor de 0 y hasta 30 inclusive.
        'La función retorna un valor booleano verdadero es si el valor cumple la condición si no devuelve falso.
        'En el método “Main” ingresar un valor por teclado y comprobar con la función ValidarPeso si es válido, si no lo fuera 
        'solicitar su re ingreso hasta que sea válido.
        'Dim peso As Int32
        'Console.WriteLine("Cinta Transportadora (paso 1): ")
        'Do
        '    Console.Write("Ingrese peso: ")
        '    peso = Console.ReadLine()
        'Loop Until ValidarPeso(peso)


        '***----PASO 2----***
        '    Crear una función llamada “PesoTotal” que:
        'Reciba por referencia una colección basada en FIFO y de tipo entero sin signo de 2 bytes y retorne un valor de tipo 
        'entero sin signo de 4 bytes. 
        'En la función sumar todos los valores incluidos en la colección y retornar la sumatoria.
        'En el método principal:
        'Comentar lo anterior, 
        'crear una colección del mismo tipo que la de la función, 
        'programáticamente agregar 3 valores cualquiera a la colección, 
        'invocar a la función y mostrar el resultado.
        'Dim cola_pesototal As New Queue(Of UInt16) 'ushort
        'cola_pesototal.Enqueue(5)
        'cola_pesototal.Enqueue(46)
        'cola_pesototal.Enqueue(12)
        'Console.WriteLine("La sumatoria de elementos es: {0} (peso)", PesoTotal(cola_pesototal))


        '***----PASO 3----***
        '    En el mismo módulo crear una función llamada “ValidarNombreUsuario” que reciba una cadena y retorne un valor booleano.
        'La función debe validar que la cadena cumpla las siguientes condiciones:
        'De 5 a 10 caracteres de longitud. 
        'No puede empezar con números (ASCII de 48 al 57). 
        'No puede tener espacios. (ASCII 32)
        'Para realizar las comprobaciones anteriores puede utilizar los métodos Length y ElementAt de la variable 
        '(por ejemplo valor.ElementAt(z) donde z es la posición del carácter) y Convert
        'Se deben cumplir todas las condiciones para retornar verdadero.
        'En el método principal comentar lo anterior y realizar la prueba programáticamente de la función para todos los casos 
        'posibles (válidos e inválidos) mostrando los resultados.
        'Dim nombreUsuario As String
        'Do
        '    Console.Write("Nombre: ")
        '    nombreUsuario = Console.ReadLine()
        '    If ValidarNombreUsusario(nombreUsuario) Then
        '        Console.WriteLine("Valido")
        '    Else
        '        Console.WriteLine("Invalido")
        '    End If
        'Loop Until ValidarNombreUsusario(nombreUsuario)


        '***----PASO 4----***
        'Escenario: Una cinta transportadora de equipaje traslada maletas desde un mostrador de despacho de equipaje hasta la aeronave. 
        'Consignas:
        'En el método principal comentar lo anterior y crear un menú que permita ejecutar un procedimiento y luego volver a ejecutar 
        'el mismo hasta que se elija salir. Las opciones del menú se validan con una enumeración.
        'Usar subrutinas para empaquetar el código de los comandos invocados desde el menú.
        'Crear las estructuras de datos necesarias para cumplir las consignas únicamente con Dim.
        'Cada vez que se deba ingresar un dato, mostrar una leyenda adecuada.
        'Procedimientos:
        '1) Alta: agrega un usuario y el peso de su maleta. Utilizar las funciones “ValidarNombreUsuario” y “ValidarPeso”, si el dato
        'no es válido reingresar. Si el peso total de la cinta excede los 100 kilos no permitir este proceso e informar con un 
        'mensaje, este valor debe accederse mediante una constante. 
        '2) Baja: Extrae la primer maleta y muestra el nombre del usuario y el peso de la maleta. Si no hay maletas informar con 
        'un mensaje.
        '3) Ver cinta: muestra el contenido de la cinta transportadora: lista de usuarios y el peso de su maleta. Al final 
        'informar el peso total sobre la cinta. Tip: Puede usar el método “elementAt” sobre una colección.
        '0) Salir
        Dim elegir_opc As Short
        Dim pesoMaletas As New Queue(Of UInt16)
        Dim nombres As New Queue(Of String)
        Do
            Console.WriteLine("Opciones: 1-Alta 2-Baja 3-Ver Cinta 0-Salir")
            elegir_opc = Console.ReadLine()
            Select Case elegir_opc
                Case opciones.alta
                    Dim nombre As String
                    Dim peso As UInt16
                    Do
                        Console.Write("Nombre: ")
                        nombre = Console.ReadLine()
                    Loop Until ValidarNombreUsusario(nombre)
                    '--------------------------
                    nombres.Enqueue(nombre)
                    '--------------------------
                    Do
                        Console.Write("Peso de la maleta: ")
                        peso = Console.ReadLine()
                        'If PesoTotal(pesoMaletas) <= 100 And ValidarPeso(peso) Then
                        '    pesoMaletas.Enqueue(peso)
                        'Else
                        '    peso = 31
                        'End If
                    Loop Until ValidarPeso(peso) And PesoTotal(pesoMaletas) <= 100
                    '--------------------------
                    pesoMaletas.Enqueue(peso)
                    '--------------------------

                Case opciones.baja
                    Console.WriteLine("***---BAJA---***")
                    If nombres.Count = 0 Then
                        Console.WriteLine("No hay maletas que extraer!")
                    Else
                        Console.WriteLine("Nombre: {0}, Peso Maleta: {1}", nombres.Peek(), pesoMaletas.Peek())
                        nombres.Dequeue()
                        pesoMaletas.Dequeue()
                    End If

                Case opciones.vercinta
                    Console.WriteLine("***---Elementos de la Cinta---***")
                    For x = 0 To nombres.Count - 1
                        Console.WriteLine("Nombre {0}, Peso Maleta: {1}", nombres.ElementAt(x), pesoMaletas.ElementAt(x))
                    Next
                    Console.WriteLine("Peso total: {0}", PesoTotal(pesoMaletas))
                Case opciones.salir
                    Console.WriteLine("Adios")
                    Exit Do
                Case Else
                    Console.WriteLine("Opcion no valida pe!")
                    Exit Do
            End Select
        Loop While True

        Console.ReadKey()
    End Sub
    Private Function ValidarPeso(valor1 As Int32) As Boolean
        Return If(valor1 > 0 And valor1 <= 30, True, False)
    End Function
    Private Function PesoTotal(ByRef cola As Queue(Of UInt16)) As UInt32
        Dim sumatoria As UInt32
        For Each elemento In cola
            sumatoria += elemento
        Next
        Return sumatoria
    End Function
    Private Function ValidarNombreUsusario(cadena As String) As Boolean
        If cadena.Length >= 5 And cadena.Length <= 10 Then
            For pos = 0 To cadena.Length - 1 Step 1 'recorre la longuitud de la variable tipo string
                'Console.WriteLine(cadena.ElementAt(pos)) 'muestra el valor de la variable segun la posicion
                If cadena.ElementAt(pos) = Convert.ToChar(32) Then 'evalua si hay un un espacio en blanco
                    Return False
                End If
                For elemento = 48 To 57 Step 1 'valores de los numeros en ASCII
                    If cadena.ElementAt(0) = Convert.ToChar(elemento) Then 'evalua si empieza con numero en la cadena
                        Return False
                    End If
                Next
            Next
            Return True
        Else
            Return False
        End If
    End Function
End Module
