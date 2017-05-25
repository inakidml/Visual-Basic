<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ctNombre = New System.Windows.Forms.TextBox()
        Me.ctSalario = New System.Windows.Forms.TextBox()
        Me.btDatos = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.etTituloNombre = New System.Windows.Forms.Label()
        Me.etTituloSalario = New System.Windows.Forms.Label()
        Me.etTituloFechaAlta = New System.Windows.Forms.Label()
        Me.etNombre = New System.Windows.Forms.Label()
        Me.etSalario = New System.Windows.Forms.Label()
        Me.etDiasTrabajados = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mskFechaAlta = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'ctNombre
        '
        Me.ctNombre.Location = New System.Drawing.Point(108, 58)
        Me.ctNombre.Name = "ctNombre"
        Me.ctNombre.Size = New System.Drawing.Size(100, 20)
        Me.ctNombre.TabIndex = 0
        '
        'ctSalario
        '
        Me.ctSalario.Location = New System.Drawing.Point(108, 85)
        Me.ctSalario.Name = "ctSalario"
        Me.ctSalario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ctSalario.Size = New System.Drawing.Size(100, 20)
        Me.ctSalario.TabIndex = 1
        '
        'btDatos
        '
        Me.btDatos.Location = New System.Drawing.Point(108, 151)
        Me.btDatos.Name = "btDatos"
        Me.btDatos.Size = New System.Drawing.Size(100, 23)
        Me.btDatos.TabIndex = 3
        Me.btDatos.Text = "Mostrar Datos"
        Me.btDatos.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(31, 304)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(289, 23)
        Me.btSalir.TabIndex = 4
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'etTituloNombre
        '
        Me.etTituloNombre.AutoSize = True
        Me.etTituloNombre.Location = New System.Drawing.Point(28, 189)
        Me.etTituloNombre.Name = "etTituloNombre"
        Me.etTituloNombre.Size = New System.Drawing.Size(50, 13)
        Me.etTituloNombre.TabIndex = 5
        Me.etTituloNombre.Text = "Nombre: "
        Me.etTituloNombre.Visible = False
        '
        'etTituloSalario
        '
        Me.etTituloSalario.AutoSize = True
        Me.etTituloSalario.Location = New System.Drawing.Point(31, 218)
        Me.etTituloSalario.Name = "etTituloSalario"
        Me.etTituloSalario.Size = New System.Drawing.Size(45, 13)
        Me.etTituloSalario.TabIndex = 6
        Me.etTituloSalario.Text = "Salario: "
        Me.etTituloSalario.Visible = False
        '
        'etTituloFechaAlta
        '
        Me.etTituloFechaAlta.AutoSize = True
        Me.etTituloFechaAlta.Location = New System.Drawing.Point(31, 246)
        Me.etTituloFechaAlta.Name = "etTituloFechaAlta"
        Me.etTituloFechaAlta.Size = New System.Drawing.Size(103, 13)
        Me.etTituloFechaAlta.TabIndex = 7
        Me.etTituloFechaAlta.Text = "Dias en la empresa: "
        Me.etTituloFechaAlta.Visible = False
        '
        'etNombre
        '
        Me.etNombre.AutoSize = True
        Me.etNombre.Location = New System.Drawing.Point(143, 189)
        Me.etNombre.Name = "etNombre"
        Me.etNombre.Size = New System.Drawing.Size(39, 13)
        Me.etNombre.TabIndex = 8
        Me.etNombre.Text = "Label1"
        Me.etNombre.Visible = False
        '
        'etSalario
        '
        Me.etSalario.AutoSize = True
        Me.etSalario.Location = New System.Drawing.Point(143, 218)
        Me.etSalario.Name = "etSalario"
        Me.etSalario.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etSalario.Size = New System.Drawing.Size(39, 13)
        Me.etSalario.TabIndex = 9
        Me.etSalario.Text = "Label1"
        Me.etSalario.Visible = False
        '
        'etDiasTrabajados
        '
        Me.etDiasTrabajados.AutoSize = True
        Me.etDiasTrabajados.Location = New System.Drawing.Point(143, 246)
        Me.etDiasTrabajados.Name = "etDiasTrabajados"
        Me.etDiasTrabajados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.etDiasTrabajados.Size = New System.Drawing.Size(39, 13)
        Me.etDiasTrabajados.TabIndex = 10
        Me.etDiasTrabajados.Text = "Label1"
        Me.etDiasTrabajados.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Salario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha Alta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Datos del Empleado "
        '
        'mskFechaAlta
        '
        Me.mskFechaAlta.Location = New System.Drawing.Point(108, 115)
        Me.mskFechaAlta.Mask = "00/00/0000"
        Me.mskFechaAlta.Name = "mskFechaAlta"
        Me.mskFechaAlta.Size = New System.Drawing.Size(66, 20)
        Me.mskFechaAlta.TabIndex = 2
        Me.mskFechaAlta.ValidatingType = GetType(Date)
        '
        'dtpFechaAlta
        '
        Me.dtpFechaAlta.Location = New System.Drawing.Point(257, 118)
        Me.dtpFechaAlta.Name = "dtpFechaAlta"
        Me.dtpFechaAlta.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaAlta.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 349)
        Me.Controls.Add(Me.dtpFechaAlta)
        Me.Controls.Add(Me.mskFechaAlta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.etDiasTrabajados)
        Me.Controls.Add(Me.etSalario)
        Me.Controls.Add(Me.etNombre)
        Me.Controls.Add(Me.etTituloFechaAlta)
        Me.Controls.Add(Me.etTituloSalario)
        Me.Controls.Add(Me.etTituloNombre)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btDatos)
        Me.Controls.Add(Me.ctSalario)
        Me.Controls.Add(Me.ctNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ctNombre As System.Windows.Forms.TextBox
    Friend WithEvents ctSalario As System.Windows.Forms.TextBox
    Friend WithEvents btDatos As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents etTituloNombre As System.Windows.Forms.Label
    Friend WithEvents etTituloSalario As System.Windows.Forms.Label
    Friend WithEvents etTituloFechaAlta As System.Windows.Forms.Label
    Friend WithEvents etNombre As System.Windows.Forms.Label
    Friend WithEvents etSalario As System.Windows.Forms.Label
    Friend WithEvents etDiasTrabajados As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mskFechaAlta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpFechaAlta As System.Windows.Forms.DateTimePicker

End Class
