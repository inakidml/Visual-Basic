Module TtoCondicionales

    Sub Main()

        ''>>> IF PRUEBAS   '''''''''''''''''''

        Dim vif1 As Integer = 10, vif2 = 20, vif3 = 30, vif4 = 30

        If vif1 = vif2 Then
            MsgBox("cod:01 - se cumple la 1")
        End If


        If vif1 = vif2 Then
            MsgBox("cod:02 - se cumple la 1")
        Else
            MsgBox("cod:03 - Ninguna ")
        End If


        If vif1 = vif2 Then
            MsgBox("cod:04 - se cumple la 1")
        Else
            If vif2 = vif4 Then
                MsgBox("cod:05 - se cumple la 3")
            Else
                MsgBox("cod:06 - Ninguna ")
            End If
        End If


        ''>>> IF ElseIf   ......... 
        'Dim vif1 As Integer = 20, vif2 = 20, vif3 = 15, vif4 = 10

        If vif1 = vif2 Then
            MsgBox("cod:07 - se cumple la 1")
        ElseIf vif3 = vif4 Then
            MsgBox("cod:08 - se cumple la 2")
        ElseIf vif2 = vif4 Then
            MsgBox("cod:09 - se cumple la 3")
        ElseIf vif1 = vif4 Then
            MsgBox("cod:10 - se cumple la 4")
        Else
            MsgBox("cod:11 - Ninguna ")
        End If

        ''>>> IF ElseIf   ......... Equals
        'Dim vif1 As Integer = 20, vif2 = 20, vif3 = 15, vif4 = 10

        If vif1.Equals(vif2) Then
            MsgBox("cod:12 - se cumple la 1")
        ElseIf vif3.Equals(vif4) Then
            MsgBox("cod:13 - se cumple la 2")
        ElseIf vif2.Equals(vif4) Then
            MsgBox("cod:14 - se cumple la 3")
        ElseIf vif1.Equals(vif4) Then
            MsgBox("cod:15 - se cumple la 4")
        Else
            MsgBox("cod:16 - Ninguna ")
        End If


        '>>> IF en una sola línea   ''''''''''''''''''
        If vif1 = vif2 Then MsgBox("cod:17 - se cumple la 1") : MsgBox("cod:18 - se cumple la 2")
        ': sirve para poner dos ordenes en una misma linea


        ''>>> SELECT ... END SELECT    ''''''''''''''''''''''''''
        'Dim variable As Integer = 3        '15,30,41,12,7,3

        'Select Case variable
        '    Case 15                         ' variable =15
        '        MsgBox("cod:19 - se cumple la 1")
        '    Case 20, 30, 40                 ' variable =20 or =30 or = 40
        '        MsgBox("cod:20 - se cumple la 2")
        '    Case Is >= 40                   ' variable >=40
        '        MsgBox("cod:21 - se cumple la 3")
        '        '    Case "si"                   ' variable = "si"
        '        '         MsgBox("se cumple la 4")
        '    Case 10 To 15                    ' variable >=10 y <=15
        '        MsgBox("cod:22 - se cumple la 5")
        '    Case -2, 5 To 10                ' variable=-2 or (variable >=5 y <=10)
        '        MsgBox("cod:23 - se cumple la 6")
        '    Case Else
        '        MsgBox("cod:24 - Ninguna ")
        'End Select

    End Sub

End Module
