Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Public Class Form_notificacionjusgado
    Dim vasb As Integer = 0
    Dim ta_i As New SqlDataAdapter
    Dim bs_i As New BindingSource
    Dim consulta_Sql As New Class_SQL
    Dim resultado As Boolean
    Dim campoc, valoresc As String
    Dim dt_apod4 As New DataTable


    Private Sub Form_notificacionjusgado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.CENOTI_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_CODIGO", True))
            Me.CB_Unidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_UNIJUD", True))
            Me.CB_Unidad.DataSource = consulta_Sql.Consulta_General("Vista_unijud")
            Me.CB_Unidad.DisplayMember = "CENOTI_UNIJUD"

            Me.CB_Juzgado.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_JUZGAD", True))
            Me.CB_Juzgado.DataSource = consulta_Sql.Consulta_General("Vista_juzgado_noti")
            Me.CB_Juzgado.DisplayMember = "CENOTI_JUZGAD"

            Me.CB_Juez.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_JUEZXX", True))
            Me.CB_Juez.DataSource = consulta_Sql.Consulta_General("Vista_juez_noti")
            Me.CB_Juez.DisplayMember = "CENOTI_JUEZXX"

            Me.CENOTI_INFSOLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_INFSOL", True))
            Me.CENOTI_NUMCAUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_NUMCAU", True))
            Me.CB_accion.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_ACCION", True))
            Me.CB_accion.DataSource = consulta_Sql.Consulta_General("Vista_accion_noti")
            Me.CB_accion.DisplayMember = "CENOTI_ACCION"

            Me.MCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", bs, "M", True))
            Me.PCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", bs, "P", True))
            Me.ACCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", bs, "AC", True))
            Me.ETCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", bs, "ET", True))
            bs.Sort = "CENOTI_CODIGO ASC"
            bs_v.Sort = "CODIGO ASC"
            Me.DGV_demandante.DefaultCellStyle.Font = New Font("Arial", 9)
            Me.DGV_demandante.DefaultCellStyle.ForeColor = Color.Blue
            Me.DGV_demandante.DefaultCellStyle.BackColor = Color.Beige
            Me.DGV_demandante.DefaultCellStyle.SelectionForeColor = Color.Yellow
            Me.DGV_demandante.DefaultCellStyle.SelectionBackColor = Color.Gray


            Me.DGV_demandado.DefaultCellStyle.Font = New Font("Arial", 9)
            Me.DGV_demandado.DefaultCellStyle.ForeColor = Color.Blue
            Me.DGV_demandado.DefaultCellStyle.BackColor = Color.Beige
            Me.DGV_demandado.DefaultCellStyle.SelectionForeColor = Color.Yellow
            Me.DGV_demandado.DefaultCellStyle.SelectionBackColor = Color.Gray

            Me.DGV_demandante.Columns(0).HeaderText = "CODIGO"
            Me.DGV_demandante.Columns(0).Visible = False
            Me.DGV_demandante.Columns(1).HeaderText = "CODIGO2"

            Me.DGV_demandante.Columns(1).Visible = False
            Me.DGV_demandante.Columns(2).HeaderText = "NOMBRE"
            Me.DGV_demandante.Columns(2).Width = 300

            Me.DGV_demandante.Columns(3).Visible = False
            Me.DGV_demandante.Columns(4).Visible = False




            Me.DGV_demandado.Columns(0).HeaderText = "CODIGO"
            Me.DGV_demandado.Columns(0).Visible = False
            Me.DGV_demandado.Columns(1).HeaderText = "CODIGO2"

            Me.DGV_demandado.Columns(1).Visible = False
            Me.DGV_demandado.Columns(2).HeaderText = "NOMBRE"
            Me.DGV_demandado.Columns(2).Width = 300
            Me.DGV_demandado.Columns(3).Visible = False
            Me.DGV_demandado.Columns(4).Visible = False

            
            Me.DGV_DATOS.Columns(0).Visible = False
            REM  Me.DGV_DATOS.Columns(11).Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        vasb = 1
        Me.MCheckBox.Checked = False
        Me.PCheckBox.Checked = False
        Me.ETCheckBox.Checked = False
        Me.ACCheckBox.Checked = False
    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        If vasb = 1 Then
          
            If Me.ETCheckBox.Checked = True Then

                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'ET','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If

            If Me.PCheckBox.Checked = True Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'P','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If
            If Me.MCheckBox.Checked = True Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'M' ,'PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If

            If Me.ACCheckBox.Checked = True Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'AC','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If

        End If
        If vasb = 2 Then
            dt_apod4 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CEINFO_TIPOXX='ET' and CENOTI_CODIGO=" + CENOTI_CODIGOTextBox.Text + "")

            If Me.ETCheckBox.Checked = True And dt_apod4.Rows.Count = 0 Then

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'ET','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If
            dt_apod4 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CEINFO_TIPOXX='P' and CENOTI_CODIGO=" + CENOTI_CODIGOTextBox.Text + "")


            If Me.PCheckBox.Checked = True And dt_apod4.Rows.Count = 0 Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'P','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If
            dt_apod4 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CEINFO_TIPOXX='M' and CENOTI_CODIGO=" + CENOTI_CODIGOTextBox.Text + "")

            If Me.MCheckBox.Checked = True And dt_apod4.Rows.Count = 0 Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'M','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If
            dt_apod4 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CEINFO_TIPOXX='AC' and CENOTI_CODIGO=" + CENOTI_CODIGOTextBox.Text + "")

            If Me.ACCheckBox.Checked = True And dt_apod4.Rows.Count = 0 Then
                REM    dt_apod3 = consulta_Sql.Consulta_Filtro3("CEINFO_INFORME", " where CENOTI_NOTIFICACION=" + dt_apod4.Rows(0).Item(0).ToString + "")

                campoc = "CENOTI_CODIGO,CEINFO_TIPOXX,CEINFO_ESTADO"
                valoresc = " " & CENOTI_CODIGOTextBox.Text & ",'AC','PENDIENTE' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEINFO_INFORME")
            End If
        End If
    End Sub

    Private Sub BN_EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_EDITAR.Click
        vasb = 2
    End Sub



    Private Sub CENOTI_CODIGOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENOTI_CODIGOTextBox.TextChanged
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_demandado.DataSource = consulta_Sql.Consulta_Individual("Vista_demandadonoti", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vista2 = "Vista_detallenoti"
        tabla2 = "DETALLE_NOTIFICACION"
        bs2.Filter = ""
        codigonoti = Val(CENOTI_CODIGOTextBox.Text)
        Dim formulario2 As New Form_AgregarDemandante

        formulario2.Show()

        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_demandado.DataSource = consulta_Sql.Consulta_Individual("Vista_demandadonoti", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        vista2 = "Vista_detallenoti"
        tabla2 = "DETALLE_NOTIFICACION"
        bs2.Filter = ""
        codigonoti = Val(CENOTI_CODIGOTextBox.Text)
        Dim formulario2 As New Form_AgregarDemandado

        formulario2.ShowDialog()
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_demandado.DataSource = consulta_Sql.Consulta_Individual("Vista_demandadonoti", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))

    End Sub

    Private Sub BN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_IMPRIMIR.Click
        Dim Reportecategoria As New CrystalReport_Notificacion
        Dim ver As New Form_verReportes
        Reportecategoria.SetDataSource(Me.consulta_Sql.Consulta_Filtro2("CENOTI_NOTIFICACION", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text)))
        ver.CrystalReportViewer1.ReportSource = Reportecategoria
        ver.ShowDialog()
    End Sub
    Private Sub CB_Unidad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_Unidad.SelectedValueChanged
        'Me.CB_Unidad.DataSource = consulta_Sql.Consulta_General("Vista_unijud")
        ''Me.CB_Unidad.ValueMember = "CENOTI_CODIGO"
        'Me.CB_Unidad.DisplayMember = "CENOTI_UNIJUD"

    End Sub
End Class
