Module Module1

    Sub Main()
        Dim calif1, calif2, calif3, prom As Decimal
        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:::Airdel:::_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-")
        Console.WriteLine("Bienvenido, introduzca sus calificaciones
        Console.Write("Calificacion 1: ")
        calif1 = Console.ReadLine()
        Console.Write("Calificacion 2: ")
        calif2 = Console.ReadLine()
        Console.Write("Calificacion 3: ")
        calif3 = Console.ReadLine()
        prom = (calif1 + calif2 + calif3) / 3
        Console.WriteLine("Su promedio es: {0} ", prom)

    End Sub

End Module
