Public Class padre
    Public Dato1 As String
    Private Dato2 As String
    Protected Dato3 As String


    REM: Constructor por omision

    Public Sub New()
        Dato1 = "Que (Soy publico)|"
        Dato2 = "Denébola (Soy privado)|"
        Dato3 = "Te ilumine (Soy protegido)|"
    End Sub

    Public Overloads Function imprime() As String
        Dim cadena As String
        cadena = "Imprimiendo desde clase Padre"
        cadena += vbCrLf & "   Dato público: " & Dato1
        cadena += vbCrLf & "   Dato privado: " & Dato2
        cadena += vbCrLf & "Dato protegido: " & Dato3
        Return cadena
    End Function

    Public Sub New(ByVal dat1 As String, ByVal dat2 As String, ByVal dat3 As String)
        Dato1 = dat1
        Dato2 = dat2
        Dato3 = dat3


    End Sub
    Public Sub New(ByVal dat1 As String, ByVal dat3 As String)
        Dato1 = dat1
        Dato3 = dat3
    End Sub

    Public Overridable Function visualizar() As String
        Dim cadena As String
        cadena = "Datos Padre" & vbCrLf
        cadena += "Dato 1:   " & Dato1
        cadena += "Dato 2:   " & Dato2
        cadena += "Dato 3:   " & Dato3
        Return cadena
    End Function


End Class
