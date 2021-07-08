Module Module1

    Sub Main()
        Dim Valor As Integer
        Console.WriteLine("Introducir un número")
        Valor = Console.ReadLine()
        Select Case Valor
            Case 5
                Console.WriteLine("El valor es 5")
            Case 120, 250
                Console.WriteLine("El valor es 120 ó 250")
            Case 3000 To 4000
                Console.WriteLine("El valor está en el rango de 3000 a 4000")
            Case Is < 10
                Console.WriteLine("El valor es menor de 10")
            Case Else
                Console.WriteLine("El valor es {0}, y no se cumple ningún caso", Valor)
        End Select
        Console.ReadLine()
    End Sub

End Module
