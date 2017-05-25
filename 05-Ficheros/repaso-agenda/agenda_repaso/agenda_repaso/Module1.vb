Imports System.IO

Module Module1
    Structure contacto
        Dim codigo As Integer
        Dim nombre As String
        Dim numero As Integer
    End Structure
    Sub Main()
        Dim codigo As Integer = 0
        Dim ultimoCodigoFichero As Integer = 0
        Dim opcion As Integer
        Dim contactos As New ArrayList
        Dim contactosNuevos As New ArrayList
        Dim tamanio As Int32 = 100
        Dim registro As Int32 = 1

        'filestream para poder leer o escribir
        Dim fs As FileStream

        'leemos fichero y volcamos a arraylist contactos
        leerFichero(fs, contactos, registro, tamanio, codigo, ultimoCodigoFichero)

        'menu
        Do
            System.Console.WriteLine("1. introducir nuevo")
            System.Console.WriteLine("2. modificar")
            System.Console.WriteLine("3. buscar")
            System.Console.WriteLine("4. listar")
            System.Console.WriteLine("9. salir")
            System.Console.Write("opcion: ")
            opcion = Console.ReadLine()

            Select Case opcion
                Case "1" ' añadir
                    aniadirContacto(contactosNuevos, codigo)'añade contacto a arraylist contactosNuevos
                Case "2" ' modificar

                    Dim codMod As Integer
                    listarContactos(contactos, contactosNuevos)
                    Console.Write("seleccione un contacto (Codigo): ")
                    Try
                        codMod = CInt(Console.ReadLine())
                    Catch ex As Exception
                    End Try
                    Dim indexOF As Integer
                    If codMod > ultimoCodigoFichero Then 'si no era del fichero lo modificamos en el arraylist contactos nuevos
                        'podría haber grabado a disco todo primero y luego modificar solo en disco y volver a leer
                        For Each contacto In contactosNuevos
                            If contacto.codigo = codMod Then
                                indexOF = contactosNuevos.IndexOf(contacto) 'buscamos el indice
                                'TODO validar que ha escrito bien y existe el indexof
                            End If
                        Next
                        Dim contactoTemp As contacto 'creamos contacto temporal
                        contactoTemp.numero = 0
                        contactoTemp.codigo = codMod
                        Console.Write("Introduce el nombre: ")
                        contactoTemp.nombre = Console.ReadLine()
                        Do
                            Try
                                Console.Write("Introduce el número ")
                                contactoTemp.numero = CInt(Console.ReadLine())
                            Catch ex As Exception
                                Console.WriteLine("maaal")
                            End Try
                        Loop While contactoTemp.numero = 0
                        'TODO validar indexOf
                        contactosNuevos.RemoveAt(indexOF) 'borramos el antiguo
                        contactosNuevos.Insert(indexOF, contactoTemp) 'introducimos el nuevo
                    Else                            ' si en codigo pertenece al fichero
                        For Each contacto In contactos
                            If contacto.codigo = codMod Then
                                indexOF = contactos.IndexOf(contacto) ' buscamos el indice del array
                                'TODO validar que ha escrito bien y existe el indexof
                            End If
                        Next
                        Dim contactoTemp As contacto  'contacto temporal
                        contactoTemp.numero = 0
                        contactoTemp.codigo = codMod
                        Console.Write("Introduce el nombre: ")
                        contactoTemp.nombre = Console.ReadLine()
                        Do
                            Try
                                Console.Write("Introduce el número ")
                                contactoTemp.numero = CInt(Console.ReadLine())
                            Catch ex As Exception
                                Console.WriteLine("maaal")
                            End Try
                        Loop While contactoTemp.numero = 0

                        'TODO validar indexOf 
                        contactos.RemoveAt(indexOF) 'borramos el antiguo
                        contactos.Insert(indexOF, contactoTemp) 'lo insertamos en el array
                        modificarFichero(fs, tamanio, contactoTemp, codMod) ' lo insertamos en el fichero
                    End If
                Case "3" ' buscar
                    Dim buscar As String
                    Dim codigoBuscar As Integer
                    Dim nombreBuscar As String
                    Dim encontrado As Boolean = False
                    Do
                        System.Console.WriteLine("1. por codigo")
                        System.Console.WriteLine("2. por nombre")
                        System.Console.WriteLine("3. volver")
                        buscar = Console.ReadLine()
                        Select Case buscar
                            Case "1" ' por código
                                Console.WriteLine("Escribe el código:")
                                Try
                                    codigoBuscar = CInt(Console.ReadLine)
                                Catch ex As Exception
                                End Try
                                For Each contacto In contactos
                                    If contacto.codigo = codigoBuscar Then
                                        Console.WriteLine("Codigo: {0}", contacto.codigo)
                                        Console.WriteLine("Nombre: {0}", contacto.nombre)
                                        Console.WriteLine("Número: {0}", contacto.numero)
                                        encontrado = True
                                    End If
                                Next
                                If encontrado = False Then
                                    For Each contacto In contactosNuevos
                                        If contacto.codigo = codigoBuscar Then
                                            Console.WriteLine("Codigo: {0}", contacto.codigo)
                                            Console.WriteLine("Nombre: {0}", contacto.nombre)
                                            Console.WriteLine("Número: {0}", contacto.numero)
                                            encontrado = True
                                        End If
                                    Next
                                End If
                                encontrado = False
                            Case "2" ' por nombre
                                Console.WriteLine("Escribe el nombre:")

                                nombreBuscar = Console.ReadLine.ToLower

                                For Each contacto In contactos
                                    If contacto.nombre.ToLower = nombreBuscar Then
                                        Console.WriteLine("Codigo: {0}", contacto.codigo)
                                        Console.WriteLine("Nombre: {0}", contacto.nombre)
                                        Console.WriteLine("Número: {0}", contacto.numero)
                                        encontrado = True
                                    End If
                                Next
                                If encontrado = False Then
                                    For Each contacto In contactosNuevos
                                        If contacto.codigo = codigoBuscar Then
                                            Console.WriteLine("Codigo: {0}", contacto.codigo)
                                            Console.WriteLine("Nombre: {0}", contacto.nombre)
                                            Console.WriteLine("Número: {0}", contacto.numero)
                                            encontrado = True
                                        End If
                                    Next
                                End If
                                encontrado = False
                            Case Else
                                buscar = "3"
                        End Select
                    Loop While buscar <> "3"
                Case "4" ' listar
                    listarContactos(contactos, contactosNuevos)
                    'Console.WriteLine("registro {0}", registro)
                Case "9" ' salir
                    If contactosNuevos.Count <> 0 Then ' solo grabamos si se han añadido nuevos
                        grabarFichero(fs, contactosNuevos, registro, tamanio)
                    End If
                    Console.WriteLine("Fin del programa")
                Case Else
                    Console.WriteLine("escriba otra vez")
            End Select
        Loop While opcion <> 9
        Console.ReadKey()

    End Sub
    Sub aniadirContacto(ByRef contactosNuevos As ArrayList, ByRef codigo As Integer) ' añadimos contacto a array contactosNuevos
        Dim contactoTemp As contacto
        codigo += 1
        contactoTemp.numero = 0
        contactoTemp.codigo = codigo
        Console.Write("Introduce el nombre: ")
        contactoTemp.nombre = Console.ReadLine()
        Do
            Try
                Console.Write("Introduce el número ")
                contactoTemp.numero = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("maaal")
            End Try
        Loop While contactoTemp.numero = 0

        contactosNuevos.Add(contactoTemp)
    End Sub
    Sub listarContactos(ByRef contactos As ArrayList, ByRef contactosNuevos As ArrayList) ' listamos contactos del array contactos(leido del disco) y luego de contactosNuevos
        For Each contacto As contacto In contactos
            Console.WriteLine("el contacto número {0} se llama {1} y su número es {2}", contacto.codigo, contacto.nombre, contacto.numero)
        Next
        For Each contacto In contactosNuevos
            Console.WriteLine("el contacto número {0} se llama {1} y su número es {2}", contacto.codigo, contacto.nombre, contacto.numero)
        Next
    End Sub
    Sub grabarFichero(ByRef fs As FileStream, ByRef contactosNuevos As ArrayList, ByRef registro As Integer, ByVal tamanio As Integer)
        'volcamos a fichero a partir del ultimo registro leido el contenido de contactosNuevos
        Console.WriteLine("Grabando fichero...")
        fs = New FileStream("agenda.dat", FileMode.Open, FileAccess.Write)
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        For Each contacto In contactosNuevos
            ' Console.WriteLine("contacto numero {0}", contacto.codigo)
            bw.BaseStream.Seek((registro - 1) * tamanio, SeekOrigin.Begin)
            registro += 1
            bw.Write(contacto.codigo)
            bw.Write(contacto.nombre)
            bw.Write(contacto.numero)
        Next
        bw.Close()
        fs.Close()
        Console.WriteLine("Hecho")
    End Sub
    Sub modificarFichero(ByRef fs As FileStream, ByVal tamanio As Integer, ByRef contacto As contacto, ByRef codMod As Integer)
        'si se modifica un contacto que estaba en disco, lo grabamos
        Console.WriteLine("Grabando fichero...")
        fs = New FileStream("agenda.dat", FileMode.Open, FileAccess.Write)
        Dim bw As BinaryWriter = New BinaryWriter(fs)

        bw.BaseStream.Seek((codMod - 1) * tamanio, SeekOrigin.Begin)

        bw.Write(contacto.codigo)
        bw.Write(contacto.nombre)
        bw.Write(contacto.numero)

        bw.Close()
        fs.Close()
        Console.WriteLine("Hecho")
    End Sub
    Sub leerFichero(ByRef fs As FileStream, ByRef contactos As ArrayList, ByRef registro As Integer, ByVal tamanio As Integer, ByRef codigo As Integer, ByRef UltimoCodigoFichero As Integer)
        'leemos todo el contanido del fichero y lo volcamos al array contactos
        fs = New FileStream("agenda.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim contacto As contacto
        While fs.Length > fs.Position
            'Console.WriteLine(fs.Length)
            'Console.WriteLine(fs.Position)
            br.BaseStream.Seek((registro - 1) * tamanio, SeekOrigin.Begin)
            registro += 1
            contacto.codigo = br.ReadInt32()
            codigo = contacto.codigo
            UltimoCodigoFichero = contacto.codigo
            contacto.nombre = br.ReadString()
            contacto.numero = br.ReadInt32()
            contactos.Add(contacto)
        End While
        br.Close()
        fs.Close()
    End Sub
End Module
