Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'saludos()
    End Sub

    Sub saludos()
        MsgBox("SALUDAD TERRICOLAS")
    End Sub

    Function regresaSaludo()
        Dim saludos As String
        saludos = "Hola, soy un procedimiento que procede."

        Return saludos

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        saludos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim procede As String
        procede = regresaSaludo()
        MsgBox(procede)
    End Sub
End Class
