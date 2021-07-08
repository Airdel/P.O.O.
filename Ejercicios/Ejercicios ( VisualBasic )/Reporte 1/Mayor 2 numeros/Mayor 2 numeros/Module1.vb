Module Module1

    Sub Main()
        Console.Title = "Mayor 2 numeros"
        Dim num1, num2 As Double
        Console.Write("Introduce un numero: ")
        num1 = Console.ReadLine()
        Console.Write("Introduce el segundo numero: ")
        num2 = Console.ReadLine()
        If (num1 > num2) Then
            Console.WriteLine("El primer numero es mayor: {0}", num1)
        Else
            Console.WriteLine("El segundo numero es mayor: {0}", num2)
        End If

        Console.ReadKey(True)
    End Sub

End Module
