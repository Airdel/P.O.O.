Public Class programa
    'DATOS MIEMBRO
    Private nomPrograma As String
    Private durPrograma As Double
    Private clasPrograma As String

    'Clasificación TV. 
    'AA (Todo público, especialmente dirigido a público infantil, cualquier horario)
    'A  (Todo público, cualquier horario)
    'B  (12 años en adelante; desde las 16 horas).
    'B-15  (15 años en adelante y adultos; de las 19 a las 5:59 horas).
    'C  (Para adultos, de las 21 a las 5:59 horas).
    'D  (Exclusivamente adultos, de las 0 a las 5 horas.).
    'SC  (Sin clasificación, cualquier horario).

    'PROPIEDADES

    'ACTIVIDAD. Validar  para que devuelva el nombre del programa en mayúsculas
    Public Property Nombre As String
        Get
            Return nomPrograma.ToUpper
        End Get
        Set(ByVal value As String)
            nomPrograma = value
        End Set
    End Property


    'ACTIVIDAD. Validar la entrada para que la duración del programa no sea menor a 0
    'y no mayor a 60 minutos.
    Public Property Duracion As Double
        Get
            Return durPrograma
        End Get
        Set(ByVal value As Double)
            If (value <= 60 And value >= 0) Then
                durPrograma = value
            Else
                MsgBox("Duración no permitida")
                durPrograma = "30"
            End If
        End Set
    End Property


    'ACTIVIDAD. Validar para que la entrada sea solo de los valores válidos
    ' (ver valores parte superior)
   Public Property Clasificacion As String
        Get
            Return clasPrograma
        End Get
        Set(ByVal value As String)
            If value = "AA" Or value = "A" Or value = "B" Or value = "B-15" Or value = "C" Or value = "D" Or value = "SC" Then
                clasPrograma = value
            Else
                MsgBox("La clasificacion es incorrecta", MsgBoxStyle.Critical)
                clasPrograma = "SC"

            End If
        End Set
    End Property

    'FUNCIONES MIEMBRO

    Public Sub leeDatos()
        Console.WriteLine(" " & vbCrLf)
        Console.WriteLine("Bienvenido, introduzca los datos de su programa.")
        Console.Write("Nombre: ")
        Nombre = Console.ReadLine()
        Console.Write("Duración del programa: ")
        Duracion = Console.ReadLine()
        Console.Write("Clasificación: ")
        Clasificacion = Console.ReadLine()
    End Sub
    Public Sub imprimeDatos()

        Console.WriteLine("Nombre de su programa: " & Nombre)
        Console.WriteLine("Duración del programa: " & Duracion)
        Console.WriteLine("Clasificación del programa: " & Clasificacion & vbCrLf)
        Console.WriteLine(" " & vbCrLf)


    End Sub
    Public Sub asignaDatos(ByVal Nombre As String, ByVal Duracion As Double, ByVal Clasificacion As Char)
        Nombre = nomPrograma
        Duracion = durPrograma
        Clasificacion = clasPrograma

    End Sub

    'ACTIVIDADES. agregar las siguientes funciones:
    ' leeDatos -> leer todos los datos
    ' asignaDatos -> funcion para recibir todos los datos y guardarlos en sus atributos correspondientes
    ' imprimeDatos -> función para imprimir todos los datos

End Class
