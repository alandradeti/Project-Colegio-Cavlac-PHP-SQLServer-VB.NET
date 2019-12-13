Imports System.Data.SqlClient

Public Class frmRelDesemEscola

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

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

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus, cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
        End If
        BtnCarregar.PerformClick()

    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
    End Sub

    Private Sub txtAno_GotFocus(sender As Object, e As EventArgs) Handles txtAno.GotFocus
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

    Private Sub cmbBim_GotFocus(sender As Object, e As EventArgs) Handles cmbBim.GotFocus, cmbBim.DropDown
        cmbBim.ForeColor = Color.Black
    End Sub

    Private Sub cmbBim_LostFocus(sender As Object, e As EventArgs) Handles cmbBim.LostFocus
        If cmbBim.SelectedIndex = 0 Then
            cmbBim.ForeColor = Color.LightSteelBlue
        End If
    End Sub


    Public Sub Rel(Optional pAno As String = "", Optional pDiscp As String = "", Optional pBim As String = "")
        Try
            Pr_DesemEscolaTableAdapter.Fill(Me.BD_TCCDataSet.Pr_DesemEscola, pAno, pDiscp, pBim)
        Catch ex As Exception
            MsgBox(Err.ToString)
        End Try

        ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmRelDesemEscola_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_DesemEscola' table. You can move, or remove it, as needed.
        'Me.Pr_DesemEscolaTableAdapter.Fill(Me.BD_TCCDataSet.Pr_DesemEscola)
        Call disciplinas()
        cmbBim.SelectedIndex = 0
        txtAno.Text = ano
        Rel()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        If cmbDisc.SelectedIndex = 0 Then
            Rel(pAno:=txtAno.Text.ToString, pDiscp:="", pBim:=cmbBim.Text.ToString)
        Else
            Rel(pAno:=txtAno.Text.ToString, pDiscp:=cmbDisc.Text.ToString, pBim:=cmbBim.Text.ToString)
        End If
    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
    End Sub

    Private Sub cmbBim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBim.KeyPress, cmbDisc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtnCarregar.PerformClick()
        End If
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

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        cmbBim.SelectedIndex = 0
        cmbBim.ForeColor = Color.LightSteelBlue
        cmbDisc.SelectedIndex = 0
        cmbDisc.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub cmbBim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBim.SelectedIndexChanged
        BtnCarregar.PerformClick()
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class