namespace ESG_SOLUTION
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblBrand = new Label();
            lblTagline = new Label();
            lblCompany = new Label();
            pnlStatLine = new Panel();
            pnlRight = new Panel();
            btnExit = new RoundedButton();
            lblWelcome = new Label();
            lblSub = new Label();
            lblUserLbl = new Label();
            lblUserIcon = new Label();
            txtUsername = new TextBox();
            pnlUserLine = new Panel();
            lblPassLbl = new Label();
            lblPassIcon = new Label();
            txtPassword = new TextBox();
            pnlPassLine = new Panel();
            chkShow = new CheckBox();
            lblError = new Label();
            btnLogin = new RoundedButton();
            lblVersion = new Label();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(15, 22, 30);
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Controls.Add(lblTagline);
            pnlLeft.Controls.Add(lblCompany);
            pnlLeft.Controls.Add(pnlStatLine);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(360, 560);
            pnlLeft.TabIndex = 0;
            pnlLeft.Paint += PnlLeft_Paint;
            // 
            // lblBrand
            // 
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Font = new Font("Georgia", 36F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(240, 245, 248);
            lblBrand.Location = new Point(28, 194);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(280, 58);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "DCL-ESG";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTagline
            // 
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Font = new Font("Segoe UI", 8.5F);
            lblTagline.ForeColor = Color.FromArgb(16, 185, 129);
            lblTagline.Location = new Point(38, 258);
            lblTagline.Name = "lblTagline";
            lblTagline.Size = new Size(290, 18);
            lblTagline.TabIndex = 2;
            lblTagline.Text = "Environmental  ·  Social  ·  Governance";
            // 
            // lblCompany
            // 
            lblCompany.BackColor = Color.Transparent;
            lblCompany.Font = new Font("Segoe UI", 9.5F);
            lblCompany.ForeColor = Color.FromArgb(100, 116, 139);
            lblCompany.Location = new Point(38, 280);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(280, 20);
            lblCompany.TabIndex = 3;
            lblCompany.Text = "Diamond Cutters Ltd";
            // 
            // pnlStatLine
            // 
            pnlStatLine.BackColor = Color.FromArgb(35, 255, 255, 255);
            pnlStatLine.Location = new Point(38, 326);
            pnlStatLine.Name = "pnlStatLine";
            pnlStatLine.Size = new Size(270, 1);
            pnlStatLine.TabIndex = 4;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(26, 34, 44);
            pnlRight.Controls.Add(btnExit);
            pnlRight.Controls.Add(lblWelcome);
            pnlRight.Controls.Add(lblSub);
            pnlRight.Controls.Add(lblUserLbl);
            pnlRight.Controls.Add(lblUserIcon);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(pnlUserLine);
            pnlRight.Controls.Add(lblPassLbl);
            pnlRight.Controls.Add(lblPassIcon);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(pnlPassLine);
            pnlRight.Controls.Add(chkShow);
            pnlRight.Controls.Add(lblError);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lblVersion);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(360, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(520, 560);
            pnlRight.TabIndex = 1;
            pnlRight.Paint += PnlRight_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(16, 185, 129);
            btnExit.CornerRadius = 8;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(5, 30, 20);
            btnExit.Location = new Point(50, 434);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(368, 46);
            btnExit.TabIndex = 15;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Georgia", 26F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(240, 245, 248);
            lblWelcome.Location = new Point(48, 82);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(200, 48);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Sign in";
            // 
            // lblSub
            // 
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 9.5F);
            lblSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblSub.Location = new Point(50, 132);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(380, 18);
            lblSub.TabIndex = 1;
            lblSub.Text = "Enter your credentials to access the ESG portal";
            // 
            // lblUserLbl
            // 
            lblUserLbl.BackColor = Color.Transparent;
            lblUserLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblUserLbl.ForeColor = Color.FromArgb(100, 116, 139);
            lblUserLbl.Location = new Point(50, 172);
            lblUserLbl.Name = "lblUserLbl";
            lblUserLbl.Size = new Size(100, 16);
            lblUserLbl.TabIndex = 2;
            lblUserLbl.Text = "USERNAME";
            // 
            // lblUserIcon
            // 
            lblUserIcon.BackColor = Color.Transparent;
            lblUserIcon.Font = new Font("Segoe UI Emoji", 12F);
            lblUserIcon.ForeColor = Color.FromArgb(71, 85, 105);
            lblUserIcon.Location = new Point(50, 194);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(30, 34);
            lblUserIcon.TabIndex = 3;
            lblUserIcon.Text = "👤";
            lblUserIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(36, 46, 58);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 10.5F);
            txtUsername.ForeColor = Color.FromArgb(226, 232, 240);
            txtUsername.Location = new Point(84, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(330, 19);
            txtUsername.TabIndex = 4;
            // 
            // pnlUserLine
            // 
            pnlUserLine.BackColor = Color.FromArgb(50, 65, 80);
            pnlUserLine.Location = new Point(50, 232);
            pnlUserLine.Name = "pnlUserLine";
            pnlUserLine.Size = new Size(368, 1);
            pnlUserLine.TabIndex = 5;
            // 
            // lblPassLbl
            // 
            lblPassLbl.BackColor = Color.Transparent;
            lblPassLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblPassLbl.ForeColor = Color.FromArgb(100, 116, 139);
            lblPassLbl.Location = new Point(50, 252);
            lblPassLbl.Name = "lblPassLbl";
            lblPassLbl.Size = new Size(100, 16);
            lblPassLbl.TabIndex = 6;
            lblPassLbl.Text = "PASSWORD";
            // 
            // lblPassIcon
            // 
            lblPassIcon.BackColor = Color.Transparent;
            lblPassIcon.Font = new Font("Segoe UI Emoji", 12F);
            lblPassIcon.ForeColor = Color.FromArgb(71, 85, 105);
            lblPassIcon.Location = new Point(50, 274);
            lblPassIcon.Name = "lblPassIcon";
            lblPassIcon.Size = new Size(30, 34);
            lblPassIcon.TabIndex = 7;
            lblPassIcon.Text = "🔒";
            lblPassIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(36, 46, 58);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = Color.FromArgb(226, 232, 240);
            txtPassword.Location = new Point(84, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(330, 19);
            txtPassword.TabIndex = 8;
            // 
            // pnlPassLine
            // 
            pnlPassLine.BackColor = Color.FromArgb(50, 65, 80);
            pnlPassLine.Location = new Point(50, 312);
            pnlPassLine.Name = "pnlPassLine";
            pnlPassLine.Size = new Size(368, 1);
            pnlPassLine.TabIndex = 9;
            // 
            // chkShow
            // 
            chkShow.BackColor = Color.Transparent;
            chkShow.Cursor = Cursors.Hand;
            chkShow.Font = new Font("Segoe UI", 9F);
            chkShow.ForeColor = Color.FromArgb(100, 116, 139);
            chkShow.Location = new Point(50, 324);
            chkShow.Name = "chkShow";
            chkShow.Size = new Size(130, 22);
            chkShow.TabIndex = 10;
            chkShow.Text = "Show password";
            chkShow.UseVisualStyleBackColor = false;
            // 
            // lblError
            // 
            lblError.BackColor = Color.Transparent;
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(239, 68, 68);
            lblError.Location = new Point(50, 354);
            lblError.Name = "lblError";
            lblError.Size = new Size(368, 20);
            lblError.TabIndex = 11;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(16, 185, 129);
            btnLogin.CornerRadius = 8;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(5, 30, 20);
            btnLogin.Location = new Point(50, 382);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(368, 46);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "SIGN  IN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblVersion
            // 
            lblVersion.BackColor = Color.Transparent;
            lblVersion.Font = new Font("Segoe UI", 7.5F);
            lblVersion.ForeColor = Color.FromArgb(55, 75, 95);
            lblVersion.Location = new Point(156, 535);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(170, 16);
            lblVersion.TabIndex = 14;
            lblVersion.Text = "v1.0.0  ·  © 2024 Diamond Cutters Ltd";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            BackColor = Color.FromArgb(18, 24, 32);
            ClientSize = new Size(880, 560);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(880, 560);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCL-ESG | Login";
            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // ── Designer fields ───────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Panel pnlStatLine;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblUserLbl;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlUserLine;
        private System.Windows.Forms.Label lblPassLbl;
        private System.Windows.Forms.Label lblPassIcon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPassLine;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Label lblError;
        private ESG_SOLUTION.RoundedButton btnLogin;
        private System.Windows.Forms.Label lblVersion;
        private RoundedButton btnExit;
    }
}
