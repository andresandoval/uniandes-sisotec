Imports System.Drawing.Drawing2D
Public Class Form_Menu
    Dim consulta_Sql As New Class_SQL
    Dim mdiChildForm As New Form
    Private Sub Form_Menu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Form_salir.Show()
    End Sub

 
    'Y en el load del formulario
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
    Private Sub Form_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Set the IsMdiContainer property to true.
        IsMdiContainer = True

        ' Set the child form's MdiParent property to 
        ' the current form.
        mdiChildForm.MdiParent = Me

        'Call the method that changes the background color.
        SetBackGroundColorOfMDIForm()

        bs_bdd()

        If rangousuario = "TÉCNICO" Then
            'TSM2.Visible = False
            'TSM22.Visible = False

            'TSM4.Visible = False
            'TSM44.Visible = False
            'TSM5.Visible = False
            'TSM55.Visible = False
            'TSM6.Visible = False
            'TSM66.Visible = False



        End If
        'Me.BackgroundImage = My.Resources.FONDOMENU
    End Sub

    Private Sub USUARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_AdminUser.ShowDialog()
    End Sub

    Private Sub TecnicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form_PersonaT.MdiParent = Me

        Form_PersonaT.Show()
    End Sub

    Private Sub RibbonTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTabItem1.Click

    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem3.Click

        vista = "Vista_InformeEstado"
        tabla = "CEINFO_INFORME"

        Dim formulario As New Form_Asignacion

        formulario.MdiParent = Me

        formulario.Show()


    End Sub

    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        vista = "Vista_general_informe"
        tabla = "CEINFO_INFORME"

        Dim formulario As New Form_informe

        formulario.MdiParent = Me

        formulario.Show()
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        vista = "Vista_notificaciones"
        tabla = "CENOTI_NOTIFICACION"
        bs.Filter = ""

        Dim formulario As New Form_notificacionjusgado
        formulario.MdiParent = Me
        formulario.Show()
    End Sub



    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        'vista = "Vista_notificaciones"
        'tabla = "CENOTI_NOTIFICACION"
        'bs.Filter = ""
        Dim formulario As New frmCalendarioTecnico(2)
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Dim Reportecategoria As New CR_Seguimiento
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_pendientes"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        Dim Reportecategoria As New CRE_Seguimiento
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_pendientes"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem13.Click
        vista = "Vista_notificaciones"
        tabla = "CENOTI_NOTIFICACION"
        bs.Filter = ""
        Dim formulario As New Form_PersonaT
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem14.Click
        vista = "Vista_Usuarios"
        tabla = "CEUSUA_USUARIO"
        bs.Filter = ""
        Dim formulario As New Form_usuarios
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        Dim Reportecategoria As New CR_SAT
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vsita_asignacion"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem15.Click
        Dim Reportecategoria As New CrystalReport_Notificacion
        Dim ver As New Form_verReportes
        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("CENOTI_NOTIFICACION"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        Dim Reportecategoria As New CR_CRM_JUZGADO
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_CRMJUSGADO"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub RibbonTabItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTabItem3.Click

    End Sub

    Private Sub ButtonItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem18.Click
        vista = "Vista_Usuarios"
        tabla = "CEUSUA_USUARIO"
        bs.Filter = ""
        Dim formulario As New Form_SujetoDerechos
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem19.Click
        vista = "Vista_Usuarios"
        tabla = "CEUSUA_USUARIO"
        bs.Filter = ""
        Dim formulario As New Form_InformanteDirecto
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem20.Click
        vista = "Vista_Usuarios"
        tabla = "CEUSUA_USUARIO"
        bs.Filter = ""
        Dim formulario As New Form_InformantesColaterales
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem21.Click
        Dim Reportecategoria As New CR_CRMEJUEZ
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_CRMJUEZ"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem22.Click
        Dim Reportecategoria As New CR_CRMACCION
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_CRMACCION"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem23.Click
        vista = "Vista_Usuarios"
        tabla = "CEUSUA_USUARIO"
        bs.Filter = ""
        Dim formulario As New Form_Demandado
        formulario.MdiParent = Me
        formulario.Show()
    End Sub

    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        Dim Reportecategoria As New CR_CRM_ATECNICOMES
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_atecnicomes"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem25.Click
        Dim Reportecategoria As New CR_CRM_ATECNICOANIO
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_atecnicoanio"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem26.Click
        Dim Reportecategoria As New CR_CRM_AINFORMEMES
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_ainformemes"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub

    Private Sub ButtonItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem27.Click
        Dim Reportecategoria As New CR_CRM_AINFORMEANIO
        Dim ver As New Form_verReportes

        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_General("Vista_ainformeanio"))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub
End Class