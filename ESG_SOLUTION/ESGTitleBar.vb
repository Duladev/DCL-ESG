Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

''' <summary>
''' Reusable ESG Title Bar — drop onto every form.
''' Set Title, Subtitle, and ShowBackButton as needed.
''' </summary>
Public Class ESGTitleBar
    Inherits UserControl

    Public Event CloseClicked()
    Public Event BackClicked()
    Public Event MinimizeClicked()

    Private _title As String = "ESG System"
    Private _subtitle As String = ""
    Private _showBack As Boolean = False
    Private _isDragging As Boolean = False
    Private _dragStart As Point

    ' ── Public Properties ────────────────────────────────────────────────────
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(v As String)
            _title = v
            Invalidate()
        End Set
    End Property

    Public Property Subtitle As String
        Get
            Return _subtitle
        End Get
        Set(v As String)
            _subtitle = v
            Invalidate()
        End Set
    End Property

    Public Property ShowBackButton As Boolean
        Get
            Return _showBack
        End Get
        Set(v As Boolean)
            _showBack = v
            Invalidate()
        End Set
    End Property

    ' ── Constructor ──────────────────────────────────────────────────────────
    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer, True)
        Height = 64
        Dock = DockStyle.Top
        BackColor = AppTheme.ColorSurface
    End Sub

    ' ── Hit-test helpers ─────────────────────────────────────────────────────
    Private Function CloseRect() As Rectangle
        Return New Rectangle(Width - 40, (Height - 28) \ 2, 28, 28)
    End Function

    Private Function MinRect() As Rectangle
        Return New Rectangle(Width - 76, (Height - 28) \ 2, 28, 28)
    End Function

    Private Function BackRect() As Rectangle
        Return New Rectangle(12, (Height - 28) \ 2, 28, 28)
    End Function

    ' ── Paint ────────────────────────────────────────────────────────────────
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Background gradient
        Using gb As New LinearGradientBrush(
            ClientRectangle,
            AppTheme.ColorSurface,
            AppTheme.AdjustBrightness(AppTheme.ColorSurface, 0.9),
            LinearGradientMode.Vertical)
            g.FillRectangle(gb, ClientRectangle)
        End Using

        ' Left accent bar
        Using br As New SolidBrush(AppTheme.ColorPrimary)
            g.FillRectangle(br, New Rectangle(0, 0, 4, Height))
        End Using

        ' ESG icon (filled circle with inner dot)
        Dim iconX As Integer = If(_showBack, 54, 18)
        Using br As New SolidBrush(AppTheme.ColorPrimary)
            g.FillEllipse(br, New Rectangle(iconX, Height \ 2 - 10, 20, 20))
        End Using
        Using br As New SolidBrush(AppTheme.ColorBackground)
            g.FillEllipse(br, New Rectangle(iconX + 5, Height \ 2 - 5, 10, 10))
        End Using

        ' Title and subtitle text
        Dim textX As Integer = iconX + 28
        Using br As New SolidBrush(AppTheme.ColorText)
            g.DrawString(_title, AppTheme.FontTitle, br, New PointF(textX, 8))
        End Using
        If _subtitle.Length > 0 Then
            Using br As New SolidBrush(AppTheme.ColorTextMuted)
                g.DrawString(_subtitle, AppTheme.FontSmall, br, New PointF(textX, 36))
            End Using
        End If

        ' Back chevron
        If _showBack Then
            Dim br2 As Rectangle = BackRect()
            Using p As New Pen(AppTheme.ColorPrimary, 2)
                g.DrawLine(p, br2.Right - 8, br2.Top + 8, br2.Left + 8, br2.Top + 14)
                g.DrawLine(p, br2.Left + 8, br2.Top + 14, br2.Right - 8, br2.Bottom - 8)
            End Using
        End If

        ' Minimize dash
        Dim mr As Rectangle = MinRect()
        Using p As New Pen(AppTheme.ColorTextMuted, 2)
            g.DrawLine(p, mr.Left + 6, mr.Bottom - 8, mr.Right - 6, mr.Bottom - 8)
        End Using

        ' Close X
        Dim cr As Rectangle = CloseRect()
        Using p As New Pen(AppTheme.ColorDanger, 2)
            g.DrawLine(p, cr.Left + 6, cr.Top + 6, cr.Right - 6, cr.Bottom - 6)
            g.DrawLine(p, cr.Right - 6, cr.Top + 6, cr.Left + 6, cr.Bottom - 6)
        End Using

        ' Bottom divider
        Using p As New Pen(AppTheme.ColorBorder, 1)
            g.DrawLine(p, 0, Height - 1, Width, Height - 1)
        End Using
    End Sub

    ' ── Mouse events ─────────────────────────────────────────────────────────
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If e.Button = MouseButtons.Left Then
            If CloseRect().Contains(e.Location) Then
                RaiseEvent CloseClicked()
            ElseIf MinRect().Contains(e.Location) Then
                RaiseEvent MinimizeClicked()
            ElseIf _showBack AndAlso BackRect().Contains(e.Location) Then
                RaiseEvent BackClicked()
            Else
                _isDragging = True
                _dragStart = e.Location
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If _isDragging AndAlso ParentForm IsNot Nothing Then
            Dim loc As Point = ParentForm.Location
            ParentForm.Location = New Point(
                loc.X + e.X - _dragStart.X,
                loc.Y + e.Y - _dragStart.Y)
        End If
        If CloseRect().Contains(e.Location) OrElse
           MinRect().Contains(e.Location) OrElse
           (_showBack AndAlso BackRect().Contains(e.Location)) Then
            Cursor = Cursors.Hand
        Else
            Cursor = Cursors.SizeAll
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        _isDragging = False
    End Sub

End Class
' 