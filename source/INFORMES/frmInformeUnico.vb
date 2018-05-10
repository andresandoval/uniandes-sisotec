Public Class frmInformeUnico

    Private informeId As Integer

    Public Sub New(ByVal infid As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        Me.informeId = infid
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub loadContent() Handles MyBase.Load
        Try
            Dim source As DataTable
            Dim ds = New informeUnicoDSTableAdapters.VISTAINFORMEUNICOTableAdapter
            Dim dsInformantes = New informeUnicoDSTableAdapters.INFORMANTESTableAdapter
            ds.Connection.ConnectionString = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"
            dsInformantes.Connection.ConnectionString = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"
            Dim taGF As New informeUnicoDSTableAdapters.VISTA_REP_GRUPO_FAMILIARTableAdapter
            taGF.Connection.ConnectionString = "Data Source=DIEGO;Initial Catalog=JUDICATURA1;Persist Security Info=True;User ID=sa;Password=0994511771"
            source = ds.GetData(Me.informeId)
            If (source Is Nothing OrElse source.Rows.Count <= 0) Then
                MsgBox("No se han encontrado datos para mostrar")
                Me.Close()
            End If
            Dim rep As New rptInformeUnico()
            rep.SetDataSource(source)
            Dim source_colateral As DataTable = dsInformantes.GetInfColateral(Me.informeId)
            Dim source_directos As DataTable = dsInformantes.GetInfDirecto(Me.informeId)
            Dim source_gf As DataTable = taGF.GetData(Me.informeId)
            rep.Subreports("inf_col").SetDataSource(source_colateral)
            rep.Subreports("inf_dir").SetDataSource(source_directos)
            rep.Subreports("grupo_familiar").SetDataSource(source_gf)

            Me.CrystalReportViewer1.ReportSource = rep

        Catch ex As Exception
            MsgBox("Ocurrio un error al procesar la transaccion")
            Me.Close()
        End Try
        
    End Sub

End Class