Module NotasFuncio

    Sub load()
        Call limparAlunos()
        Call limparNotas()

        FrmNotas.txtTurma.Text = "Digite a turma"
        FrmNotas.txtTurma.ForeColor = Color.LightSteelBlue

        FrmNotas.cmbPeriodo.Items.Add("---")
        FrmNotas.cmbPeriodo.Items.Add("MANHÃ")
        FrmNotas.cmbPeriodo.Items.Add("TARDE")
        FrmNotas.cmbPeriodo.Items.Add("NOITE")

        FrmNotas.cmbPeriodo.SelectedIndex = 0
        FrmNotas.cmbPeriodo.ForeColor = Color.LightSteelBlue

    End Sub

    Sub limparTurmas()
        FrmNotas.txtTurma.Text = "Digite a turma"
        FrmNotas.txtTurma.ForeColor = Color.LightSteelBlue
        FrmNotas.cmbPeriodo.SelectedIndex = 0
        FrmNotas.cmbPeriodo.ForeColor = Color.LightSteelBlue
        FrmNotas.txtMatricula.Enabled = False
        FrmNotas.btnConsAluno.Enabled = False
        FrmNotas.btnLimparAluno.Enabled = False
    End Sub

    Sub limparAlunos()
        FrmNotas.txtNomeAluno.Text = "Digite o nome"
        FrmNotas.txtNomeAluno.ForeColor = Color.LightSteelBlue
        FrmNotas.txtMatricula.Text = ""
        FrmNotas.cmbDisc.Enabled = False
    End Sub

    Sub masterLoad()
        FrmNotas.mtbAnoTurma.Enabled = True
        FrmNotas.cmbBimestre.Enabled = True
        FrmNotas.btnOk.Enabled = True
        FrmNotas.cmbDisc.Enabled = False
        FrmNotas.txt1bim.Enabled = False
        FrmNotas.txt2bim.Enabled = False
        FrmNotas.txt3bim.Enabled = False
        FrmNotas.txt4bim.Enabled = False
        FrmNotas.mtbFaltas1bim.Enabled = False
        FrmNotas.mtbFaltas2bim.Enabled = False
        FrmNotas.mtbFaltas3bim.Enabled = False
        FrmNotas.mtbFaltas4bim.Enabled = False
        FrmNotas.btn1Bim.Enabled = True
        FrmNotas.btn2Bim.Enabled = True
        FrmNotas.btn3Bim.Enabled = True
        FrmNotas.btn4Bim.Enabled = True

        FrmNotas.btn1Bim.Text = "X"
        FrmNotas.btn2Bim.Text = "X"
        FrmNotas.btn3Bim.Text = "X"
        FrmNotas.btn4Bim.Text = "X"
    End Sub

    Sub usuBlock()
        FrmNotas.mtbAnoTurma.Enabled = False
        FrmNotas.cmbBimestre.Enabled = False
        FrmNotas.btnOk.Enabled = False
        FrmNotas.cmbDisc.Enabled = False
        FrmNotas.txt1bim.Enabled = False
        FrmNotas.txt2bim.Enabled = False
        FrmNotas.txt3bim.Enabled = False
        FrmNotas.txt4bim.Enabled = False
        FrmNotas.mtbFaltas1bim.Enabled = False
        FrmNotas.mtbFaltas2bim.Enabled = False
        FrmNotas.mtbFaltas3bim.Enabled = False
        FrmNotas.mtbFaltas4bim.Enabled = False
        FrmNotas.btn1Bim.Enabled = False
        FrmNotas.btn2Bim.Enabled = False
        FrmNotas.btn3Bim.Enabled = False
        FrmNotas.btn4Bim.Enabled = False
    End Sub

    Sub MasterBimestre()
        FrmNotas.cmbBimestre.Items.Add("---")
        FrmNotas.cmbBimestre.Items.Add("1°BIMESTRE")
        FrmNotas.cmbBimestre.Items.Add("2°BIMESTRE")
        FrmNotas.cmbBimestre.Items.Add("3°BIMESTRE")
        FrmNotas.cmbBimestre.Items.Add("4°BIMESTRE")

        FrmNotas.cmbBimestre.SelectedIndex = 0
    End Sub

    Sub limparNotas()
        FrmNotas.txt1bim.Clear()
        FrmNotas.mtbFaltas1bim.Clear()

        FrmNotas.txt2bim.Clear()
        FrmNotas.mtbFaltas2bim.Clear()

        FrmNotas.txt3bim.Clear()
        FrmNotas.mtbFaltas3bim.Clear()

        FrmNotas.txt4bim.Clear()
        FrmNotas.mtbFaltas4bim.Clear()
    End Sub

    Sub ProfLoad()
        FrmNotas.btn1Bim.Text = "OK!"
        FrmNotas.btn2Bim.Text = "OK!"
        FrmNotas.btn3Bim.Text = "OK!"
        FrmNotas.btn4Bim.Text = "OK!"
    End Sub

    Sub BlockBim()
        FrmNotas.btn1Bim.Enabled = False
        FrmNotas.btn2Bim.Enabled = False
        FrmNotas.btn3Bim.Enabled = False
        FrmNotas.btn4Bim.Enabled = False

        FrmNotas.txt1bim.Enabled = False
        FrmNotas.txt2bim.Enabled = False
        FrmNotas.txt3bim.Enabled = False
        FrmNotas.txt4bim.Enabled = False

        FrmNotas.mtbFaltas1bim.Enabled = False
        FrmNotas.mtbFaltas2bim.Enabled = False
        FrmNotas.mtbFaltas3bim.Enabled = False
        FrmNotas.mtbFaltas4bim.Enabled = False
    End Sub

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890,.", Chr(Keyascii)) = 0 Then
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


