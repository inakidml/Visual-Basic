Public Class CEmpleado
    Private nombre As String
    Private salario As Double
    Private fechaAlta As Date
    Private diasTrabajados As Integer

    Sub New(ByVal nombre As String, ByVal salario As Double, ByVal fechaAlta As Date)
        Me.nombre = nombre
        Me.salario = salario
        Me.fechaAlta = fechaAlta
        diasTrabajados = 0
    End Sub

    Sub New()
    End Sub

    'Métodos
    Public Property nombreEmpleado() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            Me.nombre = value
        End Set
    End Property

    Public Property salarioEmpleado() As Double
        Get
            Return salario
        End Get
        Set(ByVal value As Double)
            If value = Nothing Then
                salario = 0
            Else
                Me.salario = value
            End If
        End Set
    End Property

    Public Property fechaAltaEmpleado() As Date
        Get
            Return fechaAlta
        End Get
        Set(ByVal value As Date)
            If value = Nothing Then
                fechaAlta = Date.Today
            Else
                Me.fechaAlta = value
            End If
        End Set
    End Property


    'Public Property diasTrabajadosEmpleado() As Integer
    '    Get
    '        Return diasTrabajados
    '    End Get
    '    Set(ByVal value As Integer)
    '        Me.diasTrabajados = value
    '    End Set
    'End Property

    Public ReadOnly Property diasTrabajadosEmpleado() As Integer
        Get
            Return diasTrabajados
        End Get
    End Property


    'Otros Métodos
    Public Sub calcularDiasTrabajados()
        Dim tiempoPasado As TimeSpan = DateTime.Now.Subtract(Me.fechaAlta)
        diasTrabajados = tiempoPasado.Days
    End Sub

End Class
