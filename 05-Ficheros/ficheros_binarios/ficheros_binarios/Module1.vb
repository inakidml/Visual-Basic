Imports System.IO

Module Module1
    'U2P630 lee del teclado (nombre, apellido, edad) y graba a
    'través del flujo FileStream
    'U2P631 lee del fichero (nombre, apellido, edad) y muestra en
    'pantalla.Para detectar el EOF, lo haremos utilizando
    'EndOfStreamException o mediante las propiedades
    'del flujo Length y Position.
    'U2P632 lee del fichero (nombre, apellido, edad) y muestra en
    'pantalla.Utilizamos procedimiento para lectura
    'LeerString(br) y LeerInt16(br) y detectaremos el fin de
    'fichero sin utilizar EndOfStreamException, ni
    'propiedades del flujo
    'U2P633 lee del teclado (nombre, apellido, edad) y graba en
    'fichero, lee del fichero y muestra en pantalla.

    Sub Main()
        Console.Write("Escriba su nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.Write("Escriba su apellido: ")
        Dim apellido As String = Console.ReadLine()
        Console.Write("Escriba su edad: ")
        Dim edad As String = Console.ReadLine()
        Dim fs As FileStream
        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\binario1.dat", FileMode.Append, FileAccess.Write)
        Catch ex As Exception
            Console.WriteLine("Parece que no existe el archivo")
            Console.WriteLine(ex)
            Try
                fs = New FileStream("C:\Users\8fdi02\Desktop\binario1.dat", FileMode.Create, FileAccess.Write)
            Catch exc As Exception
                Console.WriteLine("Imposible crear archivo")
                Console.WriteLine(exc)
            End Try
        End Try

        Dim bw As BinaryWriter
        bw = New BinaryWriter(fs)
        bw.Write(nombre)
        bw.Write(apellido)
        bw.Write(edad)

        bw.Close()
        fs.Close()

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\binario1.dat", FileMode.Open, FileAccess.Read)
        Catch ex As Exception
            Console.WriteLine("No se ha podido abrir el archivo")
            Console.WriteLine(ex)
        End Try

        Dim br As BinaryReader
        br = New BinaryReader(fs)
        Dim nombreLeido As String
        Dim apellidoLeido As String
        Dim edadLeido As String
        'Console.WriteLine(fs.Length)
        'Console.WriteLine(fs.Position)
        Console.WriteLine("datos Leidos del archivo:")
        Console.WriteLine()
        Try
            While (fs.Length > fs.Position)
                nombreLeido = br.ReadString()
                apellidoLeido = br.ReadString()
                edadLeido = br.ReadString()
                Console.WriteLine("nombre: " & nombreLeido)
                Console.WriteLine("apellido: " & apellidoLeido)
                Console.WriteLine("edad: " & edadLeido)
                Console.WriteLine()
            End While
        Catch ex As EndOfStreamException
        End Try

        br.Close()
        fs.Close()

        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\binario1.dat", FileMode.Open, FileAccess.Read)
        Catch ex As Exception
            Console.WriteLine("No se ha podido abrir el archivo")
            Console.WriteLine(ex)
        End Try
        br = New BinaryReader(fs)
        Console.WriteLine("datos Leidos del archivo con peekChar:")
        Console.WriteLine()
        Try
            While (br.PeekChar <> -1)
                nombreLeido = br.ReadString()
                apellidoLeido = br.ReadString()
                edadLeido = br.ReadString()
                Console.WriteLine("nombre: " & nombreLeido)
                Console.WriteLine("apellido: " & apellidoLeido)
                Console.WriteLine("edad: " & edadLeido)
                Console.WriteLine()
            End While
        Catch ex As EndOfStreamException
        End Try
        br = New BinaryReader(fs)
        Console.ReadKey()
    End Sub


End Module
