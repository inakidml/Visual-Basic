Module Module1

    Sub Main()
        Dim arraylist As New ArrayList
        Dim fin As Boolean = False
        Do
            Console.Write("Escribe un número o 'T' para terminar: ")
            Dim temp As String = Console.ReadLine()
            If temp.ToUpper = "T" Then
                fin = True
            Else
                Dim num As Integer = Convert.ToInt32(temp)
                arraylist.Add(num)
            End If
        Loop While fin = False
        arraylist.Sort()
        REM Console.WriteLine("ultimom valor = " & arraylist.Count)
        Console.ReadKey()
        Console.WriteLine("Valor máximo = " & arraylist(arraylist.Count() - 1))
        Console.WriteLine("Valor mínimo = " & arraylist(0))
        Console.ReadKey()
    End Sub

End Module
