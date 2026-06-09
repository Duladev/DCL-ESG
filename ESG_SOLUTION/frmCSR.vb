Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml
Imports OfficeOpenXml.Style

Public Class frmCSR
    Private currentRecordID As Integer = -1
    Private tempPhotoNames As New List(Of String) ' Store only photo names temporarily
    Private currentPreviewImage As Image = Nothing ' Track the current preview image

    Private Sub frmCSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        SetupDataGridView()
        SetupListView()
        ClearForm()
        ApplyModernStyle(Me)

        ' Create photos directory if not exists using baseFolderPath from ModShared
        Dim photoStoragePath As String = Path.Combine(baseFolderPath, "CSR_Photos")
        If Not Directory.Exists(photoStoragePath) Then
            Directory.CreateDirectory(photoStoragePath)
        End If

        txtPhotoFolderPath.Text = photoStoragePath
    End Sub

    Private Function GetPhotoStoragePath() As String
        Return Path.Combine(baseFolderPath, "CSR_Photos")
    End Function

    Private Sub SetupDataGridView()
        dgvData.AutoGenerateColumns = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.MultiSelect = False

        ' Enable horizontal scrolling
        dgvData.ScrollBars = ScrollBars.Both ' This enables both horizontal and vertical scrollbars
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None ' Don't auto-size columns to fit

        ' Optional: Set minimum column width for better scrolling experience
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        ' Ensure all columns are visible by setting their width appropriately
        ' This allows horizontal scrolling when columns exceed the visible area
        dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
    End Sub

    Private Sub SetupListView()
        lvwPhotos.View = View.Details
        lvwPhotos.FullRowSelect = True
        lvwPhotos.GridLines = True

        ' Configure ListView columns
        lvwPhotos.Columns.Clear()
        lvwPhotos.Columns.Add("Photo Name", 150)
        lvwPhotos.Columns.Add("Primary", 60)
        lvwPhotos.Columns.Add("Uploaded Date", 120)
        lvwPhotos.Columns.Add("Original File", 150)
    End Sub

    Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder.Click
        Dim currentPath As String = GetPhotoStoragePath()
        Using dialog As New FolderBrowserDialog()
            dialog.Description = "Select Photo Storage Folder"
            dialog.ShowNewFolderButton = True
            dialog.SelectedPath = currentPath

            If dialog.ShowDialog() = DialogResult.OK Then
                Dim newPath As String = dialog.SelectedPath
                ' Update baseFolderPath in ModShared (optional - if you want to persist)
                ' This would require saving to app config or registry

                txtPhotoFolderPath.Text = newPath

                ' Create directory if not exists
                If Not Directory.Exists(newPath) Then
                    Directory.CreateDirectory(newPath)
                End If

                MessageBox.Show($"Photo storage path updated to: {newPath}", "Path Updated",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub LoadData(Optional startDate As DateTime? = Nothing, Optional endDate As DateTime? = Nothing)
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT RecordID, ActivityDate, Action, Description, Frequency, Location, 
                                      TimeOfEngagement, EmployeesEnvolved, HoursInvested, PeopleImpacted, 
                                      Quantity, CostUSD, Type FROM tbl_ESG_CSR"

                If startDate.HasValue AndAlso endDate.HasValue Then
                    query &= " WHERE ActivityDate BETWEEN @StartDate AND @EndDate"
                End If

                query &= " ORDER BY ActivityDate DESC"

                Using cmd As New SqlCommand(query, conn)
                    If startDate.HasValue AndAlso endDate.HasValue Then
                        cmd.Parameters.AddWithValue("@StartDate", startDate.Value)
                        cmd.Parameters.AddWithValue("@EndDate", endDate.Value)
                    End If

                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvData.DataSource = dt

                    ' After loading data, adjust column widths for better scrolling
                    AdjustDataGridViewColumns()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdjustDataGridViewColumns()
        ' Set specific column widths to ensure horizontal scrolling works
        ' You can adjust these values based on your preference
        If dgvData.Columns.Count > 0 Then
            For Each column As DataGridViewColumn In dgvData.Columns
                ' Set a reasonable minimum width for columns
                column.MinimumWidth = 80

                ' Set specific widths for certain columns
                Select Case column.Name
                    Case "RecordID"
                        column.Width = 80
                    Case "ActivityDate"
                        column.Width = 120
                    Case "Action"
                        column.Width = 200
                    Case "Description"
                        column.Width = 250
                    Case "Frequency"
                        column.Width = 100
                    Case "Location"
                        column.Width = 150
                    Case "TimeOfEngagement"
                        column.Width = 120
                    Case "EmployeesEnvolved"
                        column.Width = 120
                    Case "HoursInvested"
                        column.Width = 100
                    Case "PeopleImpacted"
                        column.Width = 100
                    Case "Quantity"
                        column.Width = 80
                    Case "CostUSD"
                        column.Width = 100
                    Case "Type"
                        column.Width = 120
                    Case Else
                        column.Width = 100
                End Select
            Next
        End If
    End Sub

    Private Sub LoadPhotos(recordID As Integer)
        ' Clear and dispose existing preview image
        ClearPreviewImage()

        lvwPhotos.Items.Clear()

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT PhotoID, PhotoName, OriginalFileName, IsPrimary, UploadedDate 
                                      FROM tbl_ESG_CSR_Photos WHERE RecordID = @RecordID ORDER BY IsPrimary DESC, UploadedDate DESC"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RecordID", recordID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim item As New ListViewItem(reader("PhotoName").ToString())
                        item.SubItems.Add(If(reader("IsPrimary"), "Yes", "No"))
                        item.SubItems.Add(Convert.ToDateTime(reader("UploadedDate")).ToString("yyyy-MM-dd HH:mm"))
                        item.SubItems.Add(reader("OriginalFileName").ToString())
                        item.Tag = New PhotoInfo() With {
                            .PhotoID = Convert.ToInt32(reader("PhotoID")),
                            .PhotoName = reader("PhotoName").ToString(),
                            .OriginalFileName = reader("OriginalFileName").ToString(),
                            .IsPrimary = Convert.ToBoolean(reader("IsPrimary"))
                        }
                        lvwPhotos.Items.Add(item)
                    End While
                End Using
            End Using

            lblPhotoCount.Text = $"{lvwPhotos.Items.Count} photo(s)"
        Catch ex As Exception
            MessageBox.Show("Error loading photos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearPreviewImage()
        If currentPreviewImage IsNot Nothing Then
            currentPreviewImage.Dispose()
            currentPreviewImage = Nothing
        End If
        pbPhotoPreview.Image = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return

        Dim photoStoragePath As String = GetPhotoStoragePath()

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    ' Insert main record
                    Dim query As String = "INSERT INTO tbl_ESG_CSR (ActivityDate, Action, Description, Frequency, 
                                          Location, TimeOfEngagement, EmployeesEnvolved, HoursInvested, 
                                          PeopleImpacted, Quantity, CostUSD, Type) 
                                          VALUES (@ActivityDate, @Action, @Description, @Frequency, @Location, 
                                          @TimeOfEngagement, @EmployeesEnvolved, @HoursInvested, @PeopleImpacted, 
                                          @Quantity, @CostUSD, @Type);
                                          SELECT SCOPE_IDENTITY();"

                    Dim newRecordID As Integer
                    Using cmd As New SqlCommand(query, conn, transaction)
                        AddParameters(cmd)
                        newRecordID = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using

                    ' Insert photos (only store photo names)
                    For Each photoName In tempPhotoNames
                        Dim insertPhotoQuery As String = "INSERT INTO tbl_ESG_CSR_Photos (RecordID, PhotoName, OriginalFileName, FileSize, IsPrimary) 
                                                         VALUES (@RecordID, @PhotoName, @OriginalFileName, @FileSize, @IsPrimary)"
                        Using photoCmd As New SqlCommand(insertPhotoQuery, conn, transaction)
                            photoCmd.Parameters.AddWithValue("@RecordID", newRecordID)
                            photoCmd.Parameters.AddWithValue("@PhotoName", photoName)
                            photoCmd.Parameters.AddWithValue("@OriginalFileName", photoName.Substring(photoName.IndexOf("_") + 1))
                            Dim fullPath = Path.Combine(photoStoragePath, photoName)
                            photoCmd.Parameters.AddWithValue("@FileSize", New FileInfo(fullPath).Length)
                            photoCmd.Parameters.AddWithValue("@IsPrimary", False)
                            photoCmd.ExecuteNonQuery()
                        End Using
                    Next

                    transaction.Commit()

                    MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadData()
                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record from the grid to update", "No Selection",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentRecordID = -1 Then
            MessageBox.Show("Please load a record first using 'Load Selected' button", "Warning",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not ValidateInputs() Then Return

        If MessageBox.Show("Are you sure you want to update this record?", "Confirm Update",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim photoStoragePath As String = GetPhotoStoragePath()

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    ' Update main record
                    Dim query As String = "UPDATE tbl_ESG_CSR SET ActivityDate = @ActivityDate, Action = @Action, 
                                          Description = @Description, Frequency = @Frequency, Location = @Location, 
                                          TimeOfEngagement = @TimeOfEngagement, EmployeesEnvolved = @EmployeesEnvolved, 
                                          HoursInvested = @HoursInvested, PeopleImpacted = @PeopleImpacted, 
                                          Quantity = @Quantity, CostUSD = @CostUSD, Type = @Type 
                                          WHERE RecordID = @RecordID"

                    Using cmd As New SqlCommand(query, conn, transaction)
                        AddParameters(cmd)
                        cmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Insert new photos
                    For Each photoName In tempPhotoNames
                        Dim insertPhotoQuery As String = "INSERT INTO tbl_ESG_CSR_Photos (RecordID, PhotoName, OriginalFileName, FileSize, IsPrimary) 
                                                         VALUES (@RecordID, @PhotoName, @OriginalFileName, @FileSize, @IsPrimary)"
                        Using photoCmd As New SqlCommand(insertPhotoQuery, conn, transaction)
                            photoCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                            photoCmd.Parameters.AddWithValue("@PhotoName", photoName)
                            photoCmd.Parameters.AddWithValue("@OriginalFileName", photoName.Substring(photoName.IndexOf("_") + 1))
                            Dim fullPath = Path.Combine(photoStoragePath, photoName)
                            photoCmd.Parameters.AddWithValue("@FileSize", New FileInfo(fullPath).Length)
                            photoCmd.Parameters.AddWithValue("@IsPrimary", False)
                            photoCmd.ExecuteNonQuery()
                        End Using
                    Next

                    transaction.Commit()

                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadData()
                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record from the grid to delete", "No Selection",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the RecordID directly from the selected row instead of relying on currentRecordID
        Dim selectedRow = dgvData.SelectedRows(0)
        Dim recordIDToDelete As Integer = Convert.ToInt32(selectedRow.Cells("RecordID").Value)

        If MessageBox.Show("Are you sure you want to delete this record and all associated photos?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim photoStoragePath As String = GetPhotoStoragePath()

            Try
                ' First, clear any preview images to release file locks
                ClearPreviewImage()

                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim transaction = conn.BeginTransaction()

                    Try
                        ' Get all photo names to delete files
                        Dim getPhotosQuery As String = "SELECT PhotoName FROM tbl_ESG_CSR_Photos WHERE RecordID = @RecordID"
                        Dim photoNamesToDelete As New List(Of String)

                        Using getCmd As New SqlCommand(getPhotosQuery, conn, transaction)
                            getCmd.Parameters.AddWithValue("@RecordID", recordIDToDelete)
                            Dim reader = getCmd.ExecuteReader()

                            While reader.Read()
                                photoNamesToDelete.Add(reader("PhotoName").ToString())
                            End While
                            reader.Close()
                        End Using

                        ' Force garbage collection to release any pending file handles
                        GC.Collect()
                        GC.WaitForPendingFinalizers()

                        ' Delete physical files with retry logic
                        For Each photoName In photoNamesToDelete
                            Dim fullPath = Path.Combine(photoStoragePath, photoName)
                            If File.Exists(fullPath) Then
                                Dim retryCount = 0
                                Dim deleted = False
                                While retryCount < 3 AndAlso Not deleted
                                    Try
                                        File.Delete(fullPath)
                                        deleted = True
                                    Catch ex As IOException
                                        retryCount += 1
                                        If retryCount = 3 Then
                                            Throw
                                        End If
                                        System.Threading.Thread.Sleep(100) ' Wait 100ms before retry
                                    End Try
                                End While
                            End If
                        Next

                        ' Delete record (photos will be deleted automatically due to CASCADE)
                        Dim deleteQuery As String = "DELETE FROM tbl_ESG_CSR WHERE RecordID = @RecordID"
                        Using delCmd As New SqlCommand(deleteQuery, conn, transaction)
                            delCmd.Parameters.AddWithValue("@RecordID", recordIDToDelete)
                            delCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form and refresh data
                        ClearForm()
                        LoadData()

                        ' Clear selection in DataGridView
                        dgvData.ClearSelection()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ClearForm()
        LoadData()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadData(dtpStartDate.Value.Date, dtpEndDate.Value.Date)
        ClearForm()
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        dtpStartDate.Value = DateTimePicker.MinimumDateTime
        dtpEndDate.Value = DateTime.Now
        LoadData()
        ClearForm()
    End Sub

    Private Sub btnLoadSelected_Click(sender As Object, e As EventArgs) Handles btnLoadSelected.Click
        If dgvData.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record from the grid to load", "No Selection",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow = dgvData.SelectedRows(0)
        currentRecordID = Convert.ToInt32(selectedRow.Cells("RecordID").Value)

        ' Populate textboxes with selected data
        dtpActivityDate.Value = Convert.ToDateTime(selectedRow.Cells("ActivityDate").Value)
        txtAction.Text = selectedRow.Cells("Action").Value?.ToString()
        txtDescription.Text = selectedRow.Cells("Description").Value?.ToString()
        cboFrequency.Text = selectedRow.Cells("Frequency").Value?.ToString()
        txtLocation.Text = selectedRow.Cells("Location").Value?.ToString()
        txtTimeEngagement.Text = selectedRow.Cells("TimeOfEngagement").Value?.ToString()
        txtEmployeesEnvolved.Value = Convert.ToDecimal(selectedRow.Cells("EmployeesEnvolved").Value)
        txtHoursInvested.Value = Convert.ToDecimal(selectedRow.Cells("HoursInvested").Value)
        txtPeopleImpacted.Value = Convert.ToDecimal(selectedRow.Cells("PeopleImpacted").Value)
        txtQuantity.Value = Convert.ToDecimal(selectedRow.Cells("Quantity").Value)
        txtCostUSD.Value = Convert.ToDecimal(selectedRow.Cells("CostUSD").Value)
        cboType.Text = selectedRow.Cells("Type").Value?.ToString()

        ' Load photos for this record
        LoadPhotos(currentRecordID)
        tempPhotoNames.Clear()

        MessageBox.Show("Record loaded successfully! You can now update or delete it.", "Record Loaded",
                      MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUploadPhotos_Click(sender As Object, e As EventArgs) Handles btnUploadPhotos.Click
        Dim photoStoragePath As String = GetPhotoStoragePath()

        If currentRecordID = -1 Then
            ' For new record, upload photos to temp list
            OpenFileDialog1.Multiselect = True
            OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            OpenFileDialog1.Title = "Select Photos to Upload"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                ' Create photos directory if not exists
                If Not Directory.Exists(photoStoragePath) Then
                    Directory.CreateDirectory(photoStoragePath)
                End If

                For Each file In OpenFileDialog1.FileNames
                    Dim originalFileName = Path.GetFileName(file)
                    Dim uniqueFileName = $"{DateTime.Now.Ticks}_{originalFileName}"
                    Dim destPath = Path.Combine(photoStoragePath, uniqueFileName)
                    IO.File.Copy(file, destPath)
                    tempPhotoNames.Add(uniqueFileName)
                Next

                ' Show temporary photos in listview
                DisplayTempPhotos()
                lblPhotoCount.Text = $"{tempPhotoNames.Count} new photo(s) ready to upload"
            End If
        ElseIf currentRecordID <> -1 Then
            ' For existing record, upload photos directly to server and database
            OpenFileDialog1.Multiselect = True
            OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            OpenFileDialog1.Title = "Select Photos to Upload"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                If Not Directory.Exists(photoStoragePath) Then
                    Directory.CreateDirectory(photoStoragePath)
                End If

                Dim uploadedCount = 0
                For Each file In OpenFileDialog1.FileNames
                    Dim originalFileName = Path.GetFileName(file)
                    Dim uniqueFileName = $"{DateTime.Now.Ticks}_{originalFileName}"
                    Dim destPath = Path.Combine(photoStoragePath, uniqueFileName)
                    IO.File.Copy(file, destPath)

                    ' Save photo info to database
                    Using conn As SqlConnection = GetConnection()
                        conn.Open()
                        Dim insertQuery As String = "INSERT INTO tbl_ESG_CSR_Photos (RecordID, PhotoName, OriginalFileName, FileSize, IsPrimary) 
                                                    VALUES (@RecordID, @PhotoName, @OriginalFileName, @FileSize, @IsPrimary)"
                        Using cmd As New SqlCommand(insertQuery, conn)
                            cmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                            cmd.Parameters.AddWithValue("@PhotoName", uniqueFileName)
                            cmd.Parameters.AddWithValue("@OriginalFileName", originalFileName)
                            cmd.Parameters.AddWithValue("@FileSize", New FileInfo(destPath).Length)
                            cmd.Parameters.AddWithValue("@IsPrimary", False)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    uploadedCount += 1
                Next

                MessageBox.Show($"{uploadedCount} photo(s) uploaded successfully to {photoStoragePath}!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadPhotos(currentRecordID)
            End If
        End If
    End Sub

    Private Sub DisplayTempPhotos()
        lvwPhotos.Items.Clear()
        For Each photoName In tempPhotoNames
            Dim originalName = photoName.Substring(photoName.IndexOf("_") + 1)
            Dim item As New ListViewItem(photoName)
            item.SubItems.Add("No") ' Not primary yet
            item.SubItems.Add("Pending")
            item.SubItems.Add(originalName)
            item.Tag = New PhotoInfo() With {
                .PhotoName = photoName,
                .OriginalFileName = originalName,
                .IsPrimary = False
            }
            lvwPhotos.Items.Add(item)
        Next
    End Sub

    Private Sub btnDeletePhoto_Click(sender As Object, e As EventArgs) Handles btnDeletePhoto.Click
        If lvwPhotos.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a photo to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedItem = lvwPhotos.SelectedItems(0)
        Dim photoInfo = DirectCast(selectedItem.Tag, PhotoInfo)
        Dim photoStoragePath As String = GetPhotoStoragePath()

        If MessageBox.Show("Are you sure you want to delete this photo?", "Confirm Delete",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Clear preview if this photo is currently being viewed
            ClearPreviewImage()

            If currentRecordID = -1 Then
                ' Delete from temp list
                tempPhotoNames.Remove(photoInfo.PhotoName)
                Dim fullPath = Path.Combine(photoStoragePath, photoInfo.PhotoName)
                If File.Exists(fullPath) Then
                    Try
                        File.Delete(fullPath)
                    Catch ex As IOException
                        ' Force garbage collection and retry
                        GC.Collect()
                        GC.WaitForPendingFinalizers()
                        File.Delete(fullPath)
                    End Try
                End If
                lvwPhotos.Items.Remove(selectedItem)
                lblPhotoCount.Text = $"{tempPhotoNames.Count} new photo(s) ready to upload"
            Else
                ' Delete from database
                Try
                    Using conn As SqlConnection = GetConnection()
                        conn.Open()
                        Dim deleteQuery As String = "DELETE FROM tbl_ESG_CSR_Photos WHERE PhotoID = @PhotoID"
                        Using cmd As New SqlCommand(deleteQuery, conn)
                            cmd.Parameters.AddWithValue("@PhotoID", photoInfo.PhotoID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Delete physical file
                    Dim fullPath = Path.Combine(photoStoragePath, photoInfo.PhotoName)
                    If File.Exists(fullPath) Then
                        Try
                            File.Delete(fullPath)
                        Catch ex As IOException
                            GC.Collect()
                            GC.WaitForPendingFinalizers()
                            File.Delete(fullPath)
                        End Try
                    End If

                    MessageBox.Show("Photo deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPhotos(currentRecordID)
                Catch ex As Exception
                    MessageBox.Show("Error deleting photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnViewPhoto_Click(sender As Object, e As EventArgs) Handles btnViewPhoto.Click
        If lvwPhotos.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a photo to view", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Clear existing preview image
        ClearPreviewImage()

        Dim selectedItem = lvwPhotos.SelectedItems(0)
        Dim photoInfo = DirectCast(selectedItem.Tag, PhotoInfo)
        Dim photoStoragePath As String = GetPhotoStoragePath()
        Dim fullPath = Path.Combine(photoStoragePath, photoInfo.PhotoName)

        If File.Exists(fullPath) Then
            Try
                ' Load image in a using block to ensure proper disposal
                Using fs As New FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.Read)
                    currentPreviewImage = Image.FromStream(fs)
                    pbPhotoPreview.Image = currentPreviewImage.Clone() ' Create a copy for display
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show($"Photo file not found at: {fullPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnSetPrimary_Click(sender As Object, e As EventArgs) Handles btnSetPrimary.Click
        If lvwPhotos.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a photo to set as primary", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If currentRecordID = -1 Then
            MessageBox.Show("Please save the record first before setting primary photo", "Information",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim selectedItem = lvwPhotos.SelectedItems(0)
        Dim photoInfo = DirectCast(selectedItem.Tag, PhotoInfo)

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    ' Reset all photos for this record to non-primary
                    Dim resetQuery As String = "UPDATE tbl_ESG_CSR_Photos SET IsPrimary = 0 WHERE RecordID = @RecordID"
                    Using resetCmd As New SqlCommand(resetQuery, conn, transaction)
                        resetCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        resetCmd.ExecuteNonQuery()
                    End Using

                    ' Set selected photo as primary
                    Dim setPrimaryQuery As String = "UPDATE tbl_ESG_CSR_Photos SET IsPrimary = 1 WHERE PhotoID = @PhotoID"
                    Using primaryCmd As New SqlCommand(setPrimaryQuery, conn, transaction)
                        primaryCmd.Parameters.AddWithValue("@PhotoID", photoInfo.PhotoID)
                        primaryCmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit()

                    MessageBox.Show("Primary photo updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadPhotos(currentRecordID)
                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error setting primary photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvData.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Use the ExportToExcel function from ModShared
        ExportToExcel(dgvData, "ESG_CSR_Data")
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        ClearForm()
    End Sub

    Private Sub AddParameters(cmd As SqlCommand)
        cmd.Parameters.AddWithValue("@ActivityDate", dtpActivityDate.Value.Date)
        cmd.Parameters.AddWithValue("@Action", txtAction.Text)
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
        cmd.Parameters.AddWithValue("@Frequency", If(cboFrequency.SelectedItem Is Nothing, DBNull.Value, CObj(cboFrequency.SelectedItem.ToString())))
        cmd.Parameters.AddWithValue("@Location", txtLocation.Text)
        cmd.Parameters.AddWithValue("@TimeOfEngagement", txtTimeEngagement.Text)
        cmd.Parameters.AddWithValue("@EmployeesEnvolved", txtEmployeesEnvolved.Value)
        cmd.Parameters.AddWithValue("@HoursInvested", txtHoursInvested.Value)
        cmd.Parameters.AddWithValue("@PeopleImpacted", txtPeopleImpacted.Value)
        cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Value)
        cmd.Parameters.AddWithValue("@CostUSD", txtCostUSD.Value)
        cmd.Parameters.AddWithValue("@Type", cboType.Text)
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtAction.Text) Then
            MessageBox.Show("Action is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAction.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cboType.Text) Then
            MessageBox.Show("Type is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboType.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub ClearForm()
        currentRecordID = -1
        dtpActivityDate.Value = DateTime.Now
        txtAction.Clear()
        txtDescription.Clear()
        cboFrequency.SelectedIndex = -1
        txtLocation.Clear()
        txtTimeEngagement.Clear()
        txtEmployeesEnvolved.Value = 0
        txtHoursInvested.Value = 0
        txtPeopleImpacted.Value = 0
        txtQuantity.Value = 0
        txtCostUSD.Value = 0
        cboType.SelectedIndex = -1
        tempPhotoNames.Clear()
        lvwPhotos.Items.Clear()
        lblPhotoCount.Text = "No photos yet"
        ClearPreviewImage()
    End Sub

    ' Helper class for photo information
    Private Class PhotoInfo
        Public Property PhotoID As Integer
        Public Property PhotoName As String
        Public Property OriginalFileName As String
        Public Property IsPrimary As Boolean
    End Class

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        ' Clean up resources when form closes
        ClearPreviewImage()
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub
End Class