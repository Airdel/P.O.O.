Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clase 3, Arrays (Arreglos para los del ISIC :v)
        Dim arreglo(3) As String
        arreglo(0) = "Sí"
        arreglo(1) = "No"
        arreglo(2) = "Quizá"
        MsgBox(arreglo(0) + " " + arreglo(1) + " " + arreglo(2))

        '....

        Dim arreglo1() As Integer
        arreglo1 = New Integer() {1, 2, 3}
        MsgBox(arreglo1(0).ToString + " " + arreglo1(1).ToString + " " + arreglo1(2).ToString)

        'Redimension de tamaño de arreglo

        ReDim Preserve arreglo1(2)
        MsgBox(arreglo1(0).ToString + " " + arreglo1(1).ToString)

        'Redimension sin preservación de datos
        ReDim arreglo1(3)
        MsgBox(arreglo1(0).ToString + " " + arreglo1(1).ToString + " " + arreglo1(2).ToString)

        'Creación de Matrices
        Dim matriz(,) As Integer = {{1, 2, 3}, {4, 5, 6}}
        MsgBox(matriz(1, 1).ToString)


    End Sub
End Class
