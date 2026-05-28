Namespace ESG_SOLUTION

    Partial Class LoginForm

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            pnlLeft = New Panel()
            lblBrand = New Label()
            lblTagline = New Label()
            lblCompany = New Label()
            pnlStatLine = New Panel()
            pnlRight = New Panel()
            Button2 = New Button()
            btnLogin2 = New Button()
            lblWelcome = New Label()
            lblSub = New Label()
            lblUserLbl = New Label()
            lblUserIcon = New Label()
            txtUsername = New TextBox()
            pnlUserLine = New Panel()
            lblPassLbl = New Label()
            lblPassIcon = New Label()
            txtPassword = New TextBox()
            pnlPassLine = New Panel()
            chkShow = New CheckBox()
            lblError = New Label()
            lblVersion = New Label()
            pnlLeft.SuspendLayout()
            pnlRight.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnlLeft
            ' 
            pnlLeft.BackColor = SystemColors.Control
            pnlLeft.Controls.Add(lblBrand)
            pnlLeft.Controls.Add(lblTagline)
            pnlLeft.Controls.Add(lblCompany)
            pnlLeft.Controls.Add(pnlStatLine)
            pnlLeft.Dock = DockStyle.Left
            pnlLeft.Location = New Point(0, 0)
            pnlLeft.Name = "pnlLeft"
            pnlLeft.Size = New Size(360, 560)
            pnlLeft.TabIndex = 0
            ' 
            ' lblBrand
            ' 
            lblBrand.BackColor = Color.Transparent
            lblBrand.Font = New Font("Georgia", 36F, FontStyle.Bold)
            lblBrand.ForeColor = Color.Gray
            lblBrand.Location = New Point(28, 188)
            lblBrand.Name = "lblBrand"
            lblBrand.Size = New Size(280, 58)
            lblBrand.TabIndex = 1
            lblBrand.Text = "DCL-ESG"
            lblBrand.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblTagline
            ' 
            lblTagline.BackColor = Color.Transparent
            lblTagline.Font = New Font("Segoe UI", 8.5F)
            lblTagline.ForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
            lblTagline.Location = New Point(38, 252)
            lblTagline.Name = "lblTagline"
            lblTagline.Size = New Size(290, 18)
            lblTagline.TabIndex = 2
            lblTagline.Text = "Environmental  ·  Social  ·  Governance"
            ' 
            ' lblCompany
            ' 
            lblCompany.BackColor = Color.Transparent
            lblCompany.Font = New Font("Segoe UI", 9.5F)
            lblCompany.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
            lblCompany.Location = New Point(38, 274)
            lblCompany.Name = "lblCompany"
            lblCompany.Size = New Size(280, 20)
            lblCompany.TabIndex = 3
            lblCompany.Text = "Diamond Cutters Ltd"
            ' 
            ' pnlStatLine
            ' 
            pnlStatLine.BackColor = Color.FromArgb(CByte(35), CByte(255), CByte(255), CByte(255))
            pnlStatLine.Location = New Point(38, 326)
            pnlStatLine.Name = "pnlStatLine"
            pnlStatLine.Size = New Size(270, 1)
            pnlStatLine.TabIndex = 4
            ' 
            ' pnlRight
            ' 
            pnlRight.BackColor = SystemColors.Control
            pnlRight.Controls.Add(Button2)
            pnlRight.Controls.Add(btnLogin2)
            pnlRight.Controls.Add(lblWelcome)
            pnlRight.Controls.Add(lblSub)
            pnlRight.Controls.Add(lblUserLbl)
            pnlRight.Controls.Add(lblUserIcon)
            pnlRight.Controls.Add(txtUsername)
            pnlRight.Controls.Add(pnlUserLine)
            pnlRight.Controls.Add(lblPassLbl)
            pnlRight.Controls.Add(lblPassIcon)
            pnlRight.Controls.Add(txtPassword)
            pnlRight.Controls.Add(pnlPassLine)
            pnlRight.Controls.Add(chkShow)
            pnlRight.Controls.Add(lblError)
            pnlRight.Controls.Add(lblVersion)
            pnlRight.Dock = DockStyle.Fill
            pnlRight.Location = New Point(360, 0)
            pnlRight.Name = "pnlRight"
            pnlRight.Size = New Size(520, 560)
            pnlRight.TabIndex = 1
            ' 
            ' Button2
            ' 
            Button2.Location = New Point(147, 426)
            Button2.Name = "Button2"
            Button2.Size = New Size(179, 29)
            Button2.TabIndex = 16
            Button2.Text = "Exit"
            Button2.UseVisualStyleBackColor = True
            ' 
            ' btnLogin2
            ' 
            btnLogin2.Location = New Point(147, 382)
            btnLogin2.Name = "btnLogin2"
            btnLogin2.Size = New Size(179, 29)
            btnLogin2.TabIndex = 15
            btnLogin2.Text = "Login"
            btnLogin2.UseVisualStyleBackColor = True
            ' 
            ' lblWelcome
            ' 
            lblWelcome.BackColor = Color.Transparent
            lblWelcome.Font = New Font("Georgia", 26F, FontStyle.Bold)
            lblWelcome.ForeColor = Color.Gray
            lblWelcome.Location = New Point(48, 82)
            lblWelcome.Name = "lblWelcome"
            lblWelcome.Size = New Size(200, 48)
            lblWelcome.TabIndex = 0
            lblWelcome.Text = "Sign in"
            ' 
            ' lblSub
            ' 
            lblSub.BackColor = Color.Transparent
            lblSub.Font = New Font("Segoe UI", 9.5F)
            lblSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
            lblSub.Location = New Point(50, 132)
            lblSub.Name = "lblSub"
            lblSub.Size = New Size(380, 18)
            lblSub.TabIndex = 1
            lblSub.Text = "Enter your credentials to access the ESG portal"
            ' 
            ' lblUserLbl
            ' 
            lblUserLbl.BackColor = Color.Transparent
            lblUserLbl.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
            lblUserLbl.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
            lblUserLbl.Location = New Point(50, 172)
            lblUserLbl.Name = "lblUserLbl"
            lblUserLbl.Size = New Size(100, 16)
            lblUserLbl.TabIndex = 2
            lblUserLbl.Text = "USERNAME"
            ' 
            ' lblUserIcon
            ' 
            lblUserIcon.BackColor = Color.Transparent
            lblUserIcon.Font = New Font("Segoe UI Emoji", 12F)
            lblUserIcon.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
            lblUserIcon.Location = New Point(50, 194)
            lblUserIcon.Name = "lblUserIcon"
            lblUserIcon.Size = New Size(30, 34)
            lblUserIcon.TabIndex = 3
            lblUserIcon.Text = "👤"
            lblUserIcon.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' txtUsername
            ' 
            txtUsername.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
            txtUsername.BorderStyle = BorderStyle.None
            txtUsername.Font = New Font("Segoe UI", 10.5F)
            txtUsername.ForeColor = Color.Black
            txtUsername.Location = New Point(84, 200)
            txtUsername.Name = "txtUsername"
            txtUsername.PlaceholderText = "Enter username"
            txtUsername.Size = New Size(330, 19)
            txtUsername.TabIndex = 4
            ' 
            ' pnlUserLine
            ' 
            pnlUserLine.BackColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
            pnlUserLine.Location = New Point(50, 232)
            pnlUserLine.Name = "pnlUserLine"
            pnlUserLine.Size = New Size(368, 1)
            pnlUserLine.TabIndex = 5
            ' 
            ' lblPassLbl
            ' 
            lblPassLbl.BackColor = Color.Transparent
            lblPassLbl.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
            lblPassLbl.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
            lblPassLbl.Location = New Point(50, 252)
            lblPassLbl.Name = "lblPassLbl"
            lblPassLbl.Size = New Size(100, 16)
            lblPassLbl.TabIndex = 6
            lblPassLbl.Text = "PASSWORD"
            ' 
            ' lblPassIcon
            ' 
            lblPassIcon.BackColor = Color.Transparent
            lblPassIcon.Font = New Font("Segoe UI Emoji", 12F)
            lblPassIcon.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
            lblPassIcon.Location = New Point(50, 274)
            lblPassIcon.Name = "lblPassIcon"
            lblPassIcon.Size = New Size(30, 34)
            lblPassIcon.TabIndex = 7
            lblPassIcon.Text = "🔒"
            lblPassIcon.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' txtPassword
            ' 
            txtPassword.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
            txtPassword.BorderStyle = BorderStyle.None
            txtPassword.Font = New Font("Segoe UI", 10.5F)
            txtPassword.ForeColor = Color.Black
            txtPassword.Location = New Point(84, 280)
            txtPassword.Name = "txtPassword"
            txtPassword.PasswordChar = "●"c
            txtPassword.PlaceholderText = "Enter password"
            txtPassword.Size = New Size(330, 19)
            txtPassword.TabIndex = 8
            ' 
            ' pnlPassLine
            ' 
            pnlPassLine.BackColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
            pnlPassLine.Location = New Point(50, 312)
            pnlPassLine.Name = "pnlPassLine"
            pnlPassLine.Size = New Size(368, 1)
            pnlPassLine.TabIndex = 9
            ' 
            ' chkShow
            ' 
            chkShow.BackColor = Color.Transparent
            chkShow.Cursor = Cursors.Hand
            chkShow.Font = New Font("Segoe UI", 9F)
            chkShow.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
            chkShow.Location = New Point(50, 324)
            chkShow.Name = "chkShow"
            chkShow.Size = New Size(130, 22)
            chkShow.TabIndex = 10
            chkShow.Text = "Show password"
            chkShow.UseVisualStyleBackColor = False
            ' 
            ' lblError
            ' 
            lblError.BackColor = Color.Transparent
            lblError.Font = New Font("Segoe UI", 9F)
            lblError.ForeColor = Color.FromArgb(CByte(239), CByte(68), CByte(68))
            lblError.Location = New Point(50, 359)
            lblError.Name = "lblError"
            lblError.Size = New Size(368, 20)
            lblError.TabIndex = 11
            ' 
            ' lblVersion
            ' 
            lblVersion.BackColor = Color.Transparent
            lblVersion.Font = New Font("Segoe UI", 7.5F)
            lblVersion.ForeColor = Color.FromArgb(CByte(55), CByte(75), CByte(95))
            lblVersion.Location = New Point(156, 535)
            lblVersion.Name = "lblVersion"
            lblVersion.Size = New Size(170, 16)
            lblVersion.TabIndex = 14
            lblVersion.Text = "v1.0.0  ·  © 2026 Diamond Cutters Ltd"
            ' 
            ' LoginForm
            ' 
            BackColor = Color.FromArgb(CByte(18), CByte(24), CByte(32))
            ClientSize = New Size(880, 560)
            Controls.Add(pnlRight)
            Controls.Add(pnlLeft)
            FormBorderStyle = FormBorderStyle.None
            MinimumSize = New Size(880, 560)
            Name = "LoginForm"
            StartPosition = FormStartPosition.CenterScreen
            Text = "DCL-ESG | Login"
            pnlLeft.ResumeLayout(False)
            pnlRight.ResumeLayout(False)
            pnlRight.PerformLayout()
            ResumeLayout(False)
        End Sub

        ' ── Designer fields ───────────────────────────────────────────────────
        Private pnlLeft As System.Windows.Forms.Panel
        Private lblBrand As System.Windows.Forms.Label
        Private lblTagline As System.Windows.Forms.Label
        Private lblCompany As System.Windows.Forms.Label
        Private pnlStatLine As System.Windows.Forms.Panel
        Private pnlRight As System.Windows.Forms.Panel
        Private lblWelcome As System.Windows.Forms.Label
        Private lblSub As System.Windows.Forms.Label
        Private lblUserLbl As System.Windows.Forms.Label
        Private lblUserIcon As System.Windows.Forms.Label
        Private txtUsername As System.Windows.Forms.TextBox
        Private pnlUserLine As System.Windows.Forms.Panel
        Private lblPassLbl As System.Windows.Forms.Label
        Private lblPassIcon As System.Windows.Forms.Label
        Private txtPassword As System.Windows.Forms.TextBox
        Private pnlPassLine As System.Windows.Forms.Panel
        Private chkShow As System.Windows.Forms.CheckBox
        Private lblError As System.Windows.Forms.Label
        Private lblVersion As System.Windows.Forms.Label
        Private btnExit As RoundedButton
        Friend WithEvents btnLogin1 As RoundedButton
        Friend WithEvents btnexitbtn As RoundedButton
        Friend WithEvents Button2 As Button
        Friend WithEvents btnLogin2 As Button
    End Class

End Namespace
