Module Module1

    Sub Main()
        Console.Write("Cuantas filas quieres que tenga?:")
        Dim filas As Integer = Convert.ToInt32(Console.ReadLine())
        Console.Write("Cuantas columnas quieres que tenga?:")
        Dim columnas As Integer = Convert.ToInt32(Console.ReadLine())
        Dim matriz(filas, columnas) As Integer
        rellenar(matriz, filas, columnas)
        visualizarMatriz(matriz, filas, columnas)
        Console.ReadKey()

    End Sub
    Sub rellenar(ByRef matriz(,) As Integer, ByVal filas As Integer, ByVal columnas As Integer)
        For indexF As Integer = 0 To filas - 1
            For indexC As Integer = 0 To columnas - 1
                Dim random As Integer = CInt(Math.Floor((100 - 0 + 1) * Rnd())) + 0
                matriz(indexF, indexC) = random
            Next
        Next
    End Sub

    Sub visualizarMatriz(ByRef matriz(,) As Integer, ByVal filas As Integer, ByVal columnas As Integer)
        Dim suma As Integer = 0
        For indexF As Integer = 0 To filas - 1
            For indexC As Integer = 0 To columnas - 1
                suma += matriz(indexF, indexC)
                Console.Write("{0,-5}", matriz(indexF, indexC))
            Next
            Console.WriteLine("suma fila: " & suma)
        Next
        Console.WriteLine("Suma columnas: ")
        suma = 0
        For indexC As Integer = 0 To columnas - 1
            For indexF As Integer = 0 To filas - 1

                suma += matriz(indexF, indexC)
            Next

            Console.Write("{0,-5}", suma)
        Next
    End Sub


End Module
