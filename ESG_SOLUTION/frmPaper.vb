Imports System.Data.SqlClient
Imports System.IO

Public Class frmPaper
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1

    Private Sub frmPaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure DateTimePickers
        dtpYear.CustomFormat = "yyyy"
        dtpYear.ShowUpDown = True
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.ShowUpDown = True

        ' Set default values
        dtpYear.Value = DateTime.Now
        dtpMonth.Value = DateTime.Now

        AddHandler txtUnitCount.TextChanged, AddressOf CalculateFields
        AddHandler txtPricePerUnit.TextChanged, AddressOf CalculateFields

        LoadProducts()
        LoadPaperData()
    End Sub

    Private Sub LoadProducts()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, ProductCategory, ProductTypeName, UnitType, WeightPerUnit FROM tbl_ESG_ProductMaster WHERE ProductType='Paper' AND IsActive=1 ORDER BY ProductCategory, ProductTypeName"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cmbProductCategory.DataSource = dt
                cmbProductCategory.DisplayMember = "ProductCategory"
                cmbProductCategory.ValueMember = "ID"

                cmbProductType.DataSource = dt.Copy()
                cmbProductType.DisplayMember = "ProductTypeName"
                cmbProductType.ValueMember = "ID"

                ' Load filters
                Dim categories = dt.AsEnumerable().Select(Function(r) r("ProductCategory").ToString()).Distinct().ToList()
                cmbPaperCategoryFilter.Items.Clear()
                cmbPaperCategoryFilter.Items.Add("All")
                For Each cat In categories
                    cmbPaperCategoryFilter.Items.Add(cat)
                Next
                cmbPaperCategoryFilter.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductCategory.SelectedIndexChanged
        If cmbProductCategory.SelectedValue IsNot Nothing AndAlso
       TypeOf cmbProductCategory.SelectedValue Is Integer Then
            Dim productId As Integer = Convert.ToInt32(cmbProductCategory.SelectedValue)
            LoadProductDetails(productId)
        End If
    End Sub

    ' Fixed
    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        If cmbProductType.SelectedValue IsNot Nothing AndAlso
       TypeOf cmbProductType.SelectedValue Is Integer Then
            Dim productId As Integer = Convert.ToInt32(cmbProductType.SelectedValue)
            LoadProductDetails(productId)
        End If
    End Sub

    Private Sub LoadProductDetails(productId As Integer)
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT UnitType, WeightPerUnit FROM tbl_ESG_ProductMaster WHERE ID=@ID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", productId)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtUnitType.Text = reader("UnitType").ToString()
                        txtWeightPerUnit.Text = reader("WeightPerUnit").ToString()
                    End If
                    reader.Close()
                End Using
            End Using
            CalculateFields(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show($"Error loading product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateFields(sender As Object, e As EventArgs)
        Try
            Dim unitCount As Integer = If(String.IsNullOrEmpty(txtUnitCount.Text), 0, Convert.ToInt32(txtUnitCount.Text))
            Dim weightPerUnit As Decimal = If(String.IsNullOrEmpty(txtWeightPerUnit.Text), 0, Convert.ToDecimal(txtWeightPerUnit.Text))
            Dim pricePerUnit As Decimal = If(String.IsNullOrEmpty(txtPricePerUnit.Text), 0, Convert.ToDecimal(txtPricePerUnit.Text))

            txtPurchasedScale.Text = (unitCount * weightPerUnit).ToString("N2")
            txtTotalCost.Text = (unitCount * pricePerUnit).ToString("N2")
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm() Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()

                    Dim sql As String = "INSERT INTO tbl_ESG_Paper (Year, Month, ProductMasterID, PurchasedUnitCount, PurchasedScale, PricePerUnit, TotalPurchaseCost, Comments, BillFilesPath) VALUES (@Year, @Month, @ProductID, @UnitCount, @Scale, @Price, @TotalCost, @Comments, @BillFiles)"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                        cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                        cmd.Parameters.AddWithValue("@ProductID", cmbProductCategory.SelectedValue)
                        cmd.Parameters.AddWithValue("@UnitCount", Convert.ToInt32(txtUnitCount.Text))
                        cmd.Parameters.AddWithValue("@Scale", Convert.ToDecimal(txtPurchasedScale.Text))
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPricePerUnit.Text))
                        cmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text))
                        cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

                        Dim recordId = $"Paper_{dtpYear.Value.Year}_{dtpMonth.Value.Month}_{DateTime.Now.Ticks}"
                        Dim filesPath = SaveMultipleFiles(currentFiles, recordId, "Paper")
                        cmd.Parameters.AddWithValue("@BillFiles", filesPath)

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Paper inventory data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPaperData()
                    currentFiles.Clear()
                    lblFileCount.Text = "No files selected"
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error saving paper data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub LoadPaperData()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, Year, Month, ProductCategory, ProductType, TypeOfUnit, PurchasedUnitCount, WeightPerUnit, PurchasedScale, PricePerUnit, TotalPurchaseCost, Comments, BillFilesPath FROM vw_ESG_Paper ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Apply filter
                If cmbPaperCategoryFilter.SelectedItem IsNot Nothing AndAlso cmbPaperCategoryFilter.SelectedItem.ToString() <> "All" Then
                    Dim dv As New DataView(dt)
                    dv.RowFilter = $"ProductCategory = '{cmbPaperCategoryFilter.SelectedItem.ToString()}'"
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
            MessageBox.Show($"Error loading paper data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        cmbProductCategory.Text = row.Cells("ProductCategory").Value.ToString()
        cmbProductType.Text = row.Cells("ProductType").Value.ToString()
        txtUnitCount.Text = row.Cells("PurchasedUnitCount").Value.ToString()
        txtPricePerUnit.Text = row.Cells("PricePerUnit").Value.ToString()
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

        If ValidateForm() Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "UPDATE tbl_ESG_Paper SET Year=@Year, Month=@Month, ProductMasterID=@ProductID, PurchasedUnitCount=@UnitCount, PurchasedScale=@Scale, PricePerUnit=@Price, TotalPurchaseCost=@TotalCost, Comments=@Comments, UpdatedDate=GETDATE() WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                        cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                        cmd.Parameters.AddWithValue("@ProductID", cmbProductCategory.SelectedValue)
                        cmd.Parameters.AddWithValue("@UnitCount", Convert.ToInt32(txtUnitCount.Text))
                        cmd.Parameters.AddWithValue("@Scale", Convert.ToDecimal(txtPurchasedScale.Text))
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPricePerUnit.Text))
                        cmd.Parameters.AddWithValue("@TotalCost", Convert.ToDecimal(txtTotalCost.Text))
                        cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Paper data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPaperData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating paper data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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
                    Dim sql As String = "DELETE FROM tbl_ESG_Paper WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Paper data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPaperData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting paper data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If cmbProductCategory.SelectedValue Is Nothing Then
            MessageBox.Show("Please select product category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(txtUnitCount.Text) OrElse Not IsNumeric(txtUnitCount.Text) Then
            MessageBox.Show("Please enter valid unit count", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(txtPricePerUnit.Text) OrElse Not IsNumeric(txtPricePerUnit.Text) Then
            MessageBox.Show("Please enter valid price per unit", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        currentEditID = -1
        txtUnitCount.Clear()
        txtPricePerUnit.Clear()
        txtPurchasedScale.Clear()
        txtTotalCost.Clear()
        txtComments.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToExcel(grdData, "Paper_Inventory_Data")
    End Sub

    Private Sub cmbPaperCategoryFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaperCategoryFilter.SelectedIndexChanged
        LoadPaperData()
    End Sub

End Class