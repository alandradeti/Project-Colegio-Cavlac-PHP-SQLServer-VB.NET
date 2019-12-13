<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CadastrarTurma
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastrarTurma))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.btnConsTurma = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.mtbAnoTurma = New System.Windows.Forms.MaskedTextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtTurma = New System.Windows.Forms.TextBox()
        Me.dgvTurma = New System.Windows.Forms.DataGridView()
        Me.colIDTurma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTurma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabAlunProf = New System.Windows.Forms.TabControl()
        Me.tbpAluno = New System.Windows.Forms.TabPage()
        Me.btnRemoveAluno = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.btnConsAluno = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.btnAddAluno = New System.Windows.Forms.Button()
        Me.btnLimparAluno = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvAluno = New System.Windows.Forms.DataGridView()
        Me.colAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbpProfessor = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.cmbDisc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvProf = New System.Windows.Forms.DataGridView()
        Me.colProfessor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDProfDiscp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtNomeProf = New System.Windows.Forms.TextBox()
        Me.btnConsProf = New System.Windows.Forms.Button()
        Me.btnLimparProf = New System.Windows.Forms.Button()
        Me.btnRemoveProf = New System.Windows.Forms.Button()
        Me.btnAddProf = New System.Windows.Forms.Button()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.ToolTurmas = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvTurma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAlunProf.SuspendLayout()
        Me.tbpAluno.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpProfessor.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.btnGravar)
        Me.Panel1.Controls.Add(Me.btnLimparTurma)
        Me.Panel1.Controls.Add(Me.btnConsTurma)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.dgvTurma)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tabAlunProf)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 692)
        Me.Panel1.TabIndex = 0
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnExcluir.FlatAppearance.BorderSize = 2
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnExcluir.Image = Global.Tcc.My.Resources.Resources.notepad__1_
        Me.btnExcluir.Location = New System.Drawing.Point(122, 90)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 96)
        Me.btnExcluir.TabIndex = 78
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnExcluir, "Clique para excluir turma.")
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCancelar.Image = Global.Tcc.My.Resources.Resources.notepad__2_
        Me.btnCancelar.Location = New System.Drawing.Point(215, 90)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 96)
        Me.btnCancelar.TabIndex = 79
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnCancelar, "Clique para cancelar operação.")
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNovo.FlatAppearance.BorderSize = 2
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNovo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnNovo.Image = Global.Tcc.My.Resources.Resources.notepad
        Me.btnNovo.Location = New System.Drawing.Point(29, 90)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(87, 96)
        Me.btnNovo.TabIndex = 77
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnNovo, "Clique para adicionar nova turma.")
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnGravar
        '
        Me.btnGravar.BackColor = System.Drawing.Color.Transparent
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGravar.FlatAppearance.BorderSize = 2
        Me.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGravar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGravar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnGravar.Image = Global.Tcc.My.Resources.Resources.notepad__3_
        Me.btnGravar.Location = New System.Drawing.Point(308, 90)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(87, 96)
        Me.btnGravar.TabIndex = 80
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnGravar, "Clique para gravar operação.")
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'btnLimparTurma
        '
        Me.btnLimparTurma.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparTurma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimparTurma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparTurma.FlatAppearance.BorderSize = 2
        Me.btnLimparTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimparTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparTurma.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimparTurma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparTurma.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimparTurma.Location = New System.Drawing.Point(369, 48)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 76
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnLimparTurma, "Clique para limpar texto 'Turmas'.")
        Me.btnLimparTurma.UseVisualStyleBackColor = False
        '
        'btnConsTurma
        '
        Me.btnConsTurma.BackColor = System.Drawing.Color.Transparent
        Me.btnConsTurma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsTurma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsTurma.FlatAppearance.BorderSize = 2
        Me.btnConsTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnConsTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsTurma.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsTurma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsTurma.Image = Global.Tcc.My.Resources.Resources.magnifier
        Me.btnConsTurma.Location = New System.Drawing.Point(320, 48)
        Me.btnConsTurma.Name = "btnConsTurma"
        Me.btnConsTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnConsTurma.TabIndex = 75
        Me.btnConsTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnConsTurma, "Clique para consultar Turmas.")
        Me.btnConsTurma.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.cmbPeriodo)
        Me.Panel8.Location = New System.Drawing.Point(195, 49)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(119, 35)
        Me.Panel8.TabIndex = 74
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPeriodo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbPeriodo.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(2, 2)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(113, 29)
        Me.cmbPeriodo.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.mtbAnoTurma)
        Me.Panel7.Location = New System.Drawing.Point(140, 49)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(49, 35)
        Me.Panel7.TabIndex = 73
        '
        'mtbAnoTurma
        '
        Me.mtbAnoTurma.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mtbAnoTurma.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.mtbAnoTurma.Location = New System.Drawing.Point(2, 2)
        Me.mtbAnoTurma.Mask = "0000"
        Me.mtbAnoTurma.Name = "mtbAnoTurma"
        Me.mtbAnoTurma.Size = New System.Drawing.Size(43, 29)
        Me.mtbAnoTurma.TabIndex = 1
        Me.mtbAnoTurma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtTurma)
        Me.Panel6.Location = New System.Drawing.Point(15, 49)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(119, 35)
        Me.Panel6.TabIndex = 72
        '
        'txtTurma
        '
        Me.txtTurma.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTurma.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.txtTurma.Location = New System.Drawing.Point(2, 2)
        Me.txtTurma.Name = "txtTurma"
        Me.txtTurma.Size = New System.Drawing.Size(113, 29)
        Me.txtTurma.TabIndex = 0
        Me.txtTurma.Text = "Digite a turma"
        '
        'dgvTurma
        '
        Me.dgvTurma.AllowUserToAddRows = False
        Me.dgvTurma.AllowUserToDeleteRows = False
        Me.dgvTurma.AllowUserToResizeColumns = False
        Me.dgvTurma.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvTurma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTurma.BackgroundColor = System.Drawing.Color.White
        Me.dgvTurma.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvTurma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurma.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDTurma, Me.colAno, Me.colTurma, Me.colPeriodo})
        Me.dgvTurma.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTurma.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTurma.EnableHeadersVisualStyles = False
        Me.dgvTurma.GridColor = System.Drawing.Color.Black
        Me.dgvTurma.Location = New System.Drawing.Point(3, 192)
        Me.dgvTurma.MultiSelect = False
        Me.dgvTurma.Name = "dgvTurma"
        Me.dgvTurma.ReadOnly = True
        Me.dgvTurma.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTurma.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTurma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvTurma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTurma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTurma.ShowCellErrors = False
        Me.dgvTurma.ShowCellToolTips = False
        Me.dgvTurma.ShowEditingIcon = False
        Me.dgvTurma.ShowRowErrors = False
        Me.dgvTurma.Size = New System.Drawing.Size(422, 169)
        Me.dgvTurma.TabIndex = 71
        Me.dgvTurma.TabStop = False
        '
        'colIDTurma
        '
        Me.colIDTurma.DataPropertyName = "id_turma"
        Me.colIDTurma.HeaderText = "colIDTurma"
        Me.colIDTurma.Name = "colIDTurma"
        Me.colIDTurma.ReadOnly = True
        Me.colIDTurma.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDTurma.Visible = False
        '
        'colAno
        '
        Me.colAno.DataPropertyName = "ano"
        Me.colAno.HeaderText = "ANO"
        Me.colAno.Name = "colAno"
        Me.colAno.ReadOnly = True
        Me.colAno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colTurma
        '
        Me.colTurma.DataPropertyName = "turma"
        Me.colTurma.HeaderText = "TURMA"
        Me.colTurma.Name = "colTurma"
        Me.colTurma.ReadOnly = True
        Me.colTurma.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurma.Width = 129
        '
        'colPeriodo
        '
        Me.colPeriodo.DataPropertyName = "periodo"
        Me.colPeriodo.HeaderText = "PERÍODO"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.ReadOnly = True
        Me.colPeriodo.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Turma:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(192, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Período:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(137, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 14)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Ano:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(164, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 23)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "TURMAS"
        '
        'tabAlunProf
        '
        Me.tabAlunProf.CausesValidation = False
        Me.tabAlunProf.Controls.Add(Me.tbpAluno)
        Me.tabAlunProf.Controls.Add(Me.tbpProfessor)
        Me.tabAlunProf.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAlunProf.Location = New System.Drawing.Point(3, 367)
        Me.tabAlunProf.Multiline = True
        Me.tabAlunProf.Name = "tabAlunProf"
        Me.tabAlunProf.SelectedIndex = 0
        Me.tabAlunProf.Size = New System.Drawing.Size(422, 319)
        Me.tabAlunProf.TabIndex = 57
        '
        'tbpAluno
        '
        Me.tbpAluno.Controls.Add(Me.btnRemoveAluno)
        Me.tbpAluno.Controls.Add(Me.Panel2)
        Me.tbpAluno.Controls.Add(Me.btnConsAluno)
        Me.tbpAluno.Controls.Add(Me.Panel3)
        Me.tbpAluno.Controls.Add(Me.btnAddAluno)
        Me.tbpAluno.Controls.Add(Me.btnLimparAluno)
        Me.tbpAluno.Controls.Add(Me.Label5)
        Me.tbpAluno.Controls.Add(Me.Label4)
        Me.tbpAluno.Controls.Add(Me.dgvAluno)
        Me.tbpAluno.Location = New System.Drawing.Point(4, 25)
        Me.tbpAluno.Name = "tbpAluno"
        Me.tbpAluno.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAluno.Size = New System.Drawing.Size(414, 290)
        Me.tbpAluno.TabIndex = 0
        Me.tbpAluno.Text = "Alunos"
        Me.tbpAluno.UseVisualStyleBackColor = True
        '
        'btnRemoveAluno
        '
        Me.btnRemoveAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnRemoveAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveAluno.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveAluno.Image = Global.Tcc.My.Resources.Resources.minus_sign_inside_a_black_circle
        Me.btnRemoveAluno.Location = New System.Drawing.Point(203, 55)
        Me.btnRemoveAluno.Name = "btnRemoveAluno"
        Me.btnRemoveAluno.Size = New System.Drawing.Size(43, 47)
        Me.btnRemoveAluno.TabIndex = 45
        Me.btnRemoveAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnRemoveAluno, "Clique para desvincular aluno.")
        Me.btnRemoveAluno.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNomeAluno)
        Me.Panel2.Location = New System.Drawing.Point(58, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 28)
        Me.Panel2.TabIndex = 41
        '
        'txtNomeAluno
        '
        Me.txtNomeAluno.BackColor = System.Drawing.Color.White
        Me.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeAluno.Enabled = False
        Me.txtNomeAluno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeAluno.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNomeAluno.Location = New System.Drawing.Point(2, 2)
        Me.txtNomeAluno.Name = "txtNomeAluno"
        Me.txtNomeAluno.Size = New System.Drawing.Size(231, 22)
        Me.txtNomeAluno.TabIndex = 9
        Me.txtNomeAluno.Tag = ""
        Me.txtNomeAluno.Text = "Digite o nome"
        '
        'btnConsAluno
        '
        Me.btnConsAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnConsAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsAluno.FlatAppearance.BorderSize = 2
        Me.btnConsAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnConsAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsAluno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsAluno.Location = New System.Drawing.Point(301, 19)
        Me.btnConsAluno.Name = "btnConsAluno"
        Me.btnConsAluno.Size = New System.Drawing.Size(41, 32)
        Me.btnConsAluno.TabIndex = 42
        Me.btnConsAluno.Text = "..."
        Me.btnConsAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnConsAluno, "Clique para consultar aluno.")
        Me.btnConsAluno.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtMatricula)
        Me.Panel3.Location = New System.Drawing.Point(7, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(45, 28)
        Me.Panel3.TabIndex = 40
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.White
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMatricula.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.Black
        Me.txtMatricula.Location = New System.Drawing.Point(2, 2)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(39, 22)
        Me.txtMatricula.TabIndex = 8
        Me.txtMatricula.Tag = ""
        Me.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddAluno
        '
        Me.btnAddAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnAddAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAddAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAluno.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddAluno.Image = Global.Tcc.My.Resources.Resources.plus_sign_in_a_black_circle
        Me.btnAddAluno.Location = New System.Drawing.Point(154, 55)
        Me.btnAddAluno.Name = "btnAddAluno"
        Me.btnAddAluno.Size = New System.Drawing.Size(43, 47)
        Me.btnAddAluno.TabIndex = 44
        Me.btnAddAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnAddAluno, "Clique para vincular aluno.")
        Me.btnAddAluno.UseVisualStyleBackColor = False
        '
        'btnLimparAluno
        '
        Me.btnLimparAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimparAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparAluno.FlatAppearance.BorderSize = 2
        Me.btnLimparAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimparAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparAluno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimparAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparAluno.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimparAluno.Location = New System.Drawing.Point(348, 16)
        Me.btnLimparAluno.Name = "btnLimparAluno"
        Me.btnLimparAluno.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparAluno.TabIndex = 43
        Me.btnLimparAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnLimparAluno, "Clique para limpar texto 'aluno'.")
        Me.btnLimparAluno.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 14)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "RA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Nome:"
        '
        'dgvAluno
        '
        Me.dgvAluno.AllowUserToAddRows = False
        Me.dgvAluno.AllowUserToDeleteRows = False
        Me.dgvAluno.AllowUserToResizeColumns = False
        Me.dgvAluno.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvAluno.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAluno.BackgroundColor = System.Drawing.Color.White
        Me.dgvAluno.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvAluno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAluno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAluno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAluno, Me.colIDAluno})
        Me.dgvAluno.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAluno.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAluno.EnableHeadersVisualStyles = False
        Me.dgvAluno.GridColor = System.Drawing.Color.Black
        Me.dgvAluno.Location = New System.Drawing.Point(6, 108)
        Me.dgvAluno.MultiSelect = False
        Me.dgvAluno.Name = "dgvAluno"
        Me.dgvAluno.ReadOnly = True
        Me.dgvAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAluno.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAluno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAluno.ShowCellErrors = False
        Me.dgvAluno.ShowCellToolTips = False
        Me.dgvAluno.ShowEditingIcon = False
        Me.dgvAluno.ShowRowErrors = False
        Me.dgvAluno.Size = New System.Drawing.Size(402, 169)
        Me.dgvAluno.TabIndex = 20
        Me.dgvAluno.TabStop = False
        '
        'colAluno
        '
        Me.colAluno.DataPropertyName = "nome_aluno"
        Me.colAluno.HeaderText = "ALUNO"
        Me.colAluno.Name = "colAluno"
        Me.colAluno.ReadOnly = True
        Me.colAluno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colAluno.Width = 359
        '
        'colIDAluno
        '
        Me.colIDAluno.DataPropertyName = "id_matricula"
        Me.colIDAluno.HeaderText = "colIDAluno"
        Me.colIDAluno.Name = "colIDAluno"
        Me.colIDAluno.ReadOnly = True
        Me.colIDAluno.Visible = False
        '
        'tbpProfessor
        '
        Me.tbpProfessor.Controls.Add(Me.Panel9)
        Me.tbpProfessor.Controls.Add(Me.Label8)
        Me.tbpProfessor.Controls.Add(Me.Panel4)
        Me.tbpProfessor.Controls.Add(Me.Label6)
        Me.tbpProfessor.Controls.Add(Me.dgvProf)
        Me.tbpProfessor.Controls.Add(Me.Label7)
        Me.tbpProfessor.Controls.Add(Me.Panel5)
        Me.tbpProfessor.Controls.Add(Me.btnConsProf)
        Me.tbpProfessor.Controls.Add(Me.btnLimparProf)
        Me.tbpProfessor.Controls.Add(Me.btnRemoveProf)
        Me.tbpProfessor.Controls.Add(Me.btnAddProf)
        Me.tbpProfessor.Location = New System.Drawing.Point(4, 25)
        Me.tbpProfessor.Name = "tbpProfessor"
        Me.tbpProfessor.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpProfessor.Size = New System.Drawing.Size(414, 290)
        Me.tbpProfessor.TabIndex = 1
        Me.tbpProfessor.Text = "Professores"
        Me.tbpProfessor.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.cmbDisc)
        Me.Panel9.Location = New System.Drawing.Point(8, 66)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(158, 35)
        Me.Panel9.TabIndex = 76
        '
        'cmbDisc
        '
        Me.cmbDisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDisc.Enabled = False
        Me.cmbDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDisc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbDisc.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmbDisc.FormattingEnabled = True
        Me.cmbDisc.Location = New System.Drawing.Point(2, 2)
        Me.cmbDisc.Name = "cmbDisc"
        Me.cmbDisc.Size = New System.Drawing.Size(151, 29)
        Me.cmbDisc.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(5, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 14)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Disciplina:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCod)
        Me.Panel4.Location = New System.Drawing.Point(7, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(45, 28)
        Me.Panel4.TabIndex = 48
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.White
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.ForeColor = System.Drawing.Color.Black
        Me.txtCod.Location = New System.Drawing.Point(2, 2)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(39, 22)
        Me.txtCod.TabIndex = 8
        Me.txtCod.Tag = ""
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(58, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Nome:"
        '
        'dgvProf
        '
        Me.dgvProf.AllowUserToAddRows = False
        Me.dgvProf.AllowUserToDeleteRows = False
        Me.dgvProf.AllowUserToResizeColumns = False
        Me.dgvProf.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.dgvProf.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProf.BackgroundColor = System.Drawing.Color.White
        Me.dgvProf.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProfessor, Me.colDisc, Me.colIDProfDiscp, Me.colIDProf})
        Me.dgvProf.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProf.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProf.EnableHeadersVisualStyles = False
        Me.dgvProf.GridColor = System.Drawing.Color.Black
        Me.dgvProf.Location = New System.Drawing.Point(6, 108)
        Me.dgvProf.MultiSelect = False
        Me.dgvProf.Name = "dgvProf"
        Me.dgvProf.ReadOnly = True
        Me.dgvProf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProf.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvProf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProf.ShowCellErrors = False
        Me.dgvProf.ShowCellToolTips = False
        Me.dgvProf.ShowEditingIcon = False
        Me.dgvProf.ShowRowErrors = False
        Me.dgvProf.Size = New System.Drawing.Size(402, 169)
        Me.dgvProf.TabIndex = 21
        Me.dgvProf.TabStop = False
        '
        'colProfessor
        '
        Me.colProfessor.DataPropertyName = "nome_usuario"
        Me.colProfessor.HeaderText = "PROFESSOR"
        Me.colProfessor.Name = "colProfessor"
        Me.colProfessor.ReadOnly = True
        Me.colProfessor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colProfessor.Width = 234
        '
        'colDisc
        '
        Me.colDisc.DataPropertyName = "disciplina"
        Me.colDisc.HeaderText = "DISCIPLINA"
        Me.colDisc.Name = "colDisc"
        Me.colDisc.ReadOnly = True
        Me.colDisc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDisc.Width = 125
        '
        'colIDProfDiscp
        '
        Me.colIDProfDiscp.DataPropertyName = "id_prof_discp"
        Me.colIDProfDiscp.HeaderText = "colIDProfDiscp"
        Me.colIDProfDiscp.Name = "colIDProfDiscp"
        Me.colIDProfDiscp.ReadOnly = True
        Me.colIDProfDiscp.Visible = False
        '
        'colIDProf
        '
        Me.colIDProf.DataPropertyName = "id_usuario"
        Me.colIDProf.HeaderText = "colIDProf"
        Me.colIDProf.Name = "colIDProf"
        Me.colIDProf.ReadOnly = True
        Me.colIDProf.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 14)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "COD:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtNomeProf)
        Me.Panel5.Location = New System.Drawing.Point(58, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(237, 28)
        Me.Panel5.TabIndex = 49
        '
        'txtNomeProf
        '
        Me.txtNomeProf.BackColor = System.Drawing.Color.White
        Me.txtNomeProf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeProf.Enabled = False
        Me.txtNomeProf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProf.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNomeProf.Location = New System.Drawing.Point(2, 2)
        Me.txtNomeProf.Name = "txtNomeProf"
        Me.txtNomeProf.Size = New System.Drawing.Size(231, 22)
        Me.txtNomeProf.TabIndex = 9
        Me.txtNomeProf.Tag = ""
        Me.txtNomeProf.Text = "Digite o nome"
        '
        'btnConsProf
        '
        Me.btnConsProf.BackColor = System.Drawing.Color.Transparent
        Me.btnConsProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsProf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsProf.FlatAppearance.BorderSize = 2
        Me.btnConsProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnConsProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsProf.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsProf.Location = New System.Drawing.Point(301, 19)
        Me.btnConsProf.Name = "btnConsProf"
        Me.btnConsProf.Size = New System.Drawing.Size(41, 32)
        Me.btnConsProf.TabIndex = 50
        Me.btnConsProf.Text = "..."
        Me.btnConsProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnConsProf, "Clique para consultar professor.")
        Me.btnConsProf.UseVisualStyleBackColor = False
        '
        'btnLimparProf
        '
        Me.btnLimparProf.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimparProf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparProf.FlatAppearance.BorderSize = 2
        Me.btnLimparProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimparProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparProf.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimparProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparProf.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimparProf.Location = New System.Drawing.Point(348, 16)
        Me.btnLimparProf.Name = "btnLimparProf"
        Me.btnLimparProf.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparProf.TabIndex = 51
        Me.btnLimparProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnLimparProf, "Clique para limpar texto 'professor'.")
        Me.btnLimparProf.UseVisualStyleBackColor = False
        '
        'btnRemoveProf
        '
        Me.btnRemoveProf.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveProf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnRemoveProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProf.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveProf.Image = Global.Tcc.My.Resources.Resources.minus_sign_inside_a_black_circle
        Me.btnRemoveProf.Location = New System.Drawing.Point(249, 54)
        Me.btnRemoveProf.Name = "btnRemoveProf"
        Me.btnRemoveProf.Size = New System.Drawing.Size(43, 47)
        Me.btnRemoveProf.TabIndex = 53
        Me.btnRemoveProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnRemoveProf, "Clique para desvincular professor.")
        Me.btnRemoveProf.UseVisualStyleBackColor = False
        '
        'btnAddProf
        '
        Me.btnAddProf.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddProf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddProf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAddProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProf.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddProf.Image = Global.Tcc.My.Resources.Resources.plus_sign_in_a_black_circle
        Me.btnAddProf.Location = New System.Drawing.Point(200, 54)
        Me.btnAddProf.Name = "btnAddProf"
        Me.btnAddProf.Size = New System.Drawing.Size(43, 47)
        Me.btnAddProf.TabIndex = 52
        Me.btnAddProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTurmas.SetToolTip(Me.btnAddProf, "Clique para vincular professor.")
        Me.btnAddProf.UseVisualStyleBackColor = False
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(397, 3)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 13
        Me.ptbfechar.TabStop = False
        '
        'ToolTurmas
        '
        Me.ToolTurmas.ToolTipTitle = "Turmas."
        '
        'CadastrarTurma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(435, 700)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastrarTurma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Turmas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvTurma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAlunProf.ResumeLayout(False)
        Me.tbpAluno.ResumeLayout(False)
        Me.tbpAluno.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpProfessor.ResumeLayout(False)
        Me.tbpProfessor.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Private WithEvents dgvProf As DataGridView
    Private WithEvents dgvAluno As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLimparProf As Button
    Friend WithEvents btnRemoveProf As Button
    Friend WithEvents btnAddProf As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCod As TextBox
    Friend WithEvents btnConsProf As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtNomeProf As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLimparAluno As Button
    Friend WithEvents btnRemoveAluno As Button
    Friend WithEvents btnAddAluno As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents btnConsAluno As Button
    Friend WithEvents txtNomeAluno As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tabAlunProf As TabControl
    Friend WithEvents tbpAluno As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbpProfessor As TabPage
    Friend WithEvents btnLimparTurma As Button
    Friend WithEvents btnConsTurma As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents mtbAnoTurma As MaskedTextBox
    Friend WithEvents Panel6 As Panel
    Private WithEvents dgvTurma As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents ToolTurmas As System.Windows.Forms.ToolTip
    Friend WithEvents colIDTurma As DataGridViewTextBoxColumn
    Friend WithEvents colAno As DataGridViewTextBoxColumn
    Friend WithEvents colTurma As DataGridViewTextBoxColumn
    Friend WithEvents colPeriodo As DataGridViewTextBoxColumn
    Friend WithEvents Panel9 As Panel
    Friend WithEvents cmbDisc As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents colProfessor As DataGridViewTextBoxColumn
    Friend WithEvents colDisc As DataGridViewTextBoxColumn
    Friend WithEvents colIDProfDiscp As DataGridViewTextBoxColumn
    Friend WithEvents colIDProf As DataGridViewTextBoxColumn
    Friend WithEvents colAluno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIDAluno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTurma As TextBox
End Class
