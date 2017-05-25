' VARIABLES
Dim [Nombre variable] As [Tipo variable]
'conversión de tipos'
a = Convert.ToInt32(System.Console.ReadLine());

'CAST
convert.toInt(variable)
CInt(variable)
'CONSOLA'
System.Console.WriteLine(“Tengo{0}meses y{1}años”,meses,años) ' concatenar cadenas & o +'
'vbCrLf retorno de carro
dim a as String = System.console.ReadLine()
System.console.ReadKey()
'Expresiones aritméticas'
'+, -, /, ^, Mod '  ->(/ division real-> resultado Double, \ división entera (byte, short, integer o long) resultado -> entero)

'OPERADORES LÓGICOS
And, AndAlso, or, orelse, Not Xor'

'ESTRUCTURAS DE CONTROL 
If condicion Then instruccion [Else instruccion]
If [(]expresion condicional[)] Then
..................
[ElseIf [(]condicion2[)] Then
sentencias
[Else
................]
End If
'---------------------------------------------'
Select [Case] [(]expresion-test[)]
Case expresion1
..............
[Case expresion2] [................]
[Case expresion3] [................]
[Case Else] [...........]
End Select
'---------------------------------------------'
While [(]condicion[)]
sentencias
End While

Do
Sentencias
Loop While [(]condicion[)]

Dim index As Integer = 0
Do
Console.Write(index.ToString & " ")
index += 1
Loop Until index > 10
'----------------------------------------------'
For variable = expresion1 To expresion2 [Step expresion3]
Sentencias
Next

For number As Double = 2 To 0 Step -0.25
Console.Write(number.ToString & " ")
Next
Console.WriteLine("")

For Each caracter As Char In arrayChar
  Console.Write(caracter)
Next

'PROCEDIMIENTOS
' SUB'
'Si el método no devuelve ningún valor utilizamos
'Sub para crear el método y End Sub para finalizarlo
'Los argumentos se pueden transferir de dos formas:
'• Por valor (Byval)
'• Por referencia (ByRef)
Sub nombreMetodo ([ByRef ]nombreparametro As tipoDeParametro)
'...code...
End Sub'

'FUNCIONES'
Function nombreMetodo (parametro As String)As Single
return	importe
End Function

'MATRICES
Dim students(6) As Integer
Dim cargoWeights As Double()
ReDim cargoWeights(15)

Dim cargoWeights(10) As Double
Dim atmospherePressures(2, 2, 4) As Integer
cargoWeights = New Double(10){}
atmospherePressures = New Integer(2, 2, 4){}

'Propiedades de la matriz para saber el TAMAÑO
'matriz.Length:Me da el Nro de elementos en TODA la matriz, sin tener en cta las dimensiones
'matriz.GetLength(0):Me da el Nro de elementos de esa dimensión - (0)indica primera dimension
'matriz.GetUpperBound(0):Me da el Indice mas alto de esa dimensión - (0)indica primera dimension 

'array.clear - inicializa a ceros la matriz m1, a partir de la posicion 0, 
'con una longitud, es este caso toda la tabla
System.Array.Clear(m1, 0, m1.Length)
'array.copy -copia el contenido de un array en otro a partir de una posicion dejandolo 
'en la posicion indicando el n elementos
Dim nroElementos As Integer = m6.Length
System.Array.Copy(m6, 0, m30, 2, nroElementos)  'COPIA m6 en m30 desde 0 y deja en posicion 2 n elementos
'array.copyTo - copia el contenido de un array en otro a partir de una posicion, la segunda será de tamaño igual o mayor
Dim m30(19) As Integer
m6.CopyTo(m30, 2)'copia m6 en m30 a partir de la posicion indicada, m30 debera ser de tamaño igual o mayor
'System.Array.clone - para clonar matrices, ojo serán 2 matrices distintas,  con otra referencia
'System.Array.equals - permite compara las REFERENCIAS para saber si se trata del mismo objeto
'System.Array.sort -ordena los elementos de menor a mayor
'System.Array.reverse -invierte el orden de los elementos

'busqueda binaria en una matriz -
Dim m40() As Integer = {10, 20, 30, 40, 50} 'creada e inicializada
Dim valorBusqueda As Integer = 20
Dim posicion As Integer = System.Array.BinarySearch(m40, valorBusqueda)' realiza una busqueda binaria 
If (posicion < 0) Then                                          ' deberá estar ordenada
   Console.WriteLine("El dato no se encuentra en el array ")
Else
Console.WriteLine("El dato {0} se encuentra en la posicion:{1} ", valorBusqueda, posicion)
End If

'Asigna un nuevo tamaño a la matriz y conserva a los valores de los
'elementos actuales
ReDim Preserve cargoWeights(20)
'Asignar un nuevo tamaño de la matriz y retener sólo los cinco primeros
'valores de los elementos
ReDim Preserve cargoWeights(4)
'Asigna un nuevo tamaño a la matriz y elimina todos los valores de los
'elementos actuales.
ReDim cargoWeights(15)
'Preserve, cambia el tamaño de sólo la última
'dimensión de la matriz.'
Dim valores As Double() = {1, 2, 3, 4, 5, 6}
Dim nombres() As String={“a”,“b”,“c”}
Dim B(,) As Short = New Short(,) { {5,6}, {7, 8} }'

'Matrices carácteres utilizando un String
Dim cadena As String = "HOLA MARIOLA"
Dim m As Integer = 0
Dim caracter As Char = cadena.Chars(m) 'para acceder a cada caracter pg.175 VB 

'substring -   Recupera una subcadena dentro de la cadena
Dim cadenaFinal As String = cadena.Substring(0, 3) 'a partir de que posicion y cuantos caracteres
Console.WriteLine(" >>>>>: " & cadenaFinal)
' para eliminar la coma final VER ejercicio Material Complementario\Practica_3\P3E40

'MATRIZ ESCALONADA'
Dim ventas()() As Double = New Double(11)(){}
ventas(0) = New Double(10){}
ventas(1) = New Double(8){}

'ARRAYLIST
' Crea e inicializa un ArrayList.
Dim miArrayList As New ArrayList()
' agregar elementos al ArrayList

miArrayList.Add("Hello")
miArrayList.Insert(2, "Agur") 'inserta un elemento en la posicion indicada
miArrayList.Sort() 'ordena el contenido del ArrayList
miArrayList.Reverse() 'invierte  el contenido del ArrayList
miArrayList.Clear() 'quita todos los elementos del arrayList
miArrayList.RemoveAt(2)     'borra el elemento en la posicion indicada
miArrayList.count() 'Tamaño del arrayList
miArrayList.remove(Object) 'borra el objeto del arrayList

Dim resp As Boolean = miArrayList.Contains("World") 'busqueda dentro de un ArrayList
Console.WriteLine("Count:{0}", miArrayList.Count)' Nos dice el nro de elementos reales que contiene
Console.WriteLine("Capacity:{0}", miArrayList.Capacity)' Obtiene o establece el nro de elemntos que puede contener
Console.WriteLine("El elmto de la pos 1 es :" & CStr(miArrayList.Item(1)))'Nos da el contenido en esa posicion
Console.WriteLine(miArrayList.Item(1))' Nos da el contenido en esa posicion
Dim valorBusqueda As [String] = "El"
Dim indice As Integer = mArrayList.IndexOf(valorBusqueda) 'Busca el objeto especificado y devuelve el índice de 
'base cero de la primera aparición en la ArrayList completa.
indice = mArrayList.IndexOf(valorBusqueda, 4)'Busca la primera aparicion del valor duplicado a partir de la posicion dada
indice = mArrayList.IndexOf(valorBusqueda, 7, 3)'Busca la primera aparición del valor duplicado en un sector de la clase ArrayList.
indice = mArrayList.IndexOf(valorBusqueda, 11)
Console.WriteLine("La primera aparicion de ""{0}"" entre el indice 11 y el fin de este indice {1}.", valorBusqueda, indice)
' Busca para la primera aparicion del valor duplicado en una pequeña seccion al final del ArrayList

For Each obj In miArrayList
	Console.Write("{0}", obj)
Next obj

' ESTRUCTURAS
'Fuera del Main, si no, no van
Structure Empleado	
 Dim	nombre	 As	String	
 Dim	apellido As	String	
 Dim	telf	 As	Long	
 Dim	sueldo   As	Decimal	
End	Structure

Dim empleado1 As Empleado
empleado1.nombre = “valor”

'FICHEROS'
'Tipos de acceso
'a) Acceso secuencial: orientado a su uso en archivos
'donde la información está dispuesta como tipo texto
'b) Acceso aleatorio: orientado a su uso en archivos con
'datos contenidos en registros de longitud fija, que a su vez
'pueden estar subdivididos en campos. Un campo puede
'contener un valor numérico o ser tipo texto.

imports System.io
'Constructor
New FileStream(nombre As String, modo As FileMode, acceso As FileAccess)

'Modo: FileMode
'• CreateNew: crear nuevo,si el archivo ya existe, IOException.
'• Create: crear un archivo nuevo. Si el archivo ya existe, se sobrescribirá
'• Open: abre un que archivo exista
'• OpenOrCreate: si existe se abre, sino deberá crearse
'• Append: si existe se abre, si no, lo crea coloca el puntero al final sólo para añadir

'Acceso: FileAccess
'• Read: se lee
'• ReadWrite: se lee o escribe
'• Write: se escribe

'Definir un flujo de entrada desde fichero xxx.txt
Dim fe As FileStream
fe = New FileStream(“c:\Desktop\doc.txt”, FileMode.Open, FileAccess.Read)
'Definir un flujo de salida al fichero xxxx.txt
Dim fs As FileStream
fs = New FileStream(“c:\Desktop\doc.txt”, FileMode.Create, FileAccess.Write)
'READ	
Dim cbuffer() As Byte = New Byte(50) {}
for each 
cbuffer(contador) = Convert.ToByte(arrayChar(contador))
nbytes = fe.Read(cbuffer, 0, cbuffer.Length)
'cbuffer: matriz donde dejará los byte leídos
'0: posición desde donde se empieza a dejar
'cbuffer.Length: número de bytes a leer
'nbytes: nro de bytes leídos ó 0 si no hay datos
'Escritura	
Dim buffer() As Byte = New Byte(50) {}
fs.Write(buffer,0,nbytes)
'buffer: matriz que contiene los byte
'0: posición desde donde se empieza a coger
'nbytes: nro de bytes a coger para escribir en el fichero
fs.Close()
fe.Close()
'Close puede lanzar la excepción IOException

        Dim bufferBytes(100) As Byte
        Dim fs As FileStream
        Dim caracter As Integer
        Dim CR As Integer = 13 ' enter
        crearAbrirFichero(fs)
        Dim contador As Integer
        Console.Write("Escribe algo: ")
        caracter = Console.Read()
        While (caracter <> CR And contador < 100)
            bufferBytes(contador) = Convert.ToByte(caracter)
            contador += 1
            caracter = Console.Read()
            Console.WriteLine(caracter)
        End While
        Console.WriteLine("escribiendo archivo...")
        fs.Write(bufferBytes, 0, bufferBytes.Length)
        fs.Close()
        crearAbrirFichero(fs)
        Console.WriteLine("Leyendo archivo....")
        fs.Read(bufferBytes, 0, fs.Length)
        Dim caracterLeido As Char
        For Each n In bufferBytes
            caracterLeido = Convert.ToChar(n)
            Console.WriteLine(caracterLeido)
        Next
		Function crearAbrirFichero(ByRef fs As FileStream) As Boolean
           fs = New FileStream("C:\Users\txiki\Desktop\prueba_fichero.txt", FileMode.Open, FileAccess.ReadWrite)
           'fs = New FileStream("C:\Users\txiki\Desktop\prueba_fichero.txt", FileMode.Create, FileAccess.ReadWrite)
        End Function


'INPUT STREAM'
Dim sr As StreamReader 'definir un flujo de entrada
sr = New StreamReader(“c:\temp\nombreFichero.txt”) -
'nombreFichero: fichero de donde se cogerán los datos
sr.ReadLine( ) 'permite leer una línea. Una línea está definida como un conjunto
'de caracteres que termina en CR, LF, o bien CR+LF. La cadena de caracteres
'devuelta no contiene los caracteres de terminación.
cadena = sr.ReadLine()
'cadena: es una variable de tipo String que guardará los caracteres leídos del flujo
cadena = sr.ReadToEnd()

'OUTPUT STREAM'
'1er constructor
Dim sw As StreamWriter
sw = New StreamWriter(“c:\temp\nombreFichero.txt”)
'Si el fichero existe, se machacaría la información con los datos nuevos. Si se
'quiere conservar tendremos que utilizar el segundo constructor.
'2º constructor
Dim fs As FileStream
Dim sw As StreamWriter
fs = New FileStream(“c:\temp\doc.txt”, FileMode.Append, FileAccess.Write)
sw = New StreamWriter(fs)

sw.WriteLine(Console.ReadLine()) 'escribimos lo que leemos de consola
sw.Close() 'super importante cerrar el flujo
fs.Close()
		'ejercicios
        Dim bufferBytes(100) As Byte
        Dim fs As FileStream
        Dim caracter As Integer
        Dim CR As Integer = 13 ' enter
        Console.Write("Escribe el nombre para el archivo: ")
        Dim fichero As String = Console.ReadLine()
        ' P6E20 lee datos del teclado y los graba en un fichero.
        ' Pide el nombre del fichero por consola.
        fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Create, FileAccess.Write)
        Console.Write("Texto a guardar: ")
        Dim sw As StreamWriter
        sw = New StreamWriter(fs)
        sw.WriteLine(Console.ReadLine())
        sw.Close() 'super importante cerrar el flujo
        fs.Close()
        'P6E21 lee datos del teclado y los añade al final del
        'fichero
        fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Append, FileAccess.Write)
        Console.Write("Ahora añadir mas texto: ")
        sw = New StreamWriter(fs)
        sw.WriteLine(Console.ReadLine())
        sw.Close() 'super importante cerrar el flujo
        fs.Close()
        ' P6E22 lee datos del fichero y los muestra en pantalla
        fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Open, FileAccess.Read)
        Dim sr As StreamReader
        sr = New StreamReader(fs)
        Dim cadena As String = sr.ReadToEnd()
        Console.Write(cadena)
        sr.Close()
        fs.Close()
        ' P6E23 lee datos del teclado y se graban en el fichero
        ' a través del flujo FileStream y lee del fichero y muestra
        ' en pantalla
        fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Append, FileAccess.Write)		
        Dim contador As Integer
        Console.Write("Escribe algo: ")
        caracter = Console.Read()
        While (caracter <> CR And contador < 100)
            bufferBytes(contador) = Convert.ToByte(caracter)
            contador += 1
            caracter = Console.Read()
            Console.WriteLine(caracter)
        End While  
        fs.Write(bufferBytes, 0, bufferBytes.Length)
        fs.Close()       
        fs = New FileStream("C:\Users\8fdi02\Desktop\" & fichero, FileMode.Open, FileAccess.Read)
        sr = New StreamReader(fs)
        cadena = sr.ReadToEnd()
        Console.Write(cadena)
        sr.Close()
        fs.Close()
		
'FLUJOS DE DATOS BINARIOS'
'Definir un flujo de entrada
Dim fs As FileStream
Dim br As BinaryReader 'definir un flujo de entrada
fs = New FileStream(“c:\temp\doc.dat”, FileMode.Open, FileAccess.Read)
br = New BinaryReader(fs) - constructor

While (fs.Length > fs.Position)  ' While (br.PeekChar <> -1) lee el siguiente caracter, si es -1 es que no hay más
    nombreLeido = br.ReadString()
    apellidoLeido = br.ReadString()
    edadLeido = br.ReadString()
    Console.WriteLine("nombre: " & nombreLeido)
    Console.WriteLine("apellido: " & apellidoLeido)
    Console.WriteLine("edad: " & edadLeido)
End While

'Definir un flujo de salida
Dim fs As FileStream
Dim bw As BinaryWriter
fs = New FileStream(“c:\temp\doc.dat”, FileMode.Append, FileAccess.Write)
bw = New BinaryWriter(fs) - constructor

'br.ReadByte: Devuelve un valor de tipo Byte
'br.ReadBytes: Devuelve una matriz unidimensional de Bytes() (matriz de bytes)''
'br.ReadChar: Devuelve un valor de tipo Char
'br.ReadChars:Devuelve una matriz unidimensional de caracteres
'br.ReadInt16: Devuelve un valor de tipo Short
'br.ReadInt32: Devuelve un valor de tipo Integer
'br.ReadInt64: Devuelve un valor de tipo Long
'br.ReadDecimal: Devuelve un valor de tipo Decimal
'br.ReadSingle: Devuelve un valor de tipo Single
'br.ReadDouble: Devuelve un valor de tipo Double
'br.ReadString: Devuelve una cadena de caracteres de formato
'UTF-8; el primer o los dos primeros bytes especifican el
'numero de bytes de datos que serán leídos a continuación.

'Al leer si se alcanza final de fichero, lanzará la excepción
'EndOfStreamException, me obligará a poner un bloque Try .. Catch

'bw.Write(Byte): Escribe un valor de tipo Byte
'bw.Write(Byte()): Escribe una matriz unidimensional de Bytes
'bw.Write(Char): Escribe un valor de tipo Char
'bw.Write(Char()): Escribe una matriz unidimensional de caracteres
'bw.Write(Short): Escribe un valor de tipo Short
'bw.Write(Integer): Escribe un valor de tipo Integer
'bw.Write(Long): Escribe un valor de tipo Long
'bw.Write(Decimal): Escribe un valor de tipo Decimal
'bw.Write(Single): Escribe un valor de tipo Single
'bw.Write(Double): Escribe un valor de tipo Double
'bw.Write(String): Escribe una cadena de caracteres de
'formato UTF-8; el primer o los dos primeros bytesespecifican el numero de bytes de datos escritos a continuación.

'ACCESO ALEATORIO'
'Length: propiedad del flujo que me da la longitud total del fichero en bytes
'Position: propiedad del flujo me da la posición en bytes de donde se encuentra el puntero
'Seek: mueve el puntero de L/E a una nueva localización desplazada desp bytes de la
'posición pos del fichero. Los desplazamientos pueden ser positivos o negativos

'Seek (desp As Long, pos As SeekOrigin) As Long
'SeekOrigin define las constantes:
'Begin: Referencia la primera posición en el fichero
'Current: Referencia la primera posición actual
'End: Referencia a la última posición en el fichero

' referencia a la primera posición del fichero
br.BaseStream.Seek (desplazamiento, SeekOrigin.Begin)
' referencia a la primera posición actual
br.BaseStream.Seek (desplazamiento, SeekOrigin.Current)
' referencia a la última posición del fichero
br.BaseStream.Seek (desplazamiento, SeekOrigin.End)
'br no soporta el método Seek , es por lo que recurrimos a través de la propiedad BaseStream al método Seek del flujo fs

If (fs.Length = fs.Position)
Console.WriteLine(“Fin de Fichero..”)
End If

' Cálculo donde colocar el puntero
Dim desplazamiento As Integer = ( nroRgtro – 1) * longitudRegistro
Dim longitudRegistro As Long=100 'longitud del registro en Byte's
' posiciono el puntero desplazado tantos bytes a partir del principio
br.BaseStream.Seek(desp, SeekOrigin.Begin)
' dependiendo del tipo de flujo abierto
br.ReadString(xxxxx) - leo
bw.Write(xxxxxx) - grabo

'Leer - escribir'

Dim fs As FileStream
fs = New FileStream(“c:\temp\doc.dat”, FileMode.OpenOrCrearte, FileAccess.ReadWrite)
Dim br As BinaryReader
br = New BinaryReader(fs) 
'para leer
br.BaseStream.Seek (desplazamiento, SeekOrigin.Begin)
Dim bw As BinaryWriter
bw = New BinaryWriter(fs) 
' para escribir
bw.BaseStream.Seek (desplazamiento, SeekOrigin.Begin)

Dim fs As FileStream
Sub grabarFichero(ByRef fs As FileStream, ByRef contactosNuevos As ArrayList, ByRef registro As Integer, ByVal tamanio As Integer)
        'volcamos a fichero a partir del ultimo registro leido el contenido de contactosNuevos
        Console.WriteLine("Grabando fichero...")
        fs = New FileStream("agenda.dat", FileMode.Open, FileAccess.Write)
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        For Each contacto In contactosNuevos
            ' Console.WriteLine("contacto numero {0}", contacto.codigo)
            bw.BaseStream.Seek((registro - 1) * tamanio, SeekOrigin.Begin)
            registro += 1
            bw.Write(contacto.codigo)
            bw.Write(contacto.nombre)
            bw.Write(contacto.numero)
        Next
        bw.Close()
        fs.Close()
End Sub
Sub leerFichero(ByRef fs As FileStream, ByRef contactos As ArrayList, ByRef registro As Integer, ByVal tamanio As Integer, ByRef codigo As Integer, ByRef UltimoCodigoFichero As Integer)
        'leemos todo el contanido del fichero y lo volcamos al array contactos
        fs = New FileStream("agenda.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim br As BinaryReader = New BinaryReader(fs)
        Dim contacto As contacto
        While fs.Length > fs.Position
            'Console.WriteLine(fs.Length)
            'Console.WriteLine(fs.Position)
            br.BaseStream.Seek((registro - 1) * tamanio, SeekOrigin.Begin)
            registro += 1
            contacto.codigo = br.ReadInt32()
            codigo = contacto.codigo
            UltimoCodigoFichero = contacto.codigo
            contacto.nombre = br.ReadString()
            contacto.numero = br.ReadInt32()
            contactos.Add(contacto)
        End While
        br.Close()
        fs.Close()
End Sub
