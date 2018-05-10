Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_usuarios

    Private Sub Form_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ta_p As New SqlDataAdapter
        Dim bs_p As New BindingSource
        ta_p = tab("CEPERS_PERSONA")
        ta_p.Fill(ds, "CEPERS_PERSONA")
        bs_p.DataSource = ds.Tables("CEPERS_PERSONA")
        bs_p.Filter = "CEPERS_TIPOXX='TÉCNICO'"





        ComboBox1.DataSource = bs_p.DataSource
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "CEPERS_NOMBRE"

        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bs, "CEPERS_CODIGO", True))

        bs.Filter = "CEUSUA_CODIGO<>1"

        Me.CEUSUA_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEUSUA_CODIGO", True))
        Me.CEUSUA_NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEUSUA_NOMBRE", True))
        Me.CEPERS_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEPERS_CODIGO", True))

    End Sub



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
