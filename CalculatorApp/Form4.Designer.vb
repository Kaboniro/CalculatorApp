<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Panel1 = New Panel()
        Label3 = New Label()
        loginpg_btn = New Button()
        cancel_btn = New Button()
        register_btn = New Button()
        txtpassword = New TextBox()
        Label2 = New Label()
        txtusername = New TextBox()
        Label1 = New Label()
        txtphone = New TextBox()
        Label4 = New Label()
        txtemail = New TextBox()
        Label5 = New Label()
        txtconfirm = New TextBox()
        Label6 = New Label()
        SqlCommandBuilder1 = New Microsoft.Data.SqlClient.SqlCommandBuilder()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(9, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(246, 268)
        Panel1.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(176, 40)
        Label3.TabIndex = 0
        Label3.Text = "REGISTER"
        ' 
        ' loginpg_btn
        ' 
        loginpg_btn.Cursor = Cursors.Hand
        loginpg_btn.Location = New Point(694, 397)
        loginpg_btn.Name = "loginpg_btn"
        loginpg_btn.Size = New Size(82, 28)
        loginpg_btn.TabIndex = 15
        loginpg_btn.Text = "Login page"
        loginpg_btn.UseVisualStyleBackColor = True
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Cursor = Cursors.Hand
        cancel_btn.Location = New Point(344, 277)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(102, 45)
        cancel_btn.TabIndex = 14
        cancel_btn.Text = "Clear"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' register_btn
        ' 
        register_btn.Cursor = Cursors.Hand
        register_btn.Location = New Point(499, 277)
        register_btn.Name = "register_btn"
        register_btn.Size = New Size(95, 45)
        register_btn.TabIndex = 13
        register_btn.Text = "Register"
        register_btn.UseVisualStyleBackColor = True
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(429, 79)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(130, 23)
        txtpassword.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(280, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 11
        Label2.Text = "Password :"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(429, 31)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(130, 23)
        txtusername.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(280, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 9
        Label1.Text = "Username :"
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(429, 183)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(130, 23)
        txtphone.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(280, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 25)
        Label4.TabIndex = 19
        Label4.Text = "Phone no :"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(429, 133)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(130, 23)
        txtemail.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(280, 130)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 25)
        Label5.TabIndex = 17
        Label5.Text = "Email :"
        ' 
        ' txtconfirm
        ' 
        txtconfirm.Location = New Point(607, 79)
        txtconfirm.Name = "txtconfirm"
        txtconfirm.Size = New Size(141, 23)
        txtconfirm.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label6.Location = New Point(591, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 25)
        Label6.TabIndex = 21
        Label6.Text = "Confirm Password :"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtconfirm)
        Controls.Add(Label6)
        Controls.Add(txtphone)
        Controls.Add(Label4)
        Controls.Add(txtemail)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(loginpg_btn)
        Controls.Add(cancel_btn)
        Controls.Add(register_btn)
        Controls.Add(txtpassword)
        Controls.Add(Label2)
        Controls.Add(txtusername)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents loginpg_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents register_btn As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SqlCommandBuilder1 As Microsoft.Data.SqlClient.SqlCommandBuilder
End Class
