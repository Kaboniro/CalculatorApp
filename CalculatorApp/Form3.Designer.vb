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
        lbl_admin = New Label()
        txt_admin_name = New TextBox()
        lbl_admin2 = New Label()
        txt_admin_lbl = New TextBox()
        lst_code = New ListBox()
        btn_back = New Button()
        btn_submit = New Button()
        VScrollBar1 = New VScrollBar()
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
        ' lbl_admin
        ' 
        lbl_admin.AutoSize = True
        lbl_admin.Location = New Point(40, 82)
        lbl_admin.Name = "lbl_admin"
        lbl_admin.Size = New Size(92, 15)
        lbl_admin.TabIndex = 1
        lbl_admin.Text = "Name of Button"
        ' 
        ' txt_admin_name
        ' 
        txt_admin_name.Location = New Point(153, 79)
        txt_admin_name.Name = "txt_admin_name"
        txt_admin_name.Size = New Size(100, 23)
        txt_admin_name.TabIndex = 2
        ' 
        ' lbl_admin2
        ' 
        lbl_admin2.AutoSize = True
        lbl_admin2.Location = New Point(309, 82)
        lbl_admin2.Name = "lbl_admin2"
        lbl_admin2.Size = New Size(88, 15)
        lbl_admin2.TabIndex = 3
        lbl_admin2.Text = "Label of Button"
        ' 
        ' txt_admin_lbl
        ' 
        txt_admin_lbl.Location = New Point(440, 79)
        txt_admin_lbl.Name = "txt_admin_lbl"
        txt_admin_lbl.Size = New Size(100, 23)
        txt_admin_lbl.TabIndex = 4
        ' 
        ' lst_code
        ' 
        lst_code.FormattingEnabled = True
        lst_code.ItemHeight = 15
        lst_code.Location = New Point(40, 131)
        lst_code.Name = "lst_code"
        lst_code.Size = New Size(535, 259)
        lst_code.TabIndex = 5
        ' 
        ' btn_back
        ' 
        btn_back.Location = New Point(663, 302)
        btn_back.Name = "btn_back"
        btn_back.Size = New Size(75, 23)
        btn_back.TabIndex = 6
        btn_back.Text = "To app"
        btn_back.UseVisualStyleBackColor = True
        ' 
        ' btn_submit
        ' 
        btn_submit.Location = New Point(663, 212)
        btn_submit.Name = "btn_submit"
        btn_submit.Size = New Size(75, 23)
        btn_submit.TabIndex = 7
        btn_submit.Text = "Submit"
        btn_submit.UseVisualStyleBackColor = True
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.Location = New Point(569, 131)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.Size = New Size(21, 259)
        VScrollBar1.TabIndex = 8
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(VScrollBar1)
        Controls.Add(btn_submit)
        Controls.Add(btn_back)
        Controls.Add(lst_code)
        Controls.Add(txt_admin_lbl)
        Controls.Add(lbl_admin2)
        Controls.Add(txt_admin_name)
        Controls.Add(lbl_admin)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents txt_admin_name As TextBox
    Friend WithEvents lbl_admin2 As Label
    Friend WithEvents txt_admin_lbl As TextBox
    Friend WithEvents lst_code As ListBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
