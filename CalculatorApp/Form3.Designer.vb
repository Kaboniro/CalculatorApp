<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        btn_deactivate = New Button()
        btn_update = New Button()
        LogoutAd = New Button()
        UsersDataGridView = New DataGridView()
        Register_btn = New Button()
        Refresh_btn = New Button()
        CType(UsersDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(340, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN PANEL"
        ' 
        ' btn_deactivate
        ' 
        btn_deactivate.Location = New Point(700, 191)
        btn_deactivate.Name = "btn_deactivate"
        btn_deactivate.Size = New Size(75, 23)
        btn_deactivate.TabIndex = 6
        btn_deactivate.Text = "Deactivate"
        btn_deactivate.UseVisualStyleBackColor = True
        ' 
        ' btn_update
        ' 
        btn_update.Location = New Point(700, 130)
        btn_update.Name = "btn_update"
        btn_update.Size = New Size(75, 23)
        btn_update.TabIndex = 7
        btn_update.Text = "Update"
        btn_update.UseVisualStyleBackColor = True
        ' 
        ' LogoutAd
        ' 
        LogoutAd.Location = New Point(700, 26)
        LogoutAd.Name = "LogoutAd"
        LogoutAd.Size = New Size(88, 25)
        LogoutAd.TabIndex = 9
        LogoutAd.Text = "Logout"
        LogoutAd.UseVisualStyleBackColor = True
        ' 
        ' UsersDataGridView
        ' 
        UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        UsersDataGridView.Location = New Point(97, 75)
        UsersDataGridView.Name = "UsersDataGridView"
        UsersDataGridView.Size = New Size(538, 312)
        UsersDataGridView.TabIndex = 10
        ' 
        ' Register_btn
        ' 
        Register_btn.Location = New Point(700, 75)
        Register_btn.Name = "Register_btn"
        Register_btn.Size = New Size(75, 23)
        Register_btn.TabIndex = 13
        Register_btn.Text = "Register"
        Register_btn.UseVisualStyleBackColor = True
        ' 
        ' Refresh_btn
        ' 
        Refresh_btn.Location = New Point(560, 393)
        Refresh_btn.Name = "Refresh_btn"
        Refresh_btn.Size = New Size(75, 23)
        Refresh_btn.TabIndex = 14
        Refresh_btn.Text = "Refresh"
        Refresh_btn.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Refresh_btn)
        Controls.Add(Register_btn)
        Controls.Add(UsersDataGridView)
        Controls.Add(LogoutAd)
        Controls.Add(btn_update)
        Controls.Add(btn_deactivate)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Panel"
        CType(UsersDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_deactivate As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents LogoutAd As Button
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents Register_btn As Button
    Friend WithEvents Refresh_btn As Button
End Class
