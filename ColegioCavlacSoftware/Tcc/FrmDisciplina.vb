Public Class FrmDisciplina

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private strAcao As String = "alterar"
    Public idDisc As Integer
    Public idProf As Integer
    Public click As Integer = 1
    Public cadastros As Boolean = False
    Public cadastrosNome As String
    Public cadastrosID As String
    Private idConsProf As String

    Sub consProf()
        Dim objConsProf As New FrmConsProf
        objConsProf.ShowDialog()
        If objConsProf.confirm = True Then
            txtCodProf.Text = objConsProf.GetcolIDprof().ToString
            txtNomeProf.Text = objConsProf.GetcolNomeprof().ToString
            btnAddProf.Enabled = True
        End If
    End Sub

    Private Sub txtDisciplina_GotFocus(sender As Object, e As EventArgs) Handles txtDisciplina.GotFocus
        If txtDisciplina.Text = "Digite a disciplina" Then
            txtDisciplina.Text = ""
            txtDisciplina.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDisciplina_LostFocus(sender As Object, e As EventArgs) Handles txtDisciplina.LostFocus
        If txtDisciplina.Text = "" Then
            txtDisciplina.Text = "Digite a disciplina"
            txtDisciplina.ForeColor = Color.LightSteelBlue
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

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Sub preencherGridDisc()
        strSql = "Select * From TB_DISCP ORDER BY disciplina"
        Dim cmdDisc As New SqlClient.SqlCommand(strSql, cnn)
        Dim daDisc As New SqlClient.SqlDataAdapter(cmdDisc)
        Dim tblDisc As New DataTable
        daDisc.Fill(tblDisc)

        dgvDisc.DataSource = tblDisc
    End Sub

    Sub preencherGridProf()
        strSql = "SELECT        TB_USUARIO.id_usuario, TB_USUARIO.dt_nasc, TB_USUARIO.nome_usuario " & vbNewLine &
                 "FROM          TB_USUARIO INNER JOIN " & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA ON TB_USUARIO.id_usuario = TB_PROFESSOR_DISCIPLINA.id_usuario INNER JOIN " & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE TB_DISCP.id_discp = @disciplina" & vbNewLine &
                 "ORDER BY TB_USUARIO.nome_usuario"
        Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
        cmdProf.Parameters.AddWithValue("@disciplina", dgvDisc.CurrentRow.Cells("colIDdisciplina").Value.ToString)
        Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
        Dim tblProf As New DataTable
        daProf.Fill(tblProf)

        dgvProf.DataSource = tblProf
    End Sub

    Private Sub FrmDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DiscpFuncio.load()
        Call preencherGridDisc()
        idConsProf = ""
    End Sub

    Private Sub dgvDisc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDisc.CellClick
        Call preencherGridProf()
        Call DiscpFuncio.consultaDisc()
        idDisc = dgvDisc.CurrentRow.Cells("colIDdisciplina").Value
        txtDisciplina.Text = dgvDisc.CurrentRow.Cells("colDisciplina").Value
        txtDisciplina.ForeColor = Color.Black
        strAcao = "alterar"
        btnConsProf.Enabled = True
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        strAcao = "incluir"
        Call DiscpFuncio.limparDisc()
        Call DiscpFuncio.novo()
        cadastros = False
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Call DiscpFuncio.limparProf()
        If DiscpFuncio.Gravar() Then
            Dim cmdDisc As New SqlClient.SqlCommand
            If strAcao = "incluir" Then
                strSql = "insert into TB_DISCP (disciplina) values (@disciplina)"

                cmdDisc.Connection = cnn
                cmdDisc.CommandText = strSql

                cmdDisc.Parameters.AddWithValue("@disciplina", txtDisciplina.Text.ToString.ToUpper)
                Try
                    cmdDisc.ExecuteNonQuery()
                    Call preencherGridDisc()
                    MessageBox.Show("ADICIONADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call DiscpFuncio.limparDisc()
                    Call DiscpFuncio.load()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdDisc.Parameters.Clear()
            Else
                strSql = "update TB_DISCP set disciplina = @disciplina where id_discp = @id"

                cmdDisc.Connection = cnn
                cmdDisc.CommandText = strSql

                cmdDisc.Parameters.AddWithValue("@disciplina", txtDisciplina.Text.ToString.ToUpper)
                cmdDisc.Parameters.AddWithValue("@id", idDisc.ToString)
                Try
                    cmdDisc.ExecuteNonQuery()
                    Call preencherGridDisc()
                    MessageBox.Show("ALTERADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call DiscpFuncio.limparDisc()
                    Call DiscpFuncio.load()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdDisc.Parameters.Clear()
            End If
        Else

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar?", "CANCELAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Call DiscpFuncio.load()
            Call DiscpFuncio.limparDisc()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnLimparDisc_Click(sender As Object, e As EventArgs) Handles btnLimparDisc.Click
        Call DiscpFuncio.limparDisc()
        Call DiscpFuncio.load()
        Call preencherGridDisc()
        Call preencherGridProf()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim cmdDisc As New SqlClient.SqlCommand
            strSql = "delete from TB_DISCP where id_discp = @id"
            cmdDisc.Connection = cnn
            cmdDisc.CommandText = strSql
            cmdDisc.Parameters.AddWithValue("@id", idDisc.ToString)
            Try
                cmdDisc.ExecuteNonQuery()
                Call preencherGridDisc()
                MessageBox.Show("REMOVIDO COM SUCESSO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call DiscpFuncio.limparDisc()
                Call DiscpFuncio.load()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdDisc.Parameters.Clear()

            Call DiscpFuncio.load()
            Call DiscpFuncio.limparDisc()
        End If
    End Sub

    Private Sub btnConsDisc_Click(sender As Object, e As EventArgs) Handles btnConsDisc.Click
        If txtDisciplina.Text = "Digite a disciplina" Or txtDisciplina.Text = "" Then
            Call preencherGridDisc()
        Else
            strSql = "select * from tb_discp where disciplina like '%'+@disciplina+'%'"
            Dim cmdDisc As New SqlClient.SqlCommand(strSql, cnn)
            cmdDisc.Parameters.AddWithValue("@disciplina", txtDisciplina.Text.ToString)
            Dim daDisc As New SqlClient.SqlDataAdapter(cmdDisc)
            Dim tblDisc As New DataTable
            daDisc.Fill(tblDisc)

            dgvDisc.DataSource = tblDisc
            cmdDisc.Parameters.Clear()
        End If
        Call DiscpFuncio.limparProf()
    End Sub

    Private Sub dgvProf_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProf.CellClick
        idProf = dgvProf.CurrentRow.Cells("colIDProf").Value
        txtCodProf.Text = dgvProf.CurrentRow.Cells("colIDprof").Value
        txtCodProf.ForeColor = Color.Black
        txtNomeProf.Text = dgvProf.CurrentRow.Cells("colNomeProf").Value
        txtNomeProf.ForeColor = Color.Black
        Call DiscpFuncio.botoes()
        btnRemoveProf.Enabled = True
        btnAddProf.Enabled = False

        click = 2
    End Sub

    Private Sub btnRemoveProf_Click(sender As Object, e As EventArgs) Handles btnRemoveProf.Click
        Dim cmdProf As New SqlClient.SqlCommand
        strSql = "delete from TB_PROFESSOR_DISCIPLINA where id_usuario = @id and id_discp = @id_discp"
        cmdProf.Connection = cnn
        cmdProf.CommandText = strSql
        cmdProf.Parameters.AddWithValue("@id", idProf.ToString)
        cmdProf.Parameters.AddWithValue("@id_discp", idDisc.ToString)
        Try
            cmdProf.ExecuteNonQuery()
            Call preencherGridProf()
            btnRemoveProf.Enabled = False
            DiscpFuncio.limparProf()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        cmdProf.Parameters.Clear()
        If cadastros = True Then
            txtCodProf.Text = cadastrosID
            txtNomeProf.Text = cadastrosNome
            btnAddProf.Enabled = True
        End If
    End Sub

    Private Sub btnLimparProf_Click(sender As Object, e As EventArgs) Handles btnLimparProf.Click
        Call DiscpFuncio.limparProf()
        Call DiscpFuncio.botoes()
        cadastros = False
        click = 1
        idConsProf = ""
    End Sub

    Private Sub btnConsProf_Click(sender As Object, e As EventArgs) Handles btnConsProf.Click
        btnAddProf.Enabled = False
        Dim drProf As SqlClient.SqlDataReader
        Dim cmdProf As New SqlClient.SqlCommand
        Call DiscpFuncio.botoes()
        If txtCodProf.Text = idConsProf Then
            Call consProf()
            If idConsProf <> "" Then
                If idConsProf = txtCodProf.Text Then
                    btnAddProf.Enabled = True
                End If
                Exit Sub
            End If
            Exit Sub
        End If
        If click < 2 Then
            If txtCodProf.Text <> "" Then
                strSql = "select * from tb_usuario where id_usuario = @id and tipo_usuario = 'PROFESSOR'"

                cmdProf.Connection = cnn
                cmdProf.CommandText = strSql

                cmdProf.Parameters.AddWithValue("@id", txtCodProf.Text)

                Try
                    drProf = cmdProf.ExecuteReader()
                Catch ex As Exception
                    MsgBox(Err.Description)
                    Exit Sub
                End Try
                If Not drProf.HasRows Then
                    MessageBox.Show("Professor não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    drProf.Close()
                    Call consProf()
                    If idConsProf <> "" Then
                        If idConsProf = txtCodProf.Text Then
                            btnAddProf.Enabled = True
                        End If
                        Exit Sub
                    End If
                    Exit Sub
                Else
                    drProf.Read()
                    txtCodProf.Text = drProf("id_usuario").ToString
                    txtNomeProf.Text = drProf("nome_usuario").ToString
                    btnAddProf.Enabled = True
                    drProf.Close()
                    click = 1
                End If
            Else
                Call consProf()
                If idConsProf <> "" Then
                    If idConsProf = txtCodProf.Text Then
                        btnAddProf.Enabled = True
                    End If
                    Exit Sub
                End If
            End If
        Else
            Call consProf()
            If idConsProf <> "" Then
                If idConsProf = txtCodProf.Text Then
                    btnAddProf.Enabled = True
                End If
                Exit Sub
            End If
            click = 1
        End If
        btnRemoveProf.Enabled = False
        If cadastrosID <> txtCodProf.Text Then
            cadastros = False
        End If
        idConsProf = txtCodProf.Text
    End Sub

    Private Sub btnAddProf_Click(sender As Object, e As EventArgs) Handles btnAddProf.Click
        Dim id As String = txtCodProf.Text
        Dim c As Integer = 0
        Dim c2 = dgvProf.RowCount()
        Dim adc As Boolean = True
        While c < c2
            If id = dgvProf.Rows(c).Cells(0).Value Then
                adc = False
            End If
            c += 1
        End While
        If adc = True Then
            Dim cmdProf As New SqlClient.SqlCommand

            strSql = "SELECT TIPO_USUARIO FROM TB_USUARIO WHERE ID_USUARIO = " & txtCodProf.Text
            cmdProf.Connection = cnn
            cmdProf.CommandText = strSql
            Dim TipoUsu As String = cmdProf.ExecuteScalar

            strSql = "SELECT NOME_USUARIO FROM TB_USUARIO WHERE ID_USUARIO = " & txtCodProf.Text
            cmdProf = New SqlClient.SqlCommand(strSql, cnn)
            Dim nomeUsu As String = cmdProf.ExecuteScalar()

            If TipoUsu <> "PROFESSOR" Or nomeUsu <> txtNomeProf.Text Then
                MessageBox.Show("DIGITE O CÓDIGO CORRETO DE UM PROFESSOR!", "DISCIPLINAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodProf.Focus()
                Exit Sub
            End If
            cmdProf = New SqlClient.SqlCommand
            strSql = "insert into tb_professor_disciplina (id_discp , id_usuario) values(@disciplina , @id)"
            cmdProf.Connection = cnn
            cmdProf.CommandText = strSql
            cmdProf.Parameters.AddWithValue("@id", txtCodProf.Text.ToString)
            cmdProf.Parameters.AddWithValue("@disciplina", idDisc.ToString)
            Try
                cmdProf.ExecuteNonQuery()
                Call preencherGridProf()
                btnRemoveProf.Enabled = False
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "REMOVER", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdProf.Parameters.Clear()
            If cadastros = True Then
                btnAddProf.Enabled = True
            Else
                btnAddProf.Enabled = False
            End If
            click = 1
        Else
            MessageBox.Show("PROFESSOR JÁ ADICIONADO!", "DISCIPLINAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If cadastros = False Then
            DiscpFuncio.limparProf()
            btnAddProf.Enabled = False
            idConsProf = ""
        End If

    End Sub

    Private Sub txtCodProf_GotFocus(sender As Object, e As EventArgs) Handles txtCodProf.GotFocus
        Call DiscpFuncio.botoes()
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

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtCodProf.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(DiscpFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class