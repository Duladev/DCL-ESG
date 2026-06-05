Imports System.Data.SqlClient
Imports System.IO

Public Class frmElectricity
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmElectricity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupForm(Me)

        ' Configure DateTimePickers
        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        ' Set default values
        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now

        ' Configure ComboBoxes
        cmbRenewableSource.Items.AddRange(New String() {"Solar", "Wind Power", "Hydropower", "Geothermal", "Biomass Energy", "Wave Energy", "Green Hydrogen", "Tidal Energy"})
        cmbNonRenewableSource.Items.AddRange(New String() {"Coal", "Natural Gas", "Oil", "Nuclear Energy", "Diesel", "Peat", "Shale Gas and Oil", "Tar Sand"})
        cmbPurchaseType.Items.AddRange(New String() {"Main Purchase", "Additional Purchase", "Out-Source Purchase"})
        cmbPurchaseType.SelectedIndex = 0

        ' Setup filters
        SetupFilters()

        ' Add keypress handlers
        AddKeyPressHandlers(Me.Controls)

        LoadDataGridView()
    End Sub

    Private Sub SetupFilters()
        ' Load years for filter
        For year As Integer = 2020 To DateTime.Now.Year + 1
            cmbYearFilter.Items.Add(year)
        Next
        cmbYearFilter.SelectedItem = DateTime.Now.Year

        ' Load months for filter
        For month As Integer = 1 To 12
            cmbMonthFilter.Items.Add(New DateTime(2000, month, 1).ToString("MMMM"))
        Next
        cmbMonthFilter.SelectedIndex = DateTime.Now.Month - 1
    End Sub

    Private Sub cmbPurchaseType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurchaseType.SelectedIndexChanged
        Dim isOutSource As Boolean = (cmbPurchaseType.Text = "Out-Source Purchase")
        grpOutSource.Visible = isOutSource
        grpMainAdditional.Visible = Not isOutSource
    End Sub

    Private Sub btnUploadBill_Click(sender As Object, e As EventArgs) Handles btnUploadBill.Click
        Using ofd As New OpenFileDialog()
            ofd.Multiselect = True
            ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png|All Files|*.*"
            ofd.Title = "Select Bill Documents"

            If ofd.ShowDialog() = DialogResult.OK Then
                currentFiles.Clear()
                For Each file As String In ofd.FileNames
                    currentFiles.Add(file)
                Next
                lblFileCount.Text = $"{currentFiles.Count} file(s) selected"
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim year As Integer = dtpYear.Value.Year
                Dim month As Integer = dtpMonth.Value.Month
                Dim purchaseType As String = cmbPurchaseType.Text
                Dim recordId = $"{purchaseType}_{year}_{month}_{DateTime.Now.Ticks}"
                Dim filesPath = SaveMultipleFiles(currentFiles, recordId, "Electricity")

                Dim sql As String = ""

                If purchaseType = "Out-Source Purchase" Then
                    sql = "INSERT INTO tbl_ESG_ElectricityPurchase (PurchaseType, Year, Month, RenewableSourceType, RenewableCapacity, NonRenewableSourceType, NonRenewableCapacity, BillFilesPath) VALUES (@PurchaseType, @Year, @Month, @RenewableSource, @RenewableCap, @NonRenewableSource, @NonRenewableCap, @BillFiles)"
                Else
                    sql = "INSERT INTO tbl_ESG_ElectricityPurchase (PurchaseType, Year, Month, PeakTimeQty, NormalTimeQty, OffPeakTimeQty, PeakTimeAmount, NormalTimeAmount, OffPeakTimeAmount, BillFilesPath) VALUES (@PurchaseType, @Year, @Month, @PeakQty, @NormalQty, @OffPeakQty, @PeakAmount, @NormalAmount, @OffPeakAmount, @BillFiles)"
                End If

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PurchaseType", purchaseType)
                    cmd.Parameters.AddWithValue("@Year", year)
                    cmd.Parameters.AddWithValue("@Month", month)
                    cmd.Parameters.AddWithValue("@BillFiles", If(String.IsNullOrEmpty(filesPath), DBNull.Value, filesPath))

                    If purchaseType = "Out-Source Purchase" Then
                        cmd.Parameters.AddWithValue("@RenewableSource", cmbRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@RenewableCap", GetSafeDecimal(txtRenewableCap.Text))
                        cmd.Parameters.AddWithValue("@NonRenewableSource", cmbNonRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@NonRenewableCap", GetSafeDecimal(txtNonRenewableCap.Text))
                    Else
                        cmd.Parameters.AddWithValue("@PeakQty", GetSafeDecimal(txtPeakQty.Text))
                        cmd.Parameters.AddWithValue("@NormalQty", GetSafeDecimal(txtNormalQty.Text))
                        cmd.Parameters.AddWithValue("@OffPeakQty", GetSafeDecimal(txtOffPeakQty.Text))
                        cmd.Parameters.AddWithValue("@PeakAmount", GetSafeDecimal(txtPeakAmount.Text))
                        cmd.Parameters.AddWithValue("@NormalAmount", GetSafeDecimal(txtNormalAmount.Text))
                        cmd.Parameters.AddWithValue("@OffPeakAmount", GetSafeDecimal(txtOffPeakAmount.Text))
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadDataGridView()
                currentFiles.Clear()
                lblFileCount.Text = "No files selected"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If cmbPurchaseType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a purchase type", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Function GetSafeDecimal(inputText As String) As Decimal
        Dim result As Decimal = 0
        If Decimal.TryParse(inputText, result) Then
            Return result
        End If
        Return 0
    End Function

    Private Sub LoadDataGridView()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, PurchaseType, Year, Month, PeakTimeQty, NormalTimeQty, OffPeakTimeQty, PeakTimeAmount, NormalTimeAmount, OffPeakTimeAmount, RenewableSourceType, RenewableCapacity, NonRenewableSourceType, NonRenewableCapacity, BillFilesPath FROM tbl_ESG_ElectricityPurchase ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Apply filters
                Dim dv As New DataView(dt)
                If cmbYearFilter.SelectedItem IsNot Nothing Then
                    dv.RowFilter = $"Year = {cmbYearFilter.SelectedItem}"
                End If
                If cmbMonthFilter.SelectedIndex >= 0 Then
                    Dim monthNum As Integer = cmbMonthFilter.SelectedIndex + 1
                    dv.RowFilter = If(String.IsNullOrEmpty(dv.RowFilter), $"Month = {monthNum}", $"{dv.RowFilter} AND Month = {monthNum}")
                End If

                grdData.DataSource = dv

                ' Add view files link column if not exists
                If Not grdData.Columns.Contains("ViewFiles") Then
                    Dim linkColumn As New DataGridViewLinkColumn()
                    linkColumn.Name = "ViewFiles"
                    linkColumn.HeaderText = "View Bills"
                    linkColumn.Text = "View Files"
                    linkColumn.UseColumnTextForLinkValue = True
                    grdData.Columns.Add(linkColumn)
                End If

                If grdData.Columns.Contains("BillFilesPath") Then
                    grdData.Columns("BillFilesPath").Visible = False
                End If

                ' Clear selection
                grdData.ClearSelection()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grdData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso grdData.Columns(e.ColumnIndex).Name = "ViewFiles" Then
                ViewFiles(e.RowIndex)
            Else
                LoadDataToForm(e.RowIndex)
            End If
        End If
    End Sub

    'Private Sub ViewFiles(rowIndex As Integer)
    '    Dim filesPath As String = grdData.Rows(rowIndex).Cells("BillFilesPath").Value?.ToString()
    '    If Not String.IsNullOrEmpty(filesPath) Then
    '        Dim files = GetFilesFromPath(filesPath)
    '        If files.Count > 0 Then
    '            For Each file As String In files
    '                If System.IO.File.Exists(file) Then
    '                    System.Diagnostics.Process.Start(file)
    '                Else
    '                    MessageBox.Show($"File not found: {file}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                End If
    '            Next
    '        Else
    '            MessageBox.Show("No files available for this record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        MessageBox.Show("No files uploaded for this record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'view file testmethod
    Private Sub ViewFiles(rowIndex As Integer)
        Dim filesPath As String = grdData.Rows(rowIndex).Cells("BillFilesPath").Value?.ToString()
        If Not String.IsNullOrEmpty(filesPath) Then
            Dim files = GetFilesFromPath(filesPath)
            If files.Count > 0 Then
                For Each file As String In files
                    If System.IO.File.Exists(file) Then
                        Try
                            ' Use Process.Start with proper error handling
                            Dim psi As New ProcessStartInfo()
                            psi.FileName = file
                            psi.UseShellExecute = True
                            Process.Start(psi)
                        Catch ex As Exception
                            MessageBox.Show($"Error opening file '{Path.GetFileName(file)}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show($"File not found: {file}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
            Else
                MessageBox.Show("No files available for this record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No files uploaded for this record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'end vew file test method

    Private Sub LoadDataToForm(rowIndex As Integer)
        Dim row As DataGridViewRow = grdData.Rows(rowIndex)
        currentEditID = Convert.ToInt32(row.Cells("ID").Value)

        cmbPurchaseType.Text = row.Cells("PurchaseType").Value.ToString()
        dtpYear.Value = New Date(Convert.ToInt32(row.Cells("Year").Value), 1, 1)
        dtpMonth.Value = New Date(DateTime.Now.Year, Convert.ToInt32(row.Cells("Month").Value), 1)

        If cmbPurchaseType.Text = "Out-Source Purchase" Then
            cmbRenewableSource.Text = row.Cells("RenewableSourceType").Value?.ToString()
            txtRenewableCap.Text = row.Cells("RenewableCapacity").Value?.ToString()
            cmbNonRenewableSource.Text = row.Cells("NonRenewableSourceType").Value?.ToString()
            txtNonRenewableCap.Text = row.Cells("NonRenewableCapacity").Value?.ToString()
        Else
            txtPeakQty.Text = If(row.Cells("PeakTimeQty").Value Is DBNull.Value, "", row.Cells("PeakTimeQty").Value.ToString())
            txtNormalQty.Text = If(row.Cells("NormalTimeQty").Value Is DBNull.Value, "", row.Cells("NormalTimeQty").Value.ToString())
            txtOffPeakQty.Text = If(row.Cells("OffPeakTimeQty").Value Is DBNull.Value, "", row.Cells("OffPeakTimeQty").Value.ToString())
            txtPeakAmount.Text = If(row.Cells("PeakTimeAmount").Value Is DBNull.Value, "", row.Cells("PeakTimeAmount").Value.ToString())
            txtNormalAmount.Text = If(row.Cells("NormalTimeAmount").Value Is DBNull.Value, "", row.Cells("NormalTimeAmount").Value.ToString())
            txtOffPeakAmount.Text = If(row.Cells("OffPeakTimeAmount").Value Is DBNull.Value, "", row.Cells("OffPeakTimeAmount").Value.ToString())
        End If

        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentEditID = -1 Then
            MessageBox.Show("Please select a record to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim sql As String

                If cmbPurchaseType.Text = "Out-Source Purchase" Then
                    sql = "UPDATE tbl_ESG_ElectricityPurchase SET PurchaseType=@PurchaseType, Year=@Year, Month=@Month, RenewableSourceType=@RenewableSource, RenewableCapacity=@RenewableCap, NonRenewableSourceType=@NonRenewableSource, NonRenewableCapacity=@NonRenewableCap, UpdatedDate=GETDATE() WHERE ID=@ID"
                Else
                    sql = "UPDATE tbl_ESG_ElectricityPurchase SET PurchaseType=@PurchaseType, Year=@Year, Month=@Month, PeakTimeQty=@PeakQty, NormalTimeQty=@NormalQty, OffPeakTimeQty=@OffPeakQty, PeakTimeAmount=@PeakAmount, NormalTimeAmount=@NormalAmount, OffPeakTimeAmount=@OffPeakAmount, UpdatedDate=GETDATE() WHERE ID=@ID"
                End If

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentEditID)
                    cmd.Parameters.AddWithValue("@PurchaseType", cmbPurchaseType.Text)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)

                    If cmbPurchaseType.Text = "Out-Source Purchase" Then
                        cmd.Parameters.AddWithValue("@RenewableSource", cmbRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@RenewableCap", GetSafeDecimal(txtRenewableCap.Text))
                        cmd.Parameters.AddWithValue("@NonRenewableSource", cmbNonRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@NonRenewableCap", GetSafeDecimal(txtNonRenewableCap.Text))
                    Else
                        cmd.Parameters.AddWithValue("@PeakQty", GetSafeDecimal(txtPeakQty.Text))
                        cmd.Parameters.AddWithValue("@NormalQty", GetSafeDecimal(txtNormalQty.Text))
                        cmd.Parameters.AddWithValue("@OffPeakQty", GetSafeDecimal(txtOffPeakQty.Text))
                        cmd.Parameters.AddWithValue("@PeakAmount", GetSafeDecimal(txtPeakAmount.Text))
                        cmd.Parameters.AddWithValue("@NormalAmount", GetSafeDecimal(txtNormalAmount.Text))
                        cmd.Parameters.AddWithValue("@OffPeakAmount", GetSafeDecimal(txtOffPeakAmount.Text))
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadDataGridView()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentEditID = -1 Then
            MessageBox.Show("Please select a record to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_ESG_ElectricityPurchase WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadDataGridView()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDataGridView()
        ClearForm()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        For Each f As Form In Application.OpenForms
            If f.Name = "frmMain" Then
                f.Close()
            End If
        Next
        Dim dashboard As New frmDashboard()
        dashboard.Show()
        'Me.Close()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToExcel(grdData, "Electricity_Data")
    End Sub

    Private Sub ClearForm()
        currentEditID = -1
        txtPeakQty.Clear()
        txtNormalQty.Clear()
        txtOffPeakQty.Clear()
        txtPeakAmount.Clear()
        txtNormalAmount.Clear()
        txtOffPeakAmount.Clear()
        txtRenewableCap.Clear()
        txtNonRenewableCap.Clear()
        currentFiles.Clear()
        lblFileCount.Text = "No files selected"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        grdData.ClearSelection()
    End Sub

    Private Sub ApplyFilters(sender As Object, e As EventArgs) Handles cmbYearFilter.SelectedIndexChanged, cmbMonthFilter.SelectedIndexChanged
        LoadDataGridView()
    End Sub
End Class