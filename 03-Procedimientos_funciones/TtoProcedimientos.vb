Module TtoProcedimientos

    'Los procedimientos brindan la capacidad de agrupar logicamente el código para determinadas
    ' tareas. Si un código realiza la misma tarea en diferentes lugares, se puede escribir la 
    ' tarea en un procedimiento y después llamarlo desde distintos lugares del código.


    Sub Main()


        '>>> PROCEDIMIENTOS SUB y FUNCTION
        Dim a As Byte = 10, b As Byte = 20

        realizarCambio(a, b)  'ver el procedimiento al final del Main
        Console.WriteLine("Resultado en la funcion Main es --> a: {0}, b: {1}", a, b)

        visualizaProcedimento_2(a, b, 185)   'con parametro opcional
        visualizaProcedimento_2(a, b)        'con parametro opcional
        visualizaProcedimento_2(a, b + a)    'con parametro tipo expresion
        visualizaProcedimento_2(a, 200)      'con parametro tipo kte

        Dim rdo As Byte = procedimientoSuma(a, b)      'con llamada a una funcion
        Console.WriteLine("Resultado de la funcion suma es --> rdo = {0}", rdo)
        'Console.WriteLine("Resultado de la funcion suma es --> rdo = {0}", procedimientoSuma(a, b))


    End Sub


    'Ver la diferencia al pasar los argumentos por Referencia o por Valor
    'por Valor, NO cambia las variables originales, pasa una copia
    Private Sub realizarCambio(ByVal a As Byte, ByVal b As Byte)
        Dim cambio As Byte
        cambio = a
        a = b
        b = cambio
    End Sub

    'Ver la diferencia al pasar los argumentos por Referencia o por Valor
    'por Referencia. cambia las variables originales
    'Private Sub realizarCambio(ByRef a As Byte, ByRef b As Byte)
    '    Dim cambio As Byte
    '    cambio = a
    '    a = b
    '    b = cambio
    'End Sub

    Private Sub visualizaProcedimento_2(ByVal a As Byte, ByVal b As Byte, Optional ByVal p3 As Integer = 5)
        Console.WriteLine("a: {0}, b: {1} , el opcional es {2}", a, b, p3)
    End Sub

    Private Function procedimientoSuma(ByVal a As Byte, ByVal b As Byte) As Byte
        'cualquiera de las dos representaciones es valida para devolver el resultado
        'Return a + b
        procedimientoSuma = a + b
    End Function



End Module
