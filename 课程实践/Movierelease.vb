Imports System.Data.SqlClient
Public Class Movierelease
    Public dactor As SqlDataAdapter
    Public dactortable As DataTable
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Movierelease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSet.Movieunreleased”中。您可以根据需要移动或删除它。
        Me.MovieunreleasedTableAdapter.Fill(Me.BoxOfficeDataSet.Movieunreleased)

    End Sub
    Private Sub ComboBoxRelease_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRelease.SelectedIndexChanged
        '筛选年份功能
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        da.SelectCommand = New SqlCommand()
        da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
        da.SelectCommand.CommandText = "select * from Movieunreleased where Releasetime like '%" & ComboBoxRelease.Text & "%' and Genre like '%" & ComboBoxGenre.Text & "%'"
        Dim dset As New DataSet()
        da.Fill(dset, "Movie")
        DataGridViewrelease.DataSource = dset
        DataGridViewrelease.DataMember = "Movie"
    End Sub

    Private Sub ComboBoxGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGenre.SelectedIndexChanged
        '筛选类别功能
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        da.SelectCommand = New SqlCommand()
        da.SelectCommand.Connection = sqlcn '取右边4个字符，即年份
        da.SelectCommand.CommandText = "select * from Movieunreleased where Genre like '%" & ComboBoxGenre.Text & "%' and Releasetime like '%" & ComboBoxRelease.Text & "%'"
        Dim dset As New DataSet()
        da.Fill(dset, "Movie")
        DataGridViewrelease.DataSource = dset
        DataGridViewrelease.DataMember = "Movie"
    End Sub

    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DataGridViewrelease '打印报表
            Using fmt As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .FormatFlags = StringFormatFlags.NoWrap, .Trimming = StringTrimming.EllipsisCharacter}
                Dim y As Single = e.MarginBounds.Top
                Dim scl As Single = 1.0F
                Dim wdth As Integer = 1
                For Each c As DataGridViewColumn In DataGridViewrelease.Columns
                    wdth += c.Width
                Next
                If wdth > e.MarginBounds.Width Then scl = CSng(e.MarginBounds.Width / wdth)
                newpage = True
                Do While mRow < .RowCount
                    Dim row As DataGridViewRow = .Rows(mRow)
                    Dim x As Single = e.MarginBounds.Left
                    Dim h As Single = 0
                    For Each cell As DataGridViewCell In row.Cells
                        Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width * scl, cell.Size.Height)
                        e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                        If (newpage) Then
                            e.Graphics.DrawString(DataGridViewrelease.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                        Else
                            e.Graphics.DrawString(DataGridViewrelease.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                        End If
                        x += rc.Width
                        h = Math.Max(h, rc.Height)
                    Next
                    If Not newpage Then mRow += 1
                    newpage = False
                    y += h
                    If y + h > e.MarginBounds.Bottom Then
                        e.HasMorePages = True
                        mRow -= 1
                        newpage = True
                        Exit Sub
                    End If
                Loop
                mRow = 0
            End Using
        End With
    End Sub

    Private Sub PictureBoxPrint_Click(sender As Object, e As EventArgs) Handles PictureBoxPrint.Click
        PrintDocument1.Print() '执行打印功能
    End Sub

    Private Sub PictureBoxdeleteall_Click(sender As Object, e As EventArgs) Handles PictureBoxdeleteall.Click
        If usertype = 2 Then '仅有管理员可以删除改项
            MsgBox("Only Administrator can delete.", vbInformation)
            Exit Sub
        ElseIf MsgBox("Are you sure to delete the Movie?", vbOKCancel) = vbOK Then '提醒用户慎重考虑
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim dactstr As String '更新MovieActor表中的信息
            dactstr = "Delete from Movie_Actor_cn Where Actorname ='" & Str(DataGridViewrelease.SelectedCells) & "'"
            da.SelectCommand = New SqlCommand(dactstr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            '更新gridactor表
            Dim dactorup = New SqlCommandBuilder(dactor)
            dactor.Update(dactortable)
            MsgBox("Delete successfully.", vbOK)
            '更新表
            Dim conn = New SqlConnection("server=(local);database=BoxOffice;Integrated Security=True")
            dactor = New SqlDataAdapter("select Moviename,Actorname,Remuneration from Movie_Actor_cn where Moviename = '" & Trim(Movieselected) & "'", conn) '查看演员
            dactortable = New DataTable
            dactor.Fill(dactortable)
            DataGridViewrelease.DataSource = dactortable
        End If
    End Sub

    Private Sub PictureBoxupdate_Click(sender As Object, e As EventArgs) Handles PictureBoxupdate.Click
        If usertype = 2 Then '仅有管理员可以更改
            MsgBox("Only Administrator can update.", vbInformation)
            Exit Sub
        ElseIf MsgBox("Are you sure to update?", vbOKCancel) = vbOK Then '提醒用户慎重考虑
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim dactorup = New SqlCommandBuilder(dactor)
            dactor.Update(dactortable)
            MsgBox("Update successfully.", vbOK)
        End If
    End Sub
End Class