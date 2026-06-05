<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGas
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
        btnAddGasType = New Button()
        txtAmount = New TextBox()
        lblAmount = New Label()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        cmbGasType = New ComboBox()
        lblGasType = New Label()
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
        cmbGasFilter = New ComboBox()
        lblFilter = New Label()
        grdData = New DataGridView()
        grpFilters = New GroupBox()
        lblYearFilter = New Label()
        cmbYearFilter = New ComboBox()
        lblMonthFilter = New Label()
        cmbMonthFilter = New ComboBox()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        grpFilter.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        grpFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(btnAddGasType)
        grpInput.Controls.Add(txtAmount)
        grpInput.Controls.Add(lblAmount)
        grpInput.Controls.Add(txtQuantity)
        grpInput.Controls.Add(lblQuantity)
        grpInput.Controls.Add(cmbGasType)
        grpInput.Controls.Add(lblGasType)
        grpInput.Controls.Add(dtpMonth)
        grpInput.Controls.Add(dtpYear)
        grpInput.Controls.Add(lblMonth)
        grpInput.Controls.Add(lblYear)
        grpInput.Location = New Point(12, 12)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(620, 135)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Gas Data Entry"
        ' 
        ' btnAddGasType
        ' 
        btnAddGasType.Location = New Point(410, 54)
        btnAddGasType.Name = "btnAddGasType"
        btnAddGasType.Size = New Size(94, 23)
        btnAddGasType.TabIndex = 10
        btnAddGasType.Text = "Add Gas Type"
        btnAddGasType.UseVisualStyleBackColor = True
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(436, 90)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(118, 23)
        txtAmount.TabIndex = 9
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(374, 92)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(54, 15)
        lblAmount.TabIndex = 8
        lblAmount.Text = "Amount:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(178, 90)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(118, 23)
        txtQuantity.TabIndex = 7
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(16, 92)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(120, 15)
        lblQuantity.TabIndex = 6
        lblQuantity.Text = "Quantity (KWh/Litre):"
        ' 
        ' cmbGasType
        ' 
        cmbGasType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGasType.FormattingEnabled = True
        cmbGasType.Location = New Point(178, 52)
        cmbGasType.Name = "cmbGasType"
        cmbGasType.Size = New Size(156, 23)
        cmbGasType.TabIndex = 5
        ' 
        ' lblGasType
        ' 
        lblGasType.AutoSize = True
        lblGasType.Location = New Point(16, 54)
        lblGasType.Name = "lblGasType"
        lblGasType.Size = New Size(57, 15)
        lblGasType.TabIndex = 4
        lblGasType.Text = "Gas Type:"
        ' 
        ' dtpMonth
        ' 
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.Format = DateTimePickerFormat.Custom
        dtpMonth.Location = New Point(436, 22)
        dtpMonth.Name = "dtpMonth"
        dtpMonth.ShowUpDown = True
        dtpMonth.Size = New Size(94, 23)
        dtpMonth.TabIndex = 3
        ' 
        ' dtpYear
        ' 
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(178, 22)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 2
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(384, 24)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 1
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(140, 24)
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
        grpButtons.Size = New Size(280, 178)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = SystemColors.AppWorkspace
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(148, 140)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(116, 26)
        btnHome.TabIndex = 8
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(15, 140)
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
        btnRefresh.Location = New Point(148, 105)
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
        btnDelete.Location = New Point(148, 70)
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
        btnSave.Location = New Point(148, 38)
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
        lblFileCount.Location = New Point(148, 19)
        lblFileCount.Name = "lblFileCount"
        lblFileCount.Size = New Size(93, 15)
        lblFileCount.TabIndex = 0
        lblFileCount.Text = "No files selected"
        ' 
        ' grpFilter
        ' 
        grpFilter.Controls.Add(cmbGasFilter)
        grpFilter.Controls.Add(lblFilter)
        grpFilter.Location = New Point(12, 196)
        grpFilter.Name = "grpFilter"
        grpFilter.Size = New Size(300, 45)
        grpFilter.TabIndex = 2
        grpFilter.TabStop = False
        grpFilter.Text = "Gas Type Filter"
        ' 
        ' cmbGasFilter
        ' 
        cmbGasFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGasFilter.FormattingEnabled = True
        cmbGasFilter.Location = New Point(102, 16)
        cmbGasFilter.Name = "cmbGasFilter"
        cmbGasFilter.Size = New Size(156, 23)
        cmbGasFilter.TabIndex = 1
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(16, 19)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(57, 15)
        lblFilter.TabIndex = 0
        lblFilter.Text = "Gas Type:"
        ' 
        ' grdData
        ' 
        grdData.AllowUserToAddRows = False
        grdData.AllowUserToDeleteRows = False
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(12, 281)
        grdData.Name = "grdData"
        grdData.ReadOnly = True
        grdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdData.Size = New Size(906, 231)
        grdData.TabIndex = 3
        ' 
        ' grpFilters
        ' 
        grpFilters.Controls.Add(lblYearFilter)
        grpFilters.Controls.Add(cmbYearFilter)
        grpFilters.Controls.Add(lblMonthFilter)
        grpFilters.Controls.Add(cmbMonthFilter)
        grpFilters.Location = New Point(320, 196)
        grpFilters.Name = "grpFilters"
        grpFilters.Size = New Size(312, 45)
        grpFilters.TabIndex = 6
        grpFilters.TabStop = False
        grpFilters.Text = "Date Filters"
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
        ' frmGas
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 524)
        Controls.Add(grpFilters)
        Controls.Add(grdData)
        Controls.Add(grpFilter)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Name = "frmGas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gas Management"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        grpFilter.ResumeLayout(False)
        grpFilter.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        grpFilters.ResumeLayout(False)
        grpFilters.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbGasType As ComboBox
    Friend WithEvents lblGasType As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnAddGasType As Button
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUploadBill As Button
    Friend WithEvents lblFileCount As Label
    Friend WithEvents grpFilter As GroupBox
    Friend WithEvents cmbGasFilter As ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents grdData As DataGridView
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents lblYearFilter As Label
    Friend WithEvents cmbYearFilter As ComboBox
    Friend WithEvents lblMonthFilter As Label
    Friend WithEvents cmbMonthFilter As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHome As Button
End Class