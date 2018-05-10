<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_nom = New System.Windows.Forms.TextBox
        Me.txt_clave = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_salir = New System.Windows.Forms.Button
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(74, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "USUARIO :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(89, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "CLAVE :"
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.Color.White
        Me.txt_nom.ForeColor = System.Drawing.Color.Black
        Me.txt_nom.Location = New System.Drawing.Point(161, 6)
        Me.txt_nom.MaxLength = 20
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(124, 20)
        Me.txt_nom.TabIndex = 40
        '
        'txt_clave
        '
        Me.txt_clave.BackColor = System.Drawing.Color.White
        Me.txt_clave.ForeColor = System.Drawing.Color.Black
        Me.txt_clave.Location = New System.Drawing.Point(161, 36)
        Me.txt_clave.MaxLength = 15
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(124, 20)
        Me.txt_clave.TabIndex = 41
        Me.txt_clave.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_aceptar)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 188)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 69)
        Me.Panel1.TabIndex = 43
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.White
        Me.btn_salir.ForeColor = System.Drawing.Color.Black
        Me.btn_salir.Image = Global.SISOTEC.My.Resources.Resources._exit
        Me.btn_salir.Location = New System.Drawing.Point(206, 9)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(99, 55)
        Me.btn_salir.TabIndex = 43
        Me.btn_salir.Text = "&SALIR"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.White
        Me.btn_aceptar.ForeColor = System.Drawing.Color.Black
        Me.btn_aceptar.Image = Global.SISOTEC.My.Resources.Resources.accept
        Me.btn_aceptar.Location = New System.Drawing.Point(88, 9)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(99, 55)
        Me.btn_aceptar.TabIndex = 42
        Me.btn_aceptar.Text = "&ACEPTAR"
        Me.btn_aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.Controls.Add(Me.txt_clave)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_nom)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 75)
        Me.Panel2.TabIndex = 44
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(161, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 38)
        Me.Panel3.TabIndex = 46
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(161, 52)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 24)
        Me.Panel4.TabIndex = 47
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.ForeColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(161, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 24)
        Me.Panel5.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(177, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 37)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(183, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Sistema de Gestión de Relación"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = Global.SISOTEC.My.Resources.Resources.NUEVO_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(12, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(409, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nom As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
