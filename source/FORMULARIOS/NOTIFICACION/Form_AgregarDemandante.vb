Public Class Form_AgregarDemandante
    Dim consulta_Sql As New Class_SQL
    Private Sub Form_AgregarDemandante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs2.Filter = "ESTADO='PD' AND CENOTI_CODIGO=" + codigonoti.ToString
        bs_v2.Filter = "ESTADO='PD' AND CENOTI_CODIGO=" + codigonoti.ToString
        Me.CODIGO_DETALLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CODIGO_DETALLE", True))

        Me.CEPERS_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CEPERS_CODIGO", True))

        Me.CENOTI_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "CENOTI_CODIGO", True))

        Me.ESTADOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs2, "ESTADO", True))
        ComboBox1.DataSource = consulta_Sql.Consulta_General("Vista_Sujeto")
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "NOMBRE"

        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bs2, "CEPERS_CODIGO", True))
        Me.DGV_DATOS.Columns(1).Visible = False
        Me.DGV_DATOS.Columns(2).Visible = False
        Me.DGV_DATOS.Columns(3).Visible = False
        Me.DGV_DATOS.Columns(0).Width = 280
    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        bs2.Filter = "ESTADO='PD' AND CENOTI_CODIGO=" + codigonoti.ToString
        bs_v2.Filter = "ESTADO='PD' AND CENOTI_CODIGO=" + codigonoti.ToString
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        CENOTI_CODIGOTextBox.Text = codigonoti.ToString
        ESTADOTextBox.Text = "PD"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim formulario2 As New Form_SujetoDerechos

        formulario2.ShowDialog()
       
        ComboBox1.DataSource = consulta_Sql.Consulta_General("Vista_Sujeto")
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "NOMBRE"

   
    End Sub

    Private Sub ESTADOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADOTextBox.TextChanged

    End Sub
End Class
