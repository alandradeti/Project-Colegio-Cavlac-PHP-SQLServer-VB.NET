<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisciplina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDisciplina))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.btnLimparProf = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimparDisc = New System.Windows.Forms.Button()
        Me.btnRemoveProf = New System.Windows.Forms.Button()
        Me.btnAddProf = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCodProf = New System.Windows.Forms.TextBox()
        Me.btnConsProf = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNomeProf = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnConsDisc = New System.Windows.Forms.Button()
        Me.dgvProf = New System.Windows.Forms.DataGridView()
        Me.colIDProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomeProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDTNascProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDisc = New System.Windows.Forms.DataGridView()
        Me.colIDdisciplina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDisciplina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtDisciplina = New System.Windows.Forms.TextBox()
        Me.ptbFechar = New System.Windows.Forms.PictureBox()
        Me.ToolDisp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblCod)
        Me.Panel1.Controls.Add(Me.btnLimparProf)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLimparDisc)
        Me.Panel1.Controls.Add(Me.btnRemoveProf)
        Me.Panel1.Controls.Add(Me.btnAddProf)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnConsProf)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.btnGravar)
        Me.Panel1.Controls.Add(Me.btnConsDisc)
        Me.Panel1.Controls.Add(Me.dgvProf)
        Me.Panel1.Controls.Add(Me.dgvDisc)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.ptbFechar)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 660)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(52, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 14)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Nome:"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblCod.Location = New System.Drawing.Point(1, 382)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(37, 14)
        Me.lblCod.TabIndex = 39
        Me.lblCod.Text = "COD:"
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
        Me.btnLimparProf.Location = New System.Drawing.Point(342, 395)
        Me.btnLimparProf.Name = "btnLimparProf"
        Me.btnLimparProf.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparProf.TabIndex = 11
        Me.btnLimparProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnLimparProf, "Clique para limpar texto 'professor'.")
        Me.btnLimparProf.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "PROFESSORES"
        '
        'btnLimparDisc
        '
        Me.btnLimparDisc.BackColor = System.Drawing.Color.Transparent
        Me.btnLimparDisc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimparDisc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparDisc.FlatAppearance.BorderSize = 2
        Me.btnLimparDisc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimparDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimparDisc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimparDisc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimparDisc.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimparDisc.Location = New System.Drawing.Point(303, 26)
        Me.btnLimparDisc.Name = "btnLimparDisc"
        Me.btnLimparDisc.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparDisc.TabIndex = 3
        Me.btnLimparDisc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnLimparDisc, "Clique para limpar texto 'disciplina'.")
        Me.btnLimparDisc.UseVisualStyleBackColor = False
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
        Me.btnRemoveProf.Location = New System.Drawing.Point(195, 434)
        Me.btnRemoveProf.Name = "btnRemoveProf"
        Me.btnRemoveProf.Size = New System.Drawing.Size(43, 47)
        Me.btnRemoveProf.TabIndex = 13
        Me.btnRemoveProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnRemoveProf, "Clique para desvincular professor com disciplina.")
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
        Me.btnAddProf.Location = New System.Drawing.Point(146, 434)
        Me.btnAddProf.Name = "btnAddProf"
        Me.btnAddProf.Size = New System.Drawing.Size(43, 47)
        Me.btnAddProf.TabIndex = 12
        Me.btnAddProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnAddProf, "Clique para vincular professor com disciplina.")
        Me.btnAddProf.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DISCIPLINAS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtCodProf)
        Me.Panel3.Location = New System.Drawing.Point(1, 399)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(45, 28)
        Me.Panel3.TabIndex = 8
        '
        'txtCodProf
        '
        Me.txtCodProf.BackColor = System.Drawing.Color.White
        Me.txtCodProf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodProf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProf.ForeColor = System.Drawing.Color.Black
        Me.txtCodProf.Location = New System.Drawing.Point(2, 2)
        Me.txtCodProf.Name = "txtCodProf"
        Me.txtCodProf.Size = New System.Drawing.Size(39, 22)
        Me.txtCodProf.TabIndex = 8
        Me.txtCodProf.Tag = ""
        Me.txtCodProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnConsProf.Location = New System.Drawing.Point(295, 398)
        Me.btnConsProf.Name = "btnConsProf"
        Me.btnConsProf.Size = New System.Drawing.Size(41, 32)
        Me.btnConsProf.TabIndex = 10
        Me.btnConsProf.Text = "..."
        Me.btnConsProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnConsProf, "Clique para consultar professor.")
        Me.btnConsProf.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNomeProf)
        Me.Panel2.Location = New System.Drawing.Point(52, 399)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 29)
        Me.Panel2.TabIndex = 9
        '
        'txtNomeProf
        '
        Me.txtNomeProf.BackColor = System.Drawing.Color.White
        Me.txtNomeProf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomeProf.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProf.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNomeProf.Location = New System.Drawing.Point(2, 2)
        Me.txtNomeProf.Name = "txtNomeProf"
        Me.txtNomeProf.Size = New System.Drawing.Size(231, 22)
        Me.txtNomeProf.TabIndex = 9
        Me.txtNomeProf.Tag = ""
        Me.txtNomeProf.Text = "Digite o nome"
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
        Me.btnExcluir.Image = Global.Tcc.My.Resources.Resources.file__4_
        Me.btnExcluir.Location = New System.Drawing.Point(102, 68)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(87, 96)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnExcluir, "Clique para excluir disciplina.")
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
        Me.btnCancelar.Image = Global.Tcc.My.Resources.Resources.file__7_
        Me.btnCancelar.Location = New System.Drawing.Point(195, 68)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(87, 96)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnCancelar, "Clique para cancelar operação.")
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
        Me.btnNovo.Image = Global.Tcc.My.Resources.Resources.file__5_
        Me.btnNovo.Location = New System.Drawing.Point(9, 68)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(87, 96)
        Me.btnNovo.TabIndex = 4
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnNovo, "Clique para adicionar nova disciplina.")
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
        Me.btnGravar.Image = Global.Tcc.My.Resources.Resources.file__6_
        Me.btnGravar.Location = New System.Drawing.Point(288, 68)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(87, 96)
        Me.btnGravar.TabIndex = 7
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnGravar, "Clique para gravar operação.")
        Me.btnGravar.UseVisualStyleBackColor = False
        '
        'btnConsDisc
        '
        Me.btnConsDisc.BackColor = System.Drawing.Color.Transparent
        Me.btnConsDisc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsDisc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsDisc.FlatAppearance.BorderSize = 2
        Me.btnConsDisc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnConsDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsDisc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsDisc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnConsDisc.Image = Global.Tcc.My.Resources.Resources.magnifier
        Me.btnConsDisc.Location = New System.Drawing.Point(254, 26)
        Me.btnConsDisc.Name = "btnConsDisc"
        Me.btnConsDisc.Size = New System.Drawing.Size(41, 39)
        Me.btnConsDisc.TabIndex = 2
        Me.btnConsDisc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDisp.SetToolTip(Me.btnConsDisc, "Clique para consultar disciplinas.")
        Me.btnConsDisc.UseVisualStyleBackColor = False
        '
        'dgvProf
        '
        Me.dgvProf.AllowUserToAddRows = False
        Me.dgvProf.AllowUserToDeleteRows = False
        Me.dgvProf.AllowUserToResizeColumns = False
        Me.dgvProf.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvProf.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProf.BackgroundColor = System.Drawing.Color.White
        Me.dgvProf.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvProf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProf.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDProf, Me.colNomeProf, Me.colDTNascProf})
        Me.dgvProf.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProf.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProf.EnableHeadersVisualStyles = False
        Me.dgvProf.GridColor = System.Drawing.Color.Black
        Me.dgvProf.Location = New System.Drawing.Point(9, 487)
        Me.dgvProf.MultiSelect = False
        Me.dgvProf.Name = "dgvProf"
        Me.dgvProf.ReadOnly = True
        Me.dgvProf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProf.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProf.ShowCellErrors = False
        Me.dgvProf.ShowCellToolTips = False
        Me.dgvProf.ShowEditingIcon = False
        Me.dgvProf.ShowRowErrors = False
        Me.dgvProf.Size = New System.Drawing.Size(367, 169)
        Me.dgvProf.TabIndex = 0
        Me.dgvProf.TabStop = False
        '
        'colIDProf
        '
        Me.colIDProf.DataPropertyName = "id_usuario"
        Me.colIDProf.HeaderText = "colIDusuario"
        Me.colIDProf.Name = "colIDProf"
        Me.colIDProf.ReadOnly = True
        Me.colIDProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDProf.Visible = False
        '
        'colNomeProf
        '
        Me.colNomeProf.DataPropertyName = "nome_usuario"
        Me.colNomeProf.HeaderText = "PROFESSOR"
        Me.colNomeProf.Name = "colNomeProf"
        Me.colNomeProf.ReadOnly = True
        Me.colNomeProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNomeProf.Width = 162
        '
        'colDTNascProf
        '
        Me.colDTNascProf.DataPropertyName = "dt_nasc"
        Me.colDTNascProf.HeaderText = "NASCIMENTO"
        Me.colDTNascProf.Name = "colDTNascProf"
        Me.colDTNascProf.ReadOnly = True
        Me.colDTNascProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDTNascProf.Width = 162
        '
        'dgvDisc
        '
        Me.dgvDisc.AllowUserToAddRows = False
        Me.dgvDisc.AllowUserToDeleteRows = False
        Me.dgvDisc.AllowUserToResizeColumns = False
        Me.dgvDisc.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgvDisc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDisc.BackgroundColor = System.Drawing.Color.White
        Me.dgvDisc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvDisc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDdisciplina, Me.colDisciplina})
        Me.dgvDisc.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDisc.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDisc.EnableHeadersVisualStyles = False
        Me.dgvDisc.GridColor = System.Drawing.Color.Black
        Me.dgvDisc.Location = New System.Drawing.Point(9, 170)
        Me.dgvDisc.MultiSelect = False
        Me.dgvDisc.Name = "dgvDisc"
        Me.dgvDisc.ReadOnly = True
        Me.dgvDisc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisc.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDisc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDisc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDisc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisc.ShowCellErrors = False
        Me.dgvDisc.ShowCellToolTips = False
        Me.dgvDisc.ShowEditingIcon = False
        Me.dgvDisc.ShowRowErrors = False
        Me.dgvDisc.Size = New System.Drawing.Size(367, 169)
        Me.dgvDisc.TabIndex = 0
        Me.dgvDisc.TabStop = False
        '
        'colIDdisciplina
        '
        Me.colIDdisciplina.DataPropertyName = "id_discp"
        Me.colIDdisciplina.HeaderText = "colID"
        Me.colIDdisciplina.Name = "colIDdisciplina"
        Me.colIDdisciplina.ReadOnly = True
        Me.colIDdisciplina.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDdisciplina.Visible = False
        '
        'colDisciplina
        '
        Me.colDisciplina.DataPropertyName = "disciplina"
        Me.colDisciplina.HeaderText = "DISCIPLINA"
        Me.colDisciplina.Name = "colDisciplina"
        Me.colDisciplina.ReadOnly = True
        Me.colDisciplina.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDisciplina.Width = 324
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.txtDisciplina)
        Me.Panel13.Location = New System.Drawing.Point(9, 34)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(237, 28)
        Me.Panel13.TabIndex = 1
        '
        'txtDisciplina
        '
        Me.txtDisciplina.BackColor = System.Drawing.Color.White
        Me.txtDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDisciplina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisciplina.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDisciplina.Location = New System.Drawing.Point(2, 2)
        Me.txtDisciplina.Name = "txtDisciplina"
        Me.txtDisciplina.Size = New System.Drawing.Size(231, 22)
        Me.txtDisciplina.TabIndex = 1
        Me.txtDisciplina.Tag = ""
        Me.txtDisciplina.Text = "Digite a disciplina"
        '
        'ptbFechar
        '
        Me.ptbFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbFechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbFechar.Location = New System.Drawing.Point(354, 3)
        Me.ptbFechar.Name = "ptbFechar"
        Me.ptbFechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFechar.TabIndex = 15
        Me.ptbFechar.TabStop = False
        '
        'ToolDisp
        '
        Me.ToolDisp.ToolTipTitle = "Disciplinas."
        '
        'FrmDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(391, 668)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDisciplina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Disciplinas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ptbFechar As System.Windows.Forms.PictureBox
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents txtDisciplina As System.Windows.Forms.TextBox
    Private WithEvents dgvProf As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsDisc As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNomeProf As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtCodProf As System.Windows.Forms.TextBox
    Friend WithEvents btnConsProf As System.Windows.Forms.Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoveProf As Button
    Friend WithEvents btnAddProf As Button
    Friend WithEvents colIDProf As DataGridViewTextBoxColumn
    Friend WithEvents colNomeProf As DataGridViewTextBoxColumn
    Friend WithEvents colDTNascProf As DataGridViewTextBoxColumn
    Friend WithEvents btnLimparDisc As Button
    Public WithEvents dgvDisc As DataGridView
    Friend WithEvents colIDdisciplina As DataGridViewTextBoxColumn
    Friend WithEvents colDisciplina As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimparProf As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCod As Label
    Friend WithEvents ToolDisp As ToolTip
End Class
