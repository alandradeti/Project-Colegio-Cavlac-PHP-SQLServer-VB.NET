Public Class conn
    Public Function AbrirConexao(
        Optional ByVal strConexao As String = "",
        Optional ByRef Mensagem As String = "") As _
        SqlClient.SqlConnection

        Dim objCnn As New SqlClient.SqlConnection



        If strConexao.Trim() = "" Then

            strConexao = "DATA SOURCE=(LOCAL);" &
                         "INITIAL CATALOG=BD_TCC;" &
                         "USER ID=sa; PASSWORD=etec;"
        End If

        ' "INTEGRATED SECURITY=SSPI;" & _
        ' "USER ID=DAVI; PASSWORD=123;" & _

        '-- Abrir conexao com Banco de Dados --'

        Try

            objCnn.ConnectionString = strConexao
            objCnn.Open()

        Catch ex As Exception
            '-- Descricao do Erro Ocorrido --'
            Mensagem = Err.Description
        End Try

        Return objCnn

    End Function
End Class
