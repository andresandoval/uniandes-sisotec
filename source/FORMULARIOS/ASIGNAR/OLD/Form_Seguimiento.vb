Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_Seguimiento
    Dim g As Integer = 0
    Dim ta_vc As New SqlDataAdapter
    Dim bs_vc As New BindingSource

    Dim ta_vr As New SqlDataAdapter
    Dim bs_vr As New BindingSource


    Dim ta_vp As New SqlDataAdapter
    Dim bs_vp As New BindingSource

    Private Sub Form_CalendarioFlitro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ds.Tables.Remove("Vista_nombreTecnico")
        Catch ex As Exception

        End Try
        Try
            ds.Tables.Remove("Vista_pendientes")
        Catch ex As Exception

        End Try
        Try
            ds.Tables.Remove("Vista_asignacionReporte")




        Catch ex As Exception

        End Try

        Try

        
            ta_vp = tab("Vista_nombreTecnico")
            ta_vp.Fill(ds, "Vista_nombreTecnico")
            bs_vp.DataSource = ds.Tables("Vista_nombreTecnico")
            ComboBox1.DataSource = bs_vp.DataSource
            Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
            Me.ComboBox1.DisplayMember = "NOMBRE"


            ta_vr = tab("Vista_pendientes")
            ta_vr.Fill(ds, "Vista_pendientes")
            bs_vr.DataSource = ds.Tables("Vista_pendientes")
            bs_vr.Filter = "CODIGO=" & ComboBox1.SelectedValue
            DataGridView2.DataSource = bs_vr.DataSource

            ta_vc = tab("Vista_asignacionReporte")
            ta_vc.Fill(ds, "Vista_asignacionReporte")
            bs_vc.DataSource = ds.Tables("Vista_asignacionReporte")
            bs_vc.Filter = "CEPERS_CODIGO=" & ComboBox1.SelectedValue
            bs_vc.Sort = "S ASC"
            DataGridView1.DataSource = bs_vc.DataSource

            Me.DataGridView1.Columns(0).Width = 20

            Me.DataGridView1.Columns(1).Width = 50

            Me.DataGridView1.Columns(2).Visible = False
            Me.DataGridView1.Columns(3).Visible = False
            Me.DataGridView1.Columns(4).Visible = False
            Me.DataGridView1.Columns(5).Width = 50
            Me.DataGridView1.Columns(5).ReadOnly = True
            Me.DataGridView1.Columns(6).Width = 70
            Me.DataGridView1.Columns(6).ReadOnly = True

            Me.DataGridView1.Columns(7).Width = 50
            Me.DataGridView1.Columns(7).ReadOnly = True
            Me.DataGridView1.Columns(8).Width = 70
            Me.DataGridView1.Columns(8).ReadOnly = True


            Me.DataGridView1.Columns(9).Width = 50
            Me.DataGridView1.Columns(9).ReadOnly = True
            Me.DataGridView1.Columns(10).Width = 70
            Me.DataGridView1.Columns(10).ReadOnly = True


            Me.DataGridView1.Columns(11).Width = 50
            Me.DataGridView1.Columns(11).ReadOnly = True
            Me.DataGridView1.Columns(12).Width = 70
            Me.DataGridView1.Columns(12).ReadOnly = True


            Me.DataGridView1.Columns(13).Width = 50
            Me.DataGridView1.Columns(13).ReadOnly = True
            Me.DataGridView1.Columns(14).Width = 70
            Me.DataGridView1.Columns(14).ReadOnly = True

            Me.DataGridView1.Columns(15).Width = 50
            Me.DataGridView1.Columns(15).ReadOnly = True
            Me.DataGridView1.Columns(16).Width = 70
            Me.DataGridView1.Columns(16).ReadOnly = True


            Me.DataGridView1.Columns(17).Width = 50
            Me.DataGridView1.Columns(17).ReadOnly = True
            Me.DataGridView1.Columns(18).Width = 70
            Me.DataGridView1.Columns(18).ReadOnly = True
            CargarDgv()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            bs_vc.Filter = "CEPERS_CODIGO=" & ComboBox1.SelectedValue
            bs_vr.Filter = "CODIGO=" & ComboBox1.SelectedValue
            REM  CargarDgv()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Try
            bs_vc.Filter = "CEPERS_CODIGO=" & ComboBox1.SelectedValue
            bs_vr.Filter = "CODIGO=" & ComboBox1.SelectedValue
            REM  CargarDgv()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If (e.ColumnIndex = 5 Or e.ColumnIndex = 7 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 13 Or e.ColumnIndex = 15 Or e.ColumnIndex = 17) Then
            If DataGridView1(e.ColumnIndex, e.RowIndex).Value Is DBNull.Value Then
                If DataGridView1(e.ColumnIndex + 1, e.RowIndex).Value Is DBNull.Value Then
                Else
                    tecnicov = ComboBox1.SelectedValue
                    horav = DataGridView1(1, e.RowIndex).Value
                    fechav = DataGridView1(e.ColumnIndex + 1, e.RowIndex).Value
                    Hide()
                End If

            Else


            End If
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' If g <= 8 Then
        '     g = g + 1
        '     DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Blue
        ' End If



        ' If Me.DataGridView1.Columns(e.ColumnIndex).Name _
        '= "CAUSA: 0009-2015 -- TIPO: M-- INFORME: INFOEM MEDIO" Then
        '     If e.Value IsNot Nothing Then

        '         ' Check for the string "pink" in the cell.
        '         Dim stringValue As String = _
        '         CType(e.Value, String)
        '         stringValue = stringValue.ToLower()
        '         If ((stringValue.IndexOf("pink") > -1)) Then
        '             e.CellStyle.BackColor = Color.Pink
        '         End If

        '     End If
        ' ElseIf Me.DataGridView1.Columns(e.ColumnIndex).Name _
        '     = "Release Date" Then
        '     REM  ShortFormDateFormat(e)
        ' End If
    End Sub

    Sub CargarDgv()





        ''Cambiamos de color las filas según si están cobradas totalmente o no.

        'For Each fila As DataGridViewRow In DataGridView1.Rows
        '    Try

        '        If fila.Cells(5).Value = "" Then
        '            REM   fila.DefaultCellStyle.BackColor = Color.Green
        '        Else
        '            REM(fila.DefaultCellStyle.BackColor = Color.Red)
        '        End If
        '        REM  fila.DefaultCellStyle.BackColor = Color.Green
        '        fila.Cells(5).Style.BackColor = Color.Blue
        '    Catch ex As Exception

        '    End Try

        '    'If fila.Cells(5).Value = "" Then
        '    '    fila.DefaultCellStyle.BackColor = Color.Green
        '    'Else
        '    '    fila.DefaultCellStyle.BackColor = Color.Red
        '    'End If

        'Next
    End Sub
End Class