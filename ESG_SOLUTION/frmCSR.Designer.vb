<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCSR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Visual Basic Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCSR))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txtAction = New TextBox()
        txtDescription = New TextBox()
        txtLocation = New TextBox()
        txtTimeEngagement = New TextBox()
        txtEmployeesEnvolved = New NumericUpDown()
        txtHoursInvested = New NumericUpDown()
        txtPeopleImpacted = New NumericUpDown()
        txtQuantity = New NumericUpDown()
        txtCostUSD = New NumericUpDown()
        cboType = New ComboBox()
        dtpActivityDate = New DateTimePicker()
        btnSave = New Button()
        btnRefresh = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnExportExcel = New Button()
        btnUploadPhotos = New Button()
        dgvData = New DataGridView()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        Label13 = New Label()
        Label14 = New Label()
        btnFilter = New Button()
        btnClearFilter = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        cboFrequency = New ComboBox()
        btnBrowseFolder = New Button()
        Label15 = New Label()
        txtPhotoFolderPath = New TextBox()
        btnClearForm = New Button()
        btnLoadSelected = New Button()
        Panel1 = New Panel()
        GroupBox4 = New GroupBox()
        btnHome = New Button()
        pbPhotoPreview = New PictureBox()
        lblPhotoCount = New Label()
        btnSetPrimary = New Button()
        btnViewPhoto = New Button()
        btnDeletePhoto = New Button()
        lvwPhotos = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        CType(txtEmployeesEnvolved, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtHoursInvested, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtPeopleImpacted, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtCostUSD, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(pbPhotoPreview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 32)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 15)
        Label1.TabIndex = 0
        Label1.Text = "Activity Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 63)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 1
        Label2.Text = "Action:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 93)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 2
        Label3.Text = "Description:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 140)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 15)
        Label4.TabIndex = 3
        Label4.Text = "Frequency:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 170)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 4
        Label5.Text = "Location:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 201)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 15)
        Label6.TabIndex = 5
        Label6.Text = "Time of Engage.:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 231)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 15)
        Label7.TabIndex = 6
        Label7.Text = "Employees Envolved:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 262)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 15)
        Label8.TabIndex = 7
        Label8.Text = "Hours Invested:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 293)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 15)
        Label9.TabIndex = 8
        Label9.Text = "People Impacted:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 324)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 15)
        Label10.TabIndex = 9
        Label10.Text = "Quantity:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(14, 355)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 15)
        Label11.TabIndex = 10
        Label11.Text = "Cost USD:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(14, 388)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(35, 15)
        Label12.TabIndex = 11
        Label12.Text = "Type:"
        ' 
        ' txtAction
        ' 
        txtAction.Location = New Point(145, 60)
        txtAction.Margin = New Padding(4, 3, 4, 3)
        txtAction.Name = "txtAction"
        txtAction.Size = New Size(114, 23)
        txtAction.TabIndex = 12
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(145, 90)
        txtDescription.Margin = New Padding(4, 3, 4, 3)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(114, 44)
        txtDescription.TabIndex = 13
        ' 
        ' txtLocation
        ' 
        txtLocation.Location = New Point(145, 170)
        txtLocation.Margin = New Padding(4, 3, 4, 3)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(114, 23)
        txtLocation.TabIndex = 15
        ' 
        ' txtTimeEngagement
        ' 
        txtTimeEngagement.Location = New Point(145, 200)
        txtTimeEngagement.Margin = New Padding(4, 3, 4, 3)
        txtTimeEngagement.Name = "txtTimeEngagement"
        txtTimeEngagement.Size = New Size(114, 23)
        txtTimeEngagement.TabIndex = 16
        ' 
        ' txtEmployeesEnvolved
        ' 
        txtEmployeesEnvolved.Location = New Point(145, 230)
        txtEmployeesEnvolved.Margin = New Padding(4, 3, 4, 3)
        txtEmployeesEnvolved.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        txtEmployeesEnvolved.Name = "txtEmployeesEnvolved"
        txtEmployeesEnvolved.Size = New Size(114, 23)
        txtEmployeesEnvolved.TabIndex = 17
        ' 
        ' txtHoursInvested
        ' 
        txtHoursInvested.DecimalPlaces = 2
        txtHoursInvested.Location = New Point(145, 260)
        txtHoursInvested.Margin = New Padding(4, 3, 4, 3)
        txtHoursInvested.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        txtHoursInvested.Name = "txtHoursInvested"
        txtHoursInvested.Size = New Size(114, 23)
        txtHoursInvested.TabIndex = 18
        ' 
        ' txtPeopleImpacted
        ' 
        txtPeopleImpacted.Location = New Point(145, 290)
        txtPeopleImpacted.Margin = New Padding(4, 3, 4, 3)
        txtPeopleImpacted.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        txtPeopleImpacted.Name = "txtPeopleImpacted"
        txtPeopleImpacted.Size = New Size(114, 23)
        txtPeopleImpacted.TabIndex = 19
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(145, 320)
        txtQuantity.Margin = New Padding(4, 3, 4, 3)
        txtQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(114, 23)
        txtQuantity.TabIndex = 20
        ' 
        ' txtCostUSD
        ' 
        txtCostUSD.DecimalPlaces = 2
        txtCostUSD.Location = New Point(145, 350)
        txtCostUSD.Margin = New Padding(4, 3, 4, 3)
        txtCostUSD.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        txtCostUSD.Name = "txtCostUSD"
        txtCostUSD.Size = New Size(114, 23)
        txtCostUSD.TabIndex = 21
        ' 
        ' cboType
        ' 
        cboType.DropDownStyle = ComboBoxStyle.DropDownList
        cboType.FormattingEnabled = True
        cboType.Items.AddRange(New Object() {"Environmental", "Social", "Governance", "Community", "Education", "Health", "Other"})
        cboType.Location = New Point(145, 380)
        cboType.Margin = New Padding(4, 3, 4, 3)
        cboType.Name = "cboType"
        cboType.Size = New Size(114, 23)
        cboType.TabIndex = 22
        ' 
        ' dtpActivityDate
        ' 
        dtpActivityDate.Format = DateTimePickerFormat.Short
        dtpActivityDate.Location = New Point(145, 30)
        dtpActivityDate.Margin = New Padding(4, 3, 4, 3)
        dtpActivityDate.Name = "dtpActivityDate"
        dtpActivityDate.Size = New Size(114, 23)
        dtpActivityDate.TabIndex = 23
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.Control
        btnSave.Location = New Point(50, 438)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(82, 28)
        btnSave.TabIndex = 24
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.Control
        btnRefresh.Location = New Point(277, 320)
        btnRefresh.Margin = New Padding(4, 3, 4, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(98, 28)
        btnRefresh.TabIndex = 25
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.Control
        btnUpdate.Location = New Point(230, 438)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(76, 26)
        btnUpdate.TabIndex = 26
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        btnUpdate.Visible = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Location = New Point(277, 354)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(98, 28)
        btnDelete.TabIndex = 27
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.Control
        btnExportExcel.Location = New Point(7, 51)
        btnExportExcel.Margin = New Padding(4, 3, 4, 3)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(95, 23)
        btnExportExcel.TabIndex = 28
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnUploadPhotos
        ' 
        btnUploadPhotos.Location = New Point(277, 250)
        btnUploadPhotos.Margin = New Padding(4, 3, 4, 3)
        btnUploadPhotos.Name = "btnUploadPhotos"
        btnUploadPhotos.Size = New Size(98, 27)
        btnUploadPhotos.TabIndex = 29
        btnUploadPhotos.Text = "Upload Photos"
        btnUploadPhotos.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvData.DefaultCellStyle = DataGridViewCellStyle2
        dgvData.Location = New Point(7, 122)
        dgvData.Margin = New Padding(4, 3, 4, 3)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvData.Size = New Size(570, 296)
        dgvData.TabIndex = 30
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(75, 22)
        dtpStartDate.Margin = New Padding(4, 3, 4, 3)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(139, 23)
        dtpStartDate.TabIndex = 31
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(75, 56)
        dtpEndDate.Margin = New Padding(4, 3, 4, 3)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(139, 23)
        dtpEndDate.TabIndex = 32
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(7, 29)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(58, 15)
        Label13.TabIndex = 33
        Label13.Text = "Start Date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(7, 59)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(54, 15)
        Label14.TabIndex = 34
        Label14.Text = "End Date"
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(222, 22)
        btnFilter.Margin = New Padding(4, 3, 4, 3)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(88, 27)
        btnFilter.TabIndex = 35
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.Location = New Point(222, 52)
        btnClearFilter.Margin = New Padding(4, 3, 4, 3)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(88, 27)
        btnClearFilter.TabIndex = 36
        btnClearFilter.Text = "Clear Filter"
        btnClearFilter.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog1.Multiselect = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtpStartDate)
        GroupBox1.Controls.Add(btnClearFilter)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(btnFilter)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(dtpEndDate)
        GroupBox1.Location = New Point(110, 22)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(459, 89)
        GroupBox1.TabIndex = 38
        GroupBox1.TabStop = False
        GroupBox1.Text = "Date Range Filter"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Controls.Add(btnExportExcel)
        GroupBox2.Location = New Point(4, 3)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(577, 118)
        GroupBox2.TabIndex = 39
        GroupBox2.TabStop = False
        GroupBox2.Text = "Filter & Export"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(cboFrequency)
        GroupBox3.Controls.Add(btnBrowseFolder)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(txtPhotoFolderPath)
        GroupBox3.Controls.Add(btnClearForm)
        GroupBox3.Controls.Add(btnLoadSelected)
        GroupBox3.Controls.Add(dtpActivityDate)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Controls.Add(btnUploadPhotos)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtAction)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(txtDescription)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txtLocation)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(txtTimeEngagement)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(txtEmployeesEnvolved)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(txtHoursInvested)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtPeopleImpacted)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(txtQuantity)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(txtCostUSD)
        GroupBox3.Controls.Add(btnSave)
        GroupBox3.Controls.Add(cboType)
        GroupBox3.Controls.Add(btnRefresh)
        GroupBox3.Controls.Add(btnUpdate)
        GroupBox3.Controls.Add(btnDelete)
        GroupBox3.Location = New Point(13, 12)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(388, 474)
        GroupBox3.TabIndex = 40
        GroupBox3.TabStop = False
        GroupBox3.Text = "Data Entry Form"
        ' 
        ' cboFrequency
        ' 
        cboFrequency.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        cboFrequency.DropDownStyle = ComboBoxStyle.DropDownList
        cboFrequency.Font = New Font("Segoe UI", 10F)
        cboFrequency.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        cboFrequency.Items.AddRange(New Object() {"One-Time", "Weekly", "Monthly", "Quarterly", "Annually"})
        cboFrequency.Location = New Point(145, 140)
        cboFrequency.Name = "cboFrequency"
        cboFrequency.Size = New Size(114, 25)
        cboFrequency.TabIndex = 35
        ' 
        ' btnBrowseFolder
        ' 
        btnBrowseFolder.Location = New Point(277, 405)
        btnBrowseFolder.Margin = New Padding(4, 3, 4, 3)
        btnBrowseFolder.Name = "btnBrowseFolder"
        btnBrowseFolder.Size = New Size(35, 27)
        btnBrowseFolder.TabIndex = 34
        btnBrowseFolder.Text = "..."
        btnBrowseFolder.UseVisualStyleBackColor = True
        btnBrowseFolder.Visible = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(14, 412)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(83, 15)
        Label15.TabIndex = 33
        Label15.Text = "Photos Folder:"
        Label15.Visible = False
        ' 
        ' txtPhotoFolderPath
        ' 
        txtPhotoFolderPath.Location = New Point(145, 409)
        txtPhotoFolderPath.Margin = New Padding(4, 3, 4, 3)
        txtPhotoFolderPath.Name = "txtPhotoFolderPath"
        txtPhotoFolderPath.ReadOnly = True
        txtPhotoFolderPath.Size = New Size(114, 23)
        txtPhotoFolderPath.TabIndex = 32
        txtPhotoFolderPath.Text = "C:\ESG_CSR_Photos"
        txtPhotoFolderPath.Visible = False
        ' 
        ' btnClearForm
        ' 
        btnClearForm.BackColor = SystemColors.Control
        btnClearForm.Location = New Point(140, 438)
        btnClearForm.Margin = New Padding(4, 3, 4, 3)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(82, 28)
        btnClearForm.TabIndex = 31
        btnClearForm.Text = "Clear Form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' btnLoadSelected
        ' 
        btnLoadSelected.BackColor = SystemColors.Control
        btnLoadSelected.Location = New Point(277, 286)
        btnLoadSelected.Margin = New Padding(4, 3, 4, 3)
        btnLoadSelected.Name = "btnLoadSelected"
        btnLoadSelected.Size = New Size(98, 28)
        btnLoadSelected.TabIndex = 30
        btnLoadSelected.Text = "Load Selected"
        btnLoadSelected.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(dgvData)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Location = New Point(409, 152)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(585, 434)
        Panel1.TabIndex = 41
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnHome)
        GroupBox4.Controls.Add(pbPhotoPreview)
        GroupBox4.Controls.Add(lblPhotoCount)
        GroupBox4.Controls.Add(btnSetPrimary)
        GroupBox4.Controls.Add(btnViewPhoto)
        GroupBox4.Controls.Add(btnDeletePhoto)
        GroupBox4.Controls.Add(lvwPhotos)
        GroupBox4.Location = New Point(408, 12)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(586, 136)
        GroupBox4.TabIndex = 42
        GroupBox4.TabStop = False
        GroupBox4.Text = "Photo Management"
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Stretch
        btnHome.Location = New Point(534, 14)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(45, 38)
        btnHome.TabIndex = 6
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' pbPhotoPreview
        ' 
        pbPhotoPreview.BorderStyle = BorderStyle.FixedSingle
        pbPhotoPreview.Location = New Point(392, 20)
        pbPhotoPreview.Margin = New Padding(4, 3, 4, 3)
        pbPhotoPreview.Name = "pbPhotoPreview"
        pbPhotoPreview.Size = New Size(110, 108)
        pbPhotoPreview.SizeMode = PictureBoxSizeMode.Zoom
        pbPhotoPreview.TabIndex = 5
        pbPhotoPreview.TabStop = False
        ' 
        ' lblPhotoCount
        ' 
        lblPhotoCount.AutoSize = True
        lblPhotoCount.Location = New Point(170, 9)
        lblPhotoCount.Margin = New Padding(4, 0, 4, 0)
        lblPhotoCount.Name = "lblPhotoCount"
        lblPhotoCount.Size = New Size(82, 15)
        lblPhotoCount.TabIndex = 4
        lblPhotoCount.Text = "No photos yet"
        ' 
        ' btnSetPrimary
        ' 
        btnSetPrimary.BackColor = SystemColors.Control
        btnSetPrimary.Location = New Point(288, 20)
        btnSetPrimary.Margin = New Padding(4, 3, 4, 3)
        btnSetPrimary.Name = "btnSetPrimary"
        btnSetPrimary.Size = New Size(86, 28)
        btnSetPrimary.TabIndex = 3
        btnSetPrimary.Text = "Set as Primary"
        btnSetPrimary.UseVisualStyleBackColor = False
        btnSetPrimary.Visible = False
        ' 
        ' btnViewPhoto
        ' 
        btnViewPhoto.BackColor = SystemColors.Control
        btnViewPhoto.Location = New Point(288, 95)
        btnViewPhoto.Margin = New Padding(4, 3, 4, 3)
        btnViewPhoto.Name = "btnViewPhoto"
        btnViewPhoto.Size = New Size(86, 33)
        btnViewPhoto.TabIndex = 2
        btnViewPhoto.Text = "View Photo"
        btnViewPhoto.UseVisualStyleBackColor = False
        ' 
        ' btnDeletePhoto
        ' 
        btnDeletePhoto.BackColor = SystemColors.Control
        btnDeletePhoto.Location = New Point(288, 54)
        btnDeletePhoto.Margin = New Padding(4, 3, 4, 3)
        btnDeletePhoto.Name = "btnDeletePhoto"
        btnDeletePhoto.Size = New Size(86, 35)
        btnDeletePhoto.TabIndex = 1
        btnDeletePhoto.Text = "Delete Photo"
        btnDeletePhoto.UseVisualStyleBackColor = False
        ' 
        ' lvwPhotos
        ' 
        lvwPhotos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        lvwPhotos.FullRowSelect = True
        lvwPhotos.GridLines = True
        lvwPhotos.Location = New Point(8, 25)
        lvwPhotos.Margin = New Padding(4, 3, 4, 3)
        lvwPhotos.Name = "lvwPhotos"
        lvwPhotos.Size = New Size(269, 103)
        lvwPhotos.TabIndex = 0
        lvwPhotos.UseCompatibleStateImageBehavior = False
        lvwPhotos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Photo Name"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Primary"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Upload Date"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Original Name"
        ColumnHeader4.Width = 100
        ' 
        ' frmCSR
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1007, 635)
        Controls.Add(GroupBox4)
        Controls.Add(Panel1)
        Controls.Add(GroupBox3)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmCSR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG/CSR Data Management System"
        CType(txtEmployeesEnvolved, ComponentModel.ISupportInitialize).EndInit()
        CType(txtHoursInvested, ComponentModel.ISupportInitialize).EndInit()
        CType(txtPeopleImpacted, ComponentModel.ISupportInitialize).EndInit()
        CType(txtQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(txtCostUSD, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        Panel1.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(pbPhotoPreview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtTimeEngagement As TextBox
    Friend WithEvents txtEmployeesEnvolved As NumericUpDown
    Friend WithEvents txtHoursInvested As NumericUpDown
    Friend WithEvents txtPeopleImpacted As NumericUpDown
    Friend WithEvents txtQuantity As NumericUpDown
    Friend WithEvents txtCostUSD As NumericUpDown
    Friend WithEvents cboType As ComboBox
    Friend WithEvents dtpActivityDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnUploadPhotos As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lvwPhotos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnDeletePhoto As Button
    Friend WithEvents btnViewPhoto As Button
    Friend WithEvents btnSetPrimary As Button
    Friend WithEvents lblPhotoCount As Label
    Friend WithEvents pbPhotoPreview As PictureBox
    Friend WithEvents btnLoadSelected As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnBrowseFolder As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPhotoFolderPath As TextBox
    Friend WithEvents cboFrequency As ComboBox
    Friend WithEvents btnHome As Button
End Class