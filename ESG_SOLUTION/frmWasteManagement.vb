Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class frmWasteManagement
    Private currentRecordID As Integer = -1
    Private currentWasteCategory As String = ""
    Private uploadedDocuments As New Dictionary(Of String, List(Of String))
    Private tempDocumentPaths As New Dictionary(Of String, List(Of String)) ' Store temporary copies of documents

    Public Class DynamicWasteItem
        Public Property WasteType As String
        Public Property NumericControl As NumericUpDown
        Public Property Panel As Panel
        Public Property Category As String
    End Class

    Private Sub frmWasteManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize upload documents dictionary
        uploadedDocuments.Clear()
        uploadedDocuments.Add("Non-Recycled", New List(Of String))
        uploadedDocuments.Add("Recycled", New List(Of String))
        uploadedDocuments.Add("Other Recycled", New List(Of String))
        uploadedDocuments.Add("Chemical", New List(Of String))

        tempDocumentPaths.Clear()
        tempDocumentPaths.Add("Non-Recycled", New List(Of String))
        tempDocumentPaths.Add("Recycled", New List(Of String))
        tempDocumentPaths.Add("Other Recycled", New List(Of String))
        tempDocumentPaths.Add("Chemical", New List(Of String))

        LoadCollectors()
        LoadAllTabRecords()
        SetupDateTimePickers()
        ModShared.AddKeyPressHandlers(Me.Controls)
        WireUpEvents()

        ' Add handlers for numeric controls
        AddAllNumericHandlers()
    End Sub

    Private Sub SetupDateTimePickers()
        dtpFrom.Format = DateTimePickerFormat.Custom
        dtpFrom.CustomFormat = "yyyy-MM-dd"
        dtpTo.Format = DateTimePickerFormat.Custom
        dtpTo.CustomFormat = "yyyy-MM-dd"
        dtpFrom.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpTo.Value = DateTime.Now

        ' Set all record date pickers to today
        Dim today As Date = DateTime.Now.Date
        dtpRecordDateNonRecycled.Value = today
        dtpRecordDateRecycled.Value = today
        dtpRecordDateOtherRecycled.Value = today
        dtpRecordDateChemical.Value = today
    End Sub

    Private Sub WireUpEvents()
        ' Wire up button events for Non-Recycled tab
        AddHandler btnSaveNonRecycled.Click, AddressOf btnSave_Click
        AddHandler btnUpdateNonRecycled.Click, AddressOf btnUpdate_Click
        AddHandler btnDeleteNonRecycled.Click, AddressOf btnDelete_Click
        AddHandler btnRefreshNonRecycled.Click, AddressOf btnRefresh_Click
        AddHandler btnUploadNonRecycled.Click, AddressOf btnUploadDocuments_Click
        AddHandler btnExportNonRecycled.Click, AddressOf btnExportExcel_Click
        AddHandler btnViewLicenseNonRecycled.Click, AddressOf btnViewLicense_Click
        AddHandler btnAddNonRecycledItem.Click, AddressOf btnAddItem_Click

        ' Wire up button events for Recycled tab
        AddHandler btnSaveRecycled.Click, AddressOf btnSave_Click
        AddHandler btnUpdateRecycled.Click, AddressOf btnUpdate_Click
        AddHandler btnDeleteRecycled.Click, AddressOf btnDelete_Click
        AddHandler btnRefreshRecycled.Click, AddressOf btnRefresh_Click
        AddHandler btnUploadRecycled.Click, AddressOf btnUploadDocuments_Click
        AddHandler btnExportRecycled.Click, AddressOf btnExportExcel_Click
        AddHandler btnViewLicenseRecycled.Click, AddressOf btnViewLicense_Click
        AddHandler btnAddRecycledItem.Click, AddressOf btnAddItem_Click

        ' Wire up button events for Other Recycled tab
        AddHandler btnSaveOtherRecycled.Click, AddressOf btnSave_Click
        AddHandler btnUpdateOtherRecycled.Click, AddressOf btnUpdate_Click
        AddHandler btnDeleteOtherRecycled.Click, AddressOf btnDelete_Click
        AddHandler btnRefreshOtherRecycled.Click, AddressOf btnRefresh_Click
        AddHandler btnUploadOtherRecycled.Click, AddressOf btnUploadDocuments_Click
        AddHandler btnExportOtherRecycled.Click, AddressOf btnExportExcel_Click
        AddHandler btnViewLicenseOtherRecycled.Click, AddressOf btnViewLicense_Click
        AddHandler btnAddOtherRecycledItem.Click, AddressOf btnAddItem_Click

        ' Wire up button events for Chemical tab
        AddHandler btnSaveChemical.Click, AddressOf btnSave_Click
        AddHandler btnUpdateChemical.Click, AddressOf btnUpdate_Click
        AddHandler btnDeleteChemical.Click, AddressOf btnDelete_Click
        AddHandler btnRefreshChemical.Click, AddressOf btnRefresh_Click
        AddHandler btnUploadChemical.Click, AddressOf btnUploadDocuments_Click
        AddHandler btnExportChemical.Click, AddressOf btnExportExcel_Click
        AddHandler btnFilterChemical.Click, AddressOf btnFilter_Click
        AddHandler btnViewLicenseChemical.Click, AddressOf btnViewLicense_Click
        AddHandler btnAddChemicalItem.Click, AddressOf btnAddItem_Click

        ' Wire up DataGridView cell click events
        AddHandler dgvNonRecycled.CellClick, AddressOf DataGridView_CellClick
        AddHandler dgvRecycled.CellClick, AddressOf DataGridView_CellClick
        AddHandler dgvOtherRecycled.CellClick, AddressOf DataGridView_CellClick
        AddHandler dgvChemical.CellClick, AddressOf DataGridView_CellClick

        ' Wire up date filter changes for daily total
        AddHandler dtpRecordDateNonRecycled.ValueChanged, AddressOf DateForDailyTotalChanged
        AddHandler dtpRecordDateRecycled.ValueChanged, AddressOf DateForDailyTotalChanged
        AddHandler dtpRecordDateOtherRecycled.ValueChanged, AddressOf DateForDailyTotalChanged
        AddHandler dtpRecordDateChemical.ValueChanged, AddressOf DateForDailyTotalChanged
    End Sub

    Private Sub DateForDailyTotalChanged(sender As Object, e As EventArgs)
        Dim dtp As DateTimePicker = DirectCast(sender, DateTimePicker)
        dtpRecordDateNonRecycled.Value = dtp.Value
        dtpRecordDateRecycled.Value = dtp.Value
        dtpRecordDateOtherRecycled.Value = dtp.Value
        dtpRecordDateChemical.Value = dtp.Value
        CalculateDailyTotal(Nothing, Nothing)
    End Sub

    Private Sub AddAllNumericHandlers()
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

    Private Sub LoadCollectors()
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT CollectorID, CollectorName FROM tbl_ESG_WasteCollectors WHERE IsActive = 1 ORDER BY CollectorName"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                For Each cmb As ComboBox In {cmbCollectorNonRecycled, cmbCollectorRecycled, cmbCollectorOtherRecycled, cmbCollectorChemical}
                    cmb.DataSource = dt.Copy()
                    cmb.DisplayMember = "CollectorName"
                    cmb.ValueMember = "CollectorID"
                    cmb.SelectedIndex = -1
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading collectors: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllTabRecords()
        LoadTabRecords("Non-Recycled", dgvNonRecycled, dtpFrom.Value, dtpTo.Value)
        LoadTabRecords("Recycled", dgvRecycled, dtpFrom.Value, dtpTo.Value)
        LoadTabRecords("Other Recycled", dgvOtherRecycled, dtpFrom.Value, dtpTo.Value)
        LoadTabRecords("Chemical", dgvChemical, dtpFrom.Value, dtpTo.Value)
    End Sub

    Private Sub LoadTabRecords(category As String, dataGridView As DataGridView, fromDate As Date, toDate As Date)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT RecordID, RecordDate, WasteType, QuantityKG, CollectorName 
                                     FROM vw_ESG_WasteRecords 
                                     WHERE WasteCategory = @Category 
                                     AND RecordDate BETWEEN @FromDate AND @ToDate
                                     ORDER BY RecordDate DESC"
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.SelectCommand.Parameters.AddWithValue("@Category", category)
                adapter.SelectCommand.Parameters.AddWithValue("@FromDate", fromDate)
                adapter.SelectCommand.Parameters.AddWithValue("@ToDate", toDate)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dataGridView.DataSource = dt

                ' Add View Document button column if not exists
                Dim btnColumnExists As Boolean = False
                For Each col As DataGridViewColumn In dataGridView.Columns
                    If col.Name = "ViewDocument" Then
                        btnColumnExists = True
                        Exit For
                    End If
                Next

                If Not btnColumnExists Then
                    Dim btnColumn As New DataGridViewButtonColumn()
                    btnColumn.Name = "ViewDocument"
                    btnColumn.HeaderText = "Documents"
                    btnColumn.Text = "View"
                    btnColumn.UseColumnTextForButtonValue = True
                    dataGridView.Columns.Add(btnColumn)
                End If

                ' Format columns
                If dataGridView.Columns.Count > 0 Then
                    If dataGridView.Columns.Contains("RecordID") Then
                        dataGridView.Columns("RecordID").Visible = False
                    End If
                    If dataGridView.Columns.Contains("RecordDate") Then
                        dataGridView.Columns("RecordDate").HeaderText = "Date"
                        dataGridView.Columns("RecordDate").DefaultCellStyle.Format = "yyyy-MM-dd"
                    End If
                    If dataGridView.Columns.Contains("WasteType") Then
                        dataGridView.Columns("WasteType").HeaderText = "Waste Type"
                    End If
                    If dataGridView.Columns.Contains("QuantityKG") Then
                        dataGridView.Columns("QuantityKG").HeaderText = "Quantity (KG)"
                    End If
                    If dataGridView.Columns.Contains("CollectorName") Then
                        dataGridView.Columns("CollectorName").HeaderText = "Collector"
                    End If
                    ' Remove AdditionalInfo column if exists
                    If dataGridView.Columns.Contains("AdditionalInfo") Then
                        dataGridView.Columns("AdditionalInfo").Visible = False
                    End If
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading {category} records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateDailyTotal(sender As Object, e As EventArgs)
        Try
            Dim total As Decimal = 0

            total += GetTabTotal(tpNonRecycled)
            total += GetTabTotal(tpRecycled)
            total += GetTabTotal(tpOtherRecycled)
            total += GetTabTotal(tpChemical)

            lblDailyTotalAmount.Text = total.ToString("N2")
        Catch ex As Exception
            lblDailyTotalAmount.Text = "0.00"
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

    Private Sub ClearTabForm(tabPage As TabPage, category As String)
        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                ' Clear dynamically added items only, keep static ones
                Dim flp As FlowLayoutPanel = DirectCast(ctrl, FlowLayoutPanel)
                Dim controlsToRemove As New List(Of Control)
                For Each panel As Control In flp.Controls
                    ' Check if this is a dynamically added panel (has remove button)
                    Dim hasRemoveBtn As Boolean = False
                    For Each subCtrl As Control In panel.Controls
                        If TypeOf subCtrl Is Button AndAlso subCtrl.Text = "X" Then
                            hasRemoveBtn = True
                            Exit For
                        End If
                    Next
                    If hasRemoveBtn Then
                        controlsToRemove.Add(panel)
                    End If
                Next
                For Each panel In controlsToRemove
                    flp.Controls.Remove(panel)
                Next
            ElseIf ctrl.HasChildren Then
                ClearNumericValuesInContainer(ctrl)
            End If
        Next

        ' Clear uploaded documents for this tab
        If uploadedDocuments.ContainsKey(category) Then
            uploadedDocuments(category).Clear()
        End If
        If tempDocumentPaths.ContainsKey(category) Then
            ' Delete temporary files
            For Each tempFile In tempDocumentPaths(category)
                Try
                    If File.Exists(tempFile) Then
                        File.Delete(tempFile)
                    End If
                Catch
                End Try
            Next
            tempDocumentPaths(category).Clear()
        End If

        ' Reset collector combo box
        Dim cmb As ComboBox = GetComboBoxForCategory(category)
        If cmb IsNot Nothing Then
            cmb.SelectedIndex = -1
        End If

        CalculateDailyTotal(Nothing, Nothing)
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

    Private Function GetComboBoxForCategory(category As String) As ComboBox
        Select Case category
            Case "Non-Recycled"
                Return cmbCollectorNonRecycled
            Case "Recycled"
                Return cmbCollectorRecycled
            Case "Other Recycled"
                Return cmbCollectorOtherRecycled
            Case "Chemical"
                Return cmbCollectorChemical
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetFlowLayoutPanelForCategory(category As String) As FlowLayoutPanel
        Select Case category
            Case "Non-Recycled"
                Return flpNonRecycledItems
            Case "Recycled"
                Return flpRecycledItems
            Case "Other Recycled"
                Return flpOtherRecycledItems
            Case "Chemical"
                Return flpChemicalItems
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetDataGridViewForCategory(category As String) As DataGridView
        Select Case category
            Case "Non-Recycled"
                Return dgvNonRecycled
            Case "Recycled"
                Return dgvRecycled
            Case "Other Recycled"
                Return dgvOtherRecycled
            Case "Chemical"
                Return dgvChemical
            Case Else
                Return Nothing
        End Select
    End Function

    Private Function GetDatePickerForCategory(category As String) As DateTimePicker
        Select Case category
            Case "Non-Recycled"
                Return dtpRecordDateNonRecycled
            Case "Recycled"
                Return dtpRecordDateRecycled
            Case "Other Recycled"
                Return dtpRecordDateOtherRecycled
            Case "Chemical"
                Return dtpRecordDateChemical
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub btnUploadDocuments_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()

        ofdDocuments.Multiselect = True
        ofdDocuments.Filter = "All Files|*.*|PDF Files|*.pdf|Image Files|*.jpg;*.png;*.bmp|Word Files|*.doc;*.docx"

        If ofdDocuments.ShowDialog() = DialogResult.OK Then
            If Not uploadedDocuments.ContainsKey(category) Then
                uploadedDocuments(category) = New List(Of String)
            End If
            If Not tempDocumentPaths.ContainsKey(category) Then
                tempDocumentPaths(category) = New List(Of String)
            End If

            For Each file In ofdDocuments.FileNames
                uploadedDocuments(category).Add(file)
                ' Create a temporary copy in the application temp folder
                Dim tempFileName As String = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() & Path.GetExtension(file))
                IO.File.Copy(file, tempFileName, True)
                tempDocumentPaths(category).Add(tempFileName)
            Next
            MessageBox.Show($"{ofdDocuments.FileNames.Length} document(s) selected for {category}.", "Documents Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()
        SaveRecordForCategory(category)
    End Sub

    Private Sub SaveRecordForCategory(category As String)
        Dim cmbCollector As ComboBox = GetComboBoxForCategory(category)
        Dim dtpDate As DateTimePicker = GetDatePickerForCategory(category)

        If cmbCollector.SelectedIndex = -1 Then
            MessageBox.Show($"Please select a waste collector for {category}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim transaction = conn.BeginTransaction()

                Try
                    SaveCategoryEntries(conn, transaction, category, GetTabPageByCategory(category), dtpDate.Value, cmbCollector.SelectedValue, Nothing)

                    transaction.Commit()
                    MessageBox.Show($"Waste records saved successfully for {category}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ClearTabForm(GetTabPageByCategory(category), category)
                    LoadTabRecords(category, GetDataGridViewForCategory(category), dtpFrom.Value, dtpTo.Value)

                    If uploadedDocuments.ContainsKey(category) Then
                        uploadedDocuments(category).Clear()
                    End If
                    If tempDocumentPaths.ContainsKey(category) Then
                        ' Delete temporary files
                        For Each tempFile In tempDocumentPaths(category)
                            Try
                                If File.Exists(tempFile) Then
                                    File.Delete(tempFile)
                                End If
                            Catch
                            End Try
                        Next
                        tempDocumentPaths(category).Clear()
                    End If

                Catch ex As Exception
                    transaction.Rollback()
                    Throw ex
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving {category} records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveCategoryEntries(conn As SqlConnection, transaction As SqlTransaction, category As String, tabPage As TabPage, recordDate As Date, collectorID As Object, existingRecordID As Integer?)
        ' Get the documents for this category (same for all items)
        Dim categoryDocuments As List(Of String) = Nothing
        If uploadedDocuments.ContainsKey(category) AndAlso uploadedDocuments(category).Count > 0 Then
            categoryDocuments = New List(Of String)(uploadedDocuments(category))
        End If

        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                Dim numCtrl As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                If numCtrl.Value > 0 Then
                    Dim wasteType As String = GetWasteTypeFromControl(numCtrl)
                    SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value, recordDate, collectorID, categoryDocuments, existingRecordID)
                End If
            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                Dim flp As FlowLayoutPanel = DirectCast(ctrl, FlowLayoutPanel)
                For Each panel As Control In flp.Controls
                    For Each subCtrl As Control In panel.Controls
                        If TypeOf subCtrl Is NumericUpDown Then
                            Dim numCtrl As NumericUpDown = DirectCast(subCtrl, NumericUpDown)
                            If numCtrl.Value > 0 Then
                                Dim wasteType As String = GetLabelTextFromPanel(panel)
                                SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value, recordDate, collectorID, categoryDocuments, existingRecordID)
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
                            SaveWasteEntry(conn, transaction, category, wasteType, numCtrl.Value, recordDate, collectorID, categoryDocuments, existingRecordID)
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Function GetWasteTypeFromControl(numCtrl As NumericUpDown) As String
        ' Look for label in parent container
        Dim parent As Control = numCtrl.Parent
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Label AndAlso Not String.IsNullOrEmpty(ctrl.Text) Then
                Dim labelText As String = ctrl.Text.Trim()
                If labelText.EndsWith(":") Then
                    Return labelText.TrimEnd(":"c)
                Else
                    Return labelText
                End If
            End If
        Next
        ' If no label found, use the name
        Return numCtrl.Name.Replace("num", "").Replace("Num", "")
    End Function

    Private Function GetLabelTextFromPanel(panel As Control) As String
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is Label Then
                Dim labelText As String = ctrl.Text.Trim()
                If labelText.EndsWith(":") Then
                    Return labelText.TrimEnd(":"c)
                Else
                    Return labelText
                End If
            End If
        Next
        Return "Unknown"
    End Function

    Private Sub SaveWasteEntry(conn As SqlConnection, transaction As SqlTransaction, category As String, wasteType As String, quantity As Decimal, recordDate As Date, collectorID As Object, documents As List(Of String), existingRecordID As Integer?)
        Dim recordID As Integer

        If existingRecordID.HasValue Then
            recordID = existingRecordID.Value
            ' Update existing record
            Dim updateQuery As String = "UPDATE tbl_ESG_WasteRecords SET RecordDate = @RecordDate, WasteCategory = @Category, WasteType = @WasteType, QuantityKG = @Quantity, CollectorID = @CollectorID WHERE RecordID = @RecordID"
            Using cmd As New SqlCommand(updateQuery, conn, transaction)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                cmd.Parameters.AddWithValue("@RecordDate", recordDate.Date)
                cmd.Parameters.AddWithValue("@Category", category)
                cmd.Parameters.AddWithValue("@WasteType", wasteType)
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                cmd.Parameters.AddWithValue("@CollectorID", collectorID)
                cmd.ExecuteNonQuery()
            End Using
        Else
            ' Insert new record
            Dim query As String = "INSERT INTO tbl_ESG_WasteRecords (RecordDate, WasteCategory, WasteType, QuantityKG, CollectorID, AdditionalInfo) 
                                  OUTPUT INSERTED.RecordID
                                  VALUES (@RecordDate, @Category, @WasteType, @Quantity, @CollectorID, @AdditionalInfo)"
            Using cmd As New SqlCommand(query, conn, transaction)
                cmd.Parameters.AddWithValue("@RecordDate", recordDate.Date)
                cmd.Parameters.AddWithValue("@Category", category)
                cmd.Parameters.AddWithValue("@WasteType", wasteType)
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                cmd.Parameters.AddWithValue("@CollectorID", collectorID)
                cmd.Parameters.AddWithValue("@AdditionalInfo", "")
                recordID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End If

        ' Save documents for this record (only for the first item or if documents exist)
        If documents IsNot Nothing AndAlso documents.Count > 0 Then
            ' Check if documents already exist for this record
            Dim docCheckQuery As String = "SELECT COUNT(*) FROM tbl_ESG_WasteDocuments WHERE RecordID = @RecordID"
            Using checkCmd As New SqlCommand(docCheckQuery, conn, transaction)
                checkCmd.Parameters.AddWithValue("@RecordID", recordID)
                Dim docCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If docCount = 0 Then
                    ' Only save documents if none exist for this record
                    For Each filePath In documents
                        ' Use the temporary file path or original
                        Dim sourceFile As String = filePath
                        ' Check if this is a temporary file
                        If tempDocumentPaths.ContainsKey(category) AndAlso tempDocumentPaths(category).Contains(filePath) Then
                            sourceFile = filePath
                        End If

                        Dim savedPath As String = ModShared.SaveSingleFile(sourceFile, recordID.ToString(), category)

                        Dim docQuery As String = "INSERT INTO tbl_ESG_WasteDocuments (RecordID, DocumentName, DocumentPath) VALUES (@RecordID, @DocName, @DocPath)"
                        Using docCmd As New SqlCommand(docQuery, conn, transaction)
                            docCmd.Parameters.AddWithValue("@RecordID", recordID)
                            docCmd.Parameters.AddWithValue("@DocName", Path.GetFileName(filePath))
                            docCmd.Parameters.AddWithValue("@DocPath", savedPath)
                            docCmd.ExecuteNonQuery()
                        End Using
                    Next
                End If
            End Using
        End If
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim grid As DataGridView = DirectCast(sender, DataGridView)

            If e.ColumnIndex >= 0 AndAlso grid.Columns(e.ColumnIndex).Name = "ViewDocument" Then
                Dim recordID As Integer = Convert.ToInt32(grid.Rows(e.RowIndex).Cells("RecordID").Value)
                ViewDocumentsForRecord(recordID)
            Else
                currentRecordID = Convert.ToInt32(grid.Rows(e.RowIndex).Cells("RecordID").Value)
                currentWasteCategory = GetCategoryFromDataGridView(grid)
                LoadRecordForEditing(currentRecordID, currentWasteCategory)
            End If
        End If
    End Sub

    Private Sub ViewDocumentsForRecord(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT DocumentPath, DocumentName FROM tbl_ESG_WasteDocuments WHERE RecordID = @RecordID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RecordID", recordID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim files As New List(Of String)
                    While reader.Read()
                        files.Add(reader("DocumentPath").ToString())
                    End While
                    reader.Close()

                    If files.Count > 0 Then
                        ModShared.OpenMultipleFiles(files)
                    Else
                        MessageBox.Show("No documents found for this record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error viewing documents: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            ClearTabForm(GetTabPageByCategory(category), category)

            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                ' Get all records for this RecordID (there may be multiple waste types per date)
                Dim query As String = "SELECT RecordDate, WasteType, QuantityKG, CollectorID 
                                     FROM tbl_ESG_WasteRecords 
                                     WHERE RecordID = @RecordID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RecordID", recordID)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim firstRecord As Boolean = True
                    While reader.Read()
                        If firstRecord Then
                            Dim dtpDate As DateTimePicker = GetDatePickerForCategory(category)
                            Dim cmbCollector As ComboBox = GetComboBoxForCategory(category)
                            dtpDate.Value = Convert.ToDateTime(reader("RecordDate"))
                            cmbCollector.SelectedValue = Convert.ToInt32(reader("CollectorID"))
                            firstRecord = False
                        End If
                        SetControlValue(category, reader("WasteType").ToString(), Convert.ToDecimal(reader("QuantityKG")))
                    End While
                    reader.Close()
                End Using
            End Using

            tabWasteCategories.SelectedTab = GetTabPageByCategory(category)

        Catch ex As Exception
            MessageBox.Show("Error loading record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetControlValue(category As String, wasteType As String, quantity As Decimal)
        Dim tabPage As TabPage = GetTabPageByCategory(category)

        For Each ctrl As Control In tabPage.Controls
            If TypeOf ctrl Is NumericUpDown Then
                If GetWasteTypeFromControl(DirectCast(ctrl, NumericUpDown)).Equals(wasteType, StringComparison.OrdinalIgnoreCase) Then
                    DirectCast(ctrl, NumericUpDown).Value = quantity
                    Return
                End If
            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                For Each panel As Control In ctrl.Controls
                    If GetLabelTextFromPanel(panel).Equals(wasteType, StringComparison.OrdinalIgnoreCase) Then
                        For Each subCtrl As Control In panel.Controls
                            If TypeOf subCtrl Is NumericUpDown Then
                                DirectCast(subCtrl, NumericUpDown).Value = quantity
                                Return
                            End If
                        Next
                    End If
                Next
            ElseIf ctrl.HasChildren Then
                SetControlValueInContainer(ctrl, wasteType, quantity)
            End If
        Next
    End Sub

    Private Sub SetControlValueInContainer(container As Control, wasteType As String, quantity As Decimal)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is NumericUpDown Then
                If GetWasteTypeFromControl(DirectCast(ctrl, NumericUpDown)).Equals(wasteType, StringComparison.OrdinalIgnoreCase) Then
                    DirectCast(ctrl, NumericUpDown).Value = quantity
                    Return
                End If
            ElseIf ctrl.HasChildren Then
                SetControlValueInContainer(ctrl, wasteType, quantity)
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()

        If currentRecordID = -1 OrElse currentWasteCategory <> category Then
            MessageBox.Show($"Please select a record from {category} to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this record?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = ModShared.GetConnection()
                    conn.Open()
                    Dim transaction = conn.BeginTransaction()

                    Try
                        ' Delete existing records for this record ID
                        Dim deleteQuery As String = "DELETE FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID"
                        Using deleteCmd As New SqlCommand(deleteQuery, conn, transaction)
                            deleteCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        Dim cmbCollector As ComboBox = GetComboBoxForCategory(category)
                        Dim dtpDate As DateTimePicker = GetDatePickerForCategory(category)

                        SaveCategoryEntries(conn, transaction, category, GetTabPageByCategory(category), dtpDate.Value, cmbCollector.SelectedValue, currentRecordID)

                        transaction.Commit()
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ClearTabForm(GetTabPageByCategory(category), category)
                        LoadTabRecords(category, GetDataGridViewForCategory(category), dtpFrom.Value, dtpTo.Value)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()

        If currentRecordID = -1 OrElse currentWasteCategory <> category Then
            MessageBox.Show($"Please select a record from {category} to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record? This will delete ALL waste entries for this date.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = ModShared.GetConnection()
                    conn.Open()

                    ' Use a separate command for getting document paths
                    Dim docPaths As New List(Of String)
                    Dim docQuery As String = "SELECT DocumentPath FROM tbl_ESG_WasteDocuments WHERE RecordID = @RecordID"
                    Using docCmd As New SqlCommand(docQuery, conn)
                        docCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        Using reader As SqlDataReader = docCmd.ExecuteReader()
                            While reader.Read()
                                docPaths.Add(reader("DocumentPath").ToString())
                            End While
                        End Using ' This closes the reader automatically
                    End Using

                    ' Delete associated documents from server
                    For Each filePath As String In docPaths
                        If File.Exists(filePath) Then
                            Try
                                File.Delete(filePath)
                            Catch
                                ' Continue even if file deletion fails
                            End Try
                        End If
                    Next

                    ' Delete documents from database (use a separate connection or command)
                    Using docCmd As New SqlCommand("DELETE FROM tbl_ESG_WasteDocuments WHERE RecordID = @RecordID", conn)
                        docCmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        docCmd.ExecuteNonQuery()
                    End Using

                    ' Delete the records (all waste types for this RecordID)
                    Using cmd As New SqlCommand("DELETE FROM tbl_ESG_WasteRecords WHERE RecordID = @RecordID", conn)
                        cmd.Parameters.AddWithValue("@RecordID", currentRecordID)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then
                            MessageBox.Show("No records found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Record(s) deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using

                LoadTabRecords(category, GetDataGridViewForCategory(category), dtpFrom.Value, dtpTo.Value)
                ClearTabForm(GetTabPageByCategory(category), category)
                currentRecordID = -1
            Catch ex As Exception
                MessageBox.Show("Error deleting record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()
        LoadTabRecords(category, GetDataGridViewForCategory(category), dtpFrom.Value, dtpTo.Value)
        ClearTabForm(GetTabPageByCategory(category), category)
        currentRecordID = -1
        MessageBox.Show($"Records refreshed for {category}.", "Refresh Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnViewLicense_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()
        Dim cmbCollector As ComboBox = GetComboBoxForCategory(category)

        If cmbCollector.SelectedIndex = -1 Then
            MessageBox.Show("Please select a collector first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim collectorID As Integer = Convert.ToInt32(cmbCollector.SelectedValue)

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                conn.Open()
                Dim query As String = "SELECT LicenseDocumentPath FROM tbl_ESG_WasteCollectors WHERE CollectorID = @CollectorID"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CollectorID", collectorID)
                    Dim licensePath As Object = cmd.ExecuteScalar()

                    If licensePath IsNot Nothing AndAlso Not String.IsNullOrEmpty(licensePath.ToString()) Then
                        If File.Exists(licensePath.ToString()) Then
                            ModShared.OpenFileWithDefaultProgram(licensePath.ToString())
                        Else
                            MessageBox.Show("License document file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("No license document uploaded for this collector.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error viewing license: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()
        Dim grid As DataGridView = GetDataGridViewForCategory(category)

        If grid.Rows.Count = 0 Then
            MessageBox.Show($"No data to export for {category}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ModShared.ExportToExcel(grid, $"WasteRecords_{category}")
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()

        If dtpFrom.Value > dtpTo.Value Then
            MessageBox.Show("From date cannot be greater than To date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadTabRecords(category, GetDataGridViewForCategory(category), dtpFrom.Value, dtpTo.Value)
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim category As String = btn.Tag.ToString()
        Dim targetPanel As FlowLayoutPanel = GetFlowLayoutPanelForCategory(category)
        AddDynamicWasteItem(category, targetPanel)
    End Sub

    Private Sub AddDynamicWasteItem(category As String, targetPanel As FlowLayoutPanel)
        Dim inputDialog As New Form()
        inputDialog.Text = "Add New Waste Type"
        inputDialog.Size = New Size(350, 160)
        inputDialog.StartPosition = FormStartPosition.CenterParent
        inputDialog.FormBorderStyle = FormBorderStyle.FixedDialog
        inputDialog.MaximizeBox = False
        inputDialog.MinimizeBox = False

        Dim lbl As New Label() With {.Text = "Waste Type Name:", .Location = New Point(12, 20), .Size = New Size(100, 25)}
        Dim txt As New TextBox() With {.Location = New Point(120, 20), .Size = New Size(200, 25)}
        Dim btnOK As New Button() With {.Text = "OK", .Location = New Point(120, 70), .Size = New Size(90, 35), .DialogResult = DialogResult.OK}
        Dim btnCancel As New Button() With {.Text = "Cancel", .Location = New Point(220, 70), .Size = New Size(90, 35), .DialogResult = DialogResult.Cancel}

        inputDialog.Controls.AddRange({lbl, txt, btnOK, btnCancel})

        If inputDialog.ShowDialog() = DialogResult.OK AndAlso Not String.IsNullOrWhiteSpace(txt.Text) Then
            CreateDynamicWasteControl(category, txt.Text.Trim(), targetPanel)
        End If
    End Sub

    Private Sub CreateDynamicWasteControl(category As String, wasteType As String, targetPanel As FlowLayoutPanel)
        Dim panel As New Panel() With {.Size = New Size(280, 35), .BorderStyle = BorderStyle.FixedSingle, .Margin = New Padding(3)}
        Dim lbl As New Label() With {.Text = wasteType & ":", .Location = New Point(5, 8), .Size = New Size(120, 20)}
        Dim num As New NumericUpDown() With {.Location = New Point(130, 5), .Size = New Size(100, 25), .DecimalPlaces = 2, .Maximum = 999999, .Minimum = 0}
        Dim btnRemove As New Button() With {.Text = "X", .Location = New Point(235, 5), .Size = New Size(35, 25), .BackColor = Color.LightCoral, .FlatStyle = FlatStyle.Flat}

        AddHandler num.ValueChanged, AddressOf CalculateDailyTotal
        AddHandler btnRemove.Click, Sub(s, e)
                                        targetPanel.Controls.Remove(panel)
                                        CalculateDailyTotal(Nothing, Nothing)
                                    End Sub

        panel.Controls.AddRange({lbl, num, btnRemove})
        targetPanel.Controls.Add(panel)
        targetPanel.Visible = True
        btnAddNonRecycledItem.Visible = True
        btnAddRecycledItem.Visible = True
        btnAddOtherRecycledItem.Visible = True
        btnAddChemicalItem.Visible = True
    End Sub

    Private Sub tpNonRecycled_Enter(sender As Object, e As EventArgs) Handles tpNonRecycled.Enter
        currentWasteCategory = "Non-Recycled"
    End Sub

    Private Sub tpRecycled_Enter(sender As Object, e As EventArgs) Handles tpRecycled.Enter
        currentWasteCategory = "Recycled"
    End Sub

    Private Sub tpOtherRecycled_Enter(sender As Object, e As EventArgs) Handles tpOtherRecycled.Enter
        currentWasteCategory = "Other Recycled"
    End Sub

    Private Sub tpChemical_Enter(sender As Object, e As EventArgs) Handles tpChemical.Enter
        currentWasteCategory = "Chemical"
    End Sub

    Private Sub btnDeleteNonRecycled_Click(sender As Object, e As EventArgs) Handles btnDeleteNonRecycled.Click

    End Sub
End Class