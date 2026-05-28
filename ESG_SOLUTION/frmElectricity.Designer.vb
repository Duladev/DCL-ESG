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
        btnExportExcel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnUploadBill = New Button()
        lblFileCount = New Label()
        grdData = New DataGridView()
        grpMainAdditional.SuspendLayout()
        grpOutSource.SuspendLayout()
        grpControls.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
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
        grpMainAdditional.Location = New Point(10, 75)
        grpMainAdditional.Margin = New Padding(3, 2, 3, 2)
        grpMainAdditional.Name = "grpMainAdditional"
        grpMainAdditional.Padding = New Padding(3, 2, 3, 2)
        grpMainAdditional.Size = New Size(622, 112)
        grpMainAdditional.TabIndex = 0
        grpMainAdditional.TabStop = False
        grpMainAdditional.Text = "Main / Additional Purchase"
        ' 
        ' lblPeakAmount
        ' 
        lblPeakAmount.Location = New Point(234, 22)
        lblPeakAmount.Name = "lblPeakAmount"
        lblPeakAmount.Size = New Size(94, 17)
        lblPeakAmount.TabIndex = 11
        lblPeakAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtPeakAmount
        ' 
        txtPeakAmount.Location = New Point(334, 21)
        txtPeakAmount.Margin = New Padding(3, 2, 3, 2)
        txtPeakAmount.Name = "txtPeakAmount"
        txtPeakAmount.Size = New Size(118, 23)
        txtPeakAmount.TabIndex = 10
        ' 
        ' lblNormalAmount
        ' 
        lblNormalAmount.Location = New Point(234, 52)
        lblNormalAmount.Name = "lblNormalAmount"
        lblNormalAmount.Size = New Size(94, 17)
        lblNormalAmount.TabIndex = 9
        lblNormalAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtNormalAmount
        ' 
        txtNormalAmount.Location = New Point(334, 51)
        txtNormalAmount.Margin = New Padding(3, 2, 3, 2)
        txtNormalAmount.Name = "txtNormalAmount"
        txtNormalAmount.Size = New Size(118, 23)
        txtNormalAmount.TabIndex = 8
        ' 
        ' lblOffPeakAmount
        ' 
        lblOffPeakAmount.Location = New Point(234, 82)
        lblOffPeakAmount.Name = "lblOffPeakAmount"
        lblOffPeakAmount.Size = New Size(94, 17)
        lblOffPeakAmount.TabIndex = 7
        lblOffPeakAmount.Text = "Paid Amount (LKR):"
        ' 
        ' txtOffPeakAmount
        ' 
        txtOffPeakAmount.Location = New Point(334, 81)
        txtOffPeakAmount.Margin = New Padding(3, 2, 3, 2)
        txtOffPeakAmount.Name = "txtOffPeakAmount"
        txtOffPeakAmount.Size = New Size(118, 23)
        txtOffPeakAmount.TabIndex = 6
        ' 
        ' lblPeakQty
        ' 
        lblPeakQty.Location = New Point(16, 22)
        lblPeakQty.Name = "lblPeakQty"
        lblPeakQty.Size = New Size(94, 17)
        lblPeakQty.TabIndex = 5
        lblPeakQty.Text = "Peak Time Qty(KWh):"
        ' 
        ' txtPeakQty
        ' 
        txtPeakQty.Location = New Point(116, 21)
        txtPeakQty.Margin = New Padding(3, 2, 3, 2)
        txtPeakQty.Name = "txtPeakQty"
        txtPeakQty.Size = New Size(102, 23)
        txtPeakQty.TabIndex = 4
        ' 
        ' lblNormalQty
        ' 
        lblNormalQty.Location = New Point(16, 52)
        lblNormalQty.Name = "lblNormalQty"
        lblNormalQty.Size = New Size(94, 17)
        lblNormalQty.TabIndex = 3
        lblNormalQty.Text = "Normal Time Qty:"
        ' 
        ' txtNormalQty
        ' 
        txtNormalQty.Location = New Point(116, 51)
        txtNormalQty.Margin = New Padding(3, 2, 3, 2)
        txtNormalQty.Name = "txtNormalQty"
        txtNormalQty.Size = New Size(102, 23)
        txtNormalQty.TabIndex = 2
        ' 
        ' lblOffPeakQty
        ' 
        lblOffPeakQty.Location = New Point(16, 82)
        lblOffPeakQty.Name = "lblOffPeakQty"
        lblOffPeakQty.Size = New Size(94, 17)
        lblOffPeakQty.TabIndex = 1
        lblOffPeakQty.Text = "Off-Peak Time Qty:"
        ' 
        ' txtOffPeakQty
        ' 
        txtOffPeakQty.Location = New Point(116, 81)
        txtOffPeakQty.Margin = New Padding(3, 2, 3, 2)
        txtOffPeakQty.Name = "txtOffPeakQty"
        txtOffPeakQty.Size = New Size(102, 23)
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
        grpOutSource.Location = New Point(10, 75)
        grpOutSource.Margin = New Padding(3, 2, 3, 2)
        grpOutSource.Name = "grpOutSource"
        grpOutSource.Padding = New Padding(3, 2, 3, 2)
        grpOutSource.Size = New Size(622, 115)
        grpOutSource.TabIndex = 1
        grpOutSource.TabStop = False
        grpOutSource.Text = "Out-Source Purchase"
        grpOutSource.Visible = False
        ' 
        ' lblRenewableSource
        ' 
        lblRenewableSource.Location = New Point(16, 22)
        lblRenewableSource.Name = "lblRenewableSource"
        lblRenewableSource.Size = New Size(140, 17)
        lblRenewableSource.TabIndex = 7
        lblRenewableSource.Text = "Type Of Renewable Source:"
        ' 
        ' cmbRenewableSource
        ' 
        cmbRenewableSource.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRenewableSource.FormattingEnabled = True
        cmbRenewableSource.Location = New Point(164, 21)
        cmbRenewableSource.Margin = New Padding(3, 2, 3, 2)
        cmbRenewableSource.Name = "cmbRenewableSource"
        cmbRenewableSource.Size = New Size(140, 23)
        cmbRenewableSource.TabIndex = 6
        ' 
        ' lblRenewableCap
        ' 
        lblRenewableCap.Location = New Point(318, 22)
        lblRenewableCap.Name = "lblRenewableCap"
        lblRenewableCap.Size = New Size(116, 17)
        lblRenewableCap.TabIndex = 5
        lblRenewableCap.Text = "Total Capacity (KWh):"
        ' 
        ' txtRenewableCap
        ' 
        txtRenewableCap.Location = New Point(436, 21)
        txtRenewableCap.Margin = New Padding(3, 2, 3, 2)
        txtRenewableCap.Name = "txtRenewableCap"
        txtRenewableCap.Size = New Size(94, 23)
        txtRenewableCap.TabIndex = 4
        ' 
        ' lblNonRenewableSource
        ' 
        lblNonRenewableSource.Location = New Point(16, 52)
        lblNonRenewableSource.Name = "lblNonRenewableSource"
        lblNonRenewableSource.Size = New Size(140, 17)
        lblNonRenewableSource.TabIndex = 3
        lblNonRenewableSource.Text = "Type Of Non-Renewable:"
        ' 
        ' cmbNonRenewableSource
        ' 
        cmbNonRenewableSource.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNonRenewableSource.FormattingEnabled = True
        cmbNonRenewableSource.Location = New Point(164, 51)
        cmbNonRenewableSource.Margin = New Padding(3, 2, 3, 2)
        cmbNonRenewableSource.Name = "cmbNonRenewableSource"
        cmbNonRenewableSource.Size = New Size(140, 23)
        cmbNonRenewableSource.TabIndex = 2
        ' 
        ' lblNonRenewableCap
        ' 
        lblNonRenewableCap.Location = New Point(318, 52)
        lblNonRenewableCap.Name = "lblNonRenewableCap"
        lblNonRenewableCap.Size = New Size(116, 17)
        lblNonRenewableCap.TabIndex = 1
        lblNonRenewableCap.Text = "Total Capacity (KWh):"
        ' 
        ' txtNonRenewableCap
        ' 
        txtNonRenewableCap.Location = New Point(436, 51)
        txtNonRenewableCap.Margin = New Padding(3, 2, 3, 2)
        txtNonRenewableCap.Name = "txtNonRenewableCap"
        txtNonRenewableCap.Size = New Size(94, 23)
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
        grpControls.Location = New Point(10, 9)
        grpControls.Margin = New Padding(3, 2, 3, 2)
        grpControls.Name = "grpControls"
        grpControls.Padding = New Padding(3, 2, 3, 2)
        grpControls.Size = New Size(622, 62)
        grpControls.TabIndex = 2
        grpControls.TabStop = False
        grpControls.Text = "Selection Controls"
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
        dtpMonth.TabIndex = 5
        ' 
        ' dtpYear
        ' 
        dtpYear.CustomFormat = "yyyy"
        dtpYear.Format = DateTimePickerFormat.Custom
        dtpYear.Location = New Point(296, 26)
        dtpYear.Margin = New Padding(3, 2, 3, 2)
        dtpYear.Name = "dtpYear"
        dtpYear.ShowUpDown = True
        dtpYear.Size = New Size(78, 23)
        dtpYear.TabIndex = 4
        ' 
        ' lblMonth
        ' 
        lblMonth.AutoSize = True
        lblMonth.Location = New Point(396, 28)
        lblMonth.Name = "lblMonth"
        lblMonth.Size = New Size(46, 15)
        lblMonth.TabIndex = 3
        lblMonth.Text = "Month:"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(256, 28)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(32, 15)
        lblYear.TabIndex = 2
        lblYear.Text = "Year:"
        ' 
        ' cmbPurchaseType
        ' 
        cmbPurchaseType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPurchaseType.FormattingEnabled = True
        cmbPurchaseType.Items.AddRange(New Object() {"Main Purchase", "Additional Purchase", "Out-Source Purchase"})
        cmbPurchaseType.Location = New Point(102, 26)
        cmbPurchaseType.Margin = New Padding(3, 2, 3, 2)
        cmbPurchaseType.Name = "cmbPurchaseType"
        cmbPurchaseType.Size = New Size(140, 23)
        cmbPurchaseType.TabIndex = 1
        ' 
        ' lblPurchaseType
        ' 
        lblPurchaseType.AutoSize = True
        lblPurchaseType.Location = New Point(16, 28)
        lblPurchaseType.Name = "lblPurchaseType"
        lblPurchaseType.Size = New Size(86, 15)
        lblPurchaseType.TabIndex = 0
        lblPurchaseType.Text = "Purchase Type:"
        ' 
        ' grpButtons
        ' 
        grpButtons.Controls.Add(btnExportExcel)
        grpButtons.Controls.Add(btnDelete)
        grpButtons.Controls.Add(btnUpdate)
        grpButtons.Controls.Add(btnSave)
        grpButtons.Controls.Add(btnUploadBill)
        grpButtons.Controls.Add(lblFileCount)
        grpButtons.Location = New Point(638, 37)
        grpButtons.Margin = New Padding(3, 2, 3, 2)
        grpButtons.Name = "grpButtons"
        grpButtons.Padding = New Padding(3, 2, 3, 2)
        grpButtons.Size = New Size(277, 150)
        grpButtons.TabIndex = 3
        grpButtons.TabStop = False
        grpButtons.Text = "Actions"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.AppWorkspace
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(15, 115)
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
        btnDelete.Location = New Point(147, 115)
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
        btnUpdate.Location = New Point(147, 78)
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
        btnSave.Location = New Point(15, 78)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(116, 26)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUploadBill
        ' 
        btnUploadBill.Location = New Point(26, 22)
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
        lblFileCount.Location = New Point(158, 30)
        lblFileCount.Name = "lblFileCount"
        lblFileCount.Size = New Size(93, 15)
        lblFileCount.TabIndex = 0
        lblFileCount.Text = "No files selected"
        ' 
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 233)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 62
        grdData.RowTemplate.Height = 28
        grdData.Size = New Size(908, 258)
        grdData.TabIndex = 4
        ' 
        ' frmElectricity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 501)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpControls)
        Controls.Add(grpOutSource)
        Controls.Add(grpMainAdditional)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmElectricity"
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
End Class