Module Module1

    Sub Main()

        'Introducir informacion para realizar el ejercicio

        Console.WriteLine("Introduce el valor de n1: ")
        Dim n1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de n2: ")
        Dim n2 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de n3: ")
        Dim n3 As Integer = Integer.Parse(Console.ReadLine())

        If (n1 < n2 And n2 < n3) Then
            ' n1 < n2 y n2 <n3
            Console.WriteLine("Secuencia CRECIENTE de n1: " & n1 & " n2: " & n2 & " y n3: " & n3)
        Else
            If (n1 = n2 And n2 = n3) Then
                ' n1 == n2  y n2 == n3 
                Console.WriteLine("Tienen valores IGUALES n1: " & n1 & " n2: " & n2 & " y n3: " & n3)
            Else
                If (n1 > n2 And n2 > n3) Then
                    ' n1 > n2 y n2 > n3
                    Console.WriteLine("Secuencia DECRECIENTE de n1: " & n1 & " n2: " & n2 & " y n3:" & n3)
                Else
                    If (n1 = n2 And n1 > n3) Then
                        'decreciente 
                        Console.WriteLine("Secuencia = DECRECIENTE >>> " & n1 & ", " & n2 & ", " & n3)
                    ElseIf (n1 = n2 And n1 < n3) Then
                        'creciente
                        Console.WriteLine("Secuencia = CRECIENTE  >>> " & n1 & ", " & n2 & ", " & n3)
                    ElseIf (n2 = n3 And n2 > n1) Then
                        'creciente
                        Console.WriteLine("Secuencia CRECIENTE =  >>> " & n1 & ", " & n2 & ", " & n3)
                    ElseIf (n2 = n3 And n2 < n1) Then
                        'decreciente
                        Console.WriteLine("Secuencia DECRECIENTE = >>> " & n1 & ", " & n2 & ", " & n3)
                    Else

                        Console.WriteLine("Sin ninguna secuencia  >>> " & n1 & ", " & n2 & ", " & n3)

                    End If
                End If
            End If
        End If
        Console.ReadLine()
    End Sub

End Module
