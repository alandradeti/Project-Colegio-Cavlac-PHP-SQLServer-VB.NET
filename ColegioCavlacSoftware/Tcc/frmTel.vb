Public Class frmTel
    Public strAcao As String = "consultar"
    Dim id As Integer
    Dim blnConfirm As Boolean = False
    Dim telAdd As Cadastros

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public Property GetcolID As Integer
        Get
            GetcolID = dgvTel.CurrentRow.Cells("colID").Value
        End Get
        Set(Value As Integer)

        End Set
    End Property

    Public Property GetcolTel As String
        Get
            GetcolTel = dgvTel.CurrentRow.Cells("colTel").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property GetcolContato As String
        Get
            GetcolContato = dgvTel.CurrentRow.Cells("colContato").Value.ToString
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property confirm As Boolean
        Get
            confirm = blnConfirm
        End Get
        Set(value As Boolean)
            blnConfirm = value
        End Set
    End Property


    Private Sub mskTel_GotFocus(sender As Object, e As EventArgs) Handles mskTel.GotFocus, mskTel.Click
        mskTel.ForeColor = Color.Black
    End Sub

    Private Sub mskTel_LostFocus(sender As Object, e As EventArgs) Handles mskTel.LostFocus
        Dim numRp1 As String = (Replace(mskTel.Text, "-", ""))
        Dim numRp2 As String = (Replace(numRp1, "(", ""))
        Dim numRp3 As String = (Replace(numRp2, ")", ""))
        If Val(numRp3) = 0 Then
            mskTel.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtContato_GotFocus(sender As Object, e As EventArgs) Handles txtContato.GotFocus
        If txtContato.Text = "Digite o nome" Then
            txtContato.Text = ""
            txtContato.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtContato.LostFocus
        If txtContato.Text = "" Then
            txtContato.Text = "Digite o nome"
            txtContato.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbTipo_GotFocus(sender As Object, e As EventArgs) Handles cmbTipo.GotFocus, cmbTipo.DropDown
        cmbTipo.ForeColor = Color.Black
    End Sub

    Private Sub cmbTipo_LostFocus(sender As Object, e As EventArgs) Handles cmbTipo.LostFocus
        If cmbTipo.SelectedIndex = 0 Then
            cmbTipo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub PreencherTel()
        strSql = "Select id_telefone,telefone, contato, tipo From TB_TELEFONE "
        Dim cmdTel As New SqlClient.SqlCommand(strSql, cnn)
        Dim daTel As New SqlClient.SqlDataAdapter(cmdTel)
        Dim tblTel As New DataTable
        daTel.Fill(tblTel)

        dgvTel.DataSource = tblTel

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        Dim cmdTel As New SqlClient.SqlCommand
        If strAcao = "incluir" Then
            If gravar() Then
                strSql = " execute dbo.iaeTelefone @ACAO = 1," &
                    "@telefone = @telefone," &
                    "@contato = @contato," &
                    "@tipo = @tipo"

                cmdTel.Connection = cnn
                cmdTel.CommandText = strSql

                cmdTel.Parameters.AddWithValue("@telefone", mskTel.Text.ToUpper)
                cmdTel.Parameters.AddWithValue("@contato", txtContato.Text.ToUpper)
                cmdTel.Parameters.AddWithValue("@tipo", cmbTipo.Text.ToString.ToUpper)

                Try
                    cmdTel.ExecuteNonQuery()
                    Call PreencherTel()
                    MessageBox.Show("ADICIONADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar()
                    load()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdTel.Parameters.Clear()
            End If

        Else
            If gravar() Then
                strSql = " execute dbo.iaeTelefone @ACAO = 2," &
                    "@id_telefone = @id_telefone," &
                    "@telefone = @telefone," &
                    "@contato = @contato," &
                    "@tipo = @tipo"

                cmdTel.Connection = cnn
                cmdTel.CommandText = strSql

                cmdTel.Parameters.AddWithValue("@id_telefone", id)
                cmdTel.Parameters.AddWithValue("@telefone", mskTel.Text.ToUpper)
                cmdTel.Parameters.AddWithValue("@contato", txtContato.Text.ToUpper)
                cmdTel.Parameters.AddWithValue("@tipo", cmbTipo.Text.ToString.ToUpper)

                Try
                    cmdTel.ExecuteNonQuery()
                    Call PreencherTel()
                    MessageBox.Show("ALTERADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpar()
                    load()
                Catch ex As Exception
                    MessageBox.Show("Erro: " & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
                cmdTel.Parameters.Clear()
            End If
            strAcao = "consultar"
            mskTel.Focus()
        End If


    End Sub

    Private Sub frmTel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreencherTel()
        cmbTipo.Items.Add("---")
        cmbTipo.Items.Add("CASA")
        cmbTipo.Items.Add("CELULAR")
        cmbTipo.Items.Add("TRABALHO")
        cmbTipo.Items.Add("RECADO")
        cmbTipo.Items.Add("OUTROS")

        cmbTipo.SelectedIndex = 0

        load()
    End Sub

    Private Sub dgvTel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTel.CellClick

        id = dgvTel.CurrentRow.Cells("colID").Value
        mskTel.Text = dgvTel.CurrentRow.Cells("colTel").Value
        mskTel.ForeColor = Color.Black
        txtContato.Text = dgvTel.CurrentRow.Cells("colContato").Value.ToString
        txtContato.ForeColor = Color.Black
        cmbTipo.SelectedItem = dgvTel.CurrentRow.Cells("colTipo").Value.ToString
        cmbTipo.ForeColor = Color.Black
        strAcao = "alterar"
        novoAlt()
        btnCons.Enabled = True

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Dim cmdTel As New SqlClient.SqlCommand
            strSql = " execute dbo.iaeTelefone @ACAO = 0," &
                    "@id_telefone = @id_telefone"

            cmdTel.Connection = cnn
            cmdTel.CommandText = strSql

            cmdTel.Parameters.AddWithValue("@id_telefone", id)

            Try
                cmdTel.ExecuteNonQuery()
                Call PreencherTel()
                MessageBox.Show("TELEFONE REMOVIDO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erro: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdTel.Parameters.Clear()
            limpar()
            load()
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        strAcao = "incluir"
        btnOk.Enabled = False
        limpar()
        novoAlt()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limpar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar?", "CANCELAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            limpar()
            load()
            strAcao = "consultar"
            mskTel.Focus()
            PreencherTel()
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.confirm = True
        Me.Hide()
    End Sub

    Sub load()
        btnCons.Enabled = True
        mskTel.Enabled = True
        btnLimpar.Enabled = True
        txtContato.Enabled = False
        cmbTipo.Enabled = False
        btnNovo.Enabled = True
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnGravar.Enabled = False
        dgvTel.Enabled = True
        If Home.cadastros.telAdd = True Then
            btnOk.Enabled = True
        Else : btnOk.Enabled = False
        End If
    End Sub

    Sub limpar()
        mskTel.Clear()
        mskTel.ForeColor = Color.LightSteelBlue
        txtContato.Text = "Digite o nome"
        txtContato.ForeColor = Color.LightSteelBlue
        cmbTipo.SelectedItem = "---"
        cmbTipo.ForeColor = Color.LightSteelBlue
    End Sub

    Sub novoAlt()
        btnCons.Enabled = False
        mskTel.Enabled = True
        btnLimpar.Enabled = True
        txtContato.Enabled = True
        cmbTipo.Enabled = True
        btnCancelar.Enabled = True
        btnGravar.Enabled = True
        If strAcao = "alterar" Then
            dgvTel.Enabled = True
            btnExcluir.Enabled = True
            btnNovo.Enabled = True
        Else
            dgvTel.Enabled = False
            btnExcluir.Enabled = False
            btnNovo.Enabled = False
            mskTel.Focus()
        End If

    End Sub
    Function gravar() As Boolean
        Dim numRp1 As String = (Replace(mskTel.Text, "-", ""))
        Dim numRp2 As String = (Replace(numRp1, "(", ""))
        Dim numRp3 As String = (Replace(numRp2, ")", ""))
        Dim valor As String = numRp3.Trim()
        If valor.Length < 11 Then
            MessageBox.Show("Telefone é um campo obrigatório!" & vbNewLine & "DIGITE O TELEFONE.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mskTel.Focus()
            Return False
            Exit Function
        End If
        If txtContato.Text = "Digite o nome" Or txtContato.Text = "" Then
            MessageBox.Show("Contato é um campo obrigatório!" & vbNewLine & "DIGITE O NOME.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContato.Focus()
            Return False
            Exit Function
        End If
        If cmbTipo.SelectedIndex = 0 Then
            MessageBox.Show("Tipo de contato é um campo obrigatório!" & vbNewLine & "SELECIONE O TIPO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbTipo.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCons_Click(sender As Object, e As EventArgs) Handles btnCons.Click
        Dim tel1 As String = Replace(mskTel.Text, "(", "")
        Dim tel As String = Replace(tel1, ")", "")
        Dim cmdTel As New SqlClient.SqlCommand(strSql, cnn)
        If Val(tel) < 10 Then
            PreencherTel()
        Else
            strSql = "select * from tb_telefone where telefone like '%'+@tel+'%'"

            cmdTel.Parameters.AddWithValue("@tel", mskTel.Text)
            Dim daTel As New SqlClient.SqlDataAdapter(cmdTel)
            Dim tblTel As New DataTable
            daTel.Fill(tblTel)
            dgvTel.DataSource = tblTel
        End If
        cmdTel.Parameters.Clear()
        load()
        txtContato.Clear()
        txtContato.Text = "Digite o nome"
        cmbTipo.SelectedIndex = 0
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

End Class