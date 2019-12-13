Imports System.Data.SqlClient

Public Class frmRelDesemTurma

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public Sub Rel(Optional pTurma As String = "", Optional pDiscp As String = "", Optional pBim As String = "", Optional PAno As String = "")
        Try
            Pr_MaiorNotaTableAdapter.Fill(BD_TCCDataSet.Pr_MaiorNota, pTurma, pDiscp, pBim, PAno)
        Catch ex As Exception

        End Try

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_MaiorNota' table. You can move, or remove it, as needed.
        'Me.Pr_MaiorNotaTableAdapter.Fill(Me.BD_TCCDataSet.Pr_MaiorNota)
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        txtAno.Text = ano
        cmbBim.SelectedIndex = 0
        Rel()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub disciplinas()
        Dim idTurma As String
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        strSql = "select id_turma from TB_TURMA where ano = @ano and turma = @turma"
        Dim cmdTurma As New SqlClient.SqlCommand(strSql, cnn)
        cmdTurma.Parameters.AddWithValue("@ano", ano.ToString)
        cmdTurma.Parameters.AddWithValue("@turma", txtTurma.Text.ToString)

        idTurma = cmdTurma.ExecuteScalar()
        If idTurma = "" Then
            idTurma = 0
        End If

        strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
             "FROM TB_PROFESSOR_DISCIPLINA INNER JOIN" & vbNewLine &
             "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
             "TB_PROFESSOR_DISCIPLINA_TURMA ON TB_PROFESSOR_DISCIPLINA.id_prof_discp = TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp INNER JOIN" & vbNewLine &
             "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
             "WHERE (TB_PROFESSOR_DISCIPLINA_TURMA.id_turma = @idTurma)"

        Dim cmdDiscp As New SqlClient.SqlCommand(strSql, cnn)
        Dim daDiscp As New SqlClient.SqlDataAdapter(cmdDiscp)
        cmdDiscp.Parameters.AddWithValue("@idTurma", idTurma.ToString)

        Dim reader As SqlDataReader = cmdDiscp.ExecuteReader()

        While reader.Read()
            Dim disc As String
            disc = reader.GetValue(0).ToString
            cmbDisc.Items.Add(disc)
        End While
        reader.Close()
    End Sub

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus, cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
        End If
        BtnCarregar.PerformClick()

    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
    End Sub

    Private Sub txtTurma_GotFocus(sender As Object, e As EventArgs) Handles txtTurma.GotFocus
        If txtTurma.Text = "Digite a turma" Then
            txtTurma.Text = ""
            txtTurma.ForeColor = Color.Black
        End If
    End Sub

    Private Sub cmbBim_GotFocus(sender As Object, e As EventArgs) Handles cmbBim.GotFocus, cmbBim.DropDown
        cmbBim.ForeColor = Color.Black
    End Sub

    Private Sub cmbBim_LostFocus(sender As Object, e As EventArgs) Handles cmbBim.LostFocus
        If cmbBim.SelectedIndex = 0 Then
            cmbBim.ForeColor = Color.LightSteelBlue
            cmbDisc.SelectedIndex = 0
            cmbDisc.Enabled = False
        Else
            Call disciplinas()
            cmbDisc.Enabled = True
        End If
    End Sub

    Private Sub cmbBim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBim.KeyPress, cmbDisc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtnCarregar.PerformClick()
            Call disciplinas()
            cmbDisc.Enabled = True
        End If
    End Sub

    Private Sub cmbBim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBim.SelectedIndexChanged
        BtnCarregar.PerformClick()
        Call disciplinas()
        cmbDisc.Enabled = True
    End Sub

    Private Sub txtTurma_LostFocus(sender As Object, e As EventArgs) Handles txtTurma.LostFocus
        If txtTurma.Text = "" Then
            txtTurma.Text = "Digite a turma"
            txtTurma.ForeColor = Color.LightSteelBlue
            cmbDisc.SelectedIndex = 0
            cmbDisc.Enabled = False
        End If
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        If cmbDisc.SelectedIndex = 0 Then
            Rel(pTurma:=txtTurma.Text.ToString, pDiscp:="", pBim:=cmbBim.Text.ToString, PAno:=txtAno.Text.ToString)
        Else
            Rel(pTurma:=txtTurma.Text.ToString, pDiscp:=cmbDisc.Text.ToString, pBim:=cmbBim.Text.ToString, PAno:=txtAno.Text.ToString)
        End If

    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
    End Sub

    Private Sub txtTurma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTurma.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            cmbBim.Focus()
        End If
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

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        txtTurma.Text = "Digite a turma"
        txtTurma.ForeColor = Color.LightSteelBlue
        cmbBim.SelectedIndex = 0
        cmbBim.ForeColor = Color.LightSteelBlue
        cmbDisc.Enabled = False
        cmbDisc.SelectedIndex = 0
        cmbDisc.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class