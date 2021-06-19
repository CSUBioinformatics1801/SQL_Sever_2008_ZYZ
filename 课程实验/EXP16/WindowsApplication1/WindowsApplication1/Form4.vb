Public Class Form4

    Dim i = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "CXK" And TextBox2.Text = "1111" Then
            MsgBox("Successfully log on!" & vbCrLf & "Come to see me NOW!!!")
            Form3.Show()
            Me.Finalize()
        ElseIf 3 - i > 0 Then
            i = i + 1
            MsgBox("Go checking your fucking ID and PW!!!" & vbCrLf & "Log on failed,you can try again " & 3 - i & " times")
        Else
            MsgBox("You will never be allow to see 蔡徐坤 again")
            Me.Finalize()
        End If
    End Sub
End Class