<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PnlHome = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MnsPrincipal = New System.Windows.Forms.MenuStrip()
        Me.TSMICadastros = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIAlunosCadastros = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIProfessores = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMITurmas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIDisciplinas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIAlunos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIObs = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMINotas = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIREL = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastraisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelTurma = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalíticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelBoletim = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelObs = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelNota = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelDesemEscola = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelDesemTurma = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelDesemAluno = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMIRelDesemProf = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.ptbminimizar = New System.Windows.Forms.PictureBox()
        Me.ptbfechar = New System.Windows.Forms.PictureBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.prbMinimize = New System.Windows.Forms.PictureBox()
        Me.PrbClose = New System.Windows.Forms.PictureBox()
        Me.PnlHome.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnsPrincipal.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHome
        '
        Me.PnlHome.BackColor = System.Drawing.Color.White
        Me.PnlHome.Controls.Add(Me.PictureBox1)
        Me.PnlHome.Controls.Add(Me.MnsPrincipal)
        Me.PnlHome.Location = New System.Drawing.Point(5, 39)
        Me.PnlHome.Name = "PnlHome"
        Me.PnlHome.Size = New System.Drawing.Size(765, 586)
        Me.PnlHome.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tcc.My.Resources.Resources.asd
        Me.PictureBox1.Location = New System.Drawing.Point(225, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 112)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MnsPrincipal
        '
        Me.MnsPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.MnsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMICadastros, Me.TSMIAlunos, Me.TSMINotas, Me.TSMIREL})
        Me.MnsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnsPrincipal.Name = "MnsPrincipal"
        Me.MnsPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MnsPrincipal.Size = New System.Drawing.Size(765, 33)
        Me.MnsPrincipal.TabIndex = 1
        Me.MnsPrincipal.Text = "MenuStrip1"
        '
        'TSMICadastros
        '
        Me.TSMICadastros.BackColor = System.Drawing.Color.Transparent
        Me.TSMICadastros.Checked = True
        Me.TSMICadastros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSMICadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TSMIAlunosCadastros, Me.TSMIProfessores, Me.TSMITurmas, Me.TSMIDisciplinas, Me.TSMIUsuarios})
        Me.TSMICadastros.Enabled = False
        Me.TSMICadastros.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMICadastros.ForeColor = System.Drawing.Color.White
        Me.TSMICadastros.Name = "TSMICadastros"
        Me.TSMICadastros.Padding = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.TSMICadastros.Size = New System.Drawing.Size(102, 29)
        Me.TSMICadastros.Text = "Cadastros"
        Me.TSMICadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 24)
        Me.ToolStripMenuItem1.Text = "Usuarios"
        '
        'TSMIAlunosCadastros
        '
        Me.TSMIAlunosCadastros.BackColor = System.Drawing.Color.Transparent
        Me.TSMIAlunosCadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TSMIAlunosCadastros.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIAlunosCadastros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIAlunosCadastros.Name = "TSMIAlunosCadastros"
        Me.TSMIAlunosCadastros.Size = New System.Drawing.Size(173, 24)
        Me.TSMIAlunosCadastros.Text = "Alunos"
        '
        'TSMIProfessores
        '
        Me.TSMIProfessores.BackColor = System.Drawing.Color.Transparent
        Me.TSMIProfessores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TSMIProfessores.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIProfessores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIProfessores.Name = "TSMIProfessores"
        Me.TSMIProfessores.Size = New System.Drawing.Size(173, 24)
        Me.TSMIProfessores.Text = "Professores"
        '
        'TSMITurmas
        '
        Me.TSMITurmas.BackColor = System.Drawing.Color.Transparent
        Me.TSMITurmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TSMITurmas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMITurmas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMITurmas.Name = "TSMITurmas"
        Me.TSMITurmas.Size = New System.Drawing.Size(173, 24)
        Me.TSMITurmas.Text = "Turmas"
        '
        'TSMIDisciplinas
        '
        Me.TSMIDisciplinas.BackColor = System.Drawing.Color.Transparent
        Me.TSMIDisciplinas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TSMIDisciplinas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIDisciplinas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIDisciplinas.Name = "TSMIDisciplinas"
        Me.TSMIDisciplinas.Size = New System.Drawing.Size(173, 24)
        Me.TSMIDisciplinas.Text = "Disciplinas"
        '
        'TSMIUsuarios
        '
        Me.TSMIUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.TSMIUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TSMIUsuarios.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIUsuarios.Name = "TSMIUsuarios"
        Me.TSMIUsuarios.Size = New System.Drawing.Size(173, 24)
        Me.TSMIUsuarios.Text = "Telefones"
        '
        'TSMIAlunos
        '
        Me.TSMIAlunos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIObs})
        Me.TSMIAlunos.Enabled = False
        Me.TSMIAlunos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMIAlunos.ForeColor = System.Drawing.Color.White
        Me.TSMIAlunos.Name = "TSMIAlunos"
        Me.TSMIAlunos.Padding = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.TSMIAlunos.Size = New System.Drawing.Size(76, 29)
        Me.TSMIAlunos.Text = "Alunos"
        Me.TSMIAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSMIObs
        '
        Me.TSMIObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIObs.Name = "TSMIObs"
        Me.TSMIObs.Size = New System.Drawing.Size(180, 24)
        Me.TSMIObs.Text = "Observações"
        '
        'TSMINotas
        '
        Me.TSMINotas.Enabled = False
        Me.TSMINotas.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSMINotas.ForeColor = System.Drawing.Color.White
        Me.TSMINotas.Name = "TSMINotas"
        Me.TSMINotas.Padding = New System.Windows.Forms.Padding(4, 6, 4, 0)
        Me.TSMINotas.Size = New System.Drawing.Size(68, 29)
        Me.TSMINotas.Text = "Notas"
        Me.TSMINotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSMIREL
        '
        Me.TSMIREL.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastraisToolStripMenuItem, Me.AnalíticosToolStripMenuItem})
        Me.TSMIREL.Enabled = False
        Me.TSMIREL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TSMIREL.ForeColor = System.Drawing.Color.White
        Me.TSMIREL.Name = "TSMIREL"
        Me.TSMIREL.Size = New System.Drawing.Size(105, 29)
        Me.TSMIREL.Text = "Relatórios"
        '
        'CadastraisToolStripMenuItem
        '
        Me.CadastraisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIRelProf, Me.TSMIRelAluno, Me.TSMIRelTurma, Me.DisciplinasToolStripMenuItem})
        Me.CadastraisToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.CadastraisToolStripMenuItem.Name = "CadastraisToolStripMenuItem"
        Me.CadastraisToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.CadastraisToolStripMenuItem.Text = "Cadastrais"
        '
        'TSMIRelProf
        '
        Me.TSMIRelProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelProf.Name = "TSMIRelProf"
        Me.TSMIRelProf.Size = New System.Drawing.Size(173, 24)
        Me.TSMIRelProf.Text = "Professores"
        '
        'TSMIRelAluno
        '
        Me.TSMIRelAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelAluno.Name = "TSMIRelAluno"
        Me.TSMIRelAluno.Size = New System.Drawing.Size(173, 24)
        Me.TSMIRelAluno.Text = "Alunos"
        '
        'TSMIRelTurma
        '
        Me.TSMIRelTurma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelTurma.Name = "TSMIRelTurma"
        Me.TSMIRelTurma.Size = New System.Drawing.Size(173, 24)
        Me.TSMIRelTurma.Text = "Turmas"
        '
        'DisciplinasToolStripMenuItem
        '
        Me.DisciplinasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DisciplinasToolStripMenuItem.Name = "DisciplinasToolStripMenuItem"
        Me.DisciplinasToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.DisciplinasToolStripMenuItem.Text = "Disciplinas"
        '
        'AnalíticosToolStripMenuItem
        '
        Me.AnalíticosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIRelBoletim, Me.TSMIRelObs, Me.TSMIRelNota})
        Me.AnalíticosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.AnalíticosToolStripMenuItem.Name = "AnalíticosToolStripMenuItem"
        Me.AnalíticosToolStripMenuItem.Size = New System.Drawing.Size(164, 24)
        Me.AnalíticosToolStripMenuItem.Text = "Analíticos"
        '
        'TSMIRelBoletim
        '
        Me.TSMIRelBoletim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelBoletim.Name = "TSMIRelBoletim"
        Me.TSMIRelBoletim.Size = New System.Drawing.Size(183, 24)
        Me.TSMIRelBoletim.Text = "Boletim"
        '
        'TSMIRelObs
        '
        Me.TSMIRelObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelObs.Name = "TSMIRelObs"
        Me.TSMIRelObs.Size = New System.Drawing.Size(183, 24)
        Me.TSMIRelObs.Text = "Observações"
        '
        'TSMIRelNota
        '
        Me.TSMIRelNota.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMIRelDesemEscola, Me.TSMIRelDesemTurma, Me.TSMIRelDesemAluno, Me.TSMIRelDesemProf})
        Me.TSMIRelNota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelNota.Name = "TSMIRelNota"
        Me.TSMIRelNota.Size = New System.Drawing.Size(183, 24)
        Me.TSMIRelNota.Text = "Desempenho"
        '
        'TSMIRelDesemEscola
        '
        Me.TSMIRelDesemEscola.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelDesemEscola.Name = "TSMIRelDesemEscola"
        Me.TSMIRelDesemEscola.Size = New System.Drawing.Size(155, 24)
        Me.TSMIRelDesemEscola.Text = "Escola"
        '
        'TSMIRelDesemTurma
        '
        Me.TSMIRelDesemTurma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelDesemTurma.Name = "TSMIRelDesemTurma"
        Me.TSMIRelDesemTurma.Size = New System.Drawing.Size(155, 24)
        Me.TSMIRelDesemTurma.Text = "Turma"
        '
        'TSMIRelDesemAluno
        '
        Me.TSMIRelDesemAluno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelDesemAluno.Name = "TSMIRelDesemAluno"
        Me.TSMIRelDesemAluno.Size = New System.Drawing.Size(155, 24)
        Me.TSMIRelDesemAluno.Text = "Aluno"
        '
        'TSMIRelDesemProf
        '
        Me.TSMIRelDesemProf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.TSMIRelDesemProf.Name = "TSMIRelDesemProf"
        Me.TSMIRelDesemProf.Size = New System.Drawing.Size(155, 24)
        Me.TSMIRelDesemProf.Text = "Professor"
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.White
        Me.PnlMenu.Controls.Add(Me.ptbminimizar)
        Me.PnlMenu.Controls.Add(Me.ptbfechar)
        Me.PnlMenu.Controls.Add(Me.lblMenu)
        Me.PnlMenu.Controls.Add(Me.prbMinimize)
        Me.PnlMenu.Controls.Add(Me.PrbClose)
        Me.PnlMenu.Location = New System.Drawing.Point(5, 5)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(765, 29)
        Me.PnlMenu.TabIndex = 0
        '
        'ptbminimizar
        '
        Me.ptbminimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbminimizar.Image = Global.Tcc.My.Resources.Resources.round_delete_button
        Me.ptbminimizar.Location = New System.Drawing.Point(696, 1)
        Me.ptbminimizar.Name = "ptbminimizar"
        Me.ptbminimizar.Size = New System.Drawing.Size(28, 26)
        Me.ptbminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbminimizar.TabIndex = 4
        Me.ptbminimizar.TabStop = False
        '
        'ptbfechar
        '
        Me.ptbfechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbfechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbfechar.Location = New System.Drawing.Point(730, 1)
        Me.ptbfechar.Name = "ptbfechar"
        Me.ptbfechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbfechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbfechar.TabIndex = 1
        Me.ptbfechar.TabStop = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblMenu.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(12, 4)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(101, 19)
        Me.lblMenu.TabIndex = 1
        Me.lblMenu.Text = "PRINCIPAL"
        '
        'prbMinimize
        '
        Me.prbMinimize.Location = New System.Drawing.Point(0, 0)
        Me.prbMinimize.Name = "prbMinimize"
        Me.prbMinimize.Size = New System.Drawing.Size(100, 50)
        Me.prbMinimize.TabIndex = 2
        Me.prbMinimize.TabStop = False
        '
        'PrbClose
        '
        Me.PrbClose.Location = New System.Drawing.Point(0, 0)
        Me.PrbClose.Name = "PrbClose"
        Me.PrbClose.Size = New System.Drawing.Size(100, 50)
        Me.PrbClose.TabIndex = 3
        Me.PrbClose.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(775, 630)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.PnlHome)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MnsPrincipal
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.PnlHome.ResumeLayout(False)
        Me.PnlHome.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnsPrincipal.ResumeLayout(False)
        Me.MnsPrincipal.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        Me.PnlMenu.PerformLayout()
        CType(Me.ptbminimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbfechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHome As Panel
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents MnsPrincipal As MenuStrip
    Friend WithEvents TSMICadastros As ToolStripMenuItem
    Friend WithEvents TSMIUsuarios As ToolStripMenuItem
    Friend WithEvents TSMIAlunos As ToolStripMenuItem
    Friend WithEvents TSMIObs As ToolStripMenuItem
    Friend WithEvents PrbClose As System.Windows.Forms.PictureBox
    Friend WithEvents TSMINotas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents prbMinimize As PictureBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents ptbminimizar As PictureBox
    Friend WithEvents ptbfechar As PictureBox
    Friend WithEvents TSMIAlunosCadastros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIProfessores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIDisciplinas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMITurmas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIREL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastraisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelProf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelTurma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalíticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisciplinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelBoletim As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelObs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelNota As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelDesemEscola As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelDesemTurma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelDesemAluno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMIRelDesemProf As System.Windows.Forms.ToolStripMenuItem
End Class
