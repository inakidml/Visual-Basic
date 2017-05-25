Module Module2
    Sub Main()
        Dim nAlumnos As Integer       'nro de alumnos (valor no negativo)

        nAlumnos = LeerEntero("Introducir el número de alumnos: ")

        Dim arrayNotas(nAlumnos - 1) As Single   ' crear el array notas

        Console.WriteLine(vbCrLf & "Introducir las notas medias del curso.")
        llenarArray(arrayNotas)

        ' Sumar las notas y calcular la media
        Dim media As Single = calcularNotaMedia(arrayNotas, nAlumnos)

        ' Visualizar la nota media del curso
        Console.WriteLine(vbCrLf & "Nota media del curso: " & media)

        Console.ReadLine()
    End Sub


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

    Private Function LeerSingle() As Single
        Try
            Return Single.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Single.NaN ' No es un Número valor Single.
        End Try
    End Function

    Private Function LeerSingle(ByVal mensaje As String) As Single
        Dim realPositivo As Single
        Do
            Try
                Console.Write(mensaje)
                realPositivo = Single.Parse(Console.ReadLine())
            Catch e As FormatException
                realPositivo = Single.MinValue
            Finally
                If (realPositivo = Single.MinValue Or realPositivo <= 0) Then
                    Console.Write("Será un valor positivo superior a 0, Repite... " & vbLf)
                End If
            End Try
        Loop While (realPositivo = Single.MinValue Or realPositivo <= 0)
        Return realPositivo
    End Function

    Private Sub llenarArray(ByRef notas As Single())
        For i = 0 To notas.Length - 1
            Do
                notas(i) = LeerSingle("Nota media del alumno <" & (i + 1) & ">: ")
                If notas(i) > 10 Then
                    Console.Write("Nota del alumno no superá el 10  " & vbCrLf)
                End If
            Loop While notas(i) > 10
        Next
    End Sub

    Private Function calcularNotaMedia(ByRef notas As Single(), ByVal nAlumnos As Integer) As Single

        Dim suma As Single

        For i = 0 To notas.Length - 1
            suma += notas(i)
        Next

        Return suma / nAlumnos

        'Return suma / notas.Length        'Se podría solucionar sin pasar el nro de alumnos
    End Function



End Module
