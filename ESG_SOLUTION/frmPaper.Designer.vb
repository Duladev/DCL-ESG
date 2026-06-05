<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaper
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpInput = New GroupBox()
        txtComments = New TextBox()
        lblComments = New Label()
        txtTotalCost = New TextBox()
        lblTotalCost = New Label()
        txtPricePerUnit = New TextBox()
        lblPricePerUnit = New Label()
        txtPurchasedScale = New TextBox()
        lblPurchasedScale = New Label()
        txtWeightPerUnit = New TextBox()
        lblWeightPerUnit = New Label()
        txtUnitCount = New TextBox()
        lblUnitCount = New Label()
        txtUnitType = New TextBox()
        lblUnitType = New Label()
        cmbProductType = New ComboBox()
        lblProductType = New Label()
        cmbProductCategory = New ComboBox()
        lblProductCategory = New Label()
        dtpMonth = New DateTimePicker()
        dtpYear = New DateTimePicker()
        lblMonth = New Label()
        lblYear = New Label()
        grpButtons = New GroupBox()
        btnHome = New Button()
        btnClear = New Button()
        btnRefresh = New Button()
        btnExportExcel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnUploadBill = New Button()
        lblFileCount = New Label()
        grpFilter = New GroupBox()
        cmbPaperCategoryFilter = New ComboBox()
        lblCategoryFilter = New Label()
        grpDateFilters = New GroupBox()
        lblYearFilter = New Label()
        cmbYearFilter = New ComboBox()
        lblMonthFilter = New Label()
        cmbMonthFilter = New ComboBox()
        grdData = New DataGridView()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        grpFilter.SuspendLayout()
        grpDateFilters.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(txtComments)
        grpInput.Controls.Add(lblComments)
        grpInput.Controls.Add(txtTotalCost)
        grpInput.Controls.Add(lblTotalCost)
        grpInput.Controls.Add(txtPricePerUnit)
        grpInput.Controls.Add(lblPricePerUnit)
        grpInput.Controls.Add(txtPurchasedScale)
        grpInput.Controls.Add(lblPurchasedScale)
        grpInput.Controls.Add(txtWeightPerUnit)
        grpInput.Controls.Add(lblWeightPerUnit)
        grpInput.Controls.Add(txtUnitCount)
        grpInput.Controls.Add(lblUnitCount)
        grpInput.Controls.Add(txtUnitType)
        grpInput.Controls.Add(lblUnitType)
        grpInput.Controls.Add(cmbProductType)
        grpInput.Controls.Add(lblProductType)
        grpInput.Controls.Add(cmbProductCategory)
        grpInput.Controls.Add(lblProductCategory)
        grpInput.Controls.Add(dtpMonth)
        grpInput.Controls.Add(dtpYear)
        grpInput.Controls.Add(lblMonth)
        grpInput.Controls.Add(lblYear)
        grpInput.Location = New Point(12, 12)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(620, 210)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Paper Inventory Entry"
        ' 
        ' txtComments
        ' 
        txtComments.Location = New Point(140, 180)
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(460, 23)
        txtComments.TabIndex = 21
        ' 
        ' lblComments
        ' 
        lblComments.AutoSize = True
        lblComments.Location = New Point(16, 183)
        lblComments.Name = "lblComments"
        lblComments.Size = New Size(69, 15)
        lblComments.TabIndex = 20
        lblComments.Text = "Comments:"
        ' 
        ' txtTotalCost
        ' 
        txtTotalCost.BackColor = Color.LightGray
        txtTotalCost.Enabled = False
        txtTotalCost.Location = New Point(528, 150)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.Size = New Size(72, 23)
        txtTotalCost.TabIndex = 19
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Location = New Point(452, 153)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(63, 15)
        lblTotalCost.TabIndex = 18
        lblTotalCost.Text = "Total Cost:"
        ' 
        ' txtPricePerUnit
        ' 
        txtPricePerUnit.Location = New Point(312, 150)
        txtPricePerUnit.Name = "txtPricePerUnit"
        txtPricePerUnit.Size = New Size(118, 23)
        txtPricePerUnit.TabIndex = 17
        ' 
        ' lblPricePerUnit
        ' 
        lblPricePerUnit.AutoSize = True
        lblPricePerUnit.Location = New Point(218, 153)
        lblPricePerUnit.Name = "lblPricePerUnit"
        lblPricePerUnit.Size = New Size(81, 15)
        lblPricePerUnit.TabIndex = 16
        lblPricePerUnit.Text = "Price Per Unit:"
        ' 
        ' txtPurchasedScale
        ' 
        txtPurchasedScale.BackColor = Color.LightGray
        txtPurchasedScale.Enabled = False
        txtPurchasedScale.Location = New Point(140, 150)
        txtPurchasedScale.Name = "txtPurchasedScale"
        txtPurchasedScale.Size = New Size(64, 23)
        txtPurchasedScale.TabIndex = 15
        ' 
        ' lblPurchasedScale
        ' 
        lblPurchasedScale.AutoSize = True
        lblPurchasedScale.Location = New Point(16, 153)
        lblPurchasedScale.Name = "lblPurchasedScale"
        lblPurchasedScale.Size = New Size(95, 15)
        lblPurchasedScale.TabIndex = 14
        lblPurchasedScale.Text = "Purchased Scale:"
        ' 
        ' txtWeightPerUnit
        ' 
        txtWeightPerUnit.BackColor = Color.LightGray
        txtWeightPerUnit.Enabled = False
        txtWeightPerUnit.Location = New Point(528, 120)
        txtWeightPerUnit.Name = "txtWeightPerUnit"
        txtWeightPerUnit.Size = New Size(72, 23)
        txtWeightPerUnit.TabIndex = 13
        ' 
        ' lblWeightPerUnit
        ' 
        lblWeightPerUnit.AutoSize = True
        lblWeightPerUnit.Location = New Point(436, 123)
        lblWeightPerUnit.Name = "lblWeightPerUnit"
        lblWeightPerUnit.Size = New Size(93, 15)
        lblWeightPerUnit.TabIndex = 12
        lblWeightPerUnit.Text = "Weight Per Unit:"
        ' 
        ' txtUnitCount
        ' 
        txtUnitCount.Location = New Point(312, 120)
        txtUnitCount.Name = "txtUnitCount"
        txtUnitCount.Size = New Size(102, 23)
        txtUnitCount.TabIndex = 11
        ' 
        ' lblUnitCount
        ' 
        lblUnitCount.AutoSize = True
        lblUnitCount.Location = New Point(218, 123)
        lblUnitCount.Name = "lblUnitCount"
        lblUnitCount.Size = New Size(98, 15)
        lblUnitCount.TabIndex = 10
        lblUnitCount.Text = "Unit Count (Qty):"
        ' 
        ' txtUnitType
        ' 
        txtUnitType.BackColor = Color.LightGray
        txtUnitType.Enabled = False
        txtUnitType.Location = New Point(140, 120)
        txtUnitType.Name = "txtUnitType"
        txtUnitType.Size = New Size(64, 23)
        txtUnitType.TabIndex = 9
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(16, 123)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New Size(60, 15)
        lblUnitType.TabIndex = 8
        lblUnitType.Text = "Unit Type:"
        ' 
        ' cmbProductType
        ' 
        cmbProductType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductType.FormattingEnabled = True
        cmbProductType.Location = New Point(312, 90)
        cmbProductType.Name = "cmbProductType"
        cmbProductType.Size = New Size(156, 23)
        cmbProductType.TabIndex = 7
        ' 
        ' lblProductType
        ' 
        lblProductType.AutoSize = True
        lblProductType.Location = New Point(218, 93)
        lblProductType.Name = "lblProductType"
        lblProductType.Size = New Size(80, 15)
        lblProductType.TabIndex = 6
        lblProductType.Text = "Product Type:"
        ' 
        ' cmbProductCategory
        ' 
        cmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductCategory.FormattingEnabled = True
        cmbProductCategory.Location = New Point(140, 90)
        cmbProductCategory.Name = "cmbProductCategory"
        cmbProductCategory.Size = New Size(64, 23)
        cmbProductCategory.TabIndex = 5
        ' 
        ' lblProductCategory
        ' 
        lblProductCategory.AutoSize = True
        lblProductCategory.Location = New Point(16, 93)
        lblProductCategory.Name = "lblProductCategory"
        lblProductCategory.Size = New Size(103, 15)
        lblProductCategory.TabIndex = 4
        lblProductCategory.Text = "Product Category:"
        ' 
        ' dtpMonth
        ' 
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.Format = DateTimePickerFormat.Custom
        dtpMonth.Location = New Point(436, 26)
        dtpMonth.Name = "dtpMonth"
        dtpMonth.ShowUpDown = True
        dtpMonth.Size = New Size(94, 23)
        dtpMonth.TabIndex = 3
        ' 
        ' dtpYear
        ' 
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(178, 26)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 2
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(384, 28)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 1
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(132, 28)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 0
        lblYear.Text = "Year:"
        ' 
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnHome)
        grpButtons.Controls.Add(btnClear)
        grpButtons.Controls.Add(btnRefresh)
        grpButtons.Controls.Add(btnExportExcel)
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Controls.Add(btnUploadBill)
        grpButtons.Controls.Add(lblFileCount)
        grpButtons.Location = New Point(638, 12)
        grpButtons.Name = "grpButtons"
        grpButtons.Size = New Size(280, 210)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = SystemColors.AppWorkspace
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(15, 172)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(250, 26)
        btnHome.TabIndex = 8
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(148, 140)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(116, 26)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.AppWorkspace
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(15, 140)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(116, 26)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.AppWorkspace
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(15, 105)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(116, 26)
        btnExportExcel.TabIndex = 5
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.AppWorkspace
        btnDelete.Enabled = False
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(148, 105)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(116, 26)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.AppWorkspace
        btnUpdate.Enabled = False
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(15, 70)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 26)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.AppWorkspace
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(148, 70)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 26)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUploadBill
        ' 
        btnUploadBill.Location = New Point(15, 22)
        btnUploadBill.Name = "btnUploadBill"
        btnUploadBill.Size = New Size(116, 26)
        btnUploadBill.TabIndex = 1
        btnUploadBill.Text = "Upload Bills"
        btnUploadBill.UseVisualStyleBackColor = True
        ' 
        ' lblFileCount
        ' 
        lblFileCount.AutoSize = True
        lblFileCount.Location = New Point(148, 30)
        lblFileCount.Name = "lblFileCount"
        lblFileCount.Size = New Size(93, 15)
        lblFileCount.TabIndex = 0
        lblFileCount.Text = "No files selected"
        ' 
        ' grpFilter
        ' 
        grpFilter.Controls.Add(cmbPaperCategoryFilter)
        grpFilter.Controls.Add(lblCategoryFilter)
        grpFilter.Location = New Point(12, 228)
        grpFilter.Name = "grpFilter"
        grpFilter.Size = New Size(300, 45)
        grpFilter.TabIndex = 2
        grpFilter.TabStop = False
        grpFilter.Text = "Category Filter"
        ' 
        ' cmbPaperCategoryFilter
        ' 
        cmbPaperCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaperCategoryFilter.FormattingEnabled = True
        cmbPaperCategoryFilter.Location = New Point(125, 16)
        cmbPaperCategoryFilter.Name = "cmbPaperCategoryFilter"
        cmbPaperCategoryFilter.Size = New Size(156, 23)
        cmbPaperCategoryFilter.TabIndex = 1
        ' 
        ' lblCategoryFilter
        ' 
        lblCategoryFilter.AutoSize = True
        lblCategoryFilter.Location = New Point(16, 19)
        lblCategoryFilter.Name = "lblCategoryFilter"
        lblCategoryFilter.Size = New Size(103, 15)
        lblCategoryFilter.TabIndex = 0
        lblCategoryFilter.Text = "Product Category:"
        ' 
        ' grpDateFilters
        ' 
        grpDateFilters.Controls.Add(lblYearFilter)
        grpDateFilters.Controls.Add(cmbYearFilter)
        grpDateFilters.Controls.Add(lblMonthFilter)
        grpDateFilters.Controls.Add(cmbMonthFilter)
        grpDateFilters.Location = New Point(320, 228)
        grpDateFilters.Name = "grpDateFilters"
        grpDateFilters.Size = New Size(312, 45)
        grpDateFilters.TabIndex = 3
        grpDateFilters.TabStop = False
        grpDateFilters.Text = "Date Filters"
        ' 
        ' lblYearFilter
        ' 
        lblYearFilter.AutoSize = True
        lblYearFilter.Location = New Point(16, 19)
        lblYearFilter.Name = "lblYearFilter"
        lblYearFilter.Size = New Size(32, 15)
        lblYearFilter.TabIndex = 0
        lblYearFilter.Text = "Year:"
        ' 
        ' cmbYearFilter
        ' 
        cmbYearFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearFilter.FormattingEnabled = True
        cmbYearFilter.Location = New Point(54, 16)
        cmbYearFilter.Name = "cmbYearFilter"
        cmbYearFilter.Size = New Size(85, 23)
        cmbYearFilter.TabIndex = 1
        ' 
        ' lblMonthFilter
        ' 
        lblMonthFilter.AutoSize = True
        lblMonthFilter.Location = New Point(155, 19)
        lblMonthFilter.Name = "lblMonthFilter"
        lblMonthFilter.Size = New Size(46, 15)
        lblMonthFilter.TabIndex = 2
        lblMonthFilter.Text = "Month:"
        ' 
        ' cmbMonthFilter
        ' 
        cmbMonthFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMonthFilter.FormattingEnabled = True
        cmbMonthFilter.Location = New Point(207, 16)
        cmbMonthFilter.Name = "cmbMonthFilter"
        cmbMonthFilter.Size = New Size(85, 23)
        cmbMonthFilter.TabIndex = 3
        ' 
        ' grdData
        ' 
        grdData.AllowUserToAddRows = False
        grdData.AllowUserToDeleteRows = False
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(12, 280)
        grdData.Name = "grdData"
        grdData.ReadOnly = True
        grdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdData.Size = New Size(906, 210)
        grdData.TabIndex = 4
        ' 
        ' frmPaper
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 502)
        Controls.Add(grdData)
        Controls.Add(grpDateFilters)
        Controls.Add(grpFilter)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Name = "frmPaper"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Paper Inventory Management"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        grpFilter.ResumeLayout(False)
        grpFilter.PerformLayout()
        grpDateFilters.ResumeLayout(False)
        grpDateFilters.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents lblProductType As Label
    Friend WithEvents txtUnitType As TextBox
    Friend WithEvents lblUnitType As Label
    Friend WithEvents txtUnitCount As TextBox
    Friend WithEvents lblUnitCount As Label
    Friend WithEvents txtWeightPerUnit As TextBox
    Friend WithEvents lblWeightPerUnit As Label
    Friend WithEvents txtPurchasedScale As TextBox
    Friend WithEvents lblPurchasedScale As Label
    Friend WithEvents txtPricePerUnit As TextBox
    Friend WithEvents lblPricePerUnit As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblComments As Label
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUploadBill As Button
    Friend WithEvents lblFileCount As Label
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents cmbPaperCategoryFilter As ComboBox
    Friend WithEvents lblCategoryFilter As Label
    Friend WithEvents grdData As DataGridView
    Friend WithEvents grpDateFilters As GroupBox
    Friend WithEvents lblYearFilter As Label
    Friend WithEvents cmbYearFilter As ComboBox
    Friend WithEvents lblMonthFilter As Label
    Friend WithEvents cmbMonthFilter As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHome As Button
End Class