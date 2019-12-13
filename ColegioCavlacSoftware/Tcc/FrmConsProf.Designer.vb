<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsProf))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCons = New System.Windows.Forms.Button()
        Me.dgvProf = New System.Windows.Forms.DataGridView()
        Me.colIDProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomeProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDTNascProf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDisc = New System.Windows.Forms.DataGridView()
        Me.colIDdisciplina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDisciplina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ptbFechar = New System.Windows.Forms.PictureBox()
        Me.ToolConsProf = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCons)
        Me.Panel1.Controls.Add(Me.dgvProf)
        Me.Panel1.Controls.Add(Me.dgvDisc)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.ptbFechar)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 570)
        Me.Panel1.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 2
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnOk.Image = Global.Tcc.My.Resources.Resources.ok_mark
        Me.btnOk.Location = New System.Drawing.Point(141, 469)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(105, 92)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsProf.SetToolTip(Me.btnOk, "Clique para confirmar")
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(127, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "DISCIPLINAS"
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimpar.FlatAppearance.BorderSize = 2
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnLimpar.Image = Global.Tcc.My.Resources.Resources.short_broom
        Me.btnLimpar.Location = New System.Drawing.Point(303, 31)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(41, 39)
        Me.btnLimpar.TabIndex = 3
        Me.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsProf.SetToolTip(Me.btnLimpar, "Clique para limpar.")
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "PROFESSORES"
        '
        'btnCons
        '
        Me.btnCons.BackColor = System.Drawing.Color.Transparent
        Me.btnCons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCons.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCons.FlatAppearance.BorderSize = 2
        Me.btnCons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCons.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCons.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCons.Image = Global.Tcc.My.Resources.Resources.magnifier
        Me.btnCons.Location = New System.Drawing.Point(254, 31)
        Me.btnCons.Name = "btnCons"
        Me.btnCons.Size = New System.Drawing.Size(41, 39)
        Me.btnCons.TabIndex = 2
        Me.btnCons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsProf.SetToolTip(Me.btnCons, "Clique para consultar.")
        Me.btnCons.UseVisualStyleBackColor = False
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
        Me.dgvProf.Location = New System.Drawing.Point(9, 76)
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
        Me.colIDProf.HeaderText = "COD"
        Me.colIDProf.Name = "colIDProf"
        Me.colIDProf.ReadOnly = True
        Me.colIDProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDProf.Width = 50
        '
        'colNomeProf
        '
        Me.colNomeProf.DataPropertyName = "nome_usuario"
        Me.colNomeProf.HeaderText = "PROFESSOR"
        Me.colNomeProf.Name = "colNomeProf"
        Me.colNomeProf.ReadOnly = True
        Me.colNomeProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNomeProf.Width = 151
        '
        'colDTNascProf
        '
        Me.colDTNascProf.DataPropertyName = "dt_nasc"
        Me.colDTNascProf.HeaderText = "NASCIMENTO"
        Me.colDTNascProf.Name = "colDTNascProf"
        Me.colDTNascProf.ReadOnly = True
        Me.colDTNascProf.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDTNascProf.Width = 123
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
        Me.dgvDisc.Location = New System.Drawing.Point(9, 294)
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
        Me.Panel13.Controls.Add(Me.txtNome)
        Me.Panel13.Location = New System.Drawing.Point(9, 39)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(237, 28)
        Me.Panel13.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNome.Location = New System.Drawing.Point(2, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(231, 22)
        Me.txtNome.TabIndex = 1
        Me.txtNome.Tag = ""
        Me.txtNome.Text = "Digite o nome"
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
        'ToolConsProf
        '
        Me.ToolConsProf.ToolTipTitle = "PROFESSOR"
        '
        'FrmConsProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(391, 577)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConsProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCons As Button
    Private WithEvents dgvProf As DataGridView
    Public WithEvents dgvDisc As DataGridView
    Friend WithEvents colIDdisciplina As DataGridViewTextBoxColumn
    Friend WithEvents colDisciplina As DataGridViewTextBoxColumn
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txtNome As TextBox
    Friend WithEvents ptbFechar As PictureBox
    Friend WithEvents colIDProf As DataGridViewTextBoxColumn
    Friend WithEvents colNomeProf As DataGridViewTextBoxColumn
    Friend WithEvents colDTNascProf As DataGridViewTextBoxColumn
    Friend WithEvents btnOk As Button
    Friend WithEvents ToolConsProf As ToolTip
End Class
