Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmEmployee
    Private dtEmployees As New DataTable()

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
        SetupFilters()
        SetupDetailsGroupBox()
        ' Add keypress handlers for Enter key navigation
        AddKeyPressHandlers(Me.Controls)
    End Sub

    Private Sub LoadEmployeeData()
        Try
            Using conn As SqlConnection = GetConnection()
                Dim query As String = "SELECT FullEmpNo, EMP_NO, EPF_NO, SURNAME, INITIALS, NAME, NIC, DATE_JOINED, " &
                                     "DEPT_CODE, DepartmentName, GRP_CODE, GRP_DESC, SECT_CODE, SECTION_DESC, DESIGNATION, " &
                                     "SEX, GRADE, PROCESS_TYPE, WanCode, Pay, PreFix, CATEGORY, ProductName, ADD1, ADD2, ADD3, " &
                                     "TargetDate, DEACTIVATE, RELIGION, Nationality, BDATE " &
                                     "FROM PAYROLL.dbo.vw_pay_emp_master WHERE Pay = 1 ORDER BY FullEmpNo"

                Dim da As New SqlDataAdapter(query, conn)
                dtEmployees.Clear()
                da.Fill(dtEmployees)

                PopulateGridView()
                UpdateFilterCounters()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateGridView()
        ' Clear existing columns
        DataGridViewEmployees.Columns.Clear()

        ' Define columns to display
        DataGridViewEmployees.AutoGenerateColumns = False

        ' Emp_No - FullEmpNo
        Dim colEmpNo As New DataGridViewTextBoxColumn()
        colEmpNo.Name = "Emp_No"
        colEmpNo.HeaderText = "Emp No"
        colEmpNo.DataPropertyName = "FullEmpNo"
        colEmpNo.Width = 120

        ' Emp_Name (Name + Surname)
        Dim colEmpName As New DataGridViewTextBoxColumn()
        colEmpName.Name = "Emp_Name"
        colEmpName.HeaderText = "Employee Name"
        colEmpName.DataPropertyName = "EmpName"
        colEmpName.Width = 200

        ' Gender
        Dim colGender As New DataGridViewTextBoxColumn()
        colGender.Name = "Gender"
        colGender.HeaderText = "Gender"
        colGender.DataPropertyName = "GenderText"
        colGender.Width = 80

        ' Category
        Dim colCategory As New DataGridViewTextBoxColumn()
        colCategory.Name = "Category"
        colCategory.HeaderText = "Category"
        colCategory.DataPropertyName = "CATEGORY"
        colCategory.Width = 100

        ' Department
        Dim colDepartment As New DataGridViewTextBoxColumn()
        colDepartment.Name = "Department"
        colDepartment.HeaderText = "Department"
        colDepartment.DataPropertyName = "DepartmentName"
        colDepartment.Width = 150

        ' Date of Join
        Dim colDOJ As New DataGridViewTextBoxColumn()
        colDOJ.Name = "Date_of_Join"
        colDOJ.HeaderText = "Date of Join"
        colDOJ.DataPropertyName = "DATE_JOINED"
        colDOJ.DefaultCellStyle.Format = "dd/MM/yyyy"
        colDOJ.Width = 100

        ' To or Present (dummy - always "Present")
        Dim colToPresent As New DataGridViewTextBoxColumn()
        colToPresent.Name = "To_or_Present"
        colToPresent.HeaderText = "Status"
        colToPresent.DataPropertyName = "ToPresent"
        colToPresent.Width = 80

        ' Date of Birth
        Dim colDOB As New DataGridViewTextBoxColumn()
        colDOB.Name = "Date_of_Birth"
        colDOB.HeaderText = "Date of Birth"
        colDOB.DataPropertyName = "BDATE"
        colDOB.DefaultCellStyle.Format = "dd/MM/yyyy"
        colDOB.Width = 100

        ' Age(y)
        Dim colAge As New DataGridViewTextBoxColumn()
        colAge.Name = "Age"
        colAge.HeaderText = "Age (Yrs)"
        colAge.DataPropertyName = "Age"
        colAge.Width = 80

        ' Tenure (y)
        Dim colTenure As New DataGridViewTextBoxColumn()
        colTenure.Name = "Tenure"
        colTenure.HeaderText = "Tenure (Yrs)"
        colTenure.DataPropertyName = "Tenure"
        colTenure.Width = 90

        ' Nationalities
        Dim colNationality As New DataGridViewTextBoxColumn()
        colNationality.Name = "Nationalities"
        colNationality.HeaderText = "Nationality"
        colNationality.DataPropertyName = "Nationality"
        colNationality.Width = 120

        ' Add all columns to grid
        DataGridViewEmployees.Columns.AddRange(New DataGridViewColumn() {colEmpNo, colEmpName, colGender, colCategory, colDepartment,
                                                                         colDOJ, colToPresent, colDOB, colAge, colTenure, colNationality})

        ' Create a new DataTable for display with calculated columns
        Dim displayTable As New DataTable()
        displayTable.Columns.Add("FullEmpNo", GetType(String))
        displayTable.Columns.Add("EmpName", GetType(String))
        displayTable.Columns.Add("GenderText", GetType(String))
        displayTable.Columns.Add("CATEGORY", GetType(String))
        displayTable.Columns.Add("DepartmentName", GetType(String))
        displayTable.Columns.Add("DATE_JOINED", GetType(DateTime))
        displayTable.Columns.Add("ToPresent", GetType(String))
        displayTable.Columns.Add("BDATE", GetType(DateTime))
        displayTable.Columns.Add("Age", GetType(Integer))
        displayTable.Columns.Add("Tenure", GetType(Double))
        displayTable.Columns.Add("Nationality", GetType(String))

        ' Populate display table with calculated values
        For Each row As DataRow In dtEmployees.Rows
            Dim displayRow As DataRow = displayTable.NewRow()
            displayRow("FullEmpNo") = row("FullEmpNo").ToString()

            ' Combine Name and Surname
            Dim empName As String = row("NAME").ToString() & " " & row("SURNAME").ToString()
            displayRow("EmpName") = empName.Trim()

            ' Convert SEX (0=Female,1=Male)
            Dim sexValue As Integer? = If(row("SEX") Is DBNull.Value, Nothing, Convert.ToInt32(row("SEX")))
            displayRow("GenderText") = If(sexValue = 1, "Male", If(sexValue = 0, "Female", "N/A"))

            displayRow("CATEGORY") = row("CATEGORY").ToString()
            displayRow("DepartmentName") = row("DepartmentName").ToString()
            displayRow("DATE_JOINED") = If(row("DATE_JOINED") Is DBNull.Value, DBNull.Value, Convert.ToDateTime(row("DATE_JOINED")))
            displayRow("ToPresent") = "Present"
            displayRow("BDATE") = If(row("BDATE") Is DBNull.Value, DBNull.Value, Convert.ToDateTime(row("BDATE")))

            ' Calculate Age
            If row("BDATE") IsNot DBNull.Value Then
                Dim birthDate As DateTime = Convert.ToDateTime(row("BDATE"))
                Dim today As DateTime = DateTime.Today
                Dim age As Integer = today.Year - birthDate.Year
                If birthDate.Date > today.AddYears(-age) Then age -= 1
                displayRow("Age") = age
            Else
                displayRow("Age") = 0
            End If

            ' Calculate Tenure
            If row("DATE_JOINED") IsNot DBNull.Value Then
                Dim joinDate As DateTime = Convert.ToDateTime(row("DATE_JOINED"))
                Dim today As DateTime = DateTime.Today
                Dim tenure As Double = (today - joinDate).TotalDays / 365.25
                displayRow("Tenure") = Math.Round(tenure, 1)
            Else
                displayRow("Tenure") = 0
            End If

            displayRow("Nationality") = row("Nationality").ToString()

            displayTable.Rows.Add(displayRow)
        Next

        DataGridViewEmployees.DataSource = displayTable
        lblRecordCount.Text = displayTable.Rows.Count.ToString()
    End Sub

    Private Sub SetupFilters()
        ' Populate filter comboboxes with unique values from dtEmployees
        cmbGender.Items.Clear()
        cmbGender.Items.Add("All")
        cmbGender.SelectedIndex = 0

        ' Category filter
        Dim categories = dtEmployees.AsEnumerable().Select(Function(r) r("CATEGORY").ToString()).Where(Function(c) Not String.IsNullOrEmpty(c)).Distinct().OrderBy(Function(c) c).ToList()
        categories.Insert(0, "All")
        cmbCategory.DataSource = Nothing
        cmbCategory.DataSource = categories.ToList()

        ' Department filter
        Dim departments = dtEmployees.AsEnumerable().Select(Function(r) r("DepartmentName").ToString()).Where(Function(d) Not String.IsNullOrEmpty(d)).Distinct().OrderBy(Function(d) d).ToList()
        departments.Insert(0, "All")
        cmbDepartment.DataSource = Nothing
        cmbDepartment.DataSource = departments.ToList()

        ' Nationality filter
        Dim nationalities = dtEmployees.AsEnumerable().Select(Function(r) r("Nationality").ToString()).Where(Function(n) Not String.IsNullOrEmpty(n)).Distinct().OrderBy(Function(n) n).ToList()
        nationalities.Insert(0, "All")
        cmbNationality.DataSource = Nothing
        cmbNationality.DataSource = nationalities.ToList()

        ' Remove existing handlers to avoid duplicates, then add
        RemoveHandler cmbGender.SelectedIndexChanged, AddressOf ApplyFilters
        RemoveHandler cmbCategory.SelectedIndexChanged, AddressOf ApplyFilters
        RemoveHandler cmbDepartment.SelectedIndexChanged, AddressOf ApplyFilters
        RemoveHandler cmbNationality.SelectedIndexChanged, AddressOf ApplyFilters

        AddHandler cmbGender.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler cmbCategory.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler cmbDepartment.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler cmbNationality.SelectedIndexChanged, AddressOf ApplyFilters
    End Sub

    Private Sub UpdateFilterCounters()
        ' Count for each filter category
        lblGenderCount.Text = "(" & dtEmployees.AsEnumerable().Select(Function(r) If(r("SEX") Is DBNull.Value, "N/A", If(Convert.ToInt32(r("SEX")) = 1, "Male", "Female"))).Distinct().Count() & ")"
        lblCategoryCount.Text = "(" & dtEmployees.AsEnumerable().Select(Function(r) r("CATEGORY").ToString()).Where(Function(c) Not String.IsNullOrEmpty(c)).Distinct().Count() & ")"
        lblDeptCount.Text = "(" & dtEmployees.AsEnumerable().Select(Function(r) r("DepartmentName").ToString()).Where(Function(d) Not String.IsNullOrEmpty(d)).Distinct().Count() & ")"
        lblNationalityCount.Text = "(" & dtEmployees.AsEnumerable().Select(Function(r) r("Nationality").ToString()).Where(Function(n) Not String.IsNullOrEmpty(n)).Distinct().Count() & ")"
    End Sub

    Private Sub ApplyFilters(sender As Object, e As EventArgs)
        Try
            Dim dv As New DataView(dtEmployees)
            Dim filters As New List(Of String)()

            ' Gender filter (0=Female,1=Male)
            If cmbGender.SelectedItem IsNot Nothing AndAlso cmbGender.SelectedItem.ToString() <> "All" Then
                Dim genderValue As Integer = If(cmbGender.SelectedItem.ToString() = "Male", 1, 0)
                filters.Add($"SEX = {genderValue}")
            End If

            ' Category filter
            If cmbCategory.SelectedItem IsNot Nothing AndAlso cmbCategory.SelectedItem.ToString() <> "All" Then
                filters.Add($"CATEGORY = '{cmbCategory.SelectedItem.ToString().Replace("'", "''")}'")
            End If

            ' Department filter
            If cmbDepartment.SelectedItem IsNot Nothing AndAlso cmbDepartment.SelectedItem.ToString() <> "All" Then
                filters.Add($"DepartmentName = '{cmbDepartment.SelectedItem.ToString().Replace("'", "''")}'")
            End If

            ' Nationality filter
            If cmbNationality.SelectedItem IsNot Nothing AndAlso cmbNationality.SelectedItem.ToString() <> "All" Then
                filters.Add($"Nationality = '{cmbNationality.SelectedItem.ToString().Replace("'", "''")}'")
            End If

            dv.RowFilter = If(filters.Count > 0, String.Join(" AND ", filters), "")

            ' Re-populate grid with filtered data
            Dim filteredTable As DataTable = dv.ToTable()
            PopulateGridViewWithFilteredData(filteredTable)

        Catch ex As Exception
            MessageBox.Show("Error applying filters: " & ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateGridViewWithFilteredData(filteredTable As DataTable)
        ' Similar to PopulateGridView but with filtered data
        Dim displayTable As New DataTable()
        displayTable.Columns.Add("FullEmpNo", GetType(String))
        displayTable.Columns.Add("EmpName", GetType(String))
        displayTable.Columns.Add("GenderText", GetType(String))
        displayTable.Columns.Add("CATEGORY", GetType(String))
        displayTable.Columns.Add("DepartmentName", GetType(String))
        displayTable.Columns.Add("DATE_JOINED", GetType(DateTime))
        displayTable.Columns.Add("ToPresent", GetType(String))
        displayTable.Columns.Add("BDATE", GetType(DateTime))
        displayTable.Columns.Add("Age", GetType(Integer))
        displayTable.Columns.Add("Tenure", GetType(Double))
        displayTable.Columns.Add("Nationality", GetType(String))

        For Each row As DataRow In filteredTable.Rows
            Dim displayRow As DataRow = displayTable.NewRow()
            displayRow("FullEmpNo") = row("FullEmpNo").ToString()
            displayRow("EmpName") = row("NAME").ToString() & " " & row("SURNAME").ToString()
            Dim sexValue As Integer? = If(row("SEX") Is DBNull.Value, Nothing, Convert.ToInt32(row("SEX")))
            displayRow("GenderText") = If(sexValue = 1, "Male", If(sexValue = 0, "Female", "N/A"))
            displayRow("CATEGORY") = row("CATEGORY").ToString()
            displayRow("DepartmentName") = row("DepartmentName").ToString()
            displayRow("DATE_JOINED") = If(row("DATE_JOINED") Is DBNull.Value, DBNull.Value, Convert.ToDateTime(row("DATE_JOINED")))
            displayRow("ToPresent") = "Present"
            displayRow("BDATE") = If(row("BDATE") Is DBNull.Value, DBNull.Value, Convert.ToDateTime(row("BDATE")))

            ' Age calculation
            If row("BDATE") IsNot DBNull.Value Then
                Dim birthDate As DateTime = Convert.ToDateTime(row("BDATE"))
                Dim age As Integer = DateTime.Today.Year - birthDate.Year
                If birthDate.Date > DateTime.Today.AddYears(-age) Then age -= 1
                displayRow("Age") = age
            Else
                displayRow("Age") = 0
            End If

            ' Tenure calculation
            If row("DATE_JOINED") IsNot DBNull.Value Then
                Dim joinDate As DateTime = Convert.ToDateTime(row("DATE_JOINED"))
                Dim tenure As Double = (DateTime.Today - joinDate).TotalDays / 365.25
                displayRow("Tenure") = Math.Round(tenure, 1)
            Else
                displayRow("Tenure") = 0
            End If

            displayRow("Nationality") = row("Nationality").ToString()
            displayTable.Rows.Add(displayRow)
        Next

        DataGridViewEmployees.DataSource = displayTable
        lblRecordCount.Text = displayTable.Rows.Count.ToString()
    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        If cmbGender.Items.Count > 0 Then cmbGender.SelectedIndex = 0
        If cmbCategory.Items.Count > 0 Then cmbCategory.SelectedIndex = 0
        If cmbDepartment.Items.Count > 0 Then cmbDepartment.SelectedIndex = 0
        If cmbNationality.Items.Count > 0 Then cmbNationality.SelectedIndex = 0
        txtEmpID.Clear()
        LoadEmployeeData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtEmpID.Text) Then
            MessageBox.Show("Please enter Employee ID to search", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        For Each row As DataGridViewRow In DataGridViewEmployees.Rows
            If row.Cells("Emp_No").Value.ToString().ToLower().Contains(txtEmpID.Text.ToLower()) Then
                row.Selected = True
                DataGridViewEmployees.FirstDisplayedScrollingRowIndex = row.Index
                DataGridViewEmployees_CellClick(DataGridViewEmployees, New DataGridViewCellEventArgs(0, row.Index))
                Exit For
            End If
        Next
    End Sub

    Private Sub SetupDetailsGroupBox()
        ' This method can be used for any additional setup of the details group box
        ' Remove any hardcoded styling here
    End Sub

    Private Sub DataGridViewEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewEmployees.Rows(e.RowIndex)

            txtEmpNo.Text = selectedRow.Cells("Emp_No").Value.ToString()
            txtEmpName.Text = selectedRow.Cells("Emp_Name").Value.ToString()
            txtGender.Text = selectedRow.Cells("Gender").Value.ToString()
            txtCategory.Text = selectedRow.Cells("Category").Value.ToString()
            txtDepartment.Text = selectedRow.Cells("Department").Value.ToString()
            txtDOJ.Text = If(selectedRow.Cells("Date_of_Join").Value Is DBNull.Value, "", Convert.ToDateTime(selectedRow.Cells("Date_of_Join").Value).ToString("dd/MM/yyyy"))
            txtDOB.Text = If(selectedRow.Cells("Date_of_Birth").Value Is DBNull.Value, "", Convert.ToDateTime(selectedRow.Cells("Date_of_Birth").Value).ToString("dd/MM/yyyy"))
            txtAge.Text = selectedRow.Cells("Age").Value.ToString()
            txtTenure.Text = selectedRow.Cells("Tenure").Value.ToString()
            txtNationality.Text = selectedRow.Cells("Nationalities").Value.ToString()
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
            saveDialog.Title = "Export Employee Data"
            saveDialog.FileName = $"Employee_Export_{DateTime.Now:yyyyMMdd_HHmmss}"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Use the ExportToExcel helper from ModShared
                ExportToExcel(DataGridViewEmployees, "Employee_Data")
                MessageBox.Show("Data exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmpID_TextChanged(sender As Object, e As EventArgs) Handles txtEmpID.TextChanged
        ' Auto-search as user types (optional)
        If txtEmpID.Text.Length >= 3 Then
            btnSearch.PerformClick()
        End If
    End Sub

    ' Helper method to add keypress handlers for Enter key navigation (from ModShared pattern)
    Private Sub AddKeyPressHandlers(controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            If TypeOf ctrl Is TextBox Then
                RemoveHandler ctrl.KeyPress, AddressOf TextBox_KeyPress
                AddHandler ctrl.KeyPress, AddressOf TextBox_KeyPress
            ElseIf ctrl.HasChildren Then
                AddKeyPressHandlers(ctrl.Controls)
            End If
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(13) Then ' Enter key
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'LoadEmployeeData()
        'SetupFilters()
        'SetupDetailsGroupBox()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
    End Sub
End Class