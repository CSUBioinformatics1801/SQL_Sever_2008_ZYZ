Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = DateTime.Now
        Label2.Text = Now.ToString("yyyy-mm-dd")
        Label3.Text = DateTime.Today
        Label4.Text = Now.Hour
    End Sub
End Class
