Public Class Form2
    Dim progTV2 As New programa

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        progTV2.Nombre = txtNombre.Text
        progTV2.Nombre = numericUpDuracion.value

    End Sub
End Class