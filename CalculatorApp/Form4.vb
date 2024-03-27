Imports System.Data
Imports System.Data.SqlClient
Public Class Form4
    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim Pass1, Pass2 As String
        Pass1 = txtpassword.Text
        Pass2 = txtconfirm.Text

        Dim connStr As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"
        Dim query As String = "INSERT INTO [dbo].[Users] ([Username], [Passwords], [Email], [Phone_no]) VALUES (@Username, @Passwords, @Email, @Phone_no); SELECT SCOPE_IDENTITY();"

        If Pass1 = Pass2 Then
            Using conn As New SqlConnection(connStr)
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                    cmd.Parameters.AddWithValue("@Passwords", txtpassword.Text)
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text)
                    cmd.Parameters.AddWithValue("@Phone_no", txtphone.Text)

                    conn.Open()
                    Dim newUserID As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    MessageBox.Show("You have registered successfully. Your User ID is: " & newUserID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Else
            MessageBox.Show("Password did not match!")
            txtpassword.Clear()
            txtconfirm.Clear()
            txtpassword.Focus()
        End If
    End Sub


    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        txtusername.Clear()
        txtpassword.Clear()
        txtconfirm.Clear()
        txtemail.Clear()
        txtphone.Clear()
        txtusername.Focus()
    End Sub

    Private Sub loginpg_btn_Click(sender As Object, e As EventArgs) Handles loginpg_btn.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub txtusername_Enter(sender As Object, e As EventArgs) Handles txtusername.Enter
        'clear the textbox when the textbox get the focus
        Dim username As String = txtusername.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            'clear the textbox
            txtusername.Text = ""
            'change the textbox for color
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_Leave(sender As Object, e As EventArgs) Handles txtusername.Leave
        'when the textbox lost focus
        Dim username As String = txtusername.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            'set the textbox text
            txtusername.Text = "username"
            'change the textbox for color
            txtusername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        Dim pass As String = txtpassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        Dim pass As String = txtpassword.Text
        If pass.Trim().ToLower() = "password" Or pass.Trim() = "" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.DarkGray
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtconfirm_Enter(sender As Object, e As EventArgs) Handles txtconfirm.Enter
        Dim cpass As String = txtconfirm.Text
        If cpass.Trim().ToLower() = "cpassword" Or cpass.Trim() = "" Then
            txtconfirm.Text = ""
            txtconfirm.ForeColor = Color.Black
            txtconfirm.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtconfirm_Leave(sender As Object, e As EventArgs) Handles txtconfirm.Leave
        Dim cpass As String = txtconfirm.Text
        If cpass.Trim().ToLower() = "cpassword" Or cpass.Trim() = "" Then
            txtconfirm.Text = ""
            txtconfirm.ForeColor = Color.DarkGray
            txtconfirm.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtemail_Enter(sender As Object, e As EventArgs) Handles txtemail.Enter
        Dim mail As String = txtemail.Text
        If mail.Trim().ToLower() = "email" Or mail.Trim() = "" Then
            txtemail.Text = ""
            txtemail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        Dim mail As String = txtemail.Text
        If mail.Trim().ToLower() = "email" Or mail.Trim() = "" Then
            txtemail.Text = "Email"
            txtemail.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtphone_Enter(sender As Object, e As EventArgs) Handles txtphone.Enter
        Dim phone As String = txtphone.Text
        If phone.Trim().ToLower() = "Phone" Or phone.Trim() = "" Then
            txtphone.Text = ""
            txtphone.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtphone_Leave(sender As Object, e As EventArgs) Handles txtphone.Leave
        Dim phone As String = txtphone.Text
        If phone.Trim().ToLower() = "Phone" Or phone.Trim() = "" Then
            txtphone.Text = "Phone number"
            txtphone.ForeColor = Color.DarkGray
        End If
    End Sub
End Class