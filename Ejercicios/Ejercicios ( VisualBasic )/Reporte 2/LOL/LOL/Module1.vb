Module Module1

    Sub Main()
        'Dim Co1 As New Componentes()
        'Dim C1 As New Computadora '<-----Cons. Omision

        'Dim C2 As New Computadora("Escritorio", "Metal", 1000.9, 1900, 10, "i5", "Intel", "Inalambrico", "Inalambrico", "Lenovo", "Rojo")
        'Dim C3 As New Computadora("Hp", "rosa", "Portaltil", "Alambre", 10000, Co1) '<----Leido

        'Dim C4 As Computadora = C2 '<----Cons. Copia
        'Dim C5 As New Computadora() '<----Leido

        Dim c1 As New Campeon()

        c1.leedatos()
        c1.items.leerdatos()
        c1.Imprimedatos()
        c1.items.Imprimedatos()
        Dim b2 As New Campeon()
        b2.items.Imprimedatos()
        Dim b3 As New Campeon()
        b3.items.Imprimedatos()
        Dim b4 As New Build

        Console.ReadKey()

    End Sub

End Module
