Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resultado As Boolean

        'resultado = 1 = 1
        'MsgBox(resultado)

        'resultado = 1 = 2
        'MsgBox(resultado)

        'resultado = 1 > 2
        'MsgBox(resultado)

        'resultado = 1 < 2
        'MsgBox(resultado)

        'resultado = 1 >= 2
        'MsgBox(resultado)

        'resultado = 1 <= 2
        'MsgBox(resultado)

        'resultado = 1 <> 2
        'MsgBox(resultado)

        'resultado = "Denébola" <> "Askella"
        'MsgBox(resultado)

        'resultado = "Denébola" <> "Denébola"
        'MsgBox(resultado)

        'resultado = (2 + 1) = 3
        'MsgBox(resultado)

        'resultado = (2 + 1) = (5 * 1)
        'MsgBox(resultado)






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim igual As Boolean
        igual = Numero1.Text = Numero2.Text
        MsgBox(igual)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim menor As Boolean
        menor = Numero1.Text > Numero2.Text
        MsgBox(menor)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mayor As Boolean
        mayor = Numero1.Text < Numero2.Text
        MsgBox(mayor)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mayor2 As Boolean
        mayor2 = Numero1.Text >= Numero2.Text
        MsgBox(mayor2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim menor2 As Boolean
        menor2 = Numero1.Text <= Numero2.Text
        MsgBox(menor2)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dif As Boolean
        dif = Numero1.Text <> Numero2.Text
        MsgBox(dif)
    End Sub
End Class
