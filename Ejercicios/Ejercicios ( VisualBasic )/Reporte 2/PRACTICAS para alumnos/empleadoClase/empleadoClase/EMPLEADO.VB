Public Class empleado

    'ARCHIVO: empleado.vb

    'Definición de la clase empleado
    'DATOS MIEMBRO
    Public numEmpleado As String    'Se definieron como publicos (no se debería hacer así)
    Public nomEmpleado As String
    Private domEmpleado As String   'Se definieron como privados (sería la forma común)
    Private CP_Empleado As String
    Private sueldoEmp As Double = 30000

    'INICIALIZACION 
    '(Creación de las Propiedades), sirven para asignar y devolver valores de la clase
    Public Property Numero As String
        Get
            Return numEmpleado
        End Get
        Set(value As String)
            numEmpleado = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nomEmpleado
        End Get
        Set(value As String)
            nomEmpleado = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return domEmpleado
        End Get
        Set(value As String)
            domEmpleado = value
        End Set
    End Property

    Public Property CP As String
        Get
            Return CP_Empleado
        End Get
        Set(value As String)
            CP_Empleado = value
        End Set
    End Property

    Public ReadOnly Property Sueldo As Double
        Get
            Return sueldoEmp
        End Get
    End Property

End Class
