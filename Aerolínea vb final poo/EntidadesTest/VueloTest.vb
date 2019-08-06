Imports Entidades
Module VueloTest
    Sub Main()
        Dim ciudad1 As New Ciudad("asdd", "asd")
        Dim ciudad2 As New Ciudad("qwer", "qwe")
        Dim asiento1 As New Espacioso(2, "A")
        Dim asiento2 As New Economico(2, "B")
        Dim vuelo1 As New Vuelo(4568, ciudad1, ciudad2)
        vuelo1.addAsiento(asiento1)
        vuelo1.addAsiento(asiento2)

        Console.ReadKey()
    End Sub
End Module
