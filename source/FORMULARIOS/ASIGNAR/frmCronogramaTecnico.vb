Imports SISOTEC.DataAccess
Imports SISOTEC.Entities
Imports DevExpress.XtraScheduler
Imports System.ComponentModel

Public Class frmCronogramaTecnico

    Private tecnicoDA As tecnicoDA
    Private informeId As Nullable(Of Integer) = Nothing

    Private strConn As String = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"

    Private Sub frmAsignacionTecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Tecnic's data
        Me.tecnicoDA = New tecnicoDA(Me.strConn)
        Me.TecnicoBindingSource.DataSource = Me.tecnicoDA.getNombreTecnicoById(codigopersona)
        'Tecnic's informs
        Me.CEINFO_INFORMETableAdapter.FillBy(Me.AppointmentDataDS.CEINFO_INFORME, codigopersona)
        'Focus on firs inform row
        If Me.informesDataGridView.Rows.Count <= 0 Then
            MsgBox("El usuario no tiene proyectos disponibles")
            Me.Close()
        End If
        Me.Text = Me.Label2.Text
    End Sub

    Private Sub primarySchedulerControl_InitNewAppointment(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentEventArgs) Handles primarySchedulerControl.InitNewAppointment
        e.Appointment.CustomFields.Item("UserId") = codigopersona
        e.Appointment.CustomFields.Item("InformeId") = Me.informeId
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentCreate(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentCreate
        Dim visibleIntervals As TimeInterval = DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl).SelectedInterval

        Dim ini As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(1).Value.ToString)
        Dim fin As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(2).Value.ToString)
        If visibleIntervals.Start < ini Then
            e.Allow = False
        ElseIf visibleIntervals.End > fin Then
            e.Allow = False
        Else
            e.Allow = True
        End If
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentDrag(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentDrag
        Dim visibleIntervals As TimeInterval = DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl).SelectedInterval

        Dim ini As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(1).Value.ToString)
        Dim fin As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(2).Value.ToString)
        If visibleIntervals.Start < ini Then
            e.Allow = False
        ElseIf visibleIntervals.End > fin Then
            e.Allow = False
        Else
            e.Allow = True
        End If
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentResize(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentResize
        Dim visibleIntervals As TimeInterval = DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl).SelectedInterval

        Dim ini As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(1).Value.ToString)
        Dim fin As DateTime = DateTime.Parse(Me.informesDataGridView.SelectedRows(0).Cells(2).Value.ToString)
        If visibleIntervals.Start < ini Then
            e.Allow = False
        ElseIf visibleIntervals.End > fin Then
            e.Allow = False
        Else
            e.Allow = True
        End If
    End Sub

    Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles primarySchedulerStorage.AppointmentsChanged, primarySchedulerStorage.AppointmentsDeleted, primarySchedulerStorage.AppointmentsInserted
        AppointmentsTableAdapter.Update(Me.AppointmentDataDS)
        Me.AppointmentDataDS.AcceptChanges()
    End Sub

    Private Sub informesDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informesDataGridView.SelectionChanged
        If Me.informeId Is Nothing OrElse Me.informeId <= 0 Then
            Me.informesDataGridView.Rows(0).Selected = True
        End If
        Dim currentRow As DataGridViewRow = Me.informesDataGridView.CurrentRow
        Me.informeId = CInt(currentRow.Cells(0).Value.ToString())
        Me.AppointmentsTableAdapter.filDataBy(Me.AppointmentDataDS.Appointments, codigopersona, Me.informeId)
        Me.ResourcesTableAdapter.Fill(Me.AppointmentDataDS.Resources)
        Me.primarySchedulerControl.LimitInterval.Start = CDate(currentRow.Cells(1).Value.ToString())
        Me.primarySchedulerControl.LimitInterval.End = CDate(currentRow.Cells(2).Value.ToString())
    End Sub

End Class