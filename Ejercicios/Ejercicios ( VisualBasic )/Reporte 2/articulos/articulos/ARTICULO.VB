
Public Class articulo
    'DATOS MIEMBRO
    Private idArticulo As Integer
    Private nomArticulo As String
    Private cantArticulo As Integer
    Private precArticulo As Single

    Private Shared totalArticulos As Integer = 0

    'PROPIEDADES
    Public Property Numero As Integer
        Get
            Return idArticulo
        End Get

        Set(value As Integer)
            idArticulo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return nomArticulo
        End Get
        Set(value As String)
            nomArticulo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return cantArticulo
        End Get
        Set(value As Integer)
            cantArticulo = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return precArticulo
        End Get
        Set(value As Integer)
            precArticulo = value
        End Set
    End Property

    Public Property TotArticulos As Integer
        Get
            Return totalArticulos
        End Get
        Set(value As Integer)
            totalArticulos = value
        End Set
    End Property


    'CONSTRUCTORES
    Public Sub New()
        Numero = 0
        Nombre = "Articulo generico"
        Precio = 0
        Cantidad = 0
        TotArticulos += 1
    End Sub

    Public Sub New(ByVal idArt As Integer, ByVal nomArt As String, ByVal cantArt As Integer, ByVal precArt As Single)
        Numero = idArt
        Nombre = nomArt
        Precio = precArt
        Cantidad = cantArt
        TotArticulos += 1
    End Sub


    Public Function buscaNumero(ByVal num As Integer) As Boolean
        If (Numero = num) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub leeNumeroEntero(ByRef entero As Integer, Optional ByVal msje As String = "Introduce un valor entero:", Optional ByVal rango1 As Integer = 0, Optional ByVal rango2 As Integer = 100)
        Do
            Console.Write(msje)
            entero = Console.ReadLine()
            If entero < rango1 Or entero > rango2 Then
                Console.WriteLine("Error, valor fuera de rango (min-" & rango1 & " max-" & rango2 & "). Intente de nuevo...")
            End If
        Loop Until entero >= rango1 And entero <= rango2
    End Sub


    Private Sub leeNumeroFlotante(ByRef flotante As Double, Optional ByVal msje As String = "Introduce un valor decimal:", Optional ByVal rango1 As Double = 0, Optional ByVal rango2 As Double = 100)
        Do
            Console.Write(msje)
            flotante = Console.ReadLine()
            If flotante < rango1 Or flotante > rango2 Then
                Console.WriteLine("Error, valor fuera de rango (min--->" & rango1 & " max--->" & rango2 & "). Intente de nuevo...")
            End If
        Loop Until flotante >= rango1 And flotante <= rango2
    End Sub


    Public Sub lectura()
        Console.WriteLine("Datos del artículo")
        leeNumeroEntero(Numero, "#id del artículo: ")
        Console.Write("Nombre: ")
        Nombre = Console.ReadLine()
        leeNumeroEntero(Cantidad, "Cantidad: ", 0, 20)
        leeNumeroFlotante(Precio, "Precio?", 0, 1000)
    End Sub

    Public Sub imprime()
        Console.WriteLine("Datos del artículo" & vbCrLf &
                          "Número: " & Numero & vbCrLf &
                          "Nombre: " & Nombre & vbCrLf &
                          "Cantidad: " & Cantidad & vbCrLf &
                          "Precio: " & Precio)
    End Sub

    Public Sub imprimeLinea()
        Console.WriteLine("{0,-5} {1, 35} {2, 10} {3, 10:c2}", Numero, Nombre, Cantidad, Precio)
    End Sub

    Public Function devuelveDatosLinea() As String
        Dim msje As String = Nothing
        'ACTIVIDAD
        'escribir el código en esta función para devolver los datos que se necesitan
        'mostrar en los MsgBox() del formulario


        Return msje
    End Function

    Public Sub asignaDatos(ByVal idArt As Integer, ByVal nomArt As String, ByVal cantArt As Integer, ByVal precArt As Single)
        Numero = idArt
        Nombre = nomArt
        Precio = precArt
        Cantidad = cantArt
        'TotArticulos += 1
    End Sub
End Class
