Public Class Form1


    'al mover el ratón sobre el control, en este caso sobre el formulario, se produce el evento
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'e.X y e.Y: me da las coordenadas de donde se posiciona el ratón
        Me.Text = "Coordenadas raton X: " & e.X & " Y: " & e.Y

    End Sub

    'Al pulsar el boton rojo de cierre de ventana, se lanza Closing cuando está en proceso de cierre
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If MessageBox.Show("Cerrar ventana?", "Atencion", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then

            e.Cancel = True  'indica o establece si se debe cancelar el evento

        End If

    End Sub

End Class
