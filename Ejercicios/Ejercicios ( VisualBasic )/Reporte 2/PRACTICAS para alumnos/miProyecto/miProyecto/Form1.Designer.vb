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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreP = New System.Windows.Forms.TextBox()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNumeroAvion = New System.Windows.Forms.TextBox()
        Me.txtCantidadVuelos = New System.Windows.Forms.TextBox()
        Me.txthorasVuelos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTipoPlaguicida = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSalida = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Piloto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Copiloto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matricula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numero de Avion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad de vuelos"
        '
        'txtNombreP
        '
        Me.txtNombreP.Location = New System.Drawing.Point(116, 1)
        Me.txtNombreP.Name = "txtNombreP"
        Me.txtNombreP.Size = New System.Drawing.Size(222, 20)
        Me.txtNombreP.TabIndex = 6
        '
        'txtNombreC
        '
        Me.txtNombreC.Location = New System.Drawing.Point(116, 53)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(222, 20)
        Me.txtNombreC.TabIndex = 7
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(116, 27)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(157, 20)
        Me.txtMatricula.TabIndex = 8
        '
        'txtNumeroAvion
        '
        Me.txtNumeroAvion.Location = New System.Drawing.Point(116, 79)
        Me.txtNumeroAvion.Name = "txtNumeroAvion"
        Me.txtNumeroAvion.Size = New System.Drawing.Size(76, 20)
        Me.txtNumeroAvion.TabIndex = 9
        '
        'txtCantidadVuelos
        '
        Me.txtCantidadVuelos.Location = New System.Drawing.Point(116, 105)
        Me.txtCantidadVuelos.Name = "txtCantidadVuelos"
        Me.txtCantidadVuelos.Size = New System.Drawing.Size(44, 20)
        Me.txtCantidadVuelos.TabIndex = 10
        '
        'txthorasVuelos
        '
        Me.txthorasVuelos.Location = New System.Drawing.Point(116, 130)
        Me.txthorasVuelos.Name = "txthorasVuelos"
        Me.txthorasVuelos.Size = New System.Drawing.Size(100, 20)
        Me.txthorasVuelos.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(58, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 24)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTipoPlaguicida
        '
        Me.txtTipoPlaguicida.Location = New System.Drawing.Point(116, 156)
        Me.txtTipoPlaguicida.Name = "txtTipoPlaguicida"
        Me.txtTipoPlaguicida.Size = New System.Drawing.Size(222, 20)
        Me.txtTipoPlaguicida.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Horas De Vuelo"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(356, 12)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(322, 477)
        Me.txtDisplay.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo de Plaguicida:"
        '
        'btnSalida
        '
        Me.btnSalida.Location = New System.Drawing.Point(263, 202)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(75, 23)
        Me.btnSalida.TabIndex = 18
        Me.btnSalida.Text = "Salir"
        Me.btnSalida.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(717, 514)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTipoPlaguicida)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txthorasVuelos)
        Me.Controls.Add(Me.txtCantidadVuelos)
        Me.Controls.Add(Me.txtNumeroAvion)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.txtNombreC)
        Me.Controls.Add(Me.txtNombreP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aviofug 0.3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombreP As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreC As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroAvion As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadVuelos As System.Windows.Forms.TextBox
    Friend WithEvents txthorasVuelos As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtTipoPlaguicida As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSalida As System.Windows.Forms.Button
End Class
