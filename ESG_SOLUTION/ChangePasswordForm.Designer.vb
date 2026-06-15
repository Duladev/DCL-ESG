<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePasswordForm
    Inherits Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer = Nothing

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblMessage = New Label()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        lblNewPassword = New Label()
        lblConfirmPassword = New Label()
        btnChangePassword = New RoundedButton()
        btnCancel = New RoundedButton()
        lblError = New Label()
        pnlContainer = New Panel()
        pnlContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        lblTitle.Location = New Point(101, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(196, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Change Password"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMessage
        ' 
        lblMessage.AutoSize = True
        lblMessage.Font = New Font("Segoe UI", 9F)
        lblMessage.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblMessage.Location = New Point(7, 74)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(390, 15)
        lblMessage.TabIndex = 1
        lblMessage.Text = "For security reasons, you must change your password before continuing."
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 11F)
        txtNewPassword.Location = New Point(50, 150)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.PasswordChar = "●"c
        txtNewPassword.Size = New Size(300, 27)
        txtNewPassword.TabIndex = 0
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 11F)
        txtConfirmPassword.Location = New Point(50, 220)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "●"c
        txtConfirmPassword.Size = New Size(300, 27)
        txtConfirmPassword.TabIndex = 1
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Segoe UI", 9F)
        lblNewPassword.ForeColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
        lblNewPassword.Location = New Point(50, 128)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(84, 15)
        lblNewPassword.TabIndex = 4
        lblNewPassword.Text = "New Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 9F)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
        lblConfirmPassword.Location = New Point(50, 198)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(104, 15)
        lblConfirmPassword.TabIndex = 5
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.DarkGray
        btnChangePassword.CornerRadius = 8
        btnChangePassword.FlatAppearance.BorderSize = 0
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnChangePassword.ForeColor = Color.White
        btnChangePassword.Location = New Point(50, 290)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(145, 40)
        btnChangePassword.TabIndex = 2
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnCancel.CornerRadius = 8
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(205, 290)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(145, 40)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Segoe UI", 8F)
        lblError.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        lblError.Location = New Point(50, 265)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 13)
        lblError.TabIndex = 8
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BackColor = Color.White
        pnlContainer.Controls.Add(lblTitle)
        pnlContainer.Controls.Add(lblMessage)
        pnlContainer.Controls.Add(txtNewPassword)
        pnlContainer.Controls.Add(txtConfirmPassword)
        pnlContainer.Controls.Add(lblNewPassword)
        pnlContainer.Controls.Add(lblConfirmPassword)
        pnlContainer.Controls.Add(btnChangePassword)
        pnlContainer.Controls.Add(btnCancel)
        pnlContainer.Controls.Add(lblError)
        pnlContainer.Dock = DockStyle.Fill
        pnlContainer.Location = New Point(0, 0)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Size = New Size(400, 380)
        pnlContainer.TabIndex = 9
        ' 
        ' ChangePasswordForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(248))
        ClientSize = New Size(400, 380)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ChangePasswordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Change Password"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents lblTitle As Label
    Private WithEvents lblMessage As Label
    Private WithEvents txtNewPassword As TextBox
    Private WithEvents txtConfirmPassword As TextBox
    Private WithEvents lblNewPassword As Label
    Private WithEvents lblConfirmPassword As Label
    Private WithEvents btnChangePassword As RoundedButton
    Private WithEvents btnCancel As RoundedButton
    Private WithEvents lblError As Label
    Private WithEvents pnlContainer As Panel
End Class