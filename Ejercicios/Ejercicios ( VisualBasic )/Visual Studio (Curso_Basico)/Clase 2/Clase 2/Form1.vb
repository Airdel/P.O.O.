Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim entero As Integer = 1
        MsgBox(entero)
        entero = 2
        MsgBox(entero)
        ' Dato Double
        Dim numero As Double = 102.512
        MsgBox(numero)
        numero = 42.4
        MsgBox(numero)
        ' Dato String
        Dim text As String = "Hola Galaxia"
        MsgBox(text)
        Dim text2 As String = " Denébola te ilumina"
        MsgBox(text + text2)
        ' Dato Date (Fechas)
        Dim fecha As Date = "05-12-1999"
        MsgBox(fecha)
        Dim fecha2 As Date = "01-December-1999"
        MsgBox(fecha2)


    End Sub
End Class
