Module Module1

    Sub Main()

        'Introducir informacion para realizar el ejercicio

        Console.WriteLine("Introduce el valor de n1: ")
        Dim n1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de n2: ")
        Dim n2 As Integer = Integer.Parse(Console.ReadLine())

        If (n1 > n2) Then
            Console.WriteLine("El valor " & n1 & " es > que " & n2)
        Else
            If (n1 < n2) Then
                Console.WriteLine("El valor " & n1 & " es < que " & n2)
            Else
                Console.WriteLine("El valor " & n1 & " es == que " & n2)
            End If
        End If

        Console.ReadLine()

    End Sub

End Module
