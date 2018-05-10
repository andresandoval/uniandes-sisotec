Public Class Form_MenuT

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim formulario As New frmCronogramaTecnico()
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        vista = "Vista_general_informe"
        tabla = "CEINFO_INFORME"
        Dim formulario As New Form_informeT
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim formulario As New Form_PersonaT
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        vista = "Vista_general_informe"
        tabla = "CEINFO_INFORME"
        Dim formulario As New Form_informeThistorial
        formulario.MdiParent = Me
        formulario.Show()
    End Sub
    Dim ctl As Control

    Private Sub SetBackGroundColorOfMDIForm()
        Dim ctl As Control

        ' Loop through controls,  
        ' looking for controls of MdiClient type. 
        For Each ctl In Me.Controls
            If TypeOf (ctl) Is MdiClient Then

                ' If the control is the correct type,
                ' change the color.
                ctl.BackColor = System.Drawing.Color.White

            End If
        Next

    End Sub

    Private Sub Form_MenuT_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Form_salir.Show()
    End Sub
    Private Sub Form_MenuT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetBackGroundColorOfMDIForm()
    End Sub
End Class