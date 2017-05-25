Module Module1

    Sub Main()
        Console.Write("Introduce el mes en formato numerico del 1 al 12: ")
        Dim mes As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Introduce el año: ")
        Dim anyo As Integer = Integer.Parse(Console.ReadLine())

        Select Case mes
            Case 1, 3, 5, 7, 9, 11
                Console.WriteLine("El mes introducido tiene 31 días")
            Case 4, 6, 8, 10, 12
                Console.WriteLine("El mes introducido tiene 30 días")
            Case 2
                If anyo Mod 4 = 0 AndAlso (anyo Mod 100 <> 0 Or anyo Mod 400 = 0) Then
                    Console.WriteLine("El mes introducido tiene 29 días")
                Else
                    Console.WriteLine("El mes introducido tiene 28 días")
                End If

        End Select

        Console.ReadLine()

    End Sub

End Module
