Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Public Class frmCSRActivity

    '── DB connection — temperorly ─────────────────────────────────────
    Private Const ConnStr As String =
        "Server=DCL-ICT-007/DEVELOPER;Database=ESG;Integrated Security=True;"

    '── Currently selected CSRID for Update / Delete ─────────────────────────
    Private _selectedID As Integer = 0

    '── Colours ───────────────────────────────────────────────────────────────
    Private ReadOnly Emerald As Color = Color.FromArgb(16, 185, 129)
    Private ReadOnly EmeraldHov As Color = Color.FromArgb(5, 150, 105)
    Private ReadOnly BorderClr As Color = Color.FromArgb(50, 65, 80)
    Private ReadOnly TextMuted As Color = Color.FromArgb(100, 116, 139)
    Private ReadOnly TextPri As Color = Color.FromArgb(240, 245, 248)

    '── Drag support ──────────────────────────────────────────────────────────
    Private _dragStart As Point

    '═════════════════════════════════════════════════════════════════════════
    '  FORM LOAD
    '═════════════════════════════════════════════════════════════════════════
    Private Sub frmCSRActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set corner radii
        btnBrowse.CornerRadius = 6
        btnSave.CornerRadius = 7
        btnUpdate.CornerRadius = 7
        btnDelete.CornerRadius = 7
        btnClear.CornerRadius = 7
        btnSearch.CornerRadius = 6
        btnRefresh.CornerRadius = 6

        ' Your existing load code
        SetRoundedCorners(12)
        StyleInputs()
        WireHoverEvents()
        SetupGrid()
        LoadGrid()
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  ROUNDED CORNERS
    '═════════════════════════════════════════════════════════════════════════
    Private Sub SetRoundedCorners(r As Integer)
        Dim d As Integer = r * 2
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, d, d, 180, 90)
        path.AddArc(Me.Width - d, 0, d, d, 270, 90)
        path.AddArc(Me.Width - d, Me.Height - d, d, d, 0, 90)
        path.AddArc(0, Me.Height - d, d, d, 90, 90)
        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  STYLE INPUT BORDERS ON FOCUS
    '═════════════════════════════════════════════════════════════════════════
    Private Sub StyleInputs()
        Dim inputs As TextBox() = {txtAction, txtDescription, txtLocation,
                               txtEmployees, txtHours, txtPeople,
                               txtQty, txtCost}
        For Each tb In inputs
            If tb IsNot Nothing Then
                AddHandler tb.GotFocus, AddressOf Input_GotFocus
                AddHandler tb.LostFocus, AddressOf Input_LostFocus
            End If
        Next
    End Sub

    Private Sub Input_GotFocus(sender As Object, e As EventArgs)
        CType(sender, TextBox).BackColor = Color.FromArgb(20, 50, 60)
    End Sub
    Private Sub Input_LostFocus(sender As Object, e As EventArgs)
        CType(sender, TextBox).BackColor = Color.FromArgb(30, 40, 52)
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  HOVER EVENTS
    '═════════════════════════════════════════════════════════════════════════
    Private Sub WireHoverEvents()
        If btnSave Is Nothing Then MessageBox.Show("btnSave is Nothing") : Return
        If btnSearch Is Nothing Then MessageBox.Show("btnSearch is Nothing") : Return
        If btnClose Is Nothing Then MessageBox.Show("btnClose is Nothing") : Return
        If btnMinimize Is Nothing Then MessageBox.Show("btnMinimize is Nothing") : Return

        AddHandler btnSave.MouseEnter, Sub() btnSave.BackColor = EmeraldHov
        AddHandler btnSave.MouseLeave, Sub() btnSave.BackColor = Emerald
        AddHandler btnSearch.MouseEnter, Sub() btnSearch.BackColor = EmeraldHov
        AddHandler btnSearch.MouseLeave, Sub() btnSearch.BackColor = Emerald
        AddHandler btnClose.MouseEnter, Sub() btnClose.ForeColor = Color.FromArgb(239, 68, 68)
        AddHandler btnClose.MouseLeave, Sub() btnClose.ForeColor = TextMuted
        AddHandler btnMinimize.MouseEnter, Sub() btnMinimize.ForeColor = TextPri
        AddHandler btnMinimize.MouseLeave, Sub() btnMinimize.ForeColor = TextMuted
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  PAINT — Form panels
    '═════════════════════════════════════════════════════════════════════════
    Private Sub pnlFormCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlFormCard.Paint
        DrawCardBorder(e.Graphics, pnlFormCard)
    End Sub

    Private Sub pnlGridCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlGridCard.Paint
        DrawCardBorder(e.Graphics, pnlGridCard)
    End Sub

    Private Sub pnlTitleBar_Paint(sender As Object, e As PaintEventArgs) Handles pnlTitleBar.Paint
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        ' Bottom accent line
        Using br As New LinearGradientBrush(
            New Point(0, pnlTitleBar.Height - 1),
            New Point(pnlTitleBar.Width, pnlTitleBar.Height - 1),
            Color.FromArgb(16, 10, 10),
            Color.Transparent)
            Using pen As New Pen(br, 1)
                g.DrawLine(pen, 0, pnlTitleBar.Height - 1, pnlTitleBar.Width, pnlTitleBar.Height - 1)
            End Using
        End Using
    End Sub

    Private Sub DrawCardBorder(g As Graphics, ctrl As Control)
        g.SmoothingMode = SmoothingMode.AntiAlias
        Using pen As New Pen(Color.FromArgb(15, 255, 255, 255), 1)
            Dim rect As New Rectangle(0, 0, ctrl.Width - 1, ctrl.Height - 1)
            g.DrawRectangle(pen, rect)
        End Using
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  SETUP DATAGRIDVIEW COLUMNS
    '═════════════════════════════════════════════════════════════════════════
    Private Sub SetupGrid()
        dgvCSR.Columns.Clear()
        Dim cols() As String = {"CSRID", "Date", "Action", "Description",
                                 "Frequency", "Location", "Engagement",
                                 "Employees", "Hours", "Impacted",
                                 "Quantity", "Cost (USD)", "Type", "Photo"}
        Dim dbCols() As String = {"CSRID", "ActivityDate", "Action", "Description",
                                   "Frequency", "Location", "EngagementType",
                                   "EmployeesInvolved", "HoursInvested", "PeopleImpacted",
                                   "Quantity", "CostUSD", "ActivityType", "PhotoPath"}

        For i As Integer = 0 To cols.Length - 1
            Dim col As New DataGridViewTextBoxColumn()
            col.HeaderText = cols(i)
            col.DataPropertyName = dbCols(i)
            col.Name = dbCols(i)
            dgvCSR.Columns.Add(col)
        Next

        ' Hide CSRID column
        dgvCSR.Columns("CSRID").Visible = False
        ' Photo column — show icon if path exists
        dgvCSR.Columns("PhotoPath").DefaultCellStyle.ForeColor = Emerald
        dgvCSR.Columns("PhotoPath").DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Underline)
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  LOAD / FILTER GRID
    '═════════════════════════════════════════════════════════════════════════
    Private Sub LoadGrid(Optional fromDate As DateTime = Nothing,
                         Optional toDate As DateTime = Nothing)
        Try
            Dim sql As String
            If fromDate = Nothing Then
                sql = "SELECT CSRID, ActivityDate, Action, Description, Frequency,
                              Location, EngagementType, EmployeesInvolved, HoursInvested,
                              PeopleImpacted, Quantity, CostUSD, ActivityType, PhotoPath
                       FROM tblESGCSRActivity
                       ORDER BY ActivityDate DESC"
            Else
                sql = "SELECT CSRID, ActivityDate, Action, Description, Frequency,
                              Location, EngagementType, EmployeesInvolved, HoursInvested,
                              PeopleImpacted, Quantity, CostUSD, ActivityType, PhotoPath
                       FROM tblESGCSRActivity
                       WHERE ActivityDate BETWEEN @from AND @to
                       ORDER BY ActivityDate DESC"
            End If

            Using conn As New SqlConnection(ConnStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    If fromDate <> Nothing Then
                        cmd.Parameters.AddWithValue("@from", fromDate)
                        cmd.Parameters.AddWithValue("@to", toDate)
                    End If
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvCSR.DataSource = dt
                    lblRecordCount.Text = dt.Rows.Count & " record(s)"
                    ShowStatus("✔  " & dt.Rows.Count & " records loaded", Emerald)
                End Using
            End Using

        Catch ex As SqlException
            ShowStatus("✘  DB Error: " & ex.Message, Color.FromArgb(239, 68, 68))
        Catch ex As Exception
            ShowStatus("✘  " & ex.Message, Color.FromArgb(239, 68, 68))
        End Try
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  SAVE
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateForm() Then Return

        Try
            Dim sql As String =
                "INSERT INTO tblESGCSRActivity
                 (ActivityDate, Action, Description, Frequency, Location,
                  EngagementType, EmployeesInvolved, HoursInvested, PeopleImpacted,
                  Quantity, CostUSD, ActivityType, PhotoPath, CreatedBy, CreatedDate)
                 VALUES
                 (@date, @action, @desc, @freq, @loc,
                  @eng, @emp, @hrs, @ppl,
                  @qty, @cost, @type, @photo, @createdBy, GETDATE())"

            Using conn As New SqlConnection(ConnStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    BuildParams(cmd)
                    cmd.Parameters.AddWithValue("@createdBy", Environment.UserName)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ShowStatus("✔  Activity saved successfully!", Emerald)
            AnimateSaveButton()
            ClearForm()
            LoadGrid()

        Catch ex As SqlException
            ShowStatus("✘  Save failed: " & ex.Message, Color.FromArgb(239, 68, 68))
        End Try
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  UPDATE
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If _selectedID = 0 Then Return
        If Not ValidateForm() Then Return

        Dim confirm = MessageBox.Show(
            "Update this CSR activity record?",
            "Confirm Update",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Dim sql As String =
                "UPDATE tblESGCSRActivity SET
                  ActivityDate = @date, Action = @action, Description = @desc,
                  Frequency = @freq, Location = @loc, EngagementType = @eng,
                  EmployeesInvolved = @emp, HoursInvested = @hrs, PeopleImpacted = @ppl,
                  Quantity = @qty, CostUSD = @cost, ActivityType = @type,
                  PhotoPath = @photo, ModifiedBy = @modBy, ModifiedDate = GETDATE()
                 WHERE CSRID = @id"

            Using conn As New SqlConnection(ConnStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    BuildParams(cmd)
                    cmd.Parameters.AddWithValue("@modBy", Environment.UserName)
                    cmd.Parameters.AddWithValue("@id", _selectedID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ShowStatus("✔  Record updated successfully!", Emerald)
            ClearForm()
            LoadGrid()

        Catch ex As SqlException
            ShowStatus("✘  Update failed: " & ex.Message, Color.FromArgb(239, 68, 68))
        End Try
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  DELETE
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If _selectedID = 0 Then Return

        Dim confirm = MessageBox.Show(
            "Are you sure you want to delete this record?" & Environment.NewLine &
            "This action cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)
        If confirm <> DialogResult.Yes Then Return

        Try
            Using conn As New SqlConnection(ConnStr)
                conn.Open()
                Using cmd As New SqlCommand(
                    "DELETE FROM tblESGCSRActivity WHERE CSRID = @id", conn)
                    cmd.Parameters.AddWithValue("@id", _selectedID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ShowStatus("✔  Record deleted.", Color.FromArgb(251, 146, 60))
            ClearForm()
            LoadGrid()

        Catch ex As SqlException
            ShowStatus("✘  Delete failed: " & ex.Message, Color.FromArgb(239, 68, 68))
        End Try
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  BUILD SQL PARAMETERS (shared by Save and Update)
    '═════════════════════════════════════════════════════════════════════════
    Private Sub BuildParams(cmd As SqlCommand)
        cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
        cmd.Parameters.AddWithValue("@action", txtAction.Text.Trim())
        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim())
        cmd.Parameters.AddWithValue("@freq", If(cboFrequency.SelectedItem Is Nothing, DBNull.Value, CObj(cboFrequency.SelectedItem.ToString())))
        cmd.Parameters.AddWithValue("@loc", txtLocation.Text.Trim())
        cmd.Parameters.AddWithValue("@eng", If(cboEngagement.SelectedItem Is Nothing, DBNull.Value, CObj(cboEngagement.SelectedItem.ToString())))
        cmd.Parameters.AddWithValue("@emp", ParseInt(txtEmployees.Text))
        cmd.Parameters.AddWithValue("@hrs", ParseDec(txtHours.Text))
        cmd.Parameters.AddWithValue("@ppl", ParseInt(txtPeople.Text))
        cmd.Parameters.AddWithValue("@qty", ParseDec(txtQty.Text))
        cmd.Parameters.AddWithValue("@cost", ParseDec(txtCost.Text))
        cmd.Parameters.AddWithValue("@type", If(cboActivityType.SelectedItem Is Nothing, DBNull.Value, CObj(cboActivityType.SelectedItem.ToString())))
        cmd.Parameters.AddWithValue("@photo", If(String.IsNullOrEmpty(txtPhotoPath.Text), DBNull.Value, CObj(txtPhotoPath.Text)))
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  DATAGRIDVIEW SELECTION — populate form fields
    '═════════════════════════════════════════════════════════════════════════
    Private Sub dgvCSR_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCSR.SelectionChanged
        If dgvCSR.SelectedRows.Count = 0 Then Return
        Dim row As DataGridViewRow = dgvCSR.SelectedRows(0)

        _selectedID = CInt(If(IsDBNull(row.Cells("CSRID").Value), 0, row.Cells("CSRID").Value))

        dtpDate.Value = CDate(If(IsDBNull(row.Cells("ActivityDate").Value), DateTime.Now, row.Cells("ActivityDate").Value))
        txtAction.Text = SafeStr(row.Cells("Action").Value)
        txtDescription.Text = SafeStr(row.Cells("Description").Value)
        txtLocation.Text = SafeStr(row.Cells("Location").Value)
        txtEmployees.Text = SafeStr(row.Cells("EmployeesInvolved").Value)
        txtHours.Text = SafeStr(row.Cells("HoursInvested").Value)
        txtPeople.Text = SafeStr(row.Cells("PeopleImpacted").Value)
        txtQty.Text = SafeStr(row.Cells("Quantity").Value)
        txtCost.Text = SafeStr(row.Cells("CostUSD").Value)

        SetCombo(cboFrequency, SafeStr(row.Cells("Frequency").Value))
        SetCombo(cboEngagement, SafeStr(row.Cells("EngagementType").Value))
        SetCombo(cboActivityType, SafeStr(row.Cells("ActivityType").Value))

        ' Photo path
        Dim photoPath As String = SafeStr(row.Cells("PhotoPath").Value)
        txtPhotoPath.Text = photoPath
        LoadPhotoPreview(photoPath)

        ' Enable Update/Delete
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        lblFormTitle.Text = "Edit Activity  [ID: " & _selectedID & "]"
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  CELL CLICK — click photo cell to popup photo viewer
    '═════════════════════════════════════════════════════════════════════════
    Private Sub dgvCSR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSR.CellClick
        If e.RowIndex < 0 Then Return
        If dgvCSR.Columns(e.ColumnIndex).Name <> "PhotoPath" Then Return

        Dim path As String = SafeStr(dgvCSR.Rows(e.RowIndex).Cells("PhotoPath").Value)
        If String.IsNullOrEmpty(path) OrElse Not File.Exists(path) Then
            MessageBox.Show("No photo found at: " & path, "Photo Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ShowPhotoPopup(path)
    End Sub

    '── Photo popup viewer ────────────────────────────────────────────────────
    Private Sub ShowPhotoPopup(imagePath As String)
        Dim popup As New Form()
        popup.Text = "CSR Photo — " & Path.GetFileName(imagePath)
        popup.Size = New Size(800, 620)
        popup.StartPosition = FormStartPosition.CenterParent
        popup.BackColor = Color.FromArgb(15, 20, 28)
        popup.FormBorderStyle = FormBorderStyle.FixedDialog
        popup.MaximizeBox = False

        Dim pic As New PictureBox()
        pic.Dock = DockStyle.Fill
        pic.SizeMode = PictureBoxSizeMode.Zoom
        pic.BackColor = Color.FromArgb(15, 20, 28)
        Try
            pic.Image = Image.FromFile(imagePath)
        Catch
            MessageBox.Show("Could not load image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        Dim lblPath As New Label()
        lblPath.Text = imagePath
        lblPath.Dock = DockStyle.Bottom
        lblPath.Height = 28
        lblPath.Font = New Font("Segoe UI", 8.5!)
        lblPath.ForeColor = Color.FromArgb(71, 85, 105)
        lblPath.BackColor = Color.FromArgb(10, 14, 20)
        lblPath.TextAlign = ContentAlignment.MiddleLeft
        lblPath.Padding = New Padding(8, 0, 0, 0)

        popup.Controls.Add(pic)
        popup.Controls.Add(lblPath)
        popup.ShowDialog(Me)
        pic.Image?.Dispose()
    End Sub

    '── Preview in form ───────────────────────────────────────────────────────
    Private Sub LoadPhotoPreview(path As String)
        If Not String.IsNullOrEmpty(path) AndAlso File.Exists(path) Then
            Try
                picPreview.Image = Image.FromFile(path)
                lblPhotoHint.Visible = False
                picPreview.Visible = True
            Catch
                picPreview.Visible = False
                lblPhotoHint.Visible = True
                lblPhotoHint.Text = "⚠  Could not load image"
            End Try
        Else
            picPreview.Image = Nothing
            picPreview.Visible = False
            lblPhotoHint.Visible = True
            lblPhotoHint.Text = "📷  No photo selected"
        End If
    End Sub

    '── Click preview to popup ────────────────────────────────────────────────
    Private Sub picPreview_Click(sender As Object, e As EventArgs) Handles picPreview.Click
        If Not String.IsNullOrEmpty(txtPhotoPath.Text) AndAlso File.Exists(txtPhotoPath.Text) Then
            ShowPhotoPopup(txtPhotoPath.Text)
        End If
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  BROWSE PHOTO
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Photo"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtPhotoPath.Text = ofd.FileName
                LoadPhotoPreview(ofd.FileName)
                ShowStatus("Photo selected: " & Path.GetFileName(ofd.FileName), Emerald)
            End If
        End Using
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  SEARCH / FILTER
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadGrid(dtpFrom.Value.Date, dtpTo.Value.Date.AddDays(1).AddSeconds(-1))
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dtpFrom.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpTo.Value = DateTime.Now
        LoadGrid()
        ClearForm()
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  CLEAR FORM
    '═════════════════════════════════════════════════════════════════════════
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        _selectedID = 0
        dtpDate.Value = DateTime.Now
        txtAction.Text = ""
        txtDescription.Text = ""
        txtLocation.Text = ""
        txtEmployees.Text = ""
        txtHours.Text = ""
        txtPeople.Text = ""
        txtQty.Text = ""
        txtCost.Text = ""
        txtPhotoPath.Text = ""
        cboFrequency.SelectedIndex = -1
        cboEngagement.SelectedIndex = -1
        cboActivityType.SelectedIndex = -1
        LoadPhotoPreview("")
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        lblFormTitle.Text = "New Activity Entry"
        dgvCSR.ClearSelection()
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  VALIDATION
    '═════════════════════════════════════════════════════════════════════════
    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtAction.Text) Then
            ShowStatus("✘  Action field is required.", Color.FromArgb(239, 68, 68))
            txtAction.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtLocation.Text) Then
            ShowStatus("✘  Location field is required.", Color.FromArgb(239, 68, 68))
            txtLocation.Focus()
            Return False
        End If
        Return True
    End Function

    '═════════════════════════════════════════════════════════════════════════
    '  STATUS BAR
    '═════════════════════════════════════════════════════════════════════════
    Private Sub ShowStatus(msg As String, clr As Color)
        lblStatus.Text = msg
        lblStatusIcon.ForeColor = clr
        tmrStatus.Stop()
        tmrStatus.Start()
    End Sub

    Private Sub tmrStatus_Tick(sender As Object, e As EventArgs) Handles tmrStatus.Tick
        tmrStatus.Stop()
        lblStatus.Text = "Ready"
        lblStatusIcon.ForeColor = Emerald
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  SAVE BUTTON ANIMATION
    '═════════════════════════════════════════════════════════════════════════
    Private Async Sub AnimateSaveButton()
        btnSave.Text = "✔  Saved!"
        btnSave.BackColor = Color.FromArgb(5, 150, 105)
        Await System.Threading.Tasks.Task.Delay(1800)
        btnSave.Text = "💾  Save"
        btnSave.BackColor = Emerald
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  TITLE BAR DRAG + BUTTONS
    '═════════════════════════════════════════════════════════════════════════
    Private _dragStart2 As Point

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) _
        Handles pnlTitleBar.MouseDown, lblTitle.MouseDown, lblTitleIcon.MouseDown
        If e.Button = MouseButtons.Left Then _dragStart2 = e.Location
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Me.Location = New Point(Me.Left + e.X - _dragStart2.X,
                                    Me.Top + e.Y - _dragStart2.Y)
        End If
        MyBase.OnMouseMove(e)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  GRID ROW COLOUR (alternate rows already set in Designer;
    '  this adds hover highlight)
    '═════════════════════════════════════════════════════════════════════════
    Private Sub dgvCSR_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSR.CellMouseEnter
        If e.RowIndex < 0 Then Return
        dgvCSR.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(25, 38, 50)
    End Sub

    Private Sub dgvCSR_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSR.CellMouseLeave
        If e.RowIndex < 0 Then Return
        ' Restore alternate row colour
        If e.RowIndex Mod 2 = 0 Then
            dgvCSR.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(22, 30, 40)
        Else
            dgvCSR.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(18, 26, 36)
        End If
    End Sub

    '═════════════════════════════════════════════════════════════════════════
    '  HELPERS
    '═════════════════════════════════════════════════════════════════════════
    Private Shared Function SafeStr(val As Object) As String
        Return If(IsDBNull(val) OrElse val Is Nothing, "", val.ToString())
    End Function

    Private Shared Function ParseInt(s As String) As Object
        Dim n As Integer
        Return If(Integer.TryParse(s.Trim(), n), CObj(n), DBNull.Value)
    End Function

    Private Shared Function ParseDec(s As String) As Object
        Dim d As Decimal
        Return If(Decimal.TryParse(s.Trim(), d), CObj(d), DBNull.Value)
    End Function

    Private Shared Sub SetCombo(cbo As ComboBox, value As String)
        Dim idx As Integer = cbo.FindStringExact(value)
        cbo.SelectedIndex = If(idx >= 0, idx, -1)
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub pnlBody_Paint(sender As Object, e As PaintEventArgs) Handles pnlBody.Paint

    End Sub
End Class