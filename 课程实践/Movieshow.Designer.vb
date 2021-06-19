<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Movieshow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movieshow))
        Me.GroupBoxMoviename = New System.Windows.Forms.GroupBox()
        Me.GroupBoxRating = New System.Windows.Forms.GroupBox()
        Me.Labelratingnum = New System.Windows.Forms.Label()
        Me.PictureBoxstar = New System.Windows.Forms.PictureBox()
        Me.PictureBoxunrate = New System.Windows.Forms.PictureBox()
        Me.Buttonpicup = New System.Windows.Forms.Button()
        Me.TextBoxgenre = New System.Windows.Forms.TextBox()
        Me.Labelgenre = New System.Windows.Forms.Label()
        Me.Labelactor = New System.Windows.Forms.Label()
        Me.Labelboxoffice = New System.Windows.Forms.Label()
        Me.PictureBoxplaybill = New System.Windows.Forms.PictureBox()
        Me.DataGridViewactor = New System.Windows.Forms.DataGridView()
        Me.MovienameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemunerationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieActorcnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSet = New 电影票房数据库界面.BoxOfficeDataSet()
        Me.TextBoxproduction = New System.Windows.Forms.TextBox()
        Me.TextBoxstudio = New System.Windows.Forms.TextBox()
        Me.TextBoxdirector = New System.Windows.Forms.TextBox()
        Me.TextBoxrelease = New System.Windows.Forms.TextBox()
        Me.Labelproduction = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelStudio = New System.Windows.Forms.Label()
        Me.LinkLabelseemore = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewBoxoffice = New System.Windows.Forms.DataGridView()
        Me.NAmericaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChinaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JapanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HongkongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FranceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetachDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SouthkoreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorldwideDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoxofficeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEW = New 电影票房数据库界面.BoxOfficeDataSetNEW()
        Me.Labelrelease = New System.Windows.Forms.Label()
        Me.BoxofficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActorTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.ActorTableAdapter()
        Me.Movie_Actor_cnTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.Movie_Actor_cnTableAdapter()
        Me.BoxofficeTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.BoxofficeTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialogpicup = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxPrint = New System.Windows.Forms.PictureBox()
        Me.PictureBoxupdate = New System.Windows.Forms.PictureBox()
        Me.PictureBoxdeleteall = New System.Windows.Forms.PictureBox()
        Me.PictureBoxdeleteactor = New System.Windows.Forms.PictureBox()
        Me.BoxofficeTableAdapter1 = New 电影票房数据库界面.BoxOfficeDataSetNEWTableAdapters.BoxofficeTableAdapter()
        Me.GroupBoxMoviename.SuspendLayout()
        Me.GroupBoxRating.SuspendLayout()
        CType(Me.PictureBoxstar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxunrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxplaybill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieActorcnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBoxoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxofficeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxofficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxdeleteall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxdeleteactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxMoviename
        '
        Me.GroupBoxMoviename.Controls.Add(Me.GroupBoxRating)
        Me.GroupBoxMoviename.Controls.Add(Me.Buttonpicup)
        Me.GroupBoxMoviename.Controls.Add(Me.TextBoxgenre)
        Me.GroupBoxMoviename.Controls.Add(Me.Labelgenre)
        Me.GroupBoxMoviename.Controls.Add(Me.Labelactor)
        Me.GroupBoxMoviename.Controls.Add(Me.Labelboxoffice)
        Me.GroupBoxMoviename.Controls.Add(Me.PictureBoxplaybill)
        Me.GroupBoxMoviename.Controls.Add(Me.DataGridViewactor)
        Me.GroupBoxMoviename.Controls.Add(Me.TextBoxproduction)
        Me.GroupBoxMoviename.Controls.Add(Me.TextBoxstudio)
        Me.GroupBoxMoviename.Controls.Add(Me.TextBoxdirector)
        Me.GroupBoxMoviename.Controls.Add(Me.TextBoxrelease)
        Me.GroupBoxMoviename.Controls.Add(Me.Labelproduction)
        Me.GroupBoxMoviename.Controls.Add(Me.Label1)
        Me.GroupBoxMoviename.Controls.Add(Me.LabelStudio)
        Me.GroupBoxMoviename.Controls.Add(Me.LinkLabelseemore)
        Me.GroupBoxMoviename.Controls.Add(Me.DataGridViewBoxoffice)
        Me.GroupBoxMoviename.Controls.Add(Me.Labelrelease)
        Me.GroupBoxMoviename.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBoxMoviename.Location = New System.Drawing.Point(24, 12)
        Me.GroupBoxMoviename.Name = "GroupBoxMoviename"
        Me.GroupBoxMoviename.Size = New System.Drawing.Size(757, 461)
        Me.GroupBoxMoviename.TabIndex = 1
        Me.GroupBoxMoviename.TabStop = False
        Me.GroupBoxMoviename.Text = "Moviename"
        '
        'GroupBoxRating
        '
        Me.GroupBoxRating.Controls.Add(Me.Labelratingnum)
        Me.GroupBoxRating.Controls.Add(Me.PictureBoxstar)
        Me.GroupBoxRating.Controls.Add(Me.PictureBoxunrate)
        Me.GroupBoxRating.Location = New System.Drawing.Point(18, 209)
        Me.GroupBoxRating.Name = "GroupBoxRating"
        Me.GroupBoxRating.Size = New System.Drawing.Size(254, 86)
        Me.GroupBoxRating.TabIndex = 21
        Me.GroupBoxRating.TabStop = False
        Me.GroupBoxRating.Text = "Rating"
        '
        'Labelratingnum
        '
        Me.Labelratingnum.AutoSize = True
        Me.Labelratingnum.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labelratingnum.Location = New System.Drawing.Point(172, 0)
        Me.Labelratingnum.Name = "Labelratingnum"
        Me.Labelratingnum.Size = New System.Drawing.Size(76, 17)
        Me.Labelratingnum.TabIndex = 17
        Me.Labelratingnum.Text = "Labelrate"
        '
        'PictureBoxstar
        '
        Me.PictureBoxstar.BackColor = System.Drawing.Color.Yellow
        Me.PictureBoxstar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxstar.Image = CType(resources.GetObject("PictureBoxstar.Image"), System.Drawing.Image)
        Me.PictureBoxstar.Location = New System.Drawing.Point(22, 32)
        Me.PictureBoxstar.Name = "PictureBoxstar"
        Me.PictureBoxstar.Size = New System.Drawing.Size(200, 37)
        Me.PictureBoxstar.TabIndex = 15
        Me.PictureBoxstar.TabStop = False
        '
        'PictureBoxunrate
        '
        Me.PictureBoxunrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxunrate.BackColor = System.Drawing.Color.White
        Me.PictureBoxunrate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxunrate.Image = CType(resources.GetObject("PictureBoxunrate.Image"), System.Drawing.Image)
        Me.PictureBoxunrate.Location = New System.Drawing.Point(22, 32)
        Me.PictureBoxunrate.Name = "PictureBoxunrate"
        Me.PictureBoxunrate.Size = New System.Drawing.Size(200, 37)
        Me.PictureBoxunrate.TabIndex = 18
        Me.PictureBoxunrate.TabStop = False
        '
        'Buttonpicup
        '
        Me.Buttonpicup.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Buttonpicup.Location = New System.Drawing.Point(315, 286)
        Me.Buttonpicup.Name = "Buttonpicup"
        Me.Buttonpicup.Size = New System.Drawing.Size(165, 26)
        Me.Buttonpicup.TabIndex = 20
        Me.Buttonpicup.Text = "Update Poster"
        Me.Buttonpicup.UseVisualStyleBackColor = True
        '
        'TextBoxgenre
        '
        Me.TextBoxgenre.Location = New System.Drawing.Point(123, 144)
        Me.TextBoxgenre.Name = "TextBoxgenre"
        Me.TextBoxgenre.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxgenre.TabIndex = 19
        '
        'Labelgenre
        '
        Me.Labelgenre.AutoSize = True
        Me.Labelgenre.Location = New System.Drawing.Point(67, 147)
        Me.Labelgenre.Name = "Labelgenre"
        Me.Labelgenre.Size = New System.Drawing.Size(44, 14)
        Me.Labelgenre.TabIndex = 18
        Me.Labelgenre.Text = "Genre"
        '
        'Labelactor
        '
        Me.Labelactor.AutoSize = True
        Me.Labelactor.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labelactor.Location = New System.Drawing.Point(517, 17)
        Me.Labelactor.Name = "Labelactor"
        Me.Labelactor.Size = New System.Drawing.Size(111, 17)
        Me.Labelactor.TabIndex = 14
        Me.Labelactor.Text = "Cast of Actors"
        '
        'Labelboxoffice
        '
        Me.Labelboxoffice.AutoSize = True
        Me.Labelboxoffice.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Labelboxoffice.Location = New System.Drawing.Point(6, 338)
        Me.Labelboxoffice.Name = "Labelboxoffice"
        Me.Labelboxoffice.Size = New System.Drawing.Size(114, 17)
        Me.Labelboxoffice.TabIndex = 13
        Me.Labelboxoffice.Text = "Boxoffice area"
        '
        'PictureBoxplaybill
        '
        Me.PictureBoxplaybill.ImageLocation = ""
        Me.PictureBoxplaybill.Location = New System.Drawing.Point(315, 36)
        Me.PictureBoxplaybill.Name = "PictureBoxplaybill"
        Me.PictureBoxplaybill.Size = New System.Drawing.Size(165, 244)
        Me.PictureBoxplaybill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxplaybill.TabIndex = 11
        Me.PictureBoxplaybill.TabStop = False
        '
        'DataGridViewactor
        '
        Me.DataGridViewactor.AutoGenerateColumns = False
        Me.DataGridViewactor.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewactor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovienameDataGridViewTextBoxColumn, Me.ActornameDataGridViewTextBoxColumn, Me.RemunerationDataGridViewTextBoxColumn})
        Me.DataGridViewactor.DataSource = Me.MovieActorcnBindingSource
        Me.DataGridViewactor.Location = New System.Drawing.Point(517, 37)
        Me.DataGridViewactor.Name = "DataGridViewactor"
        Me.DataGridViewactor.RowHeadersVisible = False
        Me.DataGridViewactor.RowTemplate.Height = 23
        Me.DataGridViewactor.Size = New System.Drawing.Size(223, 296)
        Me.DataGridViewactor.TabIndex = 10
        '
        'MovienameDataGridViewTextBoxColumn
        '
        Me.MovienameDataGridViewTextBoxColumn.DataPropertyName = "Moviename"
        Me.MovienameDataGridViewTextBoxColumn.HeaderText = "Moviename"
        Me.MovienameDataGridViewTextBoxColumn.Name = "MovienameDataGridViewTextBoxColumn"
        Me.MovienameDataGridViewTextBoxColumn.Visible = False
        '
        'ActornameDataGridViewTextBoxColumn
        '
        Me.ActornameDataGridViewTextBoxColumn.DataPropertyName = "Actorname"
        Me.ActornameDataGridViewTextBoxColumn.HeaderText = "Actorname"
        Me.ActornameDataGridViewTextBoxColumn.Name = "ActornameDataGridViewTextBoxColumn"
        Me.ActornameDataGridViewTextBoxColumn.Width = 120
        '
        'RemunerationDataGridViewTextBoxColumn
        '
        Me.RemunerationDataGridViewTextBoxColumn.DataPropertyName = "Remuneration"
        Me.RemunerationDataGridViewTextBoxColumn.HeaderText = "Remuneration"
        Me.RemunerationDataGridViewTextBoxColumn.Name = "RemunerationDataGridViewTextBoxColumn"
        '
        'MovieActorcnBindingSource
        '
        Me.MovieActorcnBindingSource.DataMember = "Movie_Actor_cn"
        Me.MovieActorcnBindingSource.DataSource = Me.BoxOfficeDataSetBindingSource
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
        'TextBoxproduction
        '
        Me.TextBoxproduction.Location = New System.Drawing.Point(123, 172)
        Me.TextBoxproduction.Name = "TextBoxproduction"
        Me.TextBoxproduction.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxproduction.TabIndex = 9
        '
        'TextBoxstudio
        '
        Me.TextBoxstudio.Location = New System.Drawing.Point(123, 85)
        Me.TextBoxstudio.Name = "TextBoxstudio"
        Me.TextBoxstudio.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxstudio.TabIndex = 8
        '
        'TextBoxdirector
        '
        Me.TextBoxdirector.Location = New System.Drawing.Point(123, 113)
        Me.TextBoxdirector.Name = "TextBoxdirector"
        Me.TextBoxdirector.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxdirector.TabIndex = 7
        '
        'TextBoxrelease
        '
        Me.TextBoxrelease.Location = New System.Drawing.Point(123, 55)
        Me.TextBoxrelease.Name = "TextBoxrelease"
        Me.TextBoxrelease.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxrelease.TabIndex = 6
        '
        'Labelproduction
        '
        Me.Labelproduction.AutoSize = True
        Me.Labelproduction.Location = New System.Drawing.Point(37, 175)
        Me.Labelproduction.Name = "Labelproduction"
        Me.Labelproduction.Size = New System.Drawing.Size(76, 14)
        Me.Labelproduction.TabIndex = 5
        Me.Labelproduction.Text = "Production"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Director"
        '
        'LabelStudio
        '
        Me.LabelStudio.AutoSize = True
        Me.LabelStudio.Location = New System.Drawing.Point(65, 88)
        Me.LabelStudio.Name = "LabelStudio"
        Me.LabelStudio.Size = New System.Drawing.Size(48, 14)
        Me.LabelStudio.TabIndex = 3
        Me.LabelStudio.Text = "Studio"
        '
        'LinkLabelseemore
        '
        Me.LinkLabelseemore.AutoSize = True
        Me.LinkLabelseemore.Location = New System.Drawing.Point(687, 0)
        Me.LinkLabelseemore.Name = "LinkLabelseemore"
        Me.LinkLabelseemore.Size = New System.Drawing.Size(66, 14)
        Me.LinkLabelseemore.TabIndex = 2
        Me.LinkLabelseemore.TabStop = True
        Me.LinkLabelseemore.Text = "See More"
        '
        'DataGridViewBoxoffice
        '
        Me.DataGridViewBoxoffice.AllowUserToAddRows = False
        Me.DataGridViewBoxoffice.AutoGenerateColumns = False
        Me.DataGridViewBoxoffice.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewBoxoffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBoxoffice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAmericaDataGridViewTextBoxColumn, Me.ChinaDataGridViewTextBoxColumn, Me.JapanDataGridViewTextBoxColumn, Me.HongkongDataGridViewTextBoxColumn, Me.FranceDataGridViewTextBoxColumn, Me.IndiaDataGridViewTextBoxColumn, Me.DetachDataGridViewTextBoxColumn, Me.SouthkoreaDataGridViewTextBoxColumn, Me.UKDataGridViewTextBoxColumn, Me.WorldwideDataGridViewTextBoxColumn})
        Me.DataGridViewBoxoffice.DataSource = Me.BoxofficeBindingSource1
        Me.DataGridViewBoxoffice.Location = New System.Drawing.Point(6, 358)
        Me.DataGridViewBoxoffice.Name = "DataGridViewBoxoffice"
        Me.DataGridViewBoxoffice.RowHeadersVisible = False
        Me.DataGridViewBoxoffice.RowTemplate.Height = 23
        Me.DataGridViewBoxoffice.Size = New System.Drawing.Size(745, 65)
        Me.DataGridViewBoxoffice.TabIndex = 1
        '
        'NAmericaDataGridViewTextBoxColumn
        '
        Me.NAmericaDataGridViewTextBoxColumn.DataPropertyName = "NAmerica"
        Me.NAmericaDataGridViewTextBoxColumn.HeaderText = "NAmerica"
        Me.NAmericaDataGridViewTextBoxColumn.Name = "NAmericaDataGridViewTextBoxColumn"
        '
        'ChinaDataGridViewTextBoxColumn
        '
        Me.ChinaDataGridViewTextBoxColumn.DataPropertyName = "China"
        Me.ChinaDataGridViewTextBoxColumn.HeaderText = "China"
        Me.ChinaDataGridViewTextBoxColumn.Name = "ChinaDataGridViewTextBoxColumn"
        '
        'JapanDataGridViewTextBoxColumn
        '
        Me.JapanDataGridViewTextBoxColumn.DataPropertyName = "Japan"
        Me.JapanDataGridViewTextBoxColumn.HeaderText = "Japan"
        Me.JapanDataGridViewTextBoxColumn.Name = "JapanDataGridViewTextBoxColumn"
        '
        'HongkongDataGridViewTextBoxColumn
        '
        Me.HongkongDataGridViewTextBoxColumn.DataPropertyName = "Hongkong"
        Me.HongkongDataGridViewTextBoxColumn.HeaderText = "Hongkong"
        Me.HongkongDataGridViewTextBoxColumn.Name = "HongkongDataGridViewTextBoxColumn"
        '
        'FranceDataGridViewTextBoxColumn
        '
        Me.FranceDataGridViewTextBoxColumn.DataPropertyName = "France"
        Me.FranceDataGridViewTextBoxColumn.HeaderText = "France"
        Me.FranceDataGridViewTextBoxColumn.Name = "FranceDataGridViewTextBoxColumn"
        '
        'IndiaDataGridViewTextBoxColumn
        '
        Me.IndiaDataGridViewTextBoxColumn.DataPropertyName = "India"
        Me.IndiaDataGridViewTextBoxColumn.HeaderText = "India"
        Me.IndiaDataGridViewTextBoxColumn.Name = "IndiaDataGridViewTextBoxColumn"
        '
        'DetachDataGridViewTextBoxColumn
        '
        Me.DetachDataGridViewTextBoxColumn.DataPropertyName = "Detach"
        Me.DetachDataGridViewTextBoxColumn.HeaderText = "Detach"
        Me.DetachDataGridViewTextBoxColumn.Name = "DetachDataGridViewTextBoxColumn"
        '
        'SouthkoreaDataGridViewTextBoxColumn
        '
        Me.SouthkoreaDataGridViewTextBoxColumn.DataPropertyName = "Southkorea"
        Me.SouthkoreaDataGridViewTextBoxColumn.HeaderText = "Southkorea"
        Me.SouthkoreaDataGridViewTextBoxColumn.Name = "SouthkoreaDataGridViewTextBoxColumn"
        '
        'UKDataGridViewTextBoxColumn
        '
        Me.UKDataGridViewTextBoxColumn.DataPropertyName = "UK"
        Me.UKDataGridViewTextBoxColumn.HeaderText = "UK"
        Me.UKDataGridViewTextBoxColumn.Name = "UKDataGridViewTextBoxColumn"
        '
        'WorldwideDataGridViewTextBoxColumn
        '
        Me.WorldwideDataGridViewTextBoxColumn.DataPropertyName = "Worldwide"
        Me.WorldwideDataGridViewTextBoxColumn.HeaderText = "Worldwide"
        Me.WorldwideDataGridViewTextBoxColumn.Name = "WorldwideDataGridViewTextBoxColumn"
        '
        'BoxofficeBindingSource1
        '
        Me.BoxofficeBindingSource1.DataMember = "Boxoffice"
        Me.BoxofficeBindingSource1.DataSource = Me.BoxOfficeDataSetNEWBindingSource
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
        'Labelrelease
        '
        Me.Labelrelease.AutoSize = True
        Me.Labelrelease.Location = New System.Drawing.Point(58, 58)
        Me.Labelrelease.Name = "Labelrelease"
        Me.Labelrelease.Size = New System.Drawing.Size(54, 14)
        Me.Labelrelease.TabIndex = 0
        Me.Labelrelease.Text = "Release"
        '
        'BoxofficeBindingSource
        '
        Me.BoxofficeBindingSource.DataMember = "Boxoffice"
        Me.BoxofficeBindingSource.DataSource = Me.BoxOfficeDataSetBindingSource
        '
        'ActorBindingSource
        '
        Me.ActorBindingSource.DataMember = "Actor"
        Me.ActorBindingSource.DataSource = Me.BoxOfficeDataSetBindingSource
        '
        'ActorTableAdapter
        '
        Me.ActorTableAdapter.ClearBeforeFill = True
        '
        'Movie_Actor_cnTableAdapter
        '
        Me.Movie_Actor_cnTableAdapter.ClearBeforeFill = True
        '
        'BoxofficeTableAdapter
        '
        Me.BoxofficeTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(484, 479)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialogpicup
        '
        Me.OpenFileDialogpicup.FileName = "OpenFileDialogpicup"
        '
        'PictureBoxPrint
        '
        Me.PictureBoxPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxPrint.Image = CType(resources.GetObject("PictureBoxPrint.Image"), System.Drawing.Image)
        Me.PictureBoxPrint.Location = New System.Drawing.Point(242, 479)
        Me.PictureBoxPrint.Name = "PictureBoxPrint"
        Me.PictureBoxPrint.Size = New System.Drawing.Size(58, 52)
        Me.PictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPrint.TabIndex = 25
        Me.PictureBoxPrint.TabStop = False
        '
        'PictureBoxupdate
        '
        Me.PictureBoxupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxupdate.Image = CType(resources.GetObject("PictureBoxupdate.Image"), System.Drawing.Image)
        Me.PictureBoxupdate.Location = New System.Drawing.Point(310, 479)
        Me.PictureBoxupdate.Name = "PictureBoxupdate"
        Me.PictureBoxupdate.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxupdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxupdate.TabIndex = 27
        Me.PictureBoxupdate.TabStop = False
        '
        'PictureBoxdeleteall
        '
        Me.PictureBoxdeleteall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxdeleteall.Image = CType(resources.GetObject("PictureBoxdeleteall.Image"), System.Drawing.Image)
        Me.PictureBoxdeleteall.Location = New System.Drawing.Point(368, 479)
        Me.PictureBoxdeleteall.Name = "PictureBoxdeleteall"
        Me.PictureBoxdeleteall.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxdeleteall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxdeleteall.TabIndex = 28
        Me.PictureBoxdeleteall.TabStop = False
        '
        'PictureBoxdeleteactor
        '
        Me.PictureBoxdeleteactor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxdeleteactor.Image = CType(resources.GetObject("PictureBoxdeleteactor.Image"), System.Drawing.Image)
        Me.PictureBoxdeleteactor.Location = New System.Drawing.Point(426, 479)
        Me.PictureBoxdeleteactor.Name = "PictureBoxdeleteactor"
        Me.PictureBoxdeleteactor.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxdeleteactor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxdeleteactor.TabIndex = 29
        Me.PictureBoxdeleteactor.TabStop = False
        '
        'BoxofficeTableAdapter1
        '
        Me.BoxofficeTableAdapter1.ClearBeforeFill = True
        '
        'Movieshow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 538)
        Me.Controls.Add(Me.PictureBoxdeleteactor)
        Me.Controls.Add(Me.PictureBoxdeleteall)
        Me.Controls.Add(Me.PictureBoxupdate)
        Me.Controls.Add(Me.PictureBoxPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBoxMoviename)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Movieshow"
        Me.Text = "Movieshow"
        Me.GroupBoxMoviename.ResumeLayout(False)
        Me.GroupBoxMoviename.PerformLayout()
        Me.GroupBoxRating.ResumeLayout(False)
        Me.GroupBoxRating.PerformLayout()
        CType(Me.PictureBoxstar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxunrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxplaybill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieActorcnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBoxoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxofficeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxofficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxupdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxdeleteall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxdeleteactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxMoviename As GroupBox
    Friend WithEvents Labelrelease As Label
    Friend WithEvents LinkLabelseemore As LinkLabel
    Friend WithEvents DataGridViewBoxoffice As DataGridView
    Friend WithEvents Labelproduction As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelStudio As Label
    Friend WithEvents TextBoxproduction As TextBox
    Friend WithEvents TextBoxstudio As TextBox
    Friend WithEvents TextBoxdirector As TextBox
    Friend WithEvents TextBoxrelease As TextBox
    Friend WithEvents DataGridViewactor As DataGridView
    Friend WithEvents BoxOfficeDataSetBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSet As BoxOfficeDataSet
    Friend WithEvents ActorBindingSource As BindingSource
    Friend WithEvents ActorTableAdapter As BoxOfficeDataSetTableAdapters.ActorTableAdapter
    Friend WithEvents MovieActorcnBindingSource As BindingSource
    Friend WithEvents Movie_Actor_cnTableAdapter As BoxOfficeDataSetTableAdapters.Movie_Actor_cnTableAdapter
    Friend WithEvents BoxofficeBindingSource As BindingSource
    Friend WithEvents BoxofficeTableAdapter As BoxOfficeDataSetTableAdapters.BoxofficeTableAdapter
    Friend WithEvents PictureBoxplaybill As PictureBox
    Friend WithEvents Labelactor As Label
    Friend WithEvents Labelboxoffice As Label
    Friend WithEvents PictureBoxstar As PictureBox
    Friend WithEvents Labelratingnum As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxgenre As TextBox
    Friend WithEvents Labelgenre As Label
    Friend WithEvents MovienameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemunerationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Buttonpicup As Button
    Friend WithEvents NAmercicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialogpicup As OpenFileDialog
    Friend WithEvents GroupBoxRating As GroupBox
    Friend WithEvents PictureBoxunrate As PictureBox
    Friend WithEvents PictureBoxPrint As PictureBox
    Friend WithEvents PictureBoxupdate As PictureBox
    Friend WithEvents PictureBoxdeleteall As PictureBox
    Friend WithEvents PictureBoxdeleteactor As PictureBox
    Friend WithEvents BoxOfficeDataSetNEWBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSetNEW As BoxOfficeDataSetNEW
    Friend WithEvents BoxofficeBindingSource1 As BindingSource
    Friend WithEvents BoxofficeTableAdapter1 As BoxOfficeDataSetNEWTableAdapters.BoxofficeTableAdapter
    Friend WithEvents NAmericaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JapanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HongkongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FranceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetachDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SouthkoreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorldwideDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
