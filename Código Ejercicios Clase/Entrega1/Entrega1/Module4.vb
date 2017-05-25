Module Module4
    Sub Main()

        Dim nAlumnos As Integer

        nAlumnos = LeerEntero("Introducir número de alumnos en clase: ")

        ' Matriz de cadenas de caracteres
        Dim nombre(nAlumnos - 1) As String

        entradaDatosMatrizAlumnos(nombre)

        Console.WriteLine("El nro de alumnos introducidos es: " & nombre.Length)

        Dim respuesta As Char = deseaVisualizar()

        If (Char.ToLower(respuesta) = "s"c) Then
            visualizarTodosAlumnos(nombre)
        End If

        visulizaSeleccionAlumno(nombre)

        Console.WriteLine("Fin del programa... ")
        Console.ReadLine()
    End Sub


    Private Function LeerEntero() As Integer
        Try
            Return Int32.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Int32.MinValue      ' valor más pequeño
        End Try
    End Function

    Private Function LeerCaracter() As Char
        Try
            Return CChar(Console.ReadLine())
        Catch e As FormatException
            Return "!"c 'devuelvo un caracter cualquiera
        End Try
    End Function

    Private Function LeerEntero(ByVal mensaje As String) As Integer
        Dim enteroPositivo As Integer
        Do
            Try
                Console.Write(mensaje)
                enteroPositivo = Int32.Parse(Console.ReadLine())
            Catch e As FormatException
                enteroPositivo = Int32.MinValue
            Finally
                If (enteroPositivo = Int32.MinValue Or enteroPositivo <= 0) Then
                    Console.Write("Será un valor positivo superior a 0, Repite... " & vbCrLf)
                End If
            End Try
        Loop While (enteroPositivo = Int32.MinValue Or enteroPositivo <= 0)
        Return enteroPositivo

    End Function


    Private Sub entradaDatosMatrizAlumnos(ByRef nombre() As String)
        Dim x As Integer

        Console.WriteLine("Escriba los nombres que desea introducir.")
        Console.WriteLine("Puede finalizar pulsando las teclas [Ctrl]+[Z] antes de la entrada del alumno." & vbCrLf)

        For x = 0 To nombre.Length - 1
            Console.Write("Nombre(" & x & "): ")
            nombre(x) = Console.ReadLine()         'Si se introduce [Ctrl][Z] retorna Nothing
            ' Si se pulsó [Ctrl][Z], salir del bucle
            If (nombre(x) = Nothing) Then Exit For
        Next
        Console.WriteLine()

        'redefino la matriz con el número real de filas leídas
        If (x < nombre.Length) Then
            MsgBox("... " & x)
            ReDim Preserve nombre(x - 1)
        End If


    End Sub

    Private Function deseaVisualizar() As Char
        Dim respuesta As Char
        Do
            Console.Write("Desea visualizar la lista completa de alumnos < s / n > ")
            respuesta = CChar(Console.ReadLine())
            'respuesta = LeerCaracter()
        Loop While (Char.ToLower(respuesta) <> "s"c And Char.ToLower(respuesta) <> "n"c)
        Return respuesta
    End Function


    Private Sub visualizarTodosAlumnos(ByRef nombre() As String)
        ' Visualizar la lista de nombres
        Console.WriteLine()
        Dim elemento As String
        For Each elemento In nombre
            Console.WriteLine(elemento)
        Next


    End Sub
    Private Sub visulizaSeleccionAlumno(ByRef nombre As String())
        Dim nroAlumno As Integer
        Do
            Do
                Console.Write("Introduzca el número del alumno a visualizar (Cero para terminar) maximo <{0}> :  ", nombre.Length)
                nroAlumno = LeerEntero()
            Loop While (nroAlumno < 0 Or nroAlumno > nombre.Length) ' no permitir un valor negativo ni mayor que los introducidos
            If (nroAlumno <> 0) Then
                Console.WriteLine(nombre(nroAlumno - 1))
            End If

        Loop While (nroAlumno <> 0)
    End Sub
End Module
