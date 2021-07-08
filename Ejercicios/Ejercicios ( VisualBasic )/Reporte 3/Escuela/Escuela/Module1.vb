Module Module1

    Sub Main()
        Dim m(5) As Maestro
        m(0) = New Maestro("Juan Perez", 29, "Calle 8  #30", 100, 6, "1 / 1 / 2010", "Fisica")
        m(1) = New Maestro("Lucia Diaz", 35, "Av. Mexico #30 Sur", 101, 5, "5 / 2 / 2011", "Matematicas")
        m(2) = New Maestro("Santos Hdez", 51, "San Luis #400 Norte", 102, 10, "2 / 5 / 2006", "Inglés")
        m(3) = New Maestro("Enrique Chavéz", 32, "P.Sanchez 18", 103, 2, "8 / 9 / 2013", "Química")
        m(4) = New Maestro("Olegario Tapia", 26, "Calle Ave #35", 104, 1, "2 / 2 / 2013", "Educación Fisica")
        m(5) = New Maestro("Alexandra Canales", 38, "Calle 7 #25", 105, 10, "3 / 7 / 2006", "Civismo")

        Dim X As Byte
        For X = 0 To 5
            m(X).impresion()
        Next
        Console.ReadKey()
    End Sub

End Module

Public Class Persona

    Public nomPersona As String
    Public edadPersona As Integer
    Protected domPersona As String

    REM -------------------

    Public Sub New()
        nomPersona = "Airdel"
        edadPersona = 16
        domPersona = "Av.Denébola #512"
    End Sub

    Public Sub New(ByVal nom As String, ByVal edad As Integer, ByVal dom As String)
        nomPersona = nom
        edadPersona = edad
        domPersona = dom
    End Sub

    Public Overridable Sub AsignaDatos(ByVal nom As String, ByVal edad As Integer, ByVal dom As String)
        nomPersona = nom
        edadPersona = edad
        domPersona = dom
    End Sub

    Public Overridable Sub Lectura()
        Console.WriteLine("Introduzca los siguientes datos.")
        Console.Write("   Nombre: ")
        nomPersona = Console.ReadLine()
        Console.Write("     Edad: ")
        edadPersona = Console.ReadLine()
        Console.Write("Domicilio: ")
        domPersona = Console.ReadLine()

    End Sub

    Public Overridable Sub Impresion()
        Console.WriteLine("   Nombre: " & nomPersona)
        Console.WriteLine("     Edad: " & edadPersona)
        Console.WriteLine("Domicilio: " & domPersona)
    End Sub

End Class

Public Class Maestro : Inherits Persona

    Protected idMaestro As String
    Public antiguedad As Double
    Public Fecha_ing As Date
    Public materia As String

    REM ----------------

    Public Sub New()
        MyBase.New()
        idMaestro = "18dooo9pde"
        antiguedad = 12
        Fecha_ing = Date.FromOADate(5 / 12 / 2005)
        materia = "Fisica"
    End Sub

    Public Sub New(ByVal nomP As String, ByVal edadP As Integer, ByVal domP As String, ByVal iDM As String, ByVal antiM As Double, ByVal FechaIDM As Date, ByVal matM As String)
        MyBase.New(nomP, edadP, domP)
        idMaestro = iDM
        antiguedad = antiM
        Fecha_ing = FechaIDM
        materia = matM
    End Sub
    Public Overrides Sub Lectura()
        MyBase.Lectura()

        Console.WriteLine("--------Inserte los datos---------")
        Console.Write("   ID de maestro: ")
        idMaestro = Console.ReadLine()
        Console.Write("      Antiguedad: ")
        antiguedad = Console.ReadLine()
        Console.Write("Fecha de ingreso: ")
        Fecha_ing = Console.ReadLine()
        Console.Write("         Materia: ")
        materia = Console.ReadLine()
    End Sub

    Public Overrides Sub impresion()
        MyBase.Impresion()
        Console.WriteLine("Datos del Maestro" & vbCrLf)
        Console.WriteLine("ID del Maestro: " & idMaestro)
        Console.WriteLine("    Antiguedad: " & antiguedad)
        Console.WriteLine("Fecha de Ingreso:" & Fecha_ing)
        Console.WriteLine("         Materia:" & materia & vbCrLf & "-------------" & vbCrLf)

    End Sub
    Public Overloads Sub AsignaDatos(ByVal nomP As String, ByVal edadP As Integer, ByVal domP As String, ByVal iDM As String, ByVal antiM As Double, ByVal FechaIDM As Date, ByVal matM As String)
        MyBase.AsignaDatos(nomP, edadP, domP)
        idMaestro = iDM
        antiguedad = antiM
        Fecha_ing = FechaIDM
        materia = matM
    End Sub


End Class

