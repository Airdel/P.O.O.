Module Module1

    Sub Main()
        Dim num1 As Double
        Dim num2 As Double

        Console.Title = "Programa, operadores aritmeticos"
        Console.Write("Introduce el primer valor: ")
        num1 = Console.ReadLine()
        Console.Write("Introduce el segundo valor: ")
        num2 = Console.ReadLine()
        Console.WriteLine("La suma de {0} más {1} es igual a {2}", num1, num2, num1 + num2)
        Console.WriteLine("La resta de {0} menos {1} es igual a {2}", num1, num2, num1 - num2)
        Console.WriteLine("La multiplicacion de {0} por {1} es igual a {2}", num1, num2, num1 * num2)
        Console.WriteLine("La division de {0} entre {1} es igual a {2}", num1, num2, num1 / num2)
        Console.WriteLine("La potenciacion de {0} a la {1} es igual a {2}", num1, num2, num1 ^ num2)
        Console.WriteLine("El residuo de {0} entre {1} es igual a {2}", num1, num2, num1 Mod num2)
        Console.WriteLine("El numero {0} desplazado {1} veces a la derecha es: {2}", num1, num2, num1 >> num2)
        Console.WriteLine("El numero {0} desplazado {1} veces a la izquierda es: {2}", num1, num2, num1 << num2)
        Console.ReadKey()
    End Sub

End Module
