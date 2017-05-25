Module Module1

    Sub Main()

        Console.WriteLine("Introduce el valor n1 positivo: ")
        Dim n1 As Integer = Integer.Parse(Console.ReadLine())

        If (n1 <= 0) Then
            Console.WriteLine("El valor " & n1 & " no es positivo ya que es inferior o igual a 0")
        Else
            Dim rto As Integer = n1 Mod 2
            If (rto = 0) Then
                Console.WriteLine("El valor de n1: " & n1 & " es PAR")
            Else
                Console.WriteLine("El valor de n1: " & n1 & " es IMPAR")
            End If
        End If

        Console.ReadLine()

    End Sub

End Module
