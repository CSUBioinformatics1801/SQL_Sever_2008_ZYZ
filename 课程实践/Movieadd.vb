Imports System.Data.SqlClient

Public Class Movieadd
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close() '返回按钮
    End Sub

    Private Sub TextBoxMovietitle_Leave(sender As Object, e As EventArgs) Handles TextBoxMovietitle.Leave
        sqlcn = New SqlConnection() '电影名查重
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        Dim checkstr As String
        checkstr = "Select count(Movietitle) from Movie where Movietitle ='" & Trim(TextBoxMovietitle.Text) & "'"
        sqlcmd = New SqlCommand(checkstr)
        sqlcmd.Connection = sqlcn
        Dim recount = sqlcmd.ExecuteScalar
        If Trim(TextBoxMovietitle.Text) = "" Then
            LabelnameNULL.Visible = True '提醒电影名不能为空
        ElseIf recount <> 0 Then
            LabelnameNULL.Visible = False
            LabelmovieExisted.Visible = True '显示电影名已存在
            LabelMovieable.Visible = False
        ElseIf TextBoxProduction.Text = "" Or TextBoxBoxoffice.Text = "" Then
        ElseIf TextBoxProduction.Text <> Val(TextBoxProduction.Text) Or TextBoxBoxoffice.Text <> Val(TextBoxBoxoffice.Text) Then
            MsgBox("Production or Boxoffice must be integer!", vbInformation) '票房和成本必须是数字
        Else
            LabelnameNULL.Visible = False
            LabelmovieExisted.Visible = False '用户更改后即可消失
            LabelMovieable.Visible = True
        End If
    End Sub

    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click
        If Trim(TextBoxMovietitle.Text) <> "" Then
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim instr As String
            instr = "INSERT INTO Movie VALUES('" & Trim(TextBoxMovietitle.Text) & "','2019-06-21','" & TextBoxStudio.Text & "','" & TextBoxDirector.Text & "','" & ComboBoxGenre.Text & "','" & TextBoxProduction.Text & "','https://www.boxofficemojo.com/','" & PictureBoxposter.ImageLocation & "')"
            da.SelectCommand = New SqlCommand(instr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim instrrt As String
            instrrt = "insert into MovieRating values('" & Trim(TextBoxMovietitle.Text) & "'0','0')"

            Dim checkstr As String '开始检查是否插入成功
                checkstr = "Select count(Movietitle) from Movie where Movietitle ='" & Trim(TextBoxMovietitle.Text) & "'"
                sqlcmd = New SqlCommand(checkstr)
                sqlcmd.Connection = sqlcn
                Dim recount = sqlcmd.ExecuteScalar
                If recount = 1 Then
                    MsgBox("Congratulations! Register succeed.", vbInformation)
                    Me.Close()
                Else
                    MsgBox("Oops! Register failed." & vbCrLf & "Please inform the Administrator.") '用户更改后即可消失
                End If
            Else
                MsgBox("No empty moviename!", vbCritical)
        End If
    End Sub

    Private Sub Buttonupic_Click(sender As Object, e As EventArgs) Handles Buttonupic.Click
        If usertype = 2 Then '仅有管理员可以更改图片
            MsgBox("Only Administrator can update the filmposter.", vbInformation)
            Exit Sub
        Else
            PictureBoxnone.Visible = False
            Dim L_Err As String = "" '打开一张新的图片
            Dim opd As OpenFileDialog = New OpenFileDialog()
            opd.CheckFileExists = True
            opd.CheckPathExists = True
            opd.RestoreDirectory = True
            opd.DefaultExt = "*.*"
            opd.Filter = "图像文件 (*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png"
            opd.ShowDialog()
            If opd.FileName <> "" Then
                Me.PictureBoxposter.Image = Image.FromFile(opd.FileName)
                Me.PictureBoxposter.ImageLocation = opd.FileName

            End If
        End If
        'Dim opd As OpenFileDialog = New OpenFileDialog()
        'opd.CheckFileExists = True
        'opd.CheckPathExists = True
        'opd.RestoreDirectory = True
        'opd.DefaultExt = "*.*"
        'opd.Filter = "图像文件 (*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png"
        'opd.ShowDialog()
    End Sub
End Class