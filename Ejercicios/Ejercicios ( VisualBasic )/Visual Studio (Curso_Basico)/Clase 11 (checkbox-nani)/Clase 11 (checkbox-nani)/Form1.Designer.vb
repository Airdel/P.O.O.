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
        Me.Rock = New System.Windows.Forms.CheckBox()
        Me.Pop = New System.Windows.Forms.CheckBox()
        Me.Clasica = New System.Windows.Forms.CheckBox()
        Me.jpop = New System.Windows.Forms.CheckBox()
        Me.lblpregunta = New System.Windows.Forms.Label()
        Me.otros = New System.Windows.Forms.CheckBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rock
        '
        Me.Rock.AutoSize = True
        Me.Rock.Location = New System.Drawing.Point(13, 55)
        Me.Rock.Name = "Rock"
        Me.Rock.Size = New System.Drawing.Size(52, 17)
        Me.Rock.TabIndex = 0
        Me.Rock.Text = "Rock"
        Me.Rock.UseVisualStyleBackColor = True
        '
        'Pop
        '
        Me.Pop.AutoSize = True
        Me.Pop.Location = New System.Drawing.Point(13, 79)
        Me.Pop.Name = "Pop"
        Me.Pop.Size = New System.Drawing.Size(45, 17)
        Me.Pop.TabIndex = 1
        Me.Pop.Text = "Pop"
        Me.Pop.UseVisualStyleBackColor = True
        '
        'Clasica
        '
        Me.Clasica.AutoSize = True
        Me.Clasica.Location = New System.Drawing.Point(13, 103)
        Me.Clasica.Name = "Clasica"
        Me.Clasica.Size = New System.Drawing.Size(60, 17)
        Me.Clasica.TabIndex = 2
        Me.Clasica.Text = "Clásica"
        Me.Clasica.UseVisualStyleBackColor = True
        '
        'jpop
        '
        Me.jpop.AutoSize = True
        Me.jpop.Location = New System.Drawing.Point(13, 127)
        Me.jpop.Name = "jpop"
        Me.jpop.Size = New System.Drawing.Size(53, 17)
        Me.jpop.TabIndex = 3
        Me.jpop.Text = "J-Pop"
        Me.jpop.UseVisualStyleBackColor = True
        '
        'lblpregunta
        '
        Me.lblpregunta.AutoSize = True
        Me.lblpregunta.Location = New System.Drawing.Point(13, 24)
        Me.lblpregunta.Name = "lblpregunta"
        Me.lblpregunta.Size = New System.Drawing.Size(114, 13)
        Me.lblpregunta.TabIndex = 4
        Me.lblpregunta.Text = "Qué musica te agrada."
        '
        'otros
        '
        Me.otros.AutoSize = True
        Me.otros.Location = New System.Drawing.Point(13, 151)
        Me.otros.Name = "otros"
        Me.otros.Size = New System.Drawing.Size(51, 17)
        Me.otros.TabIndex = 5
        Me.otros.Text = "Otros"
        Me.otros.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnEnviar.Location = New System.Drawing.Point(158, 79)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.otros)
        Me.Controls.Add(Me.lblpregunta)
        Me.Controls.Add(Me.jpop)
        Me.Controls.Add(Me.Clasica)
        Me.Controls.Add(Me.Pop)
        Me.Controls.Add(Me.Rock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rock As CheckBox
    Friend WithEvents Pop As CheckBox
    Friend WithEvents Clasica As CheckBox
    Friend WithEvents jpop As CheckBox
    Friend WithEvents lblpregunta As Label
    Friend WithEvents otros As CheckBox
    Friend WithEvents btnEnviar As Button
End Class
