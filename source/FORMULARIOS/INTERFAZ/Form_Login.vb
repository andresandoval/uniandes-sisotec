Imports System.Data 'Importa la clase ADO para administrar y acceder a la BDD
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_Login
    Dim cons_sql As New Class_SQL
    Dim re As Boolean
    Dim intentos As New Integer
    Public dt_usu As New DataTable
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        cons_sql.Consulta_Actualizar_Informe()
        dt_usu = cons_sql.Consulta_Usuario(Me.txt_nom.Text, Me.txt_clave.Text)
       
        If txt_nom.Text <> "" And txt_clave.Text <> "" Then
            Try
                usuariosistema = dt_usu.Rows(0).Item(1).ToString
                rangousuario = dt_usu.Rows(0).Item(3).ToString

                codigopersona = dt_usu.Rows(0).Item(7).ToString
                'Form_Menu.txt_nivel.Text = rangousuario
                'Form_Menu.txt_nombreusuario.Text = usuariosistema
                If rangousuario = "TÉCNICO" Then
                    Me.Hide()
                    Form_MenuT.Show()
                Else
                    Me.Hide()
                    Form_Menu.Show()
                End If
               

            Catch ex As Exception
                Me.txt_nom.Text = ""
                Me.txt_clave.Text = ""
                Me.txt_clave.Focus()
                MsgBox("La clave o el nombre de usuario incorrectos...")
                intentos = intentos + 1
                If intentos = 3 Then
                    MsgBox("Sobrepasó el límite de intentos (Comunícate con el administrador del sistema)")
                    REM   cons_sql.Consulta_Actualizar("", "", "", )
                    End
                End If
            End Try
           
        Else
            MsgBox("Tienes que llenar los datos porque son obligatorios")
        End If

    End Sub

    Private Sub Form_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        intentos = 0
        
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class