Module Module1
    'Proyecto: ejemplos Practicos Ciclos
    '
    Sub Main()
        cocienteResto()
        Factorial()
        aBinario()      'ACTIVIDAD
    End Sub


    Sub cocienteResto()
        'Dados dos números enteros, realizar el algoritmo que calcule el cociente y el resto.
        'Método por restas sucesivas. El método sería restar sucesivamente el divisor del dividendo
        'hasta obtener un resultado menor que el divisor, que será el resto de la división; el número
        'de restas efectuadas será el cociente. Ver ejemplo problema 4.5 (Libro fundamentos de programacion)

        'ACTIVIDAD: Modificar el programa para que lea los datos de la operación (dividendo y divisor)

        Dim dividendoM, divisorN, cocienteQ, restoR As Double

        'Datos clavados (valores fijos para dividendo y divisor)
        dividendoM = 50
        divisorN = 11

        cocienteQ = 0
        restoR = dividendoM
        Do
            restoR = restoR - divisorN
            cocienteQ = cocienteQ + 1
        Loop Until restoR < divisorN
        Console.WriteLine("Dividendo: " & dividendoM)
        Console.WriteLine("Divisor: " & divisorN)
        Console.WriteLine("Cociente: " & cocienteQ)
        Console.WriteLine("Resto: " & restoR)
        Console.ReadKey(True)
    End Sub


    Sub Factorial()
        'Metodo 1:
        ' Calcular el factorial de un número n con el siguiente método
        '  n! = n x (n -1 ) x (n - 2) x ... 3 x 2 x 1

        'ACTIVIDAD: Modificar el programa para que lea el valor a calcular el factorial,
        'e imprima al final los valores del número original y el resultado.
        'Ejemplo:
        'Factorial de?    5
        'El factorial de 5 es 120


        Dim n As Double
        Dim fact As Double

        n = 5
        fact = n
        Do
            n = n - 1
            fact = fact * n
        Loop While (n > 1)
        Console.WriteLine("Factorial =  {1}", n, fact)
        Console.ReadKey(True)
    End Sub


    'ACTIVIDAD EXTRA. Busca otra formula para calculo de factorial y desarrolla el programa


    Sub aBinario()
        'ACTIVIDAD. Desarrollar un programa para convertir un número decimal a binario. 
        'Nota. Recuerda que un método para convertir es dividir sucesivamente el valor original entre 2
        'hasta que no sea divisible, y el resto de cada una de las divisiones es el resultado final
        'Investigar detalles del método.


    End Sub
End Module

