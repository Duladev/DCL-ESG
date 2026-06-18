Imports System.Data.SqlClient

Public Class frmProductManagement
    Private currentEditID As Integer = -1
    Private isAddingNewCategory As Boolean = False

    Private Sub frmProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup form background if needed
        ModShared.SetupForm(Me)

        ' Load data
        LoadProductTypes()
        LoadProducts()

        ' Load categories for the first product type if available
        If cmbProductType.Items.Count > 0 Then
            cmbProductType.SelectedIndex = 0
        End If

        ' Add Enter key handling
        ModShared.AddKeyPressHandlers(Me.Controls)
    End Sub

    Private Sub SetupCategoryComboBox()
        ' Setup category combo to allow adding new items
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
        cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub

    Private Sub LoadProductTypes()
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT DISTINCT ProductType FROM tbl_ESG_ProductMaster WHERE IsActive=1 ORDER BY ProductType"

                Dim cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cmbProductType.Items.Clear()

                ' Always add Plastic and Paper first
                cmbProductType.Items.Add("Plastic")
                cmbProductType.Items.Add("Paper")

                ' Then add any additional types from database
                While reader.Read()
                    Dim productType As String = reader("ProductType").ToString()
                    ' Avoid duplicates
                    If productType <> "Plastic" AndAlso productType <> "Paper" Then
                        cmbProductType.Items.Add(productType)
                    End If
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            ' Fallback to default items if database connection fails
            cmbProductType.Items.Clear()
            cmbProductType.Items.AddRange(New Object() {"Plastic", "Paper"})
        End Try
    End Sub

    Private Sub LoadCategoriesByProductType(productType As String)
        If String.IsNullOrEmpty(productType) Then Return

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT DISTINCT ProductCategory FROM tbl_ESG_ProductMaster WHERE ProductType = @ProductType AND IsActive=1 ORDER BY ProductCategory"

                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductType", productType)

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cmbCategory.Items.Clear()
                While reader.Read()
                    cmbCategory.Items.Add(reader("ProductCategory").ToString())
                End While
                reader.Close()

                ' Add option to create new category
                cmbCategory.Items.Add("-- Add New Category --")

                If cmbCategory.Items.Count > 1 Then
                    cmbCategory.SelectedIndex = 0
                Else
                    cmbCategory.Text = ""
                End If

                ' Ensure dropdown style is correct for adding new categories
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCategory.Items.Clear()
            cmbCategory.Items.Add("-- Add New Category --")
        End Try
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        If cmbProductType.SelectedItem IsNot Nothing AndAlso Not isAddingNewCategory Then
            ' Store current selection to avoid recursive calls
            Dim selectedType As String = cmbProductType.SelectedItem.ToString()
            LoadCategoriesByProductType(selectedType)
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() = "-- Add New Category --" Then
            isAddingNewCategory = True
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
            cmbCategory.Text = ""
            cmbCategory.Focus()
            MessageBox.Show("Enter new category name and press Enter", "New Category", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            isAddingNewCategory = False
        End If
    End Sub

    Private Sub cmbCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategory.KeyPress
        If isAddingNewCategory AndAlso e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Dim newCategory As String = cmbCategory.Text.Trim()

            If Not String.IsNullOrEmpty(newCategory) Then
                ' Check if category already exists (excluding the "-- Add New Category --" item)
                Dim categoryExists As Boolean = False
                For i As Integer = 0 To cmbCategory.Items.Count - 2 ' Skip last item
                    If cmbCategory.Items(i).ToString() = newCategory Then
                        categoryExists = True
                        Exit For
                    End If
                Next

                If Not categoryExists Then
                    ' Add new category to the list (before the "-- Add New Category --" item)
                    Dim insertIndex As Integer = cmbCategory.Items.Count - 1
                    If insertIndex < 0 Then insertIndex = 0
                    cmbCategory.Items.Insert(insertIndex, newCategory)
                    cmbCategory.SelectedItem = newCategory
                    MessageBox.Show($"New category '{newCategory}' added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    cmbCategory.SelectedItem = newCategory
                    MessageBox.Show("Category already exists!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            isAddingNewCategory = False
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

    Private Sub LoadProducts()
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, ProductType, ProductCategory, ProductTypeName, UnitType, WeightPerUnit FROM tbl_ESG_ProductMaster WHERE IsActive=1 ORDER BY ProductType, ProductCategory, ProductTypeName"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                grdData.DataSource = dt

                ' Auto-size columns
                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Hide ID column
                If grdData.Columns.Contains("ID") Then
                    grdData.Columns("ID").Visible = False
                End If

                ' Format column headers
                If grdData.Columns.Contains("ProductType") Then
                    grdData.Columns("ProductType").HeaderText = "Product Type"
                End If
                If grdData.Columns.Contains("ProductCategory") Then
                    grdData.Columns("ProductCategory").HeaderText = "Category"
                End If
                If grdData.Columns.Contains("ProductTypeName") Then
                    grdData.Columns("ProductTypeName").HeaderText = "Product Name"
                End If
                If grdData.Columns.Contains("UnitType") Then
                    grdData.Columns("UnitType").HeaderText = "Unit Type"
                End If
                If grdData.Columns.Contains("WeightPerUnit") Then
                    grdData.Columns("WeightPerUnit").HeaderText = "Weight/Unit"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm() Then
            Try
                Using conn As SqlConnection = ModShared.GetConnection()
                    conn.Open()

                    ' Check if product already exists
                    Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_ESG_ProductMaster WHERE ProductType=@ProductType AND ProductCategory=@Category AND ProductTypeName=@TypeName AND IsActive=1"
                    Using checkCmd As New SqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        checkCmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim())
                        checkCmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())

                        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            MessageBox.Show("This product already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using

                    Dim sql As String = "INSERT INTO tbl_ESG_ProductMaster (ProductType, ProductCategory, ProductTypeName, UnitType, WeightPerUnit, IsActive) VALUES (@ProductType, @Category, @TypeName, @UnitType, @Weight, 1)"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim())
                        cmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text)
                        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeightPerUnit.Text))

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadProducts()

                    ' Refresh product types to include any new ones, but keep Plastic and Paper
                    LoadProductTypes()
                    If cmbProductType.Items.Count > 0 Then
                        ' Try to select the newly added product type
                        Dim index As Integer = cmbProductType.FindStringExact(cmbProductType.Text)
                        If index >= 0 Then
                            cmbProductType.SelectedIndex = index
                        Else
                            cmbProductType.SelectedIndex = 0
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub grdData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellClick
        If e.RowIndex >= 0 Then
            currentEditID = Convert.ToInt32(grdData.Rows(e.RowIndex).Cells("ID").Value)
            cmbProductType.Text = grdData.Rows(e.RowIndex).Cells("ProductType").Value.ToString()

            ' Load categories for this product type
            LoadCategoriesByProductType(cmbProductType.Text)

            cmbCategory.Text = grdData.Rows(e.RowIndex).Cells("ProductCategory").Value.ToString()
            txtProductTypeName.Text = grdData.Rows(e.RowIndex).Cells("ProductTypeName").Value.ToString()
            cmbUnitType.Text = grdData.Rows(e.RowIndex).Cells("UnitType").Value.ToString()
            txtWeightPerUnit.Text = grdData.Rows(e.RowIndex).Cells("WeightPerUnit").Value.ToString()

            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False

            ' Enable category combo when editing (fixed)
            cmbCategory.Enabled = True
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentEditID = -1 Then
            MessageBox.Show("Please select a product to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateForm() Then
            Try
                Using conn As SqlConnection = ModShared.GetConnection()
                    conn.Open()

                    ' Check for duplicate excluding current record
                    Dim checkQuery As String = "SELECT COUNT(*) FROM tbl_ESG_ProductMaster WHERE ProductType=@ProductType AND ProductCategory=@Category AND ProductTypeName=@TypeName AND ID<>@ID AND IsActive=1"
                    Using checkCmd As New SqlCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        checkCmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim())
                        checkCmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())
                        checkCmd.Parameters.AddWithValue("@ID", currentEditID)

                        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            MessageBox.Show("Another product with this name already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using

                    Dim sql As String = "UPDATE tbl_ESG_ProductMaster SET ProductType=@ProductType, ProductCategory=@Category, ProductTypeName=@TypeName, UnitType=@UnitType, WeightPerUnit=@Weight WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text.Trim())
                        cmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text)
                        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeightPerUnit.Text))

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadProducts()

                    ' Refresh product types to include any new ones, but keep Plastic and Paper
                    LoadProductTypes()
                    If cmbProductType.Items.Count > 0 Then
                        cmbProductType.SelectedIndex = 0
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentEditID = -1 Then
            MessageBox.Show("Please select a product to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this product? This will affect existing inventory records.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = ModShared.GetConnection()
                    conn.Open()
                    ' Soft delete by setting IsActive=0
                    Dim sql As String = "UPDATE tbl_ESG_ProductMaster SET IsActive=0 WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadProducts()
                    LoadProductTypes()
                    If cmbProductType.Items.Count > 0 Then
                        cmbProductType.SelectedIndex = 0
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrEmpty(cmbProductType.Text) Then
            MessageBox.Show("Please select product type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(cmbCategory.Text) OrElse cmbCategory.Text = "-- Add New Category --" Then
            MessageBox.Show("Please select or add a product category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(txtProductTypeName.Text) Then
            MessageBox.Show("Please enter product type name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrEmpty(cmbUnitType.Text) Then
            MessageBox.Show("Please select unit type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If Not IsNumeric(txtWeightPerUnit.Text) OrElse Convert.ToDecimal(txtWeightPerUnit.Text) <= 0 Then
            MessageBox.Show("Please enter valid weight per unit", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        currentEditID = -1
        cmbProductType.SelectedIndex = -1
        cmbCategory.Items.Clear()
        cmbCategory.Text = ""
        txtProductTypeName.Clear()
        cmbUnitType.SelectedIndex = -1
        txtWeightPerUnit.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        cmbCategory.Enabled = True
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDown
        isAddingNewCategory = False

        ' Reload categories for current product type if available
        If cmbProductType.SelectedItem IsNot Nothing Then
            LoadCategoriesByProductType(cmbProductType.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If grdData.Rows.Count > 0 Then
            ModShared.ExportToExcel(grdData, "Product_Management_List")
        Else
            MessageBox.Show("No data to export!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
    End Sub
End Class