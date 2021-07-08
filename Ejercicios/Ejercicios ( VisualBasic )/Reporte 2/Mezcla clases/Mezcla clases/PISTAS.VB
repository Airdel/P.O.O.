Public Class pistas
    Private nomPista As String
    Private intPista As String
    Private durPista As Double
    Private genPista As Char

    Public Property NombreP As String
        Get
            Return nomPista
        End Get
        Set(ByVal value As String)
            nomPista = value
        End Set
    End Property

    Public Property InterpreteP As String
        Get
            Return intPista
        End Get
        Set(ByVal value As String)
            intPista = value
        End Set
    End Property

    Public Property DuracionP As Double
        Get
            Return durPista
        End Get
        Set(ByVal value As Double)
            durPista = value
        End Set
    End Property

    Public Property GeneroP As String
        Get
            Return genPista
        End Get
        Set(ByVal value As String)
            genPista = value
        End Set
    End Property

    Public Sub New()
        NombreP = "Blue Star"
        InterpreteP = "Hatsune Miku"
        DuracionP = 3.42
        GeneroP = "V"
    End Sub

    Public Sub New(ByVal nom As String, ByVal int As String, ByVal dur As Double, ByVal gen As Char)
        NombreP = nom
        InterpreteP = int
        DuracionP = dur
        GeneroP = gen
    End Sub



End Class
