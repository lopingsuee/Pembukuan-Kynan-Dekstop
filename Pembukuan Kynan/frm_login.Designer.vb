<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txt_username = New TextBox()
        txt_password = New TextBox()
        btn_login = New Button()
        btn_exit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(24, 70)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(223, 27)
        txt_username.TabIndex = 0
        txt_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(24, 123)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(223, 27)
        txt_password.TabIndex = 1
        txt_password.TextAlign = HorizontalAlignment.Center
        txt_password.UseSystemPasswordChar = True
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.DodgerBlue
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatAppearance.BorderSize = 0
        btn_login.ForeColor = SystemColors.ControlLightLight
        btn_login.Location = New Point(24, 179)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(223, 35)
        btn_login.TabIndex = 2
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btn_exit.Cursor = Cursors.Hand
        btn_exit.FlatAppearance.BorderSize = 0
        btn_exit.ForeColor = SystemColors.ControlLightLight
        btn_exit.Location = New Point(24, 215)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(223, 35)
        btn_exit.TabIndex = 3
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 19)
        Label1.TabIndex = 4
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 19)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' frm_login
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(278, 298)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_exit)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "frm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
