Imports System.Data.SqlClient

Public Class frmRelDiscp

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Public Sub Rel(Optional pNome As String = "", Optional pDiscp As String = "")
        Try
            Pr_ProfDiscpTableAdapter.Fill(BD_TCCDataSet.Pr_ProfDiscp, pNome, pDiscp)
        Catch ex As Exception

        End Try

        ReportViewer1.RefreshReport()

    End Sub

    Sub disciplinas()
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0

        strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
             "FROM TB_PROFESSOR_DISCIPLINA INNER JOIN" & vbNewLine &
             "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
             "TB_PROFESSOR_DISCIPLINA_TURMA ON TB_PROFESSOR_DISCIPLINA.id_prof_discp = TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp INNER JOIN" & vbNewLine &
             "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine & _
             "GROUP BY TB_DISCP.disciplina"

        Dim cmdDiscp As New SqlClient.SqlCommand(strSql, cnn)
        Dim daDiscp As New SqlClient.SqlDataAdapter(cmdDiscp)
        Dim reader As SqlDataReader = cmdDiscp.ExecuteReader()

        While reader.Read()
            Dim disc As String
            disc = reader.GetValue(0).ToString
            cmbDisc.Items.Add(disc)
        End While
        reader.Close()
    End Sub

    Private Sub frmRelDiscp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_ProfDiscp' table. You can move, or remove it, as needed.
        'Me.Pr_ProfDiscpTableAdapter.Fill(Me.BD_TCCDataSet.Pr_ProfDiscp)
        Call disciplinas()

        Try
            'Me.Pr_ProfDiscpTableAdapter.Fill(Me.BD_TCCDataSet.Pr_ProfDiscp)
            Rel()
        Catch ex As Exception

        End Try


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus, cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
        End If
        If cmbDisc.SelectedIndex = 0 Then
            Rel()
        Else
            Rel(pDiscp:=cmbDisc.Text.ToString)
        End If

    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
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

    Private Sub Enter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDisc.KeyPress, txtProf.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Dim Prof As String
            Dim Discp As String

            If txtProf.Text = "Digite o nome" Then
                Prof = ""
            Else
                Prof = txtProf.Text
            End If

            If cmbDisc.SelectedIndex = 0 Then
                Discp = ""
            Else
                Discp = cmbDisc.Text
            End If

            Rel(pDiscp:=Discp, pNome:=Prof)
        End If
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        cmbDisc.SelectedIndex = 0
        cmbDisc.ForeColor = Color.LightSteelBlue
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