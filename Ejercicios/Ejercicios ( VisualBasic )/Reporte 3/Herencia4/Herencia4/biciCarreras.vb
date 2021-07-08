Public Class biciCarreras : Inherits bicicleta
    Dim numCambios As Byte

    Public Property Cambios As Byte
        Get
            Return numCambios
        End Get
        Set(ByVal value As Byte)
            numCambios = value
        End Set
    End Property

    Public Sub New()
        numCambios = 1
    End Sub

    Public Sub New(ByVal numC As Byte, ByVal marB As String, ByVal modB As String, ByVal rodB As Byte)
        MyBase.New(marB, modB, rodB)
        numCambios = numC
    End Sub

    Public Shadows Sub AsignaDatos(ByVal numC As Byte, ByVal marB As String, ByVal modB As String, ByVal rodB As Byte)
        MyBase.AsignaDatos(marB, modB, rodB)
        numCambios = numC
    End Sub

    Public Shadows Sub dameDatos(ByRef numC As Byte, ByRef marB As String, ByRef modB As String, ByRef rodB As Byte)
        marB = marcaB
        modB = modeloB
        rodB = rodadaB
        numC = numCambios
    End Sub

End Class
