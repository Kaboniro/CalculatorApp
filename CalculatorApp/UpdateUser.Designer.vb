<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateUser
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
        txtphone = New TextBox()
        Label1 = New Label()
        txtemail = New TextBox()
        Label3 = New Label()
        txtpass = New TextBox()
        Label4 = New Label()
        txtusername = New TextBox()
        Label5 = New Label()
        clear_btn = New Button()
        update_btn = New Button()
        txtid = New TextBox()
        Label2 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(406, 290)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(130, 23)
        txtphone.TabIndex = 44
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(257, 290)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 43
        Label1.Text = "Phone no :"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(406, 240)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(130, 23)
        txtemail.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(257, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 25)
        Label3.TabIndex = 41
        Label3.Text = "Email :"
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(406, 188)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(130, 23)
        txtpass.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(257, 188)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 39
        Label4.Text = "Password :"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(406, 140)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(130, 23)
        txtusername.TabIndex = 38
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(257, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 25)
        Label5.TabIndex = 37
        Label5.Text = "Username :"
        ' 
        ' clear_btn
        ' 
        clear_btn.Cursor = Cursors.Hand
        clear_btn.Location = New Point(269, 354)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(102, 45)
        clear_btn.TabIndex = 36
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = True
        ' 
        ' update_btn
        ' 
        update_btn.Cursor = Cursors.Hand
        update_btn.Location = New Point(424, 354)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(95, 45)
        update_btn.TabIndex = 35
        update_btn.Text = "Update"
        update_btn.UseVisualStyleBackColor = True
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(406, 91)
        txtid.Name = "txtid"
        txtid.Size = New Size(130, 23)
        txtid.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(257, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 25)
        Label2.TabIndex = 33
        Label2.Text = "Id :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(283, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(261, 31)
        Label6.TabIndex = 45
        Label6.Text = "Update Users Details"
        ' 
        ' UpdateUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(txtphone)
        Controls.Add(Label1)
        Controls.Add(txtemail)
        Controls.Add(Label3)
        Controls.Add(txtpass)
        Controls.Add(Label4)
        Controls.Add(txtusername)
        Controls.Add(Label5)
        Controls.Add(clear_btn)
        Controls.Add(update_btn)
        Controls.Add(txtid)
        Controls.Add(Label2)
        Name = "UpdateUser"
        Text = "UpdateUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtphone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
