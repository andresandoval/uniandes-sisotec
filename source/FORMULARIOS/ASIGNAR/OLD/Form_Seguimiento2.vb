Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Form_Seguimiento2

    Private Sub Form_Seguimiento2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim asss As List(Of AppointmentsEntity) = Me.primaryBindingSource.List
    End Sub

    Private Sub primarySchedulerControl_InplaceEditorShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.InplaceEditorEventArgs) Handles primarySchedulerControl.InplaceEditorShowing

    End Sub

    Private Sub primarySchedulerControl_InitNewAppointment(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentEventArgs) Handles primarySchedulerControl.InitNewAppointment
        With e.Appointment
            If .Start.Year < Now.Year Then
                MsgBox("No se puede crear eventos en fechas pasadas")
                Return
            ElseIf .Start.Year = Now.Year Then
                If (.Start.Month < Now.Month) Then
                    MsgBox("No se puede crear eventos en fechas pasadas")
                    Return
                ElseIf .Start.Month = Now.Month Then
                    If (.Start.Day < Now.Day) Then
                        MsgBox("No se puede crear eventos en fechas pasadas")
                        Return
                    End If
                End If
            End If
        End With
    End Sub
End Class