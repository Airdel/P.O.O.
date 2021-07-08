Public Class Campeon
    Private Nomcampeon As String
    Private tipocampeon As String
    Private carricampeon As String
    Private dificultadcampeon As String
    Private cantidadc As Byte
    Private item1 As New Build


    Public Property Nombrec As String
        Get
            Return Nomcampeon
        End Get
        Set(ByVal value As String)
            If value = "URF" Then
                Console.WriteLine("YOM,YOM")
                Nomcampeon = "Warwhick"
            Else
                Nomcampeon = value
            End If
        End Set
    End Property
    Public Property tipoc As String
        Get
            Return tipocampeon
        End Get
        Set(ByVal value As String)
            tipocampeon = value
        End Set
    End Property
    Public Property carrilc As String
        Get
            Return carricampeon
        End Get
        Set(ByVal value As String)
            If value = "Troll" Then
                MsgBox("reportado")
                value = "reportado"
            Else
                carricampeon = value
            End If
        End Set
    End Property
    Public Property DificultadC As String
        Get
            Return dificultadcampeon
        End Get
        Set(ByVal value As String)
            If (value = "Facil") Then
                MsgBox("Sea hombre",, "Rito")
                dificultadcampeon = "Vas reportadisimo papu :V"
            Else
                dificultadcampeon = value
            End If

        End Set
    End Property
    Public Property items As Build
        Get
            Return item1
        End Get
        Set(ByVal value As Build)
            item1 = value

        End Set
    End Property
    Public ReadOnly Property Cantidad As Byte 'el READONLY ES PARA QUE SOLO SEA LECTURA
        Get
            Return cantidadc
        End Get
    End Property

    Public Sub New()
        Nomcampeon = "Vel'Koz"
        tipocampeon = "Mago"
        carricampeon = "Mid"
        dificultadcampeon = "Moderado"
    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Build As Build)
        Nombrec = Nombre
        cantidadc += 1
        With items
            With item1
                .nombre = "Cetro avisal"
                .Costo = 3600
                .tipoB = "Daño magico"
                .Pasivas = "Pasiva"
                .Activas = "Activa"
            End With
        End With
    End Sub
    Public Sub New(ByVal nom As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nom
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
    Public Sub New(ByVal copy As Campeon)
        Nombrec = copy.Nombrec
        tipoc = copy.tipoc
        carrilc = copy.carrilc
        DificultadC = copy.DificultadC
    End Sub
    Public Sub leedatos()
        Console.WriteLine("INTRODUZCA LOS DATOS DEL CAMPEON")
        Console.Write("Nombre:")
        Nombrec = Console.ReadLine
        Console.Write("tipo de campeon: ")
        tipoc = Console.ReadLine
        Console.Write("carril: ")
        carrilc = Console.ReadLine
        Console.Write("Dificultad: ")
        DificultadC = Console.ReadLine
    End Sub
    Public Sub Imprimedatos()
        Console.WriteLine("Datos del campeon")
        Console.WriteLine("Nombre:     ", Nombrec)
        Console.WriteLine("Tipo:       ", tipoc)
        Console.WriteLine("Carril:     ", carrilc)
        Console.WriteLine("Dificultad: ", DificultadC)

    End Sub
    Public Sub asignadatos(ByVal nomc As String, ByVal tipc As String, ByVal carrilca As String, ByVal difc As Char)
        Nombrec = nomc
        tipoc = tipc
        carrilc = carrilca
        DificultadC = difc
    End Sub
End Class
