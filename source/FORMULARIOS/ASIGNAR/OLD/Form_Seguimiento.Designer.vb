<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Seguimiento
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calendario Anual"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(992, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(87, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(335, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TÉCNICO :"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(428, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(607, 95)
        Me.DataGridView2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Seguimiento del técnico"
        '
        'Form_Seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1047, 472)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Seguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendario Flitro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
