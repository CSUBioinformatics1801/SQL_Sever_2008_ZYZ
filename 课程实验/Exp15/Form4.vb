Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        If TextBox1.Text = Val(TextBox1.Text) Then
            n = Val(TextBox1.Text)
            For i = 1 To n
                Debug.Print(i)
                i = i + 1
            Next i
        End If

    End Sub
End Class
