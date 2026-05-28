Imports System.Data.SqlClient
Imports System.IO

Public Class frmWater
    Private currentWaterFiles As New List(Of String)
    Private currentRainFiles As New List(Of String)
    Private currentWaterEditID As Integer = -1
    Private currentRainEditID As Integer = -1

    Private Sub frmWater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure Water DateTimePickers
        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        ' Configure RainWater DateTimePickers
        dtpRainYear.CustomFormat = "yyyy"
        dtpRainYear.ShowUpDown = True
        dtpRainMonth.CustomFormat = "MMMM"
        dtpRainMonth.ShowUpDown = True

        ' Set default values
        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now
        dtpRainYear.Value = DateTime.Now
        dtpRainMonth.Value = DateTime.Now

        LoadWaterData()
        LoadRainWaterData()
    End Sub

    Private Sub btnUploadWaterBill_Click(sender As Object, e As EventArgs) Handles btnUploadWaterBill.Click
        Using ofd As New OpenFileDialog()
            ofd.Multiselect = True
            ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png|All Files|*.*"
            ofd.Title = "Select Water Bills"

            If ofd.ShowDialog() = DialogResult.OK Then
                currentWaterFiles.Clear()
                For Each file As String In ofd.FileNames
                    currentWaterFiles.Add(file)
                Next
                lblWaterFileCount.Text = $"{currentWaterFiles.Count} file(s) selected"
            End If
        End Using
    End Sub

    Private Sub btnSaveWater_Click(sender As Object, e As EventArgs) Handles btnSaveWater.Click
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "INSERT INTO tbl_ESG_Water (Year, Month, WaterPurchasedQty, AmountPaid, AdditionalWaterQty, AdditionalAmountPaid, BillFilesPath) VALUES (@Year, @Month, @WaterQty, @Amount, @AdditionalQty, @AdditionalAmount, @BillFiles)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@WaterQty", Convert.ToDecimal(txtWaterQty.Text))
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtWaterAmount.Text))
                    cmd.Parameters.AddWithValue("@AdditionalQty", Convert.ToDecimal(txtAdditionalWaterQty.Text))
                    cmd.Parameters.AddWithValue("@AdditionalAmount", Convert.ToDecimal(txtAdditionalAmount.Text))

                    Dim recordId = $"Water_{dtpYear.Value.Year}_{dtpMonth.Value.Month}_{DateTime.Now.Ticks}"
                    Dim filesPath = SaveMultipleFiles(currentWaterFiles, recordId, "Water")
                    cmd.Parameters.AddWithValue("@BillFiles", filesPath)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Water data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearWaterForm()
                LoadWaterData()
                currentWaterFiles.Clear()
                lblWaterFileCount.Text = "No files selected"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadWaterData()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, Year, Month, WaterPurchasedQty, AmountPaid, AdditionalWaterQty, AdditionalAmountPaid, BillFilesPath FROM vw_ESG_Water ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                grdWater.DataSource = dt

                If grdWater.Columns.Contains("BillFilesPath") AndAlso Not grdWater.Columns.Contains("ViewFiles") Then
                    Dim linkColumn As New DataGridViewLinkColumn()
                    linkColumn.Name = "ViewFiles"
                    linkColumn.HeaderText = "View Bills"
                    linkColumn.Text = "View Files"
                    linkColumn.UseColumnTextForLinkValue = True
                    grdWater.Columns.Add(linkColumn)
                    grdWater.Columns("BillFilesPath").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUploadRainBill_Click(sender As Object, e As EventArgs) Handles btnUploadRainBill.Click
        Using ofd As New OpenFileDialog()
            ofd.Multiselect = True
            ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png|All Files|*.*"
            ofd.Title = "Select Rain Water Bills"

            If ofd.ShowDialog() = DialogResult.OK Then
                currentRainFiles.Clear()
                For Each file As String In ofd.FileNames
                    currentRainFiles.Add(file)
                Next
                lblRainFileCount.Text = $"{currentRainFiles.Count} file(s) selected"
            End If
        End Using
    End Sub

    Private Sub btnSaveRainWater_Click(sender As Object, e As EventArgs) Handles btnSaveRainWater.Click
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()

                Dim sql As String = "INSERT INTO tbl_ESG_RainWater (Year, Month, RainWaterCollected, RainWaterConsumed, RainWaterRecycled, Comments, BillFilesPath) VALUES (@Year, @Month, @Collected, @Consumed, @Recycled, @Comments, @BillFiles)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Year", dtpRainYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpRainMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@Collected", Convert.ToDecimal(txtRainCollected.Text))
                    cmd.Parameters.AddWithValue("@Consumed", Convert.ToDecimal(txtRainConsumed.Text))
                    cmd.Parameters.AddWithValue("@Recycled", Convert.ToDecimal(txtRainRecycled.Text))
                    cmd.Parameters.AddWithValue("@Comments", txtRainComments.Text)

                    Dim recordId = $"RainWater_{dtpRainYear.Value.Year}_{dtpRainMonth.Value.Month}_{DateTime.Now.Ticks}"
                    Dim filesPath = SaveMultipleFiles(currentRainFiles, recordId, "RainWater")
                    cmd.Parameters.AddWithValue("@BillFiles", filesPath)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Rain water data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearRainWaterForm()
                LoadRainWaterData()
                currentRainFiles.Clear()
                lblRainFileCount.Text = "No files selected"
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving rain water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadRainWaterData()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, Year, Month, RainWaterCollected, RainWaterConsumed, RainWaterRecycled, Comments, BillFilesPath FROM tbl_ESG_RainWater ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Apply month filter
                If cmbRainMonthFilter.SelectedItem IsNot Nothing AndAlso cmbRainMonthFilter.SelectedItem.ToString() <> "All" Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = $"Month = {Convert.ToInt32(cmbRainMonthFilter.SelectedItem.ToString())}"
                    grdRainWater.DataSource = dv
                Else
                    grdRainWater.DataSource = dt
                End If

                If grdRainWater.Columns.Contains("BillFilesPath") AndAlso Not grdRainWater.Columns.Contains("ViewFiles") Then
                    Dim linkColumn As New DataGridViewLinkColumn()
                    linkColumn.Name = "ViewFiles"
                    linkColumn.HeaderText = "View Bills"
                    linkColumn.Text = "View Files"
                    linkColumn.UseColumnTextForLinkValue = True
                    grdRainWater.Columns.Add(linkColumn)
                    grdRainWater.Columns("BillFilesPath").Visible = False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading rain water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub grdWater_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdWater.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso grdWater.Columns(e.ColumnIndex).Name = "ViewFiles" Then
                Dim filesPath As String = grdWater.Rows(e.RowIndex).Cells("BillFilesPath").Value.ToString()
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
                currentWaterEditID = Convert.ToInt32(grdWater.Rows(e.RowIndex).Cells("ID").Value)
                LoadWaterToForm(grdWater.Rows(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub grdRainWater_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRainWater.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex >= 0 AndAlso grdRainWater.Columns(e.ColumnIndex).Name = "ViewFiles" Then
                Dim filesPath As String = grdRainWater.Rows(e.RowIndex).Cells("BillFilesPath").Value.ToString()
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
                currentRainEditID = Convert.ToInt32(grdRainWater.Rows(e.RowIndex).Cells("ID").Value)
                LoadRainWaterToForm(grdRainWater.Rows(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub LoadWaterToForm(row As DataGridViewRow)
        dtpYear.Value = New Date(Convert.ToInt32(row.Cells("Year").Value), 1, 1)
        dtpMonth.Value = New Date(DateTime.Now.Year, Convert.ToInt32(row.Cells("Month").Value), 1)
        txtWaterQty.Text = row.Cells("WaterPurchasedQty").Value.ToString()
        txtWaterAmount.Text = row.Cells("AmountPaid").Value.ToString()
        txtAdditionalWaterQty.Text = row.Cells("AdditionalWaterQty").Value.ToString()
        txtAdditionalAmount.Text = row.Cells("AdditionalAmountPaid").Value.ToString()

        btnUpdateWater.Enabled = True
        btnDeleteWater.Enabled = True
        btnSaveWater.Enabled = False
    End Sub

    Private Sub LoadRainWaterToForm(row As DataGridViewRow)
        dtpRainYear.Value = New Date(Convert.ToInt32(row.Cells("Year").Value), 1, 1)
        dtpRainMonth.Value = New Date(DateTime.Now.Year, Convert.ToInt32(row.Cells("Month").Value), 1)
        txtRainCollected.Text = row.Cells("RainWaterCollected").Value.ToString()
        txtRainConsumed.Text = row.Cells("RainWaterConsumed").Value.ToString()
        txtRainRecycled.Text = row.Cells("RainWaterRecycled").Value.ToString()
        txtRainComments.Text = If(row.Cells("Comments").Value Is DBNull.Value, "", row.Cells("Comments").Value.ToString())

        btnUpdateRain.Enabled = True
        btnDeleteRain.Enabled = True
        btnSaveRainWater.Enabled = False
    End Sub

    Private Sub btnUpdateWater_Click(sender As Object, e As EventArgs) Handles btnUpdateWater.Click
        If currentWaterEditID = -1 Then
            MessageBox.Show("Please select a water record to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "UPDATE tbl_ESG_Water SET Year=@Year, Month=@Month, WaterPurchasedQty=@WaterQty, AmountPaid=@Amount, AdditionalWaterQty=@AdditionalQty, AdditionalAmountPaid=@AdditionalAmount, UpdatedDate=GETDATE() WHERE ID=@ID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentWaterEditID)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@WaterQty", Convert.ToDecimal(txtWaterQty.Text))
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtWaterAmount.Text))
                    cmd.Parameters.AddWithValue("@AdditionalQty", Convert.ToDecimal(txtAdditionalWaterQty.Text))
                    cmd.Parameters.AddWithValue("@AdditionalAmount", Convert.ToDecimal(txtAdditionalAmount.Text))

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Water data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearWaterForm()
                LoadWaterData()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteWater_Click(sender As Object, e As EventArgs) Handles btnDeleteWater.Click
        If currentWaterEditID = -1 Then
            MessageBox.Show("Please select a water record to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this water record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_ESG_Water WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentWaterEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Water data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearWaterForm()
                    LoadWaterData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnUpdateRain_Click(sender As Object, e As EventArgs) Handles btnUpdateRain.Click
        If currentRainEditID = -1 Then
            MessageBox.Show("Please select a rain water record to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim sql As String = "UPDATE tbl_ESG_RainWater SET Year=@Year, Month=@Month, RainWaterCollected=@Collected, RainWaterConsumed=@Consumed, RainWaterRecycled=@Recycled, Comments=@Comments, UpdatedDate=GETDATE() WHERE ID=@ID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentRainEditID)
                    cmd.Parameters.AddWithValue("@Year", dtpRainYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpRainMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@Collected", Convert.ToDecimal(txtRainCollected.Text))
                    cmd.Parameters.AddWithValue("@Consumed", Convert.ToDecimal(txtRainConsumed.Text))
                    cmd.Parameters.AddWithValue("@Recycled", Convert.ToDecimal(txtRainRecycled.Text))
                    cmd.Parameters.AddWithValue("@Comments", txtRainComments.Text)

                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Rain water data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearRainWaterForm()
                LoadRainWaterData()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating rain water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteRain_Click(sender As Object, e As EventArgs) Handles btnDeleteRain.Click
        If currentRainEditID = -1 Then
            MessageBox.Show("Please select a rain water record to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this rain water record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "DELETE FROM tbl_ESG_RainWater WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentRainEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Rain water data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearRainWaterForm()
                    LoadRainWaterData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting rain water data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnExportWaterExcel_Click(sender As Object, e As EventArgs) Handles btnExportWaterExcel.Click
        ExportToExcel(grdWater, "Water_Data")
    End Sub

    Private Sub btnExportRainExcel_Click(sender As Object, e As EventArgs) Handles btnExportRainExcel.Click
        ExportToExcel(grdRainWater, "RainWater_Data")
    End Sub

    Private Sub cmbRainMonthFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRainMonthFilter.SelectedIndexChanged
        LoadRainWaterData()
    End Sub

    Private Sub ClearWaterForm()
        currentWaterEditID = -1
        txtWaterQty.Clear()
        txtWaterAmount.Clear()
        txtAdditionalWaterQty.Clear()
        txtAdditionalAmount.Clear()
        btnUpdateWater.Enabled = False
        btnDeleteWater.Enabled = False
        btnSaveWater.Enabled = True
    End Sub

    Private Sub ClearRainWaterForm()
        currentRainEditID = -1
        txtRainCollected.Clear()
        txtRainConsumed.Clear()
        txtRainRecycled.Clear()
        txtRainComments.Clear()
        btnUpdateRain.Enabled = False
        btnDeleteRain.Enabled = False
        btnSaveRainWater.Enabled = True
    End Sub
End Class