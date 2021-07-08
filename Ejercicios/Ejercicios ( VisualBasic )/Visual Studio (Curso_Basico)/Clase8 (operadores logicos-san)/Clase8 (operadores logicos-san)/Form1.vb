Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim resul As Boolean

        'Operador AND

        resul = (1 = 1) And (2 = 2)
        MsgBox(resul)

        resul = (1 = 1) And (2 = 4)
        MsgBox(resul)

        resul = (1 = 3) And (2 = 2)
        MsgBox(resul)

        resul = (1 = 2) And (2 = 3)
        MsgBox(resul)

        'Operador OR

        resul = (1 = 1) Or (2 = 2)
        MsgBox(resul)

        resul = (1 = 1) Or (2 = 3)
        MsgBox(resul)

        resul = (1 = 34) Or (2 = 2)
        MsgBox(resul)

        resul = (1 = 13) Or (22 = 2)
        MsgBox(resul)

        'Operador NOT

        resul = Not (1 = 1)
        MsgBox(resul)

        resul = Not (1 <> 1)
        MsgBox(resul)

        resul = ((1 = 1) And (2 = 1)) Or (3 = 3)
        MsgBox(resul)
    End Sub
End Class
