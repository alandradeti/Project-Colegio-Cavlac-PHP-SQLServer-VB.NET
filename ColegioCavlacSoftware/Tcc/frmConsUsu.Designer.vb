<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsUsu))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCons = New System.Windows.Forms.Button()
        Me.dgvUsu = New System.Windows.Forms.DataGridView()
        Me.colIDUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomeUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDTNascUsu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ptbFechar = New System.Windows.Forms.PictureBox()
        Me.ToolConsUsu = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.btnLimpar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCons)
        Me.Panel1.Controls.Add(Me.dgvUsu)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.ptbFechar)
        Me.Panel1.Location = New System.Drawing.Point(4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 351)
        Me.Panel1.TabIndex = 1
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
        Me.btnOk.Location = New System.Drawing.Point(137, 249)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(105, 92)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsUsu.SetToolTip(Me.btnOk, "Clique para confirmar.")
        Me.btnOk.UseVisualStyleBackColor = False
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
        Me.btnLimpar.Location = New System.Drawing.Point(300, 28)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(41, 39)
        Me.btnLimpar.TabIndex = 3
        Me.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsUsu.SetToolTip(Me.btnLimpar, "Clique para limpar.")
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "USUÁRIOS"
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
        Me.btnCons.Location = New System.Drawing.Point(251, 28)
        Me.btnCons.Name = "btnCons"
        Me.btnCons.Size = New System.Drawing.Size(41, 39)
        Me.btnCons.TabIndex = 2
        Me.btnCons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolConsUsu.SetToolTip(Me.btnCons, "Clique para consultar.")
        Me.btnCons.UseVisualStyleBackColor = False
        '
        'dgvUsu
        '
        Me.dgvUsu.AllowUserToAddRows = False
        Me.dgvUsu.AllowUserToDeleteRows = False
        Me.dgvUsu.AllowUserToResizeColumns = False
        Me.dgvUsu.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvUsu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsu.BackgroundColor = System.Drawing.Color.White
        Me.dgvUsu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvUsu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDUsu, Me.colNomeUsu, Me.colDTNascUsu})
        Me.dgvUsu.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUsu.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUsu.EnableHeadersVisualStyles = False
        Me.dgvUsu.GridColor = System.Drawing.Color.Black
        Me.dgvUsu.Location = New System.Drawing.Point(4, 73)
        Me.dgvUsu.MultiSelect = False
        Me.dgvUsu.Name = "dgvUsu"
        Me.dgvUsu.ReadOnly = True
        Me.dgvUsu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsu.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUsu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUsu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsu.ShowCellErrors = False
        Me.dgvUsu.ShowCellToolTips = False
        Me.dgvUsu.ShowEditingIcon = False
        Me.dgvUsu.ShowRowErrors = False
        Me.dgvUsu.Size = New System.Drawing.Size(367, 169)
        Me.dgvUsu.TabIndex = 0
        Me.dgvUsu.TabStop = False
        '
        'colIDUsu
        '
        Me.colIDUsu.DataPropertyName = "id_usuario"
        Me.colIDUsu.HeaderText = "COD"
        Me.colIDUsu.Name = "colIDUsu"
        Me.colIDUsu.ReadOnly = True
        Me.colIDUsu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDUsu.Width = 50
        '
        'colNomeUsu
        '
        Me.colNomeUsu.DataPropertyName = "nome_usuario"
        Me.colNomeUsu.HeaderText = "USUÁRIO"
        Me.colNomeUsu.Name = "colNomeUsu"
        Me.colNomeUsu.ReadOnly = True
        Me.colNomeUsu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNomeUsu.Width = 151
        '
        'colDTNascUsu
        '
        Me.colDTNascUsu.DataPropertyName = "dt_nasc"
        Me.colDTNascUsu.HeaderText = "NASCIMENTO"
        Me.colDTNascUsu.Name = "colDTNascUsu"
        Me.colDTNascUsu.ReadOnly = True
        Me.colDTNascUsu.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDTNascUsu.Width = 123
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.txtNome)
        Me.Panel13.Location = New System.Drawing.Point(8, 32)
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
        Me.ptbFechar.Location = New System.Drawing.Point(344, 3)
        Me.ptbFechar.Name = "ptbFechar"
        Me.ptbFechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFechar.TabIndex = 15
        Me.ptbFechar.TabStop = False
        '
        'frmConsUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 358)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsUsu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCons As Button
    Private WithEvents dgvUsu As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txtNome As TextBox
    Friend WithEvents ptbFechar As PictureBox
    Friend WithEvents btnOk As Button
    Friend WithEvents colIDUsu As DataGridViewTextBoxColumn
    Friend WithEvents colNomeUsu As DataGridViewTextBoxColumn
    Friend WithEvents colDTNascUsu As DataGridViewTextBoxColumn
    Friend WithEvents ToolConsUsu As ToolTip
End Class
