Imports System.Data
Imports System.Data.SqlClient
Public Class LogINForm
    Dim rdm As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RegisterForm.Show()
    End Sub
    Private Sub TextBoxUserID_onBlur(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxUserID.Leave
        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        Dim checkstr As String
        checkstr = "Select count(UserID) from UserTable where UserID ='" & Trim(TextBoxUserID.Text) & "'"
        sqlcmd = New SqlCommand(checkstr)
        sqlcmd.Connection = sqlcn
        Dim recount = sqlcmd.ExecuteScalar
        If recount = 0 Then
            LabelUserIDExist.Visible = True '显示用户名不存在
        Else
            LabelUserIDExist.Visible = False '用户更改后即可消失
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonlogon.Click '开始登录

        sqlcn = New SqlConnection()
        sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
        sqlcn.Open() '连接SQL
        Dim checkstr As String
        checkstr = "Select count(UserID) from UserTable where UserID ='" & Trim(TextBoxUserID.Text) & "'and Password ='" & Trim(TextBoxPW.Text) & "'"
        sqlcmd = New SqlCommand(checkstr)
        sqlcmd.Connection = sqlcn
        Dim recount = sqlcmd.ExecuteScalar
        If recount = 1 Then
            MsgBox("Log in succeed！" & vbCrLf & "Welcome back to BoxOffices Database 2019!", vbYes)
            Me.Close()
            CentralForm.Show()
            usertype = 1
            CurrentUsername = TextBoxUserID.Text
        Else
            MsgBox("Log in failed!" & vbCrLf & "Please check your ID and PW again!", vbInformation) '用户更改后即可消失
        End If

    End Sub

    Private Sub ButtonVisit_Click(sender As Object, e As EventArgs) Handles ButtonVisit.Click
        MsgBox("Welcome back to BoxOffices Database 2019!", vbYes)
        CentralForm.Show()
        usertype = 2
    End Sub


End Class
