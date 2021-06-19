Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a(9), t, q As Long
        a(0) = InputBox("接下来您需要输入10个不同的整数", "1")
        a(1) = InputBox("您还需要输入9个不同的整数", "2")
        a(2) = InputBox("您还需要输入8个不同的整数", "3")
        a(3) = InputBox("您还需要输入7个不同的整数", "4")
        a(4) = InputBox("您还需要输入6个不同的整数", "5")
        a(5) = InputBox("您还需要输入5个不同的整数", "6")
        a(6) = InputBox("您还需要输入4个不同的整数", "7")
        a(7) = InputBox("您还需要输入3个不同的整数", "8")
        a(8) = InputBox("您还需要输入2个不同的整数", "9")
        a(9) = InputBox("您还需要输入1个不同的整数", "10")
        t = a(0)
        q = a(0)
        For i = 0 To 9
            If t <= a(i) Then
                t = a(i)
            End If
        Next i
        For k = 0 To 9
            If q >= a(k) Then
                q = a(k)
            End If
        Next k
        MsgBox("10个数中最大的是：" & t & vbCrLf & "10个数中最小数是：" & q)
    End Sub
End Class
