Public Class Computadora

    Private idComputadora As Long
    Private marcaComputadora As String
    Private modeloComputadora As String
    Private fechaAdquisicionPC As Date
    Private tipoComputadora As Char

    '|----------------------------------------|
    '                Propiedades

    Public Property ID() As Long
        Get
            Return idComputadora 
        End Get
        Set(ByVal value As Long)
            If (value >= 0) Then
                idComputadora = value
            Else
                System.Math.Abs(value)
            End If
        End Set
    End Property

    Public Property marca() As String
        Get
            'If de marca
        End Get
        Set(ByVal value As String)
            marcaComputadora = value
        End Set
    End Property

    Public Property modelo() As String
        Get
            Return marcaComputadora
        End Get
        Set(ByVal value As String)
            If (value = "Dell" Or value = "hp" Or value = "acer" Or value = "alienware") Then
                marcaComputadora = value
            Else
                marcaComputadora =  

        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return fechaAdquisicionPC
        End Get
        Set(ByVal value As Date)
            fechaAdquisicionPC = value
        End Set
    End Property

    Public Property tipo As Char
        Get
            Return tipoComputadora
        End Get
        Set(ByVal value As Char)
            If (value = "L" Or value = "E" Or value = "T" Or value = "C") Then
                tipoComputadora = "value"
            Else
                tipoComputadora = "L"
            End If

        End Set
    End Property



End Class
