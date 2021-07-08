Module Module1

    Sub Main()
        Console.Title = "Atlet-pro"
        Console.WriteLine("Bienvenido a atletic systems")
        Console.WriteLine("Inicializando...")
        Dim meta, data, acum As Integer
        data = 0
        Console.WriteLine("Presiona cualquier tecla para continuar")
        Console.ReadKey(1)
        Console.Clear()
        Console.WriteLine("Hola, introduce tu meta a lograr")
        Console.Write("Distancia: ")
        meta = Console.ReadLine()
        Console.WriteLine("Genial, introduce cualquier tecla para iniciar")
        Console.ReadKey()
        Console.Clear()
        While (data < meta)
            Console.WriteLine("Introduce tus kilometros de hoy")
            Console.Write("Km recorridos: ")
            acum = Console.ReadLine()
            data = data + acum
            If (data >= meta) Then
                Console.WriteLine("Genial, has logrado tu meta.")
                Console.WriteLine("Gracias por usar Atletic Systems, presione cualquier tecla para continuar")
                Console.ReadKey()
            Else
                Console.WriteLine("Tu puedes, Que Denébola te ilumine")
                Console.ReadKey()
                Console.Clear()
            End If

        End While

    End Sub
End Module
