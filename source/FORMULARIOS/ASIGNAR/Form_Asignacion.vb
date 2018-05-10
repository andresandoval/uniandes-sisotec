Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_Asignacion
    Public g As Integer = 0
    Public ta_vc As New SqlDataAdapter
    Public bs_vc As New BindingSource


    Public ta_vp As New SqlDataAdapter
    Public bs_vp As New BindingSource

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form_Asignacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ds.Tables.Remove("Vista_asignacionReporte")
            ds.Tables.Remove("Vista_nombreTecnico")
            ds.Tables.Remove("Vista_pendientes")


        Catch ex As Exception

        End Try
        BN_NUEVO.Enabled = False
        BN_ELIMINAR.Enabled = False
        Try

        Catch ex As Exception

        End Try

        bs.Sort = "CEINFO_CODIGO ASC"
        bs_v.Sort = "CODIGO ASC"
        ta_vp = tab("Vista_nombreTecnico")
        ta_vp.Fill(ds, "Vista_nombreTecnico")
        bs_vp.DataSource = ds.Tables("Vista_nombreTecnico")
        ComboBox1.DataSource = bs_vp.DataSource
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        Me.ComboBox1.DisplayMember = "NOMBRE"


        Me.CEINFO_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_CODIGO", True))

        Me.CEPERS_CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEPERS_CODIGO", True))

        Me.CEINFO_FECINIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_FECINI", True))

        Me.CEINFO_FECFINDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEINFO_FECFIN", True))
      
          Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bs, "CEPERS_CODIGO", True))
        Try
            Me.CEHOR_HORATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs, "CEHOR_HORA", True))

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tecnicov = ComboBox1.SelectedValue
        Dim frmDlg As New frmCalendarioTecnico(1)
        frmDlg.tecnicoId = tecnicov
        Dim value As Integer = CInt(DGV_DATOS.SelectedRows(0).Cells(0).Value.ToString())

        frmDlg.informeId = value
        frmDlg.ShowDialog(Me)
        If frmDlg.success Then
            ComboBox1.SelectedValue = frmDlg.tecnicoId
            CEINFO_FECFINDateTimePicker.Text = frmDlg.endDate
            CEINFO_FECINIDateTimePicker.Text = frmDlg.initDate
        End If

        ''horav = CEHOR_HORATextBox.Text
        ''fechav = CEINFO_FECINIDateTimePicker.Text
        ''Dim forx As New Form_CalendarioFlitro
        ''forx.ShowDialog()
        ''ComboBox1.SelectedValue = tecnicov
        ''CEHOR_HORATextBox.Text = horav
        ''CEINFO_FECINIDateTimePicker.Text = fechav

    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        BN_NUEVO.Enabled = False
        BN_ELIMINAR.Enabled = False
    End Sub

    Private Sub BN_EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_EDITAR.Click
        BN_NUEVO.Enabled = False
        BN_ELIMINAR.Enabled = False
    End Sub

    Private Sub BN_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_CANCELAR.Click
        BN_NUEVO.Enabled = False
        BN_ELIMINAR.Enabled = False
    End Sub
End Class
