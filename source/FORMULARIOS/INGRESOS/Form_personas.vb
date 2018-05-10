Public Class Form_personas

    Private Sub Form_personas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DGV_DATOS.DataSource = bs.DataSource
        Me.CEPERS_NOMBRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEPERS_NOMBRE", True))
        Me.CEPERS_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEPERS_CODIGO", True))

    End Sub

    Private Sub BN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_IMPRIMIR.Click

    End Sub
End Class
