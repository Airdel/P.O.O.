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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.Texto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'etiqueta
        '
        Me.etiqueta.AutoSize = True
        Me.etiqueta.Location = New System.Drawing.Point(20, 19)
        Me.etiqueta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(387, 19)
        Me.etiqueta.TabIndex = 0
        Me.etiqueta.Text = "Que Denébola te ilumine. (Y si no chupa limon)"
        '
        'Texto
        '
        Me.Texto.Location = New System.Drawing.Point(24, 42)
        Me.Texto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(334, 26)
        Me.Texto.TabIndex = 1
        Me.Texto.Text = "Escribe pls ;-;"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 459)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.etiqueta)
        Me.Font = New System.Drawing.Font("AR DESTINE", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Pero que raios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents etiqueta As Label
    Friend WithEvents Texto As TextBox
End Class
