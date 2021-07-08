Module Module1
    'PROYECTO: conversiones Bases Numericas
    'Descripcion: Programa para mostrar los valores del 1 al 20 en diferentes sistemas numéricos
    'Se emplean funciones definidas por el usuario para efectuar las conversiones númericas

    'ACTIVIDAD: Crear la función baseNa10() -> Funcion para convertir desde cualquier base a base 10
    'La función debe recibir 2 valores, en primer lugar el valor decimal a convertir y el segundo
    'la base numerica a convertir  (inicialmente solo serán base 2, 8 y 16)

    Sub Main()
        For x As Byte = 1 To 20
            Console.WriteLine("Decimal: {0}  {1} Octal: {2} {3}  Binario: {4}", x, vbTab, base8a10(x), vbTab, base2a10(x))

        Next
        Console.ReadKey(True)
    End Sub



    Function base2a10(ByVal valor) As String

        Dim divisor, dividendo, cociente, residuo As UShort
        Dim bin As String = ""

        divisor = 2
        dividendo = valor
        Do While dividendo >= divisor
            cociente = dividendo \ divisor
            residuo = dividendo Mod divisor
            dividendo = cociente

            If residuo <> 0 Then
                bin = "1" + bin
            Else
                bin = "0" + bin
            End If
        Loop
        bin = "1" + bin
        Return bin
    End Function


    Function base8a10(ByVal valor) As String

        Dim divisor, dividendo, cociente, residuo As UShort
        Dim oct As String = ""

        divisor = 8
        cociente = valor
        dividendo = valor

        Do While dividendo >= divisor
            cociente = dividendo \ divisor
            residuo = dividendo Mod divisor
            dividendo = cociente
            oct = CStr(residuo) + oct
        Loop
        oct = CStr(cociente) + oct
        Return oct
    End Function

    Function BaseNa10(ByVal valor) As string
	Dim divisor, dividiendo, cociente, residuo As Ushort
	Dim ocrt As String = ""

	divisor = 10
	cociente = valor
	dividendo = valor
	
	Do While dividendo >= divisor
	    cociente = dividendo \ divisor
	    residuo = dividendo Mod divisor
	    dividendo = cociente
	    

End Module
