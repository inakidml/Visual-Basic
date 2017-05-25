Public Class Cadena
    Private texto As String
    Private textoMod As String

    Public Sub New(textoEscrito As String)
        texto = textoEscrito
        textoMod = textoEscrito
    End Sub
    Public Property GetTextoMod() As String
        Get
            Return textoMod
        End Get
        Set(value As String)

        End Set
    End Property

    Public Sub desplazarLetras()
        Dim textoProv As String = textoMod.ElementAt(textoMod.Count - 1)
        Dim contador As Integer = 0
        For Each letra In textoMod
            contador += 1
            If textoMod.Count <> contador Then
                textoProv += letra
                'Console.Write(textoMod.Count)
                'Console.Write("contador: " & contador)
            End If
        Next
        textoMod = textoProv
        'Console.WriteLine(textoMod)
        'Console.ReadKey()
    End Sub
    Public Function comprobarFin() As Boolean
        If textoMod = texto Then
            Return False
        End If
        Return True
    End Function

End Class
