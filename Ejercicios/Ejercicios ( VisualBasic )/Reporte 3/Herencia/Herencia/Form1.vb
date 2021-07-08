Imports System.Drawing
Public Class Form1

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim Pincel As Pen = New Pen(Color.Aqua, 5)
        e.Graphics.DrawRectangle(Pincel, 10, 10, 100, 100)
        Pincel.Color = Color.DarkCyan
        'e.Graphics.DrawPolygon(Pincel)
    End Sub
End Class