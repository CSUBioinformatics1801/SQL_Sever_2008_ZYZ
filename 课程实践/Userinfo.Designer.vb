<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Userinfo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Userinfo))
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxoldpw = New System.Windows.Forms.TextBox()
        Me.Lableoldpw = New System.Windows.Forms.Label()
        Me.Labelnewpw = New System.Windows.Forms.Label()
        Me.LabelCknewpw = New System.Windows.Forms.Label()
        Me.TextBoxnewpw = New System.Windows.Forms.TextBox()
        Me.TextBoxcknewpw = New System.Windows.Forms.TextBox()
        Me.Labelusernameexist = New System.Windows.Forms.Label()
        Me.GroupBoxNewPW = New System.Windows.Forms.GroupBox()
        Me.PictureBoxback = New System.Windows.Forms.PictureBox()
        Me.LabelUserIDable = New System.Windows.Forms.Label()
        Me.LabelPWempty = New System.Windows.Forms.Label()
        Me.LabelPWDFT = New System.Windows.Forms.Label()
        Me.PictureBoxupdate = New System.Windows.Forms.PictureBox()
        Me.PictureBoxlogout = New System.Windows.Forms.PictureBox()
        Me.GroupBoxNewPW.SuspendLayout()
        CType(Me.PictureBoxback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxlogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUsername.Location = New System.Drawing.Point(86, 58)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(81, 17)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(182, 55)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxUsername.TabIndex = 1
        '
        'TextBoxoldpw
        '
        Me.TextBoxoldpw.Location = New System.Drawing.Point(182, 103)
        Me.TextBoxoldpw.Name = "TextBoxoldpw"
        Me.TextBoxoldpw.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxoldpw.TabIndex = 2
        Me.TextBoxoldpw.UseSystemPasswordChar = True
        '
        'Lableoldpw
        '
        Me.Lableoldpw.AutoSize = True
        Me.Lableoldpw.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lableoldpw.Location = New System.Drawing.Point(93, 104)
        Me.Lableoldpw.Name = "Lableoldpw"
        Me.Lableoldpw.Size = New System.Drawing.Size(62, 17)
        Me.Lableoldpw.TabIndex = 3
        Me.Lableoldpw.Text = "Old PW"
        '
        'Labelnewpw
        '
        Me.Labelnewpw.AutoSize = True
        Me.Labelnewpw.Location = New System.Drawing.Point(33, 35)
        Me.Labelnewpw.Name = "Labelnewpw"
        Me.Labelnewpw.Size = New System.Drawing.Size(69, 17)
        Me.Labelnewpw.TabIndex = 4
        Me.Labelnewpw.Text = "New PW"
        '
        'LabelCknewpw
        '
        Me.LabelCknewpw.AutoSize = True
        Me.LabelCknewpw.Location = New System.Drawing.Point(1, 84)
        Me.LabelCknewpw.Name = "LabelCknewpw"
        Me.LabelCknewpw.Size = New System.Drawing.Size(117, 17)
        Me.LabelCknewpw.TabIndex = 5
        Me.LabelCknewpw.Text = "Check New PW"
        '
        'TextBoxnewpw
        '
        Me.TextBoxnewpw.Location = New System.Drawing.Point(129, 32)
        Me.TextBoxnewpw.Name = "TextBoxnewpw"
        Me.TextBoxnewpw.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxnewpw.TabIndex = 6
        Me.TextBoxnewpw.UseSystemPasswordChar = True
        '
        'TextBoxcknewpw
        '
        Me.TextBoxcknewpw.Location = New System.Drawing.Point(129, 81)
        Me.TextBoxcknewpw.Name = "TextBoxcknewpw"
        Me.TextBoxcknewpw.Size = New System.Drawing.Size(100, 24)
        Me.TextBoxcknewpw.TabIndex = 7
        Me.TextBoxcknewpw.UseSystemPasswordChar = True
        '
        'Labelusernameexist
        '
        Me.Labelusernameexist.AutoSize = True
        Me.Labelusernameexist.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labelusernameexist.ForeColor = System.Drawing.Color.Red
        Me.Labelusernameexist.Location = New System.Drawing.Point(285, 59)
        Me.Labelusernameexist.Name = "Labelusernameexist"
        Me.Labelusernameexist.Size = New System.Drawing.Size(111, 14)
        Me.Labelusernameexist.TabIndex = 9
        Me.Labelusernameexist.Text = "*新用户名已存在"
        Me.Labelusernameexist.Visible = False
        '
        'GroupBoxNewPW
        '
        Me.GroupBoxNewPW.Controls.Add(Me.TextBoxnewpw)
        Me.GroupBoxNewPW.Controls.Add(Me.Labelnewpw)
        Me.GroupBoxNewPW.Controls.Add(Me.LabelCknewpw)
        Me.GroupBoxNewPW.Controls.Add(Me.TextBoxcknewpw)
        Me.GroupBoxNewPW.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBoxNewPW.Location = New System.Drawing.Point(53, 146)
        Me.GroupBoxNewPW.Name = "GroupBoxNewPW"
        Me.GroupBoxNewPW.Size = New System.Drawing.Size(229, 124)
        Me.GroupBoxNewPW.TabIndex = 10
        Me.GroupBoxNewPW.TabStop = False
        Me.GroupBoxNewPW.Text = "New PW"
        '
        'PictureBoxback
        '
        Me.PictureBoxback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxback.Image = CType(resources.GetObject("PictureBoxback.Image"), System.Drawing.Image)
        Me.PictureBoxback.Location = New System.Drawing.Point(255, 284)
        Me.PictureBoxback.Name = "PictureBoxback"
        Me.PictureBoxback.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxback.TabIndex = 18
        Me.PictureBoxback.TabStop = False
        '
        'LabelUserIDable
        '
        Me.LabelUserIDable.AutoSize = True
        Me.LabelUserIDable.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserIDable.ForeColor = System.Drawing.Color.Green
        Me.LabelUserIDable.Location = New System.Drawing.Point(288, 58)
        Me.LabelUserIDable.Name = "LabelUserIDable"
        Me.LabelUserIDable.Size = New System.Drawing.Size(131, 19)
        Me.LabelUserIDable.TabIndex = 19
        Me.LabelUserIDable.Text = "*新用户名可用"
        Me.LabelUserIDable.Visible = False
        '
        'LabelPWempty
        '
        Me.LabelPWempty.AutoSize = True
        Me.LabelPWempty.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPWempty.ForeColor = System.Drawing.Color.Red
        Me.LabelPWempty.Location = New System.Drawing.Point(292, 178)
        Me.LabelPWempty.Name = "LabelPWempty"
        Me.LabelPWempty.Size = New System.Drawing.Size(127, 17)
        Me.LabelPWempty.TabIndex = 20
        Me.LabelPWempty.Text = "*密码不能为空值"
        Me.LabelPWempty.Visible = False
        '
        'LabelPWDFT
        '
        Me.LabelPWDFT.AutoSize = True
        Me.LabelPWDFT.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPWDFT.ForeColor = System.Drawing.Color.Red
        Me.LabelPWDFT.Location = New System.Drawing.Point(292, 230)
        Me.LabelPWDFT.Name = "LabelPWDFT"
        Me.LabelPWDFT.Size = New System.Drawing.Size(127, 17)
        Me.LabelPWDFT.TabIndex = 21
        Me.LabelPWDFT.Text = "*两次密码不一致"
        Me.LabelPWDFT.Visible = False
        '
        'PictureBoxupdate
        '
        Me.PictureBoxupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxupdate.Image = CType(resources.GetObject("PictureBoxupdate.Image"), System.Drawing.Image)
        Me.PictureBoxupdate.Location = New System.Drawing.Point(139, 284)
        Me.PictureBoxupdate.Name = "PictureBoxupdate"
        Me.PictureBoxupdate.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxupdate.TabIndex = 28
        Me.PictureBoxupdate.TabStop = False
        '
        'PictureBoxlogout
        '
        Me.PictureBoxlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxlogout.Image = CType(resources.GetObject("PictureBoxlogout.Image"), System.Drawing.Image)
        Me.PictureBoxlogout.Location = New System.Drawing.Point(197, 284)
        Me.PictureBoxlogout.Name = "PictureBoxlogout"
        Me.PictureBoxlogout.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxlogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxlogout.TabIndex = 29
        Me.PictureBoxlogout.TabStop = False
        '
        'Userinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 361)
        Me.Controls.Add(Me.PictureBoxlogout)
        Me.Controls.Add(Me.PictureBoxupdate)
        Me.Controls.Add(Me.LabelPWDFT)
        Me.Controls.Add(Me.LabelPWempty)
        Me.Controls.Add(Me.LabelUserIDable)
        Me.Controls.Add(Me.PictureBoxback)
        Me.Controls.Add(Me.GroupBoxNewPW)
        Me.Controls.Add(Me.Labelusernameexist)
        Me.Controls.Add(Me.Lableoldpw)
        Me.Controls.Add(Me.TextBoxoldpw)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.LabelUsername)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Userinfo"
        Me.Text = "Userinfo"
        Me.GroupBoxNewPW.ResumeLayout(False)
        Me.GroupBoxNewPW.PerformLayout()
        CType(Me.PictureBoxback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxlogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxoldpw As TextBox
    Friend WithEvents Lableoldpw As Label
    Friend WithEvents Labelnewpw As Label
    Friend WithEvents LabelCknewpw As Label
    Friend WithEvents TextBoxnewpw As TextBox
    Friend WithEvents TextBoxcknewpw As TextBox
    Friend WithEvents Labelusernameexist As Label
    Friend WithEvents GroupBoxNewPW As GroupBox
    Friend WithEvents PictureBoxback As PictureBox
    Friend WithEvents LabelUserIDable As Label
    Friend WithEvents LabelPWempty As Label
    Friend WithEvents LabelPWDFT As Label
    Friend WithEvents PictureBoxupdate As PictureBox
    Friend WithEvents PictureBoxlogout As PictureBox
End Class
