Public Class Build
    Private Nombreitem As String
    Private Costoimtem As Double
    Private tipoitem As String
    Private pasiva As String
    Private activa As String

    Public Property nombre As String
        Get
            Return Nombreitem
        End Get
        Set(ByVal value As String)
            Nombreitem = value
        End Set
    End Property
    Public Property Costo As Double
        Get
            Return Costoimtem
        End Get
        Set(ByVal value As Double)
            Costoimtem = value
        End Set
    End Property
    Public Property tipoB As String
        Get
            Return tipoitem
        End Get
        Set(ByVal value As String)
            If value = "Resistencia" And value = "Mana" And value = "Vida" And value = "Reg vida" And value = "Reg mana" And value = "Enfriamento" And value = "Daño" And value = "Daño magico" Then
                tipoitem = value
            Else
                tipoitem = value
            End If
        End Set
    End Property
    Public Property Pasivas As String
        Get
            Return pasiva
        End Get
        Set(ByVal value As String)
            If value = "Si" And value = "No" Then
                pasiva = value
            Else
                pasiva = value
            End If
        End Set
    End Property
    Public Property Activas As String
        Get
            Return activa
        End Get
        Set(ByVal value As String)
            If value = "Si" And value = "No" Then
                activa = value
            Else
                activa = value
            End If
        End Set
    End Property
    Public Sub New()
        nombre = "Cetro abisal"
        Costo = 3600
        tipoB = "Daño magico"
        pasiva = "Pasiva"
        activa = "Activa"
    End Sub
    Public Sub New(ByVal nom As String, ByVal cost As Double, ByVal tip As String, ByVal pas As String, ByVal act As String)
        nombre = nom
        Costo = cost
        tipoB = tip
        Pasivas = pas
        Activas = act
    End Sub

    Public Sub New(ByVal copy As Build)
        Nombreitem = copy.Nombreitem
        Costoimtem = copy.Costoimtem
        tipoitem = copy.tipoitem
        pasiva = copy.pasiva
        activa = copy.activa
    End Sub
    Public Sub leerdatos()
        Console.WriteLine("INTRODUCE LOS DATOS DEL ITEM")
        Console.Write("Nombre: ")
        nombre = Console.ReadLine
        Console.Write("Costo del item: ")
        Costo = Console.ReadLine
        Console.Write("Tipo de item:   ")
        tipoB = Console.ReadLine
        Console.Write("Tiene pasiva:   ")
        pasiva = Console.ReadLine
        Console.Write("Tiene Activa:   ")
        activa = Console.ReadLine
    End Sub
    Public Sub Imprimedatos()
        Console.WriteLine("Datos del item")
        Console.WriteLine("Nombre:  ", nombre)
        Console.WriteLine("Tipo:    ", tipoB)
        Console.WriteLine("Costo:   ", Costo)
        Console.WriteLine("Pasiva:  ", pasiva)
        Console.WriteLine("Activa:  ", activa)
        Console.WriteLine()

    End Sub
    Public Sub asigardatos(ByVal nomb As String, ByVal tipi As String, ByVal cos As Double, ByVal pasi As String, ByVal acti As String)
        nombre = nomb
        tipoB = tipi
        cos = Costo
        Pasivas = pasi
        Activas = acti
    End Sub
End Class

