'Crear una tabla <asignaturas> e inicialízala con el nombre de 6 asignaturas 
'crear una estructura <asignaturaNota> que contenga el nombre asignatura y la nota
'crear la tabla para guardar los nombre de los alumnos <alumnos>, que introduciremos mas tarde (serán 3)
'crea la tabla <matriculaAlumnos>, primer nivel, que será dentada, donde luego guardaremos los bloques de
'  (asignatura y notas de la asignatura) en las que se haya matriculado cada uno de los (3) alumnos

'crea el procedimiento entradaDatos
'   repetir – tantas veces como alumnos se matriculen
'      pedir nombre alumno 
'         guardar en la tabla y recordar la posición en la que se ha guardado
'      visualiza (procedimiento) el nombre de las asignaturas
'      pedir número de asignaturas en las que se ha matriculado
'      crear huecos  (columnas) en la M. escalonada  matriculaAlumnos
'      repetir – tanta veces como asignaturas tengas ese alumno
'         pedir nombre asignatura y comprobar si el nombre es correcto (procedimiento) y guardar nombre asignatura en
'            AsignaturaNotas en la posición asociada para ese alumno
'         pedir nota en esa asignatura y guardar en  AsignaturaNotas misma posición que asignatura

'Visualizar (procedimiento) por alumnos asignaturas y notas en las que está matriculado.
'    de cada alumno saco asignatura con la nota y la media de ese alumno
'Visualizar (procedimiento) por asignaturas las medias obtenidas
'    de cada asignatura, la busco en todos los alumnos para calcular la media


Module Module1
    Structure asignaturaNota
        Dim asignatura As String
        Dim nota As Single
    End Structure
    Const totalAlumnos As Int32 = 2         'seran tres alumnos
    Const totalAsignaturas As Int32 = 5     'seran seis asignaturas distintas

    Sub Main()
        Dim asignaturas() As String = New String() {"FOL", "PLE", "VB", "SO", "CALIDAD", "ANALISIS"}
        Dim alumnos(totalAlumnos) As String

        'Matriz escalonada, para un máximo de 3 alumnos
        'Dim matriculaAlumnos()() As alumno = New alumno(totalAlumnos)() {}
        Dim matriculaAlumnos(totalAlumnos)() As asignaturaNota


        DatosEntrada(matriculaAlumnos, alumnos, asignaturas)

        'visualizar las notas medias por alumno
        VisualizarNotasAlumnos(matriculaAlumnos, alumnos)

        VisualizarNotasAsignaturas(matriculaAlumnos, asignaturas)
        Console.ReadLine()

    End Sub

    Sub DatosEntrada(ByRef matriculaAlumnos()() As asignaturaNota, ByRef alumnos() As String, ByRef asignaturas() As String)

        For x As Integer = 0 To alumnos.Length - 1

            Console.Write("Teclea el nombre del alumno: ")
            alumnos(x) = Console.ReadLine()
            Console.WriteLine()
            visualizaNombreAsignaturas(asignaturas)
            Dim nro As Integer  'numero de asignaturas en la que se matricula
            Do
                Console.Write("Teclea el número de asignaturas de las que está matriculado este alumno: ")
                nro = LeerEntero()
            Loop While (nro < 1 OrElse nro > 6) 'OrElse, si la 1ª cond. es True no evalua la segunda

            matriculaAlumnos(x) = New asignaturaNota(nro - 1) {}  'crea huecos asig-notas para ese alumno
            Dim y As Integer
            For y = 0 To nro - 1         'recojo las asignaturas
                Dim nombreAsignatura As String
                Do
                    Console.Write("Teclea el nombre de la asignatura: ")
                    nombreAsignatura = Console.ReadLine().ToUpper
                    If (validarNombreasignatura(nombreAsignatura, asignaturas) = False) Then
                        Console.WriteLine("Error al introducir el nombre de la asignatura...")
                        visualizaNombreAsignaturas(asignaturas)
                    End If
                Loop While (validarNombreasignatura(nombreAsignatura, asignaturas) = False)

                matriculaAlumnos(x)(y).asignatura = nombreAsignatura
                Console.WriteLine()

                Dim nota As Single
                Do
                    Console.WriteLine("Teclea la nota: ")
                    nota = LeerSingle()
                    If (nota < 0 OrElse nota > 10) Then Console.WriteLine("El rango es entre 0..10")
                Loop While (nota < 0 OrElse nota > 10)
                matriculaAlumnos(x)(y).nota = nota
            Next
        Next
    End Sub

    Private Sub visualizaNombreAsignaturas(ByVal asignaturas As String())
        Console.WriteLine(vbCrLf & " Las asignaturas existentes son:  " & vbCrLf)
        For Each elemento In asignaturas
            Console.Write("  {0} ", elemento)
        Next
        Console.WriteLine(vbCrLf)
    End Sub

    Function validarNombreasignatura(ByVal nombreAsignatura As String, ByRef asignaturas() As String) As Boolean
        Dim z As Integer

        ' AndAlso, si la 1ª es False no evalua la segunda
        While (z < asignaturas.Length AndAlso nombreAsignatura <> asignaturas(z))
            z += 1
        End While
        If z = 6 Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub VisualizarNotasAlumnos(ByRef matriculaAlumnos()() As asignaturaNota, ByRef alumnos() As String)
        Dim x, y As Integer
        Dim sumaNotas As Single = 0
        Dim contadorNotas As Integer = 0

        'para cada alumno saco asignatura con la nota y la media de ese alumno
        For x = 0 To alumnos.Length - 1   'para cada alumno
            Console.WriteLine()
            Console.WriteLine("El alumno: " & alumnos(x) & " ")

            sumaNotas = 0
            contadorNotas = 0
            y = 0 'calculo la nota para cada asignatura 
            Do
                Console.Write(matriculaAlumnos(x)(y).asignatura & " " & matriculaAlumnos(x)(y).nota & " ")
                contadorNotas += 1
                sumaNotas = sumaNotas + matriculaAlumnos(x)(y).nota
                y += 1 'avanzo otra asignatura
            Loop While (y < matriculaAlumnos(x).GetUpperBound(0) + 1)  'y < indice mas alto de esa fila

            Console.WriteLine(vbCrLf & " La nota media de {0} es {1:f2}", alumnos(x), sumaNotas / contadorNotas)
        Next
    End Sub

    Sub VisualizarNotasAsignaturas(ByRef matriculaAlumnos()() As asignaturaNota, ByRef asignaturas() As String)

        Dim notas(totalAsignaturas) As Single   ' acumulo las notas en la asig independiente del alumno
        Dim tcont(totalAsignaturas) As Integer  ' contabilizo cuanto alumnos estan matriculados en la asig
        Dim y, x As Integer
        Dim z As Integer
        Dim ASIGNATURA As String

        Console.WriteLine(vbCrLf & "Las notas por asignaturas son: " & vbCrLf)
        For z = 0 To totalAsignaturas 'por cada asignatura
            ASIGNATURA = asignaturas(z)

            For x = 0 To totalAlumnos 'para cada alumno

                y = 0 'para las asignaturas de este alumno

                While (y <= matriculaAlumnos(x).GetUpperBound(0)) 'nos da el indice mas alto de la dimension pasada p.206
                    If (matriculaAlumnos(x)(y).asignatura = ASIGNATURA) Then 'buscar la asignatura
                        notas(z) = notas(z) + matriculaAlumnos(x)(y).nota
                        tcont(z) += 1
                    End If
                    y += 1 'asi miro todas las asignatura de ese alumno
                End While
            Next
        Next
        For z = 0 To totalAsignaturas
            If tcont(z) <> 0 Then
                Console.WriteLine("La nota media en {0} es {1:f2} notas {2} cont {3}", asignaturas(z), notas(z) / tcont(z), notas(z), tcont(z))
            Else
                Console.WriteLine("No se dispone de notas en {0}", asignaturas(z))
            End If
        Next

    End Sub

    Public Function LeerEntero() As Integer
        Try
            Return Int32.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Int32.MinValue ' valor más pequeño
        End Try
    End Function

    Private Function LeerSingle() As Single
        Try
            Return Single.Parse(Console.ReadLine())
        Catch e As FormatException
            Return Single.MinValue ' valor más pequeño
        End Try
    End Function


End Module
