Module Module5
    Sub main()
        Dim nElementos As Integer   ' número de elementos (valor no negativo)

        Do
            Console.Write("Número de valores que desea introducir: ")
            nElementos = LeerEntero()
        Loop While (nElementos < 1)

        Dim matrizDato(nElementos - 1) As Single ' crear la matriz dato
        Dim max, min As Single ' valor máximo y valor mínimo

        nElementos = entradaDatosMatriz(matrizDato)

        obtenerMaximoMinimo(matrizDato, max, min, nElementos)
        If (nElementos > 0) Then
            ' Escribir los resultados 
            Console.WriteLine("Valor máximo: " & max)
            Console.WriteLine("Valor mínimo: " & min)

            ' valores máximo y valor mínimo utilizando las funciones
            Array.Sort(matrizDato)
            min = matrizDato(0)
            max = matrizDato(nElementos - 1)
            Console.WriteLine("Valor máximo..........: " & max)
            Console.WriteLine("Valor mínimo..........: " & min)
        Else
            Console.WriteLine("No hay datos.")
        End If

        Console.ReadLine()
    End Sub

    Private Function LeerEntero() As Integer
        Try
            Return Int32.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Int32.MinValue ' valor más pequeño
        End Try
    End Function
    Private Function LeerSingle() As Single
        Try
            Return Single.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Single.NaN ' valor no numerico
            'Single.MinValue() ' valor más pequeño
        End Try
    End Function

    Private Function entradaDatosMatriz(ByRef matrizDato() As Single) As Integer
        Dim x As Integer       ' subíndice
        Console.WriteLine("Introducir los valores. " &
                          "Para finalizar pulse [Entrar]")
        For x = 0 To matrizDato.Length - 1
            Console.Write("dato(" & x & ")= ")
            matrizDato(x) = LeerSingle()
            If (Single.IsNaN(matrizDato(x))) Then Exit For
        Next
        Return x ' número de valores leídos
    End Function

    Private Sub obtenerMaximoMinimo(ByVal matrizDato() As Single, ByRef max As Single, ByRef min As Single, ByVal nElementos As Integer)
        ' Obtener los valores máximo y mínimo
        min = matrizDato(0) : max = matrizDato(0)
        For x = 0 To nElementos - 1
            If (matrizDato(x) > max) Then max = matrizDato(x)
            If (matrizDato(x) < min) Then min = matrizDato(x)
        Next
    End Sub
End Module
