Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

''' <summary>
''' Centralized ESG Theme — apply to ALL forms for consistent look with image backgrounds
''' Usage: AppTheme.Apply(Me) — call in each form's Load event
''' </summary>
Public Module AppTheme

    ' ─── Colour Palette (Fresh Green Theme) ────────────────────────────────────
    Public ReadOnly ColorPrimaryLight As Color = Color.FromArgb(230, 255, 191)    ' e6ffbf
    Public ReadOnly ColorPrimary As Color = Color.FromArgb(33, 86, 0)             ' 215600
    Public ReadOnly ColorBackground As Color = Color.FromArgb(248, 251, 245)      ' f8fbf5

    ' Extended palette for UI elements
    Public ReadOnly ColorSurface As Color = Color.FromArgb(240, 245, 235)         ' Lighter surface
    Public ReadOnly ColorCard As Color = Color.FromArgb(255, 255, 255)            ' White cards
    Public ReadOnly ColorPrimaryDark As Color = Color.FromArgb(25, 66, 0)         ' Darker green
    Public ReadOnly ColorAccent As Color = Color.FromArgb(139, 195, 74)           ' Light green accent
    Public ReadOnly ColorText As Color = Color.FromArgb(33, 86, 0)                ' Dark green text
    Public ReadOnly ColorTextMuted As Color = Color.FromArgb(100, 120, 80)        ' Muted green-gray
    Public ReadOnly ColorBorder As Color = Color.FromArgb(200, 215, 180)          ' Soft green border
    Public ReadOnly ColorDanger As Color = Color.FromArgb(220, 53, 69)            ' Red
    Public ReadOnly ColorWarning As Color = Color.FromArgb(255, 193, 7)           ' Yellow

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

    ' ─── Image Management ─────────────────────────────────────────────────────
    Private ReadOnly _formImages As New Dictionary(Of Form, Image)
    Private ReadOnly _blurredImages As New Dictionary(Of Form, Image)
    Private Const BLUR_AMOUNT As Integer = 15

    ''' <summary>
    ''' Assign an image to a form (call from form's Load event)
    ''' </summary>
    Public Sub SetFormImage(frm As Form, image As Image, Optional enableBlur As Boolean = False)
        If _formImages.ContainsKey(frm) Then
            If _formImages(frm) IsNot Nothing AndAlso _formImages(frm) IsNot image Then
                _formImages(frm).Dispose()
            End If
            _formImages(frm) = image
        Else
            _formImages.Add(frm, image)
        End If

        If enableBlur Then
            ApplyBlurToForm(frm, image)
        Else
            frm.BackgroundImage = image
            frm.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    ''' <summary>
    ''' Apply blur effect to form background
    ''' </summary>
    Public Sub ApplyBlurToForm(frm As Form, Optional image As Image = Nothing)
        Dim imgToBlur = If(image IsNot Nothing, image,
                          If(_formImages.ContainsKey(frm), _formImages(frm), Nothing))

        If imgToBlur Is Nothing Then Return

        ' Dispose old blurred image
        If _blurredImages.ContainsKey(frm) Then
            _blurredImages(frm)?.Dispose()
            _blurredImages(frm) = Nothing
        End If

        Dim blurred = BlurImage(imgToBlur, BLUR_AMOUNT)

        If _blurredImages.ContainsKey(frm) Then
            _blurredImages(frm) = blurred
        Else
            _blurredImages.Add(frm, blurred)
        End If

        frm.BackgroundImage = blurred
        frm.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    ''' <summary>
    ''' Remove blur and show original image
    ''' </summary>
    Public Sub RemoveBlurFromForm(frm As Form)
        If _formImages.ContainsKey(frm) Then
            frm.BackgroundImage = _formImages(frm)
            frm.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    ''' <summary>
    ''' Apply blur effect using simple box blur
    ''' </summary>
    Private Function BlurImage(original As Image, blurSize As Integer) As Image
        Dim bmp As New Bitmap(original)

        ' Simple blur by averaging pixels
        For blur As Integer = 0 To Math.Min(blurSize, 3)
            bmp = BoxBlur(bmp, 3)
        Next

        Return bmp
    End Function

    Private Function BoxBlur(source As Bitmap, radius As Integer) As Bitmap
        Dim result As New Bitmap(source.Width, source.Height)

        Using g As Graphics = Graphics.FromImage(result)
            Dim rect As New Rectangle(0, 0, source.Width, source.Height)

            ' Create a blur effect using a matrix transformation
            Dim matrixElements As Single()() = {
                New Single() {1 / 9.0F, 1 / 9.0F, 1 / 9.0F},
                New Single() {1 / 9.0F, 1 / 9.0F, 1 / 9.0F},
                New Single() {1 / 9.0F, 1 / 9.0F, 1 / 9.0F}
            }

            Dim matrix As New ColorMatrix()
            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    matrix.Item(i, j) = matrixElements(i)(j)
                Next
            Next
            matrix.Matrix33 = 1
            matrix.Matrix44 = 1

            Using attrs As New ImageAttributes()
                attrs.SetColorMatrix(matrix)
                g.DrawImage(source, rect, 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, attrs)
            End Using
        End Using

        Return result
    End Function

    ' ─── Apply Theme to a Form ────────────────────────────────────────────────
    Public Sub Apply(frm As Form)
        ' Set form properties
        frm.BackColor = ColorBackground
        frm.ForeColor = ColorText
        frm.Font = FontBody
        frm.FormBorderStyle = FormBorderStyle.None

        ' Round the form corners
        SetRoundRegion(frm, PanelRadius)

        ' Style all child controls
        StyleControls(frm.Controls)

        ' Wire resize to keep round corners
        RemoveHandler frm.Resize, AddressOf OnFormResize
        AddHandler frm.Resize, AddressOf OnFormResize

        ' Wire form closing to clean up resources
        RemoveHandler frm.FormClosed, AddressOf OnFormClosed
        AddHandler frm.FormClosed, AddressOf OnFormClosed
    End Sub

    Private Sub OnFormResize(sender As Object, e As EventArgs)
        Dim frm = DirectCast(sender, Form)
        If frm.WindowState <> FormWindowState.Minimized AndAlso frm.Width > 0 AndAlso frm.Height > 0 Then
            SetRoundRegion(frm, PanelRadius)
        End If
    End Sub

    Private Sub OnFormClosed(sender As Object, e As FormClosedEventArgs)
        CleanupFormResources(DirectCast(sender, Form))
    End Sub

    Private Sub CleanupFormResources(frm As Form)
        If _blurredImages.ContainsKey(frm) Then
            _blurredImages(frm)?.Dispose()
            _blurredImages.Remove(frm)
        End If
        If _formImages.ContainsKey(frm) Then
            ' Don't dispose the original image as it might be shared
            _formImages.Remove(frm)
        End If
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
        btn.ForeColor = If(style = ButtonStyle.Secondary, ColorPrimary, Color.White)
        btn.Cursor = Cursors.Hand
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.UseVisualStyleBackColor = False
        btn.BackColor = GetButtonColor(style)
        btn.Tag = style

        ' Remove default painting; use custom renderer
        RemoveHandler btn.Paint, AddressOf PaintRoundButton
        RemoveHandler btn.MouseEnter, AddressOf ButtonMouseEnter
        RemoveHandler btn.MouseLeave, AddressOf ButtonMouseLeave
        RemoveHandler btn.MouseDown, AddressOf ButtonMouseDown
        RemoveHandler btn.MouseUp, AddressOf ButtonMouseUp

        AddHandler btn.Paint, AddressOf PaintRoundButton
        AddHandler btn.MouseEnter, AddressOf ButtonMouseEnter
        AddHandler btn.MouseLeave, AddressOf ButtonMouseLeave
        AddHandler btn.MouseDown, AddressOf ButtonMouseDown
        AddHandler btn.MouseUp, AddressOf ButtonMouseUp
    End Sub

    Private Function GetButtonColor(style As ButtonStyle) As Color
        Select Case style
            Case ButtonStyle.Primary : Return ColorPrimary
            Case ButtonStyle.Secondary : Return ColorPrimaryLight
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

        ' Gradient fill with subtle effect
        Dim top = AdjustBrightness(btn.BackColor, 1.05)
        Dim btm = AdjustBrightness(btn.BackColor, 0.95)
        Using gb As New LinearGradientBrush(r, top, btm, LinearGradientMode.Vertical)
            g.FillPath(gb, path)
        End Using

        ' Subtle border highlight
        Using pen As New Pen(Color.FromArgb(40, Color.Black), 1)
            g.DrawPath(pen, path)
        End Using

        ' Text with slight shadow for readability on images
        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Center,
            .LineAlignment = StringAlignment.Center
        }

        ' Add text shadow for better readability on images
        Using shadowBrush As New SolidBrush(Color.FromArgb(50, 0, 0, 0))
            g.DrawString(btn.Text, btn.Font, shadowBrush,
                        New RectangleF(1, 1, btn.Width, btn.Height), sf)
        End Using

        Using br As New SolidBrush(btn.ForeColor)
            g.DrawString(btn.Text, btn.Font, br, New RectangleF(0, 0, btn.Width, btn.Height), sf)
        End Using
    End Sub

    Private Sub ButtonMouseEnter(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = AdjustBrightness(btn.BackColor, 1.08)
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
        btn.BackColor = AdjustBrightness(btn.BackColor, 0.92)
        btn.Invalidate()
    End Sub

    Private Sub ButtonMouseUp(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        btn.BackColor = AdjustBrightness(btn.BackColor, 1.04)
        btn.Invalidate()
    End Sub

    ' ─── Label (Transparent Background) ───────────────────────────────────────
    Public Sub StyleLabel(lbl As Label)
        lbl.BackColor = Color.Transparent
        lbl.ForeColor = ColorText
    End Sub

    ' ─── TextBox (Semi-transparent with hover effect) ──────────────────────────────
    Public Sub StyleTextBox(txt As TextBox)
        txt.BackColor = Color.FromArgb(240, 245, 235)  ' Light semi-transparent look
        txt.ForeColor = ColorPrimary
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Font = FontBody

        ' Remove existing handlers to avoid duplicates
        RemoveHandler txt.Enter, AddressOf TextBoxEnter
        RemoveHandler txt.Leave, AddressOf TextBoxLeave
        RemoveHandler txt.MouseHover, AddressOf TextBoxHover

        AddHandler txt.Enter, AddressOf TextBoxEnter
        AddHandler txt.Leave, AddressOf TextBoxLeave
        AddHandler txt.MouseHover, AddressOf TextBoxHover
    End Sub

    Private Sub TextBoxEnter(sender As Object, e As EventArgs)
        Dim txt = DirectCast(sender, TextBox)
        txt.BackColor = Color.FromArgb(255, 255, 245)
        txt.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub TextBoxLeave(sender As Object, e As EventArgs)
        Dim txt = DirectCast(sender, TextBox)
        txt.BackColor = Color.FromArgb(240, 245, 235)
        txt.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub TextBoxHover(sender As Object, e As EventArgs)
        Dim txt = DirectCast(sender, TextBox)
        txt.BackColor = Color.FromArgb(245, 250, 240)
    End Sub

    ' ─── ComboBox (Semi-transparent with hover) ────────────────────────────────────
    Public Sub StyleComboBox(cmb As ComboBox)
        cmb.BackColor = Color.FromArgb(240, 245, 235)
        cmb.ForeColor = ColorPrimary
        cmb.FlatStyle = FlatStyle.Flat
        cmb.Font = FontBody
        cmb.DropDownStyle = ComboBoxStyle.DropDownList

        RemoveHandler cmb.MouseHover, AddressOf ComboBoxHover
        RemoveHandler cmb.MouseLeave, AddressOf ComboBoxLeave

        AddHandler cmb.MouseHover, AddressOf ComboBoxHover
        AddHandler cmb.MouseLeave, AddressOf ComboBoxLeave
    End Sub

    Private Sub ComboBoxHover(sender As Object, e As EventArgs)
        Dim cmb = DirectCast(sender, ComboBox)
        cmb.BackColor = Color.FromArgb(245, 250, 240)
    End Sub

    Private Sub ComboBoxLeave(sender As Object, e As EventArgs)
        Dim cmb = DirectCast(sender, ComboBox)
        cmb.BackColor = Color.FromArgb(240, 245, 235)
    End Sub

    ' ─── DataGridView ─────────────────────────────────────────────────────────
    Public Sub StyleGrid(dgv As DataGridView)
        dgv.BackgroundColor = Color.FromArgb(245, 250, 240)
        dgv.GridColor = ColorBorder
        dgv.ForeColor = ColorText
        dgv.Font = FontBody
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = ColorText
        dgv.DefaultCellStyle.SelectionBackColor = ColorPrimary
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorSurface
        dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimary
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = ColorPrimaryLight
        dgv.ColumnHeadersDefaultCellStyle.Font = FontButton
    End Sub

    ' ─── Panel (MAKE TRANSPARENT) ─────────────────────────────────────────────────
    Public Sub StylePanel(pnl As Panel, Optional withCardStyle As Boolean = False)
        ' Make panel transparent to show background image
        pnl.BackColor = Color.Transparent

        If withCardStyle Then
            ' If card style is requested, draw rounded white background
            RemoveHandler pnl.Paint, AddressOf PanelPaintCard
            AddHandler pnl.Paint, AddressOf PanelPaintCard
        Else
            ' Remove any custom painting
            RemoveHandler pnl.Paint, AddressOf PanelPaintCard
        End If
    End Sub

    Private Sub PanelPaintCard(sender As Object, e As PaintEventArgs)
        Dim pnl = DirectCast(sender, Panel)
        ' Draw a semi-transparent white card
        Using br As New SolidBrush(Color.FromArgb(230, 255, 255, 255))
            Dim path = RoundedRect(pnl.ClientRectangle, CardRadius)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.FillPath(br, path)

            ' Draw border
            Using pen As New Pen(Color.FromArgb(100, ColorBorder), 1)
                e.Graphics.DrawPath(pen, path)
            End Using
        End Using
    End Sub

    ' ─── GroupBox (Transparent) ───────────────────────────────────────────────
    Public Sub StyleGroupBox(grp As GroupBox)
        grp.BackColor = Color.Transparent
        grp.ForeColor = ColorPrimary
        grp.Font = FontButton
    End Sub

    ' ─── TabControl ───────────────────────────────────────────────────────────
    Public Sub StyleTabControl(tab As TabControl)
        tab.DrawMode = TabDrawMode.OwnerDrawFixed
        RemoveHandler tab.DrawItem, AddressOf DrawTabItem
        AddHandler tab.DrawItem, AddressOf DrawTabItem
        tab.Appearance = TabAppearance.Normal
    End Sub

    Private Sub DrawTabItem(sender As Object, e As DrawItemEventArgs)
        Dim tab = DirectCast(sender, TabControl)
        If e.Index >= 0 AndAlso e.Index < tab.TabPages.Count Then
            Dim page = tab.TabPages(e.Index)
            Dim isSelected = (tab.SelectedIndex = e.Index)
            Dim bg = If(isSelected, ColorPrimary, Color.FromArgb(200, ColorPrimaryLight))

            Using br As New SolidBrush(bg)
                e.Graphics.FillRectangle(br, e.Bounds)
            End Using

            Dim sf As New StringFormat With {
                .Alignment = StringAlignment.Center,
                .LineAlignment = StringAlignment.Center
            }

            Dim textColor = If(isSelected, Color.White, ColorPrimary)
            Using br As New SolidBrush(textColor)
                e.Graphics.DrawString(page.Text, FontButton, br, e.Bounds, sf)
            End Using
        End If
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
        If ctrl.Width > 0 AndAlso ctrl.Height > 0 Then
            Dim path As New GraphicsPath()
            Dim d = radius * 2
            path.AddArc(0, 0, d, d, 180, 90)
            path.AddArc(ctrl.Width - d, 0, d, d, 270, 90)
            path.AddArc(ctrl.Width - d, ctrl.Height - d, d, d, 0, 90)
            path.AddArc(0, ctrl.Height - d, d, d, 90, 90)
            path.CloseFigure()
            ctrl.Region = New Region(path)
        End If
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
        Dim col = If(bg = Nothing, Color.FromArgb(230, 255, 255, 255), bg)
        Dim path = RoundedRect(bounds, radius)
        Using br As New SolidBrush(col)
            g.FillPath(br, path)
        End Using
        Using pen As New Pen(Color.FromArgb(100, ColorBorder), 1)
            g.DrawPath(pen, path)
        End Using
    End Sub

    ' ─── Draggable borderless form ────────────────────────────────────────────
    Private _dragging As Boolean = False
    Private _startPoint As Point = Point.Empty

    Public Sub EnableDrag(frm As Form)
        RemoveHandler frm.MouseDown, AddressOf FormMouseDown
        RemoveHandler frm.MouseMove, AddressOf FormMouseMove
        RemoveHandler frm.MouseUp, AddressOf FormMouseUp

        AddHandler frm.MouseDown, AddressOf FormMouseDown
        AddHandler frm.MouseMove, AddressOf FormMouseMove
        AddHandler frm.MouseUp, AddressOf FormMouseUp
    End Sub

    Private Sub FormMouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            _dragging = True
            _startPoint = e.Location
        End If
    End Sub

    Private Sub FormMouseMove(sender As Object, e As MouseEventArgs)
        If _dragging Then
            Dim frm = DirectCast(sender, Form)
            frm.Location = New Point(
                frm.Location.X + (e.X - _startPoint.X),
                frm.Location.Y + (e.Y - _startPoint.Y))
        End If
    End Sub

    Private Sub FormMouseUp(sender As Object, e As MouseEventArgs)
        _dragging = False
    End Sub

End Module

Public Enum ButtonStyle
    Primary
    Secondary
    Danger
    Accent
End Enum