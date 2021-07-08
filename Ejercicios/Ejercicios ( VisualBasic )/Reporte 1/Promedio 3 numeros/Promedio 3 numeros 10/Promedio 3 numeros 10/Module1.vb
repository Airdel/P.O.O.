Module Module1

    Sub Main()
        Console.Title = "Promedio 3 numeros"
        Dim num1, num2, num3, prom As Decimal
        Console.WriteLine("Bienvenido, introduzca el primer numero")
        Console.Write("Numero 1: ")
        num1 = Console.ReadLine
        Console.Write("Numero 2: ")
        num2 = Console.ReadLine
        Console.Write("Numero 3: ")
        num3 = Console.ReadLine()
        prom = (num1 + num2 + num3) / 3
        Console.WriteLine("Su promedio es: {0}", prom)
        Console.ReadLine()
    End Sub

End Module