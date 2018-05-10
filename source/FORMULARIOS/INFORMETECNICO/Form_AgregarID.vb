Public Class Form_AgregarID
    Dim consulta_Sql As New Class_SQL
    Dim campof, campo2 As String
    Sub ETIQUETAS()
        Me.DGV_DATOS.Columns(0).HeaderText = "NOMBRE"
        'Me.DGV_DATOS.Columns(0).Visible = False
        Me.DGV_DATOS.Columns(1).HeaderText = "NUMERO DE INFORME"
        Me.DGV_DATOS.Columns(1).Width = 150
        Me.DGV_DATOS.Columns(2).HeaderText = "CODIGO2"
        Me.DGV_DATOS.Columns(2).Visible = False
        Me.DGV_DATOS.Columns(3).Visible = False
        Me.DGV_DATOS.Columns(4).HeaderText = "OBSERVACION"
        Me.DGV_DATOS.Columns(4).Width = 230
        Me.DGV_DATOS.Columns(5).HeaderText = "ROL"
        Me.DGV_DATOS.Columns(5).Width = 150
        Me.DGV_DATOS.Columns(6).Visible = False
    End Sub
    Private Sub Form_AgregarSD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ETIQUETAS()

        bs2.Filter = "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and   CEINFO_CODIGO =" + Val(codigoinfo).ToString
        bs_v2.Filter = "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and   CEINFO_CODIGO =" + Val(codigoinfo).ToString

        Me.CEINFO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CEINFO_CODIGO", True))

        Me.CEPERS_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CEPERS_CODIGO", True))

        Me.CFDEIN_PARENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CFDEIN_PARENT", True))

        Me.CFDEIN_ACTCASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CFDEIN_ACTCAS", True))

        Me.CFDEIN_INFDIRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CFDEIN_INFDIR", True))

        Me.CFDEIN_INFCOLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CFDEIN_INFCOL", True))

        Me.CFDEIN_ROLXXXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CFDEIN_ROLXXX", True))

        Me.CEIDET_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CEIDET_CODIGO", True))
        campof = "CEPERS_TIPOXX"
        REM campo2 = "CEPERS_NOMAPE"

        Me.ComboBox1.DataSource = consulta_Sql.Consulta_Filtro2("Visata_personas", "CEPERS_TIPOXX", "INFORMANTE DIRECTO")
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "NOMBRE"
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bs2, "CEPERS_CODIGO", True))

    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        CFDEIN_ROLXXXTextBox.Text = "INFORMANTE DIRECTO"
        CEINFO_CODIGOTextBox.Text = codigoinfo

    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        bs2.Filter = "CFDEIN_ROLXXX ='INFORMANTE DIRECTO' and   CEINFO_CODIGO =" + Val(codigoinfo).ToString

    End Sub

  

    Private Sub BN_AGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_AGREGAR.Click
        Dim formulario2 As New Form_InformanteDirecto

        formulario2.ShowDialog()
        Me.ComboBox1.DataSource = consulta_Sql.Consulta_Filtro2("Visata_personas", "CEPERS_TIPOXX", "INFORMANTE DIRECTO")
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "NOMBRE"
    End Sub

    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_SALIR.Click
        Me.Close()
    End Sub
End Class
