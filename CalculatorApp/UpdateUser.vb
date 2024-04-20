Imports System.Data.SqlClient
Public Class UpdateUser

    Private userId As Integer

    ' Event to notify the admin panel form of data updates
    Public Event UpdateData(userId As Integer, updatedUsername As String, updatedPassword As String, updatedEmail As String, updatedPhoneNo As String)

    ' Constructor to receive the selected user ID and other data
    Public Sub New(userId As Integer, username As String, password As String, email As String, phoneNo As String)
        InitializeComponent()

        ' Initialize form controls with selected data
        Me.userId = userId
        txtid.Text = userId.ToString() ' Set the UserID in the textbox
        txtid.ReadOnly = True ' Set the textbox to read-only
        txtid.Enabled = False ' Disable the textbox
        txtusername.Text = username
        txtpass.Text = password
        txtemail.Text = email
        txtphone.Text = phoneNo
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        ' Get updated data from form controls
        Dim updatedUsername As String = txtusername.Text
        Dim updatedPassword As String = txtpass.Text
        Dim updatedEmail As String = txtemail.Text
        Dim updatedPhoneNo As String = txtphone.Text

        ' Validate the data if needed

        ' Update the user details in the database
        UpdateUserInDatabase(updatedUsername, updatedPassword, updatedEmail, updatedPhoneNo)

        ' Close the form
        Me.Close()
    End Sub

    Private Sub UpdateUserInDatabase(updatedUsername As String, updatedPassword As String, updatedEmail As String, updatedPhoneNo As String)
        ' Replace "YourConnectionString" with your actual SQL Server connection string
        Dim connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

        ' Construct the SQL UPDATE query
        Dim query As String = "UPDATE Users SET Username = @Username, Passwords = @Password, Email = @Email, Phone_no = @PhoneNo WHERE UserID = @UserID"

        Try
            ' Create and open a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create a SqlCommand object with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", updatedUsername)
                    command.Parameters.AddWithValue("@Password", updatedPassword)
                    command.Parameters.AddWithValue("@Email", updatedEmail)
                    command.Parameters.AddWithValue("@PhoneNo", updatedPhoneNo)
                    ' Replace "userId" with the actual user ID value
                    command.Parameters.AddWithValue("@UserID", userId)

                    ' Execute the query
                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Notify the user that the update was successful
            MessageBox.Show("User details updated successfully.")

        Catch ex As Exception
            ' Handle any exceptions that may occur during database access
            MessageBox.Show("An error occurred while updating user details: " & ex.Message)
        End Try
    End Sub


    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        txtusername.Clear()
        txtpass.Clear()
        txtemail.Clear()
        txtphone.Clear()
        txtusername.Focus()
    End Sub

End Class