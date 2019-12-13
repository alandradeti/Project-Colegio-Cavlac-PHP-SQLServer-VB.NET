Public Class Home
    Public cadastros As Cadastros = New Cadastros

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TipoUsu = "PROFESSOR" Then
            TSMIAlunos.Enabled = True
            TSMINotas.Enabled = True
        ElseIf TipoUsu = "USUARIO" Then
            TSMICadastros.Enabled = True
            TSMIREL.Enabled = True
        Else
            TSMICadastros.Enabled = True
            TSMINotas.Enabled = True
            TSMIREL.Enabled = True
        End If
        MnsPrincipal.RenderMode = ToolStripRenderMode.Professional
        MnsPrincipal.Renderer = New ToolStripProfessionalRenderer(New CoresStrip())

        Dim objBanco As New conn
        Dim strMensagem As String = ""

        cnn = objBanco.AbrirConexao("", strMensagem)
        Call MasterAno()
        If cnn.State = ConnectionState.Closed Then
            MessageBox.Show("ERRO: " & vbNewLine & strMensagem, "BANCO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If

        'Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        ''Passamos para o Formulário o Tamanho em que ele será exibido
        'Me.Size = New System.Drawing.Size(intX, intY)


    End Sub

    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSMIUsuarios.Click
        frmTel.ShowDialog()
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        frmLogin.txtLogin.Clear()
        frmLogin.txtSenha.Clear()
        frmLogin.Show()
        frmLogin.txtLogin.Focus()
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
    End Sub

    Private Sub TSMIAlunos_Click(sender As Object, e As EventArgs) Handles TSMIAlunosCadastros.Click
        cadastros = New Cadastros
        cadastros.hm = "aluno"
        cadastros.ShowDialog()
    End Sub

    Private Sub TSMIProfessores_Click(sender As Object, e As EventArgs) Handles TSMIProfessores.Click
        cadastros = New Cadastros
        cadastros.hm = "professor"
        cadastros.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        cadastros = New Cadastros
        cadastros.hm = "usuario"
        cadastros.ShowDialog()
    End Sub

    Private Sub TSMITurmas_Click(sender As Object, e As EventArgs) Handles TSMITurmas.Click
        CadastrarTurma.ShowDialog()
    End Sub

    Private Sub TSMIObs_Click(sender As Object, e As EventArgs) Handles TSMIObs.Click
        AlunoObs.ShowDialog()
    End Sub

    Private Sub TSMIDisciplinas_Click(sender As Object, e As EventArgs) Handles TSMIDisciplinas.Click
        FrmDisciplina.ShowDialog()
    End Sub

    Private Sub PnlMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub PnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PnlMenu.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub

    Private Sub TSMINotas_Click(sender As Object, e As EventArgs) Handles TSMINotas.Click
        FrmNotas.ShowDialog()
    End Sub

    Private Sub TSMIRelTurma_Click(sender As Object, e As EventArgs) Handles TSMIRelTurma.Click
        Dim objRelTurma As frmRelTurma
        objRelTurma = New frmRelTurma
        objRelTurma.ShowDialog()
    End Sub

    Private Sub TSMIRelAluno_Click(sender As Object, e As EventArgs) Handles TSMIRelAluno.Click
        Dim objRelAluno As frmRelAluno
        objRelAluno = New frmRelAluno
        objRelAluno.ShowDialog()
    End Sub

    Private Sub TSMIRelProf_Click(sender As Object, e As EventArgs) Handles TSMIRelProf.Click
        Dim objRelProf As frmRelProf
        objRelProf = New frmRelProf
        objRelProf.ShowDialog()
    End Sub

    Private Sub DisciplinasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinasToolStripMenuItem.Click
        Dim objRelDiscp As frmRelDiscp
        objRelDiscp = New frmRelDiscp
        objRelDiscp.ShowDialog()
    End Sub

    Private Sub TSMIRelBoletim_Click(sender As Object, e As EventArgs) Handles TSMIRelBoletim.Click
        Dim objRelBoletim As frmRelBoletim
        objRelBoletim = New frmRelBoletim
        objRelBoletim.ShowDialog()
    End Sub

    Private Sub TSMIRelObs_Click(sender As Object, e As EventArgs) Handles TSMIRelObs.Click
        Dim objRelObs As frmRelObs
        objRelObs = New frmRelObs
        objRelObs.ShowDialog()
    End Sub

    Private Sub TSMIRelDesemTurma_Click(sender As Object, e As EventArgs) Handles TSMIRelDesemTurma.Click
        Dim objRelDesemTurma As frmRelDesemTurma
        objRelDesemTurma = New frmRelDesemTurma
        objRelDesemTurma.ShowDialog()
    End Sub

    Private Sub TSMIRelDesemEscola_Click(sender As Object, e As EventArgs) Handles TSMIRelDesemEscola.Click
        Dim objRelDesemEscola As frmRelDesemEscola
        objRelDesemEscola = New frmRelDesemEscola
        objRelDesemEscola.ShowDialog()
    End Sub

    Private Sub TSMIRelDesemAluno_Click(sender As Object, e As EventArgs) Handles TSMIRelDesemAluno.Click
        Dim objRelDesemAluno As frmRelDesemAluno
        objRelDesemAluno = New frmRelDesemAluno
        objRelDesemAluno.ShowDialog()
    End Sub

    Private Sub TSMIRelDesemProf_Click(sender As Object, e As EventArgs) Handles TSMIRelDesemProf.Click
        Dim objRelDesemProf As frmRelDesemProf
        objRelDesemProf = New frmRelDesemProf
        objRelDesemProf.ShowDialog()
    End Sub

End Class
