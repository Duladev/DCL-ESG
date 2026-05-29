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
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        grpFilter.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
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
        grpInput.Location = New Point(10, 9)
        grpInput.Margin = New Padding(3, 2, 3, 2)
        grpInput.Name = "grpInput"
        grpInput.Padding = New Padding(3, 2, 3, 2)
        grpInput.Size = New Size(622, 150)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Gas Data Entry"
        ' 
        ' btnAddGasType
        ' 
        btnAddGasType.Location = New Point(410, 54)
        btnAddGasType.Margin = New Padding(3, 2, 3, 2)
        btnAddGasType.Name = "btnAddGasType"
        btnAddGasType.Size = New Size(94, 22)
        btnAddGasType.TabIndex = 10
        btnAddGasType.Text = "Add Gas Type"
        btnAddGasType.UseVisualStyleBackColor = True
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(436, 90)
        txtAmount.Margin = New Padding(3, 2, 3, 2)
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
        txtQuantity.Margin = New Padding(3, 2, 3, 2)
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
        cmbGasType.Margin = New Padding(3, 2, 3, 2)
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
        dtpYear.Location = New Point(178, 22)
        dtpYear.Margin = New Padding(3, 2, 3, 2)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 2
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(374, 24)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 1
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(132, 24)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 0
        lblYear.Text = "Year:"
        ' 
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnExportExcel)
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Controls.Add(btnUploadBill)
        grpButtons.Controls.Add(lblFileCount)
        grpButtons.Location = New Point(638, 9)
        grpButtons.Margin = New Padding(3, 2, 3, 2)
        grpButtons.Name = "grpButtons"
        grpButtons.Padding = New Padding(3, 2, 3, 2)
        grpButtons.Size = New Size(280, 150)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.AppWorkspace
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(16, 112)
        btnExportExcel.Margin = New Padding(3, 2, 3, 2)
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
        btnDelete.Location = New Point(148, 75)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
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
        btnUpdate.Location = New Point(16, 75)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
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
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 26)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUploadBill
        ' 
        btnUploadBill.Location = New Point(16, 22)
        btnUploadBill.Margin = New Padding(3, 2, 3, 2)
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
        grpFilter.Controls.Add(cmbGasFilter)
        grpFilter.Controls.Add(lblFilter)
        grpFilter.Location = New Point(10, 163)
        grpFilter.Margin = New Padding(3, 2, 3, 2)
        grpFilter.Name = "grpFilter"
        grpFilter.Padding = New Padding(3, 2, 3, 2)
        grpFilter.Size = New Size(908, 45)
        grpFilter.TabIndex = 2
        grpFilter.TabStop = False
        grpFilter.Text = "Filters"
        ' 
        ' cmbGasFilter
        ' 
        cmbGasFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGasFilter.FormattingEnabled = True
        cmbGasFilter.Location = New Point(102, 19)
        cmbGasFilter.Margin = New Padding(3, 2, 3, 2)
        cmbGasFilter.Name = "cmbGasFilter"
        cmbGasFilter.Size = New Size(156, 23)
        cmbGasFilter.TabIndex = 1
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Location = New Point(16, 21)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(57, 15)
        lblFilter.TabIndex = 0
        lblFilter.Text = "Gas Type:"
        ' 
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 213)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 62
        grdData.RowTemplate.Height = 28
        grdData.Size = New Size(908, 278)
        grdData.TabIndex = 3
        ' 
        ' frmGas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 501)
        Controls.Add(grdData)
        Controls.Add(grpFilter)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmGas"
        Text = "Gas Management"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        grpFilter.ResumeLayout(False)
        grpFilter.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
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
End Class