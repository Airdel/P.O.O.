Public Class Form1
    Private Sub consultar_Click(sender As Object, e As EventArgs) Handles consultar.Click
        'Dim num1, num2 As Integer

        'num1 = txtnum1.Text
        'num2 = txtnum2.Text

        'If (num1 < num2) Then
        '    MsgBox("El numerito uno es menor que el numerito 2")
        'ElseIf (num1 = num2) Then
        '    MsgBox("Los numeros son iguales")
        'Else
        '    MsgBox("El primero es mayor que el segundo")
        'End If

        If (txtnum1.Text.Contains("Denébola")) Then
            MsgBox("Que Denébola te ilumine")
        Else
            MsgBox("maldito mortal")
        End If


    End Sub
End Class
