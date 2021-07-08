<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altaBicicleta
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
        Me.rbt24 = New System.Windows.Forms.RadioButton()
        Me.rbt20 = New System.Windows.Forms.RadioButton()
        Me.rbt16 = New System.Windows.Forms.RadioButton()
        Me.rbt14 = New System.Windows.Forms.RadioButton()
        Me.rbt12 = New System.Windows.Forms.RadioButton()
        Me.rbt10 = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbt24)
        Me.GroupBox1.Controls.Add(Me.rbt20)
        Me.GroupBox1.Controls.Add(Me.rbt16)
        Me.GroupBox1.Controls.Add(Me.rbt14)
        Me.GroupBox1.Controls.Add(Me.rbt12)
        Me.GroupBox1.Controls.Add(Me.rbt10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 102)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rodada"
        '
        'rbt24
        '
        Me.rbt24.AutoSize = True
        Me.rbt24.Location = New System.Drawing.Point(128, 65)
        Me.rbt24.Name = "rbt24"
        Me.rbt24.Size = New System.Drawing.Size(37, 17)
        Me.rbt24.TabIndex = 5
        Me.rbt24.TabStop = True
        Me.rbt24.Text = "24"
        Me.rbt24.UseVisualStyleBackColor = True
        '
        'rbt20
        '
        Me.rbt20.AutoSize = True
        Me.rbt20.Location = New System.Drawing.Point(128, 42)
        Me.rbt20.Name = "rbt20"
        Me.rbt20.Size = New System.Drawing.Size(37, 17)
        Me.rbt20.TabIndex = 4
        Me.rbt20.TabStop = True
        Me.rbt20.Text = "20"
        Me.rbt20.UseVisualStyleBackColor = True
        '
        'rbt16
        '
        Me.rbt16.AutoSize = True
        Me.rbt16.Location = New System.Drawing.Point(128, 19)
        Me.rbt16.Name = "rbt16"
        Me.rbt16.Size = New System.Drawing.Size(37, 17)
        Me.rbt16.TabIndex = 3
        Me.rbt16.TabStop = True
        Me.rbt16.Text = "16"
        Me.rbt16.UseVisualStyleBackColor = True
        '
        'rbt14
        '
        Me.rbt14.AutoSize = True
        Me.rbt14.Location = New System.Drawing.Point(6, 65)
        Me.rbt14.Name = "rbt14"
        Me.rbt14.Size = New System.Drawing.Size(37, 17)
        Me.rbt14.TabIndex = 2
        Me.rbt14.TabStop = True
        Me.rbt14.Text = "14"
        Me.rbt14.UseVisualStyleBackColor = True
        '
        'rbt12
        '
        Me.rbt12.AutoSize = True
        Me.rbt12.Location = New System.Drawing.Point(6, 42)
        Me.rbt12.Name = "rbt12"
        Me.rbt12.Size = New System.Drawing.Size(37, 17)
        Me.rbt12.TabIndex = 1
        Me.rbt12.TabStop = True
        Me.rbt12.Text = "12"
        Me.rbt12.UseVisualStyleBackColor = True
        '
        'rbt10
        '
        Me.rbt10.AutoSize = True
        Me.rbt10.Location = New System.Drawing.Point(6, 19)
        Me.rbt10.Name = "rbt10"
        Me.rbt10.Size = New System.Drawing.Size(37, 17)
        Me.rbt10.TabIndex = 0
        Me.rbt10.TabStop = True
        Me.rbt10.Text = "10"
        Me.rbt10.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(57, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(57, 14)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Modelo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Marca"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(34, 182)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(63, 25)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(146, 184)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(68, 22)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'altaBicicleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 224)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "altaBicicleta"
        Me.Text = "altaBicicleta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbt24 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt20 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt16 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt14 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt12 As System.Windows.Forms.RadioButton
    Friend WithEvents rbt10 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
