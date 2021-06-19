Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim c As Long
        Dim a As String
        a = InputBox("请输入一个整数", "输入框")
        If a = Int(a) Then
            c = 1
            For i = 1 To Int(a)
                c = c * i
            Next i
            MsgBox("计算结果为" & c)
        Else
            Debug.Print("您输入的不是整数")
        End If
    End Sub
End Class
