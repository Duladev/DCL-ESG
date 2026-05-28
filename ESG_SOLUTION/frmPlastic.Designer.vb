<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlastic
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
        btnExportExcel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnUploadBill = New Button()
        lblFileCount = New Label()
        grpFilter = New GroupBox()
        cmbPlasticTypeFilter = New ComboBox()
        lblTypeFilter = New Label()
        cmbPlasticCategoryFilter = New ComboBox()
        lblCategoryFilter = New Label()
        grdData = New DataGridView()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        grpFilter.SuspendLayout()
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
        grpInput.Location = New Point(10, 9)
        grpInput.Margin = New Padding(3, 2, 3, 2)
        grpInput.Name = "grpInput"
        grpInput.Padding = New Padding(3, 2, 3, 2)
        grpInput.Size = New Size(662, 210)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Plastic Inventory Entry"
        ' 
        ' txtComments
        ' 
        txtComments.Location = New Point(140, 180)
        txtComments.Margin = New Padding(3, 2, 3, 2)
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(506, 23)
        txtComments.TabIndex = 21
        ' 
        ' lblComments
        ' 
        lblComments.AutoSize = True
        lblComments.Location = New Point(16, 182)
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
        txtTotalCost.Margin = New Padding(3, 2, 3, 2)
        txtTotalCost.Name = "txtTotalCost"
        txtTotalCost.Size = New Size(118, 23)
        txtTotalCost.TabIndex = 19
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Location = New Point(452, 152)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(63, 15)
        lblTotalCost.TabIndex = 18
        lblTotalCost.Text = "Total Cost:"
        ' 
        ' txtPricePerUnit
        ' 
        txtPricePerUnit.Location = New Point(312, 150)
        txtPricePerUnit.Margin = New Padding(3, 2, 3, 2)
        txtPricePerUnit.Name = "txtPricePerUnit"
        txtPricePerUnit.Size = New Size(118, 23)
        txtPricePerUnit.TabIndex = 17
        ' 
        ' lblPricePerUnit
        ' 
        lblPricePerUnit.AutoSize = True
        lblPricePerUnit.Location = New Point(218, 152)
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
        txtPurchasedScale.Margin = New Padding(3, 2, 3, 2)
        txtPurchasedScale.Name = "txtPurchasedScale"
        txtPurchasedScale.Size = New Size(64, 23)
        txtPurchasedScale.TabIndex = 15
        ' 
        ' lblPurchasedScale
        ' 
        lblPurchasedScale.AutoSize = True
        lblPurchasedScale.Location = New Point(16, 152)
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
        txtWeightPerUnit.Margin = New Padding(3, 2, 3, 2)
        txtWeightPerUnit.Name = "txtWeightPerUnit"
        txtWeightPerUnit.Size = New Size(118, 23)
        txtWeightPerUnit.TabIndex = 13
        ' 
        ' lblWeightPerUnit
        ' 
        lblWeightPerUnit.AutoSize = True
        lblWeightPerUnit.Location = New Point(436, 122)
        lblWeightPerUnit.Name = "lblWeightPerUnit"
        lblWeightPerUnit.Size = New Size(93, 15)
        lblWeightPerUnit.TabIndex = 12
        lblWeightPerUnit.Text = "Weight Per Unit:"
        ' 
        ' txtUnitCount
        ' 
        txtUnitCount.Location = New Point(312, 120)
        txtUnitCount.Margin = New Padding(3, 2, 3, 2)
        txtUnitCount.Name = "txtUnitCount"
        txtUnitCount.Size = New Size(102, 23)
        txtUnitCount.TabIndex = 11
        ' 
        ' lblUnitCount
        ' 
        lblUnitCount.AutoSize = True
        lblUnitCount.Location = New Point(218, 122)
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
        txtUnitType.Margin = New Padding(3, 2, 3, 2)
        txtUnitType.Name = "txtUnitType"
        txtUnitType.Size = New Size(64, 23)
        txtUnitType.TabIndex = 9
        ' 
        ' lblUnitType
        ' 
        lblUnitType.AutoSize = True
        lblUnitType.Location = New Point(16, 122)
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
        cmbProductType.Margin = New Padding(3, 2, 3, 2)
        cmbProductType.Name = "cmbProductType"
        cmbProductType.Size = New Size(156, 23)
        cmbProductType.TabIndex = 7
        ' 
        ' lblProductType
        ' 
        lblProductType.AutoSize = True
        lblProductType.Location = New Point(218, 92)
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
        cmbProductCategory.Margin = New Padding(3, 2, 3, 2)
        cmbProductCategory.Name = "cmbProductCategory"
        cmbProductCategory.Size = New Size(64, 23)
        cmbProductCategory.TabIndex = 5
        ' 
        ' lblProductCategory
        ' 
        lblProductCategory.AutoSize = True
        lblProductCategory.Location = New Point(16, 92)
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
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnExportExcel)
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Controls.Add(btnUploadBill)
        grpButtons.Controls.Add(lblFileCount)
        grpButtons.Location = New Point(676, 9)
        grpButtons.Margin = New Padding(3, 2, 3, 2)
        grpButtons.Name = "grpButtons"
        grpButtons.Padding = New Padding(3, 2, 3, 2)
        grpButtons.Size = New Size(242, 210)
        grpButtons.TabIndex = 1
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.AppWorkspace
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(16, 172)
        btnExportExcel.Margin = New Padding(3, 2, 3, 2)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(94, 26)
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
        btnDelete.Location = New Point(116, 172)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(108, 26)
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
        btnUpdate.Location = New Point(16, 135)
        btnUpdate.Margin = New Padding(3, 2, 3, 2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 26)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.AppWorkspace
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(116, 135)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(108, 26)
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
        lblFileCount.Location = New Point(16, 60)
        lblFileCount.Name = "lblFileCount"
        lblFileCount.Size = New Size(93, 15)
        lblFileCount.TabIndex = 0
        lblFileCount.Text = "No files selected"
        ' 
        ' grpFilter
        ' 
        grpFilter.Controls.Add(cmbPlasticTypeFilter)
        grpFilter.Controls.Add(lblTypeFilter)
        grpFilter.Controls.Add(cmbPlasticCategoryFilter)
        grpFilter.Controls.Add(lblCategoryFilter)
        grpFilter.Location = New Point(10, 223)
        grpFilter.Margin = New Padding(3, 2, 3, 2)
        grpFilter.Name = "grpFilter"
        grpFilter.Padding = New Padding(3, 2, 3, 2)
        grpFilter.Size = New Size(908, 45)
        grpFilter.TabIndex = 2
        grpFilter.TabStop = False
        grpFilter.Text = "Filters"
        ' 
        ' cmbPlasticTypeFilter
        ' 
        cmbPlasticTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPlasticTypeFilter.FormattingEnabled = True
        cmbPlasticTypeFilter.Location = New Point(350, 18)
        cmbPlasticTypeFilter.Margin = New Padding(3, 2, 3, 2)
        cmbPlasticTypeFilter.Name = "cmbPlasticTypeFilter"
        cmbPlasticTypeFilter.Size = New Size(118, 23)
        cmbPlasticTypeFilter.TabIndex = 3
        ' 
        ' lblTypeFilter
        ' 
        lblTypeFilter.AutoSize = True
        lblTypeFilter.Location = New Point(264, 21)
        lblTypeFilter.Name = "lblTypeFilter"
        lblTypeFilter.Size = New Size(80, 15)
        lblTypeFilter.TabIndex = 2
        lblTypeFilter.Text = "Product Type:"
        ' 
        ' cmbPlasticCategoryFilter
        ' 
        cmbPlasticCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPlasticCategoryFilter.FormattingEnabled = True
        cmbPlasticCategoryFilter.Location = New Point(125, 18)
        cmbPlasticCategoryFilter.Margin = New Padding(3, 2, 3, 2)
        cmbPlasticCategoryFilter.Name = "cmbPlasticCategoryFilter"
        cmbPlasticCategoryFilter.Size = New Size(118, 23)
        cmbPlasticCategoryFilter.TabIndex = 1
        ' 
        ' lblCategoryFilter
        ' 
        lblCategoryFilter.AutoSize = True
        lblCategoryFilter.Location = New Point(16, 21)
        lblCategoryFilter.Name = "lblCategoryFilter"
        lblCategoryFilter.Size = New Size(103, 15)
        lblCategoryFilter.TabIndex = 0
        lblCategoryFilter.Text = "Product Category:"
        ' 
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 273)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 62
        grdData.RowTemplate.Height = 28
        grdData.Size = New Size(908, 218)
        grdData.TabIndex = 3
        ' 
        ' frmPlastic
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 501)
        Controls.Add(grdData)
        Controls.Add(grpFilter)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmPlastic"
        Text = "Plastic Inventory Management"
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
    Friend WithEvents cmbPlasticCategoryFilter As ComboBox
    Friend WithEvents lblCategoryFilter As Label
    Friend WithEvents cmbPlasticTypeFilter As ComboBox
    Friend WithEvents lblTypeFilter As Label
    Friend WithEvents grdData As DataGridView
End Class