Public Class clientes
    Private idCliente As Long
    Private nomCliente As String
    Private domCliente As String
    Private telcliente As String
    Private numCliente As String

    'Funciones miembro

    Public Sub leerCliente()
        Console.Write("Numero de cliente: ")
        idCliente = Console.ReadLine()
        Console.Write("Nombre: ")
        nomCliente = Console.ReadLine()
        Console.Write("Domicilio: ")
        domCliente = Console.ReadLine()

    End Sub
    Public Sub imprimirCliente()
        Console.WriteLine("El cliente # {0} {1} vive en {2}", idCliente, numCliente, domCliente)

    End Sub
    Public Sub asignarCliente(ByVal idC As Long, ByVal domC As String, ByVal numC As String, ByVal nomC As String)
        idCliente = idC
        nomCliente = nomC
        domCliente = domC
        telcliente = numC

    End Sub
End Class
