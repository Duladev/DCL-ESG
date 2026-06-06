<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmElectricity
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
        grpMainAdditional = New GroupBox()
        lblPeakAmount = New Label()
        txtPeakAmount = New TextBox()
        lblNormalAmount = New Label()
        txtNormalAmount = New TextBox()
        lblOffPeakAmount = New Label()
        txtOffPeakAmount = New TextBox()
        lblPeakQty = New Label()
        txtPeakQty = New TextBox()
        lblNormalQty = New Label()
        txtNormalQty = New TextBox()
        lblOffPeakQty = New Label()
        txtOffPeakQty = New TextBox()
        grpOutSource = New GroupBox()
        lblRenewableSource = New Label()
        cmbRenewableSource = New ComboBox()
        lblRenewableCap = New Label()
        txtRenewableCap = New TextBox()
        lblNonRenewableSource = New Label()
        cmbNonRenewableSource = New ComboBox()
        lblNonRenewableCap = New Label()
        txtNonRenewableCap = New TextBox()
        grpControls = New GroupBox()
        dtpMonth = New DateTimePicker()
        dtpYear = New DateTimePicker()
        lblMonth = New Label()
        lblYear = New Label()
        cmbPurchaseType = New ComboBox()
        lblPurchaseType = New Label()
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
        grdData = New DataGridView()
        grpFilters = New GroupBox()
        lblYearFilter = New Label()
        cmbYearFilter = New ComboBox()
        lblMonthFilter = New Label()
        cmbMonthFilter = New ComboBox()
        grpMainAdditional.SuspendLayout()
        grpOutSource.SuspendLayout()
        grpControls.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        grpFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpMainAdditional
        ' 
        grpMainAdditional.Controls.Add(lblPeakAmount)
        grpMainAdditional.Controls.Add(txtPeakAmount)
        grpMainAdditional.Controls.Add(lblNormalAmount)
        grpMainAdditional.Controls.Add(txtNormalAmount)
        grpMainAdditional.Controls.Add(lblOffPeakAmount)
        grpMainAdditional.Controls.Add(txtOffPeakAmount)
        grpMainAdditional.Controls.Add(lblPeakQty)
        grpMainAdditional.Controls.Add(txtPeakQty)
        grpMainAdditional.Controls.Add(lblNormalQty)
        grpMainAdditional.Controls.Add(txtNormalQty)
        grpMainAdditional.Controls.Add(lblOffPeakQty)
        grpMainAdditional.Controls.Add(txtOffPeakQty)
        grpMainAdditional.Location = New Point(12, 80)
        grpMainAdditional.Name = "grpMainAdditional"
        grpMainAdditional.Size = New Size(620, 110)
        grpMainAdditional.TabIndex = 0
        grpMainAdditional.TabStop = False
        grpMainAdditional.Text = "Main / Additional Purchase"
        ' 
        ' lblPeakAmount
        ' 
        lblPeakAmount.AutoSize = True
        lblPeakAmount.Location = New Point(280, 25)
        lblPeakAmount.Name = "lblPeakAmount"
        lblPeakAmount.Size = New Size(111, 15)
        lblPeakAmount.TabIndex = 11
        lblPeakAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtPeakAmount
        ' 
        txtPeakAmount.Location = New Point(412, 22)
        txtPeakAmount.Name = "txtPeakAmount"
        txtPeakAmount.Size = New Size(118, 23)
        txtPeakAmount.TabIndex = 10
        ' 
        ' lblNormalAmount
        ' 
        lblNormalAmount.AutoSize = True
        lblNormalAmount.Location = New Point(280, 55)
        lblNormalAmount.Name = "lblNormalAmount"
        lblNormalAmount.Size = New Size(111, 15)
        lblNormalAmount.TabIndex = 9
        lblNormalAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtNormalAmount
        ' 
        txtNormalAmount.Location = New Point(412, 52)
        txtNormalAmount.Name = "txtNormalAmount"
        txtNormalAmount.Size = New Size(118, 23)
        txtNormalAmount.TabIndex = 8
        ' 
        ' lblOffPeakAmount
        ' 
        lblOffPeakAmount.AutoSize = True
        lblOffPeakAmount.Location = New Point(280, 85)
        lblOffPeakAmount.Name = "lblOffPeakAmount"
        lblOffPeakAmount.Size = New Size(111, 15)
        lblOffPeakAmount.TabIndex = 7
        lblOffPeakAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtOffPeakAmount
        ' 
        txtOffPeakAmount.Location = New Point(412, 82)
        txtOffPeakAmount.Name = "txtOffPeakAmount"
        txtOffPeakAmount.Size = New Size(118, 23)
        txtOffPeakAmount.TabIndex = 6
        ' 
        ' lblPeakQty
        ' 
        lblPeakQty.AutoSize = True
        lblPeakQty.Location = New Point(16, 25)
        lblPeakQty.Name = "lblPeakQty"
        lblPeakQty.Size = New Size(120, 15)
        lblPeakQty.TabIndex = 5
        lblPeakQty.Text = "Peak Time Qty(KWh):"
        ' 
        ' txtPeakQty
        ' 
        txtPeakQty.Location = New Point(142, 22)
        txtPeakQty.Name = "txtPeakQty"
        txtPeakQty.Size = New Size(100, 23)
        txtPeakQty.TabIndex = 4
        ' 
        ' lblNormalQty
        ' 
        lblNormalQty.AutoSize = True
        lblNormalQty.Location = New Point(16, 55)
        lblNormalQty.Name = "lblNormalQty"
        lblNormalQty.Size = New Size(80, 15)
        lblNormalQty.TabIndex = 3
        lblNormalQty.Text = "Normal Time:"
        ' 
        ' txtNormalQty
        ' 
        txtNormalQty.Location = New Point(142, 52)
        txtNormalQty.Name = "txtNormalQty"
        txtNormalQty.Size = New Size(100, 23)
        txtNormalQty.TabIndex = 2
        ' 
        ' lblOffPeakQty
        ' 
        lblOffPeakQty.AutoSize = True
        lblOffPeakQty.Location = New Point(16, 85)
        lblOffPeakQty.Name = "lblOffPeakQty"
        lblOffPeakQty.Size = New Size(87, 15)
        lblOffPeakQty.TabIndex = 1
        lblOffPeakQty.Text = "Off-Peak Time:"
        ' 
        ' txtOffPeakQty
        ' 
        txtOffPeakQty.Location = New Point(142, 82)
        txtOffPeakQty.Name = "txtOffPeakQty"
        txtOffPeakQty.Size = New Size(100, 23)
        txtOffPeakQty.TabIndex = 0
        ' 
        ' grpOutSource
        ' 
        grpOutSource.Controls.Add(lblRenewableSource)
        grpOutSource.Controls.Add(cmbRenewableSource)
        grpOutSource.Controls.Add(lblRenewableCap)
        grpOutSource.Controls.Add(txtRenewableCap)
        grpOutSource.Controls.Add(lblNonRenewableSource)
        grpOutSource.Controls.Add(cmbNonRenewableSource)
        grpOutSource.Controls.Add(lblNonRenewableCap)
        grpOutSource.Controls.Add(txtNonRenewableCap)
        grpOutSource.Location = New Point(12, 75)
        grpOutSource.Name = "grpOutSource"
        grpOutSource.Size = New Size(620, 110)
        grpOutSource.TabIndex = 1
        grpOutSource.TabStop = False
        grpOutSource.Text = "Out-Source Purchase"
        grpOutSource.Visible = False
        ' 
        ' lblRenewableSource
        ' 
        lblRenewableSource.AutoSize = True
        lblRenewableSource.Location = New Point(16, 28)
        lblRenewableSource.Name = "lblRenewableSource"
        lblRenewableSource.Size = New Size(150, 15)
        lblRenewableSource.TabIndex = 7
        lblRenewableSource.Text = "Type Of Renewable Source:"
        ' 
        ' cmbRenewableSource
        ' 
        cmbRenewableSource.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRenewableSource.FormattingEnabled = True
        cmbRenewableSource.Location = New Point(200, 22)
        cmbRenewableSource.Name = "cmbRenewableSource"
        cmbRenewableSource.Size = New Size(150, 23)
        cmbRenewableSource.TabIndex = 6
        ' 
        ' lblRenewableCap
        ' 
        lblRenewableCap.AutoSize = True
        lblRenewableCap.Location = New Point(356, 25)
        lblRenewableCap.Name = "lblRenewableCap"
        lblRenewableCap.Size = New Size(92, 15)
        lblRenewableCap.TabIndex = 5
        lblRenewableCap.Text = "Capacity (KWh):"
        ' 
        ' txtRenewableCap
        ' 
        txtRenewableCap.Location = New Point(458, 22)
        txtRenewableCap.Name = "txtRenewableCap"
        txtRenewableCap.Size = New Size(100, 23)
        txtRenewableCap.TabIndex = 4
        ' 
        ' lblNonRenewableSource
        ' 
        lblNonRenewableSource.AutoSize = True
        lblNonRenewableSource.Location = New Point(16, 58)
        lblNonRenewableSource.Name = "lblNonRenewableSource"
        lblNonRenewableSource.Size = New Size(139, 15)
        lblNonRenewableSource.TabIndex = 3
        lblNonRenewableSource.Text = "Type Of Non-Renewable:"
        ' 
        ' cmbNonRenewableSource
        ' 
        cmbNonRenewableSource.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNonRenewableSource.FormattingEnabled = True
        cmbNonRenewableSource.Location = New Point(200, 52)
        cmbNonRenewableSource.Name = "cmbNonRenewableSource"
        cmbNonRenewableSource.Size = New Size(150, 23)
        cmbNonRenewableSource.TabIndex = 2
        ' 
        ' lblNonRenewableCap
        ' 
        lblNonRenewableCap.AutoSize = True
        lblNonRenewableCap.Location = New Point(356, 55)
        lblNonRenewableCap.Name = "lblNonRenewableCap"
        lblNonRenewableCap.Size = New Size(92, 15)
        lblNonRenewableCap.TabIndex = 1
        lblNonRenewableCap.Text = "Capacity (KWh):"
        ' 
        ' txtNonRenewableCap
        ' 
        txtNonRenewableCap.Location = New Point(458, 52)
        txtNonRenewableCap.Name = "txtNonRenewableCap"
        txtNonRenewableCap.Size = New Size(100, 23)
        txtNonRenewableCap.TabIndex = 0
        ' 
        ' grpControls
        ' 
        grpControls.Controls.Add(dtpMonth)
        grpControls.Controls.Add(dtpYear)
        grpControls.Controls.Add(lblMonth)
        grpControls.Controls.Add(lblYear)
        grpControls.Controls.Add(cmbPurchaseType)
        grpControls.Controls.Add(lblPurchaseType)
        grpControls.Location = New Point(12, 12)
        grpControls.Name = "grpControls"
        grpControls.Size = New Size(620, 62)
        grpControls.TabIndex = 2
        grpControls.TabStop = False
        grpControls.Text = "Selection Controls"
        ' 
        ' dtpMonth
        ' 
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.Format = DateTimePickerFormat.Custom
        dtpMonth.Location = New Point(436, 26)
        dtpMonth.Name = "dtpMonth"
        dtpMonth.ShowUpDown = True
        dtpMonth.Size = New Size(94, 23)
        dtpMonth.TabIndex = 5
        ' 
        ' dtpYear
        ' 
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(296, 26)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 4
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(384, 30)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 3
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(258, 30)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 2
        lblYear.Text = "Year:"
        ' 
        ' cmbPurchaseType
        ' 
        cmbPurchaseType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPurchaseType.FormattingEnabled = True
        cmbPurchaseType.Items.AddRange(New Object() {""})
        cmbPurchaseType.Location = New Point(102, 26)
        cmbPurchaseType.Name = "cmbPurchaseType"
        cmbPurchaseType.Size = New Size(150, 23)
        cmbPurchaseType.TabIndex = 1
        ' 
        ' lblPurchaseType
        ' 
        lblPurchaseType.AutoSize = True
        lblPurchaseType.Location = New Point(10, 30)
        lblPurchaseType.Name = "lblPurchaseType"
        lblPurchaseType.Size = New Size(86, 15)
        lblPurchaseType.TabIndex = 0
        lblPurchaseType.Text = "Purchase Type:"
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
        grpButtons.TabIndex = 3
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
        lblFileCount.Location = New Point(137, 19)
        lblFileCount.Name = "lblFileCount"
        lblFileCount.Size = New Size(93, 15)
        lblFileCount.TabIndex = 0
        lblFileCount.Text = "No files selected"
        ' 
        ' grdData
        ' 
        grdData.AllowUserToAddRows = False
        grdData.AllowUserToDeleteRows = False
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(12, 262)
        grdData.Name = "grdData"
        grdData.ReadOnly = True
        grdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdData.Size = New Size(906, 250)
        grdData.TabIndex = 4
        ' 
        ' grpFilters
        ' 
        grpFilters.Controls.Add(lblYearFilter)
        grpFilters.Controls.Add(cmbYearFilter)
        grpFilters.Controls.Add(lblMonthFilter)
        grpFilters.Controls.Add(cmbMonthFilter)
        grpFilters.Location = New Point(12, 196)
        grpFilters.Name = "grpFilters"
        grpFilters.Size = New Size(300, 55)
        grpFilters.TabIndex = 5
        grpFilters.TabStop = False
        grpFilters.Text = "Filters"
        ' 
        ' lblYearFilter
        ' 
        lblYearFilter.AutoSize = True
        lblYearFilter.Location = New Point(16, 25)
        lblYearFilter.Name = "lblYearFilter"
        lblYearFilter.Size = New Size(32, 15)
        lblYearFilter.TabIndex = 0
        lblYearFilter.Text = "Year:"
        ' 
        ' cmbYearFilter
        ' 
        cmbYearFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearFilter.FormattingEnabled = True
        cmbYearFilter.Location = New Point(60, 22)
        cmbYearFilter.Name = "cmbYearFilter"
        cmbYearFilter.Size = New Size(85, 23)
        cmbYearFilter.TabIndex = 1
        ' 
        ' lblMonthFilter
        ' 
        lblMonthFilter.AutoSize = True
        lblMonthFilter.Location = New Point(160, 25)
        lblMonthFilter.Name = "lblMonthFilter"
        lblMonthFilter.Size = New Size(46, 15)
        lblMonthFilter.TabIndex = 2
        lblMonthFilter.Text = "Month:"
        ' 
        ' cmbMonthFilter
        ' 
        cmbMonthFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMonthFilter.FormattingEnabled = True
        cmbMonthFilter.Location = New Point(212, 22)
        cmbMonthFilter.Name = "cmbMonthFilter"
        cmbMonthFilter.Size = New Size(85, 23)
        cmbMonthFilter.TabIndex = 3
        ' 
        ' frmElectricity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 524)
        Controls.Add(grpFilters)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpControls)
        Controls.Add(grpOutSource)
        Controls.Add(grpMainAdditional)
        Name = "frmElectricity"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Electricity Management"
        grpMainAdditional.ResumeLayout(False)
        grpMainAdditional.PerformLayout()
        grpOutSource.ResumeLayout(False)
        grpOutSource.PerformLayout()
        grpControls.ResumeLayout(False)
        grpControls.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        grpFilters.ResumeLayout(False)
        grpFilters.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpMainAdditional As GroupBox
    Friend WithEvents grpOutSource As GroupBox
    Friend WithEvents grpControls As GroupBox
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents grdData As DataGridView
    Friend WithEvents lblPeakAmount As Label
    Friend WithEvents txtPeakAmount As TextBox
    Friend WithEvents lblNormalAmount As Label
    Friend WithEvents txtNormalAmount As TextBox
    Friend WithEvents lblOffPeakAmount As Label
    Friend WithEvents txtOffPeakAmount As TextBox
    Friend WithEvents lblPeakQty As Label
    Friend WithEvents txtPeakQty As TextBox
    Friend WithEvents lblNormalQty As Label
    Friend WithEvents txtNormalQty As TextBox
    Friend WithEvents lblOffPeakQty As Label
    Friend WithEvents txtOffPeakQty As TextBox
    Friend WithEvents lblRenewableSource As Label
    Friend WithEvents cmbRenewableSource As ComboBox
    Friend WithEvents lblRenewableCap As Label
    Friend WithEvents txtRenewableCap As TextBox
    Friend WithEvents lblNonRenewableSource As Label
    Friend WithEvents cmbNonRenewableSource As ComboBox
    Friend WithEvents lblNonRenewableCap As Label
    Friend WithEvents txtNonRenewableCap As TextBox
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbPurchaseType As ComboBox
    Friend WithEvents lblPurchaseType As Label
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUploadBill As Button
    Friend WithEvents lblFileCount As Label
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents lblYearFilter As Label
    Friend WithEvents cmbYearFilter As ComboBox
    Friend WithEvents lblMonthFilter As Label
    Friend WithEvents cmbMonthFilter As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnHome As Button
End Class