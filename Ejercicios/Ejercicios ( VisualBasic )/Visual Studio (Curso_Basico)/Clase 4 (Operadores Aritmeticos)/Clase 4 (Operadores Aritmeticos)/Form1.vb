Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clase 4, operadores aritmeticos

        Dim num1, num2, operacion As Integer
        num1 = 2
        num2 = 5
        operacion = num1 + num2
        MsgBox(operacion.ToString)
        operacion = num1 - num2
        MsgBox(operacion.ToString)
        operacion = num1 * num2
        MsgBox(operacion.ToString)

        'Operadores que necesitan dato Double
        Dim num3, num4, resultado As Double
        num3 = 2
        num4 = 5
        resultado = num3 / num4
        MsgBox(resultado.ToString)
        resultado = num3 Mod num4
        MsgBox(resultado.ToString)

        'Incremento o decremento de variables
        num1 += 1
        MsgBox(num1)
        num1 += 5
        MsgBox(num1)
        'Decremento
        num1 -= 1
        MsgBox(num1)

    End Sub
End Class
