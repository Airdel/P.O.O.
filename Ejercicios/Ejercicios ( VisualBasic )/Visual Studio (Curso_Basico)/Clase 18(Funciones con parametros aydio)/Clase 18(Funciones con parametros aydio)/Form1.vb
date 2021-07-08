Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vari As String
        vari = "Variable natal (sin cambiar)"
        porValor(vari)
        porRef(vari)

    End Sub

    Private Sub porValor(ByVal variable As String)
        MsgBox(variable)
        variable = "variable cambiadeishon"
        MsgBox(variable)

    End Sub

    Private Sub porRef(ByRef variable As String)
        MsgBox(variable)
        variable = "variable cambiada por referencia(Y por magia)"
        MsgBox(variable)

    End Sub

End Class
