<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarioTecnico
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.informesDataGridView = New System.Windows.Forms.DataGridView
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PendientesEntityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tecnicoComboBox = New System.Windows.Forms.ComboBox
        Me.selectedTecnicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TecnicoEntityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.primarySchedulerControl = New DevExpress.XtraScheduler.SchedulerControl
        Me.primarySchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.primaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.informesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendientesEntityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selectedTecnicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnicoEntityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primarySchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btnAceptar)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.informesDataGridView)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.tecnicoComboBox)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1154, 472)
        Me.SplitContainerControl1.SplitterPosition = 117
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(84, 88)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(335, 28)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "&ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 39)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Asignación de Técnico"
        '
        'informesDataGridView
        '
        Me.informesDataGridView.AllowUserToAddRows = False
        Me.informesDataGridView.AllowUserToDeleteRows = False
        Me.informesDataGridView.AllowUserToOrderColumns = True
        Me.informesDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.informesDataGridView.AutoGenerateColumns = False
        Me.informesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.informesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.informesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBREDataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.CANTIDADDataGridViewTextBoxColumn})
        Me.informesDataGridView.DataSource = Me.PendientesEntityBindingSource
        Me.informesDataGridView.Location = New System.Drawing.Point(534, 12)
        Me.informesDataGridView.Name = "informesDataGridView"
        Me.informesDataGridView.ReadOnly = True
        Me.informesDataGridView.Size = New System.Drawing.Size(357, 93)
        Me.informesDataGridView.TabIndex = 12
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PendientesEntityBindingSource
        '
        Me.PendientesEntityBindingSource.DataSource = GetType(SISOTEC.Entities.pendientesEntity)
        '
        'tecnicoComboBox
        '
        Me.tecnicoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.tecnicoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tecnicoComboBox.BackColor = System.Drawing.Color.White
        Me.tecnicoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.selectedTecnicoBindingSource, "CEPERS_CODIGO", True))
        Me.tecnicoComboBox.DataSource = Me.TecnicoEntityBindingSource
        Me.tecnicoComboBox.DisplayMember = "NOMBRE"
        Me.tecnicoComboBox.ForeColor = System.Drawing.Color.Black
        Me.tecnicoComboBox.FormattingEnabled = True
        Me.tecnicoComboBox.Location = New System.Drawing.Point(84, 61)
        Me.tecnicoComboBox.Name = "tecnicoComboBox"
        Me.tecnicoComboBox.Size = New System.Drawing.Size(335, 21)
        Me.tecnicoComboBox.TabIndex = 10
        Me.tecnicoComboBox.ValueMember = "CEPERS_CODIGO"
        '
        'selectedTecnicoBindingSource
        '
        Me.selectedTecnicoBindingSource.DataSource = GetType(SISOTEC.Entities.tecnicoEntity)
        '
        'TecnicoEntityBindingSource
        '
        Me.TecnicoEntityBindingSource.DataSource = GetType(SISOTEC.Entities.tecnicoEntity)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(18, 64)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1154, 350)
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
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1148, 331)
        Me.SplitContainerControl2.SplitterPosition = 766
        Me.SplitContainerControl2.TabIndex = 1
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'primarySchedulerControl
        '
        Me.primarySchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primarySchedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.primarySchedulerControl.Name = "primarySchedulerControl"
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.Custom
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.Custom
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentDrag = DevExpress.XtraScheduler.UsedAppointmentType.Custom
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentDragBetweenResources = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.Custom
        Me.primarySchedulerControl.OptionsCustomization.AllowAppointmentResize = DevExpress.XtraScheduler.UsedAppointmentType.Custom
        Me.primarySchedulerControl.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.primarySchedulerControl.Size = New System.Drawing.Size(766, 331)
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
        Me.primarySchedulerStorage.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("AllowEdit", "allowEdit"))
        Me.primarySchedulerStorage.Appointments.DataSource = Me.primaryBindingSource
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
        Me.DateNavigator1.Size = New System.Drawing.Size(377, 331)
        Me.DateNavigator1.TabIndex = 0
        '
        'frmCalendarioTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1154, 472)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCalendarioTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario Filtro"
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.informesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendientesEntityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selectedTecnicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnicoEntityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.primarySchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primarySchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents informesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents tecnicoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents primarySchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents primarySchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents primaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TecnicoEntityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendientesEntityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents selectedTecnicoBindingSource As System.Windows.Forms.BindingSource
End Class
