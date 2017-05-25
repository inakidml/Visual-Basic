Public Class Controlador
    'atributos
    Private oF1 As Form1
    Private objEmpleado As CEmpleado         'se podría declarar dentro de TtoDatos


    'Métodos
    Public Sub New()
        'A la vez que se crea el constructor creo la vtna y le paso mi Ref
        oF1 = New Form1(Me)
    End Sub

    Sub comenzar()
        oF1.Empieza()
    End Sub

    Sub terminar()
        oF1.Dispose()
        Application.Exit()
    End Sub

    ''Function TtoDatos(ByVal ctNombre As TextBox, ByVal ctSalario As TextBox, ByVal mskFechaAlta As MaskedTextBox) As CEmpleado
    Function TtoDatos(ByVal ctNombre As TextBox, ByVal ctSalario As TextBox, ByVal dtpFechaAlta As DateTimePicker) As CEmpleado

        'Si se crea el objeto ya inicializado con los valores
        'Dim nombre As String = ctNombre.Text
        'Dim salario As Double = CDbl(ctSalario.Text)
        'Dim fechaAlta As Date = dtpFechaAlta.Value.Date
        ''Dim fechaAlta As Date = CDate(mskFechaAlta.Text)
        'Dim objEmpleado = New CEmpleado(nombre, salario, fechaAlta)

        'creo el objeto
        Dim objEmpleado = New CEmpleado()
        'lo inicializo con los valores
        objEmpleado.nombreEmpleado = ctNombre.Text
        objEmpleado.salarioEmpleado = CDbl(ctSalario.Text)
        objEmpleado.fechaAltaEmpleado = CDate(dtpFechaAlta.Text)
        ''objEmpleado.fechaAltaEmpleado = CDate(mskFechaAlta.Text)

        'calculo los dias
        objEmpleado.calcularDiasTrabajados()

        Return objEmpleado
    End Function



End Class
