Module DiscpFuncio
    Sub load()
        FrmDisciplina.btnConsDisc.Enabled = True
        FrmDisciplina.txtDisciplina.Enabled = True
        FrmDisciplina.btnNovo.Enabled = True
        FrmDisciplina.btnExcluir.Enabled = False
        FrmDisciplina.btnCancelar.Enabled = False
        FrmDisciplina.btnGravar.Enabled = False
        FrmDisciplina.txtCodProf.Enabled = False
        FrmDisciplina.txtNomeProf.Enabled = False
        FrmDisciplina.btnConsProf.Enabled = False
        FrmDisciplina.btnLimparProf.Enabled = False
        If FrmDisciplina.cadastros = True Then
            FrmDisciplina.btnAddProf.Enabled = True
        Else
            FrmDisciplina.btnAddProf.Enabled = False
        End If
        FrmDisciplina.btnRemoveProf.Enabled = False
        FrmDisciplina.dgvDisc.Enabled = True
    End Sub

    Sub botoes()
        FrmDisciplina.btnConsDisc.Enabled = True
        FrmDisciplina.txtDisciplina.Enabled = True
        FrmDisciplina.btnNovo.Enabled = True
        FrmDisciplina.btnExcluir.Enabled = False
        FrmDisciplina.btnCancelar.Enabled = False
        FrmDisciplina.btnGravar.Enabled = False
        FrmDisciplina.txtCodProf.Enabled = True
        FrmDisciplina.txtNomeProf.Enabled = False
        FrmDisciplina.btnConsProf.Enabled = True
        FrmDisciplina.btnLimparProf.Enabled = True
        FrmDisciplina.dgvDisc.Enabled = True
    End Sub

    Sub novo()
        FrmDisciplina.btnConsDisc.Enabled = False
        FrmDisciplina.txtDisciplina.Enabled = True
        FrmDisciplina.txtDisciplina.Focus()
        FrmDisciplina.btnNovo.Enabled = False
        FrmDisciplina.btnExcluir.Enabled = False
        FrmDisciplina.btnCancelar.Enabled = True
        FrmDisciplina.btnGravar.Enabled = True
        FrmDisciplina.txtCodProf.Enabled = False
        FrmDisciplina.txtNomeProf.Enabled = False
        FrmDisciplina.btnConsProf.Enabled = False
        FrmDisciplina.btnLimparProf.Enabled = False
        FrmDisciplina.btnAddProf.Enabled = False
        FrmDisciplina.btnRemoveProf.Enabled = False
        FrmDisciplina.dgvDisc.Enabled = False
    End Sub

    Function Gravar() As Boolean
        If FrmDisciplina.txtDisciplina.Text = "" Or FrmDisciplina.txtDisciplina.Text = "Digite a disciplina" Then
            MessageBox.Show("Disciplina não Informada!" & vbNewLine & "DIGITE A DISCIPLINA.", "GRAVAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FrmDisciplina.txtDisciplina.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Sub limparDisc()
        FrmDisciplina.txtDisciplina.Text = "Digite a disciplina"
        FrmDisciplina.txtDisciplina.ForeColor = Color.LightSteelBlue
    End Sub
    Sub consultaDisc()
        FrmDisciplina.btnConsDisc.Enabled = True
        FrmDisciplina.txtDisciplina.Enabled = True
        FrmDisciplina.btnNovo.Enabled = True
        FrmDisciplina.btnExcluir.Enabled = True
        FrmDisciplina.btnCancelar.Enabled = True
        FrmDisciplina.btnGravar.Enabled = True
        FrmDisciplina.txtCodProf.Enabled = True
        FrmDisciplina.txtNomeProf.Enabled = False
        FrmDisciplina.btnConsProf.Enabled = True
        FrmDisciplina.btnLimparProf.Enabled = True
        If FrmDisciplina.cadastros = True Then
            FrmDisciplina.btnAddProf.Enabled = True
        Else
            FrmDisciplina.btnAddProf.Enabled = False
        End If
        FrmDisciplina.btnRemoveProf.Enabled = False
        FrmDisciplina.dgvDisc.Enabled = True
    End Sub

    Sub limparProf()
        FrmDisciplina.txtCodProf.Clear()
        FrmDisciplina.txtNomeProf.Text = "Digite o nome"
        FrmDisciplina.txtNomeProf.ForeColor = Color.LightSteelBlue
        FrmDisciplina.btnAddProf.Enabled = False
        FrmDisciplina.btnRemoveProf.Enabled = False
    End Sub

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
