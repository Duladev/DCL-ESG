<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollectorManagement
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpCollectorInfo = New GroupBox()
        btnUploadLicense = New Button()
        lblLicenseStatus = New Label()
        txtLicenseNumber = New TextBox()
        lblLicenseNumber = New Label()
        btnSaveCollector = New Button()
        txtPhone = New TextBox()
        btnRefresh = New Button()
        btnDeleteCollector = New Button()
        lblPhone = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        txtCollectorName = New TextBox()
        lblCollectorName = New Label()
        grdCollectors = New DataGridView()
        ofdLicense = New OpenFileDialog()
        grpCollectorInfo.SuspendLayout()
        CType(grdCollectors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpCollectorInfo
        ' 
        grpCollectorInfo.Controls.Add(btnUploadLicense)
        grpCollectorInfo.Controls.Add(lblLicenseStatus)
        grpCollectorInfo.Controls.Add(txtLicenseNumber)
        grpCollectorInfo.Controls.Add(lblLicenseNumber)
        grpCollectorInfo.Controls.Add(btnSaveCollector)
        grpCollectorInfo.Controls.Add(txtPhone)
        grpCollectorInfo.Controls.Add(btnRefresh)
        grpCollectorInfo.Controls.Add(btnDeleteCollector)
        grpCollectorInfo.Controls.Add(lblPhone)
        grpCollectorInfo.Controls.Add(txtAddress)
        grpCollectorInfo.Controls.Add(lblAddress)
        grpCollectorInfo.Controls.Add(txtCollectorName)
        grpCollectorInfo.Controls.Add(lblCollectorName)
        grpCollectorInfo.Font = New Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCollectorInfo.Location = New Point(14, 14)
        grpCollectorInfo.Margin = New Padding(4, 3, 4, 3)
        grpCollectorInfo.Name = "grpCollectorInfo"
        grpCollectorInfo.Padding = New Padding(4, 3, 4, 3)
        grpCollectorInfo.Size = New Size(525, 288)
        grpCollectorInfo.TabIndex = 0
        grpCollectorInfo.TabStop = False
        grpCollectorInfo.Text = "Collector Information"
        ' 
        ' btnUploadLicense
        ' 
        btnUploadLicense.BackColor = SystemColors.Control
        btnUploadLicense.Font = New Font("Microsoft Sans Serif", 9.75F)
        btnUploadLicense.Location = New Point(337, 195)
        btnUploadLicense.Margin = New Padding(4, 3, 4, 3)
        btnUploadLicense.Name = "btnUploadLicense"
        btnUploadLicense.Size = New Size(139, 27)
        btnUploadLicense.TabIndex = 12
        btnUploadLicense.Text = "Upload License"
        btnUploadLicense.UseVisualStyleBackColor = False
        ' 
        ' lblLicenseStatus
        ' 
        lblLicenseStatus.AutoSize = True
        lblLicenseStatus.Font = New Font("Microsoft Sans Serif", 8F)
        lblLicenseStatus.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblLicenseStatus.Location = New Point(12, 202)
        lblLicenseStatus.Margin = New Padding(4, 0, 4, 0)
        lblLicenseStatus.Name = "lblLicenseStatus"
        lblLicenseStatus.Size = New Size(114, 13)
        lblLicenseStatus.TabIndex = 11
        lblLicenseStatus.Text = "No document selected"
        ' 
        ' txtLicenseNumber
        ' 
        txtLicenseNumber.Font = New Font("Arial", 11.25F)
        txtLicenseNumber.Location = New Point(140, 138)
        txtLicenseNumber.Margin = New Padding(4, 3, 4, 3)
        txtLicenseNumber.Name = "txtLicenseNumber"
        txtLicenseNumber.Size = New Size(349, 25)
        txtLicenseNumber.TabIndex = 7
        ' 
        ' lblLicenseNumber
        ' 
        lblLicenseNumber.AutoSize = True
        lblLicenseNumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblLicenseNumber.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblLicenseNumber.Location = New Point(12, 141)
        lblLicenseNumber.Margin = New Padding(4, 0, 4, 0)
        lblLicenseNumber.Name = "lblLicenseNumber"
        lblLicenseNumber.Size = New Size(100, 15)
        lblLicenseNumber.TabIndex = 6
        lblLicenseNumber.Text = "License Number:"
        ' 
        ' btnSaveCollector
        ' 
        btnSaveCollector.BackColor = SystemColors.Control
        btnSaveCollector.Font = New Font("Microsoft Sans Serif", 9.75F)
        btnSaveCollector.Location = New Point(39, 244)
        btnSaveCollector.Margin = New Padding(4, 3, 4, 3)
        btnSaveCollector.Name = "btnSaveCollector"
        btnSaveCollector.Size = New Size(100, 27)
        btnSaveCollector.TabIndex = 10
        btnSaveCollector.Text = "Save Collector"
        btnSaveCollector.UseVisualStyleBackColor = False
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Arial", 11.25F)
        txtPhone.Location = New Point(140, 104)
        txtPhone.Margin = New Padding(4, 3, 4, 3)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(349, 25)
        txtPhone.TabIndex = 5
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.Control
        btnRefresh.Font = New Font("Microsoft Sans Serif", 9.75F)
        btnRefresh.Location = New Point(337, 244)
        btnRefresh.Margin = New Padding(4, 3, 4, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 27)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCollector
        ' 
        btnDeleteCollector.BackColor = SystemColors.Control
        btnDeleteCollector.Font = New Font("Microsoft Sans Serif", 9.75F)
        btnDeleteCollector.Location = New Point(190, 244)
        btnDeleteCollector.Margin = New Padding(4, 3, 4, 3)
        btnDeleteCollector.Name = "btnDeleteCollector"
        btnDeleteCollector.Size = New Size(100, 27)
        btnDeleteCollector.TabIndex = 9
        btnDeleteCollector.Text = "Delete"
        btnDeleteCollector.UseVisualStyleBackColor = False
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblPhone.Location = New Point(12, 106)
        lblPhone.Margin = New Padding(4, 0, 4, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(68, 15)
        lblPhone.TabIndex = 4
        lblPhone.Text = "Telephone:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Arial", 11.25F)
        txtAddress.Location = New Point(140, 69)
        txtAddress.Margin = New Padding(4, 3, 4, 3)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(349, 25)
        txtAddress.TabIndex = 3
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblAddress.Location = New Point(12, 72)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(54, 15)
        lblAddress.TabIndex = 2
        lblAddress.Text = "Address:"
        ' 
        ' txtCollectorName
        ' 
        txtCollectorName.Font = New Font("Arial", 11.25F)
        txtCollectorName.Location = New Point(140, 35)
        txtCollectorName.Margin = New Padding(4, 3, 4, 3)
        txtCollectorName.Name = "txtCollectorName"
        txtCollectorName.Size = New Size(349, 25)
        txtCollectorName.TabIndex = 1
        ' 
        ' lblCollectorName
        ' 
        lblCollectorName.AutoSize = True
        lblCollectorName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCollectorName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCollectorName.Location = New Point(12, 37)
        lblCollectorName.Margin = New Padding(4, 0, 4, 0)
        lblCollectorName.Name = "lblCollectorName"
        lblCollectorName.Size = New Size(96, 15)
        lblCollectorName.TabIndex = 0
        lblCollectorName.Text = "Collector Name:"
        ' 
        ' grdCollectors
        ' 
        grdCollectors.AllowUserToAddRows = False
        grdCollectors.AllowUserToDeleteRows = False
        grdCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdCollectors.Location = New Point(14, 324)
        grdCollectors.Margin = New Padding(4, 3, 4, 3)
        grdCollectors.Name = "grdCollectors"
        grdCollectors.RowHeadersWidth = 51
        grdCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdCollectors.Size = New Size(525, 273)
        grdCollectors.TabIndex = 1
        ' 
        ' ofdLicense
        ' 
        ofdLicense.FileName = "OpenFileDialog1"
        ofdLicense.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.png;*.bmp|Word Files|*.doc;*.docx|All Files|*.*"
        ' 
        ' frmCollectorManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(553, 613)
        Controls.Add(grdCollectors)
        Controls.Add(grpCollectorInfo)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmCollectorManagement"
        StartPosition = FormStartPosition.CenterParent
        Text = "Waste Collector Management"
        grpCollectorInfo.ResumeLayout(False)
        grpCollectorInfo.PerformLayout()
        CType(grdCollectors, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents grpCollectorInfo As GroupBox
    Friend WithEvents grdCollectors As DataGridView
    Friend WithEvents txtCollectorName As TextBox
    Friend WithEvents lblCollectorName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents btnSaveCollector As Button
    Friend WithEvents btnDeleteCollector As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUploadLicense As Button
    Friend WithEvents lblLicenseStatus As Label
    Friend WithEvents ofdLicense As OpenFileDialog

End Class