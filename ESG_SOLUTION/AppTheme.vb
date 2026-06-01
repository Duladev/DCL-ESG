Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Centralized ESG Theme — apply to ALL forms for consistent look.
''' Usage: AppTheme.Apply(Me)  — call in each form's Load event
''' </summary>
Public Module AppTheme

    ' ─── Colour Palette (ESG / Sustainability) ────────────────────────────────
    Public ReadOnly ColorBackground As Color = Color.FromArgb(15, 23, 42)        ' Slate-900
    Public ReadOnly ColorSurface As Color = Color.FromArgb(30, 41, 59)           ' Slate-800
    Public ReadOnly ColorCard As Color = Color.FromArgb(51, 65, 85)              ' Slate-700
    Public ReadOnly ColorPrimary As Color = Color.FromArgb(16, 185, 129)         ' Emerald-500
    Public ReadOnly ColorPrimaryDark As Color = Color.FromArgb(5, 150, 105)      ' Emerald-600
    Public ReadOnly ColorPrimaryLight As Color = Color.FromArgb(52, 211, 153)    ' Emerald-400
    Public ReadOnly ColorAccent As Color = Color.FromArgb(99, 179, 237)          ' Sky-300
    Public ReadOnly ColorText As Color = Color.FromArgb(241, 245, 249)           ' Slate-100
    Public ReadOnly ColorTextMuted As Color = Color.FromArgb(148, 163, 184)      ' Slate-400
    Public ReadOnly ColorBorder As Color = Color.FromArgb(71, 85, 105)           ' Slate-600
    Public ReadOnly ColorDanger As Color = Color.FromArgb(239, 68, 68)           ' Red-500
    Public ReadOnly ColorWarning As Color = Color.FromArgb(245, 158, 11)         ' Amber-500

    ' ─── Typography ───────────────────────────────────────────────────────────
    Public ReadOnly FontTitle As New Font("Segoe UI", 18, FontStyle.Bold)
    Public ReadOnly FontSubtitle As New Font("Segoe UI", 11, FontStyle.Regular)
    Public ReadOnly FontButton As New Font("Segoe UI Semibold", 9, FontStyle.Bold)
    Public ReadOnly FontBody As New Font("Segoe UI", 9, FontStyle.Regular)
    Public ReadOnly FontSmall As New Font("Segoe UI", 8, FontStyle.Regular)
    Public ReadOnly FontBadge As New Font("Segoe UI", 7, FontStyle.Bold)

    ' ─── Sizing ───────────────────────────────────────────────────────────────
    Public Const ButtonRadius As Integer = 20
    Public Const CardRadius As Integer = 12
    Public Const PanelRadius As Integer = 16

    ' ─── Apply Theme to a Form ────────────────────────────────────────────────
    Public Sub Apply(frm As Form)
        frm.BackColor = ColorBackground
        frm.ForeColor = ColorText
        frm.Font = FontBody
        frm.FormBorderStyle = FormBorderStyle.None   ' borderless = modern look

        ' Round the form corners
        SetRoundRegion(frm, PanelRadius)

        ' Style all child controls
        StyleControls(frm.Controls)

        ' Wire resize to keep round corners
        AddHandler frm.Resize, Sub(s, e) SetRoundRegion(frm, PanelRadius)
    End Sub

    ' ─── Recursively style controls ───────────────────────────────────────────
    Public Sub StyleControls(controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            Select Case ctrl.GetType().Name
                Case "Button"
                    StyleButton(DirectCast(ctrl, Button))
                Case "Label"
                    StyleLabel(DirectCast(ctrl, Label))
                Case "TextBox"
                    StyleTextBox(DirectCast(ctrl, TextBox))
                Case "ComboBox"
                    StyleComboBox(DirectCast(ctrl, ComboBox))
                Case "DataGridView"
                    StyleGrid(DirectCast(ctrl, DataGridView))
                Case "Panel"
                    StylePanel(DirectCast(ctrl, Panel))
                Case "GroupBox"
                    StyleGroupBox(DirectCast(ctrl, GroupBox))
                Case "TabControl"
                    StyleTabControl(DirectCast(ctrl, TabControl))
            End Select

            If ctrl.HasChildren Then
                StyleControls(ctrl.Controls)
            End If
        Next
    End Sub

    ' ─── Button ───────────────────────────────────────────────────────────────
    Public Sub StyleButton(btn As Button,
                           Optional style As ButtonStyle = ButtonStyle.Primary)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Font = FontButton
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.UseVisualStyleBackColor = False

        Dim bg As Color = GetButtonColor(style)
        btn.BackColor = bg

        ' Remove default painting; use custom renderer
        btn.Tag = style

        AddHandler btn.Paint, AddressOf PaintRoundButton
        AddHandler btn.MouseEnter, AddressOf ButtonMouseEnter
        AddHandler btn.MouseLeave, AddressOf ButtonMouseLeave
        AddHandler btn.MouseDown, AddressOf ButtonMouseDown
        AddHandler btn.MouseUp, AddressOf ButtonMouseUp
    End Sub

    Private Function GetButtonColor(style As ButtonStyle) As Color
        Select Case style
            Case ButtonStyle.Primary : Return ColorPrimary
            Case ButtonStyle.Secondary : Return ColorCard
            Case ButtonStyle.Danger : Return ColorDanger
            Case ButtonStyle.Accent : Return ColorAccent
            Case Else : Return ColorPrimary
        End Select
    End Function

    Private Sub PaintRoundButton(sender As Object, e As PaintEventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim r = New Rectangle(1, 1, btn.Width - 3, btn.Height - 3)
        Dim radius = Math.Min(ButtonRadius, Math.Min(btn.Height, btn.Width) \ 2)
        Dim path = RoundedRect(r, radius)

        ' Gradient fill
        Dim top = AdjustBrightness(btn.BackColor, 1.15)
        Dim btm = AdjustBrightness(btn.BackColor, 0.85)
        Using gb As New LinearGradientBrush(r, top, btm, LinearGradientMode.Vertical)
            g.FillPath(gb, path)
        End Using

        ' Subtle border highlight
        Using pen As New Pen(Color.FromArgb(60, Color.White), 1)
            g.DrawPath(pen, path)
        End Using

        ' Text
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        Using br As New SolidBrush(btn.ForeColor)
            g.DrawString(btn.Text, btn.Font, br, New RectangleF(0, 0, btn.Width, btn.Height), sf)
        End Using
    End Sub

    Private Sub ButtonMouseEnter(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = AdjustBrightness(btn.BackColor, 1.12)
        btn.Invalidate()
    End Sub

    Private Sub ButtonMouseLeave(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim style = If(TypeOf btn.Tag Is ButtonStyle, DirectCast(btn.Tag, ButtonStyle), ButtonStyle.Primary)
        btn.BackColor = GetButtonColor(style)
        btn.Invalidate()
    End Sub

    Private Sub ButtonMouseDown(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = AdjustBrightness(btn.BackColor, 0.88)
        btn.Invalidate()
    End Sub

    Private Sub ButtonMouseUp(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = AdjustBrightness(btn.BackColor, 1.08)
        btn.Invalidate()
    End Sub

    ' ─── Label ────────────────────────────────────────────────────────────────
    Public Sub StyleLabel(lbl As Label)
        lbl.BackColor = Color.Transparent
        lbl.ForeColor = ColorText
    End Sub

    ' ─── TextBox ──────────────────────────────────────────────────────────────
    Public Sub StyleTextBox(txt As TextBox)
        txt.BackColor = ColorSurface
        txt.ForeColor = ColorText
        txt.BorderStyle = BorderStyle.None
        txt.Font = FontBody
    End Sub

    ' ─── ComboBox ─────────────────────────────────────────────────────────────
    Public Sub StyleComboBox(cmb As ComboBox)
        cmb.BackColor = ColorSurface
        cmb.ForeColor = ColorText
        cmb.FlatStyle = FlatStyle.Flat
        cmb.Font = FontBody
    End Sub

    ' ─── DataGridView ─────────────────────────────────────────────────────────
    Public Sub StyleGrid(dgv As DataGridView)
        dgv.BackgroundColor = ColorSurface
        dgv.GridColor = ColorBorder
        dgv.ForeColor = ColorText
        dgv.Font = FontBody
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.DefaultCellStyle.BackColor = ColorSurface
        dgv.DefaultCellStyle.ForeColor = ColorText
        dgv.DefaultCellStyle.SelectionBackColor = ColorPrimaryDark
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorCard
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorCard
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorPrimary
        dgv.ColumnHeadersDefaultCellStyle.Font = FontButton
    End Sub

    ' ─── Panel ────────────────────────────────────────────────────────────────
    Public Sub StylePanel(pnl As Panel)
        pnl.BackColor = ColorSurface
    End Sub

    ' ─── GroupBox ─────────────────────────────────────────────────────────────
    Public Sub StyleGroupBox(grp As GroupBox)
        grp.BackColor = ColorSurface
        grp.ForeColor = ColorPrimary
        grp.Font = FontButton
    End Sub

    ' ─── TabControl ───────────────────────────────────────────────────────────
    Public Sub StyleTabControl(tab As TabControl)
        tab.DrawMode = TabDrawMode.OwnerDrawFixed
        AddHandler tab.DrawItem, AddressOf DrawTabItem
        tab.Appearance = TabAppearance.Normal
    End Sub

    Private Sub DrawTabItem(sender As Object, e As DrawItemEventArgs)
        Dim tab = DirectCast(sender, TabControl)
        Dim page = tab.TabPages(e.Index)
        Dim isSelected = (tab.SelectedIndex = e.Index)
        Dim bg = If(isSelected, ColorPrimary, ColorCard)
        Using br As New SolidBrush(bg)
            e.Graphics.FillRectangle(br, e.Bounds)
        End Using
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        Using br As New SolidBrush(Color.White)
            e.Graphics.DrawString(page.Text, FontButton, br, e.Bounds, sf)
        End Using
    End Sub

    ' ─── Helpers ──────────────────────────────────────────────────────────────
    Public Function RoundedRect(bounds As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90)
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90)
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90)
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Public Sub SetRoundRegion(ctrl As Control, radius As Integer)
        Dim path As New GraphicsPath()
        Dim d = radius * 2
        path.AddArc(0, 0, d, d, 180, 90)
        path.AddArc(ctrl.Width - d, 0, d, d, 270, 90)
        path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90)
        path.AddArc(0, ctrl.Height - d, d, d, 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub

    Public Function AdjustBrightness(c As Color, factor As Double) As Color
        Return Color.FromArgb(
            Math.Min(255, CInt(c.R * factor)),
            Math.Min(255, CInt(c.G * factor)),
            Math.Min(255, CInt(c.B * factor)))
    End Function

    ' ─── Draw a card panel with rounded corners ───────────────────────────────
    Public Sub PaintCard(g As Graphics, bounds As Rectangle,
                         Optional radius As Integer = 12,
                         Optional bg As Color = Nothing)
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim col = If(bg = Nothing, ColorCard, bg)
        Dim path = RoundedRect(bounds, radius)
        Using br As New SolidBrush(col)
            g.FillPath(br, path)
        End Using
        Using pen As New Pen(ColorBorder, 1)
            g.DrawPath(pen, path)
        End Using
    End Sub

    ' ─── Draggable borderless form ────────────────────────────────────────────
    Public Sub EnableDrag(frm As Form)
        Dim _dragging As Boolean = False
        Dim _startPoint As Point

        AddHandler frm.MouseDown, Sub(s, e)
                                      If e.Button = MouseButtons.Left Then
                                          _dragging = True
                                          _startPoint = e.Location
                                      End If
                                  End Sub
        AddHandler frm.MouseMove, Sub(s, e)
                                      If _dragging Then
                                          frm.Location = New Point(
                                              frm.Location.X + (e.X - _startPoint.X),
                                              frm.Location.Y + (e.Y - _startPoint.Y))
                                      End If
                                  End Sub
        AddHandler frm.MouseUp, Sub(s, e)
                                    _dragging = False
                                End Sub
    End Sub

End Module

Public Enum ButtonStyle
    Primary
    Secondary
    Danger
    Accent
End Enum
