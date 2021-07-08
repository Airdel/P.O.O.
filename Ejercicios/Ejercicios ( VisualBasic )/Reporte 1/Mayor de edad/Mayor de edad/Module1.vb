Module Module1

    Sub Main()
        Dim edad As Integer
        Console.Title = "Mayor de edad- Programa"
        Console.WriteLine("Bienvenido, por favor introduzca su edad")
        Console.Write("Edad: ")
        edad = Console.ReadLine()
        If (edad >= 18) Then
            Console.WriteLine("Mayor de edad, su edad es de: {0}", edad)
        Else
            Console.WriteLine("Menor de edad, su edad es de {0}", edad)
            Console.ReadKey()
        End If
    End Sub

End Module
