<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPalabra = New System.Windows.Forms.TextBox()
        Me.TextBoxMulti = New System.Windows.Forms.TextBox()
        Me.ButtonIntro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCarControl = New System.Windows.Forms.Label()
        Me.LabelCarSelec = New System.Windows.Forms.Label()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(78, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editor de texto Multilineal"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(314, 88)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAceptar.TabIndex = 1
        Me.ButtonAceptar.Text = "Aceptar"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Palabra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Texto"
        '
        'TextBoxPalabra
        '
        Me.TextBoxPalabra.Location = New System.Drawing.Point(63, 90)
        Me.TextBoxPalabra.Name = "TextBoxPalabra"
        Me.TextBoxPalabra.Size = New System.Drawing.Size(243, 20)
        Me.TextBoxPalabra.TabIndex = 4
        '
        'TextBoxMulti
        '
        Me.TextBoxMulti.Location = New System.Drawing.Point(63, 162)
        Me.TextBoxMulti.Multiline = True
        Me.TextBoxMulti.Name = "TextBoxMulti"
        Me.TextBoxMulti.Size = New System.Drawing.Size(407, 247)
        Me.TextBoxMulti.TabIndex = 5
        '
        'ButtonIntro
        '
        Me.ButtonIntro.Location = New System.Drawing.Point(395, 88)
        Me.ButtonIntro.Name = "ButtonIntro"
        Me.ButtonIntro.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIntro.TabIndex = 6
        Me.ButtonIntro.Text = "Intro"
        Me.ButtonIntro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 453)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Carácteres en el control"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Carácteres seleccionados"
        '
        'LabelCarControl
        '
        Me.LabelCarControl.AutoSize = True
        Me.LabelCarControl.Location = New System.Drawing.Point(63, 487)
        Me.LabelCarControl.Name = "LabelCarControl"
        Me.LabelCarControl.Size = New System.Drawing.Size(13, 13)
        Me.LabelCarControl.TabIndex = 9
        Me.LabelCarControl.Text = "0"
        '
        'LabelCarSelec
        '
        Me.LabelCarSelec.AutoSize = True
        Me.LabelCarSelec.Location = New System.Drawing.Point(246, 487)
        Me.LabelCarSelec.Name = "LabelCarSelec"
        Me.LabelCarSelec.Size = New System.Drawing.Size(13, 13)
        Me.LabelCarSelec.TabIndex = 10
        Me.LabelCarSelec.Text = "0"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(63, 416)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiar.TabIndex = 11
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Location = New System.Drawing.Point(395, 487)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 12
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 525)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.LabelCarSelec)
        Me.Controls.Add(Me.LabelCarControl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonIntro)
        Me.Controls.Add(Me.TextBoxMulti)
        Me.Controls.Add(Me.TextBoxPalabra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPalabra As TextBox
    Friend WithEvents TextBoxMulti As TextBox
    Friend WithEvents ButtonIntro As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelCarControl As Label
    Friend WithEvents LabelCarSelec As Label
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
End Class
