Public Class Avioneta_fumigadora
    Private numAvion As String  'Prop Lista
    Private vuelosDiarios As Double ' Prop Lista
    Private nomPiloto As String 'Prop lista
    Private matPiloto As String ' Prop lista
    Private tipoPlaguicida As String 'Prop lista
    Private nomCopiloto As String 'Prop lista
    Private horasVuelo As Double

    'Propiedades de interaccion

    Public Property NombrePiloto As String
        Get
            Return nomPiloto.ToUpper

        End Get
        Set(ByVal value As String)
            nomPiloto = value
        End Set
    End Property

    Public Property NombreCopiloto As String
        Get
            Return nomPiloto.ToUpper

        End Get
        Set(ByVal value As String)
            nomPiloto = value
        End Set
    End Property

    Public Property matriculaP As String
        Get
            Return matPiloto
        End Get
        Set(ByVal value As String)
            matPiloto = value
        End Set
    End Property

    Public Property Plaguicida As String
        Get
            Return TipoPlaguicida
        End Get
        Set(ByVal value As String)
            If (value <> "Forte" And value <> "Adison" And value <> "Arde") Then
                tipoPlaguicida = "Plaguicida no registrado"
            Else
                tipoPlaguicida = value
            End If
        End Set
    End Property

    Public Property vuelosPorDia As Double
        Get
            Return vuelosDiarios
        End Get
        Set(ByVal value As Double)
            If (value >= 0 And value <= 6) Then
                vuelosDiarios = value
            Else
                If (value <= 0) Then
                    MsgBox("Capacidad de vuelos incorrecta-(No se ha realizado ningun vuelo)", MsgBoxStyle.Critical)
                End If
                If (value >= 6) Then
                    MsgBox("Capacidad de vuelos incorrecta-(Demasiados vuelos)", MsgBoxStyle.Information)
                End If
                vuelosDiarios = 0
            End If

        End Set
    End Property

    Public Property NumeroAvion As String
        Get
            Return numAvion
        End Get
        Set(ByVal value As String)
            If (value <> 15 And value <> 20) Then
                numAvion = value
            Else
                MsgBox("Avion fuera de servicio.")
                numAvion = 1
            End If
        End Set
    End Property

    Public Property horasdVuelo As Double
        Get
            Return horasVuelo
        End Get
        Set(ByVal value As Double)
            If (value >= 0 And value <= 10) Then
                horasVuelo = value
                horasVuelo = 0
            Else

                MsgBox("Horas de vuelo incorrectas")
            End If

        End Set
    End Property
    


    'Asignación de valores.

    Public Sub AsignaDatos(ByVal nomP As String, ByVal matP As String, ByVal nomC As String, ByVal numA As String, ByVal vuelosD As Double, ByVal tipoP As String, ByVal horasV As Double)

        nomPiloto = UCase(nomP)
        nomCopiloto = UCase(nomC)
        matPiloto = matP
        numAvion = numA
        vuelosDiarios = vuelosD
        tipoPlaguicida = tipoP
        horasVuelo = horasV
    End Sub

    'Constructor
    Public Sub New()
        NombrePiloto = "Airdel Denébol"
        NombreCopiloto = "Suair Aguilar"
        matriculaP = "14D213AO-13"
        NumeroAvion = "13"
        vuelosPorDia = "3"
        horasdVuelo = "5"
        Plaguicida = "Arden"
    End Sub

    'Constructor parametrizado
    Public Sub New(ByVal nomP As String, ByVal matP As String, ByVal nomC As String, ByVal numA As String, ByVal vuelosD As Integer, ByVal tipoP As String, ByVal horasV As Double)
        AsignaDatos(nomP, matP, nomC, numA, vuelosD, tipoP, horasV)

    End Sub


End Class
