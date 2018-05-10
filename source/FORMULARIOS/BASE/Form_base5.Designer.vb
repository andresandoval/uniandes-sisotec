<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_base5
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGV_DATOS = New System.Windows.Forms.DataGridView
        Me.txt_inac = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txt_meap = New System.Windows.Forms.TextBox
        Me.txt_pare = New System.Windows.Forms.TextBox
        Me.txt_ning = New System.Windows.Forms.TextBox
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_DATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox3.Controls.Add(Me.DGV_DATOS)
        Me.GroupBox3.Controls.Add(Me.txt_inac)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.txt_meap)
        Me.GroupBox3.Controls.Add(Me.txt_pare)
        Me.GroupBox3.Controls.Add(Me.txt_ning)
        Me.GroupBox3.Controls.Add(Me.txt_filtro)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(9, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1132, 124)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Ingresados"
        '
        'DGV_DATOS
        '
        Me.DGV_DATOS.AllowUserToAddRows = False
        Me.DGV_DATOS.AllowUserToDeleteRows = False
        Me.DGV_DATOS.BackgroundColor = System.Drawing.Color.White
        Me.DGV_DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DATOS.Location = New System.Drawing.Point(19, 19)
        Me.DGV_DATOS.Name = "DGV_DATOS"
        Me.DGV_DATOS.ReadOnly = True
        Me.DGV_DATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DATOS.Size = New System.Drawing.Size(1105, 98)
        Me.DGV_DATOS.TabIndex = 5
        '
        'txt_inac
        '
        Me.txt_inac.BackColor = System.Drawing.Color.White
        Me.txt_inac.Enabled = False
        Me.txt_inac.ForeColor = System.Drawing.Color.Black
        Me.txt_inac.Location = New System.Drawing.Point(319, 88)
        Me.txt_inac.Name = "txt_inac"
        Me.txt_inac.Size = New System.Drawing.Size(315, 20)
        Me.txt_inac.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(108, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 57)
        Me.DataGridView1.TabIndex = 11
        '
        'txt_meap
        '
        Me.txt_meap.BackColor = System.Drawing.Color.White
        Me.txt_meap.Enabled = False
        Me.txt_meap.ForeColor = System.Drawing.Color.Black
        Me.txt_meap.Location = New System.Drawing.Point(291, 79)
        Me.txt_meap.Name = "txt_meap"
        Me.txt_meap.Size = New System.Drawing.Size(200, 20)
        Me.txt_meap.TabIndex = 29
        '
        'txt_pare
        '
        Me.txt_pare.BackColor = System.Drawing.Color.White
        Me.txt_pare.Enabled = False
        Me.txt_pare.ForeColor = System.Drawing.Color.Black
        Me.txt_pare.Location = New System.Drawing.Point(458, 53)
        Me.txt_pare.Name = "txt_pare"
        Me.txt_pare.Size = New System.Drawing.Size(100, 20)
        Me.txt_pare.TabIndex = 25
        Me.txt_pare.Visible = False
        '
        'txt_ning
        '
        Me.txt_ning.BackColor = System.Drawing.Color.White
        Me.txt_ning.Enabled = False
        Me.txt_ning.ForeColor = System.Drawing.Color.Black
        Me.txt_ning.Location = New System.Drawing.Point(497, 52)
        Me.txt_ning.Name = "txt_ning"
        Me.txt_ning.Size = New System.Drawing.Size(200, 20)
        Me.txt_ning.TabIndex = 32
        '
        'txt_filtro
        '
        Me.txt_filtro.BackColor = System.Drawing.Color.White
        Me.txt_filtro.ForeColor = System.Drawing.Color.Black
        Me.txt_filtro.Location = New System.Drawing.Point(319, 57)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(133, 20)
        Me.txt_filtro.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1132, 369)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'Form_base5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1150, 510)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_base5"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".::HISTORIAL::."
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_DATOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_inac As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_meap As System.Windows.Forms.TextBox
    Friend WithEvents txt_pare As System.Windows.Forms.TextBox
    Friend WithEvents txt_ning As System.Windows.Forms.TextBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents DGV_DATOS As System.Windows.Forms.DataGridView
End Class
