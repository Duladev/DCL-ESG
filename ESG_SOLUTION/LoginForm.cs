using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ESG_SOLUTION
{
    public partial class LoginForm : Form
    {
        // ── Colours ───────────────────────────────────────────────────────────
        private readonly Color Emerald = Color.FromArgb(16, 185, 129);
        private readonly Color EmeraldHov = Color.FromArgb(5, 150, 105);
        private readonly Color Border = Color.FromArgb(50, 65, 80);
        private readonly Color TextMuted = Color.FromArgb(100, 116, 139);
        private readonly Color TextPrimary = Color.FromArgb(240, 245, 248);
        private readonly Color ErrorColor = Color.FromArgb(239, 68, 68);

        // ── DB connection — update before deployment ──────────────────────────
        private const string ConnStr =
            "Server=DCL-ICT-007/DEVELOPER;Database=ESG;Integrated Security=True;";

        // ═════════════════════════════════════════════════════════════════════
        public LoginForm()
        {
            InitializeComponent();   // calls LoginForm.Designer.cs
            WireEvents();
            SetRoundedCorners(14);
        }

        // ═════════════════════════════════════════════════════════════════════
        //  Wire events (kept out of Designer file)
        // ═════════════════════════════════════════════════════════════════════
        private void WireEvents()
        {
            // Focus highlight on input lines
            txtUsername.GotFocus += (s, e) => pnlUserLine.BackColor = Emerald;
            txtUsername.LostFocus += (s, e) => pnlUserLine.BackColor = Border;
            txtPassword.GotFocus += (s, e) => pnlPassLine.BackColor = Emerald;
            txtPassword.LostFocus += (s, e) => pnlPassLine.BackColor = Border;

            // Show / hide password
            chkShow.CheckedChanged += (s, e) =>
                txtPassword.PasswordChar = chkShow.Checked ? '\0' : '●';

            // Buttons
            btnLogin.Click += BtnLogin_Click;
            btnLogin.MouseEnter += (s, e) => btnLogin.BackColor = EmeraldHov;
            btnLogin.MouseLeave += (s, e) => btnLogin.BackColor = Emerald;

            btnExit.Click += (s, e) => Application.Exit();
            btnExit.MouseEnter += (s, e) => { btnExit.ForeColor = TextPrimary; btnExit.FlatAppearance.BorderColor = TextMuted; };
            btnExit.MouseLeave += (s, e) => { btnExit.ForeColor = TextMuted; btnExit.FlatAppearance.BorderColor = Border; };

            // Dragging (no title bar)
            pnlLeft.MouseDown += FormDrag_MouseDown;
            pnlRight.MouseDown += FormDrag_MouseDown;
            lblWelcome.MouseDown += FormDrag_MouseDown;
            lblSub.MouseDown += FormDrag_MouseDown;
        }

        // ═════════════════════════════════════════════════════════════════════
        //  Rounded window corners
        // ═════════════════════════════════════════════════════════════════════
        private void SetRoundedCorners(int radius)
        {
            this.Shown += (s, e) =>
            {
                int d = radius * 2;
                var path = new GraphicsPath();
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(Width - d, 0, d, d, 270, 90);
                path.AddArc(Width - d, Height - d, d, d, 0, 90);
                path.AddArc(0, Height - d, d, d, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            };
        }

        // ═════════════════════════════════════════════════════════════════════
        //  Custom painting
        // ═════════════════════════════════════════════════════════════════════
        private void PnlLeft_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Hexagon grid pattern
            using (var pen = new Pen(Color.FromArgb(28, 255, 255, 255), 0.6f))
            {
                int s = 50;
                for (int y = -s; y < pnlLeft.Height + s; y += (int)(s * 1.5))
                    for (int x = -s; x < pnlLeft.Width + s; x += s + 10)
                        DrawHex(g, pen, x, y, s);
            }

            // Emerald glow — bottom left
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(-60, pnlLeft.Height - 160, 240, 240);
                using (var br = new PathGradientBrush(gp))
                {
                    br.CenterColor = Color.FromArgb(55, 16, 185, 129);
                    br.SurroundColors = new[] { Color.Transparent };
                    g.FillPath(br, gp);
                }
            }

            // Vertical separator
            using (var p = new Pen(Color.FromArgb(45, 255, 255, 255), 1f))
                g.DrawLine(p, pnlLeft.Width - 1, 40, pnlLeft.Width - 1, pnlLeft.Height - 40);
        }

        private void PnlRight_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            using (var pen = new Pen(Color.FromArgb(12, 255, 255, 255), 1f))
                for (int y = 0; y < pnlRight.Height; y += 40)
                    g.DrawLine(pen, 0, y, pnlRight.Width, y);
        }

        private static void DrawHex(Graphics g, Pen pen, int cx, int cy, int r)
        {
            var pts = new PointF[6];
            for (int i = 0; i < 6; i++)
            {
                double a = Math.PI / 3 * i - Math.PI / 6;
                pts[i] = new PointF(cx + r * (float)Math.Cos(a),
                                    cy + r * (float)Math.Sin(a));
            }
            g.DrawPolygon(pen, pts);
        }

        // ═════════════════════════════════════════════════════════════════════
        //  Login logic
        // ═════════════════════════════════════════════════════════════════════
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                ShowError("Please enter both username and password.");
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Signing in...";

            try
            {
                if (AuthenticateUser(user, pass))
                {
                    // TODO: open main dashboard
                    // new MainForm(user).Show();
                    // this.Hide();
                    MessageBox.Show(
                        $"Welcome, {user}!\nLogin successful.",
                        "DCL-ESG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                }
                else
                {
                    ShowError("Invalid username or password.");
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            catch (SqlException sqlEx)
            {
                ShowError("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                ShowError("Connection error: " + ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "SIGN  IN";
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Matches your Users table: Username and UserPws columns
            const string sql =
                "SELECT COUNT(1) FROM Users WHERE Username = @user AND UserPws = @pass";

            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.NVarChar, 100).Value = username;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 256).Value = password;
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        private void ShowError(string msg)
        {
            lblError.Text = "⚠  " + msg;
            ShakeAsync(pnlRight, 6);
        }

        private async void ShakeAsync(Control ctrl, int amount)
        {
            Point origin = ctrl.Location;
            for (int i = 0; i < 6; i++)
            {
                ctrl.Left = origin.X + (i % 2 == 0 ? amount : -amount);
                await System.Threading.Tasks.Task.Delay(28);
            }
            ctrl.Left = origin.X;
        }

        // ═════════════════════════════════════════════════════════════════════
        //  Drag to move (borderless form)
        // ═════════════════════════════════════════════════════════════════════
        private Point _dragStart;

        private void FormDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                _dragStart = e.Location;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Left + e.X - _dragStart.X,
                                     Top + e.Y - _dragStart.Y);
            base.OnMouseMove(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // ═════════════════════════════════════════════════════════════════════════
    //  RoundedButton — shared helper used by Designer
    // ═════════════════════════════════════════════════════════════════════════
    public class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 8;

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundPath(rect, CornerRadius))
            {
                using (var fill = new SolidBrush(BackColor))
                    g.FillPath(fill, path);

                if (FlatAppearance.BorderSize > 0)
                    using (var bp = new Pen(FlatAppearance.BorderColor, 1f))
                        g.DrawPath(bp, path);

                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                using (var tb = new SolidBrush(ForeColor))
                    g.DrawString(Text, Font, tb, rect, sf);
            }
        }

        private static GraphicsPath RoundPath(Rectangle r, int rad)
        {
            int d = rad * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }
}
