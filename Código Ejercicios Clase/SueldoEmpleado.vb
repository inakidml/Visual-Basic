Module Module1

    Sub Main()
        'Constantes
        Const precioHoraNormal As Single = 10
        Const precioHoraExtra As Single = 15

        'Datos de entrada
        Console.WriteLine("Teclea el número de horas que ha trabajado")
        Dim horasTrabajadas As Byte = Byte.Parse(Console.ReadLine())

        Console.WriteLine("Teclea el estado civil del trabajador")
        Dim estadoCivil As Char = Char.ToUpper(CChar(Console.ReadLine()))

        'Validación estado Civil
        'If (estadoCivil.CompareTo("S"c) = 0 or estadoCivil.CompareTo("C"c) = 0 or _
        '    estadoCivil.CompareTo("D"c) = 0 or estadoCivil.CompareTo("V"c) = 0) Then
        If (estadoCivil = "S" Or estadoCivil = "C" Or
            estadoCivil = "D" Or estadoCivil = "V") Then

            Console.WriteLine("Teclea el nivel de estudios del trabajador")
            Dim nivelEstudios As Char = Char.ToUpper(CChar(Console.ReadLine()))

            'Validación nivel Estudios
            'If (nivelEstudios.CompareTo("P") <> 0 And nivelEstudios.CompareTo("M") <> 0 And _
            'nivelEstudios.CompareTo("S") <> 0) Then
            If (nivelEstudios <> "P" And nivelEstudios <> "M" And nivelEstudios <> "S") Then
                Console.WriteLine("El nivel de estudios tecleado no es correcto")
            Else
                'Operaciones para calcular la nómina
                Dim sueldo As Single

                If (horasTrabajadas > 40) Then ' 40 podría ser otra constante
                    sueldo = (horasTrabajadas - 40) * precioHoraExtra + 40 * precioHoraNormal
                Else
                    sueldo = horasTrabajadas * precioHoraNormal
                End If

                Const plus As Single = 100.0F
                'Dim estadoEstudios As String = estadoCivil & nivelEstudios
                'If (estadoEstudios = "SP" Or estadoEstudios = "VS" Or estadoEstudios = "SM" Or estadoEstudios = "CS" Or estadoEstudios = "VP" Or estadoEstudios = "SS" Or estadoEstudios = "DS") Then
                '   sueldo += plus
                'End If

                ''Primera solución
                'If (nivelEstudios = "S" Or estadoCivil = "S" Or (nivelEstudios = "P" And estadoCivil = "V")) Then
                '    sueldo += plus
                'End If

                ''Segunda solución
                'If (nivelEstudios.CompareTo("S") = 0) Then
                '    sueldo = sueldo + plus
                'Else
                '    If (estadoCivil.CompareTo("S") = 0) Then
                '        sueldo += plus
                '    Else
                '        If estadoCivil.CompareTo("V") = 0 And nivelEstudios.CompareTo("P") = 0 Then
                '            sueldo += plus
                '        End If
                '    End If
                'End If

                ''Tercera solución
                Dim combo As String = estadoCivil & nivelEstudios
                Select Case combo
                        Case "SP", "VS", "SM", "CS", "VP", "SS", "DS"
                        sueldo += plus
                End Select

                    'Salida
                    Console.WriteLine("El sueldo de este trabajador asciende a " & sueldo)
                End If
                Else
            Console.WriteLine("El estado civil tecleado no es correcto")
        End If


        Console.ReadLine()

    End Sub

End Module
