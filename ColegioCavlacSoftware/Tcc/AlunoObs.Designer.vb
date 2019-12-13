<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlunoObs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlunoObs))
        Me.ToolObs = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemoveObs = New System.Windows.Forms.Button()
        Me.btnConsAluno = New System.Windows.Forms.Button()
        Me.btnAddobs = New System.Windows.Forms.Button()
        Me.btnLimparAluno = New System.Windows.Forms.Button()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.btnConsTurma = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvTurma = New System.Windows.Forms.DataGridView()
        Me.colIDTurma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTurma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNomeAluno = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvObs = New System.Windows.Forms.DataGridView()
        Me.colData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colobs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDobs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtTurma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTurma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvObs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRemoveObs
        '
        Me.btnRemoveObs.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveObs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveObs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveObs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnRemoveObs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveObs.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnRemoveObs.Image = Global.Tcc.My.Resources.Resources.minus_sign_inside_a_black_circle
        Me.btnRemoveObs.Location = New System.Drawing.Point(227, 336)
        Me.btnRemoveObs.Name = "btnRemoveObs"
        Me.btnRemoveObs.Size = New System.Drawing.Size(43, 47)
        Me.btnRemoveObs.TabIndex = 9
        Me.btnRemoveObs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnRemoveObs, "Clique para Remover Notificação.")
        Me.btnRemoveObs.UseVisualStyleBackColor = False
        '
        'btnConsAluno
        '
        Me.btnConsAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnConsAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsAluno.Enabled = False
        Me.btnConsAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsAluno.FlatAppearance.BorderSize = 2
        Me.btnConsAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnConsAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsAluno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsAluno.Location = New System.Drawing.Point(325, 300)
        Me.btnConsAluno.Name = "btnConsAluno"
        Me.btnConsAluno.Size = New System.Drawing.Size(41, 32)
        Me.btnConsAluno.TabIndex = 6
        Me.btnConsAluno.Text = "..."
        Me.btnConsAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnConsAluno, "Clique para Consultar Aluno.")
        Me.btnConsAluno.UseVisualStyleBackColor = False
        '
        'btnAddobs
        '
        Me.btnAddobs.BackColor = System.Drawing.Color.Transparent
        Me.btnAddobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddobs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddobs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAddobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddobs.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddobs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnAddobs.Image = Global.Tcc.My.Resources.Resources.plus_sign_in_a_black_circle
        Me.btnAddobs.Location = New System.Drawing.Point(178, 336)
        Me.btnAddobs.Name = "btnAddobs"
        Me.btnAddobs.Size = New System.Drawing.Size(43, 47)
        Me.btnAddobs.TabIndex = 8
        Me.btnAddobs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnAddobs, "Clique para Adicionar Nova Notificação.")
        Me.btnAddobs.UseVisualStyleBackColor = False
        '
        'btnLimparAluno
        '
        Me.btnLimparAluno.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparAluno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimparAluno.Enabled = False
        Me.btnLimparAluno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparAluno.FlatAppearance.BorderSize = 2
        Me.btnLimparAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimparAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparAluno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimparAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparAluno.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimparAluno.Location = New System.Drawing.Point(372, 297)
        Me.btnLimparAluno.Name = "btnLimparAluno"
        Me.btnLimparAluno.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparAluno.TabIndex = 7
        Me.btnLimparAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnLimparAluno, "Clique para Limpar Campos do Aluno.")
        Me.btnLimparAluno.UseVisualStyleBackColor = False
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
        Me.btnLimparTurma.Location = New System.Drawing.Point(377, 50)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 3
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnLimparTurma, "Clique para Limpar Campos da Turma.")
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
        Me.btnConsTurma.Location = New System.Drawing.Point(328, 50)
        Me.btnConsTurma.Name = "btnConsTurma"
        Me.btnConsTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnConsTurma.TabIndex = 2
        Me.btnConsTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolObs.SetToolTip(Me.btnConsTurma, "Clique para Consultar Turma.")
        Me.btnConsTurma.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvTurma)
        Me.Panel1.Controls.Add(Me.btnRemoveObs)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnConsAluno)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnAddobs)
        Me.Panel1.Controls.Add(Me.btnLimparAluno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dgvObs)
        Me.Panel1.Controls.Add(Me.btnLimparTurma)
        Me.Panel1.Controls.Add(Me.btnConsTurma)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 590)
        Me.Panel1.TabIndex = 1
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
        Me.dgvTurma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDTurma, Me.colTurma, Me.colPeriodo})
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
        Me.dgvTurma.Location = New System.Drawing.Point(10, 95)
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
        Me.dgvTurma.TabIndex = 96
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
        'colTurma
        '
        Me.colTurma.DataPropertyName = "turma"
        Me.colTurma.HeaderText = "TURMA"
        Me.colTurma.Name = "colTurma"
        Me.colTurma.ReadOnly = True
        Me.colTurma.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurma.Width = 154
        '
        'colPeriodo
        '
        Me.colPeriodo.DataPropertyName = "periodo"
        Me.colPeriodo.HeaderText = "PERÍODO"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.ReadOnly = True
        Me.colPeriodo.Width = 225
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNomeAluno)
        Me.Panel2.Location = New System.Drawing.Point(82, 301)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 28)
        Me.Panel2.TabIndex = 5
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
        Me.txtNomeAluno.TabIndex = 5
        Me.txtNomeAluno.Tag = ""
        Me.txtNomeAluno.Text = "Digite o nome"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtMatricula)
        Me.Panel3.Location = New System.Drawing.Point(31, 301)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(45, 28)
        Me.Panel3.TabIndex = 4
        '
        'txtMatricula
        '
        Me.txtMatricula.BackColor = System.Drawing.Color.White
        Me.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricula.ForeColor = System.Drawing.Color.Black
        Me.txtMatricula.Location = New System.Drawing.Point(2, 2)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(39, 22)
        Me.txtMatricula.TabIndex = 4
        Me.txtMatricula.Tag = ""
        Me.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(31, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 14)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "N°"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(82, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Nome:"
        '
        'dgvObs
        '
        Me.dgvObs.AllowUserToAddRows = False
        Me.dgvObs.AllowUserToDeleteRows = False
        Me.dgvObs.AllowUserToResizeColumns = False
        Me.dgvObs.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvObs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvObs.BackgroundColor = System.Drawing.Color.White
        Me.dgvObs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvObs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvObs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colData, Me.colobs, Me.colIDobs})
        Me.dgvObs.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvObs.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvObs.EnableHeadersVisualStyles = False
        Me.dgvObs.GridColor = System.Drawing.Color.Black
        Me.dgvObs.Location = New System.Drawing.Point(22, 389)
        Me.dgvObs.MultiSelect = False
        Me.dgvObs.Name = "dgvObs"
        Me.dgvObs.ReadOnly = True
        Me.dgvObs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvObs.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvObs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvObs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvObs.ShowCellErrors = False
        Me.dgvObs.ShowCellToolTips = False
        Me.dgvObs.ShowEditingIcon = False
        Me.dgvObs.ShowRowErrors = False
        Me.dgvObs.Size = New System.Drawing.Size(402, 169)
        Me.dgvObs.TabIndex = 87
        Me.dgvObs.TabStop = False
        '
        'colData
        '
        Me.colData.DataPropertyName = "data"
        Me.colData.HeaderText = "DATA"
        Me.colData.Name = "colData"
        Me.colData.ReadOnly = True
        Me.colData.Width = 75
        '
        'colobs
        '
        Me.colobs.DataPropertyName = "notificacao"
        Me.colobs.HeaderText = "NOTIFICAÇÃO"
        Me.colobs.Name = "colobs"
        Me.colobs.ReadOnly = True
        Me.colobs.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colobs.Width = 284
        '
        'colIDobs
        '
        Me.colIDobs.DataPropertyName = "id_noti"
        Me.colIDobs.HeaderText = "colIDobs"
        Me.colIDobs.Name = "colIDobs"
        Me.colIDobs.ReadOnly = True
        Me.colIDobs.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.cmbPeriodo)
        Me.Panel8.Location = New System.Drawing.Point(178, 51)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(144, 35)
        Me.Panel8.TabIndex = 1
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPeriodo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbPeriodo.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Location = New System.Drawing.Point(3, 2)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(136, 29)
        Me.cmbPeriodo.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtTurma)
        Me.Panel6.Location = New System.Drawing.Point(23, 51)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(148, 35)
        Me.Panel6.TabIndex = 0
        '
        'txtTurma
        '
        Me.txtTurma.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTurma.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.txtTurma.Location = New System.Drawing.Point(2, 2)
        Me.txtTurma.Name = "txtTurma"
        Me.txtTurma.Size = New System.Drawing.Size(141, 29)
        Me.txtTurma.TabIndex = 0
        Me.txtTurma.Text = "Digite a turma"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Turma:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(179, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Período:"
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(415, 3)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 77
        Me.ptbfechar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(148, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "OBSERVAÇÕES"
        '
        'AlunoObs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 599)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlunoObs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observações"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvTurma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvObs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolObs As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents dgvTurma As System.Windows.Forms.DataGridView
    Friend WithEvents colIDTurma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPeriodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveObs As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNomeAluno As System.Windows.Forms.TextBox
    Friend WithEvents btnConsAluno As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents btnAddobs As System.Windows.Forms.Button
    Friend WithEvents btnLimparAluno As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents dgvObs As System.Windows.Forms.DataGridView
    Friend WithEvents colData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colobs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIDobs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimparTurma As System.Windows.Forms.Button
    Friend WithEvents btnConsTurma As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtTurma As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
