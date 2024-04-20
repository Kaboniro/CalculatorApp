Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class HistoryForm


    Private connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"
    Private historyTable As DataTable
    Public Property LoggedInUserID As Integer

    Public Sub New(historyTable As DataTable)
        ' This call is required by the designer.
        InitializeComponent()

        ' Bind the DataTable to the DataGridView
        Me.historyTable = historyTable
        DataGridView1.DataSource = Me.historyTable


        ' Optionally, customize DataGridView appearance and behavior
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ' Loop through each selected row in the DataGridView
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            ' Extract the history ID from the selected row
            Dim historyId As Integer = Convert.ToInt32(row.Cells("ID").Value) ' Use the correct column name

            ' Execute a DELETE query to remove the history record from the database
            DeleteHistoryRecord(historyId)
        Next

        ' After deletion, reload the user history to reflect the changes
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = historyTable
    End Sub

    Private Sub DeleteHistoryRecord(historyId As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Execute a DELETE query to remove the history record with the specified ID
            Dim query As String = "DELETE FROM History WHERE ID = @historyId"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@historyId", historyId)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show($"History record with ID {historyId} has been deleted.")
                Else
                    MessageBox.Show($"Failed to delete history record with ID {historyId}.")
                End If
            End Using
        End Using
    End Sub

End Class