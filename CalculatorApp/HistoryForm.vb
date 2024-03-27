Imports System.Data

Public Class HistoryForm

    Public Property LoggedInUserID As Integer

    Public Sub New(historyTable As DataTable)
        ' This call is required by the designer.
        InitializeComponent()

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = historyTable

        ' Optionally, customize DataGridView appearance and behavior
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
    End Sub
End Class
