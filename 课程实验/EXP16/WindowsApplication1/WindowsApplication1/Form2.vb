Public Class Form2
    Private Sub COPYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COPYToolStripMenuItem.Click
        Label1.Text = "Start" & Str(TextBox1.SelectionStart)
        Label2.Text = "Length" + Str(TextBox1.SelectionLength)
    End Sub

    Private Sub COlORChangeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COlORChangeToolStripMenuItem.Click
        Form1.Show()
        Me.Finalize()
    End Sub
End Class