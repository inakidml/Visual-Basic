Module Module1

    Public Sub Main()

        'declara e instanciar un objeto de la clase del formulario 
        Dim oF1 As Form1
        oF1 = New Form1()

        'Dim oF1 As New Form1()

        oF1.Text = "probando desde código"

        ' asignamos el color de fondo al formulario
        ' utilizando uno de los miembros de la estructura Color de la plataforma
        oF1.BackColor = Color.Aquamarine
        'Form1.Show()

        Application.Run(oF1)
        ' se necesita crear un bucle de mensajes que le permita detectar los mensajes que
        ' le envia el S.O. y actuar en consecuencia para ello
        ' utilizamos método Run() de la clase Application 


        ' Se podria haber creado y lanzado a la vez, sin modificar propiedades 
        'Application.Run(New Form1)

        MsgBox("salgo desde el Main ....")


    End Sub


End Module
