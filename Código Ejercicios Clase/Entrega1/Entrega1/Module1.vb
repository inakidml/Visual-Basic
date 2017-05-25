Imports System.Environment

Module Module1

    Sub Main()
        Dim nElementos As Integer

        nElementos = LeerEntero("Número de elementos del Array: ")

        ' crear la matriz m
        Dim m(nElementos - 1) As Integer

        ' Introduce los datos en el Array
        llenarArray(m)

        ' Ordenar los elementos del Array
        Array.Sort(m)

        ' Visualizar los elementos del Array
        visualizarArray(m)


        Console.WriteLine(NewLine & "Fin del proceso.")
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
                    Console.Write("Será un valor positivo superior a 0, Repite... " & vbLf)
                End If
            End Try
        Loop While (enteroPositivo = Int32.MinValue Or enteroPositivo <= 0)
        Return enteroPositivo
    End Function

    Private Sub llenarArray(ByVal m As Integer())
        Console.WriteLine("Introducir los valores de la Array.")
        For i = 0 To m.Length - 1
            Console.Write("m(" & i & ") = ")
            m(i) = LeerEntero("")
        Next
    End Sub

    Private Sub visualizarArray(ByVal m As Integer())
        ' Visualizar los elementos de la Array
        Console.WriteLine()
        For i = 0 To m.Length - 1
            Console.Write(m(i) & " ")
        Next
        Console.WriteLine()
    End Sub

End Module
