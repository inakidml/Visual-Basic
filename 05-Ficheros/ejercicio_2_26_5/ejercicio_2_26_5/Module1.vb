
Imports System.IO

Module Module1

    Sub Main()
        Dim opcion As String
        Dim codigo As Integer = 0 ' le sumamos uno al entrar en el do while si no leemos nada
        Dim nombre As String
        Dim direccion As String
        Dim telefono As Integer
        Dim edad As Integer

        Dim fs As FileStream
        openFilestream(fs)

        Dim tamanioReg As Integer = 100 'longitud en byte's del registro
        Dim nroRgtro As Integer = 1

        Dim br As BinaryReader = New BinaryReader(fs)
        nroRgtro = 1

        While (fs.Length > fs.Position)
            br.BaseStream.Seek((nroRgtro - 1) * tamanioReg, SeekOrigin.Begin)
            nroRgtro += 1
            codigo = br.ReadInt32()
            nombre = br.ReadString()
            direccion = br.ReadString()
            telefono = br.ReadInt32()
            edad = br.ReadInt32()
            Console.WriteLine("Codigo: " & codigo)
            Console.WriteLine("nombre: " & nombre)
            Console.WriteLine("direccion: " & direccion)
            Console.WriteLine("telefono: " & telefono)
            Console.WriteLine("edad: " & edad)
            Console.WriteLine()
        End While

        br.Close()
        fs.Close()
        openFilestream(fs)

        Dim bw As BinaryWriter
        bw = New BinaryWriter(fs)

        Do
            codigo += 1
            Console.WriteLine("1. codigo número: " & codigo)
            Console.Write("2. introduce el nombre: ")
            nombre = Console.ReadLine()
            Console.Write("3. introduce la direccion: ")
            direccion = Console.ReadLine()
            Console.Write("4. introduce el telefono: ")
            telefono = Convert.ToInt32(Console.ReadLine())
            Console.Write("5. introduce la edad: ")
            edad = Convert.ToInt32(Console.ReadLine())

            bw.BaseStream.Seek((nroRgtro - 1) * tamanioReg, SeekOrigin.Begin)
            bw.Write(codigo)
            bw.Write(nombre)
            bw.Write(direccion)
            bw.Write(telefono)
            bw.Write(edad)

            nroRgtro += 1

            Console.Write("6. ¿quieres meter otro?:(Y/N) ")
            opcion = (Console.ReadLine()).ToUpper
        Loop While (opcion <> "N")

        bw.Close()
        fs.Close()
        openFilestream(fs)

        br = New BinaryReader(fs)
        nroRgtro = 1

        While (fs.Length > fs.Position)
            br.BaseStream.Seek((nroRgtro - 1) * tamanioReg, SeekOrigin.Begin)
            nroRgtro += 1
            codigo = br.ReadInt32()
            nombre = br.ReadString()
            direccion = br.ReadString()
            telefono = br.ReadInt32()
            edad = br.ReadInt32()
            Console.WriteLine("Codigo: " & codigo)
            Console.WriteLine("nombre: " & nombre)
            Console.WriteLine("direccion: " & direccion)
            Console.WriteLine("telefono: " & telefono)
            Console.WriteLine("edad: " & edad)
            Console.WriteLine()
        End While

        br.Close()
        fs.Close()

        Console.ReadKey()

    End Sub

    Sub openFilestream(ByRef fs As FileStream)
        Try
            fs = New FileStream("C:\Users\8fdi02\Desktop\ejer2_26_5.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Catch ex As Exception
            Console.WriteLine("Parece que no existe el archivo")
            Console.WriteLine(ex)
            Try
                fs = New FileStream("C:\Users\8fdi02\Desktop\ejer2_26_5.dat", FileMode.Create, FileAccess.ReadWrite)
            Catch exc As Exception
                Console.WriteLine("Imposible crear archivo")
                Console.WriteLine(exc)
            End Try
        End Try
    End Sub



End Module
