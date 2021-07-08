Module Module1
    'PROYECTO:  empleadoClase
    'Programa para mostrar la forma de crear una clase, inicializarla y usarla

    'ARCHIVO:  Module1.vb

    Sub Main()
        'Creando un objeto e de la clase empleado (instanciación)
        Dim e As empleado
        e = New empleado

        'Inicializando empleando datos publicos
        e.numEmpleado = 0
        e.nomEmpleado = "Anita López del Toro"
        'e.Domicilio = "San Luis 344 nte"               'No se puede asignar ya que el dato es privado (hacer prueba quitando comentario)

        'Imprimiendo el contenido del objeto
        Console.WriteLine("Datos Iniciales del Empleado")
        Console.WriteLine("Numero: " & e.numEmpleado)
        Console.WriteLine("Nombre: " & e.nomEmpleado)
        Console.WriteLine("Domicilio: " & e.Domicilio)
        Console.WriteLine("Codigo Postal: " & e.CP)
        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()


        'Asignando valores empleando las funciones miembro (Propiedades-Property)
        e.Numero = 1
        e.Nombre = "Juan Pérez"
        e.Domicilio = "México 233 nte"
        e.CP = "63000"
        'e.Sueldo = 12300.32   La propiedad Sueldo es de solo lectura


        'Imprimiendo el contenido del objeto, usando funciones miembro (propiedades)
        Console.WriteLine("Datos Modificados del Empleado")
        Console.WriteLine("Numero: " & e.Numero)
        Console.WriteLine("Nombre: " & e.Nombre)
        Console.WriteLine("Domicilio: " & e.Domicilio)
        Console.WriteLine("Codigo Postal: " & e.CP)
        Console.WriteLine("Pulsa Enter para continuar...")
        Console.ReadLine()

    End Sub

End Module
