Imports System.Data
Imports System.Data.SqlClient

Public Class RegisterForm

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("IEXPLORE.EXE", "https://mail.qq.com/cgi-bin/loginpage")
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
        If recount <> 0 Then
            LabelUserIDExisted.Visible = True '显示用户名已存在
            LabelUserIDable.Visible = False
        Else
            LabelUserIDExisted.Visible = False '用户更改后即可消失
            LabelUserIDable.Visible = True
        End If
    End Sub
    Private Sub TextBoxPW_onBlur(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxPW.Leave
        If Trim(TextBoxPW.Text) = "" Then '检测密码是否为空值
            LabelPWempty.Visible = True
        Else
            LabelPWempty.Visible = False
            LabelPWestimate.Visible = True '开始进行密码评估
            Select Case Len(TextBoxPW.Text)
                Case Is <= 6
                    LabelPWestimate.Text = "当前密码强度低"
                Case 7 To 12
                    LabelPWestimate.Text = "当前密码强度中"
                Case Else
                    LabelPWestimate.Text = "当前密码强度高"
            End Select
        End If
    End Sub
    Private Sub TextBoxREAFPW_onBlur(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxREAFPW.Leave
        If TextBoxPW.Text <> TextBoxREAFPW.Text Then '检测2次密码是否一致
            LabelPWDFT.Visible = True
        Else
            LabelPWDFT.Visible = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxPW.Text = TextBoxREAFPW.Text And TextBoxIvCode.Text = "HELLOWORLD" And TextBoxUserID.Text <> "" Then
            sqlcn = New SqlConnection()
            sqlcn.ConnectionString = "server=(local);database=BoxOffice;Integrated Security=True"
            sqlcn.Open() '连接SQL
            Dim instr As String
            instr = "INSERT INTO UserTable VALUES('" & Trim(TextBoxUserID.Text) & "','" & Trim(TextBoxPW.Text) & "')"
            da.SelectCommand = New SqlCommand(instr, sqlcn)
            da.SelectCommand.ExecuteNonQuery()
            Dim checkstr As String '开始检查是否插入成功
            checkstr = "Select count(UserID) from UserTable where UserID ='" & Trim(TextBoxUserID.Text) & "'"
            sqlcmd = New SqlCommand(checkstr)
            sqlcmd.Connection = sqlcn
            Dim recount = sqlcmd.ExecuteScalar
            If recount = 1 Then
                MsgBox("Congratulations! Register succeed.")
                Me.Close()
            Else
                MsgBox("Oops! Register failed." & vbCrLf & "Please inform the Administrator.") '用户更改后即可消失
            End If
        ElseIf TextBoxUserID.Text = "" Or TextBoxPW.Text = "" Then '检查用户是否修改完成
            MsgBox("No Null Values!")
        ElseIf TextBoxPW.Text = TextBoxREAFPW.Text Then
            MsgBox("Register Failed!" & vbCrLf & "Please check your Invitation Code again.", vbInformation)
        Else
            MsgBox("Please collate your PW and RePW!")
        End If
    End Sub

End Class