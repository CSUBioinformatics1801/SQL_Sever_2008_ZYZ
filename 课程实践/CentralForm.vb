Imports System.Data.SqlClient

Public Class CentralForm
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        If usertype = 2 Then
            MsgBox("Only Administrator can operate.")
            Exit Sub
        Else
            Movieadd.Show()
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        If Trim(TextBoxMovie.Text) = "" Then '输入不能为空
            MsgBox("You input nothing.", vbBack)
        Else
            Dim msch As New SqlDataAdapter
            msch.SelectCommand = New SqlCommand()
            msch.SelectCommand.Connection = sqlcn
            msch.SelectCommand.CommandText = "select Movietitle,Releasetime,Genre from Movie where Movietitle like '%" & Trim(TextBoxMovie.Text) & "%'"
            Dim dset As New DataSet()
            msch.Fill(dset, "Movie")
            DataGridViewmovie.DataSource = dset
            DataGridViewmovie.DataMember = "Movie"
        End If
    End Sub

    Private Sub DataGridViewmovie_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewmovie.CellContentDoubleClick
        Movieselected = DataGridViewmovie.CurrentCell.Value
        Movieshow.ShowDialog()
    End Sub

    Private Sub CentralForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSetNEW.Movie”中。您可以根据需要移动或删除它。
        Me.MovieTableAdapter1.Fill(Me.BoxOfficeDataSetNEW.Movie)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MovieTableAdapter.FillBy(Me.BoxOfficeDataSet.Movie)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBoxRelease_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRelease.SelectedIndexChanged
        '筛选年份功能
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        da.SelectCommand = New SqlCommand()
        da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
        da.SelectCommand.CommandText = "select * from Movie where Releasetime like '%" & ComboBoxRelease.Text & "%' and Genre like '%" & ComboBoxGenre.Text & "%'"
        Dim dset As New DataSet()
        da.Fill(dset, "Movie")
        DataGridViewmovie.DataSource = dset
        DataGridViewmovie.DataMember = "Movie"
    End Sub

    Private Sub ComboBoxGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGenre.SelectedIndexChanged
        '筛选类别功能
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        da.SelectCommand = New SqlCommand()
        da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
        da.SelectCommand.CommandText = "select * from Movie where Genre like '%" & ComboBoxGenre.Text & "%' and Releasetime like '%" & ComboBoxRelease.Text & "%'"
        Dim dset As New DataSet()
        da.Fill(dset, "Movie")
        DataGridViewmovie.DataSource = dset
        DataGridViewmovie.DataMember = "Movie"

    End Sub

    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseToolStripMenuItem.Click
        Movierelease.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Threading.Thread.Sleep(1000)
        MsgBox("The version is V1.0.0" & vbCrLf & "You are up to date.", vbOKOnly)
    End Sub '无聊地检查最新版，欺骗使用者

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Exit or not?", vbOKCancel, "Yse") = vbOK Then
            Me.Close()
        End If '退出界面
    End Sub

    Private Sub MyInfomationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyInfomationToolStripMenuItem.Click
        Userinfo.Show() '打开用户信息界面
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        Record.ShowDialog() '打开记录窗体
    End Sub

End Class