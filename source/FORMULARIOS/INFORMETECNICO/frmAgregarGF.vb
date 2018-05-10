Public Class frmAgregarGF


    Private strConn As String = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"
    Private infCode As Integer
    Private Notif As Integer
    Public Sub New(ByVal inf As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.infCode = inf

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub onLoadMe() Handles MyBase.Load
        Try
            Dim ta As New personasDSTableAdapters.CEPERS_PERSONATableAdapter()
            ta.Connection.ConnectionString = Me.strConn
            primaryGridView.DataSource = ta.recuperarPersonas
            Me.Notif = CInt(ta.getNotificacionCodigo(Me.infCode))
            Me.primaryGridView.Select()
        Catch ex As Exception
            MsgBox("Ocurrio un error")
            Me.Close()
        End Try
    End Sub

    Public Sub ok() Handles btnOk.Click
        Cursor.Current = Cursors.WaitCursor
        Try
            If (Me.primaryGridView.SelectedRows.Count <= 0) Then
                MsgBox("Debes elegir una persona")
                Return
            End If
            If (Trim(Me.txtRelPar.Text).Length <= 0) Then
                MsgBox("Debes establecer una relacion de parentezco")
                Return
            End If
            Dim persId = Me.primaryGridView.SelectedRows.Item(0).Cells.Item(0).Value
            Dim rel = Me.txtRelPar.Text.Trim()
            Dim ta As New personasDSTableAdapters.CEPERS_PERSONATableAdapter()
            ta.Connection.ConnectionString = Me.strConn
            ta.insertarRelacionDeParentezco(persId, Me.Notif, rel)
            Me.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error")
            Me.Close()
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub primaryGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles primaryGridView.CellClick
        Try
            Me.txtPersonaName.Text = Me.primaryGridView.SelectedRows.Item(0).Cells.Item(1).Value & " " & Me.primaryGridView.SelectedRows.Item(0).Cells.Item(2).Value
        Catch ex As Exception

        End Try
    End Sub
End Class