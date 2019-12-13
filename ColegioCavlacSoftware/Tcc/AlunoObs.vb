Imports System.Data.SqlClient

Public Class AlunoObs

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public idTurma As String
    Public idAluno As String
    Private idObs As String
    Private click As Integer = 1
    Private numChamada As String = 0

    Sub PreencherGridTurma()
        strSql = "select ano from tb_master"
        Dim cmdAno As New SqlClient.SqlCommand
        cmdAno.Connection = cnn
        cmdAno.CommandText = strSql
        Dim ano As String = cmdAno.ExecuteScalar()

        strSql = "Select TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                 "From TB_PROFESSOR_DISCIPLINA_TURMA INNER Join" & vbNewLine &
                 "TB_TURMA On TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = TB_TURMA.id_turma INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA On TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp" & vbNewLine &
                 "WHERE (TB_PROFESSOR_DISCIPLINA.id_usuario = @id And TB_TURMA.ano = @ano)" & vbNewLine &
                 "GROUP BY TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                 "ORDER BY TB_TURMA.periodo, TB_TURMA.turma"

        Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
        cmdTurma.Parameters.AddWithValue("@id", id.ToString)
        cmdTurma.Parameters.AddWithValue("@ano", ano.ToString)
        Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
        Dim tblTurma As New DataTable
        daTurma.Fill(tblTurma)

        dgvTurma.DataSource = tblTurma
    End Sub

    Sub preencherGridObs()
        strSql = "select ano from tb_master"
        Dim cmdAno As New SqlClient.SqlCommand
        cmdAno.Connection = cnn
        cmdAno.CommandText = strSql
        Dim ano As String = cmdAno.ExecuteScalar()

        strSql = "SELECT TB_NOTIFICACOES.notificacao, TB_NOTIFICACOES.data, TB_NOTIFICACOES.id_noti" & vbNewLine &
                 "From TB_NOTIFICACOES INNER Join" & vbNewLine &
                 "TB_USUARIO ON TB_NOTIFICACOES.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                 "Where (YEAR(TB_NOTIFICACOES.data) = @ano) AND (TB_USUARIO.id_usuario = @idUsu) AND (TB_NOTIFICACOES.id_matricula = @idAluno)"

        Dim cmdObs As New SqlClient.SqlCommand(strSql, cnn)
        cmdObs.Parameters.AddWithValue("@idUsu", id.ToString)
        cmdObs.Parameters.AddWithValue("@idAluno", idAluno.ToString)
        cmdObs.Parameters.AddWithValue("@ano", ano.ToString)
        Dim daObs As New SqlClient.SqlDataAdapter(cmdObs)
        Dim tblObs As New DataTable
        daObs.Fill(tblObs)

        dgvObs.DataSource = tblObs
    End Sub

    Sub consAluno()
        Call ObsFuncio.limparAlunos()
        Dim objConsAluno As New frmConsAluno
        objConsAluno.Turma = True
        objConsAluno.obs = True
        objConsAluno.ShowDialog()
        If objConsAluno.confirm = True Then
            idAluno = objConsAluno.GetcolIDAluno().ToString
            txtNomeAluno.Text = objConsAluno.GetcolNomeAluno().ToString
            strSql = "WITH Chamada AS" & vbNewLine & _
                 "(" & vbNewLine & _
                 "SELECT TB_ALUNO.nome_aluno, TB_ALUNO.id_matricula, ROW_NUMBER() OVER(ORDER BY nome_aluno) as NumChamada" & vbNewLine & _
                 "FROM TB_ALUNO INNER JOIN" & vbNewLine & _
                 "TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN" & vbNewLine & _
                 "TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma" & vbNewLine & _
                 "WHERE TB_TURMA.id_turma = @idTurma" & vbNewLine & _
                 "--ORDER BY TB_ALUNO.nome_aluno" & vbNewLine & _
                 ")" & vbNewLine & _
                 "SELECT NumChamada" & vbNewLine & _
                 "FROM Chamada" & vbNewLine & _
                 "WHERE nome_aluno = @nome" & vbNewLine & _
                 "ORDER BY nome_aluno"

            Dim cmdNumChamada As New SqlClient.SqlCommand(strSql, cnn)
            Dim daNumChamada As New SqlClient.SqlDataAdapter(cmdNumChamada)
            cmdNumChamada.Parameters.AddWithValue("@idTurma", idTurma.ToString)
            cmdNumChamada.Parameters.AddWithValue("@nome", txtNomeAluno.Text.ToString)
            Dim readerNumChamada As SqlDataReader = cmdNumChamada.ExecuteReader()
            readerNumChamada.Read()
            txtMatricula.Text = readerNumChamada.GetValue(0).ToString
            numChamada = readerNumChamada.GetValue(0).ToString
            readerNumChamada.Close()
            btnAddobs.Enabled = True
            Call preencherGridObs()
        End If
    End Sub

    Private Sub txtTurma_GotFocus(sender As Object, e As EventArgs) Handles txtTurma.GotFocus
        If txtTurma.Text = "Digite a turma" Then
            txtTurma.Text = ""
            txtTurma.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTurma_LostFocus(sender As Object, e As EventArgs) Handles txtTurma.LostFocus
        If txtTurma.Text = "" Then
            txtTurma.Text = "Digite a turma"
            txtTurma.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbPeriodo_GotFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.GotFocus, cmbPeriodo.DropDown
        cmbPeriodo.ForeColor = Color.Black
    End Sub

    Private Sub cmbPeriodo_LostFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.LostFocus
        If cmbPeriodo.SelectedIndex = 0 Then
            cmbPeriodo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub AlunoObs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numChamada = 0
        cmbPeriodo.Items.Clear()
        Call ObsFuncio.load()
        Call PreencherGridTurma()
        btnAddobs.Enabled = False
        btnRemoveObs.Enabled = False
    End Sub

    Private Sub btnConsTurma_Click(sender As Object, e As EventArgs) Handles btnConsTurma.Click
        strSql = "select ano from tb_master"
        Dim cmdAno As New SqlClient.SqlCommand
        cmdAno.Connection = cnn
        cmdAno.CommandText = strSql
        Dim ano As String = cmdAno.ExecuteScalar()

        strSql = "Select TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                "From TB_TURMA INNER Join" & vbNewLine &
                "TB_PROFESSOR_DISCIPLINA_TURMA On TB_TURMA.id_turma = TB_PROFESSOR_DISCIPLINA_TURMA.id_turma INNER JOIN" & vbNewLine &
                "TB_PROFESSOR_DISCIPLINA On TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp INNER JOIN" & vbNewLine &
                "TB_USUARIO On TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                "WHERE TB_TURMA.turma Like '%'+@turma+'%' and TB_TURMA.periodo like '%'+@periodo+'%' and TB_TURMA.ano like '%'+@ano+'%' and TB_USUARIO.id_usuario = @id" & vbNewLine &
                "GROUP BY TB_TURMA.periodo, TB_TURMA.turma, TB_TURMA.id_turma" & vbNewLine &
                "ORDER BY TB_TURMA.periodo, TB_TURMA.turma"

        Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
        If txtTurma.Text = "Digite a turma" Then
            cmdTurma.Parameters.AddWithValue("@turma", "")
        Else
            cmdTurma.Parameters.AddWithValue("@turma", txtTurma.Text.ToString)
        End If
        If cmbPeriodo.SelectedIndex = 0 Then
            cmdTurma.Parameters.AddWithValue("@periodo", "")
        Else
            cmdTurma.Parameters.AddWithValue("@periodo", cmbPeriodo.Text.ToString)
        End If
        cmdTurma.Parameters.AddWithValue("@ano", ano.ToString)
        cmdTurma.Parameters.AddWithValue("@id", id.ToString)
        Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
        Dim tblTurma As New DataTable
        daTurma.Fill(tblTurma)

        dgvTurma.DataSource = tblTurma
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        Call ObsFuncio.limparTurmas()
        Call PreencherGridTurma()
        Call ObsFuncio.limparAlunos()
    End Sub

    Private Sub dgvTurma_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTurma.CellClick
        If dgvTurma.RowCount = 0 Then
            Exit Sub
        End If
        txtTurma.Text = dgvTurma.CurrentRow.Cells("colTurma").Value
        txtTurma.ForeColor = Color.Black
        cmbPeriodo.SelectedItem = dgvTurma.CurrentRow.Cells("colPeriodo").Value
        cmbPeriodo.ForeColor = Color.Black
        idTurma = dgvTurma.CurrentRow.Cells("colIDTurma").Value
        Call ObsFuncio.limparAlunos()
        txtMatricula.Enabled = True
        btnConsAluno.Enabled = True
        btnLimparAluno.Enabled = True
    End Sub

    Private Sub btnConsAluno_Click(sender As Object, e As EventArgs) Handles btnConsAluno.Click
        If click = 2 Or txtMatricula.Text = "" Or txtMatricula.Text = numChamada Then
            Call consAluno()
        Else
            strSql = "WITH Chamada AS" & vbNewLine &
                 "(" & vbNewLine &
                 "SELECT TB_ALUNO.nome_aluno, TB_ALUNO.id_matricula, ROW_NUMBER() OVER(ORDER BY nome_aluno) as NumChamada" & vbNewLine &
                 "FROM TB_ALUNO INNER JOIN" & vbNewLine &
                 "TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN" & vbNewLine &
                 "TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma" & vbNewLine &
                 "WHERE TB_TURMA.id_turma = @idTurma" & vbNewLine &
                 "--ORDER BY TB_ALUNO.nome_aluno" & vbNewLine &
                 ")" & vbNewLine &
                 "SELECT nome_aluno, id_matricula, ROW_NUMBER() OVER(ORDER BY nome_aluno) as NumChamada" & vbNewLine &
                 "FROM Chamada" & vbNewLine &
                 "WHERE NumChamada = @numChamada" & vbNewLine &
                 "ORDER BY nome_aluno"

            Dim cmbAluno As New SqlClient.SqlCommand(strSql, cnn)
            Dim daAluno As New SqlClient.SqlDataAdapter(cmbAluno)
            cmbAluno.Parameters.AddWithValue("@idTurma", idTurma.ToString)
            cmbAluno.Parameters.AddWithValue("@numChamada", txtMatricula.Text.ToString)
            Dim readerAluno As SqlDataReader = cmbAluno.ExecuteReader()
            If readerAluno.HasRows = True Then
                readerAluno.Read()
                txtNomeAluno.Text = readerAluno.GetValue(0).ToString
                idAluno = readerAluno.GetValue(1).ToString
                numChamada = txtMatricula.Text
                readerAluno.Close()
                btnAddobs.Enabled = True
                Call preencherGridObs()
            Else
                readerAluno.Close()
                Call consAluno()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnLimparAluno_Click(sender As Object, e As EventArgs) Handles btnLimparAluno.Click
        Call ObsFuncio.limparAlunos()
    End Sub

    Private Sub dgvObs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObs.CellClick
        idObs = dgvObs.CurrentRow.Cells("colIDobs").Value
        btnRemoveObs.Enabled = True
    End Sub

    Private Sub dgvObs_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvObs.CellDoubleClick
        btnRemoveObs.Enabled = False
        idObs = dgvObs.CurrentRow.Cells("colIDobs").Value
        Dim objFrmObs As New frmObs
        objFrmObs.idObs = idObs
        objFrmObs.strAcao = "Alterar"
        objFrmObs.mtbData.Enabled = False
        objFrmObs.ToolNovo.Active = False
        objFrmObs.ToolAlterar.Active = True
        objFrmObs.Show()

    End Sub

    Private Sub btnRemoveObs_Click(sender As Object, e As EventArgs) Handles btnRemoveObs.Click
        If MessageBox.Show("Deseja Mesmo Remover?", "REMOVER", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim cmdObs As New SqlClient.SqlCommand
            strSql = "delete from  TB_NOTIFICACOES where id_noti = " & idObs
            cmdObs.Connection = cnn
            cmdObs.CommandText = strSql
            Try
                cmdObs.ExecuteNonQuery()
                Call preencherGridObs()
                btnRemoveObs.Enabled = False
                MessageBox.Show("NOTIFICAÇÃO REMOVIDA COM SUCESSO!", "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox("ERRO!" & Err.Description)
            End Try
        End If
    End Sub

    Private Sub btnAddobs_Click(sender As Object, e As EventArgs) Handles btnAddobs.Click
        btnRemoveObs.Enabled = False

        frmObs.ShowDialog()
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

    Private Sub txtMatricula_TextChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged
        If txtMatricula.Text = numChamada Then
            click = 2
        ElseIf txtMatricula.Text = "" Then
            numChamada = 0
            click = 1
        Else
            click = 1
        End If
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtMatricula.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(ObsFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class