Public Class hija : Inherits padre
    Public DatoX As String
    Private DatoY As String
    Protected DatoZ As String

    REM: Constructor por omision
    Public Sub New()
        DatoX = "Que (Soy publica)|"
        DatoY = "Askella (Soy privada)|"
        DatoZ = "Te guie (Soy protegida)|"

    End Sub

    Public Sub New(ByVal dat1 As String, ByVal dat3 As String, ByVal datX As String, ByVal DatY As String, ByVal datZ As String)
        MyBase.New(dat1, dat3)
        DatoX = datX
        DatoY = DatY
        DatoZ = datZ
    End Sub




    Public Overloads Function imprime() As String
        Dim cadena As String
        cadena = "Imprimiendo desde clase Hija"
        cadena += vbCrLf & "   Dato público 1: " & Dato1
        'cadena += vbCrLf & "   Dato privado 2: " & Dato2
        cadena += vbCrLf & "Dato protegido 3: " & Dato3
        cadena += vbCrLf
        cadena += vbCrLf & "   Dato público X: " & DatoX
        'cadena += vbCrLf & "   Dato privado Y: " & Dato2
        cadena += vbCrLf & "Dato protegido Z: " & DatoZ

        Return cadena
    End Function

    Public Overrides Function visualizar() As String
        Dim cadena As String
        cadena = MyBase.visualizar()
        cadena += vbCrLf & "Datos hija" & vbCrLf
        cadena += "Dato x: " & DatoX
        cadena += "Dato y: " & DatoY
        cadena += "Dato z: " & DatoZ
        Return cadena
    End Function

End Class
