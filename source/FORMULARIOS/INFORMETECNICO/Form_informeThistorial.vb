Public Class Form_informeThistorial
    Dim consulta_Sql As New Class_SQL
    Private strConn As String = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form_informe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd3, "CFDEIN_PARENT", True))

        'Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd3, "CFDEIN_INFCOL", True))

        'Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd2, "CFDEIN_PARENT", True))

        'Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd2, "CFDEIN_INFDIR", True))

        'Me.CFDEIN_PARENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd, "CFDEIN_PARENT", True))

        'Me.CFDEIN_ACTCASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsd, "CFDEIN_ACTCAS", True))

        bs.Filter = "CEPERS_CODIGO=" & codigopersona.ToString

        Me.txt_diso.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_DISOPR", True))

        Me.txt_acre.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_ACCREA", True))

        Me.txt_enre.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_ENTREA", True))

        Me.txt_sivi.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_SITVIV", True))

        Me.txt_meap.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_METAPL", True))

        Me.txt_core.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_CONREC", True))

        Me.CEINFO_PRIOCUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_PRIOCU", True))

        Me.CEINFO_TIECURTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_TIECUR", True))

        Me.CEINFO_NEASMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_NEASME", True))

        Me.CEINFO_ESTSALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_ESTSAL", True))

        Me.CEINFO_CICATRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_CICATR", True))

        Me.CEINFO_TASFUNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_TASFUN", True))

        Me.cbb_tipoin.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_ESTADO", True))

        Me.dtm_fecfin.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "CEINFO_FECFIN", True))

        Me.dtm_fecini.DataBindings.Add(New System.Windows.Forms.Binding("Value", bs, "CEINFO_FECINI", True))

        Me.CEINFO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_CODIGO", True))
        Me.CENOTI_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CENOTI_CODIGO", True))

        REM Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bs, "CEPERS_CODIGO", True))
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))

        Me.DGV_demandante.Columns(0).HeaderText = "CODIGO"
        Me.DGV_demandante.Columns(0).Visible = False
        Me.DGV_demandante.Columns(1).HeaderText = "CODIGO2"

        Me.DGV_demandante.Columns(1).Visible = False
        Me.DGV_demandante.Columns(2).HeaderText = "NOMBRE"
        Me.DGV_demandante.Columns(2).Width = 800

        Me.DGV_demandante.Columns(3).Visible = False
        Me.DGV_demandante.Columns(4).Visible = False
        Me.DGV_InformanteDirecto.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))
        Me.DGV_InformanteColateral.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE COLATERAL' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))



       



        Me.DGV_InformanteDirecto.Columns(0).Width = 800

        Me.DGV_InformanteDirecto.Columns(1).Visible = False
        Me.DGV_InformanteDirecto.Columns(2).Visible = False
        Me.DGV_InformanteDirecto.Columns(3).Visible = False
        Me.DGV_InformanteDirecto.Columns(4).Visible = False
        Me.DGV_InformanteDirecto.Columns(5).Visible = False
        Me.DGV_InformanteDirecto.Columns(6).Visible = False



        Me.DGV_InformanteColateral.Columns(0).Width = 800

        Me.DGV_InformanteColateral.Columns(1).Visible = False
        Me.DGV_InformanteColateral.Columns(2).Visible = False
        Me.DGV_InformanteColateral.Columns(3).Visible = False
        Me.DGV_InformanteColateral.Columns(4).Visible = False
        Me.DGV_InformanteColateral.Columns(5).Visible = False
        Me.DGV_InformanteColateral.Columns(6).Visible = False

        Me.DGV_InformanteColateral.Columns(0).Visible = False
        bs_v.Filter = "CEPERS_CODIGO=" + codigopersona.ToString
        Me.updateChangeRow()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        vista2 = "Vista_detalleInformes"
        tabla2 = "DETALLE_INFORME"
        bs2.Filter = ""
        codigoinfo = Val(CEINFO_CODIGOTextBox.Text)
        Dim formulario2 As New Form_AgregarSD

        formulario2.ShowDialog()
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_InformanteDirecto.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))
        Me.DGV_InformanteColateral.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE COLATERAL' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        vista2 = "Vista_detalleInformes"
        tabla2 = "DETALLE_INFORME"
        bs2.Filter = ""
        codigoinfo = Val(CEINFO_CODIGOTextBox.Text)
        Dim formulario2 As New Form_AgregarID
        formulario2.ShowDialog()
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_InformanteDirecto.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))
        Me.DGV_InformanteColateral.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE COLATERAL' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        vista2 = "Vista_detalleInformes"
        tabla2 = "DETALLE_INFORME"
        bs2.Filter = ""
        codigoinfo = Val(CEINFO_CODIGOTextBox.Text)
        Dim formulario2 As New Form_AgregarIC
        formulario2.ShowDialog()
        Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
        Me.DGV_InformanteDirecto.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))
        Me.DGV_InformanteColateral.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE COLATERAL' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))

    End Sub

    Private Sub CEINFO_CODIGOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEINFO_CODIGOTextBox.TextChanged
        Try
            Me.DGV_demandante.DataSource = consulta_Sql.Consulta_Individual("Vista_deatalleno", "CENOTI_CODIGO", Val(CENOTI_CODIGOTextBox.Text))
            Me.DGV_InformanteDirecto.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))
            Me.DGV_InformanteColateral.DataSource = consulta_Sql.Consulta_Individual("Vista_detalleInformes", "CFDEIN_ROLXXX ='INFORMANTE COLATERAL' and CEINFO_CODIGO", Val(CEINFO_CODIGOTextBox.Text))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BTN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.Click
        If (Me.DGV_DATOS.RowCount > 0 AndAlso Me.DGV_DATOS.SelectedRows.Count > 0) Then
            Dim cod = CInt(Me.DGV_DATOS.SelectedRows(0).Cells(0).Value.ToString)
            Dim frm As New frmInformeUnico(cod)
            frm.ShowDialog()
            frm.Dispose()
        End If

    End Sub

    Private Sub EditarGFamiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarGFamiliar.Click
        Dim inf As Integer = Me.DGV_DATOS.SelectedRows.Item(0).Cells.Item(0).Value
        Dim frm As New frmAgregarGF(inf)
        frm.ShowDialog(Me)
        frm.Dispose()
        Me.updateChangeRow()
    End Sub

    Public Overrides Sub updateChangeRow()
        Try
            Dim inf As Integer = Me.DGV_DATOS.SelectedRows.Item(0).Cells.Item(0).Value
            Dim ta As New personasDSTableAdapters.VISTA_GRUPO_FAMILIARTableAdapter()
            ta.Connection.ConnectionString = Me.strConn
            Me.DataGridView3.DataSource = ta.GetData(inf)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarRelacion.Click
        If MsgBox("Deseas eliminar el registro ?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Dim inf As Integer = Me.DataGridView3.SelectedRows.Item(0).Cells.Item(0).Value
            Dim ta As New personasDSTableAdapters.CEPERS_PERSONATableAdapter()
            ta.Connection.ConnectionString = Me.strConn
            ta.deleteRelacion(inf)
            Me.updateChangeRow()
        Catch ex As Exception
        End Try
    End Sub
End Class
