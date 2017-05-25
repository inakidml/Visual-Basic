Module Module1

    Sub Main()
        Console.Write("Un numero: ")
        Dim a As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Un numero: ")
        Dim b As Integer = Integer.Parse(Console.ReadLine())

        Dim salir As Boolean = False
        Dim opcion As Integer

        Do

            Console.WriteLine("1. Suma")
            Console.WriteLine("2. Resta")
            Console.WriteLine("3. Multiplicar")
            Console.WriteLine("4. dividir")
            Console.WriteLine("5. Salir")
            Console.Write("Selecione una opción: ")
            opcion = Console.ReadLine()

            Select Case opcion
                Case 1
                    Console.Write("Resultado: ")
                    Console.WriteLine(a + b)
                Case 2
                    Console.Write("Resultado: ")
                    Console.WriteLine(a - b)
                Case 3
                    Console.Write("Resultado: ")
                    Console.WriteLine(a * b)
                Case 4
                    Console.Write("Resultado: ")
                    Console.WriteLine(a / b)
                Case 5
                    salir = True

                Case Else
                    Console.WriteLine("Opcion incorrecta")
            End Select



        Loop While salir = False
        Console.ReadLine()

    End Sub

End Module
