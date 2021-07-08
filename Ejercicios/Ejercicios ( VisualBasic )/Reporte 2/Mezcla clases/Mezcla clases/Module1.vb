Module Module1
    Sub Main()

        Dim d1 As New disco()
        Dim d2 As New disco("Astrometry", "Regulus", "Hatsune Miku", 3.14, "V")
        Dim d3 As New disco()
        Dim d4 As New disco()


        Console.WriteLine("Album: " & d1.nombreD)
        Console.WriteLine("Interprete: " & d1.Cancion.InterpreteP)

        Console.ReadKey()





    End Sub

End Module
