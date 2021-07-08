Module Module1
    'PROYECTO: articulos
    'DESCRIPCION: Programa que almacena 5 objetos de la clase articulos, para realizar compras e imprimir el total a pagar
    Sub Main()
        'VARIABLES LOCALES
        Dim nArt, cant As Integer
        Dim x As Integer = -1
        Dim encontrado As Boolean = False
        Dim sTotal As Double = 0
        Dim resp As Char = "S"

        'OBJETOS DE INVENTARIO
        Dim a(5) As articulo                    'declaracion de un arreglo de 6 elementos
        a(0) = New articulo(1, "hub usb", 5, 100.0)     'Se inicializan los valores del arreglo
        a(1) = New articulo(2, "mouse", 10, 250.0)
        a(2) = New articulo(3, "teclado", 7, 520.0)
        a(3) = New articulo(4, "cable usb", 5, 70.0)
        a(4) = New articulo(5, "cable utp", 12, 60.5)
        a(5) = New articulo()           'Solo para prueba, se declara uno con valores por omision


        'Se imprime el inventario
        Console.Clear()
        Console.WriteLine("{0,5} {1, 35} {2, 10} {3, 10}", "#Art", "Nombre del artículo", "Cantidad", "Precio")
        For x = 0 To 5
            a(x).imprimeLinea()
        Next
        Console.WriteLine("Artículos en stock: " & a(0).TotArticulos & vbCrLf & vbCrLf)


        'Se agrega un artículo de forma manual
        Console.WriteLine("Agregamos un artículo de forma manual")
        a(5).lectura()                  'Se leen por teclado el objeto declarado por omisión


        'CICLO PARA HACER LA COMPRA (se repite hasta que la respuesta de salida sea N)
        Do

            'Se imprime el inventario
            Console.Clear()
            Console.WriteLine("{0,-5} {1, 35} {2, 10} {3, 10}", "#Art", "Nombre del artículo", "Cantidad", "Precio")
            For x = 0 To 5
                a(x).imprimeLinea()
            Next
            Console.WriteLine("Artículos en stock: " & a(0).TotArticulos & vbCrLf & vbCrLf)


            'SE inicia/continua el proceso de compra
            Console.Write("Artículo que desea adquirir:")
            nArt = Console.ReadLine()
            For x = 0 To 5                      'Se valida que el numero de artículo exista
                If a(x).buscaNumero(nArt) Then
                    encontrado = True
                    Exit For
                End If
            Next

            If encontrado Then                  'Si encontro el artículo entonces se inicia la compra
                Console.WriteLine("Proceso de compra iniciado")
                Console.WriteLine("Artículo " & a(x).Nombre)
                Do                              'Valida que la cantidad a comprar no sea mayor a la existencia
                    Console.Write("Cantidad? (max-" & a(x).Cantidad & ")")
                    cant = Console.ReadLine()
                Loop Until cant <= a(x).Cantidad

                a(x).Cantidad -= cant                       'Descuenta la cantidad que se compro a la existencia
                sTotal = sTotal + (a(x).Precio * cant)      'Calcula el subtotal
            Else                                'Si no encontro el artículo manda un msje de error
                Console.WriteLine("El artículo no se encuentra en existencia...")
                Console.ReadLine()
            End If

            Console.WriteLine("Quiere hacer otra compra?")      'Preguntar si quiere comprar otro artículo
            resp = UCase(Console.ReadLine())
            Console.Clear()
        Loop Until resp = "N"

        'Imprime el subtotal de la compra
        Console.WriteLine("El total de su compra es: {0:c2}", sTotal)
        Console.ReadLine()

    End Sub

End Module
