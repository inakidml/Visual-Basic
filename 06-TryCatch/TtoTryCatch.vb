Module TtoTryCatch

    'Cuando durante la ejecución de un programa ocurre un error que impide su continuación, 
    'por ej, una entrada incorrecta de datos, VB lanza una excepción, que si no se captura 
    'da lugar a un mensaje de error y detiene la ejecución.

    'Para capturar una excepción hay que hacer dos cosas:
    ' 1. Poner a prueba el código que puede lanzar excepciones dentro del bloque Try
    ' 2. Manejar la excepción cuando se lance, en un bloque Catch

    Sub Main()

        Dim nro, x, rto As Integer
        Dim texto As String = ""

        Try
            'SENTENCIA O GRUPO DE SENTENCIAS A CONTROLAR

            Console.WriteLine("Teclear un nro:    ")
            nro = Integer.Parse(Console.ReadLine())

            'Reptitiva de 1 .. n
            x = nro
            Do
                x = x - 1
                rto = nro Mod x
            Loop While (rto <> 0) 'mientras no sea divisible

            If (x = 1) Then
                Console.WriteLine("El nro introducido es PRIMO ")
            Else
                Console.WriteLine("El nro introducido No es PRIMO ")
            End If

        Catch ex As FormatException        'ex: almacena la inform. del error ocurrido
            ' CATCH CAPTURA EL ERROR Y SE INDICA COMO RESOLVER LA EXCEPCIÓN
            'Console.WriteLine("Error de tipo FormatException: " & ex.Message)
            texto = "Error de tipo FormatException: " & ex.Message
        Catch ex As InvalidCastException
            'Console.WriteLine("Error de tipo InvalidCastException: " & ex.Message)
            texto = "Error de tipo InvalidCastException: " & ex.Message
        Catch ex As OverflowException
            'Console.WriteLine("Error de Overflow: " & ex.Message)
            texto = "Error de Overflow: " & ex.Message
        Catch ex As Exception
            ' DETECTA CUALQUIER ERROR PRODUCIDO EN TIEMPO DE EJECUCIÓN NO CONTROLADO 
            'Console.WriteLine("Error inesperado: " & ex.Message)
            'texto = ex.ToString
            texto = ex.Message

        Finally
            ' APARTADO OPCIONAL, LAS SENTENCIAS SE DEBERÁN DE EJECUTAR 
            ' INDEPENDIENTEMENTE DE SI SE PRODUCE UNA EXCEPCIÓN O NO

            Console.WriteLine(texto)
        End Try

    End Sub



End Module
