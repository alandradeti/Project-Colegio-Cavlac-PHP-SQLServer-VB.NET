Imports System.Data.SqlClient

Public Class frmRelDesemProf

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private click As Integer = 1
    Private COD As String = 0

    Sub consProf()
        Dim objConsProf As New FrmConsProf
        objConsProf.ShowDialog()
        If objConsProf.confirm = True Then
            txtCodigo.Text = objConsProf.GetcolIDprof().ToString
            txtNome.Text = objConsProf.GetcolNomeprof().ToString
            COD = txtCodigo.Text
            cmbBim.Focus()
            Call disciplinas()
            cmbDisc.Enabled = True
        Else
            cmbDisc.SelectedIndex = 0
            cmbDisc.Enabled = False
        End If
    End Sub

    Sub disciplinas()
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0

        strSql = "SELECT TB_DISCP.disciplina" & vbNewLine &
                 "FROM TB_PROFESSOR_DISCIPLINA INNER JOIN" & vbNewLine &
                 "TB_USUARIO ON TB_PROFESSOR_DISCIPLINA.id_usuario = TB_USUARIO.id_usuario INNER JOIN" & vbNewLine &
                 "TB_PROFESSOR_DISCIPLINA_TURMA ON TB_PROFESSOR_DISCIPLINA.id_prof_discp = TB_PROFESSOR_DISCIPLINA_TURMA.id_prof_discp INNER JOIN" & vbNewLine &
                 "TB_DISCP ON TB_PROFESSOR_DISCIPLINA.id_discp = TB_DISCP.id_discp" & vbNewLine &
                 "WHERE (TB_PROFESSOR_DISCIPLINA.id_usuario = @id)" & vbNewLine & _
                 "GROUP BY TB_DISCP.disciplina"

        Dim cmdDiscp As New SqlClient.SqlCommand(strSql, cnn)
        cmdDiscp.Parameters.AddWithValue("@id", COD.ToString)
        Dim daDiscp As New SqlClient.SqlDataAdapter(cmdDiscp)
        Dim reader As SqlDataReader = cmdDiscp.ExecuteReader()

        While reader.Read()
            Dim disc As String
            disc = reader.GetValue(0).ToString
            cmbDisc.Items.Add(disc)
        End While
        reader.Close()
    End Sub

    Private Sub txtCodigo_GotFocus(sender As Object, e As EventArgs) Handles txtCodigo.GotFocus
        If txtCodigo.Text = "Digite o Código" Then
            txtCodigo.Text = ""
            txtCodigo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        If txtCodigo.Text = "" Then
            txtCodigo.Text = "Digite o Código"
            txtCodigo.ForeColor = Color.LightSteelBlue
        End If
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

    Private Sub cmbDisc_LostFocus(sender As Object, e As EventArgs) Handles cmbDisc.LostFocus, cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedIndex = 0 Then
            cmbDisc.ForeColor = Color.LightSteelBlue
        End If
        BtnCarregar.PerformClick()

    End Sub

    Private Sub cmbDisc_GotFocus(sender As Object, e As EventArgs) Handles cmbDisc.GotFocus, cmbDisc.DropDown
        cmbDisc.ForeColor = Color.Black
    End Sub

    Private Sub cmbBim_GotFocus(sender As Object, e As EventArgs) Handles cmbBim.GotFocus, cmbBim.DropDown
        cmbBim.ForeColor = Color.Black
    End Sub

    Private Sub cmbBim_LostFocus(sender As Object, e As EventArgs) Handles cmbBim.LostFocus
        If cmbBim.SelectedIndex = 0 Then
            cmbBim.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Public Sub Rel(Optional pAno As String = "", Optional pCodigo As Integer = 0, Optional pBim As String = "", Optional pDiscp As String = "")
        Try
            Pr_DesemProfTableAdapter.Fill(BD_TCCDataSet.Pr_DesemProf, pAno, pCodigo, pBim, pDiscp)
        Catch ex As Exception

        End Try

        ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelDesemProf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_DesemProf' table. You can move, or remove it, as needed.
        'Me.Pr_DesemProfTableAdapter.Fill(Me.BD_TCCDataSet.Pr_DesemProf)
        cmbDisc.Items.Add("---")
        cmbDisc.SelectedIndex = 0
        txtAno.Text = ano
        cmbBim.SelectedIndex = 0
        Rel()
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Dim CodProf As Integer
        If txtCodigo.Text = "Digite o Código" Or txtCodigo.Text = "" Then
            CodProf = 0
        Else
            CodProf = COD
        End If
        If cmbDisc.SelectedIndex = 0 Then
            Rel(pAno:=txtAno.Text.ToString, pCodigo:=CodProf, pBim:=cmbBim.Text.ToString, pDiscp:="")
        Else
            Rel(pAno:=txtAno.Text.ToString, pCodigo:=CodProf, pBim:=cmbBim.Text.ToString, pDiscp:=cmbDisc.Text.ToString)
        End If

    End Sub

    Private Sub ptbfechar_Click(sender As Object, e As EventArgs) Handles ptbfechar.Click
        Me.Close()
    End Sub

    Private Sub ptbminimizar_Click(sender As Object, e As EventArgs) Handles ptbminimizar.Click
        Me.WindowState = 1
    End Sub

    Private Sub btnConsAluno_Click(sender As Object, e As EventArgs) Handles btnConsProf.Click
        If click = 2 Or txtCodigo.Text = "" Or txtCodigo.Text = COD Then
            Call consProf()
        Else
            strSql = "select nome_usuario from TB_USUARIO where id_usuario = @id and tipo_usuario = 'PROFESSOR'"

            Dim cmdProf As New SqlClient.SqlCommand(strSql, cnn)
            Dim daProf As New SqlClient.SqlDataAdapter(cmdProf)
            cmdProf.Parameters.AddWithValue("@id", txtCodigo.Text.ToString)
            Dim readerAluno As SqlDataReader = cmdProf.ExecuteReader()
            If readerAluno.HasRows = True Then
                readerAluno.Read()
                txtNome.Text = readerAluno.GetValue(0).ToString
                COD = txtCodigo.Text
                readerAluno.Close()
                cmbBim.Focus()
                Call disciplinas()
                cmbDisc.Enabled = True
            Else
                readerAluno.Close()
                Call consProf()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If txtCodigo.Text = COD Then
            click = 2
        ElseIf txtCodigo.Text = "" Then
            COD = 0
            click = 1
        Else
            click = 1
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            btnConsProf.PerformClick()
        End If
    End Sub

    Private Sub Carregar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBim.KeyPress, cmbDisc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtnCarregar.PerformClick()
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
        txtCodigo.Text = "Digite o Código"
        txtCodigo.ForeColor = Color.LightSteelBlue
        txtNome.Text = "Digite o nome"
        cmbDisc.Enabled = False
        cmbDisc.SelectedIndex = 0
        cmbDisc.ForeColor = Color.LightSteelBlue
        cmbBim.SelectedIndex = 0
        cmbBim.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub cmbBim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBim.SelectedIndexChanged
        BtnCarregar.PerformClick()
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress, txtCodigo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class