Public Class Alumno

    'DATOS MIEMBRO
    Private psNombre As String
    Private psMatricula As String
    Private pcGrupo As Char
    Private pdMatematicas As Double
    Private pdQuimica As Double
    Private pdIngles As Double

    'USO DE PROPIEDADES PARA ASIGNAR Y REGRESAR LOS VALORES DE LOS DATOS MIEMBRO
    Public Property Nombre() As String
        Get
            Return psNombre.ToUpper
        End Get
        Set(ByVal value As String)
            psNombre = value
        End Set
    End Property

    Public Property Matricula() As String
        Get
            Return psMatricula
        End Get
        Set(ByVal value As String)
            psMatricula = value
        End Set
    End Property

    Public Property Grupo() As Char
        Get
            Return pcGrupo
        End Get
        Set(ByVal value As Char)
            pcGrupo = value
        End Set
    End Property

    Public Property Matematicas() As Double
        Get
            Return pdMatematicas
        End Get
        Set(ByVal value As Double)
            If (value >= 0 And value <= 10) Then
                pdMatematicas = value
            Else
                pdMatematicas = 0
            End If

        End Set
    End Property

    Public Property Quimica() As Double
        Get
            Return pdQuimica

        End Get
        Set(ByVal value As Double)
            If (value >= 0 And value <= 10) Then
                pdQuimica = value
            Else
                pdQuimica = 0
            End If

        End Set
    End Property

    Public Property Ingles() As Double
        Get
            Return pdIngles
        End Get
        Set(ByVal value As Double)
            If (value >= 0 And value <= 10) Then
                pdIngles = value
            Else
                pdIngles = 0
            End If

        End Set
    End Property

    'Propiedad virtual de solo lectura , el usuario no puede manipular el promedio
    Public ReadOnly Property Promedio() As Double
        Get
            Return (pdMatematicas + pdIngles + pdQuimica) / 3
        End Get

    End Property


    'METODOS

    'CONSTRUCTOR
    Public Sub New()
        Nombre = "YOMERO ESTUDIANTE"
        Matricula = "00000000"
        Matematicas = Quimica = Ingles = 0
        Grupo = "I"

    End Sub

    'CONSTRUCTOR CON ARGUMENTOS (PARAMETRIZADO)
    Public Sub New(ByVal nom As String, ByVal mat As String, ByVal gpo As Char, _
                            ByVal mate As Double, ByVal quim As Double, ByVal ing As Double)
        asignarDatos(nom, mat, gpo, mate, quim, ing)
    End Sub

    'SUBRUTINA DE IMPRESION
    Public Sub imprimirDatos()
        Console.WriteLine("Alumno " & Nombre)
        Console.WriteLine("Matricula: " & Matricula)
        Console.WriteLine("Grupo: " & Grupo)
        Console.WriteLine("Matemáticas: " & Matematicas)
        Console.WriteLine("Química: " & Quimica)
        Console.WriteLine("Inglés: " & Ingles)
        Console.WriteLine("Promedio: {0:2c}", Promedio)
    End Sub

    'SUBRUTINA PARA ASIGNAR DATOS
    Public Sub asignarDatos(ByVal nom As String, ByVal mat As String, ByVal gpo As Char, _
                            ByVal mate As Double, ByVal quim As Double, ByVal ing As Double)
        Nombre = UCase(nom)
        Matricula = UCase(mat)
        Grupo = UCase(gpo)
        'completar las validaciones
        If (mate >= 0 And mate <= 10) Then Matematicas = mate Else Matematicas = 0
        Quimica = quim
        Ingles = ing
    End Sub

    'SUBRUTINA PARA LEER DATOS
    Public Sub leerDatos()

        Console.WriteLine("Datos del alumno")
        Console.Write("Nombre: ")
        Nombre = Console.ReadLine()
        Console.Write("Matricula: ")
        Matricula = Console.ReadLine()
        Console.Write("Calificación de Matemáticas: ")
        Matematicas = Console.ReadLine()
        Console.Write("Calificación de Inglés: ")
        Ingles = Console.ReadLine()
        Console.Write("Calificación de Química: ")
        Quimica = Console.ReadLine()

    End Sub

End Class

' SSD = +velocidad And +Precio And -capacidad
' HDD = -velocidad And -Precio And +capacidad