<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CentralForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.排片管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyInfomationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxGenre = New System.Windows.Forms.ComboBox()
        Me.MovieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSet = New 电影票房数据库界面.BoxOfficeDataSet()
        Me.TextBoxMovie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxRelease = New System.Windows.Forms.ComboBox()
        Me.MovieBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelDirectsearch = New System.Windows.Forms.Label()
        Me.DataGridViewmovie = New System.Windows.Forms.DataGridView()
        Me.MovietitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleasetimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEW = New 电影票房数据库界面.BoxOfficeDataSetNEW()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.MovieTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.MovieTableAdapter()
        Me.LabelSelectsearch = New System.Windows.Forms.Label()
        Me.MovieTableAdapter1 = New 电影票房数据库界面.BoxOfficeDataSetNEWTableAdapters.MovieTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewmovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.排片管理ToolStripMenuItem, Me.SearchToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '排片管理ToolStripMenuItem
        '
        Me.排片管理ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.排片管理ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.排片管理ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.排片管理ToolStripMenuItem.Name = "排片管理ToolStripMenuItem"
        Me.排片管理ToolStripMenuItem.Size = New System.Drawing.Size(97, 21)
        Me.排片管理ToolStripMenuItem.Text = "Management"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordsToolStripMenuItem, Me.ReleaseToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(37, 21)
        Me.SearchToolStripMenuItem.Text = "DB"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'ReleaseToolStripMenuItem
        '
        Me.ReleaseToolStripMenuItem.Name = "ReleaseToolStripMenuItem"
        Me.ReleaseToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ReleaseToolStripMenuItem.Text = "Release"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.MyInfomationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'MyInfomationToolStripMenuItem
        '
        Me.MyInfomationToolStripMenuItem.Name = "MyInfomationToolStripMenuItem"
        Me.MyInfomationToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.MyInfomationToolStripMenuItem.Text = "My_Infomation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ComboBoxGenre
        '
        Me.ComboBoxGenre.FormattingEnabled = True
        Me.ComboBoxGenre.Items.AddRange(New Object() {"Adventure", "Action"})
        Me.ComboBoxGenre.Location = New System.Drawing.Point(70, 147)
        Me.ComboBoxGenre.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxGenre.Name = "ComboBoxGenre"
        Me.ComboBoxGenre.Size = New System.Drawing.Size(107, 22)
        Me.ComboBoxGenre.TabIndex = 1
        '
        'MovieBindingSource
        '
        Me.MovieBindingSource.DataMember = "Movie"
        Me.MovieBindingSource.DataSource = Me.BoxOfficeDataSetBindingSource
        '
        'BoxOfficeDataSetBindingSource
        '
        Me.BoxOfficeDataSetBindingSource.DataSource = Me.BoxOfficeDataSet
        Me.BoxOfficeDataSetBindingSource.Position = 0
        '
        'BoxOfficeDataSet
        '
        Me.BoxOfficeDataSet.DataSetName = "BoxOfficeDataSet"
        Me.BoxOfficeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxMovie
        '
        Me.TextBoxMovie.Location = New System.Drawing.Point(70, 70)
        Me.TextBoxMovie.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBoxMovie.Name = "TextBoxMovie"
        Me.TextBoxMovie.Size = New System.Drawing.Size(484, 22)
        Me.TextBoxMovie.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Genre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rekease year"
        '
        'ComboBoxRelease
        '
        Me.ComboBoxRelease.FormattingEnabled = True
        Me.ComboBoxRelease.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009"})
        Me.ComboBoxRelease.Location = New System.Drawing.Point(203, 147)
        Me.ComboBoxRelease.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ComboBoxRelease.Name = "ComboBoxRelease"
        Me.ComboBoxRelease.Size = New System.Drawing.Size(107, 22)
        Me.ComboBoxRelease.TabIndex = 5
        '
        'MovieBindingSource1
        '
        Me.MovieBindingSource1.DataMember = "Movie"
        Me.MovieBindingSource1.DataSource = Me.BoxOfficeDataSetBindingSource
        '
        'LabelDirectsearch
        '
        Me.LabelDirectsearch.AutoSize = True
        Me.LabelDirectsearch.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelDirectsearch.Location = New System.Drawing.Point(66, 48)
        Me.LabelDirectsearch.Name = "LabelDirectsearch"
        Me.LabelDirectsearch.Size = New System.Drawing.Size(217, 19)
        Me.LabelDirectsearch.TabIndex = 7
        Me.LabelDirectsearch.Text = "Direct search for movies"
        '
        'DataGridViewmovie
        '
        Me.DataGridViewmovie.AllowUserToAddRows = False
        Me.DataGridViewmovie.AutoGenerateColumns = False
        Me.DataGridViewmovie.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataGridViewmovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewmovie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovietitleDataGridViewTextBoxColumn, Me.ReleasetimeDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.DataGridViewmovie.DataSource = Me.MovieBindingSource2
        Me.DataGridViewmovie.Location = New System.Drawing.Point(70, 175)
        Me.DataGridViewmovie.Name = "DataGridViewmovie"
        Me.DataGridViewmovie.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewmovie.RowHeadersVisible = False
        Me.DataGridViewmovie.RowTemplate.Height = 23
        Me.DataGridViewmovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewmovie.Size = New System.Drawing.Size(383, 275)
        Me.DataGridViewmovie.TabIndex = 8
        '
        'MovietitleDataGridViewTextBoxColumn
        '
        Me.MovietitleDataGridViewTextBoxColumn.DataPropertyName = "Movietitle"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.MovietitleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MovietitleDataGridViewTextBoxColumn.HeaderText = "Movietitle"
        Me.MovietitleDataGridViewTextBoxColumn.Name = "MovietitleDataGridViewTextBoxColumn"
        Me.MovietitleDataGridViewTextBoxColumn.Width = 160
        '
        'ReleasetimeDataGridViewTextBoxColumn
        '
        Me.ReleasetimeDataGridViewTextBoxColumn.DataPropertyName = "Releasetime"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.ReleasetimeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ReleasetimeDataGridViewTextBoxColumn.HeaderText = "Releasetime"
        Me.ReleasetimeDataGridViewTextBoxColumn.Name = "ReleasetimeDataGridViewTextBoxColumn"
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.GenreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 120
        '
        'MovieBindingSource2
        '
        Me.MovieBindingSource2.DataMember = "Movie"
        Me.MovieBindingSource2.DataSource = Me.BoxOfficeDataSetNEWBindingSource
        '
        'BoxOfficeDataSetNEWBindingSource
        '
        Me.BoxOfficeDataSetNEWBindingSource.DataSource = Me.BoxOfficeDataSetNEW
        Me.BoxOfficeDataSetNEWBindingSource.Position = 0
        '
        'BoxOfficeDataSetNEW
        '
        Me.BoxOfficeDataSetNEW.DataSetName = "BoxOfficeDataSetNEW"
        Me.BoxOfficeDataSetNEW.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(598, 68)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSearch.TabIndex = 9
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'MovieTableAdapter
        '
        Me.MovieTableAdapter.ClearBeforeFill = True
        '
        'LabelSelectsearch
        '
        Me.LabelSelectsearch.AutoSize = True
        Me.LabelSelectsearch.Font = New System.Drawing.Font("等线", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelSelectsearch.Location = New System.Drawing.Point(66, 111)
        Me.LabelSelectsearch.Name = "LabelSelectsearch"
        Me.LabelSelectsearch.Size = New System.Drawing.Size(216, 19)
        Me.LabelSelectsearch.TabIndex = 10
        Me.LabelSelectsearch.Text = "Select search for movies"
        '
        'MovieTableAdapter1
        '
        Me.MovieTableAdapter1.ClearBeforeFill = True
        '
        'CentralForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 525)
        Me.Controls.Add(Me.LabelSelectsearch)
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.DataGridViewmovie)
        Me.Controls.Add(Me.LabelDirectsearch)
        Me.Controls.Add(Me.ComboBoxRelease)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMovie)
        Me.Controls.Add(Me.ComboBoxGenre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CentralForm"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MovieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewmovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 排片管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxGenre As ComboBox
    Friend WithEvents TextBoxMovie As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxRelease As ComboBox
    Friend WithEvents LabelDirectsearch As Label
    Friend WithEvents DataGridViewmovie As DataGridView
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents BoxOfficeDataSetBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSet As BoxOfficeDataSet
    Friend WithEvents MovieBindingSource As BindingSource
    Friend WithEvents MovieTableAdapter As BoxOfficeDataSetTableAdapters.MovieTableAdapter
    Friend WithEvents MovieBindingSource1 As BindingSource
    Friend WithEvents LabelSelectsearch As Label
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MyInfomationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoxOfficeDataSetNEWBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSetNEW As BoxOfficeDataSetNEW
    Friend WithEvents MovieBindingSource2 As BindingSource
    Friend WithEvents MovieTableAdapter1 As BoxOfficeDataSetNEWTableAdapters.MovieTableAdapter
    Friend WithEvents MovietitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReleasetimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
