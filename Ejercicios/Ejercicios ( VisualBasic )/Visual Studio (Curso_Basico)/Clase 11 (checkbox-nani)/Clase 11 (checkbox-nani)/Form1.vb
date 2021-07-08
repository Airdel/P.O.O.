Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim rock, pop, clasica, jpop, otros As Boolean

        If Me.Rock.Checked = True Then
            rock = True
        Else
            rock = False
        End If
        If Me.Pop.Checked = True Then
            pop = True
        Else
            pop = False
        End If
        If Me.Clasica.Checked = True Then
            clasica = True
        Else
            clasica = False
        End If
        If Me.jpop.Checked = True Then
            jpop = True
        Else
            jpop = False
        End If
        If Me.otros.Checked = True Then
            otros = True
        Else
            otros = False
        End If

        MsgBox("Tus generos: ")
        If rock = True Then
            MsgBox("ROCK THIS BABY")
        End If
        If pop = True Then
            MsgBox("ONLY POP HERE")
        End If
        If clasica = True Then
            MsgBox("The four stations of your heart")
        End If
        If jpop = True Then
            MsgBox("These Chineses are gays. hue")
        End If
        If otros = True Then
            MsgBox("Interesting, tell me more.")
        End If

    End Sub

End Class
