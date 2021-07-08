Module Module1

    Sub Main()
        Dim mat, fis, quim, prom As Decimal
        'Inicio
        Console.Title = " Promedio Alumno--::Airdel::"
        mat = 10
        fis = 10
        quim = 8
        prom = (fis + quim + mat) / 3
        Console.WriteLine("El promedio del alumno es:{0}", prom)
        If (prom >= 7) Then
            Console.WriteLine("Alumno Aprobado")
        Else
            Console.WriteLine("Alumno Reprobado")
        End If
        Console.ReadKey()
    End Sub

End Module
