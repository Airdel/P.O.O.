Public Class Form1

    Dim obj_padre As New padre()
    Dim obj_hija As New hija()
    Dim obj_padre2 As padre = New padre("Que (I'm Public)", " Alrisha (I'm private)", " Te ilumine (I'm Protected)")

    Private Sub btnpadre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpadre.Click
        MsgBox(obj_padre.imprime(), MsgBoxStyle.Information, "Rito mai frien")
    End Sub



    Private Sub btnhija_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhija.Click
        MsgBox(obj_hija.imprime(), MsgBoxStyle.Information, "OW OW OW IT'S MAGIC, YOU KNOOOOW!")
    End Sub

    Private Sub btnpadre2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpadre2.Click
        MsgBox(obj_padre2.imprime(), MsgBoxStyle.Exclamation, "The stars...")
    End Sub
End Class
