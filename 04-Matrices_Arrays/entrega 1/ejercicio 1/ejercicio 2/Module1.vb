Module Module1

    Sub Main()
        Dim tamanio As Integer
        pedirTamanio(tamanio)
        Dim matriz As New ArrayList
        rellenar(matriz, tamanio)
        Dim media As Double = 0
        visualizarNotaMedia(matriz, media)

    End Sub
    Sub rellenar(ByRef matriz As ArrayList, tamanio As Integer)
        For indexA As Integer = 0 To tamanio - 1
            Console.Write("Introduzca un valor: ")
            matriz.Add(Console.ReadLine())
        Next
    End Sub

    Sub visualizarNotaMedia(ByRef matriz As ArrayList, media As Double)
        Dim contador As Integer = 0
        For Each number In matriz
            media += number
            contador += 1
        Next
        media = media / contador
        Console.Write("La nota media es:  " & media)
        Console.WriteLine()
        Console.ReadKey()
    End Sub

    Sub pedirTamanio(ByRef tamanio As Integer)
        Console.Write("¿Cuantos alumnos?: ")
        tamanio = Convert.ToInt32(Console.ReadLine())
    End Sub
End Module
