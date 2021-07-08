Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MessageBox.Show("Bienvenidos a Windoz form, perdon; Codigo Facilito")

    End Sub

    Private Sub btnSumar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumar.Click

        Dim valor1, valor2 As Integer
        Dim nombre As String
        nombre = txtNombre.Text
        valor1 = txtNum1.Text
        valor2 = txtNum2.Text

        MsgBox("Hola " & txtNombre.Text & vbCrLf & "La suma de " & txtNum1.Text & " mas " & txtNum2.Text & " Es igual a: " & valor1 + valor2)




    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
