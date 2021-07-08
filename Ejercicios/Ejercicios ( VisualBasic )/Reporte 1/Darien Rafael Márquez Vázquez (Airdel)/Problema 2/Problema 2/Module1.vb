Module Module1

    Sub Main()
        Dim litros, tazas, galones As Double
        Console.Title = "Problema 2"
        Console.WriteLine("                      Bienvenido al sistema conversor EpOc")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("Por favor introduzca su medida en litros.")
        Console.Write("Litros: ")
        litros = Console.ReadLine()
        tazas = litros * 4.3
        galones = litros * 3.78
        Console.WriteLine("Su medida es equivalente a:")
        Console.WriteLine(" ")
        Console.WriteLine("{0} tazas.", tazas)
        Console.WriteLine("{0} galones.", galones)
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("           Gracias por usar EpOc, presione cualquier tecla para continuar.")
        Console.WriteLine("                                   -Ergo Cogito, ergo sum-")
        Console.ReadKey()
    End Sub

End Module
