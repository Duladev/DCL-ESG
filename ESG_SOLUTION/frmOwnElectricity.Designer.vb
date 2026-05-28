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
        btnExportExcel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        btnUploadBill = New Button()
        lblFileCount = New Label()
        grdData = New DataGridView()
        grpInput.SuspendLayout()
        grpButtons.SuspendLayout()
        CType(grdData, ComponentModel.ISupportInitialize).BeginInit()
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
        grpInput.Location = New Point(10, 9)
        grpInput.Margin = New Padding(3, 2, 3, 2)
        grpInput.Name = "grpInput"
        grpInput.Padding = New Padding(3, 2, 3, 2)
        grpInput.Size = New Size(622, 210)
        grpInput.TabIndex = 0
        grpInput.TabStop = False
        grpInput.Text = "Own Generated Electricity"
        ' 
        ' txtComments
        ' 
        txtComments.Location = New Point(140, 172)
        txtComments.Margin = New Padding(3, 2, 3, 2)
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.Size = New Size(468, 31)
        txtComments.TabIndex = 17
        ' 
        ' lblComments
        ' 
        lblComments.AutoSize = True
        lblComments.Location = New Point(16, 174)
        lblComments.Name = "lblComments"
        lblComments.Size = New Size(69, 15)
        lblComments.TabIndex = 16
        lblComments.Text = "Comments:"
        ' 
        ' txtSoldCapacity
        ' 
        txtSoldCapacity.BackColor = Color.LightGray
        txtSoldCapacity.Enabled = False
        txtSoldCapacity.Location = New Point(436, 142)
        txtSoldCapacity.Margin = New Padding(3, 2, 3, 2)
        txtSoldCapacity.Name = "txtSoldCapacity"
        txtSoldCapacity.Size = New Size(118, 23)
        txtSoldCapacity.TabIndex = 15
        ' 
        ' lblSoldCapacity
        ' 
        lblSoldCapacity.AutoSize = True
        lblSoldCapacity.Location = New Point(318, 144)
        lblSoldCapacity.Name = "lblSoldCapacity"
        lblSoldCapacity.Size = New Size(118, 15)
        lblSoldCapacity.TabIndex = 14
        lblSoldCapacity.Text = "Own Generated Sold:"
        ' 
        ' txtTotalConsumed
        ' 
        txtTotalConsumed.Location = New Point(178, 142)
        txtTotalConsumed.Margin = New Padding(3, 2, 3, 2)
        txtTotalConsumed.Name = "txtTotalConsumed"
        txtTotalConsumed.Size = New Size(118, 23)
        txtTotalConsumed.TabIndex = 13
        ' 
        ' lblTotalConsumed
        ' 
        lblTotalConsumed.AutoSize = True
        lblTotalConsumed.Location = New Point(16, 144)
        lblTotalConsumed.Name = "lblTotalConsumed"
        lblTotalConsumed.Size = New Size(187, 15)
        lblTotalConsumed.TabIndex = 12
        lblTotalConsumed.Text = "Total Own Generated(Consumed):"
        ' 
        ' txtNonRenewableCap
        ' 
        txtNonRenewableCap.Location = New Point(436, 105)
        txtNonRenewableCap.Margin = New Padding(3, 2, 3, 2)
        txtNonRenewableCap.Name = "txtNonRenewableCap"
        txtNonRenewableCap.Size = New Size(118, 23)
        txtNonRenewableCap.TabIndex = 11
        ' 
        ' lblNonRenewableCap
        ' 
        lblNonRenewableCap.AutoSize = True
        lblNonRenewableCap.Location = New Point(318, 107)
        lblNonRenewableCap.Name = "lblNonRenewableCap"
        lblNonRenewableCap.Size = New Size(112, 15)
        lblNonRenewableCap.TabIndex = 10
        lblNonRenewableCap.Text = "Monthly Generated:"
        ' 
        ' cmbNonRenewableType
        ' 
        cmbNonRenewableType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbNonRenewableType.FormattingEnabled = True
        cmbNonRenewableType.Location = New Point(178, 105)
        cmbNonRenewableType.Margin = New Padding(3, 2, 3, 2)
        cmbNonRenewableType.Name = "cmbNonRenewableType"
        cmbNonRenewableType.Size = New Size(118, 23)
        cmbNonRenewableType.TabIndex = 9
        ' 
        ' lblNonRenewableType
        ' 
        lblNonRenewableType.AutoSize = True
        lblNonRenewableType.Location = New Point(16, 107)
        lblNonRenewableType.Name = "lblNonRenewableType"
        lblNonRenewableType.Size = New Size(123, 15)
        lblNonRenewableType.TabIndex = 8
        lblNonRenewableType.Text = "Non-Renewable Type:"
        ' 
        ' txtRenewableCap
        ' 
        txtRenewableCap.Location = New Point(436, 75)
        txtRenewableCap.Margin = New Padding(3, 2, 3, 2)
        txtRenewableCap.Name = "txtRenewableCap"
        txtRenewableCap.Size = New Size(118, 23)
        txtRenewableCap.TabIndex = 7
        ' 
        ' lblRenewableCap
        ' 
        lblRenewableCap.AutoSize = True
        lblRenewableCap.Location = New Point(318, 77)
        lblRenewableCap.Name = "lblRenewableCap"
        lblRenewableCap.Size = New Size(112, 15)
        lblRenewableCap.TabIndex = 6
        lblRenewableCap.Text = "Monthly Generated:"
        ' 
        ' cmbRenewableType
        ' 
        cmbRenewableType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRenewableType.FormattingEnabled = True
        cmbRenewableType.Location = New Point(178, 75)
        cmbRenewableType.Margin = New Padding(3, 2, 3, 2)
        cmbRenewableType.Name = "cmbRenewableType"
        cmbRenewableType.Size = New Size(118, 23)
        cmbRenewableType.TabIndex = 5
        ' 
        ' lblRenewableType
        ' 
        lblRenewableType.AutoSize = True
        lblRenewableType.Location = New Point(16, 77)
        lblRenewableType.Name = "lblRenewableType"
        lblRenewableType.Size = New Size(134, 15)
        lblRenewableType.TabIndex = 4
        lblRenewableType.Text = "Renewable Source Type:"
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
        lblMonth.Location = New Point(388, 28)
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
        grpButtons.Size = New Size(280, 210)
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
        btnDelete.Location = New Point(148, 170)
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
        btnUpdate.Location = New Point(16, 135)
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
        btnSave.Location = New Point(148, 133)
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
        ' grdData
        ' 
        grdData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grdData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdData.Location = New Point(10, 225)
        grdData.Margin = New Padding(3, 2, 3, 2)
        grdData.Name = "grdData"
        grdData.RowHeadersWidth = 62
        grdData.RowTemplate.Height = 28
        grdData.Size = New Size(908, 266)
        grdData.TabIndex = 2
        ' 
        ' frmOwnElectricity
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 501)
        Controls.Add(grdData)
        Controls.Add(grpButtons)
        Controls.Add(grpInput)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmOwnElectricity"
        Text = "Own Generated Electricity"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpButtons.ResumeLayout(False)
        grpButtons.PerformLayout()
        CType(grdData, ComponentModel.ISupportInitialize).EndInit()
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
End Class