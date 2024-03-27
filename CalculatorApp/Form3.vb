Public Class Form3

    Public Shared Property LoggedInUserID As Integer
    Private Sub LogoutAd_Click(sender As Object, e As EventArgs) Handles LogoutAd.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class