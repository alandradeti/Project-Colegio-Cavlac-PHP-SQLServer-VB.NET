Imports System.Data.SqlClient
Imports System.IO

Public Class Cadastros

    Private senha As String
    Private ImageCaminho As String = ""
    Private imageDestino As String = Application.StartupPath + "\FOTOS\"
    Public verificaSenhas As Boolean = True
    Public hm As String
    Public sqlCmd As New SqlCommand
    Private strAcao As String = "Incluir"
    Private notFoto As Boolean = True
    Private arytelIdAdd As New ArrayList
    Private aryTelDel As New ArrayList
    Private cmd As New SqlClient.SqlCommand
    Public telAdd As Boolean = False
    Private click As Integer = 1
    Private disc As Boolean = False
    Dim move As MoveForm

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Sub consUsu()
        click = 1

        If hm = "professor" Then
            Dim objConsProf As New FrmConsProf()
            objConsProf.ShowDialog()
            If objConsProf.confirm = True Then
                txtCod.Text = objConsProf.GetcolIDprof()
                btnCons.PerformClick()
                verificaSenhas = False
            Else
                click = 2
            End If
            Exit Sub
        ElseIf hm = "usuario" Then
            Dim objConsUsu As New frmConsUsu()
            objConsUsu.ShowDialog()
            If objConsUsu.confirm = True Then
                txtCod.Text = objConsUsu.GetcolIDUsu()
                btnCons.PerformClick()
                verificaSenhas = False
                Exit Sub
            Else
                click = 2
            End If
        ElseIf hm = "aluno" Then
            Dim objConsAluno As New frmConsAluno()
            objConsAluno.ShowDialog()
            If objConsAluno.confirm = True Then
                txtCod.Text = objConsAluno.GetcolIDAluno()
                btnCons.PerformClick()
                chkVisuSenha.Visible = True
                verificaSenhas = False
            Else
                click = 2
            End If
        End If
        Exit Sub

    End Sub

    Function preencherGridTel()
        If hm = "aluno" Then
            strSql = "SELECT TB_TELEFONE.id_telefone, TB_TELEFONE.telefone, TB_TELEFONE.contato " & vbNewLine &
                 "From TB_ALUNO INNER JOIN" & vbNewLine &
                 "TB_TELEFONE_ALUNO On TB_ALUNO.id_matricula = TB_TELEFONE_ALUNO.id_matricula INNER JOIN " & vbNewLine &
                 "TB_TELEFONE On TB_TELEFONE_ALUNO.id_telefone = TB_TELEFONE.id_telefone" & vbNewLine &
                 "Where (TB_TELEFONE_ALUNO.id_matricula = " & txtCod.Text & ")"
        Else
            strSql = "SELECT TB_TELEFONE.id_telefone, TB_TELEFONE.telefone, TB_TELEFONE.contato " & vbNewLine &
                 "From TB_USUARIO INNER JOIN" & vbNewLine &
                 "TB_TELEFONE_USUARIO On TB_USUARIO.id_usuario = TB_TELEFONE_USUARIO.id_usuario INNER JOIN " & vbNewLine &
                 "TB_TELEFONE On TB_TELEFONE_USUARIO.id_telefone = TB_TELEFONE.id_telefone" & vbNewLine &
                 "Where (TB_TELEFONE_USUARIO.id_usuario = " & txtCod.Text & ")"
        End If


        Dim cmdTel As New SqlClient.SqlCommand(strSql, cnn)
        Dim daTel As New SqlClient.SqlDataAdapter(cmdTel)
        Dim reader As SqlDataReader = cmdTel.ExecuteReader()

        While reader.Read()
            Dim telefone, nome, id As String
            id = reader.GetValue(0).ToString
            telefone = reader.GetValue(1).ToString
            nome = reader.GetValue(2).ToString
            Dim row As String() = New String() {id, telefone, nome}
            dgvTel.Rows.Add(row)

        End While

        reader.Close()

    End Function

    Private Sub TranferirImagem()
        If ImageCaminho = "" Then
            Exit Sub
        Else
            File.Delete(imageDestino + hm + Trim(txtCod.Text) + ".jpg")
            Dim destino As String = imageDestino + hm + Trim(txtCod.Text) + ".jpg"
            File.Copy(ImageCaminho, destino)
        End If
    End Sub

    Function ObtemImagem() As String

        Dim caminho As String
        Dim converter As New ImageConverter
        With sqlCmd
            .CommandType = CommandType.Text
            If hm = "aluno" Then
                .CommandText = "Select foto_aluno From TB_ALUNO Where id_matricula = " & txtCod.Text
            Else
                .CommandText = "Select foto_usuario From TB_USUARIO Where id_USUARIO = " & txtCod.Text
            End If

            .Connection = cnn
        End With
        Try

            If IsDBNull(sqlCmd.ExecuteScalar()) Then
                ptbFoto.Image = Nothing
                Exit Function
            Else
                caminho = sqlCmd.ExecuteScalar()
                Dim img As Image
                Dim img2 As Bitmap
                img = Image.FromFile(caminho)
                img2 = New Bitmap(img)
                img.Dispose()
                ptbFoto.Image = img2
                ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox("Erro : " + ex.Message)
        End Try
    End Function

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub txtCod_TextChangedFocus(sender As Object, e As EventArgs) Handles txtCod.TextChanged
        click = 1
        lblDisc.Enabled = False
        disc = False
    End Sub

    Private Sub txtNome_GotFocus(sender As Object, e As EventArgs) Handles txtNome.GotFocus
        If txtNome.Text = "Digite o nome" Then
            txtNome.Text = ""
            txtNome.ForeColor = Color.Black
            click = 1
        End If
    End Sub

    Private Sub txtNome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        If txtNome.Text = "" Then
            txtNome.Text = "Digite o nome"
            txtNome.ForeColor = Color.LightSteelBlue
        End If

    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "Digite o E-MAIL" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "Digite o E-MAIL"
            txtEmail.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtResponsavel_GotFocus(sender As Object, e As EventArgs) Handles txtResponsavel.GotFocus
        If txtResponsavel.Text = "Digite o nome" Then
            txtResponsavel.Text = ""
            txtResponsavel.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtResponsavel_LostFocus(sender As Object, e As EventArgs) Handles txtResponsavel.LostFocus
        If txtResponsavel.Text = "" Then
            txtResponsavel.Text = "Digite o nome"
            txtResponsavel.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtEndereco_GotFocus(sender As Object, e As EventArgs) Handles txtEndereco.GotFocus
        If txtEndereco.Text = "Digite o endereço" Then
            txtEndereco.Text = ""
            txtEndereco.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEndereco_LostFocus(sender As Object, e As EventArgs) Handles txtEndereco.LostFocus
        If txtEndereco.Text = "" Then
            txtEndereco.Text = "Digite o endereço"
            txtEndereco.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtBairro_GotFocus(sender As Object, e As EventArgs) Handles txtBairro.GotFocus
        If txtBairro.Text = "Digite o bairro" Then
            txtBairro.Text = ""
            txtBairro.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBairro_LostFocus(sender As Object, e As EventArgs) Handles txtBairro.LostFocus
        If txtBairro.Text = "" Then
            txtBairro.Text = "Digite o bairro"
            txtBairro.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtCidade_GotFocus(sender As Object, e As EventArgs) Handles txtCidade.GotFocus
        If txtCidade.Text = "Digite a cidade" Then
            txtCidade.Text = ""
            txtCidade.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCidade_LostFocus(sender As Object, e As EventArgs) Handles txtCidade.LostFocus
        If txtCidade.Text = "" Then
            txtCidade.Text = "Digite a cidade"
            txtCidade.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtPontoRef_GotFocus(sender As Object, e As EventArgs) Handles txtPontoRef.GotFocus
        If txtPontoRef.Text = "Digite a referência" Then
            txtPontoRef.Text = ""
            txtPontoRef.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPontoRef_LostFocus(sender As Object, e As EventArgs) Handles txtPontoRef.LostFocus
        If txtPontoRef.Text = "" Then
            txtPontoRef.Text = "Digite a referência"
            txtPontoRef.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbDtNasc_GotFocus(sender As Object, e As EventArgs) Handles mtbDtNasc.GotFocus, mtbDtNasc.Click
        mtbDtNasc.ForeColor = Color.Black
        If Val(mtbDtNasc.Text) = 0 Then
            mtbDtNasc.SelectionStart = 0
        End If

        click = 1
    End Sub

    Private Sub mtbDtNasc_LostFocus(sender As Object, e As EventArgs) Handles mtbDtNasc.LostFocus
        If Val(mtbDtNasc.Text) = 0 Then
            mtbDtNasc.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbSexo_GotFocus(sender As Object, e As EventArgs) Handles cmbSexo.GotFocus, cmbSexo.DropDown
        cmbSexo.ForeColor = Color.Black
    End Sub

    Private Sub cmbSexo_LostFocus(sender As Object, e As EventArgs) Handles cmbSexo.LostFocus
        If cmbSexo.SelectedIndex = 0 Then
            cmbSexo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbCpf_GostFocus(sender As Object, e As EventArgs) Handles mtbCpf.GotFocus, mtbCpf.Click
        mtbCpf.ForeColor = Color.Black
        If Val(mtbCpf.Text) = 0 Then
            mtbCpf.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbCpf_LostFocus(sender As Object, e As EventArgs) Handles mtbCpf.LostFocus
        If Val(mtbCpf.Text) = 0 Then
            mtbCpf.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbRg_GotFocus(sender As Object, e As EventArgs) Handles mtbRg.GotFocus, mtbRg.Click
        mtbRg.ForeColor = Color.Black
        If Val(mtbRg.Text) = 0 Then
            mtbRg.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbRg_LostFocus(sender As Object, e As EventArgs) Handles mtbRg.LostFocus
        If Val(mtbRg.Text) = 0 Then
            mtbRg.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub mtbCep_GotFocus(sender As Object, e As EventArgs) Handles mtbCep.GotFocus, mtbCep.Click
        mtbCep.ForeColor = Color.Black
        If Val(mtbCep.Text) = 0 Then
            mtbCep.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbCep_LostFocus(sender As Object, e As EventArgs) Handles mtbCep.LostFocus
        If Val(mtbCep.Text) = 0 Then
            mtbCep.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbUf_GotFocus(sender As Object, e As EventArgs) Handles cmbUf.GotFocus, cmbUf.DropDown
        cmbUf.ForeColor = Color.Black
    End Sub

    Private Sub cmbUf_LostFocus(sender As Object, e As EventArgs) Handles cmbUf.LostFocus
        If cmbUf.SelectedIndex = 0 Then
            cmbUf.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtLogin_GotFocus(sender As Object, e As EventArgs) Handles txtLogin.GotFocus
        If txtLogin.Text = "Digite o login" Then
            txtLogin.Text = ""
            txtLogin.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLogin_LostFocus(sender As Object, e As EventArgs) Handles txtLogin.LostFocus
        If txtLogin.Text = "" Then
            txtLogin.Text = "Digite o login"
            txtLogin.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtSenha_GotFocus(sender As Object, e As EventArgs) Handles txtSenha.GotFocus
        If txtSenha.Text = "Digite a senha" Then
            txtSenha.Text = ""
            txtSenha.ForeColor = Color.Black
            txtSenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtSenha_LostFocus(sender As Object, e As EventArgs) Handles txtSenha.LostFocus
        If txtSenha.Text = "" Then
            txtSenha.Text = "Digite a senha"
            txtSenha.ForeColor = Color.LightSteelBlue
            txtSenha.PasswordChar = ""
        End If
    End Sub

    Private Sub txtConfirmSenha_GotFocus(sender As Object, e As EventArgs) Handles txtConfimSenha.GotFocus
        If txtConfimSenha.Text = "Digite a senha novamente" Then
            txtConfimSenha.Text = ""
            txtConfimSenha.ForeColor = Color.Black
            txtConfimSenha.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtConfirmSenha_LostFocus(sender As Object, e As EventArgs) Handles txtConfimSenha.LostFocus
        If txtConfimSenha.Text = "" Then
            txtConfimSenha.Text = "Digite a senha novamente"
            txtConfimSenha.ForeColor = Color.LightSteelBlue
            txtConfimSenha.PasswordChar = ""
        End If
    End Sub

    Private Sub mtbDtCad_GotFocus(sender As Object, e As EventArgs) Handles mtbDtCad.GotFocus, mtbDtCad.Click
        mtbDtCad.ForeColor = Color.Black
        If Val(mtbDtCad.Text) = 0 Then
            mtbDtCad.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbDtCad_LostFocus(sender As Object, e As EventArgs) Handles mtbDtCad.LostFocus
        If Val(mtbDtCad.Text) = 0 Then
            mtbDtCad.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub CadastrarAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CadatrosFuncio.load()
        CadatrosFuncio.entrada()
        If hm <> "professor" Then
            lblDisc.Visible = False
        End If
        lblDisc.Enabled = False
    End Sub

    Private Sub btnConsTel_Click(sender As Object, e As EventArgs) Handles btnConsTel.Click
        Dim objFrmTel As New frmTel
        telAdd = True
        objFrmTel.ShowDialog()
        objFrmTel.btnOk.Visible = True

        '-- se houve seleção de Produto e clicado no botao "OK"
        If objFrmTel.confirm = True Then
            Dim id = objFrmTel.GetcolID
            If dgvTel.RowCount() = 0 Then
                Dim row As String() = New String() {objFrmTel.GetcolID, objFrmTel.GetcolTel.ToString, objFrmTel.GetcolContato}
                dgvTel.Rows.Add(row)
                arytelIdAdd.Add(id.ToString)
            Else
                Dim c As Integer = 0
                Dim c2 = dgvTel.RowCount()
                Dim adc As Boolean = True

                While c < c2
                    If id = dgvTel.Rows(c).Cells(0).Value Then
                        adc = False
                    End If
                    c += 1
                End While
                If adc = True Then
                    Dim row As String() = New String() {objFrmTel.GetcolID, objFrmTel.GetcolTel.ToString, objFrmTel.GetcolContato}
                    dgvTel.Rows.Add(row)
                    arytelIdAdd.Add(id.ToString)
                Else
                    MessageBox.Show("TELEFONE JÁ SELECIONADO!", "TELEFONE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
                If MessageBox.Show("DESEJA ADICIONAR OUTRO TELEFONE?", "TELEFONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    btnConsTel.PerformClick()
                Else
                    telAdd = False
                End If
            End If
        End If
        objFrmTel = Nothing

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Deseja Cancelar?", "CANCELAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            CadatrosFuncio.limpar()
            CadatrosFuncio.entrada()
            aryTelDel.Clear()
            arytelIdAdd.Clear()
            lblDisc.Enabled = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnConsFoto_Click(sender As Object, e As EventArgs) Handles btnConsFoto.Click

        Using OFD As New OpenFileDialog With {.Filter = "Jpg (*.jpg)|*.jpg"}
            OFD.Title = "Selecione a Foto"
            If OFD.ShowDialog = DialogResult.OK Then
                Try
                    Dim FOTO = Image.FromFile(OFD.FileName)
                    ImageCaminho = OFD.FileName
                    ptbFoto.Image = FOTO
                    ptbFoto.SizeMode = PictureBoxSizeMode.StretchImage
                Catch ex As Exception
                    MessageBox.Show("ERRO:" & vbNewLine & Err.Description, "FOTO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnApagarFoto_Click(sender As Object, e As EventArgs) Handles btnApagarFoto.Click
        ptbFoto.Image = Nothing
        ptbFoto.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub btnConsCep_Click(sender As Object, e As EventArgs) Handles btnConsCep.Click
        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", mtbCep.Text)
            ds.ReadXml(xml)
            txtEndereco.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            If txtEndereco.Text <> "" Then
                txtEndereco.ForeColor = Color.Black
            Else
                txtEndereco.Text = "Digite o endereço"
                txtEndereco.ForeColor = Color.LightSteelBlue
            End If
            txtBairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            If txtBairro.Text <> "" Then
                txtBairro.ForeColor = Color.Black
            Else
                txtBairro.Text = "Digite o bairro"
                txtBairro.ForeColor = Color.LightSteelBlue
            End If
            txtCidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            If txtCidade.Text <> "" Then
                txtCidade.ForeColor = Color.Black
            Else
                txtCidade.Text = "Digite a cidade"
                txtCidade.ForeColor = Color.LightSteelBlue
            End If

            Dim uf = ds.Tables(0).Rows(0)("uf").ToString()

            If uf <> "" Then
                cmbUf.SelectedItem = uf
                cmbUf.ForeColor = Color.Black
            Else
                cmbUf.SelectedItem = "---"
                cmbUf.ForeColor = Color.LightSteelBlue
            End If

        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "CEP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        If hm = "aluno" Then
            CadatrosFuncio.limpar()
            CadatrosFuncio.NovoAluno()
        Else

            strSql = "SELECT MAX(ID_USUARIO) FROM TB_USUARIO"
            cmd = New SqlClient.SqlCommand(strSql, cnn)
            CadatrosFuncio.limpar()
            CadatrosFuncio.Novo()
            Try
                txtCod.Text = cmd.ExecuteScalar().ToString + 1
            Catch ex As Exception
                txtCod.Text = 1
            End Try
        End If
        strAcao = "incluir"
        verificaSenhas = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click

        If strAcao = "incluir" Then
            If hm = "aluno" Then
                If CadatrosFuncio.GravarAluno() Then

                    cmd = New SqlClient.SqlCommand
                    strSql = "exec dbo.uspIAEALUNO @ACAO = 1," &
                              "@id_matricula = @id_matricula," &
                              "@rg = @rg," &
                              "@nome_aluno = @nome_aluno," &
                              "@cep_aluno = @cep_aluno," &
                              "@cpf = @cpf," &
                              "@dt_nasc = @dt_nasc," &
                              "@nome_responsavel = @nome_responsavel," &
                              "@senha = @senha," &
                              "@ponto_ref = @ponto_ref," &
                              "@dt_cad = @dt_cad," &
                              "@foto_aluno = @foto_aluno," &
                              "@email_aluno = @email_aluno," &
                              "@sexo = @sexo," &
                              "@Num_Casa = @Num_Casa"

                    Dim CPF As String
                    Dim RG As String

                    CPF = Replace(mtbCpf.Text, ",", "")
                    CPF = Replace(CPF, "-", "")

                    RG = Replace(mtbRg.Text, ",", "")
                    RG = Replace(RG, "-", "")
                    cmd.Connection = cnn
                    cmd.CommandText = strSql

                    cmd.Parameters.AddWithValue("@id_matricula", txtCod.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@rg", RG.ToUpper)
                    cmd.Parameters.AddWithValue("@nome_aluno", txtNome.Text.ToString.ToUpper)
                    cmd.Parameters.AddWithValue("@cep_aluno", mtbCep.Text.ToString.ToUpper)
                    If Val(mtbCpf.Text) = 0 Then
                        cmd.Parameters.AddWithValue("@cpf", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@cpf", CPF.ToUpper)
                    End If
                    cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@nome_responsavel", txtResponsavel.Text.ToString.ToUpper)
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text.ToString.ToUpper)
                    If txtPontoRef.Text = "" Or txtPontoRef.Text = "Digite a referência" Then
                        cmd.Parameters.AddWithValue("@ponto_ref", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@ponto_ref", txtPontoRef.Text.ToString.ToUpper)
                    End If
                    cmd.Parameters.AddWithValue("@dt_cad", mtbDtCad.Text.ToUpper)
                    If ptbFoto.Image Is Nothing Then
                        cmd.Parameters.AddWithValue("@foto_aluno", DBNull.Value)
                    Else
                        TranferirImagem()
                        cmd.Parameters.AddWithValue("@foto_aluno", imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                    End If

                    If txtEmail.Text = "" Or txtEmail.Text = "Digite o E-MAIL" Then
                        cmd.Parameters.AddWithValue("@email_aluno", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@email_aluno", txtEmail.Text.ToString.ToUpper)
                    End If
                    Dim sexo As Integer
                    If cmbSexo.SelectedIndex = 1 Then
                        sexo = 0
                    ElseIf cmbSexo.SelectedIndex = 2 Then
                        sexo = 1
                    End If
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@Num_Casa", txtNumCasa.Text.ToString.ToUpper)
                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("ADICIONADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CadatrosFuncio.entrada()
                        verificaSenhas = True
                        click = 2
                    Catch ex As Exception
                        MessageBox.Show("ERRO:" & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    cmd.Parameters.Clear()

                    If arytelIdAdd.Count > 0 Then
                        Dim cont, cont2 As Integer
                        cont2 = 0
                        cont = arytelIdAdd.Count - 1
                        While cont2 <= cont
                            cmd = New SqlClient.SqlCommand
                            strSql = "execute dbo.InserirTB_aluno_telefone @id_matricula = @idmatricula," &
                                     "@id_telefone = @idtelefone"
                            cmd.Parameters.AddWithValue("@idtelefone", arytelIdAdd.Item(cont2).ToString)
                            cmd.Parameters.AddWithValue("@idmatricula", txtCod.Text.ToString)
                            Try
                                cmd.Connection = cnn
                                cmd.CommandText = strSql
                                cmd.ExecuteNonQuery()
                                cmd.Parameters.Clear()
                            Catch ex As Exception
                                MsgBox("erro: " & Err.Description)
                            End Try
                            cont2 += 1
                        End While
                        arytelIdAdd.Clear()
                    End If
                End If
            Else
                If CadatrosFuncio.GravarUsuario() Then

                    cmd = New SqlClient.SqlCommand
                    strSql = "execute dbo.aiaeUsuario @ACAO = 1," &
                              "@id_usuario = @id_usuario," &
                              "@cpf_usuario = @cpf," &
                              "@rg_usuario = @rg," &
                              "@email_usuario = @email," &
                              "@senha_usuario = @senha_usuario," &
                              "@nome_usuario = @nome_usuario," &
                              "@dt_nasc = @dt_nasc," &
                              "@dt_cad = @dt_cad," &
                              "@tipo_usuario = @tipo_usuario," &
                              "@cep = @cep," &
                              "@numero_residencia = @numero_residencia," &
                              "@referencia = @referencia," &
                              "@foto_usuario = @foto," &
                              "@sexo = @sexo," &
                              "@login = @login"

                    Dim CPF As String
                    Dim RG As String

                    CPF = Replace(mtbCpf.Text, ",", "")
                    CPF = Replace(CPF, "-", "")

                    RG = Replace(mtbRg.Text, ",", "")
                    RG = Replace(RG, "-", "")
                    cmd.Connection = cnn
                    cmd.CommandText = strSql

                    cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString.ToUpper)
                    cmd.Parameters.AddWithValue("@tipo_usuario", hm.ToUpper)
                    cmd.Parameters.AddWithValue("@rg", RG.ToUpper)
                    cmd.Parameters.AddWithValue("@nome_usuario", txtNome.Text.ToString.ToUpper)
                    cmd.Parameters.AddWithValue("@cep", mtbCep.Text.ToString.ToUpper)
                    If Val(mtbCpf.Text) = 0 Then
                        cmd.Parameters.AddWithValue("@cpf", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@cpf", CPF.ToUpper)
                    End If
                    cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToUpper)
                    cmd.Parameters.AddWithValue("@senha_usuario", txtSenha.Text.ToString.ToUpper)
                    If txtPontoRef.Text = "" Or txtPontoRef.Text = "Digite a referência" Then
                        cmd.Parameters.AddWithValue("@referencia", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@referencia", txtPontoRef.Text.ToString.ToUpper)
                    End If
                    cmd.Parameters.AddWithValue("@dt_cad", mtbDtCad.Text.ToUpper)
                    If ptbFoto.Image Is Nothing Then
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value)
                    Else
                        TranferirImagem()
                        cmd.Parameters.AddWithValue("@foto", imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                    End If
                    If txtEmail.Text = "" Or txtEmail.Text = "Digite o E-MAIL" Then
                        cmd.Parameters.AddWithValue("@email", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToString.ToUpper)
                    End If
                    Dim sexo As Integer
                    If cmbSexo.SelectedIndex = 1 Then
                        sexo = 0
                    ElseIf cmbSexo.SelectedIndex = 2 Then
                        sexo = 1
                    End If
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@numero_residencia", txtNumCasa.Text.ToString.ToUpper)
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text.ToString.ToUpper)
                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("ADICIONADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CadatrosFuncio.entrada()
                        click = 2
                        verificaSenhas = True
                    Catch ex As Exception
                        MessageBox.Show("ERRO:" & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    cmd.Parameters.Clear()
                    If arytelIdAdd.Count > 0 Then
                        Dim cont, cont2 As Integer
                        cont2 = 0
                        cont = arytelIdAdd.Count - 1
                        cmd = New SqlClient.SqlCommand
                        While cont2 <= cont
                            cmd = New SqlClient.SqlCommand
                            strSql = "execute dbo.Inserir_telefone_usuario @id_telefone = @id_telefone," &
                                     "@id_usuario = @id_usuario"
                            cmd.Parameters.AddWithValue("@id_telefone", arytelIdAdd.Item(cont2).ToString)
                            cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString)
                            Try
                                cmd.Connection = cnn
                                cmd.CommandText = strSql
                                cmd.ExecuteNonQuery()
                                cmd.Parameters.Clear()
                            Catch ex As Exception
                                MsgBox("erro: " & Err.Description)
                            End Try
                            cont2 += 1
                        End While
                        arytelIdAdd.Clear()
                    End If
                End If
            End If
        Else
            If hm = "aluno" Then
                If CadatrosFuncio.GravarAluno() = False Then
                    Exit Sub
                End If
                cmd = New SqlClient.SqlCommand
                strSql = "execute dbo.uspIAEALUNO @ACAO = 2, " &
                          "@id_matricula = @id_matricula," &
                              "@rg = @rg," &
                              "@nome_aluno = @nome_aluno," &
                              "@cep_aluno = @cep_aluno," &
                              "@cpf = @cpf," &
                              "@dt_nasc = @dt_nasc," &
                              "@nome_responsavel = @nome_responsavel," &
                              "@senha = @senha," &
                              "@ponto_ref = @ponto_ref," &
                              "@dt_cad = @dt_cad," &
                              "@foto_aluno = @foto_aluno," &
                              "@email_aluno = @email_aluno," &
                              "@sexo = @sexo," &
                              "@Num_Casa = @Num_Casa"

                Dim CPF As String
                Dim RG As String

                CPF = Replace(mtbCpf.Text, ",", "")
                CPF = Replace(CPF, "-", "")

                RG = Replace(mtbRg.Text, ",", "")
                RG = Replace(RG, "-", "")
                cmd.Connection = cnn
                cmd.CommandText = strSql

                cmd.Parameters.AddWithValue("@id_matricula", txtCod.Text.ToUpper)
                cmd.Parameters.AddWithValue("@rg", RG.ToUpper)
                cmd.Parameters.AddWithValue("@nome_aluno", txtNome.Text.ToString.ToUpper)
                cmd.Parameters.AddWithValue("@cep_aluno", mtbCep.Text.ToString.ToUpper)
                If Val(mtbCpf.Text) = 0 Then
                    cmd.Parameters.AddWithValue("@cpf", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@cpf", CPF.ToUpper)
                End If
                cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToUpper)
                cmd.Parameters.AddWithValue("@nome_responsavel", txtResponsavel.Text.ToString.ToUpper)
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.ToString.ToUpper)
                If txtPontoRef.Text = "" Or txtPontoRef.Text = "Digite a referência" Then
                    cmd.Parameters.AddWithValue("@ponto_ref", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@ponto_ref", txtPontoRef.Text.ToString.ToUpper)
                End If
                cmd.Parameters.AddWithValue("@dt_cad", mtbDtCad.Text.ToUpper)
                If ptbFoto.Image Is Nothing Then
                    cmd.Parameters.AddWithValue("@foto_aluno", DBNull.Value)
                    File.Delete(imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                Else
                    TranferirImagem()
                    cmd.Parameters.AddWithValue("@foto_aluno", imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                End If
                If txtEmail.Text = "" Or txtEmail.Text = "Digite o E-MAIL" Then
                    cmd.Parameters.AddWithValue("@email_aluno", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@email_aluno", txtEmail.Text.ToString.ToUpper)
                End If
                Dim sexo As Integer
                If cmbSexo.SelectedIndex = 1 Then
                    sexo = 0
                ElseIf cmbSexo.SelectedIndex = 2 Then
                    sexo = 1
                End If
                cmd.Parameters.AddWithValue("@sexo", sexo)
                cmd.Parameters.AddWithValue("@Num_Casa", txtNumCasa.Text.ToString.ToUpper)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("ALTERADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CadatrosFuncio.entrada()
                    click = 2
                    verificaSenhas = True
                Catch ex As Exception
                    MessageBox.Show("ERRO:" & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                cmd.Parameters.Clear()
                If aryTelDel.Count() > 0 Then
                    Dim cont, cont2 As Integer
                    cont2 = 0
                    cont = aryTelDel.Count - 1
                    While cont2 <= cont
                        cmd = New SqlClient.SqlCommand
                        strSql = "delete from TB_TELEFONE_ALUNO " &
                                 "where id_telefone = @idtelefone and id_matricula = @idmatricula"
                        cmd.Parameters.AddWithValue("@idtelefone", aryTelDel.Item(cont2).ToString)
                        cmd.Parameters.AddWithValue("@idmatricula", txtCod.Text.ToString)
                        Try
                            cmd.Connection = cnn
                            cmd.CommandText = strSql
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            MsgBox("erro: " & Err.Description)
                        End Try
                        cont2 += 1
                        aryTelDel.Clear()
                    End While
                End If
                If arytelIdAdd.Count > 0 Then
                    Dim cont, cont2 As Integer
                    cont2 = 0
                    cont = arytelIdAdd.Count - 1
                    While cont2 <= cont
                        cmd = New SqlClient.SqlCommand
                        strSql = "execute dbo.InserirTB_aluno_telefone @id_matricula = @idmatricula," &
                                 "@id_telefone = @idtelefone"
                        cmd.Parameters.AddWithValue("@idtelefone", arytelIdAdd.Item(cont2).ToString)
                        cmd.Parameters.AddWithValue("@idmatricula", txtCod.Text.ToString)
                        Try
                            cmd.Connection = cnn
                            cmd.CommandText = strSql
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            MsgBox("erro: " & Err.Description)
                        End Try
                        cont2 += 1
                    End While
                    arytelIdAdd.Clear()
                End If
            End If

            If hm = "usuario" Or hm = "professor" Then
                If CadatrosFuncio.GravarUsuario() = False Then
                    Exit Sub
                End If
                cmd = New SqlClient.SqlCommand
                strSql = "execute dbo.aiaeUsuario @ACAO = 2," &
                              "@id_usuario = @id_usuario," &
                              "@cpf_usuario = @cpf," &
                              "@rg_usuario = @rg," &
                              "@email_usuario = @email," &
                              "@senha_usuario = @senha_usuario," &
                              "@nome_usuario = @nome_usuario," &
                              "@dt_nasc = @dt_nasc," &
                              "@dt_cad = @dt_cad," &
                              "@tipo_usuario = @tipo_usuario," &
                              "@cep = @cep," &
                              "@numero_residencia = @numero_residencia," &
                              "@referencia = @referencia," &
                              "@foto_usuario = @foto," &
                              "@sexo = @sexo," &
                              "@login = @login"

                Dim CPF As String
                Dim RG As String

                CPF = Replace(mtbCpf.Text, ",", "")
                CPF = Replace(CPF, "-", "")

                RG = Replace(mtbRg.Text, ",", "")
                RG = Replace(RG, "-", "")
                cmd.Connection = cnn
                cmd.CommandText = strSql

                cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text)
                cmd.Parameters.AddWithValue("@tipo_usuario", hm.ToUpper)
                cmd.Parameters.AddWithValue("@rg", RG.ToUpper)
                cmd.Parameters.AddWithValue("@nome_usuario", txtNome.Text.ToString.ToUpper)
                cmd.Parameters.AddWithValue("@cep", mtbCep.Text.ToString.ToUpper)
                If Val(mtbCpf.Text) = 0 Then
                    cmd.Parameters.AddWithValue("@cpf", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@cpf", CPF.ToUpper)
                End If
                cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToUpper)
                cmd.Parameters.AddWithValue("@senha_usuario", txtSenha.Text.ToString.ToUpper)
                If txtPontoRef.Text = "" Or txtPontoRef.Text = "Digite a referência" Then
                    cmd.Parameters.AddWithValue("@referencia", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@referencia", txtPontoRef.Text.ToString.ToUpper)
                End If
                cmd.Parameters.AddWithValue("@dt_cad", mtbDtCad.Text.ToUpper)
                If ptbFoto.Image Is Nothing Then
                    cmd.Parameters.AddWithValue("@foto", DBNull.Value)
                    File.Delete(imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                Else
                    TranferirImagem()
                    cmd.Parameters.AddWithValue("@foto", imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                End If
                If txtEmail.Text = "" Or txtEmail.Text = "Digite o E-MAIL" Then
                    cmd.Parameters.AddWithValue("@email", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToString.ToUpper)
                End If
                Dim sexo As Integer
                If cmbSexo.SelectedIndex = 1 Then
                    sexo = 0
                ElseIf cmbSexo.SelectedIndex = 2 Then
                    sexo = 1
                End If
                cmd.Parameters.AddWithValue("@sexo", sexo)
                cmd.Parameters.AddWithValue("@numero_residencia", txtNumCasa.Text.ToString.ToUpper)
                cmd.Parameters.AddWithValue("@login", txtLogin.Text.ToString.ToUpper)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("ALTERADO COM SUCESSO!", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CadatrosFuncio.entrada()
                    click = 2
                    verificaSenhas = True
                Catch ex As Exception
                    MessageBox.Show("ERRO:" & vbNewLine & Err.Description, "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                cmd.Parameters.Clear()
                If aryTelDel.Count() > 0 Then
                    Dim cont, cont2 As Integer
                    cont2 = 0
                    cont = aryTelDel.Count - 1
                    While cont2 <= cont
                        cmd = New SqlClient.SqlCommand
                        strSql = "delete from TB_TELEFONE_USUARIO " &
                                 "where id_telefone = @id_telefone and id_usuario = @id_usuario"
                        cmd.Parameters.AddWithValue("@id_telefone", aryTelDel.Item(cont2).ToString)
                        cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString)
                        Try
                            cmd.Connection = cnn
                            cmd.CommandText = strSql
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            MsgBox("erro: " & Err.Description)
                        End Try
                        cont2 += 1
                    End While
                    aryTelDel.Clear()
                End If
                If arytelIdAdd.Count > 0 Then
                    Dim cont, cont2 As Integer
                    cont2 = 0
                    cont = arytelIdAdd.Count - 1
                    While cont2 <= cont
                        cmd = New SqlClient.SqlCommand
                        strSql = "execute dbo.inserir_Telefone_Usuario @id_telefone = @id_telefone," &
                                 "@id_usuario = @id_usuario"
                        cmd.Parameters.AddWithValue("@id_telefone", arytelIdAdd.Item(cont2).ToString)
                        cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString)
                        Try
                            cmd.Connection = cnn
                            cmd.CommandText = strSql
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            MsgBox("erro: " & Err.Description)
                        End Try
                        cont2 += 1
                    End While
                    arytelIdAdd.Clear()
                End If
            End If
        End If
        aryTelDel.Clear()
        arytelIdAdd.Clear()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        CadatrosFuncio.limpar()
        CadatrosFuncio.entrada()
        aryTelDel.Clear()
        arytelIdAdd.Clear()
        click = 1
        lblDisc.Enabled = False
    End Sub

    Private Sub btnCons_Click(sender As Object, e As EventArgs) Handles btnCons.Click

        btnDelTel.Enabled = False
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        Dim carregaFoto As Boolean = False
        If hm = "aluno" Then
            If click < 2 Then
                click += 1
            Else
                Call consUsu()
                Exit Sub
            End If
            If CadatrosFuncio.cons() = False Then
                Call consUsu()
                Exit Sub
            End If
            strSql = "execute dbo.uspConsultarAluno @nome_aluno = @nome_aluno," &
                 "@dt_nasc = @dt_nasc," &
                 "@id_matricula = @id_matricula"

            cmd.Connection = cnn
            cmd.CommandText = strSql

            If txtCod.Text = "" Then
                cmd.Parameters.AddWithValue("@nome_aluno", txtNome.Text.ToString)
                cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToString)
                cmd.Parameters.AddWithValue("@id_matricula", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@nome_aluno", DBNull.Value)
                cmd.Parameters.AddWithValue("@dt_nasc", DBNull.Value)
                cmd.Parameters.AddWithValue("@id_matricula", txtCod.Text.ToString)
            End If

            Try
                dr = cmd.ExecuteReader()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmd.Parameters.Clear()
                Exit Sub
            End Try

            Dim cont As Integer = 0
            While dr.Read()
                cont += 1
            End While
            dr.Close()
            If cont > 1 Then
                Call consUsu()
                Exit Sub
            End If

            dr = cmd.ExecuteReader()
            dr.Read()

            If Not dr.HasRows Then
                MessageBox.Show("Aluno não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr.Close()
                Call consUsu()
                Exit Sub
            Else
                dgvTel.Rows.Clear()

                txtConfimSenha.PasswordChar = ""
                txtConfimSenha.Text = "Digite a senha novamente"
                txtConfimSenha.ForeColor = Color.LightSteelBlue

                txtCod.Text = dr("id_matricula").ToString
                If dr("rg") <> "" Then
                    mtbRg.Text = dr("rg").ToString
                    mtbRg.ForeColor = Color.Black
                End If
                If dr("nome_aluno") <> "" Then
                    txtNome.Text = dr("nome_aluno").ToString
                    txtNome.ForeColor = Color.Black
                End If
                If dr("cep_aluno") <> "" Then
                    mtbCep.Text = dr("cep_aluno").ToString
                    mtbCep.ForeColor = Color.Black
                End If
                If Not IsDBNull(dr("cpf")) Then
                    mtbCpf.Text = dr("cpf").ToString
                    mtbCpf.ForeColor = Color.Black
                End If
                If IsDate(dr("dt_nasc")) Then
                    mtbDtNasc.Text = dr("dt_nasc").ToString
                    mtbDtNasc.ForeColor = Color.Black
                End If
                If dr("nome_responsavel") <> "" Then
                    txtResponsavel.Text = dr("nome_responsavel").ToString
                    txtResponsavel.ForeColor = Color.Black
                End If
                If dr("sexo") <> vbNull Then
                    If dr("sexo") = 0 Then
                        cmbSexo.SelectedIndex = 1
                    Else
                        cmbSexo.SelectedIndex = 2
                    End If
                    cmbSexo.ForeColor = Color.Black
                End If
                If dr("senha") <> "" Then
                    txtSenha.PasswordChar = "*"
                    senha = dr("senha").ToString
                    txtSenha.Text = senha
                    txtSenha.ForeColor = Color.Black
                End If
                If Not IsDBNull(dr("ponto_ref")) Then
                    txtPontoRef.Text = dr("ponto_ref").ToString
                    txtPontoRef.ForeColor = Color.Black
                End If
                If IsDate(dr("dt_cad")) Then
                    mtbDtCad.Text = dr("dt_cad").ToString
                    mtbDtCad.ForeColor = Color.Black
                End If
                If Not IsDBNull(dr("email_aluno")) Then
                    txtEmail.Text = dr("email_aluno").ToString
                    txtEmail.ForeColor = Color.Black
                End If
                If Not IsDBNull(dr("foto_aluno")) Then
                    carregaFoto = True
                End If
                txtNumCasa.Text = dr("Num_Casa").ToString
                dr.Close()
                Call btnConsCep.PerformClick()
                strAcao = "alterar"
                chkVisuSenha.Visible = True
                verificaSenhas = False
            End If

            cmd.Parameters.Clear()
            cmd = Nothing
            dr.Close()
            If carregaFoto = True Then
                Call ObtemImagem()
            End If
            Try
                preencherGridTel()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try

            txtNome.Focus()
            strAcao = "alterar"
            CadatrosFuncio.ConsultarAluno()
            btnConsCep.PerformClick()
            Exit Sub
        Else
            If click < 2 Then
                click += 1
            Else
                Call consUsu()
                Exit Sub
            End If
            If CadatrosFuncio.cons() = False Then
                Call consUsu()
                Exit Sub
            End If
            strSql = "execute dbo.uspConsultarUsuario @nome_usuario = @nome_usuario," &
                     "@dt_nasc = @dt_nasc," &
                     "@id_usuario = @id_usuario"

            cmd.Connection = cnn
            cmd.CommandText = strSql

            If txtCod.Text = "" Then
                cmd.Parameters.AddWithValue("@nome_usuario", txtNome.Text.ToString)
                cmd.Parameters.AddWithValue("@dt_nasc", mtbDtNasc.Text.ToString)
                cmd.Parameters.AddWithValue("@id_usuario", DBNull.Value)
            Else
                cmd.Parameters.AddWithValue("@nome_usuario", DBNull.Value)
                cmd.Parameters.AddWithValue("@dt_nasc", DBNull.Value)
                cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString)
            End If

            Try
                dr = cmd.ExecuteReader()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmd.Parameters.Clear()
                Exit Sub
            End Try
            Dim cont As Integer = 0
            While dr.Read()
                cont += 1
            End While
            dr.Close()
            If cont > 1 Then
                Call consUsu()
            End If
            dr = cmd.ExecuteReader()
            dr.Read()
            If Not dr.HasRows Then
                MessageBox.Show(hm.ToUpper & " não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr.Close()
                Call consUsu()
                Exit Sub
            Else
                If dr("tipo_usuario") <> hm.ToUpper Then
                    MessageBox.Show(hm.ToUpper & " não encontrado!", "CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dr.Close()
                    cmd.Parameters.Clear()
                    Call consUsu()
                    Exit Sub
                End If
                dgvTel.Rows.Clear()

                txtConfimSenha.PasswordChar = ""
                txtConfimSenha.Text = "Digite a senha novamente"
                txtConfimSenha.ForeColor = Color.LightSteelBlue

                txtCod.Text = dr("id_usuario").ToString
                If dr("rg_usuario") <> "" Then
                    mtbRg.Text = dr("rg_usuario").ToString
                    mtbRg.ForeColor = Color.Black
                End If
                If dr("nome_usuario") <> "" Then
                    txtNome.Text = dr("nome_usuario").ToString
                    txtNome.ForeColor = Color.Black
                End If
                If dr("cep") <> "" Then
                    mtbCep.Text = dr("cep").ToString
                    mtbCep.ForeColor = Color.Black
                    Call btnConsCep.PerformClick()
                End If
                If dr("cpf_usuario") IsNot DBNull.Value Then
                    mtbCpf.Text = dr("cpf_usuario").ToString
                    mtbCpf.ForeColor = Color.Black
                End If
                If IsDate(dr("dt_nasc")) Then
                    mtbDtNasc.Text = dr("dt_nasc").ToString
                    mtbDtNasc.ForeColor = Color.Black
                End If
                If dr("sexo") <> vbNull Then
                    If dr("sexo") = 0 Then
                        cmbSexo.SelectedIndex = 1
                    Else
                        cmbSexo.SelectedIndex = 2
                    End If
                    cmbSexo.ForeColor = Color.Black
                End If
                If dr("senha_usuario") <> "" Then
                    txtSenha.PasswordChar = "*"
                    senha = dr("senha_usuario").ToString
                    txtSenha.Text = senha
                    txtSenha.ForeColor = Color.Black
                End If
                If dr("referencia") IsNot DBNull.Value Then
                    txtPontoRef.Text = dr("referencia").ToString
                    txtPontoRef.ForeColor = Color.Black
                End If
                If IsDate(dr("dt_cad")) Then
                    mtbDtCad.Text = dr("dt_cad").ToString
                    mtbDtCad.ForeColor = Color.Black
                End If
                If dr("email_usuario") IsNot DBNull.Value Then
                    txtEmail.Text = dr("email_usuario").ToString
                    txtEmail.ForeColor = Color.Black
                End If
                If dr("login") <> "" Then
                    txtLogin.Text = dr("login").ToString
                    txtLogin.ForeColor = Color.Black
                End If
                If Not IsDBNull(dr("foto_usuario")) Then
                    carregaFoto = True
                End If
                cmbSexo.ForeColor = Color.Black

                txtNumCasa.Text = dr("numero_residencia").ToString
                dr.Close()
                strAcao = "alterar"
                verificaSenhas = False
                lblDisc.Enabled = True
                disc = True

            End If

            cmd.Parameters.Clear()
            If carregaFoto = True Then
                Call ObtemImagem()
            End If
            Try
                preencherGridTel()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
            txtNome.Focus()

            strAcao = "alterar"

            CadatrosFuncio.ConsultarAluno()
            Call btnConsCep.PerformClick()
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            If hm = "aluno" Then
                If strAcao = "alterar" Then
                    Dim cmd As New SqlClient.SqlCommand
                    strSql = "delete from TB_TELEFONE_ALUNO where id_matricula = " & txtCod.Text
                    cmd.Connection = cnn
                    cmd.CommandText = strSql
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("erou!" & Err.Description)
                    End Try
                    cmd = New SqlClient.SqlCommand
                    strSql = "execute dbo.uspIAEALUNO @ACAO = 0," &
                             "@id_matricula = @id_matricula"
                    cmd.Connection = cnn
                    cmd.CommandText = strSql
                    cmd.Parameters.AddWithValue("@id_matricula", txtCod.Text.ToString)
                    Try
                        cmd.ExecuteNonQuery()
                        File.Delete(imageDestino + hm + Trim(txtCod.Text) + ".jpg")
                        MessageBox.Show("ALUNO REMOVIDO COM SUCESSO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CadatrosFuncio.limpar()
                        CadatrosFuncio.entrada()
                    Catch ex As Exception
                        MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    cmd.Parameters.Clear()
                End If
            Else
                If strAcao = "alterar" Then
                    Dim cmd As New SqlClient.SqlCommand
                    strSql = "delete from TB_TELEFONE_USUARIO where id_usuario = " & txtCod.Text
                    cmd.Connection = cnn
                    cmd.CommandText = strSql
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("erou!" & Err.Description)
                    End Try
                    cmd = New SqlClient.SqlCommand
                    strSql = "dbo.aiaeUsuario @ACAO = 0," &
                             "@id_usuario = @id_usuario"
                    cmd.Connection = cnn
                    cmd.CommandText = strSql
                    cmd.Parameters.AddWithValue("@id_usuario", txtCod.Text.ToString)
                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show(hm.ToUpper & " REMOVIDO COM SUCESSO!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CadatrosFuncio.limpar()
                        CadatrosFuncio.entrada()
                    Catch ex As Exception
                        MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    cmd.Parameters.Clear()
                End If
            End If

        Else

        End If
    End Sub

    Private Sub letras(sender As Object, e As KeyPressEventArgs) Handles txtCidade.KeyPress, txtBairro.KeyPress, txtEndereco.KeyPress, txtResponsavel.KeyPress, txtNome.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtCod.KeyPress, txtNumCasa.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub

    Private Sub btnDelTel_Click(sender As Object, e As EventArgs) Handles btnDelTel.Click
        If MessageBox.Show("DESEJA MESMO REMOVER ESSE TELEFONE?", "TELEFONE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If strAcao = "incluir" Then
                arytelIdAdd.RemoveAt(dgvTel.CurrentRow.Index)

                Dim cont, cont2 As Integer
                cont2 = 0
                cont = aryTelDel.Count - 1
                While cont2 <= cont

                    cont2 += 1
                End While
            Else
                Dim id = dgvTel.CurrentRow.Cells("cadColID").Value
                aryTelDel.Add(id.ToString)
            End If
            dgvTel.Rows.Remove(dgvTel.CurrentRow)
        End If

    End Sub

    Private Sub dgvTel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTel.CellClick
        btnDelTel.Enabled = True
    End Sub

    Private Sub lblDisc_MouseMove(sender As Object, e As EventArgs) Handles lblDisc.MouseMove
        lblDisc.ForeColor = Color.White
    End Sub

    Private Sub lblDisc_MouseLeave(sender As Object, e As EventArgs) Handles lblDisc.MouseLeave
        lblDisc.ForeColor = ColorTranslator.FromOle(RGB(22, 95, 88))
    End Sub

    Private Sub lblDisc_Click(sender As Object, e As EventArgs) Handles lblDisc.Click
        If disc = True Then
            FrmDisciplina.txtCodProf.Text = txtCod.Text
            FrmDisciplina.txtNomeProf.Text = txtNome.Text
            FrmDisciplina.cadastrosID = txtCod.Text
            FrmDisciplina.cadastrosNome = txtNome.Text
            FrmDisciplina.txtNomeProf.ForeColor = Color.Black
            FrmDisciplina.btnAddProf.Enabled = True
            FrmDisciplina.cadastros = True
            FrmDisciplina.click = 2
        End If
        FrmDisciplina.ShowDialog()
        FrmDisciplina.txtCodProf.Clear()
        FrmDisciplina.txtNomeProf.Text = "Digite o nome"
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub

    Private Sub chkVisuSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkVisuSenha.CheckedChanged
        If chkVisuSenha.Checked Then
            txtSenha.PasswordChar = ""
        Else
            txtSenha.PasswordChar = "*"
        End If

    End Sub

    Private Sub txtSenha_TextChanged(sender As Object, e As EventArgs) Handles txtSenha.TextChanged
        If txtSenha.Text <> senha Then
            verificaSenhas = True
        End If
    End Sub
End Class