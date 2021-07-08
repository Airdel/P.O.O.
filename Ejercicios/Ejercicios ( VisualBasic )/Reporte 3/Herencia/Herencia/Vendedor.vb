Public Class Vendedor : Inherits Empleado
    Private ventasV As Double
    Private comisionV As Double
    Public Property Ventas As Double
        Get
            Return ventasV
        End Get
        Set(ByVal value As Double)
            ventasV = value
        End Set
    End Property
    Public Property Comision As Double
        Get
            Return comisionV
        End Get
        Set(ByVal value As Double)
            comisionV = value
        End Set
    End Property
    Public Sub New()
        MyBase.New()
        Ventas = 0
        Comision = 0.1
    End Sub
    Public Sub New(ByVal nom As String, ByVal puest As String, ByVal suel As String, ByVal ven As Double, ByVal com As Double)
        MyBase.New(nom, puest, suel)
        Ventas = ven
        Comision = com
    End Sub
    Public Overloads Sub Imprime()
        MyBase.ImprimeDatos()
        Console.WriteLine("Ventas: " & Ventas)
        Console.WriteLine("Comisión: " & Comision)
    End Sub
    Public Sub recalculaSueldo(ByVal vtas As Double, ByVal porcentaje As Double)
        Ventas = vtas
        Comision = Ventas * (porcentaje / 100)
        sueldo = sueldo + Comision
    End Sub
End Class
