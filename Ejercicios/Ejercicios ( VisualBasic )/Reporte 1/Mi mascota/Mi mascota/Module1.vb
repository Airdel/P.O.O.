Module Module1
    'Cadena: Mi mascota |firulais| come cada semana |5 kg| de |croquetas|
    Sub Main()
        Console.Title = "Mi mascota"
        'Declaracion
        Dim nombre As String
        Dim cantidad As Decimal
        Dim comida As String
        'Inicializacion
        nombre = "Ringo"
        cantidad = 2
        comida = "Croquetas"
        'impresion
        Console.WriteLine("Mi mascota {0} come cada semana {1}kg de {2}", nombre, cantidad, comida)
        Console.ReadLine()
    End Sub

End Module
