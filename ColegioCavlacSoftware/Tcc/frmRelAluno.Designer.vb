<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelAluno
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelAluno))
        Me.Pr_AlunoTurmaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TCCDataSet = New Tcc.BD_TCCDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTurma = New System.Windows.Forms.Panel()
        Me.txtTurma = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ptbminimizar = New System.Windows.Forms.PictureBox()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.Pr_AlunoTurmaTableAdapter = New Tcc.BD_TCCDataSetTableAdapters.Pr_AlunoTurmaTableAdapter()
        Me.ToolRelAluno = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pr_AlunoTurmaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlTurma.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pr_AlunoTurmaBindingSource
        '
        Me.Pr_AlunoTurmaBindingSource.DataMember = "Pr_AlunoTurma"
        Me.Pr_AlunoTurmaBindingSource.DataSource = Me.BD_TCCDataSet
        '
        'BD_TCCDataSet
        '
        Me.BD_TCCDataSet.DataSetName = "BD_TCCDataSet"
        Me.BD_TCCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLimparTurma)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pnlTurma)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ptbminimizar)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Location = New System.Drawing.Point(8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 580)
        Me.Panel1.TabIndex = 0
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
        Me.btnLimparTurma.Location = New System.Drawing.Point(478, 45)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 8
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolRelAluno.SetToolTip(Me.btnLimparTurma, "Clique para limpar.")
        Me.btnLimparTurma.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(17, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1094, 476)
        Me.Panel2.TabIndex = 2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetAluno"
        ReportDataSource1.Value = Me.Pr_AlunoTurmaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tcc.ReportAluno.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 7)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1077, 461)
        Me.ReportViewer1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Turma:"
        '
        'pnlTurma
        '
        Me.pnlTurma.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.pnlTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTurma.Controls.Add(Me.txtTurma)
        Me.pnlTurma.Location = New System.Drawing.Point(25, 46)
        Me.pnlTurma.Name = "pnlTurma"
        Me.pnlTurma.Size = New System.Drawing.Size(216, 35)
        Me.pnlTurma.TabIndex = 0
        '
        'txtTurma
        '
        Me.txtTurma.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTurma.ForeColor = System.Drawing.Color.Black
        Me.txtTurma.Location = New System.Drawing.Point(2, 2)
        Me.txtTurma.MaxLength = 5
        Me.txtTurma.Name = "txtTurma"
        Me.txtTurma.Size = New System.Drawing.Size(209, 29)
        Me.txtTurma.TabIndex = 0
        Me.txtTurma.Text = "Digite a turma"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtAno)
        Me.Panel6.Location = New System.Drawing.Point(263, 46)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(197, 35)
        Me.Panel6.TabIndex = 1
        '
        'txtAno
        '
        Me.txtAno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAno.ForeColor = System.Drawing.Color.Black
        Me.txtAno.Location = New System.Drawing.Point(3, 2)
        Me.txtAno.MaxLength = 4
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(189, 29)
        Me.txtAno.TabIndex = 1
        Me.txtAno.Text = "Digite o ano"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(425, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(243, 24)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "CADASTRO DE ALUNOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(263, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Ano:"
        '
        'ptbminimizar
        '
        Me.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbminimizar.Image = Global.Tcc.My.Resources.Resources.round_delete_button
        Me.ptbminimizar.Location = New System.Drawing.Point(1062, 5)
        Me.ptbminimizar.Name = "ptbminimizar"
        Me.ptbminimizar.Size = New System.Drawing.Size(28, 26)
        Me.ptbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbminimizar.TabIndex = 16
        Me.ptbminimizar.TabStop = False
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(1096, 5)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 15
        Me.ptbfechar.TabStop = False
        '
        'Pr_AlunoTurmaTableAdapter
        '
        Me.Pr_AlunoTurmaTableAdapter.ClearBeforeFill = True
        '
        'frmRelAluno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1144, 595)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelAluno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Alunos"
        CType(Me.Pr_AlunoTurmaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pnlTurma.ResumeLayout(False)
        Me.pnlTurma.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ptbminimizar As System.Windows.Forms.PictureBox
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Friend WithEvents BD_TCCDataSet As Tcc.BD_TCCDataSet
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Pr_AlunoTurmaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pr_AlunoTurmaTableAdapter As Tcc.BD_TCCDataSetTableAdapters.Pr_AlunoTurmaTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTurma As System.Windows.Forms.Panel
    Friend WithEvents txtTurma As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLimparTurma As System.Windows.Forms.Button
    Friend WithEvents ToolRelAluno As System.Windows.Forms.ToolTip
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
