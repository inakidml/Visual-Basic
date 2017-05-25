Public Class Form1


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Dispose()

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        TextBoxMulti.Text = TextBoxMulti.Text & " " & TextBoxPalabra.Text
        TextBoxPalabra.Text = ""

    End Sub

    Private Sub ButtonIntro_Click(sender As Object, e As EventArgs) Handles ButtonIntro.Click
        TextBoxMulti.Text = TextBoxMulti.Text & " " & TextBoxPalabra.Text
        TextBoxMulti.Text = TextBoxMulti.Text & vbCrLf
        TextBoxPalabra.Clear()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        TextBoxMulti.Clear()
    End Sub


    Private Sub TextBoxPalabra_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxPalabra.MouseEnter
        LabelCarControl.Text = TextBoxPalabra.TextLength
        ' LabelCarSelec.Text = CStr(TextBoxPalabra.SelectionLength)

    End Sub
    Private Sub TextBoxPalabra_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxPalabra.MouseLeave
        LabelCarControl.Text = "0"
        'LabelCarSelec.Text = CStr(TextBoxPalabra.SelectionLength)
    End Sub
    Private Sub textoPalabra_MouseSelect(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxPalabra.MouseUp
        'TODO cuando se hace la seleccion (ahora esta cunado sale el ratón)
        LabelCarSelec.Text = CStr(TextBoxPalabra.SelectionLength)
    End Sub
End Class
