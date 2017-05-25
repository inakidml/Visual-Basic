Module Module1

    Sub Main()
        REM Ejercicio3:
        Dim horas, mint, seg As Integer
        Console.WriteLine("Escribe la hora en segundos que deses ver convertida")
        seg = Console.ReadLine()
        horas = 00
        mint = 00

        mint = seg / 60
        seg = seg Mod 60
        If mint > 60 Then
            horas = mint / 60
            mint = mint Mod 60
        End If

        Console.WriteLine("la hora es ")
        Console.WriteLine(horas & ":" & mint & ":" & seg)
        Threading.Thread.Sleep(2000)


    End Sub

End Module










REM Ejercicio2:
'Dim r1, r2, r3, valor As Double

'Console.WriteLine("Escribe el valor de la Resistencia 1")
'r1 = Convert.ToDouble(Console.ReadLine())
'Console.WriteLine("Escribe el valor de la Resistencia 2")
'r2 = Convert.ToDouble(Console.ReadLine())
'Console.WriteLine("Escribe el valor de la Resistencia 3")
'r3 = Convert.ToDouble(Console.ReadLine())
'Console.WriteLine("El valor global es")

'valor = 1 / (1 / r1 + 1 / r2 + 1 / r3)
'Console.WriteLine(valor)
'Threading.Thread.Sleep(2000)