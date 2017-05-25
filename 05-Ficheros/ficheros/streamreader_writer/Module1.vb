Imports System.IO

Module Module1

    Sub Main()


        Dim bufferBytes(100) As Byte
        Dim fs As FileStream
        Dim caracter As Integer
        Dim CR As Integer = 13 ' enter
        Console.Write("Escribe el nombre para el archivo: ")
        Dim fichero As String = Console.ReadLine()

        ' P6E20 lee datos del teclado y los graba en un fichero.
        ' Pide el nombre del fichero por consola.

        Console.WriteLine("Creando archivo...")
        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Create, FileAccess.Write)
        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al crear el fichero")
            Console.WriteLine(ex)
        End Try
        Console.Write("Texto a guardar: ")
        Dim sw As StreamWriter
        sw = New StreamWriter(fs)
        sw.WriteLine(Console.ReadLine())
        sw.Close() 'super importante cerrar el flujo
        fs.Close()

        'P6E21 lee datos del teclado y los añade al final del
        'fichero

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Append, FileAccess.Write)
        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al crear el fichero")
            Console.WriteLine(ex)
        End Try
        Console.Write("Ahora añadir mas texto: ")
        sw = New StreamWriter(fs)
        sw.WriteLine(Console.ReadLine())
        sw.Close() 'super importante cerrar el flujo
        fs.Close()

        ' P6E22 lee datos del fichero y los muestra en pantalla

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Open, FileAccess.Read)
        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al crear el fichero")
            Console.WriteLine(ex)
        End Try
        Dim sr As StreamReader
        sr = New StreamReader(fs)

        Dim cadena As String = sr.ReadToEnd()
        Console.Write(cadena)
        sr.Close()
        fs.Close()

        ' P6E23 lee datos del teclado y se graban en el fichero
        ' a través del flujo FileStream y lee del fichero y muestra
        ' en pantalla

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Append, FileAccess.Write)

        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al crear el fichero")
            Console.WriteLine(ex)
        End Try
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
        fs.Close()

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Open, FileAccess.Read)

        Catch ex As Exception
            Console.WriteLine("Algo ha fallado al crear el fichero")
            Console.WriteLine(ex)
        End Try
        sr = New StreamReader(fs)

        cadena = sr.ReadToEnd()
        Console.Write(cadena)
        sr.Close()
        fs.Close()



        Console.ReadKey()
    End Sub

End Module
