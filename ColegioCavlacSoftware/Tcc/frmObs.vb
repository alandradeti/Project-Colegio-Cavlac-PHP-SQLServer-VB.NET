Public Class frmObs
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Public strAcao As String = "incluir"
    Public idObs As Integer = 0
    Public idAluno As Integer
    Dim move As MoveForm

    Private limite As Integer = 300

    Private Sub mtbData_GotFocus(sender As Object, e As EventArgs) Handles mtbData.GotFocus, mtbData.Click
        mtbData.ForeColor = Color.Black
        If Val(mtbData.Text) = 0 Then
            mtbData.SelectionStart = 0
        End If
    End Sub

    Private Sub mtbData_LostFocus(sender As Object, e As EventArgs) Handles mtbData.LostFocus
        If Val(mtbData.Text) = 0 Then
            mtbData.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Private Sub preencherObs()
        Dim drObs As SqlClient.SqlDataReader
        Dim cmdObs As New SqlClient.SqlCommand
        strSql = "select data, notificacao from tb_notificacoes where id_noti = @id"

        cmdObs.Connection = cnn
        cmdObs.CommandText = strSql
        cmdObs.Parameters.AddWithValue("@id", idObs.ToString)
        Try
            drObs = cmdObs.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmdObs.Parameters.Clear()
            Exit Sub
        End Try
        drObs.Read()
        mtbData.Text = drObs("data").ToString
        txtNotificacao.Text = drObs("notificacao").ToString
        drObs.Close()
    End Sub

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub frmObs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idAluno = AlunoObs.idAluno
        lblAno.Text = ano
        txtNotificacao.Clear()
        mtbData.Text = ""
        txtNotificacao.MaxLength = 300
        If idObs <> 0 Then
            Call preencherObs()
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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim data As String = mtbData.Text + lblAno.Text
        If Not IsDate(data) Then
            MessageBox.Show("Data é um Campo Obrigatório." & vbNewLine & "DIGITE A DATA!", "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mtbData.Focus()
            Exit Sub
        End If
        If txtNotificacao.Text = "" Then
            MessageBox.Show("Notificação é um Campo Obrigatório." & vbNewLine & "DIGITE A NOTIFICAÇÃO!", "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNotificacao.Focus()
            Exit Sub
        End If
        If strAcao = "incluir" Then
            If MessageBox.Show("A DATA ESTÁ MESMO CORRETA ?" & vbNewLine & Data, "NOTIFICAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                Exit Sub
            End If
            mtbData.Focus()
            strSql = "INSERT INTO TB_NOTIFICACOES values(@idAluno, @noti, @idProf, @data)"
            Dim cmdNoti As New SqlClient.SqlCommand(strSql, cnn)
            cmdNoti.Parameters.AddWithValue("@idAluno", idAluno.ToString)
            cmdNoti.Parameters.AddWithValue("@noti", txtNotificacao.Text.ToString)
            cmdNoti.Parameters.AddWithValue("@idProf", id.ToString)
            cmdNoti.Parameters.AddWithValue("@data", Data)
            Try
                cmdNoti.ExecuteNonQuery()
                Call AlunoObs.preencherGridObs()
                MessageBox.Show("NOTIFICAÇÃO REGISTRADA COM SUCESSO!", "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdNoti.Parameters.Clear()
        Else
            strSql = "UPDATE TB_NOTIFICACOES SET notificacao = @noti WHERE id_noti = @id"
            Dim cmdNoti As New SqlClient.SqlCommand(strSql, cnn)
            cmdNoti.Parameters.AddWithValue("@noti", txtNotificacao.Text.ToString)
            cmdNoti.Parameters.AddWithValue("@id", idObs.ToString)
            Try
                cmdNoti.ExecuteNonQuery()
                Call AlunoObs.preencherGridObs()
                MessageBox.Show("NOTIFICAÇÃO ALTERADA COM SUCESSO!", "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("ERRO: " & vbNewLine & Err.Description, "NOTIFICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            cmdNoti.Parameters.Clear()
        End If
    End Sub
End Class