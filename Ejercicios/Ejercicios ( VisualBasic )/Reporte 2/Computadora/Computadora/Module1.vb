Module Module1

    Sub Main()

        Dim pc As Computadora
        pc = New Computadora
        pc.ID = -100
        pc.marca = "Alienware"
        pc.modelo = "Corsair"
        pc.fecha = Now()
        pc.tipo = "Z"
        'Impresion
	Console.WriteLine("Clases computadora")
        Console.WriteLine("#ID de la computadora {0}", pc.ID)
        Console.WriteLine("Marca de la computadora: {0}", pc.marca)
        Console.WriteLine("Modelo de la computadora: {0}", pc.modelo)
        Console.WriteLine("Fecha de adquisición: {0}", pc.fecha)
        Console.WriteLine("Tipo de computadora: {0}", pc.tipo)
        Console.ReadKey()

    End Sub

End Module
