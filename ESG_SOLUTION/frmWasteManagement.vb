Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmWasteManagement
    ' Database Connection String
    Private connString As String = "Data Source=DCL-ICT-007\DEVELOPER;Initial Catalog=ESG;Integrated Security=True"
    Private currentRecordID As Integer = -1
    Private uploadedDocuments As New List(Of String)
    Private dynamicWasteItems As New Dictionary(Of String, List(Of DynamicWasteItem))

    Public Class DynamicWasteItem
        Public Property WasteType As String
        Public Property NumericControl As NumericUpDown
        Public Property Panel As Panel
    End Class

    Private Sub frmWasteManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollectors()
        LoadWasteRecords()
        SetupDynamicItems()
        AddHandler dtpRecordDate.ValueChanged, AddressOf CalculateDailyTotal
    End Sub

    Private Sub SetupDynamicItems()
        dynamicWasteItems.Add("NonRecycled", New List(Of DynamicWasteItem))
        dynamicWasteItems.Add("Recycled", New List(Of DynamicWasteItem))
        dynamicWasteItems.Add("OtherRecycled", New List(Of DynamicWasteItem))
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

    Private Sub LoadWasteRecords()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM vw_ESG_WasteRecords ORDER BY RecordDate DESC"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvWasteRecords.DataSource = dt

                ' Format columns
                If dgvWasteRecords.Columns.Count > 0 Then
                    dgvWasteRecords.Columns("RecordID").Visible = False
                    dgvWasteRecords.Columns("RecordDate").HeaderText = "Date"
                    dgvWasteRecords.Columns("WasteCategory").HeaderText = "Category"
                    dgvWasteRecords.Columns("WasteType").HeaderText = "Waste Type"
                    dgvWasteRecords.Columns("QuantityKG").HeaderText = "Quantity (KG)"
                    dgvWasteRecords.Columns("CollectorName").HeaderText = "Collector"
                    dgvWasteRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateDailyTotal(sender As Object, e As EventArgs)
        Try
            Dim selectedDate As Date = dtpRecordDate.Value.Date
            Dim total As Decimal = 0

            ' Calculate from Non-Recycled
            total += numNonPolyethene.Value + numNonPlastic.Value

            ' Sum dynamic non-recycled items
            For Each item In dynamicWasteItems("NonRecycled")
                total += item.NumericControl.Value
            Next

            ' Calculate from Recycled
            total += numRecPaper.Value + numRecCardboard.Value + numRecPlastic.Value + numRecOtherPlastic.Value

            ' Sum dynamic recycled items
            For Each item In dynamicWasteItems("Recycled")
                total += item.NumericControl.Value
            Next

            ' Calculate from Other Recycled
            total += numOrgFood.Value + numCopper.Value + numAluminium.Value + numGlass.Value + numEWaste.Value

            ' Sum dynamic other recycled items
            For Each item In dynamicWasteItems("OtherRecycled")
                total += item.NumericControl.Value
            Next

            ' Calculate from Chemical
            total += numChemLiquids.Value + numChemPacking.Value + numChemFabric.Value

            ' Sum dynamic chemical items
            For Each item In dynamicWasteItems("Chemical")
                total += item.NumericControl.Value
            Next

            txtDailyTotal.Text = total.ToString("N2") & " KG"
        Catch ex As Exception
            txtDailyTotal.Text = "0 KG"
        End Try
    End Sub

    Private Sub btnAddNonRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddNonRecycledItem.Click
        AddDynamicWasteItem("NonRecycled", flpNonRecycledItems)
    End Sub

    Private Sub btnAddRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddRecycledItem.Click
        AddDynamicWasteItem("Recycled", flpRecycledItems)
    End Sub

    Private Sub btnAddOtherRecycledItem_Click(sender As Object, e As EventArgs) Handles btnAddOtherRecycledItem.Click
        AddDynamicWasteItem("OtherRecycled", flpOtherRecycledItems)
    End Sub

    Private Sub btnAddChemicalItem_Click(sender As Object, e As EventArgs) Handles btnAddChemicalItem.Click
        AddDynamicWasteItem("Chemical", flpChemicalItems)
    End Sub

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
            .Panel = panel
        })
    End Sub

    Private Sub btnUploadDocuments_Click(sender As Object, e As EventArgs) Handles btnUploadDocuments.Click
        ofdDocuments.Multiselect = True
        ofdDocuments.Filter = "All Files|*.*|PDF Files|*.pdf|Image Files|*.jpg;*.png;*.bmp|Word Files|*.doc;*.docx"

        If ofdDocuments.ShowDialog() = DialogResult.OK Then
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
                    ' Save each waste entry
                    SaveWasteEntries(conn, transaction, "Non-Recycled", "Polyethene", numNonPolyethene.Value)
                    SaveWasteEntries(conn, transaction, "Non-Recycled", "Plastic", numNonPlastic.Value)

                    For Each item In dynamicWasteItems("NonRecycled")
                        SaveWasteEntries(conn, transaction, "Non-Recycled", item.WasteType, item.NumericControl.Value)
                    Next

                    SaveWasteEntries(conn, transaction, "Recycled", "Paper", numRecPaper.Value)
                    SaveWasteEntries(conn, transaction, "Recycled", "Cardboard", numRecCardboard.Value)
                    SaveWasteEntries(conn, transaction, "Recycled", "Recycled Plastic", numRecPlastic.Value)
                    SaveWasteEntries(conn, transaction, "Recycled", "Other Plastic Recycled", numRecOtherPlastic.Value)

                    For Each item In dynamicWasteItems("Recycled")
                        SaveWasteEntries(conn, transaction, "Recycled", item.WasteType, item.NumericControl.Value)
                    Next

                    ' Save Other Recycled
                    If numOrgFood.Value > 0 Then
                        Dim recordID As Integer = SaveWasteEntries(conn, transaction, "Other Recycled", "Organic Waste(Food)", numOrgFood.Value)
                        If chkCompost.Checked Then
                            SaveOrganicDetails(conn, transaction, recordID, "Compost")
                        End If
                        If chkAnimalFeed.Checked Then
                            SaveOrganicDetails(conn, transaction, recordID, "Animal Feed")
                        End If
                    End If

                    SaveWasteEntries(conn, transaction, "Other Recycled", "Copper", numCopper.Value)
                    SaveWasteEntries(conn, transaction, "Other Recycled", "Aluminium", numAluminium.Value)
                    SaveWasteEntries(conn, transaction, "Other Recycled", "Glass", numGlass.Value)
                    SaveWasteEntries(conn, transaction, "Other Recycled", "Electronic Waste", numEWaste.Value)

                    For Each item In dynamicWasteItems("OtherRecycled")
                        SaveWasteEntries(conn, transaction, "Other Recycled", item.WasteType, item.NumericControl.Value)
                    Next

                    ' Save Chemical
                    SaveWasteEntries(conn, transaction, "Chemical", "Used Chemical Liquids", numChemLiquids.Value)
                    SaveWasteEntries(conn, transaction, "Chemical", "Chemical Packing", numChemPacking.Value)
                    SaveWasteEntries(conn, transaction, "Chemical", "Chemical Fabric", numChemFabric.Value)

                    For Each item In dynamicWasteItems("Chemical")
                        SaveWasteEntries(conn, transaction, "Chemical", item.WasteType, item.NumericControl.Value)
                    Next

                    transaction.Commit()
                    MessageBox.Show("Waste records saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearForm()
                    LoadWasteRecords()
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

    Private Function SaveWasteEntries(conn As SqlConnection, transaction As SqlTransaction, category As String, wasteType As String, quantity As Decimal) As Integer
        If quantity <= 0 Then Return -1

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

            Return recordID
        End Using
    End Function

    Private Sub SaveOrganicDetails(conn As SqlConnection, transaction As SqlTransaction, recordID As Integer, method As String)
        Dim query As String = "INSERT INTO tbl_ESG_OrganicWasteDetails (RecordID, DisposalMethod) VALUES (@RecordID, @Method)"
        Using cmd As New SqlCommand(query, conn, transaction)
            cmd.Parameters.AddWithValue("@RecordID", recordID)
            cmd.Parameters.AddWithValue("@Method", method)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub dgvWasteRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvWasteRecords.SelectionChanged
        If dgvWasteRecords.SelectedRows.Count > 0 Then
            currentRecordID = Convert.ToInt32(dgvWasteRecords.SelectedRows(0).Cells("RecordID").Value)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If currentRecordID = -1 Then
            MessageBox.Show("Please select a record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Load selected record data into form for editing
        LoadRecordForEditing(currentRecordID)
    End Sub

    Private Sub LoadRecordForEditing(recordID As Integer)
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT * FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RecordID", recordID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        dtpRecordDate.Value = Convert.ToDateTime(reader("RecordDate"))
                        ' Load other fields based on WasteType
                        ' This would need to be expanded based on your specific needs
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading record: " & ex.Message)
        End Try
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
                    Dim query As String = "DELETE FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadWasteRecords()
                ClearForm()
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        If cmbFilter.SelectedItem IsNot Nothing Then
            Dim filterValue As String = cmbFilter.SelectedItem.ToString()

            If filterValue = "All" Then
                dgvWasteRecords.DataSource = Nothing
                LoadWasteRecords()
            Else
                Try
                    Using conn As New SqlConnection(connString)
                        conn.Open()
                        Dim query As String = "SELECT * FROM vw_ESG_WasteRecords WHERE WasteCategory = @Category ORDER BY RecordDate DESC"
                        Dim adapter As New SqlDataAdapter(query, conn)
                        adapter.SelectCommand.Parameters.AddWithValue("@Category", filterValue)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        dgvWasteRecords.DataSource = dt
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error filtering records: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
            saveDialog.Title = "Export Waste Records"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Try
                    ExportToExcel(dgvWasteRecords, saveDialog.FileName)
                    MessageBox.Show($"Data exported successfully to {saveDialog.FileName}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub ExportToExcel(grid As DataGridView, filePath As String)
        Dim sb As New StringBuilder()

        ' Add headers
        For Each col As DataGridViewColumn In grid.Columns
            If col.Visible Then
                ' Corrected: Added missing & and fixed quote nesting
                sb.Append("""" & col.HeaderText & """,")
            End If
        Next
        If sb.Length > 0 Then sb.Remove(sb.Length - 1, 1)
        sb.AppendLine()

        ' Add data rows
        For Each row As DataGridViewRow In grid.Rows
            If Not row.IsNewRow Then
                For Each col As DataGridViewColumn In grid.Columns
                    If col.Visible Then
                        Dim cellValue As String = If(row.Cells(col.Index).Value IsNot Nothing, row.Cells(col.Index).Value.ToString().Replace("""", """"""), "")
                        ' Corrected: Fixed quote structure
                        sb.Append("""" & cellValue & """,")
                    End If
                Next
                If sb.Length > 0 Then sb.Remove(sb.Length - 1, 1)
                sb.AppendLine()
            End If
        Next

        System.IO.File.WriteAllText(filePath, sb.ToString(), System.Text.Encoding.UTF8)
    End Sub


    Private Sub ClearForm()
        ' Clear all numeric values
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            End If
        Next

        ' Clear checkboxes
        chkCompost.Checked = False
        chkAnimalFeed.Checked = False

        ' Clear dynamic items
        flpNonRecycledItems.Controls.Clear()
        flpRecycledItems.Controls.Clear()
        flpOtherRecycledItems.Controls.Clear()
        flpChemicalItems.Controls.Clear()

        ' Reset dynamic collections
        SetupDynamicItems()

        cmbCollector.SelectedIndex = -1
        currentRecordID = -1
        uploadedDocuments.Clear()

        CalculateDailyTotal(Nothing, Nothing)
    End Sub

    Private Sub btnManageCollectors_Click(sender As Object, e As EventArgs) Handles btnManageCollectors.Click
        Dim collectorForm As New frmCollectorManagement(connString)
        collectorForm.ShowDialog()
        LoadCollectors() ' Refresh collector list
    End Sub

End Class