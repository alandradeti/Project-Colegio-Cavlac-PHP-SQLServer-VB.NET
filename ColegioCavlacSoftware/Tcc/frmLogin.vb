Imports System.Data.SqlClient

Public Class frmLogin

    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure

    Dim move As MoveForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim objBanco As New conn
        Dim strMensagem As String = ""

        cnn = objBanco.AbrirConexao("", strMensagem)

        If cnn.State = ConnectionState.Closed Then
            MessageBox.Show("ERRO: " & vbNewLine & strMensagem, "BANCO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If

        strSql = "select * from TB_USUARIO where login = @login and senha_usuario = @senha"
        Dim cmdLogin As New SqlClient.SqlCommand(strSql, cnn)
        cmdLogin.Parameters.AddWithValue("@login", txtLogin.Text)
        cmdLogin.Parameters.AddWithValue("@senha", txtSenha.Text)
        Dim daLogin As New SqlClient.SqlDataAdapter(cmdLogin)
        Dim readerLogin As SqlDataReader
        readerLogin = cmdLogin.ExecuteReader()

        If Not readerLogin.HasRows Then
            MessageBox.Show("LOGIN OU SENHA INVÁLIDOS!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmdLogin = Nothing
            Exit Sub
        Else

            readerLogin.Read()
            id = readerLogin("id_usuario").ToString
            TipoUsu = readerLogin("tipo_usuario").ToString

            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        move.X = Me.Left - MousePosition.X
        move.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = move.X + MousePosition.X
        Me.Top = move.y + MousePosition.Y
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
