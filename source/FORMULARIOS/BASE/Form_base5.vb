Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_base5
    Dim ta_v As New SqlDataAdapter

    Dim x As Integer = 0
    Dim vb As Integer = 0



    
   
    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
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


    Private Sub BN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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