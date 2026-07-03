<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOwnElectricity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOwnElectricity))
        grpInput = New GroupBox()
        txtComments = New TextBox()
        lblComments = New Label()
        txtSoldCapacity = New TextBox()
        lblSoldCapacity = New Label()
        txtTotalConsumed = New TextBox()
        lblTotalConsumed = New Label()
        txtNonRenewableCap = New TextBox()
        lblNonRenewableCap = New Label()
        cmbNonRenewableType = New ComboBox()
        lblNonRenewableType = New Label()
        txtRenewableCap = New TextBox()
        lblRenewableCap = New Label()
        cmbRenewableType = New ComboBox()
        lblRenewableType = New Label()
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
        grdData = New DataGridView()
        grpFilters = New GroupBox()
        lblYearFilter = New Label()
        cmbYearFilter = New ComboBox()
        lblMonthFilter = New Label()
        cmbMonthFilter = New ComboBox()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
        grpFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(txtComments)
        grpInput.Controls.Add(lblComments)
        grpInput.Controls.Add(txtSoldCapacity)
        grpInput.Controls.Add(lblSoldCapacity)
        grpInput.Controls.Add(txtTotalConsumed)
        grpInput.Controls.Add(lblTotalConsumed)
        grpInput.Controls.Add(txtNonRenewableCap)
        grpInput.Controls.Add(lblNonRenewableCap)
        grpInput.Controls.Add(cmbNonRenewableType)
        grpInput.Controls.Add(lblNonRenewableType)
        grpInput.Controls.Add(txtRenewableCap)
        grpInput.Controls.Add(lblRenewableCap)
        grpInput.Controls.Add(cmbRenewableType)
        grpInput.Controls.Add(lblRenewableType)
        grpInput.Controls.Add(dtpMonth)
        grpInput.Controls.Add(dtpYear)
        grpInput.Controls.Add(lblMonth)
        grpInput.Controls.Add(lblYear)
        grpInput.Location = New Point(12, 12)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(620, 215)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Own Generated Electricity"
        ' 
        ' txtComments
        ' 
        txtComments.Location = New Point(140, 178)
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(468, 30)
        txtComments.TabIndex = 17
        ' 
        ' lblComments
        ' 
        lblComments.AutoSize = True
        lblComments.Location = New Point(16, 180)
        lblComments.Name = "lblComments"
        lblComments.Size = New Size(69, 15)
        lblComments.TabIndex = 16
        lblComments.Text = "Comments:"
        ' 
        ' txtSoldCapacity
        ' 
        txtSoldCapacity.BackColor = Color.LightGray
        txtSoldCapacity.Enabled = False
        txtSoldCapacity.Location = New Point(472, 146)
        txtSoldCapacity.Name = "txtSoldCapacity"
        txtSoldCapacity.Size = New Size(118, 23)
        txtSoldCapacity.TabIndex = 15
        ' 
        ' lblSoldCapacity
        ' 
        lblSoldCapacity.AutoSize = True
        lblSoldCapacity.Location = New Point(318, 150)
        lblSoldCapacity.Name = "lblSoldCapacity"
        lblSoldCapacity.Size = New Size(118, 15)
        lblSoldCapacity.TabIndex = 14
        lblSoldCapacity.Text = "Own Generated Sold:"
        ' 
        ' txtTotalConsumed
        ' 
        txtTotalConsumed.Location = New Point(178, 148)
        txtTotalConsumed.Name = "txtTotalConsumed"
        txtTotalConsumed.Size = New Size(118, 23)
        txtTotalConsumed.TabIndex = 13
        ' 
        ' lblTotalConsumed
        ' 
        lblTotalConsumed.AutoSize = True
        lblTotalConsumed.Location = New Point(16, 150)
        lblTotalConsumed.Name = "lblTotalConsumed"
        lblTotalConsumed.Size = New Size(150, 15)
        lblTotalConsumed.TabIndex = 12
        lblTotalConsumed.Text = "Total Own Generated Used:"
        ' 
        ' txtNonRenewableCap
        ' 
        txtNonRenewableCap.Location = New Point(472, 106)
        txtNonRenewableCap.Name = "txtNonRenewableCap"
        txtNonRenewableCap.Size = New Size(118, 23)
        txtNonRenewableCap.TabIndex = 11
        ' 
        ' lblNonRenewableCap
        ' 
        lblNonRenewableCap.AutoSize = True
        lblNonRenewableCap.Location = New Point(318, 110)
        lblNonRenewableCap.Name = "lblNonRenewableCap"
        lblNonRenewableCap.Size = New Size(148, 15)
        lblNonRenewableCap.TabIndex = 10
        lblNonRenewableCap.Text = "Monthly Generated (KWh):"
        ' 
        ' cmbNonRenewableType
        ' 
        cmbNonRenewableType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNonRenewableType.FormattingEnabled = True
        cmbNonRenewableType.Location = New Point(178, 108)
        cmbNonRenewableType.Name = "cmbNonRenewableType"
        cmbNonRenewableType.Size = New Size(118, 23)
        cmbNonRenewableType.TabIndex = 9
        ' 
        ' lblNonRenewableType
        ' 
        lblNonRenewableType.AutoSize = True
        lblNonRenewableType.Location = New Point(16, 110)
        lblNonRenewableType.Name = "lblNonRenewableType"
        lblNonRenewableType.Size = New Size(123, 15)
        lblNonRenewableType.TabIndex = 8
        lblNonRenewableType.Text = "Non-Renewable Type:"
        ' 
        ' txtRenewableCap
        ' 
        txtRenewableCap.Location = New Point(472, 76)
        txtRenewableCap.Name = "txtRenewableCap"
        txtRenewableCap.Size = New Size(118, 23)
        txtRenewableCap.TabIndex = 7
        ' 
        ' lblRenewableCap
        ' 
        lblRenewableCap.AutoSize = True
        lblRenewableCap.Location = New Point(318, 80)
        lblRenewableCap.Name = "lblRenewableCap"
        lblRenewableCap.Size = New Size(148, 15)
        lblRenewableCap.TabIndex = 6
        lblRenewableCap.Text = "Monthly Generated (KWh):"
        ' 
        ' cmbRenewableType
        ' 
        cmbRenewableType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRenewableType.FormattingEnabled = True
        cmbRenewableType.Location = New Point(178, 78)
        cmbRenewableType.Name = "cmbRenewableType"
        cmbRenewableType.Size = New Size(118, 23)
        cmbRenewableType.TabIndex = 5
        ' 
        ' lblRenewableType
        ' 
        lblRenewableType.AutoSize = True
        lblRenewableType.Location = New Point(16, 80)
        lblRenewableType.Name = "lblRenewableType"
        lblRenewableType.Size = New Size(134, 15)
        lblRenewableType.TabIndex = 4
        lblRenewableType.Text = "Renewable Source Type:"
        ' 
        ' dtpMonth
        ' 
        dtpMonth.CustomFormat = "MMMM"
        dtpMonth.Format = DateTimePickerFormat.Custom
        dtpMonth.Location = New Point(436, 28)
        dtpMonth.Name = "dtpMonth"
        dtpMonth.ShowUpDown = True
        dtpMonth.Size = New Size(94, 23)
        dtpMonth.TabIndex = 3
        ' 
        ' dtpYear
        ' 
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(178, 28)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 2
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(384, 30)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 1
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(140, 30)
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
        grpButtons.Size = New Size(280, 224)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Stretch
        btnHome.Location = New Point(185, 175)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(45, 38)
        btnHome.TabIndex = 10
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(15, 178)
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
        btnRefresh.Location = New Point(148, 143)
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
        btnExportExcel.Location = New Point(15, 143)
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
        btnDelete.Location = New Point(148, 108)
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
        btnUpdate.Location = New Point(15, 108)
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
        btnSave.Location = New Point(148, 73)
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
        ' grdData
        ' 
        grdData.AllowUserToAddRows = False
        grdData.AllowUserToDeleteRows = False
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(12, 297)
        grdData.Name = "grdData"
        grdData.ReadOnly = True
        grdData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdData.Size = New Size(906, 220)
        grdData.TabIndex = 2
        ' 
        ' grpFilters
        ' 
        grpFilters.Controls.Add(lblYearFilter)
        grpFilters.Controls.Add(cmbYearFilter)
        grpFilters.Controls.Add(lblMonthFilter)
        grpFilters.Controls.Add(cmbMonthFilter)
        grpFilters.Location = New Point(12, 233)
        grpFilters.Name = "grpFilters"
        grpFilters.Size = New Size(300, 55)
        grpFilters.TabIndex = 6
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
        ' frmOwnElectricity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(930, 529)
        Controls.Add(grpFilters)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Name = "frmOwnElectricity"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Own Generated Electricity"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
        grpFilters.ResumeLayout(False)
        grpFilters.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents lblComments As Label
    Friend WithEvents txtSoldCapacity As TextBox
    Friend WithEvents lblSoldCapacity As Label
    Friend WithEvents txtTotalConsumed As TextBox
    Friend WithEvents lblTotalConsumed As Label
    Friend WithEvents txtNonRenewableCap As TextBox
    Friend WithEvents lblNonRenewableCap As Label
    Friend WithEvents cmbNonRenewableType As ComboBox
    Friend WithEvents lblNonRenewableType As Label
    Friend WithEvents txtRenewableCap As TextBox
    Friend WithEvents lblRenewableCap As Label
    Friend WithEvents cmbRenewableType As ComboBox
    Friend WithEvents lblRenewableType As Label
    Friend WithEvents dtpMonth As DateTimePicker
    Friend WithEvents dtpYear As DateTimePicker
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents grpButtons As GroupBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUploadBill As Button
    Friend WithEvents lblFileCount As Label
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