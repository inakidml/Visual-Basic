'>>> MATRICES DE MATRICES O ESCALONADAS 

Module TtoDeEscalonadas

    Sub Main()

        'Creo una matriz de 2 filas --> en la fila 0 con 3 columnas y el la fila 1 con 4 columnas
        'Dim m3()() As Integer = New Integer(1)() {}
        'm3(0) = New Integer(2) {} ' así creo los huecos de las filas sin valores
        'm3(1) = New Integer(3) {}

        ''de forma abreviada
        'Dim m3(1)() As Integer

        ''creo los huecos de las filas con valores
        'm3(0) = New Integer(2) {1, 2, 3}
        'm3(1) = New Integer(3) {11, 12, 13, 14}

        '' Tambien podrian definirse
        'Dim m3()() As Integer = New Integer(1)() {New Integer(2) {}, New Integer(3) {}}


        '>>> MATRICES ESCALONADAS - el ejemplo de los apuntes
        Dim ventas(11)() As Integer
        Dim meses, dias As Integer

        For meses = 0 To 11
            dias = DateTime.DaysInMonth(Year(Now), meses + 1)  'nro de dias del mes y año indicado
            ventas(meses) = New Integer(dias - 1) {}

            '    Console.WriteLine("año: " & Year(Now) & " mes " & meses & " dias" & dias)
            '    Console.WriteLine("tamaño: " & ventas(meses).GetUpperBound(0) & ": " & dias)

        Next

        Dim rnd As Random = New Random()  'crear un objeto de la clase Random

        ' lleno la matriz dentada con valores aleatorios y la imprimo
        Dim tope As Integer = 0
        For mes As Integer = 0 To 11    'ventas.Length - 1
            'tope = DateTime.DaysInMonth(Year(Now), x + 1)
            'For y = 0 To tope - 1
            For dia As Integer = 0 To ventas(mes).GetUpperBound(0)  'en vez de tope me da el indice de esa dimension
                ventas(mes)(dia) = rnd.Next(1, 10) 'obtener el siguiente nro aleatorio entre 1 y 9, ambos inclusive
                Console.WriteLine("ventas({0})({1})= {2,2} ", mes, dia, ventas(mes)(dia))
            Next
            Console.WriteLine()
        Next




    End Sub

End Module
