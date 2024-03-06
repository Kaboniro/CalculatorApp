<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lbl_admin = New Label()
        Label1 = New Label()
        txtusername = New TextBox()
        Label2 = New Label()
        txtpassword = New TextBox()
        btn_admin = New Button()
        SuspendLayout()
        ' 
        ' lbl_admin
        ' 
        lbl_admin.AutoSize = True
        lbl_admin.Location = New Point(336, 34)
        lbl_admin.Name = "lbl_admin"
        lbl_admin.Size = New Size(84, 15)
        lbl_admin.TabIndex = 0
        lbl_admin.Text = "ADMIN LOGIN"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(246, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(414, 113)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(246, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(414, 181)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 4
        ' 
        ' btn_admin
        ' 
        btn_admin.Location = New Point(336, 252)
        btn_admin.Name = "btn_admin"
        btn_admin.Size = New Size(75, 23)
        btn_admin.TabIndex = 5
        btn_admin.Text = "Login"
        btn_admin.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_admin)
        Controls.Add(txtpassword)
        Controls.Add(Label2)
        Controls.Add(txtusername)
        Controls.Add(Label1)
        Controls.Add(lbl_admin)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_admin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btn_admin As Button
End Class
