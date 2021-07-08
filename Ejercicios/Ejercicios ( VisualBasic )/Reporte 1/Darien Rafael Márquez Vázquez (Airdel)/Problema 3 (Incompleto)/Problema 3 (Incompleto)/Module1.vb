Module Module1

    Sub Main()
        Dim base, numero, numero1, factorial As Long
        Console.WriteLine("Aplicacion factorial")
        Console.WriteLine("Introduzca su numero:")
        numero = Console.ReadLine()
        base = numero
        While numero > 0 And numero <= base
            factorial = base * numero
            numero1 = factorial
            numero = numero - 1
        End While
        Console.WriteLine("El factorial es: {0}", factorial)
        Console.ReadKey()
    End Sub

End Module
