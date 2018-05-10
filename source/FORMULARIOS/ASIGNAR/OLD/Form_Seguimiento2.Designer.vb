<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Seguimiento2
    Inherits System.Windows.Forms.Form


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.primarySchedulerControl = New DevExpress.XtraScheduler.SchedulerControl
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.primaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.DataGridView2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1047, 472)
        Me.SplitContainerControl1.SplitterPosition = 117
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Seguimiento del técnico"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(425, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(607, 95)
        Me.DataGridView2.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(335, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TÉCNICO :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.SplitContainerControl2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 350)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calendario Anual"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(3, 16)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.primarySchedulerControl)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.DateNavigator1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1041, 331)
        Me.SplitContainerControl2.SplitterPosition = 766
        Me.SplitContainerControl2.TabIndex = 1
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'primarySchedulerControl
        '
        Me.primarySchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primarySchedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.primarySchedulerControl.Name = "primarySchedulerControl"
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.NonRecurring
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.primarySchedulerControl.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.primarySchedulerControl.Size = New System.Drawing.Size(766, 331)
        Me.primarySchedulerControl.Start = New Date(2015, 5, 30, 0, 0, 0, 0)
        Me.primarySchedulerControl.Storage = Me.SchedulerStorage1
        Me.primarySchedulerControl.TabIndex = 0
        Me.primarySchedulerControl.Text = "SchedulerControl1"
        TimeRuler1.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.SouthAmericaWestern
        TimeRuler1.UseClientTimeZone = False
        Me.primarySchedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.primarySchedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("00:15:00")
        Me.primarySchedulerControl.Views.DayView.VisibleTime.End = System.TimeSpan.Parse("18:00:00")
        Me.primarySchedulerControl.Views.DayView.VisibleTime.Start = System.TimeSpan.Parse("08:00:00")
        Me.primarySchedulerControl.Views.DayView.WorkTime.Start = System.TimeSpan.Parse("08:00:00")
        TimeRuler2.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.SouthAmericaWestern
        TimeRuler2.UseClientTimeZone = False
        Me.primarySchedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.DataSource = Me.primaryBindingSource
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
        '
        'primaryBindingSource
        '
        Me.primaryBindingSource.DataSource = GetType(SISOTEC.Entities.AppointmentsEntity)
        '
        'DateNavigator1
        '
        Me.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateNavigator1.HotDate = Nothing
        Me.DateNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.SchedulerControl = Me.primarySchedulerControl
        Me.DateNavigator1.Size = New System.Drawing.Size(270, 331)
        Me.DateNavigator1.TabIndex = 0
        '
        'Form_Seguimiento2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1047, 472)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Seguimiento2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario Flitro"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents primarySchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents primaryBindingSource As System.Windows.Forms.BindingSource
End Class
