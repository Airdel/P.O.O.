Module Module1

    Sub Main()
        Dim mat, fis, quim, prom As Decimal
        'Inicio
        Console.Title = " Promedio Alumno--::Airdel::"
        Console.WriteLine("Bienvenido, Introdusca sus calificaciones")
        Console.Write("Matematicas: ")
        mat = Console.ReadLine()
        Console.Write("Fisica: ")
        fis = Console.ReadLine()
        Console.Write("Quimica: ")
        quim = Console.ReadLine()
        prom = (fis + quim + mat) / 3
        Console.WriteLine("El promedio del alumno es:{0}", prom)
        If (prom >= 7) Then
            Console.WriteLine("Alumno Aprobado")
        Else
            Console.WriteLine("Alumno REprobado")
        End If
        Console.ReadLine()
    End Sub

End Module
