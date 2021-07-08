Module Module1

    Sub Main()
        Dim p As programa = New programa()
        Dim d As programa = New programa()
        Dim s As programa = New programa()


        p.Nombre = "Noticiero nocturno"
        p.Duracion = 1.4
        p.Clasificacion = "A"
        p.imprimeDatos()
        p.leeDatos()
        Console.WriteLine("Nombre del programa:" & p.Nombre)
        Console.WriteLine("Duracion: " & p.Duracion)
        Console.WriteLine("Clasificación: " & p.Clasificacion)
        Console.ReadLine()


        d.leeDatos()
        d.imprimeDatos()
        s.asignaDatos("Denébola", 4.45, "C")

        s.imprimeDatos()



        'ACTIVIDAD. agregar 2 objetos nuevos, uno de ellos leerlo con su correspondiente función (leeDatos)
        'y el segundo asignar los valores que tu quieras
        'imprimir ambos objetos


    End Sub

End Module

