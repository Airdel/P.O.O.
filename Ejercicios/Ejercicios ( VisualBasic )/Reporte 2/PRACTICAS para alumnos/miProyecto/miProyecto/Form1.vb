Public Class Form1
    Dim aviofug As New Avioneta_fumigadora

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        aviofug.NombrePiloto = txtNombreP.Text
        aviofug.NombreCopiloto = txtNombreC.Text
        aviofug.matriculaP = txtMatricula.Text
        aviofug.Plaguicida = txtTipoPlaguicida.Text
        aviofug.vuelosPorDia = txtCantidadVuelos.Text
        aviofug.horasdVuelo = txthorasVuelos.Text
        txtDisplay.Text += "Nombre: " & aviofug.NombrePiloto & vbCrLf & "Matricula del piloto: " & aviofug.matriculaP & vbCrLf & "Nombre Del Copiloto: " & aviofug.NombreCopiloto & vbCrLf & "Vuelos Diarios: " & aviofug.vuelosPorDia & vbCrLf & "Horas De Vuelo: " & aviofug.horasdVuelo & vbCrLf & "Nombre del plaguicida: " & aviofug.Plaguicida & vbCrLf
    End Sub



    Private Sub btnSalida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalida.Click
        Me.Close()
    End Sub
End Class
