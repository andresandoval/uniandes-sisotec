Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_base2
    Dim ta_v2 As New SqlDataAdapter

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
        BN_NUEVO.Enabled = True
        BN_EDITAR.Enabled = True
        BN_SALIR.Enabled = True
        BN_ELIMINAR.Enabled = True
        BN_IMPRIMIR.Enabled = True
        GroupBox3.Enabled = True
        GroupBox1.Enabled = False
    End Sub
    Sub CambiarColorFila(ByVal dgv As DataGridView)
        Try
            With dgv
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
        End Try
    End Sub
    Sub EstiloDataGrid()
        Me.DGV_DATOS.DefaultCellStyle.Font = New Font("Arial", 9)
        Me.DGV_DATOS.DefaultCellStyle.ForeColor = Color.Black
        Me.DGV_DATOS.DefaultCellStyle.BackColor = Color.Transparent
        Me.DGV_DATOS.DefaultCellStyle.SelectionForeColor = Color.Black
        'Me.DGV_PERSONA.DefaultCellStyle.SelectionBackColor = Color.Red
    End Sub
    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_SALIR.Click
        Hide()
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        Me.ActivarBotones()
        vb = 1
        bs2.AddNew()
    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        Try
            bs2.EndEdit()
            ta2.Update(ds.Tables(tabla2))

            ds.Tables.Remove(tabla2)
            ta2.Fill(ds, tabla2)
            bs2.DataSource = ds.Tables(tabla2)



            ds.Tables.Remove(vista2)
            ta_v2 = tab(vista2)
            ta_v2.Fill(ds, vista2)
            bs_v2.DataSource = ds.Tables(vista2)
            DGV_DATOS.DataSource = bs_v2.DataSource

            If vb = 2 Then
                bs2.Position = x
                DGV_DATOS.Rows(x).Selected = True
                DGV_DATOS.CurrentCell = DGV_DATOS.Rows(x).Cells(0)
            Else
                bs2.MoveLast()
                bs_v2.MoveLast()
                DGV_DATOS.Rows(bs_v2.Position).Selected = True
                DGV_DATOS.CurrentCell = DGV_DATOS.Rows(bs_v2.Position).Cells(0)
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
        bs2.CancelEdit()
    End Sub

    Private Sub Form_base_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EstiloDataGrid()
        CambiarColorFila(DGV_DATOS)
        bs_v2.Filter = ""
        bs_v.Filter = ""
        bs2.Sort = ""
        bs_v2.Sort = ""
        Try
            ds.Tables.Remove(vista2)
            ds.Tables.Remove(tabla2)
        Catch ex As Exception

        End Try

        ta_v2 = tab2(vista2)
        ta_v2.Fill(ds, vista2)

        ta2 = tab2(tabla2)

        ta2.Fill(ds, tabla2)
        ta2 = tab_SqlCommandBuilder2(ta2)
        ta2 = tab_SqlTransaction2(ta2)

        bs2.DataSource = ds.Tables(tabla2)

        bs_v2.DataSource = ds.Tables(vista2)

        DGV_DATOS.DataSource = bs_v2.DataSource

    End Sub

    Private Sub DGV_DATOS_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_DATOS.CellClick
        Try
            bs2.Position = e.RowIndex
            x = e.RowIndex
        Catch ex As Exception

        End Try

        Try
            REM   bs2.Filter = "CENOTI_CODIGO =" + DGV_DATOS(0, bs_v2.Position).Value.ToString + ""
        Catch ex As Exception

        End Try

    End Sub


    Private Sub BN_ELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_ELIMINAR.Click
        If MessageBox.Show("Seguro que desea eliminar", "Eliminar", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            Try

                bs2.RemoveAt(bs2.Position)
                ta2.Update(ds.Tables(tabla2))






                ds.Tables.Remove(vista2)
                ta_v2 = tab(vista2)
                ta_v2.Fill(ds, vista2)
                bs_v2.DataSource = ds.Tables(vista2)
                DGV_DATOS.DataSource = bs_v2.DataSource
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