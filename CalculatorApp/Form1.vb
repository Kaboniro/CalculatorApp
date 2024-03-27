Imports MathNet.Symbolics
Imports MathNet.Symbolics.FloatingPoint
Imports Extreme.Mathematics.Calculus
Imports Extreme.Mathematics
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Verify the license during form load
        Extreme.License.Verify("37551-31834-20229-27429")
        Dim loginForm As Form2 = DirectCast(Application.OpenForms("LoginForm"), Form2)
        If loginForm IsNot Nothing Then
            ' Access the LoggedInUserID property
            LoggedInUserID = loginForm.LoggedInUserID
            MessageBox.Show("Logged-in User ID: " & LoggedInUserID)
        End If
    End Sub

    Private Sub btn_click(sender As Object, e As EventArgs) Handles btn_num_0.Click, btn_num_1.Click, btn_num_2.Click, btn_num_3.Click, btn_num_4.Click, btn_num_5.Click, btn_num_6.Click, btn_num_7.Click, btn_num_8.Click, btn_num_9.Click, btn_sum.Click, btn_difference.Click, btn_multiplication.Click, btn_division.Click, btn_log.Click, btn_exponent.Click, btn_sin.Click, btn_cos.Click, btn_tan.Click, btn_factorial.Click, btn_root.Click, btn_mod.Click
        Dim button As Button = DirectCast(sender, Button)
        If button.Text = "log" Then
            input_box.Text &= "log({})"
        ElseIf button.Text = "mod" Then
            input_box.Text &= "%"
        Else
            input_box.Text &= button.Text
        End If
    End Sub

    Private Sub ButtonClear(sender As Object, e As EventArgs) Handles btn_clear.Click
        input_box.Clear()
        result_box.Clear()
    End Sub

    ' Define a property to store the logged-in user's ID
    Public Shared Property LoggedInUserID As Integer

    Private Sub btn_sign_eq_Click(sender As Object, e As EventArgs) Handles btn_sign_eq.Click
        Dim expression As String = input_box.Text
        Dim result As Double = EvaluateExpression(expression)

        ' Make sure LoggedInUserID is properly set before calling SaveToHistory
        If LoggedInUserID <> 0 Then
            ' Save the history with the logged-in user's ID
            SaveToHistory(LoggedInUserID, expression, result)
        Else
            MessageBox.Show("User not logged in.")
        End If

        result_box.Text = result.ToString()
    End Sub

    Private Sub SaveToHistory(UserID As Integer, expression As String, result As Double)
        Try
            ' Define the connection string for the MSSQL database
            Dim connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

            ' Define the SQL query to insert history entry
            Dim query As String = "INSERT INTO History (UserID, Expression, Result, Timestamp) VALUES (@LoggedInUserID, @Expression, @Result, GETDATE())"

            ' Establish connection to the database
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command object
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@LoggedInUserID", UserID)
                    command.Parameters.AddWithValue("@Expression", expression)
                    command.Parameters.AddWithValue("@Result", result)

                    ' Execute the SQL command
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving to history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_history_Click(sender As Object, e As EventArgs) Handles btn_history.Click
        ' Define the connection string for the MSSQL database
        Dim connectionString As String = "Data Source=HISUL-2;Initial Catalog=Calc;Integrated Security=True;"

        ' Define the SQL query to fetch history entries for the logged-in user
        Dim query As String = "SELECT Expression, Result, Timestamp FROM History WHERE UserID = @UserID"

        Try
            ' Establish connection to the database
            Using connection As New SqlConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' Create a command object
                Using command As New SqlCommand(query, connection)
                    ' Add parameter to the command
                    command.Parameters.AddWithValue("@UserID", LoggedInUserID)

                    ' Create a data adapter to fill data from the command
                    Using adapter As New SqlDataAdapter(command)
                        ' Create a DataTable to hold the fetched history entries
                        Dim historyTable As New DataTable()

                        ' Fill the DataTable with data from the database
                        adapter.Fill(historyTable)

                        ' Display the history entries (for example, in a new form)
                        Dim historyForm As New HistoryForm(historyTable)
                        historyForm.ShowDialog()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function EvaluateExpression(expression As String) As Double
        Try
            ' Check if expression contains 'log' function
            If expression.Contains("log") Then
                expression = expression.Replace("log", "EvaluateLogarithm")
                expression = expression.Replace("{", "")
                expression = expression.Replace("}", "")
                Dim result_log As Double = EvaluateLogarithm(expression)
                Return result_log
            ElseIf expression.Contains("sin") Or expression.Contains("cos") Or expression.Contains("tan") Then
                Dim result_trig As Double = EvaluateTrig(expression)
                Return result_trig
            ElseIf expression.Contains("^") Then
                Dim result_exp As Double = EvaluateExp(expression)
                Return result_exp
            ElseIf expression.Contains("!") Then
                Dim result_fact As Double = EvaluateFact(expression)
                Return result_fact
            ElseIf expression.Contains("root") Then
                Dim result_root As Double = EvaluateRoot(expression)
                Return result_root
            ElseIf expression.Contains("%") Then
                Dim result_modulus As Double = EvaluateMod(expression)
                Return result_modulus
            Else
                Dim result_exp As Object = New DataTable().Compute(expression, Nothing)
                Return Convert.ToDouble(result_exp)
            End If
        Catch ex As Exception
            MessageBox.Show("Error evaluating expression: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Private Function EvaluateLogarithm(expression As String) As Double
        Dim parts() As String = expression.Split("("c, ")"c)
        Dim base As Double = 10 ' Default base
        Dim argument As Double = 0

        If parts.Length >= 2 Then
            Dim baseArgument() As String = parts(1).Split(","c)
            If baseArgument.Length >= 2 Then
                Double.TryParse(baseArgument(0), base)
                Double.TryParse(baseArgument(1), argument)
            End If
        End If

        ' Ensure argument is positive and base is positive and not equal to 1
        If argument <= 0 OrElse base <= 0 OrElse base = 10 Then
            Throw New ArgumentException("Invalid argument or base for logarithm evaluation.")
        End If

        ' Calculate the logarithm using the change of base formula
        Dim result As Double = Math.Log(argument) / Math.Log(base)
        Return result
    End Function

    Private Function EvaluateTrig(expression As String) As Double
        Dim parts2() As String = expression.Split("("c, ")"c)
        Dim angle As Double = 0

        If parts2.Length >= 2 Then
            Double.TryParse(parts2(1), angle)
        End If

        ' Ensure the angle is within valid range
        If angle < 0 OrElse angle > 360 Then
            Throw New ArgumentException("Invalid angle for trigonometric function.")
        End If

        ' Calculate the sine, cosine, or tangent based on the function
        Select Case parts2(0).ToLower()
            Case "sin"
                Return Math.Sin(angle * Math.PI / 180) ' Convert angle to radians
            Case "cos"
                Return Math.Cos(angle * Math.PI / 180)
            Case "tan"
                Return Math.Tan(angle * Math.PI / 180)
            Case Else
                Throw New ArgumentException("Unsupported trigonometric function.")
        End Select
    End Function

    Private Function EvaluateExp(expression As String) As Double
        Dim parts3() As String = expression.Split("^"c)
        If parts3.Length <> 2 Then
            Throw New ArgumentException("Invalid exponent expression.")
        End If

        ' Parse the base and exponent
        Dim base As Double = Double.Parse(parts3(0))
        Dim exponent As Double = Double.Parse(parts3(1))

        ' Calculate the result
        Dim result As Double = Math.Pow(base, exponent)
        Return result
    End Function

    Private Function EvaluateMod(expression As String) As Double
        Dim parts6() As String = expression.Split("%"c)
        If parts6.Length <> 2 Then
            Throw New ArgumentException("Invalid exponent expression.")
        End If

        ' Parse the base and exponent
        Dim dividend As Double = Double.Parse(parts6(0))
        Dim divisor As Double = Double.Parse(parts6(1))

        ' Calculate the result using modulo operation
        Dim result As Double = dividend Mod divisor
        Return result
    End Function

    Private Function EvaluateFact(expression As String) As Double
        Dim parts4() As String = expression.Split("!"c)
        If parts4.Length <> 2 Then
            Throw New ArgumentException("Invalid factorial expression.")
        End If

        ' Parse the number before the factorial symbol
        Dim number As Double = Double.Parse(parts4(0))

        ' Calculate the factorial
        Dim result As Double = Factorial(number)
        Return result
    End Function

    Private Function Factorial(n As Integer) As Double
        ' Calculate the factorial of a number
        If n < 0 Then
            Throw New ArgumentException("Factorial is not defined for negative numbers.")
        End If

        If n = 0 Then
            Return 1
        End If

        Dim result As Double = 1
        For i As Integer = 1 To n
            result *= i
        Next

        Return result
    End Function

    Private Function EvaluateRoot(expression As String) As Double
        Dim parts5() As String = expression.Split("("c, ")"c, ","c)
        If parts5.Length <> 3 OrElse parts5(0).ToLower() <> "root" Then
            Throw New ArgumentException("Invalid root expression.")
        End If
        ' Parse the number inside parentheses
        Dim n As Double = Double.Parse(parts5(1))
        ' Calculate the square root (n = 2)
        Dim result As Double = Math.Sqrt(n)
        Return result
    End Function

    Private Sub btn_intergrate_Click(sender As Object, e As EventArgs) Handles btn_intergrate.Click
        Dim expression As String = exp_box.Text
        Dim integralResult As Double = CommunicationMaximaInt(expression)
    End Sub
    Private Sub btn_differentiate_Click(sender As Object, e As EventArgs) Handles btn_differentiate.Click
        Dim expression As String = exp_box.Text
        Dim diffResult As Double = CommunicationMaximadiff(expression)
    End Sub
    Private Function CommunicationMaximadiff(expression As String) As Double
        Try
            Dim maximaProcess As New Process()
            maximaProcess.StartInfo.FileName = "C:\maxima-5.47.0\bin\maxima.bat"
            maximaProcess.StartInfo.Arguments = "--very-quiet"
            maximaProcess.StartInfo.RedirectStandardInput = True
            maximaProcess.StartInfo.RedirectStandardOutput = True
            maximaProcess.StartInfo.UseShellExecute = False
            maximaProcess.StartInfo.CreateNoWindow = True

            maximaProcess.Start()

            ' Send expression to Maxima for integration'
            maximaProcess.StandardInput.WriteLine("derivative(" & expression & ", x);") ' Assuming 'x' is the derivative variable
            maximaProcess.StandardInput.WriteLine("quit();")

            Dim result As String = maximaProcess.StandardOutput.ReadToEnd()

            maximaProcess.WaitForExit()
            maximaProcess.Close()

            MessageBox.Show("Integration result: " & result)
        Catch ex As Exception
            ' Show error message
            MessageBox.Show("Error integrating expression: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Function CommunicationMaximaInt(expression As String) As Double
        Try
            Dim maximaProcess As New Process()
            maximaProcess.StartInfo.FileName = "C:\maxima-5.47.0\bin\maxima.bat"
            maximaProcess.StartInfo.Arguments = "--very-quiet"
            maximaProcess.StartInfo.RedirectStandardInput = True
            maximaProcess.StartInfo.RedirectStandardOutput = True
            maximaProcess.StartInfo.UseShellExecute = False
            maximaProcess.StartInfo.CreateNoWindow = True

            maximaProcess.Start()

            ' Send expression to Maxima for integration'
            maximaProcess.StandardInput.WriteLine("integrate(" & expression & ", x);") ' Assuming 'x' is the integration variable
            maximaProcess.StandardInput.WriteLine("quit();")

            Dim result As String = maximaProcess.StandardOutput.ReadToEnd()

            maximaProcess.WaitForExit()
            maximaProcess.Close()

            MessageBox.Show("Integration result: " & result)
        Catch ex As Exception
            ' Show error message
            MessageBox.Show("Error integrating expression: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Private Sub Logoutcalc_Click(sender As Object, e As EventArgs) Handles Logoutcalc.Click
        Me.Close()
        Form2.Show()
    End Sub

End Class



