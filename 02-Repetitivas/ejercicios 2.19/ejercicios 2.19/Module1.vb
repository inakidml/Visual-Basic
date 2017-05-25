Module Module1

    Sub Main()
        Console.Write("Escriba un número: ")
        Dim a As Integer = Convert.ToInt16(Console.ReadLine())
        Console.Write("Escriba otro número, mayor que el anterior: ")
        Dim b As Integer = Convert.ToInt16(Console.ReadLine())
        Dim suma As Integer
        If b > a Then
            Dim dif As Integer
            dif = b - a
            For index As Integer = 0 To dif
                Console.WriteLine(" " & a + index)
                suma += (a + index)
            Next
            Console.WriteLine(suma)
            Console.ReadKey()
        Else
            Console.WriteLine("Valores erroneos")

        End If
    End Sub

End Module
