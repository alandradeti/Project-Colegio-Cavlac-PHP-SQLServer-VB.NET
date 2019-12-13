Imports System.Data.SqlClient

Public Class CadastrarTurma

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private strAcao As String = "alterar"
    Private idTurma As String
    Private clickAluno As Integer = 1
    Private clickProf As Integer = 1
    Private idConsAluno As String
    Private idConsProf As String
    Private idAluno As String
    Private idProf As String = "0"
    Private clickMudarAluno As Boolean = True
    Private clickMudarProf As Boolean = True

    Sub consAluno()
        Dim objConsAluno As New frmConsAluno
        objConsAluno.ShowDialog()
        If objConsAluno.confirm = True Then
            txtMatricula.Text = objConsAluno.GetcolIDAluno().ToString
            txtNomeAluno.Text = objConsAluno.GetcolNomeAluno().ToString
            btnAddAluno.Enabled = True
            clickMudarAluno = False
        End If
    End Sub

    Sub consProf()

        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0

        Dim objConsProf As New FrmConsProf
        objConsProf.ShowDialog()
        If objConsProf.confirm = True Then
            txtCod.Text = objConsProf.GetcolIDprof().ToString
            txtNomeProf.Text = objConsProf.GetcolNomeprof().ToString
            btnAddProf.Enabled = True

            strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
                     "From TB_DISCP INNER Join" & vbNewLine &
                     "TB_PROFESSOR_DISCIPLINA ON TB_DISCP.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp INNER JOIN" & vbNewLine &
                     "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                     "WHERE        (TB_USUARIO.id_usuario = @id)"

            Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
            Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
            cmdProf.Parameters.AddWithValue("@id", objConsProf.GetcolIDprof().ToString)
            Dim reader As SqlDataReader = cmdProf.ExecuteReader()

            While reader.Read()
                Dim disc As String
                disc = reader.GetValue(0).ToString
                cmbDisc.Items.Add(disc)
            End While
            reader.Close()
            clickMudarProf = False
            cmbDisc.Enabled = True
        Else
            If txtNomeProf.Text = "Digite o nome" Then
                cmbDisc.Enabled = False
            End If
        End If
    End Sub

    Sub PreencherGridTurma()
        strSql = "Select * From TB_TURMA ORDER BY ano"
        Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
        Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
        Dim tblTurma As New DataTable
        daTurma.Fill(tblTurma)

        dgvTurma.DataSource = tblTurma
    End Sub

    Sub preencherGridAluno()
        strSql = "SELECT        TB_ALUNO.nome_aluno, TB_ALUNO.id_matricula" & vbNewLine &
                 "FROM            TB_ALUNO INNER JOIN" & vbNewLine &
                 "TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula" & vbNewLine &
                 "WHERE(TB_ALUNO_TURMA.id_turma = @id)" & vbNewLine &
                 "ORDER BY TB_ALUNO.nome_aluno"
        Dim cmdAluno As New SqlClient.SqlCommand(strSql, cnn)
        cmdAluno.Parameters.AddWithValue("@id", dgvTurma.CurrentRow.Cells("colIDTurma").Value.ToString)
        Dim daAluno As New SqlClient.SqlDataAdapter(cmdAluno)
        Dim tblAluno As New DataTable
        daAluno.Fill(tblAluno)

        dgvAluno.DataSource = tblAluno
    End Sub

    Sub preencherGridProf()
        strSql = "SELECT TB_USUARIO.id_usuario, TB_USUARIO.nome_usuario, TB_DISCP.disciplina, TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp" & vbNewLine &
                 "From TB_PROFESSOR_DISCIPLINA_TURMA INNER Join" & vbNewLine &
                 "TB_TURMA ON TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = TB_TURMA.id_turma INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA ON TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp INNER JOIN" & vbNewLine &
                 "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE TB_TURMA.id_turma = @id" & vbNewLine &
                 "ORDER BY TB_USUARIO.id_usuario"
        Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
        cmdProf.Parameters.AddWithValue("@id", dgvTurma.CurrentRow.Cells("colIDTurma").Value.ToString)
        Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
        Dim tblProf As New DataTable
        daProf.Fill(tblProf)

        dgvProf.DataSource = tblProf
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub txtTurma_GotFocus(sender As Object, e As EventArgs) Handles txtTurma.GotFocus
        If txtTurma.Text = "Digite a turma" Then
            txtTurma.Text = ""
            txtTurma.ForeColor = Color.Black
            clickAluno = 1
        End If
    End Sub

    Private Sub txtTurma_LostFocus(sender As Object, e As EventArgs) Handles txtTurma.LostFocus
        If txtTurma.Text = "" Then
            txtTurma.Text = "Digite a turma"
            txtTurma.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbAnoTurma_GotFocus(sender As Object, e As EventArgs) Handles mtbAnoTurma.GotFocus, mtbAnoTurma.Click
        If Val(mtbAnoTurma.Text) = 0 Then
            mtbAnoTurma.SelectionStart = 0
        End If
        mtbAnoTurma.ForeColor = Color.Black
        clickAluno = 1
    End Sub

    Private Sub mtbAnoTurma_LostFocus(sender As Object, e As EventArgs) Handles mtbAnoTurma.LostFocus
        If Val(mtbAnoTurma.Text) = 0 Then
            mtbAnoTurma.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtNomeAluno_GotFocus(sender As Object, e As EventArgs) Handles txtNomeAluno.GotFocus
        If txtNomeAluno.Text = "Digite o nome" Then
            txtNomeAluno.Text = ""
            txtNomeAluno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNomeAluno_LostFocus(sender As Object, e As EventArgs) Handles txtNomeAluno.LostFocus
        If txtNomeAluno.Text = "" Then
            txtNomeAluno.Text = "Digite o nome"
            txtNomeAluno.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtNomeProf_GotFocus(sender As Object, e As EventArgs) Handles txtNomeProf.GotFocus
        If txtNomeProf.Text = "Digite o nome" Then
            txtNomeProf.Text = ""
            txtNomeProf.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNomeProf_LostFocus(sender As Object, e As EventArgs) Handles txtNomeProf.LostFocus
        If txtNomeProf.Text = "" Then
            txtNomeProf.Text = "Digite o nome"
            txtNomeProf.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbPeriodo_GotFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.GotFocus, cmbPeriodo.DropDown
        cmbPeriodo.ForeColor = Color.Black
        clickAluno = 1
    End Sub

    Private Sub cmbPeriodo_LostFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.LostFocus
        If cmbPeriodo.SelectedIndex = 0 Then
            cmbPeriodo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
    End Sub

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub CadastrarTurma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TurmasFuncio.load()
        TurmasFuncio.entrada()
        Call TurmasFuncio.limparAluno()
        Call TurmasFuncio.limparProfessor()
        Call TurmasFuncio.limparTurma()
        Call PreencherGridTurma()
        idConsAluno = ""
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Call TurmasFuncio.limparTurma()
        Call TurmasFuncio.novo()
        strAcao = "incluir"
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        Call TurmasFuncio.limparTurma()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar?", "CANCELAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Call TurmasFuncio.limparTurma()
            Call TurmasFuncio.botoes()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        If TurmasFuncio.Gravar() Then
            Dim cmdTurma As New SqlClient.SqlCommand
            If strAcao = "incluir" Then
                strSql = "insert into TB_TURMA values (@turma, @periodo, @ano)"

                cmdTurma.Connection = cnn
                cmdTurma.CommandText = strSql

                cmdTurma.Parameters.AddWithValue("@turma", txtTurma.Text.ToString.ToUpper)
                cmdTurma.Parameters.AddWithValue("@periodo", cmbPeriodo.Text.ToString.ToUpper)
                cmdTurma.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString.ToUpper)
                Try
                    cmdTurma.ExecuteNonQuery()
                    Call PreencherGridTurma()
                    MessageBox.Show("ADICIONADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call TurmasFuncio.entrada()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdTurma.Parameters.Clear()
            Else
                strSql = "update TB_TURMA set turma = @turma , periodo = @periodo, ano = @ano where id_turma = @id"

                cmdTurma.Connection = cnn
                cmdTurma.CommandText = strSql

                cmdTurma.Parameters.AddWithValue("@turma", txtTurma.Text.ToString.ToUpper)
                cmdTurma.Parameters.AddWithValue("@periodo", cmbPeriodo.Text.ToString.ToUpper)
                cmdTurma.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString.ToUpper)
                cmdTurma.Parameters.AddWithValue("@id", idTurma.ToString)
                Try
                    cmdTurma.ExecuteNonQuery()
                    Call PreencherGridTurma()
                    MessageBox.Show("ALTERADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call TurmasFuncio.entrada()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdTurma.Parameters.Clear()
            End If
        End If
    End Sub

    Private Sub btnConsTurma_Click(sender As Object, e As EventArgs) Handles btnConsTurma.Click
        If txtTurma.Text = "Digite a turma" Or txtTurma.Text = "" And Val(mtbAnoTurma.Text) = 0 And cmbPeriodo.SelectedIndex = 0 Then
            Call PreencherGridTurma()
            Exit Sub
        Else
            strSql = "select * from TB_TURMA where turma like '%'+@turma+'%' and ano like '%'+@ano+'%' and periodo like '%'+@periodo+'%'"
            Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
            If txtTurma.Text = "Digite a turma" Or txtTurma.Text.Trim() = "" Then
                cmdTurma.Parameters.AddWithValue("@turma", DBNull.Value)
            Else
                cmdTurma.Parameters.AddWithValue("@turma", txtTurma.Text.ToString)
            End If

            cmdTurma.Parameters.AddWithValue("@periodo", cmbPeriodo.Text.ToString)
            cmdTurma.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
            Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
            Dim tblTurma As New DataTable
            daTurma.Fill(tblTurma)

            dgvTurma.DataSource = tblTurma
            cmdTurma.Parameters.Clear()
        End If
        'Call DiscpFuncio.limparProf()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim cmdTurma As New SqlClient.SqlCommand
            strSql = "delete from TB_TURMA where id_turma = @id"
            cmdTurma.Connection = cnn
            cmdTurma.CommandText = strSql
            cmdTurma.Parameters.AddWithValue("@id", idTurma.ToString)
            Try
                cmdTurma.ExecuteNonQuery()
                Call PreencherGridTurma()
                MessageBox.Show("REMOVIDO COM SUCESSO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call TurmasFuncio.entrada()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdTurma.Parameters.Clear()

            Call TurmasFuncio.entrada()
        End If
    End Sub

    Private Sub btnConsAluno_Click(sender As Object, e As EventArgs) Handles btnConsAluno.Click
        Dim drAluno As SqlClient.SqlDataReader
        Dim cmdAluno As New SqlClient.SqlCommand
        Call TurmasFuncio.botoes()
        If txtMatricula.Text = idConsAluno Then
            Call consAluno()
            clickAluno = 2
            Exit Sub
            If idConsAluno <> "" Then
                If idAluno = idConsAluno Then
                    Call consAluno()
                    clickAluno = 2
                    Exit Sub
                End If
                If idConsAluno = txtMatricula.Text Then
                    btnAddAluno.Enabled = True
                End If
                Exit Sub
            End If
            Exit Sub
        End If
        If clickAluno < 2 Then
            If txtMatricula.Text <> "" Then
                strSql = "select * from tb_aluno where id_matricula = @matricula"

                cmdAluno.Connection = cnn
                cmdAluno.CommandText = strSql

                cmdAluno.Parameters.AddWithValue("@matricula", txtMatricula.Text)

                Try
                    drAluno = cmdAluno.ExecuteReader()
                Catch ex As Exception
                    MsgBox(Err.Description)
                    Exit Sub
                End Try
                If Not drAluno.HasRows Then
                    MessageBox.Show("Aluno não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    drAluno.Close()
                    Call consAluno()
                    If idConsAluno <> "" Then
                        If idConsAluno = txtMatricula.Text Then
                            btnAddAluno.Enabled = True
                        End If
                        Exit Sub
                    End If
                    Exit Sub
                Else
                    drAluno.Read()
                    txtMatricula.Text = drAluno("id_matricula").ToString
                    txtNomeAluno.Text = drAluno("nome_aluno").ToString
                    btnAddAluno.Enabled = True
                    drAluno.Close()
                    clickAluno = 1
                End If
            Else
                Call consAluno()
                If idConsAluno <> "" Then
                    If idConsAluno = txtMatricula.Text Then
                        btnAddAluno.Enabled = True
                    End If
                    Exit Sub
                End If
            End If
        Else
            Call consAluno()
            If idConsAluno <> "" Then
                If idConsAluno = txtMatricula.Text Then
                    btnAddAluno.Enabled = True
                End If
                Exit Sub
            End If
            clickAluno = 1
        End If
        btnRemoveAluno.Enabled = False
        idConsAluno = txtMatricula.Text
    End Sub

    Private Sub btnConsProf_Click(sender As Object, e As EventArgs) Handles btnConsProf.Click
        Dim drProf As SqlClient.SqlDataReader
        Dim cmdProf As New SqlClient.SqlCommand
        Call TurmasFuncio.botoes()
        If txtCod.Text = idConsProf Then
            Call consProf()
            Exit Sub
            If idConsProf <> "" Then
                If idProf = idConsProf Then
                    Call consProf()
                    Exit Sub
                End If
                If idConsProf = txtCod.Text Then
                    btnAddProf.Enabled = True
                End If
                Exit Sub
            End If
            Exit Sub
        End If
        If clickProf < 2 Then
            If txtCod.Text <> "" Then
                strSql = "select * from tb_usuario where id_usuario = @id and tipo_usuario = 'PROFESSOR'"

                cmdProf.Connection = cnn
                cmdProf.CommandText = strSql

                cmdProf.Parameters.AddWithValue("@id", txtCod.Text)

                Try
                    drProf = cmdProf.ExecuteReader()
                    cmbDisc.Enabled = True
                Catch ex As Exception
                    MsgBox(Err.Description)
                    Exit Sub
                End Try
                If Not drProf.HasRows Then
                    MessageBox.Show("Professor não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    drProf.Close()
                    Call consProf()
                    If idConsProf <> "" Then
                        If idConsProf = txtCod.Text Then
                            btnAddProf.Enabled = True
                        End If
                        Exit Sub
                    End If
                    Exit Sub
                Else
                    drProf.Read()
                    txtCod.Text = drProf("id_usuario").ToString
                    txtNomeProf.Text = drProf("nome_usuario").ToString
                    btnAddProf.Enabled = True
                    drProf.Close()
                    clickProf = 1
                End If

                cmbDisc.Items.Clear()
                cmbDisc.Items.Add("---")
                cmbDisc.SelectedIndex = 0

                strSql = "SELECT        TB_DISCP.disciplina" & vbNewLine &
                     "From TB_DISCP INNER Join" & vbNewLine &
                     "TB_PROFESSOR_DISCIPLINA ON TB_DISCP.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp INNER JOIN" & vbNewLine &
                     "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                     "WHERE        (TB_USUARIO.id_usuario = @id)"

                cmdProf = New SqlClient.SqlCommand(strSql, cnn)
                Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
                cmdProf.Parameters.AddWithValue("@id", txtCod.Text)
                Dim reader As SqlDataReader = cmdProf.ExecuteReader()

                While reader.Read()
                    Dim disc As String
                    disc = reader.GetValue(0).ToString
                    cmbDisc.Items.Add(disc)
                End While
                reader.Close()
            Else
                Call consProf()
                If idConsProf <> "" Then
                    If idConsProf = txtCod.Text Then
                        btnAddProf.Enabled = True
                    End If
                    Exit Sub
                End If
            End If
        Else
            Call consProf()
            If idConsProf <> "" Then
                If idConsProf = txtCod.Text Then
                    btnAddProf.Enabled = True
                End If
                Exit Sub
            End If
            clickProf = 1
        End If
        btnRemoveProf.Enabled = False
        idConsProf = txtCod.Text
    End Sub

    Private Sub dgvTurma_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurma.CellClick
        Call preencherGridAluno()
        Call preencherGridProf()
        Call TurmasFuncio.ConsTurma()
        idTurma = dgvTurma.CurrentRow.Cells("colIDTurma").Value
        txtTurma.Text = dgvTurma.CurrentRow.Cells("colTurma").Value
        txtTurma.ForeColor = Color.Black
        mtbAnoTurma.Text = dgvTurma.CurrentRow.Cells("colAno").Value
        mtbAnoTurma.ForeColor = Color.Black
        cmbPeriodo.SelectedItem = dgvTurma.CurrentRow.Cells("colPeriodo").Value
        cmbPeriodo.ForeColor = Color.Black
        strAcao = "alterar"
        btnConsProf.Enabled = True
        btnConsAluno.Enabled = True
        btnAddAluno.Enabled = False
        btnRemoveAluno.Enabled = False
        btnAddProf.Enabled = False
        btnRemoveProf.Enabled = False
    End Sub

    Private Sub dgvAluno_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAluno.CellClick
        idAluno = dgvAluno.CurrentRow.Cells("colIDAluno").Value
        txtMatricula.Text = dgvAluno.CurrentRow.Cells("colIDAluno").Value
        txtMatricula.ForeColor = Color.Black
        txtNomeAluno.Text = dgvAluno.CurrentRow.Cells("colAluno").Value
        txtNomeProf.ForeColor = Color.Black
        Call TurmasFuncio.botoes()
        btnRemoveAluno.Enabled = True
        btnAddAluno.Enabled = False

        clickAluno = 2
    End Sub

    Private Sub btnLimparAluno_Click(sender As Object, e As EventArgs) Handles btnLimparAluno.Click
        Call TurmasFuncio.limparAluno()
        Call TurmasFuncio.botoes()
        clickAluno = 1
        idConsAluno = ""
        btnAddAluno.Enabled = False
        btnRemoveAluno.Enabled = False
    End Sub

    Private Sub btnLimparProf_Click(sender As Object, e As EventArgs) Handles btnLimparProf.Click
        Call TurmasFuncio.limparProfessor()
        Call TurmasFuncio.botoes()
        clickProf = 1
        idConsProf = ""
        btnAddProf.Enabled = False
        btnRemoveProf.Enabled = False
    End Sub

    Private Sub txtMatricula_TxtCod_GotFocus(sender As Object, e As EventArgs) Handles txtMatricula.GotFocus, txtCod.GotFocus
        Call TurmasFuncio.botoes()
        clickMudarAluno = True
        clickMudarProf = True
    End Sub

    Private Sub txtMatricula_TxtCod_TextChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged, txtCod.TextChanged
        If clickMudarAluno = True Then
            clickAluno = 1
        End If
        If clickMudarProf = True Then
            clickProf = 1
        End If
    End Sub

    Private Sub btnRemoveAluno_Click(sender As Object, e As EventArgs) Handles btnRemoveAluno.Click
        Dim cmdAluno As New SqlClient.SqlCommand
        strSql = "delete from TB_ALUNO_TURMA where id_matricula = @matricula and id_turma = @id_turma"
        cmdAluno.Connection = cnn
        cmdAluno.CommandText = strSql
        cmdAluno.Parameters.AddWithValue("@matricula", idAluno.ToString)
        cmdAluno.Parameters.AddWithValue("@id_turma", idTurma.ToString)
        Try
            cmdAluno.ExecuteNonQuery()
            Call preencherGridAluno()
            btnRemoveAluno.Enabled = False
            Call TurmasFuncio.botoes()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        cmdAluno.Parameters.Clear()
        Call TurmasFuncio.limparAluno()

    End Sub

    Private Sub btnAddAluno_Click(sender As Object, e As EventArgs) Handles btnAddAluno.Click
        Dim id As String = txtMatricula.Text
        Dim c As Integer = 0
        Dim c2 = dgvAluno.RowCount()
        Dim adc As Boolean = True
        While c < c2
            If id = dgvAluno.Rows(c).Cells(1).Value Then
                adc = False
            End If
            c += 1
        End While
        If adc = True Then
            Dim cmdAluno As New SqlClient.SqlCommand
            strSql = "insert into tb_aluno_turma (id_matricula , id_turma) values(@matricula , @id_turma)"
            cmdAluno.Connection = cnn
            cmdAluno.CommandText = strSql
            cmdAluno.Parameters.AddWithValue("@matricula", txtMatricula.Text.ToString)
            cmdAluno.Parameters.AddWithValue("@id_turma", idTurma.ToString)
            Try
                cmdAluno.ExecuteNonQuery()
                Call preencherGridAluno()
                btnRemoveAluno.Enabled = False
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdAluno.Parameters.Clear()

            clickAluno = 1
        Else
            MessageBox.Show("ALUNO JÁ VINCULADO!", "TURMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Call TurmasFuncio.botoes()
        btnAddAluno.Enabled = False
        idConsAluno = ""
    End Sub

    Private Sub dgvProf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProf.CellClick
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        idProf = dgvProf.CurrentRow.Cells("colIDProf").Value
        txtCod.Text = dgvProf.CurrentRow.Cells("colIDProf").Value
        txtCod.ForeColor = Color.Black
        txtNomeProf.Text = dgvProf.CurrentRow.Cells("colProfessor").Value
        Dim strDisc As String = dgvProf.CurrentRow.Cells("colDisc").Value
        strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
                     "From TB_DISCP INNER Join" & vbNewLine &
                     "TB_PROFESSOR_DISCIPLINA ON TB_DISCP.id_discp = TB_PROFESSOR_DISCIPLINA.id_discp INNER JOIN" & vbNewLine &
                     "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                     "WHERE (TB_USUARIO.id_usuario = @id)"

        Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
        Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
        cmdProf.Parameters.AddWithValue("@id", txtCod.Text)
        Dim reader As SqlDataReader = cmdProf.ExecuteReader()

        While reader.Read()
            Dim disc As String
            disc = reader.GetValue(0).ToString
            cmbDisc.Items.Add(disc)
        End While
        reader.Close()
        cmbDisc.SelectedItem = strDisc
        Call TurmasFuncio.botoes()
        btnRemoveProf.Enabled = True
        btnAddProf.Enabled = False

        clickAluno = 2
    End Sub

    Private Sub btnAddProf_Click(sender As Object, e As EventArgs) Handles btnAddProf.Click
        If TurmasFuncio.addProf() Then
            strSql = "SELECT TB_PROFESSOR_DISCIPLINA.id_prof_discp " & vbNewLine &
                 "From TB_USUARIO INNER Join " & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN " & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp " & vbNewLine &
                 "WHERE        (TB_USUARIO.id_usuario = @id) AND (TB_DISCP.disciplina = @discp)"
            Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
            Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
            cmdProf.Parameters.AddWithValue("@id", txtCod.Text)
            cmdProf.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
            Dim idProfDiscp = cmdProf.ExecuteScalar()

            Dim c As Integer = 0
            Dim c2 = dgvProf.RowCount()
            Dim adc As Boolean = True
            While c < c2
                If cmbDisc.Text = dgvProf.Rows(c).Cells(2).Value Then
                    adc = False
                End If
                c += 1
            End While

            If adc = True Then
                strSql = "INSERT INTO TB_PROFESSOR_DISCIPLINA_TURMA VALUES (@idProfDiscp , @idTurma)"
                cmdProf = New SqlClient.SqlCommand(strSql, cnn)
                daProf = New SqlClient.SqlDataAdapter(cmdProf)
                cmdProf.Parameters.AddWithValue("@idProfDiscp", idProfDiscp.ToString)
                cmdProf.Parameters.AddWithValue("@idTurma", idTurma.ToString)
                Try
                    cmdProf.ExecuteNonQuery()
                    Call preencherGridProf()
                    btnRemoveProf.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdProf.Parameters.Clear()

                clickAluno = 1
            Else
                MessageBox.Show("DISCIPLINA JÁ VINCULADA!", "TURMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub

    Private Sub btnRemoveProf_Click(sender As Object, e As EventArgs) Handles btnRemoveProf.Click
        Dim cmdProf As New SqlClient.SqlCommand
        strSql = "DELETE FROM TB_PROFESSOR_DISCIPLINA_TURMA WHERE id_turma = @idTurma and id_prof_discp = @idProfDiscp"
        cmdProf.Connection = cnn
        cmdProf.CommandText = strSql
        cmdProf.Parameters.AddWithValue("@idTurma", idTurma.ToString)
        cmdProf.Parameters.AddWithValue("@idProfDiscp", dgvProf.CurrentRow.Cells("colIDProfDiscp").Value.ToString)
        Try
            cmdProf.ExecuteNonQuery()
            Call preencherGridProf()
            btnRemoveProf.Enabled = False
            Call TurmasFuncio.botoes()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        cmdProf.Parameters.Clear()
        Call TurmasFuncio.limparProfessor()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtCod.KeyPress, txtMatricula.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(TurmasFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class