Module CadatrosFuncio

    Private Const msgErro As String = "Dados Inválidos"
    Private bValida As Boolean
    Private sCPF As String

    Function cons() As Boolean
        If Home.cadastros.txtCod.Text = "" And Home.cadastros.txtNome.Text = "" And Val(Home.cadastros.mtbDtNasc.Text) = 0 Then
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCod.Text = "" And Home.cadastros.txtNome.Text = "Digite o nome" And Val(Home.cadastros.mtbDtNasc.Text) = 0 Then
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCod.Text = "" And Val(Home.cadastros.mtbDtNasc.Text) = 0 Then
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCod.Text = "" And Home.cadastros.txtNome.Text = "" Then
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCod.Text = "" And Home.cadastros.txtNome.Text = "Digite o nome" Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Sub entrada()
        If Home.cadastros.hm = "aluno" Then
            Home.cadastros.lblCod.Text = "RA:"
            Home.cadastros.lblCPF.Text = "CPF:"
        Else
            Home.cadastros.lblCod.Text = "COD:"
            Home.cadastros.lblCPF.Text = "*CPF:"
        End If
        Home.cadastros.txtCod.Enabled = True
        Home.cadastros.txtNome.Enabled = True
        Home.cadastros.mtbDtNasc.Enabled = True
        Home.cadastros.btnCons.Enabled = True
        Home.cadastros.btnNovo.Enabled = True
        Home.cadastros.btnLimpar.Enabled = True

        Home.cadastros.cmbSexo.Enabled = False
        Home.cadastros.mtbCpf.Enabled = False
        Home.cadastros.mtbRg.Enabled = False
        Home.cadastros.txtEmail.Enabled = False
        Home.cadastros.txtResponsavel.Enabled = False
        Home.cadastros.btnConsFoto.Enabled = False
        Home.cadastros.btnApagarFoto.Enabled = False

        Home.cadastros.pnlEndereco.Enabled = False
        Home.cadastros.pnlUsuario.Enabled = False
        Home.cadastros.dgvTel.Enabled = False
        Home.cadastros.btnConsTel.Enabled = False
        Home.cadastros.btnDelTel.Enabled = False

        Home.cadastros.btnExcluir.Enabled = False
        Home.cadastros.btnGravar.Enabled = False
        Home.cadastros.btnCancelar.Enabled = False
        If IsNothing(Home.cadastros.ptbFoto.Image) Then
            Home.cadastros.ptbFoto.Image = Nothing
        End If
        Home.cadastros.lblDisc.Enabled = True

    End Sub

    Sub Novo()
        Home.cadastros.txtCod.Enabled = False
        Home.cadastros.txtNome.Enabled = True
        Home.cadastros.mtbDtNasc.Enabled = True
        Home.cadastros.btnCons.Enabled = False
        Home.cadastros.btnNovo.Enabled = False
        Home.cadastros.btnLimpar.Enabled = False

        Home.cadastros.cmbSexo.Enabled = True
        Home.cadastros.mtbCpf.Enabled = True
        Home.cadastros.mtbRg.Enabled = True
        Home.cadastros.txtEmail.Enabled = True
        Home.cadastros.txtResponsavel.Enabled = False
        Home.cadastros.btnConsFoto.Enabled = True
        Home.cadastros.btnApagarFoto.Enabled = True

        Home.cadastros.pnlEndereco.Enabled = True
        Home.cadastros.pnlUsuario.Enabled = True
        Home.cadastros.dgvTel.Enabled = True
        Home.cadastros.btnConsTel.Enabled = True

        Home.cadastros.btnExcluir.Enabled = False
        Home.cadastros.btnGravar.Enabled = True
        Home.cadastros.btnCancelar.Enabled = True
        Home.cadastros.lblDisc.Enabled = False
    End Sub

    Sub NovoAluno()
        Home.cadastros.txtCod.Focus()
        Home.cadastros.txtCod.Enabled = True
        Home.cadastros.txtNome.Enabled = True
        Home.cadastros.mtbDtNasc.Enabled = True
        Home.cadastros.btnCons.Enabled = False
        Home.cadastros.btnNovo.Enabled = False
        Home.cadastros.btnLimpar.Enabled = False

        Home.cadastros.cmbSexo.Enabled = True
        Home.cadastros.mtbCpf.Enabled = True
        Home.cadastros.mtbRg.Enabled = True
        Home.cadastros.txtEmail.Enabled = True
        Home.cadastros.txtResponsavel.Enabled = True
        Home.cadastros.btnConsFoto.Enabled = True
        Home.cadastros.btnApagarFoto.Enabled = True

        Home.cadastros.pnlEndereco.Enabled = True

        Home.cadastros.pnlUsuario.Enabled = True
        Home.cadastros.txtLogin.Enabled = False
        Home.cadastros.mtbDtCad.Enabled = True
        Home.cadastros.txtSenha.Enabled = True
        Home.cadastros.txtConfimSenha.Enabled = True

        Home.cadastros.dgvTel.Enabled = True
        Home.cadastros.btnConsTel.Enabled = True

        Home.cadastros.btnExcluir.Enabled = False
        Home.cadastros.btnGravar.Enabled = True
        Home.cadastros.btnCancelar.Enabled = True
    End Sub

    Sub ConsultarAluno()
        Home.cadastros.txtCod.Focus()
        Home.cadastros.txtCod.Enabled = True
        Home.cadastros.txtNome.Enabled = True
        Home.cadastros.mtbDtNasc.Enabled = True
        Home.cadastros.btnCons.Enabled = True
        Home.cadastros.btnNovo.Enabled = True
        Home.cadastros.btnLimpar.Enabled = True

        Home.cadastros.cmbSexo.Enabled = True
        Home.cadastros.mtbCpf.Enabled = True
        Home.cadastros.mtbRg.Enabled = True
        Home.cadastros.txtEmail.Enabled = True
        Home.cadastros.txtResponsavel.Enabled = True
        Home.cadastros.btnConsFoto.Enabled = True
        Home.cadastros.btnApagarFoto.Enabled = True

        Home.cadastros.pnlEndereco.Enabled = True

        Home.cadastros.pnlUsuario.Enabled = True
        Home.cadastros.txtLogin.Enabled = False
        Home.cadastros.mtbDtCad.Enabled = True
        If Home.cadastros.hm = "aluno" Then
            Home.cadastros.txtSenha.Enabled = False
        Else
            Home.cadastros.txtSenha.Enabled = True
        End If

        Home.cadastros.txtConfimSenha.Enabled = False

        Home.cadastros.dgvTel.Enabled = True
        Home.cadastros.btnConsTel.Enabled = True

        Home.cadastros.btnExcluir.Enabled = True
        Home.cadastros.btnGravar.Enabled = True
        Home.cadastros.btnCancelar.Enabled = True

        If Home.cadastros.hm <> "aluno" Then
            Home.cadastros.txtLogin.Enabled = True
            Home.cadastros.txtConfimSenha.Enabled = True
            Home.cadastros.txtResponsavel.Enabled = False
        End If
    End Sub

    Sub limpar()
        If Home.cadastros.hm = "aluno" Then
            Home.cadastros.chkVisuSenha.CheckState = False
            Home.cadastros.chkVisuSenha.Visible = False
            Home.cadastros.txtSenha.PasswordChar = ""
        End If
        'Home.cadastros.verificaSenhas = True
        Home.cadastros.txtNome.Text = "Digite o nome"
        Home.cadastros.txtNome.ForeColor = Color.LightSteelBlue
        Home.cadastros.mtbDtNasc.Clear()
        Home.cadastros.mtbDtNasc.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtCod.Clear()
        Home.cadastros.cmbSexo.SelectedIndex = 0
        Home.cadastros.cmbSexo.ForeColor = Color.LightSteelBlue
        Home.cadastros.mtbCpf.Clear()
        Home.cadastros.mtbCpf.ForeColor = Color.LightSteelBlue
        Home.cadastros.mtbRg.Clear()
        Home.cadastros.mtbRg.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtEmail.Text = "Digite o E-MAIL"
        Home.cadastros.txtEmail.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtResponsavel.Text = "Digite o nome"
        Home.cadastros.txtResponsavel.ForeColor = Color.LightSteelBlue
        Home.cadastros.mtbCep.Clear()
        Home.cadastros.mtbCep.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtEndereco.Text = "Digite o endereço"
        Home.cadastros.txtEndereco.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtBairro.Text = "Digite o bairro"
        Home.cadastros.txtBairro.ForeColor = Color.LightSteelBlue
        Home.cadastros.cmbUf.SelectedIndex = 0
        Home.cadastros.cmbUf.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtCidade.Text = "Digite a cidade"
        Home.cadastros.txtCidade.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtPontoRef.Text = "Digite a referência"
        Home.cadastros.txtPontoRef.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtLogin.Text = "Digite o login"
        Home.cadastros.txtLogin.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtSenha.PasswordChar = ""
        Home.cadastros.txtSenha.Text = "Digite a senha"
        Home.cadastros.txtConfimSenha.PasswordChar = ""
        Home.cadastros.txtSenha.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtConfimSenha.Text = "Digite a senha novamente"
        Home.cadastros.txtConfimSenha.PasswordChar = ""
        Home.cadastros.txtConfimSenha.ForeColor = Color.LightSteelBlue
        Home.cadastros.mtbDtCad.Clear()
        Home.cadastros.mtbDtCad.ForeColor = Color.LightSteelBlue
        Home.cadastros.txtNumCasa.Text = ""
        Home.cadastros.ptbFoto.Image = Nothing
        Home.cadastros.dgvTel.Rows.Clear()
        Home.cadastros.lblDisc.Enabled = True
    End Sub

    Sub load()
        Home.cadastros.cmbSexo.Items.Add("---")
        Home.cadastros.cmbSexo.Items.Add("Masculino")
        Home.cadastros.cmbSexo.Items.Add("Feminino")
        Home.cadastros.cmbSexo.SelectedIndex = 0

        Home.cadastros.cmbUf.Items.Add("---")
        Home.cadastros.cmbUf.Items.Add("AC")
        Home.cadastros.cmbUf.Items.Add("AL")
        Home.cadastros.cmbUf.Items.Add("AP")
        Home.cadastros.cmbUf.Items.Add("AM")
        Home.cadastros.cmbUf.Items.Add("BA")
        Home.cadastros.cmbUf.Items.Add("CE")
        Home.cadastros.cmbUf.Items.Add("DF")
        Home.cadastros.cmbUf.Items.Add("ES")
        Home.cadastros.cmbUf.Items.Add("GO")
        Home.cadastros.cmbUf.Items.Add("MA")
        Home.cadastros.cmbUf.Items.Add("MT")
        Home.cadastros.cmbUf.Items.Add("MS")
        Home.cadastros.cmbUf.Items.Add("MG")
        Home.cadastros.cmbUf.Items.Add("PA")
        Home.cadastros.cmbUf.Items.Add("PB")
        Home.cadastros.cmbUf.Items.Add("PR")
        Home.cadastros.cmbUf.Items.Add("PE")
        Home.cadastros.cmbUf.Items.Add("PI")
        Home.cadastros.cmbUf.Items.Add("RJ")
        Home.cadastros.cmbUf.Items.Add("RN")
        Home.cadastros.cmbUf.Items.Add("RS")
        Home.cadastros.cmbUf.Items.Add("RO")
        Home.cadastros.cmbUf.Items.Add("RR")
        Home.cadastros.cmbUf.Items.Add("SC")
        Home.cadastros.cmbUf.Items.Add("SP")
        Home.cadastros.cmbUf.Items.Add("SE")
        Home.cadastros.cmbUf.Items.Add("TO")

        Home.cadastros.cmbUf.SelectedIndex = 0

        Home.cadastros.lblDisc.Enabled = True
    End Sub

    Public Function GravarAluno() As Boolean
        If Home.cadastros.txtCod.Text = "" Then
            MessageBox.Show("RA é um campo obrigatório!" & vbNewLine & "DIGITE O RA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtCod.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtNome.Text.Trim = "" Or Home.cadastros.txtNome.Text = "Digite o nome" Then
            MessageBox.Show("Nome é um campo obrigatório!" & vbNewLine & "DIGITE UM NOME.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtNome.Focus()
            Return False
            Exit Function
        End If
        If Not (IsDate(Home.cadastros.mtbDtNasc.Text)) Then
            MessageBox.Show("Data de Nascimento é um campo obrigatório!" & vbNewLine & "DIGITE UMA DATA VÁLIDA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbDtNasc.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.cmbSexo.SelectedIndex = 0 Then
            MessageBox.Show("Sexo é um campo obrigatório!" & vbNewLine & "SELECIONE UM SEXO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.cmbSexo.Focus()
            Return False
            Exit Function
        End If

        If Val(Home.cadastros.mtbCpf.Text) <> 0 Then
            If ValidaCPF(Home.cadastros.mtbCpf.Text) = False Then
                MessageBox.Show("CPF Inválido!" & vbNewLine & "DIGITE UM CPF VÁLIDO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.mtbCpf.Focus()
                Return False
                Exit Function
            End If
        End If
        If Val(Home.cadastros.mtbRg.Text) = 0 Then
            MessageBox.Show("RG é um campo obrigatório!" & vbNewLine & "DIGITE O RG.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbRg.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtEmail.Text <> "" And Home.cadastros.txtEmail.Text <> "Digite o E-MAIL" Then
            If ValidateEmail(Home.cadastros.txtEmail.Text) = False Then
                MessageBox.Show("E-MAIL Inválido!" & vbNewLine & "DIGITE UM E-MAIL VÁLIDO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtEmail.Focus()
                Return False
                Exit Function
            End If
        End If
        If Home.cadastros.txtResponsavel.Text = "Digite o nome" Or Home.cadastros.txtResponsavel.Text.Trim() = "" Then
            MessageBox.Show("Nome do Responsável é um campo obrigatório!" & vbNewLine & "DIGITE O NOME DO RESPONSÁVEL.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtResponsavel.Focus()
            Return False
            Exit Function
        End If
        If Val(Home.cadastros.mtbCep.Text) = 0 Then
            MessageBox.Show("CEP é um campo obrigatório!" & vbNewLine & "DIGITE O CEP.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbCep.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtEndereco.Text = "Digite o endereço" Or Home.cadastros.txtEndereco.Text.Trim() = "" Then
            MessageBox.Show("Endereço é um campo obrigatório!" & vbNewLine & "DIGITE O ENDEREÇO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtEndereco.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtBairro.Text = "Digite o bairro" Or Home.cadastros.txtBairro.Text.Trim() = "" Then
            MessageBox.Show("Bairro é um campo obrigatório!" & vbNewLine & "DIGITE O BAIRRO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtBairro.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.cmbUf.SelectedIndex = 0 Then
            MessageBox.Show("UF é um campo obrigatório!" & vbNewLine & "SELECIONE O UF.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.cmbUf.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtNumCasa.Text = "" Then
            MessageBox.Show("Número da casa é um campo obrigatório!" & vbNewLine & "DIGITE O NÚMERO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtNumCasa.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCidade.Text = "Digite a cidade" Or Home.cadastros.txtCidade.Text.Trim() = "" Then
            MessageBox.Show("Cidade é um campo obrigatório!" & vbNewLine & "DIGITE A CIDADE.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtCidade.Focus()
            Return False
            Exit Function
        End If
        If Not (IsDate(Home.cadastros.mtbDtCad.Text)) Then
            MessageBox.Show("Data de Cadastros é um campo obrigatório!" & vbNewLine & "DIGITE A DATA DE CADASTRO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbDtCad.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.verificaSenhas Then
            If Home.cadastros.txtSenha.Text = "" Or Home.cadastros.txtSenha.Text = "Digite a senha" Then
                MessageBox.Show("Senha é um campo obrigatório!" & vbNewLine & "DIGITE A SENHA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtSenha.Focus()
                Return False
                Exit Function
            End If
            If Home.cadastros.txtSenha.Text <> Home.cadastros.txtConfimSenha.Text Then
                MessageBox.Show("Validação da senha está incorreta!!" & vbNewLine & "CONFIRME A SENHA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtConfimSenha.Focus()
                Return False
                Exit Function
            End If
        End If

        If Home.cadastros.dgvTel.RowCount = 0 Then
            MessageBox.Show("Telefone é um campo obrigatório!" & vbNewLine & "SELECIONE AO MENOS UM TELEFONE.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.btnConsTel.PerformClick()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Public Function GravarUsuario() As Boolean

        If Home.cadastros.txtNome.Text.Trim = "" Or Home.cadastros.txtNome.Text = "Digite o nome" Then
            MessageBox.Show("Nome é um campo obrigatório!" & vbNewLine & "DIGITE UM NOME.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtNome.Focus()
            Return False
            Exit Function
        End If
        If Not (IsDate(Home.cadastros.mtbDtNasc.Text)) Then
            MessageBox.Show("Data de Nascimento é um campo obrigatório!" & vbNewLine & "DIGITE UMA DATA VÁLIDA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbDtNasc.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.cmbSexo.SelectedIndex = 0 Then
            MessageBox.Show("Sexo é um campo obrigatório!" & vbNewLine & "SELECIONE UM SEXO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.cmbSexo.Focus()
            Return False
            Exit Function
        End If

        If Val(Home.cadastros.mtbCpf.Text) = 0 Then
                MessageBox.Show("CPF é um campo obrigatório!" & vbNewLine & "DIGITE UM CPF VÁLIDO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.mtbCpf.Focus()
                Return False
                Exit Function
            End If

        If Val(Home.cadastros.mtbCpf.Text) <> 0 Then

            If ValidaCPF(Home.cadastros.mtbCpf.Text) = False Then
                MessageBox.Show("CPF Inválido!" & vbNewLine & "DIGITE UM CPF VÁLIDO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.mtbCpf.Focus()
                Return False
                Exit Function
            End If
        End If
        If Val(Home.cadastros.mtbRg.Text) = 0 Then
            MessageBox.Show("RG é um campo obrigatório!" & vbNewLine & "DIGITE O RG.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbRg.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtEmail.Text <> "" And Home.cadastros.txtEmail.Text <> "Digite o E-MAIL" Then
            If ValidateEmail(Home.cadastros.txtEmail.Text) = False Then
                MessageBox.Show("E-MAIL Inválido!" & vbNewLine & "DIGITE UM E-MAIL VÁLIDO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtEmail.Focus()
                Return False
                Exit Function
            End If
        End If
        If Val(Home.cadastros.mtbCep.Text) = 0 Then
            MessageBox.Show("CEP é um campo obrigatório!" & vbNewLine & "DIGITE O CEP.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbCep.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtEndereco.Text = "Digite o endereço" Or Home.cadastros.txtEndereco.Text.Trim() = "" Then
            MessageBox.Show("Endereço é um campo obrigatório!" & vbNewLine & "DIGITE O ENDEREÇO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtEndereco.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtBairro.Text = "Digite o bairro" Or Home.cadastros.txtBairro.Text.Trim() = "" Then
            MessageBox.Show("Bairro é um campo obrigatório!" & vbNewLine & "DIGITE O BAIRRO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtBairro.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.cmbUf.SelectedIndex = 0 Then
            MessageBox.Show("UF é um campo obrigatório!" & vbNewLine & "SELECIONE O UF.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.cmbUf.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtNumCasa.Text = "" Then
            MessageBox.Show("Número da casa é um campo obrigatório!" & vbNewLine & "DIGITE O NÚMERO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtNumCasa.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtCidade.Text = "Digite a cidade" Or Home.cadastros.txtCidade.Text.Trim() = "" Then
            MessageBox.Show("Cidade é um campo obrigatório!" & vbNewLine & "DIGITE A CIDADE.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtCidade.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.txtLogin.Text = "" Or Home.cadastros.txtLogin.Text = "Digite o login" Then
            MessageBox.Show("Login é um campo obrigatório!" & vbNewLine & "DIGITE O LOGIN.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.txtLogin.Focus()
            Return False
            Exit Function
        End If
        If Not (IsDate(Home.cadastros.mtbDtCad.Text)) Then
            MessageBox.Show("Data de Cadastros é um campo obrigatório!" & vbNewLine & "DIGITE A DATA DE CADASTRO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.mtbDtCad.Focus()
            Return False
            Exit Function
        End If
        If Home.cadastros.verificaSenhas Then
            If Home.cadastros.txtSenha.Text = "" Or Home.cadastros.txtSenha.Text = "Digite a senha" Then
                MessageBox.Show("Senha é um campo obrigatório!" & vbNewLine & "DIGITE A SENHA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtSenha.Focus()
                Return False
                Exit Function
            End If
            If Home.cadastros.txtSenha.Text <> Home.cadastros.txtConfimSenha.Text Then
                MessageBox.Show("Validação da senha está incorreta!!" & vbNewLine & "CONFIRME A SENHA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Home.cadastros.txtConfimSenha.Focus()
                Return False
                Exit Function
            End If
        End If

            If Home.cadastros.dgvTel.RowCount = 0 Then
            MessageBox.Show("Telefone é um campo obrigatório!" & vbNewLine & "SELECIONE AO MENOS UM TELEFONE.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Home.cadastros.btnConsTel.PerformClick()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If

        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
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

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex(
        "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match =
       emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Function ValidaCPF(ByVal CPF As String) As Boolean

        Dim dadosArray() As String = {"111,111,111-11", "222,222,222-22", "333,333,333-33", "444,444,444-44",
                                              "555,555,555-55", "666,666,666-66", "777,777,777-77", "888,888,888-88", "999,999,999-99"}
        Dim i, x, n1, n2 As Integer

        CPF = CPF.Trim
        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
                Return False
            End If
        Next
        'remove a maskara
        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0

            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                Return False
            End If
        Next

        Return True
    End Function

End Module

