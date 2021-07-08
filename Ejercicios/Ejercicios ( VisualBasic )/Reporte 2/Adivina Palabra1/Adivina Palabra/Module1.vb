Module Module1
    'PROYECTO:  adivinaPalabra
    'Programa para mostrar el uso de los ciclos
    'Actividad: Migrarlo a la version "Do While Loop"

    Sub Main()
        Dim palabra As String = "Denébola"
        Dim intentos As Byte = 0
        Console.Title = "Que Denébola te ilumine"

        Console.WriteLine("¡Adivina la palabra y gana, UN AUUUTO! :D")
        Do
            Console.WriteLine("                -Adivina adivinador-")
            Console.WriteLine("Numero de intentos: {0}", intentos)
            palabra = Console.ReadLine()
            intentos += 1
            Console.Clear()
                If (palabra = "Askella") Then
                    Console.WriteLine("Yeah, lo has conseguido")
                    Exit Do
            End If
            If (intentos = 3) Then
                Console.WriteLine("Ha superado el número máximo de intentos, suerte para la proxima. c:")
                Exit Do
            End If
        Loop While (palabra <> "Askella" And intentos < 3)


        Console.ReadLine()
    End Sub

End Module
