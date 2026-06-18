Imports System.Data.SqlClient

Public Class frmPlastic
    Private currentFiles As New List(Of String)
    Private currentEditID As Integer = -1
    Private productsDataTable As DataTable

    Private Sub frmPlastic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupForm(Me)

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

        SetupFilters()
        LoadProducts()
        AddKeyPressHandlers(Me.Controls)
        LoadPlasticData()
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

    Private Sub LoadProducts()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, ProductCategory, ProductTypeName, UnitType, WeightPerUnit FROM tbl_ESG_ProductMaster WHERE ProductType='Plastic' AND IsActive=1 ORDER BY ProductCategory, ProductTypeName"

                Dim da As New SqlDataAdapter(query, conn)
                productsDataTable = New DataTable()
                da.Fill(productsDataTable)

                ' Load unique categories for category dropdown
                Dim categories = productsDataTable.AsEnumerable().Select(Function(r) r("ProductCategory").ToString()).Distinct().ToList()
                cmbProductCategory.Items.Clear()
                For Each cat In categories
                    cmbProductCategory.Items.Add(cat)
                Next
                If cmbProductCategory.Items.Count > 0 Then
                    cmbProductCategory.SelectedIndex = 0
                End If

                ' Load filters
                cmbPlasticCategoryFilter.Items.Clear()
                cmbPlasticCategoryFilter.Items.Add("All")
                For Each cat In categories
                    cmbPlasticCategoryFilter.Items.Add(cat)
                Next
                cmbPlasticCategoryFilter.SelectedIndex = 0

                ' Load type filter
                Dim types = productsDataTable.AsEnumerable().Select(Function(r) r("ProductTypeName").ToString()).Distinct().ToList()
                cmbPlasticTypeFilter.Items.Clear()
                cmbPlasticTypeFilter.Items.Add("All")
                For Each t In types
                    cmbPlasticTypeFilter.Items.Add(t)
                Next
                cmbPlasticTypeFilter.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbProductCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductCategory.SelectedIndexChanged
        If cmbProductCategory.SelectedItem IsNot Nothing Then
            Dim selectedCategory As String = cmbProductCategory.SelectedItem.ToString()

            ' Filter product types based on selected category
            cmbProductType.Items.Clear()
            Dim filteredRows = productsDataTable.AsEnumerable().Where(Function(r) r("ProductCategory").ToString() = selectedCategory)

            For Each row In filteredRows
                cmbProductType.Items.Add(row("ProductTypeName").ToString())
            Next

            If cmbProductType.Items.Count > 0 Then
                cmbProductType.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        If cmbProductType.SelectedItem IsNot Nothing Then
            Dim selectedType As String = cmbProductType.SelectedItem.ToString()
            Dim productRow = productsDataTable.AsEnumerable().FirstOrDefault(Function(r) r("ProductTypeName").ToString() = selectedType)

            If productRow IsNot Nothing Then
                txtUnitType.Text = productRow("UnitType").ToString()
                txtWeightPerUnit.Text = productRow("WeightPerUnit").ToString()
                CalculateFields(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub CalculateFields(sender As Object, e As EventArgs)
        Try
            Dim unitCount As Decimal = GetSafeDecimal(txtUnitCount.Text)
            Dim weightPerUnit As Decimal = GetSafeDecimal(txtWeightPerUnit.Text)
            Dim pricePerUnit As Decimal = GetSafeDecimal(txtPricePerUnit.Text)

            txtPurchasedScale.Text = (unitCount * weightPerUnit).ToString("N2")
            txtTotalCost.Text = (unitCount * pricePerUnit).ToString("N2")
        Catch ex As Exception
            ' Handle conversion errors silently
        End Try
    End Sub

    Private Sub btnUploadBill_Click(sender As Object, e As EventArgs) Handles btnUploadBill.Click
        Using ofd As New OpenFileDialog()
            ofd.Multiselect = True
            ofd.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png|Excel Files|*.xlsx;*.xls|All Files|*.*"
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

                    ' Get ProductMasterID
                    Dim productId As Integer = GetProductMasterID()
                    If productId = -1 Then
                        MessageBox.Show("Please select valid product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim sql As String = "INSERT INTO tbl_ESG_Plastic (Year, Month, ProductMasterID, PurchasedUnitCount, PurchasedScale, PricePerUnit, TotalPurchaseCost, Comments, BillFilesPath) VALUES (@Year, @Month, @ProductID, @UnitCount, @Scale, @Price, @TotalCost, @Comments, @BillFiles)"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                        cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                        cmd.Parameters.AddWithValue("@ProductID", productId)
                        cmd.Parameters.AddWithValue("@UnitCount", GetSafeDecimal(txtUnitCount.Text))
                        cmd.Parameters.AddWithValue("@Scale", GetSafeDecimal(txtPurchasedScale.Text))
                        cmd.Parameters.AddWithValue("@Price", GetSafeDecimal(txtPricePerUnit.Text))
                        cmd.Parameters.AddWithValue("@TotalCost", GetSafeDecimal(txtTotalCost.Text))
                        cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

                        Dim recordId = $"Plastic_{dtpYear.Value.Year}_{dtpMonth.Value.Month}_{DateTime.Now.Ticks}"
                        Dim filesPath = SaveMultipleFiles(currentFiles, recordId, "Plastic")
                        cmd.Parameters.AddWithValue("@BillFiles", If(String.IsNullOrEmpty(filesPath), DBNull.Value, filesPath))

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Plastic inventory data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPlasticData()
                    currentFiles.Clear()
                    lblFileCount.Text = "No files selected"
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error saving plastic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetProductMasterID() As Integer
        If cmbProductType.SelectedItem Is Nothing Then
            Return -1
        End If

        Dim selectedType As String = cmbProductType.SelectedItem.ToString()
        Dim productRow = productsDataTable.AsEnumerable().FirstOrDefault(Function(r) r("ProductTypeName").ToString() = selectedType)

        If productRow IsNot Nothing Then
            Return Convert.ToInt32(productRow("ID"))
        End If
        Return -1
    End Function

    Private Sub LoadPlasticData()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, Year, Month, ProductCategory, ProductType, TypeOfUnit, PurchasedUnitCount, WeightPerUnit, PurchasedScale, PricePerUnit, TotalPurchaseCost, Comments, BillFilesPath FROM vw_ESG_Plastic ORDER BY Year DESC, Month DESC"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' Apply filters
                Dim dv As New DataView(dt)

                ' Year filter
                If cmbYearFilter.SelectedItem IsNot Nothing Then
                    dv.RowFilter = $"Year = {cmbYearFilter.SelectedItem}"
                End If

                ' Month filter
                If cmbMonthFilter.SelectedIndex >= 0 Then
                    Dim monthNum As Integer = cmbMonthFilter.SelectedIndex + 1
                    dv.RowFilter = If(String.IsNullOrEmpty(dv.RowFilter), $"Month = {monthNum}", $"{dv.RowFilter} AND Month = {monthNum}")
                End If

                ' Category filter
                If cmbPlasticCategoryFilter.SelectedItem IsNot Nothing AndAlso cmbPlasticCategoryFilter.SelectedItem.ToString() <> "All" Then
                    dv.RowFilter = If(String.IsNullOrEmpty(dv.RowFilter), $"ProductCategory = '{cmbPlasticCategoryFilter.SelectedItem.ToString()}'", $"{dv.RowFilter} AND ProductCategory = '{cmbPlasticCategoryFilter.SelectedItem.ToString()}'")
                End If

                ' Type filter
                If cmbPlasticTypeFilter.SelectedItem IsNot Nothing AndAlso cmbPlasticTypeFilter.SelectedItem.ToString() <> "All" Then
                    dv.RowFilter = If(String.IsNullOrEmpty(dv.RowFilter), $"ProductType = '{cmbPlasticTypeFilter.SelectedItem.ToString()}'", $"{dv.RowFilter} AND ProductType = '{cmbPlasticTypeFilter.SelectedItem.ToString()}'")
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

                grdData.ClearSelection()
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading plastic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub ViewFiles(rowIndex As Integer)
        Dim filesPath As String = grdData.Rows(rowIndex).Cells("BillFilesPath").Value?.ToString()
        If Not String.IsNullOrEmpty(filesPath) Then
            Dim files = GetFilesFromPath(filesPath)
            If files.Count > 0 Then
                OpenMultipleFiles(files)
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

        ' Set category and type
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

                    Dim productId As Integer = GetProductMasterID()
                    If productId = -1 Then
                        MessageBox.Show("Please select valid product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim sql As String = "UPDATE tbl_ESG_Plastic SET Year=@Year, Month=@Month, ProductMasterID=@ProductID, PurchasedUnitCount=@UnitCount, PurchasedScale=@Scale, PricePerUnit=@Price, TotalPurchaseCost=@TotalCost, Comments=@Comments, UpdatedDate=GETDATE() WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.Parameters.AddWithValue("@Year", dtpYear.Value.Year)
                        cmd.Parameters.AddWithValue("@Month", dtpMonth.Value.Month)
                        cmd.Parameters.AddWithValue("@ProductID", productId)
                        cmd.Parameters.AddWithValue("@UnitCount", GetSafeDecimal(txtUnitCount.Text))
                        cmd.Parameters.AddWithValue("@Scale", GetSafeDecimal(txtPurchasedScale.Text))
                        cmd.Parameters.AddWithValue("@Price", GetSafeDecimal(txtPricePerUnit.Text))
                        cmd.Parameters.AddWithValue("@TotalCost", GetSafeDecimal(txtTotalCost.Text))
                        cmd.Parameters.AddWithValue("@Comments", txtComments.Text)

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Plastic data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPlasticData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating plastic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Dim sql As String = "DELETE FROM tbl_ESG_Plastic WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Plastic data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadPlasticData()
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting plastic data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPlasticData()
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
        ExportToExcel(grdData, "Plastic_Inventory_Data")
    End Sub

    Private Sub ApplyFilters(sender As Object, e As EventArgs) Handles cmbYearFilter.SelectedIndexChanged, cmbMonthFilter.SelectedIndexChanged, cmbPlasticCategoryFilter.SelectedIndexChanged, cmbPlasticTypeFilter.SelectedIndexChanged
        LoadPlasticData()
    End Sub

    Private Function ValidateForm() As Boolean
        If cmbProductCategory.SelectedItem Is Nothing Then
            MessageBox.Show("Please select product category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbProductType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select product type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        currentFiles.Clear()
        lblFileCount.Text = "No files selected"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        grdData.ClearSelection()
        cmbProductType.SelectedIndex = -1
        cmbProductCategory.SelectedIndex = -1

        ' Reset product selections if needed
        If cmbProductCategory.Items.Count > 0 Then
            cmbProductCategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
    End Sub
End Class