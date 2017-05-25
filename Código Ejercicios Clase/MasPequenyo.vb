Module Module1

    Sub Main()

        Dim menor As Integer

        'Introducir informacion para realizar el ejercicio

        Console.WriteLine("Introduce el valor de n1: ")
        Dim n1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de n2: ")
        Dim n2 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de n3: ")
        Dim n3 As Integer = Integer.Parse(Console.ReadLine())

        If (n1 < n2) Then
            If (n1 < n3) Then
                menor = n1
            Else
                menor = n3
            End If
        Else
            If (n2 < n3) Then
                menor = n2
            Else
                menor = n3
            End If
        End If

        Console.WriteLine("El número más pequeño tecleado es {0}", menor)

        'Podriamos hacer también...
        If (n1 < n2 And n1 < n3) Then
            Console.WriteLine("El primer número tecleado es el más pequeño de los tres - " & n1)
        ElseIf (n2 < n1 And n2 < n3) Then
            Console.WriteLine("El segundo número tecleado es el más pequeño de los tres - " & n2)
        ElseIf (n3 < n1 And n3 < n2) Then
            Console.WriteLine("El tercer número tecleado es el más pequeño de los tres - " & n3)
        End If

        Console.ReadLine()

    End Sub

End Module
