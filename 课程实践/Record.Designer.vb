<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record))
        Me.DataGridViewmovierank = New System.Windows.Forms.DataGridView()
        Me.BoxofficeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetNEW = New 电影票房数据库界面.BoxOfficeDataSetNEW()
        Me.BoxofficeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSet = New 电影票房数据库界面.BoxOfficeDataSet()
        Me.BoxofficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxofficeTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetTableAdapters.BoxofficeTableAdapter()
        Me.BoxofficeTableAdapter1 = New 电影票房数据库界面.BoxOfficeDataSetNEWTableAdapters.BoxofficeTableAdapter()
        Me.DataGridViewACsumBoxoffice = New System.Windows.Forms.DataGridView()
        Me.ActornameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SumBoxofficeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewACBoxofficeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoxOfficeDataSetView = New 电影票房数据库界面.BoxOfficeDataSetView()
        Me.ViewACBoxofficeTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetViewTableAdapters.ViewACBoxofficeTableAdapter()
        Me.GroupBoxAcrank = New System.Windows.Forms.GroupBox()
        Me.DataGridViewACRe = New System.Windows.Forms.DataGridView()
        Me.ActornameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUMRemunerationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewACmoneyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewACmoneyTableAdapter = New 电影票房数据库界面.BoxOfficeDataSetViewTableAdapters.ViewACmoneyTableAdapter()
        Me.PictureBoxclose = New System.Windows.Forms.PictureBox()
        Me.ComboBoxarea = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Labelyear = New System.Windows.Forms.Label()
        Me.Labelarea = New System.Windows.Forms.Label()
        Me.ComboBoxTime = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridViewmovierank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxofficeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxofficeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxofficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewACsumBoxoffice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewACBoxofficeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxOfficeDataSetView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAcrank.SuspendLayout()
        CType(Me.DataGridViewACRe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewACmoneyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewmovierank
        '
        Me.DataGridViewmovierank.AllowUserToAddRows = False
        Me.DataGridViewmovierank.AllowUserToDeleteRows = False
        Me.DataGridViewmovierank.AllowUserToOrderColumns = True
        Me.DataGridViewmovierank.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewmovierank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewmovierank.Location = New System.Drawing.Point(19, 80)
        Me.DataGridViewmovierank.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridViewmovierank.Name = "DataGridViewmovierank"
        Me.DataGridViewmovierank.RowHeadersVisible = False
        Me.DataGridViewmovierank.RowTemplate.Height = 23
        Me.DataGridViewmovierank.Size = New System.Drawing.Size(324, 343)
        Me.DataGridViewmovierank.TabIndex = 0
        '
        'BoxofficeBindingSource2
        '
        Me.BoxofficeBindingSource2.DataMember = "Boxoffice"
        Me.BoxofficeBindingSource2.DataSource = Me.BoxOfficeDataSetNEWBindingSource
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
        'BoxofficeBindingSource1
        '
        Me.BoxofficeBindingSource1.DataMember = "Boxoffice"
        Me.BoxofficeBindingSource1.DataSource = Me.BoxOfficeDataSetBindingSource
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
        'BoxofficeBindingSource
        '
        Me.BoxofficeBindingSource.DataMember = "Boxoffice"
        Me.BoxofficeBindingSource.DataSource = Me.BoxOfficeDataSet
        '
        'BoxofficeTableAdapter
        '
        Me.BoxofficeTableAdapter.ClearBeforeFill = True
        '
        'BoxofficeTableAdapter1
        '
        Me.BoxofficeTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewACsumBoxoffice
        '
        Me.DataGridViewACsumBoxoffice.AllowUserToAddRows = False
        Me.DataGridViewACsumBoxoffice.AllowUserToDeleteRows = False
        Me.DataGridViewACsumBoxoffice.AllowUserToOrderColumns = True
        Me.DataGridViewACsumBoxoffice.AutoGenerateColumns = False
        Me.DataGridViewACsumBoxoffice.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewACsumBoxoffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewACsumBoxoffice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActornameDataGridViewTextBoxColumn, Me.SumBoxofficeDataGridViewTextBoxColumn})
        Me.DataGridViewACsumBoxoffice.DataSource = Me.ViewACBoxofficeBindingSource
        Me.DataGridViewACsumBoxoffice.Location = New System.Drawing.Point(22, 25)
        Me.DataGridViewACsumBoxoffice.Name = "DataGridViewACsumBoxoffice"
        Me.DataGridViewACsumBoxoffice.RowHeadersVisible = False
        Me.DataGridViewACsumBoxoffice.RowTemplate.Height = 23
        Me.DataGridViewACsumBoxoffice.Size = New System.Drawing.Size(216, 398)
        Me.DataGridViewACsumBoxoffice.TabIndex = 2
        '
        'ActornameDataGridViewTextBoxColumn
        '
        Me.ActornameDataGridViewTextBoxColumn.DataPropertyName = "Actorname"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ActornameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ActornameDataGridViewTextBoxColumn.HeaderText = "Actorname"
        Me.ActornameDataGridViewTextBoxColumn.Name = "ActornameDataGridViewTextBoxColumn"
        '
        'SumBoxofficeDataGridViewTextBoxColumn
        '
        Me.SumBoxofficeDataGridViewTextBoxColumn.DataPropertyName = "SumBoxoffice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.SumBoxofficeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SumBoxofficeDataGridViewTextBoxColumn.HeaderText = "SumBoxoffice"
        Me.SumBoxofficeDataGridViewTextBoxColumn.Name = "SumBoxofficeDataGridViewTextBoxColumn"
        Me.SumBoxofficeDataGridViewTextBoxColumn.Width = 110
        '
        'ViewACBoxofficeBindingSource
        '
        Me.ViewACBoxofficeBindingSource.DataMember = "ViewACBoxoffice"
        Me.ViewACBoxofficeBindingSource.DataSource = Me.BoxOfficeDataSetViewBindingSource
        '
        'BoxOfficeDataSetViewBindingSource
        '
        Me.BoxOfficeDataSetViewBindingSource.DataSource = Me.BoxOfficeDataSetView
        Me.BoxOfficeDataSetViewBindingSource.Position = 0
        '
        'BoxOfficeDataSetView
        '
        Me.BoxOfficeDataSetView.DataSetName = "BoxOfficeDataSetView"
        Me.BoxOfficeDataSetView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewACBoxofficeTableAdapter
        '
        Me.ViewACBoxofficeTableAdapter.ClearBeforeFill = True
        '
        'GroupBoxAcrank
        '
        Me.GroupBoxAcrank.Controls.Add(Me.DataGridViewACRe)
        Me.GroupBoxAcrank.Controls.Add(Me.DataGridViewACsumBoxoffice)
        Me.GroupBoxAcrank.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBoxAcrank.Location = New System.Drawing.Point(383, 25)
        Me.GroupBoxAcrank.Name = "GroupBoxAcrank"
        Me.GroupBoxAcrank.Size = New System.Drawing.Size(480, 442)
        Me.GroupBoxAcrank.TabIndex = 3
        Me.GroupBoxAcrank.TabStop = False
        Me.GroupBoxAcrank.Text = "Actor Rank"
        '
        'DataGridViewACRe
        '
        Me.DataGridViewACRe.AllowUserToAddRows = False
        Me.DataGridViewACRe.AllowUserToDeleteRows = False
        Me.DataGridViewACRe.AutoGenerateColumns = False
        Me.DataGridViewACRe.BackgroundColor = System.Drawing.Color.Beige
        Me.DataGridViewACRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewACRe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ActornameDataGridViewTextBoxColumn1, Me.SUMRemunerationDataGridViewTextBoxColumn})
        Me.DataGridViewACRe.DataSource = Me.ViewACmoneyBindingSource
        Me.DataGridViewACRe.Location = New System.Drawing.Point(244, 25)
        Me.DataGridViewACRe.Name = "DataGridViewACRe"
        Me.DataGridViewACRe.RowHeadersVisible = False
        Me.DataGridViewACRe.RowTemplate.Height = 23
        Me.DataGridViewACRe.Size = New System.Drawing.Size(230, 398)
        Me.DataGridViewACRe.TabIndex = 3
        '
        'ActornameDataGridViewTextBoxColumn1
        '
        Me.ActornameDataGridViewTextBoxColumn1.DataPropertyName = "Actorname"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ActornameDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.ActornameDataGridViewTextBoxColumn1.HeaderText = "Actorname"
        Me.ActornameDataGridViewTextBoxColumn1.Name = "ActornameDataGridViewTextBoxColumn1"
        '
        'SUMRemunerationDataGridViewTextBoxColumn
        '
        Me.SUMRemunerationDataGridViewTextBoxColumn.DataPropertyName = "SUMRemuneration"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.SUMRemunerationDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SUMRemunerationDataGridViewTextBoxColumn.HeaderText = "SUMRemuneration"
        Me.SUMRemunerationDataGridViewTextBoxColumn.Name = "SUMRemunerationDataGridViewTextBoxColumn"
        Me.SUMRemunerationDataGridViewTextBoxColumn.Width = 125
        '
        'ViewACmoneyBindingSource
        '
        Me.ViewACmoneyBindingSource.DataMember = "ViewACmoney"
        Me.ViewACmoneyBindingSource.DataSource = Me.BoxOfficeDataSetViewBindingSource
        '
        'ViewACmoneyTableAdapter
        '
        Me.ViewACmoneyTableAdapter.ClearBeforeFill = True
        '
        'PictureBoxclose
        '
        Me.PictureBoxclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxclose.Image = CType(resources.GetObject("PictureBoxclose.Image"), System.Drawing.Image)
        Me.PictureBoxclose.Location = New System.Drawing.Point(811, 474)
        Me.PictureBoxclose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxclose.Name = "PictureBoxclose"
        Me.PictureBoxclose.Size = New System.Drawing.Size(52, 52)
        Me.PictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxclose.TabIndex = 21
        Me.PictureBoxclose.TabStop = False
        '
        'ComboBoxarea
        '
        Me.ComboBoxarea.FormattingEnabled = True
        Me.ComboBoxarea.Items.AddRange(New Object() {"NAmerica", "China", "Japan", "Hongkong", "France", "India", "Detach", "Southkorea", "UK", "Worldwide"})
        Me.ComboBoxarea.Location = New System.Drawing.Point(111, 21)
        Me.ComboBoxarea.Name = "ComboBoxarea"
        Me.ComboBoxarea.Size = New System.Drawing.Size(136, 22)
        Me.ComboBoxarea.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labelyear)
        Me.GroupBox1.Controls.Add(Me.Labelarea)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTime)
        Me.GroupBox1.Controls.Add(Me.ComboBoxarea)
        Me.GroupBox1.Controls.Add(Me.DataGridViewmovierank)
        Me.GroupBox1.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 442)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Box-Office Rank"
        '
        'Labelyear
        '
        Me.Labelyear.AutoSize = True
        Me.Labelyear.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Labelyear.Location = New System.Drawing.Point(19, 52)
        Me.Labelyear.Name = "Labelyear"
        Me.Labelyear.Size = New System.Drawing.Size(40, 17)
        Me.Labelyear.TabIndex = 13
        Me.Labelyear.Text = "Year"
        '
        'Labelarea
        '
        Me.Labelarea.AutoSize = True
        Me.Labelarea.Font = New System.Drawing.Font("等线", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Labelarea.Location = New System.Drawing.Point(19, 21)
        Me.Labelarea.Name = "Labelarea"
        Me.Labelarea.Size = New System.Drawing.Size(42, 17)
        Me.Labelarea.TabIndex = 12
        Me.Labelarea.Text = "Area"
        '
        'ComboBoxTime
        '
        Me.ComboBoxTime.FormattingEnabled = True
        Me.ComboBoxTime.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009"})
        Me.ComboBoxTime.Location = New System.Drawing.Point(111, 52)
        Me.ComboBoxTime.Name = "ComboBoxTime"
        Me.ComboBoxTime.Size = New System.Drawing.Size(136, 22)
        Me.ComboBoxTime.TabIndex = 11
        '
        'Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBoxclose)
        Me.Controls.Add(Me.GroupBoxAcrank)
        Me.Font = New System.Drawing.Font("等线", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Record"
        Me.Text = "Record"
        CType(Me.DataGridViewmovierank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxofficeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetNEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxofficeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxofficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewACsumBoxoffice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewACBoxofficeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxOfficeDataSetView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAcrank.ResumeLayout(False)
        CType(Me.DataGridViewACRe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewACmoneyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewmovierank As DataGridView
    Friend WithEvents BoxOfficeDataSet As BoxOfficeDataSet
    Friend WithEvents BoxofficeBindingSource As BindingSource
    Friend WithEvents BoxofficeTableAdapter As BoxOfficeDataSetTableAdapters.BoxofficeTableAdapter
    Friend WithEvents BoxofficeBindingSource1 As BindingSource
    Friend WithEvents BoxOfficeDataSetBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSetNEWBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSetNEW As BoxOfficeDataSetNEW
    Friend WithEvents BoxofficeBindingSource2 As BindingSource
    Friend WithEvents BoxofficeTableAdapter1 As BoxOfficeDataSetNEWTableAdapters.BoxofficeTableAdapter
    Friend WithEvents DataGridViewACsumBoxoffice As DataGridView
    Friend WithEvents BoxOfficeDataSetViewBindingSource As BindingSource
    Friend WithEvents BoxOfficeDataSetView As BoxOfficeDataSetView
    Friend WithEvents ViewACBoxofficeBindingSource As BindingSource
    Friend WithEvents ViewACBoxofficeTableAdapter As BoxOfficeDataSetViewTableAdapters.ViewACBoxofficeTableAdapter
    Friend WithEvents GroupBoxAcrank As GroupBox
    Friend WithEvents DataGridViewACRe As DataGridView
    Friend WithEvents ViewACmoneyBindingSource As BindingSource
    Friend WithEvents ViewACmoneyTableAdapter As BoxOfficeDataSetViewTableAdapters.ViewACmoneyTableAdapter
    Friend WithEvents PictureBoxclose As PictureBox
    Friend WithEvents ComboBoxarea As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ActornameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SumBoxofficeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActornameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SUMRemunerationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Labelyear As Label
    Friend WithEvents Labelarea As Label
    Friend WithEvents ComboBoxTime As ComboBox
End Class
