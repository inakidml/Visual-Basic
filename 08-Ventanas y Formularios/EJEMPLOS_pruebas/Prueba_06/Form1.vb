Public Class Form1

    Private oc As Controlador
    Dim formato As String = "#,###,###,##0.00"


    'Métodos constructores
    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Sub New(ByRef oc As Controlador)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.oc = oc
    End Sub

    'Métodos
    Sub Empieza()
        'muestro la vtna
        Me.Show()
        Me.Text = "Datos del personal de ERPASA"

        'limpio los campos de la vtna
        Me.ctNombre.Clear()      'podria sobrar
        Me.ctSalario.Clear()         'podria sobrar

        Me.mskFechaAlta.Text = CStr(Date.Today)

        'posiciono el foco
        Me.ctNombre.Focus()
        Me.ctNombre.SelectAll()
    End Sub


    Private Sub btDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDatos.Click
        Try
            'Datos de Entrada y recogida de objeto
            'Dim objeto As CEmpleado = oc.TtoDatos(ctNombre, ctSalario, mskFechaAlta)
            Dim objeto As CEmpleado = oc.TtoDatos(ctNombre, ctSalario, dtpFechaAlta)

            'Datos de Salida 
            etNombre.Text = objeto.nombreEmpleado

            'etSalario.Text = CStr(objeto.salarioEmpleado) 'sin formato ninguno
            etSalario.Text = Format(objeto.salarioEmpleado, "#,###,###,##0.00")
            'etSalario.Text = String.Format("{0:F2}", objeto.salarioEmpleado)
            'etSalario.Text = String.Format("{0:n2}", objeto.salarioEmpleado)
            '{0,5:F2} 0:posicionArgumento, 5:nnro de digitos, F:tipo float, 2:nro decimales
            etDiasTrabajados.Text = CStr(objeto.diasTrabajadosEmpleado)

            etNombre.Visible = True
            etSalario.Visible = True
            etDiasTrabajados.Visible = True
            etTituloNombre.Visible = True
            etTituloSalario.Visible = True
            etTituloFechaAlta.Visible = True

            ctNombre.Focus()
            ctNombre.SelectAll()
        Catch ex As Exception
            MsgBox("Error imprevisto: ")
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub controlNumerico(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctSalario.KeyPress
        Validaciones.Numeros(e)

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True          'tomo yo el mando sobre que hacer en el control
            'SendKeys.Send("{TAB}")
            'SendKeys.Send(Chr(9))    
            SendKeys.Send(vbTab)      'al pulsar Enter enviamos un control de Tabulador
        End If

        'ChrW: devuelve el caracter asociasdo al codigo de caracter especificado
        'Keys: especifica el codigo de tecla - Enter=13, Tab=9, Back=8retroceso
        'SendKeys: proporciona métodos para enviar pulsaciones de teclas a una aplicación
        'Send: envía pulsaciones de tecla a la aplicacion activa
    End Sub

    Private Sub controlIntro(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True          'tomo yo el mando sobre que hacer en el control
            'SendKeys.Send("{TAB}")
            'SendKeys.Send(Chr(9))    
            SendKeys.Send(vbTab)      'al pulsar Enter enviamos un control de Tabulador
        End If
    End Sub

    Private Sub mskFechaAlta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFechaAlta.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                Dim dia As String = mskFechaAlta.Text.Substring(0, 2)
                Dim mes As String = mskFechaAlta.Text.Substring(3, 2)
                Dim año As String = mskFechaAlta.Text.Substring(6, 4)
                'MsgBox("dia " & dia)
                'MsgBox("mes " & mes)
                'MsgBox("año " & año)

                If Validaciones.ComprobarDiaDelMes(dia, mes, año) Then
                    e.Handled = True
                    mskFechaAlta.SelectAll()
                Else
                    e.Handled = True          'tomo yo el mando sobre que hacer en el control
                    'SendKeys.Send("{TAB}")
                    'SendKeys.Send(Chr(9))    
                    SendKeys.Send(vbTab)      'al pulsar Enter enviamos un control de Tabulador
                End If
            End If
        Catch ex As Exception
            MsgBox("Error imprevisto " & ex.Message)
            e.Handled = True
        End Try
    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        oc.terminar()
    End Sub


    Private Sub mskFechaAlta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskFechaAlta.Enter
        mskFechaAlta.Focus()
        mskFechaAlta.SelectAll()
    End Sub


End Class
