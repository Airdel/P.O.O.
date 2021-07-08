Module Module1

    Sub Main()
        'Programa 1 (3 puntos)
        Dim nombre As String
        Dim fecha As Date
        Dim llamadas, saldo, recibo As Double
        Dim numero As Long
        Console.Title = "Problema 1"

        Console.WriteLine("Hola, bienvenido a Airdel Systems")
        Console.WriteLine("Por favor, introduzca su nombre.")
        Console.Write("Nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Hola, {0} introduzca su numero de recibo", nombre)
        Console.Write("Recibo: ")
        recibo = Console.ReadLine()
        Console.WriteLine("Genial, ahora introduzca su número de llamadas.")
        Console.WriteLine("Num. Llamadas: ")
        llamadas = Console.ReadLine()
        Console.WriteLine("Ahora introduzca su fecha de corte (Separada por guiones o diagonales)")
        Console.Write("Fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("Bien, ahora necesitamos su total a pagar")
        Console.Write("Saldo: ")
        saldo = Console.ReadLine()
        Console.WriteLine("Por ultimo, necesitamos su numero telefonico para aclaraciones (Sin separaciones).")
        Console.Write("Telefono: ")
        numero = Console.ReadLine()
        Console.WriteLine("Perfecto, presione cualquier tecla para generar su reporte.")
        Console.ReadKey()
        Console.Clear()

        Console.WriteLine("El cliente {0} tiene un saldo de: {1}.; Los detalles están en el recibo {2}", nombre, saldo, recibo)
        Console.WriteLine("emitido el {0}, tiene registradas {1} llamadas a sú número {2}", fecha, llamadas, numero)
        Console.WriteLine("Gracias por usar Airdel Systems, presione cualquier tecla para continuar.")
        Console.ReadKey()
    End Sub

End Module
