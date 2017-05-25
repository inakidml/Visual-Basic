Module Module1

    Sub Main()

        Dim val1 As Integer
        Dim val2 As Integer
        Dim suma As Integer

        Do

            Console.WriteLine("Introduce un valor:")
            val1 = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine("Introduce otro valor:")
            val2 = Convert.ToInt32(Console.ReadLine)

            If val1 > val2 Then
                Console.WriteLine("Valores Erroneos, El primer valor tiene que ser más pequeño que el segundo")
            End If

        Loop While (val1 > val2)

        For index = val1 To val2

            'Console.WriteLine("-" & index)

            suma = suma + index

            'Console.WriteLine("-----" & suma)

        Next
        Console.WriteLine("-----" & suma)

        Console.ReadKey()


    End Sub

End Module
