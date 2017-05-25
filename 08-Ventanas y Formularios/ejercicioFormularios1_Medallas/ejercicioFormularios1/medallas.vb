Public Class medallas
    Private medallasUsa As Integer
    Private medallasRusia As Integer
    Private medallasAlemania As Integer
    Private medallasAustralia As Integer

    Public Sub New()

        Dim random As New Random
        medallasUsa = random.Next(1, 10)
        medallasRusia = random.Next(1, 10)
        medallasUsa = random.Next(1, 10)
        medallasAlemania = random.Next(1, 10)
        medallasAustralia = random.Next(1, 10)

    End Sub

    Public ReadOnly Property GetMedallasUsa() As Integer
        Get
            Return medallasUsa
        End Get
    End Property
    Public ReadOnly Property GetMedallasRusia() As Integer
        Get
            Return medallasRusia
        End Get
    End Property
    Public ReadOnly Property GetMedallasAlemania() As Integer
        Get
            Return medallasAlemania
        End Get
    End Property
    Public ReadOnly Property GetMedallasAustralia() As Integer
        Get
            Return medallasAustralia
        End Get
    End Property

End Class
