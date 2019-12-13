Public Class FrmConsProf

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private idProf As Integer
    Public filtar As Boolean = False
    Public Property confirm As Boolean
    Private consultar As Boolean = False

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

    Public Property GetcolIDprof As Integer
        Get
            GetcolIDprof = dgvProf.CurrentRow.Cells("colIDprof").Value
        End Get
        Set(Value As Integer)

        End Set
    End Property

    Public Property GetcolNomeprof As String
        Get
            GetcolNomeprof = dgvProf.CurrentRow.Cells("colNomeProf").Value
        End Get
        Set(Value As String)

        End Set
    End Property

    Sub preencherGridProf()
        Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
        If filtar = True Then
            strSql = "Select * from tb_usuario where tipo_usuario = 'PROFESSOR' and nome_usuario = @nome and dt_nasc = @dt_nasc"
            cmdProf = New SqlClient.SqlCommand(strSql, cnn)
            cmdProf.Parameters.AddWithValue("@nome", Home.cadastros.txtNome.Text.ToString)
            cmdProf.Parameters.AddWithValue("@dt_nasc", Home.cadastros.mtbDtNasc.Text.ToString)
            filtar = False
        Else
            If consultar = True Then
                strSql = "Select * From TB_USUARIO WHERE nome_usuario like '%'+@nome+'%' ORDER BY nome_usuario"
                cmdProf = New SqlClient.SqlCommand(strSql, cnn)
                cmdProf.Parameters.AddWithValue("@nome", txtNome.Text.ToString)
                consultar = False
            ElseIf txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
                strSql = "Select * From TB_USUARIO WHERE tipo_usuario = 'PROFESSOR' ORDER BY nome_usuario"
                cmdProf = New SqlClient.SqlCommand(strSql, cnn)
            End If
        End If
        Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
        Dim tblProf As New DataTable
        daProf.Fill(tblProf)

        dgvProf.DataSource = tblProf
    End Sub

    Sub preencherGridDisc()
        strSql = " SELECT        TB_DISCP.disciplina, TB_DISCP.id_discp" & vbNewLine &
                 "FROM            TB_USUARIO INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN" & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE TB_USUARIO.id_usuario = @id" & vbNewLine &
                 "ORDER BY TB_DISCP.disciplina"

        Dim cmdDisc As New SqlClient.SqlCommand(strSql, cnn)
        cmdDisc.Parameters.AddWithValue("@id", idProf.ToString)
        Dim daDisc As New SqlClient.SqlDataAdapter(cmdDisc)
        Dim tblDisc As New DataTable
        daDisc.Fill(tblDisc)

        dgvDisc.DataSource = tblDisc
    End Sub

    Private Sub FrmConsProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call preencherGridProf()
    End Sub

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub dgvProf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProf.CellClick
        idProf = dgvProf.CurrentRow.Cells("colIDProf").Value
        txtNome.Text = dgvProf.CurrentRow.Cells("colNomeProf").Value
        txtNome.ForeColor = Color.Black
        Call preencherGridDisc()
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

    Private Sub btnCons_Click(sender As Object, e As EventArgs) Handles btnCons.Click
        If txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
            consultar = False
        Else
            consultar = True
        End If
        Call preencherGridProf()
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