<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObs))
        Me.ToolNovo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ToolAlterar = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtNotificacao = New System.Windows.Forms.TextBox()
        Me.ptbFechar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.mtbData = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel20.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnOk.Location = New System.Drawing.Point(143, 298)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(105, 92)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolNovo.SetToolTip(Me.btnOk, "Clique para Gravar.")
        Me.ToolAlterar.SetToolTip(Me.btnOk, "Clique para Alterar.")
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'ToolAlterar
        '
        Me.ToolAlterar.Active = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ptbFechar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel20)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 398)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtNotificacao)
        Me.Panel2.Location = New System.Drawing.Point(3, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 176)
        Me.Panel2.TabIndex = 1
        '
        'txtNotificacao
        '
        Me.txtNotificacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotificacao.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNotificacao.Location = New System.Drawing.Point(3, 3)
        Me.txtNotificacao.Multiline = True
        Me.txtNotificacao.Name = "txtNotificacao"
        Me.txtNotificacao.Size = New System.Drawing.Size(375, 168)
        Me.txtNotificacao.TabIndex = 1
        '
        'ptbFechar
        '
        Me.ptbFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ptbFechar.Image = Global.Tcc.My.Resources.Resources.close_cross_circular_interface_button
        Me.ptbFechar.Location = New System.Drawing.Point(359, 3)
        Me.ptbFechar.Name = "ptbFechar"
        Me.ptbFechar.Size = New System.Drawing.Size(28, 26)
        Me.ptbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbFechar.TabIndex = 32
        Me.ptbFechar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(119, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NOTIFICAÇÃO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(7, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Notificação:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(7, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Data:"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.lblAno)
        Me.Panel20.Controls.Add(Me.mtbData)
        Me.Panel20.Location = New System.Drawing.Point(7, 48)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(125, 35)
        Me.Panel20.TabIndex = 0
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAno.ForeColor = System.Drawing.Color.White
        Me.lblAno.Location = New System.Drawing.Point(74, 5)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(46, 21)
        Me.lblAno.TabIndex = 1
        Me.lblAno.Text = "0000"
        '
        'mtbData
        '
        Me.mtbData.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mtbData.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.mtbData.Location = New System.Drawing.Point(2, 2)
        Me.mtbData.Mask = "00/00/"
        Me.mtbData.Name = "mtbData"
        Me.mtbData.Size = New System.Drawing.Size(66, 29)
        Me.mtbData.TabIndex = 0
        Me.mtbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmObs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 406)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmObs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Notificações"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ptbFechar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolNovo As System.Windows.Forms.ToolTip
    Friend WithEvents ToolAlterar As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNotificacao As System.Windows.Forms.TextBox
    Friend WithEvents ptbFechar As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents mtbData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblAno As Label
End Class
