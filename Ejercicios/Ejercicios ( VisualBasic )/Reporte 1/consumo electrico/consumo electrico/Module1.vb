Module Module1

    Sub Main()
        Console.Title = "Consumo electrico"
        Dim consumo, consumo2, consumo3 As Integer
        Dim total As Integer


        Console.WriteLine("-.-.-.-.-.-.-.-Brownot electric Co.")
        Console.WriteLine("Bienvenido, por favor introduzca su consumo electrico anterior (En Kilowats)")
        Console.Write("Kilowatts:")
        consumo = Console.ReadLine()
        Console.WriteLine("Introdusca su consumo actual")
        Console.Write("Kilowatts:")
        consumo2 = Console.ReadLine()
        If (consumo > consumo2) Then

            consumo3 = consumo - consumo2
            If (consumo3 > 0 And consumo3 <= 1000) Then
                total = consumo3 * 25
                Console.WriteLine("Su total a pagar es: {0} ", total)
            Else
                total = consumo3 * 30
                Console.WriteLine("Su total a pagar es: {0} ", total)
            End If
        Else
            consumo3 = consumo2 - consumo
            If (consumo3 > 0 And consumo3 <= 1000) Then
                total = consumo3 * 0.25
                Console.WriteLine("Su total a pagar es: {0} ", total)
            Else
                total = consumo3 * 0.3
                Console.WriteLine("Su total a pagar es: {0} ", total)
            End If
            Console.WriteLine("Presione cualquier tecla para continuar, gracias. :D")
            Console.WriteLine("Brownot electric Co.-.-.-.-.-.-.-.-")
            Console.ReadKey()
        End If


    End Sub

End Module
