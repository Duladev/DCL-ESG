Imports System.Data.SqlClient
Imports System.IO

Public Class frmCollectorManagement
    Private currentCollectorID As Integer = -1
    Private licenseDocumentPath As String = ""

    Public Sub New()
        InitializeComponent()
        AddKeyPressHandlers(Me.Controls)
    End Sub

    Private Sub frmCollectorManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyModernStyle(Me)
        LoadCollectors()
        SetupForm(Me)
    End Sub

    Private Sub LoadCollectors()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT CollectorID, CollectorName, Address, TelephoneNumber, LicenseNumber, LicenseDocumentPath FROM tbl_ESG_WasteCollectors WHERE IsActive = 1 ORDER BY CollectorName"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                grdCollectors.DataSource = dt

                ' Format DataGridView
                If grdCollectors.Columns.Count > 0 Then
                    grdCollectors.Columns("CollectorID").Visible = False
                    grdCollectors.Columns("LicenseDocumentPath").Visible = False
                    grdCollectors.Columns("CollectorName").HeaderText = "Collector Name"
                    grdCollectors.Columns("Address").HeaderText = "Address"
                    grdCollectors.Columns("TelephoneNumber").HeaderText = "Telephone"
                    grdCollectors.Columns("LicenseNumber").HeaderText = "License Number"
                    grdCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    ' Add View Document button column if not exists
                    AddViewDocumentButtonColumn()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading collectors: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddViewDocumentButtonColumn()
        ' Check if column already exists
        If grdCollectors.Columns("ViewDocument") Is Nothing Then
            Dim viewButtonColumn As New DataGridViewButtonColumn()
            viewButtonColumn.Name = "ViewDocument"
            viewButtonColumn.HeaderText = "View License"
            viewButtonColumn.Text = "View"
            viewButtonColumn.UseColumnTextForButtonValue = True
            viewButtonColumn.Width = 80
            grdCollectors.Columns.Add(viewButtonColumn)
        End If
    End Sub

    Private Sub btnSaveCollector_Click(sender As Object, e As EventArgs) Handles btnSaveCollector.Click
        If String.IsNullOrWhiteSpace(txtCollectorName.Text) Then
            MessageBox.Show("Please enter collector name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Handle document upload first
            Dim savedDocumentPath As String = ""
            If Not String.IsNullOrEmpty(licenseDocumentPath) AndAlso File.Exists(licenseDocumentPath) Then
                ' Generate unique filename
                Dim fileName As String = Guid.NewGuid().ToString() & "_" & Path.GetFileName(licenseDocumentPath)
                Dim targetFolder As String = Path.Combine(baseFolderPath, "WasteCollectors")

                ' Create directory if not exists
                If Not Directory.Exists(targetFolder) Then
                    Directory.CreateDirectory(targetFolder)
                End If

                savedDocumentPath = Path.Combine(targetFolder, fileName)
                File.Copy(licenseDocumentPath, savedDocumentPath, True)
            End If

            Using conn As SqlConnection = GetConnection()
                conn.Open()

                If currentCollectorID = -1 Then
                    ' Insert new collector
                    Dim query As String = "INSERT INTO tbl_ESG_WasteCollectors (CollectorName, Address, TelephoneNumber, LicenseNumber, LicenseDocumentPath, CreatedDate, IsActive) 
                                          VALUES (@Name, @Address, @Phone, @License, @DocPath, GETDATE(), 1)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Name", txtCollectorName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(txtAddress.Text), DBNull.Value, txtAddress.Text.Trim()))
                        cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(txtPhone.Text), DBNull.Value, txtPhone.Text.Trim()))
                        cmd.Parameters.AddWithValue("@License", If(String.IsNullOrWhiteSpace(txtLicenseNumber.Text), DBNull.Value, txtLicenseNumber.Text.Trim()))
                        cmd.Parameters.AddWithValue("@DocPath", If(String.IsNullOrEmpty(savedDocumentPath), DBNull.Value, savedDocumentPath))
                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    ' Update existing collector
                    ' Get existing document path if no new document uploaded
                    If String.IsNullOrEmpty(savedDocumentPath) AndAlso currentCollectorID <> -1 Then
                        savedDocumentPath = GetExistingDocumentPath(currentCollectorID)
                    End If

                    Dim query As String = "UPDATE tbl_ESG_WasteCollectors SET CollectorName=@Name, Address=@Address, 
                                          TelephoneNumber=@Phone, LicenseNumber=@License, LicenseDocumentPath=@DocPath 
                                          WHERE CollectorID=@ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", currentCollectorID)
                        cmd.Parameters.AddWithValue("@Name", txtCollectorName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(txtAddress.Text), DBNull.Value, txtAddress.Text.Trim()))
                        cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(txtPhone.Text), DBNull.Value, txtPhone.Text.Trim()))
                        cmd.Parameters.AddWithValue("@License", If(String.IsNullOrWhiteSpace(txtLicenseNumber.Text), DBNull.Value, txtLicenseNumber.Text.Trim()))
                        cmd.Parameters.AddWithValue("@DocPath", If(String.IsNullOrEmpty(savedDocumentPath), DBNull.Value, savedDocumentPath))
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Collector saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadCollectors()
        Catch ex As Exception
            MessageBox.Show("Error saving collector: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetExistingDocumentPath(collectorID As Integer) As String
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT LicenseDocumentPath FROM tbl_ESG_WasteCollectors WHERE CollectorID = @ID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", collectorID)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Return empty string if error
        End Try
        Return ""
    End Function

    Private Sub btnUploadLicense_Click(sender As Object, e As EventArgs) Handles btnUploadLicense.Click
        Using ofdLicense As New OpenFileDialog()
            ofdLicense.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png;*.bmp|Word Files|*.doc;*.docx|All Files|*.*"
            ofdLicense.Title = "Select License Document"

            If ofdLicense.ShowDialog() = DialogResult.OK Then
                licenseDocumentPath = ofdLicense.FileName
                lblLicenseStatus.Text = "Document selected: " & Path.GetFileName(licenseDocumentPath)
                lblLicenseStatus.ForeColor = Color.Green
            End If
        End Using
    End Sub

    Private Sub grdCollectors_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdCollectors.CellContentClick
        If e.RowIndex >= 0 Then
            ' Check if View Document button was clicked
            If grdCollectors.Columns("ViewDocument") IsNot Nothing AndAlso e.ColumnIndex = grdCollectors.Columns("ViewDocument").Index Then
                Dim documentPath As String = grdCollectors.Rows(e.RowIndex).Cells("LicenseDocumentPath").Value?.ToString()
                If Not String.IsNullOrEmpty(documentPath) AndAlso File.Exists(documentPath) Then
                    OpenFileWithDefaultProgram(documentPath)
                ElseIf Not String.IsNullOrEmpty(documentPath) AndAlso Not File.Exists(documentPath) Then
                    MessageBox.Show("Document file not found at: " & documentPath & vbCrLf & "The file may have been moved or deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("No document uploaded for this collector.", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                ' Select the row for editing
                grdCollectors.Rows(e.RowIndex).Selected = True
                LoadCollectorToForm()
            End If
        End If
    End Sub

    Private Sub grdCollectors_SelectionChanged(sender As Object, e As EventArgs) Handles grdCollectors.SelectionChanged
        ' Fix: Check if there are selected rows and if the selection changed due to row selection
        If grdCollectors.SelectedRows.Count > 0 Then
            ' Check if we're not clicking on a button column
            If grdCollectors.CurrentCell IsNot Nothing Then
                If grdCollectors.Columns("ViewDocument") IsNot Nothing AndAlso
                   grdCollectors.CurrentCell.ColumnIndex = grdCollectors.Columns("ViewDocument").Index Then
                    Return ' Don't load form when clicking view button
                End If
            End If
            LoadCollectorToForm()
        End If
    End Sub

    Private Sub LoadCollectorToForm()
        ' Safety check to ensure we have selected rows
        If grdCollectors.SelectedRows Is Nothing OrElse grdCollectors.SelectedRows.Count = 0 Then
            Return
        End If

        Try
            Dim selectedRow As DataGridViewRow = grdCollectors.SelectedRows(0)

            ' Check if the row has the required cells
            If selectedRow.Cells("CollectorID") Is Nothing OrElse selectedRow.Cells("CollectorID").Value Is Nothing Then
                Return
            End If

            currentCollectorID = Convert.ToInt32(selectedRow.Cells("CollectorID").Value)

            ' Safely set textbox values
            txtCollectorName.Text = If(selectedRow.Cells("CollectorName").Value IsNot Nothing, selectedRow.Cells("CollectorName").Value.ToString(), "")
            txtAddress.Text = If(selectedRow.Cells("Address").Value IsNot Nothing, selectedRow.Cells("Address").Value.ToString(), "")
            txtPhone.Text = If(selectedRow.Cells("TelephoneNumber").Value IsNot Nothing, selectedRow.Cells("TelephoneNumber").Value.ToString(), "")
            txtLicenseNumber.Text = If(selectedRow.Cells("LicenseNumber").Value IsNot Nothing, selectedRow.Cells("LicenseNumber").Value.ToString(), "")

            ' Handle document path
            If selectedRow.Cells("LicenseDocumentPath").Value IsNot Nothing AndAlso selectedRow.Cells("LicenseDocumentPath").Value IsNot DBNull.Value Then
                licenseDocumentPath = selectedRow.Cells("LicenseDocumentPath").Value.ToString()
                If File.Exists(licenseDocumentPath) Then
                    lblLicenseStatus.Text = "Current document: " & Path.GetFileName(licenseDocumentPath)
                    lblLicenseStatus.ForeColor = Color.Blue
                Else
                    lblLicenseStatus.Text = "Document file missing: " & Path.GetFileName(licenseDocumentPath)
                    lblLicenseStatus.ForeColor = Color.Red
                End If
            Else
                licenseDocumentPath = ""
                lblLicenseStatus.Text = "No document uploaded"
                lblLicenseStatus.ForeColor = Color.Gray
            End If
        Catch ex As Exception
            ' Silent fail - don't crash the form
            Console.WriteLine("Error loading collector to form: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteCollector_Click(sender As Object, e As EventArgs) Handles btnDeleteCollector.Click
        If currentCollectorID = -1 Then
            MessageBox.Show("Please select a collector to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if collector has associated waste records
        If HasAssociatedRecords(currentCollectorID) Then
            MessageBox.Show("This collector has associated waste records and cannot be deleted. Consider marking as inactive instead.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this collector?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    ' Soft delete - set IsActive to 0
                    Dim query As String = "UPDATE tbl_ESG_WasteCollectors SET IsActive = 0 WHERE CollectorID = @ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", currentCollectorID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Collector deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadCollectors()
            Catch ex As Exception
                MessageBox.Show("Error deleting collector: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function HasAssociatedRecords(collectorID As Integer) As Boolean
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                ' Check if there are waste records associated with this collector
                Dim query As String = "SELECT COUNT(*) FROM tbl_ESG_WasteRecords WHERE CollectorID = @ID AND IsActive = 1"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", collectorID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCollectors()
        ClearForm()
    End Sub

    Private Sub btnViewDocument_Click(sender As Object, e As EventArgs) Handles btnViewDocument.Click
        If Not String.IsNullOrEmpty(licenseDocumentPath) AndAlso File.Exists(licenseDocumentPath) Then
            OpenFileWithDefaultProgram(licenseDocumentPath)
        ElseIf Not String.IsNullOrEmpty(licenseDocumentPath) Then
            MessageBox.Show("Document file not found at: " & licenseDocumentPath, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("No document uploaded for this collector.", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtCollectorName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtLicenseNumber.Clear()
        licenseDocumentPath = ""
        lblLicenseStatus.Text = "No document selected"
        lblLicenseStatus.ForeColor = Color.Gray
        currentCollectorID = -1
        txtCollectorName.Focus()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
        Me.Close()
    End Sub
End Class