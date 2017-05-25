Public Class Form1
    
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        For Each control In Me.Controls
            If (TypeOf control Is TextBox) Then
                control.Enabled = False
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each control In Controls
            If (TypeOf control Is Label) Then
                control.ForeColor = Color.Red

            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each control In Controls
            If (TypeOf control Is TextBox) Then
                control.BackColor = Color.Green
            End If
        Next

        Dim etNueva As Label = Nothing 'la declaro
        etNueva = New Label() 'la creo
        etNueva.Name = "etNueva" 'le doy un nombre
        etNueva.Text = "Etiqueta Nueva...." 'le doy las propiedades
        etNueva.Location = New Point(89, 78) 'le doy las propiedades
        Controls.Add(etNueva) 'la añado al formulario
        Controls.Remove(TextBox1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each control In Controls
            If (TypeOf control Is Button) Then
                control.ForeColor = Color.Blue
            End If
        Next
    End Sub
End Class
