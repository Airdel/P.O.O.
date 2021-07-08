Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Dim arreglo(5)
        'Do
        '    MsgBox("Ciclo do-do-DO = " + i.ToString)
        '    i += 1
        'Loop While i < 3

        'i = 0

        'Do While i < 3
        '    MsgBox("Ciclo do-di-DO while = " + i.ToString)
        '    i = i + 1
        'Loop

        'i = 0

        'While i < 3
        '    MsgBox("Ciclo while = " + i.ToString)
        '    i += 1
        'End While

        Do While i < 5
            arreglo(i) = i
            i += 1
        Loop

        i = 0

        While i < 5
            MsgBox("Arreglo(" + i.ToString + ") = " + arreglo(i).ToString)
            i += 1
        End While


    End Sub
End Class
