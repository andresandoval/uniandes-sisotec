<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_AdminUser
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
        Me.DGV_ADMUSU = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_obse = New System.Windows.Forms.TextBox
        Me.cbb_esta = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbb_tipo = New System.Windows.Forms.ComboBox
        Me.txt_clav = New System.Windows.Forms.TextBox
        Me.dtm_feve = New System.Windows.Forms.DateTimePicker
        Me.txt_nomb = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BN_SALIR = New System.Windows.Forms.Button
        Me.BN_EDITAR = New System.Windows.Forms.Button
        Me.BN_CANCELAR = New System.Windows.Forms.Button
        Me.BN_GUARDAR = New System.Windows.Forms.Button
        Me.BN_NUEVO = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.DGV_ADMUSU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_ADMUSU
        '
        Me.DGV_ADMUSU.AllowUserToAddRows = False
        Me.DGV_ADMUSU.AllowUserToDeleteRows = False
        Me.DGV_ADMUSU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ADMUSU.Location = New System.Drawing.Point(26, 15)
        Me.DGV_ADMUSU.Name = "DGV_ADMUSU"
        Me.DGV_ADMUSU.ReadOnly = True
        Me.DGV_ADMUSU.Size = New System.Drawing.Size(640, 170)
        Me.DGV_ADMUSU.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BN_SALIR)
        Me.GroupBox2.Controls.Add(Me.BN_EDITAR)
        Me.GroupBox2.Controls.Add(Me.BN_CANCELAR)
        Me.GroupBox2.Controls.Add(Me.BN_GUARDAR)
        Me.GroupBox2.Controls.Add(Me.BN_NUEVO)
        Me.GroupBox2.Location = New System.Drawing.Point(84, 450)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 89)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_obse)
        Me.GroupBox1.Controls.Add(Me.cbb_esta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbb_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_clav)
        Me.GroupBox1.Controls.Add(Me.dtm_feve)
        Me.GroupBox1.Controls.Add(Me.txt_nomb)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 227)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS"
        '
        'txt_obse
        '
        Me.txt_obse.Enabled = False
        Me.txt_obse.Location = New System.Drawing.Point(156, 169)
        Me.txt_obse.Multiline = True
        Me.txt_obse.Name = "txt_obse"
        Me.txt_obse.Size = New System.Drawing.Size(315, 52)
        Me.txt_obse.TabIndex = 26
        '
        'cbb_esta
        '
        Me.cbb_esta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_esta.Enabled = False
        Me.cbb_esta.FormattingEnabled = True
        Me.cbb_esta.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cbb_esta.Location = New System.Drawing.Point(156, 142)
        Me.cbb_esta.Name = "cbb_esta"
        Me.cbb_esta.Size = New System.Drawing.Size(139, 21)
        Me.cbb_esta.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "ESTADO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "OBSERVACION ;"
        '
        'cbb_tipo
        '
        Me.cbb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_tipo.Enabled = False
        Me.cbb_tipo.FormattingEnabled = True
        Me.cbb_tipo.Items.AddRange(New Object() {"ADMINISTRADOR", "USER"})
        Me.cbb_tipo.Location = New System.Drawing.Point(157, 84)
        Me.cbb_tipo.Name = "cbb_tipo"
        Me.cbb_tipo.Size = New System.Drawing.Size(139, 21)
        Me.cbb_tipo.TabIndex = 22
        '
        'txt_clav
        '
        Me.txt_clav.Enabled = False
        Me.txt_clav.Location = New System.Drawing.Point(156, 114)
        Me.txt_clav.Name = "txt_clav"
        Me.txt_clav.Size = New System.Drawing.Size(100, 20)
        Me.txt_clav.TabIndex = 20
        '
        'dtm_feve
        '
        Me.dtm_feve.Enabled = False
        Me.dtm_feve.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_feve.Location = New System.Drawing.Point(157, 56)
        Me.dtm_feve.Name = "dtm_feve"
        Me.dtm_feve.Size = New System.Drawing.Size(139, 20)
        Me.dtm_feve.TabIndex = 19
        '
        'txt_nomb
        '
        Me.txt_nomb.Enabled = False
        Me.txt_nomb.Location = New System.Drawing.Point(156, 27)
        Me.txt_nomb.Name = "txt_nomb"
        Me.txt_nomb.Size = New System.Drawing.Size(315, 20)
        Me.txt_nomb.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TIPO :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CLAVE :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FECHA VENCIMIENTO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_ADMUSU)
        Me.GroupBox3.Location = New System.Drawing.Point(89, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(688, 199)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DATOS REGISTRADOS"
        '
        'BN_SALIR
        '
        Me.BN_SALIR.Image = Global.SISOTEC.My.Resources.Resources.SALIR_FINAL
        Me.BN_SALIR.Location = New System.Drawing.Point(550, 19)
        Me.BN_SALIR.Name = "BN_SALIR"
        Me.BN_SALIR.Size = New System.Drawing.Size(125, 54)
        Me.BN_SALIR.TabIndex = 4
        Me.BN_SALIR.Text = "&SALIR"
        Me.BN_SALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BN_SALIR.UseVisualStyleBackColor = True
        '
        'BN_EDITAR
        '
        Me.BN_EDITAR.Image = Global.SISOTEC.My.Resources.Resources.EDITAR_FINAL
        Me.BN_EDITAR.Location = New System.Drawing.Point(288, 19)
        Me.BN_EDITAR.Name = "BN_EDITAR"
        Me.BN_EDITAR.Size = New System.Drawing.Size(125, 54)
        Me.BN_EDITAR.TabIndex = 3
        Me.BN_EDITAR.Text = "&EDITAR"
        Me.BN_EDITAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BN_EDITAR.UseVisualStyleBackColor = True
        '
        'BN_CANCELAR
        '
        Me.BN_CANCELAR.Enabled = False
        Me.BN_CANCELAR.Image = Global.SISOTEC.My.Resources.Resources.CANCELAR_FINAL
        Me.BN_CANCELAR.Location = New System.Drawing.Point(419, 19)
        Me.BN_CANCELAR.Name = "BN_CANCELAR"
        Me.BN_CANCELAR.Size = New System.Drawing.Size(125, 54)
        Me.BN_CANCELAR.TabIndex = 2
        Me.BN_CANCELAR.Text = "&CANCELAR"
        Me.BN_CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BN_GUARDAR
        '
        Me.BN_GUARDAR.Enabled = False
        Me.BN_GUARDAR.Image = Global.SISOTEC.My.Resources.Resources.GUARDAR_FINAL
        Me.BN_GUARDAR.Location = New System.Drawing.Point(157, 19)
        Me.BN_GUARDAR.Name = "BN_GUARDAR"
        Me.BN_GUARDAR.Size = New System.Drawing.Size(125, 54)
        Me.BN_GUARDAR.TabIndex = 1
        Me.BN_GUARDAR.Text = "&GUARDAR"
        Me.BN_GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BN_GUARDAR.UseVisualStyleBackColor = True
        '
        'BN_NUEVO
        '
        Me.BN_NUEVO.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_FINAL
        Me.BN_NUEVO.Location = New System.Drawing.Point(26, 19)
        Me.BN_NUEVO.Name = "BN_NUEVO"
        Me.BN_NUEVO.Size = New System.Drawing.Size(125, 54)
        Me.BN_NUEVO.TabIndex = 0
        Me.BN_NUEVO.Text = "&NUEVO"
        Me.BN_NUEVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BN_NUEVO.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(731, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Form_AdminUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(883, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form_AdminUser"
        Me.Text = ".:: ADMINISTRADOR DE USUARIOS ::."
        CType(Me.DGV_ADMUSU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DGV_ADMUSU As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BN_SALIR As System.Windows.Forms.Button
    Friend WithEvents BN_EDITAR As System.Windows.Forms.Button
    Friend WithEvents BN_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents BN_GUARDAR As System.Windows.Forms.Button
    Friend WithEvents BN_NUEVO As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_clav As System.Windows.Forms.TextBox
    Friend WithEvents dtm_feve As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nomb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbb_esta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_obse As System.Windows.Forms.TextBox
End Class
