Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form3
    Public Shared Property LoggedInUserID As Integer

    Private connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call a method to load and display the list of users when the form loads
        LoadUsersList()
    End Sub

    Private Sub LoadUsersList()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT UserID, Username, Email, Phone_no FROM Users"
            Using command As New SqlCommand(query, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView control
                    UsersDataGridView.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ' Check if a row is selected
        If UsersDataGridView.SelectedRows.Count > 0 Then
            ' Get the selected user ID from the DataGridView
            Dim userId As Integer = Convert.ToInt32(UsersDataGridView.SelectedRows(0).Cells("UserID").Value)

            ' Retrieve other data for the selected user (e.g., username, email, phone_no) from the DataGridView or database
            Dim username As String = Convert.ToString(UsersDataGridView.SelectedRows(0).Cells("Username").Value)
            Dim email As String = Convert.ToString(UsersDataGridView.SelectedRows(0).Cells("Email").Value)
            Dim phoneNo As String = Convert.ToString(UsersDataGridView.SelectedRows(0).Cells("Phone_no").Value)

            ' Retrieve password for the selected user from the database
            Dim password As String = RetrievePasswordFromDatabase(userId)

            ' Instantiate the update form, passing the selected data
            Dim UpdateUser As New UpdateUser(userId, username, password, email, phoneNo) ' Pass selected data to constructor
            ' Attach an event handler to handle updates made in the update form
            AddHandler UpdateUser.UpdateData, AddressOf UpdateUserData
            UpdateUser.ShowDialog()
        Else
            MessageBox.Show("Please select a user to update.")
        End If
    End Sub

    Private Sub UpdateUserData(userId As Integer, updatedUsername As String, updatedPassword As String, updatedEmail As String, updatedPhoneNo As String)
        ' Update the user data in the DataGridView or reload the DataGridView from the database
        ' For simplicity, let's assume we update the DataGridView directly
        For Each row As DataGridViewRow In UsersDataGridView.Rows
            If Convert.ToInt32(row.Cells("UserID").Value) = userId Then
                row.Cells("Username").Value = updatedUsername
                row.Cells("Passwords").Value = updatedPassword
                row.Cells("Email").Value = updatedEmail
                row.Cells("Phone_no").Value = updatedPhoneNo
                Exit For
            End If
        Next
    End Sub

    Private Function RetrievePasswordFromDatabase(userId As Integer) As String
        Dim password As String = String.Empty

        ' Replace "YourConnectionString" with your actual SQL Server connection string
        Dim connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

        ' SQL query to retrieve the password for the specified user ID
        Dim query As String = "SELECT Passwords FROM Users WHERE UserID = @UserID"

        Try
            ' Create and open a connection to the database
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Create a SqlCommand object with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@UserID", userId)

                    ' Execute the query and retrieve the password
                    Dim result As Object = command.ExecuteScalar()

                    ' Check if the result is not null
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        ' Convert the result to a string and assign it to the password variable
                        password = Convert.ToString(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database access
            MessageBox.Show("An error occurred while retrieving the password from the database: " & ex.Message)
        End Try

        ' Return the retrieved password
        Return password
    End Function

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_deactivate.Click
        ' Loop through each selected row in the DataGridView
        For Each row As DataGridViewRow In UsersDataGridView.SelectedRows
            ' Extract the user ID from the selected row
            Dim userId As Integer = Convert.ToInt32(row.Cells("UserID").Value)

            ' Execute a DELETE query to remove the user from the database
            DeleteUser(userId)
        Next

        ' After deletion, reload the list of users to reflect the changes
        LoadUsersList()
    End Sub

    Private Sub DeleteUser(userId As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Execute a DELETE query to remove the user with the specified ID
            Dim query As String = "DELETE FROM Users WHERE UserID = @UserId"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserId", userId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show($"User with ID {userId} has been deactivated and removed from the database.")
                Else
                    MessageBox.Show($"Failed to deactivate and remove user with ID {userId}.")
                End If
            End Using
        End Using
    End Sub

    Private Sub LogoutAd_Click(sender As Object, e As EventArgs) Handles LogoutAd.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Register_btn_Click(sender As Object, e As EventArgs) Handles Register_btn.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        ' Reload entire dataset from the database
        ReloadDataGridView()
    End Sub

    Private Sub ReloadDataGridView()
        ' Clear the existing data in the DataGridView
        UsersDataGridView.DataSource = Nothing

        ' Rebind the DataGridView with the updated data from the database
        UsersDataGridView.DataSource = GetDataFromDatabase()
    End Sub

    Private Function GetDataFromDatabase() As DataTable
        ' Replace "YourConnectionString" with your actual SQL Server connection string
        Dim connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

        ' Create a DataTable to hold the retrieved data
        Dim dataTable As New DataTable()

        Try
            ' Create a SqlConnection object with the connection string
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Define the SQL query to retrieve the data from the database
                Dim query As String = "SELECT UserID, Username, Passwords, Email, Phone_no FROM Users"

                ' Create a SqlCommand object with the query and connection
                Using command As New SqlCommand(query, connection)
                    ' Create a SqlDataAdapter to execute the query and fill the DataTable
                    Using adapter As New SqlDataAdapter(command)
                        ' Fill the DataTable with the retrieved data
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur during database access
            MessageBox.Show("An error occurred while retrieving data from the database: " & ex.Message)
        End Try

        ' Return the populated DataTable
        Return dataTable
    End Function

    Private Sub ResizeColumns()
        ' Set the AutoSizeMode property of each column to Fill
        For Each column As DataGridViewColumn In UsersDataGridView.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

End Class
