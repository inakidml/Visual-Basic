Module Module1

    Sub Main()

        'Introducir informacion para realizar el ejercicio

        Console.WriteLine("Introduce el valor de nro1: ")
        Dim nro1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Introduce el valor de nro2: ")
        Dim nro2 As Integer = Integer.Parse(Console.ReadLine())

        If (nro1 > nro2) Then Console.WriteLine("El rdo restar {0,3} - {1,3} es: {2,3}", nro1, nro2, (nro1 - nro2))

        'mostrar rdo de la suma en todos los casos
        Console.WriteLine("El rdo sumar  " & nro1 & " + " & nro2 & " es: {0}", (nro1 + nro2))

        Console.ReadLine()

    End Sub

End Module
