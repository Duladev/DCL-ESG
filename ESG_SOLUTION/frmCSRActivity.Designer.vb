<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCSRActivity
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlMain = New Panel()
        pnlBody = New Panel()
        pnlRight = New Panel()
        pnlGridCard = New Panel()
        pnlGridAccent = New Panel()
        lblGridTitle = New Label()
        lblRecordCount = New Label()
        pnlFilter = New Panel()
        lblFrom = New Label()
        dtpFrom = New DateTimePicker()
        lblTo = New Label()
        dtpTo = New DateTimePicker()
        btnSearch = New RoundedButton()
        btnRefresh = New RoundedButton()
        dgvCSR = New DataGridView()
        pnlLeft = New Panel()
        pnlFormCard = New Panel()
        pnlFormAccent = New Panel()
        lblFormTitle = New Label()
        lblDate = New Label()
        dtpDate = New DateTimePicker()
        lblAction = New Label()
        txtAction = New TextBox()
        lblDesc = New Label()
        txtDescription = New TextBox()
        lblFrequency = New Label()
        cboFrequency = New ComboBox()
        lblLocation = New Label()
        txtLocation = New TextBox()
        lblEngagement = New Label()
        cboEngagement = New ComboBox()
        lblActivityType = New Label()
        cboActivityType = New ComboBox()
        lblEmployees = New Label()
        txtEmployees = New TextBox()
        lblHours = New Label()
        txtHours = New TextBox()
        lblPeople = New Label()
        txtPeople = New TextBox()
        lblQty = New Label()
        txtQty = New TextBox()
        lblCost = New Label()
        txtCost = New TextBox()
        lblPhoto = New Label()
        txtPhotoPath = New TextBox()
        btnBrowse = New RoundedButton()
        pnlPhotoPreview = New Panel()
        picPreview = New PictureBox()
        lblPhotoHint = New Label()
        btnSave = New RoundedButton()
        btnUpdate = New RoundedButton()
        btnDelete = New RoundedButton()
        btnClear = New RoundedButton()
        pnlTitleBar = New Panel()
        lblTitleIcon = New Label()
        lblTitle = New Label()
        btnMinimize = New Button()
        btnClose = New Button()
        pnlStatus = New Panel()
        lblStatusIcon = New Label()
        lblStatus = New Label()
        tmrStatus = New Timer(components)
        pnlMain.SuspendLayout()
        pnlBody.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlGridCard.SuspendLayout()
        pnlFilter.SuspendLayout()
        CType(dgvCSR, ComponentModel.ISupportInitialize).BeginInit()
        pnlLeft.SuspendLayout()
        pnlFormCard.SuspendLayout()
        pnlPhotoPreview.SuspendLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        pnlTitleBar.SuspendLayout()
        pnlStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        pnlMain.Controls.Add(pnlBody)
        pnlMain.Controls.Add(pnlTitleBar)
        pnlMain.Controls.Add(pnlStatus)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1150, 700)
        pnlMain.TabIndex = 0
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = SystemColors.Control
        pnlBody.Controls.Add(pnlRight)
        pnlBody.Controls.Add(pnlLeft)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.ForeColor = SystemColors.Control
        pnlBody.Location = New Point(0, 52)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(14, 10, 14, 10)
        pnlBody.Size = New Size(1150, 616)
        pnlBody.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.Transparent
        pnlRight.Controls.Add(pnlGridCard)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(454, 10)
        pnlRight.Name = "pnlRight"
        pnlRight.Size = New Size(682, 596)
        pnlRight.TabIndex = 0
        ' 
        ' pnlGridCard
        ' 
        pnlGridCard.BackColor = SystemColors.Control
        pnlGridCard.Controls.Add(pnlGridAccent)
        pnlGridCard.Controls.Add(lblGridTitle)
        pnlGridCard.Controls.Add(lblRecordCount)
        pnlGridCard.Controls.Add(pnlFilter)
        pnlGridCard.Controls.Add(dgvCSR)
        pnlGridCard.Dock = DockStyle.Fill
        pnlGridCard.Location = New Point(0, 0)
        pnlGridCard.Name = "pnlGridCard"
        pnlGridCard.Padding = New Padding(16)
        pnlGridCard.Size = New Size(682, 596)
        pnlGridCard.TabIndex = 0
        ' 
        ' pnlGridAccent
        ' 
        pnlGridAccent.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        pnlGridAccent.Location = New Point(16, 16)
        pnlGridAccent.Name = "pnlGridAccent"
        pnlGridAccent.Size = New Size(40, 3)
        pnlGridAccent.TabIndex = 0
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.BackColor = Color.Transparent
        lblGridTitle.Font = New Font("Georgia", 13F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.Black
        lblGridTitle.Location = New Point(16, 26)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(160, 21)
        lblGridTitle.TabIndex = 1
        lblGridTitle.Text = "Activity Records"
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.BackColor = Color.Transparent
        lblRecordCount.Font = New Font("Segoe UI", 9F)
        lblRecordCount.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblRecordCount.Location = New Point(16, 50)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(55, 15)
        lblRecordCount.TabIndex = 2
        lblRecordCount.Text = "0 records"
        ' 
        ' pnlFilter
        ' 
        pnlFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilter.BackColor = SystemColors.Control
        pnlFilter.Controls.Add(lblFrom)
        pnlFilter.Controls.Add(dtpFrom)
        pnlFilter.Controls.Add(lblTo)
        pnlFilter.Controls.Add(dtpTo)
        pnlFilter.Controls.Add(btnSearch)
        pnlFilter.Controls.Add(btnRefresh)
        pnlFilter.Location = New Point(19, 68)
        pnlFilter.Name = "pnlFilter"
        pnlFilter.Size = New Size(649, 46)
        pnlFilter.TabIndex = 3
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.BackColor = Color.Transparent
        lblFrom.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblFrom.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFrom.Location = New Point(10, 6)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(35, 12)
        lblFrom.TabIndex = 0
        lblFrom.Text = "FROM"
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Font = New Font("Segoe UI", 9.5F)
        dtpFrom.Format = DateTimePickerFormat.Short
        dtpFrom.Location = New Point(46, 4)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(130, 24)
        dtpFrom.TabIndex = 1
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.BackColor = Color.Transparent
        lblTo.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblTo.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTo.Location = New Point(188, 6)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(19, 12)
        lblTo.TabIndex = 2
        lblTo.Text = "TO"
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Segoe UI", 9.5F)
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(208, 4)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(130, 24)
        dtpTo.TabIndex = 3
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnSearch.CornerRadius = 8
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.ForeColor = Color.FromArgb(CByte(5), CByte(30), CByte(20))
        btnSearch.Location = New Point(350, 6)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(83, 22)
        btnSearch.TabIndex = 4
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        btnRefresh.CornerRadius = 8
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnRefresh.Location = New Point(450, 6)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(83, 22)
        btnRefresh.TabIndex = 5
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvCSR
        ' 
        dgvCSR.AllowUserToAddRows = False
        dgvCSR.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(18), CByte(26), CByte(36))
        dgvCSR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvCSR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCSR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCSR.BackgroundColor = SystemColors.Control
        dgvCSR.BorderStyle = BorderStyle.None
        dgvCSR.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(16), CByte(24), CByte(34))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCSR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCSR.ColumnHeadersHeight = 38
        dgvCSR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(22), CByte(30), CByte(40))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle3.ForeColor = SystemColors.Control
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(58), CByte(50))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCSR.DefaultCellStyle = DataGridViewCellStyle3
        dgvCSR.EnableHeadersVisualStyles = False
        dgvCSR.Font = New Font("Segoe UI", 9.5F)
        dgvCSR.GridColor = Color.FromArgb(CByte(30), CByte(42), CByte(56))
        dgvCSR.Location = New Point(19, 120)
        dgvCSR.MultiSelect = False
        dgvCSR.Name = "dgvCSR"
        dgvCSR.ReadOnly = True
        dgvCSR.RowHeadersVisible = False
        dgvCSR.RowTemplate.Height = 34
        dgvCSR.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCSR.Size = New Size(649, 469)
        dgvCSR.TabIndex = 4
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.Transparent
        pnlLeft.Controls.Add(pnlFormCard)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(14, 10)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(0, 0, 10, 0)
        pnlLeft.Size = New Size(440, 596)
        pnlLeft.TabIndex = 1
        ' 
        ' pnlFormCard
        ' 
        pnlFormCard.BackColor = SystemColors.Control
        pnlFormCard.Controls.Add(pnlFormAccent)
        pnlFormCard.Controls.Add(lblFormTitle)
        pnlFormCard.Controls.Add(lblDate)
        pnlFormCard.Controls.Add(dtpDate)
        pnlFormCard.Controls.Add(lblAction)
        pnlFormCard.Controls.Add(txtAction)
        pnlFormCard.Controls.Add(lblDesc)
        pnlFormCard.Controls.Add(txtDescription)
        pnlFormCard.Controls.Add(lblFrequency)
        pnlFormCard.Controls.Add(cboFrequency)
        pnlFormCard.Controls.Add(lblLocation)
        pnlFormCard.Controls.Add(txtLocation)
        pnlFormCard.Controls.Add(lblEngagement)
        pnlFormCard.Controls.Add(cboEngagement)
        pnlFormCard.Controls.Add(lblActivityType)
        pnlFormCard.Controls.Add(cboActivityType)
        pnlFormCard.Controls.Add(lblEmployees)
        pnlFormCard.Controls.Add(txtEmployees)
        pnlFormCard.Controls.Add(lblHours)
        pnlFormCard.Controls.Add(txtHours)
        pnlFormCard.Controls.Add(lblPeople)
        pnlFormCard.Controls.Add(txtPeople)
        pnlFormCard.Controls.Add(lblQty)
        pnlFormCard.Controls.Add(txtQty)
        pnlFormCard.Controls.Add(lblCost)
        pnlFormCard.Controls.Add(txtCost)
        pnlFormCard.Controls.Add(lblPhoto)
        pnlFormCard.Controls.Add(txtPhotoPath)
        pnlFormCard.Controls.Add(btnBrowse)
        pnlFormCard.Controls.Add(pnlPhotoPreview)
        pnlFormCard.Controls.Add(btnSave)
        pnlFormCard.Controls.Add(btnUpdate)
        pnlFormCard.Controls.Add(btnDelete)
        pnlFormCard.Controls.Add(btnClear)
        pnlFormCard.Dock = DockStyle.Fill
        pnlFormCard.Location = New Point(0, 0)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Padding = New Padding(20, 16, 20, 16)
        pnlFormCard.Size = New Size(430, 596)
        pnlFormCard.TabIndex = 0
        ' 
        ' pnlFormAccent
        ' 
        pnlFormAccent.BackColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        pnlFormAccent.Location = New Point(20, 16)
        pnlFormAccent.Name = "pnlFormAccent"
        pnlFormAccent.Size = New Size(40, 3)
        pnlFormAccent.TabIndex = 0
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.BackColor = Color.Transparent
        lblFormTitle.Font = New Font("Georgia", 13F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.Black
        lblFormTitle.Location = New Point(20, 26)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(183, 21)
        lblFormTitle.TabIndex = 1
        lblFormTitle.Text = "New Activity Entry"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.BackColor = Color.Transparent
        lblDate.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblDate.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDate.Location = New Point(20, 60)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(76, 12)
        lblDate.TabIndex = 2
        lblDate.Text = "ACTIVITY DATE"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI", 10F)
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(20, 78)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(175, 25)
        dtpDate.TabIndex = 3
        ' 
        ' lblAction
        ' 
        lblAction.AutoSize = True
        lblAction.BackColor = Color.Transparent
        lblAction.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblAction.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblAction.Location = New Point(208, 60)
        lblAction.Name = "lblAction"
        lblAction.Size = New Size(43, 12)
        lblAction.TabIndex = 4
        lblAction.Text = "ACTION"
        ' 
        ' txtAction
        ' 
        txtAction.BackColor = SystemColors.Control
        txtAction.BorderStyle = BorderStyle.FixedSingle
        txtAction.Font = New Font("Segoe UI", 10F)
        txtAction.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtAction.Location = New Point(208, 78)
        txtAction.Name = "txtAction"
        txtAction.Size = New Size(190, 25)
        txtAction.TabIndex = 5
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.BackColor = Color.Transparent
        lblDesc.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblDesc.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDesc.Location = New Point(20, 116)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(70, 12)
        lblDesc.TabIndex = 6
        lblDesc.Text = "DESCRIPTION"
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = SystemColors.Control
        txtDescription.BorderStyle = BorderStyle.FixedSingle
        txtDescription.Font = New Font("Segoe UI", 10F)
        txtDescription.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtDescription.Location = New Point(20, 134)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ScrollBars = ScrollBars.Vertical
        txtDescription.Size = New Size(378, 60)
        txtDescription.TabIndex = 7
        ' 
        ' lblFrequency
        ' 
        lblFrequency.AutoSize = True
        lblFrequency.BackColor = Color.Transparent
        lblFrequency.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblFrequency.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFrequency.Location = New Point(20, 204)
        lblFrequency.Name = "lblFrequency"
        lblFrequency.Size = New Size(62, 12)
        lblFrequency.TabIndex = 8
        lblFrequency.Text = "FREQUENCY"
        ' 
        ' cboFrequency
        ' 
        cboFrequency.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        cboFrequency.DropDownStyle = ComboBoxStyle.DropDownList
        cboFrequency.Font = New Font("Segoe UI", 10F)
        cboFrequency.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        cboFrequency.Items.AddRange(New Object() {"One-Time", "Weekly", "Monthly", "Quarterly", "Annually"})
        cboFrequency.Location = New Point(20, 222)
        cboFrequency.Name = "cboFrequency"
        cboFrequency.Size = New Size(175, 25)
        cboFrequency.TabIndex = 9
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.BackColor = Color.Transparent
        lblLocation.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblLocation.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblLocation.Location = New Point(208, 204)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(55, 12)
        lblLocation.TabIndex = 10
        lblLocation.Text = "LOCATION"
        ' 
        ' txtLocation
        ' 
        txtLocation.BackColor = SystemColors.Control
        txtLocation.BorderStyle = BorderStyle.FixedSingle
        txtLocation.Font = New Font("Segoe UI", 10F)
        txtLocation.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtLocation.Location = New Point(208, 222)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(190, 25)
        txtLocation.TabIndex = 11
        ' 
        ' lblEngagement
        ' 
        lblEngagement.AutoSize = True
        lblEngagement.BackColor = Color.Transparent
        lblEngagement.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblEngagement.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblEngagement.Location = New Point(20, 260)
        lblEngagement.Name = "lblEngagement"
        lblEngagement.Size = New Size(99, 12)
        lblEngagement.TabIndex = 12
        lblEngagement.Text = "ENGAGEMENT TYPE"
        ' 
        ' cboEngagement
        ' 
        cboEngagement.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        cboEngagement.DropDownStyle = ComboBoxStyle.DropDownList
        cboEngagement.Font = New Font("Segoe UI", 10F)
        cboEngagement.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        cboEngagement.Items.AddRange(New Object() {"Community", "Employee", "Partnership", "Government", "Educational", "Environmental"})
        cboEngagement.Location = New Point(20, 278)
        cboEngagement.Name = "cboEngagement"
        cboEngagement.Size = New Size(175, 25)
        cboEngagement.TabIndex = 13
        ' 
        ' lblActivityType
        ' 
        lblActivityType.AutoSize = True
        lblActivityType.BackColor = Color.Transparent
        lblActivityType.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblActivityType.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblActivityType.Location = New Point(208, 260)
        lblActivityType.Name = "lblActivityType"
        lblActivityType.Size = New Size(75, 12)
        lblActivityType.TabIndex = 14
        lblActivityType.Text = "ACTIVITY TYPE"
        ' 
        ' cboActivityType
        ' 
        cboActivityType.BackColor = Color.FromArgb(CByte(30), CByte(40), CByte(52))
        cboActivityType.DropDownStyle = ComboBoxStyle.DropDownList
        cboActivityType.Font = New Font("Segoe UI", 10F)
        cboActivityType.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        cboActivityType.Items.AddRange(New Object() {"Environmental", "Social", "Governance", "Health", "Education", "Sports", "Cultural"})
        cboActivityType.Location = New Point(208, 278)
        cboActivityType.Name = "cboActivityType"
        cboActivityType.Size = New Size(190, 25)
        cboActivityType.TabIndex = 15
        ' 
        ' lblEmployees
        ' 
        lblEmployees.AutoSize = True
        lblEmployees.BackColor = Color.Transparent
        lblEmployees.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblEmployees.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblEmployees.Location = New Point(20, 316)
        lblEmployees.Name = "lblEmployees"
        lblEmployees.Size = New Size(61, 12)
        lblEmployees.TabIndex = 16
        lblEmployees.Text = "EMPLOYEES"
        ' 
        ' txtEmployees
        ' 
        txtEmployees.BackColor = SystemColors.Control
        txtEmployees.BorderStyle = BorderStyle.FixedSingle
        txtEmployees.Font = New Font("Segoe UI", 10F)
        txtEmployees.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtEmployees.Location = New Point(20, 334)
        txtEmployees.Name = "txtEmployees"
        txtEmployees.Size = New Size(112, 25)
        txtEmployees.TabIndex = 17
        txtEmployees.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblHours
        ' 
        lblHours.AutoSize = True
        lblHours.BackColor = Color.Transparent
        lblHours.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblHours.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHours.Location = New Point(144, 316)
        lblHours.Name = "lblHours"
        lblHours.Size = New Size(91, 12)
        lblHours.TabIndex = 18
        lblHours.Text = "HOURS INVESTED"
        ' 
        ' txtHours
        ' 
        txtHours.BackColor = SystemColors.Control
        txtHours.BorderStyle = BorderStyle.FixedSingle
        txtHours.Font = New Font("Segoe UI", 10F)
        txtHours.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtHours.Location = New Point(144, 334)
        txtHours.Name = "txtHours"
        txtHours.Size = New Size(112, 25)
        txtHours.TabIndex = 19
        txtHours.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPeople
        ' 
        lblPeople.AutoSize = True
        lblPeople.BackColor = Color.Transparent
        lblPeople.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblPeople.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblPeople.Location = New Point(268, 316)
        lblPeople.Name = "lblPeople"
        lblPeople.Size = New Size(92, 12)
        lblPeople.TabIndex = 20
        lblPeople.Text = "PEOPLE IMPACTED"
        ' 
        ' txtPeople
        ' 
        txtPeople.BackColor = SystemColors.Control
        txtPeople.BorderStyle = BorderStyle.FixedSingle
        txtPeople.Font = New Font("Segoe UI", 10F)
        txtPeople.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtPeople.Location = New Point(268, 334)
        txtPeople.Name = "txtPeople"
        txtPeople.Size = New Size(130, 25)
        txtPeople.TabIndex = 21
        txtPeople.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.BackColor = Color.Transparent
        lblQty.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblQty.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblQty.Location = New Point(20, 372)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(56, 12)
        lblQty.TabIndex = 22
        lblQty.Text = "QUANTITY"
        ' 
        ' txtQty
        ' 
        txtQty.BackColor = SystemColors.Control
        txtQty.BorderStyle = BorderStyle.FixedSingle
        txtQty.Font = New Font("Segoe UI", 10F)
        txtQty.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtQty.Location = New Point(20, 390)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(175, 25)
        txtQty.TabIndex = 23
        txtQty.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.BackColor = Color.Transparent
        lblCost.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblCost.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCost.Location = New Point(208, 372)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(62, 12)
        lblCost.TabIndex = 24
        lblCost.Text = "COST (USD)"
        ' 
        ' txtCost
        ' 
        txtCost.BackColor = SystemColors.Control
        txtCost.BorderStyle = BorderStyle.FixedSingle
        txtCost.Font = New Font("Segoe UI", 10F)
        txtCost.ForeColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        txtCost.Location = New Point(208, 390)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(190, 25)
        txtCost.TabIndex = 25
        txtCost.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblPhoto
        ' 
        lblPhoto.AutoSize = True
        lblPhoto.BackColor = Color.Transparent
        lblPhoto.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblPhoto.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblPhoto.Location = New Point(20, 428)
        lblPhoto.Name = "lblPhoto"
        lblPhoto.Size = New Size(41, 12)
        lblPhoto.TabIndex = 26
        lblPhoto.Text = "PHOTO"
        ' 
        ' txtPhotoPath
        ' 
        txtPhotoPath.BackColor = SystemColors.Control
        txtPhotoPath.BorderStyle = BorderStyle.FixedSingle
        txtPhotoPath.Font = New Font("Segoe UI", 9F)
        txtPhotoPath.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        txtPhotoPath.Location = New Point(20, 446)
        txtPhotoPath.Name = "txtPhotoPath"
        txtPhotoPath.ReadOnly = True
        txtPhotoPath.Size = New Size(280, 23)
        txtPhotoPath.TabIndex = 27
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.Control
        btnBrowse.CornerRadius = 8
        btnBrowse.Cursor = Cursors.Hand
        btnBrowse.FlatAppearance.BorderColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBrowse.ForeColor = SystemColors.ActiveCaptionText
        btnBrowse.Location = New Point(308, 441)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(90, 28)
        btnBrowse.TabIndex = 28
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pnlPhotoPreview
        ' 
        pnlPhotoPreview.BackColor = Color.FromArgb(CByte(18), CByte(26), CByte(36))
        pnlPhotoPreview.BorderStyle = BorderStyle.FixedSingle
        pnlPhotoPreview.Controls.Add(picPreview)
        pnlPhotoPreview.Controls.Add(lblPhotoHint)
        pnlPhotoPreview.Location = New Point(20, 482)
        pnlPhotoPreview.Name = "pnlPhotoPreview"
        pnlPhotoPreview.Size = New Size(378, 70)
        pnlPhotoPreview.TabIndex = 29
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = SystemColors.Control
        picPreview.Cursor = Cursors.Hand
        picPreview.Dock = DockStyle.Fill
        picPreview.Location = New Point(0, 0)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(376, 68)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 0
        picPreview.TabStop = False
        ' 
        ' lblPhotoHint
        ' 
        lblPhotoHint.BackColor = Color.Transparent
        lblPhotoHint.Dock = DockStyle.Fill
        lblPhotoHint.Font = New Font("Segoe UI", 9F)
        lblPhotoHint.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblPhotoHint.Location = New Point(0, 0)
        lblPhotoHint.Name = "lblPhotoHint"
        lblPhotoHint.Size = New Size(376, 68)
        lblPhotoHint.TabIndex = 1
        lblPhotoHint.Text = "No photo selected"
        lblPhotoHint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.AppWorkspace
        btnSave.CornerRadius = 8
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9.75F)
        btnSave.ForeColor = SystemColors.ActiveCaptionText
        btnSave.Location = New Point(26, 558)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(71, 31)
        btnSave.TabIndex = 30
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.AppWorkspace
        btnUpdate.CornerRadius = 8
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Enabled = False
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9.75F)
        btnUpdate.ForeColor = SystemColors.ActiveCaptionText
        btnUpdate.Location = New Point(120, 558)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(71, 31)
        btnUpdate.TabIndex = 31
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.AppWorkspace
        btnDelete.CornerRadius = 8
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 9.75F)
        btnDelete.ForeColor = SystemColors.ActiveCaptionText
        btnDelete.Location = New Point(214, 558)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(71, 31)
        btnDelete.TabIndex = 32
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.AppWorkspace
        btnClear.CornerRadius = 8
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(50), CByte(65), CByte(80))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.5F)
        btnClear.ForeColor = SystemColors.ActiveCaptionText
        btnClear.Location = New Point(308, 558)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(71, 31)
        btnClear.TabIndex = 33
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = SystemColors.Control
        pnlTitleBar.Controls.Add(lblTitleIcon)
        pnlTitleBar.Controls.Add(lblTitle)
        pnlTitleBar.Controls.Add(btnMinimize)
        pnlTitleBar.Controls.Add(btnClose)
        pnlTitleBar.Dock = DockStyle.Top
        pnlTitleBar.Location = New Point(0, 0)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1150, 52)
        pnlTitleBar.TabIndex = 1
        ' 
        ' lblTitleIcon
        ' 
        lblTitleIcon.AutoSize = True
        lblTitleIcon.BackColor = Color.Transparent
        lblTitleIcon.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblTitleIcon.ForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        lblTitleIcon.Location = New Point(29, 9)
        lblTitleIcon.Name = "lblTitleIcon"
        lblTitleIcon.Size = New Size(47, 25)
        lblTitleIcon.TabIndex = 0
        lblTitleIcon.Text = "CSR"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Georgia", 14F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Black
        lblTitle.Location = New Point(82, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(264, 23)
        lblTitle.TabIndex = 1
        lblTitle.Text = "CSR Activity Management"
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 12F)
        btnMinimize.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnMinimize.Location = New Point(2006, 6)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(40, 40)
        btnMinimize.TabIndex = 2
        btnMinimize.Text = "-"
        btnMinimize.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnClose.Location = New Point(2050, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 3
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' pnlStatus
        ' 
        pnlStatus.BackColor = SystemColors.Control
        pnlStatus.Controls.Add(lblStatusIcon)
        pnlStatus.Controls.Add(lblStatus)
        pnlStatus.Dock = DockStyle.Bottom
        pnlStatus.Location = New Point(0, 668)
        pnlStatus.Name = "pnlStatus"
        pnlStatus.Size = New Size(1150, 32)
        pnlStatus.TabIndex = 2
        ' 
        ' lblStatusIcon
        ' 
        lblStatusIcon.AutoSize = True
        lblStatusIcon.BackColor = Color.Transparent
        lblStatusIcon.Font = New Font("Segoe UI", 10F)
        lblStatusIcon.ForeColor = Color.FromArgb(CByte(16), CByte(185), CByte(129))
        lblStatusIcon.Location = New Point(14, 8)
        lblStatusIcon.Name = "lblStatusIcon"
        lblStatusIcon.Size = New Size(20, 19)
        lblStatusIcon.TabIndex = 0
        lblStatusIcon.Text = "O"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI", 9F)
        lblStatus.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatus.Location = New Point(37, 8)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 15)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Ready"
        ' 
        ' tmrStatus
        ' 
        tmrStatus.Interval = 3000
        ' 
        ' frmCSRActivity
        ' 
        AcceptButton = btnSave
        BackColor = Color.FromArgb(CByte(15), CByte(20), CByte(28))
        ClientSize = New Size(1150, 700)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1000, 650)
        Name = "frmCSRActivity"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DCL-ESG | CSR Activities"
        pnlMain.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlGridCard.ResumeLayout(False)
        pnlGridCard.PerformLayout()
        pnlFilter.ResumeLayout(False)
        pnlFilter.PerformLayout()
        CType(dgvCSR, ComponentModel.ISupportInitialize).EndInit()
        pnlLeft.ResumeLayout(False)
        pnlFormCard.ResumeLayout(False)
        pnlFormCard.PerformLayout()
        pnlPhotoPreview.ResumeLayout(False)
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlStatus.ResumeLayout(False)
        pnlStatus.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
    Friend WithEvents lblTitleIcon As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents pnlFormCard As System.Windows.Forms.Panel
    Friend WithEvents pnlFormAccent As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents cboFrequency As System.Windows.Forms.ComboBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblEngagement As System.Windows.Forms.Label
    Friend WithEvents cboEngagement As System.Windows.Forms.ComboBox
    Friend WithEvents lblActivityType As System.Windows.Forms.Label
    Friend WithEvents cboActivityType As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmployees As System.Windows.Forms.Label
    Friend WithEvents txtEmployees As System.Windows.Forms.TextBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents lblPeople As System.Windows.Forms.Label
    Friend WithEvents txtPeople As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoto As System.Windows.Forms.Label
    Friend WithEvents txtPhotoPath As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As RoundedButton
    Friend WithEvents pnlPhotoPreview As System.Windows.Forms.Panel
    Friend WithEvents picPreview As System.Windows.Forms.PictureBox
    Friend WithEvents lblPhotoHint As System.Windows.Forms.Label
    Friend WithEvents btnSave As RoundedButton
    Friend WithEvents btnUpdate As RoundedButton
    Friend WithEvents btnDelete As RoundedButton
    Friend WithEvents btnClear As RoundedButton
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
    Friend WithEvents pnlGridAccent As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents lblRecordCount As System.Windows.Forms.Label
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As RoundedButton
    Friend WithEvents btnRefresh As RoundedButton
    Friend WithEvents dgvCSR As System.Windows.Forms.DataGridView
    Friend WithEvents pnlStatus As System.Windows.Forms.Panel
    Friend WithEvents lblStatusIcon As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tmrStatus As System.Windows.Forms.Timer
End Class