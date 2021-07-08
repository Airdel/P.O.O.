Public Class Empleado
    Protected nomEmp As String
    Protected puestoEmp As String
    Protected sueldoEmp As Double
    Public Property Nombre As String
        Get
            Return nomEmp
        End Get
        Set(ByVal value As String)
            nomEmp = value
        End Set
    End Property
    Public Property puesto As String
        Get
            Return puestoEmp
        End Get
        Set(ByVal value As String)
            puestoEmp = value
        End Set
    End Property
    Public Property sueldo As Double
        Get
            Return sueldoEmp
        End Get
        Set(ByVal value As Double)
            sueldoEmp = value
        End Set
    End Property
    Public Sub CalculaSueldo(ByVal s As Double)
        sueldo = s
    End Sub
    Public Sub New()
        Nombre = "Airdel"
        puesto = "Developer"
        sueldo = 2000.6
    End Sub
    Public Sub New(ByVal nom As String, ByVal puest As String, ByVal suel As Double)
        Nombre = nom
        puesto = puest
        sueldo = suel
    End Sub

    Public Sub New(ByVal copi As Empleado)
        Nombre = copi.Nombre
        sueldo = copi.sueldo
        puesto = copi.puesto
    End Sub

    Public Sub AsignaDatos(ByVal nom As String, ByVal puest As String, ByVal suel As Double)
        Nombre = nom
        puesto = puest
        sueldo = suel
    End Sub

    Public Sub ImprimeDatos()
        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Puesto: " & puesto)
        Console.WriteLine("Sueldo: " & sueldo)
    End Sub
End Class
