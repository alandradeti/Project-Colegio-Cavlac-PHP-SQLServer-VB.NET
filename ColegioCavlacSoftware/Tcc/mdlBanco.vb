Module mdlBanco
    Public cnn As New SqlClient.SqlConnection

    Public strSql As String


    '-- Login --'
    Public id As String
    Public TipoUsu As String
    Public ano

    Sub MasterAno()
        strSql = "select ano from TB_MASTER "

        Dim cmdAno As New SqlClient.SqlCommand(strSql, cnn)
        ano = cmdAno.ExecuteScalar()
    End Sub

End Module
