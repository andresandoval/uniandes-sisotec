Imports SISOTEC.Entities
Namespace DataAccess

    Public Class tecnicoDA
        Private strConnexion As String

        Public Sub New(ByVal strConn As String)
            Me.strConnexion = strConn
        End Sub

        Public Function getNombreTecnico() As List(Of tecnicoEntity)
            Dim ta As New AppointmentsDSTableAdapters.Vista_nombreTecnicoTableAdapter
            ta.Connection.ConnectionString = Me.strConnexion
            Return Me.cast(ta.getNombreTecnico)
        End Function

        Public Function getNombreTecnicoById(ByVal id As Integer) As tecnicoEntity
            Dim ta As New AppointmentsDSTableAdapters.Vista_nombreTecnicoTableAdapter
            ta.Connection.ConnectionString = Me.strConnexion
            Dim ret As List(Of tecnicoEntity) = Me.cast(ta.getNombreTecnicoById(id))
            If (ret Is Nothing Or ret.Count <> 1) Then
                Return Nothing
            End If
            Return ret(0)
        End Function

        Private Function cast(ByVal dataTable As DataTable) As List(Of tecnicoEntity)
            If (dataTable.Equals(Nothing) OrElse dataTable.Rows().Count <= 0) Then
                Return Nothing
            End If
            Dim ents As New List(Of tecnicoEntity)
            For Each row As DataRow In dataTable.Rows()
                ents.Add(Me.cast(row))
            Next
            Return ents
        End Function

        Private Function cast(ByVal row As DataRow) As tecnicoEntity
            Dim ent = New tecnicoEntity()
            ent.CARGO = row("CARGO").ToString()
            ent.NOMBRE = row("NOMBRE").ToString()
            ent.CEPERS_CODIGO = Integer.Parse(row("CEPERS_CODIGO").ToString())
            Return ent
        End Function

    End Class

End Namespace