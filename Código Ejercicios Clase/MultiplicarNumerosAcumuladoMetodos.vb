Module Module1


    Sub entradadatos(ByRef cant As Integer)

        Do

            Console.WriteLine("Introduce cuantos numeros quieres:")
            cant = Convert.ToInt32(Console.ReadLine)

            If cant < 1 Then
                Console.WriteLine("numero erroneo.....")
            End If

        Loop While (cant < 1)

    End Sub

    Function calcular(ByVal cant As Integer) As Integer
        Dim multi2 As Integer
        Dim num As Integer

        multi2 = 1

        For index = 1 To cant

            Console.WriteLine("Introduce numero: " & index)
            num = Convert.ToInt32(Console.ReadLine())

            multi2 = multi2 * num

        Next
        Return multi2
    End Function

    Sub calcularRef(ByVal cant As Integer, ByRef resultado As Integer)
        For index = 1 To cant
            Console.WriteLine("Introduce numero: " & index)
            resultado *= Convert.ToInt32(Console.ReadLine())
        Next

    End Sub
    Sub Main()

        Dim cant As Integer
        Dim multi2 As Integer
        Dim resultado As Integer = 1

        entradadatos(cant)
        multi2 = calcular(cant)
        calcularRef(cant, resultado)

        Console.WriteLine("la multiplicacion es: " & multi2)
        Console.WriteLine("La multiplicacion es: " & resultado)
        Console.ReadKey()


    End Sub

End Module
