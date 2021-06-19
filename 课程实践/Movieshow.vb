Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Movieshow
    Public dactor As SqlDataAdapter
    Public dactortable As DataTable
    Private Sub Movieshow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSetNEW.Boxoffice”中。您可以根据需要移动或删除它。
        Me.BoxofficeTableAdapter1.Fill(Me.BoxOfficeDataSetNEW.Boxoffice)

        'TODO: 这行代码将数据加载到表“BoxOfficeDataSet.Movie_Actor_cn”中。您可以根据需要移动或删除它。
        Me.Movie_Actor_cnTableAdapter.Fill(Me.BoxOfficeDataSet.Movie_Actor_cn)
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSet.Actor”中。您可以根据需要移动或删除它。
        Me.ActorTableAdapter.Fill(Me.BoxOfficeDataSet.Actor)
        GroupBoxMoviename.Text = Trim(Movieselected) '显示名称


        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        da.SelectCommand = New SqlCommand()
        da.SelectCommand.Connection = sqlcn
        da.SelectCommand.CommandText = "select * from Movie where Movietitle = '" & Movieselected & "'"
        Dim picset As New DataSet() '查看图片
        da.Fill(picset, "Movie")
        Dim seemore As String
        seemore = picset.Tables(0).Rows(0)("Poster")
        PictureBoxplaybill.ImageLocation = seemore

        Dim dset As New DataSet()
        da.Fill(dset, "Movie") '进行赋值输出
        TextBoxrelease.Text = dset.Tables(0).Rows(0)("Releasetime")
        TextBoxdirector.Text = dset.Tables(0).Rows(0)("Director")
        TextBoxstudio.Text = dset.Tables(0).Rows(0)("Studio")
        TextBoxproduction.Text = dset.Tables(0).Rows(0)("Production_Budget")
        TextBoxgenre.Text = dset.Tables(0).Rows(0)("Genre")

        Dim conn = New SqlConnection("server=(local);database=BoxOffice;Integrated Security=True")
        dactor = New SqlDataAdapter("select Moviename,Actorname,Remuneration from Movie_Actor_cn where Moviename = '" & Trim(Movieselected) & "'", conn) '查看演员
        dactortable = New DataTable
        dactor.Fill(dactortable)
        DataGridViewactor.DataSource = dactortable

        Dim dabf As New SqlDataAdapter '查看票房
        dabf.SelectCommand = New SqlCommand()
        dabf.SelectCommand.Connection = sqlcn
        dabf.SelectCommand.CommandText = "select NAmerica,China,Japan,Hongkong,France,India,Detach,Southkorea,UK,Worldwide from Boxoffice where Moviename = '" & Trim(Movieselected) & "'"
        Dim dsetbf As New DataSet()
        dabf.Fill(dsetbf, "Boxoffice")
        DataGridViewBoxoffice.DataSource = dsetbf
        DataGridViewBoxoffice.DataMember = "Boxoffice"

        Dim dart As New SqlDataAdapter '查看评星
        dart.SelectCommand = New SqlCommand()
        dart.SelectCommand.Connection = sqlcn
        dart.SelectCommand.CommandText = "select Rating from ViewRating where Movie ='" & Movieselected & "'"
        Dim darating As New DataSet
        dart.Fill(darating, "ViewRating")
        Labelratingnum.Text = darating.Tables(0).Rows(0)("Rating")
        PictureBoxstar.Width = Val(darating.Tables(0).Rows(0)("Rating")) * 20

    End Sub

    Private Sub LinkLabelseemore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelseemore.LinkClicked
        Dim dset As New DataSet() '打开更多信息
        da.Fill(dset, "Movie")
        Dim seemore As String
        seemore = dset.Tables(0).Rows(0)("Playbill")
        Process.Start("IEXPLORE.EXE", seemore)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close() '关闭窗体
    End Sub

    '打印声明  Specifies  what  happens  when  the  PrintPage  event  is  raised.  
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim obj As Bitmap
        Dim iData As IDataObject = Clipboard.GetDataObject()
        '  Determines  whether  the  data  is  in  a  format  you  can  use.  
        If iData.GetDataPresent(DataFormats.Bitmap) Then
            obj = iData.GetData(DataFormats.Bitmap)
            ev.Graphics.DrawImage(obj,
                    obj.GetBounds(System.Drawing.GraphicsUnit.Pixel))      'ev.Graphics.VisibleClipBounds)  
        End If
        ev.HasMorePages = False
    End Sub
    Private Sub PictureBoxPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxPrint.Click
        Try
            'Printscreen  
            SendKeys.SendWait("%{PRTSC}")
            '  Assumes  the  default  printer.  
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf Me.pd_PrintPage
            pd.DefaultPageSettings.Landscape = True
            pd.Print()
        Catch ex As Exception
            MessageBox.Show("An  error  occurred  while  printing" & vbCrLf &
                    ex.ToString(), "Error")
        End Try
    End Sub

    Private Sub PictureBoxstar_Click(sender As Object, e As EventArgs) Handles PictureBoxstar.Click
        If usertype = 2 Then '仅有管理员可以评分,这是往低处评分
            MsgBox("Only Administrator can rate.", vbInformation)
            Exit Sub
        Else
            Dim xmouse As Long
            xmouse = MousePosition.X
            Dim newrate As Long
            newrate = CInt((xmouse - 124) / 200)
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim ratestr As String
            ratestr = "Update MovieRating SET " & CurrentUsername & " =" & newrate & " where Movie = " & Movieselected '向制定属性值修改
            da.SelectCommand = New SqlCommand(ratestr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
        End If
    End Sub
    Private Sub PictureBoxunrate_Click(sender As Object, e As EventArgs)
        If usertype = 2 Then '仅有管理员可以评分,这是往高处评分
            MsgBox("Only Administrator can rate.", vbInformation)
            Exit Sub
        Else
            Dim xmouse As Long
            xmouse = MousePosition.X
            Dim newrate As Long
            newrate = CInt((324 - xmouse) / 200)
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim ratestr As String
            ratestr = "Update MovieRating SET " & CurrentUsername & " =" & newrate & " where Movie = " & Movieselected '向制定属性值修改
            da.SelectCommand = New SqlCommand(ratestr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Buttonpicup_Click(sender As Object, e As EventArgs) Handles Buttonpicup.Click
        If usertype = 2 Then '仅有管理员可以更改图片
            MsgBox("Only Administrator can update the filmposter.", vbInformation)
            Exit Sub
        Else
            Dim L_Err As String = "" '打开一张新的图片
            Dim opd As OpenFileDialog = New OpenFileDialog()
            opd.CheckFileExists = True
            opd.CheckPathExists = True
            opd.RestoreDirectory = True
            opd.DefaultExt = "*.*"
            opd.Filter = "图像文件 (*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png"
            opd.ShowDialog()
            If opd.FileName <> "" Then
                Me.PictureBoxplaybill.Image = Image.FromFile(opd.FileName)
                Me.PictureBoxplaybill.ImageLocation = opd.FileName
                sqlcn = New SqlConnection()
                sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
                sqlcn.Open() '连接SQL
                Dim ratestr As String
                ratestr = "Update Movie SET Poster = " & opd.FileName & "where movietitle = '" & Movieselected & "'" '向制定属性值修改
                da.SelectCommand = New SqlCommand(ratestr, sqlcn)
                da.SelectCommand.ExecuteNonQuery()
            End If
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
            Dim updtstr As String '更新Movie表中的信息
            updtstr = "Update Movie Set Releasetime ='" & TextBoxrelease.Text & "',Studio = '" & TextBoxstudio.Text & "',Director = '" & TextBoxdirector.Text & "',Production_Budget = '" & TextBoxproduction.Text & "',Genre ='" & TextBoxgenre.Text & "' where Movietitle ='" & Movieselected & "'"
            da.SelectCommand = New SqlCommand(updtstr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            '更新gridactor表
            Dim dactorup = New SqlCommandBuilder(dactor)
            dactor.Update(dactortable)
            MsgBox("Update successfully.", vbOK)
        End If
    End Sub

    Private Sub PictureBoxdeleteall_Click(sender As Object, e As EventArgs) Handles PictureBoxdeleteall.Click
        If usertype = 2 Then '仅有管理员可以删除
            MsgBox("Only Administrator can delete.", vbInformation)
            Exit Sub
        ElseIf MsgBox("Are you sure to delete the movie?" & vbCrLf & "Please think carefully. There's no way back.", vbOKCancel) = vbOK Then '提醒用户慎重考虑
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim dltstr1 As String '删除MovieRating Table & Movie表中的电影信息
            dltstr1 = "delete from a from Movie a inner join MovieRating b on a." & Movieselected & "=b." & Movieselected & " where a.Movietitle ='" & Movieselected & "'"
            da.SelectCommand = New SqlCommand(dltstr1, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            Dim dltstr2 As String '删除Movie_Actor_cn表中的电影信息
            dltstr2 = "delete from Movie_Actor_cn where Moviename ='" & Movieselected & "'"
            da.SelectCommand = New SqlCommand(dltstr2, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            Dim checkstr As String '开始检查是否删除成功
            checkstr = "Select count(Movietitle) from Movie where Movietitle ='" & Movieselected & "'"
            sqlcmd = New SqlCommand(checkstr)
            sqlcmd.Connection = sqlcn
            Dim recount = sqlcmd.ExecuteScalar
            If recount = 0 Then
                MsgBox("Delete succeed.")
                Me.Close()
            Else
                MsgBox("Oops! Register failed." & vbCrLf & "Please inform the Administrator.") '用户更改后即可消失
            End If
        End If
    End Sub

    Private Sub PictureBoxdeleteactor_Click(sender As Object, e As EventArgs) Handles PictureBoxdeleteactor.Click
        If usertype = 2 Then '仅有管理员可以删除改项
            MsgBox("Only Administrator can delete.", vbInformation)
            Exit Sub
        ElseIf MsgBox("Are you sure to delete the Actor?", vbOKCancel) = vbOK Then '提醒用户慎重考虑
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim dactstr As String '更新MovieActor表中的信息
            dactstr = "Delete from Movie_Actor_cn Where Actorname ='" & Str(DataGridViewactor.SelectedCells) & "'"
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
            DataGridViewactor.DataSource = dactortable
        End If
    End Sub
End Class