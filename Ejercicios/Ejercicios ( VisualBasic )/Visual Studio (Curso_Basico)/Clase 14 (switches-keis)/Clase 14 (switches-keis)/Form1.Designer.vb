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
        Me.ejecutar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sumar = New System.Windows.Forms.RadioButton()
        Me.restar = New System.Windows.Forms.RadioButton()
        Me.multiplicar = New System.Windows.Forms.RadioButton()
        Me.dividir = New System.Windows.Forms.RadioButton()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ejecutar
        '
        Me.ejecutar.Location = New System.Drawing.Point(172, 107)
        Me.ejecutar.Name = "ejecutar"
        Me.ejecutar.Size = New System.Drawing.Size(89, 47)
        Me.ejecutar.TabIndex = 0
        Me.ejecutar.Text = "Calcular"
        Me.ejecutar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero 1: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numero 2:"
        '
        'sumar
        '
        Me.sumar.AutoSize = True
        Me.sumar.Location = New System.Drawing.Point(12, 89)
        Me.sumar.Name = "sumar"
        Me.sumar.Size = New System.Drawing.Size(55, 17)
        Me.sumar.TabIndex = 3
        Me.sumar.TabStop = True
        Me.sumar.Text = "Sumar"
        Me.sumar.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.AutoSize = True
        Me.restar.Location = New System.Drawing.Point(12, 113)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(56, 17)
        Me.restar.TabIndex = 4
        Me.restar.TabStop = True
        Me.restar.Text = "Restar"
        Me.restar.UseVisualStyleBackColor = True
        '
        'multiplicar
        '
        Me.multiplicar.AutoSize = True
        Me.multiplicar.Location = New System.Drawing.Point(12, 137)
        Me.multiplicar.Name = "multiplicar"
        Me.multiplicar.Size = New System.Drawing.Size(72, 17)
        Me.multiplicar.TabIndex = 5
        Me.multiplicar.TabStop = True
        Me.multiplicar.Text = "Multiplicar"
        Me.multiplicar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.AutoSize = True
        Me.dividir.Location = New System.Drawing.Point(12, 160)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(54, 17)
        Me.dividir.TabIndex = 6
        Me.dividir.TabStop = True
        Me.dividir.Text = "Dividir"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(72, 6)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 7
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(72, 39)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.multiplicar)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.sumar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ejecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ejecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents sumar As RadioButton
    Friend WithEvents restar As RadioButton
    Friend WithEvents multiplicar As RadioButton
    Friend WithEvents dividir As RadioButton
    Friend WithEvents num1 As TextBox
    Friend WithEvents num2 As TextBox
End Class
