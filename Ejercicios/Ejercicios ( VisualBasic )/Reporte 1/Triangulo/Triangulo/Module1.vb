Module Module1

    Sub Main()
        Dim base, altura, area As Decimal
        Console.Write("Introduce el valor de la base: ")
        base = Console.ReadLine()
        Console.Write("Introduce el valor de la altura: ")
        altura = Console.ReadLine()
        area = (base * altura) / 2
        Console.WriteLine("El area es: {0}", area)
        Console.ReadKey()
    End Sub

End Module
