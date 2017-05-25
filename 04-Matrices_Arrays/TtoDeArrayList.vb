
'>>> Tto de ArrayList
'En programación, un array dinámico, que crece o mengua dinámicamente conforme los elementos se agregan o se eliminan. ...

Module TtoDeArrayList

    Sub Main()

        ' Crea e inicializa un ArrayList.
        Dim miArrayList As New ArrayList()


        ' agregar elementos al ArrayList
        miArrayList.Add("Hello")
        miArrayList.Add("World")
        miArrayList.Add("!")
        miArrayList.Add("Hola")
        miArrayList.Add("Mariola")
        miArrayList.Insert(2, "Agur") 'inserta un elemento en la posicion indicada
        Console.Write("    Values:")
        ImprimirValores(miArrayList)


        Console.WriteLine("tamaño: " & miArrayList.Capacity)
        miArrayList.Sort() 'ordena el contenido del ArrayList
        miArrayList.Reverse() 'invierte  el contenido del ArrayList
        miArrayList.Reverse(1, 3) 'invierte  el contenido en un intervalo
        'miArrayList.Clear() 'quita todos los elementos del arrayList
        miArrayList.Insert(2, "Agur") 'inserta un elemento en la posicion indicada
        miArrayList.Remove("Agur") 'borra el elemento indicado
        'miArrayList.RemoveAt(2)     'borra el elemento en la posicion indicada
        miArrayList.RemoveRange(2, 3) 'borra a partir de la posicion indicada el nro del elemento indicados 


        Console.Write("    Valores:")
        ImprimirValores(miArrayList)

        Dim resp As Boolean = miArrayList.Contains("World") 'busqueda dentro de un ArrayList
        If (resp) Then Console.WriteLine(" ""World"" Si está en el array") Else Console.WriteLine("No está en el array")


        'Muestra las propiedades y valores de un ArrayList.
        Console.WriteLine("miArrayList")
        Console.WriteLine("    Count:    {0}", miArrayList.Count)    ' Nos dice el nro de elementos reales que contiene
        Console.WriteLine("    Capacity: {0}", miArrayList.Capacity) ' Obtiene o establece el nro de elemntos que puede contener
        Console.WriteLine("    El elemento de la posisicion 1 es :" & CStr(miArrayList.Item(1))) ' Nos da el contenido en esa posicion
        Console.WriteLine(miArrayList.Item(1))                                                   ' Nos da el contenido en esa posicion

        Console.Write("    Valores del arrayList:")
        ImprimirValores(miArrayList) 'imprime el contenido del arryList



        '>>> BUSQUEDA EN UN >> ArrayList <<
        'Creo e inicializo un ArrayList con 3 elementos con igual información
        Dim mArrayList As New ArrayList()
        mArrayList.Add("El")
        mArrayList.Add("rapido")
        mArrayList.Add("marron")
        mArrayList.Add("zorro")
        mArrayList.Add("saltos")
        mArrayList.Add("sobre")
        mArrayList.Add("El")
        mArrayList.Add("perezoso")
        mArrayList.Add("perro")
        mArrayList.Add("en")
        mArrayList.Add("El")
        mArrayList.Add("granero")


        'Visualiza los valores del ArrayList
        Console.WriteLine("El ArrayList contiene los siguiente valores:")
        ImprimirIndicesyValores(mArrayList)

        ' Busca la primera aparicion del valor (en caso de estar duplicado)
        Dim valorBusqueda As [String] = "El"
        Dim indice As Integer = mArrayList.IndexOf(valorBusqueda) 'IndexOf -Busca el objeto especificado y devuelve el índice de base cero de la primera aparición en la ArrayList completa.
        Console.WriteLine("La primera aparicion ""{0}"" está en el indice  {1}.", valorBusqueda, indice)


        ' Busca la primera aparicion del valor duplicado a partir de la posicion dada
        indice = mArrayList.IndexOf(valorBusqueda, 4)
        Console.WriteLine("La primera aparicion de ""{0}"" entre el indice 4 y el final, esta en el indice {1}.", valorBusqueda, indice)


        ' Busca la primera aparición del valor duplicado en un sector de la clase ArrayList.
        indice = mArrayList.IndexOf(valorBusqueda, 7, 3)
        Console.WriteLine("La primera aparicion de ""{0}"" a apartir del indice 7 y en los 3 elementos siguientes está en el indice {1}.", valorBusqueda, indice)

        ' Busca para la primera aparicion del valor duplicado en una pequeña seccion al final del ArrayList
        indice = mArrayList.IndexOf(valorBusqueda, 11)
        Console.WriteLine("La primera aparicion de ""{0}"" entre el indice 11 y el fin de este indice {1}.", valorBusqueda, indice)


    End Sub

    Private Sub ImprimirValores(ByVal miArrayList As ArrayList)
        'Dim obj As Object
        For Each obj In miArrayList
            Console.Write("   {0}", obj)
        Next obj
        Console.WriteLine()
    End Sub

    Private Sub ImprimirIndicesyValores(ByVal miArrayList As ArrayList)
        Dim i As Integer
        Dim obj As [Object]
        For Each obj In miArrayList
            Console.WriteLine("   [{0}]:    {1}", i, obj)
            i = i + 1
        Next obj
        Console.WriteLine()
    End Sub

End Module
