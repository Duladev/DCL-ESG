<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridViewEmployees = New DataGridView()
        GroupBoxGrid = New GroupBox()
        lblRecordCount = New Label()
        btnExportExcel = New Button()
        Label12 = New Label()
        GroupBoxFilters = New GroupBox()
        lblNationalityCount = New Label()
        lblDeptCount = New Label()
        lblCategoryCount = New Label()
        lblGenderCount = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        cmbNationality = New ComboBox()
        cmbDepartment = New ComboBox()
        cmbCategory = New ComboBox()
        cmbGender = New ComboBox()
        btnClearFilters = New Button()
        GroupBoxSearch = New GroupBox()
        btnSearch = New Button()
        txtEmpID = New TextBox()
        Label1 = New Label()
        GroupBoxDetails = New GroupBox()
        txtDistance = New TextBox()
        Label7 = New Label()
        txtNationality = New TextBox()
        Label6 = New Label()
        txtTenure = New TextBox()
        Label5 = New Label()
        txtAge = New TextBox()
        Label4 = New Label()
        txtDOB = New TextBox()
        Label3 = New Label()
        txtDOJ = New TextBox()
        Label2 = New Label()
        txtDepartment = New TextBox()
        txtCategory = New TextBox()
        txtGender = New TextBox()
        txtEmpName = New TextBox()
        txtEmpNo = New TextBox()
        lblDepartment = New Label()
        lblCategory = New Label()
        lblGender = New Label()
        lblEmpName = New Label()
        lblEmpNo = New Label()
        CType(DataGridViewEmployees, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxGrid.SuspendLayout()
        GroupBoxFilters.SuspendLayout()
        GroupBoxSearch.SuspendLayout()
        GroupBoxDetails.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewEmployees
        ' 
        DataGridViewEmployees.AllowUserToAddRows = False
        DataGridViewEmployees.AllowUserToDeleteRows = False
        DataGridViewEmployees.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewEmployees.BackgroundColor = Color.White
        DataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewEmployees.Location = New Point(11, 69)
        DataGridViewEmployees.Name = "DataGridViewEmployees"
        DataGridViewEmployees.ReadOnly = True
        DataGridViewEmployees.RowHeadersWidth = 51
        DataGridViewEmployees.RowTemplate.Height = 24
        DataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewEmployees.Size = New Size(960, 310)
        DataGridViewEmployees.TabIndex = 0
        ' 
        ' GroupBoxGrid
        ' 
        GroupBoxGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxGrid.Controls.Add(lblRecordCount)
        GroupBoxGrid.Controls.Add(btnExportExcel)
        GroupBoxGrid.Controls.Add(DataGridViewEmployees)
        GroupBoxGrid.Controls.Add(Label12)
        GroupBoxGrid.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBoxGrid.Location = New Point(10, 291)
        GroupBoxGrid.Name = "GroupBoxGrid"
        GroupBoxGrid.Size = New Size(977, 385)
        GroupBoxGrid.TabIndex = 1
        GroupBoxGrid.TabStop = False
        GroupBoxGrid.Text = "EMPLOYEE DATA"
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 9F)
        lblRecordCount.Location = New Point(232, 29)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(13, 15)
        lblRecordCount.TabIndex = 3
        lblRecordCount.Text = "0"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportExcel.BackColor = SystemColors.Control
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnExportExcel.ForeColor = SystemColors.ActiveCaptionText
        btnExportExcel.Location = New Point(13, 22)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(98, 28)
        btnExportExcel.TabIndex = 1
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F)
        Label12.Location = New Point(145, 29)
        Label12.Name = "Label12"
        Label12.Size = New Size(81, 15)
        Label12.TabIndex = 2
        Label12.Text = "Total Records:"
        ' 
        ' GroupBoxFilters
        ' 
        GroupBoxFilters.Controls.Add(lblNationalityCount)
        GroupBoxFilters.Controls.Add(lblDeptCount)
        GroupBoxFilters.Controls.Add(lblCategoryCount)
        GroupBoxFilters.Controls.Add(lblGenderCount)
        GroupBoxFilters.Controls.Add(Label11)
        GroupBoxFilters.Controls.Add(Label10)
        GroupBoxFilters.Controls.Add(Label9)
        GroupBoxFilters.Controls.Add(Label8)
        GroupBoxFilters.Controls.Add(cmbNationality)
        GroupBoxFilters.Controls.Add(cmbDepartment)
        GroupBoxFilters.Controls.Add(cmbCategory)
        GroupBoxFilters.Controls.Add(cmbGender)
        GroupBoxFilters.Controls.Add(btnClearFilters)
        GroupBoxFilters.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBoxFilters.Location = New Point(10, 97)
        GroupBoxFilters.Name = "GroupBoxFilters"
        GroupBoxFilters.Size = New Size(426, 167)
        GroupBoxFilters.TabIndex = 2
        GroupBoxFilters.TabStop = False
        GroupBoxFilters.Text = "FILTERS"
        ' 
        ' lblNationalityCount
        ' 
        lblNationalityCount.AutoSize = True
        lblNationalityCount.Font = New Font("Segoe UI", 8.25F)
        lblNationalityCount.Location = New Point(126, 146)
        lblNationalityCount.Name = "lblNationalityCount"
        lblNationalityCount.Size = New Size(19, 13)
        lblNationalityCount.TabIndex = 12
        lblNationalityCount.Text = "(0)"
        ' 
        ' lblDeptCount
        ' 
        lblDeptCount.AutoSize = True
        lblDeptCount.Font = New Font("Segoe UI", 8.25F)
        lblDeptCount.Location = New Point(11, 146)
        lblDeptCount.Name = "lblDeptCount"
        lblDeptCount.Size = New Size(19, 13)
        lblDeptCount.TabIndex = 11
        lblDeptCount.Text = "(0)"
        ' 
        ' lblCategoryCount
        ' 
        lblCategoryCount.AutoSize = True
        lblCategoryCount.Font = New Font("Segoe UI", 8.25F)
        lblCategoryCount.Location = New Point(124, 75)
        lblCategoryCount.Name = "lblCategoryCount"
        lblCategoryCount.Size = New Size(19, 13)
        lblCategoryCount.TabIndex = 10
        lblCategoryCount.Text = "(0)"
        ' 
        ' lblGenderCount
        ' 
        lblGenderCount.AutoSize = True
        lblGenderCount.Font = New Font("Segoe UI", 8.25F)
        lblGenderCount.Location = New Point(13, 75)
        lblGenderCount.Name = "lblGenderCount"
        lblGenderCount.Size = New Size(19, 13)
        lblGenderCount.TabIndex = 9
        lblGenderCount.Text = "(0)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F)
        Label11.Location = New Point(124, 99)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 15)
        Label11.TabIndex = 8
        Label11.Text = "Nationality:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F)
        Label10.Location = New Point(9, 99)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 15)
        Label10.TabIndex = 7
        Label10.Text = "Department:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(120, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 15)
        Label9.TabIndex = 6
        Label9.Text = "Category:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(13, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 15)
        Label8.TabIndex = 5
        Label8.Text = "Gender:"
        ' 
        ' cmbNationality
        ' 
        cmbNationality.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNationality.Font = New Font("Segoe UI", 9F)
        cmbNationality.FormattingEnabled = True
        cmbNationality.Location = New Point(126, 120)
        cmbNationality.Name = "cmbNationality"
        cmbNationality.Size = New Size(99, 23)
        cmbNationality.TabIndex = 4
        ' 
        ' cmbDepartment
        ' 
        cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDepartment.Font = New Font("Segoe UI", 9F)
        cmbDepartment.FormattingEnabled = True
        cmbDepartment.Location = New Point(13, 120)
        cmbDepartment.Name = "cmbDepartment"
        cmbDepartment.Size = New Size(94, 23)
        cmbDepartment.TabIndex = 3
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.Font = New Font("Segoe UI", 9F)
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(124, 49)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(102, 23)
        cmbCategory.TabIndex = 2
        ' 
        ' cmbGender
        ' 
        cmbGender.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGender.Font = New Font("Segoe UI", 9F)
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"All", "Male", "Female"})
        cmbGender.Location = New Point(13, 49)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(94, 23)
        cmbGender.TabIndex = 1
        ' 
        ' btnClearFilters
        ' 
        btnClearFilters.BackColor = SystemColors.Control
        btnClearFilters.FlatStyle = FlatStyle.Flat
        btnClearFilters.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnClearFilters.ForeColor = SystemColors.ActiveCaptionText
        btnClearFilters.Location = New Point(283, 45)
        btnClearFilters.Name = "btnClearFilters"
        btnClearFilters.Size = New Size(88, 28)
        btnClearFilters.TabIndex = 0
        btnClearFilters.Text = "Clear Filters"
        btnClearFilters.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxSearch
        ' 
        GroupBoxSearch.Controls.Add(btnSearch)
        GroupBoxSearch.Controls.Add(txtEmpID)
        GroupBoxSearch.Controls.Add(Label1)
        GroupBoxSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBoxSearch.Location = New Point(10, 11)
        GroupBoxSearch.Name = "GroupBoxSearch"
        GroupBoxSearch.Size = New Size(426, 80)
        GroupBoxSearch.TabIndex = 3
        GroupBoxSearch.TabStop = False
        GroupBoxSearch.Text = "SEARCH"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.Control
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(283, 37)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(88, 28)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtEmpID
        ' 
        txtEmpID.Font = New Font("Segoe UI", 10F)
        txtEmpID.Location = New Point(114, 39)
        txtEmpID.Name = "txtEmpID"
        txtEmpID.Size = New Size(162, 25)
        txtEmpID.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(11, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 15)
        Label1.TabIndex = 0
        Label1.Text = "Employee ID / No:"
        ' 
        ' GroupBoxDetails
        ' 
        GroupBoxDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBoxDetails.Controls.Add(txtDistance)
        GroupBoxDetails.Controls.Add(Label7)
        GroupBoxDetails.Controls.Add(txtNationality)
        GroupBoxDetails.Controls.Add(Label6)
        GroupBoxDetails.Controls.Add(txtTenure)
        GroupBoxDetails.Controls.Add(Label5)
        GroupBoxDetails.Controls.Add(txtAge)
        GroupBoxDetails.Controls.Add(Label4)
        GroupBoxDetails.Controls.Add(txtDOB)
        GroupBoxDetails.Controls.Add(Label3)
        GroupBoxDetails.Controls.Add(txtDOJ)
        GroupBoxDetails.Controls.Add(Label2)
        GroupBoxDetails.Controls.Add(txtDepartment)
        GroupBoxDetails.Controls.Add(txtCategory)
        GroupBoxDetails.Controls.Add(txtGender)
        GroupBoxDetails.Controls.Add(txtEmpName)
        GroupBoxDetails.Controls.Add(txtEmpNo)
        GroupBoxDetails.Controls.Add(lblDepartment)
        GroupBoxDetails.Controls.Add(lblCategory)
        GroupBoxDetails.Controls.Add(lblGender)
        GroupBoxDetails.Controls.Add(lblEmpName)
        GroupBoxDetails.Controls.Add(lblEmpNo)
        GroupBoxDetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        GroupBoxDetails.Location = New Point(442, 24)
        GroupBoxDetails.Name = "GroupBoxDetails"
        GroupBoxDetails.Size = New Size(587, 269)
        GroupBoxDetails.TabIndex = 4
        GroupBoxDetails.TabStop = False
        GroupBoxDetails.Text = "EMPLOYEE DETAILS (Click on row to view)"
        ' 
        ' txtDistance
        ' 
        txtDistance.Font = New Font("Segoe UI", 9F)
        txtDistance.Location = New Point(426, 150)
        txtDistance.Name = "txtDistance"
        txtDistance.ReadOnly = True
        txtDistance.Size = New Size(132, 23)
        txtDistance.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(330, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 20
        Label7.Text = "Manager Dist.:"
        ' 
        ' txtNationality
        ' 
        txtNationality.Font = New Font("Segoe UI", 9F)
        txtNationality.Location = New Point(426, 197)
        txtNationality.Name = "txtNationality"
        txtNationality.ReadOnly = True
        txtNationality.Size = New Size(132, 23)
        txtNationality.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(331, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 15)
        Label6.TabIndex = 18
        Label6.Text = "Nationality:"
        ' 
        ' txtTenure
        ' 
        txtTenure.Font = New Font("Segoe UI", 9F)
        txtTenure.Location = New Point(426, 112)
        txtTenure.Name = "txtTenure"
        txtTenure.ReadOnly = True
        txtTenure.Size = New Size(132, 23)
        txtTenure.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(328, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 16
        Label5.Text = "Tenure (Yrs):"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 9F)
        txtAge.Location = New Point(108, 239)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(176, 23)
        txtAge.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(15, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 14
        Label4.Text = "Age (Yrs):"
        ' 
        ' txtDOB
        ' 
        txtDOB.Font = New Font("Segoe UI", 9F)
        txtDOB.Location = New Point(426, 73)
        txtDOB.Name = "txtDOB"
        txtDOB.ReadOnly = True
        txtDOB.Size = New Size(132, 23)
        txtDOB.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(328, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 12
        Label3.Text = "Date of Birth:"
        ' 
        ' txtDOJ
        ' 
        txtDOJ.Font = New Font("Segoe UI", 9F)
        txtDOJ.Location = New Point(426, 33)
        txtDOJ.Name = "txtDOJ"
        txtDOJ.ReadOnly = True
        txtDOJ.Size = New Size(132, 23)
        txtDOJ.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(328, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 15)
        Label2.TabIndex = 10
        Label2.Text = "Date of Joined:"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Segoe UI", 9F)
        txtDepartment.Location = New Point(108, 194)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.ReadOnly = True
        txtDepartment.Size = New Size(176, 23)
        txtDepartment.TabIndex = 9
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Segoe UI", 9F)
        txtCategory.Location = New Point(108, 145)
        txtCategory.Name = "txtCategory"
        txtCategory.ReadOnly = True
        txtCategory.Size = New Size(176, 23)
        txtCategory.TabIndex = 8
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Segoe UI", 9F)
        txtGender.Location = New Point(108, 104)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(176, 23)
        txtGender.TabIndex = 7
        ' 
        ' txtEmpName
        ' 
        txtEmpName.Font = New Font("Segoe UI", 9F)
        txtEmpName.Location = New Point(108, 65)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.ReadOnly = True
        txtEmpName.Size = New Size(176, 23)
        txtEmpName.TabIndex = 6
        ' 
        ' txtEmpNo
        ' 
        txtEmpNo.Font = New Font("Segoe UI", 9F)
        txtEmpNo.Location = New Point(108, 25)
        txtEmpNo.Name = "txtEmpNo"
        txtEmpNo.ReadOnly = True
        txtEmpNo.Size = New Size(176, 23)
        txtEmpNo.TabIndex = 5
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 9F)
        lblDepartment.Location = New Point(15, 197)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(73, 15)
        lblDepartment.TabIndex = 4
        lblDepartment.Text = "Department:"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Font = New Font("Segoe UI", 9F)
        lblCategory.Location = New Point(15, 150)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(58, 15)
        lblCategory.TabIndex = 3
        lblCategory.Text = "Category:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9F)
        lblGender.Location = New Point(15, 107)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(48, 15)
        lblGender.TabIndex = 2
        lblGender.Text = "Gender:"
        ' 
        ' lblEmpName
        ' 
        lblEmpName.AutoSize = True
        lblEmpName.Font = New Font("Segoe UI", 9F)
        lblEmpName.Location = New Point(15, 68)
        lblEmpName.Name = "lblEmpName"
        lblEmpName.Size = New Size(42, 15)
        lblEmpName.TabIndex = 1
        lblEmpName.Text = "Name:"
        ' 
        ' lblEmpNo
        ' 
        lblEmpNo.AutoSize = True
        lblEmpNo.Font = New Font("Segoe UI", 9F)
        lblEmpNo.Location = New Point(15, 28)
        lblEmpNo.Name = "lblEmpNo"
        lblEmpNo.Size = New Size(81, 15)
        lblEmpNo.TabIndex = 0
        lblEmpNo.Text = "Employee No:"
        ' 
        ' frmEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1067, 688)
        Controls.Add(GroupBoxDetails)
        Controls.Add(GroupBoxSearch)
        Controls.Add(GroupBoxFilters)
        Controls.Add(GroupBoxGrid)
        Name = "frmEmployee"
        Text = "Employee Management System - Details Viewer"
        WindowState = FormWindowState.Maximized
        CType(DataGridViewEmployees, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxGrid.ResumeLayout(False)
        GroupBoxGrid.PerformLayout()
        GroupBoxFilters.ResumeLayout(False)
        GroupBoxFilters.PerformLayout()
        GroupBoxSearch.ResumeLayout(False)
        GroupBoxSearch.PerformLayout()
        GroupBoxDetails.ResumeLayout(False)
        GroupBoxDetails.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewEmployees As DataGridView
    Friend WithEvents GroupBoxGrid As GroupBox
    Friend WithEvents GroupBoxFilters As GroupBox
    Friend WithEvents GroupBoxSearch As GroupBox
    Friend WithEvents GroupBoxDetails As GroupBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents cmbNationality As ComboBox
    Friend WithEvents cmbDepartment As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNationalityCount As Label
    Friend WithEvents lblDeptCount As Label
    Friend WithEvents lblCategoryCount As Label
    Friend WithEvents lblGenderCount As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTenure As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDOB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDOJ As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents txtEmpNo As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblEmpName As Label
    Friend WithEvents lblEmpNo As Label
End Class