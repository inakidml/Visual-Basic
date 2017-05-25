Public Class Form1
    Dim medallas As New medallas

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        ' Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ButtonuUsa_Click(sender As Object, e As EventArgs) Handles ButtonuUsa.Click
        TextBox1.Text = medallas.GetMedallasUsa
        ButtonuUsa.Enabled = False
        comprobarTodos()
    End Sub

    Private Sub ButtonRusia_Click(sender As Object, e As EventArgs) Handles ButtonRusia.Click
        TextBox2.Text = medallas.GetMedallasRusia
        ButtonRusia.Enabled = False
        comprobarTodos()
    End Sub

    Private Sub ButtonAlemania_Click(sender As Object, e As EventArgs) Handles ButtonAlemania.Click
        TextBox3.Text = medallas.GetMedallasAlemania
        ButtonAlemania.Enabled = False
        comprobarTodos()
    End Sub

    Private Sub ButtonAustralia_Click(sender As Object, e As EventArgs) Handles ButtonAustralia.Click
        TextBox4.Text = medallas.GetMedallasAustralia
        ButtonAustralia.Enabled = False
        comprobarTodos()
    End Sub

    Private Sub ButtonCampeon_Click(sender As Object, e As EventArgs) Handles ButtonCampeon.Click


        Dim ganador As String
            Dim masALto As Integer
            If medallas.GetMedallasUsa > medallas.GetMedallasRusia Then
                ganador = "USA"
                masALto = medallas.GetMedallasUsa
            Else
                ganador = "RUSIA"
                masALto = medallas.GetMedallasRusia
            End If
            If medallas.GetMedallasAlemania > masALto Then
                ganador = "ALEMANIA"
                masALto = medallas.GetMedallasAlemania
            End If
            If medallas.GetMedallasAustralia > masALto Then
                ganador = "ALEMANIA"
                masALto = medallas.GetMedallasAustralia
            End If
        TextBox5.Text = "El ganador ha sido " & ganador & " con " & masALto & " medallas"



    End Sub
    Public Sub comprobarTodos()
        If ButtonuUsa.Enabled = False And ButtonRusia.Enabled = False And ButtonAlemania.Enabled = False And ButtonAustralia.Enabled = False Then
            ButtonCampeon.Enabled = True
        Else
            'MsgBox("Debe pulsar los cuatro paises")
        End If
    End Sub
End Class
