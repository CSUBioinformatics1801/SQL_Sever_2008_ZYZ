<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movierelease
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movierelease))
        Me.DataGridViewrelease = New System.Windows.Forms.DataGridView()
        Me.MovietitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleasetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieunreleasedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSet = New 电影票房数据库界面.BoxOfficeDataSet()
        Me.ComboBoxRelease = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MovieunreleasedTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.MovieunreleasedTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxPrint = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBoxupdate = New System.Windows.Forms.PictureBox()
        Me.PictureBoxdeleteall = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewrelease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieunreleasedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxdeleteall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewrelease
        '
        Me.DataGridViewrelease.AllowUserToDeleteRows = False
        Me.DataGridViewrelease.AllowUserToOrderColumns = True
        Me.DataGridViewrelease.AutoGenerateColumns = False
        Me.DataGridViewrelease.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewrelease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewrelease.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovietitleDataGridViewTextBoxColumn, Me.ReleasetimeDataGridViewTextBoxColumn, Me.StudioDataGridViewTextBoxColumn, Me.DirectorDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.DataGridViewrelease.DataSource = Me.MovieunreleasedBindingSource
        Me.DataGridViewrelease.Location = New System.Drawing.Point(45, 133)
        Me.DataGridViewrelease.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewrelease.Name = "DataGridViewrelease"
        Me.DataGridViewrelease.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewrelease.RowHeadersVisible = False
        Me.DataGridViewrelease.RowTemplate.Height = 23
        Me.DataGridViewrelease.Size = New System.Drawing.Size(775, 472)
        Me.DataGridViewrelease.TabIndex = 15
        '
        'MovietitleDataGridViewTextBoxColumn
        '
        Me.MovietitleDataGridViewTextBoxColumn.DataPropertyName = "Movietitle"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.MovietitleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.MovietitleDataGridViewTextBoxColumn.HeaderText = "Movietitle"
        Me.MovietitleDataGridViewTextBoxColumn.Name = "MovietitleDataGridViewTextBoxColumn"
        Me.MovietitleDataGridViewTextBoxColumn.Width = 150
        '
        'ReleasetimeDataGridViewTextBoxColumn
        '
        Me.ReleasetimeDataGridViewTextBoxColumn.DataPropertyName = "Releasetime"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ReleasetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ReleasetimeDataGridViewTextBoxColumn.HeaderText = "Releasetime"
        Me.ReleasetimeDataGridViewTextBoxColumn.Name = "ReleasetimeDataGridViewTextBoxColumn"
        Me.ReleasetimeDataGridViewTextBoxColumn.Width = 120
        '
        'StudioDataGridViewTextBoxColumn
        '
        Me.StudioDataGridViewTextBoxColumn.DataPropertyName = "Studio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StudioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.StudioDataGridViewTextBoxColumn.HeaderText = "Studio"
        Me.StudioDataGridViewTextBoxColumn.Name = "StudioDataGridViewTextBoxColumn"
        Me.StudioDataGridViewTextBoxColumn.Width = 120
        '
        'DirectorDataGridViewTextBoxColumn
        '
        Me.DirectorDataGridViewTextBoxColumn.DataPropertyName = "Director"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DirectorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.DirectorDataGridViewTextBoxColumn.HeaderText = "Director"
        Me.DirectorDataGridViewTextBoxColumn.Name = "DirectorDataGridViewTextBoxColumn"
        Me.DirectorDataGridViewTextBoxColumn.Width = 120
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GenreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 200
        '
        'MovieunreleasedBindingSource
        '
        Me.MovieunreleasedBindingSource.DataMember = "Movieunreleased"
        Me.MovieunreleasedBindingSource.DataSource = Me.BoxOfficeDataSet
        '
        'BoxOfficeDataSet
        '
        Me.BoxOfficeDataSet.DataSetName = "BoxOfficeDataSet"
        Me.BoxOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBoxRelease
        '
        Me.ComboBoxRelease.FormattingEnabled = True
        Me.ComboBoxRelease.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009"})
        Me.ComboBoxRelease.Location = New System.Drawing.Point(211, 52)
        Me.ComboBoxRelease.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ComboBoxRelease.Name = "ComboBoxRelease"
        Me.ComboBoxRelease.Size = New System.Drawing.Size(158, 27)
        Me.ComboBoxRelease.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rekease year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Genre"
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Adventure", "Action", "Animation"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(13, 55)
        Me.ComboBoxGenre.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(158, 27)
        Me.ComboBoxGenre.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(764, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'MovieunreleasedTableAdapter
        '
        Me.MovieunreleasedTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxRelease)
        Me.GroupBox1.Controls.Add(Me.ComboBoxGenre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(500, 109)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select for unreleased Movie"
        '
        'PictureBoxPrint
        '
        Me.PictureBoxPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPrint.Image = CType(resources.GetObject("PictureBoxPrint.Image"), System.Drawing.Image)
        Me.PictureBoxPrint.Location = New System.Drawing.Point(583, 47)
        Me.PictureBoxPrint.Name = "PictureBoxPrint"
        Me.PictureBoxPrint.Size = New System.Drawing.Size(58, 52)
        Me.PictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrint.TabIndex = 26
        Me.PictureBoxPrint.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PictureBoxupdate
        '
        Me.PictureBoxupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxupdate.Image = CType(resources.GetObject("PictureBoxupdate.Image"), System.Drawing.Image)
        Me.PictureBoxupdate.Location = New System.Drawing.Point(647, 47)
        Me.PictureBoxupdate.Name = "PictureBoxupdate"
        Me.PictureBoxupdate.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxupdate.TabIndex = 28
        Me.PictureBoxupdate.TabStop = False
        '
        'PictureBoxdeleteall
        '
        Me.PictureBoxdeleteall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxdeleteall.Image = CType(resources.GetObject("PictureBoxdeleteall.Image"), System.Drawing.Image)
        Me.PictureBoxdeleteall.Location = New System.Drawing.Point(705, 47)
        Me.PictureBoxdeleteall.Name = "PictureBoxdeleteall"
        Me.PictureBoxdeleteall.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxdeleteall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxdeleteall.TabIndex = 29
        Me.PictureBoxdeleteall.TabStop = False
        '
        'Movierelease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 638)
        Me.Controls.Add(Me.PictureBoxdeleteall)
        Me.Controls.Add(Me.PictureBoxupdate)
        Me.Controls.Add(Me.PictureBoxPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridViewrelease)
        Me.Font = New System.Drawing.Font("等线", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Movierelease"
        Me.Text = "Movierelease"
        CType(Me.DataGridViewrelease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieunreleasedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxdeleteall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewrelease As DataGridView
    Friend WithEvents ComboBoxRelease As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BoxOfficeDataSet As BoxOfficeDataSet
    Friend WithEvents MovieunreleasedBindingSource As BindingSource
    Friend WithEvents MovieunreleasedTableAdapter As BoxOfficeDataSetTableAdapters.MovieunreleasedTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MovietitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReleasetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBoxPrint As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBoxupdate As PictureBox
    Friend WithEvents PictureBoxdeleteall As PictureBox
End Class
