Imports System.Data.SqlClient

Public Class frmRelObs

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private click As Integer = 1
    Private RA As String = 0

    Sub consAluno()
        Dim objConsAluno As New frmConsAluno
        objConsAluno.ShowDialog()
        If objConsAluno.confirm = True Then
            txtRA.Text = objConsAluno.GetcolIDAluno().ToString
            txtNome.Text = objConsAluno.GetcolNomeAluno().ToString
            RA = txtRA.Text
            Dim dataF As String
            Dim dataI As String
            If Not IsDate(txtDataF.Text) Then
                dataF = ""
            Else
                dataF = txtDataF.Text
            End If
            If Not IsDate(txtDataI.Text) Then
                dataI = ""
            Else
                dataI = txtDataI.Text
            End If
            Rel(pRA:=txtRA.Text, pDataI:=dataI, pDataF:=dataF)
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

    Private Sub txtDataF_GotFocus(sender As Object, e As EventArgs) Handles txtDataF.GotFocus, txtDataF.Click
        txtDataF.ForeColor = Color.Black
        If Val(txtDataF.Text) = 0 Then
            txtDataF.SelectionStart = 0
        End If
    End Sub

    Private Sub txtDataF_LostFocus(sender As Object, e As EventArgs) Handles txtDataF.LostFocus
        If Val(txtDataF.Text) = 0 Then
            txtDataF.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub txtDataI_GotFocus(sender As Object, e As EventArgs) Handles txtDataI.GotFocus, txtDataI.Click
        txtDataI.ForeColor = Color.Black
        If Val(txtDataI.Text) = 0 Then
            txtDataI.SelectionStart = 0
        End If
    End Sub

    Private Sub txtDataI_LostFocus(sender As Object, e As EventArgs) Handles txtDataI.LostFocus
        If Val(txtDataI.Text) = 0 Then
            txtDataI.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Public Sub Rel(Optional pRA As Integer = 0, Optional pDataI As String = "", Optional pDataF As String = "")

        Pr_ObsTableAdapter.Fill(BD_TCCDataSet.Pr_Obs, pRA, pDataI, pDataF)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub frmRelObs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BD_TCCDataSet.Pr_Obs' table. You can move, or remove it, as needed.
        'Me.Pr_ObsTableAdapter.Fill(Me.BD_TCCDataSet.Pr_Obs)
        'Me.ReportViewer1.RefreshReport()

        txtRA.Text = ""
        txtDataF.Text = ""
        txtDataI.Text = ""
        txtRA.Focus()

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

    Private Sub txtRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRA.KeyPress
        Dim dataF As String
        Dim dataI As String
        If e.KeyChar = Convert.ToChar(13) Then
            btnConsAluno.PerformClick()
            If Not IsDate(txtDataF.Text) Then
                dataF = ""
            Else
                dataF = txtDataF.Text
            End If
            If Not IsDate(txtDataI.Text) Then
                dataI = ""
            Else
                dataI = txtDataI.Text
            End If
            Rel(pRA:=txtRA.Text, pDataI:=dataI, pDataF:=dataF)
        End If
    End Sub

    Private Sub txtDataI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataI.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            txtDataF.Focus()
        Else

        End If
    End Sub

    Private Sub txtDataF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataF.KeyPress
        Dim dataF As String
        Dim dataI As String
        If Not IsDate(txtDataF.Text) Then
            dataF = ""
        Else
            dataF = txtDataF.Text
        End If
        If Not IsDate(txtDataI.Text) Then
            dataI = ""
        Else
            dataI = txtDataI.Text
        End If
        If e.KeyChar = Convert.ToChar(13) Then
            If Val(txtRA.Text) > 0 Then
                Rel(pRA:=txtRA.Text, pDataI:=dataI, pDataF:=dataF)
            End If
        Else

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

    Private Sub btnLimparTurma_Click(sender As Object, e As EventArgs) Handles btnLimparTurma.Click
        txtRA.Text = "Digite o RA"
        txtRA.ForeColor = Color.LightSteelBlue
        txtNome.Text = "Digite o nome"
        txtDataI.Text = ""
        txtDataI.ForeColor = Color.LightSteelBlue
        txtDataF.Text = ""
        txtDataF.ForeColor = Color.LightSteelBlue
        Rel()
    End Sub

    Private Sub numeros(sender As Object, e As KeyPressEventArgs) Handles txtRA.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(CadatrosFuncio.SoNumeros(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class