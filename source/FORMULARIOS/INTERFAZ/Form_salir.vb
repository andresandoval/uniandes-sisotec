Public Class Form_salir
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub



    Private Sub btn_cambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cambiar.Click
        Me.Hide()
        Form_Login.Show()
        Form_Login.txt_nom.Text = ""
        Form_Login.txt_clave.Text = ""
        Form_Login.txt_nom.Focus()
    End Sub
End Class