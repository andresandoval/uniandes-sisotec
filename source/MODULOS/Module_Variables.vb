Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Module Module_Variables
    'SISTEMA_JUDI BDD
    Public usuariosistema As String = "Admin"
    Public rangousuario As String = "Adinistrador"

    Public config As System.Configuration.Configuration = _
            ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)

    Public connectionStringsSection As ConnectionStringsSection = _
        DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)




    Dim config2 As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Dim csSection As ConnectionStringsSection = config.ConnectionStrings

    Dim confiStr As New ConnectionStringSettings

    'SISTEMA_JUDI BDD
    Public usua As String = "sa" 'declara una variable y almacena el usuario
    Public clav As String = "0994511771" 'declara una variable y almacena la contraseña
    Public serv As String = "DIEGO" 'declara una variable y almacena el nombre del servidor
    Dim CadenaConexion As String
    Public usuariopersona As String = ""
    Dim appconfig As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)



    Public Function Connection() As SqlConnection
        Return New SqlConnection("Data Source=" + serv + ";Initial Catalog=JUDICATURA1;User ID=" + usua + ";Password=" + clav + "")




        CadenaConexion = ConfigurationManager.ConnectionStrings("JUDICATURA.My.MySettings.JUDICATURA1ConnectionString").ConnectionString
        appconfig.ConnectionStrings.ConnectionStrings("JUDICATURA.My.MySettings.JUDICATURA1ConnectionString").ConnectionString = "Data Source=" + serv + ";Initial Catalog=JUDICATURA1;User ID=" + usua + ";Password=" + clav + ""
        appconfig.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Function



End Module
