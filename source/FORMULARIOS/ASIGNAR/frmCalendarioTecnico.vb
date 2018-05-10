Imports SISOTEC.DataAccess
Imports SISOTEC.Entities
Imports DevExpress.XtraScheduler
Imports System.ComponentModel

Public Class frmCalendarioTecnico

    Public tecnicoId As Integer
    Public initDate As Nullable(Of DateTime)
    Public endDate As Nullable(Of DateTime)
    Public success As Boolean = False
    Public informeId As Integer = 0
    Public Tipo As Integer

    Public Sub New(ByVal _Tipo As Integer)
        InitializeComponent()
        Me.initDate = Nothing
        Me.endDate = Nothing
        Me.Tipo = _Tipo
    End Sub

    Private tecnicoDA As tecnicoDA
    Private pendientesDA As pendientesDA
    Private informeDA As informeDA
    Private strConn As String = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"

    Private Function existsAppointment() As Boolean
        Me.primaryBindingSource.EndEdit()
        Dim app As List(Of AppointmentsEntity) = DirectCast(Me.primaryBindingSource.List, BindingList(Of AppointmentsEntity)).ToList()
        app = (From a As AppointmentsEntity In app Where a.allowEdit).ToList()
        If (app Is Nothing OrElse app.Count <> 1) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmAsignacionTecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.tecnicoDA = New tecnicoDA(Me.strConn)
        Me.pendientesDA = New pendientesDA(Me.strConn)
        Me.informeDA = New informeDA(Me.strConn)
        Me.TecnicoEntityBindingSource.DataSource = Me.tecnicoDA.getNombreTecnico()
        If Me.Tipo = 1 Then
            ''ASIGNACION
            Me.Label2.Text = "Asignación de Técnico"
            Me.btnAceptar.Visible = True
            Me.selectedTecnicoBindingSource.DataSource = New tecnicoEntity With {.CEPERS_CODIGO = Me.tecnicoId, .NOMBRE = "SELECTED"}
        ElseIf Me.Tipo = 2 Then
            ''SEGUIMIENTO
            Me.Label2.Text = "Seguimiento de Técnico"
            Me.btnAceptar.Visible = False
            Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentCreate = UsedAppointmentType.None
            Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentDelete = UsedAppointmentType.None
            Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentDrag = UsedAppointmentType.None
            Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentResize = UsedAppointmentType.None
            Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentEdit = UsedAppointmentType.None
            Me.primarySchedulerControl.OptionsCustomization.AllowDisplayAppointmentForm = UsedAppointmentType.None
            Me.tecnicoComboBox.SelectedIndex = 0
        End If
        Me.Text = Me.Label2.Text
    End Sub

    Private Sub TecnicoEntityBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TecnicoEntityBindingSource.CurrentItemChanged
        Dim tmpTecnico As tecnicoEntity = Me.TecnicoEntityBindingSource.Current
        Me.PendientesEntityBindingSource.DataSource = Me.pendientesDA.getPendientesByTecnico(tmpTecnico.CEPERS_CODIGO)
        Dim tmpInformes As List(Of informeEntity) = Me.informeDA.getInformesByTecnicoId(tmpTecnico.CEPERS_CODIGO)
        If (tmpInformes.Equals(Nothing) OrElse tmpInformes.Count <= 0) Then
            Me.primaryBindingSource.DataSource = Nothing
            Return
        End If
         Me.primarySchedulerControl.Storage.Appointments.Clear()
        For Each inf As informeEntity In tmpInformes
            Dim tmpApt = Me.primarySchedulerControl.Storage.CreateAppointment(AppointmentType.Normal)
            tmpApt.Description = "Tipo de informe: " & inf.CEINFO_TIPOXX & vbCrLf & "Estado: " & inf.CEINFO_ESTADO
            tmpApt.LabelId = IIf(CInt(inf.CEINFO_CODIGO) = Me.informeId, 1, 2)
            tmpApt.Location = "Santo Domingo"
            tmpApt.CustomFields.Item("AllowEdit") = (CInt(inf.CEINFO_CODIGO) = Me.informeId)
            tmpApt.Subject = "Informe Nro: " & inf.CEINFO_CODIGO
            tmpApt.StatusId = 2
            tmpApt.Start = DateTime.Parse(inf.CEINFO_FECINI)
            tmpApt.End = DateTime.Parse(inf.CEINFO_FECFIN)
            Me.primarySchedulerControl.Storage.Appointments.Add(tmpApt)
        Next
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.TecnicoEntityBindingSource.EndEdit()
        Me.tecnicoId = DirectCast(Me.TecnicoEntityBindingSource.Current, tecnicoEntity).CEPERS_CODIGO
        If Not Me.existsAppointment() Then
            MsgBox("No has creado ninguna entrada")
            Return
        End If
        Me.primaryBindingSource.EndEdit()
        Dim app As List(Of AppointmentsEntity) = DirectCast(Me.primaryBindingSource.List, BindingList(Of AppointmentsEntity)).ToList()
        app = (From a As AppointmentsEntity In app Where a.allowEdit).ToList()
        Me.initDate = app(0).StartDate
        Me.endDate = app(0).EndDate
        Me.success = True
        Me.Close()
    End Sub

    Private Sub primarySchedulerControl_InitNewAppointment(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentEventArgs) Handles primarySchedulerControl.InitNewAppointment
        e.Appointment.Subject = "Informe"
        e.Appointment.Description = "Informe..."
        e.Appointment.Location = "Santo Domingo"
        e.Appointment.StatusId = 2
        e.Appointment.LabelId = 1
        e.Appointment.CustomFields.Item("AllowEdit") = True
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentCreate(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentCreate
        e.Allow = Not Me.existsAppointment()
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentDelete(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentDelete
        e.Allow = CBool(e.Appointment.CustomFields.Item("AllowEdit"))
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentEdit(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentEdit
        e.Allow = CBool(e.Appointment.CustomFields.Item("AllowEdit"))
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentDrag(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentDrag
        e.Allow = CBool(e.Appointment.CustomFields.Item("AllowEdit"))
    End Sub

    Private Sub primarySchedulerControl_AllowAppointmentResize(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentOperationEventArgs) Handles primarySchedulerControl.AllowAppointmentResize
        e.Allow = CBool(e.Appointment.CustomFields.Item("AllowEdit"))
    End Sub

End Class