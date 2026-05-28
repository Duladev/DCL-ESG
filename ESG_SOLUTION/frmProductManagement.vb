Imports System.Data.SqlClient

Public Class frmProductManagement
    Private currentEditID As Integer = -1

    Private Sub frmProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            Using conn As SqlConnection = GetConnection()
                conn.Open()
                Dim query As String = "SELECT ID, ProductType, ProductCategory, ProductTypeName, UnitType, WeightPerUnit FROM tbl_ESG_ProductMaster WHERE IsActive=1 ORDER BY ProductType, ProductCategory, ProductTypeName"

                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                grdData.DataSource = dt

                ' Auto-size columns
                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm() Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "INSERT INTO tbl_ESG_ProductMaster (ProductType, ProductCategory, ProductTypeName, UnitType, WeightPerUnit) VALUES (@ProductType, @Category, @TypeName, @UnitType, @Weight)"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim())
                        cmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text)
                        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeightPerUnit.Text))

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadProducts()
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
            txtCategory.Text = grdData.Rows(e.RowIndex).Cells("ProductCategory").Value.ToString()
            txtProductTypeName.Text = grdData.Rows(e.RowIndex).Cells("ProductTypeName").Value.ToString()
            cmbUnitType.Text = grdData.Rows(e.RowIndex).Cells("UnitType").Value.ToString()
            txtWeightPerUnit.Text = grdData.Rows(e.RowIndex).Cells("WeightPerUnit").Value.ToString()

            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentEditID = -1 Then
            MessageBox.Show("Please select a product to update", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateForm() Then
            Try
                Using conn As SqlConnection = GetConnection()
                    conn.Open()
                    Dim sql As String = "UPDATE tbl_ESG_ProductMaster SET ProductType=@ProductType, ProductCategory=@Category, ProductTypeName=@TypeName, UnitType=@UnitType, WeightPerUnit=@Weight WHERE ID=@ID"

                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ID", currentEditID)
                        cmd.Parameters.AddWithValue("@ProductType", cmbProductType.Text)
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim())
                        cmd.Parameters.AddWithValue("@TypeName", txtProductTypeName.Text.Trim())
                        cmd.Parameters.AddWithValue("@UnitType", cmbUnitType.Text)
                        cmd.Parameters.AddWithValue("@Weight", Convert.ToDecimal(txtWeightPerUnit.Text))

                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadProducts()
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
                Using conn As SqlConnection = GetConnection()
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
        If String.IsNullOrEmpty(txtCategory.Text) Then
            MessageBox.Show("Please enter product category", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        txtCategory.Clear()
        txtProductTypeName.Clear()
        cmbUnitType.SelectedIndex = -1
        txtWeightPerUnit.Clear()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub
End Class