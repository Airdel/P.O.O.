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
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblGranTotal = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnVerInventario = New System.Windows.Forms.Button()
        Me.cboId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidadComprar = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtGranTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Existencia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Unitario $"
        '
        'txtCaja
        '
        Me.txtCaja.Location = New System.Drawing.Point(16, 208)
        Me.txtCaja.Multiline = True
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(833, 187)
        Me.txtCaja.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(128, 119)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(160, 22)
        Me.txtPrecio.TabIndex = 6
        '
        'txtExistencia
        '
        Me.txtExistencia.Enabled = False
        Me.txtExistencia.Location = New System.Drawing.Point(128, 89)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Size = New System.Drawing.Size(160, 22)
        Me.txtExistencia.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(128, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(365, 22)
        Me.txtNombre.TabIndex = 8
        '
        'lblGranTotal
        '
        Me.lblGranTotal.AutoSize = True
        Me.lblGranTotal.Location = New System.Drawing.Point(600, 139)
        Me.lblGranTotal.Name = "lblGranTotal"
        Me.lblGranTotal.Size = New System.Drawing.Size(97, 17)
        Me.lblGranTotal.TabIndex = 9
        Me.lblGranTotal.Text = "Total a pagar:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(576, 401)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(138, 31)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.Enabled = False
        Me.btnComprar.Location = New System.Drawing.Point(379, 401)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(138, 31)
        Me.btnComprar.TabIndex = 11
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnVerInventario
        '
        Me.btnVerInventario.Location = New System.Drawing.Point(182, 401)
        Me.btnVerInventario.Name = "btnVerInventario"
        Me.btnVerInventario.Size = New System.Drawing.Size(138, 31)
        Me.btnVerInventario.TabIndex = 12
        Me.btnVerInventario.Text = "Ver inventario"
        Me.btnVerInventario.UseVisualStyleBackColor = True
        '
        'cboId
        '
        Me.cboId.FormattingEnabled = True
        Me.cboId.Location = New System.Drawing.Point(128, 31)
        Me.cboId.Name = "cboId"
        Me.cboId.Size = New System.Drawing.Size(261, 24)
        Me.cboId.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(603, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(606, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Subtotal"
        '
        'txtCantidadComprar
        '
        Me.txtCantidadComprar.Location = New System.Drawing.Point(673, 37)
        Me.txtCantidadComprar.Name = "txtCantidadComprar"
        Me.txtCantidadComprar.Size = New System.Drawing.Size(160, 22)
        Me.txtCantidadComprar.TabIndex = 16
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(672, 65)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(160, 22)
        Me.txtSubTotal.TabIndex = 17
        '
        'txtGranTotal
        '
        Me.txtGranTotal.Enabled = False
        Me.txtGranTotal.Location = New System.Drawing.Point(704, 139)
        Me.txtGranTotal.Name = "txtGranTotal"
        Me.txtGranTotal.Size = New System.Drawing.Size(129, 22)
        Me.txtGranTotal.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 444)
        Me.Controls.Add(Me.txtGranTotal)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtCantidadComprar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboId)
        Me.Controls.Add(Me.btnVerInventario)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblGranTotal)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtExistencia)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCaja)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Proyecto artículo, compra de productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtCaja As Windows.Forms.TextBox
    Friend WithEvents txtPrecio As Windows.Forms.TextBox
    Friend WithEvents txtExistencia As Windows.Forms.TextBox
    Friend WithEvents txtNombre As Windows.Forms.TextBox
    Friend WithEvents lblGranTotal As Windows.Forms.Label
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents btnComprar As Windows.Forms.Button
    Friend WithEvents btnVerInventario As Windows.Forms.Button
    Friend WithEvents cboId As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents txtCantidadComprar As Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As Windows.Forms.TextBox
    Friend WithEvents txtGranTotal As Windows.Forms.TextBox
End Class
