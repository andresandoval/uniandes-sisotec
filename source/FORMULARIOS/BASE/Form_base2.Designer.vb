<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_base2
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BN_ELIMINAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_IMPRIMIR = New DevComponents.DotNetBar.ButtonX
        Me.BN_SALIR = New DevComponents.DotNetBar.ButtonX
        Me.BN_EDITAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_CANCELAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DGV_DATOS = New System.Windows.Forms.DataGridView
        Me.txt_inac = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txt_meap = New System.Windows.Forms.TextBox
        Me.txt_pare = New System.Windows.Forms.TextBox
        Me.txt_ning = New System.Windows.Forms.TextBox
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_DATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(739, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 96)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox2.Controls.Add(Me.BN_ELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BN_IMPRIMIR)
        Me.GroupBox2.Controls.Add(Me.BN_SALIR)
        Me.GroupBox2.Controls.Add(Me.BN_EDITAR)
        Me.GroupBox2.Controls.Add(Me.BN_CANCELAR)
        Me.GroupBox2.Controls.Add(Me.BN_GUARDAR)
        Me.GroupBox2.Controls.Add(Me.BN_NUEVO)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(739, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 398)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'BN_ELIMINAR
        '
        Me.BN_ELIMINAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_ELIMINAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_ELIMINAR.Image = Global.SISOTEC.My.Resources.Resources.CANCELAR_FINAL
        Me.BN_ELIMINAR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_ELIMINAR.Location = New System.Drawing.Point(9, 230)
        Me.BN_ELIMINAR.Name = "BN_ELIMINAR"
        Me.BN_ELIMINAR.Size = New System.Drawing.Size(125, 52)
        Me.BN_ELIMINAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_ELIMINAR.TabIndex = 6
        Me.BN_ELIMINAR.Text = "&ELIMINAR"
        '
        'BN_IMPRIMIR
        '
        Me.BN_IMPRIMIR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_IMPRIMIR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_IMPRIMIR.Image = Global.SISOTEC.My.Resources.Resources.prin
        Me.BN_IMPRIMIR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_IMPRIMIR.Location = New System.Drawing.Point(9, 285)
        Me.BN_IMPRIMIR.Name = "BN_IMPRIMIR"
        Me.BN_IMPRIMIR.Size = New System.Drawing.Size(125, 52)
        Me.BN_IMPRIMIR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_IMPRIMIR.TabIndex = 5
        Me.BN_IMPRIMIR.Text = "&IMPRIMIR"
        '
        'BN_SALIR
        '
        Me.BN_SALIR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_SALIR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_SALIR.Image = Global.SISOTEC.My.Resources.Resources.SALIR_FINAL
        Me.BN_SALIR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_SALIR.Location = New System.Drawing.Point(9, 340)
        Me.BN_SALIR.Name = "BN_SALIR"
        Me.BN_SALIR.Size = New System.Drawing.Size(125, 52)
        Me.BN_SALIR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_SALIR.TabIndex = 4
        Me.BN_SALIR.Text = "&SALIR"
        '
        'BN_EDITAR
        '
        Me.BN_EDITAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_EDITAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_EDITAR.Image = Global.SISOTEC.My.Resources.Resources.EDITAR_FINAL
        Me.BN_EDITAR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_EDITAR.Location = New System.Drawing.Point(9, 122)
        Me.BN_EDITAR.Name = "BN_EDITAR"
        Me.BN_EDITAR.Size = New System.Drawing.Size(125, 52)
        Me.BN_EDITAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_EDITAR.TabIndex = 3
        Me.BN_EDITAR.Text = "&EDITAR"
        '
        'BN_CANCELAR
        '
        Me.BN_CANCELAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_CANCELAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_CANCELAR.Enabled = False
        Me.BN_CANCELAR.Image = Global.SISOTEC.My.Resources.Resources.atras
        Me.BN_CANCELAR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_CANCELAR.Location = New System.Drawing.Point(9, 176)
        Me.BN_CANCELAR.Name = "BN_CANCELAR"
        Me.BN_CANCELAR.Size = New System.Drawing.Size(125, 52)
        Me.BN_CANCELAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_CANCELAR.TabIndex = 2
        Me.BN_CANCELAR.Text = "&CANCELAR"
        '
        'BN_GUARDAR
        '
        Me.BN_GUARDAR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_GUARDAR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_GUARDAR.Enabled = False
        Me.BN_GUARDAR.Image = Global.SISOTEC.My.Resources.Resources.GUARDAR_FINAL
        Me.BN_GUARDAR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_GUARDAR.Location = New System.Drawing.Point(9, 68)
        Me.BN_GUARDAR.Name = "BN_GUARDAR"
        Me.BN_GUARDAR.Size = New System.Drawing.Size(125, 52)
        Me.BN_GUARDAR.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_GUARDAR.TabIndex = 1
        Me.BN_GUARDAR.Text = "&GUARDAR"
        '
        'BN_NUEVO
        '
        Me.BN_NUEVO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_NUEVO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_NUEVO.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_FINAL
        Me.BN_NUEVO.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_NUEVO.Location = New System.Drawing.Point(9, 13)
        Me.BN_NUEVO.Name = "BN_NUEVO"
        Me.BN_NUEVO.Size = New System.Drawing.Size(125, 52)
        Me.BN_NUEVO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BN_NUEVO.TabIndex = 0
        Me.BN_NUEVO.Text = "&NUEVO"
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
        Me.GroupBox3.Location = New System.Drawing.Point(9, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 304)
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
        Me.DGV_DATOS.Size = New System.Drawing.Size(672, 274)
        Me.DGV_DATOS.TabIndex = 5
        '
        'txt_inac
        '
        Me.txt_inac.BackColor = System.Drawing.Color.White
        Me.txt_inac.Enabled = False
        Me.txt_inac.ForeColor = System.Drawing.Color.Black
        Me.txt_inac.Location = New System.Drawing.Point(319, 105)
        Me.txt_inac.Name = "txt_inac"
        Me.txt_inac.Size = New System.Drawing.Size(315, 20)
        Me.txt_inac.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(108, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
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
        Me.txt_ning.Location = New System.Drawing.Point(444, 52)
        Me.txt_ning.Name = "txt_ning"
        Me.txt_ning.Size = New System.Drawing.Size(200, 20)
        Me.txt_ning.TabIndex = 32
        '
        'txt_filtro
        '
        Me.txt_filtro.BackColor = System.Drawing.Color.White
        Me.txt_filtro.ForeColor = System.Drawing.Color.Black
        Me.txt_filtro.Location = New System.Drawing.Point(184, 161)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(133, 20)
        Me.txt_filtro.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 190)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'Form_base2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(905, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_base2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_base"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_DATOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_inac As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_meap As System.Windows.Forms.TextBox
    Friend WithEvents txt_pare As System.Windows.Forms.TextBox
    Friend WithEvents txt_ning As System.Windows.Forms.TextBox
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents DGV_DATOS As System.Windows.Forms.DataGridView
    Public WithEvents BN_SALIR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_EDITAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_CANCELAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_IMPRIMIR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_ELIMINAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_NUEVO As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
