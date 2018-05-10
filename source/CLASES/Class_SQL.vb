Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Xml
Imports System
Imports System.Web

Imports System.Collections
Imports System.Reflection
Imports System.Diagnostics

Public Enum ConfigFileType
    WebConfig
    AppConfig
End Enum
Public Class Class_SQL
    Inherits System.Configuration.AppSettingsReader

    Public docName As String = String.Empty
    Private node As XmlNode = Nothing
    Private _configType As Integer
    Dim clase_conexion As New Class_Conexion 'creando una varable que puede utilizar las funciones que se encuentren en la class_conexion
    'declarar una variable para la conexion

    Public Sub Abrir_Conexion() 'Realizar la conexión
           conexion.Open() 'abriendo la conexion
    End Sub

    Public Sub Cerrar_Conexion() 'Finaliza la conexión
        conexion.Close()
    End Sub

    Public Sub Insertar_Informacion(ByVal campos As String, ByVal valores As String, ByVal tabla As String)
        Dim ds As New DataSet
        Dim consulta_sql As String
        consulta_sql = "insert into " & tabla & " (" & campos & ") values (" & valores & ")"
        REM  MsgBox(consulta_sql)
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        Me.Cerrar_Conexion()
    End Sub

    Public Sub eliminar_Informacion(ByVal campos As String, ByVal valores As String, ByVal tabla As String)
        Dim ds As New DataSet
        Dim consulta_sql As String
        consulta_sql = " DELETE FROM " & tabla & " where " & campos & "=" & valores & ""
        REM  MsgBox(consulta_sql)
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        Me.Cerrar_Conexion()
    End Sub

    Public Function Consulta_Generalmax(ByVal tabla As String, ByVal campos As String, ByVal campo As String) As DataTable
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        Dim consulta_sql As String



        consulta_sql = "insert into " & tabla & " (" & campos & ") values ('')"
        REM  MsgBox(consulta_sql)
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        Me.Cerrar_Conexion()



        consulta_sql = "select max(" & campo & ") AS d from  " & tabla
        Me.Abrir_Conexion()
        Dim da1 As New SqlDataAdapter(consulta_sql, conexion)
        da1.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function


    'Public Function Consulta_General1(ByVal tabla As String) As DataTable
    '    Dim ds As New DataSet
    '    Dim dt As New DataTable
    '    Dim consulta_sql As String
    '    consulta_sql = "select * from " & tabla
    '    Me.Abrir_Conexion()
    '    Dim da As New SqlDataAdapter(consulta_sql, conexion)
    '    da.Fill(ds, tabla)
    '    dt = ds.Tables(tabla)
    '    Me.Cerrar_Conexion()
    '    Return dt
    'End Function
    Public Function Consulta_General(ByVal tabla As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from " & tabla
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function


    Public Function Consulta_Individual(ByVal tabla As String, ByVal campo As String, ByVal validacion As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from " & tabla & " where " & campo & "=" & validacion
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function

    Public Function Consulta_Filtro(ByVal tabla As String, ByVal campo As String, ByVal campo2 As String, ByVal texto As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from " & tabla & " where " & campo & " like '" & texto & "%'" & " OR " & campo2 & " like '" & texto & "%'"
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function




    Public Function Consulta_Usuario(ByVal usuario As String, ByVal clave As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from  CEUSUA_USUARIO where CEUSUA_NOMBRE='" & usuario & "'-- and  DECRYPTBYPASSPHRASE('SISOTEC',CEUSUA_CLAVE)='" & clave & "'"
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, "CEUSUA_USUARIO")
        dt = ds.Tables("CEUSUA_USUARIO")
        Me.Cerrar_Conexion()
        Return dt
    End Function


    Public Function Consulta_Filtro2(ByVal tabla As String, ByVal campo As String, ByVal texto As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from " & tabla & " where " & campo & " = '" & texto & "'" & ""
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function

    Public Function Consulta_Filtro3(ByVal tabla As String, ByVal texto As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select * from " & tabla & " " & texto & ""
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function


    Public Function Consulta_max(ByVal tabla As String, ByVal texto As String) As DataTable
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim consulta_sql As String
        consulta_sql = "select max(" & texto & ") from " & tabla & " "
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        dt = ds.Tables(tabla)
        Me.Cerrar_Conexion()
        Return dt
    End Function
    'Public Sub Consulta_Actualizar(ByVal vtabla As String, ByVal vcampo As String, ByVal vcampo2 As String, ByVal condicion As String)
    '    Dim ds As New DataSet
    '    Dim consulta_sql As String
    '    consulta_sql = "Update " & vtabla & " set " & vcampo & " where " & vcampo2 & "=" & condicion
    '    Me.Abrir_Conexion()
    '    Dim da As New SqlDataAdapter(consulta_sql, conexion)
    '    da.Fill(ds, vtabla)
    '    Me.Cerrar_Conexion()
    'End Sub
    Public Sub Consulta_Actualizar(ByVal tabla As String, ByVal campo As String, ByVal valores As String, ByVal campopk As String, ByVal codigo As Integer)
        Dim ds As New DataSet
        Dim consulta_sql As String = "update " + tabla + " set " + campo + " Where " + campopk + " = " & codigo
        MsgBox("Registro Modificado", MsgBoxStyle.Information)
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, tabla)
        Me.Cerrar_Conexion()
    End Sub


    Public Sub Consulta_Actualizar_Informe()
        Dim ds As New DataSet
        Dim consulta_sql As String = "update CEINFO_INFORME set CEINFO_ESTADO='FINALIZADO' , CEINFO_ESTADOSISTEMA='SI' Where CEINFO_ESTADO='PENDIENTE' and CEINFO_FECFIN<{ fn NOW()} "

        'MsgBox("INFORMES FINALIZADOS POR EL SISTEMA")
        Me.Abrir_Conexion()
        Dim da As New SqlDataAdapter(consulta_sql, conexion)
        da.Fill(ds, "CEINFO_INFORME")
        Me.Cerrar_Conexion()
    End Sub
    Public Function Consulta_Usuarios_Sql(ByVal nombre As String, ByVal clave As String, ByRef tipo As String) As Boolean
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim sql As String
        sql = "select * from CEUSUA_USUARIO where CEUSUA_NOMBRE='" & nombre & "' and CEUSUA_CLAVE='" & clave & "'"
        conexion.Open()
        Dim da As New SqlDataAdapter(sql, conexion)
        da.Fill(ds, "CEUSUA_USUARIO")
        dt = ds.Tables("CEUSUA_USUARIO")
        conexion.Close()
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function























    Public Property ConfigType() As Integer
        Get
            Return _configType
        End Get
        Set(ByVal Value As Integer)
            _configType = Value
        End Set
    End Property

    

    Private Sub saveConfigDoc(ByVal cfgDoc As XmlDocument, ByVal cfgDocPath As String)
        Try
            Dim writer As XmlTextWriter = New XmlTextWriter(cfgDocPath, Nothing)
            writer.Formatting = Formatting.Indented
            cfgDoc.WriteTo(writer)
            writer.Flush()
            writer.Close()
            Return
        Catch
            Throw
        End Try
    End Sub

   

    
End Class
