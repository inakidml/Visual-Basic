Module Module1

    Sub entradadatos(ByRef val1 As Integer, ByRef val2 As Integer)

        Do
            Console.WriteLine("Introduce un valor:")
            val1 = Convert.ToInt32(Console.ReadLine)

            Console.WriteLine("Introduce otro valor:")
            val2 = Convert.ToInt32(Console.ReadLine)

            If val1 >= val2 Then
                Console.WriteLine("Valores Erroneos")
            End If

        Loop While (val1 >= val2)

    End Sub

    Function operacion(ByVal val1 As Integer, ByVal val2 As Integer)
        Dim s As Integer
        For index = val1 To val2
            s = index + s
        Next
        Return s
        'operacion = s
    End Function

    Sub visualizar(sum As Integer)
        Console.WriteLine("La suma es:" & sum)
    End Sub

    Sub Main()



        Dim val1 As Integer
        Dim val2 As Integer
        'Dim suma As Integer

        entradadatos(val1, val2)
        'suma = operacion(val1, val2)
        'visualizar(suma)
        REM Pasamos el resultado de la funcion operacion al procedimiento
        visualizar(operacion(val1, val2))
        Console.ReadKey()

    End Sub

End Module
