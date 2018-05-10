Public Class Class_validacion
    Public Sub salto(ByVal sender As Object, ByRef caja1 As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            caja1.Focus()
            caja1.SelectAll()
        End If
    End Sub
    Public Sub salto2(ByVal sender As Object, ByRef caja1 As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            caja1.Focus()
            caja1.SelectAll()
        End If
    End Sub
    Public Sub salto3(ByVal sender As Object, ByRef caja1 As DateTimePicker, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            caja1.Focus()
        End If
    End Sub

    Public Sub solo_numeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13) Then
            If e.KeyChar < Chr(48) Or e.KeyChar > Chr(57) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub
    Public Sub solo_numeros_guion(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13) Then
            If e.KeyChar < Chr(48) Or e.KeyChar > Chr(57) Then
                If e.KeyChar <> Chr(45) Then
                    e.KeyChar = Chr(0)
                End If
            End If
        End If
    End Sub

    Public Sub solo_letras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub solo_letras_punto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(46) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Sub solo_letras(ByVal sender As Object, ByVal e As KeyEventArgs)
        Throw New NotImplementedException
    End Sub
    Public Function verifica_caja_vacias(ByVal f As Form) As Boolean
        Dim ctrl As Control
        For Each ctrl In f.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = Nothing Then
                    Return True
                End If
            End If
        Next
    End Function
    Public Function VerificarCedula(ByVal Cedula As String) As Boolean
        VerificarCedula = True
        If Len(Trim(Cedula)) <> 10 Then
            VerificarCedula = False
        End If

        If Val(Mid(Cedula, 1, 2)) > 25 Then
            VerificarCedula = False
        End If

        If Val(Mid(Cedula, 3, 1)) > 5 Then
            VerificarCedula = False
        End If

        If VerificarCedula = False Then
            '   MsgBox("Cedula incorrecta", vbInformation)
        Else
            Dim total As Integer
            Dim cifra As Integer
            total = 0

            For a = 1 To 9
                If (a Mod 2) = 0 Then
                    cifra = Val(Mid(Cedula, a, 1))
                Else
                    cifra = Val(Mid(Cedula, a, 1)) * 2
                    If cifra > 9 Then
                        cifra = cifra - 9
                    End If
                End If
                total = total + cifra
            Next

            cifra = total Mod 10


            If cifra > 0 Then
                cifra = 10 - cifra
            End If

            If cifra = Val(Mid(Cedula, 10, 1)) Then
                VerificarCedula = True
            Else
                MsgBox("Numero de cedula no pasa la validacion, verifique por favor", vbInformation)
                VerificarCedula = False
            End If
        End If
    End Function
    
End Class
