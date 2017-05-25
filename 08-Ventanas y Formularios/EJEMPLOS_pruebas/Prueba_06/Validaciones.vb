Module Validaciones
    'IMPORTANTE- con KeyPress, la tecla pulsada se valida antes de que se añada el caracter a la caja

    Public Sub Numeros(ByRef e As KeyPressEventArgs)
        Dim car As String
        car = e.KeyChar
        If InStr("0123456789" & Chr(13) & Chr(8) & ",", car) = 0 Then
            Beep()
            e.Handled = True
        End If
        'InStr:devuelve un entero que indica la posicion de la primera aparicion en la cadena 1...n
        ' si = 0, no lo encuentra, por tanto error ...
        ' ASCII 13=Enter y 8=TeclaRetroceso Backspace
    End Sub

    Public Sub NumerosReales(ByVal sender As System.Object, ByRef e As KeyPressEventArgs)
        'si quiero controlar que no haya mas que una coma y un signo + o - y sólo al principio 
        '(p70) valido a medida que se teclea cada caracter
        'IMPORTANTE- la tecla pulsada se valida antes de que el controlador añada el caracter a la caja

        If (e.KeyChar = Convert.ToChar(13)) Then  'e contiene informacion sobre el evento producido, e.keyChar nos da la tecla pulsada
            'se pulsó la tecla intro
            e.Handled = True  'tomo yo el control de la tecla intro y sigo no dejo que se escriba
        ElseIf (e.KeyChar = Convert.ToChar(8)) Then
            'se pulsó la tecla retroceso
            e.Handled = False 'sigue con el control, permitira que retroceda un caracter que es la función habitual de la retroceso
        ElseIf (e.KeyChar = ","c) Then
            Dim objTextBox As TextBox = CType(sender, TextBox)
            'import hace la validadcion antes de añadir el caracter
            If (objTextBox.Text.IndexOf(","c) <> -1) Then
                'IndexOf(","c) devuelve el indice de la 1ª aparicion del caracter especificado en la cadena
                'sólo puede haber una coma - si pasa por aqui quiere decir que ya hay una ","
                e.Handled = True 'tomo yo el control de la tecla, y no le permito que inserte la "," que es su func. por defecto
            End If
        ElseIf (e.KeyChar = "-"c Or e.KeyChar = "+"c) Then  'para que si hay signo este al comienzo del campo y solo uno
            Dim objTextBox As TextBox = CType(sender, TextBox)
            'admitir - o + solo en la primera posicion
            If (objTextBox.SelectionLength = objTextBox.TextLength) Then
                'si todo el texto está seleccionado: por tanto está vacio, se sobreescribe con el signo
                e.Handled = False  'le permitira que añada + o - que es la función habitual de las teclas + y -
            ElseIf (objTextBox.TextLength <> 0) Then
                'la primera posicion ya está ocupada
                e.Handled = True  'tomo yo el control,no le permitira que añada + o - que es la función habitual de las teclas + y - 
            End If
        ElseIf (e.KeyChar < "0"c Or e.KeyChar > "9"c) Then
            'desechar los caracteres que no son digitos
            e.Handled = True 'tomo yo el control, y no le dejo que inserte ese caracter
        End If
    End Sub

    Public Sub Letras(ByVal e As KeyPressEventArgs)
        Dim car As String
        car = e.KeyChar
        If InStr("0123456789", car) <> 0 Then
            Beep()
            e.Handled = True
        End If
    End Sub

    Public Sub LetrasEnterRetroceso(ByVal e As KeyPressEventArgs)
        Dim car As String
        car = e.KeyChar
        If InStr("abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ" & Chr(13) & Chr(8), car) = 0 Then
            Beep()
            e.Handled = True
        End If
        ' ASCII 13=Enter y 8=TeclaRetroceso Backspace
    End Sub


    Public Function ComprobarDiaDelMes(ByVal dia As String, ByVal mes As String, ByVal año As String) As Boolean
        'diasmes = System.DateTime.DaysInMonth(año, mes) 'devuelve el nro de días del mes y año especificado
        'MsgBox(System.DateTime.DaysInMonth(2013, 2)) -->28
        If (mes > "0" And mes < "13") Then
            Dim diasmes As Integer
            diasmes = System.DateTime.DaysInMonth(CInt(año), CInt(mes))
            If (CInt(dia) > diasmes) Then
                Return True    'si hay error
            Else
                Return False   'si no hay error
            End If
        Else
            Return True        'si hay error
        End If
    End Function

End Module
