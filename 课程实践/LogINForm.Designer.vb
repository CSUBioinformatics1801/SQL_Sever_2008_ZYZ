<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogINForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogINForm))
        Me.Labeltitle = New System.Windows.Forms.Label()
        Me.LabelUserID = New System.Windows.Forms.Label()
        Me.LabelPW = New System.Windows.Forms.Label()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.Buttonlogon = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LabelUserIDExist = New System.Windows.Forms.Label()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.ButtonVisit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Labeltitle
        '
        Me.Labeltitle.AutoSize = True
        Me.Labeltitle.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labeltitle.Location = New System.Drawing.Point(189, 60)
        Me.Labeltitle.Name = "Labeltitle"
        Me.Labeltitle.Size = New System.Drawing.Size(383, 22)
        Me.Labeltitle.TabIndex = 1
        Me.Labeltitle.Text = "Welcome to BoxOffices Database 2019"
        Me.Labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelUserID
        '
        Me.LabelUserID.AutoSize = True
        Me.LabelUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LabelUserID.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelUserID.Location = New System.Drawing.Point(167, 151)
        Me.LabelUserID.Name = "LabelUserID"
        Me.LabelUserID.Size = New System.Drawing.Size(77, 21)
        Me.LabelUserID.TabIndex = 2
        Me.LabelUserID.Text = "User ID"
        '
        'LabelPW
        '
        Me.LabelPW.AutoSize = True
        Me.LabelPW.Font = New System.Drawing.Font("等线", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPW.Location = New System.Drawing.Point(167, 191)
        Me.LabelPW.Name = "LabelPW"
        Me.LabelPW.Size = New System.Drawing.Size(96, 21)
        Me.LabelPW.TabIndex = 3
        Me.LabelPW.Text = "Password"
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.Location = New System.Drawing.Point(283, 151)
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(259, 22)
        Me.TextBoxUserID.TabIndex = 4
        '
        'Buttonlogon
        '
        Me.Buttonlogon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttonlogon.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Buttonlogon.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Buttonlogon.Location = New System.Drawing.Point(170, 305)
        Me.Buttonlogon.Name = "Buttonlogon"
        Me.Buttonlogon.Size = New System.Drawing.Size(379, 40)
        Me.Buttonlogon.TabIndex = 6
        Me.Buttonlogon.Text = "Log in"
        Me.Buttonlogon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Register"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(170, 260)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(149, 23)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Remember Me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabelUserIDExist
        '
        Me.LabelUserIDExist.AutoSize = True
        Me.LabelUserIDExist.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelUserIDExist.ForeColor = System.Drawing.Color.Red
        Me.LabelUserIDExist.Location = New System.Drawing.Point(548, 156)
        Me.LabelUserIDExist.Name = "LabelUserIDExist"
        Me.LabelUserIDExist.Size = New System.Drawing.Size(111, 17)
        Me.LabelUserIDExist.TabIndex = 9
        Me.LabelUserIDExist.Text = "*用户名不存在"
        Me.LabelUserIDExist.Visible = False
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Location = New System.Drawing.Point(283, 190)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.TextBoxPW.Size = New System.Drawing.Size(259, 22)
        Me.TextBoxPW.TabIndex = 5
        Me.TextBoxPW.UseSystemPasswordChar = True
        '
        'ButtonVisit
        '
        Me.ButtonVisit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVisit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonVisit.Font = New System.Drawing.Font("等线", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonVisit.Location = New System.Drawing.Point(170, 351)
        Me.ButtonVisit.Name = "ButtonVisit"
        Me.ButtonVisit.Size = New System.Drawing.Size(379, 40)
        Me.ButtonVisit.TabIndex = 10
        Me.ButtonVisit.Text = "Visitor"
        Me.ButtonVisit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LogINForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 472)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonVisit)
        Me.Controls.Add(Me.LabelUserIDExist)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonlogon)
        Me.Controls.Add(Me.TextBoxPW)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.LabelPW)
        Me.Controls.Add(Me.LabelUserID)
        Me.Controls.Add(Me.Labeltitle)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "LogINForm"
        Me.Text = "BoxOffice Database 2019"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labeltitle As Label
    Friend WithEvents LabelUserID As Label
    Friend WithEvents LabelPW As Label
    Friend WithEvents TextBoxUserID As TextBox
    Friend WithEvents Buttonlogon As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LabelUserIDExist As Label
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents ButtonVisit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
