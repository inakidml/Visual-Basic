Module Module1

    Sub Main()
        Dim a As Integer
        Dim producto As Integer
        producto = 1
        EntradaDatos(a, producto)
        VisualizarDatos(producto)


    End Sub
    Sub EntradaDatos(ByRef a As Integer, ByRef producto As Integer)
        Console.Write("¿Cuantos número?: ")
        a = Convert.ToInt32(Console.ReadLine())
        For index As Integer = 0 To a - 1
            Console.Write("Escribe un número: ")
            producto = producto * Convert.ToInt32(Console.ReadLine())

        Next
    End Sub

    Sub VisualizarDatos(ByVal producto As Integer)
        Console.WriteLine("producto = " & producto)
        Console.ReadKey()
    End Sub
End Module
