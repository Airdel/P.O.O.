Public Class Form1
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles multiplicar.CheckedChanged

    End Sub

    Private Sub ejecutar_Click(sender As Object, e As EventArgs) Handles ejecutar.Click
        Dim opc As String
        Dim n1, n2 As Integer
        Dim resultado As Double

        If sumar.Checked = True Then
            opc = "Sumar"
        End If
        If restar.Checked = True Then
            opc = "Restar"
        End If
        If multiplicar.Checked = True Then
            opc = "Multiplicar"
        End If
        If dividir.Checked = True Then
            opc = "Dividir"
        End If

        n1 = num1.Text
        n2 = num2.Text



        Select Case opc
            Case "Sumar"
                resultado = n1 + n2
            Case "Restar"
                resultado = n1 - n2
            Case "Multiplicar"
                resultado = n1 * n2
            Case "Dividir"
                resultado = n1 / n2
            Case Else
                MsgBox("No se selecciono ninguna operación para ejecutar.")
                Exit Sub
        End Select



        MsgBox("El resultado es: " + resultado.ToString)

    End Sub
End Class
