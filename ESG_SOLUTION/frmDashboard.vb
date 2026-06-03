Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


'  No separate .Designer.vb needed; InitializeComponent is here.
Public Class frmDashboard
    Inherits System.Windows.Forms.Form

    ' ── Dispose ──────────────────────────────────────────────────────────────
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                If _animTimer IsNot Nothing Then
                    _animTimer.Stop()
                    _animTimer.Dispose()
                End If
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    ' ── Animation state ──────────────────────────────────────────────────────
    Private _animTimer As System.Windows.Forms.Timer
    Private _animStep As Integer = 0

    ' ── Control declarations ─────────────────────────────────────────────────
    Private titleBar As ESGTitleBar
    Private pnlNav As Panel
    Private pnlContent As Panel
    Private picBanner As PictureBox

    Private WithEvents btnEmp As Button
    Private WithEvents btnCSR As Button
    Private WithEvents btnWaste As Button
    Private WithEvents btnInventory As Button
    Private WithEvents btnHSE As Button

    Private cardEmissions As ESGCard
    Private cardWasteCard As ESGCard
    Private cardEnergy As ESGCard
    Private cardEmployees As ESGCard

    Private lblSectionNav As Label
    Private lblSectionMetrics As Label
    Private lblFooter As Label

    ' ═══════════════════════════════════════════════════════════════
    '  InitializeComponent
    ' ═══════════════════════════════════════════════════════════════
    Private Sub InitializeComponent()
        Text = "ESG Management System"
        ClientSize = New Size(920, 580)
        StartPosition = FormStartPosition.CenterScreen
        MinimumSize = New Size(800, 520)
        ' ── Title bar ────────────────────────────────────────────────────────
        titleBar = New ESGTitleBar()
        titleBar.Title = "ESG Management System"
        titleBar.Subtitle = "Environmental · Social · Governance"
        titleBar.ShowBackButton = False
        ' ── Animated colour bar ───────────────────────────────────────────────
        picBanner = New PictureBox()
        picBanner.Location = New Point(0, 64)
        picBanner.Size = New Size(920, 5)
        picBanner.BackColor = ColorPrimary
        ' ── Left nav panel ───────────────────────────────────────────────────
        pnlNav = New Panel()
        pnlNav.Location = New Point(0, 69)
        pnlNav.Size = New Size(200, 511)
        pnlNav.BackColor = ColorSurface
        lblSectionNav = New Label()
        lblSectionNav.Text = "NAVIGATION"
        lblSectionNav.Location = New Point(12, 12)
        lblSectionNav.Size = New Size(176, 20)
        lblSectionNav.Font = FontBadge
        lblSectionNav.ForeColor = ColorTextMuted
        lblSectionNav.BackColor = Color.Transparent
        btnEmp = MakeNavButton("Employee", 44)
        btnCSR = MakeNavButton("CSR", 92)
        btnWaste = MakeNavButton("Waste Mgmt", 140)
        btnInventory = MakeNavButton("Inventory", 188)
        btnHSE = MakeNavButton("HSE", 236)
        pnlNav.Controls.Add(lblSectionNav)
        pnlNav.Controls.Add(btnEmp)
        pnlNav.Controls.Add(btnCSR)
        pnlNav.Controls.Add(btnWaste)
        pnlNav.Controls.Add(btnInventory)
        pnlNav.Controls.Add(btnHSE)
        ' ── Main content panel ───────────────────────────────────────────────
        pnlContent = New Panel()
        pnlContent.Location = New Point(200, 69)
        pnlContent.Size = New Size(720, 511)
        pnlContent.BackColor = ColorBackground
        lblSectionMetrics = New Label()
        lblSectionMetrics.Text = "KEY METRICS"
        lblSectionMetrics.Location = New Point(16, 12)
        lblSectionMetrics.Size = New Size(200, 20)
        lblSectionMetrics.Font = FontBadge
        lblSectionMetrics.ForeColor = ColorTextMuted
        lblSectionMetrics.BackColor = Color.Transparent
        cardEmissions = New ESGCard()
        cardEmissions.Location = New Point(16, 40)
        cardEmissions.Size = New Size(158, 90)
        cardEmissions.MetricLabel = "CO2 Emissions"
        cardEmissions.MetricValue = "1,240 t"
        cardEmissions.Badge = "Down 8%"
        cardEmissions.AccentColor = ColorPrimary
        cardEmissions.IconChar = "C"
        cardWasteCard = New ESGCard()
        cardWasteCard.Location = New Point(186, 40)
        cardWasteCard.Size = New Size(158, 90)
        cardWasteCard.MetricLabel = "Waste Recycled"
        cardWasteCard.MetricValue = "76%"
        cardWasteCard.Badge = "Up 3%"
        cardWasteCard.AccentColor = ColorAccent
        cardWasteCard.IconChar = "W"
        cardEnergy = New ESGCard()
        cardEnergy.Location = New Point(356, 40)
        cardEnergy.Size = New Size(158, 90)
        cardEnergy.MetricLabel = "Energy (kWh)"
        cardEnergy.MetricValue = "84,200"
        cardEnergy.Badge = "Down 5%"
        cardEnergy.AccentColor = ColorWarning
        cardEnergy.IconChar = "E"
        cardEmployees = New ESGCard()
        cardEmployees.Location = New Point(526, 40)
        cardEmployees.Size = New Size(158, 90)
        cardEmployees.MetricLabel = "Employees"
        cardEmployees.MetricValue = "342"
        cardEmployees.Badge = "Stable"
        cardEmployees.AccentColor = Color.FromArgb(167, 139, 250)
        cardEmployees.IconChar = "P"
        lblFooter = New Label()
        'lblFooter.Text = "ESG System  -  " + Date.Now.Year + "  -  All rights reserved"
        lblFooter.Location = New Point(0, 490)
        lblFooter.Size = New Size(720, 20)
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        lblFooter.Font = FontSmall
        lblFooter.ForeColor = ColorTextMuted
        lblFooter.BackColor = Color.Transparent
        pnlContent.Controls.Add(lblSectionMetrics)
        pnlContent.Controls.Add(cardEmissions)
        pnlContent.Controls.Add(cardWasteCard)
        pnlContent.Controls.Add(cardEnergy)
        pnlContent.Controls.Add(cardEmployees)
        pnlContent.Controls.Add(lblFooter)
        Controls.Add(titleBar)
        Controls.Add(picBanner)
        Controls.Add(pnlNav)
        Controls.Add(pnlContent)
    End Sub

    ' ═══════════════════════════════════════════════════════════════
    '  Form Load
    ' ═══════════════════════════════════════════════════════════════
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        AppTheme.Apply(Me)

        _animTimer = New System.Windows.Forms.Timer()
        _animTimer.Interval = 40
        AddHandler _animTimer.Tick, AddressOf AnimateBanner
        _animTimer.Start()
    End Sub

    ' ═══════════════════════════════════════════════════════════════
    '  Animated banner bar
    ' ═══════════════════════════════════════════════════════════════
    Private Sub AnimateBanner(sender As Object, e As EventArgs)
        If picBanner Is Nothing OrElse picBanner.IsDisposed Then
            Return
        End If
        _animStep = (_animStep + 1) Mod 360
        Dim hue As Double = (_animStep Mod 60) / 60.0
        Dim r As Integer = Math.Min(255, CInt(16 + 83 * hue))
        Dim g As Integer = Math.Min(255, CInt(185 - 60 * hue))
        Dim b As Integer = Math.Min(255, CInt(129 + 108 * hue))
        picBanner.BackColor = Color.FromArgb(r, g, b)
    End Sub

    ' ═══════════════════════════════════════════════════════════════
    '  Title bar handlers
    ' ═══════════════════════════════════════════════════════════════
    Private Sub TitleBar_CloseClicked()
        Application.Exit()
    End Sub

    Private Sub TitleBar_MinimizeClicked()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' ═══════════════════════════════════════════════════════════════
    '  Nav panel right-border paint
    ' ═══════════════════════════════════════════════════════════════
    Private Sub PnlNav_Paint(sender As Object, e As PaintEventArgs)
        Using p As New Pen(AppTheme.ColorBorder, 1)
            e.Graphics.DrawLine(p, pnlNav.Width - 1, 0, pnlNav.Width - 1, pnlNav.Height)
        End Using
    End Sub

    ' ═══════════════════════════════════════════════════════════════
    '  Nav button factory
    ' ═══════════════════════════════════════════════════════════════
    Private Function MakeNavButton(displayText As String, y As Integer) As Button
        Dim btn As New Button()
        btn.Text = displayText
        btn.Location = New Point(8, y)
        btn.Size = New Size(184, 40)
        btn.TextAlign = ContentAlignment.MiddleLeft
        btn.Padding = New Padding(12, 0, 0, 0)
        btn.FlatStyle = FlatStyle.Flat
        btn.ForeColor = AppTheme.ColorText
        btn.BackColor = Color.Transparent
        btn.Font = AppTheme.FontButton
        btn.Cursor = Cursors.Hand
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, AppTheme.ColorPrimary)
        btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, AppTheme.ColorPrimary)
        Return btn
    End Function

    ' ═══════════════════════════════════════════════════════════════
    '  Navigation clicks
    ' ═══════════════════════════════════════════════════════════════
    Private Sub btnWaste_Click(sender As Object, e As EventArgs)
        Dim form As New frmWasteManagement
        form.Show()
        Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs)
        Dim form As New frmMain
        form.Show()
        Hide()
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs)
        Dim form As New frmEmployee
        form.Show()
        Hide()
    End Sub

    Private Sub btnCSR_Click(sender As Object, e As EventArgs)
        Dim form As New frmCSRActivity
        form.Show()
        Hide()
    End Sub

    Private Sub btnHSE_Click(sender As Object, e As EventArgs)
        Dim form As New frmESGMain
        form.Show()
        Hide()
    End Sub

End Class
