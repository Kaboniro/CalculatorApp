<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
  '  <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtusername = New TextBox()
        Label2 = New Label()
        txtpassword = New TextBox()
        login_btn = New Button()
        cancel_btn = New Button()
        exit_btn = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        MenuStrip1 = New MenuStrip()
        Calculator = New RadioButton()
        Admin_panel = New RadioButton()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(358, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 1
        Label1.Text = "Username :"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(507, 110)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(358, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 3
        Label2.Text = "Password :"
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(507, 178)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 4
        ' 
        ' login_btn
        ' 
        login_btn.Cursor = Cursors.Hand
        login_btn.Location = New Point(512, 251)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(95, 45)
        login_btn.TabIndex = 5
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = True
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Cursor = Cursors.Hand
        cancel_btn.Location = New Point(357, 251)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(102, 45)
        cancel_btn.TabIndex = 6
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' exit_btn
        ' 
        exit_btn.Cursor = Cursors.Hand
        exit_btn.Location = New Point(436, 327)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(82, 38)
        exit_btn.TabIndex = 7
        exit_btn.Text = "Exit"
        exit_btn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(22, 84)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(246, 268)
        Panel1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 40)
        Label3.TabIndex = 0
        Label3.Text = "LOGIN"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Calculator
        ' 
        Calculator.AutoSize = True
        Calculator.Location = New Point(682, 114)
        Calculator.Name = "Calculator"
        Calculator.Size = New Size(79, 19)
        Calculator.TabIndex = 10
        Calculator.TabStop = True
        Calculator.Text = "Calculator"
        Calculator.UseVisualStyleBackColor = True
        ' 
        ' Admin_panel
        ' 
        Admin_panel.AutoSize = True
        Admin_panel.Location = New Point(682, 152)
        Admin_panel.Name = "Admin_panel"
        Admin_panel.Size = New Size(93, 19)
        Admin_panel.TabIndex = 11
        Admin_panel.TabStop = True
        Admin_panel.Text = "Admin Panel"
        Admin_panel.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Admin_panel)
        Controls.Add(Calculator)
        Controls.Add(Panel1)
        Controls.Add(exit_btn)
        Controls.Add(cancel_btn)
        Controls.Add(login_btn)
        Controls.Add(txtpassword)
        Controls.Add(Label2)
        Controls.Add(txtusername)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Name = "Form2"
        Text = "LOGIN WINDOW"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents login_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Calculator As RadioButton
    Friend WithEvents Admin_panel As RadioButton
End Class
