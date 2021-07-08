Module Module1
    'PROYECTO:  adivinaPalabra
    'Programa para mostrar el uso de los ciclos

    Sub Main()
        Dim palabra As String = "no lo se"
        Dim intentos As Byte = 0


        While (palabra <> "CLAVE" And intentos < 3)
            Console.WriteLine("Adivina la palabra secreta para salir")
            palabra = Console.ReadLine()
            intentos += 1       'empleando el operador suma mas asignación
            If (intentos = 3) Then
                Console.WriteLine("Ha superado el número máximo de intentos")
                Exit While      'La palabra Exit While saca del ciclo While
            End If
        End While

       
        Console.ReadLine()
    End Sub

End Module
