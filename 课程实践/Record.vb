Imports System.Data.SqlClient
Public Class Record
    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSetView.ViewACmoney”中。您可以根据需要移动或删除它。
        Me.ViewACmoneyTableAdapter.Fill(Me.BoxOfficeDataSetView.ViewACmoney)
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSetView.ViewACBoxoffice”中。您可以根据需要移动或删除它。
        Me.ViewACBoxofficeTableAdapter.Fill(Me.BoxOfficeDataSetView.ViewACBoxoffice)
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSetNEW.Boxoffice”中。您可以根据需要移动或删除它。
        Me.BoxofficeTableAdapter1.Fill(Me.BoxOfficeDataSetNEW.Boxoffice)
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSet.Boxoffice”中。您可以根据需要移动或删除它。
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL

        Dim msch As New SqlDataAdapter '获得演员总票房信息
        msch.SelectCommand = New SqlCommand()
        msch.SelectCommand.Connection = sqlcn
        msch.SelectCommand.CommandText = "select * from ViewACBoxoffice order by SumBoxoffice desc"
        Dim dset As New DataSet()
        msch.Fill(dset, "ViewACBoxoffice")
        DataGridViewACRe.DataSource = dset
        DataGridViewACRe.DataMember = "ViewACBoxoffice"

        Dim acre As New SqlDataAdapter '获得总片酬信息
        acre.SelectCommand = New SqlCommand()
        acre.SelectCommand.Connection = sqlcn
        acre.SelectCommand.CommandText = "select * from ViewACmoney order by SUMRemuneration desc"
        Dim dsetacre As New DataSet()
        acre.Fill(dsetacre, "ViewACmoney")
        DataGridViewACRe.DataSource = dsetacre
        DataGridViewACRe.DataMember = "ViewACmoney"

        Dim movieboxoffice As New SqlDataAdapter
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxclose.Click
        Me.Close() '关闭当前窗口
    End Sub

    Private Sub ComboBoxarea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxarea.SelectedIndexChanged
        If ComboBoxTime.Text = "" Then '若没有选择年份，则默认所有年份
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
            da.SelectCommand.CommandText = "select a.moviename,a." & ComboBoxarea.Text & " ,year(b.Releasetime) as Year from Boxoffice a inner join Movie b on a.Moviename=b.Movietitle"
            Dim dset As New DataSet()
            da.Fill(dset, "Boxoffice")
            DataGridViewmovierank.DataSource = dset
            DataGridViewmovierank.DataMember = "Boxoffice"
        Else
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
            da.SelectCommand.CommandText = "select a.moviename,a." & ComboBoxarea.Text & " ,year(b.Releasetime) as Year from Boxoffice a inner join Movie b on a.Moviename=b.Movietitle where year(b.Releasetime)=" & Val(ComboBoxTime.Text) & ""
            Dim dset As New DataSet()
            da.Fill(dset, "Boxoffice")
            DataGridViewmovierank.DataSource = dset
            DataGridViewmovierank.DataMember = "Boxoffice"
        End If
    End Sub

    Private Sub ComboBoxTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTime.SelectedIndexChanged
        If ComboBoxarea.Text = "" Then '若没有选择地区，则默认选择worldwide
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
            da.SelectCommand.CommandText = "select a.moviename,a.worldwide,year(b.Releasetime) as Year from Boxoffice a inner join movie b on a.Moviename=b.Movietitle where year(b.Releasetime)=" & ComboBoxTime.Text & ""
            Dim dset As New DataSet()
            da.Fill(dset, "Boxoffice")
            DataGridViewmovierank.DataSource = dset
            DataGridViewmovierank.DataMember = "Boxoffice"
        Else '正常连接
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
            da.SelectCommand.CommandText = "select a.moviename,a." & ComboBoxarea.Text & " ,year(b.Releasetime) as Year from Boxoffice a inner join movie b on a.Moviename=b.Movietitle where year(b.Releasetime)=" & ComboBoxTime.Text & ""
            Dim dset As New DataSet()
            da.Fill(dset, "Boxoffice")
            DataGridViewmovierank.DataSource = dset
            DataGridViewmovierank.DataMember = "Boxoffice"
        End If
    End Sub
End Class