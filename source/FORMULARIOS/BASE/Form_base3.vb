Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_base3
    Dim ta_v As New SqlDataAdapter

    Dim x As Integer = 0
    Dim vb As Integer = 0



    Sub ActivarBotones()
        Me.BN_CANCELAR.Enabled = True
        Me.BN_GUARDAR.Enabled = True
        BN_NUEVO.Enabled = False
        BN_EDITAR.Enabled = False
        BN_SALIR.Enabled = False
        BN_ELIMINAR.Enabled = False
        BN_IMPRIMIR.Enabled = False
        GroupBox1.Enabled = True
        GroupBox3.Enabled = False
    End Sub
    Sub DesactivarBotones()
        Me.BN_CANCELAR.Enabled = False
        Me.BN_GUARDAR.Enabled = False
        BN_NUEVO.Enabled = False
        BN_EDITAR.Enabled = True
        BN_SALIR.Enabled = True
        BN_ELIMINAR.Enabled = False
        BN_IMPRIMIR.Enabled = True
        GroupBox3.Enabled = True
        GroupBox1.Enabled = False
    End Sub
    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_SALIR.Click
        Hide()
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        Me.ActivarBotones()
        vb = 1
        bs.AddNew()
    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        Try
            bs.EndEdit()
            ta.Update(ds.Tables(tabla))

            ds.Tables.Remove(tabla)
            ta.Fill(ds, tabla)
            bs.DataSource = ds.Tables(tabla)



            ds.Tables.Remove(vista)
            ta_v = tab(vista)
            ta_v.Fill(ds, vista)
            bs_v.DataSource = ds.Tables(vista)
            DGV_DATOS.DataSource = bs_v.DataSource

            If vb = 2 Then
                bs.Position = x
                DGV_DATOS.Rows(x).Selected = True
                DGV_DATOS.CurrentCell = DGV_DATOS.Rows(x).Cells(0)
            Else
                bs.MoveLast()
                bs_v.MoveLast()
                DGV_DATOS.Rows(bs_v.Position).Selected = True
                DGV_DATOS.CurrentCell = DGV_DATOS.Rows(bs_v.Position).Cells(0)
            End If

        Catch ex As Exception

        End Try
        Me.DesactivarBotones()
    End Sub

    Private Sub BN_EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_EDITAR.Click
        Me.ActivarBotones()
        vb = 2
    End Sub

    Private Sub BN_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_CANCELAR.Click
        Me.DesactivarBotones()
        bs.CancelEdit()
    End Sub

    Private Sub Form_base_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bs.Sort = ""
        bs_v.Sort = ""
        Try
            ds.Tables.Remove(vista)
            ds.Tables.Remove(tabla)
        Catch ex As Exception

        End Try

        ta_v = tab(vista)
        ta_v.Fill(ds, vista)

        ta = tab(tabla)

        ta.Fill(ds, tabla)
        ta = tab_SqlCommandBuilder(ta)
        ta = tab_SqlTransaction(ta)

        bs.DataSource = ds.Tables(tabla)

        bs_v.DataSource = ds.Tables(vista)

        DGV_DATOS.DataSource = bs_v.DataSource
        'Me.DGV_DATOS.Columns(0).Visible = False
        'Me.DGV_DATOS.Columns(11).Visible = False
    End Sub

    Public Overridable Sub updateChangeRow()

    End Sub

    Private Sub DGV_DATOS_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_DATOS.CellClick
        Try
            bs.Position = e.RowIndex
            x = e.RowIndex
        Catch ex As Exception

        End Try

        Try
            REM   bs.Filter = "CENOTI_CODIGO =" + DGV_DATOS(0, bs_v.Position).Value.ToString + ""
        Catch ex As Exception

        End Try
        Me.updateChangeRow()

    End Sub


    Private Sub BN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_ELIMINAR.Click
        If MessageBox.Show("Seguro que desea eliminar", "Eliminar", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Try

                bs.RemoveAt(bs.Position)
                ta.Update(ds.Tables(tabla))






                ds.Tables.Remove(vista)
                ta_v = tab(vista)
                ta_v.Fill(ds, vista)
                bs_v.DataSource = ds.Tables(vista)
                DGV_DATOS.DataSource = bs_v.DataSource
                DGV_DATOS.Rows(x - 1).Selected = True
                DGV_DATOS.CurrentCell = DGV_DATOS.Rows(x - 1).Cells(0)
            Catch ex As Exception

            End Try




        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DGV_DATOS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_DATOS.CellContentClick

    End Sub
End Class