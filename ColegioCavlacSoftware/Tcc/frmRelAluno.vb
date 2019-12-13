Public Class frmRelAluno

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private Sub txtAno_GotFocus(sender As Object, e As EventArgs) Handles txtAno.GotFocus
        If txtAno.Text = ano Then
            Exit Sub
        End If
        If txtAno.Text = "Digite o ano" Then
            txtAno.Text = ""
            txtAno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtAno_LostFocus(sender As Object, e As EventArgs) Handles txtAno.LostFocus
        If txtAno.Text = "" Then
            txtAno.Text = "Digite o ano"
            txtAno.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtTurma_GotFocus(sender As Object, e As EventArgs) Handles txtTurma.GotFocus
        If txtTurma.Text = "Digite a turma" Then
            txtTurma.Text = ""
            txtTurma.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtTurma_LostFocus(sender As Object, e As EventArgs) Handles txtTurma.LostFocus
        If txtTurma.Text = "" Then
            txtTurma.Text = "Digite a turma"
            txtTurma.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Public Sub Rel(Optional pAno As String = "", Optional pTurma As String = "")
        Try
            Pr_AlunoTurmaTableAdapter.Fill(BD_TCCDataSet.Pr_AlunoTurma, pAno, pTurma)
        Catch ex As Exception

        End Try

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_AlunoTurma' table. You can move, or remove it, as needed.
        'Me.Pr_AlunoTurmaTableAdapter.Fill(Me.BD_TCCDataSet.Pr_AlunoTurma)
        txtAno.Text = ano
        Rel(pAno:=ano)
        Me.ReportViewer1.RefreshReport()
        pnlTurma.Focus()
        txtTurma.Focus()
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Move.X = Me.Left - MousePosition.X
        Move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = Move.X + MousePosition.X
        Me.Top = Move.y + MousePosition.Y
    End Sub

    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If txtTurma.Text = "Digite a turma" Then
                Rel(pAno:=txtAno.Text.ToString, pTurma:="")
            Else
                Rel(pAno:=txtAno.Text.ToString, pTurma:=txtTurma.Text.ToString)
            End If
        Else

        End If
    End Sub

    Private Sub txtTurma_TextChanged(sender As Object, e As EventArgs) Handles txtTurma.TextChanged
        If txtTurma.Text = "Digite a turma" Then
            Rel(pAno:=txtAno.Text.ToString, pTurma:="")
        Else
            Rel(pAno:=txtAno.Text.ToString, pTurma:=txtTurma.Text.ToString)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        txtTurma.Text = "Digite a turma"
        txtTurma.ForeColor = Color.LightSteelBlue
        Rel(pAno:=ano)
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class