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
        flpNonRecycledItems = New FlowLayoutPanel()
        btnAddNonRecycledItem = New Button()
        lblNonPolyethene = New Label()
        numNonPolyethene = New NumericUpDown()
        lblNonPlastic = New Label()
        numNonPlastic = New NumericUpDown()
        tpRecycled = New TabPage()
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
        cmbFilter = New ComboBox()
        lblFilter = New Label()
        dgvWasteRecords = New DataGridView()
        ofdDocuments = New OpenFileDialog()
        tabWasteCategories.SuspendLayout()
        tpNonRecycled.SuspendLayout()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).BeginInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpRecycled.SuspendLayout()
        CType(numRecPaper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).BeginInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).BeginInit()
        tpOtherRecycled.SuspendLayout()
        CType(numOrgFood, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCopper, ComponentModel.ISupportInitialize).BeginInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).BeginInit()
        CType(numGlass, ComponentModel.ISupportInitialize).BeginInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).BeginInit()
        tpChemical.SuspendLayout()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).BeginInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).BeginInit()
        grpCommon.SuspendLayout()
        grpDataView.SuspendLayout()
        CType(dgvWasteRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabWasteCategories
        ' 
        tabWasteCategories.Controls.Add(tpNonRecycled)
        tabWasteCategories.Controls.Add(tpRecycled)
        tabWasteCategories.Controls.Add(tpOtherRecycled)
        tabWasteCategories.Controls.Add(tpChemical)
        tabWasteCategories.Location = New Point(14, 14)
        tabWasteCategories.Margin = New Padding(4, 3, 4, 3)
        tabWasteCategories.Name = "tabWasteCategories"
        tabWasteCategories.SelectedIndex = 0
        tabWasteCategories.Size = New Size(545, 462)
        tabWasteCategories.TabIndex = 0
        ' 
        ' tpNonRecycled
        ' 
        tpNonRecycled.Controls.Add(flpNonRecycledItems)
        tpNonRecycled.Controls.Add(btnAddNonRecycledItem)
        tpNonRecycled.Controls.Add(lblNonPolyethene)
        tpNonRecycled.Controls.Add(numNonPolyethene)
        tpNonRecycled.Controls.Add(lblNonPlastic)
        tpNonRecycled.Controls.Add(numNonPlastic)
        tpNonRecycled.Location = New Point(4, 24)
        tpNonRecycled.Margin = New Padding(4, 3, 4, 3)
        tpNonRecycled.Name = "tpNonRecycled"
        tpNonRecycled.Padding = New Padding(4, 3, 4, 3)
        tpNonRecycled.Size = New Size(537, 434)
        tpNonRecycled.TabIndex = 0
        tpNonRecycled.Text = "Non-Recycled Waste"
        tpNonRecycled.UseVisualStyleBackColor = True
        ' 
        ' flpNonRecycledItems
        ' 
        flpNonRecycledItems.AutoScroll = True
        flpNonRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpNonRecycledItems.Location = New Point(7, 173)
        flpNonRecycledItems.Margin = New Padding(4, 3, 4, 3)
        flpNonRecycledItems.Name = "flpNonRecycledItems"
        flpNonRecycledItems.Size = New Size(472, 207)
        flpNonRecycledItems.TabIndex = 10
        ' 
        ' btnAddNonRecycledItem
        ' 
        btnAddNonRecycledItem.BackColor = SystemColors.Control
        btnAddNonRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddNonRecycledItem.Location = New Point(8, 132)
        btnAddNonRecycledItem.Margin = New Padding(4, 3, 4, 3)
        btnAddNonRecycledItem.Name = "btnAddNonRecycledItem"
        btnAddNonRecycledItem.Size = New Size(115, 35)
        btnAddNonRecycledItem.TabIndex = 9
        btnAddNonRecycledItem.Text = "+ Add New Item"
        btnAddNonRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblNonPolyethene
        ' 
        lblNonPolyethene.AutoSize = True
        lblNonPolyethene.Font = New Font("Microsoft Sans Serif", 10F)
        lblNonPolyethene.Location = New Point(7, 23)
        lblNonPolyethene.Margin = New Padding(4, 0, 4, 0)
        lblNonPolyethene.Name = "lblNonPolyethene"
        lblNonPolyethene.Size = New Size(83, 17)
        lblNonPolyethene.TabIndex = 0
        lblNonPolyethene.Text = "Polyethene:"
        ' 
        ' numNonPolyethene
        ' 
        numNonPolyethene.DecimalPlaces = 2
        numNonPolyethene.Location = New Point(175, 21)
        numNonPolyethene.Margin = New Padding(4, 3, 4, 3)
        numNonPolyethene.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPolyethene.Name = "numNonPolyethene"
        numNonPolyethene.Size = New Size(140, 23)
        numNonPolyethene.TabIndex = 1
        ' 
        ' lblNonPlastic
        ' 
        lblNonPlastic.AutoSize = True
        lblNonPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblNonPlastic.Location = New Point(7, 58)
        lblNonPlastic.Margin = New Padding(4, 0, 4, 0)
        lblNonPlastic.Name = "lblNonPlastic"
        lblNonPlastic.Size = New Size(53, 17)
        lblNonPlastic.TabIndex = 2
        lblNonPlastic.Text = "Plastic:"
        ' 
        ' numNonPlastic
        ' 
        numNonPlastic.DecimalPlaces = 2
        numNonPlastic.Location = New Point(175, 55)
        numNonPlastic.Margin = New Padding(4, 3, 4, 3)
        numNonPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numNonPlastic.Name = "numNonPlastic"
        numNonPlastic.Size = New Size(140, 23)
        numNonPlastic.TabIndex = 3
        ' 
        ' tpRecycled
        ' 
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
        tpRecycled.Margin = New Padding(4, 3, 4, 3)
        tpRecycled.Name = "tpRecycled"
        tpRecycled.Padding = New Padding(4, 3, 4, 3)
        tpRecycled.Size = New Size(537, 434)
        tpRecycled.TabIndex = 1
        tpRecycled.Text = "Recycled Waste"
        tpRecycled.UseVisualStyleBackColor = True
        ' 
        ' flpRecycledItems
        ' 
        flpRecycledItems.AutoScroll = True
        flpRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpRecycledItems.Location = New Point(7, 173)
        flpRecycledItems.Margin = New Padding(4, 3, 4, 3)
        flpRecycledItems.Name = "flpRecycledItems"
        flpRecycledItems.Size = New Size(491, 207)
        flpRecycledItems.TabIndex = 12
        ' 
        ' btnAddRecycledItem
        ' 
        btnAddRecycledItem.BackColor = SystemColors.Control
        btnAddRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddRecycledItem.Location = New Point(290, 36)
        btnAddRecycledItem.Margin = New Padding(4, 3, 4, 3)
        btnAddRecycledItem.Name = "btnAddRecycledItem"
        btnAddRecycledItem.Size = New Size(121, 35)
        btnAddRecycledItem.TabIndex = 11
        btnAddRecycledItem.Text = "+ Add New Item"
        btnAddRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblRecPaper
        ' 
        lblRecPaper.AutoSize = True
        lblRecPaper.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecPaper.Location = New Point(9, 23)
        lblRecPaper.Margin = New Padding(4, 0, 4, 0)
        lblRecPaper.Name = "lblRecPaper"
        lblRecPaper.Size = New Size(50, 17)
        lblRecPaper.TabIndex = 0
        lblRecPaper.Text = "Paper:"
        ' 
        ' numRecPaper
        ' 
        numRecPaper.DecimalPlaces = 2
        numRecPaper.Location = New Point(130, 22)
        numRecPaper.Margin = New Padding(4, 3, 4, 3)
        numRecPaper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPaper.Name = "numRecPaper"
        numRecPaper.Size = New Size(140, 23)
        numRecPaper.TabIndex = 1
        ' 
        ' lblRecCardboard
        ' 
        lblRecCardboard.AutoSize = True
        lblRecCardboard.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecCardboard.Location = New Point(7, 58)
        lblRecCardboard.Margin = New Padding(4, 0, 4, 0)
        lblRecCardboard.Name = "lblRecCardboard"
        lblRecCardboard.Size = New Size(79, 17)
        lblRecCardboard.TabIndex = 2
        lblRecCardboard.Text = "Cardboard:"
        ' 
        ' numRecCardboard
        ' 
        numRecCardboard.DecimalPlaces = 2
        numRecCardboard.Location = New Point(130, 55)
        numRecCardboard.Margin = New Padding(4, 3, 4, 3)
        numRecCardboard.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecCardboard.Name = "numRecCardboard"
        numRecCardboard.Size = New Size(140, 23)
        numRecCardboard.TabIndex = 3
        ' 
        ' lblRecPlastic
        ' 
        lblRecPlastic.AutoSize = True
        lblRecPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecPlastic.Location = New Point(9, 90)
        lblRecPlastic.Margin = New Padding(4, 0, 4, 0)
        lblRecPlastic.Name = "lblRecPlastic"
        lblRecPlastic.Size = New Size(115, 17)
        lblRecPlastic.TabIndex = 4
        lblRecPlastic.Text = "Recycled Plastic:"
        ' 
        ' numRecPlastic
        ' 
        numRecPlastic.DecimalPlaces = 2
        numRecPlastic.Location = New Point(130, 84)
        numRecPlastic.Margin = New Padding(4, 3, 4, 3)
        numRecPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecPlastic.Name = "numRecPlastic"
        numRecPlastic.Size = New Size(140, 23)
        numRecPlastic.TabIndex = 5
        ' 
        ' lblRecOtherPlastic
        ' 
        lblRecOtherPlastic.AutoSize = True
        lblRecOtherPlastic.Font = New Font("Microsoft Sans Serif", 10F)
        lblRecOtherPlastic.Location = New Point(9, 119)
        lblRecOtherPlastic.Margin = New Padding(4, 0, 4, 0)
        lblRecOtherPlastic.Name = "lblRecOtherPlastic"
        lblRecOtherPlastic.Size = New Size(93, 17)
        lblRecOtherPlastic.TabIndex = 6
        lblRecOtherPlastic.Text = "Other Plastic:"
        ' 
        ' numRecOtherPlastic
        ' 
        numRecOtherPlastic.DecimalPlaces = 2
        numRecOtherPlastic.Location = New Point(130, 113)
        numRecOtherPlastic.Margin = New Padding(4, 3, 4, 3)
        numRecOtherPlastic.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numRecOtherPlastic.Name = "numRecOtherPlastic"
        numRecOtherPlastic.Size = New Size(140, 23)
        numRecOtherPlastic.TabIndex = 7
        ' 
        ' tpOtherRecycled
        ' 
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
        tpOtherRecycled.Margin = New Padding(4, 3, 4, 3)
        tpOtherRecycled.Name = "tpOtherRecycled"
        tpOtherRecycled.Size = New Size(537, 434)
        tpOtherRecycled.TabIndex = 2
        tpOtherRecycled.Text = "Other Recycled Waste"
        tpOtherRecycled.UseVisualStyleBackColor = True
        ' 
        ' flpOtherRecycledItems
        ' 
        flpOtherRecycledItems.AutoScroll = True
        flpOtherRecycledItems.BorderStyle = BorderStyle.FixedSingle
        flpOtherRecycledItems.Location = New Point(7, 208)
        flpOtherRecycledItems.Margin = New Padding(4, 3, 4, 3)
        flpOtherRecycledItems.Name = "flpOtherRecycledItems"
        flpOtherRecycledItems.Size = New Size(526, 173)
        flpOtherRecycledItems.TabIndex = 14
        ' 
        ' btnAddOtherRecycledItem
        ' 
        btnAddOtherRecycledItem.BackColor = SystemColors.Control
        btnAddOtherRecycledItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddOtherRecycledItem.Location = New Point(335, 167)
        btnAddOtherRecycledItem.Margin = New Padding(4, 3, 4, 3)
        btnAddOtherRecycledItem.Name = "btnAddOtherRecycledItem"
        btnAddOtherRecycledItem.Size = New Size(120, 35)
        btnAddOtherRecycledItem.TabIndex = 13
        btnAddOtherRecycledItem.Text = "+ Add New Item"
        btnAddOtherRecycledItem.UseVisualStyleBackColor = False
        ' 
        ' lblOrgFood
        ' 
        lblOrgFood.AutoSize = True
        lblOrgFood.Font = New Font("Microsoft Sans Serif", 10F)
        lblOrgFood.Location = New Point(7, 17)
        lblOrgFood.Margin = New Padding(4, 0, 4, 0)
        lblOrgFood.Name = "lblOrgFood"
        lblOrgFood.Size = New Size(106, 17)
        lblOrgFood.TabIndex = 0
        lblOrgFood.Text = "Organic Waste:"
        ' 
        ' numOrgFood
        ' 
        numOrgFood.DecimalPlaces = 2
        numOrgFood.Location = New Point(142, 15)
        numOrgFood.Margin = New Padding(4, 3, 4, 3)
        numOrgFood.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numOrgFood.Name = "numOrgFood"
        numOrgFood.Size = New Size(140, 23)
        numOrgFood.TabIndex = 1
        ' 
        ' chkCompost
        ' 
        chkCompost.AutoSize = True
        chkCompost.Location = New Point(303, 17)
        chkCompost.Margin = New Padding(4, 3, 4, 3)
        chkCompost.Name = "chkCompost"
        chkCompost.Size = New Size(75, 19)
        chkCompost.TabIndex = 2
        chkCompost.Text = "Compost"
        chkCompost.UseVisualStyleBackColor = True
        ' 
        ' chkAnimalFeed
        ' 
        chkAnimalFeed.AutoSize = True
        chkAnimalFeed.Location = New Point(386, 17)
        chkAnimalFeed.Margin = New Padding(4, 3, 4, 3)
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
        lblCopper.Location = New Point(7, 52)
        lblCopper.Margin = New Padding(4, 0, 4, 0)
        lblCopper.Name = "lblCopper"
        lblCopper.Size = New Size(58, 17)
        lblCopper.TabIndex = 4
        lblCopper.Text = "Copper:"
        ' 
        ' numCopper
        ' 
        numCopper.DecimalPlaces = 2
        numCopper.Location = New Point(142, 50)
        numCopper.Margin = New Padding(4, 3, 4, 3)
        numCopper.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numCopper.Name = "numCopper"
        numCopper.Size = New Size(140, 23)
        numCopper.TabIndex = 5
        ' 
        ' lblAluminium
        ' 
        lblAluminium.AutoSize = True
        lblAluminium.Font = New Font("Microsoft Sans Serif", 10F)
        lblAluminium.Location = New Point(7, 87)
        lblAluminium.Margin = New Padding(4, 0, 4, 0)
        lblAluminium.Name = "lblAluminium"
        lblAluminium.Size = New Size(76, 17)
        lblAluminium.TabIndex = 6
        lblAluminium.Text = "Aluminium:"
        ' 
        ' numAluminium
        ' 
        numAluminium.DecimalPlaces = 2
        numAluminium.Location = New Point(142, 84)
        numAluminium.Margin = New Padding(4, 3, 4, 3)
        numAluminium.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numAluminium.Name = "numAluminium"
        numAluminium.Size = New Size(140, 23)
        numAluminium.TabIndex = 7
        ' 
        ' lblGlass
        ' 
        lblGlass.AutoSize = True
        lblGlass.Font = New Font("Microsoft Sans Serif", 10F)
        lblGlass.Location = New Point(7, 121)
        lblGlass.Margin = New Padding(4, 0, 4, 0)
        lblGlass.Name = "lblGlass"
        lblGlass.Size = New Size(48, 17)
        lblGlass.TabIndex = 8
        lblGlass.Text = "Glass:"
        ' 
        ' numGlass
        ' 
        numGlass.DecimalPlaces = 2
        numGlass.Location = New Point(142, 119)
        numGlass.Margin = New Padding(4, 3, 4, 3)
        numGlass.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numGlass.Name = "numGlass"
        numGlass.Size = New Size(140, 23)
        numGlass.TabIndex = 9
        ' 
        ' lblEWaste
        ' 
        lblEWaste.AutoSize = True
        lblEWaste.Font = New Font("Microsoft Sans Serif", 10F)
        lblEWaste.Location = New Point(7, 160)
        lblEWaste.Margin = New Padding(4, 0, 4, 0)
        lblEWaste.Name = "lblEWaste"
        lblEWaste.Size = New Size(97, 17)
        lblEWaste.TabIndex = 10
        lblEWaste.Text = "E-Waste (Kg):"
        ' 
        ' numEWaste
        ' 
        numEWaste.DecimalPlaces = 2
        numEWaste.Location = New Point(142, 154)
        numEWaste.Margin = New Padding(4, 3, 4, 3)
        numEWaste.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numEWaste.Name = "numEWaste"
        numEWaste.Size = New Size(140, 23)
        numEWaste.TabIndex = 11
        ' 
        ' tpChemical
        ' 
        tpChemical.Controls.Add(flpChemicalItems)
        tpChemical.Controls.Add(btnAddChemicalItem)
        tpChemical.Controls.Add(lblChemLiquids)
        tpChemical.Controls.Add(numChemLiquids)
        tpChemical.Controls.Add(lblChemPacking)
        tpChemical.Controls.Add(numChemPacking)
        tpChemical.Controls.Add(lblChemFabric)
        tpChemical.Controls.Add(numChemFabric)
        tpChemical.Location = New Point(4, 24)
        tpChemical.Margin = New Padding(4, 3, 4, 3)
        tpChemical.Name = "tpChemical"
        tpChemical.Size = New Size(537, 434)
        tpChemical.TabIndex = 3
        tpChemical.Text = "Chemical Waste"
        tpChemical.UseVisualStyleBackColor = True
        ' 
        ' flpChemicalItems
        ' 
        flpChemicalItems.AutoScroll = True
        flpChemicalItems.BorderStyle = BorderStyle.FixedSingle
        flpChemicalItems.Location = New Point(7, 203)
        flpChemicalItems.Margin = New Padding(4, 3, 4, 3)
        flpChemicalItems.Name = "flpChemicalItems"
        flpChemicalItems.Size = New Size(526, 146)
        flpChemicalItems.TabIndex = 14
        ' 
        ' btnAddChemicalItem
        ' 
        btnAddChemicalItem.BackColor = SystemColors.Control
        btnAddChemicalItem.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        btnAddChemicalItem.Location = New Point(7, 151)
        btnAddChemicalItem.Margin = New Padding(4, 3, 4, 3)
        btnAddChemicalItem.Name = "btnAddChemicalItem"
        btnAddChemicalItem.Size = New Size(123, 35)
        btnAddChemicalItem.TabIndex = 13
        btnAddChemicalItem.Text = "+ Add New Item"
        btnAddChemicalItem.UseVisualStyleBackColor = False
        ' 
        ' lblChemLiquids
        ' 
        lblChemLiquids.AutoSize = True
        lblChemLiquids.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemLiquids.Location = New Point(7, 23)
        lblChemLiquids.Margin = New Padding(4, 0, 4, 0)
        lblChemLiquids.Name = "lblChemLiquids"
        lblChemLiquids.Size = New Size(155, 17)
        lblChemLiquids.TabIndex = 0
        lblChemLiquids.Text = "Used Chemical Liquids:"
        ' 
        ' numChemLiquids
        ' 
        numChemLiquids.DecimalPlaces = 2
        numChemLiquids.Location = New Point(195, 23)
        numChemLiquids.Margin = New Padding(4, 3, 4, 3)
        numChemLiquids.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemLiquids.Name = "numChemLiquids"
        numChemLiquids.Size = New Size(140, 23)
        numChemLiquids.TabIndex = 1
        ' 
        ' lblChemPacking
        ' 
        lblChemPacking.AutoSize = True
        lblChemPacking.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemPacking.Location = New Point(7, 58)
        lblChemPacking.Margin = New Padding(4, 0, 4, 0)
        lblChemPacking.Name = "lblChemPacking"
        lblChemPacking.Size = New Size(123, 17)
        lblChemPacking.TabIndex = 2
        lblChemPacking.Text = "Chemical Packing:"
        ' 
        ' numChemPacking
        ' 
        numChemPacking.DecimalPlaces = 2
        numChemPacking.Location = New Point(195, 54)
        numChemPacking.Margin = New Padding(4, 3, 4, 3)
        numChemPacking.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemPacking.Name = "numChemPacking"
        numChemPacking.Size = New Size(140, 23)
        numChemPacking.TabIndex = 3
        ' 
        ' lblChemFabric
        ' 
        lblChemFabric.AutoSize = True
        lblChemFabric.Font = New Font("Microsoft Sans Serif", 10F)
        lblChemFabric.Location = New Point(7, 95)
        lblChemFabric.Margin = New Padding(4, 0, 4, 0)
        lblChemFabric.Name = "lblChemFabric"
        lblChemFabric.Size = New Size(112, 17)
        lblChemFabric.TabIndex = 4
        lblChemFabric.Text = "Chemical Fabric:"
        ' 
        ' numChemFabric
        ' 
        numChemFabric.DecimalPlaces = 2
        numChemFabric.Location = New Point(195, 89)
        numChemFabric.Margin = New Padding(4, 3, 4, 3)
        numChemFabric.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        numChemFabric.Name = "numChemFabric"
        numChemFabric.Size = New Size(140, 23)
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
        grpCommon.Location = New Point(14, 482)
        grpCommon.Margin = New Padding(4, 3, 4, 3)
        grpCommon.Name = "grpCommon"
        grpCommon.Padding = New Padding(4, 3, 4, 3)
        grpCommon.Size = New Size(513, 138)
        grpCommon.TabIndex = 1
        grpCommon.TabStop = False
        grpCommon.Text = "Record Information"
        ' 
        ' btnManageCollectors
        ' 
        btnManageCollectors.BackColor = SystemColors.Control
        btnManageCollectors.Location = New Point(423, 22)
        btnManageCollectors.Margin = New Padding(4, 3, 4, 3)
        btnManageCollectors.Name = "btnManageCollectors"
        btnManageCollectors.Size = New Size(60, 27)
        btnManageCollectors.TabIndex = 9
        btnManageCollectors.Text = "Manage"
        btnManageCollectors.UseVisualStyleBackColor = False
        ' 
        ' lblCollector
        ' 
        lblCollector.AutoSize = True
        lblCollector.Font = New Font("Microsoft Sans Serif", 10F)
        lblCollector.Location = New Point(233, 29)
        lblCollector.Margin = New Padding(4, 0, 4, 0)
        lblCollector.Name = "lblCollector"
        lblCollector.Size = New Size(67, 17)
        lblCollector.TabIndex = 6
        lblCollector.Text = "Collector:"
        ' 
        ' cmbCollector
        ' 
        cmbCollector.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCollector.FormattingEnabled = True
        cmbCollector.Location = New Point(315, 25)
        cmbCollector.Margin = New Padding(4, 3, 4, 3)
        cmbCollector.Name = "cmbCollector"
        cmbCollector.Size = New Size(100, 23)
        cmbCollector.TabIndex = 7
        ' 
        ' btnUploadDocuments
        ' 
        btnUploadDocuments.BackColor = Color.LightYellow
        btnUploadDocuments.Location = New Point(220, 99)
        btnUploadDocuments.Margin = New Padding(4, 3, 4, 3)
        btnUploadDocuments.Name = "btnUploadDocuments"
        btnUploadDocuments.Size = New Size(119, 23)
        btnUploadDocuments.TabIndex = 5
        btnUploadDocuments.Text = "Upload Documents"
        btnUploadDocuments.UseVisualStyleBackColor = False
        ' 
        ' btnSaveRecord
        ' 
        btnSaveRecord.BackColor = SystemColors.Control
        btnSaveRecord.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        btnSaveRecord.Location = New Point(423, 99)
        btnSaveRecord.Margin = New Padding(4, 3, 4, 3)
        btnSaveRecord.Name = "btnSaveRecord"
        btnSaveRecord.Size = New Size(83, 32)
        btnSaveRecord.TabIndex = 4
        btnSaveRecord.Text = "Save"
        btnSaveRecord.UseVisualStyleBackColor = False
        ' 
        ' dtpRecordDate
        ' 
        dtpRecordDate.Format = DateTimePickerFormat.Short
        dtpRecordDate.Location = New Point(93, 25)
        dtpRecordDate.Margin = New Padding(4, 3, 4, 3)
        dtpRecordDate.Name = "dtpRecordDate"
        dtpRecordDate.Size = New Size(116, 23)
        dtpRecordDate.TabIndex = 3
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Microsoft Sans Serif", 10F)
        lblDate.Location = New Point(7, 29)
        lblDate.Margin = New Padding(4, 0, 4, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(42, 17)
        lblDate.TabIndex = 2
        lblDate.Text = "Date:"
        ' 
        ' lblDailyTotal
        ' 
        lblDailyTotal.AutoSize = True
        lblDailyTotal.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        lblDailyTotal.Location = New Point(7, 69)
        lblDailyTotal.Margin = New Padding(4, 0, 4, 0)
        lblDailyTotal.Name = "lblDailyTotal"
        lblDailyTotal.Size = New Size(91, 17)
        lblDailyTotal.TabIndex = 0
        lblDailyTotal.Text = "Daily Total:"
        ' 
        ' txtDailyTotal
        ' 
        txtDailyTotal.BackColor = Color.LightYellow
        txtDailyTotal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtDailyTotal.Location = New Point(114, 63)
        txtDailyTotal.Margin = New Padding(4, 3, 4, 3)
        txtDailyTotal.Name = "txtDailyTotal"
        txtDailyTotal.ReadOnly = True
        txtDailyTotal.Size = New Size(95, 26)
        txtDailyTotal.TabIndex = 1
        txtDailyTotal.Text = "0 KG"
        ' 
        ' grpDataView
        ' 
        grpDataView.Controls.Add(btnExportExcel)
        grpDataView.Controls.Add(btnDelete)
        grpDataView.Controls.Add(btnUpdate)
        grpDataView.Controls.Add(cmbFilter)
        grpDataView.Controls.Add(lblFilter)
        grpDataView.Controls.Add(dgvWasteRecords)
        grpDataView.Location = New Point(567, 38)
        grpDataView.Margin = New Padding(4, 3, 4, 3)
        grpDataView.Name = "grpDataView"
        grpDataView.Padding = New Padding(4, 3, 4, 3)
        grpDataView.Size = New Size(627, 601)
        grpDataView.TabIndex = 2
        grpDataView.TabStop = False
        grpDataView.Text = "Waste Records"
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = SystemColors.Control
        btnExportExcel.Location = New Point(482, 24)
        btnExportExcel.Margin = New Padding(4, 3, 4, 3)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(105, 25)
        btnExportExcel.TabIndex = 7
        btnExportExcel.Text = "Export to Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.Control
        btnDelete.Location = New Point(380, 24)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 25)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.Control
        btnUpdate.Location = New Point(277, 24)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 25)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' cmbFilter
        ' 
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {"All", "Non-Recycled", "Recycled", "Other Recycled", "Chemical"})
        cmbFilter.Location = New Point(70, 25)
        cmbFilter.Margin = New Padding(4, 3, 4, 3)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(174, 23)
        cmbFilter.TabIndex = 4
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Font = New Font("Microsoft Sans Serif", 10F)
        lblFilter.Location = New Point(7, 28)
        lblFilter.Margin = New Padding(4, 0, 4, 0)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(43, 17)
        lblFilter.TabIndex = 3
        lblFilter.Text = "Filter:"
        ' 
        ' dgvWasteRecords
        ' 
        dgvWasteRecords.AllowUserToAddRows = False
        dgvWasteRecords.AllowUserToDeleteRows = False
        dgvWasteRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvWasteRecords.Location = New Point(7, 58)
        dgvWasteRecords.Margin = New Padding(4, 3, 4, 3)
        dgvWasteRecords.Name = "dgvWasteRecords"
        dgvWasteRecords.RowHeadersWidth = 51
        dgvWasteRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvWasteRecords.Size = New Size(612, 531)
        dgvWasteRecords.TabIndex = 0
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
        ClientSize = New Size(1199, 639)
        Controls.Add(grpDataView)
        Controls.Add(grpCommon)
        Controls.Add(tabWasteCategories)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmWasteManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Waste Management System"
        tabWasteCategories.ResumeLayout(False)
        tpNonRecycled.ResumeLayout(False)
        tpNonRecycled.PerformLayout()
        CType(numNonPolyethene, ComponentModel.ISupportInitialize).EndInit()
        CType(numNonPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpRecycled.ResumeLayout(False)
        tpRecycled.PerformLayout()
        CType(numRecPaper, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecCardboard, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecPlastic, ComponentModel.ISupportInitialize).EndInit()
        CType(numRecOtherPlastic, ComponentModel.ISupportInitialize).EndInit()
        tpOtherRecycled.ResumeLayout(False)
        tpOtherRecycled.PerformLayout()
        CType(numOrgFood, ComponentModel.ISupportInitialize).EndInit()
        CType(numCopper, ComponentModel.ISupportInitialize).EndInit()
        CType(numAluminium, ComponentModel.ISupportInitialize).EndInit()
        CType(numGlass, ComponentModel.ISupportInitialize).EndInit()
        CType(numEWaste, ComponentModel.ISupportInitialize).EndInit()
        tpChemical.ResumeLayout(False)
        tpChemical.PerformLayout()
        CType(numChemLiquids, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemPacking, ComponentModel.ISupportInitialize).EndInit()
        CType(numChemFabric, ComponentModel.ISupportInitialize).EndInit()
        grpCommon.ResumeLayout(False)
        grpCommon.PerformLayout()
        grpDataView.ResumeLayout(False)
        grpDataView.PerformLayout()
        CType(dgvWasteRecords, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvWasteRecords As DataGridView
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilter As ComboBox
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

End Class