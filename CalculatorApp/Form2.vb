Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class Form2

    ' Define a property to store the logged-in user's ID
    Public Property LoggedInUserID As Integer

    Private connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        ' Check if either Calculator or Admin Panel radio button is checked
        If Not (Calculator.Checked Or Admin_panel.Checked) Then
            MessageBox.Show("Please select an option (Calculator or Admin Panel)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Passwords = @Password"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text)

                Dim dt As New DataTable()
                Dim sda As New SqlDataAdapter(cmd)
                sda.Fill(dt)

                If dt.Rows.Count > 0 Then
                    ' Close the login form
                    Me.Hide()

                    ' Show either Form1 (Calculator) or Form3 (Admin Panel) based on selection
                    If Calculator.Checked Then
                        Form1.LoggedInUserID = GetUserID(txtusername.Text)
                        Form1.Show()
                    ElseIf Admin_panel.Checked Then
                        Form3.LoggedInUserID = GetUserID(txtusername.Text)
                        Form3.Show()
                    End If
                Else
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Function GetUserID(username As String) As Integer
        Dim UserID As Integer = 0
        Dim query As String = "SELECT UserID FROM Users WHERE Username = @Username"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    UserID = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return UserID
    End Function

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        txtusername.Clear()
        txtpassword.Clear()
        ' Assuming RadioButton1 is the radio button you want to clear
        Calculator.Checked = False
        Admin_panel.Checked = False
        txtusername.Focus()
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Me.Close()
    End Sub

    Private Sub txtpassword_Enter(sender As Object, e As EventArgs) Handles txtpassword.Enter
        Dim pas As String = txtpassword.Text
        If pas.Trim().ToLower() = "password" Or pas.Trim() = "" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        Dim pas As String = txtpassword.Text
        If pas.Trim().ToLower() = "password" Or pas.Trim() = "" Then
            txtpassword.Text = ""
            txtpassword.ForeColor = Color.Black
            txtpassword.UseSystemPasswordChar = False
        End If
    End Sub

End Class


