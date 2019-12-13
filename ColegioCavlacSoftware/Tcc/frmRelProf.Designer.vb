<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelProf))
        Me.Pr_ProfessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TCCDataSet = New Tcc.BD_TCCDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtProf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ptbminimizar = New System.Windows.Forms.PictureBox()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.Pr_ProfessorTableAdapter = New Tcc.BD_TCCDataSetTableAdapters.Pr_ProfessorTableAdapter()
        Me.ToolRelProf = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pr_ProfessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pr_ProfessorBindingSource
        '
        Me.Pr_ProfessorBindingSource.DataMember = "Pr_Professor"
        Me.Pr_ProfessorBindingSource.DataSource = Me.BD_TCCDataSet
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
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ptbminimizar)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 458)
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
        Me.btnLimparTurma.Location = New System.Drawing.Point(345, 53)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 80
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolRelProf.SetToolTip(Me.btnLimparTurma, "Clique para limpar.")
        Me.btnLimparTurma.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Location = New System.Drawing.Point(12, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(938, 334)
        Me.Panel3.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetProf"
        ReportDataSource1.Value = Me.Pr_ProfessorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tcc.ReportProf.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 7)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(923, 320)
        Me.ReportViewer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtProf)
        Me.Panel2.Location = New System.Drawing.Point(12, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 35)
        Me.Panel2.TabIndex = 0
        '
        'txtProf
        '
        Me.txtProf.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtProf.ForeColor = System.Drawing.Color.Black
        Me.txtProf.Location = New System.Drawing.Point(3, 2)
        Me.txtProf.MaxLength = 500
        Me.txtProf.Name = "txtProf"
        Me.txtProf.Size = New System.Drawing.Size(319, 29)
        Me.txtProf.TabIndex = 0
        Me.txtProf.Text = "Digite o nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 19)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Professor:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(328, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(308, 24)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "CADASTRO DE PROFESSORES"
        '
        'ptbminimizar
        '
        Me.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbminimizar.Image = Global.Tcc.My.Resources.Resources.round_delete_button
        Me.ptbminimizar.Location = New System.Drawing.Point(896, 3)
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
        Me.ptbfechar.Location = New System.Drawing.Point(930, 3)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 15
        Me.ptbfechar.TabStop = False
        '
        'Pr_ProfessorTableAdapter
        '
        Me.Pr_ProfessorTableAdapter.ClearBeforeFill = True
        '
        'frmRelProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 471)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Professores"
        CType(Me.Pr_ProfessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ptbminimizar As System.Windows.Forms.PictureBox
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Friend WithEvents BD_TCCDataSet As Tcc.BD_TCCDataSet
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtProf As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pr_ProfessorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pr_ProfessorTableAdapter As Tcc.BD_TCCDataSetTableAdapters.Pr_ProfessorTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnLimparTurma As System.Windows.Forms.Button
    Friend WithEvents ToolRelProf As System.Windows.Forms.ToolTip
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
