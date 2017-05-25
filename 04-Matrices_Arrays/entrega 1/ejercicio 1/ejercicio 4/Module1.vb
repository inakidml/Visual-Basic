Module Module1

    Sub Main()
        Dim matriz As New ArrayList
        Dim salir As Boolean = False
        'Dim tecla As String = Console.ReadLine()


        Console.Write("¿cunatos alumnos? ")
        Dim tamanio As Integer = Console.ReadLine()
        Do
            Console.Write("¿nombre del alumno? ")
            Dim temp As String = Console.ReadLine()
            If temp = Nothing Then
                salir = True
            Else
                matriz.Add(temp)
            End If

            tamanio -= 1

        Loop While salir = False And tamanio > 0

        Console.Write("¿Quieres ver la lista ? (Y/N)")
        Dim lista As String = Console.ReadLine()
        If lista.ToUpper = "Y" Then
            visualizarMatriz(matriz)
        End If
        Console.Write("Desea ver el alumno introducido en la posición?: ")
        Dim pos As Integer = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine(pos & ".-  " & matriz(pos))
        Console.ReadKey()
    End Sub
    Sub visualizarMatriz(ByRef matriz As ArrayList)
        Dim contador As Integer
        For Each name In matriz
            Console.WriteLine(contador & ".-" & name)
            contador += 1
        Next
        Console.WriteLine()
    End Sub
End Module
