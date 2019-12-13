Public Class frmRelProf

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public Sub Rel(Optional pProfessor As String = "")

        Pr_ProfessorTableAdapter.Fill(BD_TCCDataSet.Pr_Professor, pProfessor)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub txtProfessor_GotFocus(sender As Object, e As EventArgs) Handles txtProf.GotFocus
        If txtProf.Text = "Digite o nome" Then
            txtProf.Text = ""
            txtProf.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtProfessor_LostFocus(sender As Object, e As EventArgs) Handles txtProf.LostFocus
        If txtProf.Text = "" Then
            txtProf.Text = "Digite o nome"
            txtProf.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub frmRelProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_Professor' table. You can move, or remove it, as needed.
        'Me.Pr_ProfessorTableAdapter.Fill(Me.BD_TCCDataSet.Pr_Professor)
        txtProf.Focus()
        Rel()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
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

    Private Sub txtProf_TextChanged(sender As Object, e As EventArgs) Handles txtProf.TextChanged
        Rel(pProfessor:=txtProf.Text.ToString)
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        txtProf.Text = "Digite o nome"
        txtProf.ForeColor = Color.LightSteelBlue
        Rel()
    End Sub

    Private Sub letras(sender As Object, e As KeyPressEventArgs) Handles txtProf.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class