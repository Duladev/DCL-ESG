Imports System.Drawing.Drawing2D

''' <summary>
''' ESG Metric Card — shows an icon, label, value, and optional badge.
''' Drop multiple of these onto the Dashboard form.
''' </summary>
Public Class ESGCard
    Inherits UserControl

    Private _label As String = "Metric"
    Private _value As String = "—"
    Private _badge As String = ""
    Private _accentColor As Color = AppTheme.ColorPrimary
    Private _iconChar As String = "●"

    ' ── Properties ───────────────────────────────────────────────────────────
    Public Property MetricLabel As String
        Get
            Return _label
        End Get
        Set(v As String)
            _label = v
            Invalidate()
        End Set
    End Property

    Public Property MetricValue As String
        Get
            Return _value
        End Get
        Set(v As String)
            _value = v
            Invalidate()
        End Set
    End Property

    Public Property Badge As String
        Get
            Return _badge
        End Get
        Set(v As String)
            _badge = v
            Invalidate()
        End Set
    End Property

    Public Property AccentColor As Color
        Get
            Return _accentColor
        End Get
        Set(v As Color)
            _accentColor = v
            Invalidate()
        End Set
    End Property

    Public Property IconChar As String
        Get
            Return _iconChar
        End Get
        Set(v As String)
            _iconChar = v
            Invalidate()
        End Set
    End Property

    ' ── Constructor ──────────────────────────────────────────────────────────
    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.UserPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw, True)
        Size = New Size(170, 100)
        BackColor = Color.Transparent
        Cursor = Cursors.Hand
    End Sub

    ' ── Paint ────────────────────────────────────────────────────────────────
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim bounds As New Rectangle(2, 2, Width - 4, Height - 4)

        ' Card background
        AppTheme.PaintCard(g, bounds, AppTheme.CardRadius, AppTheme.ColorCard)

        ' Left accent stripe
        Dim stripe As New Rectangle(2, 2, 4, Height - 4)
        Dim stripePath As GraphicsPath = AppTheme.RoundedRect(stripe, 2)
        Using br As New SolidBrush(_accentColor)
            g.FillPath(br, stripePath)
        End Using

        ' Icon circle background
        Dim iconBounds As New Rectangle(14, 14, 32, 32)
        Using br As New SolidBrush(Color.FromArgb(40, _accentColor))
            g.FillEllipse(br, iconBounds)
        End Using

        ' Icon character
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }
        Using br As New SolidBrush(_accentColor)
            g.DrawString(_iconChar,
                         New Font("Segoe UI", 14, FontStyle.Bold),
                         br,
                         New RectangleF(14, 14, 32, 32),
                         sf)
        End Using

        ' Metric label
        Using br As New SolidBrush(AppTheme.ColorTextMuted)
            g.DrawString(_label, AppTheme.FontSmall, br, New PointF(54, 16))
        End Using

        ' Metric value
        Using br As New SolidBrush(AppTheme.ColorText)
            g.DrawString(_value,
                         New Font("Segoe UI", 16, FontStyle.Bold),
                         br,
                         New PointF(54, 34))
        End Using

        ' Badge (optional)
        If _badge.Length > 0 Then
            Dim sf2 As New StringFormat With {
                .Alignment = StringAlignment.Center,
                .LineAlignment = StringAlignment.Center
            }
            Dim badgeBounds As New Rectangle(bounds.Right - 52, bounds.Bottom - 22, 46, 16)
            Using br As New SolidBrush(Color.FromArgb(50, _accentColor))
                g.FillRectangle(br, badgeBounds)
            End Using
            Using br As New SolidBrush(_accentColor)
                g.DrawString(_badge, AppTheme.FontBadge, br, badgeBounds, sf2)
            End Using
        End If
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        Invalidate()
    End Sub

End Class
