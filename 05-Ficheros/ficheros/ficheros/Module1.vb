Imports System.IO

Module Module1




    Sub Main()

        Dim bufferBytes(100) As Byte
        Dim fs As FileStream
        Dim caracter As Integer
        Dim CR As Integer = 13 ' enter

        crearAbrirFichero(fs)

        Dim contador As Integer
        Console.Write("Escribe algo: ")
        caracter = Console.Read()
        While (caracter <> CR And contador < 100)
            bufferBytes(contador) = Convert.ToByte(caracter)
            contador += 1
            caracter = Console.Read()
            Console.WriteLine(caracter)
        End While
        Console.WriteLine("escribiendo archivo...")
        Try
            fs.Write(bufferBytes, 0, bufferBytes.Length)
        Catch ex As Exception
        End Try
        Try
            fs.Close()
        Catch ex As Exception

        End Try
        crearAbrirFichero(fs)
        Console.WriteLine("Leyendo archivo....")
        fs.Read(bufferBytes, 0, fs.Length)
        Dim caracterLeido As Char
        For Each n In bufferBytes
            caracterLeido = Convert.ToChar(n)
            Console.WriteLine(caracterLeido)
        Next

        Console.WriteLine("cerrando archivo...")
        Try
            fs.Close()
        Catch ex As Exception

        End Try
        Console.ReadKey()
    End Sub
    Function crearAbrirFichero(ByRef fs As FileStream) As Boolean

        Try
            Console.WriteLine("abriendo archivo...")
            'fs = New FileStream("C:\Users\8fdi02\Desktop\prueba_fichero.txt", FileMode.Open, FileAccess.ReadWrite)
            fs = New FileStream("C:\Users\txiki\Desktop\prueba_fichero.txt", FileMode.Open, FileAccess.ReadWrite)
            Console.WriteLine("Ok")
        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al abrir el fichero")
            Console.WriteLine(ex)
            Try
                Console.WriteLine("Intentando crearlo")
                fs = New FileStream("C:\Users\txiki\Desktop\prueba_fichero.txt", FileMode.Create, FileAccess.ReadWrite)
                'fs = New FileStream("C:\Users\8fdi02\Desktop\prueba_fichero.txt", FileMode.Create, FileAccess.ReadWrite)
                Console.WriteLine("Ok")
            Catch exc As Exception
                Console.WriteLine("Algo ha fallado al crear el archivo")
                Console.WriteLine(exc)
            End Try
        End Try
    End Function


End Module
