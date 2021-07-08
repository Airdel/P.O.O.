Imports Microsoft.VisualBasic

Public Class Class1
    Private nomPista As String
    Private intPista As String
    Private durPista As Decimal
    Private genPista As Char
    'Propiedades
    Public Property Nombre As String
        Get
            Return nomPista
        End Get
        Set(ByVal value As String)
            nomPista = value
        End Set
    End Property

    Public Property Interprete As String
        Get
            Return intPista
        End Get
        Set(ByVal value As String)
            intPista = value
        End Set
    End Property

    Public Property duracion As Decimal
        Get
            Return durPista
        End Get
        Set(value As Decimal)
            If (value >= 0.3 And value <= 40) Then
                durPista = value
            Else
                durPista = 0
            End If
        End Set
    End Property

    Public Property Genero As Char
        Get
            Return genPista
        End Get
        Set(value As Char)
            Select Case value
                Case "P"
                    genPista = value

                Case "R"
                    genPista = value

                Case "M"
                    genPista = value

                Case Else
                    genPista = "V"
            End Select
        End Set
    End Property
    'Constructores
    'Constructor por omision
    Public Sub New()
        Nombre = "Our Let It Be"
        duracion = 2.35
        Genero = "P"
        Interprete = "ArIA"
    End Sub

    'Constructor Parametrizado
    Public Sub New(ByVal nom As String, ByVal dur As Decimal, ByVal int As String, ByVal gen As Char)
        Nombre = nom
        duracion = dur
        Interprete = int
        Genero = gen
    End Sub

    'Asigna Datos
    Public Sub asignaDatos(ByVal nom As String, ByVal dur As Decimal, ByVal gen As Char, ByVal int As String)
        Nombre = nom
        duracion = dur
        Genero = gen
        Interprete = int
    End Sub
End Class
