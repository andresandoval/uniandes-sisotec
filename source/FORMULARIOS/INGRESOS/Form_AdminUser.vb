Public Class Form_AdminUser
    Dim consulta_Sql As New Class_SQL
    Dim resultado As Boolean
    Dim campoc, valoresc As String
    Dim validacion As New Class_validacion
    Dim codigodvg As Integer
    Dim dt_apod As New DataTable
    'Dim consulta_SqlServer As New Class_SQL
    Public GuardarEditar As Integer
    Dim campopk As String
    Dim cedula As Integer
    Dim campof, campo2 As String
    Dim cajas_vacias As New Class_validacion
    Dim estado As String = "ACTIVO"

    Sub ActivarCajaTexto()
        Me.txt_nomb.Enabled = True
        Me.dtm_feve.Enabled = True
        Me.cbb_tipo.Enabled = True
        Me.txt_clav.Enabled = True
        Me.cbb_esta.Enabled = True
        Me.txt_obse.Enabled = True
    End Sub
    Sub DesactivarCajaTexto()
        Me.txt_nomb.Enabled = False
        Me.dtm_feve.Enabled = False
        Me.cbb_tipo.Enabled = False
        Me.txt_clav.Enabled = False
        Me.cbb_esta.Enabled = False
        Me.txt_obse.Enabled = False
    End Sub
    Sub LimpiarCajaTexto()
        Me.txt_nomb.Text = ""
        Me.dtm_feve.Text = Date.Today
        Me.cbb_tipo.Text = ""
        Me.txt_clav.Text = ""
        Me.cbb_esta.Text = ""
        Me.txt_obse.Text = ""
    End Sub
    Sub ActivarBotones()
        Me.BN_CANCELAR.Enabled = True
        Me.BN_GUARDAR.Enabled = True
        BN_NUEVO.Enabled = False
        BN_SALIR.Enabled = False
        BN_EDITAR.Enabled = False
    End Sub
    Sub DesactivarBotones()
        Me.BN_CANCELAR.Enabled = False
        Me.BN_GUARDAR.Enabled = False
        BN_NUEVO.Enabled = True
        BN_SALIR.Enabled = True
        BN_EDITAR.Enabled = True
    End Sub
    Sub EtiquetasDGV()
        Me.DGV_ADMUSU.Columns(0).HeaderText = "CODIGO"
        Me.DGV_ADMUSU.Columns(0).Visible = False
        Me.DGV_ADMUSU.Columns(1).HeaderText = "NOMBRE"
        Me.DGV_ADMUSU.Columns(2).HeaderText = "FECHA VENCIMIENTO"
        Me.DGV_ADMUSU.Columns(3).HeaderText = "TIPO"
        Me.DGV_ADMUSU.Columns(4).HeaderText = "CLAVE"
        Me.DGV_ADMUSU.Columns(5).HeaderText = "ESTADO"
        Me.DGV_ADMUSU.Columns(6).HeaderText = "OBSERVACION"
    End Sub
    Sub mostrar_dgv()
        Me.txt_nomb.Text = dt_apod.Rows(0).Item(1).ToString
        Me.dtm_feve.Text = dt_apod.Rows(0).Item(2).ToString
        Me.cbb_tipo.Text = dt_apod.Rows(0).Item(3).ToString
        Me.txt_clav.Text = dt_apod.Rows(0).Item(4).ToString
        Me.cbb_esta.Text = dt_apod.Rows(0).Item(5).ToString
        Me.txt_obse.Text = dt_apod.Rows(0).Item(6).ToString
    End Sub
    Sub EstiloDataGrid()
        Me.DGV_ADMUSU.DefaultCellStyle.Font = New Font("Arial", 9)
        Me.DGV_ADMUSU.DefaultCellStyle.ForeColor = Color.Blue
        Me.DGV_ADMUSU.DefaultCellStyle.BackColor = Color.Beige
        Me.DGV_ADMUSU.DefaultCellStyle.SelectionForeColor = Color.Yellow
        Me.DGV_ADMUSU.DefaultCellStyle.SelectionBackColor = Color.Red
    End Sub
    Sub MAYUSCULAS()
        Me.txt_nomb.CharacterCasing = CharacterCasing.Upper
        Me.txt_obse.CharacterCasing = CharacterCasing.Upper
    End Sub
    Sub Consulta_SGBD()
        Me.DGV_ADMUSU.DataSource = consulta_Sql.Consulta_General("Vista_Usuario")
    End Sub

    Private Sub Form_AdminUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EstiloDataGrid()
        Me.Consulta_SGBD()
        Me.EtiquetasDGV()
        'Me.EtiquetasDGV()
        'Me.llenar_tipo()
        Me.MAYUSCULAS()
        Me.DGV_ADMUSU.ClearSelection()
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        Me.LimpiarCajaTexto()
        Me.ActivarCajaTexto()
        Me.ActivarBotones()
        Me.txt_nomb.Focus()
        GuardarEditar = 2
        Me.cbb_esta.Enabled = False
    End Sub

    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        If txt_clav.Text = Nothing And dtm_feve.Text = Nothing And cbb_tipo.Text = Nothing Or txt_clav.Text = Nothing And cbb_esta.Text = Nothing And txt_obse.Text = Nothing Then
            MsgBox("Ingresar Datos Faltantes")
            Me.txt_nomb.Focus()
        Else
            If GuardarEditar <> 1 Then
                campoc = "CEUSUA_NOMBRE,CEUSUA_FECHAX,CEUSUA_TIPOXX,CEUSUA_CLAVE,CEUSUA_ESTADO,CEUSUA_OBSERV"
                valoresc = " '" & Me.txt_nomb.Text & "','" & FormatDateTime(Me.dtm_feve.Text) & "','" & Me.cbb_tipo.Text & "', ENCRYPTBYPASSPHRASE('SISOTEC','" & Me.txt_clav.Text & "'),'" & estado & "','" & txt_obse.Text & "' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEUSUA_USUARIO")
                campopk = "CEUSUA_NOMBRE"
            Else
                campopk = "CEUSUA_CODIGO"
                campoc = " CEUSUA_NOMBRE  = '" + Trim(Me.txt_nomb.Text) + "' ,"
                campoc += " CEUSUA_FECHAX  = '" + Trim(Me.dtm_feve.Text) + "' ,"
                campoc += " CEUSUA_TIPOXX  = '" + Trim(Me.cbb_tipo.Text) + "' ,"
                campoc += " CEUSUA_CLAVE  = ENCRYPTBYPASSPHRASE('SISOTEC','" + Trim(Me.txt_clav.Text) + "') ,"
                campoc += " CEUSUA_ESTADO  = '" + Trim(Me.cbb_esta.Text) + "' ,"
                campoc += " CEUSUA_OBSERV = '" + Trim(Me.txt_obse.Text) + "' "
                consulta_Sql.Consulta_Actualizar("CEUSUA_USUARIO", campoc, "", campopk, codigodvg)
            End If
            Me.Consulta_SGBD()
            Me.LimpiarCajaTexto()
            Me.DesactivarCajaTexto()
            Me.DesactivarBotones()
            DGV_ADMUSU.ClearSelection()
        End If
    End Sub

    Private Sub BN_EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_EDITAR.Click

        If txt_clav.Text = Nothing And dtm_feve.Text = Nothing And cbb_tipo.Text = Nothing Or txt_clav.Text = Nothing And cbb_esta.Text = Nothing And txt_obse.Text = Nothing Then
            MsgBox("Seleccion la fila que desee editar")
        Else
            ActivarCajaTexto()
            Me.ActivarBotones()
            estado = Me.cbb_esta.Text
            Me.cbb_esta.Enabled = True
            Me.txt_nomb.Focus()
            GuardarEditar = 1
        End If
        Consulta_SGBD()
        DGV_ADMUSU.ClearSelection()
    End Sub

    Private Sub BN_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_CANCELAR.Click
        Me.LimpiarCajaTexto()
        Me.DesactivarCajaTexto()
        Me.DesactivarBotones()
    End Sub

    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_SALIR.Click
        Me.Close()
    End Sub

    Private Sub DGV_ADMUSU_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_ADMUSU.CellClick
        Dim fila As Byte = CByte(Me.DGV_ADMUSU.CurrentCell.RowIndex)
        codigodvg = (Me.DGV_ADMUSU.Rows(fila).Cells(0).Value)
        dt_apod = consulta_Sql.Consulta_Individual("Vista_Usuario", "CEUSUA_CODIGO", codigodvg)
        Me.mostrar_dgv()
    End Sub

End Class