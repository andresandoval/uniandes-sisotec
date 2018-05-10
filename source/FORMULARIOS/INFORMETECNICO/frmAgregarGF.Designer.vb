<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarGF
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
        Me.primaryGridView = New System.Windows.Forms.DataGridView
        Me.CEPERSCODIGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEPERSNOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEPERSAPELLIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEPERSEDADXXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEPERSGENERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEPERSPERSONABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersonasDS = New SISOTEC.personasDS
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnOk = New System.Windows.Forms.Button
        Me.txtRelPar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPersonaName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CEPERS_PERSONATableAdapter = New SISOTEC.personasDSTableAdapters.CEPERS_PERSONATableAdapter
        CType(Me.primaryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEPERSPERSONABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'primaryGridView
        '
        Me.primaryGridView.AutoGenerateColumns = False
        Me.primaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.primaryGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CEPERSCODIGODataGridViewTextBoxColumn, Me.CEPERSNOMBREDataGridViewTextBoxColumn, Me.CEPERSAPELLIDataGridViewTextBoxColumn, Me.CEPERSEDADXXDataGridViewTextBoxColumn, Me.CEPERSGENERODataGridViewTextBoxColumn})
        Me.primaryGridView.DataSource = Me.CEPERSPERSONABindingSource
        Me.primaryGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primaryGridView.Location = New System.Drawing.Point(0, 0)
        Me.primaryGridView.Name = "primaryGridView"
        Me.primaryGridView.ReadOnly = True
        Me.primaryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.primaryGridView.Size = New System.Drawing.Size(490, 234)
        Me.primaryGridView.TabIndex = 0
        '
        'CEPERSCODIGODataGridViewTextBoxColumn
        '
        Me.CEPERSCODIGODataGridViewTextBoxColumn.DataPropertyName = "CEPERS_CODIGO"
        Me.CEPERSCODIGODataGridViewTextBoxColumn.HeaderText = "CEPERS_CODIGO"
        Me.CEPERSCODIGODataGridViewTextBoxColumn.Name = "CEPERSCODIGODataGridViewTextBoxColumn"
        Me.CEPERSCODIGODataGridViewTextBoxColumn.ReadOnly = True
        Me.CEPERSCODIGODataGridViewTextBoxColumn.Visible = False
        '
        'CEPERSNOMBREDataGridViewTextBoxColumn
        '
        Me.CEPERSNOMBREDataGridViewTextBoxColumn.DataPropertyName = "CEPERS_NOMBRE"
        Me.CEPERSNOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.CEPERSNOMBREDataGridViewTextBoxColumn.Name = "CEPERSNOMBREDataGridViewTextBoxColumn"
        Me.CEPERSNOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEPERSAPELLIDataGridViewTextBoxColumn
        '
        Me.CEPERSAPELLIDataGridViewTextBoxColumn.DataPropertyName = "CEPERS_APELLI"
        Me.CEPERSAPELLIDataGridViewTextBoxColumn.HeaderText = "APELLIDO"
        Me.CEPERSAPELLIDataGridViewTextBoxColumn.Name = "CEPERSAPELLIDataGridViewTextBoxColumn"
        Me.CEPERSAPELLIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEPERSEDADXXDataGridViewTextBoxColumn
        '
        Me.CEPERSEDADXXDataGridViewTextBoxColumn.DataPropertyName = "CEPERS_EDADXX"
        Me.CEPERSEDADXXDataGridViewTextBoxColumn.HeaderText = "EDAD"
        Me.CEPERSEDADXXDataGridViewTextBoxColumn.Name = "CEPERSEDADXXDataGridViewTextBoxColumn"
        Me.CEPERSEDADXXDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEPERSGENERODataGridViewTextBoxColumn
        '
        Me.CEPERSGENERODataGridViewTextBoxColumn.DataPropertyName = "CEPERS_GENERO"
        Me.CEPERSGENERODataGridViewTextBoxColumn.HeaderText = "GENERO"
        Me.CEPERSGENERODataGridViewTextBoxColumn.Name = "CEPERSGENERODataGridViewTextBoxColumn"
        Me.CEPERSGENERODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEPERSPERSONABindingSource
        '
        Me.CEPERSPERSONABindingSource.DataMember = "CEPERS_PERSONA"
        Me.CEPERSPERSONABindingSource.DataSource = Me.PersonasDS
        '
        'PersonasDS
        '
        Me.PersonasDS.DataSetName = "personasDS"
        Me.PersonasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.txtRelPar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPersonaName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 100)
        Me.Panel1.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(417, 27)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(61, 61)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtRelPar
        '
        Me.txtRelPar.Location = New System.Drawing.Point(8, 68)
        Me.txtRelPar.Name = "txtRelPar"
        Me.txtRelPar.Size = New System.Drawing.Size(403, 20)
        Me.txtRelPar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Relacion de parentezco:"
        '
        'txtPersonaName
        '
        Me.txtPersonaName.Location = New System.Drawing.Point(9, 29)
        Me.txtPersonaName.Name = "txtPersonaName"
        Me.txtPersonaName.ReadOnly = True
        Me.txtPersonaName.Size = New System.Drawing.Size(402, 20)
        Me.txtPersonaName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Persona:"
        '
        'CEPERS_PERSONATableAdapter
        '
        Me.CEPERS_PERSONATableAdapter.ClearBeforeFill = True
        '
        'frmAgregarGF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 334)
        Me.Controls.Add(Me.primaryGridView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarGF"
        Me.ShowIcon = False
        Me.Text = "Grupo Familiar"
        CType(Me.primaryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEPERSPERSONABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents primaryGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CEPERSCODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPERSNOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPERSAPELLIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPERSEDADXXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPERSGENERODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEPERSPERSONABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonasDS As SISOTEC.personasDS
    Friend WithEvents CEPERS_PERSONATableAdapter As SISOTEC.personasDSTableAdapters.CEPERS_PERSONATableAdapter
    Friend WithEvents txtRelPar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPersonaName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
