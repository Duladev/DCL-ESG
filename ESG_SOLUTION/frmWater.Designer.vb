<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWater
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
        components = New ComponentModel.Container()
        grpWaterPurchased = New GroupBox()
        txtAdditionalAmount = New TextBox()
        lblAdditionalAmount = New Label()
        txtAdditionalWaterQty = New TextBox()
        lblAdditionalWaterQty = New Label()
        txtWaterAmount = New TextBox()
        lblWaterAmount = New Label()
        txtWaterQty = New TextBox()
        lblWaterQty = New Label()
        dtpMonth = New DateTimePicker()
        dtpYear = New DateTimePicker()
        lblMonth = New Label()
        lblYear = New Label()
        grpWaterButtons = New GroupBox()
        btnHome = New Button()
        btnClearWater = New Button()
        btnRefreshWater = New Button()
        btnExportWaterExcel = New Button()
        btnDeleteWater = New Button()
        btnUpdateWater = New Button()
        btnSaveWater = New Button()
        btnUploadWaterBill = New Button()
        lblWaterFileCount = New Label()
        grdWater = New DataGridView()
        grpRainWater = New GroupBox()
        txtRainComments = New TextBox()
        lblRainComments = New Label()
        txtRainRecycled = New TextBox()
        lblRainRecycled = New Label()
        txtRainConsumed = New TextBox()
        lblRainConsumed = New Label()
        txtRainCollected = New TextBox()
        lblRainCollected = New Label()
        dtpRainMonth = New DateTimePicker()
        dtpRainYear = New DateTimePicker()
        lblRainMonth = New Label()
        lblRainYear = New Label()
        grpRainButtons = New GroupBox()
        btnClearRain = New Button()
        btnRefreshRain = New Button()
        btnExportRainExcel = New Button()
        btnDeleteRain = New Button()
        btnUpdateRain = New Button()
        btnSaveRainWater = New Button()
        btnUploadRainBill = New Button()
        lblRainFileCount = New Label()
        grdRainWater = New DataGridView()
        ToolTip1 = New ToolTip(components)
        grpWaterFilters = New GroupBox()
        lblWaterYearFilter = New Label()
        cmbWaterYearFilter = New ComboBox()
        lblWaterMonthFilter = New Label()
        cmbWaterMonthFilter = New ComboBox()
        grpRainFilters = New GroupBox()
        lblRainYearFilter = New Label()
        cmbRainYearFilter = New ComboBox()
        lblRainMonthFilter = New Label()
        cmbRainMonthFilter = New ComboBox()
        grpWaterPurchased.SuspendLayout()
        grpWaterButtons.SuspendLayout()
        CType(grdWater, ComponentModel.ISupportInitialize).BeginInit()
        grpRainWater.SuspendLayout()
        grpRainButtons.SuspendLayout()
        CType(grdRainWater, ComponentModel.ISupportInitialize).BeginInit()
        grpWaterFilters.SuspendLayout()
        grpRainFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpWaterPurchased
        ' 
        grpWaterPurchased.Controls.Add(txtAdditionalAmount)
        grpWaterPurchased.Controls.Add(lblAdditionalAmount)
        grpWaterPurchased.Controls.Add(txtAdditionalWaterQty)
        grpWaterPurchased.Controls.Add(lblAdditionalWaterQty)
        grpWaterPurchased.Controls.Add(txtWaterAmount)
        grpWaterPurchased.Controls.Add(lblWaterAmount)
        grpWaterPurchased.Controls.Add(txtWaterQty)
        grpWaterPurchased.Controls.Add(lblWaterQty)
        grpWaterPurchased.Controls.Add(dtpMonth)
        grpWaterPurchased.Controls.Add(dtpYear)
        grpWaterPurchased.Controls.Add(lblMonth)
        grpWaterPurchased.Controls.Add(lblYear)
        grpWaterPurchased.Location = New Point(12, 12)
        grpWaterPurchased.Name = "grpWaterPurchased"
        grpWaterPurchased.Size = New Size(620, 135)
        grpWaterPurchased.TabIndex = 0
        grpWaterPurchased.TabStop = False
        grpWaterPurchased.Text = "Water Purchased"
        ' 
        ' txtAdditionalAmount
        ' 
        txtAdditionalAmount.Location = New Point(436, 95)
        txtAdditionalAmount.Name = "txtAdditionalAmount"
        txtAdditionalAmount.Size = New Size(118, 23)
        txtAdditionalAmount.TabIndex = 11
        ToolTip1.SetToolTip(txtAdditionalAmount, "(Additional can be for other offices, like NLE, SILOM, etc)")
        ' 
        ' lblAdditionalAmount
        ' 
        lblAdditionalAmount.AutoSize = True
        lblAdditionalAmount.Location = New Point(318, 97)
        lblAdditionalAmount.Name = "lblAdditionalAmount"
        lblAdditionalAmount.Size = New Size(112, 15)
        lblAdditionalAmount.TabIndex = 10
        lblAdditionalAmount.Text = "Additional Amount:"
        ' 
        ' txtAdditionalWaterQty
        ' 
        txtAdditionalWaterQty.Location = New Point(178, 95)
        txtAdditionalWaterQty.Name = "txtAdditionalWaterQty"
        txtAdditionalWaterQty.Size = New Size(118, 23)
        txtAdditionalWaterQty.TabIndex = 9
        ToolTip1.SetToolTip(txtAdditionalWaterQty, "(Additional can be for other offices, like NLE, SILOM, etc)")
        ' 
        ' lblAdditionalWaterQty
        ' 
        lblAdditionalWaterQty.AutoSize = True
        lblAdditionalWaterQty.Location = New Point(16, 97)
        lblAdditionalWaterQty.Name = "lblAdditionalWaterQty"
        lblAdditionalWaterQty.Size = New Size(157, 15)
        lblAdditionalWaterQty.TabIndex = 8
        lblAdditionalWaterQty.Text = "Additional Water Purchased:"
        ' 
        ' txtWaterAmount
        ' 
        txtWaterAmount.Location = New Point(436, 60)
        txtWaterAmount.Name = "txtWaterAmount"
        txtWaterAmount.Size = New Size(118, 23)
        txtWaterAmount.TabIndex = 7
        ' 
        ' lblWaterAmount
        ' 
        lblWaterAmount.AutoSize = True
        lblWaterAmount.Location = New Point(318, 62)
        lblWaterAmount.Name = "lblWaterAmount"
        lblWaterAmount.Size = New Size(54, 15)
        lblWaterAmount.TabIndex = 6
        lblWaterAmount.Text = "Amount:"
        ' 
        ' txtWaterQty
        ' 
        txtWaterQty.Location = New Point(178, 60)
        txtWaterQty.Name = "txtWaterQty"
        txtWaterQty.Size = New Size(118, 23)
        txtWaterQty.TabIndex = 5
        ' 
        ' lblWaterQty
        ' 
        lblWaterQty.AutoSize = True
        lblWaterQty.Location = New Point(16, 62)
        lblWaterQty.Name = "lblWaterQty"
        lblWaterQty.Size = New Size(99, 15)
        lblWaterQty.TabIndex = 4
        lblWaterQty.Text = "Water Purchased:"
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
        lblYear.Location = New Point(140, 28)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 0
        lblYear.Text = "Year:"
        ' 
        ' grpWaterButtons
        ' 
        grpWaterButtons.Controls.Add(btnHome)
        grpWaterButtons.Controls.Add(btnClearWater)
        grpWaterButtons.Controls.Add(btnRefreshWater)
        grpWaterButtons.Controls.Add(btnExportWaterExcel)
        grpWaterButtons.Controls.Add(btnDeleteWater)
        grpWaterButtons.Controls.Add(btnUpdateWater)
        grpWaterButtons.Controls.Add(btnSaveWater)
        grpWaterButtons.Controls.Add(btnUploadWaterBill)
        grpWaterButtons.Controls.Add(lblWaterFileCount)
        grpWaterButtons.Location = New Point(638, 12)
        grpWaterButtons.Name = "grpWaterButtons"
        grpWaterButtons.Size = New Size(280, 178)
        grpWaterButtons.TabIndex = 1
        grpWaterButtons.TabStop = False
        grpWaterButtons.Text = "Water Actions"
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
        ' btnClearWater
        ' 
        btnClearWater.BackColor = SystemColors.AppWorkspace
        btnClearWater.FlatStyle = FlatStyle.Flat
        btnClearWater.ForeColor = Color.White
        btnClearWater.Location = New Point(15, 140)
        btnClearWater.Name = "btnClearWater"
        btnClearWater.Size = New Size(116, 26)
        btnClearWater.TabIndex = 7
        btnClearWater.Text = "Clear"
        btnClearWater.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshWater
        ' 
        btnRefreshWater.BackColor = SystemColors.AppWorkspace
        btnRefreshWater.FlatStyle = FlatStyle.Flat
        btnRefreshWater.ForeColor = Color.White
        btnRefreshWater.Location = New Point(148, 105)
        btnRefreshWater.Name = "btnRefreshWater"
        btnRefreshWater.Size = New Size(116, 26)
        btnRefreshWater.TabIndex = 6
        btnRefreshWater.Text = "Refresh"
        btnRefreshWater.UseVisualStyleBackColor = False
        ' 
        ' btnExportWaterExcel
        ' 
        btnExportWaterExcel.BackColor = SystemColors.AppWorkspace
        btnExportWaterExcel.FlatStyle = FlatStyle.Flat
        btnExportWaterExcel.ForeColor = Color.White
        btnExportWaterExcel.Location = New Point(15, 105)
        btnExportWaterExcel.Name = "btnExportWaterExcel"
        btnExportWaterExcel.Size = New Size(116, 26)
        btnExportWaterExcel.TabIndex = 5
        btnExportWaterExcel.Text = "Export to Excel"
        btnExportWaterExcel.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteWater
        ' 
        btnDeleteWater.BackColor = SystemColors.AppWorkspace
        btnDeleteWater.Enabled = False
        btnDeleteWater.FlatStyle = FlatStyle.Flat
        btnDeleteWater.ForeColor = Color.White
        btnDeleteWater.Location = New Point(148, 70)
        btnDeleteWater.Name = "btnDeleteWater"
        btnDeleteWater.Size = New Size(116, 26)
        btnDeleteWater.TabIndex = 4
        btnDeleteWater.Text = "Delete"
        btnDeleteWater.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateWater
        ' 
        btnUpdateWater.BackColor = SystemColors.AppWorkspace
        btnUpdateWater.Enabled = False
        btnUpdateWater.FlatStyle = FlatStyle.Flat
        btnUpdateWater.ForeColor = Color.White
        btnUpdateWater.Location = New Point(15, 70)
        btnUpdateWater.Name = "btnUpdateWater"
        btnUpdateWater.Size = New Size(116, 26)
        btnUpdateWater.TabIndex = 3
        btnUpdateWater.Text = "Update"
        btnUpdateWater.UseVisualStyleBackColor = False
        ' 
        ' btnSaveWater
        ' 
        btnSaveWater.BackColor = SystemColors.AppWorkspace
        btnSaveWater.FlatStyle = FlatStyle.Flat
        btnSaveWater.ForeColor = Color.White
        btnSaveWater.Location = New Point(148, 35)
        btnSaveWater.Name = "btnSaveWater"
        btnSaveWater.Size = New Size(116, 26)
        btnSaveWater.TabIndex = 2
        btnSaveWater.Text = "Save"
        btnSaveWater.UseVisualStyleBackColor = False
        ' 
        ' btnUploadWaterBill
        ' 
        btnUploadWaterBill.Location = New Point(15, 22)
        btnUploadWaterBill.Name = "btnUploadWaterBill"
        btnUploadWaterBill.Size = New Size(116, 26)
        btnUploadWaterBill.TabIndex = 1
        btnUploadWaterBill.Text = "Upload Bills"
        btnUploadWaterBill.UseVisualStyleBackColor = True
        ' 
        ' lblWaterFileCount
        ' 
        lblWaterFileCount.AutoSize = True
        lblWaterFileCount.Location = New Point(148, 17)
        lblWaterFileCount.Name = "lblWaterFileCount"
        lblWaterFileCount.Size = New Size(93, 15)
        lblWaterFileCount.TabIndex = 0
        lblWaterFileCount.Text = "No files selected"
        ' 
        ' grdWater
        ' 
        grdWater.AllowUserToAddRows = False
        grdWater.AllowUserToDeleteRows = False
        grdWater.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grdWater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdWater.Location = New Point(12, 200)
        grdWater.Name = "grdWater"
        grdWater.ReadOnly = True
        grdWater.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdWater.Size = New Size(906, 120)
        grdWater.TabIndex = 2
        ' 
        ' grpRainWater
        ' 
        grpRainWater.Controls.Add(txtRainComments)
        grpRainWater.Controls.Add(lblRainComments)
        grpRainWater.Controls.Add(txtRainRecycled)
        grpRainWater.Controls.Add(lblRainRecycled)
        grpRainWater.Controls.Add(txtRainConsumed)
        grpRainWater.Controls.Add(lblRainConsumed)
        grpRainWater.Controls.Add(txtRainCollected)
        grpRainWater.Controls.Add(lblRainCollected)
        grpRainWater.Controls.Add(dtpRainMonth)
        grpRainWater.Controls.Add(dtpRainYear)
        grpRainWater.Controls.Add(lblRainMonth)
        grpRainWater.Controls.Add(lblRainYear)
        grpRainWater.Location = New Point(12, 340)
        grpRainWater.Name = "grpRainWater"
        grpRainWater.Size = New Size(620, 135)
        grpRainWater.TabIndex = 3
        grpRainWater.TabStop = False
        grpRainWater.Text = "RainWater Management"
        ' 
        ' txtRainComments
        ' 
        txtRainComments.Location = New Point(178, 105)
        txtRainComments.Name = "txtRainComments"
        txtRainComments.Size = New Size(428, 23)
        txtRainComments.TabIndex = 15
        ' 
        ' lblRainComments
        ' 
        lblRainComments.AutoSize = True
        lblRainComments.Location = New Point(16, 107)
        lblRainComments.Name = "lblRainComments"
        lblRainComments.Size = New Size(69, 15)
        lblRainComments.TabIndex = 14
        lblRainComments.Text = "Comments:"
        ' 
        ' txtRainRecycled
        ' 
        txtRainRecycled.Location = New Point(436, 75)
        txtRainRecycled.Name = "txtRainRecycled"
        txtRainRecycled.Size = New Size(118, 23)
        txtRainRecycled.TabIndex = 13
        ' 
        ' lblRainRecycled
        ' 
        lblRainRecycled.AutoSize = True
        lblRainRecycled.Location = New Point(318, 77)
        lblRainRecycled.Name = "lblRainRecycled"
        lblRainRecycled.Size = New Size(114, 15)
        lblRainRecycled.TabIndex = 12
        lblRainRecycled.Text = "RainWater Recycled:"
        ' 
        ' txtRainConsumed
        ' 
        txtRainConsumed.Location = New Point(178, 75)
        txtRainConsumed.Name = "txtRainConsumed"
        txtRainConsumed.Size = New Size(118, 23)
        txtRainConsumed.TabIndex = 11
        ' 
        ' lblRainConsumed
        ' 
        lblRainConsumed.AutoSize = True
        lblRainConsumed.Location = New Point(16, 77)
        lblRainConsumed.Name = "lblRainConsumed"
        lblRainConsumed.Size = New Size(125, 15)
        lblRainConsumed.TabIndex = 10
        lblRainConsumed.Text = "RainWater Consumed:"
        ' 
        ' txtRainCollected
        ' 
        txtRainCollected.Location = New Point(436, 45)
        txtRainCollected.Name = "txtRainCollected"
        txtRainCollected.Size = New Size(118, 23)
        txtRainCollected.TabIndex = 9
        ' 
        ' lblRainCollected
        ' 
        lblRainCollected.AutoSize = True
        lblRainCollected.Location = New Point(318, 47)
        lblRainCollected.Name = "lblRainCollected"
        lblRainCollected.Size = New Size(117, 15)
        lblRainCollected.TabIndex = 8
        lblRainCollected.Text = "RainWater Collected:"
        ' 
        ' dtpRainMonth
        ' 
        dtpRainMonth.CustomFormat = "MMMM"
        dtpRainMonth.Format = DateTimePickerFormat.Custom
        dtpRainMonth.Location = New Point(436, 19)
        dtpRainMonth.Name = "dtpRainMonth"
        dtpRainMonth.ShowUpDown = True
        dtpRainMonth.Size = New Size(94, 23)
        dtpRainMonth.TabIndex = 7
        ' 
        ' dtpRainYear
        ' 
        dtpRainYear.CustomFormat = "yyyy"
        dtpRainYear.Format = DateTimePickerFormat.Custom
        dtpRainYear.Location = New Point(178, 19)
        dtpRainYear.Name = "dtpRainYear"
        dtpRainYear.ShowUpDown = True
        dtpRainYear.Size = New Size(78, 23)
        dtpRainYear.TabIndex = 6
        ' 
        ' lblRainMonth
        ' 
        lblRainMonth.AutoSize = True
        lblRainMonth.Location = New Point(384, 21)
        lblRainMonth.Name = "lblRainMonth"
        lblRainMonth.Size = New Size(46, 15)
        lblRainMonth.TabIndex = 5
        lblRainMonth.Text = "Month:"
        ' 
        ' lblRainYear
        ' 
        lblRainYear.AutoSize = True
        lblRainYear.Location = New Point(140, 21)
        lblRainYear.Name = "lblRainYear"
        lblRainYear.Size = New Size(32, 15)
        lblRainYear.TabIndex = 4
        lblRainYear.Text = "Year:"
        ' 
        ' grpRainButtons
        ' 
        grpRainButtons.Controls.Add(btnClearRain)
        grpRainButtons.Controls.Add(btnRefreshRain)
        grpRainButtons.Controls.Add(btnExportRainExcel)
        grpRainButtons.Controls.Add(btnDeleteRain)
        grpRainButtons.Controls.Add(btnUpdateRain)
        grpRainButtons.Controls.Add(btnSaveRainWater)
        grpRainButtons.Controls.Add(btnUploadRainBill)
        grpRainButtons.Controls.Add(lblRainFileCount)
        grpRainButtons.Location = New Point(638, 340)
        grpRainButtons.Name = "grpRainButtons"
        grpRainButtons.Size = New Size(280, 173)
        grpRainButtons.TabIndex = 4
        grpRainButtons.TabStop = False
        grpRainButtons.Text = "Rain Water Actions"
        ' 
        ' btnClearRain
        ' 
        btnClearRain.BackColor = SystemColors.AppWorkspace
        btnClearRain.FlatStyle = FlatStyle.Flat
        btnClearRain.ForeColor = Color.White
        btnClearRain.Location = New Point(15, 140)
        btnClearRain.Name = "btnClearRain"
        btnClearRain.Size = New Size(116, 26)
        btnClearRain.TabIndex = 7
        btnClearRain.Text = "Clear"
        btnClearRain.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshRain
        ' 
        btnRefreshRain.BackColor = SystemColors.AppWorkspace
        btnRefreshRain.FlatStyle = FlatStyle.Flat
        btnRefreshRain.ForeColor = Color.White
        btnRefreshRain.Location = New Point(148, 140)
        btnRefreshRain.Name = "btnRefreshRain"
        btnRefreshRain.Size = New Size(116, 26)
        btnRefreshRain.TabIndex = 6
        btnRefreshRain.Text = "Refresh"
        btnRefreshRain.UseVisualStyleBackColor = False
        ' 
        ' btnExportRainExcel
        ' 
        btnExportRainExcel.BackColor = SystemColors.AppWorkspace
        btnExportRainExcel.FlatStyle = FlatStyle.Flat
        btnExportRainExcel.ForeColor = Color.White
        btnExportRainExcel.Location = New Point(15, 101)
        btnExportRainExcel.Name = "btnExportRainExcel"
        btnExportRainExcel.Size = New Size(116, 26)
        btnExportRainExcel.TabIndex = 5
        btnExportRainExcel.Text = "Export to Excel"
        btnExportRainExcel.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRain
        ' 
        btnDeleteRain.BackColor = SystemColors.AppWorkspace
        btnDeleteRain.Enabled = False
        btnDeleteRain.FlatStyle = FlatStyle.Flat
        btnDeleteRain.ForeColor = Color.White
        btnDeleteRain.Location = New Point(148, 101)
        btnDeleteRain.Name = "btnDeleteRain"
        btnDeleteRain.Size = New Size(116, 26)
        btnDeleteRain.TabIndex = 4
        btnDeleteRain.Text = "Delete"
        btnDeleteRain.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRain
        ' 
        btnUpdateRain.BackColor = SystemColors.AppWorkspace
        btnUpdateRain.Enabled = False
        btnUpdateRain.FlatStyle = FlatStyle.Flat
        btnUpdateRain.ForeColor = Color.White
        btnUpdateRain.Location = New Point(15, 66)
        btnUpdateRain.Name = "btnUpdateRain"
        btnUpdateRain.Size = New Size(116, 26)
        btnUpdateRain.TabIndex = 3
        btnUpdateRain.Text = "Update"
        btnUpdateRain.UseVisualStyleBackColor = False
        ' 
        ' btnSaveRainWater
        ' 
        btnSaveRainWater.BackColor = SystemColors.AppWorkspace
        btnSaveRainWater.FlatStyle = FlatStyle.Flat
        btnSaveRainWater.ForeColor = Color.White
        btnSaveRainWater.Location = New Point(148, 66)
        btnSaveRainWater.Name = "btnSaveRainWater"
        btnSaveRainWater.Size = New Size(116, 26)
        btnSaveRainWater.TabIndex = 2
        btnSaveRainWater.Text = "Save"
        btnSaveRainWater.UseVisualStyleBackColor = False
        ' 
        ' btnUploadRainBill
        ' 
        btnUploadRainBill.Location = New Point(15, 22)
        btnUploadRainBill.Name = "btnUploadRainBill"
        btnUploadRainBill.Size = New Size(116, 26)
        btnUploadRainBill.TabIndex = 1
        btnUploadRainBill.Text = "Upload Bills"
        btnUploadRainBill.UseVisualStyleBackColor = True
        ' 
        ' lblRainFileCount
        ' 
        lblRainFileCount.AutoSize = True
        lblRainFileCount.Location = New Point(148, 30)
        lblRainFileCount.Name = "lblRainFileCount"
        lblRainFileCount.Size = New Size(93, 15)
        lblRainFileCount.TabIndex = 0
        lblRainFileCount.Text = "No files selected"
        ' 
        ' grdRainWater
        ' 
        grdRainWater.AllowUserToAddRows = False
        grdRainWater.AllowUserToDeleteRows = False
        grdRainWater.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grdRainWater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdRainWater.Location = New Point(12, 519)
        grdRainWater.Name = "grdRainWater"
        grdRainWater.ReadOnly = True
        grdRainWater.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdRainWater.Size = New Size(906, 134)
        grdRainWater.TabIndex = 6
        ' 
        ' grpWaterFilters
        ' 
        grpWaterFilters.Controls.Add(lblWaterYearFilter)
        grpWaterFilters.Controls.Add(cmbWaterYearFilter)
        grpWaterFilters.Controls.Add(lblWaterMonthFilter)
        grpWaterFilters.Controls.Add(cmbWaterMonthFilter)
        grpWaterFilters.Location = New Point(12, 150)
        grpWaterFilters.Name = "grpWaterFilters"
        grpWaterFilters.Size = New Size(300, 45)
        grpWaterFilters.TabIndex = 7
        grpWaterFilters.TabStop = False
        grpWaterFilters.Text = "Water Filters"
        ' 
        ' lblWaterYearFilter
        ' 
        lblWaterYearFilter.AutoSize = True
        lblWaterYearFilter.Location = New Point(16, 19)
        lblWaterYearFilter.Name = "lblWaterYearFilter"
        lblWaterYearFilter.Size = New Size(32, 15)
        lblWaterYearFilter.TabIndex = 0
        lblWaterYearFilter.Text = "Year:"
        ' 
        ' cmbWaterYearFilter
        ' 
        cmbWaterYearFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbWaterYearFilter.FormattingEnabled = True
        cmbWaterYearFilter.Location = New Point(60, 16)
        cmbWaterYearFilter.Name = "cmbWaterYearFilter"
        cmbWaterYearFilter.Size = New Size(85, 23)
        cmbWaterYearFilter.TabIndex = 1
        ' 
        ' lblWaterMonthFilter
        ' 
        lblWaterMonthFilter.AutoSize = True
        lblWaterMonthFilter.Location = New Point(160, 19)
        lblWaterMonthFilter.Name = "lblWaterMonthFilter"
        lblWaterMonthFilter.Size = New Size(46, 15)
        lblWaterMonthFilter.TabIndex = 2
        lblWaterMonthFilter.Text = "Month:"
        ' 
        ' cmbWaterMonthFilter
        ' 
        cmbWaterMonthFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbWaterMonthFilter.FormattingEnabled = True
        cmbWaterMonthFilter.Location = New Point(212, 16)
        cmbWaterMonthFilter.Name = "cmbWaterMonthFilter"
        cmbWaterMonthFilter.Size = New Size(85, 23)
        cmbWaterMonthFilter.TabIndex = 3
        ' 
        ' grpRainFilters
        ' 
        grpRainFilters.Controls.Add(lblRainYearFilter)
        grpRainFilters.Controls.Add(cmbRainYearFilter)
        grpRainFilters.Controls.Add(lblRainMonthFilter)
        grpRainFilters.Controls.Add(cmbRainMonthFilter)
        grpRainFilters.Location = New Point(12, 474)
        grpRainFilters.Name = "grpRainFilters"
        grpRainFilters.Size = New Size(300, 45)
        grpRainFilters.TabIndex = 8
        grpRainFilters.TabStop = False
        grpRainFilters.Text = "Rain Water Filters"
        ' 
        ' lblRainYearFilter
        ' 
        lblRainYearFilter.AutoSize = True
        lblRainYearFilter.Location = New Point(16, 19)
        lblRainYearFilter.Name = "lblRainYearFilter"
        lblRainYearFilter.Size = New Size(32, 15)
        lblRainYearFilter.TabIndex = 0
        lblRainYearFilter.Text = "Year:"
        ' 
        ' cmbRainYearFilter
        ' 
        cmbRainYearFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRainYearFilter.FormattingEnabled = True
        cmbRainYearFilter.Location = New Point(60, 16)
        cmbRainYearFilter.Name = "cmbRainYearFilter"
        cmbRainYearFilter.Size = New Size(85, 23)
        cmbRainYearFilter.TabIndex = 1
        ' 
        ' lblRainMonthFilter
        ' 
        lblRainMonthFilter.AutoSize = True
        lblRainMonthFilter.Location = New Point(160, 19)
        lblRainMonthFilter.Name = "lblRainMonthFilter"
        lblRainMonthFilter.Size = New Size(46, 15)
        lblRainMonthFilter.TabIndex = 2
        lblRainMonthFilter.Text = "Month:"
        ' 
        ' cmbRainMonthFilter
        ' 
        cmbRainMonthFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRainMonthFilter.FormattingEnabled = True
        cmbRainMonthFilter.Location = New Point(212, 16)
        cmbRainMonthFilter.Name = "cmbRainMonthFilter"
        cmbRainMonthFilter.Size = New Size(85, 23)
        cmbRainMonthFilter.TabIndex = 3
        ' 
        ' frmWater
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(930, 665)
        Controls.Add(grpRainFilters)
        Controls.Add(grpWaterFilters)
        Controls.Add(grdRainWater)
        Controls.Add(grpRainButtons)
        Controls.Add(grpRainWater)
        Controls.Add(grdWater)
        Controls.Add(grpWaterButtons)
        Controls.Add(grpWaterPurchased)
        Name = "frmWater"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Water Management"
        grpWaterPurchased.ResumeLayout(False)
        grpWaterPurchased.PerformLayout()
        grpWaterButtons.ResumeLayout(False)
        grpWaterButtons.PerformLayout()
        CType(grdWater, ComponentModel.ISupportInitialize).EndInit()
        grpRainWater.ResumeLayout(False)
        grpRainWater.PerformLayout()
        grpRainButtons.ResumeLayout(False)
        grpRainButtons.PerformLayout()
        CType(grdRainWater, ComponentModel.ISupportInitialize).EndInit()
        grpWaterFilters.ResumeLayout(False)
        grpWaterFilters.PerformLayout()
        grpRainFilters.ResumeLayout(False)
        grpRainFilters.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpWaterPurchased As GroupBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents txtWaterAmount As TextBox
    Friend WithEvents lblWaterAmount As Label
    Friend WithEvents txtWaterQty As TextBox
    Friend WithEvents lblWaterQty As Label
    Friend WithEvents txtAdditionalAmount As TextBox
    Friend WithEvents lblAdditionalAmount As Label
    Friend WithEvents txtAdditionalWaterQty As TextBox
    Friend WithEvents lblAdditionalWaterQty As Label
    Friend WithEvents grpWaterButtons As GroupBox
    Friend WithEvents btnExportWaterExcel As Button
    Friend WithEvents btnDeleteWater As Button
    Friend WithEvents btnUpdateWater As Button
    Friend WithEvents btnSaveWater As Button
    Friend WithEvents btnUploadWaterBill As Button
    Friend WithEvents lblWaterFileCount As Label
    Friend WithEvents grdWater As DataGridView
    Friend WithEvents grpRainWater As GroupBox
    Friend WithEvents dtpRainMonth As DateTimePicker
    Friend WithEvents dtpRainYear As DateTimePicker
    Friend WithEvents lblRainMonth As Label
    Friend WithEvents lblRainYear As Label
    Friend WithEvents txtRainComments As TextBox
    Friend WithEvents lblRainComments As Label
    Friend WithEvents txtRainRecycled As TextBox
    Friend WithEvents lblRainRecycled As Label
    Friend WithEvents txtRainConsumed As TextBox
    Friend WithEvents lblRainConsumed As Label
    Friend WithEvents txtRainCollected As TextBox
    Friend WithEvents lblRainCollected As Label
    Friend WithEvents grpRainButtons As GroupBox
    Friend WithEvents btnExportRainExcel As Button
    Friend WithEvents btnDeleteRain As Button
    Friend WithEvents btnUpdateRain As Button
    Friend WithEvents btnSaveRainWater As Button
    Friend WithEvents btnUploadRainBill As Button
    Friend WithEvents lblRainFileCount As Label
    Friend WithEvents grdRainWater As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents grpWaterFilters As GroupBox
    Friend WithEvents lblWaterYearFilter As Label
    Friend WithEvents cmbWaterYearFilter As ComboBox
    Friend WithEvents lblWaterMonthFilter As Label
    Friend WithEvents cmbWaterMonthFilter As ComboBox
    Friend WithEvents grpRainFilters As GroupBox
    Friend WithEvents lblRainYearFilter As Label
    Friend WithEvents cmbRainYearFilter As ComboBox
    Friend WithEvents lblRainMonthFilter As Label
    Friend WithEvents cmbRainMonthFilter As ComboBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnClearWater As Button
    Friend WithEvents btnRefreshWater As Button
    Friend WithEvents btnClearRain As Button
    Friend WithEvents btnRefreshRain As Button
End Class