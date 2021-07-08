Module Module1

    Sub Main()
        Console.Title = "Declaración de Variables"
        'Declaración de variables
        Dim nombre As String
        Dim edad As SByte
        Dim fecha As Date
        'Inicialización
        nombre = "Airdel"
        edad = 16
        fecha = "06/08/1999"

        'Impresión de Valores (Metodo 1)
        Console.WriteLine("el nombre es: " & nombre)
        Console.WriteLine("La edad es: " & edad)
        Console.WriteLine("La fecha es: " & fecha)
        'Metodo 2
        Console.WriteLine("El nombre es: {0}", nombre)
        Console.WriteLine("La edad es: {0}", edad)
        Console.WriteLine("La fecha es: {0}", fecha)
        Console.ReadLine()
        'Imprimir Oraciones
        'cadena: |Airdel| tiene |16| años
        Console.WriteLine("{0} tiene {1} años", nombre, edad)
        Console.ReadLine() 'Pausa



    End Sub

End Module
