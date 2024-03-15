Public Class Form2

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim username, password As String
        username = txtusername.Text
        password = txtpassword.Text

        If username = "Admin" And password = "Pass" And Calculator.Checked Then
            Form1.Show()
            Me.Hide()
        ElseIf username = "Admin" And password = "Pass" And Admin_panel.Checked Then
            Form3.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password!")
            Me.Show()
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub
End Class