<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PersonaT
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
        Me.DGV_PERSONA = New System.Windows.Forms.DataGridView
        Me.txt_inac = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txt_meap = New System.Windows.Forms.TextBox
        Me.txt_pare = New System.Windows.Forms.TextBox
        Me.txt_ning = New System.Windows.Forms.TextBox
        Me.txt_filtro = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbb_tipo = New System.Windows.Forms.ComboBox
        Me.txt_niin = New System.Windows.Forms.TextBox
        Me.txt_tele = New System.Windows.Forms.TextBox
        Me.txt_domi = New System.Windows.Forms.TextBox
        Me.cbb_esci = New System.Windows.Forms.ComboBox
        Me.cbb_gene = New System.Windows.Forms.ComboBox
        Me.txt_ocup = New System.Windows.Forms.TextBox
        Me.txt_edad = New System.Windows.Forms.TextBox
        Me.dtm_fena = New System.Windows.Forms.DateTimePicker
        Me.txt_apel = New System.Windows.Forms.TextBox
        Me.txt_nomb = New System.Windows.Forms.TextBox
        Me.txt_cedu = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BN_SALIR = New DevComponents.DotNetBar.ButtonX
        Me.BN_EDITAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_CANCELAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_GUARDAR = New DevComponents.DotNetBar.ButtonX
        Me.BN_NUEVO = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_PERSONA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGV_PERSONA)
        Me.GroupBox3.Controls.Add(Me.txt_inac)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.txt_meap)
        Me.GroupBox3.Controls.Add(Me.txt_pare)
        Me.GroupBox3.Controls.Add(Me.txt_ning)
        Me.GroupBox3.Controls.Add(Me.txt_filtro)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 194)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(984, 231)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Ingresados"
        '
        'DGV_PERSONA
        '
        Me.DGV_PERSONA.AllowUserToAddRows = False
        Me.DGV_PERSONA.AllowUserToDeleteRows = False
        Me.DGV_PERSONA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PERSONA.Location = New System.Drawing.Point(9, 18)
        Me.DGV_PERSONA.Name = "DGV_PERSONA"
        Me.DGV_PERSONA.ReadOnly = True
        Me.DGV_PERSONA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PERSONA.Size = New System.Drawing.Size(959, 205)
        Me.DGV_PERSONA.TabIndex = 5
        '
        'txt_inac
        '
        Me.txt_inac.Enabled = False
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
        Me.txt_meap.Enabled = False
        Me.txt_meap.Location = New System.Drawing.Point(291, 79)
        Me.txt_meap.Name = "txt_meap"
        Me.txt_meap.Size = New System.Drawing.Size(200, 20)
        Me.txt_meap.TabIndex = 29
        '
        'txt_pare
        '
        Me.txt_pare.Enabled = False
        Me.txt_pare.Location = New System.Drawing.Point(458, 53)
        Me.txt_pare.Name = "txt_pare"
        Me.txt_pare.Size = New System.Drawing.Size(100, 20)
        Me.txt_pare.TabIndex = 25
        Me.txt_pare.Visible = False
        '
        'txt_ning
        '
        Me.txt_ning.Enabled = False
        Me.txt_ning.Location = New System.Drawing.Point(497, 52)
        Me.txt_ning.Name = "txt_ning"
        Me.txt_ning.Size = New System.Drawing.Size(200, 20)
        Me.txt_ning.TabIndex = 32
        '
        'txt_filtro
        '
        Me.txt_filtro.Location = New System.Drawing.Point(184, 161)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(133, 20)
        Me.txt_filtro.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbb_tipo)
        Me.GroupBox1.Controls.Add(Me.txt_niin)
        Me.GroupBox1.Controls.Add(Me.txt_tele)
        Me.GroupBox1.Controls.Add(Me.txt_domi)
        Me.GroupBox1.Controls.Add(Me.cbb_esci)
        Me.GroupBox1.Controls.Add(Me.cbb_gene)
        Me.GroupBox1.Controls.Add(Me.txt_ocup)
        Me.GroupBox1.Controls.Add(Me.txt_edad)
        Me.GroupBox1.Controls.Add(Me.dtm_fena)
        Me.GroupBox1.Controls.Add(Me.txt_apel)
        Me.GroupBox1.Controls.Add(Me.txt_nomb)
        Me.GroupBox1.Controls.Add(Me.txt_cedu)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(984, 190)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESAR DATOS"
        '
        'cbb_tipo
        '
        Me.cbb_tipo.Enabled = False
        Me.cbb_tipo.FormattingEnabled = True
        Me.cbb_tipo.Items.AddRange(New Object() {"TÉCNICO"})
        Me.cbb_tipo.Location = New System.Drawing.Point(608, 157)
        Me.cbb_tipo.Name = "cbb_tipo"
        Me.cbb_tipo.Size = New System.Drawing.Size(232, 21)
        Me.cbb_tipo.TabIndex = 31
        Me.cbb_tipo.Text = "TÉCNICO"
        '
        'txt_niin
        '
        Me.txt_niin.Enabled = False
        Me.txt_niin.Location = New System.Drawing.Point(607, 101)
        Me.txt_niin.Name = "txt_niin"
        Me.txt_niin.Size = New System.Drawing.Size(363, 20)
        Me.txt_niin.TabIndex = 27
        '
        'txt_tele
        '
        Me.txt_tele.Enabled = False
        Me.txt_tele.Location = New System.Drawing.Point(608, 46)
        Me.txt_tele.Name = "txt_tele"
        Me.txt_tele.Size = New System.Drawing.Size(211, 20)
        Me.txt_tele.TabIndex = 26
        '
        'txt_domi
        '
        Me.txt_domi.Enabled = False
        Me.txt_domi.Location = New System.Drawing.Point(608, 17)
        Me.txt_domi.Name = "txt_domi"
        Me.txt_domi.Size = New System.Drawing.Size(363, 20)
        Me.txt_domi.TabIndex = 24
        '
        'cbb_esci
        '
        Me.cbb_esci.Enabled = False
        Me.cbb_esci.FormattingEnabled = True
        Me.cbb_esci.Items.AddRange(New Object() {"SOLTERO", "CASADO", "UNIÓN LIBRE", "DIVORSIAO", "VIUDO"})
        Me.cbb_esci.Location = New System.Drawing.Point(149, 157)
        Me.cbb_esci.Name = "cbb_esci"
        Me.cbb_esci.Size = New System.Drawing.Size(314, 21)
        Me.cbb_esci.TabIndex = 23
        '
        'cbb_gene
        '
        Me.cbb_gene.Enabled = False
        Me.cbb_gene.FormattingEnabled = True
        Me.cbb_gene.Items.AddRange(New Object() {"M", "F"})
        Me.cbb_gene.Location = New System.Drawing.Point(608, 130)
        Me.cbb_gene.Name = "cbb_gene"
        Me.cbb_gene.Size = New System.Drawing.Size(50, 21)
        Me.cbb_gene.TabIndex = 22
        '
        'txt_ocup
        '
        Me.txt_ocup.Enabled = False
        Me.txt_ocup.Location = New System.Drawing.Point(608, 75)
        Me.txt_ocup.Name = "txt_ocup"
        Me.txt_ocup.Size = New System.Drawing.Size(362, 20)
        Me.txt_ocup.TabIndex = 21
        '
        'txt_edad
        '
        Me.txt_edad.Enabled = False
        Me.txt_edad.Location = New System.Drawing.Point(148, 133)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(215, 20)
        Me.txt_edad.TabIndex = 20
        '
        'dtm_fena
        '
        Me.dtm_fena.Enabled = False
        Me.dtm_fena.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtm_fena.Location = New System.Drawing.Point(148, 104)
        Me.dtm_fena.Name = "dtm_fena"
        Me.dtm_fena.Size = New System.Drawing.Size(254, 20)
        Me.dtm_fena.TabIndex = 19
        '
        'txt_apel
        '
        Me.txt_apel.Enabled = False
        Me.txt_apel.Location = New System.Drawing.Point(148, 75)
        Me.txt_apel.Name = "txt_apel"
        Me.txt_apel.Size = New System.Drawing.Size(355, 20)
        Me.txt_apel.TabIndex = 18
        '
        'txt_nomb
        '
        Me.txt_nomb.Enabled = False
        Me.txt_nomb.Location = New System.Drawing.Point(148, 46)
        Me.txt_nomb.Name = "txt_nomb"
        Me.txt_nomb.Size = New System.Drawing.Size(355, 20)
        Me.txt_nomb.TabIndex = 17
        '
        'txt_cedu
        '
        Me.txt_cedu.Enabled = False
        Me.txt_cedu.Location = New System.Drawing.Point(148, 17)
        Me.txt_cedu.Name = "txt_cedu"
        Me.txt_cedu.Size = New System.Drawing.Size(215, 20)
        Me.txt_cedu.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(564, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "TIPO :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(553, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "TITULO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(532, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "TELEFONO :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(534, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DOMICILIO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ESTADO CIVIL :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(543, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "GENERO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CARGO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "EDAD :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FECHA DE NACIMIENTO :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDOS :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRES :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CEDULA :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(1000, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 105)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox5.Controls.Add(Me.BN_SALIR)
        Me.GroupBox5.Controls.Add(Me.BN_EDITAR)
        Me.GroupBox5.Controls.Add(Me.BN_CANCELAR)
        Me.GroupBox5.Controls.Add(Me.BN_GUARDAR)
        Me.GroupBox5.Controls.Add(Me.BN_NUEVO)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(1000, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 298)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Acciones"
        '
        'BN_SALIR
        '
        Me.BN_SALIR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BN_SALIR.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BN_SALIR.Image = Global.SISOTEC.My.Resources.Resources.SALIR_FINAL
        Me.BN_SALIR.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.BN_SALIR.Location = New System.Drawing.Point(9, 234)
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
        'Form_PersonaT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1150, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_PersonaT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_PERSONA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_PERSONA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ning As System.Windows.Forms.TextBox
    Friend WithEvents cbb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_inac As System.Windows.Forms.TextBox
    Friend WithEvents txt_meap As System.Windows.Forms.TextBox
    Friend WithEvents txt_niin As System.Windows.Forms.TextBox
    Friend WithEvents txt_tele As System.Windows.Forms.TextBox
    Friend WithEvents txt_pare As System.Windows.Forms.TextBox
    Friend WithEvents txt_domi As System.Windows.Forms.TextBox
    Friend WithEvents cbb_esci As System.Windows.Forms.ComboBox
    Friend WithEvents cbb_gene As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ocup As System.Windows.Forms.TextBox
    Friend WithEvents txt_edad As System.Windows.Forms.TextBox
    Friend WithEvents dtm_fena As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_apel As System.Windows.Forms.TextBox
    Friend WithEvents txt_nomb As System.Windows.Forms.TextBox
    Friend WithEvents txt_cedu As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_filtro As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents BN_SALIR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_EDITAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_CANCELAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_GUARDAR As DevComponents.DotNetBar.ButtonX
    Public WithEvents BN_NUEVO As DevComponents.DotNetBar.ButtonX
End Class
