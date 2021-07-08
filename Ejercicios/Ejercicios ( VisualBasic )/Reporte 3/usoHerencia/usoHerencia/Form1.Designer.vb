<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnpadre = New System.Windows.Forms.Button()
        Me.btnhija = New System.Windows.Forms.Button()
        Me.btnpadre2 = New System.Windows.Forms.Button()
        Me.btnHija2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnpadre
        '
        Me.btnpadre.BackColor = System.Drawing.Color.Red
        Me.btnpadre.Font = New System.Drawing.Font("Cooper Black", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpadre.ForeColor = System.Drawing.Color.White
        Me.btnpadre.Location = New System.Drawing.Point(12, 12)
        Me.btnpadre.Name = "btnpadre"
        Me.btnpadre.Size = New System.Drawing.Size(657, 279)
        Me.btnpadre.TabIndex = 0
        Me.btnpadre.Text = "NO PRESIONAR(Padre)"
        Me.btnpadre.UseVisualStyleBackColor = False
        '
        'btnhija
        '
        Me.btnhija.BackColor = System.Drawing.Color.Cyan
        Me.btnhija.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhija.Location = New System.Drawing.Point(12, 297)
        Me.btnhija.Name = "btnhija"
        Me.btnhija.Size = New System.Drawing.Size(324, 237)
        Me.btnhija.TabIndex = 1
        Me.btnhija.Text = "QUE NO PRESIONES >:V (Hija)"
        Me.btnhija.UseVisualStyleBackColor = False
        '
        'btnpadre2
        '
        Me.btnpadre2.BackColor = System.Drawing.Color.Lime
        Me.btnpadre2.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpadre2.Location = New System.Drawing.Point(342, 297)
        Me.btnpadre2.Name = "btnpadre2"
        Me.btnpadre2.Size = New System.Drawing.Size(327, 237)
        Me.btnpadre2.TabIndex = 2
        Me.btnpadre2.Text = "HIJO DE LA..>:V"
        Me.btnpadre2.UseVisualStyleBackColor = False
        '
        'btnHija2
        '
        Me.btnHija2.BackColor = System.Drawing.Color.Cyan
        Me.btnHija2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHija2.Location = New System.Drawing.Point(12, 540)
        Me.btnHija2.Name = "btnHija2"
        Me.btnHija2.Size = New System.Drawing.Size(652, 281)
        Me.btnHija2.TabIndex = 3
        Me.btnHija2.Text = "¿Tu crees que esto es un fakin juego no? a-a"
        Me.btnHija2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 833)
        Me.Controls.Add(Me.btnHija2)
        Me.Controls.Add(Me.btnpadre2)
        Me.Controls.Add(Me.btnhija)
        Me.Controls.Add(Me.btnpadre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnpadre As System.Windows.Forms.Button
    Friend WithEvents btnhija As System.Windows.Forms.Button
    Friend WithEvents btnpadre2 As System.Windows.Forms.Button
    Friend WithEvents btnHija2 As System.Windows.Forms.Button

End Class
