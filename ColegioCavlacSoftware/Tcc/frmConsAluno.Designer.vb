<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsAluno
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsAluno))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCons = New System.Windows.Forms.Button()
        Me.dgvAluno = New System.Windows.Forms.DataGridView()
        Me.colIDaluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomeAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDTNascAluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ptbFechar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.dgvAluno)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.ptbFechar)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 351)
        Me.Panel1.TabIndex = 2
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
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ALUNOS"
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
        Me.btnCons.UseVisualStyleBackColor = False
        '
        'dgvAluno
        '
        Me.dgvAluno.AllowUserToAddRows = False
        Me.dgvAluno.AllowUserToDeleteRows = False
        Me.dgvAluno.AllowUserToResizeColumns = False
        Me.dgvAluno.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvAluno.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAluno.BackgroundColor = System.Drawing.Color.White
        Me.dgvAluno.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvAluno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAluno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAluno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDaluno, Me.colNomeAluno, Me.colDTNascAluno})
        Me.dgvAluno.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAluno.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAluno.EnableHeadersVisualStyles = False
        Me.dgvAluno.GridColor = System.Drawing.Color.Black
        Me.dgvAluno.Location = New System.Drawing.Point(4, 73)
        Me.dgvAluno.MultiSelect = False
        Me.dgvAluno.Name = "dgvAluno"
        Me.dgvAluno.ReadOnly = True
        Me.dgvAluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAluno.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAluno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAluno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAluno.ShowCellErrors = False
        Me.dgvAluno.ShowCellToolTips = False
        Me.dgvAluno.ShowEditingIcon = False
        Me.dgvAluno.ShowRowErrors = False
        Me.dgvAluno.Size = New System.Drawing.Size(367, 169)
        Me.dgvAluno.TabIndex = 0
        Me.dgvAluno.TabStop = False
        '
        'colIDaluno
        '
        Me.colIDaluno.DataPropertyName = "id_matricula"
        Me.colIDaluno.HeaderText = "COD"
        Me.colIDaluno.Name = "colIDaluno"
        Me.colIDaluno.ReadOnly = True
        Me.colIDaluno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colIDaluno.Width = 50
        '
        'colNomeAluno
        '
        Me.colNomeAluno.DataPropertyName = "nome_aluno"
        Me.colNomeAluno.HeaderText = "NOME"
        Me.colNomeAluno.Name = "colNomeAluno"
        Me.colNomeAluno.ReadOnly = True
        Me.colNomeAluno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colNomeAluno.Width = 151
        '
        'colDTNascAluno
        '
        Me.colDTNascAluno.DataPropertyName = "dt_nasc"
        Me.colDTNascAluno.HeaderText = "NASCIMENTO"
        Me.colDTNascAluno.Name = "colDTNascAluno"
        Me.colDTNascAluno.ReadOnly = True
        Me.colDTNascAluno.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDTNascAluno.Width = 123
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
        'frmConsAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 358)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAluno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOk As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCons As Button
    Private WithEvents dgvAluno As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents txtNome As TextBox
    Friend WithEvents ptbFechar As PictureBox
    Friend WithEvents colIDaluno As DataGridViewTextBoxColumn
    Friend WithEvents colNomeAluno As DataGridViewTextBoxColumn
    Friend WithEvents colDTNascAluno As DataGridViewTextBoxColumn
End Class
