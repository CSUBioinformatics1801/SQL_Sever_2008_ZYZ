Imports System.Data
Imports System.Data.SqlClient
Public Class Userinfo
    Private Sub Userinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“BoxOfficeDataSet.UserTable”中。您可以根据需要移动或删除它。
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        If CurrentUsername = "" Then
            CurrentUsername = "User001"
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn
            da.SelectCommand.CommandText = "select * from UserTable where UserID = '" & CurrentUsername & "'"
            Dim dset As New DataSet()
            da.Fill(dset, "UserTable") '进行赋值输出当前用户名
            TextBoxUsername.Text = dset.Tables(0).Rows(0)("UserID")
        Else
            da.SelectCommand = New SqlCommand()
            da.SelectCommand.Connection = sqlcn
            da.SelectCommand.CommandText = "select * from UserTable where UserID = '" & CurrentUsername & "'"
            Dim dset As New DataSet()
            da.Fill(dset, "UserTable") '进行赋值输出当前用户名
            TextBoxUsername.Text = dset.Tables(0).Rows(0)("UserID")
        End If

    End Sub

    Private Sub PictureBoxback_Click(sender As Object, e As EventArgs) Handles PictureBoxback.Click
        Me.Close() '关闭窗口
    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        Dim checkstr As String
        checkstr = "Select count(UserID) from UserTable where UserID ='" & Trim(TextBoxUsername.Text) & "'"
        sqlcmd = New SqlCommand(checkstr)
        sqlcmd.Connection = sqlcn
        Dim recount = sqlcmd.ExecuteScalar
        If recount <> 0 Then
            Labelusernameexist.Visible = True '显示用户名已存在
            LabelUserIDable.Visible = False
        Else
            Labelusernameexist.Visible = False '用户更改后即可消失
            LabelUserIDable.Visible = True
        End If
    End Sub

    Private Sub TextBoxnewpw_Leave(sender As Object, e As EventArgs) Handles TextBoxnewpw.Leave
        If Trim(TextBoxnewpw.Text) = "" Then '检测密码是否为空值
            LabelPWempty.Visible = True
        ElseIf TextBoxnewpw.Text <> TextBoxcknewpw.Text Then '检测2次密码是否一致
            LabelPWDFT.Visible = True
        Else
            LabelPWDFT.Visible = False

        End If
    End Sub


    Private Sub PictureBoxupdate_Click(sender As Object, e As EventArgs) Handles PictureBoxupdate.Click
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        Dim checkstr As String
        checkstr = "Select count(UserID) from UserTable where UserID ='" & CurrentUsername & "'and Password ='" & Trim(TextBoxoldpw.Text) & "'"
        sqlcmd = New SqlCommand(checkstr)
        sqlcmd.Connection = sqlcn
        Dim recount = sqlcmd.ExecuteScalar
        If recount = 1 Then
            Dim upstr As String
            upstr = "Update UserTable SET UserID = '" & TextBoxUsername.Text & "',Password ='" & TextBoxnewpw.Text & "where UserID = '" & CurrentUsername & "'"
            MsgBox("Update Successfull!", vbYes)
        Else
            MsgBox("Update failed!" & vbCrLf & "Please check your PW again!", vbInformation)
        End If
    End Sub

    Private Sub PictureBoxlogout_Click(sender As Object, e As EventArgs) Handles PictureBoxlogout.Click
        Me.Close()
        LogINForm.Show()
        usertype = 0
    End Sub
End Class