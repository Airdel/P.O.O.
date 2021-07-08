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
	nomPersona  =  nom
	edadPersona =  edad
	domPersona  =  dom
End sub

Public Sub AsignaDatos(ByVal nom As String, ByVal edad As Integer, ByVal dom As String)
	nomPersona  =  nom
	edadPersona =  edad
	domPersona  =  dom
End sub

Public sub Lectura()
	Console.WriteLine("Introduzca los siguientes datos.")
	Console.Write("   Nombre: ")
	nomPersona = Console.ReadLine()
	Console.Write("     Edad: ")
	edadPersona = Console.ReadLine()
	Console.Write("Domicilio: ")
	domPersona = COnsole.ReadLine()
End Sub

Public sub Impresion()
	Console.WriteLine("-------|Datos|-------")
	Console.WriteLine("")
	Console.WriteLine("   Nombre: ", nomPersona)
	Console.WriteLine("     Edad: ", edadPersona)
	Console.WriteLine("Domicilio: ", domPersona)
	Console.ReadKey()
End Sub

End Class

Public Class Maestro : inherits Persona

Protected idMaestro As String
Public antiguedad As Double
Public Fecha_ing As Date
Public materia As String

REM ----------------

Public Sub New()
Public Sub New(Argumentado)
Lectura()
Impresion()
Asignacion()




