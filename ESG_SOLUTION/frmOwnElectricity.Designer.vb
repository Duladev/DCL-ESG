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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.txtSoldCapacity = New System.Windows.Forms.TextBox()
        Me.lblSoldCapacity = New System.Windows.Forms.Label()
        Me.txtTotalConsumed = New System.Windows.Forms.TextBox()
        Me.lblTotalConsumed = New System.Windows.Forms.Label()
        Me.txtNonRenewableCap = New System.Windows.Forms.TextBox()
        Me.lblNonRenewableCap = New System.Windows.Forms.Label()
        Me.cmbNonRenewableType = New System.Windows.Forms.ComboBox()
        Me.lblNonRenewableType = New System.Windows.Forms.Label()
        Me.txtRenewableCap = New System.Windows.Forms.TextBox()
        Me.lblRenewableCap = New System.Windows.Forms.Label()
        Me.cmbRenewableType = New System.Windows.Forms.ComboBox()
        Me.lblRenewableType = New System.Windows.Forms.Label()
        Me.dtpMonth = New System.Windows.Forms.DateTimePicker()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUploadBill = New System.Windows.Forms.Button()
        Me.lblFileCount = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.lblYearFilter = New System.Windows.Forms.Label()
        Me.cmbYearFilter = New System.Windows.Forms.ComboBox()
        Me.lblMonthFilter = New System.Windows.Forms.Label()
        Me.cmbMonthFilter = New System.Windows.Forms.ComboBox()
        Me.grpInput.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilters.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtComments)
        Me.grpInput.Controls.Add(Me.lblComments)
        Me.grpInput.Controls.Add(Me.txtSoldCapacity)
        Me.grpInput.Controls.Add(Me.lblSoldCapacity)
        Me.grpInput.Controls.Add(Me.txtTotalConsumed)
        Me.grpInput.Controls.Add(Me.lblTotalConsumed)
        Me.grpInput.Controls.Add(Me.txtNonRenewableCap)
        Me.grpInput.Controls.Add(Me.lblNonRenewableCap)
        Me.grpInput.Controls.Add(Me.cmbNonRenewableType)
        Me.grpInput.Controls.Add(Me.lblNonRenewableType)
        Me.grpInput.Controls.Add(Me.txtRenewableCap)
        Me.grpInput.Controls.Add(Me.lblRenewableCap)
        Me.grpInput.Controls.Add(Me.cmbRenewableType)
        Me.grpInput.Controls.Add(Me.lblRenewableType)
        Me.grpInput.Controls.Add(Me.dtpMonth)
        Me.grpInput.Controls.Add(Me.dtpYear)
        Me.grpInput.Controls.Add(Me.lblMonth)
        Me.grpInput.Controls.Add(Me.lblYear)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(620, 215)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Own Generated Electricity"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(140, 178)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(468, 30)
        Me.txtComments.TabIndex = 17
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(16, 180)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(69, 15)
        Me.lblComments.TabIndex = 16
        Me.lblComments.Text = "Comments:"
        '
        'txtSoldCapacity
        '
        Me.txtSoldCapacity.BackColor = System.Drawing.Color.LightGray
        Me.txtSoldCapacity.Enabled = False
        Me.txtSoldCapacity.Location = New System.Drawing.Point(436, 148)
        Me.txtSoldCapacity.Name = "txtSoldCapacity"
        Me.txtSoldCapacity.Size = New System.Drawing.Size(118, 23)
        Me.txtSoldCapacity.TabIndex = 15
        '
        'lblSoldCapacity
        '
        Me.lblSoldCapacity.AutoSize = True
        Me.lblSoldCapacity.Location = New System.Drawing.Point(318, 150)
        Me.lblSoldCapacity.Name = "lblSoldCapacity"
        Me.lblSoldCapacity.Size = New System.Drawing.Size(118, 15)
        Me.lblSoldCapacity.TabIndex = 14
        Me.lblSoldCapacity.Text = "Own Generated Sold:"
        '
        'txtTotalConsumed
        '
        Me.txtTotalConsumed.Location = New System.Drawing.Point(178, 148)
        Me.txtTotalConsumed.Name = "txtTotalConsumed"
        Me.txtTotalConsumed.Size = New System.Drawing.Size(118, 23)
        Me.txtTotalConsumed.TabIndex = 13
        '
        'lblTotalConsumed
        '
        Me.lblTotalConsumed.AutoSize = True
        Me.lblTotalConsumed.Location = New System.Drawing.Point(16, 150)
        Me.lblTotalConsumed.Name = "lblTotalConsumed"
        Me.lblTotalConsumed.Size = New System.Drawing.Size(150, 15)
        Me.lblTotalConsumed.TabIndex = 12
        Me.lblTotalConsumed.Text = "Total Own Generated Used:"
        '
        'txtNonRenewableCap
        '
        Me.txtNonRenewableCap.Location = New System.Drawing.Point(436, 108)
        Me.txtNonRenewableCap.Name = "txtNonRenewableCap"
        Me.txtNonRenewableCap.Size = New System.Drawing.Size(118, 23)
        Me.txtNonRenewableCap.TabIndex = 11
        '
        'lblNonRenewableCap
        '
        Me.lblNonRenewableCap.AutoSize = True
        Me.lblNonRenewableCap.Location = New System.Drawing.Point(318, 110)
        Me.lblNonRenewableCap.Name = "lblNonRenewableCap"
        Me.lblNonRenewableCap.Size = New System.Drawing.Size(112, 15)
        Me.lblNonRenewableCap.TabIndex = 10
        Me.lblNonRenewableCap.Text = "Monthly Generated:"
        '
        'cmbNonRenewableType
        '
        Me.cmbNonRenewableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNonRenewableType.FormattingEnabled = True
        Me.cmbNonRenewableType.Location = New System.Drawing.Point(178, 108)
        Me.cmbNonRenewableType.Name = "cmbNonRenewableType"
        Me.cmbNonRenewableType.Size = New System.Drawing.Size(118, 23)
        Me.cmbNonRenewableType.TabIndex = 9
        '
        'lblNonRenewableType
        '
        Me.lblNonRenewableType.AutoSize = True
        Me.lblNonRenewableType.Location = New System.Drawing.Point(16, 110)
        Me.lblNonRenewableType.Name = "lblNonRenewableType"
        Me.lblNonRenewableType.Size = New System.Drawing.Size(123, 15)
        Me.lblNonRenewableType.TabIndex = 8
        Me.lblNonRenewableType.Text = "Non-Renewable Type:"
        '
        'txtRenewableCap
        '
        Me.txtRenewableCap.Location = New System.Drawing.Point(436, 78)
        Me.txtRenewableCap.Name = "txtRenewableCap"
        Me.txtRenewableCap.Size = New System.Drawing.Size(118, 23)
        Me.txtRenewableCap.TabIndex = 7
        '
        'lblRenewableCap
        '
        Me.lblRenewableCap.AutoSize = True
        Me.lblRenewableCap.Location = New System.Drawing.Point(318, 80)
        Me.lblRenewableCap.Name = "lblRenewableCap"
        Me.lblRenewableCap.Size = New System.Drawing.Size(112, 15)
        Me.lblRenewableCap.TabIndex = 6
        Me.lblRenewableCap.Text = "Monthly Generated:"
        '
        'cmbRenewableType
        '
        Me.cmbRenewableType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRenewableType.FormattingEnabled = True
        Me.cmbRenewableType.Location = New System.Drawing.Point(178, 78)
        Me.cmbRenewableType.Name = "cmbRenewableType"
        Me.cmbRenewableType.Size = New System.Drawing.Size(118, 23)
        Me.cmbRenewableType.TabIndex = 5
        '
        'lblRenewableType
        '
        Me.lblRenewableType.AutoSize = True
        Me.lblRenewableType.Location = New System.Drawing.Point(16, 80)
        Me.lblRenewableType.Name = "lblRenewableType"
        Me.lblRenewableType.Size = New System.Drawing.Size(134, 15)
        Me.lblRenewableType.TabIndex = 4
        Me.lblRenewableType.Text = "Renewable Source Type:"
        '
        'dtpMonth
        '
        Me.dtpMonth.CustomFormat = "MMMM"
        Me.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonth.Location = New System.Drawing.Point(436, 28)
        Me.dtpMonth.Name = "dtpMonth"
        Me.dtpMonth.ShowUpDown = True
        Me.dtpMonth.Size = New System.Drawing.Size(94, 23)
        Me.dtpMonth.TabIndex = 3
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(178, 28)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(78, 23)
        Me.dtpYear.TabIndex = 2
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(384, 30)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(46, 15)
        Me.lblMonth.TabIndex = 1
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(140, 30)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 15)
        Me.lblYear.TabIndex = 0
        Me.lblYear.Text = "Year:"
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnHome)
        Me.grpButtons.Controls.Add(Me.btnClear)
        Me.grpButtons.Controls.Add(Me.btnRefresh)
        Me.grpButtons.Controls.Add(Me.btnExportExcel)
        Me.grpButtons.Controls.Add(Me.btnDelete)
        Me.grpButtons.Controls.Add(Me.btnUpdate)
        Me.grpButtons.Controls.Add(Me.btnSave)
        Me.grpButtons.Controls.Add(Me.btnUploadBill)
        Me.grpButtons.Controls.Add(Me.lblFileCount)
        Me.grpButtons.Location = New System.Drawing.Point(638, 12)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(280, 215)
        Me.grpButtons.TabIndex = 1
        Me.grpButtons.TabStop = False
        Me.grpButtons.Text = "Actions"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(148, 178)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(116, 26)
        Me.btnHome.TabIndex = 8
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(15, 178)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 26)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(148, 143)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(116, 26)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportExcel.Location = New System.Drawing.Point(15, 143)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(116, 26)
        Me.btnExportExcel.TabIndex = 5
        Me.btnExportExcel.Text = "Export to Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDelete.Enabled = False
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(148, 108)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(116, 26)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(15, 108)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 26)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(148, 73)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 26)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUploadBill
        '
        Me.btnUploadBill.Location = New System.Drawing.Point(15, 22)
        Me.btnUploadBill.Name = "btnUploadBill"
        Me.btnUploadBill.Size = New System.Drawing.Size(116, 26)
        Me.btnUploadBill.TabIndex = 1
        Me.btnUploadBill.Text = "Upload Bills"
        Me.btnUploadBill.UseVisualStyleBackColor = True
        '
        'lblFileCount
        '
        Me.lblFileCount.AutoSize = True
        Me.lblFileCount.Location = New System.Drawing.Point(148, 30)
        Me.lblFileCount.Name = "lblFileCount"
        Me.lblFileCount.Size = New System.Drawing.Size(93, 15)
        Me.lblFileCount.TabIndex = 0
        Me.lblFileCount.Text = "No files selected"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(12, 297)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowTemplate.Height = 25
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(906, 220)
        Me.grdData.TabIndex = 2
        '
        'grpFilters
        '
        Me.grpFilters.Controls.Add(Me.lblYearFilter)
        Me.grpFilters.Controls.Add(Me.cmbYearFilter)
        Me.grpFilters.Controls.Add(Me.lblMonthFilter)
        Me.grpFilters.Controls.Add(Me.cmbMonthFilter)
        Me.grpFilters.Location = New System.Drawing.Point(12, 233)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(300, 55)
        Me.grpFilters.TabIndex = 6
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Filters"
        '
        'lblYearFilter
        '
        Me.lblYearFilter.AutoSize = True
        Me.lblYearFilter.Location = New System.Drawing.Point(16, 25)
        Me.lblYearFilter.Name = "lblYearFilter"
        Me.lblYearFilter.Size = New System.Drawing.Size(32, 15)
        Me.lblYearFilter.TabIndex = 0
        Me.lblYearFilter.Text = "Year:"
        '
        'cmbYearFilter
        '
        Me.cmbYearFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearFilter.FormattingEnabled = True
        Me.cmbYearFilter.Location = New System.Drawing.Point(60, 22)
        Me.cmbYearFilter.Name = "cmbYearFilter"
        Me.cmbYearFilter.Size = New System.Drawing.Size(85, 23)
        Me.cmbYearFilter.TabIndex = 1
        '
        'lblMonthFilter
        '
        Me.lblMonthFilter.AutoSize = True
        Me.lblMonthFilter.Location = New System.Drawing.Point(160, 25)
        Me.lblMonthFilter.Name = "lblMonthFilter"
        Me.lblMonthFilter.Size = New System.Drawing.Size(46, 15)
        Me.lblMonthFilter.TabIndex = 2
        Me.lblMonthFilter.Text = "Month:"
        '
        'cmbMonthFilter
        '
        Me.cmbMonthFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonthFilter.FormattingEnabled = True
        Me.cmbMonthFilter.Location = New System.Drawing.Point(212, 22)
        Me.cmbMonthFilter.Name = "cmbMonthFilter"
        Me.cmbMonthFilter.Size = New System.Drawing.Size(85, 23)
        Me.cmbMonthFilter.TabIndex = 3
        '
        'frmOwnElectricity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 529)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmOwnElectricity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Own Generated Electricity"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpButtons.ResumeLayout(False)
        Me.grpButtons.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        Me.ResumeLayout(False)

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