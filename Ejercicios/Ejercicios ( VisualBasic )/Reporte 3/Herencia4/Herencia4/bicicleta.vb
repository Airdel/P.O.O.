Public Class bicicleta
    Protected marcaB As String
    Protected modeloB As String
    Protected rodadaB As Byte
    Public Shared objetosBici As Byte
    Protected Const numLlantas As Byte = 2


    Public Property Marca As String
        Get
            Return marcaB
        End Get
        Set(ByVal value As String)
            marcaB = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return modeloB
        End Get
        Set(ByVal value As String)
            modeloB = value
        End Set
    End Property

    Public Property Rodada As Byte
        Get
            Return rodadaB
        End Get
        Set(ByVal value As Byte)
            If (value = 10 And value = 12 And value = 14 And value = 16 And value = 20 And value = 24 And value = 27 And value = 28 And value = 29) Then
                rodadaB = value
            Else
                rodadaB = 10
            End If
        End Set
    End Property

    Public ReadOnly Property objBici As Byte
        Get
            Return ObjetosBici
        End Get
    End Property

    Public ReadOnly Property numLl As Byte
        Get
            Return numLlantas
        End Get
    End Property

    Public Sub New()
        Marca = "Tesla"
        Modelo = "AirX"
        Rodada = 16
        objetosBici = objetosBici + 1
    End Sub

    Public Sub New(ByVal marB As String, ByVal modB As String, ByVal rodB As Byte)
        marcaB = marB
        modeloB = modB
        rodadaB = rodB
        objetosBici = objetosBici + 1
    End Sub

    Public Overridable Sub AsignaDatos(ByVal marB As String, ByVal modB As String, ByVal rodB As Byte)
        marcaB = marB
        modeloB = modB
        rodadaB = rodB
    End Sub

    Public Overridable Sub dameDatos(ByRef marB As String, ByRef modB As String, ByRef rodB As Byte, ByRef numLl As Byte)
        marB = marcaB
        modB = modeloB
        rodB = rodadaB
        numLl = numLlantas
    End Sub
End Class
