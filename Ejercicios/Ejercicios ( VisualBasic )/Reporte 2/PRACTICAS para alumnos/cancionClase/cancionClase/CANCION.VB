Public Class cancion

    'Datos miembro
    Private nomCancion As String
    Private durCancion As Single
    Private fechaGrabacion As Date
    Private GenCancion As Char
    'Declarar los miembros restantes
    'Nombre del interprete de tipo cadena 
    'Tipo de cancion (tipo caracter):  (P)op   (R)ock  (B)anda   (N)orteño  (O)tro


    'Propiedades (funciones para asignar y regresar los valores)
    Public Property Nombre As String
        Get
            Return nomCancion
        End Get
        Set(value As String)
            nomCancion = value
        End Set
    End Property

    Public Property Duracion As Single
        Get
            Return durCancion
        End Get
        Set(value As Single)
            durCancion = value
        End Set
    End Property
    
    Public Property Genero As Char
        Get
            Return GenCancion
        End Get
        Set(value As Char)
            GenCancion = value
        End Set
    End Property
    
    Public Property Fecha As Date
        Get 
            Return fechaGrabacion
        End Get
        Set
            fechaGrabacion = value
        End Set
    end Property
    
    '...Terminar las propiedades restantes

    Public Sub imprimeDatos()
        fechaGrabacion = "12/12/2018"
        MsgBox("Nombre: '" & Nombre & "'" & vbCrLf & "Duracion: " & Duracion & vbCrLf & fechaGrabacion)
        Console.WriteLine("Nombre: " & Nombre)
        Console.WriteLine("Duración: " & Duracion)
        Console.Writeline("Tipo/Genero: ", +GenCancion)
        MsgBox("Acotaciones de generos: P = pop | R = rock | B = Banda | N = Norteño | O = Otros.  ". MsgBoxStyle.Information)
        Console.WriteLine("Fecha de grabación: " & Fecha)
        '...Terminar los datos restantes
    End Sub

    Public Sub leeDatos()
        Console.WriteLine("Como se llama la canción? ")
        Nombre = Console.ReadLine()
        Console.WriteLine("Que duración tiene? ")
        Duracion = Console.ReadLine()
        Console.Writeline("Que genero es? ")
        Genero = Console.ReadLine()
        Console.Writeline("Cual es su fecha de grabacion? ")
        Fecha = Console.ReadLine()
        
        
        '...Terminar las líneas restantes

    End Sub

End Class
