Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim connStr As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"
        Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Passwords = @Password"

        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

                Dim dt As New DataTable()
                Dim sda As New SqlDataAdapter(cmd)
                sda.Fill(dt)

                If dt.Rows.Count > 0 And Calculator.Checked Then
                    Me.Show()
                    Form1.Show()

                    MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf dt.Rows.Count > 0 And Admin_panel.Checked Then
                    Form3.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub


    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class


