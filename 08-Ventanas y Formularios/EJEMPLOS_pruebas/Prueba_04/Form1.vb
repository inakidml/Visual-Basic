Public Class Form1



    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click

        MsgBox("Se acaba de pulsar el boton de salida...........")
        Close()    'cierra el formulario pasa por Dispose y por el Main

        'End       'detiene inmediatamente la ejecución pasa por Dispose pero sin ir al Main

    End Sub


    'Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'sender: tiene informacion sobre el objeto que produce el evento
    'e:      tiene informacion que depende del evento producido



    Private Sub btSalir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSalir.MouseEnter
        Me.btSalir.BackColor = Color.Cyan

        AddHandler btAcoplado.Click, AddressOf tituloFormulario      'Añade
        'RemoveHandler btAcoplado.Click, AddressOf tituloFormulario  'Desconecta un controlador de un evento
    End Sub




    Private Sub tituloFormulario(ByVal sender As Object, ByVal e As EventArgs)
        Me.Text = "kkkkaixo"
        'MyBase.Text = "kaixo"  
    End Sub




    Private Sub btSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSalir.MouseLeave
        Me.btSalir.ResetBackColor()

        Me.btSalir.UseVisualStyleBackColor = True '

    End Sub

End Class
