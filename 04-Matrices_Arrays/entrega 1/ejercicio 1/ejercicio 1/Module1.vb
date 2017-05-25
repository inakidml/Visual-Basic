Module Module1

    Sub Main()
        Dim tamanio As Integer
        pedirTamanio(tamanio)
        Dim matriz As New ArrayList
        rellenar(matriz, tamanio)
        visualizarMatriz(matriz)

    End Sub
    Sub rellenar(ByRef matriz As ArrayList, tamanio As Integer)
        For indexA As Integer = 0 To tamanio - 1
            Console.Write("Introduzca un valor: ")
            matriz.Add(Console.ReadLine())
        Next
    End Sub

    Sub visualizarMatriz(ByRef matriz As ArrayList)
        matriz.Sort()
        For Each number In matriz
            Console.Write(number & " ")
        Next
        Console.WriteLine()
        Console.ReadKey()
    End Sub

    Sub pedirTamanio(ByRef tamanio As Integer)
        Console.Write("Tamanio del array: ")
        tamanio = Convert.ToInt32(Console.ReadLine())
    End Sub
End Module
