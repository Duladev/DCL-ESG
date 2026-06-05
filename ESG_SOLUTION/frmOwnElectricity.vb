Imports System.Data.SqlClient
Imports System.IO

Public Class frmOwnElectricity
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmOwnElectricity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupForm(Me)

        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now

        cmbRenewableType.Items.AddRange(New String() {"Solar", "Wind Power", "Hydropower", "Geothermal", "Biomass Energy", "Wave Energy", "Green Hydrogen", "Tidal Energy"})
        cmbNonRenewableType.Items.AddRange(New String() {"Coal", "Natural Gas", "Oil", "Nuclear Energy", "Diesel", "Peat", "Shale Gas and Oil", "Tar Sand"})

        AddHandler txtRenewableCap.TextChanged, AddressOf CalculateSoldCapacity
        AddHandler txtNonRenewableCap.TextChanged, AddressOf CalculateSoldCapacity
        AddHandler txtTotalConsumed.TextChanged, AddressOf CalculateSoldCapacity

        SetupFilters()
        AddKeyPressHandlers(Me.Controls)
        LoadDataGridView()
    End Sub

    Private Sub SetupFilters()
        For year As Integer = 2020 To DateTime.Now.Year + 1
            cmbYearFilter.Items.Add(year)
        Next
        cmbYearFilter.SelectedItem = DateTime.Now.Year

        For month As Integer = 1 To 12
            cmbMonthFilter.Items.Add(New DateTime(2000, month, 1).ToString("MMMM"))
        Next
        cmbMonthFilter.SelectedIndex = DateTime.Now.Month - 1
    End Sub

    'added'
    Private Function GetSafeDecimal(inputText As String) As Decimal
        Dim result As Decimal = 0
        If Decimal.TryParse(inputText, result) Then
            Return result
        End If
        Return 0
    End Function
    Private Sub CalculateSoldCapacity(sender As Object, e As EventArgs)
        Try
            Dim renewable As Decimal = GetSafeDecimal(txtRenewableCap.Text)
            Dim nonRenewable As Decimal = GetSafeDecimal(txtNonRenewableCap.Text)
            Dim consumed As Decimal = GetSafeDecimal(txtTotalConsumed.Text)

            Dim sold As Decimal = (renewable + nonRenewable) - consumed
            txtSoldCapacity.Text = If(sold < 0, 0, sold).ToString("N2")
        Catch ex As Exception
        End Try
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
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "INSERT INTO tbl_ESG_OwnElectricity (Year, Month, RenewableType, RenewableCapacity, NonRenewableType, NonRenewableCapacity, TotalConsumedCapacity, SoldCapacity, Comments, BillFilesPath) VALUES (@Year, @Month, @RenewableType, @RenewableCap, @NonRenewableType, @NonRenewableCap, @TotalConsumed, @SoldCapacity, @Comments, @BillFiles)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@RenewableType", cmbRenewableType.Text)
                    cmd.Parameters.AddWithValue("@RenewableCap", GetSafeDecimal(txtRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@NonRenewableType", cmbNonRenewableType.Text)
                    cmd.Parameters.AddWithValue("@NonRenewableCap", GetSafeDecimal(txtNonRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@TotalConsumed", GetSafeDecimal(txtTotalConsumed.Text))
                    cmd.Parameters.AddWithValue("@SoldCapacity", GetSafeDecimal(txtSoldCapacity.Text))
                    cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

                    Dim recordId = $"OwnElec_{dtpYear.Value.Year}_{dtpMonth.Value.Month}_{DateTime.Now.Ticks}"
                    Dim filesPath = SaveMultipleFiles(currentFiles, recordId, "OwnElectricity")
                    cmd.Parameters.AddWithValue("@BillFiles", If(String.IsNullOrEmpty(filesPath), DBNull.Value, filesPath))

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

    Private Sub LoadDataGridView()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, Year, Month, RenewableType, RenewableCapacity, NonRenewableType, NonRenewableCapacity, TotalConsumedCapacity, SoldCapacity, Comments, BillFilesPath FROM tbl_ESG_OwnElectricity ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim dv As New DataView(dt)
                If cmbYearFilter.SelectedItem IsNot Nothing Then
                    dv.RowFilter = $"Year = {cmbYearFilter.SelectedItem}"
                End If
                If cmbMonthFilter.SelectedIndex >= 0 Then
                    Dim monthNum As Integer = cmbMonthFilter.SelectedIndex + 1
                    dv.RowFilter = If(String.IsNullOrEmpty(dv.RowFilter), $"Month = {monthNum}", $"{dv.RowFilter} AND Month = {monthNum}")
                End If

                grdData.DataSource = dv

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

    'view file fixed method
    Private Sub ViewFiles(rowIndex As Integer)
        Dim filesPath As String = grdData.Rows(rowIndex).Cells("BillFilesPath").Value?.ToString()
        If Not String.IsNullOrEmpty(filesPath) Then
            Dim files = GetFilesFromPath(filesPath)
            If files.Count > 0 Then
                For Each file As String In files
                    If System.IO.File.Exists(file) Then
                        Try
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

    Private Sub LoadDataToForm(rowIndex As Integer)
        Dim row As DataGridViewRow = grdData.Rows(rowIndex)
        currentEditID = Convert.ToInt32(row.Cells("ID").Value)

        dtpYear.Value = New Date(Convert.ToInt32(row.Cells("Year").Value), 1, 1)
        dtpMonth.Value = New Date(DateTime.Now.Year, Convert.ToInt32(row.Cells("Month").Value), 1)
        cmbRenewableType.Text = row.Cells("RenewableType").Value.ToString()
        txtRenewableCap.Text = row.Cells("RenewableCapacity").Value.ToString()
        cmbNonRenewableType.Text = row.Cells("NonRenewableType").Value.ToString()
        txtNonRenewableCap.Text = row.Cells("NonRenewableCapacity").Value.ToString()
        txtTotalConsumed.Text = row.Cells("TotalConsumedCapacity").Value.ToString()
        txtSoldCapacity.Text = row.Cells("SoldCapacity").Value.ToString()
        txtComments.Text = If(row.Cells("Comments").Value Is DBNull.Value, "", row.Cells("Comments").Value.ToString())

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
                Dim sql As String = "UPDATE tbl_ESG_OwnElectricity SET Year=@Year, Month=@Month, RenewableType=@RenewableType, RenewableCapacity=@RenewableCap, NonRenewableType=@NonRenewableType, NonRenewableCapacity=@NonRenewableCap, TotalConsumedCapacity=@TotalConsumed, SoldCapacity=@SoldCapacity, Comments=@Comments, UpdatedDate=GETDATE() WHERE ID=@ID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentEditID)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@RenewableType", cmbRenewableType.Text)
                    cmd.Parameters.AddWithValue("@RenewableCap", GetSafeDecimal(txtRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@NonRenewableType", cmbNonRenewableType.Text)
                    cmd.Parameters.AddWithValue("@NonRenewableCap", GetSafeDecimal(txtNonRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@TotalConsumed", GetSafeDecimal(txtTotalConsumed.Text))
                    cmd.Parameters.AddWithValue("@SoldCapacity", GetSafeDecimal(txtSoldCapacity.Text))
                    cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

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
                    Dim sql As String = "DELETE FROM tbl_ESG_OwnElectricity WHERE ID=@ID"

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
        Dim dashboard As New frmDashboard()
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToExcel(grdData, "Own_Electricity_Data")
    End Sub

    Private Sub ApplyFilters(sender As Object, e As EventArgs) Handles cmbYearFilter.SelectedIndexChanged, cmbMonthFilter.SelectedIndexChanged
        LoadDataGridView()
    End Sub

    Private Sub ClearForm()
        currentEditID = -1
        txtRenewableCap.Clear()
        txtNonRenewableCap.Clear()
        txtTotalConsumed.Clear()
        txtSoldCapacity.Clear()
        txtComments.Clear()
        currentFiles.Clear()
        lblFileCount.Text = "No files selected"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        grdData.ClearSelection()
    End Sub
End Class