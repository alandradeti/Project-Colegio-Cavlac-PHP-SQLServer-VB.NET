<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelObs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelObs))
        Me.Pr_ObsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TCCDataSet = New Tcc.BD_TCCDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.btnConsAluno = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDataI = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataF = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtRA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbminimizar = New System.Windows.Forms.PictureBox()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.Pr_ObsTableAdapter = New Tcc.BD_TCCDataSetTableAdapters.Pr_ObsTableAdapter()
        Me.ToolRelObs = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pr_ObsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pr_ObsBindingSource
        '
        Me.Pr_ObsBindingSource.DataMember = "Pr_Obs"
        Me.Pr_ObsBindingSource.DataSource = Me.BD_TCCDataSet
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
        Me.Panel1.Controls.Add(Me.btnConsAluno)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ptbminimizar)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 500)
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
        Me.btnLimparTurma.Location = New System.Drawing.Point(190, 30)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 97
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolRelObs.SetToolTip(Me.btnLimparTurma, "Clique para limpar.")
        Me.btnLimparTurma.UseVisualStyleBackColor = False
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
        Me.btnConsAluno.Location = New System.Drawing.Point(143, 33)
        Me.btnConsAluno.Name = "btnConsAluno"
        Me.btnConsAluno.Size = New System.Drawing.Size(41, 32)
        Me.btnConsAluno.TabIndex = 1
        Me.btnConsAluno.Text = "..."
        Me.btnConsAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConsAluno.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Nome:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtNome)
        Me.Panel4.Location = New System.Drawing.Point(24, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(237, 35)
        Me.Panel4.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNome.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.txtNome.Location = New System.Drawing.Point(3, 2)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(229, 29)
        Me.txtNome.TabIndex = 2
        Me.txtNome.Text = "Digite o nome"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Location = New System.Drawing.Point(16, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(695, 350)
        Me.Panel3.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetObs"
        ReportDataSource1.Value = Me.Pr_ObsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tcc.ReportObs.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(681, 336)
        Me.ReportViewer1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(304, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "DATA:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtDataI)
        Me.Panel2.Controls.Add(Me.txtDataF)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(308, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(299, 35)
        Me.Panel2.TabIndex = 3
        '
        'txtDataI
        '
        Me.txtDataI.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDataI.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.txtDataI.Location = New System.Drawing.Point(40, 2)
        Me.txtDataI.Mask = "00/00/0000"
        Me.txtDataI.Name = "txtDataI"
        Me.txtDataI.Size = New System.Drawing.Size(100, 29)
        Me.txtDataI.TabIndex = 3
        Me.txtDataI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataI.ValidatingType = GetType(Date)
        '
        'txtDataF
        '
        Me.txtDataF.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtDataF.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.txtDataF.Location = New System.Drawing.Point(194, 2)
        Me.txtDataF.Mask = "00/00/0000"
        Me.txtDataF.Name = "txtDataF"
        Me.txtDataF.Size = New System.Drawing.Size(100, 29)
        Me.txtDataF.TabIndex = 4
        Me.txtDataF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDataF.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(146, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "ATÉ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 19)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "DE"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtRA)
        Me.Panel6.Location = New System.Drawing.Point(24, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(113, 35)
        Me.Panel6.TabIndex = 0
        '
        'txtRA
        '
        Me.txtRA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtRA.ForeColor = System.Drawing.Color.Black
        Me.txtRA.Location = New System.Drawing.Point(3, 2)
        Me.txtRA.MaxLength = 4
        Me.txtRA.Name = "txtRA"
        Me.txtRA.Size = New System.Drawing.Size(105, 29)
        Me.txtRA.TabIndex = 0
        Me.txtRA.Text = "Digite o RA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "RA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(251, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(186, 27)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "OBSERVAÇÕES:"
        '
        'ptbminimizar
        '
        Me.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbminimizar.Image = Global.Tcc.My.Resources.Resources.round_delete_button
        Me.ptbminimizar.Location = New System.Drawing.Point(661, 3)
        Me.ptbminimizar.Name = "ptbminimizar"
        Me.ptbminimizar.Size = New System.Drawing.Size(28, 26)
        Me.ptbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbminimizar.TabIndex = 20
        Me.ptbminimizar.TabStop = False
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(695, 3)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 19
        Me.ptbfechar.TabStop = False
        '
        'Pr_ObsTableAdapter
        '
        Me.Pr_ObsTableAdapter.ClearBeforeFill = True
        '
        'frmRelObs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 514)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelObs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obsercações"
        CType(Me.Pr_ObsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ptbminimizar As System.Windows.Forms.PictureBox
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Friend WithEvents txtRA As System.Windows.Forms.TextBox
    Friend WithEvents Pr_ObsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BD_TCCDataSet As Tcc.BD_TCCDataSet
    Friend WithEvents Pr_ObsTableAdapter As Tcc.BD_TCCDataSetTableAdapters.Pr_ObsTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataI As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDataF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnConsAluno As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnLimparTurma As System.Windows.Forms.Button
    Friend WithEvents ToolRelObs As System.Windows.Forms.ToolTip
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
