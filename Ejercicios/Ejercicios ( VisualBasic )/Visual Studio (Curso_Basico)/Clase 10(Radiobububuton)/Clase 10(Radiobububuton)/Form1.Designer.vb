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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Suma = New System.Windows.Forms.RadioButton()
        Me.Resta = New System.Windows.Forms.RadioButton()
        Me.Multiplicacion = New System.Windows.Forms.RadioButton()
        Me.Division = New System.Windows.Forms.RadioButton()
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.operacion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.operacion)
        Me.GroupBox1.Controls.Add(Me.num2)
        Me.GroupBox1.Controls.Add(Me.num1)
        Me.GroupBox1.Controls.Add(Me.Division)
        Me.GroupBox1.Controls.Add(Me.Multiplicacion)
        Me.GroupBox1.Controls.Add(Me.Resta)
        Me.GroupBox1.Controls.Add(Me.Suma)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(6, 19)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(52, 17)
        Me.Suma.TabIndex = 0
        Me.Suma.TabStop = True
        Me.Suma.Text = "Suma" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Location = New System.Drawing.Point(7, 43)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(53, 17)
        Me.Resta.TabIndex = 1
        Me.Resta.TabStop = True
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.AutoSize = True
        Me.Multiplicacion.Location = New System.Drawing.Point(6, 67)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.Multiplicacion.TabIndex = 2
        Me.Multiplicacion.TabStop = True
        Me.Multiplicacion.Text = "Multiplicacion"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.AutoSize = True
        Me.Division.Location = New System.Drawing.Point(7, 92)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(62, 17)
        Me.Division.TabIndex = 3
        Me.Division.TabStop = True
        Me.Division.Text = "Division"
        Me.Division.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(159, 19)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 4
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(159, 54)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 5
        '
        'operacion
        '
        Me.operacion.Location = New System.Drawing.Point(159, 80)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(75, 23)
        Me.operacion.TabIndex = 6
        Me.operacion.Text = "Calcular"
        Me.operacion.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents operacion As Button
    Friend WithEvents num2 As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents Division As RadioButton
    Friend WithEvents Multiplicacion As RadioButton
    Friend WithEvents Resta As RadioButton
    Friend WithEvents Suma As RadioButton
End Class
