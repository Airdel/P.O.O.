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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGenP = New System.Windows.Forms.TextBox()
        Me.txtDurP = New System.Windows.Forms.TextBox()
        Me.txtNomIntP = New System.Windows.Forms.TextBox()
        Me.txtNomP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNomD = New System.Windows.Forms.TextBox()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Pista"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de Disco"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGenP)
        Me.GroupBox1.Controls.Add(Me.txtDurP)
        Me.GroupBox1.Controls.Add(Me.txtNomIntP)
        Me.GroupBox1.Controls.Add(Me.txtNomP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 125)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cancion"
        '
        'txtGenP
        '
        Me.txtGenP.Location = New System.Drawing.Point(64, 96)
        Me.txtGenP.Name = "txtGenP"
        Me.txtGenP.Size = New System.Drawing.Size(209, 20)
        Me.txtGenP.TabIndex = 8
        '
        'txtDurP
        '
        Me.txtDurP.Location = New System.Drawing.Point(72, 70)
        Me.txtDurP.Name = "txtDurP"
        Me.txtDurP.Size = New System.Drawing.Size(201, 20)
        Me.txtDurP.TabIndex = 7
        '
        'txtNomIntP
        '
        Me.txtNomIntP.Location = New System.Drawing.Point(129, 44)
        Me.txtNomIntP.Name = "txtNomIntP"
        Me.txtNomIntP.Size = New System.Drawing.Size(144, 20)
        Me.txtNomIntP.TabIndex = 6
        '
        'txtNomP
        '
        Me.txtNomP.Location = New System.Drawing.Point(107, 18)
        Me.txtNomP.Name = "txtNomP"
        Me.txtNomP.Size = New System.Drawing.Size(166, 20)
        Me.txtNomP.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Duracion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de Interprete"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNomD
        '
        Me.txtNomD.Location = New System.Drawing.Point(27, 25)
        Me.txtNomD.Name = "txtNomD"
        Me.txtNomD.Size = New System.Drawing.Size(205, 20)
        Me.txtNomD.TabIndex = 4
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(312, 12)
        Me.txtCaja.Multiline = True
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(309, 198)
        Me.txtCaja.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 222)
        Me.Controls.Add(Me.txtCaja)
        Me.Controls.Add(Me.txtNomD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGenP As System.Windows.Forms.TextBox
    Friend WithEvents txtDurP As System.Windows.Forms.TextBox
    Friend WithEvents txtNomIntP As System.Windows.Forms.TextBox
    Friend WithEvents txtNomP As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNomD As System.Windows.Forms.TextBox
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
End Class
