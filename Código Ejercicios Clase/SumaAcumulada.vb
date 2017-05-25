Module Module1

    Sub Main()
        Dim cantidad As Integer
        Dim resultado As Double = 1
        Console.WriteLine("Indica cuántos números quieres introducir: ")
        cantidad = Convert.ToInt64(Console.ReadLine())
        For index = 1 To cantidad
            Console.WriteLine("Introduce un número: ")
            resultado *= Convert.ToDouble(Console.ReadLine())
        Next
        Console.WriteLine("El resultado de la multiplicación de todos los valores es: " & resultado)
        Console.ReadKey()
    End Sub

End Module
