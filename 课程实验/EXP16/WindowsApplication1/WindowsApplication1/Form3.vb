Public Class Form3

    Dim lx, ly As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lx = PictureBox1.Location.X
        ly = PictureBox1.Location.Y
        If ly < Me.Size.Height Then
            ly = ly + 15
            PictureBox1.Location = New Point(lx, ly)
        Else
            PictureBox1.Location = New Point(lx, -PictureBox1.Size.Height)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub
End Class