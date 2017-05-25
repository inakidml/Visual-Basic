'>>> MATRICES INIDIMENSIONALES Y MULTIDIMENSIONALES 

Module TtoDeMatrices


    Sub Main()

        '         >>>    MATRICES INIDIMENSINALES   <<<<

        '>>> DECLARARLA
        Dim m1() As Integer

        '>>> CREARLA      - ésta contendrá 10 elementos ubicados del <0 .. 9>
        m1 = New Integer(9) {}

        '>>> DECLARARLA y CREARLA
        Dim m2() As Integer = New Integer(9) {}

        '>>> DECLARARLA y CREARLA           < ABREVIADA >
        Dim m3(9) As Integer

        '>>> INICIALIZARLA al crearla
        Dim m4() As Integer = New Integer(6) {10, 50, 40, 20, 30, 70, 60}
        Dim m5() As Integer = New Integer() {10, 50, 40, 20, 30, 70, 60} 'sin especificar nro de elementos


        '>>> INICIALIZARLA al crearla       < ABREVIADA >
        Dim m6() As Integer = {10, 50, 40, 20, 30, 70, 60}
        Dim mDias() As String = {"lunes", "martes", "miercoles", "jueves", "viernes"}

        '>>> INICIALIZAR una POSICION concreta
        m1(3) = 15
        mDias(0) = "domingo"

        '>>> REDIMENSIONAR
        Dim m7() As Integer = {10, 50, 40, 20, 30, 70, 60}
        ReDim m7(15)   'Se redimensiona pero se pierden los datos

        '>>> REDIMENSIONAR LA MATRIZ Y MANTENER LOS DATOS
        Dim m8() As Integer = {10, 50, 40, 20, 30, 70, 60}
        ReDim Preserve m8(15)   'Se redimensiona pero se pierden los datos

        '>>> LIBERAR la memoria asignada a la matriz, el recolector de basura 
        'Erase m8

        '>>> RECORRER una matriz 
        '                            REPETITIVA con FOR ... EACH
        Console.WriteLine(vbCrLf & "El contenido con FOR ... EACH es :")
        'Dim elemento As Integer
        For Each elemento In m8
            Console.Write(elemento & " ")
        Next
        Console.WriteLine(vbCrLf)

        '                            REPETITIVA con FOR ... Next
        Console.WriteLine(vbCrLf & "El contenido es :")
        For x = 0 To 15   'para un array de 16 elementos
            Console.Write(m8(x) & " ")
        Next
        Console.WriteLine(vbCrLf)


        '>>> Propiedades de la matriz para saber el TAMAÑO
        '  matriz.Length:           Me da el Nro de elementos en TODA la matriz, sin tener en cta las dimensiones
        '  matriz.GetLength(0):     Me da el Nro de elementos de esa dimensión - (0)indica primera dimension
        '  matriz.GetUpperBound(0): Me da el Indice mas alto de esa dimensión - (0)indica primera dimension 

        Console.WriteLine("La matriz m8 creada, los elementos que tiene son:" & m8.Length)
        Console.WriteLine("La matriz m8 creada, los elementos que tiene son:" & m8.GetLength(0))
        Console.WriteLine("La matriz m8 creada, el indice superior de esa dimension:" & m8.GetUpperBound(0))
        Console.WriteLine("La matriz m8 creada, el indice superior de esa dimension:" & UBound(m8, 1))


        'Console.WriteLine(vbCrLf & "El contenido es :")
        'For i = 0 To m8.Length - 1
        '    Console.Write(m1(i) & " ")
        'Next
        'Console.WriteLine(vbCrLf)  

        'Console.WriteLine(vbCrLf & "El contenido es :")
        'For i = 0 To m8.GetUpperBound(0)
        '    Console.Write(m1(i) & " ")
        'Next
        'Console.WriteLine(vbCrLf)  




        '         >>>    MATRICES MULTIDIMENSINALES   <<<<
        -+

        '                     >>>>    Con Dos Dimensiones ......   <<<<<

        '>>> DECLARARLA
        Dim mtz1(,) As Integer

        '>>> CREARLA      - ésta contendrá 12 elementos los índices van (<0 .. 3>,<0 .. 2>)
        mtz1 = New Integer(3, 2) {}     'de 4f x 3c de elemententos

        '>>> DECLARARLA y CREARLA
        Dim mtz2(,) As Integer = New Integer(3, 2) {}

        '>>> DECLARARLA y CREARLA               < ABREVIADA >
        Dim mtz3(3, 2) As Integer

        '>>> INICIALIZARLA al crearla   - de 4f x 3c de elemententos
        Dim mtz4(,) As Integer = New Integer(3, 2) {{10, 50, 15},
                                                    {40, 20, 25},
                                                    {30, 70, 35},
                                                    {60, 90, 55}}

        Dim mtz5(,) As Integer = New Integer(,) {{10, 50, 15}, {40, 20, 25}, {30, 70, 35}, {60, 90, 55}} 'sin especificar nro de elementos


        '>>> INICIALIZARLA al crearla          <ABREVIADA>
        Dim mtz6(,) As Integer = {{10, 50, 15}, {40, 20, 25}, {30, 70, 35}, {60, 90, 55}}

        '>>> INICIALIZAR una POSICION concreta
        mtz1(0, 1) = 15


        '>>> Propiedades de la matriz para saber el TAMAÑO
        '  matriz.Length:           Me da el Nro de elementos en TODA la matriz, sin tener en cta las dimensiones
        '  matriz.GetLength(0):     Me da el Nro de elementos de esa dimensión - (0)indica primera dimension
        '  matriz.GetUpperBound(0): Me da el Indice mas alto de esa dimensión - (0)indica primera dimension 

        Console.WriteLine(vbCrLf)
        Console.WriteLine("La matriz mtz5 creada, los elementos que tiene son:" & mtz5.Length)
        Console.WriteLine("La matriz mtz5 creada, las fila que tiene son:" & mtz5.GetLength(0)) 'nro de elementos en la 1ª dimension
        Console.WriteLine("La matriz mtz5 creada, las columnas que tiene son:" & mtz5.Length / mtz5.GetLength(0))
        Console.WriteLine("La matriz mtz5 creada, el limite superior para el primer indice:" & mtz5.GetUpperBound(0))
        Console.WriteLine("La matriz mtz5 creada, el limite superior para segundo indice:" & mtz5.GetUpperBound(1))
        Console.WriteLine("La matriz mtz5 creada, el limite superior para el primer indice:" & UBound(mtz5, 1))
        Console.WriteLine("La matriz mtz5 creada, el limite superior para segundo indice:" & UBound(mtz5, 2))


        Console.WriteLine(vbCrLf & "De dos dimensiones " & vbCrLf)
        For x = 0 To mtz5.GetUpperBound(0)
            For y = 0 To mtz5.GetUpperBound(1)
                Console.Write(mtz5(x, y) & " ")
            Next
            Console.WriteLine(vbCrLf)
        Next
        Console.WriteLine(vbCrLf)



        '                     >>>>    Con Tres Dimensiones ......   <<<<<

        '>>> DECLARARLA y CREARLA               < ABREVIADA >
        Dim mtz7(3, 2, 2) As Integer

        '>>> INICIALIZARLA al crearla          <ABREVIADA>
        Dim mtz8(,,) As Integer = {{{10, 50, 15}, {40, 20, 25}, {30, 70, 35}, {60, 90, 55}}, _
                                   {{10, 50, 15}, {40, 20, 25}, {30, 70, 35}, {60, 90, 55}}}


        Console.WriteLine(vbCrLf & "De tres dimensiones " & vbCrLf)
        For x = 0 To mtz8.GetUpperBound(0)
            For y = 0 To mtz8.GetUpperBound(1)
                For z = 0 To mtz8.GetUpperBound(2)
                    Console.Write(mtz8(x, y, z) & " ")
                Next
                Console.WriteLine(vbCrLf)
            Next
            Console.WriteLine(vbCrLf & vbCrLf)
        Next
        Console.WriteLine(vbCrLf)


        Console.WriteLine(vbCrLf & "De tres dimensiones " & vbCrLf)
        For x = 0 To UBound(mtz8, 1)
            For y = 0 To UBound(mtz8, 2)
                For z = 0 To UBound(mtz8, 3)
                    Console.Write(mtz8(x, y, z) & " ")
                Next
                Console.WriteLine(vbCrLf)
            Next
            Console.WriteLine(vbCrLf & vbCrLf)
        Next
        Console.WriteLine(vbCrLf)


        ' '' '' '' '' '' ''Dim matriz(,) As Integer = {{3, 5, 9}, {6, 8, 7}, {1, 2, 5}, {6, 8, 7}, {1, 2, 5}}

        '' '' '' '' '' '' ''Me da el Nro de elementos en TODA la matriz.Length, sin tener en cta las dimensione
        ' '' '' '' '' '' ''Console.WriteLine("La matriz creada, los elementos totales que tiene son:" & matriz.Length & vbCrLf)

        ' '' '' '' '' '' '' ''Obtengo el indice max de la dimension especificada
        '' '' '' '' '' '' ''Console.WriteLine(vbCrLf & "UBound(matriz,1): me da el indice max de la primera dimensión: " & UBound(matriz, 1))
        '' '' '' '' '' '' ''Console.WriteLine("UBound(matriz,2): me da el indice max de la segunda dimensión: " & UBound(matriz, 2))

        '' '' '' '' '' '' ''Obtengo el indice max de la dimension especificada
        ' '' '' '' '' '' ''Console.WriteLine(vbCrLf & "matriz.GetUpperBound(0): me da el indice max de la primera dimension: " & matriz.GetUpperBound(0))
        ' '' '' '' '' '' ''Console.WriteLine("matriz.GetUpperBound(1): me da el indice max de la segunda dimension:: " & matriz.GetUpperBound(1))


        '' '' '' '' '' '' '' Me da el Nro de elementos de esa dimension matriz.GetLength(0), habrá que restar 1
        ' '' '' '' '' '' ''For x = 0 To matriz.GetLength(0) - 1
        ' '' '' '' '' '' ''    For y = 0 To matriz.GetLength(1) - 1
        ' '' '' '' '' '' ''        Console.WriteLine("Elemento ({0},{1}): {2}", x, y, matriz(x, y))
        ' '' '' '' '' '' ''    Next
        ' '' '' '' '' '' ''    Console.WriteLine()
        ' '' '' '' '' '' ''Next
        ' '' '' '' '' '' ''Console.WriteLine(vbCrLf)



        '         >>>    PROPIEDADES y METODOS para  MATRICES    <<<<


        '>>> ARRAY.CLEAR  --- INICIALIZA a ceros la matriz m1, a partir de la posicion 0, con una longitud, es este caso toda la tabla
        Array.Clear(m1, 0, m1.Length)
        Console.WriteLine(vbCrLf & "Inicializa un array desde la posicion 0 y de longitud " & m1.Length)
        For i = 0 To m1.Length - 1
            Console.Write(m1(i) & " ")
        Next
        Console.WriteLine(vbCrLf)


        '>>> CLONE - para clonar matrices, ojo serán 2 matrices distintas,  con otra referencia
        '>>> EQUALS - permite COMPARA las REFERENCIAS para saber si se trata del mismo objeto

        Dim m20() As Integer = CType(m6.Clone(), Integer()) ' m20 es una copia en otro objeto de m6
        'Dim m20() As Integer = m6         ' en este caso es otra variable que apunta AL MISMO array m6

        If (m6.Equals(m20)) Then           ' COMPARA la referencia para saber si apuntan al mismo objeto
            Console.WriteLine("m6 y m20 se refieren a la misma matriz -  no Clone")
        Else
            Console.WriteLine("m6 y m20 se refieren a matrices diferentes - Clone")
        End If

        Console.WriteLine(vbCrLf & "La matriz m20 después de Clonar o Copiar de m6")
        For i = 0 To m20.Length - 1
            Console.Write(m20(i) & " ")
        Next
        Console.WriteLine(vbCrLf)

        '>>>  COPYTO    --    COPIA el contenido de un array en otro a partir de una posicion, la segunda será de tamaño igual o mayor
        Dim m30(19) As Integer
        m6.CopyTo(m30, 2)                  ' COPIA m6 en m30 a partir de la posicion indicada, m30 debera ser de tamaño igual o mayor
        If (m6.Equals(m30)) Then           ' COMPARA la referencia para saber si apuntan al mismo objeto
            Console.WriteLine("m6 y m30 se refieren a la misma matriz - CopyTo")
        Else
            Console.WriteLine("m6 y m30 se refieren a matrices diferentes -CopyTo")
        End If

        Console.WriteLine(vbCrLf & "La matriz m30 despues de copiarla de m6  - con CopyTo")
        For i = 0 To m30.Length - 1
            Console.Write(m30(i) & " ")
        Next
        Console.WriteLine(vbCrLf)

        '>>> ARRAY.COPY   --  COPIA el contenido de un array en otro a partir de una posicion dejandolo en la posicion indicando el n elementos
        Dim nroElementos As Integer = m6.Length
        Array.Copy(m6, 0, m30, 2, nroElementos)  'COPIA m6 en m30 desde 0 y deja en posicion 2 n elementos
        If (m6.Equals(m3)) Then                 ' COMPARA la referencia para saber si apuntan al mismo objeto
            Console.WriteLine("m6 y m30 se refieren a la misma matriz -Copy")
        Else
            Console.WriteLine("m6 y m30 se refieren a matrices diferentes - Copy")
        End If

        Console.WriteLine("La matriz m30 después de copiarla de m6  - con Copy")
        For i = 0 To m30.Length - 1
            Console.Write(m30(i) & " ")
        Next
        Console.WriteLine(vbCrLf)


        '>>> Para COMPARAR el CONTENIDO de las matrices, tendré  q. hacerlo elemento a elemento..
        ReDim Preserve m30(m6.Length - 1)         'redimensiono para que tenga el mismo tamaño que m6
        m30(3) = 88                               'asigno el mismo valor en los dos arrays 
        m6(3) = 88
        For i = 0 To (m6.Length - 1)              'pongo el limite del array menor
            If (m6(i) = m30(i)) Then        ' If (m6(i).CompareTo(m30(i)) = 0) Then SI fueran Char
                Console.WriteLine("m6 y m30 .. coinciden en la posicion: " & i)
            Else
                Console.WriteLine("m6 y m30 NO coinciden en la posicion: " & i)
            End If
        Next
        Console.WriteLine(vbCrLf)

        '>>> ARRAY.SORT     -   ORDENA los elementos de menor a mayor
        Array.Sort(m6)
        Console.WriteLine("La matriz m6 despues del Sort")
        For i = 0 To m6.Length - 1
            Console.Write(m6(i) & " ")
        Next
        Console.WriteLine()


        '>>> ARRAY.REVERSE   -    INVIERTE el orden de los elementos
        Array.Reverse(m6)
        Console.WriteLine("La matriz m6 despues del Reverse")
        For i = 0 To m6.Length - 1
            Console.Write(m6(i) & " ")
        Next
        Console.WriteLine(vbCrLf)

        '>>> BUSQUEDA BINARIA en una matriz -
        Dim m40() As Integer = {10, 20, 30, 40, 50} 'creada e inicializada
        Dim valorBusqueda As Integer = 20

        Dim posicion As Integer = Array.BinarySearch(m40, valorBusqueda)    ' realiza una busqueda binaria 
        If (posicion < 0) Then                                              ' deberá estar ordenada
            Console.WriteLine("El dato no se encuentra en el array ")
        Else
            Console.WriteLine("El dato {0} se encuentra en la posicion:{1} ", valorBusqueda, posicion)
        End If

        Console.WriteLine("El tamaño del array  m40: " & m40.Length)           'TAMAÑO del array
        Console.WriteLine(vbCrLf)




        '>>> MATRICES CARACTERES


        '>>> MATRICES CARACTERES - UTILIZANDO UN STRING
        Dim cadena As String = "HOLA MARIOLA"
        Dim m As Integer = 0

        Dim caracter As Char = cadena.Chars(m) 'para acceder a cada caracter pg.175 VB 
        While (m < cadena.Length - 1)

            Console.WriteLine(Convert.ToInt32(caracter) & " - " & caracter & "--")
            'Console.WriteLine(Asc(caracter) & " - " & caracter & "--")
            m += 1
            caracter = cadena.Chars(m)
        End While

        '>>>   SUBSTRING         -   Recupera una subcadena dentro de la cadena
        Dim cadenaFinal As String = cadena.Substring(0, 3) 'a partir de que posicion y cuantos caracteres
        Console.WriteLine(" >>>>>: " & cadenaFinal)
        ' para eliminar la coma final VER ejercicio Material Complementario\Practica_3\P3E40


        '           >>>   MATRICES con String   <<<

        '>>> INICIALIZARLA al crearla       < ABREVIADA >
        Dim mtzDias() As String = {"lunes", "martes", "miercoles", "jueves", "viernes"}





        Console.ReadLine()


    End Sub



End Module
