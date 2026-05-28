Imports System.Data.SqlClient
Imports System.IO

Public Class frmGas
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmGas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure DateTimePickers
        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        ' Set default values
        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now

        LoadGasTypes()
        LoadDataGridView()
    End Sub

    Private Sub LoadGasTypes()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT GasTypeName FROM tbl_ESG_GasTypes WHERE IsActive=1 ORDER BY GasTypeName"
                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cmbGasType.Items.Clear()
                cmbGasFilter.Items.Clear()
                cmbGasFilter.Items.Add("All")

                While reader.Read()
                    Dim gasType As String = reader("GasTypeName").ToString()
                    cmbGasType.Items.Add(gasType)
                    cmbGasFilter.Items.Add(gasType)
                End While
                reader.Close()

                If cmbGasType.Items.Count > 0 Then
                    cmbGasType.SelectedIndex = 0
                End If
                cmbGasFilter.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading gas types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddGasType_Click(sender As Object, e As EventArgs) Handles btnAddGasType.Click
        Dim newType As String = InputBox("Enter new gas type name:", "Add Gas Type")
        If Not String.IsNullOrEmpty(newType) Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "INSERT INTO tbl_ESG_GasTypes (GasTypeName) VALUES (@GasTypeName)"
                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@GasTypeName", newType)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Gas type added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadGasTypes()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error adding gas type: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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

                Dim sql As String = "INSERT INTO tbl_ESG_Gas (Year, Month, GasType, Quantity, Amount, BillFilesPath) VALUES (@Year, @Month, @GasType, @Quantity, @Amount, @BillFiles)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@GasType", cmbGasType.Text)
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(txtQuantity.Text))
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text))

                    Dim recordId = $"Gas_{cmbGasType.Text}_{dtpYear.Value.Year}_{dtpMonth.Value.Month}_{DateTime.Now.Ticks}"
                    Dim filesPath = SaveMultipleFiles(currentFiles, recordId, "Gas")
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
                Dim query As String = "SELECT ID, Year, Month, GasType, Quantity, Amount, BillFilesPath FROM vw_ESG_Gas ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Apply filter
                If cmbGasFilter.SelectedItem IsNot Nothing AndAlso cmbGasFilter.SelectedItem.ToString() <> "All" Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = $"GasType = '{cmbGasFilter.SelectedItem.ToString()}'"
                    grdData.DataSource = dv
                Else
                    grdData.DataSource = dt
                End If

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

    Private Sub cmbGasFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGasFilter.SelectedIndexChanged
        LoadDataGridView()
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
        cmbGasType.Text = row.Cells("GasType").Value.ToString()
        txtQuantity.Text = row.Cells("Quantity").Value.ToString()
        txtAmount.Text = row.Cells("Amount").Value.ToString()

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
                Dim sql As String = "UPDATE tbl_ESG_Gas SET Year=@Year, Month=@Month, GasType=@GasType, Quantity=@Quantity, Amount=@Amount, UpdatedDate=GETDATE() WHERE ID=@ID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ID", currentEditID)
                    cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                    cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                    cmd.Parameters.AddWithValue("@GasType", cmbGasType.Text)
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(txtQuantity.Text))
                    cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text))

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
                    Dim sql As String = "DELETE FROM tbl_ESG_Gas WHERE ID=@ID"

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
        ExportToExcel(grdData, "Gas_Data")
    End Sub

    Private Sub ClearForm()
        currentEditID = -1
        txtQuantity.Clear()
        txtAmount.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub
End Class