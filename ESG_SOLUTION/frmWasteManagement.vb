Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmWasteManagement
    ' Database Connection String
    Private connString As String = "Data Source=DCL-ICT-007\DEVELOPER;Initial Catalog=ESG;Integrated Security=True"
    Private currentRecordID As Integer = -1
    Private currentWasteCategory As String = ""
    Private uploadedDocuments As New List(Of String)
    Private dynamicWasteItems As New Dictionary(Of String, List(Of DynamicWasteItem))

    Public Class DynamicWasteItem
        Public Property WasteType As String
        Public Property NumericControl As NumericUpDown
        Public Property Panel As Panel
        Public Property Category As String
    End Class

    Private Sub frmWasteManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollectors()
        SetupDynamicItems()
        LoadAllTabRecords()

        ' Add handlers for numeric controls
        AddHandler dtpRecordDate.ValueChanged, AddressOf CalculateDailyTotal
        AddAllNumericHandlers()
    End Sub

    Private Sub AddAllNumericHandlers()
        ' Add handlers for all existing numeric controls
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is NumericUpDown Then
                RemoveHandler DirectCast(ctrl, NumericUpDown).ValueChanged, AddressOf CalculateDailyTotal
                AddHandler DirectCast(ctrl, NumericUpDown).ValueChanged, AddressOf CalculateDailyTotal
            End If
        Next

        ' Add handlers for controls in TabPages
        For Each tab As TabPage In tabWasteCategories.TabPages
            AddNumericHandlersInContainer(tab)
        Next
    End Sub

    Private Sub AddNumericHandlersInContainer(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is NumericUpDown Then
                RemoveHandler DirectCast(ctrl, NumericUpDown).ValueChanged, AddressOf CalculateDailyTotal
                AddHandler DirectCast(ctrl, NumericUpDown).ValueChanged, AddressOf CalculateDailyTotal
            ElseIf ctrl.HasChildren Then
                AddNumericHandlersInContainer(ctrl)
            End If
        Next
    End Sub

    Private Sub SetupDynamicItems()
        dynamicWasteItems.Clear()
        dynamicWasteItems.Add("Non-Recycled", New List(Of DynamicWasteItem))
        dynamicWasteItems.Add("Recycled", New List(Of DynamicWasteItem))
        dynamicWasteItems.Add("Other Recycled", New List(Of DynamicWasteItem))
        dynamicWasteItems.Add("Chemical", New List(Of DynamicWasteItem))
    End Sub

    Private Sub LoadCollectors()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT CollectorID, CollectorName FROM tbl_ESG_WasteCollectors WHERE IsActive = 1"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cmbCollector.DataSource = dt
                cmbCollector.DisplayMember = "CollectorName"
                cmbCollector.ValueMember = "CollectorID"
                cmbCollector.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading collectors: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAllTabRecords()
        LoadTabRecords("Non-Recycled", dgvNonRecycled)
        LoadTabRecords("Recycled", dgvRecycled)
        LoadTabRecords("Other Recycled", dgvOtherRecycled)
        LoadTabRecords("Chemical", dgvChemical)
    End Sub

    Private Sub LoadTabRecords(category As String, dataGridView As DataGridView)
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT RecordID, RecordDate, WasteType, QuantityKG, CollectorName, AdditionalInfo 
                                     FROM vw_ESG_WasteRecords 
                                     WHERE WasteCategory = @Category 
                                     ORDER BY RecordDate DESC"
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@Category", category)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dataGridView.DataSource = dt

                ' Format columns
                If dataGridView.Columns.Count > 0 Then
                    dataGridView.Columns("RecordID").Visible = False
                    dataGridView.Columns("RecordDate").HeaderText = "Date"
                    dataGridView.Columns("WasteType").HeaderText = "Waste Type"
                    dataGridView.Columns("QuantityKG").HeaderText = "Quantity (KG)"
                    dataGridView.Columns("CollectorName").HeaderText = "Collector"
                    dataGridView.Columns("AdditionalInfo").HeaderText = "Additional Info"
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading {category} records: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateDailyTotal(sender As Object, e As EventArgs)
        Try
            Dim total As Decimal = 0

            ' Calculate from Non-Recycled tab
            total += GetTabTotal(tpNonRecycled)

            ' Calculate from Recycled tab
            total += GetTabTotal(tpRecycled)

            ' Calculate from Other Recycled tab
            total += GetTabTotal(tpOtherRecycled)

            ' Calculate from Chemical tab
            total += GetTabTotal(tpChemical)

            txtDailyTotal.Text = total.ToString("N2") & " KG"
        Catch ex As Exception
            txtDailyTotal.Text = "0 KG"
        End Try
    End Sub

    Private Function GetTabTotal(tabPage As TabPage) As Decimal
        Dim total As Decimal = 0

        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                total += DirectCast(ctrl, NumericUpDown).Value
            ElseIf TypeOf ctrl Is Panel OrElse TypeOf ctrl Is GroupBox OrElse TypeOf ctrl Is FlowLayoutPanel Then
                total += GetNumericTotalInContainer(ctrl)
            End If
        Next

        Return total
    End Function

    Private Function GetNumericTotalInContainer(container As Control) As Decimal
        Dim total As Decimal = 0

        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is NumericUpDown Then
                total += DirectCast(ctrl, NumericUpDown).Value
            ElseIf ctrl.HasChildren Then
                total += GetNumericTotalInContainer(ctrl)
            End If
        Next

        Return total
    End Function

    Private Sub AddDynamicWasteItem(category As String, targetPanel As FlowLayoutPanel)
        Dim inputDialog As New Form()
        inputDialog.Text = "Add New Waste Type"
        inputDialog.Size = New Size(300, 150)
        inputDialog.StartPosition = FormStartPosition.CenterParent

        Dim lbl As New Label() With {.Text = "Waste Type Name:", .Location = New Point(10, 20), .Size = New Size(100, 25)}
        Dim txt As New TextBox() With {.Location = New Point(120, 20), .Size = New Size(150, 25)}
        Dim btnOK As New Button() With {.Text = "OK", .Location = New Point(120, 60), .Size = New Size(75, 30)}
        Dim btnCancel As New Button() With {.Text = "Cancel", .Location = New Point(200, 60), .Size = New Size(75, 30)}

        AddHandler btnOK.Click, Sub(s, eArg)
                                    If Not String.IsNullOrWhiteSpace(txt.Text) Then
                                        CreateDynamicWasteControl(category, txt.Text, targetPanel)
                                        inputDialog.Close()
                                    End If
                                End Sub
        AddHandler btnCancel.Click, Sub(s, eArg) inputDialog.Close()

        inputDialog.Controls.AddRange({lbl, txt, btnOK, btnCancel})
        inputDialog.ShowDialog()
    End Sub

    Private Sub CreateDynamicWasteControl(category As String, wasteType As String, targetPanel As FlowLayoutPanel)
        Dim panel As New Panel() With {.Size = New Size(280, 35), .BorderStyle = BorderStyle.FixedSingle}
        Dim lbl As New Label() With {.Text = wasteType & ":", .Location = New Point(5, 8), .Size = New Size(120, 20)}
        Dim num As New NumericUpDown() With {.Location = New Point(130, 5), .Size = New Size(100, 25), .DecimalPlaces = 2, .Maximum = 999999}
        Dim btnRemove As New Button() With {.Text = "X", .Location = New Point(235, 5), .Size = New Size(35, 25), .BackColor = Color.LightCoral}

        AddHandler num.ValueChanged, AddressOf CalculateDailyTotal
        AddHandler btnRemove.Click, Sub(s, e)
                                        targetPanel.Controls.Remove(panel)
                                        dynamicWasteItems(category).RemoveAll(Function(x) x.Panel Is panel)
                                        CalculateDailyTotal(Nothing, Nothing)
                                    End Sub

        panel.Controls.AddRange({lbl, num, btnRemove})
        targetPanel.Controls.Add(panel)

        dynamicWasteItems(category).Add(New DynamicWasteItem() With {
            .WasteType = wasteType,
            .NumericControl = num,
            .Panel = panel,
            .Category = category
        })
    End Sub

    Private Sub btnAddNonRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddNonRecycledItem.Click
        AddDynamicWasteItem("Non-Recycled", flpNonRecycledItems)
    End Sub

    Private Sub btnAddRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddRecycledItem.Click
        AddDynamicWasteItem("Recycled", flpRecycledItems)
    End Sub

    Private Sub btnAddOtherRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddOtherRecycledItem.Click
        AddDynamicWasteItem("Other Recycled", flpOtherRecycledItems)
    End Sub

    Private Sub btnAddChemicalItem_Click(sender As Object, e As EventArgs) Handles btnAddChemicalItem.Click
        AddDynamicWasteItem("Chemical", flpChemicalItems)
    End Sub

    Private Sub btnUploadDocuments_Click(sender As Object, e As EventArgs) Handles btnUploadDocuments.Click
        ofdDocuments.Multiselect = True
        ofdDocuments.Filter = "All Files|*.*|PDF Files|*.pdf|Image Files|*.jpg;*.png;*.bmp|Word Files|*.doc;*.docx"

        If ofdDocuments.ShowDialog() = DialogResult.OK Then
            uploadedDocuments.Clear()
            For Each file In ofdDocuments.FileNames
                uploadedDocuments.Add(file)
            Next
            MessageBox.Show($"{ofdDocuments.FileNames.Length} document(s) selected for upload.", "Documents Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        If cmbCollector.SelectedIndex = -1 Then
            MessageBox.Show("Please select a waste collector.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    ' Save Non-Recycled entries
                    SaveCategoryEntries(conn, transaction, "Non-Recycled", tpNonRecycled)

                    ' Save Recycled entries
                    SaveCategoryEntries(conn, transaction, "Recycled", tpRecycled)

                    ' Save Other Recycled entries
                    SaveCategoryEntries(conn, transaction, "Other Recycled", tpOtherRecycled)

                    ' Save Chemical entries
                    SaveCategoryEntries(conn, transaction, "Chemical", tpChemical)

                    transaction.Commit()
                    MessageBox.Show("Waste records saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearForm()
                    LoadAllTabRecords()
                    uploadedDocuments.Clear()

                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveCategoryEntries(conn As SqlConnection, transaction As SqlTransaction, category As String, tabPage As TabPage)
        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                Dim numCtrl As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                If numCtrl.Value > 0 Then
                    Dim wasteType As String = GetWasteTypeFromControl(numCtrl)
                    SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value)
                End If
            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                Dim flp As FlowLayoutPanel = DirectCast(ctrl, FlowLayoutPanel)
                For Each panel As Control In flp.Controls
                    For Each subCtrl As Control In panel.Controls
                        If TypeOf subCtrl Is NumericUpDown Then
                            Dim numCtrl As NumericUpDown = DirectCast(subCtrl, NumericUpDown)
                            If numCtrl.Value > 0 Then
                                Dim wasteType As String = GetLabelTextFromPanel(panel)
                                SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value)
                            End If
                        End If
                    Next
                Next
            ElseIf ctrl.HasChildren Then
                For Each child As Control In ctrl.Controls
                    If TypeOf child Is NumericUpDown Then
                        Dim numCtrl As NumericUpDown = DirectCast(child, NumericUpDown)
                        If numCtrl.Value > 0 Then
                            Dim wasteType As String = GetWasteTypeFromControl(numCtrl)
                            SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Function GetWasteTypeFromControl(numCtrl As NumericUpDown) As String
        ' Try to find associated label
        For Each ctrl As Control In numCtrl.Parent.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Text.EndsWith(":") Then
                Return ctrl.Text.TrimEnd(":"c)
            End If
        Next
        Return numCtrl.Name.Replace("num", "")
    End Function

    Private Function GetLabelTextFromPanel(panel As Control) As String
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is Label Then
                Return ctrl.Text.TrimEnd(":"c)
            End If
        Next
        Return "Unknown"
    End Function

    Private Sub SaveWasteEntry(conn As SqlConnection, transaction As SqlTransaction, category As String, wasteType As String, quantity As Decimal)
        Dim query As String = "INSERT INTO tbl_ESG_WasteRecords (RecordDate, WasteCategory, WasteType, QuantityKG, CollectorID, AdditionalInfo) 
                              OUTPUT INSERTED.RecordID
                              VALUES (@RecordDate, @Category, @WasteType, @Quantity, @CollectorID, @AdditionalInfo)"

        Using cmd As New SqlCommand(query, conn, transaction)
            cmd.Parameters.AddWithValue("@RecordDate", dtpRecordDate.Value.Date)
            cmd.Parameters.AddWithValue("@Category", category)
            cmd.Parameters.AddWithValue("@WasteType", wasteType)
            cmd.Parameters.AddWithValue("@Quantity", quantity)
            cmd.Parameters.AddWithValue("@CollectorID", cmbCollector.SelectedValue)
            cmd.Parameters.AddWithValue("@AdditionalInfo", "")

            Dim recordID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Save documents for this record
            If uploadedDocuments.Count > 0 Then
                For Each filePath In uploadedDocuments
                    Dim docQuery As String = "INSERT INTO tbl_ESG_WasteDocuments (RecordID, DocumentName, DocumentPath) VALUES (@RecordID, @DocName, @DocPath)"
                    Using docCmd As New SqlCommand(docQuery, conn, transaction)
                        docCmd.Parameters.AddWithValue("@RecordID", recordID)
                        docCmd.Parameters.AddWithValue("@DocName", Path.GetFileName(filePath))
                        docCmd.Parameters.AddWithValue("@DocPath", filePath)
                        docCmd.ExecuteNonQuery()
                    End Using
                Next
            End If
        End Using
    End Sub

    Private Sub DataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles dgvNonRecycled.SelectionChanged, dgvRecycled.SelectionChanged, dgvOtherRecycled.SelectionChanged, dgvChemical.SelectionChanged
        Dim senderGrid As DataGridView = DirectCast(sender, DataGridView)

        If senderGrid.SelectedRows.Count > 0 Then
            currentRecordID = Convert.ToInt32(senderGrid.SelectedRows(0).Cells("RecordID").Value)
            currentWasteCategory = GetCategoryFromDataGridView(senderGrid)
            LoadRecordForEditing(currentRecordID, currentWasteCategory)
        End If
    End Sub

    Private Function GetCategoryFromDataGridView(grid As DataGridView) As String
        If grid Is dgvNonRecycled Then Return "Non-Recycled"
        If grid Is dgvRecycled Then Return "Recycled"
        If grid Is dgvOtherRecycled Then Return "Other Recycled"
        If grid Is dgvChemical Then Return "Chemical"
        Return ""
    End Function

    Private Sub LoadRecordForEditing(recordID As Integer, category As String)
        Try
            ClearForm()

            Using conn As New SqlConnection(connString)
                conn.Open()

                ' Get collector info
                Dim query As String = "SELECT RecordDate, WasteType, QuantityKG, CollectorID 
                                     FROM tbl_ESG_WasteRecords 
                                     WHERE RecordID = @RecordID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RecordID", recordID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        dtpRecordDate.Value = Convert.ToDateTime(reader("RecordDate"))
                        cmbCollector.SelectedValue = Convert.ToInt32(reader("CollectorID"))

                        ' Set the value in the appropriate control based on category and waste type
                        SetControlValue(category, reader("WasteType").ToString(), Convert.ToDecimal(reader("QuantityKG")))
                    End If
                End Using
            End Using

            tabWasteCategories.SelectedTab = GetTabPageByCategory(category)

        Catch ex As Exception
            MessageBox.Show("Error loading record: " & ex.Message)
        End Try
    End Sub

    Private Sub SetControlValue(category As String, wasteType As String, quantity As Decimal)
        Dim tabPage As TabPage = GetTabPageByCategory(category)

        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown AndAlso GetWasteTypeFromControl(DirectCast(ctrl, NumericUpDown)) = wasteType Then
                DirectCast(ctrl, NumericUpDown).Value = quantity
                Return
            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                For Each panel As Control In ctrl.Controls
                    If GetLabelTextFromPanel(panel) = wasteType Then
                        For Each subCtrl As Control In panel.Controls
                            If TypeOf subCtrl Is NumericUpDown Then
                                DirectCast(subCtrl, NumericUpDown).Value = quantity
                                Return
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Function GetTabPageByCategory(category As String) As TabPage
        Select Case category
            Case "Non-Recycled"
                Return tpNonRecycled
            Case "Recycled"
                Return tpRecycled
            Case "Other Recycled"
                Return tpOtherRecycled
            Case "Chemical"
                Return tpChemical
            Case Else
                Return tpNonRecycled
        End Select
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentRecordID = -1 Then
            MessageBox.Show("Please select a record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Delete existing records for this date/category and re-save
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    Dim transaction = conn.BeginTransaction()

                    Try
                        ' Delete existing records for the same date and category
                        Dim deleteQuery As String = "DELETE FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID"
                        Using deleteCmd As New SqlCommand(deleteQuery, conn, transaction)
                            deleteCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        ' Save updated records
                        SaveCategoryEntries(conn, transaction, currentWasteCategory, GetTabPageByCategory(currentWasteCategory))

                        transaction.Commit()
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearForm()
                        LoadAllTabRecords()
                        currentRecordID = -1

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentRecordID = -1 Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()

                    ' Delete associated documents first
                    Dim docQuery As String = "DELETE FROM tbl_ESG_WasteDocuments WHERE RecordID = @RecordID"
                    Using docCmd As New SqlCommand(docQuery, conn)
                        docCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        docCmd.ExecuteNonQuery()
                    End Using

                    ' Delete the record
                    Dim query As String = "DELETE FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadAllTabRecords()
                ClearForm()
                currentRecordID = -1
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
            saveDialog.Title = "Export Waste Records"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim allData As New DataTable()
                    allData.TableName = "WasteRecords"

                    ' Add columns
                    allData.Columns.Add("Category", GetType(String))
                    allData.Columns.Add("Date", GetType(String))
                    allData.Columns.Add("WasteType", GetType(String))
                    allData.Columns.Add("QuantityKG", GetType(Decimal))
                    allData.Columns.Add("Collector", GetType(String))

                    ' Get data from all tabs
                    AddDataToExport(allData, dgvNonRecycled, "Non-Recycled")
                    AddDataToExport(allData, dgvRecycled, "Recycled")
                    AddDataToExport(allData, dgvOtherRecycled, "Other Recycled")
                    AddDataToExport(allData, dgvChemical, "Chemical")

                    ExportToExcel(allData, saveDialog.FileName)
                    MessageBox.Show($"Data exported successfully to {saveDialog.FileName}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub AddDataToExport(allData As DataTable, grid As DataGridView, category As String)
        For Each row As DataGridViewRow In grid.Rows
            If Not row.IsNewRow Then
                Dim newRow As DataRow = allData.NewRow()
                newRow("Category") = category
                newRow("Date") = row.Cells("RecordDate").Value.ToString()
                newRow("WasteType") = row.Cells("WasteType").Value.ToString()
                newRow("QuantityKG") = Convert.ToDecimal(row.Cells("QuantityKG").Value)
                newRow("Collector") = row.Cells("CollectorName").Value.ToString()
                allData.Rows.Add(newRow)
            End If
        Next
    End Sub

    Private Sub ExportToExcel(data As DataTable, filePath As String)
        Dim sb As New StringBuilder()

        ' Add headers
        For Each col As DataColumn In data.Columns
            sb.Append("""" & col.ColumnName & """,")
        Next
        If sb.Length > 0 Then sb.Remove(sb.Length - 1, 1)
        sb.AppendLine()

        ' Add data rows
        For Each row As DataRow In data.Rows
            For Each col As DataColumn In data.Columns
                Dim cellValue As String = If(row(col) IsNot Nothing, row(col).ToString().Replace("""", """"""), "")
                sb.Append("""" & cellValue & """,")
            Next
            If sb.Length > 0 Then sb.Remove(sb.Length - 1, 1)
            sb.AppendLine()
        Next

        System.IO.File.WriteAllText(filePath, sb.ToString(), System.Text.Encoding.UTF8)
    End Sub

    Private Sub ClearForm()
        ' Clear all numeric values in all tabs
        ClearTabNumericValues(tpNonRecycled)
        ClearTabNumericValues(tpRecycled)
        ClearTabNumericValues(tpOtherRecycled)
        ClearTabNumericValues(tpChemical)

        ' Clear checkboxes if any
        For Each ctrl As Control In tpOtherRecycled.Controls
            If TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
        Next

        ' Clear dynamic items
        flpNonRecycledItems.Controls.Clear()
        flpRecycledItems.Controls.Clear()
        flpOtherRecycledItems.Controls.Clear()
        flpChemicalItems.Controls.Clear()

        ' Reset dynamic collections
        SetupDynamicItems()

        cmbCollector.SelectedIndex = -1
        uploadedDocuments.Clear()

        CalculateDailyTotal(Nothing, Nothing)
    End Sub

    Private Sub ClearTabNumericValues(tabPage As TabPage)
        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            ElseIf ctrl.HasChildren Then
                ClearNumericValuesInContainer(ctrl)
            End If
        Next
    End Sub

    Private Sub ClearNumericValuesInContainer(container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            ElseIf ctrl.HasChildren Then
                ClearNumericValuesInContainer(ctrl)
            End If
        Next
    End Sub

    Private Sub btnManageCollectors_Click(sender As Object, e As EventArgs) Handles btnManageCollectors.Click
        Dim collectorForm As New frmCollectorManagement(connString)
        collectorForm.ShowDialog()
        LoadCollectors()
    End Sub

    Private Sub tabWasteCategories_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabWasteCategories.SelectedIndexChanged
        CalculateDailyTotal(Nothing, Nothing)
    End Sub
End Class