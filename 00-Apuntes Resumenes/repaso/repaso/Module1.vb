Imports System.IO

Module Module1

    Sub Main()
        Dim array As Integer(,)
        array = {{89, 45}, {25, 46}}
        Dim otroArray()() As Integer = New Integer(1)() {}
        Dim arrayString As String() = New String(9) {}
        Dim arrayList As New ArrayList
        arrayString(2) = "hola"
        Dim random As New Random
        For Each n In array
            Console.WriteLine(n)

        Next
        Console.WriteLine(random.Next(10))
        System.Array.Sort(arrayString)
        Console.WriteLine(System.Array.BinarySearch(arrayString, "hola"))

        Dim fs As FileStream
        Try
            fs = New FileStream("hola.txt", FileMode.Append, FileAccess.Write)
        Catch ex As Exception
            fs = New FileStream("hola.txt", FileMode.OpenOrCreate, FileAccess.Write)
        End Try

        Dim sw As StreamWriter = New StreamWriter(fs)
        Console.WriteLine("escribe algo")
        sw.WriteLine(Console.ReadLine())
        sw.Close()
        fs.Close()

        Console.WriteLine("VAmos aleer fichero")
        fs = New FileStream("hola.txt", FileMode.Open, FileAccess.Read)
        Dim sr As StreamReader = New StreamReader(fs)
        Console.WriteLine(sr.ReadToEnd)


        Console.ReadKey()
    End Sub

End Module
