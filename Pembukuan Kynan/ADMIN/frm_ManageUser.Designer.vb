<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageUser
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
        txt_name = New TextBox()
        txt_username = New TextBox()
        txt_password = New TextBox()
        cbo_role = New ComboBox()
        btn_register = New Button()
        btn_cancel = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txt_name
        ' 
        txt_name.Location = New Point(167, 28)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(289, 23)
        txt_name.TabIndex = 0
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(167, 67)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(289, 23)
        txt_username.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(167, 109)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(289, 23)
        txt_password.TabIndex = 2
        ' 
        ' cbo_role
        ' 
        cbo_role.FormattingEnabled = True
        cbo_role.Items.AddRange(New Object() {"ADMIN", "CASHIER"})
        cbo_role.Location = New Point(167, 154)
        cbo_role.Name = "cbo_role"
        cbo_role.Size = New Size(288, 23)
        cbo_role.TabIndex = 3
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = Color.DodgerBlue
        btn_register.FlatAppearance.BorderSize = 0
        btn_register.FlatStyle = FlatStyle.Flat
        btn_register.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_register.ForeColor = Color.White
        btn_register.Location = New Point(170, 193)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(116, 24)
        btn_register.TabIndex = 4
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btn_cancel.FlatAppearance.BorderSize = 0
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_cancel.ForeColor = Color.White
        btn_cancel.Location = New Point(339, 193)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(116, 24)
        btn_cancel.TabIndex = 5
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 7
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 8
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(104, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(30, 15)
        Label4.TabIndex = 9
        Label4.Text = "Role"
        ' 
        ' frm_ManageUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 296)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_cancel)
        Controls.Add(btn_register)
        Controls.Add(cbo_role)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(txt_name)
        Name = "frm_ManageUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage User"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents cbo_role As ComboBox
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
