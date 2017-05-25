Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Location = New Point(0, 0)
    End Sub

    Dim numero As Integer = 0
    Dim nombre As String = "btnNuevo"
    Dim tamanioBtn As Size = New Size(170, 23)
    Dim yBoton As Integer = 200
    Dim xBoton As Integer = 0

    Dim yGbox1 As Integer = 0
    Dim xGBox1 As Integer = 0



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numero += 1
        Dim btnNuevo As Button = Nothing 'lo declaro
        btnNuevo = New Button() 'lo creo
        btnNuevo.Name = nombre & numero 'le doy un nombre
        btnNuevo.Text = "Botón" 'le doy las propiedades
        btnNuevo.Size = tamanioBtn
        btnNuevo.Location = New Point(xBoton, yBoton) 'le doy las propiedades
        GroupBox2.Controls.Add(btnNuevo)
        xBoton += 180
        AddHandler btnNuevo.Click, AddressOf Me.DinButton_Click

    End Sub
    Private Sub DinButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FormPareja.Show()

    End Sub
    Private Sub CrearBoton(ByRef botonPadre As Button)


    End Sub

End Class
