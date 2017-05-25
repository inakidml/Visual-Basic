Module Module1

    Sub Main()
        Console.WriteLine("Introduce el valor entre el 1 y el 7: ")

        Dim nro As Integer = Integer.Parse(Console.ReadLine())


        Select Case (nro)
            Case 1
                Console.WriteLine("El día " & nro & " es lunes")
            Case 2
                Console.WriteLine("El día " & nro & " es martes")
            Case 3
                Console.WriteLine("El día " & nro & " es miercoles")
            Case 4
                Console.WriteLine("El día " & nro & " es jueves")
            Case 5
                Console.WriteLine("El día " & nro & " es viernes")
            Case 6
                Console.WriteLine("El día " & nro & " es sábado")
            Case 7
                Console.WriteLine("El día " & nro & " es domingo")
            Case Else
                Console.WriteLine("Numero fuera de rango")
        End Select

        Console.ReadLine()

    End Sub

End Module
