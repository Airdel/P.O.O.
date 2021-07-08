Public Class Form1
    'OBJETOS DE INVENTARIO
    Dim a(5) As articulo                    'declaracion de un arreglo de 6 elementos
    Dim granTotal As Double = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a(0) = New articulo(1, "hub usb", 5, 100.0)     'Se inicializan los valores del arreglo
        a(1) = New articulo(2, "mouse", 10, 250.0)
        a(2) = New articulo(3, "teclado", 7, 520.0)
        a(3) = New articulo(4, "cable usb", 5, 70.0)
        a(4) = New articulo(5, "cable utp", 12, 60.5)
        a(5) = New articulo(6, "memoria USB", 19, 120.5)

        'Cargar datos en el combobox de id's
        For x As Byte = 0 To 5
            cboId.Items.Add(a(x).Numero.ToString)
        Next
    End Sub

    Private Sub btnVerInventario_Click(sender As Object, e As EventArgs) Handles btnVerInventario.Click
        Dim Mensaje As String = Nothing
        For x = 0 To 5
            Mensaje += "#id" & a(x).Numero & Space(4) & "Nombre:" & a(x).Nombre & Space(4)
            Mensaje += "Existencia:" & a(x).Cantidad & vbCrLf
        Next

        MsgBox(Mensaje, MsgBoxStyle.Information, "Inventario de artículos")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub rellenaComponentes()
        txtNombre.Text = a(cboId.SelectedItem - 1).Nombre
        txtExistencia.Text = a(cboId.SelectedItem - 1).Cantidad
        txtPrecio.Text = a(cboId.SelectedItem - 1).Precio
    End Sub

    Private Sub cboId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboId.SelectedIndexChanged
        rellenaComponentes()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Dim Mensaje As String = Nothing
        Dim x As Byte = cboId.SelectedItem - 1
        Dim subTotal As Double = 0

        If (txtCantidadComprar.Text > a(x).Cantidad) Then
            MsgBox("La cantidad excede la existencia de este producto", MsgBoxStyle.Critical, "Error")
        Else
            subTotal = a(x).Precio * txtCantidadComprar.Text
            granTotal += subTotal
            a(x).Cantidad -= txtCantidadComprar.Text

            txtSubTotal.Text = subTotal
            Mensaje = "#id" & a(x).Numero & Space(4) & "Nombre:" & a(x).Nombre & Space(4)
            Mensaje += "Cantidad:" & txtCantidadComprar.Text & vbCrLf
            'Actividad.
            'Agregar al Mensaje el subtotal del artículo comprado


            txtCaja.Text = txtCaja.Text + Mensaje
            txtGranTotal.Text = granTotal.ToString
            rellenaComponentes()
        End If
        txtCantidadComprar.Text = Nothing
        btnComprar.Enabled = False
    End Sub

    Private Sub txtCantidadComprar_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadComprar.TextChanged
        btnComprar.Enabled = True
    End Sub

    'ACTIVIDADES
    'Agregar un boton "Agregar artículo" a la forma
    'Agregar una forma nueva (form2) con los controles necesarios para
    'añadir productos nuevos 


End Class