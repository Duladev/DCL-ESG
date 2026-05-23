Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Namespace ESG_SOLUTION

    Public Class LoginForm
        Inherits Form

        ' ── Colours ───────────────────────────────────────────────────────────
        Private ReadOnly Emerald As Color = Color.FromArgb(16, 185, 129)
        Private ReadOnly EmeraldHov As Color = Color.FromArgb(5, 150, 105)
        Private ReadOnly BorderColor As Color = Color.FromArgb(50, 65, 80)
        Private ReadOnly TextMuted As Color = Color.FromArgb(100, 116, 139)
        Private ReadOnly TextPrimary As Color = Color.FromArgb(240, 245, 248)
        Private ReadOnly ErrorColor As Color = Color.FromArgb(239, 68, 68)

        ' ── DB connection — update before deployment ──────────────────────────
        Private Const ConnStr As String =
            "Server=DCL-ICT-007/DEVELOPER;Database=ESG;Integrated Security=True;"

        ' ═════════════════════════════════════════════════════════════════════
        Public Sub New()
            InitializeComponent()
            WireEvents()
            SetRoundedCorners(14)
        End Sub

        ' ═════════════════════════════════════════════════════════════════════
        '  Wire events (kept out of Designer file)
        ' ═════════════════════════════════════════════════════════════════════
        Private Sub WireEvents()
            ' Focus highlight on input lines
            AddHandler txtUsername.GotFocus, Sub(s, e) pnlUserLine.BackColor = Emerald
            AddHandler txtUsername.LostFocus, Sub(s, e) pnlUserLine.BackColor = BorderColor
            AddHandler txtPassword.GotFocus, Sub(s, e) pnlPassLine.BackColor = Emerald
            AddHandler txtPassword.LostFocus, Sub(s, e) pnlPassLine.BackColor = BorderColor

            ' Show / hide password
            'AddHandler chkShow.CheckedChanged, Sub(s, e)
            'txtPassword.PasswordChar = If(chkShow.Checked, ChrW(0), "●"c)
            'End Sub



            ' Dragging (no title bar)
            AddHandler pnlLeft.MouseDown, AddressOf FormDrag_MouseDown
            AddHandler pnlRight.MouseDown, AddressOf FormDrag_MouseDown
            AddHandler lblWelcome.MouseDown, AddressOf FormDrag_MouseDown
            AddHandler lblSub.MouseDown, AddressOf FormDrag_MouseDown
        End Sub

        ' ═════════════════════════════════════════════════════════════════════
        '  Rounded window corners
        ' ═════════════════════════════════════════════════════════════════════
        Private Sub SetRoundedCorners(radius As Integer)
            AddHandler Me.Shown, Sub(s, e)
                                     Dim d As Integer = radius * 2
                                     Dim path As New GraphicsPath()
                                     path.AddArc(0, 0, d, d, 180, 90)
                                     path.AddArc(Width - d, 0, d, d, 270, 90)
                                     path.AddArc(Width - d, Height - d, d, d, 0, 90)
                                     path.AddArc(0, Height - d, d, d, 90, 90)
                                     path.CloseFigure()
                                     Me.Region = New Region(path)
                                 End Sub
        End Sub

        ' ═════════════════════════════════════════════════════════════════════
        '  Custom painting
        ' ═════════════════════════════════════════════════════════════════════
        Private Sub PnlLeft_Paint(sender As Object, e As PaintEventArgs)
            Dim g As Graphics = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias

            ' Hexagon grid pattern
            Using pen As New Pen(Color.FromArgb(28, 255, 255, 255), 0.6F)
                Dim s As Integer = 50
                Dim y As Integer = -s
                Do While y < pnlLeft.Height + s
                    Dim x As Integer = -s
                    Do While x < pnlLeft.Width + s
                        DrawHex(g, pen, x, y, s)
                        x += s + 10
                    Loop
                    y += CInt(s * 1.5)
                Loop
            End Using

            ' Emerald glow — bottom left
            Using gp As New GraphicsPath()
                gp.AddEllipse(-60, pnlLeft.Height - 160, 240, 240)
                Using br As New PathGradientBrush(gp)
                    br.CenterColor = Color.FromArgb(55, 16, 185, 129)
                    br.SurroundColors = New Color() {Color.Transparent}
                    g.FillPath(br, gp)
                End Using
            End Using

            ' Vertical separator
            Using p As New Pen(Color.FromArgb(45, 255, 255, 255), 1.0F)
                g.DrawLine(p, pnlLeft.Width - 1, 40, pnlLeft.Width - 1, pnlLeft.Height - 40)
            End Using
        End Sub

        Private Sub PnlRight_Paint(sender As Object, e As PaintEventArgs)
            Dim g As Graphics = e.Graphics
            Using pen As New Pen(Color.FromArgb(12, 255, 255, 255), 1.0F)
                Dim y As Integer = 0
                Do While y < pnlRight.Height
                    g.DrawLine(pen, 0, y, pnlRight.Width, y)
                    y += 40
                Loop
            End Using
        End Sub

        Private Shared Sub DrawHex(g As Graphics, pen As Pen, cx As Integer, cy As Integer, r As Integer)
            Dim pts(5) As PointF
            For i As Integer = 0 To 5
                Dim a As Double = Math.PI / 3 * i - Math.PI / 6
                pts(i) = New PointF(cx + r * CSng(Math.Cos(a)),
                                    cy + r * CSng(Math.Sin(a)))
            Next
            g.DrawPolygon(pen, pts)
        End Sub

        ' ═════════════════════════════════════════════════════════════════════
        '  Login logic
        ' ═════════════════════════════════════════════════════════════════════

        Private Function AuthenticateUser(username As String, password As String) As Boolean
            ' Matches Users table: Username and UserPws columns
            Const sql As String =
                "SELECT COUNT(1) FROM vw_UserLogin WHERE Username = @user AND UserPws = @pass"

            Using conn As New SqlConnection(ConnStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.Add("@user", SqlDbType.NVarChar, 100).Value = username
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 256).Value = password
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        End Function

        Private Sub ShowError(msg As String)
            lblError.Text = "⚠  " & msg
            ShakeAsync(pnlRight, 6)
        End Sub

        Private Async Sub ShakeAsync(ctrl As Control, amount As Integer)
            Dim origin As Point = ctrl.Location
            For i As Integer = 0 To 5
                ctrl.Left = origin.X + If(i Mod 2 = 0, amount, -amount)
                Await System.Threading.Tasks.Task.Delay(28)
            Next
            ctrl.Left = origin.X
        End Sub

        ' ═════════════════════════════════════════════════════════════════════
        '  Drag to move (borderless form)
        ' ═════════════════════════════════════════════════════════════════════
        Private _dragStart As Point

        Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                _dragStart = e.Location
            End If
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                Location = New Point(Left + e.X - _dragStart.X,
                                     Top + e.Y - _dragStart.Y)
            End If
            MyBase.OnMouseMove(e)
        End Sub

        Private Sub btnLogin1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
            lblError.Text = ""
            Dim user As String = txtUsername.Text.Trim()
            Dim pass As String = txtPassword.Text

            If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(pass) Then
                ShowError("Please enter both username and password.")
                Return
            End If

            btnLogin1.Enabled = True
            btnLogin1.Text = "Signing in..."

            Try
                If AuthenticateUser(user, pass) Then
                    ' TODO: open main dashboard
                    ' Dim main As New MainForm(user)
                    ' main.Show()
                    ' Me.Hide()
                    MessageBox.Show(
                        $"Welcome, {user}!" & Environment.NewLine & "Login successful.",
                        "DCL-ESG",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None)
                Else
                    ShowError("Invalid username or password.")
                    txtPassword.Clear()
                    txtUsername.Focus()
                End If
            Catch sqlEx As SqlException
                ShowError("Database error: " & sqlEx.Message)
            Catch ex As Exception
                ShowError("Connection error: " & ex.Message)
            Finally
                btnLogin1.Enabled = True
                btnLogin1.Text = "SIGN  IN"
            End Try
        End Sub



        'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Me.Close()
        'End Sub
    End Class

    ' ═════════════════════════════════════════════════════════════════════════
    '  RoundedButton — shared helper used by Designer
    ' ═════════════════════════════════════════════════════════════════════════
    Public Class RoundedButton
        Inherits Button

        Public Property CornerRadius As Integer = 8

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Dim g As Graphics = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

            Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)
            Using path As GraphicsPath = RoundPath(rect, CornerRadius)
                Using fill As New SolidBrush(BackColor)
                    g.FillPath(fill, path)
                End Using

                If FlatAppearance.BorderSize > 0 Then
                    Using bp As New Pen(FlatAppearance.BorderColor, 1.0F)
                        g.DrawPath(bp, path)
                    End Using
                End If

                Dim sf As New StringFormat With {
                    .Alignment = StringAlignment.Center,
                    .LineAlignment = StringAlignment.Center
                }
                Using tb As New SolidBrush(ForeColor)
                    g.DrawString(Text, Font, tb, rect, sf)
                End Using
            End Using
        End Sub

        Private Shared Function RoundPath(r As Rectangle, rad As Integer) As GraphicsPath
            Dim d As Integer = rad * 2
            Dim p As New GraphicsPath()
            p.AddArc(r.X, r.Y, d, d, 180, 90)
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90)
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90)
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90)
            p.CloseFigure()
            Return p
        End Function

    End Class

End Namespace
