Imports SISOTEC.Entities
Namespace DataAccess

    Public Class pendientesDA
        Private strConnexion As String

        Public Sub New(ByVal strConn As String)
            Me.strConnexion = strConn
        End Sub

        Public Function getPendientesByTecnico(ByVal codigo As Integer) As List(Of pendientesEntity)
            Dim ta As New AppointmentsDSTableAdapters.Vista_pendientesTableAdapter
            ta.Connection.ConnectionString = Me.strConnexion
            Return Me.cast(ta.getPendientesByTecnico(codigo))
        End Function

        Private Function cast(ByVal dataTable As DataTable) As List(Of pendientesEntity)
            If (dataTable.Equals(Nothing) OrElse dataTable.Rows().Count <= 0) Then
                Return Nothing
            End If
            Dim ents As New List(Of pendientesEntity)
            For Each row As DataRow In dataTable.Rows()
                ents.Add(Me.cast(row))
            Next
            Return ents
        End Function

        Private Function cast(ByVal row As DataRow) As pendientesEntity
            Dim ent = New pendientesEntity()
            ent.NOMBRE = row("NOMBRE").ToString()
            ent.ESTADO = row("ESTADO").ToString()
            ent.CANTIDAD = Double.Parse(row("CANTIDAD").ToString())
            Return ent
        End Function

    End Class

End Namespace