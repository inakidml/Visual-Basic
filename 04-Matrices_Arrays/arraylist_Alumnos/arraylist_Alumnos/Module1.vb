Module Module1

    Sub Main()
        Dim nombres As New ArrayList  '{"jon", "Josu", "Joseba", "Alain", "Yerai", "Mikel", "Jose", "Omaira", "Iker", "Aitor"}
        nombres.Insert(0, "jon") 'con insert le dices la posición
        nombres.Add("Josu")
        nombres.Add("Joseba")
        nombres.Add("Alain")
        nombres.Add("Yerai")
        nombres.Add("Mikel")
        nombres.Add("Jose")
        nombres.Add("Omaira")
        nombres.Add("Iker")
        nombres.Add("Aitor")

        nombres.Sort()
        Console.WriteLine("Nombres ordenados:")
        For Each alumno As String In nombres
            Console.WriteLine(alumno)

        Next

        nombres.Reverse()
        Console.WriteLine("Nombres reversed:")
        For Each alumno As String In nombres
            Console.WriteLine(alumno)
        Next
        nombres.Sort()
        nombres.Insert(0, "Cod. 8f, Ion Jaureguialzo")
        Console.WriteLine("Nombres 8f:")
        For Each alumno As String In nombres
            Console.WriteLine(alumno)
        Next
        Console.Write("NOmbre a buscar: ")
        Dim nombre As String = Console.ReadLine()
        For Each alumno As String In nombres
            If alumno.ToUpper = nombre.ToUpper Then
                Console.WriteLine("Alumno encontrado en la posición: " & nombres.IndexOf(alumno))
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
