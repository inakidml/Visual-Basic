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
            MsgBox("Se sale del Dispose...........")
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btAcoplado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(136, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proyecto con Eventos"
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(204, 128)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(128, 152)
        Me.btSalir.TabIndex = 1
        Me.btSalir.Text = "Salir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btAcoplado
        '
        Me.btAcoplado.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btAcoplado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btAcoplado.Location = New System.Drawing.Point(0, 349)
        Me.btAcoplado.Name = "btAcoplado"
        Me.btAcoplado.Size = New System.Drawing.Size(537, 53)
        Me.btAcoplado.TabIndex = 2
        Me.btAcoplado.Text = "Titulo Formulario"
        Me.btAcoplado.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btAcoplado
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 402)
        Me.Controls.Add(Me.btAcoplado)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btAcoplado As System.Windows.Forms.Button
End Class
