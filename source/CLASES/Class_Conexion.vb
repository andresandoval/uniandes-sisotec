Imports System.Data             'importar la clase ADO para administrar y acceder a la BDD
Imports System.Data.SqlClient
Public Class Class_Conexion
    'Generar la cadena conexión
    Public Function generar_conexion(ByVal usuario As String, ByVal clave As String) As String
        Dim csb As New SqlConnectionStringBuilder 'crear una variable para guardar el resultado de tipo string
        csb.DataSource = serv 'Asignando valores a las variables servidor,usuario,clave
        csb.UserID = usuario
        csb.Password = clave

        Return csb.ConnectionString 'devuelve el resultado a la función (String)
    End Function

    'Validar si los datos son correctos
    Public Function validar_conexion(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim conexion As New SqlConnection(generar_conexion(usuario, clave))
        Try
            conexion.Open() 'Realiza la conexión
            MessageBox.Show("Conexión con el servidor SQLServer Correcta.... ")
            Return True
        Catch ex As SqlException
            'MessageBox.Show(ex.Number) 'Muestra el número de posible error
            'MessageBox.Show(ex.Message) 'Muestra el mensaje
            If ex.Number = 18456 Then
                MessageBox.Show("EL usuario ó la contraseña son incorrectos....")
            End If
            If ex.Number = 53 Then
                MessageBox.Show("Nombre del Servidor SQLServer incorrecto....")
            End If
            Return False
        Finally
            conexion.Close() 'Finaliza la conexión
        End Try
    End Function
End Class
