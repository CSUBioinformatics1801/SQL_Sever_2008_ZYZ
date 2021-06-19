<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movieadd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movieadd))
        Me.LabelMovietitle = New System.Windows.Forms.Label()
        Me.Buttonadd = New System.Windows.Forms.Button()
        Me.TextBoxMovietitle = New System.Windows.Forms.TextBox()
        Me.LabelRltime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBoxoffice = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelMovieable = New System.Windows.Forms.Label()
        Me.LabelmovieExisted = New System.Windows.Forms.Label()
        Me.LabelnameNULL = New System.Windows.Forms.Label()
        Me.Labelinvalidtime = New System.Windows.Forms.Label()
        Me.LabelDirector = New System.Windows.Forms.Label()
        Me.TextBoxDirector = New System.Windows.Forms.TextBox()
        Me.TextBoxStudio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxProduction = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxposter = New System.Windows.Forms.PictureBox()
        Me.Buttonupic = New System.Windows.Forms.Button()
        Me.DateTimePickerRTime = New System.Windows.Forms.DateTimePicker()
        Me.PictureBoxnone = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxposter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxnone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelMovietitle
        '
        Me.LabelMovietitle.AutoSize = True
        Me.LabelMovietitle.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMovietitle.Location = New System.Drawing.Point(157, 63)
        Me.LabelMovietitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMovietitle.Name = "LabelMovietitle"
        Me.LabelMovietitle.Size = New System.Drawing.Size(83, 17)
        Me.LabelMovietitle.TabIndex = 0
        Me.LabelMovietitle.Text = "Movietitle"
        '
        'Buttonadd
        '
        Me.Buttonadd.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Buttonadd.Location = New System.Drawing.Point(93, 401)
        Me.Buttonadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Buttonadd.Name = "Buttonadd"
        Me.Buttonadd.Size = New System.Drawing.Size(318, 28)
        Me.Buttonadd.TabIndex = 1
        Me.Buttonadd.Text = "Submit"
        Me.Buttonadd.UseVisualStyleBackColor = True
        '
        'TextBoxMovietitle
        '
        Me.TextBoxMovietitle.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxMovietitle.Location = New System.Drawing.Point(261, 60)
        Me.TextBoxMovietitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxMovietitle.Name = "TextBoxMovietitle"
        Me.TextBoxMovietitle.Size = New System.Drawing.Size(136, 24)
        Me.TextBoxMovietitle.TabIndex = 3
        '
        'LabelRltime
        '
        Me.LabelRltime.AutoSize = True
        Me.LabelRltime.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelRltime.Location = New System.Drawing.Point(136, 119)
        Me.LabelRltime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelRltime.Name = "LabelRltime"
        Me.LabelRltime.Size = New System.Drawing.Size(97, 17)
        Me.LabelRltime.TabIndex = 5
        Me.LabelRltime.Text = "Release Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(184, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Genre"
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Western", "War", "Detective", "Gangster", "Thriller", "Sci-Fi", "Adventure", "Action", "comedy", "Documentary", "History", "Cartoon", "Fantasy", "Porn ", "Animation"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(261, 196)
        Me.ComboBoxGenre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(136, 25)
        Me.ComboBoxGenre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Boxoffice WorldWide($)"
        '
        'TextBoxBoxoffice
        '
        Me.TextBoxBoxoffice.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxBoxoffice.Location = New System.Drawing.Point(261, 341)
        Me.TextBoxBoxoffice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBoxoffice.Name = "TextBoxBoxoffice"
        Me.TextBoxBoxoffice.Size = New System.Drawing.Size(136, 24)
        Me.TextBoxBoxoffice.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(699, 344)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'LabelMovieable
        '
        Me.LabelMovieable.AutoSize = True
        Me.LabelMovieable.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelMovieable.ForeColor = System.Drawing.Color.Green
        Me.LabelMovieable.Location = New System.Drawing.Point(403, 60)
        Me.LabelMovieable.Name = "LabelMovieable"
        Me.LabelMovieable.Size = New System.Drawing.Size(131, 19)
        Me.LabelMovieable.TabIndex = 19
        Me.LabelMovieable.Text = "*电影名可添加"
        Me.LabelMovieable.Visible = False
        '
        'LabelmovieExisted
        '
        Me.LabelmovieExisted.AutoSize = True
        Me.LabelmovieExisted.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelmovieExisted.ForeColor = System.Drawing.Color.Red
        Me.LabelmovieExisted.Location = New System.Drawing.Point(403, 60)
        Me.LabelmovieExisted.Name = "LabelmovieExisted"
        Me.LabelmovieExisted.Size = New System.Drawing.Size(131, 19)
        Me.LabelmovieExisted.TabIndex = 20
        Me.LabelmovieExisted.Text = "*电影名已存在"
        Me.LabelmovieExisted.Visible = False
        '
        'LabelnameNULL
        '
        Me.LabelnameNULL.AutoSize = True
        Me.LabelnameNULL.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelnameNULL.ForeColor = System.Drawing.Color.Red
        Me.LabelnameNULL.Location = New System.Drawing.Point(403, 60)
        Me.LabelnameNULL.Name = "LabelnameNULL"
        Me.LabelnameNULL.Size = New System.Drawing.Size(110, 19)
        Me.LabelnameNULL.TabIndex = 21
        Me.LabelnameNULL.Text = "!不能为空值"
        Me.LabelnameNULL.Visible = False
        '
        'Labelinvalidtime
        '
        Me.Labelinvalidtime.AutoSize = True
        Me.Labelinvalidtime.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labelinvalidtime.ForeColor = System.Drawing.Color.Red
        Me.Labelinvalidtime.Location = New System.Drawing.Point(33, 113)
        Me.Labelinvalidtime.Name = "Labelinvalidtime"
        Me.Labelinvalidtime.Size = New System.Drawing.Size(85, 19)
        Me.Labelinvalidtime.TabIndex = 22
        Me.Labelinvalidtime.Text = "时间无效"
        Me.Labelinvalidtime.Visible = False
        '
        'LabelDirector
        '
        Me.LabelDirector.AutoSize = True
        Me.LabelDirector.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelDirector.Location = New System.Drawing.Point(171, 232)
        Me.LabelDirector.Name = "LabelDirector"
        Me.LabelDirector.Size = New System.Drawing.Size(62, 17)
        Me.LabelDirector.TabIndex = 23
        Me.LabelDirector.Text = "Director"
        '
        'TextBoxDirector
        '
        Me.TextBoxDirector.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxDirector.Location = New System.Drawing.Point(261, 229)
        Me.TextBoxDirector.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDirector.Name = "TextBoxDirector"
        Me.TextBoxDirector.Size = New System.Drawing.Size(136, 24)
        Me.TextBoxDirector.TabIndex = 24
        '
        'TextBoxStudio
        '
        Me.TextBoxStudio.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxStudio.Location = New System.Drawing.Point(261, 269)
        Me.TextBoxStudio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxStudio.Name = "TextBoxStudio"
        Me.TextBoxStudio.Size = New System.Drawing.Size(136, 24)
        Me.TextBoxStudio.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(181, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Studio"
        '
        'TextBoxProduction
        '
        Me.TextBoxProduction.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBoxProduction.Location = New System.Drawing.Point(261, 309)
        Me.TextBoxProduction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxProduction.Name = "TextBoxProduction"
        Me.TextBoxProduction.Size = New System.Drawing.Size(136, 24)
        Me.TextBoxProduction.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(134, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Production($)"
        '
        'PictureBoxposter
        '
        Me.PictureBoxposter.Location = New System.Drawing.Point(449, 169)
        Me.PictureBoxposter.Name = "PictureBoxposter"
        Me.PictureBoxposter.Size = New System.Drawing.Size(177, 222)
        Me.PictureBoxposter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxposter.TabIndex = 29
        Me.PictureBoxposter.TabStop = False
        '
        'Buttonupic
        '
        Me.Buttonupic.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Buttonupic.Location = New System.Drawing.Point(449, 397)
        Me.Buttonupic.Name = "Buttonupic"
        Me.Buttonupic.Size = New System.Drawing.Size(177, 32)
        Me.Buttonupic.TabIndex = 30
        Me.Buttonupic.Text = "Upload Poster"
        Me.Buttonupic.UseVisualStyleBackColor = True
        '
        'DateTimePickerRTime
        '
        Me.DateTimePickerRTime.Location = New System.Drawing.Point(261, 119)
        Me.DateTimePickerRTime.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerRTime.MinDate = New Date(1853, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerRTime.Name = "DateTimePickerRTime"
        Me.DateTimePickerRTime.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePickerRTime.TabIndex = 31
        '
        'PictureBoxnone
        '
        Me.PictureBoxnone.Image = CType(resources.GetObject("PictureBoxnone.Image"), System.Drawing.Image)
        Me.PictureBoxnone.Location = New System.Drawing.Point(449, 169)
        Me.PictureBoxnone.Name = "PictureBoxnone"
        Me.PictureBoxnone.Size = New System.Drawing.Size(177, 222)
        Me.PictureBoxnone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxnone.TabIndex = 32
        Me.PictureBoxnone.TabStop = False
        '
        'Movieadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 455)
        Me.Controls.Add(Me.PictureBoxnone)
        Me.Controls.Add(Me.DateTimePickerRTime)
        Me.Controls.Add(Me.Buttonupic)
        Me.Controls.Add(Me.PictureBoxposter)
        Me.Controls.Add(Me.TextBoxProduction)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxStudio)
        Me.Controls.Add(Me.TextBoxDirector)
        Me.Controls.Add(Me.LabelDirector)
        Me.Controls.Add(Me.Labelinvalidtime)
        Me.Controls.Add(Me.LabelnameNULL)
        Me.Controls.Add(Me.LabelmovieExisted)
        Me.Controls.Add(Me.LabelMovieable)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxBoxoffice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxGenre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelRltime)
        Me.Controls.Add(Me.TextBoxMovietitle)
        Me.Controls.Add(Me.Buttonadd)
        Me.Controls.Add(Me.LabelMovietitle)
        Me.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Movieadd"
        Me.Text = "Movieadd"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxposter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxnone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelMovietitle As Label
    Friend WithEvents Buttonadd As Button
    Friend WithEvents TextBoxMovietitle As TextBox
    Friend WithEvents LabelRltime As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxBoxoffice As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelMovieable As Label
    Public WithEvents LabelmovieExisted As Label
    Friend WithEvents LabelnameNULL As Label
    Friend WithEvents Labelinvalidtime As Label
    Friend WithEvents LabelDirector As Label
    Friend WithEvents TextBoxDirector As TextBox
    Friend WithEvents TextBoxStudio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxProduction As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBoxposter As PictureBox
    Friend WithEvents Buttonupic As Button
    Friend WithEvents DateTimePickerRTime As DateTimePicker
    Friend WithEvents PictureBoxnone As PictureBox
End Class
