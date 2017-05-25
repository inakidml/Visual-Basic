Module Module3
    Sub Main()
        Dim fila As Integer
        Dim columna As Integer
        Dim sumaFilas As Integer = 0
        Dim sumaColumnas As Integer = 0
        Dim texto As String = ""
        Dim matriz = New Integer(9, 9) {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}, {2, 3, 4, 5, 6, 7, 8, 9, 0, 1}, {3, 4, 5, 6, 7, 8, 9, 0, 1, 2}, {4, 5, 6, 7, 8, 9, 0, 1, 2, 3}, {5, 6, 7, 8, 9, 0, 1, 2, 3, 4}, {6, 7, 8, 9, 0, 1, 2, 3, 4, 5}, {7, 8, 9, 0, 1, 2, 3, 4, 5, 6}, {8, 9, 0, 1, 2, 3, 4, 5, 6, 7}, {9, 0, 1, 2, 3, 4, 5, 6, 7, 8}}
        For i As Integer = 0 To 9
            For m As Integer = 0 To 9
                texto = texto & " " & matriz(i, m)
            Next
            Console.WriteLine(texto)
            texto = ""
        Next
        Console.WriteLine()
        Console.WriteLine("Indique un número de fila (1 al 10):")
        fila = Convert.ToInt16(Console.ReadLine())
        Console.WriteLine()
        Console.WriteLine("Indique un número de columna (1 al 10):")
        columna = Convert.ToInt16(Console.ReadLine())

        For m As Integer = 0 To 9
            sumaFilas = sumaFilas + matriz(fila, m)
        Next

        For i As Integer = 0 To 9
            sumaColumnas = sumaColumnas + matriz(i, columna)
        Next
        Console.WriteLine("La suma de los números de la fila " & fila & " es " & sumaFilas)
        Console.WriteLine("La suma de los números de la columna " & columna & " es " & sumaColumnas)
        Console.WriteLine("El total es de " & sumaFilas + sumaFilas)
        Console.ReadKey()
    End Sub
End Module
