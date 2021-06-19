<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LabelUserID = New System.Windows.Forms.Label()
        Me.LabelPW = New System.Windows.Forms.Label()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.TextBoxIvCode = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxREAFPW = New System.Windows.Forms.TextBox()
        Me.LabelUserIDExisted = New System.Windows.Forms.Label()
        Me.LabelUserIDable = New System.Windows.Forms.Label()
        Me.LabelPWDFT = New System.Windows.Forms.Label()
        Me.LabelPWempty = New System.Windows.Forms.Label()
        Me.LabelPWestimate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please send an asking E-mail to the Administrator's mail box :"
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxUserID.Location = New System.Drawing.Point(177, 135)
        Me.TextBoxUserID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(301, 22)
        Me.TextBoxUserID.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(187, 62)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(189, 19)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "1127113989@qq.cpm"
        '
        'LabelUserID
        '
        Me.LabelUserID.AutoSize = True
        Me.LabelUserID.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserID.Location = New System.Drawing.Point(63, 140)
        Me.LabelUserID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUserID.Name = "LabelUserID"
        Me.LabelUserID.Size = New System.Drawing.Size(98, 17)
        Me.LabelUserID.TabIndex = 4
        Me.LabelUserID.Text = "New User ID"
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPW.Location = New System.Drawing.Point(47, 181)
        Me.LabelPW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(114, 17)
        Me.LabelPW.TabIndex = 5
        Me.LabelPW.Text = "New Password"
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxPW.Location = New System.Drawing.Point(177, 181)
        Me.TextBoxPW.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBoxPW.Size = New System.Drawing.Size(301, 22)
        Me.TextBoxPW.TabIndex = 6
        Me.TextBoxPW.UseSystemPasswordChar = True
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label.Location = New System.Drawing.Point(34, 276)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(120, 17)
        Me.Label.TabIndex = 7
        Me.Label.Text = "Invitation Code"
        '
        'TextBoxIvCode
        '
        Me.TextBoxIvCode.Location = New System.Drawing.Point(177, 276)
        Me.TextBoxIvCode.Name = "TextBoxIvCode"
        Me.TextBoxIvCode.Size = New System.Drawing.Size(301, 22)
        Me.TextBoxIvCode.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(177, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Reaffirm PW"
        '
        'TextBoxREAFPW
        '
        Me.TextBoxREAFPW.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxREAFPW.Location = New System.Drawing.Point(177, 234)
        Me.TextBoxREAFPW.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxREAFPW.Name = "TextBoxREAFPW"
        Me.TextBoxREAFPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBoxREAFPW.Size = New System.Drawing.Size(301, 22)
        Me.TextBoxREAFPW.TabIndex = 11
        Me.TextBoxREAFPW.UseSystemPasswordChar = True
        '
        'LabelUserIDExisted
        '
        Me.LabelUserIDExisted.AutoSize = True
        Me.LabelUserIDExisted.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserIDExisted.ForeColor = System.Drawing.Color.Red
        Me.LabelUserIDExisted.Location = New System.Drawing.Point(485, 140)
        Me.LabelUserIDExisted.Name = "LabelUserIDExisted"
        Me.LabelUserIDExisted.Size = New System.Drawing.Size(97, 14)
        Me.LabelUserIDExisted.TabIndex = 12
        Me.LabelUserIDExisted.Text = "*用户名已存在"
        Me.LabelUserIDExisted.Visible = False
        '
        'LabelUserIDable
        '
        Me.LabelUserIDable.AutoSize = True
        Me.LabelUserIDable.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserIDable.ForeColor = System.Drawing.Color.Green
        Me.LabelUserIDable.Location = New System.Drawing.Point(494, 138)
        Me.LabelUserIDable.Name = "LabelUserIDable"
        Me.LabelUserIDable.Size = New System.Drawing.Size(112, 19)
        Me.LabelUserIDable.TabIndex = 13
        Me.LabelUserIDable.Text = "*用户名可用"
        Me.LabelUserIDable.Visible = False
        '
        'LabelPWDFT
        '
        Me.LabelPWDFT.AutoSize = True
        Me.LabelPWDFT.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPWDFT.ForeColor = System.Drawing.Color.Red
        Me.LabelPWDFT.Location = New System.Drawing.Point(498, 234)
        Me.LabelPWDFT.Name = "LabelPWDFT"
        Me.LabelPWDFT.Size = New System.Drawing.Size(127, 17)
        Me.LabelPWDFT.TabIndex = 14
        Me.LabelPWDFT.Text = "*两次密码不一致"
        Me.LabelPWDFT.Visible = False
        '
        'LabelPWempty
        '
        Me.LabelPWempty.AutoSize = True
        Me.LabelPWempty.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelPWempty.ForeColor = System.Drawing.Color.Red
        Me.LabelPWempty.Location = New System.Drawing.Point(495, 186)
        Me.LabelPWempty.Name = "LabelPWempty"
        Me.LabelPWempty.Size = New System.Drawing.Size(127, 17)
        Me.LabelPWempty.TabIndex = 15
        Me.LabelPWempty.Text = "*密码不能为空值"
        Me.LabelPWempty.Visible = False
        '
        'LabelPWestimate
        '
        Me.LabelPWestimate.AutoSize = True
        Me.LabelPWestimate.Location = New System.Drawing.Point(498, 190)
        Me.LabelPWestimate.Name = "LabelPWestimate"
        Me.LabelPWestimate.Size = New System.Drawing.Size(14, 14)
        Me.LabelPWestimate.TabIndex = 16
        Me.LabelPWestimate.Text = "1"
        Me.LabelPWestimate.Visible = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 456)
        Me.Controls.Add(Me.LabelPWestimate)
        Me.Controls.Add(Me.LabelPWempty)
        Me.Controls.Add(Me.LabelPWDFT)
        Me.Controls.Add(Me.LabelUserIDable)
        Me.Controls.Add(Me.LabelUserIDExisted)
        Me.Controls.Add(Me.TextBoxREAFPW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxIvCode)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.TextBoxPW)
        Me.Controls.Add(Me.LabelPW)
        Me.Controls.Add(Me.LabelUserID)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUserID As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LabelUserID As Label
    Friend WithEvents LabelPW As Label
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents TextBoxIvCode As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxREAFPW As TextBox
    Friend WithEvents LabelUserIDExisted As Label
    Friend WithEvents LabelUserIDable As Label
    Friend WithEvents LabelPWDFT As Label
    Friend WithEvents LabelPWempty As Label
    Friend WithEvents LabelPWestimate As Label
End Class
