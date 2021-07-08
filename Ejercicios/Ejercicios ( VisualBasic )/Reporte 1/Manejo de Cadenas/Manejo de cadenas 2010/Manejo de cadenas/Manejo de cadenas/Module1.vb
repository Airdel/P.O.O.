Module Module1

    Sub Main()
        'Proyecto: Operadores manejo de cadenas

        Console.Title = "Manejo de Cadenas"
        Console.WriteLine("Operadores Relacionales")
        Console.WriteLine("resultado A = a ---> {0}", "A" = "a")
        Console.WriteLine("resultado M < Z ---> {0}", "M" < "Z")
        Console.WriteLine("resultado M > m ---> {0}", "M" > "m")
        Console.WriteLine("resultado F <> f ---> {0}", "F" <> "f")
        Console.ReadKey(True)
        'Actividad cambiar caracteres con tu nombre
        Console.Clear()
        Console.Write(Asc("D"))
        Console.Write("-")
        Console.Write(Asc("a"))
        Console.Write("-")
        Console.Write(Asc("r"))
        Console.Write("-")
        Console.Write(Asc("i"))
        Console.Write("-")
        Console.Write(Asc("e"))
        Console.Write("-")
        Console.Write(Asc("n."))
        Console.Write(".  ")
        Console.WriteLine("Cadena codificada: Darien")
        'Mensaje Secreto
        Console.Write(Chr(81))
        Console.Write(Chr(117))
        Console.Write(Chr(101))
        Console.Write(Chr(32))
        Console.Write(Chr(68))
        Console.Write(Chr(101))
        Console.Write(Chr(110))
        Console.Write(Chr(101))
        Console.Write(Chr(98))
        Console.Write(Chr(111))
        Console.Write(Chr(108))
        Console.Write(Chr(97))
        Console.Write(Chr(32))
        Console.Write(Chr(84))
        Console.Write(Chr(101))
        Console.Write(Chr(32))
        Console.Write(Chr(73))
        Console.Write(Chr(108))
        Console.Write(Chr(117))
        Console.Write(Chr(109))
        Console.Write(Chr(105))
        Console.Write(Chr(110))
        Console.WriteLine(Chr(101))
        Console.WriteLine(" ")

        Console.ReadKey(True)
        Console.WriteLine("comodines Like")
        'El like :v
        Console.WriteLine("Pato" Like "Paty")
        Console.WriteLine("Cuantico" Like "Cuantico")
        Console.WriteLine("android" Like "androide")
        Console.WriteLine("Microsoft" Like "Apple")
        Console.ReadKey()
    End Sub

End Module

