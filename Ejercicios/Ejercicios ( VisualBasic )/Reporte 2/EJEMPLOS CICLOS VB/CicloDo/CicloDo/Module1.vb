Module Module1
    'PROYECTO: CicloDo
    'Programa para mostrar el uso de los ciclos
    'ACTIVIDAD: Verificar en cada uso de ciclo su valor inicial, incremento y condicion
    '(anotar en el cuaderno de cada uno)


    Sub Main()
        Dim x As Integer

        x = 0

        Console.Title = "CICLO DO"

        'EJEMPLO 1
        Console.WriteLine("Ciclo While-End While ")
        x = 0
        While x < 3
            Console.WriteLine("x = " + x.ToString)
            x += 1
        End While

        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()


        'EJEMPLO 2
        Console.Clear()
        Console.WriteLine("Ciclo Do While-Loop ")
        x = 0
        Do While x < 3
            Console.WriteLine("x = " + x.ToString)
            x += 1
        Loop

        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()


        'EJEMPLO 3
        Console.Clear()
        Console.WriteLine("Ciclo do-loop while : ")
        x = 0
        Do
            Console.WriteLine("x = " + x.ToString)
            x += 1
        Loop While x < 3

        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()

        'EJEMPLO 4
        Console.Clear()
        Console.WriteLine("Ciclo do-loop Until ")
        x = 0
        Do
            Console.WriteLine("x = " + x.ToString)
            x += 1
        Loop Until x >= 3

        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()

        'EJEMPLO 5
        Console.Clear()
        Console.WriteLine("Ciclo Do Until-Loop ")
        x = 0
        Do Until x >= 3
            Console.WriteLine("x = " + x.ToString)
            x += 1
        Loop


        Console.ReadLine()
    End Sub

End Module
