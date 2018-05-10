Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module Module_ds
    Public conexion As New SqlConnection("Data Source=" + serv + ";Initial Catalog=JUDICATURA1;User ID=" + usua + ";Password=" + clav + "") 'enviando los valores del usuario y la clave
    Public ds As New DataSet()
    Public ta As New SqlDataAdapter
    Public bs As New BindingSource

    Public ta2 As New SqlDataAdapter
    Public bs2 As New BindingSource
    Public bs_v2 As New BindingSource

    Public tabla2 As String = "CEPERS_PERSONA"
    Public vista2 As String = "Vista_Usuarios"


    Public tabla As String = "CEPERS_PERSONA"
    Public vista As String = "Vista_Usuarios"
    Public bs_v As New BindingSource
    Public horav As String = ""
    Public tecnicov As Integer = 0
    Public fechav As String = ""
    Public codigonoti As Integer = 0
    Public codigoinfo As Integer = 0
    Public codigopersona As Integer = 0



   

    Public Function tab(ByVal tablas As String) As SqlDataAdapter

        Dim bs_b As New BindingSource

        Dim querySql As String = "SELECT * FROM " & tablas

        Dim ta_b As SqlDataAdapter = New SqlDataAdapter(querySql, conexion)




        Return ta_b
    End Function



    Public Function tab2(ByVal tablas As String) As SqlDataAdapter

        Dim bs_b As New BindingSource

        Dim querySql As String = "SELECT * FROM " & tablas

        Dim ta_b As SqlDataAdapter = New SqlDataAdapter(querySql, conexion)




        Return ta_b
    End Function
    Public Function tab_SqlCommandBuilder(ByVal ta_b As SqlDataAdapter) As SqlDataAdapter
        conexion.Open()
        Dim cb As New SqlCommandBuilder(ta)

        ta_b.InsertCommand = cb.GetInsertCommand()
        ta_b.UpdateCommand = cb.GetUpdateCommand()
        ta_b.DeleteCommand = cb.GetDeleteCommand()

        conexion.Close()
        Return ta_b
    End Function

    Public Function tab_SqlCommandBuilder2(ByVal ta_b As SqlDataAdapter) As SqlDataAdapter
        conexion.Open()
        Dim cb As New SqlCommandBuilder(ta2)

        ta_b.InsertCommand = cb.GetInsertCommand()
        ta_b.UpdateCommand = cb.GetUpdateCommand()
        ta_b.DeleteCommand = cb.GetDeleteCommand()

        conexion.Close()
        Return ta_b
    End Function

    Public Function tab_SqlTransaction(ByVal ta_b As SqlDataAdapter) As SqlDataAdapter

        conexion.Open()
        Dim tran As SqlTransaction = conexion.BeginTransaction
        ta.InsertCommand.Transaction = tran
        ta.UpdateCommand.Transaction = tran
        ta.DeleteCommand.Transaction = tran
        conexion.Close()
        Return ta_b
    End Function


    Public Function tab_SqlTransaction2(ByVal ta_b As SqlDataAdapter) As SqlDataAdapter

        conexion.Open()
        Dim tran As SqlTransaction = conexion.BeginTransaction
        ta2.InsertCommand.Transaction = tran
        ta2.UpdateCommand.Transaction = tran
        ta2.DeleteCommand.Transaction = tran
        conexion.Close()
        Return ta_b
    End Function


    Public Sub bs_bdd()

        'vista = "Vista_Usuarios"
        'tabla = "CEUSUA_USUARIO"









        'vista = "Vista_notificaciones"
        'tabla = "CENOTI_NOTIFICACION"

        'ta_v = tab(vista)
        'ta_v.Fill(ds, vista)



        'ta = tab(tabla)
        'ta.Fill(ds, tabla)


     

    End Sub
End Module
