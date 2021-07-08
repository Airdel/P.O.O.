Public Class Trajinera
    Private capacidadPasajeros As Integer
    Private colorTrajinera As String
    Private duracionViaje As Double
    Private costoDeViaje As Double
    Private tipoDeViaje As String
    Private modeloDeTrajinera As String
    Private nombreTrajinera As String
    'Propiedades
    Public Property capasidad As Integer
        Get
            Return capacidadPasajeros
        End Get
        Set(ByVal value As Integer)
            If value >= 1 And value <= 20 Then
                capacidadPasajeros = value
            Else
                capacidadPasajeros = 5
            End If
        End Set
    End Property
    Public Property nombre As String
        Get
            Return nombreTrajinera
        End Get
        Set(ByVal value As String)
            nombreTrajinera = value
        End Set
    End Property
    Public Property duracion As Double
        Get
            Return duracionViaje
        End Get
        Set(ByVal value As Double)
            If value >= 5 And value <= 60 Then
                duracionViaje = value
            Else
                duracionViaje = 20
            End If
        End Set
    End Property
    Public Property color As String
        Get
            Return colorTrajinera
        End Get
        Set(ByVal value As String)
            colorTrajinera = value
        End Set
    End Property
    Public Property modelo As String
        Get
            Return modeloDeTrajinera
        End Get
        Set(ByVal value As String)
            modeloDeTrajinera = value
        End Set
    End Property
    Public Property tipo As String
        Get
            Return tipoDeViaje
        End Get
        Set(ByVal value As String)
            tipoDeViaje = value
        End Set
    End Property
    Public Property costo As Double
        Get
            Return costoDeViaje
        End Get
        Set(ByVal value As Double)
            costoDeViaje = value
        End Set
    End Property
    Public Sub asignaDatos(ByVal nom As String, ByVal dur As Double, ByVal tipoo As String, ByVal cos As Double, ByVal col As String, ByVal capsidad As Integer, ByVal md As String)
        nombre = nom
        duracion = dur
        tipo = tipoo
        costo = cos
        color = col
        capasidad = capsidad
        modelo = md
    End Sub
    Public Sub New()
        nombre = "La trajinera"
        duracion = 30
        tipo = "Rentada"
        costo = 1000
        color = "Rojo"
        capasidad = 20
        modelo = "2002"

    End Sub
    Public Sub New(ByVal nom As String, ByVal dur As Double, ByVal tipoo As String, ByVal cos As Double, ByVal col As String, ByVal capsidad As Integer, ByVal md As String)
        nombre = nom
        duracion = dur
        tipo = tipoo
        costo = cos
        color = col
        capasidad = capsidad
        modelo = md
    End Sub
End Class
