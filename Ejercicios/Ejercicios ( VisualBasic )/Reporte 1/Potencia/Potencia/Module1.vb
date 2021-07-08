Module Module1

    Sub Main()
        'Proyecto potenciacion
        Console.Title = "Potencias"
        Dim num, pot, total As Integer
        Console.WriteLine("Bienvenido, introduzca el numero a elevar")
        Console.Write("Numero: ")
        num = Console.ReadLine()
        Console.WriteLine("Introduzca ahora su potencia")
        Console.Write("Potencia: ")
        pot = Console.ReadLine()
        total = num ^ pot
        Console.WriteLine("Su resultado es:{0}", total)
        Console.Write("Introduzca cualquier tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
