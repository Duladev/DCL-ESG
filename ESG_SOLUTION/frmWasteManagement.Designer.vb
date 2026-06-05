<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWasteManagement
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
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tabWasteCategories = New TabControl()
        tpNonRecycled = New TabPage()
        dgvNonRecycled = New DataGridView()
        flpNonRecycledItems = New FlowLayoutPanel()
        btnAddNonRecycledItem = New Button()
        lblNonPolyethene = New Label()
        numNonPolyethene = New NumericUpDown()
        lblNonPlastic = New Label()
        numNonPlastic = New NumericUpDown()
        tpRecycled = New TabPage()
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
        dgvChemical = New DataGridView()
        flpChemicalItems = New FlowLayoutPanel()
        btnAddChemicalItem = New Button()
        lblChemLiquids = New Label()
        numChemLiquids = New NumericUpDown()
        lblChemPacking = New Label()
        numChemPacking = New NumericUpDown()
        lblChemFabric = New Label()
        numChemFabric = New NumericUpDown()
        grpCommon = New GroupBox()
        btnManageCollectors = New Button()
        lblCollector = New Label()
        cmbCollector = New ComboBox()
        btnUploadDocuments = New Button()
        btnSaveRecord = New Button()
        dtpRecordDate = New DateTimePicker()
        lblDate = New Label()
        lblDailyTotal = New Label()
        txtDailyTotal = New TextBox()
        grpDataView = New GroupBox()
        btnExportExcel = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        ofdDocuments = New OpenFileDialog()
        tabWasteCategories.SuspendLayout()
        tpNonRecycled.SuspendLayout()
        CType(dgvNonRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpRecycled.SuspendLayout()
        CType(dgvRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecPaper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpOtherRecycled.SuspendLayout()
        CType(dgvOtherRecycled, ComponentModel.ISupportInitialize).BeginInit()
        CType(numOrgFood, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCopper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).BeginInit()
        CType(numGlass, ComponentModel.ISupportInitialize).BeginInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).BeginInit()
        tpChemical.SuspendLayout()
        CType(dgvChemical, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).BeginInit()
        grpCommon.SuspendLayout()
        grpDataView.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabWasteCategories
        ' 
        tabWasteCategories.Controls.Add(tpNonRecycled)
        tabWasteCategories.Controls.Add(tpRecycled)
        tabWasteCategories.Controls.Add(tpOtherRecycled)
        tabWasteCategories.Controls.Add(tpChemical)
        tabWasteCategories.Location = New Point(12, 12)
        tabWasteCategories.Name = "tabWasteCategories"
        tabWasteCategories.SelectedIndex = 0
        tabWasteCategories.Size = New Size(600, 650)
        tabWasteCategories.TabIndex = 0
        ' 
        ' tpNonRecycled
        ' 
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
        tpNonRecycled.Size = New Size(592, 622)
        tpNonRecycled.TabIndex = 0
        tpNonRecycled.Text = "Non-Recycled Waste"
        tpNonRecycled.UseVisualStyleBackColor = True
        ' 
        ' dgvNonRecycled
        ' 
        dgvNonRecycled.AllowUserToAddRows = False
        dgvNonRecycled.AllowUserToDeleteRows = False
        dgvNonRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvNonRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNonRecycled.Location = New Point(6, 183)
        dgvNonRecycled.Name = "dgvNonRecycled"
        dgvNonRecycled.ReadOnly = True
        dgvNonRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNonRecycled.Size = New Size(580, 190)
        dgvNonRecycled.TabIndex = 11
        ' 
        ' flpNonRecycledItems
        ' 
        flpNonRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpNonRecycledItems.AutoScroll = True
        flpNonRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpNonRecycledItems.Location = New Point(6, 82)
        flpNonRecycledItems.Name = "flpNonRecycledItems"
        flpNonRecycledItems.Size = New Size(580, 95)
        flpNonRecycledItems.TabIndex = 10
        ' 
        ' btnAddNonRecycledItem
        ' 
        btnAddNonRecycledItem.BackColor = SystemColors.Control
        btnAddNonRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddNonRecycledItem.Location = New Point(343, 20)
        btnAddNonRecycledItem.Name = "btnAddNonRecycledItem"
        btnAddNonRecycledItem.Size = New Size(120, 34)
        btnAddNonRecycledItem.TabIndex = 9
        btnAddNonRecycledItem.Text = "+ Add New Item"
        btnAddNonRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblNonPolyethene
        ' 
        lblNonPolyethene.AutoSize = True
        lblNonPolyethene.Font = New Font("Microsoft Sans Serif", 10F)
        lblNonPolyethene.Location = New Point(6, 20)
        lblNonPolyethene.Name = "lblNonPolyethene"
        lblNonPolyethene.Size = New Size(83, 17)
        lblNonPolyethene.TabIndex = 0
        lblNonPolyethene.Text = "Polyethene:"
        ' 
        ' numNonPolyethene
        ' 
        numNonPolyethene.DecimalPlaces = 2
        numNonPolyethene.Location = New Point(150, 18)
        numNonPolyethene.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPolyethene.Name = "numNonPolyethene"
        numNonPolyethene.Size = New Size(120, 23)
        numNonPolyethene.TabIndex = 1
        ' 
        ' lblNonPlastic
        ' 
        lblNonPlastic.AutoSize = True
        lblNonPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblNonPlastic.Location = New Point(6, 55)
        lblNonPlastic.Name = "lblNonPlastic"
        lblNonPlastic.Size = New Size(53, 17)
        lblNonPlastic.TabIndex = 2
        lblNonPlastic.Text = "Plastic:"
        ' 
        ' numNonPlastic
        ' 
        numNonPlastic.DecimalPlaces = 2
        numNonPlastic.Location = New Point(150, 53)
        numNonPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPlastic.Name = "numNonPlastic"
        numNonPlastic.Size = New Size(120, 23)
        numNonPlastic.TabIndex = 3
        ' 
        ' tpRecycled
        ' 
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
        tpRecycled.Size = New Size(592, 622)
        tpRecycled.TabIndex = 1
        tpRecycled.Text = "Recycled Waste"
        tpRecycled.UseVisualStyleBackColor = True
        ' 
        ' dgvRecycled
        ' 
        dgvRecycled.AllowUserToAddRows = False
        dgvRecycled.AllowUserToDeleteRows = False
        dgvRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecycled.Location = New Point(6, 200)
        dgvRecycled.Name = "dgvRecycled"
        dgvRecycled.ReadOnly = True
        dgvRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecycled.Size = New Size(580, 198)
        dgvRecycled.TabIndex = 13
        ' 
        ' flpRecycledItems
        ' 
        flpRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpRecycledItems.AutoScroll = True
        flpRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpRecycledItems.Location = New Point(285, 19)
        flpRecycledItems.Name = "flpRecycledItems"
        flpRecycledItems.Size = New Size(291, 127)
        flpRecycledItems.TabIndex = 12
        ' 
        ' btnAddRecycledItem
        ' 
        btnAddRecycledItem.BackColor = SystemColors.Control
        btnAddRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddRecycledItem.Location = New Point(456, 160)
        btnAddRecycledItem.Name = "btnAddRecycledItem"
        btnAddRecycledItem.Size = New Size(120, 34)
        btnAddRecycledItem.TabIndex = 11
        btnAddRecycledItem.Text = "+ Add New Item"
        btnAddRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblRecPaper
        ' 
        lblRecPaper.AutoSize = True
        lblRecPaper.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecPaper.Location = New Point(6, 20)
        lblRecPaper.Name = "lblRecPaper"
        lblRecPaper.Size = New Size(50, 17)
        lblRecPaper.TabIndex = 0
        lblRecPaper.Text = "Paper:"
        ' 
        ' numRecPaper
        ' 
        numRecPaper.DecimalPlaces = 2
        numRecPaper.Location = New Point(150, 18)
        numRecPaper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPaper.Name = "numRecPaper"
        numRecPaper.Size = New Size(120, 23)
        numRecPaper.TabIndex = 1
        ' 
        ' lblRecCardboard
        ' 
        lblRecCardboard.AutoSize = True
        lblRecCardboard.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecCardboard.Location = New Point(6, 55)
        lblRecCardboard.Name = "lblRecCardboard"
        lblRecCardboard.Size = New Size(79, 17)
        lblRecCardboard.TabIndex = 2
        lblRecCardboard.Text = "Cardboard:"
        ' 
        ' numRecCardboard
        ' 
        numRecCardboard.DecimalPlaces = 2
        numRecCardboard.Location = New Point(150, 53)
        numRecCardboard.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecCardboard.Name = "numRecCardboard"
        numRecCardboard.Size = New Size(120, 23)
        numRecCardboard.TabIndex = 3
        ' 
        ' lblRecPlastic
        ' 
        lblRecPlastic.AutoSize = True
        lblRecPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecPlastic.Location = New Point(6, 90)
        lblRecPlastic.Name = "lblRecPlastic"
        lblRecPlastic.Size = New Size(115, 17)
        lblRecPlastic.TabIndex = 4
        lblRecPlastic.Text = "Recycled Plastic:"
        ' 
        ' numRecPlastic
        ' 
        numRecPlastic.DecimalPlaces = 2
        numRecPlastic.Location = New Point(150, 88)
        numRecPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPlastic.Name = "numRecPlastic"
        numRecPlastic.Size = New Size(120, 23)
        numRecPlastic.TabIndex = 5
        ' 
        ' lblRecOtherPlastic
        ' 
        lblRecOtherPlastic.AutoSize = True
        lblRecOtherPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecOtherPlastic.Location = New Point(6, 125)
        lblRecOtherPlastic.Name = "lblRecOtherPlastic"
        lblRecOtherPlastic.Size = New Size(93, 17)
        lblRecOtherPlastic.TabIndex = 6
        lblRecOtherPlastic.Text = "Other Plastic:"
        ' 
        ' numRecOtherPlastic
        ' 
        numRecOtherPlastic.DecimalPlaces = 2
        numRecOtherPlastic.Location = New Point(150, 123)
        numRecOtherPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecOtherPlastic.Name = "numRecOtherPlastic"
        numRecOtherPlastic.Size = New Size(120, 23)
        numRecOtherPlastic.TabIndex = 7
        ' 
        ' tpOtherRecycled
        ' 
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
        tpOtherRecycled.Size = New Size(592, 622)
        tpOtherRecycled.TabIndex = 2
        tpOtherRecycled.Text = "Other Recycled Waste"
        tpOtherRecycled.UseVisualStyleBackColor = True
        ' 
        ' dgvOtherRecycled
        ' 
        dgvOtherRecycled.AllowUserToAddRows = False
        dgvOtherRecycled.AllowUserToDeleteRows = False
        dgvOtherRecycled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOtherRecycled.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOtherRecycled.Location = New Point(3, 210)
        dgvOtherRecycled.Name = "dgvOtherRecycled"
        dgvOtherRecycled.ReadOnly = True
        dgvOtherRecycled.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOtherRecycled.Size = New Size(580, 183)
        dgvOtherRecycled.TabIndex = 15
        ' 
        ' flpOtherRecycledItems
        ' 
        flpOtherRecycledItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpOtherRecycledItems.AutoScroll = True
        flpOtherRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpOtherRecycledItems.Location = New Point(308, 53)
        flpOtherRecycledItems.Name = "flpOtherRecycledItems"
        flpOtherRecycledItems.Size = New Size(266, 111)
        flpOtherRecycledItems.TabIndex = 14
        ' 
        ' btnAddOtherRecycledItem
        ' 
        btnAddOtherRecycledItem.BackColor = SystemColors.Control
        btnAddOtherRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddOtherRecycledItem.Location = New Point(454, 170)
        btnAddOtherRecycledItem.Name = "btnAddOtherRecycledItem"
        btnAddOtherRecycledItem.Size = New Size(120, 34)
        btnAddOtherRecycledItem.TabIndex = 13
        btnAddOtherRecycledItem.Text = "+ Add New Item"
        btnAddOtherRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblOrgFood
        ' 
        lblOrgFood.AutoSize = True
        lblOrgFood.Font = New Font("Microsoft Sans Serif", 10F)
        lblOrgFood.Location = New Point(6, 20)
        lblOrgFood.Name = "lblOrgFood"
        lblOrgFood.Size = New Size(106, 17)
        lblOrgFood.TabIndex = 0
        lblOrgFood.Text = "Organic Waste:"
        ' 
        ' numOrgFood
        ' 
        numOrgFood.DecimalPlaces = 2
        numOrgFood.Location = New Point(150, 18)
        numOrgFood.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numOrgFood.Name = "numOrgFood"
        numOrgFood.Size = New Size(120, 23)
        numOrgFood.TabIndex = 1
        ' 
        ' chkCompost
        ' 
        chkCompost.AutoSize = True
        chkCompost.Location = New Point(290, 20)
        chkCompost.Name = "chkCompost"
        chkCompost.Size = New Size(75, 19)
        chkCompost.TabIndex = 2
        chkCompost.Text = "Compost"
        chkCompost.UseVisualStyleBackColor = True
        ' 
        ' chkAnimalFeed
        ' 
        chkAnimalFeed.AutoSize = True
        chkAnimalFeed.Location = New Point(380, 20)
        chkAnimalFeed.Name = "chkAnimalFeed"
        chkAnimalFeed.Size = New Size(92, 19)
        chkAnimalFeed.TabIndex = 3
        chkAnimalFeed.Text = "Animal Feed"
        chkAnimalFeed.UseVisualStyleBackColor = True
        ' 
        ' lblCopper
        ' 
        lblCopper.AutoSize = True
        lblCopper.Font = New Font("Microsoft Sans Serif", 10F)
        lblCopper.Location = New Point(6, 55)
        lblCopper.Name = "lblCopper"
        lblCopper.Size = New Size(58, 17)
        lblCopper.TabIndex = 4
        lblCopper.Text = "Copper:"
        ' 
        ' numCopper
        ' 
        numCopper.DecimalPlaces = 2
        numCopper.Location = New Point(150, 53)
        numCopper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numCopper.Name = "numCopper"
        numCopper.Size = New Size(120, 23)
        numCopper.TabIndex = 5
        ' 
        ' lblAluminium
        ' 
        lblAluminium.AutoSize = True
        lblAluminium.Font = New Font("Microsoft Sans Serif", 10F)
        lblAluminium.Location = New Point(6, 90)
        lblAluminium.Name = "lblAluminium"
        lblAluminium.Size = New Size(76, 17)
        lblAluminium.TabIndex = 6
        lblAluminium.Text = "Aluminium:"
        ' 
        ' numAluminium
        ' 
        numAluminium.DecimalPlaces = 2
        numAluminium.Location = New Point(150, 88)
        numAluminium.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numAluminium.Name = "numAluminium"
        numAluminium.Size = New Size(120, 23)
        numAluminium.TabIndex = 7
        ' 
        ' lblGlass
        ' 
        lblGlass.AutoSize = True
        lblGlass.Font = New Font("Microsoft Sans Serif", 10F)
        lblGlass.Location = New Point(6, 125)
        lblGlass.Name = "lblGlass"
        lblGlass.Size = New Size(48, 17)
        lblGlass.TabIndex = 8
        lblGlass.Text = "Glass:"
        ' 
        ' numGlass
        ' 
        numGlass.DecimalPlaces = 2
        numGlass.Location = New Point(150, 123)
        numGlass.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numGlass.Name = "numGlass"
        numGlass.Size = New Size(120, 23)
        numGlass.TabIndex = 9
        ' 
        ' lblEWaste
        ' 
        lblEWaste.AutoSize = True
        lblEWaste.Font = New Font("Microsoft Sans Serif", 10F)
        lblEWaste.Location = New Point(6, 160)
        lblEWaste.Name = "lblEWaste"
        lblEWaste.Size = New Size(97, 17)
        lblEWaste.TabIndex = 10
        lblEWaste.Text = "E-Waste (Kg):"
        ' 
        ' numEWaste
        ' 
        numEWaste.DecimalPlaces = 2
        numEWaste.Location = New Point(150, 158)
        numEWaste.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numEWaste.Name = "numEWaste"
        numEWaste.Size = New Size(120, 23)
        numEWaste.TabIndex = 11
        ' 
        ' tpChemical
        ' 
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
        tpChemical.Size = New Size(592, 622)
        tpChemical.TabIndex = 3
        tpChemical.Text = "Chemical Waste"
        tpChemical.UseVisualStyleBackColor = True
        ' 
        ' dgvChemical
        ' 
        dgvChemical.AllowUserToAddRows = False
        dgvChemical.AllowUserToDeleteRows = False
        dgvChemical.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvChemical.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvChemical.Location = New Point(3, 175)
        dgvChemical.Name = "dgvChemical"
        dgvChemical.ReadOnly = True
        dgvChemical.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvChemical.Size = New Size(580, 218)
        dgvChemical.TabIndex = 15
        ' 
        ' flpChemicalItems
        ' 
        flpChemicalItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpChemicalItems.AutoScroll = True
        flpChemicalItems.BorderStyle = BorderStyle.FixedSingle
        flpChemicalItems.Location = New Point(349, 20)
        flpChemicalItems.Name = "flpChemicalItems"
        flpChemicalItems.Size = New Size(221, 109)
        flpChemicalItems.TabIndex = 14
        ' 
        ' btnAddChemicalItem
        ' 
        btnAddChemicalItem.BackColor = SystemColors.Control
        btnAddChemicalItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddChemicalItem.Location = New Point(450, 135)
        btnAddChemicalItem.Name = "btnAddChemicalItem"
        btnAddChemicalItem.Size = New Size(120, 34)
        btnAddChemicalItem.TabIndex = 13
        btnAddChemicalItem.Text = "+ Add New Item"
        btnAddChemicalItem.UseVisualStyleBackColor = False
        ' 
        ' lblChemLiquids
        ' 
        lblChemLiquids.AutoSize = True
        lblChemLiquids.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemLiquids.Location = New Point(6, 20)
        lblChemLiquids.Name = "lblChemLiquids"
        lblChemLiquids.Size = New Size(155, 17)
        lblChemLiquids.TabIndex = 0
        lblChemLiquids.Text = "Used Chemical Liquids:"
        ' 
        ' numChemLiquids
        ' 
        numChemLiquids.DecimalPlaces = 2
        numChemLiquids.Location = New Point(170, 18)
        numChemLiquids.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemLiquids.Name = "numChemLiquids"
        numChemLiquids.Size = New Size(120, 23)
        numChemLiquids.TabIndex = 1
        ' 
        ' lblChemPacking
        ' 
        lblChemPacking.AutoSize = True
        lblChemPacking.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemPacking.Location = New Point(6, 55)
        lblChemPacking.Name = "lblChemPacking"
        lblChemPacking.Size = New Size(123, 17)
        lblChemPacking.TabIndex = 2
        lblChemPacking.Text = "Chemical Packing:"
        ' 
        ' numChemPacking
        ' 
        numChemPacking.DecimalPlaces = 2
        numChemPacking.Location = New Point(170, 53)
        numChemPacking.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemPacking.Name = "numChemPacking"
        numChemPacking.Size = New Size(120, 23)
        numChemPacking.TabIndex = 3
        ' 
        ' lblChemFabric
        ' 
        lblChemFabric.AutoSize = True
        lblChemFabric.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemFabric.Location = New Point(6, 90)
        lblChemFabric.Name = "lblChemFabric"
        lblChemFabric.Size = New Size(112, 17)
        lblChemFabric.TabIndex = 4
        lblChemFabric.Text = "Chemical Fabric:"
        ' 
        ' numChemFabric
        ' 
        numChemFabric.DecimalPlaces = 2
        numChemFabric.Location = New Point(170, 88)
        numChemFabric.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemFabric.Name = "numChemFabric"
        numChemFabric.Size = New Size(120, 23)
        numChemFabric.TabIndex = 5
        ' 
        ' grpCommon
        ' 
        grpCommon.Controls.Add(btnManageCollectors)
        grpCommon.Controls.Add(lblCollector)
        grpCommon.Controls.Add(cmbCollector)
        grpCommon.Controls.Add(btnUploadDocuments)
        grpCommon.Controls.Add(btnSaveRecord)
        grpCommon.Controls.Add(dtpRecordDate)
        grpCommon.Controls.Add(lblDate)
        grpCommon.Controls.Add(lblDailyTotal)
        grpCommon.Controls.Add(txtDailyTotal)
        grpCommon.Location = New Point(618, 12)
        grpCommon.Name = "grpCommon"
        grpCommon.Size = New Size(450, 150)
        grpCommon.TabIndex = 1
        grpCommon.TabStop = False
        grpCommon.Text = "Record Information"
        ' 
        ' btnManageCollectors
        ' 
        btnManageCollectors.BackColor = SystemColors.Control
        btnManageCollectors.Location = New Point(370, 25)
        btnManageCollectors.Name = "btnManageCollectors"
        btnManageCollectors.Size = New Size(70, 25)
        btnManageCollectors.TabIndex = 9
        btnManageCollectors.Text = "Manage"
        btnManageCollectors.UseVisualStyleBackColor = False
        ' 
        ' lblCollector
        ' 
        lblCollector.AutoSize = True
        lblCollector.Font = New Font("Microsoft Sans Serif", 10F)
        lblCollector.Location = New Point(200, 28)
        lblCollector.Name = "lblCollector"
        lblCollector.Size = New Size(67, 17)
        lblCollector.TabIndex = 6
        lblCollector.Text = "Collector:"
        ' 
        ' cmbCollector
        ' 
        cmbCollector.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollector.FormattingEnabled = True
        cmbCollector.Location = New Point(275, 26)
        cmbCollector.Name = "cmbCollector"
        cmbCollector.Size = New Size(90, 23)
        cmbCollector.TabIndex = 7
        ' 
        ' btnUploadDocuments
        ' 
        btnUploadDocuments.BackColor = Color.LightYellow
        btnUploadDocuments.Location = New Point(200, 110)
        btnUploadDocuments.Name = "btnUploadDocuments"
        btnUploadDocuments.Size = New Size(120, 25)
        btnUploadDocuments.TabIndex = 5
        btnUploadDocuments.Text = "Upload Documents"
        btnUploadDocuments.UseVisualStyleBackColor = False
        ' 
        ' btnSaveRecord
        ' 
        btnSaveRecord.BackColor = SystemColors.Control
        btnSaveRecord.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnSaveRecord.Location = New Point(360, 105)
        btnSaveRecord.Name = "btnSaveRecord"
        btnSaveRecord.Size = New Size(80, 30)
        btnSaveRecord.TabIndex = 4
        btnSaveRecord.Text = "Save"
        btnSaveRecord.UseVisualStyleBackColor = False
        ' 
        ' dtpRecordDate
        ' 
        dtpRecordDate.Format = DateTimePickerFormat.Short
        dtpRecordDate.Location = New Point(80, 26)
        dtpRecordDate.Name = "dtpRecordDate"
        dtpRecordDate.Size = New Size(110, 23)
        dtpRecordDate.TabIndex = 3
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Microsoft Sans Serif", 10F)
        lblDate.Location = New Point(10, 28)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(42, 17)
        lblDate.TabIndex = 2
        lblDate.Text = "Date:"
        ' 
        ' lblDailyTotal
        ' 
        lblDailyTotal.AutoSize = True
        lblDailyTotal.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        lblDailyTotal.Location = New Point(10, 70)
        lblDailyTotal.Name = "lblDailyTotal"
        lblDailyTotal.Size = New Size(91, 17)
        lblDailyTotal.TabIndex = 0
        lblDailyTotal.Text = "Daily Total:"
        ' 
        ' txtDailyTotal
        ' 
        txtDailyTotal.BackColor = Color.LightYellow
        txtDailyTotal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtDailyTotal.Location = New Point(110, 65)
        txtDailyTotal.Name = "txtDailyTotal"
        txtDailyTotal.ReadOnly = True
        txtDailyTotal.Size = New Size(80, 26)
        txtDailyTotal.TabIndex = 1
        txtDailyTotal.Text = "0 KG"
        ' 
        ' grpDataView
        ' 
        grpDataView.Controls.Add(btnExportExcel)
        grpDataView.Controls.Add(btnDelete)
        grpDataView.Controls.Add(btnUpdate)
        grpDataView.Location = New Point(618, 170)
        grpDataView.Name = "grpDataView"
        grpDataView.Size = New Size(450, 60)
        grpDataView.TabIndex = 2
        grpDataView.TabStop = False
        grpDataView.Text = "Actions"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.Control
        btnExportExcel.Location = New Point(340, 22)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(100, 25)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Location = New Point(120, 22)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 25)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.Control
        btnUpdate.Location = New Point(10, 22)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(100, 25)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' ofdDocuments
        ' 
        ofdDocuments.FileName = "OpenFileDialog1"
        ofdDocuments.Multiselect = True
        ' 
        ' frmWasteManagement
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 441)
        Controls.Add(grpDataView)
        Controls.Add(grpCommon)
        Controls.Add(tabWasteCategories)
        Name = "frmWasteManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Waste Management System"
        tabWasteCategories.ResumeLayout(False)
        tpNonRecycled.ResumeLayout(False)
        tpNonRecycled.PerformLayout()
        CType(dgvNonRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).EndInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpRecycled.ResumeLayout(False)
        tpRecycled.PerformLayout()
        CType(dgvRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecPaper, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpOtherRecycled.ResumeLayout(False)
        tpOtherRecycled.PerformLayout()
        CType(dgvOtherRecycled, ComponentModel.ISupportInitialize).EndInit()
        CType(numOrgFood, ComponentModel.ISupportInitialize).EndInit()
        CType(numCopper, ComponentModel.ISupportInitialize).EndInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).EndInit()
        CType(numGlass, ComponentModel.ISupportInitialize).EndInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).EndInit()
        tpChemical.ResumeLayout(False)
        tpChemical.PerformLayout()
        CType(dgvChemical, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).EndInit()
        grpCommon.ResumeLayout(False)
        grpCommon.PerformLayout()
        grpDataView.ResumeLayout(False)
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
    Friend WithEvents grpCommon As GroupBox
    Friend WithEvents lblDailyTotal As Label
    Friend WithEvents txtDailyTotal As TextBox
    Friend WithEvents dtpRecordDate As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents btnUploadDocuments As Button
    Friend WithEvents grpDataView As GroupBox
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCollector As Label
    Friend WithEvents cmbCollector As ComboBox
    Friend WithEvents ofdDocuments As OpenFileDialog
    Friend WithEvents btnAddNonRecycledItem As Button
    Friend WithEvents flpNonRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddRecycledItem As Button
    Friend WithEvents flpRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddOtherRecycledItem As Button
    Friend WithEvents flpOtherRecycledItems As FlowLayoutPanel
    Friend WithEvents btnAddChemicalItem As Button
    Friend WithEvents flpChemicalItems As FlowLayoutPanel
    Friend WithEvents btnManageCollectors As Button
    Friend WithEvents dgvNonRecycled As DataGridView
    Friend WithEvents dgvRecycled As DataGridView
    Friend WithEvents dgvOtherRecycled As DataGridView
    Friend WithEvents dgvChemical As DataGridView

End Class