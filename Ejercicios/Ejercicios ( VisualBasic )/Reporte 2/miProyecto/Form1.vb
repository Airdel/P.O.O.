Public Class Form1
    Dim t As New Trajinera
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        t.nombre = txtNombre.Text
        t.capasidad = txtCapasidad.Text
        t.modelo = txtModelo.Text
        t.color = txtColor.Text
        t.tipo = txtTipo.Text
        t.duracion = txtDuracion.Text
        t.costo = txtCosto.Text
        txtCaja.Text = "Nombre: " & txtNombre.Text & vbCrLf & "Capasidad: " & txtCapasidad.Text & vbCrLf & ""

    End Sub
End Class
