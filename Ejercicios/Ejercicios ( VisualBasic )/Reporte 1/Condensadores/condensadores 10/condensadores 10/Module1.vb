
Module Module1

    Sub Main()
        Console.Title = "Condensadores"
        Dim con1, con2, con3, con4, con5, con6, con7, conT As Decimal
        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-:Airdel Software: _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-")
        Console.WriteLine("Bienvenido, por favor introduzca los datos de capacidad de los condensadores")
        Console.Write("Condensador 1°: ")
        con1 = Console.ReadLine()
        Console.Write("Condensador 2°: ")
        con2 = Console.ReadLine()
        Console.Write("Condensador 3°: ")
        con3 = Console.ReadLine()
        Console.Write("Condensador 4°: ")
        con4 = Console.ReadLine()
        Console.Write("Condensador 5°: ")
        con5 = Console.ReadLine()
        Console.Write("Condensador 6°: ")
        con6 = Console.ReadLine()
        Console.Write("Condensador 7: ")
        con7 = Console.ReadLine()
        Console.Clear()
        Console.WriteLine("Gracias, la capacidad total del sistema de condensadores es de: ")
        Console.WriteLine("Realizando calculos...")
        Console.ReadKey()
        Console.WriteLine("Ajustando Parámetros...")
        Console.ReadKey()
        Console.WriteLine("Ajustando tuercas...")
        Console.ReadKey()
        Console.WriteLine("Listo, presione cualquier tecla para continuar")
        conT = con1 + con2 + con3 + con4 + con5 + con6 + con7
        Console.ReadKey(True)
        Console.Clear()
        Console.WriteLine("Capacidad Total: {0}", conT)
        Console.WriteLine("Gracias por usar Airdel-systems, presione cualquier tecla para continuar. :)")
        Console.ReadKey()

    End Sub

End Module
