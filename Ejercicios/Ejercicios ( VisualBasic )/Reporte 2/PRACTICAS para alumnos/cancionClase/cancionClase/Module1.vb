Module Module1
    'PROYECTO:  cancionClase
    'Programa para mostrar y practicar la creación de una clase y sus miembros
    'Completa las partes que se te indiquen


    Sub Main()
        'Crear (instanciar) un nuevo objeto-> miCancion de la clase cancion
        Dim miCancion As cancion

        miCancion = New cancion()      'Primero ejecuten el programa sin quitar el comentario inicial, verificar el error, despúes quitenlo y verifiquen que este bien
        
        

        'Dando valores iniciales al objeto
        miCancion.Nombre = "Our Let It Be"   'Cambiar por el nombre de tu canción favorita
        miCancion.Duracion = 4.45       'Duración de la canción, cambiar por el valor de tu canción
        miCancion.Genero = "O"
        miCancion.Fecha = 05-12-2016
        'completar los valores iniciales  (recuerda de que se deben hacer primero sus propiedades-Property)


        miCancion.imprimeDatos()
        miCancion.Leedatos()
        miCancion.AsignaDatos()
        miCancion.imprimeDatos()

    End Sub

End Module
