Imports System.Environment
Module DeclaracionDeVariables

    Sub Main()

        ''>>>>DECLARACION DE VARIABLESY ASIGNACION  '''''''''''''''''

        'Variables reales
        Dim r1 As Single = 3.4F            ' 4 bytes 
        Dim r2 As Double = 3.8             ' 8 bytes
        Dim r3 As Decimal = 3.16D          ' 16 bytes

        'Variables enteras
        Dim e1 As Short = 2             'Int16 - 2 bytes 
        Dim e2 As Integer = 4           'Int32 - 4 bytes
        Dim e3 As Long = 8              'Int64 - 8 bytes

        'Variables de caracteres, booleana, date
        Dim c1 As String = "hola mariola"
        Dim b1 As Boolean = True
        Dim d1 As Date = CDate("30/07/2001")
        Dim car As Char = "A"c
        Dim by1 As Byte = 1

        Const kte As Integer = 45

        Console.WriteLine("Resultados:")
        Console.WriteLine(r1)
        Console.WriteLine(r2)
        Console.WriteLine(r3)
        Console.WriteLine(e1)
        Console.WriteLine(e2)
        Console.WriteLine(e3)
        Console.WriteLine(c1)
        Console.WriteLine(c1.ToUpper)
        Console.WriteLine(b1)
        Console.WriteLine(d1)
        Console.WriteLine(car)
        Console.WriteLine(Char.ToLower(car))
        Console.WriteLine(by1)

        Console.WriteLine(r1)
        Console.WriteLine(kte)
        'Console.ReadLine()   ' => Ctrl+F5

        Console.WriteLine("Introduce un valor entero ")
        Dim entero As Integer = CInt(Console.ReadLine())



        Console.WriteLine("El valor introducido es: " & entero)

        Dim va As Double = 11.15
        Dim rto, r As Integer
        'Dim R As Integer = 8 'No diferencia entre Mayus y Minus
        rto = CInt(va Mod 2)
        Console.WriteLine("resto " & rto)


    End Sub

End Module
