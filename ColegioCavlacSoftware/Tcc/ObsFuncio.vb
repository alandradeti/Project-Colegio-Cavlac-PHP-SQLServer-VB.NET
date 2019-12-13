Module ObsFuncio
    Sub load()
        Call limparAlunos()

        AlunoObs.txtTurma.Text = "Digite a turma"
        AlunoObs.txtTurma.ForeColor = Color.LightSteelBlue

        AlunoObs.cmbPeriodo.Items.Add("---")
        AlunoObs.cmbPeriodo.Items.Add("MANHÃ")
        AlunoObs.cmbPeriodo.Items.Add("TARDE")
        AlunoObs.cmbPeriodo.Items.Add("NOITE")

        AlunoObs.cmbPeriodo.SelectedIndex = 0
        AlunoObs.cmbPeriodo.ForeColor = Color.LightSteelBlue
    End Sub

    Sub limparAlunos()
        AlunoObs.txtNomeAluno.Text = "Digite o nome"
        AlunoObs.txtNomeAluno.ForeColor = Color.LightSteelBlue
        AlunoObs.txtMatricula.Text = ""

        strSql = "select ano from tb_master"
        Dim cmdAno As New SqlClient.SqlCommand
        cmdAno.Connection = cnn
        cmdAno.CommandText = strSql
        Dim ano As String = cmdAno.ExecuteScalar()

        strSql = "SELECT TB_NOTIFICACOES.notificacao, TB_NOTIFICACOES.data, TB_NOTIFICACOES.id_noti" & vbNewLine &
                 "From TB_NOTIFICACOES INNER Join" & vbNewLine &
                 "TB_USUARIO ON TB_NOTIFICACOES.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                 "Where (TB_USUARIO.id_usuario = 0)"

        Dim cmdObs As New SqlClient.SqlCommand(strSql, cnn)
        Dim daObs As New SqlClient.SqlDataAdapter(cmdObs)
        Dim tblObs As New DataTable
        daObs.Fill(tblObs)

        AlunoObs.dgvObs.DataSource = tblObs
    End Sub

    Sub limparTurmas()
        AlunoObs.txtTurma.Text = "Digite a turma"
        AlunoObs.txtTurma.ForeColor = Color.LightSteelBlue
        AlunoObs.cmbPeriodo.SelectedIndex = 0
        AlunoObs.cmbPeriodo.ForeColor = Color.LightSteelBlue
    End Sub

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890,.", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
        End Select
    End Function

End Module
