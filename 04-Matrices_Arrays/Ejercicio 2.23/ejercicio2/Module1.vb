Module Module1

    Sub Main()

        Dim tamanio As Integer
        Dim dimension As Integer
        pedirTamanio(tamanio)
        Dim matriz(tamanio - 1) As Integer
        Dim matrizCopia(tamanio - 1) As Integer
        Dim opcion As Integer
        rellenar(matriz, tamanio)
        Do
            Console.WriteLine("1.- Buscar un valor")
            Console.WriteLine("2.- Copiar un número determinado de elementos")
            Console.WriteLine("3.- Inicializar el array")
            Console.WriteLine("4.- Salir")
            Console.Write("Opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())

        Loop While opcion < 0 And opcion > 5

        Select Case opcion

            Case 1
                Console.Write("Introduzca un número: ")
                Dim numero As Int16 = Convert.ToInt32(Console.ReadLine())
                For indexA As Integer = 0 To tamanio - 1
                    If matriz(indexA) = numero Then
                        Console.WriteLine("Ese número esta en la posición = " & indexA + 1)
                        Console.ReadKey()
                    End If
                Next
            Case 2
                Console.Write("Nº elementos a copiar: ")
                Dim elementos As Integer = Convert.ToInt32(Console.ReadLine())
                ReDim matrizCopia(elementos - 1)
                For indexA As Integer = 0 To elementos - 1
                    matrizCopia(indexA) = matriz(indexA)
                Next

                Console.WriteLine("matriz original")
                visualizarMatriz(matriz, tamanio)
                Console.WriteLine("Matriz copia")
                visualizarMatriz(matrizCopia, elementos)
                Console.ReadKey()
            Case 3
                ReDim matriz(tamanio - 1)
            Case 4
                Console.WriteLine("Fin del programa")
                Console.ReadKey()
        End Select



    End Sub

    Sub pedirTamanio(ByRef tamanio As Integer)
        Console.Write("Tamanio del array: ")
        tamanio = Convert.ToInt32(Console.ReadLine())
    End Sub


    Sub rellenar(ByRef matriz() As Integer, ByVal tamanio As Integer)

        For indexF As Integer = 0 To tamanio - 1
            Console.Write("Introduzca un valor: ")
            matriz(indexF) = Console.ReadLine()
        Next

    End Sub

    Sub visualizarMatriz(ByRef matriz() As Integer, ByVal tamanio As Integer)
        For indexA As Integer = 0 To tamanio - 1

            Console.Write(matriz(indexA) & " ")
        Next
        Console.WriteLine()

        REM   Console.ReadKey()

    End Sub
End Module
