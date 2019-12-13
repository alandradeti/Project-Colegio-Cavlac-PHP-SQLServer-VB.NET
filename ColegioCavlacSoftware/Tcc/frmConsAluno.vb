Public Class frmConsAluno

    Public filtrar As Boolean = False
    Public Turma As Boolean = False
    Public obs As Boolean = False
    Private consultar As Boolean = False
    Public Property confirm As Boolean

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private Sub txtNome_GotFocus(sender As Object, e As EventArgs) Handles txtNome.GotFocus
        If txtNome.Text = "Digite o nome" Then
            txtNome.Text = ""
            txtNome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtnome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        If txtNome.Text = "" Then
            txtNome.Text = "Digite o nome"
            txtNome.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Public Property GetcolIDAluno As Integer
        Get
            GetcolIDAluno = dgvAluno.CurrentRow.Cells("colIDAluno").Value
        End Get
        Set(Value As Integer)

        End Set
    End Property

    Public Property GetcolNomeAluno As String
        Get
            GetcolNomeAluno = dgvAluno.CurrentRow.Cells("colNomeAluno").Value
        End Get
        Set(Value As String)

        End Set
    End Property

    Sub preencherGridAlunoTurma()
        Dim cmdAlunoTurma As New SqlClient.SqlCommand(strSql, cnn)

        If consultar = True Then
            strSql = "SELECT TB_ALUNO.nome_aluno, TB_ALUNO.dt_nasc, TB_ALUNO.id_matricula" & vbNewLine & _
                     "FROM TB_ALUNO INNER JOIN" & vbNewLine & _
                     "TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN" & vbNewLine & _
                     "TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma" & vbNewLine & _
                     "WHERE (TB_TURMA.id_turma = @id and TB_ALUNO.nome_aluno like'%'+@nome+'%')"
            cmdAlunoTurma = New SqlClient.SqlCommand(strSql, cnn)
            If obs = True Then
                cmdAlunoTurma.Parameters.AddWithValue("@id", AlunoObs.idTurma)
                cmdAlunoTurma.Parameters.AddWithValue("@nome", txtNome.Text.ToString)
            Else
                cmdAlunoTurma.Parameters.AddWithValue("@id", FrmNotas.idTurma)
                cmdAlunoTurma.Parameters.AddWithValue("@nome", txtNome.Text.ToString)
            End If
        Else
            strSql = "SELECT TB_ALUNO.nome_aluno, TB_ALUNO.dt_nasc, TB_ALUNO.id_matricula" & vbNewLine & _
                 "FROM TB_ALUNO INNER JOIN" & vbNewLine & _
                 "TB_ALUNO_TURMA ON TB_ALUNO.id_matricula = TB_ALUNO_TURMA.id_matricula INNER JOIN" & vbNewLine & _
                 "TB_TURMA ON TB_ALUNO_TURMA.id_turma = TB_TURMA.id_turma" & vbNewLine & _
                 "WHERE (TB_TURMA.id_turma = @id)"
            cmdAlunoTurma = New SqlClient.SqlCommand(strSql, cnn)
            If obs = True Then
                cmdAlunoTurma.Parameters.AddWithValue("@id", AlunoObs.idTurma)
            Else
                cmdAlunoTurma.Parameters.AddWithValue("@id", FrmNotas.idTurma)
            End If
        End If
        Dim daAlunoTurma As New SqlClient.SqlDataAdapter(cmdAlunoTurma)
        Dim tblAlunoTurma As New DataTable
        daAlunoTurma.Fill(tblAlunoTurma)

        dgvAluno.DataSource = tblAlunoTurma
    End Sub

    Sub preencherGridAluno()
        Dim cmdAluno As New SqlClient.SqlCommand(strSql, cnn)
        If filtrar = True Then
            strSql = "Select * from tb_aluno where nome_aluno = @nome and dt_nasc = @dt_nasc"
            cmdAluno = New SqlClient.SqlCommand(strSql, cnn)
            cmdAluno.Parameters.AddWithValue("@nome", Home.cadastros.txtNome.Text.ToString)
            cmdAluno.Parameters.AddWithValue("@dt_nasc", Home.cadastros.mtbDtNasc.Text.ToString)
            filtrar = False
        Else
            If consultar = True Then
                strSql = "Select * From TB_ALUNO WHERE nome_aluno like '%'+@nome+'%' ORDER BY nome_aluno"
                cmdAluno = New SqlClient.SqlCommand(strSql, cnn)
                cmdAluno.Parameters.AddWithValue("@nome", txtNome.Text.ToString)
                consultar = False
            ElseIf txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
                strSql = "Select * From TB_ALUNO ORDER BY nome_aluno"
                cmdAluno = New SqlClient.SqlCommand(strSql, cnn)
            End If
        End If
        Dim daAluno As New SqlClient.SqlDataAdapter(cmdAluno)
        Dim tblAluno As New DataTable
        daAluno.Fill(tblAluno)

        dgvAluno.DataSource = tblAluno
    End Sub

    Private Sub frmConsAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Turma = True Then
            Call preencherGridAlunoTurma()
        Else
            Call preencherGridAluno()
        End If
        btnOk.Enabled = False
    End Sub

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.confirm = True
        Me.Hide()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Call limpar()
    End Sub

    Sub limpar()
        txtNome.Text = "Digite o nome"
        txtNome.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub dgvAluno_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAluno.CellClick
        txtNome.Text = dgvAluno.CurrentRow.Cells("colNomeAluno").Value
        txtNome.ForeColor = Color.Black
        btnOk.Enabled = True
    End Sub

    Private Sub btnCons_Click(sender As Object, e As EventArgs) Handles btnCons.Click
        If txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
            consultar = False
        Else
            consultar = True
        End If
        If Turma = True Then
            Call preencherGridAlunoTurma()
            Exit Sub
        Else
            Call preencherGridAluno()
            Exit Sub
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

    Private Sub letras(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class