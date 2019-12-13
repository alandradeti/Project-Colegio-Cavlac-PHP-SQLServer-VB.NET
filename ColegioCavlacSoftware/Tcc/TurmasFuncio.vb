Module TurmasFuncio
    Sub load()
        CadastrarTurma.cmbPeriodo.Items.Add("---")
        CadastrarTurma.cmbPeriodo.Items.Add("MANHÃ")
        CadastrarTurma.cmbPeriodo.Items.Add("TARDE")
        CadastrarTurma.cmbPeriodo.Items.Add("NOITE")

        CadastrarTurma.cmbPeriodo.SelectedIndex = 0

        CadastrarTurma.cmbDisc.Items.Add("---")

        CadastrarTurma.cmbDisc.SelectedIndex = 0
    End Sub

    Sub entrada()
        CadastrarTurma.btnConsTurma.Enabled = True
        CadastrarTurma.btnLimparTurma.Enabled = True
        CadastrarTurma.btnNovo.Enabled = True
        CadastrarTurma.btnExcluir.Enabled = False
        CadastrarTurma.btnCancelar.Enabled = False
        CadastrarTurma.btnGravar.Enabled = False
        CadastrarTurma.tabAlunProf.Enabled = False
    End Sub

    Sub novo()
        CadastrarTurma.btnConsTurma.Enabled = False
        CadastrarTurma.btnLimparTurma.Enabled = True
        CadastrarTurma.btnNovo.Enabled = False
        CadastrarTurma.btnExcluir.Enabled = False
        CadastrarTurma.btnCancelar.Enabled = True
        CadastrarTurma.btnGravar.Enabled = True
        CadastrarTurma.tabAlunProf.Enabled = False
    End Sub

    Sub limparTurma()
        CadastrarTurma.txtTurma.Text = "Digite a turma"
        CadastrarTurma.txtTurma.ForeColor = Color.LightSteelBlue
        CadastrarTurma.cmbPeriodo.SelectedIndex = 0
        CadastrarTurma.cmbPeriodo.ForeColor = Color.LightSteelBlue
        CadastrarTurma.mtbAnoTurma.Text = ""
        CadastrarTurma.mtbAnoTurma.ForeColor = Color.LightSteelBlue
    End Sub

    Sub botoes()
        CadastrarTurma.btnConsTurma.Enabled = True
        CadastrarTurma.btnNovo.Enabled = True
        CadastrarTurma.btnExcluir.Enabled = False
        CadastrarTurma.btnCancelar.Enabled = False
        CadastrarTurma.btnGravar.Enabled = False
    End Sub

    Function Gravar() As Boolean
        If CadastrarTurma.txtTurma.Text = "Digite a turma" Or CadastrarTurma.txtTurma.Text = "" Then
            MessageBox.Show("Turma é um campo Obrigatório!" & vbNewLine & "DIGITE A TURMA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CadastrarTurma.txtTurma.Focus()
            Return False
            Exit Function
        End If
        If Val(CadastrarTurma.mtbAnoTurma.Text) = 0 Then
            MessageBox.Show("Ano é um campo Obrigatório!" & vbNewLine & "DIGITE O ANO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CadastrarTurma.mtbAnoTurma.Focus()
            Return False
            Exit Function
        End If
        If CadastrarTurma.cmbPeriodo.SelectedIndex = 0 Then
            MessageBox.Show("Período é um campo Obrigatório!" & vbNewLine & "SELECIONE O PERÍODO.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CadastrarTurma.cmbPeriodo.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Sub ConsTurma()
        CadastrarTurma.btnConsTurma.Enabled = True
        CadastrarTurma.btnLimparTurma.Enabled = True
        CadastrarTurma.btnNovo.Enabled = True
        CadastrarTurma.btnExcluir.Enabled = True
        CadastrarTurma.btnCancelar.Enabled = True
        CadastrarTurma.btnGravar.Enabled = True
        CadastrarTurma.tabAlunProf.Enabled = True
    End Sub

    Sub limparAluno()
        CadastrarTurma.txtMatricula.Clear()
        CadastrarTurma.txtNomeAluno.Text = "Digite o nome"
    End Sub

    Sub limparProfessor()
        CadastrarTurma.txtCod.Clear()
        CadastrarTurma.txtNomeProf.Text = "Digite o nome"
        CadastrarTurma.cmbDisc.Items.Clear()
        CadastrarTurma.cmbDisc.Items.Add("---")
        CadastrarTurma.cmbDisc.SelectedIndex = 0
        CadastrarTurma.cmbDisc.Enabled = False
    End Sub

    Function addProf() As Boolean
        If CadastrarTurma.cmbDisc.SelectedIndex = 0 Then
            MessageBox.Show("Disciplina é um Campo Obrigatório!" & vbNewLine & "SELECIONE UMA DISCIPLINA.", "ADICIONAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CadastrarTurma.cmbDisc.Focus()
            Return False
        End If
        Return True
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
End Module
