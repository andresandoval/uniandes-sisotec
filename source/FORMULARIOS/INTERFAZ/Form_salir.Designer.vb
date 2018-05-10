<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_salir
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_cambiar = New System.Windows.Forms.Button
        Me.btn_apagar = New System.Windows.Forms.Button
        Me.btn_salir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(117, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desea SALIR de SISOTEC?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione una de las siguientes opciones para continuar."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(123, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gracias por utilizar SISOTEC"
        '
        'btn_cambiar
        '
        Me.btn_cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cambiar.ForeColor = System.Drawing.Color.White
        Me.btn_cambiar.Location = New System.Drawing.Point(115, 186)
        Me.btn_cambiar.Name = "btn_cambiar"
        Me.btn_cambiar.Size = New System.Drawing.Size(110, 23)
        Me.btn_cambiar.TabIndex = 4
        Me.btn_cambiar.Text = "&Cambiar usuario"
        Me.btn_cambiar.UseVisualStyleBackColor = True
        '
        'btn_apagar
        '
        Me.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_apagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apagar.ForeColor = System.Drawing.Color.White
        Me.btn_apagar.Location = New System.Drawing.Point(231, 186)
        Me.btn_apagar.Name = "btn_apagar"
        Me.btn_apagar.Size = New System.Drawing.Size(101, 23)
        Me.btn_apagar.TabIndex = 5
        Me.btn_apagar.Text = "&Apagar PC"
        Me.btn_apagar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.White
        Me.btn_salir.Location = New System.Drawing.Point(340, 186)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(209, 23)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "&Cerrar y SALIR de SISOTEC"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Form_salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(672, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_apagar)
        Me.Controls.Add(Me.btn_cambiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_salir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_salir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cambiar As System.Windows.Forms.Button
    Friend WithEvents btn_apagar As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
