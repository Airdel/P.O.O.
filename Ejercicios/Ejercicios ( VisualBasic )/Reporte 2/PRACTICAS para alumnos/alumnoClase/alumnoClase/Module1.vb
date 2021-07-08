Module Module1

    'PROYECTO:  ALUMNO
    'Programa para mostrar el uso de una clase
    'Contiene funciones propiedad, constructores (default, c/argumento), func. impresion, asignacion y lectura
    Sub Pausa()
        Console.Write("Pulsa Enter para continuar...")
        Console.ReadLine()
        Console.Clear()
    End Sub
    Sub Main()
        Dim a As Alumno     'Se crea una instancia de la clase Alumno

        a = New Alumno()    'Se crea espacio para la instancia

        'ASIGNANDO DE FORMA INDIVIDUAL (empleando las propiedades) 
        a.Nombre = "Pancho López"
        a.Matricula = "01690001"
        a.Grupo = "A"
        a.Matematicas = 9.3
        a.Quimica = 8.34
        a.Ingles = 7.4

        'IMPRIMIENDO DE FORMA INDIVIDUAL (empleado las propiedades)
        Console.WriteLine("Alumno " & a.Nombre)
        Console.WriteLine("Matricula: " & a.Matricula)
        Console.WriteLine("Grupo: " & a.Grupo)
        Console.WriteLine("Matemáticas: " & a.Matematicas)
        Console.WriteLine("Química: " & a.Quimica)
        Console.WriteLine("Inglés: " & a.Ingles)
        Console.WriteLine("Promedio: {0:0.00}", a.Promedio)
        Pausa()

        'ASIGNANDO E IMPRIMIENDO (empleando los metodos)
        a.asignarDatos("Ana del Aire", "01169001", "Z", 12, 6.7, 9.2)
        a.imprimirDatos()
        Pausa()

        a.leerDatos()
        Console.Clear()
        a.imprimirDatos()
        Pausa()


        With a
            .asignarDatos("Dolores Uribe", "08080801", "x", 10, 9.2, 8)
            .imprimirDatos()
            Pausa()
        End With


        Dim b As Alumno = New Alumno()
        b.imprimirDatos()
        Pausa()

        Dim c As Alumno = New Alumno("ALBERTO DE LLANO", "2222222", "C", 10, 10, 10)
        c.imprimirDatos()
        Pausa()

    End Sub

End Module
