Imports MySql.Data.MySqlClient
Module MySQL_Conn
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet
    Public dt As DataTable

    Public cs As String

    'Server Configuration
    Public datasource As String = "127.0.0.1"
    Public database As String = "rpitst"
    Public user_ID As String = "root"
    Public pwd As String = ""



End Module
