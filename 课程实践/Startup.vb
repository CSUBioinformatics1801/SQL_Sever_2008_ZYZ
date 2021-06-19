Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(1500)
        LogINForm.Show()
        Me.Hide()
    End Sub
End Class