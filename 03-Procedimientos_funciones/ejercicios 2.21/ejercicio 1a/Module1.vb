Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim suma As Integer
        EntradaDatos(a, b)
        VisualizarDatos(operacion(a, b, suma))

    End Sub

    Sub EntradaDatos(ByRef a As Integer, ByRef b As Integer)
        Do
            Console.Write("Escriba un número: ")
            a = Convert.ToInt16(Console.ReadLine())
            Console.Write("Escriba otro número, mayor que el anterior: ")
            b = Convert.ToInt16(Console.ReadLine())
            If b > a Then
                Console.WriteLine("Valores Correctos")
            Else
                Console.WriteLine("Valores erroneos")
                Console.ReadKey()

            End If
        Loop While a > b

    End Sub

    Function operacion(ByVal a As Integer, ByVal b As Integer, ByRef suma As Integer) As Integer
        Dim dif As Integer
        dif = b - a
        For index As Integer = 0 To dif
            Console.WriteLine(" " & a + index)
            suma += (a + index)
        Next
        operacion = suma
    End Function
    Sub VisualizarDatos(ByVal resultado As Integer)
        Console.WriteLine(resultado)
        Console.ReadKey()
    End Sub

End Module
