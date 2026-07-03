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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollectorManagement))
        grpCollectorInfo = New GroupBox()
        btnClearForm = New Button()
        btnViewDocument = New Button()
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
        btnHome = New Button()
        grpCollectorInfo.SuspendLayout()
        CType(grdCollectors, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grpCollectorInfo
        ' 
        grpCollectorInfo.BackColor = Color.White
        grpCollectorInfo.Controls.Add(btnHome)
        grpCollectorInfo.Controls.Add(btnClearForm)
        grpCollectorInfo.Controls.Add(btnViewDocument)
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
        grpCollectorInfo.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCollectorInfo.Location = New Point(12, 12)
        grpCollectorInfo.Name = "grpCollectorInfo"
        grpCollectorInfo.Size = New Size(600, 330)
        grpCollectorInfo.TabIndex = 0
        grpCollectorInfo.TabStop = False
        grpCollectorInfo.Text = "Collector Information"
        ' 
        ' btnClearForm
        ' 
        btnClearForm.BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        btnClearForm.FlatStyle = FlatStyle.Flat
        btnClearForm.Font = New Font("Segoe UI", 9F)
        btnClearForm.Location = New Point(275, 267)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(100, 30)
        btnClearForm.TabIndex = 13
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' btnViewDocument
        ' 
        btnViewDocument.BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        btnViewDocument.FlatStyle = FlatStyle.Flat
        btnViewDocument.Font = New Font("Segoe UI", 9F)
        btnViewDocument.Location = New Point(494, 195)
        btnViewDocument.Name = "btnViewDocument"
        btnViewDocument.Size = New Size(100, 30)
        btnViewDocument.TabIndex = 12
        btnViewDocument.Text = "View Document"
        btnViewDocument.UseVisualStyleBackColor = False
        ' 
        ' btnUploadLicense
        ' 
        btnUploadLicense.BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        btnUploadLicense.FlatStyle = FlatStyle.Flat
        btnUploadLicense.Font = New Font("Segoe UI", 9F)
        btnUploadLicense.Location = New Point(388, 195)
        btnUploadLicense.Name = "btnUploadLicense"
        btnUploadLicense.Size = New Size(100, 30)
        btnUploadLicense.TabIndex = 11
        btnUploadLicense.Text = "Upload License"
        btnUploadLicense.UseVisualStyleBackColor = False
        ' 
        ' lblLicenseStatus
        ' 
        lblLicenseStatus.AutoSize = True
        lblLicenseStatus.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic)
        lblLicenseStatus.ForeColor = Color.Gray
        lblLicenseStatus.Location = New Point(12, 205)
        lblLicenseStatus.Name = "lblLicenseStatus"
        lblLicenseStatus.Size = New Size(111, 13)
        lblLicenseStatus.TabIndex = 10
        lblLicenseStatus.Text = "No document selected"
        ' 
        ' txtLicenseNumber
        ' 
        txtLicenseNumber.Font = New Font("Segoe UI", 9.75F)
        txtLicenseNumber.Location = New Point(140, 155)
        txtLicenseNumber.Name = "txtLicenseNumber"
        txtLicenseNumber.Size = New Size(448, 25)
        txtLicenseNumber.TabIndex = 9
        ' 
        ' lblLicenseNumber
        ' 
        lblLicenseNumber.AutoSize = True
        lblLicenseNumber.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblLicenseNumber.Location = New Point(12, 158)
        lblLicenseNumber.Name = "lblLicenseNumber"
        lblLicenseNumber.Size = New Size(112, 17)
        lblLicenseNumber.TabIndex = 8
        lblLicenseNumber.Text = "License Number:"
        ' 
        ' btnSaveCollector
        ' 
        btnSaveCollector.BackColor = SystemColors.Control
        btnSaveCollector.FlatStyle = FlatStyle.Flat
        btnSaveCollector.Font = New Font("Segoe UI", 9.75F)
        btnSaveCollector.Location = New Point(388, 267)
        btnSaveCollector.Name = "btnSaveCollector"
        btnSaveCollector.Size = New Size(110, 30)
        btnSaveCollector.TabIndex = 7
        btnSaveCollector.Text = "Save Collector"
        btnSaveCollector.UseVisualStyleBackColor = False
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 9.75F)
        txtPhone.Location = New Point(140, 117)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(448, 25)
        txtPhone.TabIndex = 6
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(240), CByte(248), CByte(255))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.Location = New Point(51, 267)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 30)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCollector
        ' 
        btnDeleteCollector.BackColor = SystemColors.Control
        btnDeleteCollector.FlatStyle = FlatStyle.Flat
        btnDeleteCollector.Font = New Font("Segoe UI", 9.75F)
        btnDeleteCollector.Location = New Point(157, 267)
        btnDeleteCollector.Name = "btnDeleteCollector"
        btnDeleteCollector.Size = New Size(100, 30)
        btnDeleteCollector.TabIndex = 4
        btnDeleteCollector.Text = "Delete"
        btnDeleteCollector.UseVisualStyleBackColor = False
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblPhone.Location = New Point(12, 120)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(76, 17)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Telephone:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Segoe UI", 9.75F)
        txtAddress.Location = New Point(140, 80)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(448, 25)
        txtAddress.TabIndex = 2
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblAddress.Location = New Point(12, 83)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(61, 17)
        lblAddress.TabIndex = 1
        lblAddress.Text = "Address:"
        ' 
        ' txtCollectorName
        ' 
        txtCollectorName.Font = New Font("Segoe UI", 9.75F)
        txtCollectorName.Location = New Point(140, 44)
        txtCollectorName.Name = "txtCollectorName"
        txtCollectorName.Size = New Size(448, 25)
        txtCollectorName.TabIndex = 0
        ' 
        ' lblCollectorName
        ' 
        lblCollectorName.AutoSize = True
        lblCollectorName.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        lblCollectorName.Location = New Point(12, 47)
        lblCollectorName.Name = "lblCollectorName"
        lblCollectorName.Size = New Size(107, 17)
        lblCollectorName.TabIndex = 0
        lblCollectorName.Text = "Collector Name:"
        ' 
        ' grdCollectors
        ' 
        grdCollectors.AllowUserToAddRows = False
        grdCollectors.AllowUserToDeleteRows = False
        grdCollectors.BackgroundColor = Color.White
        grdCollectors.BorderStyle = BorderStyle.Fixed3D
        grdCollectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdCollectors.Location = New Point(12, 348)
        grdCollectors.Name = "grdCollectors"
        grdCollectors.ReadOnly = True
        grdCollectors.RowHeadersVisible = False
        grdCollectors.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdCollectors.Size = New Size(600, 172)
        grdCollectors.TabIndex = 1
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Stretch
        btnHome.Location = New Point(543, 262)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(45, 38)
        btnHome.TabIndex = 14
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' frmCollectorManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(624, 525)
        Controls.Add(grdCollectors)
        Controls.Add(grpCollectorInfo)
        Font = New Font("Segoe UI", 9F)
        Name = "frmCollectorManagement"
        StartPosition = FormStartPosition.CenterScreen
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
    Friend WithEvents btnSaveCollector As Button
    Friend WithEvents btnDeleteCollector As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtLicenseNumber As TextBox
    Friend WithEvents lblLicenseNumber As Label
    Friend WithEvents lblLicenseStatus As Label
    Friend WithEvents btnUploadLicense As Button
    Friend WithEvents btnViewDocument As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnHome As Button

End Class