Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnuno_Click(sender As Object, e As EventArgs) Handles btnuno.Click
        MsgBox("Que Denébola te ilumine", MsgBoxStyle.Exclamation, "Saludations-desu")
    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, resultado As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        resultado = num1 + num2
        MsgBox(resultado)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
