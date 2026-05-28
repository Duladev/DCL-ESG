Imports System.Data.SqlClient
Imports System.IO

Public Class frmElectricity
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmElectricity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        LoadDataGridView()
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
                    cmd.Parameters.AddWithValue("@BillFiles", filesPath)

                    If purchaseType = "Out-Source Purchase" Then
                        cmd.Parameters.AddWithValue("@RenewableSource", cmbRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@RenewableCap", If(String.IsNullOrEmpty(txtRenewableCap.Text), 0, Convert.ToDecimal(txtRenewableCap.Text)))
                        cmd.Parameters.AddWithValue("@NonRenewableSource", cmbNonRenewableSource.Text)
                        cmd.Parameters.AddWithValue("@NonRenewableCap", If(String.IsNullOrEmpty(txtNonRenewableCap.Text), 0, Convert.ToDecimal(txtNonRenewableCap.Text)))
                    Else
                        cmd.Parameters.AddWithValue("@PeakQty", If(String.IsNullOrEmpty(txtPeakQty.Text), 0, Convert.ToDecimal(txtPeakQty.Text)))
                        cmd.Parameters.AddWithValue("@NormalQty", If(String.IsNullOrEmpty(txtNormalQty.Text), 0, Convert.ToDecimal(txtNormalQty.Text)))
                        cmd.Parameters.AddWithValue("@OffPeakQty", If(String.IsNullOrEmpty(txtOffPeakQty.Text), 0, Convert.ToDecimal(txtOffPeakQty.Text)))
                        cmd.Parameters.AddWithValue("@PeakAmount", If(String.IsNullOrEmpty(txtPeakAmount.Text), 0, Convert.ToDecimal(txtPeakAmount.Text)))
                        cmd.Parameters.AddWithValue("@NormalAmount", If(String.IsNullOrEmpty(txtNormalAmount.Text), 0, Convert.ToDecimal(txtNormalAmount.Text)))
                        cmd.Parameters.AddWithValue("@OffPeakAmount", If(String.IsNullOrEmpty(txtOffPeakAmount.Text), 0, Convert.ToDecimal(txtOffPeakAmount.Text)))
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

    Private Sub LoadDataGridView()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, PurchaseType, Year, Month, PeakTimeQty, NormalTimeQty, OffPeakTimeQty, PeakTimeAmount, NormalTimeAmount, OffPeakTimeAmount, RenewableSourceType, RenewableCapacity, BillFilesPath FROM vw_ESG_ElectricityPurchase ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                grdData.DataSource = dt

                ' Add view files link column if not exists
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
                            MessageBox.Show($"File not found: {file}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Next
                End If
            Else
                ' Load selected row for editing
                currentEditID = Convert.ToInt32(grdData.Rows(e.RowIndex).Cells("ID").Value)
                LoadDataToForm(grdData.Rows(e.RowIndex))
            End If
        End If
    End Sub

    Private Sub LoadDataToForm(row As DataGridViewRow)
        cmbPurchaseType.Text = row.Cells("PurchaseType").Value.ToString()
        dtpYear.Value = New Date(Convert.ToInt32(row.Cells("Year").Value), 1, 1)
        dtpMonth.Value = New Date(DateTime.Now.Year, Convert.ToInt32(row.Cells("Month").Value), 1)

        If cmbPurchaseType.Text = "Out-Source Purchase" Then
            cmbRenewableSource.Text = row.Cells("RenewableSourceType").Value.ToString()
            txtRenewableCap.Text = row.Cells("RenewableCapacity").Value.ToString()
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
                Dim sql As String = "UPDATE tbl_ESG_ElectricityPurchase SET PurchaseType=@PurchaseType, Year=@Year, Month=@Month, PeakTimeQty=@PeakQty, NormalTimeQty=@NormalQty, OffPeakTimeQty=@OffPeakQty, PeakTimeAmount=@PeakAmount, NormalTimeAmount=@NormalAmount, OffPeakTimeAmount=@OffPeakAmount, UpdatedDate=GETDATE() WHERE ID=@ID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentEditID)
                    cmd.Parameters.AddWithValue("@PurchaseType", cmbPurchaseType.Text)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@PeakQty", Convert.ToDecimal(txtPeakQty.Text))
                    cmd.Parameters.AddWithValue("@NormalQty", Convert.ToDecimal(txtNormalQty.Text))
                    cmd.Parameters.AddWithValue("@OffPeakQty", Convert.ToDecimal(txtOffPeakQty.Text))
                    cmd.Parameters.AddWithValue("@PeakAmount", Convert.ToDecimal(txtPeakAmount.Text))
                    cmd.Parameters.AddWithValue("@NormalAmount", Convert.ToDecimal(txtNormalAmount.Text))
                    cmd.Parameters.AddWithValue("@OffPeakAmount", Convert.ToDecimal(txtOffPeakAmount.Text))

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
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub
End Class