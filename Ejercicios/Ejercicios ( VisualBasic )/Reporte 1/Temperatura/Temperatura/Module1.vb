Module Module1

    Sub Main()
        Dim celsius As Decimal
        Dim farenheit As Decimal
        Console.Title = "Termo-fisics Software"
        Console.WriteLine("Qué deseas convertir: ")
        Console.WriteLine("1.-Farenheit a celsius. (Presione 1)")
        Console.WriteLine("2.-Celsius a Farenheit. (Presione 2)")
        Console.Write("Introduzca su opción: ")
        If (Console.ReadLine() = 1) Then
            Console.Write("Introduzca su valor Farenheit: ")
            farenheit = Console.ReadLine()
            celsius = 5 / 9 * (farenheit - 32)
            Console.WriteLine(" {0} grados Farenheit es equivalente a: {1} grados Celsius", farenheit, celsius)
        Else
            Console.Write("Introduzca su valor Celsius: ")
            celsius = Console.ReadLine()
            farenheit = (9 / 5 * celsius) + 32
            Console.WriteLine(" {0} grados Celsius es equivalente a: {1} grados Farenheit", celsius, farenheit)
        End If
        Console.WriteLine("Gracias, presione cualquier tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
