Public Class disco
    Private nomDisco As String
    Private Shared cantDiscos As Byte = 0
    Private pista1 As New pistas

    Public Property nombreD As String
        Get
            Return nomDisco
        End Get
        Set(ByVal value As String)
            nomDisco = value
        End Set
    End Property

    Public ReadOnly Property Cantidad As Byte
        Get
            Return cantDiscos
        End Get
    End Property

    Public Property Cancion As pistas
        Get
            Return pista1
        End Get
        Set(ByVal value As pistas)
            pista1 = value
        End Set
    End Property

    Public Sub New()
        nombreD = "Denébola"
        Cancion.NombreP = "AcMaB"
        Cancion.InterpreteP = "HAtsune Miku"
        Cancion.DuracionP = 5.3
        Cancion.GeneroP = "V"
    End Sub

    Public Sub New(ByVal nomD As String, ByVal nomP As String, ByVal intP As String, ByVal durP As Double, ByVal genP As Char)
        nombreD = nomD
        Cancion.NombreP = nomP
        Cancion.InterpreteP = intP
        Cancion.DuracionP = durP
        Cancion.GeneroP = intP
    End Sub

    Public Sub New(ByVal nomD As String, ByVal pist1 As pistas)
        nombreD = nomD
        cantDiscos += 1
        Cancion.NombreP = Nothing
        Cancion.InterpreteP = Nothing
        Cancion.DuracionP = Nothing
        Cancion.GeneroP = Nothing
    End Sub

    Public Sub New(ByVal copia As disco) 'Constructor copia-copiador :0
        nombreD = copia.nombreD
        Cancion.NombreP = copia.Cancion.NombreP
        Cancion.InterpreteP = copia.Cancion.InterpreteP
        Cancion.DuracionP = copia.Cancion.InterpreteP
        Cancion.GeneroP = copia.Cancion.GeneroP

    End Sub



End Class

