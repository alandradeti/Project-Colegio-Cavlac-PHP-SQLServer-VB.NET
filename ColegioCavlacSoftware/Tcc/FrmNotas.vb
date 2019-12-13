Imports System.Data.SqlClient

Public Class FrmNotas

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public idTurma As String
    Private idAluno As String
    Private strBim As String
    Private idDiscp As String
    Private anoAtual As String
    Private BimAtual As String
    Private click As Integer = 1
    Private numChamada As String = 0

    Sub Master()
        strSql = "select * from TB_MASTER"

        Dim cmdMaster As New SqlClient.SqlCommand(strSql, cnn)
        Dim daMaster As New SqlClient.SqlDataAdapter(cmdMaster)
        Dim readerMaster As SqlDataReader
        readerMaster = cmdMaster.ExecuteReader()

        readerMaster.Read()
        mtbAnoTurma.Text = readerMaster("ano").ToString
        cmbBimestre.SelectedItem = readerMaster("bimestre").ToString
        readerMaster.Close()
    End Sub

    Private Sub Bim1Null()
        Dim cmd1bim As New SqlClient.SqlCommand
        strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
        cmd1bim.Connection = cnn
        cmd1bim.CommandText = strSql
        cmd1bim.Parameters.AddWithValue("@nota", DBNull.Value)
        cmd1bim.Parameters.AddWithValue("@faltas", DBNull.Value)

        cmd1bim.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        cmd1bim.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
        cmd1bim.Parameters.AddWithValue("@bimestre", "1")
        cmd1bim.Parameters.AddWithValue("@id_turma", idTurma.ToString)
        cmd1bim.Parameters.AddWithValue("@id_discp", idDiscp)
        Try
            cmd1bim.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmd1bim.Parameters.Clear()
    End Sub

    Private Sub Bim2Null()
        Dim cmd1bim As New SqlClient.SqlCommand
        strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
        cmd1bim.Connection = cnn
        cmd1bim.CommandText = strSql
        cmd1bim.Parameters.AddWithValue("@nota", DBNull.Value)
        cmd1bim.Parameters.AddWithValue("@faltas", DBNull.Value)

        cmd1bim.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        cmd1bim.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
        cmd1bim.Parameters.AddWithValue("@bimestre", "2")
        cmd1bim.Parameters.AddWithValue("@id_turma", idTurma.ToString)
        cmd1bim.Parameters.AddWithValue("@id_discp", idDiscp)
        Try
            cmd1bim.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmd1bim.Parameters.Clear()
    End Sub

    Private Sub Bim3Null()
        Dim cmd1bim As New SqlClient.SqlCommand
        strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
        cmd1bim.Connection = cnn
        cmd1bim.CommandText = strSql
        cmd1bim.Parameters.AddWithValue("@nota", DBNull.Value)
        cmd1bim.Parameters.AddWithValue("@faltas", DBNull.Value)

        cmd1bim.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        cmd1bim.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
        cmd1bim.Parameters.AddWithValue("@bimestre", "3")
        cmd1bim.Parameters.AddWithValue("@id_turma", idTurma.ToString)
        cmd1bim.Parameters.AddWithValue("@id_discp", idDiscp)
        Try
            cmd1bim.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmd1bim.Parameters.Clear()
    End Sub

    Private Sub delNotas()
        If MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim cmdNotas As New SqlClient.SqlCommand
            strSql = "update TB_BOLETIM set nota = null, faltas = null where ano = @ano and bimestre = @bim and id_matricula = @id "
            cmdNotas.Connection = cnn
            cmdNotas.CommandText = strSql
            cmdNotas.Parameters.AddWithValue("@id", idAluno.ToString)
            cmdNotas.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
            cmdNotas.Parameters.AddWithValue("@bim", strBim.ToString)

            Try
                cmdNotas.ExecuteNonQuery()
                Call AlunoBoletim()
                MessageBox.Show("REMOVIDO COM SUCESSO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdNotas.Parameters.Clear()
        End If
    End Sub

    Sub disciplinas()
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        If TipoUsu = "MASTER" Then
            strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
                 "FROM TB_PROFESSOR_DISCIPLINA INNER JOIN" & vbNewLine &
                 "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA_TURMA ON TB_PROFESSOR_DISCIPLINA.id_prof_discp = TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp INNER JOIN" & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE (TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = @idTurma)"
        Else
            strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
                 "FROM TB_PROFESSOR_DISCIPLINA INNER JOIN" & vbNewLine &
                 "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA_TURMA ON TB_PROFESSOR_DISCIPLINA.id_prof_discp = TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp INNER JOIN" & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE (TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = @idTurma and TB_PROFESSOR_DISCIPLINA.id_usuario = @id)"
        End If
        Dim cmdDiscp As New SqlClient.SqlCommand(strSql, cnn)
        Dim daDiscp As New SqlClient.SqlDataAdapter(cmdDiscp)
        cmdDiscp.Parameters.AddWithValue("@idTurma", idTurma.ToString)
        cmdDiscp.Parameters.AddWithValue("@id", id.ToString)
        Dim reader As SqlDataReader = cmdDiscp.ExecuteReader()

        While reader.Read()
            Dim disc As String
            disc = reader.GetValue(0).ToString
            cmbDisc.Items.Add(disc)
        End While
        reader.Close()
    End Sub

    Sub PreencherGridTurma()
        If TipoUsu = "MASTER" Then
            strSql = "select * from TB_TURMA WHERE ano = @ano" & vbNewLine &
                     "ORDER BY periodo , turma"
        Else
            strSql = "Select TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                 "From TB_PROFESSOR_DISCIPLINA_TURMA INNER Join" & vbNewLine &
                 "TB_TURMA On TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = TB_TURMA.id_turma INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA On TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp" & vbNewLine &
                 "WHERE (TB_PROFESSOR_DISCIPLINA.id_usuario = @id And TB_TURMA.ano = @ano)" & vbNewLine &
                 "GROUP BY TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                 "ORDER BY TB_TURMA.periodo, TB_TURMA.turma"
        End If
        Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
        cmdTurma.Parameters.AddWithValue("@id", id.ToString)
        cmdTurma.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
        Dim tblTurma As New DataTable
        daTurma.Fill(tblTurma)

        dgvTurma.DataSource = tblTurma
    End Sub

    Sub consAluno()
        Call NotasFuncio.limparAlunos()
        Dim objConsAluno As New frmConsAluno
        objConsAluno.Turma = True
        objConsAluno.ShowDialog()
        If objConsAluno.confirm = True Then
            idAluno = objConsAluno.GetcolIDAluno().ToString
            txtNomeAluno.Text = objConsAluno.GetcolNomeAluno().ToString
            cmbDisc.Enabled = True
            If cmbDisc.SelectedIndex <> 0 Then
                Call AlunoBoletim()
                Call Verificarnotas()
            End If
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
        Else
            cmbDisc.SelectedIndex = 0
        End If
    End Sub

    Sub AlunoBoletim()
        Call NotasFuncio.limparNotas()
        strSql = "SELECT TB_BOLETIM.nota, TB_BOLETIM.faltas, TB_BOLETIM.bimestre" & vbNewLine &
                 "From TB_BOLETIM INNER Join" & vbNewLine &
                 "TB_DISCP ON TB_BOLETIM.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "Where (TB_BOLETIM.id_matricula = @id) AND (TB_BOLETIM.ano = @ano) AND (TB_DISCP.disciplina = @discp)" & vbNewLine &
                 "ORDER BY TB_BOLETIM.bimestre"
        Dim cmdBoletim As New SqlClient.SqlCommand(strSql, cnn)
        Dim daBoletim As New SqlClient.SqlDataAdapter(cmdBoletim)
        cmdBoletim.Parameters.AddWithValue("@id", idAluno.ToString)
        cmdBoletim.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        cmdBoletim.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
        Dim readerBoletim As SqlDataReader = cmdBoletim.ExecuteReader()

        If readerBoletim.Read() Then
            If readerBoletim.GetValue(2).ToString = 1 Then
                txt1Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas1bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 2 Then
                txt2Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas2bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 3 Then
                txt3Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas3bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 4 Then
                txt4bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas4bim.Text = readerBoletim.GetValue(1).ToString

            End If
        End If

        If readerBoletim.Read() Then
            If readerBoletim.GetValue(2).ToString = 1 Then
                txt1Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas1bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 2 Then
                txt2Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas2bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 3 Then
                txt3Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas3bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 4 Then
                txt4bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas4bim.Text = readerBoletim.GetValue(1).ToString

            End If
        End If

        If readerBoletim.Read() Then
            If readerBoletim.GetValue(2).ToString = 1 Then
                txt1Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas1bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 2 Then
                txt2Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas2bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 3 Then
                txt3Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas3bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 4 Then
                txt4bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas4bim.Text = readerBoletim.GetValue(1).ToString

            End If
        End If

        If readerBoletim.Read() Then
            If readerBoletim.GetValue(2).ToString = 1 Then
                txt1Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas1bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 2 Then
                txt2Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas2bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 3 Then
                txt3Bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas3bim.Text = readerBoletim.GetValue(1).ToString

            ElseIf readerBoletim.GetValue(2).ToString = 4 Then
                txt4bim.Text = readerBoletim.GetValue(0).ToString
                mtbFaltas4bim.Text = readerBoletim.GetValue(1).ToString

            End If
        End If
        readerBoletim.Close()
    End Sub

    Private Sub Verificarnotas()

        If TipoUsu = "MASTER" Then
            Exit Sub
        End If

        If cmbBimestre.SelectedIndex = 0 Then
            txt1Bim.Enabled = False
            mtbFaltas1bim.Enabled = False
            btn1Bim.Enabled = False
            txt2Bim.Enabled = False
            mtbFaltas2bim.Enabled = False
            btn2Bim.Enabled = False
            txt3Bim.Enabled = False
            mtbFaltas3bim.Enabled = False
            btn3Bim.Enabled = False
            txt4bim.Enabled = False
            mtbFaltas4bim.Enabled = False
            btn4Bim.Enabled = False
            Exit Sub

        ElseIf cmbBimestre.SelectedIndex = 1 Then
            If txt1Bim.Text = "" Then
                txt1Bim.Enabled = True
                mtbFaltas1bim.Enabled = True
                btn1Bim.Enabled = True
            Else
                txt1Bim.Enabled = False
                mtbFaltas1bim.Enabled = False
                btn1Bim.Enabled = False
            End If
            txt2Bim.Enabled = False
            mtbFaltas2bim.Enabled = False
            btn2Bim.Enabled = False
            txt3Bim.Enabled = False
            mtbFaltas3bim.Enabled = False
            btn3Bim.Enabled = False
            txt4bim.Enabled = False
            mtbFaltas4bim.Enabled = False
            btn4Bim.Enabled = False

        ElseIf cmbBimestre.SelectedIndex = 2 Then
            If txt2Bim.Text = "" Then
                txt2Bim.Enabled = True
                mtbFaltas2bim.Enabled = True
                btn2Bim.Enabled = True
            Else
                txt2Bim.Enabled = False
                mtbFaltas2bim.Enabled = False
                btn2Bim.Enabled = False
            End If
            txt1Bim.Enabled = False
            mtbFaltas1bim.Enabled = False
            btn1Bim.Enabled = False
            txt3Bim.Enabled = False
            mtbFaltas3bim.Enabled = False
            btn3Bim.Enabled = False
            txt4bim.Enabled = False
            mtbFaltas4bim.Enabled = False
            btn4Bim.Enabled = False

        ElseIf cmbBimestre.SelectedIndex = 3 Then
            If txt3Bim.Text = "" Then
                txt3Bim.Enabled = True
                mtbFaltas3bim.Enabled = True
                btn3Bim.Enabled = True
            Else
                txt3Bim.Enabled = False
                mtbFaltas3bim.Enabled = False
                btn3Bim.Enabled = False
            End If
            txt1Bim.Enabled = False
            mtbFaltas1bim.Enabled = False
            btn1Bim.Enabled = False
            txt2Bim.Enabled = False
            mtbFaltas2bim.Enabled = False
            btn2Bim.Enabled = False
            txt4bim.Enabled = False
            mtbFaltas4bim.Enabled = False
            btn4Bim.Enabled = False

        ElseIf cmbBimestre.SelectedIndex = 4 Then
            If txt4bim.Text = "" Then
                txt4bim.Enabled = True
                mtbFaltas4bim.Enabled = True
                btn4Bim.Enabled = True
            Else
                txt4bim.Enabled = False
                mtbFaltas4bim.Enabled = False
                btn4Bim.Enabled = False
            End If
            txt1Bim.Enabled = False
            mtbFaltas1bim.Enabled = False
            btn1Bim.Enabled = False
            txt2Bim.Enabled = False
            mtbFaltas2bim.Enabled = False
            btn2Bim.Enabled = False
            txt3Bim.Enabled = False
            mtbFaltas3bim.Enabled = False
            btn3Bim.Enabled = False
        End If

    End Sub

    Private Sub txtTurma_GotFocus(sender As Object, e As EventArgs) Handles txtTurma.GotFocus
        If txtTurma.Text = "Digite a turma" Then
            txtTurma.Text = ""
            txtTurma.ForeColor = Color.Black
            'clickAluno = 1
        End If
    End Sub

    Private Sub txtTurma_LostFocus(sender As Object, e As EventArgs) Handles txtTurma.LostFocus
        If txtTurma.Text = "" Then
            txtTurma.Text = "Digite a turma"
            txtTurma.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbAnoTurma_GotFocus(sender As Object, e As EventArgs) Handles mtbAnoTurma.GotFocus, mtbAnoTurma.Click
        mtbAnoTurma.SelectionStart = 0
        mtbAnoTurma.BackColor = Color.White
        'clickAluno = 1
    End Sub

    Private Sub mtbAnoTurma_LostFocus(sender As Object, e As EventArgs) Handles mtbAnoTurma.LostFocus
        If Val(mtbAnoTurma.Text) = anoAtual Then
            mtbAnoTurma.BackColor = SystemColors.InactiveCaption
        End If
    End Sub

    Private Sub cmbBimestre_GotFocus(sender As Object, e As EventArgs) Handles cmbBimestre.GotFocus, cmbBimestre.DropDown
        cmbBimestre.BackColor = Color.White
    End Sub

    Private Sub cmbBimestre_LostFocus(sender As Object, e As EventArgs) Handles cmbBimestre.LostFocus
        If cmbBimestre.Text = BimAtual Then
            cmbBimestre.BackColor = SystemColors.InactiveCaption
        End If
    End Sub

    Private Sub cmbPeriodo_GotFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.GotFocus, cmbPeriodo.DropDown
        cmbPeriodo.ForeColor = Color.Black
        'clickAluno = 1
    End Sub

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus, cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
            Call NotasFuncio.limparNotas()
            If TipoUsu = "PROFESSOR" Then
                Call NotasFuncio.BlockBim()
            End If
        Else
            Call AlunoBoletim()
            Call Verificarnotas()
        End If
    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
    End Sub

    Private Sub cmbPeriodo_LostFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.LostFocus
        If cmbPeriodo.SelectedIndex = 0 Then
            cmbPeriodo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub FrmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numChamada = 0
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        cmbPeriodo.Items.Clear()
        cmbBimestre.Items.Clear()
        If TipoUsu = "MASTER" Then
            Call NotasFuncio.masterLoad()
            ToolUsu.Active = False
            ToolMaster.Active = True
        Else
            Call NotasFuncio.usuBlock()
            Call NotasFuncio.ProfLoad()
            ToolUsu.Active = True
            ToolMaster.Active = False
        End If
        Call NotasFuncio.MasterBimestre()
        Call Master()
        Call PreencherGridTurma()
        Call NotasFuncio.load()
        anoAtual = mtbAnoTurma.Text
        BimAtual = cmbBimestre.Text
        cmbBimestre.BackColor = SystemColors.InactiveCaption
        mtbAnoTurma.BackColor = SystemColors.InactiveCaption
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
        Call disciplinas()
        Call NotasFuncio.limparAlunos()
        cmbDisc.SelectedIndex = 0
        cmbDisc.Enabled = False
        txtMatricula.Enabled = True
        btnConsAluno.Enabled = True
        btnLimparAluno.Enabled = True
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        Call NotasFuncio.limparTurmas()
        Call PreencherGridTurma()
        Call NotasFuncio.limparAlunos()
        cmbDisc.SelectedIndex = 0
        cmbDisc.Enabled = False
        numChamada = 0
    End Sub

    Private Sub btnConsTurma_Click(sender As Object, e As EventArgs) Handles btnConsTurma.Click
        If TipoUsu = "MASTER" Then
            strSql = "Select TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                 "From TB_TURMA INNER Join" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA_TURMA On TB_TURMA.id_turma = TB_PROFESSOR_DISCIPLINA_TURMA.id_turma INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA On TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp INNER JOIN" & vbNewLine &
                 "TB_USUARIO On TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                 "WHERE TB_TURMA.turma Like '%'+@turma+'%' and TB_TURMA.periodo like '%'+@periodo+'%' and TB_TURMA.ano like '%'+@ano+'%'" & vbNewLine &
                 "GROUP BY TB_TURMA.periodo, TB_TURMA.turma, TB_TURMA.id_turma" & vbNewLine &
                 "ORDER BY TB_TURMA.periodo, TB_TURMA.turma"
        Else
            strSql = "Select TB_TURMA.turma, TB_TURMA.periodo,TB_TURMA.id_turma" & vbNewLine &
                "From TB_TURMA INNER Join" & vbNewLine &
                "TB_PROFESSOR_DISCIPLINA_TURMA On TB_TURMA.id_turma = TB_PROFESSOR_DISCIPLINA_TURMA.id_turma INNER JOIN" & vbNewLine &
                "TB_PROFESSOR_DISCIPLINA On TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp = TB_PROFESSOR_DISCIPLINA.id_prof_discp INNER JOIN" & vbNewLine &
                "TB_USUARIO On TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario" & vbNewLine &
                "WHERE TB_TURMA.turma Like '%'+@turma+'%' and TB_TURMA.periodo like '%'+@periodo+'%' and TB_TURMA.ano like '%'+@ano+'%' and TB_USUARIO.id_usuario = @id" & vbNewLine &
                "GROUP BY TB_TURMA.periodo, TB_TURMA.turma, TB_TURMA.id_turma" & vbNewLine &
                "ORDER BY TB_TURMA.periodo, TB_TURMA.turma"
        End If

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
        cmdTurma.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        cmdTurma.Parameters.AddWithValue("@id", id.ToString)
        Dim daTurma As New SqlClient.SqlDataAdapter(cmdTurma)
        Dim tblTurma As New DataTable
        daTurma.Fill(tblTurma)

        dgvTurma.DataSource = tblTurma
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
                cmbDisc.Enabled = True
                readerAluno.Close()
                Call AlunoBoletim()
                Call Verificarnotas()
            Else
                readerAluno.Close()
                Call consAluno()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnLimparAluno_Click(sender As Object, e As EventArgs) Handles btnLimparAluno.Click
        Call NotasFuncio.limparAlunos()
        Call NotasFuncio.limparNotas()
        If TipoUsu = "PROFESSOR" Then
            Call NotasFuncio.BlockBim()
        End If
        cmbDisc.SelectedIndex = 0
        numChamada = 0
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        strSql = "update TB_MASTER set bimestre = @bim, ano = @ano"
        Dim cmdMaster As New SqlClient.SqlCommand
        cmdMaster.Connection = cnn
        cmdMaster.CommandText = strSql

        cmdMaster.Parameters.AddWithValue("@bim", cmbBimestre.Text)
        cmdMaster.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
        Try
            cmdMaster.ExecuteNonQuery()
            Call Master()
            MessageBox.Show("ALTERADO COM SUCESSO! " & vbNewLine & Err.Description, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbBimestre.BackColor = SystemColors.InactiveCaption
            mtbAnoTurma.BackColor = SystemColors.InactiveCaption
            anoAtual = mtbAnoTurma.Text
            BimAtual = cmbBimestre.Text
            Call PreencherGridTurma()
        Catch ex As Exception
            MessageBox.Show("Erro: " & vbNewLine & Err.Description, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        cmdMaster.Parameters.Clear()
    End Sub

    Private Sub btn1Bim_Click(sender As Object, e As EventArgs) Handles btn1Bim.Click
        strBim = "1"
        If TipoUsu = "MASTER" Then
            If txt1Bim.Text <> "" Then
                Call delNotas()
                Exit Sub
            Else
                MessageBox.Show("NADA PARA SER EXCLUIDO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else

            If Val(Replace(txt1Bim.Text.ToString, ",", ".")) > 10 Then
                MessageBox.Show("VALOR MAIOR QUE 10!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt1Bim.Focus()
                Exit Sub
            End If
            Dim contChar As String()
            contChar = Split(Replace(txt1Bim.Text.ToString, ",", "."), ".")
            Dim contTotal As Integer = -1
            For Each cont In contChar
                contTotal += 1
            Next
            If contTotal > 1 Then
                MessageBox.Show("MAIS DE UM PONTO OU VÍRGULA!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt1Bim.Focus()
                Exit Sub
            End If
            Dim localizaPonto As Integer = InStr(1, Replace(txt1Bim.Text.ToString, ",", "."), ".")

            If localizaPonto = 1 Then
                MessageBox.Show("PONTO OU VÍRGULA NO LOCAL ERRADO!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt1Bim.Focus()
                Exit Sub
            End If
            Dim notas As String = 0
            If Val(txt1Bim.Text) = 0 Then
                notas = 0
            Else
                notas = Replace(txt1Bim.Text, ",", ".")
            End If
            If MessageBox.Show("DESEJA MESMO SALVAR?" & vbNewLine & vbNewLine & mtbAnoTurma.Text & vbNewLine & cmbBimestre.Text & vbNewLine & "TURMA: " & txtTurma.Text & vbNewLine & "ALUNO: " & txtNomeAluno.Text & vbNewLine & "DISCIPLINA: " & cmbDisc.Text & vbNewLine & "NOTA: " & notas.ToString & vbNewLine & "FALTAS: " & mtbFaltas1bim.Text, "SALVAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                strSql = "select id_discp from TB_DISCP where disciplina = @discp"

                Dim cmdDiscp As New SqlClient.SqlCommand
                cmdDiscp.Connection = cnn
                cmdDiscp.CommandText = strSql
                cmdDiscp.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
                idDiscp = cmdDiscp.ExecuteScalar()

                Dim cmd1bimExist As New SqlClient.SqlCommand
                strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp"
                cmd1bimExist.Connection = cnn
                cmd1bimExist.CommandText = strSql

                cmd1bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmd1bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmd1bimExist.Parameters.AddWithValue("@bimestre", "1")
                cmd1bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Dim dacmd1bimExist As New SqlClient.SqlDataAdapter(cmd1bimExist)
                Dim reader1bimExist As SqlDataReader = cmd1bimExist.ExecuteReader()
                reader1bimExist.Read()
                If reader1bimExist.HasRows = True Then
                    If reader1bimExist.GetValue(0) Is DBNull.Value And reader1bimExist.GetValue(1).ToString = "1" And reader1bimExist.GetValue(2) = mtbAnoTurma.Text Then
                        reader1bimExist.Close()
                        cmd1bimExist.Parameters.Clear()
                        Dim cmdDel As New SqlClient.SqlCommand
                        strSql = "delete from TB_BOLETIM where id_matricula = @id and ano = @ano and bimestre = @bim "
                        cmdDel.Connection = cnn
                        cmdDel.CommandText = strSql
                        cmdDel.Parameters.AddWithValue("@id", idAluno.ToString)
                        cmdDel.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                        cmdDel.Parameters.AddWithValue("@bim", strBim.ToString)

                        Try
                            cmdDel.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        cmdDel.Parameters.Clear()
                    Else
                        reader1bimExist.Close()
                        cmd1bimExist.Parameters.Clear()
                    End If
                Else
                    reader1bimExist.Close()
                    cmd1bimExist.Parameters.Clear()
                End If

                Dim cmdNotas As New SqlClient.SqlCommand
                strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
                cmdNotas.Connection = cnn
                cmdNotas.CommandText = strSql
                cmdNotas.Parameters.AddWithValue("@nota", notas.ToString)
                If Val(mtbFaltas1bim.Text) = 0 Then
                    cmdNotas.Parameters.AddWithValue("@faltas", DBNull.Value)
                Else
                    cmdNotas.Parameters.AddWithValue("@faltas", mtbFaltas1bim.Text.ToString.Trim)
                End If
                cmdNotas.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmdNotas.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmdNotas.Parameters.AddWithValue("@bimestre", strBim.ToString)
                cmdNotas.Parameters.AddWithValue("@id_turma", idTurma.ToString)
                cmdNotas.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Try
                    cmdNotas.ExecuteNonQuery()
                    Call Verificarnotas()
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdNotas.Parameters.Clear()
            End If
        End If

    End Sub

    Private Sub btn2Bim_Click(sender As Object, e As EventArgs) Handles btn2Bim.Click
        strBim = "2"
        If TipoUsu = "MASTER" Then
            If txt2Bim.Text <> "" Then
                Call delNotas()
                Exit Sub
            Else
                MessageBox.Show("NADA PARA SER EXCLUIDO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else

            If Val(Replace(txt2Bim.Text.ToString, ",", ".")) > 10 Then
                MessageBox.Show("VALOR MAIOR QUE 10!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt2Bim.Focus()
                Exit Sub
            End If
            Dim contChar As String()
            contChar = Split(Replace(txt2Bim.Text.ToString, ",", "."), ".")
            Dim contTotal As Integer = -1
            For Each cont In contChar
                contTotal += 1
            Next
            If contTotal > 1 Then
                MessageBox.Show("MAIS DE UM PONTO OU VÍRGULA!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt2Bim.Focus()
                Exit Sub
            End If
            Dim localizaPonto As Integer = InStr(1, Replace(txt2Bim.Text.ToString, ",", "."), ".")

            If localizaPonto = 1 Then
                MessageBox.Show("PONTO OU VÍRGULA NO LOCAL ERRADO!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt2Bim.Focus()
                Exit Sub
            End If
            Dim notas As String = 0
            If Val(txt2Bim.Text) = 0 Then
                notas = 0
            Else
                notas = Replace(txt2Bim.Text, ",", ".")
            End If
            If MessageBox.Show("DESEJA MESMO SALVAR?" & vbNewLine & vbNewLine & mtbAnoTurma.Text & vbNewLine & cmbBimestre.Text & vbNewLine & "TURMA: " & txtTurma.Text & vbNewLine & "ALUNO: " & txtNomeAluno.Text & vbNewLine & "DISCIPLINA: " & cmbDisc.Text & vbNewLine & "NOTA: " & notas.ToString & vbNewLine & "FALTAS: " & mtbFaltas2bim.Text, "SALVAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                strSql = "select id_discp from TB_DISCP where disciplina = @discp"

                Dim cmdDiscp As New SqlClient.SqlCommand
                cmdDiscp.Connection = cnn
                cmdDiscp.CommandText = strSql
                cmdDiscp.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
                idDiscp = cmdDiscp.ExecuteScalar()

                If Val(txt1Bim.Text) = 0 Then

                    Dim cmd1bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                    cmd1bimExist.Connection = cnn
                    cmd1bimExist.CommandText = strSql

                    cmd1bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@bimestre", "1")
                    cmd1bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da1bimExist As New SqlClient.SqlDataAdapter(cmd1bimExist)
                    Dim reader1bimExist As SqlDataReader = cmd1bimExist.ExecuteReader()
                    reader1bimExist.Read()

                    If reader1bimExist.HasRows = True Then
                        If reader1bimExist.GetValue(0) Is DBNull.Value And reader1bimExist.GetValue(1).ToString = "1" And reader1bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                        Else
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                            Call Bim1Null()
                        End If
                    Else
                        reader1bimExist.Close()
                        cmd1bimExist.Parameters.Clear()
                        Call Bim1Null()
                    End If
                End If

                Dim cmd2bimExist As New SqlClient.SqlCommand
                strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                cmd2bimExist.Connection = cnn
                cmd2bimExist.CommandText = strSql

                cmd2bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmd2bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmd2bimExist.Parameters.AddWithValue("@bimestre", "2")
                cmd2bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Dim da2bimExist As New SqlClient.SqlDataAdapter(cmd2bimExist)
                Dim reader2bimExist As SqlDataReader = cmd2bimExist.ExecuteReader()
                reader2bimExist.Read()
                If reader2bimExist.HasRows = True Then
                    If reader2bimExist.GetValue(0) Is DBNull.Value And reader2bimExist.GetValue(1).ToString = "2" And reader2bimExist.GetValue(2) = mtbAnoTurma.Text Then
                        reader2bimExist.Close()
                        cmd2bimExist.Parameters.Clear()
                        Dim cmdDel As New SqlClient.SqlCommand
                        strSql = "delete from TB_BOLETIM where id_matricula = @id and ano = @ano and bimestre = @bim "
                        cmdDel.Connection = cnn
                        cmdDel.CommandText = strSql
                        cmdDel.Parameters.AddWithValue("@id", idAluno.ToString)
                        cmdDel.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                        cmdDel.Parameters.AddWithValue("@bim", strBim.ToString)

                        Try
                            cmdDel.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        cmdDel.Parameters.Clear()
                    Else
                        reader2bimExist.Close()
                        cmd2bimExist.Parameters.Clear()
                    End If
                Else
                    reader2bimExist.Close()
                    cmd2bimExist.Parameters.Clear()
                End If

                Dim cmdNotas As New SqlClient.SqlCommand
                strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
                cmdNotas.Connection = cnn
                cmdNotas.CommandText = strSql
                cmdNotas.Parameters.AddWithValue("@nota", notas.ToString)
                If Val(mtbFaltas2bim.Text) = 0 Then
                    cmdNotas.Parameters.AddWithValue("@faltas", DBNull.Value)
                Else
                    cmdNotas.Parameters.AddWithValue("@faltas", mtbFaltas2bim.Text.ToString.Trim)
                End If
                cmdNotas.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmdNotas.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmdNotas.Parameters.AddWithValue("@bimestre", strBim.ToString)
                cmdNotas.Parameters.AddWithValue("@id_turma", idTurma.ToString)
                cmdNotas.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Try
                    cmdNotas.ExecuteNonQuery()
                    Call Verificarnotas()
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                cmdNotas.Parameters.Clear()
            End If
        End If
    End Sub

    Private Sub btn3Bim_Click(sender As Object, e As EventArgs) Handles btn3Bim.Click
        strBim = "3"
        If TipoUsu = "MASTER" Then
            If txt3Bim.Text <> "" Then
                Call delNotas()
                Exit Sub
            Else
                MessageBox.Show("NADA PARA SER EXCLUIDO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else

            If Val(Replace(txt3Bim.Text.ToString, ",", ".")) > 10 Then
                MessageBox.Show("VALOR MAIOR QUE 10!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt3Bim.Focus()
                Exit Sub
            End If
            Dim contChar As String()
            contChar = Split(Replace(txt3Bim.Text.ToString, ",", "."), ".")
            Dim contTotal As Integer = -1
            For Each cont In contChar
                contTotal += 1
            Next
            If contTotal > 1 Then
                MessageBox.Show("MAIS DE UM PONTO OU VÍRGULA!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt3Bim.Focus()
                Exit Sub
            End If
            Dim localizaPonto As Integer = InStr(1, Replace(txt3Bim.Text.ToString, ",", "."), ".")

            If localizaPonto = 1 Then
                MessageBox.Show("PONTO OU VÍRGULA NO LOCAL ERRADO!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt3Bim.Focus()
                Exit Sub
            End If
            Dim notas As String = 0
            If Val(txt3Bim.Text) = 0 Then
                notas = 0
            Else
                notas = Replace(txt3Bim.Text, ",", ".")
            End If
            If MessageBox.Show("DESEJA MESMO SALVAR?" & vbNewLine & vbNewLine & mtbAnoTurma.Text & vbNewLine & cmbBimestre.Text & vbNewLine & "TURMA: " & txtTurma.Text & vbNewLine & "ALUNO: " & txtNomeAluno.Text & vbNewLine & "DISCIPLINA: " & cmbDisc.Text & vbNewLine & "NOTA: " & notas.ToString & vbNewLine & "FALTAS: " & mtbFaltas3bim.Text, "SALVAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                strSql = "select id_discp from TB_DISCP where disciplina = @discp"

                Dim cmdDiscp As New SqlClient.SqlCommand
                cmdDiscp.Connection = cnn
                cmdDiscp.CommandText = strSql
                cmdDiscp.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
                idDiscp = cmdDiscp.ExecuteScalar()

                If Val(txt1Bim.Text) = 0 Then
                    Dim cmd1bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp"
                    cmd1bimExist.Connection = cnn
                    cmd1bimExist.CommandText = strSql

                    cmd1bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@bimestre", "1")
                    cmd1bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da1bimExist As New SqlClient.SqlDataAdapter(cmd1bimExist)
                    Dim reader1bimExist As SqlDataReader = cmd1bimExist.ExecuteReader()
                    reader1bimExist.Read()

                    If reader1bimExist.HasRows = True Then
                        If reader1bimExist.GetValue(0) Is DBNull.Value And reader1bimExist.GetValue(1).ToString = "1" And reader1bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                        Else
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                            Call Bim1Null()
                        End If
                    Else
                        reader1bimExist.Close()
                        cmd1bimExist.Parameters.Clear()
                        Call Bim1Null()
                    End If
                End If

                If Val(txt2Bim.Text) = 0 Then
                    Dim cmd2bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                    cmd2bimExist.Connection = cnn
                    cmd2bimExist.CommandText = strSql

                    cmd2bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd2bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd2bimExist.Parameters.AddWithValue("@bimestre", "2")
                    cmd2bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da2bimExist As New SqlClient.SqlDataAdapter(cmd2bimExist)
                    Dim reader2bimExist As SqlDataReader = cmd2bimExist.ExecuteReader()
                    reader2bimExist.Read()

                    If reader2bimExist.HasRows = True Then
                        If reader2bimExist.GetValue(0) Is DBNull.Value And reader2bimExist.GetValue(1).ToString = "2" And reader2bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader2bimExist.Close()
                            cmd2bimExist.Parameters.Clear()
                        Else
                            reader2bimExist.Close()
                            cmd2bimExist.Parameters.Clear()
                            Call Bim2Null()
                        End If
                    Else
                        reader2bimExist.Close()
                        cmd2bimExist.Parameters.Clear()
                        Call Bim2Null()
                    End If
                End If

                Dim cmd3bimExist As New SqlClient.SqlCommand
                strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                cmd3bimExist.Connection = cnn
                cmd3bimExist.CommandText = strSql

                cmd3bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmd3bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmd3bimExist.Parameters.AddWithValue("@bimestre", "3")
                cmd3bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Dim da3bimExist As New SqlClient.SqlDataAdapter(cmd3bimExist)
                Dim reader3bimExist As SqlDataReader = cmd3bimExist.ExecuteReader()
                reader3bimExist.Read()
                If reader3bimExist.HasRows = True Then
                    If reader3bimExist.GetValue(0) Is DBNull.Value And reader3bimExist.GetValue(1).ToString = "3" And reader3bimExist.GetValue(2) = mtbAnoTurma.Text Then
                        reader3bimExist.Close()
                        cmd3bimExist.Parameters.Clear()
                        Dim cmdDel As New SqlClient.SqlCommand
                        strSql = "delete from TB_BOLETIM where id_matricula = @id and ano = @ano and bimestre = @bim "
                        cmdDel.Connection = cnn
                        cmdDel.CommandText = strSql
                        cmdDel.Parameters.AddWithValue("@id", idAluno.ToString)
                        cmdDel.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                        cmdDel.Parameters.AddWithValue("@bim", strBim.ToString)

                        Try
                            cmdDel.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        cmdDel.Parameters.Clear()
                    Else
                        reader3bimExist.Close()
                        cmd3bimExist.Parameters.Clear()
                    End If
                Else
                    reader3bimExist.Close()
                    cmd3bimExist.Parameters.Clear()
                End If

                Dim cmdNotas As New SqlClient.SqlCommand
                strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
                cmdNotas.Connection = cnn
                cmdNotas.CommandText = strSql
                cmdNotas.Parameters.AddWithValue("@nota", notas.ToString)
                If Val(mtbFaltas3bim.Text) = 0 Then
                    cmdNotas.Parameters.AddWithValue("@faltas", DBNull.Value)
                Else
                    cmdNotas.Parameters.AddWithValue("@faltas", mtbFaltas3bim.Text.ToString.Trim)
                End If
                cmdNotas.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmdNotas.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmdNotas.Parameters.AddWithValue("@bimestre", strBim.ToString)
                cmdNotas.Parameters.AddWithValue("@id_turma", idTurma.ToString)
                cmdNotas.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Try
                    cmdNotas.ExecuteNonQuery()
                    Call Verificarnotas()
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                cmdNotas.Parameters.Clear()
            End If
        End If
    End Sub

    Private Sub btn4Bim_Click(sender As Object, e As EventArgs) Handles btn4Bim.Click
        strBim = "4"
        If TipoUsu = "MASTER" Then
            If txt4bim.Text <> "" Then
                Call delNotas()
                Exit Sub
            Else
                MessageBox.Show("NADA PARA SER EXCLUIDO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else

            If Val(Replace(txt4bim.Text.ToString, ",", ".")) > 10 Then
                MessageBox.Show("VALOR MAIOR QUE 10!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt4bim.Focus()
                Exit Sub
            End If
            Dim contChar As String()
            contChar = Split(Replace(txt4bim.Text.ToString, ",", "."), ".")
            Dim contTotal As Integer = -1
            For Each cont In contChar
                contTotal += 1
            Next
            If contTotal > 1 Then
                MessageBox.Show("MAIS DE UM PONTO OU VÍRGULA!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt4bim.Focus()
                Exit Sub
            End If
            Dim localizaPonto As Integer = InStr(1, Replace(txt4bim.Text.ToString, ",", "."), ".")

            If localizaPonto = 1 Then
                MessageBox.Show("PONTO OU VÍRGULA NO LOCAL ERRADO!", "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt4bim.Focus()
                Exit Sub
            End If
            Dim notas As String = 0
            If Val(txt4bim.Text) = 0 Then
                notas = 0
            Else
                notas = Replace(txt4bim.Text, ",", ".")
            End If
            If MessageBox.Show("DESEJA MESMO SALVAR?" & vbNewLine & vbNewLine & mtbAnoTurma.Text & vbNewLine & cmbBimestre.Text & vbNewLine & "TURMA: " & txtTurma.Text & vbNewLine & "ALUNO: " & txtNomeAluno.Text & vbNewLine & "DISCIPLINA: " & cmbDisc.Text & vbNewLine & "NOTA: " & notas.ToString & vbNewLine & "FALTAS: " & mtbFaltas4bim.Text, "SALVAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                strSql = "select id_discp from TB_DISCP where disciplina = @discp"

                Dim cmdDiscp As New SqlClient.SqlCommand
                cmdDiscp.Connection = cnn
                cmdDiscp.CommandText = strSql
                cmdDiscp.Parameters.AddWithValue("@discp", cmbDisc.Text.ToString)
                idDiscp = cmdDiscp.ExecuteScalar()

                If Val(txt1Bim.Text) = 0 Then
                    Dim cmd1bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp"
                    cmd1bimExist.Connection = cnn
                    cmd1bimExist.CommandText = strSql

                    cmd1bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd1bimExist.Parameters.AddWithValue("@bimestre", "1")
                    cmd1bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da1bimExist As New SqlClient.SqlDataAdapter(cmd1bimExist)
                    Dim reader1bimExist As SqlDataReader = cmd1bimExist.ExecuteReader()
                    reader1bimExist.Read()

                    If reader1bimExist.HasRows = True Then
                        If reader1bimExist.GetValue(0) Is DBNull.Value And reader1bimExist.GetValue(1).ToString = "1" And reader1bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                        Else
                            reader1bimExist.Close()
                            cmd1bimExist.Parameters.Clear()
                            Call Bim1Null()
                        End If
                    Else
                        reader1bimExist.Close()
                        cmd1bimExist.Parameters.Clear()
                        Call Bim1Null()
                    End If
                End If

                If Val(txt2Bim.Text) = 0 Then
                    Dim cmd2bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                    cmd2bimExist.Connection = cnn
                    cmd2bimExist.CommandText = strSql

                    cmd2bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd2bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd2bimExist.Parameters.AddWithValue("@bimestre", "2")
                    cmd2bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da2bimExist As New SqlClient.SqlDataAdapter(cmd2bimExist)
                    Dim reader2bimExist As SqlDataReader = cmd2bimExist.ExecuteReader()
                    reader2bimExist.Read()

                    If reader2bimExist.HasRows = True Then
                        If reader2bimExist.GetValue(0) Is DBNull.Value And reader2bimExist.GetValue(1).ToString = "2" And reader2bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader2bimExist.Close()
                            cmd2bimExist.Parameters.Clear()
                        Else
                            reader2bimExist.Close()
                            cmd2bimExist.Parameters.Clear()
                            Call Bim2Null()
                        End If
                    Else
                        reader2bimExist.Close()
                        cmd2bimExist.Parameters.Clear()
                        Call Bim2Null()
                    End If
                End If

                If Val(txt3Bim.Text) = 0 Then
                    Dim cmd3bimExist As New SqlClient.SqlCommand
                    strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp"
                    cmd3bimExist.Connection = cnn
                    cmd3bimExist.CommandText = strSql

                    cmd3bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                    cmd3bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                    cmd3bimExist.Parameters.AddWithValue("@bimestre", "3")
                    cmd3bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                    Dim da3bimExist As New SqlClient.SqlDataAdapter(cmd3bimExist)
                    Dim reader3bimExist As SqlDataReader = cmd3bimExist.ExecuteReader()
                    reader3bimExist.Read()

                    If reader3bimExist.HasRows = True Then
                        If reader3bimExist.GetValue(0) Is DBNull.Value And reader3bimExist.GetValue(1).ToString = "3" And reader3bimExist.GetValue(2) = mtbAnoTurma.Text Then
                            reader3bimExist.Close()
                            cmd3bimExist.Parameters.Clear()
                        Else
                            reader3bimExist.Close()
                            cmd3bimExist.Parameters.Clear()
                            Call Bim3Null()
                        End If
                    Else
                        reader3bimExist.Close()
                        cmd3bimExist.Parameters.Clear()
                        Call Bim3Null()
                    End If
                End If

                Dim cmd4bimExist As New SqlClient.SqlCommand
                strSql = "SELECT nota, bimestre, ano FROM TB_BOLETIM WHERE ano = @ano and bimestre = @bimestre and id_matricula = @id_matricula and id_discp = @id_discp "
                cmd4bimExist.Connection = cnn
                cmd4bimExist.CommandText = strSql

                cmd4bimExist.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmd4bimExist.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmd4bimExist.Parameters.AddWithValue("@bimestre", "4")
                cmd4bimExist.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Dim da4bimExist As New SqlClient.SqlDataAdapter(cmd4bimExist)
                Dim reader4bimExist As SqlDataReader = cmd4bimExist.ExecuteReader()
                reader4bimExist.Read()
                If reader4bimExist.HasRows = True Then
                    If reader4bimExist.GetValue(0) Is DBNull.Value And reader4bimExist.GetValue(1).ToString = "4" And reader4bimExist.GetValue(2) = mtbAnoTurma.Text Then
                        reader4bimExist.Close()
                        cmd4bimExist.Parameters.Clear()
                        Dim cmdDel As New SqlClient.SqlCommand
                        strSql = "delete from TB_BOLETIM where id_matricula = @id and ano = @ano and bimestre = @bim "
                        cmdDel.Connection = cnn
                        cmdDel.CommandText = strSql
                        cmdDel.Parameters.AddWithValue("@id", idAluno.ToString)
                        cmdDel.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                        cmdDel.Parameters.AddWithValue("@bim", strBim.ToString)

                        Try
                            cmdDel.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        cmdDel.Parameters.Clear()
                    Else
                        reader4bimExist.Close()
                        cmd4bimExist.Parameters.Clear()
                    End If
                Else
                    reader4bimExist.Close()
                    cmd4bimExist.Parameters.Clear()
                End If

                Dim cmdNotas As New SqlClient.SqlCommand
                strSql = "INSERT INTO TB_BOLETIM (nota, faltas, ano, id_matricula, bimestre, id_turma, id_discp) VALUES (@nota, @faltas, @ano, @id_matricula, @bimestre, @id_turma, @id_discp)"
                cmdNotas.Connection = cnn
                cmdNotas.CommandText = strSql
                cmdNotas.Parameters.AddWithValue("@nota", notas.ToString)
                If Val(mtbFaltas4bim.Text) = 0 Then
                    cmdNotas.Parameters.AddWithValue("@faltas", DBNull.Value)
                Else
                    cmdNotas.Parameters.AddWithValue("@faltas", mtbFaltas4bim.Text.ToString.Trim)
                End If
                cmdNotas.Parameters.AddWithValue("@ano", mtbAnoTurma.Text.ToString)
                cmdNotas.Parameters.AddWithValue("@id_matricula", idAluno.ToString)
                cmdNotas.Parameters.AddWithValue("@bimestre", strBim.ToString)
                cmdNotas.Parameters.AddWithValue("@id_turma", idTurma.ToString)
                cmdNotas.Parameters.AddWithValue("@id_discp", idDiscp.ToString)
                Try
                    cmdNotas.ExecuteNonQuery()
                    Call Verificarnotas()
                Catch ex As Exception
                    MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTAS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                cmdNotas.Parameters.Clear()
            End If
        End If
    End Sub

    Private Sub txt1Bim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1Bim.KeyPress
        Dim localizaPonto As Integer = InStr(1, Replace(txt1Bim.Text.ToString, ",", "."), ".")
        If localizaPonto > 0 Then
            Dim intLen As Integer = Len(txt1Bim.Text)
            txt1Bim.MaxLength = localizaPonto + 1
        Else
            txt1Bim.MaxLength = 2
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(NotasFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub txt2Bim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2Bim.KeyPress
        Dim localizaPonto As Integer = InStr(1, Replace(txt2Bim.Text.ToString, ",", "."), ".")
        If localizaPonto > 0 Then
            Dim intLen As Integer = Len(txt2Bim.Text)
            txt2Bim.MaxLength = localizaPonto + 1
        Else
            txt2Bim.MaxLength = 2
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(NotasFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub txt3Bim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3Bim.KeyPress
        Dim localizaPonto As Integer = InStr(1, Replace(txt3Bim.Text.ToString, ",", "."), ".")
        If localizaPonto > 0 Then
            Dim intLen As Integer = Len(txt3Bim.Text)
            txt3Bim.MaxLength = localizaPonto + 1
        Else
            txt3Bim.MaxLength = 2
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(NotasFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub txt4bim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt4bim.KeyPress
        Dim localizaPonto As Integer = InStr(1, Replace(txt4bim.Text.ToString, ",", "."), ".")
        If localizaPonto > 0 Then
            Dim intLen As Integer = Len(txt4bim.Text)
            txt4bim.MaxLength = localizaPonto + 1
        Else
            txt4bim.MaxLength = 2
        End If

        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(NotasFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True
        End If
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtMatricula.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
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
End Class