Module Module1

    Sub Main()
        Dim mes, anio As Integer
        Console.WriteLine("Mes")
        mes = Console.ReadLine()
        Console.WriteLine("Año")
        anio = Console.ReadLine()
        If anio Mod 4 = 0 And anio Mod 100 <> 0 Then
            Select Case mes
                Case 01
                    Console.WriteLine(31)
                Case 02
                    Console.WriteLine(29)
                Case 03, 05, 07, 09, 11
                    Console.WriteLine(31)
                Case 04, 06, 08, 10, 12
                    Console.WriteLine(30)

            End Select
        Else
            Select Case mes
                Case 01
                    Console.WriteLine(31)
                Case 02
                    Console.WriteLine(28)
                Case 03, 05, 07, 09, 11
                    Console.WriteLine(31)
                Case 04, 06, 08, 10, 12
                    Console.WriteLine(30)
            End Select
        End If
        Console.ReadKey()

    End Sub

End Module
