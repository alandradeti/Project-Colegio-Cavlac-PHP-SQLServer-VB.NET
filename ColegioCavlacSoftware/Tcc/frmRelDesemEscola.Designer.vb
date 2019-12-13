<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelDesemEscola
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelDesemEscola))
        Me.Pr_DesemEscolaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_TCCDataSet = New Tcc.BD_TCCDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLimparTurma = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbDisc = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ptbminimizar = New System.Windows.Forms.PictureBox()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBim = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pr_DesemEscolaTableAdapter = New Tcc.BD_TCCDataSetTableAdapters.Pr_DesemEscolaTableAdapter()
        Me.ToolDesemEscola = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pr_DesemEscolaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pr_DesemEscolaBindingSource
        '
        Me.Pr_DesemEscolaBindingSource.DataMember = "Pr_DesemEscola"
        Me.Pr_DesemEscolaBindingSource.DataSource = Me.BD_TCCDataSet
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
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ptbminimizar)
        Me.Panel1.Controls.Add(Me.ptbfechar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnCarregar)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 572)
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
        Me.btnLimparTurma.Location = New System.Drawing.Point(624, 72)
        Me.btnLimparTurma.Name = "btnLimparTurma"
        Me.btnLimparTurma.Size = New System.Drawing.Size(41, 39)
        Me.btnLimparTurma.TabIndex = 97
        Me.btnLimparTurma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDesemEscola.SetToolTip(Me.btnLimparTurma, "Clique para limpar.")
        Me.btnLimparTurma.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(231, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 19)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Disciplina:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cmbDisc)
        Me.Panel4.Location = New System.Drawing.Point(235, 73)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 35)
        Me.Panel4.TabIndex = 1
        '
        'cmbDisc
        '
        Me.cmbDisc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDisc.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbDisc.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmbDisc.FormattingEnabled = True
        Me.cmbDisc.Location = New System.Drawing.Point(3, 2)
        Me.cmbDisc.Name = "cmbDisc"
        Me.cmbDisc.Size = New System.Drawing.Size(152, 29)
        Me.cmbDisc.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Location = New System.Drawing.Point(7, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(891, 418)
        Me.Panel2.TabIndex = 4
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetDesemEscola"
        ReportDataSource1.Value = Me.Pr_DesemEscolaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tcc.ReportDesemEscola.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(877, 406)
        Me.ReportViewer1.TabIndex = 4
        '
        'ptbminimizar
        '
        Me.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbminimizar.Image = Global.Tcc.My.Resources.Resources.round_delete_button
        Me.ptbminimizar.Location = New System.Drawing.Point(841, 3)
        Me.ptbminimizar.Name = "ptbminimizar"
        Me.ptbminimizar.Size = New System.Drawing.Size(28, 26)
        Me.ptbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbminimizar.TabIndex = 93
        Me.ptbminimizar.TabStop = False
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(875, 3)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 92
        Me.ptbfechar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(301, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 23)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "DESEMPENHO DA ESCOLA"
        '
        'BtnCarregar
        '
        Me.BtnCarregar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnCarregar.FlatAppearance.BorderSize = 2
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCarregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BtnCarregar.Location = New System.Drawing.Point(709, 64)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(160, 53)
        Me.BtnCarregar.TabIndex = 3
        Me.BtnCarregar.Text = "CARREGAR..."
        Me.BtnCarregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolDesemEscola.SetToolTip(Me.BtnCarregar, "Clique para carregar relatório.")
        Me.BtnCarregar.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(440, 51)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(47, 19)
        Me.label3.TabIndex = 89
        Me.label3.Text = "Ano:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtAno)
        Me.Panel5.Location = New System.Drawing.Point(444, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(160, 35)
        Me.Panel5.TabIndex = 2
        '
        'txtAno
        '
        Me.txtAno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAno.ForeColor = System.Drawing.Color.Black
        Me.txtAno.Location = New System.Drawing.Point(3, 2)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(152, 29)
        Me.txtAno.TabIndex = 2
        Me.txtAno.Text = "Digite o ano"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cmbBim)
        Me.Panel3.Location = New System.Drawing.Point(26, 73)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 35)
        Me.Panel3.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "º Bimestre"
        '
        'cmbBim
        '
        Me.cmbBim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBim.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cmbBim.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.cmbBim.FormattingEnabled = True
        Me.cmbBim.Items.AddRange(New Object() {"---", "1", "2", "3", "4"})
        Me.cmbBim.Location = New System.Drawing.Point(3, 2)
        Me.cmbBim.Name = "cmbBim"
        Me.cmbBim.Size = New System.Drawing.Size(50, 29)
        Me.cmbBim.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Bimestre:"
        '
        'Pr_DesemEscolaTableAdapter
        '
        Me.Pr_DesemEscolaTableAdapter.ClearBeforeFill = True
        '
        'frmRelDesemEscola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelDesemEscola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desempenho da Escola"
        CType(Me.Pr_DesemEscolaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_TCCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ptbminimizar As System.Windows.Forms.PictureBox
    Friend WithEvents ptbfechar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnCarregar As System.Windows.Forms.Button
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbBim As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Pr_DesemEscolaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BD_TCCDataSet As Tcc.BD_TCCDataSet
    Friend WithEvents Pr_DesemEscolaTableAdapter As Tcc.BD_TCCDataSetTableAdapters.Pr_DesemEscolaTableAdapter
    Friend WithEvents btnLimparTurma As System.Windows.Forms.Button
    Friend WithEvents ToolDesemEscola As System.Windows.Forms.ToolTip
    Friend WithEvents cmbDisc As System.Windows.Forms.ComboBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
