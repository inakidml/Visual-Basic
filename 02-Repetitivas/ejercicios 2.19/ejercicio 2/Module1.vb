Module Module1

    Sub Main()
        Console.Write("¿Cuantos número?: ")
        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
        Dim producto As Integer
        producto = 1
        For index As Integer = 0 To a - 1
            Console.Write("Escribe un número: ")
            producto = producto * Convert.ToInt32(Console.ReadLine())

        Next
        Console.WriteLine("producto = " & producto)
        Console.ReadKey()

    End Sub

End Module
