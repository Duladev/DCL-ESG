<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPasswordForm
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
        TabControl1 = New TabControl()
        tabSecurityQuestions = New TabPage()
        grpSecurityQuestions = New GroupBox()
        btnVerifyAnswers = New RoundedButton()
        lblSecurityError = New Label()
        pnlSecurityQuestions = New Panel()
        grpUserInfo = New GroupBox()
        btnSearchUser = New RoundedButton()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblInfo = New Label()
        tabOTP = New TabPage()
        grpOTPReset = New GroupBox()
        btnSendOTP = New RoundedButton()
        btnVerifyOTP = New RoundedButton()
        txtOTP = New TextBox()
        lblOTP = New Label()
        lblOTPError = New Label()
        pnlMain = New Panel()
        TabControl1.SuspendLayout()
        tabSecurityQuestions.SuspendLayout()
        grpSecurityQuestions.SuspendLayout()
        grpUserInfo.SuspendLayout()
        tabOTP.SuspendLayout()
        grpOTPReset.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabSecurityQuestions)
        TabControl1.Controls.Add(tabOTP)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(550, 500)
        TabControl1.TabIndex = 0
        ' 
        ' tabSecurityQuestions
        ' 
        tabSecurityQuestions.Controls.Add(grpSecurityQuestions)
        tabSecurityQuestions.Controls.Add(grpUserInfo)
        tabSecurityQuestions.Location = New Point(4, 24)
        tabSecurityQuestions.Name = "tabSecurityQuestions"
        tabSecurityQuestions.Padding = New Padding(3)
        tabSecurityQuestions.Size = New Size(542, 472)
        tabSecurityQuestions.TabIndex = 0
        tabSecurityQuestions.Text = "Security Questions"
        tabSecurityQuestions.UseVisualStyleBackColor = True
        ' 
        ' grpSecurityQuestions
        ' 
        grpSecurityQuestions.Controls.Add(btnVerifyAnswers)
        grpSecurityQuestions.Controls.Add(lblSecurityError)
        grpSecurityQuestions.Controls.Add(pnlSecurityQuestions)
        grpSecurityQuestions.Location = New Point(20, 120)
        grpSecurityQuestions.Name = "grpSecurityQuestions"
        grpSecurityQuestions.Size = New Size(500, 320)
        grpSecurityQuestions.TabIndex = 1
        grpSecurityQuestions.TabStop = False
        grpSecurityQuestions.Text = "Security Verification"
        ' 
        ' btnVerifyAnswers
        ' 
        btnVerifyAnswers.BackColor = Color.Gray
        btnVerifyAnswers.CornerRadius = 8
        btnVerifyAnswers.FlatAppearance.BorderSize = 0
        btnVerifyAnswers.FlatStyle = FlatStyle.Flat
        btnVerifyAnswers.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnVerifyAnswers.ForeColor = Color.White
        btnVerifyAnswers.Location = New Point(150, 260)
        btnVerifyAnswers.Name = "btnVerifyAnswers"
        btnVerifyAnswers.Size = New Size(200, 40)
        btnVerifyAnswers.TabIndex = 2
        btnVerifyAnswers.Text = "Verify & Reset Password"
        btnVerifyAnswers.UseVisualStyleBackColor = False
        ' 
        ' lblSecurityError
        ' 
        lblSecurityError.AutoSize = True
        lblSecurityError.Font = New Font("Segoe UI", 8.0F)
        lblSecurityError.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        lblSecurityError.Location = New Point(20, 240)
        lblSecurityError.Name = "lblSecurityError"
        lblSecurityError.Size = New Size(0, 13)
        lblSecurityError.TabIndex = 1
        ' 
        ' pnlSecurityQuestions
        ' 
        pnlSecurityQuestions.AutoScroll = True
        pnlSecurityQuestions.Location = New Point(20, 30)
        pnlSecurityQuestions.Name = "pnlSecurityQuestions"
        pnlSecurityQuestions.Size = New Size(460, 196)
        pnlSecurityQuestions.TabIndex = 0
        ' 
        ' grpUserInfo
        ' 
        grpUserInfo.Controls.Add(btnSearchUser)
        grpUserInfo.Controls.Add(txtUsername)
        grpUserInfo.Controls.Add(lblUsername)
        grpUserInfo.Controls.Add(lblInfo)
        grpUserInfo.Location = New Point(20, 20)
        grpUserInfo.Name = "grpUserInfo"
        grpUserInfo.Size = New Size(500, 90)
        grpUserInfo.TabIndex = 0
        grpUserInfo.TabStop = False
        grpUserInfo.Text = "User Information"
        ' 
        ' btnSearchUser
        ' 
        btnSearchUser.BackColor = Color.Gray
        btnSearchUser.CornerRadius = 6
        btnSearchUser.FlatAppearance.BorderSize = 0
        btnSearchUser.FlatStyle = FlatStyle.Flat
        btnSearchUser.Font = New Font("Segoe UI", 9.0F)
        btnSearchUser.ForeColor = Color.White
        btnSearchUser.Location = New Point(350, 40)
        btnSearchUser.Name = "btnSearchUser"
        btnSearchUser.Size = New Size(100, 30)
        btnSearchUser.TabIndex = 3
        btnSearchUser.Text = "Search"
        btnSearchUser.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.Location = New Point(100, 40)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(240, 25)
        txtUsername.TabIndex = 2
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.0F)
        lblUsername.Location = New Point(20, 45)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(63, 15)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username:"
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 8.0F)
        lblInfo.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblInfo.Location = New Point(20, 65)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(0, 13)
        lblInfo.TabIndex = 0
        ' 
        ' tabOTP
        ' 
        tabOTP.Controls.Add(grpOTPReset)
        tabOTP.Location = New Point(4, 24)
        tabOTP.Name = "tabOTP"
        tabOTP.Padding = New Padding(3)
        tabOTP.Size = New Size(542, 472)
        tabOTP.TabIndex = 1
        tabOTP.Text = "OTP via Email"
        tabOTP.UseVisualStyleBackColor = True
        ' 
        ' grpOTPReset
        ' 
        grpOTPReset.Controls.Add(btnSendOTP)
        grpOTPReset.Controls.Add(btnVerifyOTP)
        grpOTPReset.Controls.Add(txtOTP)
        grpOTPReset.Controls.Add(lblOTP)
        grpOTPReset.Controls.Add(lblOTPError)
        grpOTPReset.Location = New Point(20, 120)
        grpOTPReset.Name = "grpOTPReset"
        grpOTPReset.Size = New Size(500, 200)
        grpOTPReset.TabIndex = 0
        grpOTPReset.TabStop = False
        grpOTPReset.Text = "OTP Verification"
        ' 
        ' btnSendOTP
        ' 
        btnSendOTP.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        btnSendOTP.CornerRadius = 8
        btnSendOTP.FlatAppearance.BorderSize = 0
        btnSendOTP.FlatStyle = FlatStyle.Flat
        btnSendOTP.Font = New Font("Segoe UI", 9.0F)
        btnSendOTP.ForeColor = Color.White
        btnSendOTP.Location = New Point(150, 80)
        btnSendOTP.Name = "btnSendOTP"
        btnSendOTP.Size = New Size(200, 35)
        btnSendOTP.TabIndex = 4
        btnSendOTP.Text = "Send OTP"
        btnSendOTP.UseVisualStyleBackColor = False
        ' 
        ' btnVerifyOTP
        ' 
        btnVerifyOTP.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnVerifyOTP.CornerRadius = 8
        btnVerifyOTP.Enabled = False
        btnVerifyOTP.FlatAppearance.BorderSize = 0
        btnVerifyOTP.FlatStyle = FlatStyle.Flat
        btnVerifyOTP.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnVerifyOTP.ForeColor = Color.White
        btnVerifyOTP.Location = New Point(150, 140)
        btnVerifyOTP.Name = "btnVerifyOTP"
        btnVerifyOTP.Size = New Size(200, 40)
        btnVerifyOTP.TabIndex = 3
        btnVerifyOTP.Text = "Verify OTP & Reset Password"
        btnVerifyOTP.UseVisualStyleBackColor = False
        ' 
        ' txtOTP
        ' 
        txtOTP.Font = New Font("Segoe UI", 11.0F)
        txtOTP.Location = New Point(150, 40)
        txtOTP.Name = "txtOTP"
        txtOTP.Size = New Size(200, 27)
        txtOTP.TabIndex = 2
        txtOTP.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblOTP
        ' 
        lblOTP.AutoSize = True
        lblOTP.Font = New Font("Segoe UI", 9.0F)
        lblOTP.Location = New Point(100, 48)
        lblOTP.Name = "lblOTP"
        lblOTP.Size = New Size(32, 15)
        lblOTP.TabIndex = 1
        lblOTP.Text = "OTP:"
        ' 
        ' lblOTPError
        ' 
        lblOTPError.AutoSize = True
        lblOTPError.Font = New Font("Segoe UI", 8.0F)
        lblOTPError.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
        lblOTPError.Location = New Point(20, 180)
        lblOTPError.Name = "lblOTPError"
        lblOTPError.Size = New Size(0, 13)
        lblOTPError.TabIndex = 0
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(TabControl1)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(550, 500)
        pnlMain.TabIndex = 1
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(550, 500)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ForgotPasswordForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Forgot Password"
        TabControl1.ResumeLayout(False)
        tabSecurityQuestions.ResumeLayout(False)
        grpSecurityQuestions.ResumeLayout(False)
        grpSecurityQuestions.PerformLayout()
        grpUserInfo.ResumeLayout(False)
        grpUserInfo.PerformLayout()
        tabOTP.ResumeLayout(False)
        grpOTPReset.ResumeLayout(False)
        grpOTPReset.PerformLayout()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents TabControl1 As TabControl
    Private WithEvents tabSecurityQuestions As TabPage
    Private WithEvents tabOTP As TabPage
    Private WithEvents grpUserInfo As GroupBox
    Private WithEvents grpSecurityQuestions As GroupBox
    Private WithEvents grpOTPReset As GroupBox
    Private WithEvents btnSearchUser As RoundedButton
    Private WithEvents txtUsername As TextBox
    Private WithEvents lblUsername As Label
    Private WithEvents lblInfo As Label
    Private WithEvents pnlSecurityQuestions As Panel
    Private WithEvents btnVerifyAnswers As RoundedButton
    Private WithEvents lblSecurityError As Label
    Private WithEvents btnSendOTP As RoundedButton
    Private WithEvents btnVerifyOTP As RoundedButton
    Private WithEvents txtOTP As TextBox
    Private WithEvents lblOTP As Label
    Private WithEvents lblOTPError As Label
    Private WithEvents pnlMain As Panel
End Class