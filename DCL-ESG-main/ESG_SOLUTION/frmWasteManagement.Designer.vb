<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWasteManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWasteManagement))
        tabWasteCategories = New TabControl()
        tpNonRecycled = New TabPage()
        grpNonRecycledActions = New GroupBox()
        btnFilterNonRecycled = New Button()
        btnExportNonRecycled = New Button()
        btnRefreshNonRecycled = New Button()
        btnDeleteNonRecycled = New Button()
        btnUpdateNonRecycled = New Button()
        btnSaveNonRecycled = New Button()
        btnViewLicenseNonRecycled = New Button()
        btnUploadNonRecycled = New Button()
        lblCollectorNonRecycled = New Label()
        cmbCollectorNonRecycled = New ComboBox()
        dtpRecordDateNonRecycled = New DateTimePicker()
        lblDateNonRecycled = New Label()
        dgvNonRecycled = New DataGridView()
        flpNonRecycledItems = New FlowLayoutPanel()
        btnAddNonRecycledItem = New Button()
        lblNonPolyethene = New Label()
        numNonPolyethene = New NumericUpDown()
        lblNonPlastic = New Label()
        numNonPlastic = New NumericUpDown()
        tpRecycled = New TabPage()
        grpRecycledActions = New GroupBox()
        btnFilterRecycled = New Button()
        btnExportRecycled = New Button()
        btnRefreshRecycled = New Button()
        btnDeleteRecycled = New Button()
        btnUpdateRecycled = New Button()
        btnSaveRecycled = New Button()
        btnViewLicenseRecycled = New Button()
        btnUploadRecycled = New Button()
        lblCollectorRecycled = New Label()
        cmbCollectorRecycled = New ComboBox()
        dtpRecordDateRecycled = New DateTimePicker()
        lblDateRecycled = New Label()
        dgvRecycled = New DataGridView()
        flpRecycledItems = New FlowLayoutPanel()
        btnAddRecycledItem = New Button()
        lblRecPaper = New Label()
        numRecPaper = New NumericUpDown()
        lblRecCardboard = New Label()
        numRecCardboard = New NumericUpDown()
        lblRecPlastic = New Label()
        numRecPlastic = New NumericUpDown()
        lblRecOtherPlastic = New Label()
        numRecOtherPlastic = New NumericUpDown()
        tpOtherRecycled = New TabPage()
        grpOtherRecycledActions = New GroupBox()
        btnFilterOtherRecycled = New Button()
        btnExportOtherRecycled = New Button()
        btnRefreshOtherRecycled = New Button()
        btnDeleteOtherRecycled = New Button()
        btnUpdateOtherRecycled = New Button()
        btnSaveOtherRecycled = New Button()
        btnViewLicenseOtherRecycled = New Button()
        btnUploadOtherRecycled = New Button()
        lblCollectorOtherRecycled = New Label()
        cmbCollectorOtherRecycled = New ComboBox()
        dtpRecordDateOtherRecycled = New DateTimePicker()
        lblDateOtherRecycled = New Label()
        dgvOtherRecycled = New DataGridView()
        flpOtherRecycledItems = New FlowLayoutPanel()
        btnAddOtherRecycledItem = New Button()
        lblOrgFood = New Label()
        numOrgFood = New NumericUpDown()
        chkCompost = New CheckBox()
        chkAnimalFeed = New CheckBox()
        lblCopper = New Label()
        numCopper = New NumericUpDown()
        lblAluminium = New Label()
        numAluminium = New NumericUpDown()
        lblGlass = New Label()
        numGlass = New NumericUpDown()
        lblEWaste = New Label()
        numEWaste = New NumericUpDown()
        tpChemical = New TabPage()
        grpChemicalActions = New GroupBox()
        btnFilterChemical = New Button()
        btnExportChemical = New Button()
        btnRefreshChemical = New Button()
        btnDeleteChemical = New Button()
        btnUpdateChemical = New Button()
        btnSaveChemical = New Button()
        btnViewLicenseChemical = New Button()
        btnUploadChemical = New Button()
        lblCollectorChemical = New Label()
        cmbCollectorChemical = New ComboBox()
        dtpRecordDateChemical = New DateTimePicker()
        lblDateChemical = New Label()
        dgvChemical = New DataGridView()
        flpChemicalItems = New FlowLayoutPanel()
        btnAddChemicalItem = New Button()
        lblChemLiquids = New Label()
        numChemLiquids = New NumericUpDown()
        lblChemPacking = New Label()
        numChemPacking = New NumericUpDown()
        lblChemFabric = New Label()
        numChemFabric = New NumericUpDown()
        grpFilters = New GroupBox()
        lblTo = New Label()
        lblFrom = New Label()
        dtpTo = New DateTimePicker()
        dtpFrom = New DateTimePicker()
        grpDailyTotal = New GroupBox()
        lblDailyTotalLabel = New Label()
        lblDailyTotalAmount = New Label()
        ofdDocuments = New OpenFileDialog()
        btnHome = New Button()
        Button1 = New Button()
        tabWasteCategories.SuspendLayout()
        tpNonRecycled.SuspendLayout()
        grpNonRecycledActions.SuspendLayout()
        CType(dgvNonRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpRecycled.SuspendLayout()
        grpRecycledActions.SuspendLayout()
        CType(dgvRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecPaper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpOtherRecycled.SuspendLayout()
        grpOtherRecycledActions.SuspendLayout()
        CType(dgvOtherRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numOrgFood, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCopper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).BeginInit()
        CType(numGlass, ComponentModel.ISupportInitialize).BeginInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).BeginInit()
        tpChemical.SuspendLayout()
        grpChemicalActions.SuspendLayout()
        CType(dgvChemical, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).BeginInit()
        grpFilters.SuspendLayout()
        grpDailyTotal.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabWasteCategories
        ' 
        tabWasteCategories.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabWasteCategories.Controls.Add(tpNonRecycled)
        tabWasteCategories.Controls.Add(tpRecycled)
        tabWasteCategories.Controls.Add(tpOtherRecycled)
        tabWasteCategories.Controls.Add(tpChemical)
        tabWasteCategories.Location = New Point(12, 12)
        tabWasteCategories.Name = "tabWasteCategories"
        tabWasteCategories.SelectedIndex = 0
        tabWasteCategories.Size = New Size(750, 511)
        tabWasteCategories.TabIndex = 0
        ' 
        ' tpNonRecycled
        ' 
        tpNonRecycled.Controls.Add(grpNonRecycledActions)
        tpNonRecycled.Controls.Add(dgvNonRecycled)
        tpNonRecycled.Controls.Add(flpNonRecycledItems)
        tpNonRecycled.Controls.Add(btnAddNonRecycledItem)
        tpNonRecycled.Controls.Add(lblNonPolyethene)
        tpNonRecycled.Controls.Add(numNonPolyethene)
        tpNonRecycled.Controls.Add(lblNonPlastic)
        tpNonRecycled.Controls.Add(numNonPlastic)
        tpNonRecycled.Location = New Point(4, 24)
        tpNonRecycled.Name = "tpNonRecycled"
        tpNonRecycled.Padding = New Padding(3)
        tpNonRecycled.Size = New Size(742, 483)
        tpNonRecycled.TabIndex = 0
        tpNonRecycled.Text = "Non-Recycled Waste"
        tpNonRecycled.UseVisualStyleBackColor = True
        ' 
        ' grpNonRecycledActions
        ' 
        grpNonRecycledActions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpNonRecycledActions.Controls.Add(btnFilterNonRecycled)
        grpNonRecycledActions.Controls.Add(btnExportNonRecycled)
        grpNonRecycledActions.Controls.Add(btnRefreshNonRecycled)
        grpNonRecycledActions.Controls.Add(btnDeleteNonRecycled)
        grpNonRecycledActions.Controls.Add(btnUpdateNonRecycled)
        grpNonRecycledActions.Controls.Add(btnSaveNonRecycled)
        grpNonRecycledActions.Controls.Add(btnViewLicenseNonRecycled)
        grpNonRecycledActions.Controls.Add(btnUploadNonRecycled)
        grpNonRecycledActions.Controls.Add(lblCollectorNonRecycled)
        grpNonRecycledActions.Controls.Add(cmbCollectorNonRecycled)
        grpNonRecycledActions.Controls.Add(dtpRecordDateNonRecycled)
        grpNonRecycledActions.Controls.Add(lblDateNonRecycled)
        grpNonRecycledActions.Location = New Point(6, 6)
        grpNonRecycledActions.Name = "grpNonRecycledActions"
        grpNonRecycledActions.Size = New Size(728, 106)
        grpNonRecycledActions.TabIndex = 12
        grpNonRecycledActions.TabStop = False
        grpNonRecycledActions.Text = "Record Information"
        ' 
        ' btnFilterNonRecycled
        ' 
        btnFilterNonRecycled.BackColor = SystemColors.Control
        btnFilterNonRecycled.Location = New Point(528, 20)
        btnFilterNonRecycled.Name = "btnFilterNonRecycled"
        btnFilterNonRecycled.Size = New Size(90, 23)
        btnFilterNonRecycled.TabIndex = 15
        btnFilterNonRecycled.Tag = "Non-Recycled"
        btnFilterNonRecycled.Text = "Apply Filter"
        btnFilterNonRecycled.UseVisualStyleBackColor = False
        btnFilterNonRecycled.Visible = False
        ' 
        ' btnExportNonRecycled
        ' 
        btnExportNonRecycled.BackColor = SystemColors.Control
        btnExportNonRecycled.Location = New Point(528, 49)
        btnExportNonRecycled.Name = "btnExportNonRecycled"
        btnExportNonRecycled.Size = New Size(90, 23)
        btnExportNonRecycled.TabIndex = 14
        btnExportNonRecycled.Tag = "Non-Recycled"
        btnExportNonRecycled.Text = "Export Excel"
        btnExportNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshNonRecycled
        ' 
        btnRefreshNonRecycled.BackColor = SystemColors.Control
        btnRefreshNonRecycled.Location = New Point(432, 49)
        btnRefreshNonRecycled.Name = "btnRefreshNonRecycled"
        btnRefreshNonRecycled.Size = New Size(90, 23)
        btnRefreshNonRecycled.TabIndex = 13
        btnRefreshNonRecycled.Tag = "Non-Recycled"
        btnRefreshNonRecycled.Text = "Refresh"
        btnRefreshNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteNonRecycled
        ' 
        btnDeleteNonRecycled.BackColor = SystemColors.Control
        btnDeleteNonRecycled.Location = New Point(624, 48)
        btnDeleteNonRecycled.Name = "btnDeleteNonRecycled"
        btnDeleteNonRecycled.Size = New Size(90, 23)
        btnDeleteNonRecycled.TabIndex = 12
        btnDeleteNonRecycled.Tag = "Non-Recycled"
        btnDeleteNonRecycled.Text = "Delete"
        btnDeleteNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateNonRecycled
        ' 
        btnUpdateNonRecycled.BackColor = SystemColors.Control
        btnUpdateNonRecycled.Location = New Point(171, 20)
        btnUpdateNonRecycled.Name = "btnUpdateNonRecycled"
        btnUpdateNonRecycled.Size = New Size(90, 23)
        btnUpdateNonRecycled.TabIndex = 11
        btnUpdateNonRecycled.Tag = "Non-Recycled"
        btnUpdateNonRecycled.Text = "Update"
        btnUpdateNonRecycled.UseVisualStyleBackColor = False
        btnUpdateNonRecycled.Visible = False
        ' 
        ' btnSaveNonRecycled
        ' 
        btnSaveNonRecycled.BackColor = SystemColors.Control
        btnSaveNonRecycled.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnSaveNonRecycled.Location = New Point(336, 49)
        btnSaveNonRecycled.Name = "btnSaveNonRecycled"
        btnSaveNonRecycled.Size = New Size(90, 23)
        btnSaveNonRecycled.TabIndex = 10
        btnSaveNonRecycled.Tag = "Non-Recycled"
        btnSaveNonRecycled.Text = "Save"
        btnSaveNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnViewLicenseNonRecycled
        ' 
        btnViewLicenseNonRecycled.BackColor = SystemColors.Control
        btnViewLicenseNonRecycled.Location = New Point(171, 49)
        btnViewLicenseNonRecycled.Name = "btnViewLicenseNonRecycled"
        btnViewLicenseNonRecycled.Size = New Size(90, 23)
        btnViewLicenseNonRecycled.TabIndex = 9
        btnViewLicenseNonRecycled.Tag = "Non-Recycled"
        btnViewLicenseNonRecycled.Text = "View License"
        btnViewLicenseNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUploadNonRecycled
        ' 
        btnUploadNonRecycled.BackColor = SystemColors.Control
        btnUploadNonRecycled.Location = New Point(624, 20)
        btnUploadNonRecycled.Name = "btnUploadNonRecycled"
        btnUploadNonRecycled.Size = New Size(90, 23)
        btnUploadNonRecycled.TabIndex = 8
        btnUploadNonRecycled.Tag = "Non-Recycled"
        btnUploadNonRecycled.Text = "Upload Docs"
        btnUploadNonRecycled.UseVisualStyleBackColor = False
        ' 
        ' lblCollectorNonRecycled
        ' 
        lblCollectorNonRecycled.AutoSize = True
        lblCollectorNonRecycled.Location = New Point(6, 52)
        lblCollectorNonRecycled.Name = "lblCollectorNonRecycled"
        lblCollectorNonRecycled.Size = New Size(58, 15)
        lblCollectorNonRecycled.TabIndex = 6
        lblCollectorNonRecycled.Text = "Collector:"
        ' 
        ' cmbCollectorNonRecycled
        ' 
        cmbCollectorNonRecycled.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollectorNonRecycled.FormattingEnabled = True
        cmbCollectorNonRecycled.Location = New Point(65, 49)
        cmbCollectorNonRecycled.Name = "cmbCollectorNonRecycled"
        cmbCollectorNonRecycled.Size = New Size(100, 23)
        cmbCollectorNonRecycled.TabIndex = 7
        ' 
        ' dtpRecordDateNonRecycled
        ' 
        dtpRecordDateNonRecycled.Format = DateTimePickerFormat.Short
        dtpRecordDateNonRecycled.Location = New Point(65, 19)
        dtpRecordDateNonRecycled.Name = "dtpRecordDateNonRecycled"
        dtpRecordDateNonRecycled.Size = New Size(100, 23)
        dtpRecordDateNonRecycled.TabIndex = 3
        ' 
        ' lblDateNonRecycled
        ' 
        lblDateNonRecycled.AutoSize = True
        lblDateNonRecycled.Location = New Point(6, 24)
        lblDateNonRecycled.Name = "lblDateNonRecycled"
        lblDateNonRecycled.Size = New Size(34, 15)
        lblDateNonRecycled.TabIndex = 2
        lblDateNonRecycled.Text = "Date:"
        ' 
        ' dgvNonRecycled
        ' 
        dgvNonRecycled.AllowUserToAddRows = False
        dgvNonRecycled.AllowUserToDeleteRows = False
        dgvNonRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvNonRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNonRecycled.Location = New Point(6, 193)
        dgvNonRecycled.Name = "dgvNonRecycled"
        dgvNonRecycled.ReadOnly = True
        dgvNonRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNonRecycled.Size = New Size(728, 284)
        dgvNonRecycled.TabIndex = 11
        ' 
        ' flpNonRecycledItems
        ' 
        flpNonRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpNonRecycledItems.AutoScroll = True
        flpNonRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpNonRecycledItems.Location = New Point(383, 127)
        flpNonRecycledItems.Name = "flpNonRecycledItems"
        flpNonRecycledItems.Size = New Size(199, 54)
        flpNonRecycledItems.TabIndex = 10
        flpNonRecycledItems.Visible = False
        ' 
        ' btnAddNonRecycledItem
        ' 
        btnAddNonRecycledItem.BackColor = SystemColors.Control
        btnAddNonRecycledItem.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnAddNonRecycledItem.Location = New Point(600, 130)
        btnAddNonRecycledItem.Name = "btnAddNonRecycledItem"
        btnAddNonRecycledItem.Size = New Size(120, 23)
        btnAddNonRecycledItem.TabIndex = 9
        btnAddNonRecycledItem.Tag = "Non-Recycled"
        btnAddNonRecycledItem.Text = "+ Add New Item"
        btnAddNonRecycledItem.UseVisualStyleBackColor = False
        btnAddNonRecycledItem.Visible = False
        ' 
        ' lblNonPolyethene
        ' 
        lblNonPolyethene.AutoSize = True
        lblNonPolyethene.Font = New Font("Microsoft Sans Serif", 9F)
        lblNonPolyethene.Location = New Point(6, 115)
        lblNonPolyethene.Name = "lblNonPolyethene"
        lblNonPolyethene.Size = New Size(71, 15)
        lblNonPolyethene.TabIndex = 0
        lblNonPolyethene.Text = "Polyethene:"
        ' 
        ' numNonPolyethene
        ' 
        numNonPolyethene.DecimalPlaces = 2
        numNonPolyethene.Location = New Point(100, 114)
        numNonPolyethene.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPolyethene.Name = "numNonPolyethene"
        numNonPolyethene.Size = New Size(120, 23)
        numNonPolyethene.TabIndex = 1
        ' 
        ' lblNonPlastic
        ' 
        lblNonPlastic.AutoSize = True
        lblNonPlastic.Font = New Font("Microsoft Sans Serif", 9F)
        lblNonPlastic.Location = New Point(6, 143)
        lblNonPlastic.Name = "lblNonPlastic"
        lblNonPlastic.Size = New Size(46, 15)
        lblNonPlastic.TabIndex = 2
        lblNonPlastic.Text = "Plastic:"
        ' 
        ' numNonPlastic
        ' 
        numNonPlastic.DecimalPlaces = 2
        numNonPlastic.Location = New Point(100, 143)
        numNonPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPlastic.Name = "numNonPlastic"
        numNonPlastic.Size = New Size(120, 23)
        numNonPlastic.TabIndex = 3
        ' 
        ' tpRecycled
        ' 
        tpRecycled.Controls.Add(grpRecycledActions)
        tpRecycled.Controls.Add(dgvRecycled)
        tpRecycled.Controls.Add(flpRecycledItems)
        tpRecycled.Controls.Add(btnAddRecycledItem)
        tpRecycled.Controls.Add(lblRecPaper)
        tpRecycled.Controls.Add(numRecPaper)
        tpRecycled.Controls.Add(lblRecCardboard)
        tpRecycled.Controls.Add(numRecCardboard)
        tpRecycled.Controls.Add(lblRecPlastic)
        tpRecycled.Controls.Add(numRecPlastic)
        tpRecycled.Controls.Add(lblRecOtherPlastic)
        tpRecycled.Controls.Add(numRecOtherPlastic)
        tpRecycled.Location = New Point(4, 24)
        tpRecycled.Name = "tpRecycled"
        tpRecycled.Padding = New Padding(3)
        tpRecycled.Size = New Size(742, 483)
        tpRecycled.TabIndex = 1
        tpRecycled.Text = "Recycled Waste"
        tpRecycled.UseVisualStyleBackColor = True
        ' 
        ' grpRecycledActions
        ' 
        grpRecycledActions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpRecycledActions.Controls.Add(btnFilterRecycled)
        grpRecycledActions.Controls.Add(btnExportRecycled)
        grpRecycledActions.Controls.Add(btnRefreshRecycled)
        grpRecycledActions.Controls.Add(btnDeleteRecycled)
        grpRecycledActions.Controls.Add(btnUpdateRecycled)
        grpRecycledActions.Controls.Add(btnSaveRecycled)
        grpRecycledActions.Controls.Add(btnViewLicenseRecycled)
        grpRecycledActions.Controls.Add(btnUploadRecycled)
        grpRecycledActions.Controls.Add(lblCollectorRecycled)
        grpRecycledActions.Controls.Add(cmbCollectorRecycled)
        grpRecycledActions.Controls.Add(dtpRecordDateRecycled)
        grpRecycledActions.Controls.Add(lblDateRecycled)
        grpRecycledActions.Location = New Point(6, 6)
        grpRecycledActions.Name = "grpRecycledActions"
        grpRecycledActions.Size = New Size(728, 100)
        grpRecycledActions.TabIndex = 14
        grpRecycledActions.TabStop = False
        grpRecycledActions.Text = "Record Information"
        ' 
        ' btnFilterRecycled
        ' 
        btnFilterRecycled.BackColor = SystemColors.Control
        btnFilterRecycled.Location = New Point(365, 19)
        btnFilterRecycled.Name = "btnFilterRecycled"
        btnFilterRecycled.Size = New Size(90, 23)
        btnFilterRecycled.TabIndex = 15
        btnFilterRecycled.Tag = "Recycled"
        btnFilterRecycled.Text = "Apply Filter"
        btnFilterRecycled.UseVisualStyleBackColor = False
        btnFilterRecycled.Visible = False
        ' 
        ' btnExportRecycled
        ' 
        btnExportRecycled.BackColor = SystemColors.Control
        btnExportRecycled.Location = New Point(528, 49)
        btnExportRecycled.Name = "btnExportRecycled"
        btnExportRecycled.Size = New Size(90, 23)
        btnExportRecycled.TabIndex = 14
        btnExportRecycled.Tag = "Recycled"
        btnExportRecycled.Text = "Export Excel"
        btnExportRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshRecycled
        ' 
        btnRefreshRecycled.BackColor = SystemColors.Control
        btnRefreshRecycled.Location = New Point(432, 49)
        btnRefreshRecycled.Name = "btnRefreshRecycled"
        btnRefreshRecycled.Size = New Size(90, 23)
        btnRefreshRecycled.TabIndex = 13
        btnRefreshRecycled.Tag = "Recycled"
        btnRefreshRecycled.Text = "Refresh"
        btnRefreshRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRecycled
        ' 
        btnDeleteRecycled.BackColor = SystemColors.Control
        btnDeleteRecycled.Location = New Point(632, 49)
        btnDeleteRecycled.Name = "btnDeleteRecycled"
        btnDeleteRecycled.Size = New Size(90, 23)
        btnDeleteRecycled.TabIndex = 12
        btnDeleteRecycled.Tag = "Recycled"
        btnDeleteRecycled.Text = "Delete"
        btnDeleteRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRecycled
        ' 
        btnUpdateRecycled.BackColor = SystemColors.Control
        btnUpdateRecycled.Location = New Point(171, 19)
        btnUpdateRecycled.Name = "btnUpdateRecycled"
        btnUpdateRecycled.Size = New Size(90, 23)
        btnUpdateRecycled.TabIndex = 11
        btnUpdateRecycled.Tag = "Recycled"
        btnUpdateRecycled.Text = "Update"
        btnUpdateRecycled.UseVisualStyleBackColor = False
        btnUpdateRecycled.Visible = False
        ' 
        ' btnSaveRecycled
        ' 
        btnSaveRecycled.BackColor = SystemColors.Control
        btnSaveRecycled.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnSaveRecycled.Location = New Point(336, 49)
        btnSaveRecycled.Name = "btnSaveRecycled"
        btnSaveRecycled.Size = New Size(90, 23)
        btnSaveRecycled.TabIndex = 10
        btnSaveRecycled.Tag = "Recycled"
        btnSaveRecycled.Text = "Save"
        btnSaveRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnViewLicenseRecycled
        ' 
        btnViewLicenseRecycled.BackColor = SystemColors.Control
        btnViewLicenseRecycled.Location = New Point(171, 49)
        btnViewLicenseRecycled.Name = "btnViewLicenseRecycled"
        btnViewLicenseRecycled.Size = New Size(90, 23)
        btnViewLicenseRecycled.TabIndex = 9
        btnViewLicenseRecycled.Tag = "Recycled"
        btnViewLicenseRecycled.Text = "View License"
        btnViewLicenseRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUploadRecycled
        ' 
        btnUploadRecycled.BackColor = SystemColors.Control
        btnUploadRecycled.Location = New Point(632, 22)
        btnUploadRecycled.Name = "btnUploadRecycled"
        btnUploadRecycled.Size = New Size(90, 23)
        btnUploadRecycled.TabIndex = 8
        btnUploadRecycled.Tag = "Recycled"
        btnUploadRecycled.Text = "Upload Docs"
        btnUploadRecycled.UseVisualStyleBackColor = False
        ' 
        ' lblCollectorRecycled
        ' 
        lblCollectorRecycled.AutoSize = True
        lblCollectorRecycled.Location = New Point(6, 52)
        lblCollectorRecycled.Name = "lblCollectorRecycled"
        lblCollectorRecycled.Size = New Size(58, 15)
        lblCollectorRecycled.TabIndex = 6
        lblCollectorRecycled.Text = "Collector:"
        ' 
        ' cmbCollectorRecycled
        ' 
        cmbCollectorRecycled.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollectorRecycled.FormattingEnabled = True
        cmbCollectorRecycled.Location = New Point(65, 49)
        cmbCollectorRecycled.Name = "cmbCollectorRecycled"
        cmbCollectorRecycled.Size = New Size(100, 23)
        cmbCollectorRecycled.TabIndex = 7
        ' 
        ' dtpRecordDateRecycled
        ' 
        dtpRecordDateRecycled.Format = DateTimePickerFormat.Short
        dtpRecordDateRecycled.Location = New Point(65, 19)
        dtpRecordDateRecycled.Name = "dtpRecordDateRecycled"
        dtpRecordDateRecycled.Size = New Size(100, 23)
        dtpRecordDateRecycled.TabIndex = 3
        ' 
        ' lblDateRecycled
        ' 
        lblDateRecycled.AutoSize = True
        lblDateRecycled.Location = New Point(6, 24)
        lblDateRecycled.Name = "lblDateRecycled"
        lblDateRecycled.Size = New Size(34, 15)
        lblDateRecycled.TabIndex = 2
        lblDateRecycled.Text = "Date:"
        ' 
        ' dgvRecycled
        ' 
        dgvRecycled.AllowUserToAddRows = False
        dgvRecycled.AllowUserToDeleteRows = False
        dgvRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecycled.Location = New Point(7, 247)
        dgvRecycled.Name = "dgvRecycled"
        dgvRecycled.ReadOnly = True
        dgvRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecycled.Size = New Size(728, 233)
        dgvRecycled.TabIndex = 13
        ' 
        ' flpRecycledItems
        ' 
        flpRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpRecycledItems.AutoScroll = True
        flpRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpRecycledItems.Location = New Point(416, 112)
        flpRecycledItems.Name = "flpRecycledItems"
        flpRecycledItems.Size = New Size(267, 100)
        flpRecycledItems.TabIndex = 12
        flpRecycledItems.Visible = False
        ' 
        ' btnAddRecycledItem
        ' 
        btnAddRecycledItem.BackColor = SystemColors.Control
        btnAddRecycledItem.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnAddRecycledItem.Location = New Point(534, 218)
        btnAddRecycledItem.Name = "btnAddRecycledItem"
        btnAddRecycledItem.Size = New Size(120, 23)
        btnAddRecycledItem.TabIndex = 11
        btnAddRecycledItem.Tag = "Recycled"
        btnAddRecycledItem.Text = "+ Add New Item"
        btnAddRecycledItem.UseVisualStyleBackColor = False
        btnAddRecycledItem.Visible = False
        ' 
        ' lblRecPaper
        ' 
        lblRecPaper.AutoSize = True
        lblRecPaper.Font = New Font("Microsoft Sans Serif", 9F)
        lblRecPaper.Location = New Point(7, 115)
        lblRecPaper.Name = "lblRecPaper"
        lblRecPaper.Size = New Size(43, 15)
        lblRecPaper.TabIndex = 0
        lblRecPaper.Text = "Paper:"
        ' 
        ' numRecPaper
        ' 
        numRecPaper.DecimalPlaces = 2
        numRecPaper.Location = New Point(120, 114)
        numRecPaper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPaper.Name = "numRecPaper"
        numRecPaper.Size = New Size(100, 23)
        numRecPaper.TabIndex = 1
        ' 
        ' lblRecCardboard
        ' 
        lblRecCardboard.AutoSize = True
        lblRecCardboard.Font = New Font("Microsoft Sans Serif", 9F)
        lblRecCardboard.Location = New Point(7, 145)
        lblRecCardboard.Name = "lblRecCardboard"
        lblRecCardboard.Size = New Size(68, 15)
        lblRecCardboard.TabIndex = 2
        lblRecCardboard.Text = "Cardboard:"
        ' 
        ' numRecCardboard
        ' 
        numRecCardboard.DecimalPlaces = 2
        numRecCardboard.Location = New Point(120, 143)
        numRecCardboard.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecCardboard.Name = "numRecCardboard"
        numRecCardboard.Size = New Size(100, 23)
        numRecCardboard.TabIndex = 3
        ' 
        ' lblRecPlastic
        ' 
        lblRecPlastic.AutoSize = True
        lblRecPlastic.Font = New Font("Microsoft Sans Serif", 9F)
        lblRecPlastic.Location = New Point(7, 173)
        lblRecPlastic.Name = "lblRecPlastic"
        lblRecPlastic.Size = New Size(46, 15)
        lblRecPlastic.TabIndex = 4
        lblRecPlastic.Text = "Plastic:"
        ' 
        ' numRecPlastic
        ' 
        numRecPlastic.DecimalPlaces = 2
        numRecPlastic.Location = New Point(120, 172)
        numRecPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPlastic.Name = "numRecPlastic"
        numRecPlastic.Size = New Size(100, 23)
        numRecPlastic.TabIndex = 5
        ' 
        ' lblRecOtherPlastic
        ' 
        lblRecOtherPlastic.AutoSize = True
        lblRecOtherPlastic.Font = New Font("Microsoft Sans Serif", 9F)
        lblRecOtherPlastic.Location = New Point(6, 202)
        lblRecOtherPlastic.Name = "lblRecOtherPlastic"
        lblRecOtherPlastic.Size = New Size(79, 15)
        lblRecOtherPlastic.TabIndex = 6
        lblRecOtherPlastic.Text = "Other Plastic:"
        ' 
        ' numRecOtherPlastic
        ' 
        numRecOtherPlastic.DecimalPlaces = 2
        numRecOtherPlastic.Location = New Point(120, 201)
        numRecOtherPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecOtherPlastic.Name = "numRecOtherPlastic"
        numRecOtherPlastic.Size = New Size(100, 23)
        numRecOtherPlastic.TabIndex = 7
        ' 
        ' tpOtherRecycled
        ' 
        tpOtherRecycled.Controls.Add(grpOtherRecycledActions)
        tpOtherRecycled.Controls.Add(dgvOtherRecycled)
        tpOtherRecycled.Controls.Add(flpOtherRecycledItems)
        tpOtherRecycled.Controls.Add(btnAddOtherRecycledItem)
        tpOtherRecycled.Controls.Add(lblOrgFood)
        tpOtherRecycled.Controls.Add(numOrgFood)
        tpOtherRecycled.Controls.Add(chkCompost)
        tpOtherRecycled.Controls.Add(chkAnimalFeed)
        tpOtherRecycled.Controls.Add(lblCopper)
        tpOtherRecycled.Controls.Add(numCopper)
        tpOtherRecycled.Controls.Add(lblAluminium)
        tpOtherRecycled.Controls.Add(numAluminium)
        tpOtherRecycled.Controls.Add(lblGlass)
        tpOtherRecycled.Controls.Add(numGlass)
        tpOtherRecycled.Controls.Add(lblEWaste)
        tpOtherRecycled.Controls.Add(numEWaste)
        tpOtherRecycled.Location = New Point(4, 24)
        tpOtherRecycled.Name = "tpOtherRecycled"
        tpOtherRecycled.Size = New Size(742, 483)
        tpOtherRecycled.TabIndex = 2
        tpOtherRecycled.Text = "Other Recycled Waste"
        tpOtherRecycled.UseVisualStyleBackColor = True
        ' 
        ' grpOtherRecycledActions
        ' 
        grpOtherRecycledActions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpOtherRecycledActions.Controls.Add(btnFilterOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnExportOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnRefreshOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnDeleteOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnUpdateOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnSaveOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnViewLicenseOtherRecycled)
        grpOtherRecycledActions.Controls.Add(btnUploadOtherRecycled)
        grpOtherRecycledActions.Controls.Add(lblCollectorOtherRecycled)
        grpOtherRecycledActions.Controls.Add(cmbCollectorOtherRecycled)
        grpOtherRecycledActions.Controls.Add(dtpRecordDateOtherRecycled)
        grpOtherRecycledActions.Controls.Add(lblDateOtherRecycled)
        grpOtherRecycledActions.Location = New Point(3, 3)
        grpOtherRecycledActions.Name = "grpOtherRecycledActions"
        grpOtherRecycledActions.Size = New Size(736, 100)
        grpOtherRecycledActions.TabIndex = 16
        grpOtherRecycledActions.TabStop = False
        grpOtherRecycledActions.Text = "Record Information"
        ' 
        ' btnFilterOtherRecycled
        ' 
        btnFilterOtherRecycled.BackColor = SystemColors.Control
        btnFilterOtherRecycled.Location = New Point(528, 21)
        btnFilterOtherRecycled.Name = "btnFilterOtherRecycled"
        btnFilterOtherRecycled.Size = New Size(90, 23)
        btnFilterOtherRecycled.TabIndex = 15
        btnFilterOtherRecycled.Tag = "Other Recycled"
        btnFilterOtherRecycled.Text = "Apply Filter"
        btnFilterOtherRecycled.UseVisualStyleBackColor = False
        btnFilterOtherRecycled.Visible = False
        ' 
        ' btnExportOtherRecycled
        ' 
        btnExportOtherRecycled.BackColor = SystemColors.Control
        btnExportOtherRecycled.Location = New Point(528, 49)
        btnExportOtherRecycled.Name = "btnExportOtherRecycled"
        btnExportOtherRecycled.Size = New Size(90, 23)
        btnExportOtherRecycled.TabIndex = 14
        btnExportOtherRecycled.Tag = "Other Recycled"
        btnExportOtherRecycled.Text = "Export Excel"
        btnExportOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshOtherRecycled
        ' 
        btnRefreshOtherRecycled.BackColor = SystemColors.Control
        btnRefreshOtherRecycled.Location = New Point(432, 49)
        btnRefreshOtherRecycled.Name = "btnRefreshOtherRecycled"
        btnRefreshOtherRecycled.Size = New Size(90, 23)
        btnRefreshOtherRecycled.TabIndex = 13
        btnRefreshOtherRecycled.Tag = "Other Recycled"
        btnRefreshOtherRecycled.Text = "Refresh"
        btnRefreshOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteOtherRecycled
        ' 
        btnDeleteOtherRecycled.BackColor = SystemColors.Control
        btnDeleteOtherRecycled.Location = New Point(624, 49)
        btnDeleteOtherRecycled.Name = "btnDeleteOtherRecycled"
        btnDeleteOtherRecycled.Size = New Size(90, 23)
        btnDeleteOtherRecycled.TabIndex = 12
        btnDeleteOtherRecycled.Tag = "Other Recycled"
        btnDeleteOtherRecycled.Text = "Delete"
        btnDeleteOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateOtherRecycled
        ' 
        btnUpdateOtherRecycled.BackColor = SystemColors.Control
        btnUpdateOtherRecycled.Location = New Point(199, 13)
        btnUpdateOtherRecycled.Name = "btnUpdateOtherRecycled"
        btnUpdateOtherRecycled.Size = New Size(90, 23)
        btnUpdateOtherRecycled.TabIndex = 11
        btnUpdateOtherRecycled.Tag = "Other Recycled"
        btnUpdateOtherRecycled.Text = "Update"
        btnUpdateOtherRecycled.UseVisualStyleBackColor = False
        btnUpdateOtherRecycled.Visible = False
        ' 
        ' btnSaveOtherRecycled
        ' 
        btnSaveOtherRecycled.BackColor = SystemColors.Control
        btnSaveOtherRecycled.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnSaveOtherRecycled.Location = New Point(336, 49)
        btnSaveOtherRecycled.Name = "btnSaveOtherRecycled"
        btnSaveOtherRecycled.Size = New Size(90, 23)
        btnSaveOtherRecycled.TabIndex = 10
        btnSaveOtherRecycled.Tag = "Other Recycled"
        btnSaveOtherRecycled.Text = "Save"
        btnSaveOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnViewLicenseOtherRecycled
        ' 
        btnViewLicenseOtherRecycled.BackColor = SystemColors.Control
        btnViewLicenseOtherRecycled.Location = New Point(171, 48)
        btnViewLicenseOtherRecycled.Name = "btnViewLicenseOtherRecycled"
        btnViewLicenseOtherRecycled.Size = New Size(90, 23)
        btnViewLicenseOtherRecycled.TabIndex = 9
        btnViewLicenseOtherRecycled.Tag = "Other Recycled"
        btnViewLicenseOtherRecycled.Text = "View License"
        btnViewLicenseOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' btnUploadOtherRecycled
        ' 
        btnUploadOtherRecycled.BackColor = SystemColors.Control
        btnUploadOtherRecycled.Location = New Point(624, 20)
        btnUploadOtherRecycled.Name = "btnUploadOtherRecycled"
        btnUploadOtherRecycled.Size = New Size(90, 23)
        btnUploadOtherRecycled.TabIndex = 8
        btnUploadOtherRecycled.Tag = "Other Recycled"
        btnUploadOtherRecycled.Text = "Upload Docs"
        btnUploadOtherRecycled.UseVisualStyleBackColor = False
        ' 
        ' lblCollectorOtherRecycled
        ' 
        lblCollectorOtherRecycled.AutoSize = True
        lblCollectorOtherRecycled.Location = New Point(6, 52)
        lblCollectorOtherRecycled.Name = "lblCollectorOtherRecycled"
        lblCollectorOtherRecycled.Size = New Size(58, 15)
        lblCollectorOtherRecycled.TabIndex = 6
        lblCollectorOtherRecycled.Text = "Collector:"
        ' 
        ' cmbCollectorOtherRecycled
        ' 
        cmbCollectorOtherRecycled.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollectorOtherRecycled.FormattingEnabled = True
        cmbCollectorOtherRecycled.Location = New Point(65, 49)
        cmbCollectorOtherRecycled.Name = "cmbCollectorOtherRecycled"
        cmbCollectorOtherRecycled.Size = New Size(100, 23)
        cmbCollectorOtherRecycled.TabIndex = 7
        ' 
        ' dtpRecordDateOtherRecycled
        ' 
        dtpRecordDateOtherRecycled.Format = DateTimePickerFormat.Short
        dtpRecordDateOtherRecycled.Location = New Point(65, 19)
        dtpRecordDateOtherRecycled.Name = "dtpRecordDateOtherRecycled"
        dtpRecordDateOtherRecycled.Size = New Size(100, 23)
        dtpRecordDateOtherRecycled.TabIndex = 3
        ' 
        ' lblDateOtherRecycled
        ' 
        lblDateOtherRecycled.AutoSize = True
        lblDateOtherRecycled.Location = New Point(6, 24)
        lblDateOtherRecycled.Name = "lblDateOtherRecycled"
        lblDateOtherRecycled.Size = New Size(34, 15)
        lblDateOtherRecycled.TabIndex = 2
        lblDateOtherRecycled.Text = "Date:"
        ' 
        ' dgvOtherRecycled
        ' 
        dgvOtherRecycled.AllowUserToAddRows = False
        dgvOtherRecycled.AllowUserToDeleteRows = False
        dgvOtherRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvOtherRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOtherRecycled.Location = New Point(9, 259)
        dgvOtherRecycled.Name = "dgvOtherRecycled"
        dgvOtherRecycled.ReadOnly = True
        dgvOtherRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOtherRecycled.Size = New Size(730, 221)
        dgvOtherRecycled.TabIndex = 15
        ' 
        ' flpOtherRecycledItems
        ' 
        flpOtherRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpOtherRecycledItems.AutoScroll = True
        flpOtherRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpOtherRecycledItems.Location = New Point(447, 109)
        flpOtherRecycledItems.Name = "flpOtherRecycledItems"
        flpOtherRecycledItems.Size = New Size(270, 100)
        flpOtherRecycledItems.TabIndex = 14
        flpOtherRecycledItems.Visible = False
        ' 
        ' btnAddOtherRecycledItem
        ' 
        btnAddOtherRecycledItem.BackColor = SystemColors.Control
        btnAddOtherRecycledItem.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnAddOtherRecycledItem.Location = New Point(597, 215)
        btnAddOtherRecycledItem.Name = "btnAddOtherRecycledItem"
        btnAddOtherRecycledItem.Size = New Size(120, 23)
        btnAddOtherRecycledItem.TabIndex = 13
        btnAddOtherRecycledItem.Tag = "Other Recycled"
        btnAddOtherRecycledItem.Text = "+ Add New Item"
        btnAddOtherRecycledItem.UseVisualStyleBackColor = False
        btnAddOtherRecycledItem.Visible = False
        ' 
        ' lblOrgFood
        ' 
        lblOrgFood.AutoSize = True
        lblOrgFood.Font = New Font("Microsoft Sans Serif", 9F)
        lblOrgFood.Location = New Point(6, 116)
        lblOrgFood.Name = "lblOrgFood"
        lblOrgFood.Size = New Size(90, 15)
        lblOrgFood.TabIndex = 0
        lblOrgFood.Text = "Organic Waste:"
        ' 
        ' numOrgFood
        ' 
        numOrgFood.DecimalPlaces = 2
        numOrgFood.Location = New Point(96, 114)
        numOrgFood.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numOrgFood.Name = "numOrgFood"
        numOrgFood.Size = New Size(100, 23)
        numOrgFood.TabIndex = 1
        ' 
        ' chkCompost
        ' 
        chkCompost.AutoSize = True
        chkCompost.Location = New Point(202, 116)
        chkCompost.Name = "chkCompost"
        chkCompost.Size = New Size(75, 19)
        chkCompost.TabIndex = 2
        chkCompost.Text = "Compost"
        chkCompost.UseVisualStyleBackColor = True
        ' 
        ' chkAnimalFeed
        ' 
        chkAnimalFeed.AutoSize = True
        chkAnimalFeed.Location = New Point(283, 116)
        chkAnimalFeed.Name = "chkAnimalFeed"
        chkAnimalFeed.Size = New Size(92, 19)
        chkAnimalFeed.TabIndex = 3
        chkAnimalFeed.Text = "Animal Feed"
        chkAnimalFeed.UseVisualStyleBackColor = True
        ' 
        ' lblCopper
        ' 
        lblCopper.AutoSize = True
        lblCopper.Font = New Font("Microsoft Sans Serif", 9F)
        lblCopper.Location = New Point(6, 201)
        lblCopper.Name = "lblCopper"
        lblCopper.Size = New Size(50, 15)
        lblCopper.TabIndex = 4
        lblCopper.Text = "Copper:"
        ' 
        ' numCopper
        ' 
        numCopper.DecimalPlaces = 2
        numCopper.Location = New Point(96, 200)
        numCopper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numCopper.Name = "numCopper"
        numCopper.Size = New Size(100, 23)
        numCopper.TabIndex = 5
        ' 
        ' lblAluminium
        ' 
        lblAluminium.AutoSize = True
        lblAluminium.Font = New Font("Microsoft Sans Serif", 9F)
        lblAluminium.Location = New Point(6, 231)
        lblAluminium.Name = "lblAluminium"
        lblAluminium.Size = New Size(69, 15)
        lblAluminium.TabIndex = 6
        lblAluminium.Text = "Aluminium:"
        ' 
        ' numAluminium
        ' 
        numAluminium.DecimalPlaces = 2
        numAluminium.Location = New Point(96, 230)
        numAluminium.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numAluminium.Name = "numAluminium"
        numAluminium.Size = New Size(100, 23)
        numAluminium.TabIndex = 7
        ' 
        ' lblGlass
        ' 
        lblGlass.AutoSize = True
        lblGlass.Font = New Font("Microsoft Sans Serif", 9F)
        lblGlass.Location = New Point(6, 144)
        lblGlass.Name = "lblGlass"
        lblGlass.Size = New Size(41, 15)
        lblGlass.TabIndex = 8
        lblGlass.Text = "Glass:"
        ' 
        ' numGlass
        ' 
        numGlass.DecimalPlaces = 2
        numGlass.Location = New Point(96, 143)
        numGlass.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numGlass.Name = "numGlass"
        numGlass.Size = New Size(100, 23)
        numGlass.TabIndex = 9
        ' 
        ' lblEWaste
        ' 
        lblEWaste.AutoSize = True
        lblEWaste.Font = New Font("Microsoft Sans Serif", 9F)
        lblEWaste.Location = New Point(6, 172)
        lblEWaste.Name = "lblEWaste"
        lblEWaste.Size = New Size(56, 15)
        lblEWaste.TabIndex = 10
        lblEWaste.Text = "E-Waste:"
        ' 
        ' numEWaste
        ' 
        numEWaste.DecimalPlaces = 2
        numEWaste.Location = New Point(96, 171)
        numEWaste.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numEWaste.Name = "numEWaste"
        numEWaste.Size = New Size(100, 23)
        numEWaste.TabIndex = 11
        ' 
        ' tpChemical
        ' 
        tpChemical.Controls.Add(grpChemicalActions)
        tpChemical.Controls.Add(dgvChemical)
        tpChemical.Controls.Add(flpChemicalItems)
        tpChemical.Controls.Add(btnAddChemicalItem)
        tpChemical.Controls.Add(lblChemLiquids)
        tpChemical.Controls.Add(numChemLiquids)
        tpChemical.Controls.Add(lblChemPacking)
        tpChemical.Controls.Add(numChemPacking)
        tpChemical.Controls.Add(lblChemFabric)
        tpChemical.Controls.Add(numChemFabric)
        tpChemical.Location = New Point(4, 24)
        tpChemical.Name = "tpChemical"
        tpChemical.Size = New Size(742, 483)
        tpChemical.TabIndex = 3
        tpChemical.Text = "Chemical Waste"
        tpChemical.UseVisualStyleBackColor = True
        ' 
        ' grpChemicalActions
        ' 
        grpChemicalActions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpChemicalActions.Controls.Add(btnFilterChemical)
        grpChemicalActions.Controls.Add(btnExportChemical)
        grpChemicalActions.Controls.Add(btnRefreshChemical)
        grpChemicalActions.Controls.Add(btnDeleteChemical)
        grpChemicalActions.Controls.Add(btnUpdateChemical)
        grpChemicalActions.Controls.Add(btnSaveChemical)
        grpChemicalActions.Controls.Add(btnViewLicenseChemical)
        grpChemicalActions.Controls.Add(btnUploadChemical)
        grpChemicalActions.Controls.Add(lblCollectorChemical)
        grpChemicalActions.Controls.Add(cmbCollectorChemical)
        grpChemicalActions.Controls.Add(dtpRecordDateChemical)
        grpChemicalActions.Controls.Add(lblDateChemical)
        grpChemicalActions.Location = New Point(3, 3)
        grpChemicalActions.Name = "grpChemicalActions"
        grpChemicalActions.Size = New Size(736, 105)
        grpChemicalActions.TabIndex = 16
        grpChemicalActions.TabStop = False
        grpChemicalActions.Text = "Record Information"
        ' 
        ' btnFilterChemical
        ' 
        btnFilterChemical.BackColor = SystemColors.Control
        btnFilterChemical.Location = New Point(288, 17)
        btnFilterChemical.Name = "btnFilterChemical"
        btnFilterChemical.Size = New Size(90, 23)
        btnFilterChemical.TabIndex = 15
        btnFilterChemical.Tag = "Chemical"
        btnFilterChemical.Text = "Apply Filter"
        btnFilterChemical.UseVisualStyleBackColor = False
        btnFilterChemical.Visible = False
        ' 
        ' btnExportChemical
        ' 
        btnExportChemical.BackColor = SystemColors.Control
        btnExportChemical.Location = New Point(528, 49)
        btnExportChemical.Name = "btnExportChemical"
        btnExportChemical.Size = New Size(90, 23)
        btnExportChemical.TabIndex = 14
        btnExportChemical.Tag = "Chemical"
        btnExportChemical.Text = "Export Excel"
        btnExportChemical.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshChemical
        ' 
        btnRefreshChemical.BackColor = SystemColors.Control
        btnRefreshChemical.Location = New Point(432, 49)
        btnRefreshChemical.Name = "btnRefreshChemical"
        btnRefreshChemical.Size = New Size(90, 23)
        btnRefreshChemical.TabIndex = 13
        btnRefreshChemical.Tag = "Chemical"
        btnRefreshChemical.Text = "Refresh"
        btnRefreshChemical.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteChemical
        ' 
        btnDeleteChemical.BackColor = SystemColors.Control
        btnDeleteChemical.Location = New Point(624, 49)
        btnDeleteChemical.Name = "btnDeleteChemical"
        btnDeleteChemical.Size = New Size(90, 23)
        btnDeleteChemical.TabIndex = 12
        btnDeleteChemical.Tag = "Chemical"
        btnDeleteChemical.Text = "Delete"
        btnDeleteChemical.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateChemical
        ' 
        btnUpdateChemical.BackColor = SystemColors.Control
        btnUpdateChemical.Location = New Point(192, 19)
        btnUpdateChemical.Name = "btnUpdateChemical"
        btnUpdateChemical.Size = New Size(90, 23)
        btnUpdateChemical.TabIndex = 11
        btnUpdateChemical.Tag = "Chemical"
        btnUpdateChemical.Text = "Update"
        btnUpdateChemical.UseVisualStyleBackColor = False
        btnUpdateChemical.Visible = False
        ' 
        ' btnSaveChemical
        ' 
        btnSaveChemical.BackColor = SystemColors.Control
        btnSaveChemical.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnSaveChemical.Location = New Point(336, 49)
        btnSaveChemical.Name = "btnSaveChemical"
        btnSaveChemical.Size = New Size(90, 23)
        btnSaveChemical.TabIndex = 10
        btnSaveChemical.Tag = "Chemical"
        btnSaveChemical.Text = "Save"
        btnSaveChemical.UseVisualStyleBackColor = False
        ' 
        ' btnViewLicenseChemical
        ' 
        btnViewLicenseChemical.BackColor = SystemColors.Control
        btnViewLicenseChemical.Location = New Point(171, 49)
        btnViewLicenseChemical.Name = "btnViewLicenseChemical"
        btnViewLicenseChemical.Size = New Size(90, 23)
        btnViewLicenseChemical.TabIndex = 9
        btnViewLicenseChemical.Tag = "Chemical"
        btnViewLicenseChemical.Text = "View License"
        btnViewLicenseChemical.UseVisualStyleBackColor = False
        ' 
        ' btnUploadChemical
        ' 
        btnUploadChemical.BackColor = SystemColors.Control
        btnUploadChemical.Location = New Point(624, 20)
        btnUploadChemical.Name = "btnUploadChemical"
        btnUploadChemical.Size = New Size(90, 23)
        btnUploadChemical.TabIndex = 8
        btnUploadChemical.Tag = "Chemical"
        btnUploadChemical.Text = "Upload Docs"
        btnUploadChemical.UseVisualStyleBackColor = False
        ' 
        ' lblCollectorChemical
        ' 
        lblCollectorChemical.AutoSize = True
        lblCollectorChemical.Location = New Point(6, 52)
        lblCollectorChemical.Name = "lblCollectorChemical"
        lblCollectorChemical.Size = New Size(58, 15)
        lblCollectorChemical.TabIndex = 6
        lblCollectorChemical.Text = "Collector:"
        ' 
        ' cmbCollectorChemical
        ' 
        cmbCollectorChemical.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollectorChemical.FormattingEnabled = True
        cmbCollectorChemical.Location = New Point(65, 49)
        cmbCollectorChemical.Name = "cmbCollectorChemical"
        cmbCollectorChemical.Size = New Size(100, 23)
        cmbCollectorChemical.TabIndex = 7
        ' 
        ' dtpRecordDateChemical
        ' 
        dtpRecordDateChemical.Format = DateTimePickerFormat.Short
        dtpRecordDateChemical.Location = New Point(65, 19)
        dtpRecordDateChemical.Name = "dtpRecordDateChemical"
        dtpRecordDateChemical.Size = New Size(100, 23)
        dtpRecordDateChemical.TabIndex = 3
        ' 
        ' lblDateChemical
        ' 
        lblDateChemical.AutoSize = True
        lblDateChemical.Location = New Point(6, 24)
        lblDateChemical.Name = "lblDateChemical"
        lblDateChemical.Size = New Size(34, 15)
        lblDateChemical.TabIndex = 2
        lblDateChemical.Text = "Date:"
        ' 
        ' dgvChemical
        ' 
        dgvChemical.AllowUserToAddRows = False
        dgvChemical.AllowUserToDeleteRows = False
        dgvChemical.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvChemical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChemical.Location = New Point(3, 233)
        dgvChemical.Name = "dgvChemical"
        dgvChemical.ReadOnly = True
        dgvChemical.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvChemical.Size = New Size(736, 247)
        dgvChemical.TabIndex = 15
        ' 
        ' flpChemicalItems
        ' 
        flpChemicalItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpChemicalItems.AutoScroll = True
        flpChemicalItems.BorderStyle = BorderStyle.FixedSingle
        flpChemicalItems.Location = New Point(467, 116)
        flpChemicalItems.Name = "flpChemicalItems"
        flpChemicalItems.Size = New Size(250, 100)
        flpChemicalItems.TabIndex = 14
        flpChemicalItems.Visible = False
        ' 
        ' btnAddChemicalItem
        ' 
        btnAddChemicalItem.BackColor = SystemColors.Control
        btnAddChemicalItem.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnAddChemicalItem.Location = New Point(339, 153)
        btnAddChemicalItem.Name = "btnAddChemicalItem"
        btnAddChemicalItem.Size = New Size(120, 23)
        btnAddChemicalItem.TabIndex = 13
        btnAddChemicalItem.Tag = "Chemical"
        btnAddChemicalItem.Text = "+ Add New Item"
        btnAddChemicalItem.UseVisualStyleBackColor = False
        btnAddChemicalItem.Visible = False
        ' 
        ' lblChemLiquids
        ' 
        lblChemLiquids.AutoSize = True
        lblChemLiquids.Font = New Font("Microsoft Sans Serif", 9F)
        lblChemLiquids.Location = New Point(9, 115)
        lblChemLiquids.Name = "lblChemLiquids"
        lblChemLiquids.Size = New Size(137, 15)
        lblChemLiquids.TabIndex = 0
        lblChemLiquids.Text = "Used Chemical Liquids:"
        ' 
        ' numChemLiquids
        ' 
        numChemLiquids.DecimalPlaces = 2
        numChemLiquids.Location = New Point(165, 114)
        numChemLiquids.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemLiquids.Name = "numChemLiquids"
        numChemLiquids.Size = New Size(120, 23)
        numChemLiquids.TabIndex = 1
        ' 
        ' lblChemPacking
        ' 
        lblChemPacking.AutoSize = True
        lblChemPacking.Font = New Font("Microsoft Sans Serif", 9F)
        lblChemPacking.Location = New Point(9, 153)
        lblChemPacking.Name = "lblChemPacking"
        lblChemPacking.Size = New Size(109, 15)
        lblChemPacking.TabIndex = 2
        lblChemPacking.Text = "Chemical Packing:"
        ' 
        ' numChemPacking
        ' 
        numChemPacking.DecimalPlaces = 2
        numChemPacking.Location = New Point(165, 153)
        numChemPacking.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemPacking.Name = "numChemPacking"
        numChemPacking.Size = New Size(120, 23)
        numChemPacking.TabIndex = 3
        ' 
        ' lblChemFabric
        ' 
        lblChemFabric.AutoSize = True
        lblChemFabric.Font = New Font("Microsoft Sans Serif", 9F)
        lblChemFabric.Location = New Point(9, 191)
        lblChemFabric.Name = "lblChemFabric"
        lblChemFabric.Size = New Size(99, 15)
        lblChemFabric.TabIndex = 4
        lblChemFabric.Text = "Chemical Fabric:"
        ' 
        ' numChemFabric
        ' 
        numChemFabric.DecimalPlaces = 2
        numChemFabric.Location = New Point(165, 190)
        numChemFabric.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemFabric.Name = "numChemFabric"
        numChemFabric.Size = New Size(120, 23)
        numChemFabric.TabIndex = 5
        ' 
        ' grpFilters
        ' 
        grpFilters.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        grpFilters.Controls.Add(lblTo)
        grpFilters.Controls.Add(lblFrom)
        grpFilters.Controls.Add(dtpTo)
        grpFilters.Controls.Add(dtpFrom)
        grpFilters.Location = New Point(768, 12)
        grpFilters.Name = "grpFilters"
        grpFilters.Size = New Size(200, 80)
        grpFilters.TabIndex = 3
        grpFilters.TabStop = False
        grpFilters.Text = "Date Range Filters"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Location = New Point(6, 48)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(23, 15)
        lblTo.TabIndex = 3
        lblTo.Text = "To:"
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Location = New Point(6, 22)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(38, 15)
        lblFrom.TabIndex = 2
        lblFrom.Text = "From:"
        ' 
        ' dtpTo
        ' 
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(50, 45)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(140, 23)
        dtpTo.TabIndex = 1
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Format = DateTimePickerFormat.Short
        dtpFrom.Location = New Point(50, 19)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(140, 23)
        dtpFrom.TabIndex = 0
        ' 
        ' grpDailyTotal
        ' 
        grpDailyTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        grpDailyTotal.Controls.Add(lblDailyTotalLabel)
        grpDailyTotal.Controls.Add(lblDailyTotalAmount)
        grpDailyTotal.Location = New Point(768, 98)
        grpDailyTotal.Name = "grpDailyTotal"
        grpDailyTotal.Size = New Size(200, 60)
        grpDailyTotal.TabIndex = 4
        grpDailyTotal.TabStop = False
        grpDailyTotal.Text = "Daily Total"
        ' 
        ' lblDailyTotalLabel
        ' 
        lblDailyTotalLabel.AutoSize = True
        lblDailyTotalLabel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        lblDailyTotalLabel.Location = New Point(10, 28)
        lblDailyTotalLabel.Name = "lblDailyTotalLabel"
        lblDailyTotalLabel.Size = New Size(76, 15)
        lblDailyTotalLabel.TabIndex = 0
        lblDailyTotalLabel.Text = "Total (KG):"
        ' 
        ' lblDailyTotalAmount
        ' 
        lblDailyTotalAmount.AutoSize = True
        lblDailyTotalAmount.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblDailyTotalAmount.ForeColor = Color.Green
        lblDailyTotalAmount.Location = New Point(96, 24)
        lblDailyTotalAmount.Name = "lblDailyTotalAmount"
        lblDailyTotalAmount.Size = New Size(44, 20)
        lblDailyTotalAmount.TabIndex = 1
        lblDailyTotalAmount.Text = "0.00"
        ' 
        ' ofdDocuments
        ' 
        ofdDocuments.FileName = "OpenFileDialog1"
        ofdDocuments.Multiselect = True
        ' 
        ' btnHome
        ' 
        btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), Image)
        btnHome.BackgroundImageLayout = ImageLayout.Stretch
        btnHome.Location = New Point(913, 179)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(45, 38)
        btnHome.TabIndex = 11
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(774, 183)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 30)
        Button1.TabIndex = 16
        Button1.Text = "Manage Collectors"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmWasteManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(984, 525)
        Controls.Add(Button1)
        Controls.Add(btnHome)
        Controls.Add(grpDailyTotal)
        Controls.Add(grpFilters)
        Controls.Add(tabWasteCategories)
        Name = "frmWasteManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Waste Management System"
        tabWasteCategories.ResumeLayout(False)
        tpNonRecycled.ResumeLayout(False)
        tpNonRecycled.PerformLayout()
        grpNonRecycledActions.ResumeLayout(False)
        grpNonRecycledActions.PerformLayout()
        CType(dgvNonRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).EndInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpRecycled.ResumeLayout(False)
        tpRecycled.PerformLayout()
        grpRecycledActions.ResumeLayout(False)
        grpRecycledActions.PerformLayout()
        CType(dgvRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecPaper, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpOtherRecycled.ResumeLayout(False)
        tpOtherRecycled.PerformLayout()
        grpOtherRecycledActions.ResumeLayout(False)
        grpOtherRecycledActions.PerformLayout()
        CType(dgvOtherRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numOrgFood, ComponentModel.ISupportInitialize).EndInit()
        CType(numCopper, ComponentModel.ISupportInitialize).EndInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).EndInit()
        CType(numGlass, ComponentModel.ISupportInitialize).EndInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).EndInit()
        tpChemical.ResumeLayout(False)
        tpChemical.PerformLayout()
        grpChemicalActions.ResumeLayout(False)
        grpChemicalActions.PerformLayout()
        CType(dgvChemical, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).EndInit()
        grpFilters.ResumeLayout(False)
        grpFilters.PerformLayout()
        grpDailyTotal.ResumeLayout(False)
        grpDailyTotal.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents tabWasteCategories As TabControl
    Friend WithEvents tpNonRecycled As TabPage
    Friend WithEvents tpRecycled As TabPage
    Friend WithEvents tpOtherRecycled As TabPage
    Friend WithEvents tpChemical As TabPage
    Friend WithEvents lblNonPolyethene As Label
    Friend WithEvents numNonPolyethene As NumericUpDown
    Friend WithEvents lblNonPlastic As Label
    Friend WithEvents numNonPlastic As NumericUpDown
    Friend WithEvents lblRecPaper As Label
    Friend WithEvents numRecPaper As NumericUpDown
    Friend WithEvents lblRecCardboard As Label
    Friend WithEvents numRecCardboard As NumericUpDown
    Friend WithEvents lblRecPlastic As Label
    Friend WithEvents numRecPlastic As NumericUpDown
    Friend WithEvents lblRecOtherPlastic As Label
    Friend WithEvents numRecOtherPlastic As NumericUpDown
    Friend WithEvents lblOrgFood As Label
    Friend WithEvents numOrgFood As NumericUpDown
    Friend WithEvents chkCompost As CheckBox
    Friend WithEvents chkAnimalFeed As CheckBox
    Friend WithEvents lblCopper As Label
    Friend WithEvents numCopper As NumericUpDown
    Friend WithEvents lblAluminium As Label
    Friend WithEvents numAluminium As NumericUpDown
    Friend WithEvents lblGlass As Label
    Friend WithEvents numGlass As NumericUpDown
    Friend WithEvents lblEWaste As Label
    Friend WithEvents numEWaste As NumericUpDown
    Friend WithEvents lblChemLiquids As Label
    Friend WithEvents numChemLiquids As NumericUpDown
    Friend WithEvents lblChemPacking As Label
    Friend WithEvents numChemPacking As NumericUpDown
    Friend WithEvents lblChemFabric As Label
    Friend WithEvents numChemFabric As NumericUpDown
    Friend WithEvents ofdDocuments As OpenFileDialog
    Friend WithEvents btnAddNonRecycledItem As Button
    Friend WithEvents flpNonRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddRecycledItem As Button
    Friend WithEvents flpRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddOtherRecycledItem As Button
    Friend WithEvents flpOtherRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddChemicalItem As Button
    Friend WithEvents flpChemicalItems As FlowLayoutPanel
    Friend WithEvents dgvNonRecycled As DataGridView
    Friend WithEvents dgvRecycled As DataGridView
    Friend WithEvents dgvOtherRecycled As DataGridView
    Friend WithEvents dgvChemical As DataGridView
    Friend WithEvents grpNonRecycledActions As GroupBox
    Friend WithEvents btnFilterNonRecycled As Button
    Friend WithEvents btnExportNonRecycled As Button
    Friend WithEvents btnRefreshNonRecycled As Button
    Friend WithEvents btnDeleteNonRecycled As Button
    Friend WithEvents btnUpdateNonRecycled As Button
    Friend WithEvents btnSaveNonRecycled As Button
    Friend WithEvents btnViewLicenseNonRecycled As Button
    Friend WithEvents btnUploadNonRecycled As Button
    Friend WithEvents lblCollectorNonRecycled As Label
    Friend WithEvents cmbCollectorNonRecycled As ComboBox
    Friend WithEvents dtpRecordDateNonRecycled As DateTimePicker
    Friend WithEvents lblDateNonRecycled As Label
    Friend WithEvents grpRecycledActions As GroupBox
    Friend WithEvents btnFilterRecycled As Button
    Friend WithEvents btnExportRecycled As Button
    Friend WithEvents btnRefreshRecycled As Button
    Friend WithEvents btnDeleteRecycled As Button
    Friend WithEvents btnUpdateRecycled As Button
    Friend WithEvents btnSaveRecycled As Button
    Friend WithEvents btnViewLicenseRecycled As Button
    Friend WithEvents btnUploadRecycled As Button
    Friend WithEvents lblCollectorRecycled As Label
    Friend WithEvents cmbCollectorRecycled As ComboBox
    Friend WithEvents dtpRecordDateRecycled As DateTimePicker
    Friend WithEvents lblDateRecycled As Label
    Friend WithEvents grpOtherRecycledActions As GroupBox
    Friend WithEvents btnFilterOtherRecycled As Button
    Friend WithEvents btnExportOtherRecycled As Button
    Friend WithEvents btnRefreshOtherRecycled As Button
    Friend WithEvents btnDeleteOtherRecycled As Button
    Friend WithEvents btnUpdateOtherRecycled As Button
    Friend WithEvents btnSaveOtherRecycled As Button
    Friend WithEvents btnViewLicenseOtherRecycled As Button
    Friend WithEvents btnUploadOtherRecycled As Button
    Friend WithEvents lblCollectorOtherRecycled As Label
    Friend WithEvents cmbCollectorOtherRecycled As ComboBox
    Friend WithEvents dtpRecordDateOtherRecycled As DateTimePicker
    Friend WithEvents lblDateOtherRecycled As Label
    Friend WithEvents grpChemicalActions As GroupBox
    Friend WithEvents btnFilterChemical As Button
    Friend WithEvents btnExportChemical As Button
    Friend WithEvents btnRefreshChemical As Button
    Friend WithEvents btnDeleteChemical As Button
    Friend WithEvents btnUpdateChemical As Button
    Friend WithEvents btnSaveChemical As Button
    Friend WithEvents btnViewLicenseChemical As Button
    Friend WithEvents btnUploadChemical As Button
    Friend WithEvents lblCollectorChemical As Label
    Friend WithEvents cmbCollectorChemical As ComboBox
    Friend WithEvents dtpRecordDateChemical As DateTimePicker
    Friend WithEvents lblDateChemical As Label
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents grpDailyTotal As GroupBox
    Friend WithEvents lblDailyTotalLabel As Label
    Friend WithEvents lblDailyTotalAmount As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Button1 As Button
End Class