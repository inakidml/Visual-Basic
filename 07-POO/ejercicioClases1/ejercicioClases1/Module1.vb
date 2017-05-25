Module Module1

    Sub Main()
        Console.Write("Escribe una palabra: ")
        Dim texto As Cadena = New Cadena(Console.ReadLine())
        texto.desplazarLetras()
        Console.WriteLine(texto.GetTextoMod)
        While texto.comprobarFin
            texto.desplazarLetras()
            Console.WriteLine(texto.GetTextoMod)
        End While
        Console.ReadKey()
    End Sub

End Module
