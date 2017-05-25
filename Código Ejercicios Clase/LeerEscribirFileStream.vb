Imports System.IO

Module Module1

    Sub Main()
        Dim texto(9) As Byte
        Dim fichero As FileStream
        Dim caracter As Integer
        Dim posicion As Integer = 0
        Dim FinLectura As Integer = 13 'para parar de leer al pulsar intro

        'Para escribir en el fichero
        'Creamos el flujo al fichero
        fichero = New FileStream("C:\FicherosEjercicios\ficheroTexto.txt", FileMode.Create, FileAccess.Write)

        'Leemos caracter a caracter hasta que el usuario pulse intro
        caracter = Console.Read()
        While (caracter <> FinLectura And posicion < 10)
            texto(posicion) = Convert.ToByte(caracter)
            posicion += 1
            caracter = Console.Read()
        End While

        'Grabamos los datos leidos en el buffer de bytes 
        fichero.Write(texto, 0, texto.Length)
        'Cerramos el flujo hacia el fichero
        fichero.Close()

        'Para leer del fichero
        'Inicializamos el buffer donde vamos a almacenar la información leida
        texto.Clear(texto, 0, 10)

        'Abrimos el flujo para lectura
        fichero = New FileStream("C:\FicherosEjercicios\FicheroTexto.txt", FileMode.Open, FileAccess.Read)

        'Leemos en el buffer el contenido del fichero
        fichero.Read(texto, 0, 10)

        'Visualizamos el contenido del buffer leido
        For posicion = 0 To texto.Length - 1
            Console.Write(Convert.ToChar(texto(posicion)))
        Next
        Console.ReadKey()

        'Cerramos el flujo desde el fichero
        fichero.Close()

    End Sub

End Module
