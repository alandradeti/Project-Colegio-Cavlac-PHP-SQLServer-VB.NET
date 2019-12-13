Imports System.Data.SqlClient

Public Class frmRelBoletim

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Private click As Integer = 1
    Private RA As String = 0

    Sub consAluno()
        Dim objConsAluno As New frmConsAluno
        objConsAluno.ShowDialog()
        If objConsAluno.confirm = True Then
            txtRA.Text = objConsAluno.GetcolIDAluno().ToString
            txtNome.Text = objConsAluno.GetcolNomeAluno().ToString
            RA = txtRA.Text
            If Val(txtRA.Text) = 0 Then
                Rel(pRA:=0)
            Else
                Rel(pRA:=txtRA.Text, pAno:=txtAno.Text.ToString)
            End If
        Else
        End If
    End Sub

    Public Sub Rel(Optional pRA As Integer = 0, Optional pAno As String = "")
        Try
            Pr_BoletimTableAdapter.Fill(BD_TCCDataSet.Pr_Boletim, pRA, pAno)
        Catch ex As Exception

        End Try

        ReportViewer1.RefreshReport()

    End Sub

    Dim move As MoveForm

    Private Sub txtAno_GotFocus(sender As Object, e As EventArgs) Handles txtAno.GotFocus
        If txtAno.Text = "Digite o ano" Then
            txtAno.Text = ""
            txtAno.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRA_GotFocus(sender As Object, e As EventArgs) Handles txtRA.GotFocus
        If txtRA.Text = "Digite o RA" Then
            txtRA.Text = ""
            txtRA.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtRA_LostFocus(sender As Object, e As EventArgs) Handles txtRA.LostFocus
        If txtRA.Text = "" Then
            txtRA.Text = "Digite o RA"
            txtRA.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtAno_LostFocus(sender As Object, e As EventArgs) Handles txtAno.LostFocus
        If txtAno.Text = "" Then
            txtAno.Text = "Digite o ano"
            txtAno.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub frmRelBoletim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_Boletim' table. You can move, or remove it, as needed.
        'Me.Pr_BoletimTableAdapter.Fill(Me.BD_TCCDataSet.Pr_Boletim)
        'Me.ReportViewer1.RefreshReport()

        txtAno.Text = ano
        txtRA.Text = ""

        Rel()
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

    'Private Sub txtAno_TextChanged(sender As Object, e As EventArgs) Handles txtAno.TextChanged
    '    Rel(pAno:=txtAno.Text.ToString)
    'End Sub

    Private Sub txtRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRA.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            btnConsAluno.PerformClick()
            If Val(txtRA.Text) = 0 Then
                Rel(pRA:=0)
            Else
                Rel(pRA:=txtRA.Text, pAno:=txtAno.Text.ToString)
            End If
        Else

        End If
    End Sub

    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If Val(txtRA.Text) = 0 Then
                Rel(pRA:=0)
            Else
                Rel(pRA:=txtRA.Text, pAno:=txtAno.Text.ToString)
            End If
        Else

        End If
    End Sub

    Private Sub txtRA_TextChanged(sender As Object, e As EventArgs) Handles txtRA.TextChanged
        If txtRA.Text = RA Then
            click = 2
        ElseIf txtRA.Text = "" Then
            RA = 0
            click = 1
        Else
            click = 1
        End If
    End Sub

    Private Sub btnConsAluno_Click(sender As Object, e As EventArgs) Handles btnConsAluno.Click
        If click = 2 Or txtRA.Text = "" Or txtRA.Text = RA Then
            Call consAluno()
        Else
            strSql = "select nome_aluno from TB_ALUNO where id_matricula = @id"

            Dim cmbAluno As New SqlClient.SqlCommand(strSql, cnn)
            Dim daAluno As New SqlClient.SqlDataAdapter(cmbAluno)
            cmbAluno.Parameters.AddWithValue("@id", txtRA.Text.ToString)
            Dim readerAluno As SqlDataReader = cmbAluno.ExecuteReader()
            If readerAluno.HasRows = True Then
                readerAluno.Read()
                txtNome.Text = readerAluno.GetValue(0).ToString
                RA = txtRA.Text
                readerAluno.Close()
            Else
                readerAluno.Close()
                Call consAluno()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        txtRA.Text = "Digite o RA"
        txtRA.ForeColor = Color.LightSteelBlue
        txtNome.Text = "Digite o nome"
        Rel()
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtRA.KeyPress, txtAno.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class