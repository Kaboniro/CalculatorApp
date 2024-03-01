Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Dim username, password As String
        username = txtusername.Text
        password = txtpassword.Text

        If username = "Admin" And password = "Pass" Then
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password!")
            Me.Show()
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
        End If
    End Sub
End Class