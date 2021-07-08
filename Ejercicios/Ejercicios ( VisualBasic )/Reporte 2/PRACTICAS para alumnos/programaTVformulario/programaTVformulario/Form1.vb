Public Class Form1
    Dim progtv As New programa

    'Guardar datos en atributos



    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        progtv.Nombre = txtNombre.Text
        progtv.Duracion = txtDuracion.Text
        progtv.Clasificacion = txtClasificacion.Text
        txtCaja.Text += ("Nombre: " & progtv.Nombre & vbCrLf & "Duracion: " & progtv.Duracion & vbCrLf & "Clasificacion: " & progtv.Clasificacion)

    End Sub




End Class
