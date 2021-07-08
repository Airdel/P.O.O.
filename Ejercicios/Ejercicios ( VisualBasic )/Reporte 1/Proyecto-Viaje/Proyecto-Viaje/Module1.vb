Module Module1

    Sub Main()
        'Declaracion:
        Dim nombre As String
        Dim nacionalidad As String
        Dim nacimiento As Date
        Dim destino As String
        Dim Redondo As String
        'Lectura
        Console.Write("Introduzca su nombre: ")
        nombre = Console.ReadLine()
        Console.Write("Introduzca su nacionalidad: ")
        nacionalidad = Console.ReadLine()
        Console.Write("Introduzca su fecha de nacimiento: ")
        nacimiento = Console.ReadLine()
        Console.Write("Introduzca su destino: ")
        destino = Console.ReadLine()
        Console.Write("¿Su viaje es redondo?")
        Redondo = Console.ReadLine()
        ' Impresion
        Console.WriteLine("El Sr(a) {0} Viajara a: {1}", nombre, destino)
        Console.ReadLine()
    End Sub

End Module
