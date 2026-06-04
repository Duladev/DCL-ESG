Imports System.Data.SqlClient
Imports System.IO

Public Class frmOwnElectricity
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmOwnElectricity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure DateTimePickers
        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        ' Set default values
        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now

        ' Configure ComboBoxes
        cmbRenewableType.Items.AddRange(New String() {"Solar", "Wind Power", "Hydropower", "Geothermal", "Biomass Energy", "Wave Energy", "Green Hydrogen", "Tidal Energy"})
        cmbNonRenewableType.Items.AddRange(New String() {"Coal", "Natural Gas", "Oil", "Nuclear Energy", "Diesel", "Peat", "Shale Gas and Oil", "Tar Sand"})

        AddHandler txtRenewableCap.TextChanged, AddressOf CalculateSoldCapacity
        AddHandler txtNonRenewableCap.TextChanged, AddressOf CalculateSoldCapacity
        AddHandler txtTotalConsumed.TextChanged, AddressOf CalculateSoldCapacity

        LoadDataGridView()
    End Sub

    Private Sub CalculateSoldCapacity(sender As Object, e As EventArgs)
        Try
            Dim renewable As Decimal = If(String.IsNullOrEmpty(txtRenewableCap.Text), 0, Convert.ToDecimal(txtRenewableCap.Text))
            Dim nonRenewable As Decimal = If(String.IsNullOrEmpty(txtNonRenewableCap.Text), 0, Convert.ToDecimal(txtNonRenewableCap.Text))
            Dim consumed As Decimal = If(String.IsNullOrEmpty(txtTotalConsumed.Text), 0, Convert.ToDecimal(txtTotalConsumed.Text))

            Dim sold As Decimal = (renewable + nonRenewable) - consumed
            txtSoldCapacity.Text = If(sold < 0, 0, sold).ToString("N2")
        Catch ex As Exception
            ' Handle conversion errors silently
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

    'decimal helper
    Private Function GetSafeDecimal(inputText As String) As Decimal
        Dim result As Decimal = 0
        If Decimal.TryParse(inputText, result) Then
            Return result
        End If
        Return 0
    End Function


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
                    cmd.Parameters.AddWithValue("@BillFiles", filesPath)

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
                Dim query As String = "SELECT ID, Year, Month, RenewableType, RenewableCapacity, NonRenewableType, NonRenewableCapacity, TotalConsumedCapacity, SoldCapacity, Comments, BillFilesPath FROM vw_ESG_OwnElectricity ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                grdData.DataSource = dt

                If grdData.Columns.Contains("BillFilesPath") AndAlso Not grdData.Columns.Contains("ViewFiles") Then
                    Dim linkColumn As New DataGridViewLinkColumn()
                    linkColumn.Name = "ViewFiles"
                    linkColumn.HeaderText = "View Bills"
                    linkColumn.Text = "View Files"
                    linkColumn.UseColumnTextForLinkValue = True
                    grdData.Columns.Add(linkColumn)
                    grdData.Columns("BillFilesPath").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso grdData.Columns(e.ColumnIndex).Name = "ViewFiles" Then
                Dim filesPath As String = grdData.Rows(e.RowIndex).Cells("BillFilesPath").Value.ToString()
                If Not String.IsNullOrEmpty(filesPath) Then
                    Dim files = GetFilesFromPath(filesPath)
                    For Each file As String In files
                        If System.IO.File.Exists(file) Then
                            System.Diagnostics.Process.Start(file)
                        Else
                            MessageBox.Show($"File not found: {file}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Next
                End If
            Else
                currentEditID = Convert.ToInt32(grdData.Rows(e.RowIndex).Cells("ID").Value)
                LoadDataToForm(grdData.Rows(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub LoadDataToForm(row As DataGridViewRow)
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
                    cmd.Parameters.AddWithValue("@RenewableCap", Convert.ToDecimal(txtRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@NonRenewableType", cmbNonRenewableType.Text)
                    cmd.Parameters.AddWithValue("@NonRenewableCap", Convert.ToDecimal(txtNonRenewableCap.Text))
                    cmd.Parameters.AddWithValue("@TotalConsumed", Convert.ToDecimal(txtTotalConsumed.Text))
                    cmd.Parameters.AddWithValue("@SoldCapacity", Convert.ToDecimal(txtSoldCapacity.Text))
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

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToExcel(grdData, "Own_Electricity_Data")
    End Sub

    Private Sub ClearForm()
        currentEditID = -1
        txtRenewableCap.Clear()
        txtNonRenewableCap.Clear()
        txtTotalConsumed.Clear()
        txtSoldCapacity.Clear()
        txtComments.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub
End Class