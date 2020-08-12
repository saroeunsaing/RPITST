Imports MySql.Data.MySqlClient
Public MustInherit Class MySQL_Com

    Public Sub New()
        cs = "Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd
    End Sub
    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(cs)
    End Function

End Class
