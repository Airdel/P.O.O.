Public Class Form1

    Dim D As New disco
    Dim pista As New pistas
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        D.nombreD = txtNomD.Text
        D.Cancion.NombreP = txtNomP.Text
        D.Cancion.InterpreteP = txtNomIntP.Text
        D.Cancion.DuracionP = txtDurP.Text
        D.Cancion.GeneroP = txtGenP.Text

        txtCaja.Text = "Nombre del Disco: " & D.nombreD & vbCrLf & "Nombre de la canción: " & D.Cancion.NombreP & vbCrLf & "Nombre del Interprete: " & D.Cancion.InterpreteP & vbCrLf & "Duración: " & D.Cancion.DuracionP & "Genero: " & D.Cancion.GeneroP & vbCrLf







    End Sub
End Class