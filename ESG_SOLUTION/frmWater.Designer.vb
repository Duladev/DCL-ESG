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
        btnExportRainExcel = New Button()
        btnDeleteRain = New Button()
        btnUpdateRain = New Button()
        btnSaveRainWater = New Button()
        btnUploadRainBill = New Button()
        lblRainFileCount = New Label()
        grpRainFilter = New GroupBox()
        cmbRainMonthFilter = New ComboBox()
        lblRainFilter = New Label()
        grdRainWater = New DataGridView()
        ToolTip1 = New ToolTip(components)
        grpWaterPurchased.SuspendLayout()
        grpWaterButtons.SuspendLayout()
        CType(grdWater, ComponentModel.ISupportInitialize).BeginInit()
        grpRainWater.SuspendLayout()
        grpRainButtons.SuspendLayout()
        grpRainFilter.SuspendLayout()
        CType(grdRainWater, ComponentModel.ISupportInitialize).BeginInit()
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
        grpWaterPurchased.Location = New Point(10, 9)
        grpWaterPurchased.Margin = New Padding(3, 2, 3, 2)
        grpWaterPurchased.Name = "grpWaterPurchased"
        grpWaterPurchased.Padding = New Padding(3, 2, 3, 2)
        grpWaterPurchased.Size = New Size(622, 149)
        grpWaterPurchased.TabIndex = 0
        grpWaterPurchased.TabStop = False
        grpWaterPurchased.Text = "Water Purchased"
        ' 
        ' txtAdditionalAmount
        ' 
        txtAdditionalAmount.Location = New Point(436, 95)
        txtAdditionalAmount.Margin = New Padding(3, 2, 3, 2)
        txtAdditionalAmount.Name = "txtAdditionalAmount"
        txtAdditionalAmount.Size = New Size(118, 23)
        txtAdditionalAmount.TabIndex = 11
        ToolTip1.SetToolTip(txtAdditionalAmount, "(Additional  can be for other offices, like NLE, SILOM, etc)")
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
        txtAdditionalWaterQty.Margin = New Padding(3, 2, 3, 2)
        txtAdditionalWaterQty.Name = "txtAdditionalWaterQty"
        txtAdditionalWaterQty.Size = New Size(118, 23)
        txtAdditionalWaterQty.TabIndex = 9
        ToolTip1.SetToolTip(txtAdditionalWaterQty, "(Additional  can be for other offices, like NLE, SILOM, etc)")
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
        txtWaterAmount.Margin = New Padding(3, 2, 3, 2)
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
        txtWaterQty.Margin = New Padding(3, 2, 3, 2)
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
        dtpMonth.Margin = New Padding(3, 2, 3, 2)
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
        dtpYear.Margin = New Padding(3, 2, 3, 2)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 2
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(374, 28)
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
        ' grpWaterButtons
        ' 
        grpWaterButtons.Controls.Add(btnExportWaterExcel)
        grpWaterButtons.Controls.Add(btnDeleteWater)
        grpWaterButtons.Controls.Add(btnUpdateWater)
        grpWaterButtons.Controls.Add(btnSaveWater)
        grpWaterButtons.Controls.Add(btnUploadWaterBill)
        grpWaterButtons.Controls.Add(lblWaterFileCount)
        grpWaterButtons.Location = New Point(638, 9)
        grpWaterButtons.Margin = New Padding(3, 2, 3, 2)
        grpWaterButtons.Name = "grpWaterButtons"
        grpWaterButtons.Padding = New Padding(3, 2, 3, 2)
        grpWaterButtons.Size = New Size(280, 135)
        grpWaterButtons.TabIndex = 1
        grpWaterButtons.TabStop = False
        grpWaterButtons.Text = "Actions"
        ' 
        ' btnExportWaterExcel
        ' 
        btnExportWaterExcel.BackColor = SystemColors.AppWorkspace
        btnExportWaterExcel.FlatStyle = FlatStyle.Flat
        btnExportWaterExcel.ForeColor = Color.White
        btnExportWaterExcel.Location = New Point(16, 105)
        btnExportWaterExcel.Margin = New Padding(3, 2, 3, 2)
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
        btnDeleteWater.Location = New Point(148, 68)
        btnDeleteWater.Margin = New Padding(3, 2, 3, 2)
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
        btnUpdateWater.Location = New Point(16, 68)
        btnUpdateWater.Margin = New Padding(3, 2, 3, 2)
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
        btnSaveWater.Location = New Point(148, 30)
        btnSaveWater.Margin = New Padding(3, 2, 3, 2)
        btnSaveWater.Name = "btnSaveWater"
        btnSaveWater.Size = New Size(116, 26)
        btnSaveWater.TabIndex = 2
        btnSaveWater.Text = "Save"
        btnSaveWater.UseVisualStyleBackColor = False
        ' 
        ' btnUploadWaterBill
        ' 
        btnUploadWaterBill.Location = New Point(16, 22)
        btnUploadWaterBill.Margin = New Padding(3, 2, 3, 2)
        btnUploadWaterBill.Name = "btnUploadWaterBill"
        btnUploadWaterBill.Size = New Size(116, 26)
        btnUploadWaterBill.TabIndex = 1
        btnUploadWaterBill.Text = "Upload Bills"
        btnUploadWaterBill.UseVisualStyleBackColor = True
        ' 
        ' lblWaterFileCount
        ' 
        lblWaterFileCount.AutoSize = True
        lblWaterFileCount.Location = New Point(148, 30)
        lblWaterFileCount.Name = "lblWaterFileCount"
        lblWaterFileCount.Size = New Size(93, 15)
        lblWaterFileCount.TabIndex = 0
        lblWaterFileCount.Text = "No files selected"
        ' 
        ' grdWater
        ' 
        grdWater.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grdWater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdWater.Location = New Point(10, 162)
        grdWater.Margin = New Padding(3, 2, 3, 2)
        grdWater.Name = "grdWater"
        grdWater.RowHeadersWidth = 62
        grdWater.RowTemplate.Height = 28
        grdWater.Size = New Size(929, 112)
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
        grpRainWater.Location = New Point(10, 278)
        grpRainWater.Margin = New Padding(3, 2, 3, 2)
        grpRainWater.Name = "grpRainWater"
        grpRainWater.Padding = New Padding(3, 2, 3, 2)
        grpRainWater.Size = New Size(622, 135)
        grpRainWater.TabIndex = 3
        grpRainWater.TabStop = False
        grpRainWater.Text = "RainWater Management"
        ' 
        ' txtRainComments
        ' 
        txtRainComments.Location = New Point(178, 105)
        txtRainComments.Margin = New Padding(3, 2, 3, 2)
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
        txtRainRecycled.Margin = New Padding(3, 2, 3, 2)
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
        txtRainConsumed.Margin = New Padding(3, 2, 3, 2)
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
        txtRainCollected.Margin = New Padding(3, 2, 3, 2)
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
        dtpRainMonth.Margin = New Padding(3, 2, 3, 2)
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
        dtpRainYear.Margin = New Padding(3, 2, 3, 2)
        dtpRainYear.Name = "dtpRainYear"
        dtpRainYear.ShowUpDown = True
        dtpRainYear.Size = New Size(78, 23)
        dtpRainYear.TabIndex = 6
        ' 
        ' lblRainMonth
        ' 
        lblRainMonth.AutoSize = True
        lblRainMonth.Location = New Point(374, 21)
        lblRainMonth.Name = "lblRainMonth"
        lblRainMonth.Size = New Size(46, 15)
        lblRainMonth.TabIndex = 5
        lblRainMonth.Text = "Month:"
        ' 
        ' lblRainYear
        ' 
        lblRainYear.AutoSize = True
        lblRainYear.Location = New Point(132, 21)
        lblRainYear.Name = "lblRainYear"
        lblRainYear.Size = New Size(32, 15)
        lblRainYear.TabIndex = 4
        lblRainYear.Text = "Year:"
        ' 
        ' grpRainButtons
        ' 
        grpRainButtons.Controls.Add(btnExportRainExcel)
        grpRainButtons.Controls.Add(btnDeleteRain)
        grpRainButtons.Controls.Add(btnUpdateRain)
        grpRainButtons.Controls.Add(btnSaveRainWater)
        grpRainButtons.Controls.Add(btnUploadRainBill)
        grpRainButtons.Controls.Add(lblRainFileCount)
        grpRainButtons.Location = New Point(638, 278)
        grpRainButtons.Margin = New Padding(3, 2, 3, 2)
        grpRainButtons.Name = "grpRainButtons"
        grpRainButtons.Padding = New Padding(3, 2, 3, 2)
        grpRainButtons.Size = New Size(280, 135)
        grpRainButtons.TabIndex = 4
        grpRainButtons.TabStop = False
        grpRainButtons.Text = "Actions"
        ' 
        ' btnExportRainExcel
        ' 
        btnExportRainExcel.BackColor = SystemColors.AppWorkspace
        btnExportRainExcel.FlatStyle = FlatStyle.Flat
        btnExportRainExcel.ForeColor = Color.White
        btnExportRainExcel.Location = New Point(16, 105)
        btnExportRainExcel.Margin = New Padding(3, 2, 3, 2)
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
        btnDeleteRain.Location = New Point(148, 68)
        btnDeleteRain.Margin = New Padding(3, 2, 3, 2)
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
        btnUpdateRain.Location = New Point(16, 68)
        btnUpdateRain.Margin = New Padding(3, 2, 3, 2)
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
        btnSaveRainWater.Location = New Point(148, 30)
        btnSaveRainWater.Margin = New Padding(3, 2, 3, 2)
        btnSaveRainWater.Name = "btnSaveRainWater"
        btnSaveRainWater.Size = New Size(116, 26)
        btnSaveRainWater.TabIndex = 2
        btnSaveRainWater.Text = "Save"
        btnSaveRainWater.UseVisualStyleBackColor = False
        ' 
        ' btnUploadRainBill
        ' 
        btnUploadRainBill.Location = New Point(16, 22)
        btnUploadRainBill.Margin = New Padding(3, 2, 3, 2)
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
        ' grpRainFilter
        ' 
        grpRainFilter.Controls.Add(cmbRainMonthFilter)
        grpRainFilter.Controls.Add(lblRainFilter)
        grpRainFilter.Location = New Point(10, 417)
        grpRainFilter.Margin = New Padding(3, 2, 3, 2)
        grpRainFilter.Name = "grpRainFilter"
        grpRainFilter.Padding = New Padding(3, 2, 3, 2)
        grpRainFilter.Size = New Size(908, 38)
        grpRainFilter.TabIndex = 5
        grpRainFilter.TabStop = False
        grpRainFilter.Text = "Filters"
        ' 
        ' cmbRainMonthFilter
        ' 
        cmbRainMonthFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRainMonthFilter.FormattingEnabled = True
        cmbRainMonthFilter.Items.AddRange(New Object() {"All", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        cmbRainMonthFilter.Location = New Point(102, 15)
        cmbRainMonthFilter.Margin = New Padding(3, 2, 3, 2)
        cmbRainMonthFilter.Name = "cmbRainMonthFilter"
        cmbRainMonthFilter.Size = New Size(78, 23)
        cmbRainMonthFilter.TabIndex = 1
        ' 
        ' lblRainFilter
        ' 
        lblRainFilter.AutoSize = True
        lblRainFilter.Location = New Point(16, 17)
        lblRainFilter.Name = "lblRainFilter"
        lblRainFilter.Size = New Size(46, 15)
        lblRainFilter.TabIndex = 0
        lblRainFilter.Text = "Month:"
        ' 
        ' grdRainWater
        ' 
        grdRainWater.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grdRainWater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdRainWater.Location = New Point(10, 459)
        grdRainWater.Margin = New Padding(3, 2, 3, 2)
        grdRainWater.Name = "grdRainWater"
        grdRainWater.RowHeadersWidth = 62
        grdRainWater.RowTemplate.Height = 28
        grdRainWater.Size = New Size(929, 112)
        grdRainWater.TabIndex = 6
        ' 
        ' ToolTip1
        ' 
        ToolTip1.BackColor = SystemColors.GrayText
        ToolTip1.IsBalloon = True
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ' 
        ' frmWater
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(949, 627)
        Controls.Add(grdRainWater)
        Controls.Add(grpRainFilter)
        Controls.Add(grpRainButtons)
        Controls.Add(grpRainWater)
        Controls.Add(grdWater)
        Controls.Add(grpWaterButtons)
        Controls.Add(grpWaterPurchased)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmWater"
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
        grpRainFilter.ResumeLayout(False)
        grpRainFilter.PerformLayout()
        CType(grdRainWater, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpRainFilter As GroupBox
    Friend WithEvents cmbRainMonthFilter As ComboBox
    Friend WithEvents lblRainFilter As Label
    Friend WithEvents grdRainWater As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class