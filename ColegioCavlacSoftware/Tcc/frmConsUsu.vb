Public Class frmConsUsu

    Public filtrar As Boolean = False
    Private consultar As Boolean = False
    Public Property confirm As Boolean

    Private Sub txtNome_GotFocus(sender As Object, e As EventArgs) Handles txtNome.GotFocus
        If txtNome.Text = "Digite o nome" Then
            txtNome.Text = ""
            txtNome.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtnome_LostFocus(sender As Object, e As EventArgs) Handles txtNome.LostFocus
        If txtNome.Text = "" Then
            txtNome.Text = "Digite o nome"
            txtNome.ForeColor = Color.LightSteelBlue
        End If
    End Sub

    Public Property GetcolIDUsu As Integer
        Get
            GetcolIDUsu = dgvUsu.CurrentRow.Cells("colIDUsu").Value
        End Get
        Set(Value As Integer)

        End Set
    End Property

    Public Property GetcolNomeUsu As String
        Get
            GetcolNomeUsu = dgvUsu.CurrentRow.Cells("colNomeUsu").Value
        End Get
        Set(Value As String)

        End Set
    End Property

    Sub preencherGridUsu()
        Dim cmdUsu As New SqlClient.SqlCommand(strSql, cnn)
        If filtrar = True Then
            strSql = "Select * from tb_usuario where tipo_usuario = 'USUARIO' and nome_usuario = @nome and dt_nasc = @dt_nasc"
            cmdUsu = New SqlClient.SqlCommand(strSql, cnn)
            cmdUsu.Parameters.AddWithValue("@nome", Home.cadastros.txtNome.Text.ToString)
            cmdUsu.Parameters.AddWithValue("@dt_nasc", Home.cadastros.mtbDtNasc.Text.ToString)
            filtrar = False
        Else
            If consultar = True Then
                strSql = "Select * From TB_USUARIO WHERE nome_usuario like '%'+@nome+'%' ORDER BY nome_usuario"
                cmdUsu = New SqlClient.SqlCommand(strSql, cnn)
                cmdUsu.Parameters.AddWithValue("@nome", txtNome.Text.ToString)
                consultar = False
            ElseIf txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
                strSql = "Select * From TB_USUARIO WHERE tipo_usuario = 'USUARIO' ORDER BY nome_usuario"
                cmdUsu = New SqlClient.SqlCommand(strSql, cnn)
            End If
        End If
        Dim daUsu As New SqlClient.SqlDataAdapter(cmdUsu)
        Dim tblUsu As New DataTable
        daUsu.Fill(tblUsu)

        dgvUsu.DataSource = tblUsu
    End Sub

    Private Sub frmConsUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call preencherGridUsu()
    End Sub

    Private Sub ptbFechar_Click(sender As Object, e As EventArgs) Handles ptbFechar.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.confirm = True
        Me.Hide()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Call limpar()
    End Sub

    Sub limpar()
        txtNome.Text = "Digite o nome"
        txtNome.ForeColor = Color.LightSteelBlue
    End Sub

    Private Sub dgvUsu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsu.CellClick
        txtNome.Text = dgvUsu.CurrentRow.Cells("colNomeUsu").Value
        txtNome.ForeColor = Color.Black
    End Sub

    Private Sub btnCons_Click(sender As Object, e As EventArgs) Handles btnCons.Click
        If txtNome.Text = "Digite o nome" Or txtNome.Text = "" Then
            consultar = False
        Else
            consultar = True
        End If
        Call preencherGridUsu()
    End Sub

    Private Sub letras(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoLETRAS(KeyAscii))

        If KeyAscii = 0 Then

            e.Handled = True

        End If
    End Sub
End Class