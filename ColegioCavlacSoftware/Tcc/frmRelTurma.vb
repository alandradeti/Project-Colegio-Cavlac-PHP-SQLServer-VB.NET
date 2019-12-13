Public Class frmRelTurma

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

    Private Sub cmbPeriodo_LostFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.LostFocus
        If cmbPeriodo.SelectedIndex = 0 Then
            cmbPeriodo.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub cmbPeriodo_GotFocus(sender As Object, e As EventArgs) Handles cmbPeriodo.GotFocus, cmbPeriodo.DropDown
        cmbPeriodo.ForeColor = Color.Black
    End Sub

    Public Sub Rel(Optional pPeriodo As String = "", Optional pAno As String = "")

        Pr_TurmaTotalTableAdapter.Fill(BD_TCCDataSet.Pr_TurmaTotal, pPeriodo, pAno)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelTurma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_TurmaTotal' table. You can move, or remove it, as needed.
        'Me.Pr_TurmaTotalTableAdapter.Fill(Me.BD_TCCDataSet.Pr_TurmaTotal)
        'Me.ReportViewer1.RefreshReport()
        cmbPeriodo.SelectedIndex = 0
        txtAno.Text = ano
        Rel(pAno:=ano)
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

    Private Sub cbPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.SelectedIndexChanged
        If cmbPeriodo.SelectedIndex = 0 Then
            Rel(pPeriodo:="", pAno:=txtAno.Text.ToString)
        Else
            Rel(pPeriodo:=cmbPeriodo.Text.ToString, pAno:=txtAno.Text.ToString)
        End If

    End Sub

    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If cmbPeriodo.SelectedIndex = 0 Then
                Rel(pPeriodo:="", pAno:=txtAno.Text.ToString)
            Else
                Rel(pPeriodo:=cmbPeriodo.Text.ToString, pAno:=txtAno.Text.ToString)
            End If

        Else

        End If
    End Sub

    'Private Sub txtAno_TextChanged(sender As Object, e As EventArgs) Handles txtAno.TextChanged
    '    Rel(pPeriodo:=cbPeriodo.Text.ToString, pAno:=txtAno.Text.ToString)
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        cmbPeriodo.SelectedIndex = 0
        cmbPeriodo.ForeColor = Color.LightSteelBlue
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