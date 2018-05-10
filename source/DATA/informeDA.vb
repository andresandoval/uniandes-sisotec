Imports SISOTEC.Entities
Namespace DataAccess

    Public Class informeDA
        Private strConnexion As String

        Public Sub New(ByVal strConn As String)
            Me.strConnexion = strConn
        End Sub

        Public Function getInformesByTecnicoId(ByVal id As Integer) As List(Of informeEntity)
            Dim ta As New AppointmentsDSTableAdapters.CEINFO_INFORMETableAdapter
            ta.Connection.ConnectionString = Me.strConnexion
            Return Me.cast(ta.getInformeByTecnicoId(id))
        End Function

        Private Function cast(ByVal dataTable As DataTable) As List(Of informeEntity)
            If (dataTable.Equals(Nothing) OrElse dataTable.Rows().Count <= 0) Then
                Return Nothing
            End If
            Dim ents As New List(Of informeEntity)
            For Each row As DataRow In dataTable.Rows()
                ents.Add(Me.cast(row))
            Next
            Return ents
        End Function

        Private Function cast(ByVal row As DataRow) As informeEntity
            Dim ent = New informeEntity()
            ent.CEINFO_CODIGO = row("CEINFO_CODIGO").ToString()
            ent.CEINFO_FECINI = row("CEINFO_FECINI") '' & " " & row("CEINFO_TIMEINI").ToString()
            ent.CEINFO_FECFIN = row("CEINFO_FECFIN") '' & " " & row("CEINFO_TIMEFIN").ToString()
            ent.CEINFO_TIPOXX = row("CEINFO_TIPOXX").ToString()
            ent.CEPERS_CODIGO = row("CEPERS_CODIGO").ToString()
            ent.CEHOR_HORA = row("CEHOR_HORA").ToString()
            ent.CEINFO_TIMEINI = row("CEINFO_TIMEINI").ToString()
            ent.CEINFO_TIMEFIN = row("CEINFO_TIMEFIN").ToString()
            Return ent
        End Function

    End Class

End Namespace