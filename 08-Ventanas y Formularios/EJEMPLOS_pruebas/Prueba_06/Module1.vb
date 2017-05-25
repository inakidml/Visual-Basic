Module Module1
    Public Sub Main()

        'para iniciar ejecucion creo el objeto controlador
        'desde donde dirigiré toda la ejecucion
        Dim oc As Controlador
        oc = New Controlador()

        'le cedo el control 
        oc.comenzar()

        'genero un bucle de llamadas con el S.O.
        Application.Run()

    End Sub
End Module
