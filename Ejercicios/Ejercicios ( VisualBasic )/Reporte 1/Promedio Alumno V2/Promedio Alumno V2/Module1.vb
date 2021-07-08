Module Module1

    Sub Main()
        Dim mat, fis, quim, prom As Decimal
        Console.WriteLine("Bienvenido, por favor introduzca sus calificaciones")
        Console.Write("Matematicas: ")
        mat = Console.ReadLine()
        Console.Write("Fisica: ")
        fis = Console.ReadLine()
        Console.Write("Quimica: ")
        quim = Console.ReadLine()
        prom = (mat + fis + quim) / 3
        Console.WriteLine("El promedio del alumno es: {0}", prom)
        If (prom >= 7) Then
            Console.WriteLine("Alumno aprobado, felicidades!")
        Else
            Console.WriteLine("Alumno reprobado, Sigue esforzandote!")
        End If
        Console.WriteLine("Presione cualquier tecla para continuar, Gracias. :)")
        Console.ReadKey()
    End Sub

End Module
