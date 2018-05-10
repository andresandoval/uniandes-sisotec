Public Class Form_Demandado
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
    Sub ActivarCajaTexto()
        Me.txt_cedu.Enabled = True
        Me.txt_nomb.Enabled = True
        Me.txt_apel.Enabled = True
        Me.dtm_fena.Enabled = True
        Me.txt_edad.Enabled = True
        Me.txt_ocup.Enabled = True
        Me.cbb_gene.Enabled = True
        Me.cbb_esci.Enabled = True
        Me.txt_domi.Enabled = True
        Me.txt_pare.Enabled = True
        Me.txt_tele.Enabled = True
        Me.txt_niin.Enabled = True
        Me.txt_ning.Enabled = True
        Me.txt_meap.Enabled = True
        Me.txt_inac.Enabled = True
        Me.cbb_tipo.Enabled = True
    End Sub
    Sub DesactivarCajaTexto()
        Me.txt_cedu.Enabled = False
        Me.txt_nomb.Enabled = False
        Me.txt_apel.Enabled = False
        Me.dtm_fena.Enabled = False
        Me.txt_edad.Enabled = False
        Me.txt_ocup.Enabled = False
        Me.cbb_gene.Enabled = False
        Me.cbb_esci.Enabled = False
        Me.txt_domi.Enabled = False
        Me.txt_pare.Enabled = False
        Me.txt_tele.Enabled = False
        Me.txt_niin.Enabled = False
        Me.txt_ning.Enabled = False
        Me.txt_meap.Enabled = False
        Me.txt_inac.Enabled = False
        Me.cbb_tipo.Enabled = False
    End Sub
    Sub LimpiarCajaTexto()
        Me.txt_cedu.Text = ""
        Me.txt_nomb.Text = ""
        Me.txt_apel.Text = ""
        Me.dtm_fena.Text = Date.Today
        Me.txt_edad.Text = ""
        Me.txt_ocup.Text = ""
        Me.cbb_gene.Text = ""
        Me.cbb_esci.Text = ""
        Me.txt_domi.Text = ""
        Me.txt_pare.Text = ""
        Me.txt_tele.Text = ""
        Me.txt_niin.Text = ""
        Me.txt_ning.Text = ""
        Me.txt_meap.Text = ""
        Me.txt_inac.Text = ""
        Me.cbb_tipo.Text = ""

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
        Me.DGV_PERSONA.Columns(0).HeaderText = "CODIGO"
        Me.DGV_PERSONA.Columns(0).Visible = False
        Me.DGV_PERSONA.Columns(1).HeaderText = "NOMBRES"
        Me.DGV_PERSONA.Columns(2).HeaderText = "APELLIDOS"
        Me.DGV_PERSONA.Columns(3).HeaderText = "FECHA NACIMIENTO"
        Me.DGV_PERSONA.Columns(4).HeaderText = "EDAD"
        Me.DGV_PERSONA.Columns(5).HeaderText = "OCUPACION"
        Me.DGV_PERSONA.Columns(6).HeaderText = "GENERO"
        Me.DGV_PERSONA.Columns(7).HeaderText = "ESTADO CIVIL"
        Me.DGV_PERSONA.Columns(8).HeaderText = "DOMICILIO"
    End Sub
    Sub mostrar_dgv()
        Me.txt_cedu.Text = dt_apod.Rows(0).Item(0).ToString
        Me.txt_nomb.Text = dt_apod.Rows(0).Item(1).ToString
        Me.txt_apel.Text = dt_apod.Rows(0).Item(2).ToString
        Me.dtm_fena.Text = dt_apod.Rows(0).Item(3).ToString
        Me.txt_edad.Text = dt_apod.Rows(0).Item(4).ToString
        Me.txt_ocup.Text = dt_apod.Rows(0).Item(5).ToString
        Me.cbb_gene.Text = dt_apod.Rows(0).Item(6).ToString
        Me.cbb_esci.Text = dt_apod.Rows(0).Item(7).ToString
        Me.txt_domi.Text = dt_apod.Rows(0).Item(8).ToString
        'Me.txt_pare.Text = dt_apod.Rows(0).Item(9).ToString
        'Me.txt_tele.Text = dt_apod.Rows(0).Item(11).ToString
        'Me.txt_niin.Text = dt_apod.Rows(0).Item(12).ToString
        'Me.txt_ning.Text = dt_apod.Rows(0).Item(13).ToString
        'Me.txt_meap.Text = dt_apod.Rows(0).Item(14).ToString
        'Me.txt_inac.Text = dt_apod.Rows(0).Item(15).ToString
        'Me.cbb_tipo.Text = dt_apod.Rows(0).Item(16).ToString
    End Sub
    Sub Consulta_SGBD()
        Me.DGV_PERSONA.DataSource = consulta_Sql.Consulta_General("Vista_Demandados")
    End Sub

    'Private Sub llenar_tipo()
    '    Me.cbb_tipo.DataSource = consulta_Sql.Consulta_General("Vista_Tipo")
    '    Me.cbb_tipo.DisplayMember = "CEPERS_TIPOXX"
    '    'Me.cbb_tipo.ValueMember = "CEPERS_CODIGO"
    'End Sub
    Sub EstiloDataGrid()
        Me.DGV_PERSONA.DefaultCellStyle.Font = New Font("Arial", 9)
        Me.DGV_PERSONA.DefaultCellStyle.ForeColor = Color.Blue
        Me.DGV_PERSONA.DefaultCellStyle.BackColor = Color.Beige
        Me.DGV_PERSONA.DefaultCellStyle.SelectionForeColor = Color.Yellow
        Me.DGV_PERSONA.DefaultCellStyle.SelectionBackColor = Color.Red
    End Sub
    Sub MAYUSCULAS()
        Me.txt_nomb.CharacterCasing = CharacterCasing.Upper
        Me.txt_apel.CharacterCasing = CharacterCasing.Upper
        Me.txt_ocup.CharacterCasing = CharacterCasing.Upper
        Me.txt_domi.CharacterCasing = CharacterCasing.Upper
        Me.txt_pare.CharacterCasing = CharacterCasing.Upper
        Me.txt_niin.CharacterCasing = CharacterCasing.Upper
        Me.txt_meap.CharacterCasing = CharacterCasing.Upper
        Me.txt_inac.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Form_SujetoDerechos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.EstiloDataGrid()
        Me.Consulta_SGBD()
        Me.EtiquetasDGV()
        'Me.EtiquetasDGV()
        'Me.llenar_tipo()
        Me.MAYUSCULAS()
        Me.DGV_PERSONA.ClearSelection()
    End Sub

    Private Sub BN_NUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_NUEVO.Click
        Me.LimpiarCajaTexto()
        Me.ActivarCajaTexto()
        Me.ActivarBotones()
        Me.txt_nomb.Focus()
        GuardarEditar = 2
    End Sub
    Private Sub BN_GUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_GUARDAR.Click
        If txt_cedu.Text = Nothing And txt_nomb.Text = Nothing And txt_apel.Text = Nothing Or dtm_fena.Text = Nothing And txt_edad.Text = Nothing And txt_ocup.Text = Nothing And cbb_gene.Text = Nothing And cbb_esci.Text = Nothing And txt_domi.Text = Nothing And txt_pare.Text = Nothing And txt_tele.Text = Nothing And txt_niin.Text = Nothing And txt_ning.Text = Nothing And txt_meap.Text = Nothing And txt_inac.Text = Nothing And cbb_tipo.Text = Nothing Then
            MsgBox("Ingresar Datos Faltantes")
            Me.txt_nomb.Focus()
        Else
            If GuardarEditar <> 1 Then
                campoc = "CEPERS_DOCIDE,CEPERS_NOMBRE,CEPERS_APELLI,CEPERS_FECNAC,CEPERS_EDADXX,CEPERS_OCUPAC,CEPERS_GENERO,CEPERS_ESTCIV,CEPERS_DOMICI,CEPERS_PARENT,CEPERS_TELEFO,CEPERS_NIVINS,CEPERS_NIVING,CEPERS_METAPL,CEPERS_INSACO,CEPERS_TIPOXX"
                valoresc = " '" & Me.txt_cedu.Text & "','" & Me.txt_nomb.Text & "','" & Me.txt_apel.Text & "','" & FormatDateTime(Me.dtm_fena.Text) & "','" & txt_edad.Text & "','" & txt_ocup.Text & "','" & cbb_gene.Text & "','" & cbb_esci.Text & "','" & txt_domi.Text & "','" & txt_pare.Text & "','" & txt_tele.Text & "','" & txt_niin.Text & "','" & txt_ning.Text & "','" & txt_meap.Text & "','" & txt_inac.Text & "','" & "DEMANADADO" & "' "
                consulta_Sql.Insertar_Informacion(campoc, valoresc, "CEPERS_PERSONA")
                campopk = "CEPERS_DOCIDE"
            Else
                campopk = "CEPERS_CODIGO"
                campoc = " CEPERS_DOCIDE  = '" + Trim(Me.txt_cedu.Text) + "' ,"
                campoc += " CEPERS_NOMBRE  = '" + Trim(Me.txt_nomb.Text) + "' ,"
                campoc += " CEPERS_APELLI  = '" + Trim(Me.txt_apel.Text) + "' ,"
                campoc += " CEPERS_FECNAC  = '" + Trim(Me.dtm_fena.Text) + "' ,"
                campoc += " CEPERS_EDADXX  = '" + Trim(Me.txt_edad.Text) + "' ,"
                campoc += " CEPERS_OCUPAC  = '" + Trim(Me.txt_ocup.Text) + "' ,"
                campoc += " CEPERS_GENERO  = '" + Trim(Me.cbb_gene.Text) + "' ,"
                campoc += " CEPERS_ESTCIV  = '" + Trim(Me.cbb_esci.Text) + "' ,"
                campoc += " CEPERS_DOMICI  = '" + Trim(Me.txt_domi.Text) + "' ,"
                campoc += " CEPERS_PARENT  = '" + Trim(Me.txt_pare.Text) + "' ,"
                campoc += " CEPERS_TELEFO  = '" + Trim(Me.txt_tele.Text) + "' ,"
                campoc += " CEPERS_NIVINS  = '" + Trim(Me.txt_niin.Text) + "' ,"
                campoc += " CEPERS_NIVING  = '" + Trim(Me.txt_ning.Text) + "' ,"
                campoc += " CEPERS_METAPL  = '" + Trim(Me.txt_meap.Text) + "' ,"
                campoc += " CEPERS_INSACO  = '" + Trim(Me.txt_inac.Text) + "' ,"
                campoc += " CEPERS_TIPOXX = '" + Trim(Me.cbb_tipo.Text) + "' "
                consulta_Sql.Consulta_Actualizar("CEPERS_PERSONA", campoc, "", campopk, codigodvg)
            End If
            Me.Consulta_SGBD()
            Me.LimpiarCajaTexto()
            Me.DesactivarCajaTexto()
            Me.DesactivarBotones()
            'Me.llenar_tipo()
            DGV_PERSONA.ClearSelection()
        End If

    End Sub

    Private Sub BN_EDITAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_EDITAR.Click

        If txt_cedu.Text = Nothing And txt_nomb.Text = Nothing And txt_apel.Text = Nothing Or dtm_fena.Text = Nothing And txt_edad.Text = Nothing And txt_ocup.Text = Nothing And cbb_gene.Text = Nothing And cbb_esci.Text = Nothing And txt_domi.Text = Nothing And txt_pare.Text = Nothing And txt_tele.Text = Nothing And txt_niin.Text = Nothing And txt_ning.Text = Nothing And txt_meap.Text = Nothing And txt_inac.Text = Nothing And cbb_tipo.Text = Nothing Then
            MsgBox("Seleccion la fila que desee editar")
        Else
            ActivarCajaTexto()
            Me.ActivarBotones()
            Me.cbb_tipo.Text = "DEMANADADO"
            Me.txt_nomb.Focus()
            GuardarEditar = 1
        End If
        Consulta_SGBD()
        DGV_PERSONA.ClearSelection()
    End Sub

    Private Sub BN_CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_CANCELAR.Click
        Me.LimpiarCajaTexto()
        Me.DesactivarCajaTexto()
        Me.DesactivarBotones()
    End Sub
    Private Sub BN_SALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BN_SALIR.Click
        Me.Close()

    End Sub

    Private Sub DGV_PERSONA_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_PERSONA.CellClick
        Dim fila As Byte = CByte(Me.DGV_PERSONA.CurrentCell.RowIndex)
        codigodvg = (Me.DGV_PERSONA.Rows(fila).Cells(0).Value)
        dt_apod = consulta_Sql.Consulta_Individual("Vista_Demandados", "CEPERS_CODIGO", codigodvg)
        Me.mostrar_dgv()
    End Sub

    Private Sub txt_nomb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nomb.KeyPress
        validacion.solo_letras(Me.txt_nomb.Text, e)
        Me.txt_nomb.MaxLength = 60
        validacion.salto(Me.txt_nomb, Me.txt_apel, e)
    End Sub

    Private Sub txt_apel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apel.KeyPress
        validacion.solo_letras(Me.txt_apel.Text, e)
        Me.txt_nomb.MaxLength = 60
        validacion.salto3(txt_apel, dtm_fena, e)
    End Sub

    Private Sub dtm_fena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtm_fena.KeyPress
        validacion.salto(dtm_fena, txt_edad, e)
    End Sub

    Private Sub txt_edad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_edad.KeyPress
        validacion.solo_numeros(Me.txt_edad.Text, e)
        Me.txt_nomb.MaxLength = 3
        validacion.salto(txt_edad, txt_ocup, e)
    End Sub

    Private Sub txt_ocup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ocup.KeyPress
        validacion.solo_letras(Me.txt_ocup.Text, e)
        Me.txt_nomb.MaxLength = 60
        Me.validacion.salto2(txt_ocup, cbb_gene, e)
    End Sub

    Private Sub cbb_gene_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbb_gene.GotFocus
        cbb_gene.DroppedDown = True
    End Sub

    Private Sub cbb_gene_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbb_gene.KeyPress
        validacion.salto2(cbb_gene, cbb_esci, e)
    End Sub

    Private Sub cbb_esci_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbb_esci.GotFocus
        cbb_esci.DroppedDown = True
    End Sub

    Private Sub cbb_esci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbb_esci.KeyPress
        validacion.salto(cbb_esci, txt_domi, e)
    End Sub

End Class