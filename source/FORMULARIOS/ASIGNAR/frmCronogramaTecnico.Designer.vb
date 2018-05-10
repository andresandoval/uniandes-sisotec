<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCronogramaTecnico
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
        Me.informesDataGridView = New System.Windows.Forms.DataGridView
        Me.CEINFOCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEINFOFECINIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEINFOFECFINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEINFOTIPOXXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEINFOESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEINFOINFORMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentDataDS = New SISOTEC.appointmentDataDS
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TecnicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.primarySchedulerControl = New DevExpress.XtraScheduler.SchedulerControl
        Me.primarySchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.primaryDateNavigator = New DevExpress.XtraScheduler.DateNavigator
        Me.AppointmentsTableAdapter = New SISOTEC.appointmentDataDSTableAdapters.AppointmentsTableAdapter
        Me.ResourcesTableAdapter = New SISOTEC.appointmentDataDSTableAdapters.ResourcesTableAdapter
        Me.CEINFO_INFORMETableAdapter = New SISOTEC.appointmentDataDSTableAdapters.CEINFO_INFORMETableAdapter
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.informesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEINFOINFORMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primarySchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primaryDateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.informesDataGridView)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1158, 498)
        Me.SplitContainerControl1.SplitterPosition = 152
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(362, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Calendario de Técnico"
        '
        'informesDataGridView
        '
        Me.informesDataGridView.AllowUserToAddRows = False
        Me.informesDataGridView.AllowUserToDeleteRows = False
        Me.informesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.informesDataGridView.AutoGenerateColumns = False
        Me.informesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.informesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.informesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CEINFOCODIGODataGridViewTextBoxColumn, Me.CEINFOFECINIDataGridViewTextBoxColumn, Me.CEINFOFECFINDataGridViewTextBoxColumn, Me.CEINFOTIPOXXDataGridViewTextBoxColumn, Me.CEINFOESTADODataGridViewTextBoxColumn})
        Me.informesDataGridView.DataSource = Me.CEINFOINFORMEBindingSource
        Me.informesDataGridView.Location = New System.Drawing.Point(221, 54)
        Me.informesDataGridView.Name = "informesDataGridView"
        Me.informesDataGridView.ReadOnly = True
        Me.informesDataGridView.Size = New System.Drawing.Size(571, 97)
        Me.informesDataGridView.TabIndex = 12
        '
        'CEINFOCODIGODataGridViewTextBoxColumn
        '
        Me.CEINFOCODIGODataGridViewTextBoxColumn.DataPropertyName = "CEINFO_CODIGO"
        Me.CEINFOCODIGODataGridViewTextBoxColumn.HeaderText = "CODIGO"
        Me.CEINFOCODIGODataGridViewTextBoxColumn.Name = "CEINFOCODIGODataGridViewTextBoxColumn"
        Me.CEINFOCODIGODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEINFOFECINIDataGridViewTextBoxColumn
        '
        Me.CEINFOFECINIDataGridViewTextBoxColumn.DataPropertyName = "CEINFO_FECINI"
        Me.CEINFOFECINIDataGridViewTextBoxColumn.HeaderText = "FECHA DE INICIO"
        Me.CEINFOFECINIDataGridViewTextBoxColumn.Name = "CEINFOFECINIDataGridViewTextBoxColumn"
        Me.CEINFOFECINIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEINFOFECFINDataGridViewTextBoxColumn
        '
        Me.CEINFOFECFINDataGridViewTextBoxColumn.DataPropertyName = "CEINFO_FECFIN"
        Me.CEINFOFECFINDataGridViewTextBoxColumn.HeaderText = "FECHA FINAL"
        Me.CEINFOFECFINDataGridViewTextBoxColumn.Name = "CEINFOFECFINDataGridViewTextBoxColumn"
        Me.CEINFOFECFINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEINFOTIPOXXDataGridViewTextBoxColumn
        '
        Me.CEINFOTIPOXXDataGridViewTextBoxColumn.DataPropertyName = "CEINFO_TIPOXX"
        Me.CEINFOTIPOXXDataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.CEINFOTIPOXXDataGridViewTextBoxColumn.Name = "CEINFOTIPOXXDataGridViewTextBoxColumn"
        Me.CEINFOTIPOXXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEINFOESTADODataGridViewTextBoxColumn
        '
        Me.CEINFOESTADODataGridViewTextBoxColumn.DataPropertyName = "CEINFO_ESTADO"
        Me.CEINFOESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.CEINFOESTADODataGridViewTextBoxColumn.Name = "CEINFOESTADODataGridViewTextBoxColumn"
        Me.CEINFOESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEINFOINFORMEBindingSource
        '
        Me.CEINFOINFORMEBindingSource.DataMember = "CEINFO_INFORME"
        Me.CEINFOINFORMEBindingSource.DataSource = Me.AppointmentDataDS
        '
        'AppointmentDataDS
        '
        Me.AppointmentDataDS.DataSetName = "appointmentDataDS"
        Me.AppointmentDataDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.DataSource = Me.TecnicoBindingSource
        Me.ComboBox1.DisplayMember = "NOMBRE"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(434, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(474, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "CEPERS_CODIGO"
        '
        'TecnicoBindingSource
        '
        Me.TecnicoBindingSource.DataSource = GetType(SISOTEC.Entities.tecnicoEntity)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.SplitContainerControl2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1158, 341)
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
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.primaryDateNavigator)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1152, 322)
        Me.SplitContainerControl2.SplitterPosition = 766
        Me.SplitContainerControl2.TabIndex = 1
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'primarySchedulerControl
        '
        Me.primarySchedulerControl.Appearance.NavigationButtonDisabled.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.primarySchedulerControl.Appearance.NavigationButtonDisabled.Options.UseFont = True
        Me.primarySchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primarySchedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.primarySchedulerControl.LookAndFeel.UseDefaultLookAndFeel = False
        Me.primarySchedulerControl.Name = "primarySchedulerControl"
        Me.primarySchedulerControl.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.primarySchedulerControl.Size = New System.Drawing.Size(766, 322)
        Me.primarySchedulerControl.Start = New Date(2015, 5, 30, 0, 0, 0, 0)
        Me.primarySchedulerControl.Storage = Me.primarySchedulerStorage
        Me.primarySchedulerControl.TabIndex = 0
        Me.primarySchedulerControl.Text = "SchedulerControl1"
        TimeRuler1.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.SouthAmericaWestern
        TimeRuler1.UseClientTimeZone = False
        Me.primarySchedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.primarySchedulerControl.Views.DayView.TimeScale = System.TimeSpan.Parse("00:15:00")
        TimeRuler2.TimeZone.Id = DevExpress.XtraScheduler.TimeZoneId.SouthAmericaWestern
        TimeRuler2.UseClientTimeZone = False
        Me.primarySchedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'primarySchedulerStorage
        '
        Me.primarySchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("UserId", "UserId"))
        Me.primarySchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("InformeId", "InformeId"))
        Me.primarySchedulerStorage.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.primarySchedulerStorage.Appointments.Mappings.AllDay = "AllDay"
        Me.primarySchedulerStorage.Appointments.Mappings.Description = "Description"
        Me.primarySchedulerStorage.Appointments.Mappings.End = "EndDate"
        Me.primarySchedulerStorage.Appointments.Mappings.Label = "Label"
        Me.primarySchedulerStorage.Appointments.Mappings.Location = "Location"
        Me.primarySchedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.primarySchedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.primarySchedulerStorage.Appointments.Mappings.ResourceId = "ResourceID"
        Me.primarySchedulerStorage.Appointments.Mappings.Start = "StartDate"
        Me.primarySchedulerStorage.Appointments.Mappings.Status = "Status"
        Me.primarySchedulerStorage.Appointments.Mappings.Subject = "Subject"
        Me.primarySchedulerStorage.Appointments.Mappings.Type = "Type"
        Me.primarySchedulerStorage.Resources.DataSource = Me.ResourcesBindingSource
        Me.primarySchedulerStorage.Resources.Mappings.Caption = "ResourceName"
        Me.primarySchedulerStorage.Resources.Mappings.Color = "Color"
        Me.primarySchedulerStorage.Resources.Mappings.Id = "ResourceID"
        Me.primarySchedulerStorage.Resources.Mappings.Image = "Image"
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.AppointmentDataDS
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.AppointmentDataDS
        '
        'primaryDateNavigator
        '
        Me.primaryDateNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primaryDateNavigator.HotDate = Nothing
        Me.primaryDateNavigator.Location = New System.Drawing.Point(0, 0)
        Me.primaryDateNavigator.Name = "primaryDateNavigator"
        Me.primaryDateNavigator.SchedulerControl = Me.primarySchedulerControl
        Me.primaryDateNavigator.Size = New System.Drawing.Size(381, 322)
        Me.primaryDateNavigator.TabIndex = 0
        Me.primaryDateNavigator.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.FirstDay
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'CEINFO_INFORMETableAdapter
        '
        Me.CEINFO_INFORMETableAdapter.ClearBeforeFill = True
        '
        'frmCronogramaTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1158, 498)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCronogramaTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario Filtro"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.informesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEINFOINFORMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primarySchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primaryDateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents informesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents primarySchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents primarySchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents primaryDateNavigator As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents TecnicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppointmentDataDS As SISOTEC.appointmentDataDS
    Friend WithEvents AppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppointmentsTableAdapter As SISOTEC.appointmentDataDSTableAdapters.AppointmentsTableAdapter
    Friend WithEvents ResourcesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResourcesTableAdapter As SISOTEC.appointmentDataDSTableAdapters.ResourcesTableAdapter
    Friend WithEvents CEINFOINFORMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CEINFO_INFORMETableAdapter As SISOTEC.appointmentDataDSTableAdapters.CEINFO_INFORMETableAdapter
    Friend WithEvents CEINFOCODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEINFOFECINIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEINFOFECFINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEINFOTIPOXXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEINFOESTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
