Module Module1

    Sub Main()
        Dim tamanio As Integer
        Dim dimension As Integer
        pedirTamanio(tamanio, dimension)
        Dim matriz(tamanio - 1, tamanio - 1, dimension - 1) As Integer
        rellenar(matriz, tamanio, dimension)
        visualizarMatriz(matriz, tamanio, dimension)
    End Sub

    REM - mal, tenía que pedir las dimensiones, no las columnas

    Sub pedirTamanio(ByRef tamanio As Integer, ByRef dimension As Integer)
        Console.Write("Tamanio del array: ")
        tamanio = Convert.ToInt32(Console.ReadLine())
        Do
            Console.Write("Dimension del array: ")
            dimension = Convert.ToInt32(Console.ReadLine())
        Loop While dimension <= 0 And dimension > 3
    End Sub

    Sub rellenar(ByRef matriz(,,) As Integer, ByVal tamanio As Integer, ByVal dimension As Integer)
        REM Console.Write(tamanio & dimension)
        For indexD As Integer = 0 To dimension - 1
            For indexF As Integer = 0 To tamanio - 1
                For indexC As Integer = 0 To tamanio - 1
                    Console.Write("Introduzca un valor: ")
                    matriz(indexF, indexC, indexD) = Console.ReadLine()
                Next
            Next
        Next
    End Sub

    Sub visualizarMatriz(ByRef matriz(,,) As Integer, ByVal tamanio As Integer, ByVal dimension As Integer)
        For indexD As Integer = 0 To dimension - 1
            For indexF As Integer = 0 To tamanio - 1
                For indexC As Integer = 0 To tamanio - 1
                    Console.Write(matriz(indexF, indexC, indexD) & " ")
                Next
                Console.WriteLine()
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()

    End Sub
End Module
