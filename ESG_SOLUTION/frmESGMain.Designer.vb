<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmESGMain
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
        tcMain = New TabControl()
        tpHSE = New TabPage()
        grpHSEFilter = New GroupBox()
        btnClearHSEFilter = New Button()
        btnApplyHSEFilter = New Button()
        dtpHSEFilterMonth = New DateTimePicker()
        dtpHSEFilterYear = New DateTimePicker()
        Label90 = New Label()
        Label89 = New Label()
        btnExportHSE = New Button()
        btnLoadHSE = New Button()
        btnSaveHSE = New Button()
        dgvHSE = New DataGridView()
        GroupBoxHSE = New GroupBox()
        txtOtherWorkshopName = New TextBox()
        Label6 = New Label()
        nudOtherWorkshop = New NumericUpDown()
        Label5 = New Label()
        nudFireFighting = New NumericUpDown()
        Label4 = New Label()
        nudFirstAid = New NumericUpDown()
        Label3 = New Label()
        nudHSECount = New NumericUpDown()
        Label2 = New Label()
        dtpHSE = New DateTimePicker()
        Label1 = New Label()
        tpSafety = New TabPage()
        grpSafetyFilter = New GroupBox()
        btnClearSafetyFilter = New Button()
        btnApplySafetyFilter = New Button()
        dtpSafetyFilterMonth = New DateTimePicker()
        dtpSafetyFilterYear = New DateTimePicker()
        Label92 = New Label()
        Label91 = New Label()
        btnExportSafety = New Button()
        btnLoadSafety = New Button()
        btnSaveSafety = New Button()
        dgvSafety = New DataGridView()
        GroupBoxSafety = New GroupBox()
        nudDeaths = New NumericUpDown()
        Label14 = New Label()
        nudIllness = New NumericUpDown()
        Label13 = New Label()
        nudInjuries = New NumericUpDown()
        Label12 = New Label()
        nudTotalAccidents = New NumericUpDown()
        Label11 = New Label()
        nudNearMisses = New NumericUpDown()
        Label10 = New Label()
        nudEnvironmental = New NumericUpDown()
        Label9 = New Label()
        nudPropertyDamage = New NumericUpDown()
        Label8 = New Label()
        dtpSafety = New DateTimePicker()
        Label7 = New Label()
        tpGrievances = New TabPage()
        grpGrievancesFilter = New GroupBox()
        btnClearGrievancesFilter = New Button()
        btnApplyGrievancesFilter = New Button()
        dtpGrievancesFilterMonth = New DateTimePicker()
        dtpGrievancesFilterYear = New DateTimePicker()
        Label94 = New Label()
        Label93 = New Label()
        btnExportGrievances = New Button()
        btnLoadGrievances = New Button()
        btnSaveGrievances = New Button()
        dgvGrievances = New DataGridView()
        GroupBoxGrievances = New GroupBox()
        nudUnresolvedGrievances = New NumericUpDown()
        Label16 = New Label()
        nudTotalGrievances = New NumericUpDown()
        Label15 = New Label()
        dtpGrievances = New DateTimePicker()
        Label17 = New Label()
        tpSocial = New TabPage()
        grpSocialFilter = New GroupBox()
        btnClearSocialFilter = New Button()
        btnApplySocialFilter = New Button()
        dtpSocialFilterMonth = New DateTimePicker()
        dtpSocialFilterYear = New DateTimePicker()
        Label96 = New Label()
        Label95 = New Label()
        btnExportSocial = New Button()
        btnLoadSocial = New Button()
        btnSaveSocial = New Button()
        dgvSocial = New DataGridView()
        MainTabControl = New TabControl()
        tabBasicInfo = New TabPage()
        GroupBoxBasic = New GroupBox()
        btnDeleteAgeCategory = New Button()
        lstAgeCategories = New ListBox()
        btnAddAge = New Button()
        nudAgeCount = New NumericUpDown()
        cboAgeCategory = New ComboBox()
        Label23 = New Label()
        Label22 = New Label()
        nudFemale = New NumericUpDown()
        Label21 = New Label()
        nudMale = New NumericUpDown()
        Label20 = New Label()
        dtpSocial = New DateTimePicker()
        Label19 = New Label()
        tabSkills = New TabPage()
        dtpSkills = New DateTimePicker()
        Label80 = New Label()
        GroupBoxSkills = New GroupBox()
        btnSaveSkills = New Button()
        nudNewToIndustry = New NumericUpDown()
        Label26 = New Label()
        nudHiredQualified = New NumericUpDown()
        Label25 = New Label()
        nudLearntAtNIRU = New NumericUpDown()
        Label24 = New Label()
        tabPromotions = New TabPage()
        btnSavePromotions = New Button()
        dtpPromotions = New DateTimePicker()
        Label81 = New Label()
        GroupBoxPromotions = New GroupBox()
        nudSameFamily = New NumericUpDown()
        Label29 = New Label()
        nudInternalMobility = New NumericUpDown()
        Label28 = New Label()
        nudPromotions = New NumericUpDown()
        Label27 = New Label()
        tabManagement = New TabPage()
        btnSaveManagement = New Button()
        dtpManagement = New DateTimePicker()
        Label82 = New Label()
        GroupBoxManagement = New GroupBox()
        nudMenLeadership = New NumericUpDown()
        Label39 = New Label()
        nudWomenLeadership = New NumericUpDown()
        Label40 = New Label()
        Label41 = New Label()
        nudMenUpper = New NumericUpDown()
        Label36 = New Label()
        nudWomenUpper = New NumericUpDown()
        Label37 = New Label()
        Label38 = New Label()
        nudMenMiddle = New NumericUpDown()
        Label33 = New Label()
        nudWomenMiddle = New NumericUpDown()
        Label34 = New Label()
        Label35 = New Label()
        nudMenFirstLine = New NumericUpDown()
        Label30 = New Label()
        nudWomenFirstLine = New NumericUpDown()
        Label31 = New Label()
        Label32 = New Label()
        tabDisabilities = New TabPage()
        btnSaveDisabilities = New Button()
        dtpDisabilities = New DateTimePicker()
        Label83 = New Label()
        GroupBoxDisabilities = New GroupBox()
        nudChronic = New NumericUpDown()
        Label46 = New Label()
        nudIntellectual = New NumericUpDown()
        Label45 = New Label()
        nudMentalHealth = New NumericUpDown()
        Label44 = New Label()
        nudSensory = New NumericUpDown()
        Label43 = New Label()
        nudPhysical = New NumericUpDown()
        Label42 = New Label()
        tabBehavior = New TabPage()
        btnSaveBehavior = New Button()
        dtpBehavior = New DateTimePicker()
        Label84 = New Label()
        GroupBoxBehavior = New GroupBox()
        nudPansexual = New NumericUpDown()
        Label51 = New Label()
        nudAsexual = New NumericUpDown()
        Label50 = New Label()
        nudBisexual = New NumericUpDown()
        Label49 = New Label()
        nudGay = New NumericUpDown()
        Label48 = New Label()
        nudLesbian = New NumericUpDown()
        Label47 = New Label()
        tabIdentification = New TabPage()
        btnSaveIdentification = New Button()
        dtpIdentification = New DateTimePicker()
        Label85 = New Label()
        GroupBoxIdentification = New GroupBox()
        nudAgender = New NumericUpDown()
        Label56 = New Label()
        nudNonBinary = New NumericUpDown()
        Label55 = New Label()
        nudQuestioning = New NumericUpDown()
        Label54 = New Label()
        nudQueer = New NumericUpDown()
        Label53 = New Label()
        nudTransgender = New NumericUpDown()
        Label52 = New Label()
        tabNations = New TabPage()
        btnSaveNations = New Button()
        dtpNations = New DateTimePicker()
        Label86 = New Label()
        GroupBoxNations = New GroupBox()
        txtOtherEthnicitySpecify = New TextBox()
        Label63 = New Label()
        nudOtherEthnicity = New NumericUpDown()
        Label62 = New Label()
        nudEuropean = New NumericUpDown()
        Label61 = New Label()
        nudPacificIslander = New NumericUpDown()
        Label60 = New Label()
        nudMiddleEastern = New NumericUpDown()
        Label59 = New Label()
        nudIndigenous = New NumericUpDown()
        Label58 = New Label()
        nudHispanic = New NumericUpDown()
        Label64 = New Label()
        nudAsian = New NumericUpDown()
        Label57 = New Label()
        nudAfrican = New NumericUpDown()
        Label65 = New Label()
        tabReligions = New TabPage()
        btnSaveReligions = New Button()
        dtpReligions = New DateTimePicker()
        Label87 = New Label()
        GroupBoxReligions = New GroupBox()
        nudNoReligion = New NumericUpDown()
        Label74 = New Label()
        txtOtherReligionSpecify = New TextBox()
        Label73 = New Label()
        nudOtherReligion = New NumericUpDown()
        Label72 = New Label()
        nudSikhism = New NumericUpDown()
        Label71 = New Label()
        nudJudaism = New NumericUpDown()
        Label70 = New Label()
        nudBuddhism = New NumericUpDown()
        Label69 = New Label()
        nudHinduism = New NumericUpDown()
        Label68 = New Label()
        nudIslam = New NumericUpDown()
        Label67 = New Label()
        nudChristianity = New NumericUpDown()
        Label66 = New Label()
        tabLanguages = New TabPage()
        btnSaveLanguages = New Button()
        dtpLanguages = New DateTimePicker()
        Label88 = New Label()
        GroupBoxLanguages = New GroupBox()
        nudHindi = New NumericUpDown()
        Label78 = New Label()
        nudFrench = New NumericUpDown()
        Label77 = New Label()
        nudHebrew = New NumericUpDown()
        Label76 = New Label()
        nudSinhala = New NumericUpDown()
        Label75 = New Label()
        pnlSummary = New Panel()
        btnGenerateSummary = New Button()
        dtpSummaryYear = New DateTimePicker()
        Label79 = New Label()
        tcMain.SuspendLayout()
        tpHSE.SuspendLayout()
        grpHSEFilter.SuspendLayout()
        CType(dgvHSE, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxHSE.SuspendLayout()
        CType(nudOtherWorkshop, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFireFighting, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFirstAid, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHSECount, ComponentModel.ISupportInitialize).BeginInit()
        tpSafety.SuspendLayout()
        grpSafetyFilter.SuspendLayout()
        CType(dgvSafety, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxSafety.SuspendLayout()
        CType(nudDeaths, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIllness, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudInjuries, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTotalAccidents, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNearMisses, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEnvironmental, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPropertyDamage, ComponentModel.ISupportInitialize).BeginInit()
        tpGrievances.SuspendLayout()
        grpGrievancesFilter.SuspendLayout()
        CType(dgvGrievances, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxGrievances.SuspendLayout()
        CType(nudUnresolvedGrievances, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTotalGrievances, ComponentModel.ISupportInitialize).BeginInit()
        tpSocial.SuspendLayout()
        grpSocialFilter.SuspendLayout()
        CType(dgvSocial, ComponentModel.ISupportInitialize).BeginInit()
        MainTabControl.SuspendLayout()
        tabBasicInfo.SuspendLayout()
        GroupBoxBasic.SuspendLayout()
        CType(nudAgeCount, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFemale, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMale, ComponentModel.ISupportInitialize).BeginInit()
        tabSkills.SuspendLayout()
        GroupBoxSkills.SuspendLayout()
        CType(nudNewToIndustry, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHiredQualified, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLearntAtNIRU, ComponentModel.ISupportInitialize).BeginInit()
        tabPromotions.SuspendLayout()
        GroupBoxPromotions.SuspendLayout()
        CType(nudSameFamily, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudInternalMobility, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPromotions, ComponentModel.ISupportInitialize).BeginInit()
        tabManagement.SuspendLayout()
        GroupBoxManagement.SuspendLayout()
        CType(nudMenLeadership, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudWomenLeadership, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMenUpper, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudWomenUpper, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMenMiddle, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudWomenMiddle, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMenFirstLine, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudWomenFirstLine, ComponentModel.ISupportInitialize).BeginInit()
        tabDisabilities.SuspendLayout()
        GroupBoxDisabilities.SuspendLayout()
        CType(nudChronic, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIntellectual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMentalHealth, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSensory, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPhysical, ComponentModel.ISupportInitialize).BeginInit()
        tabBehavior.SuspendLayout()
        GroupBoxBehavior.SuspendLayout()
        CType(nudPansexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAsexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBisexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudGay, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLesbian, ComponentModel.ISupportInitialize).BeginInit()
        tabIdentification.SuspendLayout()
        GroupBoxIdentification.SuspendLayout()
        CType(nudAgender, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNonBinary, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQuestioning, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQueer, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTransgender, ComponentModel.ISupportInitialize).BeginInit()
        tabNations.SuspendLayout()
        GroupBoxNations.SuspendLayout()
        CType(nudOtherEthnicity, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudEuropean, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPacificIslander, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMiddleEastern, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIndigenous, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHispanic, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAsian, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAfrican, ComponentModel.ISupportInitialize).BeginInit()
        tabReligions.SuspendLayout()
        GroupBoxReligions.SuspendLayout()
        CType(nudNoReligion, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOtherReligion, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSikhism, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudJudaism, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBuddhism, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHinduism, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIslam, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudChristianity, ComponentModel.ISupportInitialize).BeginInit()
        tabLanguages.SuspendLayout()
        GroupBoxLanguages.SuspendLayout()
        CType(nudHindi, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFrench, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHebrew, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSinhala, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummary.SuspendLayout()
        SuspendLayout()
        ' 
        ' tcMain
        ' 
        tcMain.Controls.Add(tpHSE)
        tcMain.Controls.Add(tpSafety)
        tcMain.Controls.Add(tpGrievances)
        tcMain.Controls.Add(tpSocial)
        tcMain.Dock = DockStyle.Fill
        tcMain.Location = New Point(0, 38)
        tcMain.Margin = New Padding(2)
        tcMain.Name = "tcMain"
        tcMain.SelectedIndex = 0
        tcMain.Size = New Size(1011, 524)
        tcMain.TabIndex = 0
        ' 
        ' tpHSE
        ' 
        tpHSE.Controls.Add(grpHSEFilter)
        tpHSE.Controls.Add(btnExportHSE)
        tpHSE.Controls.Add(btnLoadHSE)
        tpHSE.Controls.Add(btnSaveHSE)
        tpHSE.Controls.Add(dgvHSE)
        tpHSE.Controls.Add(GroupBoxHSE)
        tpHSE.Location = New Point(4, 24)
        tpHSE.Margin = New Padding(2)
        tpHSE.Name = "tpHSE"
        tpHSE.Padding = New Padding(2)
        tpHSE.Size = New Size(1003, 496)
        tpHSE.TabIndex = 0
        tpHSE.Text = "HSE Training"
        tpHSE.UseVisualStyleBackColor = True
        ' 
        ' grpHSEFilter
        ' 
        grpHSEFilter.Controls.Add(btnClearHSEFilter)
        grpHSEFilter.Controls.Add(btnApplyHSEFilter)
        grpHSEFilter.Controls.Add(dtpHSEFilterMonth)
        grpHSEFilter.Controls.Add(dtpHSEFilterYear)
        grpHSEFilter.Controls.Add(Label90)
        grpHSEFilter.Controls.Add(Label89)
        grpHSEFilter.Location = New Point(8, 150)
        grpHSEFilter.Margin = New Padding(2)
        grpHSEFilter.Name = "grpHSEFilter"
        grpHSEFilter.Padding = New Padding(2)
        grpHSEFilter.Size = New Size(989, 75)
        grpHSEFilter.TabIndex = 6
        grpHSEFilter.TabStop = False
        grpHSEFilter.Text = "Filter Data"
        ' 
        ' btnClearHSEFilter
        ' 
        btnClearHSEFilter.Location = New Point(304, 46)
        btnClearHSEFilter.Margin = New Padding(2)
        btnClearHSEFilter.Name = "btnClearHSEFilter"
        btnClearHSEFilter.Size = New Size(93, 22)
        btnClearHSEFilter.TabIndex = 5
        btnClearHSEFilter.Text = "Clear Filter"
        btnClearHSEFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyHSEFilter
        ' 
        btnApplyHSEFilter.BackColor = Color.LightBlue
        btnApplyHSEFilter.Location = New Point(195, 49)
        btnApplyHSEFilter.Margin = New Padding(2)
        btnApplyHSEFilter.Name = "btnApplyHSEFilter"
        btnApplyHSEFilter.Size = New Size(93, 22)
        btnApplyHSEFilter.TabIndex = 4
        btnApplyHSEFilter.Text = "Apply Filter"
        btnApplyHSEFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpHSEFilterMonth
        ' 
        dtpHSEFilterMonth.CustomFormat = "MMMM"
        dtpHSEFilterMonth.Format = DateTimePickerFormat.Custom
        dtpHSEFilterMonth.Location = New Point(350, 19)
        dtpHSEFilterMonth.Margin = New Padding(2)
        dtpHSEFilterMonth.Name = "dtpHSEFilterMonth"
        dtpHSEFilterMonth.Size = New Size(118, 23)
        dtpHSEFilterMonth.TabIndex = 3
        ' 
        ' dtpHSEFilterYear
        ' 
        dtpHSEFilterYear.CustomFormat = "yyyy"
        dtpHSEFilterYear.Format = DateTimePickerFormat.Custom
        dtpHSEFilterYear.Location = New Point(156, 19)
        dtpHSEFilterYear.Margin = New Padding(2)
        dtpHSEFilterYear.Name = "dtpHSEFilterYear"
        dtpHSEFilterYear.ShowUpDown = True
        dtpHSEFilterYear.Size = New Size(79, 23)
        dtpHSEFilterYear.TabIndex = 2
        ' 
        ' Label90
        ' 
        Label90.AutoSize = True
        Label90.Location = New Point(280, 22)
        Label90.Margin = New Padding(2, 0, 2, 0)
        Label90.Name = "Label90"
        Label90.Size = New Size(46, 15)
        Label90.TabIndex = 1
        Label90.Text = "Month:"
        ' 
        ' Label89
        ' 
        Label89.AutoSize = True
        Label89.Location = New Point(86, 22)
        Label89.Margin = New Padding(2, 0, 2, 0)
        Label89.Name = "Label89"
        Label89.Size = New Size(32, 15)
        Label89.TabIndex = 0
        Label89.Text = "Year:"
        ' 
        ' btnExportHSE
        ' 
        btnExportHSE.BackColor = Color.LightBlue
        btnExportHSE.Location = New Point(770, 502)
        btnExportHSE.Margin = New Padding(2)
        btnExportHSE.Name = "btnExportHSE"
        btnExportHSE.Size = New Size(93, 22)
        btnExportHSE.TabIndex = 5
        btnExportHSE.Text = "Export to Excel"
        btnExportHSE.UseVisualStyleBackColor = False
        ' 
        ' btnLoadHSE
        ' 
        btnLoadHSE.Location = New Point(671, 502)
        btnLoadHSE.Margin = New Padding(2)
        btnLoadHSE.Name = "btnLoadHSE"
        btnLoadHSE.Size = New Size(93, 22)
        btnLoadHSE.TabIndex = 4
        btnLoadHSE.Text = "Load Data"
        btnLoadHSE.UseVisualStyleBackColor = True
        ' 
        ' btnSaveHSE
        ' 
        btnSaveHSE.BackColor = Color.LightGreen
        btnSaveHSE.Location = New Point(572, 502)
        btnSaveHSE.Margin = New Padding(2)
        btnSaveHSE.Name = "btnSaveHSE"
        btnSaveHSE.Size = New Size(93, 22)
        btnSaveHSE.TabIndex = 3
        btnSaveHSE.Text = "Save Data"
        btnSaveHSE.UseVisualStyleBackColor = False
        ' 
        ' dgvHSE
        ' 
        dgvHSE.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHSE.Location = New Point(8, 232)
        dgvHSE.Margin = New Padding(2)
        dgvHSE.Name = "dgvHSE"
        dgvHSE.RowHeadersWidth = 62
        dgvHSE.Size = New Size(989, 224)
        dgvHSE.TabIndex = 2
        ' 
        ' GroupBoxHSE
        ' 
        GroupBoxHSE.Controls.Add(txtOtherWorkshopName)
        GroupBoxHSE.Controls.Add(Label6)
        GroupBoxHSE.Controls.Add(nudOtherWorkshop)
        GroupBoxHSE.Controls.Add(Label5)
        GroupBoxHSE.Controls.Add(nudFireFighting)
        GroupBoxHSE.Controls.Add(Label4)
        GroupBoxHSE.Controls.Add(nudFirstAid)
        GroupBoxHSE.Controls.Add(Label3)
        GroupBoxHSE.Controls.Add(nudHSECount)
        GroupBoxHSE.Controls.Add(Label2)
        GroupBoxHSE.Controls.Add(dtpHSE)
        GroupBoxHSE.Controls.Add(Label1)
        GroupBoxHSE.Location = New Point(8, 8)
        GroupBoxHSE.Margin = New Padding(2)
        GroupBoxHSE.Name = "GroupBoxHSE"
        GroupBoxHSE.Padding = New Padding(2)
        GroupBoxHSE.Size = New Size(989, 135)
        GroupBoxHSE.TabIndex = 1
        GroupBoxHSE.TabStop = False
        GroupBoxHSE.Text = "HSE Training Data Entry"
        ' 
        ' txtOtherWorkshopName
        ' 
        txtOtherWorkshopName.Location = New Point(661, 86)
        txtOtherWorkshopName.Margin = New Padding(2)
        txtOtherWorkshopName.Name = "txtOtherWorkshopName"
        txtOtherWorkshopName.Size = New Size(156, 23)
        txtOtherWorkshopName.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(529, 88)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 15)
        Label6.TabIndex = 10
        Label6.Text = "Other Workshop Name:"
        ' 
        ' nudOtherWorkshop
        ' 
        nudOtherWorkshop.Location = New Point(404, 86)
        nudOtherWorkshop.Margin = New Padding(2)
        nudOtherWorkshop.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherWorkshop.Name = "nudOtherWorkshop"
        nudOtherWorkshop.Size = New Size(117, 23)
        nudOtherWorkshop.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(257, 88)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(156, 15)
        Label5.TabIndex = 8
        Label5.Text = "Other Awareness Workshop:"
        ' 
        ' nudFireFighting
        ' 
        nudFireFighting.Location = New Point(404, 56)
        nudFireFighting.Margin = New Padding(2)
        nudFireFighting.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFireFighting.Name = "nudFireFighting"
        nudFireFighting.Size = New Size(117, 23)
        nudFireFighting.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(257, 58)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 15)
        Label4.TabIndex = 6
        Label4.Text = "Fire Fighting Class/Workshop:"
        ' 
        ' nudFirstAid
        ' 
        nudFirstAid.Location = New Point(109, 86)
        nudFirstAid.Margin = New Padding(2)
        nudFirstAid.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFirstAid.Name = "nudFirstAid"
        nudFirstAid.Size = New Size(117, 23)
        nudFirstAid.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 88)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 4
        Label3.Text = "First-Aid Class:"
        ' 
        ' nudHSECount
        ' 
        nudHSECount.Location = New Point(109, 56)
        nudHSECount.Margin = New Padding(2)
        nudHSECount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHSECount.Name = "nudHSECount"
        nudHSECount.Size = New Size(117, 23)
        nudHSECount.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 58)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 2
        Label2.Text = "HSE Training:"
        ' 
        ' dtpHSE
        ' 
        dtpHSE.CustomFormat = "MMMM yyyy"
        dtpHSE.Format = DateTimePickerFormat.Custom
        dtpHSE.Location = New Point(109, 22)
        dtpHSE.Margin = New Padding(2)
        dtpHSE.Name = "dtpHSE"
        dtpHSE.Size = New Size(156, 23)
        dtpHSE.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 26)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Reporting Date:"
        ' 
        ' tpSafety
        ' 
        tpSafety.Controls.Add(grpSafetyFilter)
        tpSafety.Controls.Add(btnExportSafety)
        tpSafety.Controls.Add(btnLoadSafety)
        tpSafety.Controls.Add(btnSaveSafety)
        tpSafety.Controls.Add(dgvSafety)
        tpSafety.Controls.Add(GroupBoxSafety)
        tpSafety.Location = New Point(4, 24)
        tpSafety.Margin = New Padding(2)
        tpSafety.Name = "tpSafety"
        tpSafety.Padding = New Padding(2)
        tpSafety.Size = New Size(1003, 496)
        tpSafety.TabIndex = 1
        tpSafety.Text = "Safety Incidents"
        tpSafety.UseVisualStyleBackColor = True
        ' 
        ' grpSafetyFilter
        ' 
        grpSafetyFilter.Controls.Add(btnClearSafetyFilter)
        grpSafetyFilter.Controls.Add(btnApplySafetyFilter)
        grpSafetyFilter.Controls.Add(dtpSafetyFilterMonth)
        grpSafetyFilter.Controls.Add(dtpSafetyFilterYear)
        grpSafetyFilter.Controls.Add(Label92)
        grpSafetyFilter.Controls.Add(Label91)
        grpSafetyFilter.Location = New Point(8, 188)
        grpSafetyFilter.Margin = New Padding(2)
        grpSafetyFilter.Name = "grpSafetyFilter"
        grpSafetyFilter.Padding = New Padding(2)
        grpSafetyFilter.Size = New Size(989, 60)
        grpSafetyFilter.TabIndex = 6
        grpSafetyFilter.TabStop = False
        grpSafetyFilter.Text = "Filter Data"
        ' 
        ' btnClearSafetyFilter
        ' 
        btnClearSafetyFilter.Location = New Point(652, 22)
        btnClearSafetyFilter.Margin = New Padding(2)
        btnClearSafetyFilter.Name = "btnClearSafetyFilter"
        btnClearSafetyFilter.Size = New Size(93, 22)
        btnClearSafetyFilter.TabIndex = 5
        btnClearSafetyFilter.Text = "Clear Filter"
        btnClearSafetyFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplySafetyFilter
        ' 
        btnApplySafetyFilter.BackColor = Color.LightBlue
        btnApplySafetyFilter.Location = New Point(555, 22)
        btnApplySafetyFilter.Margin = New Padding(2)
        btnApplySafetyFilter.Name = "btnApplySafetyFilter"
        btnApplySafetyFilter.Size = New Size(93, 22)
        btnApplySafetyFilter.TabIndex = 4
        btnApplySafetyFilter.Text = "Apply Filter"
        btnApplySafetyFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpSafetyFilterMonth
        ' 
        dtpSafetyFilterMonth.CustomFormat = "MMMM"
        dtpSafetyFilterMonth.Format = DateTimePickerFormat.Custom
        dtpSafetyFilterMonth.Location = New Point(350, 19)
        dtpSafetyFilterMonth.Margin = New Padding(2)
        dtpSafetyFilterMonth.Name = "dtpSafetyFilterMonth"
        dtpSafetyFilterMonth.Size = New Size(118, 23)
        dtpSafetyFilterMonth.TabIndex = 3
        ' 
        ' dtpSafetyFilterYear
        ' 
        dtpSafetyFilterYear.CustomFormat = "yyyy"
        dtpSafetyFilterYear.Format = DateTimePickerFormat.Custom
        dtpSafetyFilterYear.Location = New Point(156, 19)
        dtpSafetyFilterYear.Margin = New Padding(2)
        dtpSafetyFilterYear.Name = "dtpSafetyFilterYear"
        dtpSafetyFilterYear.ShowUpDown = True
        dtpSafetyFilterYear.Size = New Size(79, 23)
        dtpSafetyFilterYear.TabIndex = 2
        ' 
        ' Label92
        ' 
        Label92.AutoSize = True
        Label92.Location = New Point(280, 22)
        Label92.Margin = New Padding(2, 0, 2, 0)
        Label92.Name = "Label92"
        Label92.Size = New Size(46, 15)
        Label92.TabIndex = 1
        Label92.Text = "Month:"
        ' 
        ' Label91
        ' 
        Label91.AutoSize = True
        Label91.Location = New Point(86, 22)
        Label91.Margin = New Padding(2, 0, 2, 0)
        Label91.Name = "Label91"
        Label91.Size = New Size(32, 15)
        Label91.TabIndex = 0
        Label91.Text = "Year:"
        ' 
        ' btnExportSafety
        ' 
        btnExportSafety.BackColor = Color.LightBlue
        btnExportSafety.Location = New Point(770, 502)
        btnExportSafety.Margin = New Padding(2)
        btnExportSafety.Name = "btnExportSafety"
        btnExportSafety.Size = New Size(93, 22)
        btnExportSafety.TabIndex = 5
        btnExportSafety.Text = "Export to Excel"
        btnExportSafety.UseVisualStyleBackColor = False
        ' 
        ' btnLoadSafety
        ' 
        btnLoadSafety.Location = New Point(671, 502)
        btnLoadSafety.Margin = New Padding(2)
        btnLoadSafety.Name = "btnLoadSafety"
        btnLoadSafety.Size = New Size(93, 22)
        btnLoadSafety.TabIndex = 4
        btnLoadSafety.Text = "Load Data"
        btnLoadSafety.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSafety
        ' 
        btnSaveSafety.BackColor = Color.LightGreen
        btnSaveSafety.Location = New Point(572, 502)
        btnSaveSafety.Margin = New Padding(2)
        btnSaveSafety.Name = "btnSaveSafety"
        btnSaveSafety.Size = New Size(93, 22)
        btnSaveSafety.TabIndex = 3
        btnSaveSafety.Text = "Save Data"
        btnSaveSafety.UseVisualStyleBackColor = False
        ' 
        ' dgvSafety
        ' 
        dgvSafety.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSafety.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSafety.Location = New Point(8, 255)
        dgvSafety.Margin = New Padding(2)
        dgvSafety.Name = "dgvSafety"
        dgvSafety.RowHeadersWidth = 62
        dgvSafety.Size = New Size(989, 202)
        dgvSafety.TabIndex = 2
        ' 
        ' GroupBoxSafety
        ' 
        GroupBoxSafety.Controls.Add(nudDeaths)
        GroupBoxSafety.Controls.Add(Label14)
        GroupBoxSafety.Controls.Add(nudIllness)
        GroupBoxSafety.Controls.Add(Label13)
        GroupBoxSafety.Controls.Add(nudInjuries)
        GroupBoxSafety.Controls.Add(Label12)
        GroupBoxSafety.Controls.Add(nudTotalAccidents)
        GroupBoxSafety.Controls.Add(Label11)
        GroupBoxSafety.Controls.Add(nudNearMisses)
        GroupBoxSafety.Controls.Add(Label10)
        GroupBoxSafety.Controls.Add(nudEnvironmental)
        GroupBoxSafety.Controls.Add(Label9)
        GroupBoxSafety.Controls.Add(nudPropertyDamage)
        GroupBoxSafety.Controls.Add(Label8)
        GroupBoxSafety.Controls.Add(dtpSafety)
        GroupBoxSafety.Controls.Add(Label7)
        GroupBoxSafety.Location = New Point(8, 8)
        GroupBoxSafety.Margin = New Padding(2)
        GroupBoxSafety.Name = "GroupBoxSafety"
        GroupBoxSafety.Padding = New Padding(2)
        GroupBoxSafety.Size = New Size(989, 172)
        GroupBoxSafety.TabIndex = 1
        GroupBoxSafety.TabStop = False
        GroupBoxSafety.Text = "Safety Incidents Data Entry"
        ' 
        ' nudDeaths
        ' 
        nudDeaths.Location = New Point(700, 131)
        nudDeaths.Margin = New Padding(2)
        nudDeaths.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudDeaths.Name = "nudDeaths"
        nudDeaths.Size = New Size(117, 23)
        nudDeaths.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(544, 134)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(157, 15)
        Label14.TabIndex = 14
        Label14.Text = "Accidents Resulted in Death:"
        ' 
        ' nudIllness
        ' 
        nudIllness.Location = New Point(700, 101)
        nudIllness.Margin = New Padding(2)
        nudIllness.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIllness.Name = "nudIllness"
        nudIllness.Size = New Size(117, 23)
        nudIllness.TabIndex = 13
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(544, 104)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(158, 15)
        Label13.TabIndex = 12
        Label13.Text = "Accidents Resulted in Illness:"
        ' 
        ' nudInjuries
        ' 
        nudInjuries.Location = New Point(700, 71)
        nudInjuries.Margin = New Padding(2)
        nudInjuries.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudInjuries.Name = "nudInjuries"
        nudInjuries.Size = New Size(117, 23)
        nudInjuries.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(544, 74)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(164, 15)
        Label12.TabIndex = 10
        Label12.Text = "Accidents Resulted in Injuries:"
        ' 
        ' nudTotalAccidents
        ' 
        nudTotalAccidents.Location = New Point(700, 41)
        nudTotalAccidents.Margin = New Padding(2)
        nudTotalAccidents.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTotalAccidents.Name = "nudTotalAccidents"
        nudTotalAccidents.Size = New Size(117, 23)
        nudTotalAccidents.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(544, 44)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 8
        Label11.Text = "Total Accidents:"
        ' 
        ' nudNearMisses
        ' 
        nudNearMisses.Location = New Point(233, 131)
        nudNearMisses.Margin = New Padding(2)
        nudNearMisses.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNearMisses.Name = "nudNearMisses"
        nudNearMisses.Size = New Size(117, 23)
        nudNearMisses.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(78, 134)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 15)
        Label10.TabIndex = 6
        Label10.Text = "Near Misses:"
        ' 
        ' nudEnvironmental
        ' 
        nudEnvironmental.Location = New Point(233, 101)
        nudEnvironmental.Margin = New Padding(2)
        nudEnvironmental.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudEnvironmental.Name = "nudEnvironmental"
        nudEnvironmental.Size = New Size(117, 23)
        nudEnvironmental.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(78, 104)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 15)
        Label9.TabIndex = 4
        Label9.Text = "Environmental Incidents:"
        ' 
        ' nudPropertyDamage
        ' 
        nudPropertyDamage.Location = New Point(233, 71)
        nudPropertyDamage.Margin = New Padding(2)
        nudPropertyDamage.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPropertyDamage.Name = "nudPropertyDamage"
        nudPropertyDamage.Size = New Size(117, 23)
        nudPropertyDamage.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(78, 74)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 15)
        Label8.TabIndex = 2
        Label8.Text = "Property Damage Incidents:"
        ' 
        ' dtpSafety
        ' 
        dtpSafety.CustomFormat = "MMMM yyyy"
        dtpSafety.Format = DateTimePickerFormat.Custom
        dtpSafety.Location = New Point(109, 22)
        dtpSafety.Margin = New Padding(2)
        dtpSafety.Name = "dtpSafety"
        dtpSafety.Size = New Size(156, 23)
        dtpSafety.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 26)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 0
        Label7.Text = "Reporting Date:"
        ' 
        ' tpGrievances
        ' 
        tpGrievances.Controls.Add(grpGrievancesFilter)
        tpGrievances.Controls.Add(btnExportGrievances)
        tpGrievances.Controls.Add(btnLoadGrievances)
        tpGrievances.Controls.Add(btnSaveGrievances)
        tpGrievances.Controls.Add(dgvGrievances)
        tpGrievances.Controls.Add(GroupBoxGrievances)
        tpGrievances.Location = New Point(4, 24)
        tpGrievances.Margin = New Padding(2)
        tpGrievances.Name = "tpGrievances"
        tpGrievances.Size = New Size(1003, 496)
        tpGrievances.TabIndex = 2
        tpGrievances.Text = "Grievances"
        tpGrievances.UseVisualStyleBackColor = True
        ' 
        ' grpGrievancesFilter
        ' 
        grpGrievancesFilter.Controls.Add(btnClearGrievancesFilter)
        grpGrievancesFilter.Controls.Add(btnApplyGrievancesFilter)
        grpGrievancesFilter.Controls.Add(dtpGrievancesFilterMonth)
        grpGrievancesFilter.Controls.Add(dtpGrievancesFilterYear)
        grpGrievancesFilter.Controls.Add(Label94)
        grpGrievancesFilter.Controls.Add(Label93)
        grpGrievancesFilter.Location = New Point(8, 150)
        grpGrievancesFilter.Margin = New Padding(2)
        grpGrievancesFilter.Name = "grpGrievancesFilter"
        grpGrievancesFilter.Padding = New Padding(2)
        grpGrievancesFilter.Size = New Size(989, 75)
        grpGrievancesFilter.TabIndex = 6
        grpGrievancesFilter.TabStop = False
        grpGrievancesFilter.Text = "Filter Data"
        ' 
        ' btnClearGrievancesFilter
        ' 
        btnClearGrievancesFilter.Location = New Point(582, 22)
        btnClearGrievancesFilter.Margin = New Padding(2)
        btnClearGrievancesFilter.Name = "btnClearGrievancesFilter"
        btnClearGrievancesFilter.Size = New Size(93, 22)
        btnClearGrievancesFilter.TabIndex = 5
        btnClearGrievancesFilter.Text = "Clear Filter"
        btnClearGrievancesFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyGrievancesFilter
        ' 
        btnApplyGrievancesFilter.BackColor = Color.LightBlue
        btnApplyGrievancesFilter.Location = New Point(481, 22)
        btnApplyGrievancesFilter.Margin = New Padding(2)
        btnApplyGrievancesFilter.Name = "btnApplyGrievancesFilter"
        btnApplyGrievancesFilter.Size = New Size(93, 22)
        btnApplyGrievancesFilter.TabIndex = 4
        btnApplyGrievancesFilter.Text = "Apply Filter"
        btnApplyGrievancesFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpGrievancesFilterMonth
        ' 
        dtpGrievancesFilterMonth.CustomFormat = "MMMM"
        dtpGrievancesFilterMonth.Format = DateTimePickerFormat.Custom
        dtpGrievancesFilterMonth.Location = New Point(350, 19)
        dtpGrievancesFilterMonth.Margin = New Padding(2)
        dtpGrievancesFilterMonth.Name = "dtpGrievancesFilterMonth"
        dtpGrievancesFilterMonth.Size = New Size(118, 23)
        dtpGrievancesFilterMonth.TabIndex = 3
        ' 
        ' dtpGrievancesFilterYear
        ' 
        dtpGrievancesFilterYear.CustomFormat = "yyyy"
        dtpGrievancesFilterYear.Format = DateTimePickerFormat.Custom
        dtpGrievancesFilterYear.Location = New Point(156, 19)
        dtpGrievancesFilterYear.Margin = New Padding(2)
        dtpGrievancesFilterYear.Name = "dtpGrievancesFilterYear"
        dtpGrievancesFilterYear.ShowUpDown = True
        dtpGrievancesFilterYear.Size = New Size(79, 23)
        dtpGrievancesFilterYear.TabIndex = 2
        ' 
        ' Label94
        ' 
        Label94.AutoSize = True
        Label94.Location = New Point(280, 22)
        Label94.Margin = New Padding(2, 0, 2, 0)
        Label94.Name = "Label94"
        Label94.Size = New Size(46, 15)
        Label94.TabIndex = 1
        Label94.Text = "Month:"
        ' 
        ' Label93
        ' 
        Label93.AutoSize = True
        Label93.Location = New Point(86, 22)
        Label93.Margin = New Padding(2, 0, 2, 0)
        Label93.Name = "Label93"
        Label93.Size = New Size(32, 15)
        Label93.TabIndex = 0
        Label93.Text = "Year:"
        ' 
        ' btnExportGrievances
        ' 
        btnExportGrievances.BackColor = Color.LightBlue
        btnExportGrievances.Location = New Point(770, 502)
        btnExportGrievances.Margin = New Padding(2)
        btnExportGrievances.Name = "btnExportGrievances"
        btnExportGrievances.Size = New Size(93, 22)
        btnExportGrievances.TabIndex = 5
        btnExportGrievances.Text = "Export to Excel"
        btnExportGrievances.UseVisualStyleBackColor = False
        ' 
        ' btnLoadGrievances
        ' 
        btnLoadGrievances.Location = New Point(671, 502)
        btnLoadGrievances.Margin = New Padding(2)
        btnLoadGrievances.Name = "btnLoadGrievances"
        btnLoadGrievances.Size = New Size(93, 22)
        btnLoadGrievances.TabIndex = 4
        btnLoadGrievances.Text = "Load Data"
        btnLoadGrievances.UseVisualStyleBackColor = True
        ' 
        ' btnSaveGrievances
        ' 
        btnSaveGrievances.BackColor = Color.LightGreen
        btnSaveGrievances.Location = New Point(572, 502)
        btnSaveGrievances.Margin = New Padding(2)
        btnSaveGrievances.Name = "btnSaveGrievances"
        btnSaveGrievances.Size = New Size(93, 22)
        btnSaveGrievances.TabIndex = 3
        btnSaveGrievances.Text = "Save Data"
        btnSaveGrievances.UseVisualStyleBackColor = False
        ' 
        ' dgvGrievances
        ' 
        dgvGrievances.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvGrievances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGrievances.Location = New Point(8, 232)
        dgvGrievances.Margin = New Padding(2)
        dgvGrievances.Name = "dgvGrievances"
        dgvGrievances.RowHeadersWidth = 62
        dgvGrievances.Size = New Size(989, 224)
        dgvGrievances.TabIndex = 2
        ' 
        ' GroupBoxGrievances
        ' 
        GroupBoxGrievances.Controls.Add(nudUnresolvedGrievances)
        GroupBoxGrievances.Controls.Add(Label16)
        GroupBoxGrievances.Controls.Add(nudTotalGrievances)
        GroupBoxGrievances.Controls.Add(Label15)
        GroupBoxGrievances.Controls.Add(dtpGrievances)
        GroupBoxGrievances.Controls.Add(Label17)
        GroupBoxGrievances.Location = New Point(8, 8)
        GroupBoxGrievances.Margin = New Padding(2)
        GroupBoxGrievances.Name = "GroupBoxGrievances"
        GroupBoxGrievances.Padding = New Padding(2)
        GroupBoxGrievances.Size = New Size(989, 135)
        GroupBoxGrievances.TabIndex = 1
        GroupBoxGrievances.TabStop = False
        GroupBoxGrievances.Text = "Grievances Data Entry"
        ' 
        ' nudUnresolvedGrievances
        ' 
        nudUnresolvedGrievances.Location = New Point(272, 86)
        nudUnresolvedGrievances.Margin = New Padding(2)
        nudUnresolvedGrievances.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudUnresolvedGrievances.Name = "nudUnresolvedGrievances"
        nudUnresolvedGrievances.Size = New Size(156, 23)
        nudUnresolvedGrievances.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(109, 88)
        Label16.Margin = New Padding(2, 0, 2, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(184, 15)
        Label16.TabIndex = 4
        Label16.Text = "Unresolved Employee Grievances:"
        ' 
        ' nudTotalGrievances
        ' 
        nudTotalGrievances.Location = New Point(272, 56)
        nudTotalGrievances.Margin = New Padding(2)
        nudTotalGrievances.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTotalGrievances.Name = "nudTotalGrievances"
        nudTotalGrievances.Size = New Size(156, 23)
        nudTotalGrievances.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(109, 58)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(151, 15)
        Label15.TabIndex = 2
        Label15.Text = "Total Employee Grievances:"
        ' 
        ' dtpGrievances
        ' 
        dtpGrievances.CustomFormat = "MMMM yyyy"
        dtpGrievances.Format = DateTimePickerFormat.Custom
        dtpGrievances.Location = New Point(109, 22)
        dtpGrievances.Margin = New Padding(2)
        dtpGrievances.Name = "dtpGrievances"
        dtpGrievances.Size = New Size(156, 23)
        dtpGrievances.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(16, 26)
        Label17.Margin = New Padding(2, 0, 2, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(89, 15)
        Label17.TabIndex = 0
        Label17.Text = "Reporting Date:"
        ' 
        ' tpSocial
        ' 
        tpSocial.Controls.Add(grpSocialFilter)
        tpSocial.Controls.Add(btnExportSocial)
        tpSocial.Controls.Add(btnLoadSocial)
        tpSocial.Controls.Add(btnSaveSocial)
        tpSocial.Controls.Add(dgvSocial)
        tpSocial.Controls.Add(MainTabControl)
        tpSocial.Location = New Point(4, 24)
        tpSocial.Margin = New Padding(2)
        tpSocial.Name = "tpSocial"
        tpSocial.Size = New Size(1003, 496)
        tpSocial.TabIndex = 3
        tpSocial.Text = "Social Data"
        tpSocial.UseVisualStyleBackColor = True
        ' 
        ' grpSocialFilter
        ' 
        grpSocialFilter.Controls.Add(btnClearSocialFilter)
        grpSocialFilter.Controls.Add(btnApplySocialFilter)
        grpSocialFilter.Controls.Add(dtpSocialFilterMonth)
        grpSocialFilter.Controls.Add(dtpSocialFilterYear)
        grpSocialFilter.Controls.Add(Label96)
        grpSocialFilter.Controls.Add(Label95)
        grpSocialFilter.Location = New Point(8, 338)
        grpSocialFilter.Margin = New Padding(2)
        grpSocialFilter.Name = "grpSocialFilter"
        grpSocialFilter.Padding = New Padding(2)
        grpSocialFilter.Size = New Size(989, 56)
        grpSocialFilter.TabIndex = 9
        grpSocialFilter.TabStop = False
        grpSocialFilter.Text = "Filter Data"
        ' 
        ' btnClearSocialFilter
        ' 
        btnClearSocialFilter.Location = New Point(601, 21)
        btnClearSocialFilter.Margin = New Padding(2)
        btnClearSocialFilter.Name = "btnClearSocialFilter"
        btnClearSocialFilter.Size = New Size(93, 22)
        btnClearSocialFilter.TabIndex = 5
        btnClearSocialFilter.Text = "Clear Filter"
        btnClearSocialFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplySocialFilter
        ' 
        btnApplySocialFilter.BackColor = Color.LightBlue
        btnApplySocialFilter.Location = New Point(500, 21)
        btnApplySocialFilter.Margin = New Padding(2)
        btnApplySocialFilter.Name = "btnApplySocialFilter"
        btnApplySocialFilter.Size = New Size(93, 22)
        btnApplySocialFilter.TabIndex = 4
        btnApplySocialFilter.Text = "Apply Filter"
        btnApplySocialFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpSocialFilterMonth
        ' 
        dtpSocialFilterMonth.CustomFormat = "MMMM"
        dtpSocialFilterMonth.Format = DateTimePickerFormat.Custom
        dtpSocialFilterMonth.Location = New Point(350, 19)
        dtpSocialFilterMonth.Margin = New Padding(2)
        dtpSocialFilterMonth.Name = "dtpSocialFilterMonth"
        dtpSocialFilterMonth.Size = New Size(118, 23)
        dtpSocialFilterMonth.TabIndex = 3
        ' 
        ' dtpSocialFilterYear
        ' 
        dtpSocialFilterYear.CustomFormat = "yyyy"
        dtpSocialFilterYear.Format = DateTimePickerFormat.Custom
        dtpSocialFilterYear.Location = New Point(156, 19)
        dtpSocialFilterYear.Margin = New Padding(2)
        dtpSocialFilterYear.Name = "dtpSocialFilterYear"
        dtpSocialFilterYear.ShowUpDown = True
        dtpSocialFilterYear.Size = New Size(79, 23)
        dtpSocialFilterYear.TabIndex = 2
        ' 
        ' Label96
        ' 
        Label96.AutoSize = True
        Label96.Location = New Point(280, 22)
        Label96.Margin = New Padding(2, 0, 2, 0)
        Label96.Name = "Label96"
        Label96.Size = New Size(46, 15)
        Label96.TabIndex = 1
        Label96.Text = "Month:"
        ' 
        ' Label95
        ' 
        Label95.AutoSize = True
        Label95.Location = New Point(86, 22)
        Label95.Margin = New Padding(2, 0, 2, 0)
        Label95.Name = "Label95"
        Label95.Size = New Size(32, 15)
        Label95.TabIndex = 0
        Label95.Text = "Year:"
        ' 
        ' btnExportSocial
        ' 
        btnExportSocial.BackColor = Color.LightBlue
        btnExportSocial.Location = New Point(770, 510)
        btnExportSocial.Margin = New Padding(2)
        btnExportSocial.Name = "btnExportSocial"
        btnExportSocial.Size = New Size(93, 22)
        btnExportSocial.TabIndex = 8
        btnExportSocial.Text = "Export to Excel"
        btnExportSocial.UseVisualStyleBackColor = False
        ' 
        ' btnLoadSocial
        ' 
        btnLoadSocial.Location = New Point(671, 510)
        btnLoadSocial.Margin = New Padding(2)
        btnLoadSocial.Name = "btnLoadSocial"
        btnLoadSocial.Size = New Size(93, 22)
        btnLoadSocial.TabIndex = 7
        btnLoadSocial.Text = "Load Data"
        btnLoadSocial.UseVisualStyleBackColor = True
        ' 
        ' btnSaveSocial
        ' 
        btnSaveSocial.BackColor = Color.LightGreen
        btnSaveSocial.Location = New Point(572, 510)
        btnSaveSocial.Margin = New Padding(2)
        btnSaveSocial.Name = "btnSaveSocial"
        btnSaveSocial.Size = New Size(93, 22)
        btnSaveSocial.TabIndex = 6
        btnSaveSocial.Text = "Save Data"
        btnSaveSocial.UseVisualStyleBackColor = False
        ' 
        ' dgvSocial
        ' 
        dgvSocial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSocial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocial.Location = New Point(8, 398)
        dgvSocial.Margin = New Padding(2)
        dgvSocial.Name = "dgvSocial"
        dgvSocial.RowHeadersWidth = 62
        dgvSocial.Size = New Size(989, 91)
        dgvSocial.TabIndex = 5
        ' 
        ' MainTabControl
        ' 
        MainTabControl.Controls.Add(tabBasicInfo)
        MainTabControl.Controls.Add(tabSkills)
        MainTabControl.Controls.Add(tabPromotions)
        MainTabControl.Controls.Add(tabManagement)
        MainTabControl.Controls.Add(tabDisabilities)
        MainTabControl.Controls.Add(tabBehavior)
        MainTabControl.Controls.Add(tabIdentification)
        MainTabControl.Controls.Add(tabNations)
        MainTabControl.Controls.Add(tabReligions)
        MainTabControl.Controls.Add(tabLanguages)
        MainTabControl.Location = New Point(8, 8)
        MainTabControl.Margin = New Padding(2)
        MainTabControl.Name = "MainTabControl"
        MainTabControl.SelectedIndex = 0
        MainTabControl.Size = New Size(989, 322)
        MainTabControl.TabIndex = 4
        ' 
        ' tabBasicInfo
        ' 
        tabBasicInfo.Controls.Add(GroupBoxBasic)
        tabBasicInfo.Location = New Point(4, 24)
        tabBasicInfo.Margin = New Padding(2)
        tabBasicInfo.Name = "tabBasicInfo"
        tabBasicInfo.Padding = New Padding(2)
        tabBasicInfo.Size = New Size(981, 294)
        tabBasicInfo.TabIndex = 0
        tabBasicInfo.Text = "Basic Info & Age"
        tabBasicInfo.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxBasic
        ' 
        GroupBoxBasic.Controls.Add(btnDeleteAgeCategory)
        GroupBoxBasic.Controls.Add(lstAgeCategories)
        GroupBoxBasic.Controls.Add(btnAddAge)
        GroupBoxBasic.Controls.Add(nudAgeCount)
        GroupBoxBasic.Controls.Add(cboAgeCategory)
        GroupBoxBasic.Controls.Add(Label23)
        GroupBoxBasic.Controls.Add(Label22)
        GroupBoxBasic.Controls.Add(nudFemale)
        GroupBoxBasic.Controls.Add(Label21)
        GroupBoxBasic.Controls.Add(nudMale)
        GroupBoxBasic.Controls.Add(Label20)
        GroupBoxBasic.Controls.Add(dtpSocial)
        GroupBoxBasic.Controls.Add(Label19)
        GroupBoxBasic.Location = New Point(16, 15)
        GroupBoxBasic.Margin = New Padding(2)
        GroupBoxBasic.Name = "GroupBoxBasic"
        GroupBoxBasic.Padding = New Padding(2)
        GroupBoxBasic.Size = New Size(778, 270)
        GroupBoxBasic.TabIndex = 0
        GroupBoxBasic.TabStop = False
        GroupBoxBasic.Text = "Basic Information"
        ' 
        ' btnDeleteAgeCategory
        ' 
        btnDeleteAgeCategory.BackColor = Color.LightCoral
        btnDeleteAgeCategory.Location = New Point(273, 173)
        btnDeleteAgeCategory.Margin = New Padding(2)
        btnDeleteAgeCategory.Name = "btnDeleteAgeCategory"
        btnDeleteAgeCategory.Size = New Size(78, 26)
        btnDeleteAgeCategory.TabIndex = 16
        btnDeleteAgeCategory.Text = "Delete Selected"
        btnDeleteAgeCategory.UseVisualStyleBackColor = False
        ' 
        ' lstAgeCategories
        ' 
        lstAgeCategories.FormattingEnabled = True
        lstAgeCategories.ItemHeight = 15
        lstAgeCategories.Location = New Point(102, 173)
        lstAgeCategories.Margin = New Padding(2)
        lstAgeCategories.Name = "lstAgeCategories"
        lstAgeCategories.Size = New Size(163, 64)
        lstAgeCategories.TabIndex = 15
        ' 
        ' btnAddAge
        ' 
        btnAddAge.Location = New Point(429, 134)
        btnAddAge.Margin = New Padding(2)
        btnAddAge.Name = "btnAddAge"
        btnAddAge.Size = New Size(83, 23)
        btnAddAge.TabIndex = 14
        btnAddAge.Text = "Add"
        btnAddAge.UseVisualStyleBackColor = True
        ' 
        ' nudAgeCount
        ' 
        nudAgeCount.Location = New Point(273, 134)
        nudAgeCount.Margin = New Padding(2)
        nudAgeCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAgeCount.Name = "nudAgeCount"
        nudAgeCount.Size = New Size(140, 23)
        nudAgeCount.TabIndex = 13
        ' 
        ' cboAgeCategory
        ' 
        cboAgeCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboAgeCategory.FormattingEnabled = True
        cboAgeCategory.Items.AddRange(New Object() {"17 years old or less", "Between 18 and 30 years old", "Between 31 and 50 years old", "50 years old or above"})
        cboAgeCategory.Location = New Point(102, 133)
        cboAgeCategory.Margin = New Padding(2)
        cboAgeCategory.Name = "cboAgeCategory"
        cboAgeCategory.Size = New Size(156, 23)
        cboAgeCategory.TabIndex = 12
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(16, 136)
        Label23.Margin = New Padding(2, 0, 2, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(82, 15)
        Label23.TabIndex = 11
        Label23.Text = "Age Category:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(25, 94)
        Label22.Margin = New Padding(2, 0, 2, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(48, 15)
        Label22.TabIndex = 10
        Label22.Text = "Female:"
        ' 
        ' nudFemale
        ' 
        nudFemale.Location = New Point(118, 90)
        nudFemale.Margin = New Padding(2)
        nudFemale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFemale.Name = "nudFemale"
        nudFemale.Size = New Size(140, 23)
        nudFemale.TabIndex = 9
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(25, 64)
        Label21.Margin = New Padding(2, 0, 2, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(36, 15)
        Label21.TabIndex = 8
        Label21.Text = "Male:"
        ' 
        ' nudMale
        ' 
        nudMale.Location = New Point(118, 60)
        nudMale.Margin = New Padding(2)
        nudMale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMale.Name = "nudMale"
        nudMale.Size = New Size(140, 23)
        nudMale.TabIndex = 7
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(16, 45)
        Label20.Margin = New Padding(2, 0, 2, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(48, 15)
        Label20.TabIndex = 6
        Label20.Text = "Counts:"
        ' 
        ' dtpSocial
        ' 
        dtpSocial.CustomFormat = "MMMM yyyy"
        dtpSocial.Format = DateTimePickerFormat.Custom
        dtpSocial.Location = New Point(109, 19)
        dtpSocial.Margin = New Padding(2)
        dtpSocial.Name = "dtpSocial"
        dtpSocial.Size = New Size(156, 23)
        dtpSocial.TabIndex = 4
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(16, 22)
        Label19.Margin = New Padding(2, 0, 2, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(89, 15)
        Label19.TabIndex = 3
        Label19.Text = "Reporting Date:"
        ' 
        ' tabSkills
        ' 
        tabSkills.Controls.Add(dtpSkills)
        tabSkills.Controls.Add(Label80)
        tabSkills.Controls.Add(GroupBoxSkills)
        tabSkills.Location = New Point(4, 24)
        tabSkills.Margin = New Padding(2)
        tabSkills.Name = "tabSkills"
        tabSkills.Padding = New Padding(2)
        tabSkills.Size = New Size(981, 294)
        tabSkills.TabIndex = 1
        tabSkills.Text = "Required Skills"
        tabSkills.UseVisualStyleBackColor = True
        ' 
        ' dtpSkills
        ' 
        dtpSkills.CustomFormat = "MMMM yyyy"
        dtpSkills.Format = DateTimePickerFormat.Custom
        dtpSkills.Location = New Point(124, 11)
        dtpSkills.Margin = New Padding(2)
        dtpSkills.Name = "dtpSkills"
        dtpSkills.Size = New Size(156, 23)
        dtpSkills.TabIndex = 2
        ' 
        ' Label80
        ' 
        Label80.AutoSize = True
        Label80.Location = New Point(23, 15)
        Label80.Margin = New Padding(2, 0, 2, 0)
        Label80.Name = "Label80"
        Label80.Size = New Size(89, 15)
        Label80.TabIndex = 1
        Label80.Text = "Reporting Date:"
        ' 
        ' GroupBoxSkills
        ' 
        GroupBoxSkills.Controls.Add(btnSaveSkills)
        GroupBoxSkills.Controls.Add(nudNewToIndustry)
        GroupBoxSkills.Controls.Add(Label26)
        GroupBoxSkills.Controls.Add(nudHiredQualified)
        GroupBoxSkills.Controls.Add(Label25)
        GroupBoxSkills.Controls.Add(nudLearntAtNIRU)
        GroupBoxSkills.Controls.Add(Label24)
        GroupBoxSkills.Location = New Point(16, 38)
        GroupBoxSkills.Margin = New Padding(2)
        GroupBoxSkills.Name = "GroupBoxSkills"
        GroupBoxSkills.Padding = New Padding(2)
        GroupBoxSkills.Size = New Size(622, 210)
        GroupBoxSkills.TabIndex = 0
        GroupBoxSkills.TabStop = False
        GroupBoxSkills.Text = "Skills Information"
        ' 
        ' btnSaveSkills
        ' 
        btnSaveSkills.BackColor = SystemColors.Control
        btnSaveSkills.Location = New Point(377, 164)
        btnSaveSkills.Margin = New Padding(2)
        btnSaveSkills.Name = "btnSaveSkills"
        btnSaveSkills.Size = New Size(92, 27)
        btnSaveSkills.TabIndex = 3
        btnSaveSkills.Text = "Save Skills"
        btnSaveSkills.UseVisualStyleBackColor = False
        ' 
        ' nudNewToIndustry
        ' 
        nudNewToIndustry.Location = New Point(350, 120)
        nudNewToIndustry.Margin = New Padding(2)
        nudNewToIndustry.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNewToIndustry.Name = "nudNewToIndustry"
        nudNewToIndustry.Size = New Size(156, 23)
        nudNewToIndustry.TabIndex = 5
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(23, 124)
        Label26.Margin = New Padding(2, 0, 2, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(250, 15)
        Label26.TabIndex = 4
        Label26.Text = "People that didn't work in our industry before:"
        ' 
        ' nudHiredQualified
        ' 
        nudHiredQualified.Location = New Point(350, 82)
        nudHiredQualified.Margin = New Padding(2)
        nudHiredQualified.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHiredQualified.Name = "nudHiredQualified"
        nudHiredQualified.Size = New Size(156, 23)
        nudHiredQualified.TabIndex = 3
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(23, 86)
        Label25.Margin = New Padding(2, 0, 2, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(210, 15)
        Label25.TabIndex = 2
        Label25.Text = "People hired already qualified (skilled):"
        ' 
        ' nudLearntAtNIRU
        ' 
        nudLearntAtNIRU.Location = New Point(350, 45)
        nudLearntAtNIRU.Margin = New Padding(2)
        nudLearntAtNIRU.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudLearntAtNIRU.Name = "nudLearntAtNIRU"
        nudLearntAtNIRU.Size = New Size(156, 23)
        nudLearntAtNIRU.TabIndex = 1
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(23, 49)
        Label24.Margin = New Padding(2, 0, 2, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(298, 15)
        Label24.TabIndex = 0
        Label24.Text = "People that learnt the job's skills at NIRU (current/past):"
        ' 
        ' tabPromotions
        ' 
        tabPromotions.Controls.Add(dtpPromotions)
        tabPromotions.Controls.Add(Label81)
        tabPromotions.Controls.Add(GroupBoxPromotions)
        tabPromotions.Location = New Point(4, 24)
        tabPromotions.Margin = New Padding(2)
        tabPromotions.Name = "tabPromotions"
        tabPromotions.Size = New Size(981, 294)
        tabPromotions.TabIndex = 2
        tabPromotions.Text = "Promotions & Mobility"
        tabPromotions.UseVisualStyleBackColor = True
        ' 
        ' btnSavePromotions
        ' 
        btnSavePromotions.BackColor = SystemColors.Control
        btnSavePromotions.Location = New Point(385, 169)
        btnSavePromotions.Margin = New Padding(2)
        btnSavePromotions.Name = "btnSavePromotions"
        btnSavePromotions.Size = New Size(92, 27)
        btnSavePromotions.TabIndex = 3
        btnSavePromotions.Text = "Save Data"
        btnSavePromotions.UseVisualStyleBackColor = False
        ' 
        ' dtpPromotions
        ' 
        dtpPromotions.CustomFormat = "MMMM yyyy"
        dtpPromotions.Format = DateTimePickerFormat.Custom
        dtpPromotions.Location = New Point(124, 11)
        dtpPromotions.Margin = New Padding(2)
        dtpPromotions.Name = "dtpPromotions"
        dtpPromotions.Size = New Size(156, 23)
        dtpPromotions.TabIndex = 2
        ' 
        ' Label81
        ' 
        Label81.AutoSize = True
        Label81.Location = New Point(23, 15)
        Label81.Margin = New Padding(2, 0, 2, 0)
        Label81.Name = "Label81"
        Label81.Size = New Size(89, 15)
        Label81.TabIndex = 1
        Label81.Text = "Reporting Date:"
        ' 
        ' GroupBoxPromotions
        ' 
        GroupBoxPromotions.Controls.Add(btnSavePromotions)
        GroupBoxPromotions.Controls.Add(nudSameFamily)
        GroupBoxPromotions.Controls.Add(Label29)
        GroupBoxPromotions.Controls.Add(nudInternalMobility)
        GroupBoxPromotions.Controls.Add(Label28)
        GroupBoxPromotions.Controls.Add(nudPromotions)
        GroupBoxPromotions.Controls.Add(Label27)
        GroupBoxPromotions.Location = New Point(16, 38)
        GroupBoxPromotions.Margin = New Padding(2)
        GroupBoxPromotions.Name = "GroupBoxPromotions"
        GroupBoxPromotions.Padding = New Padding(2)
        GroupBoxPromotions.Size = New Size(622, 210)
        GroupBoxPromotions.TabIndex = 0
        GroupBoxPromotions.TabStop = False
        GroupBoxPromotions.Text = "Promotions, Mobility & Family"
        ' 
        ' nudSameFamily
        ' 
        nudSameFamily.Location = New Point(350, 142)
        nudSameFamily.Margin = New Padding(2)
        nudSameFamily.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSameFamily.Name = "nudSameFamily"
        nudSameFamily.Size = New Size(156, 23)
        nudSameFamily.TabIndex = 5
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(23, 146)
        Label29.Margin = New Padding(2, 0, 2, 0)
        Label29.Name = "Label29"
        Label29.Size = New Size(208, 15)
        Label29.TabIndex = 4
        Label29.Text = "Number of people of the same family:"
        ' 
        ' nudInternalMobility
        ' 
        nudInternalMobility.Location = New Point(350, 105)
        nudInternalMobility.Margin = New Padding(2)
        nudInternalMobility.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudInternalMobility.Name = "nudInternalMobility"
        nudInternalMobility.Size = New Size(156, 23)
        nudInternalMobility.TabIndex = 3
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(23, 109)
        Label28.Margin = New Padding(2, 0, 2, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(267, 15)
        Label28.TabIndex = 2
        Label28.Text = "Employees who experienced internal role change:"
        ' 
        ' nudPromotions
        ' 
        nudPromotions.Location = New Point(350, 68)
        nudPromotions.Margin = New Padding(2)
        nudPromotions.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPromotions.Name = "nudPromotions"
        nudPromotions.Size = New Size(156, 23)
        nudPromotions.TabIndex = 1
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(23, 71)
        Label27.Margin = New Padding(2, 0, 2, 0)
        Label27.Name = "Label27"
        Label27.Size = New Size(209, 15)
        Label27.TabIndex = 0
        Label27.Text = "Employees who received a promotion:"
        ' 
        ' tabManagement
        ' 
        tabManagement.Controls.Add(dtpManagement)
        tabManagement.Controls.Add(Label82)
        tabManagement.Controls.Add(GroupBoxManagement)
        tabManagement.Location = New Point(4, 24)
        tabManagement.Margin = New Padding(2)
        tabManagement.Name = "tabManagement"
        tabManagement.Size = New Size(981, 294)
        tabManagement.TabIndex = 3
        tabManagement.Text = "Management"
        tabManagement.UseVisualStyleBackColor = True
        ' 
        ' btnSaveManagement
        ' 
        btnSaveManagement.BackColor = SystemColors.Control
        btnSaveManagement.Location = New Point(516, 147)
        btnSaveManagement.Margin = New Padding(2)
        btnSaveManagement.Name = "btnSaveManagement"
        btnSaveManagement.Size = New Size(92, 27)
        btnSaveManagement.TabIndex = 3
        btnSaveManagement.Text = "Save Data"
        btnSaveManagement.UseVisualStyleBackColor = False
        ' 
        ' dtpManagement
        ' 
        dtpManagement.CustomFormat = "MMMM yyyy"
        dtpManagement.Format = DateTimePickerFormat.Custom
        dtpManagement.Location = New Point(124, 11)
        dtpManagement.Margin = New Padding(2)
        dtpManagement.Name = "dtpManagement"
        dtpManagement.Size = New Size(156, 23)
        dtpManagement.TabIndex = 2
        ' 
        ' Label82
        ' 
        Label82.AutoSize = True
        Label82.Location = New Point(23, 15)
        Label82.Margin = New Padding(2, 0, 2, 0)
        Label82.Name = "Label82"
        Label82.Size = New Size(89, 15)
        Label82.TabIndex = 1
        Label82.Text = "Reporting Date:"
        ' 
        ' GroupBoxManagement
        ' 
        GroupBoxManagement.Controls.Add(btnSaveManagement)
        GroupBoxManagement.Controls.Add(nudMenLeadership)
        GroupBoxManagement.Controls.Add(Label39)
        GroupBoxManagement.Controls.Add(nudWomenLeadership)
        GroupBoxManagement.Controls.Add(Label40)
        GroupBoxManagement.Controls.Add(Label41)
        GroupBoxManagement.Controls.Add(nudMenUpper)
        GroupBoxManagement.Controls.Add(Label36)
        GroupBoxManagement.Controls.Add(nudWomenUpper)
        GroupBoxManagement.Controls.Add(Label37)
        GroupBoxManagement.Controls.Add(Label38)
        GroupBoxManagement.Controls.Add(nudMenMiddle)
        GroupBoxManagement.Controls.Add(Label33)
        GroupBoxManagement.Controls.Add(nudWomenMiddle)
        GroupBoxManagement.Controls.Add(Label34)
        GroupBoxManagement.Controls.Add(Label35)
        GroupBoxManagement.Controls.Add(nudMenFirstLine)
        GroupBoxManagement.Controls.Add(Label30)
        GroupBoxManagement.Controls.Add(nudWomenFirstLine)
        GroupBoxManagement.Controls.Add(Label31)
        GroupBoxManagement.Controls.Add(Label32)
        GroupBoxManagement.Location = New Point(16, 38)
        GroupBoxManagement.Margin = New Padding(2)
        GroupBoxManagement.Name = "GroupBoxManagement"
        GroupBoxManagement.Padding = New Padding(2)
        GroupBoxManagement.Size = New Size(918, 210)
        GroupBoxManagement.TabIndex = 0
        GroupBoxManagement.TabStop = False
        GroupBoxManagement.Text = "Management Structure"
        ' 
        ' nudMenLeadership
        ' 
        nudMenLeadership.Location = New Point(311, 180)
        nudMenLeadership.Margin = New Padding(2)
        nudMenLeadership.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudMenLeadership.Name = "nudMenLeadership"
        nudMenLeadership.Size = New Size(117, 23)
        nudMenLeadership.TabIndex = 23
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(171, 184)
        Label39.Margin = New Padding(2, 0, 2, 0)
        Label39.Name = "Label39"
        Label39.Size = New Size(139, 15)
        Label39.TabIndex = 22
        Label39.Text = "Men in Leadership Team:"
        ' 
        ' nudWomenLeadership
        ' 
        nudWomenLeadership.Location = New Point(311, 150)
        nudWomenLeadership.Margin = New Padding(2)
        nudWomenLeadership.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudWomenLeadership.Name = "nudWomenLeadership"
        nudWomenLeadership.Size = New Size(117, 23)
        nudWomenLeadership.TabIndex = 21
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(171, 154)
        Label40.Margin = New Padding(2, 0, 2, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(157, 15)
        Label40.TabIndex = 20
        Label40.Text = "Women in Leadership Team:"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label41.Location = New Point(16, 131)
        Label41.Margin = New Padding(2, 0, 2, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(184, 17)
        Label41.TabIndex = 19
        Label41.Text = "Group Leadership Team"
        ' 
        ' nudMenUpper
        ' 
        nudMenUpper.Location = New Point(311, 105)
        nudMenUpper.Margin = New Padding(2)
        nudMenUpper.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenUpper.Name = "nudMenUpper"
        nudMenUpper.Size = New Size(117, 23)
        nudMenUpper.TabIndex = 18
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(171, 109)
        Label36.Margin = New Padding(2, 0, 2, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(112, 15)
        Label36.TabIndex = 17
        Label36.Text = "Men at Upper Level:"
        ' 
        ' nudWomenUpper
        ' 
        nudWomenUpper.Location = New Point(311, 75)
        nudWomenUpper.Margin = New Padding(2)
        nudWomenUpper.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenUpper.Name = "nudWomenUpper"
        nudWomenUpper.Size = New Size(117, 23)
        nudWomenUpper.TabIndex = 16
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(171, 79)
        Label37.Margin = New Padding(2, 0, 2, 0)
        Label37.Name = "Label37"
        Label37.Size = New Size(130, 15)
        Label37.TabIndex = 15
        Label37.Text = "Women at Upper Level:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(16, 56)
        Label38.Margin = New Padding(2, 0, 2, 0)
        Label38.Name = "Label38"
        Label38.Size = New Size(139, 17)
        Label38.TabIndex = 14
        Label38.Text = "Upper Level Mgmt"
        ' 
        ' nudMenMiddle
        ' 
        nudMenMiddle.Location = New Point(619, 68)
        nudMenMiddle.Margin = New Padding(2)
        nudMenMiddle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenMiddle.Name = "nudMenMiddle"
        nudMenMiddle.Size = New Size(117, 23)
        nudMenMiddle.TabIndex = 13
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(479, 71)
        Label33.Margin = New Padding(2, 0, 2, 0)
        Label33.Name = "Label33"
        Label33.Size = New Size(117, 15)
        Label33.TabIndex = 12
        Label33.Text = "Men at Middle Level:"
        ' 
        ' nudWomenMiddle
        ' 
        nudWomenMiddle.Location = New Point(619, 42)
        nudWomenMiddle.Margin = New Padding(2)
        nudWomenMiddle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenMiddle.Name = "nudWomenMiddle"
        nudWomenMiddle.Size = New Size(117, 23)
        nudWomenMiddle.TabIndex = 11
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(479, 44)
        Label34.Margin = New Padding(2, 0, 2, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(135, 15)
        Label34.TabIndex = 10
        Label34.Text = "Women at Middle Level:"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(467, 19)
        Label35.Margin = New Padding(2, 0, 2, 0)
        Label35.Name = "Label35"
        Label35.Size = New Size(142, 17)
        Label35.TabIndex = 9
        Label35.Text = "Middle Level Mgmt"
        ' 
        ' nudMenFirstLine
        ' 
        nudMenFirstLine.Location = New Point(311, 105)
        nudMenFirstLine.Margin = New Padding(2)
        nudMenFirstLine.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenFirstLine.Name = "nudMenFirstLine"
        nudMenFirstLine.Size = New Size(117, 23)
        nudMenFirstLine.TabIndex = 8
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(16, 19)
        Label30.Margin = New Padding(2, 0, 2, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(306, 17)
        Label30.TabIndex = 4
        Label30.Text = "First Line Mgmt (TL/Supervisor/Manager)"
        ' 
        ' nudWomenFirstLine
        ' 
        nudWomenFirstLine.Location = New Point(311, 38)
        nudWomenFirstLine.Margin = New Padding(2)
        nudWomenFirstLine.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenFirstLine.Name = "nudWomenFirstLine"
        nudWomenFirstLine.Size = New Size(117, 23)
        nudWomenFirstLine.TabIndex = 7
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(171, 41)
        Label31.Margin = New Padding(2, 0, 2, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(151, 15)
        Label31.TabIndex = 6
        Label31.Text = "Women in First Line Mgmt:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(171, 109)
        Label32.Margin = New Padding(2, 0, 2, 0)
        Label32.Name = "Label32"
        Label32.Size = New Size(133, 15)
        Label32.TabIndex = 5
        Label32.Text = "Men in First Line Mgmt:"
        ' 
        ' tabDisabilities
        ' 
        tabDisabilities.Controls.Add(dtpDisabilities)
        tabDisabilities.Controls.Add(Label83)
        tabDisabilities.Controls.Add(GroupBoxDisabilities)
        tabDisabilities.Location = New Point(4, 24)
        tabDisabilities.Margin = New Padding(2)
        tabDisabilities.Name = "tabDisabilities"
        tabDisabilities.Size = New Size(981, 294)
        tabDisabilities.TabIndex = 4
        tabDisabilities.Text = "Disabilities"
        tabDisabilities.UseVisualStyleBackColor = True
        ' 
        ' btnSaveDisabilities
        ' 
        btnSaveDisabilities.BackColor = SystemColors.Control
        btnSaveDisabilities.Location = New Point(480, 167)
        btnSaveDisabilities.Margin = New Padding(2)
        btnSaveDisabilities.Name = "btnSaveDisabilities"
        btnSaveDisabilities.Size = New Size(92, 27)
        btnSaveDisabilities.TabIndex = 3
        btnSaveDisabilities.Text = "Save Data"
        btnSaveDisabilities.UseVisualStyleBackColor = False
        ' 
        ' dtpDisabilities
        ' 
        dtpDisabilities.CustomFormat = "MMMM yyyy"
        dtpDisabilities.Format = DateTimePickerFormat.Custom
        dtpDisabilities.Location = New Point(124, 11)
        dtpDisabilities.Margin = New Padding(2)
        dtpDisabilities.Name = "dtpDisabilities"
        dtpDisabilities.Size = New Size(156, 23)
        dtpDisabilities.TabIndex = 2
        ' 
        ' Label83
        ' 
        Label83.AutoSize = True
        Label83.Location = New Point(23, 15)
        Label83.Margin = New Padding(2, 0, 2, 0)
        Label83.Name = "Label83"
        Label83.Size = New Size(89, 15)
        Label83.TabIndex = 1
        Label83.Text = "Reporting Date:"
        ' 
        ' GroupBoxDisabilities
        ' 
        GroupBoxDisabilities.Controls.Add(btnSaveDisabilities)
        GroupBoxDisabilities.Controls.Add(nudChronic)
        GroupBoxDisabilities.Controls.Add(Label46)
        GroupBoxDisabilities.Controls.Add(nudIntellectual)
        GroupBoxDisabilities.Controls.Add(Label45)
        GroupBoxDisabilities.Controls.Add(nudMentalHealth)
        GroupBoxDisabilities.Controls.Add(Label44)
        GroupBoxDisabilities.Controls.Add(nudSensory)
        GroupBoxDisabilities.Controls.Add(Label43)
        GroupBoxDisabilities.Controls.Add(nudPhysical)
        GroupBoxDisabilities.Controls.Add(Label42)
        GroupBoxDisabilities.Location = New Point(16, 38)
        GroupBoxDisabilities.Margin = New Padding(2)
        GroupBoxDisabilities.Name = "GroupBoxDisabilities"
        GroupBoxDisabilities.Padding = New Padding(2)
        GroupBoxDisabilities.Size = New Size(622, 210)
        GroupBoxDisabilities.TabIndex = 0
        GroupBoxDisabilities.TabStop = False
        GroupBoxDisabilities.Text = "Disabilities Counts"
        ' 
        ' nudChronic
        ' 
        nudChronic.Location = New Point(272, 150)
        nudChronic.Margin = New Padding(2)
        nudChronic.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudChronic.Name = "nudChronic"
        nudChronic.Size = New Size(156, 23)
        nudChronic.TabIndex = 9
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Location = New Point(23, 154)
        Label46.Margin = New Padding(2, 0, 2, 0)
        Label46.Name = "Label46"
        Label46.Size = New Size(151, 15)
        Label46.TabIndex = 8
        Label46.Text = "Chronic Health Conditions:"
        ' 
        ' nudIntellectual
        ' 
        nudIntellectual.Location = New Point(272, 120)
        nudIntellectual.Margin = New Padding(2)
        nudIntellectual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIntellectual.Name = "nudIntellectual"
        nudIntellectual.Size = New Size(156, 23)
        nudIntellectual.TabIndex = 7
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Location = New Point(23, 124)
        Label45.Margin = New Padding(2, 0, 2, 0)
        Label45.Name = "Label45"
        Label45.Size = New Size(233, 15)
        Label45.TabIndex = 6
        Label45.Text = "Intellectual and Developmental Disabilities:"
        ' 
        ' nudMentalHealth
        ' 
        nudMentalHealth.Location = New Point(272, 90)
        nudMentalHealth.Margin = New Padding(2)
        nudMentalHealth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMentalHealth.Name = "nudMentalHealth"
        nudMentalHealth.Size = New Size(156, 23)
        nudMentalHealth.TabIndex = 5
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Location = New Point(23, 94)
        Label44.Margin = New Padding(2, 0, 2, 0)
        Label44.Name = "Label44"
        Label44.Size = New Size(146, 15)
        Label44.TabIndex = 4
        Label44.Text = "Mental Health Conditions:"
        ' 
        ' nudSensory
        ' 
        nudSensory.Location = New Point(272, 60)
        nudSensory.Margin = New Padding(2)
        nudSensory.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSensory.Name = "nudSensory"
        nudSensory.Size = New Size(156, 23)
        nudSensory.TabIndex = 3
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Location = New Point(23, 64)
        Label43.Margin = New Padding(2, 0, 2, 0)
        Label43.Name = "Label43"
        Label43.Size = New Size(110, 15)
        Label43.TabIndex = 2
        Label43.Text = "Sensory Disabilities:"
        ' 
        ' nudPhysical
        ' 
        nudPhysical.Location = New Point(272, 30)
        nudPhysical.Margin = New Padding(2)
        nudPhysical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPhysical.Name = "nudPhysical"
        nudPhysical.Size = New Size(156, 23)
        nudPhysical.TabIndex = 1
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(23, 34)
        Label42.Margin = New Padding(2, 0, 2, 0)
        Label42.Name = "Label42"
        Label42.Size = New Size(112, 15)
        Label42.TabIndex = 0
        Label42.Text = "Physical Disabilities:"
        ' 
        ' tabBehavior
        ' 
        tabBehavior.Controls.Add(dtpBehavior)
        tabBehavior.Controls.Add(Label84)
        tabBehavior.Controls.Add(GroupBoxBehavior)
        tabBehavior.Location = New Point(4, 24)
        tabBehavior.Margin = New Padding(2)
        tabBehavior.Name = "tabBehavior"
        tabBehavior.Size = New Size(981, 294)
        tabBehavior.TabIndex = 5
        tabBehavior.Text = "Behavior"
        tabBehavior.UseVisualStyleBackColor = True
        ' 
        ' btnSaveBehavior
        ' 
        btnSaveBehavior.BackColor = Color.LightGreen
        btnSaveBehavior.Location = New Point(355, 167)
        btnSaveBehavior.Margin = New Padding(2)
        btnSaveBehavior.Name = "btnSaveBehavior"
        btnSaveBehavior.Size = New Size(93, 22)
        btnSaveBehavior.TabIndex = 3
        btnSaveBehavior.Text = "Save Data"
        btnSaveBehavior.UseVisualStyleBackColor = False
        ' 
        ' dtpBehavior
        ' 
        dtpBehavior.CustomFormat = "MMMM yyyy"
        dtpBehavior.Format = DateTimePickerFormat.Custom
        dtpBehavior.Location = New Point(124, 11)
        dtpBehavior.Margin = New Padding(2)
        dtpBehavior.Name = "dtpBehavior"
        dtpBehavior.Size = New Size(156, 23)
        dtpBehavior.TabIndex = 2
        ' 
        ' Label84
        ' 
        Label84.AutoSize = True
        Label84.Location = New Point(23, 15)
        Label84.Margin = New Padding(2, 0, 2, 0)
        Label84.Name = "Label84"
        Label84.Size = New Size(89, 15)
        Label84.TabIndex = 1
        Label84.Text = "Reporting Date:"
        ' 
        ' GroupBoxBehavior
        ' 
        GroupBoxBehavior.Controls.Add(btnSaveBehavior)
        GroupBoxBehavior.Controls.Add(nudPansexual)
        GroupBoxBehavior.Controls.Add(Label51)
        GroupBoxBehavior.Controls.Add(nudAsexual)
        GroupBoxBehavior.Controls.Add(Label50)
        GroupBoxBehavior.Controls.Add(nudBisexual)
        GroupBoxBehavior.Controls.Add(Label49)
        GroupBoxBehavior.Controls.Add(nudGay)
        GroupBoxBehavior.Controls.Add(Label48)
        GroupBoxBehavior.Controls.Add(nudLesbian)
        GroupBoxBehavior.Controls.Add(Label47)
        GroupBoxBehavior.Location = New Point(16, 38)
        GroupBoxBehavior.Margin = New Padding(2)
        GroupBoxBehavior.Name = "GroupBoxBehavior"
        GroupBoxBehavior.Padding = New Padding(2)
        GroupBoxBehavior.Size = New Size(622, 210)
        GroupBoxBehavior.TabIndex = 0
        GroupBoxBehavior.TabStop = False
        GroupBoxBehavior.Text = "Sexual Orientation Counts"
        ' 
        ' nudPansexual
        ' 
        nudPansexual.Location = New Point(136, 152)
        nudPansexual.Margin = New Padding(2)
        nudPansexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPansexual.Name = "nudPansexual"
        nudPansexual.Size = New Size(156, 23)
        nudPansexual.TabIndex = 9
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Location = New Point(23, 154)
        Label51.Margin = New Padding(2, 0, 2, 0)
        Label51.Name = "Label51"
        Label51.Size = New Size(62, 15)
        Label51.TabIndex = 8
        Label51.Text = "Pansexual:"
        ' 
        ' nudAsexual
        ' 
        nudAsexual.Location = New Point(136, 122)
        nudAsexual.Margin = New Padding(2)
        nudAsexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAsexual.Name = "nudAsexual"
        nudAsexual.Size = New Size(156, 23)
        nudAsexual.TabIndex = 7
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Location = New Point(23, 124)
        Label50.Margin = New Padding(2, 0, 2, 0)
        Label50.Name = "Label50"
        Label50.Size = New Size(50, 15)
        Label50.TabIndex = 6
        Label50.Text = "Asexual:"
        ' 
        ' nudBisexual
        ' 
        nudBisexual.Location = New Point(136, 92)
        nudBisexual.Margin = New Padding(2)
        nudBisexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudBisexual.Name = "nudBisexual"
        nudBisexual.Size = New Size(156, 23)
        nudBisexual.TabIndex = 5
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(23, 94)
        Label49.Margin = New Padding(2, 0, 2, 0)
        Label49.Name = "Label49"
        Label49.Size = New Size(52, 15)
        Label49.TabIndex = 4
        Label49.Text = "Bisexual:"
        ' 
        ' nudGay
        ' 
        nudGay.Location = New Point(136, 62)
        nudGay.Margin = New Padding(2)
        nudGay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudGay.Name = "nudGay"
        nudGay.Size = New Size(156, 23)
        nudGay.TabIndex = 3
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Location = New Point(23, 64)
        Label48.Margin = New Padding(2, 0, 2, 0)
        Label48.Name = "Label48"
        Label48.Size = New Size(30, 15)
        Label48.TabIndex = 2
        Label48.Text = "Gay:"
        ' 
        ' nudLesbian
        ' 
        nudLesbian.Location = New Point(136, 32)
        nudLesbian.Margin = New Padding(2)
        nudLesbian.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudLesbian.Name = "nudLesbian"
        nudLesbian.Size = New Size(156, 23)
        nudLesbian.TabIndex = 1
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Location = New Point(23, 34)
        Label47.Margin = New Padding(2, 0, 2, 0)
        Label47.Name = "Label47"
        Label47.Size = New Size(50, 15)
        Label47.TabIndex = 0
        Label47.Text = "Lesbian:"
        ' 
        ' tabIdentification
        ' 
        tabIdentification.Controls.Add(btnSaveIdentification)
        tabIdentification.Controls.Add(dtpIdentification)
        tabIdentification.Controls.Add(Label85)
        tabIdentification.Controls.Add(GroupBoxIdentification)
        tabIdentification.Location = New Point(4, 24)
        tabIdentification.Margin = New Padding(2)
        tabIdentification.Name = "tabIdentification"
        tabIdentification.Size = New Size(981, 294)
        tabIdentification.TabIndex = 6
        tabIdentification.Text = "Gender Identification"
        tabIdentification.UseVisualStyleBackColor = True
        ' 
        ' btnSaveIdentification
        ' 
        btnSaveIdentification.BackColor = Color.LightGreen
        btnSaveIdentification.Location = New Point(272, 262)
        btnSaveIdentification.Margin = New Padding(2)
        btnSaveIdentification.Name = "btnSaveIdentification"
        btnSaveIdentification.Size = New Size(93, 22)
        btnSaveIdentification.TabIndex = 3
        btnSaveIdentification.Text = "Save Data"
        btnSaveIdentification.UseVisualStyleBackColor = False
        ' 
        ' dtpIdentification
        ' 
        dtpIdentification.CustomFormat = "MMMM yyyy"
        dtpIdentification.Format = DateTimePickerFormat.Custom
        dtpIdentification.Location = New Point(124, 11)
        dtpIdentification.Margin = New Padding(2)
        dtpIdentification.Name = "dtpIdentification"
        dtpIdentification.Size = New Size(156, 23)
        dtpIdentification.TabIndex = 2
        ' 
        ' Label85
        ' 
        Label85.AutoSize = True
        Label85.Location = New Point(23, 15)
        Label85.Margin = New Padding(2, 0, 2, 0)
        Label85.Name = "Label85"
        Label85.Size = New Size(89, 15)
        Label85.TabIndex = 1
        Label85.Text = "Reporting Date:"
        ' 
        ' GroupBoxIdentification
        ' 
        GroupBoxIdentification.Controls.Add(nudAgender)
        GroupBoxIdentification.Controls.Add(Label56)
        GroupBoxIdentification.Controls.Add(nudNonBinary)
        GroupBoxIdentification.Controls.Add(Label55)
        GroupBoxIdentification.Controls.Add(nudQuestioning)
        GroupBoxIdentification.Controls.Add(Label54)
        GroupBoxIdentification.Controls.Add(nudQueer)
        GroupBoxIdentification.Controls.Add(Label53)
        GroupBoxIdentification.Controls.Add(nudTransgender)
        GroupBoxIdentification.Controls.Add(Label52)
        GroupBoxIdentification.Location = New Point(16, 38)
        GroupBoxIdentification.Margin = New Padding(2)
        GroupBoxIdentification.Name = "GroupBoxIdentification"
        GroupBoxIdentification.Padding = New Padding(2)
        GroupBoxIdentification.Size = New Size(622, 210)
        GroupBoxIdentification.TabIndex = 0
        GroupBoxIdentification.TabStop = False
        GroupBoxIdentification.Text = "Gender Identity Counts"
        ' 
        ' nudAgender
        ' 
        nudAgender.Location = New Point(272, 150)
        nudAgender.Margin = New Padding(2)
        nudAgender.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAgender.Name = "nudAgender"
        nudAgender.Size = New Size(156, 23)
        nudAgender.TabIndex = 9
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Location = New Point(23, 154)
        Label56.Margin = New Padding(2, 0, 2, 0)
        Label56.Name = "Label56"
        Label56.Size = New Size(55, 15)
        Label56.TabIndex = 8
        Label56.Text = "Agender:"
        ' 
        ' nudNonBinary
        ' 
        nudNonBinary.Location = New Point(272, 120)
        nudNonBinary.Margin = New Padding(2)
        nudNonBinary.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNonBinary.Name = "nudNonBinary"
        nudNonBinary.Size = New Size(156, 23)
        nudNonBinary.TabIndex = 7
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Location = New Point(23, 124)
        Label55.Margin = New Padding(2, 0, 2, 0)
        Label55.Name = "Label55"
        Label55.Size = New Size(71, 15)
        Label55.TabIndex = 6
        Label55.Text = "Non-binary:"
        ' 
        ' nudQuestioning
        ' 
        nudQuestioning.Location = New Point(272, 90)
        nudQuestioning.Margin = New Padding(2)
        nudQuestioning.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudQuestioning.Name = "nudQuestioning"
        nudQuestioning.Size = New Size(156, 23)
        nudQuestioning.TabIndex = 5
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Location = New Point(23, 94)
        Label54.Margin = New Padding(2, 0, 2, 0)
        Label54.Name = "Label54"
        Label54.Size = New Size(75, 15)
        Label54.TabIndex = 4
        Label54.Text = "Questioning:"
        ' 
        ' nudQueer
        ' 
        nudQueer.Location = New Point(272, 60)
        nudQueer.Margin = New Padding(2)
        nudQueer.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudQueer.Name = "nudQueer"
        nudQueer.Size = New Size(156, 23)
        nudQueer.TabIndex = 3
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Location = New Point(23, 64)
        Label53.Margin = New Padding(2, 0, 2, 0)
        Label53.Name = "Label53"
        Label53.Size = New Size(42, 15)
        Label53.TabIndex = 2
        Label53.Text = "Queer:"
        ' 
        ' nudTransgender
        ' 
        nudTransgender.Location = New Point(272, 30)
        nudTransgender.Margin = New Padding(2)
        nudTransgender.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTransgender.Name = "nudTransgender"
        nudTransgender.Size = New Size(156, 23)
        nudTransgender.TabIndex = 1
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Location = New Point(23, 34)
        Label52.Margin = New Padding(2, 0, 2, 0)
        Label52.Name = "Label52"
        Label52.Size = New Size(75, 15)
        Label52.TabIndex = 0
        Label52.Text = "Transgender:"
        ' 
        ' tabNations
        ' 
        tabNations.Controls.Add(btnSaveNations)
        tabNations.Controls.Add(dtpNations)
        tabNations.Controls.Add(Label86)
        tabNations.Controls.Add(GroupBoxNations)
        tabNations.Location = New Point(4, 24)
        tabNations.Margin = New Padding(2)
        tabNations.Name = "tabNations"
        tabNations.Size = New Size(981, 294)
        tabNations.TabIndex = 7
        tabNations.Text = "Nations"
        tabNations.UseVisualStyleBackColor = True
        ' 
        ' btnSaveNations
        ' 
        btnSaveNations.BackColor = Color.LightGreen
        btnSaveNations.Location = New Point(272, 262)
        btnSaveNations.Margin = New Padding(2)
        btnSaveNations.Name = "btnSaveNations"
        btnSaveNations.Size = New Size(93, 22)
        btnSaveNations.TabIndex = 3
        btnSaveNations.Text = "Save Data"
        btnSaveNations.UseVisualStyleBackColor = False
        ' 
        ' dtpNations
        ' 
        dtpNations.CustomFormat = "MMMM yyyy"
        dtpNations.Format = DateTimePickerFormat.Custom
        dtpNations.Location = New Point(124, 11)
        dtpNations.Margin = New Padding(2)
        dtpNations.Name = "dtpNations"
        dtpNations.Size = New Size(156, 23)
        dtpNations.TabIndex = 2
        ' 
        ' Label86
        ' 
        Label86.AutoSize = True
        Label86.Location = New Point(23, 15)
        Label86.Margin = New Padding(2, 0, 2, 0)
        Label86.Name = "Label86"
        Label86.Size = New Size(89, 15)
        Label86.TabIndex = 1
        Label86.Text = "Reporting Date:"
        ' 
        ' GroupBoxNations
        ' 
        GroupBoxNations.Controls.Add(txtOtherEthnicitySpecify)
        GroupBoxNations.Controls.Add(Label63)
        GroupBoxNations.Controls.Add(nudOtherEthnicity)
        GroupBoxNations.Controls.Add(Label62)
        GroupBoxNations.Controls.Add(nudEuropean)
        GroupBoxNations.Controls.Add(Label61)
        GroupBoxNations.Controls.Add(nudPacificIslander)
        GroupBoxNations.Controls.Add(Label60)
        GroupBoxNations.Controls.Add(nudMiddleEastern)
        GroupBoxNations.Controls.Add(Label59)
        GroupBoxNations.Controls.Add(nudIndigenous)
        GroupBoxNations.Controls.Add(Label58)
        GroupBoxNations.Controls.Add(nudHispanic)
        GroupBoxNations.Controls.Add(Label64)
        GroupBoxNations.Controls.Add(nudAsian)
        GroupBoxNations.Controls.Add(Label57)
        GroupBoxNations.Controls.Add(nudAfrican)
        GroupBoxNations.Controls.Add(Label65)
        GroupBoxNations.Location = New Point(16, 38)
        GroupBoxNations.Margin = New Padding(2)
        GroupBoxNations.Name = "GroupBoxNations"
        GroupBoxNations.Padding = New Padding(2)
        GroupBoxNations.Size = New Size(778, 210)
        GroupBoxNations.TabIndex = 0
        GroupBoxNations.TabStop = False
        GroupBoxNations.Text = "Ethnicity/Nations Counts"
        ' 
        ' txtOtherEthnicitySpecify
        ' 
        txtOtherEthnicitySpecify.Location = New Point(350, 180)
        txtOtherEthnicitySpecify.Margin = New Padding(2)
        txtOtherEthnicitySpecify.Name = "txtOtherEthnicitySpecify"
        txtOtherEthnicitySpecify.Size = New Size(234, 23)
        txtOtherEthnicitySpecify.TabIndex = 17
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Location = New Point(194, 184)
        Label63.Margin = New Padding(2, 0, 2, 0)
        Label63.Name = "Label63"
        Label63.Size = New Size(145, 15)
        Label63.TabIndex = 16
        Label63.Text = "Other Ethnicities (specify):"
        ' 
        ' nudOtherEthnicity
        ' 
        nudOtherEthnicity.Location = New Point(350, 150)
        nudOtherEthnicity.Margin = New Padding(2)
        nudOtherEthnicity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherEthnicity.Name = "nudOtherEthnicity"
        nudOtherEthnicity.Size = New Size(156, 23)
        nudOtherEthnicity.TabIndex = 15
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Location = New Point(194, 154)
        Label62.Margin = New Padding(2, 0, 2, 0)
        Label62.Name = "Label62"
        Label62.Size = New Size(97, 15)
        Label62.TabIndex = 14
        Label62.Text = "Other Ethnicities:"
        ' 
        ' nudEuropean
        ' 
        nudEuropean.Location = New Point(350, 120)
        nudEuropean.Margin = New Padding(2)
        nudEuropean.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudEuropean.Name = "nudEuropean"
        nudEuropean.Size = New Size(156, 23)
        nudEuropean.TabIndex = 13
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Location = New Point(194, 124)
        Label61.Margin = New Padding(2, 0, 2, 0)
        Label61.Name = "Label61"
        Label61.Size = New Size(60, 15)
        Label61.TabIndex = 12
        Label61.Text = "European:"
        ' 
        ' nudPacificIslander
        ' 
        nudPacificIslander.Location = New Point(350, 90)
        nudPacificIslander.Margin = New Padding(2)
        nudPacificIslander.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPacificIslander.Name = "nudPacificIslander"
        nudPacificIslander.Size = New Size(156, 23)
        nudPacificIslander.TabIndex = 11
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Location = New Point(194, 94)
        Label60.Margin = New Padding(2, 0, 2, 0)
        Label60.Name = "Label60"
        Label60.Size = New Size(89, 15)
        Label60.TabIndex = 10
        Label60.Text = "Pacific Islander:"
        ' 
        ' nudMiddleEastern
        ' 
        nudMiddleEastern.Location = New Point(350, 60)
        nudMiddleEastern.Margin = New Padding(2)
        nudMiddleEastern.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMiddleEastern.Name = "nudMiddleEastern"
        nudMiddleEastern.Size = New Size(156, 23)
        nudMiddleEastern.TabIndex = 9
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Location = New Point(194, 64)
        Label59.Margin = New Padding(2, 0, 2, 0)
        Label59.Name = "Label59"
        Label59.Size = New Size(165, 15)
        Label59.TabIndex = 8
        Label59.Text = "Middle Eastern/North African:"
        ' 
        ' nudIndigenous
        ' 
        nudIndigenous.Location = New Point(117, 180)
        nudIndigenous.Margin = New Padding(2)
        nudIndigenous.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIndigenous.Name = "nudIndigenous"
        nudIndigenous.Size = New Size(156, 23)
        nudIndigenous.TabIndex = 7
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Location = New Point(23, 184)
        Label58.Margin = New Padding(2, 0, 2, 0)
        Label58.Name = "Label58"
        Label58.Size = New Size(69, 15)
        Label58.TabIndex = 6
        Label58.Text = "Indigenous:"
        ' 
        ' nudHispanic
        ' 
        nudHispanic.Location = New Point(117, 120)
        nudHispanic.Margin = New Padding(2)
        nudHispanic.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHispanic.Name = "nudHispanic"
        nudHispanic.Size = New Size(156, 23)
        nudHispanic.TabIndex = 5
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Location = New Point(23, 124)
        Label64.Margin = New Padding(2, 0, 2, 0)
        Label64.Name = "Label64"
        Label64.Size = New Size(94, 15)
        Label64.TabIndex = 4
        Label64.Text = "Hispanic/Latino:"
        ' 
        ' nudAsian
        ' 
        nudAsian.Location = New Point(117, 90)
        nudAsian.Margin = New Padding(2)
        nudAsian.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAsian.Name = "nudAsian"
        nudAsian.Size = New Size(156, 23)
        nudAsian.TabIndex = 3
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Location = New Point(23, 94)
        Label57.Margin = New Padding(2, 0, 2, 0)
        Label57.Name = "Label57"
        Label57.Size = New Size(39, 15)
        Label57.TabIndex = 2
        Label57.Text = "Asian:"
        ' 
        ' nudAfrican
        ' 
        nudAfrican.Location = New Point(117, 60)
        nudAfrican.Margin = New Padding(2)
        nudAfrican.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAfrican.Name = "nudAfrican"
        nudAfrican.Size = New Size(156, 23)
        nudAfrican.TabIndex = 1
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Location = New Point(23, 64)
        Label65.Margin = New Padding(2, 0, 2, 0)
        Label65.Name = "Label65"
        Label65.Size = New Size(48, 15)
        Label65.TabIndex = 0
        Label65.Text = "African:"
        ' 
        ' tabReligions
        ' 
        tabReligions.Controls.Add(btnSaveReligions)
        tabReligions.Controls.Add(dtpReligions)
        tabReligions.Controls.Add(Label87)
        tabReligions.Controls.Add(GroupBoxReligions)
        tabReligions.Location = New Point(4, 24)
        tabReligions.Margin = New Padding(2)
        tabReligions.Name = "tabReligions"
        tabReligions.Size = New Size(981, 294)
        tabReligions.TabIndex = 8
        tabReligions.Text = "Religions"
        tabReligions.UseVisualStyleBackColor = True
        ' 
        ' btnSaveReligions
        ' 
        btnSaveReligions.BackColor = Color.LightGreen
        btnSaveReligions.Location = New Point(272, 262)
        btnSaveReligions.Margin = New Padding(2)
        btnSaveReligions.Name = "btnSaveReligions"
        btnSaveReligions.Size = New Size(93, 22)
        btnSaveReligions.TabIndex = 3
        btnSaveReligions.Text = "Save Data"
        btnSaveReligions.UseVisualStyleBackColor = False
        ' 
        ' dtpReligions
        ' 
        dtpReligions.CustomFormat = "MMMM yyyy"
        dtpReligions.Format = DateTimePickerFormat.Custom
        dtpReligions.Location = New Point(124, 11)
        dtpReligions.Margin = New Padding(2)
        dtpReligions.Name = "dtpReligions"
        dtpReligions.Size = New Size(156, 23)
        dtpReligions.TabIndex = 2
        ' 
        ' Label87
        ' 
        Label87.AutoSize = True
        Label87.Location = New Point(23, 15)
        Label87.Margin = New Padding(2, 0, 2, 0)
        Label87.Name = "Label87"
        Label87.Size = New Size(89, 15)
        Label87.TabIndex = 1
        Label87.Text = "Reporting Date:"
        ' 
        ' GroupBoxReligions
        ' 
        GroupBoxReligions.Controls.Add(nudNoReligion)
        GroupBoxReligions.Controls.Add(Label74)
        GroupBoxReligions.Controls.Add(txtOtherReligionSpecify)
        GroupBoxReligions.Controls.Add(Label73)
        GroupBoxReligions.Controls.Add(nudOtherReligion)
        GroupBoxReligions.Controls.Add(Label72)
        GroupBoxReligions.Controls.Add(nudSikhism)
        GroupBoxReligions.Controls.Add(Label71)
        GroupBoxReligions.Controls.Add(nudJudaism)
        GroupBoxReligions.Controls.Add(Label70)
        GroupBoxReligions.Controls.Add(nudBuddhism)
        GroupBoxReligions.Controls.Add(Label69)
        GroupBoxReligions.Controls.Add(nudHinduism)
        GroupBoxReligions.Controls.Add(Label68)
        GroupBoxReligions.Controls.Add(nudIslam)
        GroupBoxReligions.Controls.Add(Label67)
        GroupBoxReligions.Controls.Add(nudChristianity)
        GroupBoxReligions.Controls.Add(Label66)
        GroupBoxReligions.Location = New Point(16, 38)
        GroupBoxReligions.Margin = New Padding(2)
        GroupBoxReligions.Name = "GroupBoxReligions"
        GroupBoxReligions.Padding = New Padding(2)
        GroupBoxReligions.Size = New Size(778, 210)
        GroupBoxReligions.TabIndex = 0
        GroupBoxReligions.TabStop = False
        GroupBoxReligions.Text = "Religious Counts"
        ' 
        ' nudNoReligion
        ' 
        nudNoReligion.Location = New Point(466, 140)
        nudNoReligion.Margin = New Padding(2)
        nudNoReligion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNoReligion.Name = "nudNoReligion"
        nudNoReligion.Size = New Size(156, 23)
        nudNoReligion.TabIndex = 17
        ' 
        ' Label74
        ' 
        Label74.AutoSize = True
        Label74.Location = New Point(350, 144)
        Label74.Margin = New Padding(2, 0, 2, 0)
        Label74.Name = "Label74"
        Label74.Size = New Size(72, 15)
        Label74.TabIndex = 16
        Label74.Text = "No Religion:"
        ' 
        ' txtOtherReligionSpecify
        ' 
        txtOtherReligionSpecify.Location = New Point(466, 110)
        txtOtherReligionSpecify.Margin = New Padding(2)
        txtOtherReligionSpecify.Name = "txtOtherReligionSpecify"
        txtOtherReligionSpecify.Size = New Size(156, 23)
        txtOtherReligionSpecify.TabIndex = 15
        ' 
        ' Label73
        ' 
        Label73.AutoSize = True
        Label73.Location = New Point(350, 93)
        Label73.Margin = New Padding(2, 0, 2, 0)
        Label73.Name = "Label73"
        Label73.Size = New Size(179, 15)
        Label73.TabIndex = 14
        Label73.Text = "Other Religion (e.g. R.Catheloic):"
        ' 
        ' nudOtherReligion
        ' 
        nudOtherReligion.Location = New Point(466, 59)
        nudOtherReligion.Margin = New Padding(2)
        nudOtherReligion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherReligion.Name = "nudOtherReligion"
        nudOtherReligion.Size = New Size(156, 23)
        nudOtherReligion.TabIndex = 13
        ' 
        ' Label72
        ' 
        Label72.AutoSize = True
        Label72.Location = New Point(350, 63)
        Label72.Margin = New Padding(2, 0, 2, 0)
        Label72.Name = "Label72"
        Label72.Size = New Size(91, 15)
        Label72.TabIndex = 12
        Label72.Text = "Other Religions:"
        ' 
        ' nudSikhism
        ' 
        nudSikhism.Location = New Point(466, 29)
        nudSikhism.Margin = New Padding(2)
        nudSikhism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSikhism.Name = "nudSikhism"
        nudSikhism.Size = New Size(156, 23)
        nudSikhism.TabIndex = 11
        ' 
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Location = New Point(350, 33)
        Label71.Margin = New Padding(2, 0, 2, 0)
        Label71.Name = "Label71"
        Label71.Size = New Size(51, 15)
        Label71.TabIndex = 10
        Label71.Text = "Sikhism:"
        ' 
        ' nudJudaism
        ' 
        nudJudaism.Location = New Point(150, 153)
        nudJudaism.Margin = New Padding(2)
        nudJudaism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudJudaism.Name = "nudJudaism"
        nudJudaism.Size = New Size(156, 23)
        nudJudaism.TabIndex = 9
        ' 
        ' Label70
        ' 
        Label70.AutoSize = True
        Label70.Location = New Point(33, 157)
        Label70.Margin = New Padding(2, 0, 2, 0)
        Label70.Name = "Label70"
        Label70.Size = New Size(53, 15)
        Label70.TabIndex = 8
        Label70.Text = "Judaism:"
        ' 
        ' nudBuddhism
        ' 
        nudBuddhism.Location = New Point(150, 123)
        nudBuddhism.Margin = New Padding(2)
        nudBuddhism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudBuddhism.Name = "nudBuddhism"
        nudBuddhism.Size = New Size(156, 23)
        nudBuddhism.TabIndex = 7
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Location = New Point(33, 127)
        Label69.Margin = New Padding(2, 0, 2, 0)
        Label69.Name = "Label69"
        Label69.Size = New Size(64, 15)
        Label69.TabIndex = 6
        Label69.Text = "Buddhism:"
        ' 
        ' nudHinduism
        ' 
        nudHinduism.Location = New Point(150, 93)
        nudHinduism.Margin = New Padding(2)
        nudHinduism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHinduism.Name = "nudHinduism"
        nudHinduism.Size = New Size(156, 23)
        nudHinduism.TabIndex = 5
        ' 
        ' Label68
        ' 
        Label68.AutoSize = True
        Label68.Location = New Point(33, 97)
        Label68.Margin = New Padding(2, 0, 2, 0)
        Label68.Name = "Label68"
        Label68.Size = New Size(62, 15)
        Label68.TabIndex = 4
        Label68.Text = "Hinduism:"
        ' 
        ' nudIslam
        ' 
        nudIslam.Location = New Point(150, 63)
        nudIslam.Margin = New Padding(2)
        nudIslam.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIslam.Name = "nudIslam"
        nudIslam.Size = New Size(156, 23)
        nudIslam.TabIndex = 3
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Location = New Point(33, 67)
        Label67.Margin = New Padding(2, 0, 2, 0)
        Label67.Name = "Label67"
        Label67.Size = New Size(38, 15)
        Label67.TabIndex = 2
        Label67.Text = "Islam:"
        ' 
        ' nudChristianity
        ' 
        nudChristianity.Location = New Point(150, 33)
        nudChristianity.Margin = New Padding(2)
        nudChristianity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudChristianity.Name = "nudChristianity"
        nudChristianity.Size = New Size(156, 23)
        nudChristianity.TabIndex = 1
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Location = New Point(33, 37)
        Label66.Margin = New Padding(2, 0, 2, 0)
        Label66.Name = "Label66"
        Label66.Size = New Size(70, 15)
        Label66.TabIndex = 0
        Label66.Text = "Christianity:"
        ' 
        ' tabLanguages
        ' 
        tabLanguages.Controls.Add(dtpLanguages)
        tabLanguages.Controls.Add(Label88)
        tabLanguages.Controls.Add(GroupBoxLanguages)
        tabLanguages.Location = New Point(4, 24)
        tabLanguages.Margin = New Padding(2)
        tabLanguages.Name = "tabLanguages"
        tabLanguages.Size = New Size(981, 294)
        tabLanguages.TabIndex = 9
        tabLanguages.Text = "Languages"
        tabLanguages.UseVisualStyleBackColor = True
        ' 
        ' btnSaveLanguages
        ' 
        btnSaveLanguages.BackColor = Color.LightGreen
        btnSaveLanguages.Location = New Point(320, 174)
        btnSaveLanguages.Margin = New Padding(2)
        btnSaveLanguages.Name = "btnSaveLanguages"
        btnSaveLanguages.Size = New Size(93, 22)
        btnSaveLanguages.TabIndex = 3
        btnSaveLanguages.Text = "Save Data"
        btnSaveLanguages.UseVisualStyleBackColor = False
        ' 
        ' dtpLanguages
        ' 
        dtpLanguages.CustomFormat = "MMMM yyyy"
        dtpLanguages.Format = DateTimePickerFormat.Custom
        dtpLanguages.Location = New Point(124, 11)
        dtpLanguages.Margin = New Padding(2)
        dtpLanguages.Name = "dtpLanguages"
        dtpLanguages.Size = New Size(156, 23)
        dtpLanguages.TabIndex = 2
        ' 
        ' Label88
        ' 
        Label88.AutoSize = True
        Label88.Location = New Point(23, 15)
        Label88.Margin = New Padding(2, 0, 2, 0)
        Label88.Name = "Label88"
        Label88.Size = New Size(89, 15)
        Label88.TabIndex = 1
        Label88.Text = "Reporting Date:"
        ' 
        ' GroupBoxLanguages
        ' 
        GroupBoxLanguages.Controls.Add(btnSaveLanguages)
        GroupBoxLanguages.Controls.Add(nudHindi)
        GroupBoxLanguages.Controls.Add(Label78)
        GroupBoxLanguages.Controls.Add(nudFrench)
        GroupBoxLanguages.Controls.Add(Label77)
        GroupBoxLanguages.Controls.Add(nudHebrew)
        GroupBoxLanguages.Controls.Add(Label76)
        GroupBoxLanguages.Controls.Add(nudSinhala)
        GroupBoxLanguages.Controls.Add(Label75)
        GroupBoxLanguages.Location = New Point(16, 38)
        GroupBoxLanguages.Margin = New Padding(2)
        GroupBoxLanguages.Name = "GroupBoxLanguages"
        GroupBoxLanguages.Padding = New Padding(2)
        GroupBoxLanguages.Size = New Size(622, 210)
        GroupBoxLanguages.TabIndex = 0
        GroupBoxLanguages.TabStop = False
        GroupBoxLanguages.Text = "Language Counts"
        ' 
        ' nudHindi
        ' 
        nudHindi.Location = New Point(136, 135)
        nudHindi.Margin = New Padding(2)
        nudHindi.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHindi.Name = "nudHindi"
        nudHindi.Size = New Size(156, 23)
        nudHindi.TabIndex = 7
        ' 
        ' Label78
        ' 
        Label78.AutoSize = True
        Label78.Location = New Point(19, 139)
        Label78.Margin = New Padding(2, 0, 2, 0)
        Label78.Name = "Label78"
        Label78.Size = New Size(39, 15)
        Label78.TabIndex = 6
        Label78.Text = "Hindi:"
        ' 
        ' nudFrench
        ' 
        nudFrench.Location = New Point(136, 97)
        nudFrench.Margin = New Padding(2)
        nudFrench.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFrench.Name = "nudFrench"
        nudFrench.Size = New Size(156, 23)
        nudFrench.TabIndex = 5
        ' 
        ' Label77
        ' 
        Label77.AutoSize = True
        Label77.Location = New Point(19, 101)
        Label77.Margin = New Padding(2, 0, 2, 0)
        Label77.Name = "Label77"
        Label77.Size = New Size(46, 15)
        Label77.TabIndex = 4
        Label77.Text = "French:"
        ' 
        ' nudHebrew
        ' 
        nudHebrew.Location = New Point(136, 60)
        nudHebrew.Margin = New Padding(2)
        nudHebrew.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHebrew.Name = "nudHebrew"
        nudHebrew.Size = New Size(156, 23)
        nudHebrew.TabIndex = 3
        ' 
        ' Label76
        ' 
        Label76.AutoSize = True
        Label76.Location = New Point(19, 64)
        Label76.Margin = New Padding(2, 0, 2, 0)
        Label76.Name = "Label76"
        Label76.Size = New Size(51, 15)
        Label76.TabIndex = 2
        Label76.Text = "Hebrew:"
        ' 
        ' nudSinhala
        ' 
        nudSinhala.Location = New Point(136, 30)
        nudSinhala.Margin = New Padding(2)
        nudSinhala.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSinhala.Name = "nudSinhala"
        nudSinhala.Size = New Size(156, 23)
        nudSinhala.TabIndex = 1
        ' 
        ' Label75
        ' 
        Label75.AutoSize = True
        Label75.Location = New Point(19, 34)
        Label75.Margin = New Padding(2, 0, 2, 0)
        Label75.Name = "Label75"
        Label75.Size = New Size(48, 15)
        Label75.TabIndex = 0
        Label75.Text = "Sinhala:"
        ' 
        ' pnlSummary
        ' 
        pnlSummary.Controls.Add(btnGenerateSummary)
        pnlSummary.Controls.Add(dtpSummaryYear)
        pnlSummary.Controls.Add(Label79)
        pnlSummary.Dock = DockStyle.Top
        pnlSummary.Location = New Point(0, 0)
        pnlSummary.Margin = New Padding(2)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(1011, 38)
        pnlSummary.TabIndex = 1
        ' 
        ' btnGenerateSummary
        ' 
        btnGenerateSummary.BackColor = Color.Gold
        btnGenerateSummary.Location = New Point(272, 8)
        btnGenerateSummary.Margin = New Padding(2)
        btnGenerateSummary.Name = "btnGenerateSummary"
        btnGenerateSummary.Size = New Size(156, 22)
        btnGenerateSummary.TabIndex = 2
        btnGenerateSummary.Text = "Generate Summary Report"
        btnGenerateSummary.UseVisualStyleBackColor = False
        ' 
        ' dtpSummaryYear
        ' 
        dtpSummaryYear.CustomFormat = "yyyy"
        dtpSummaryYear.Format = DateTimePickerFormat.Custom
        dtpSummaryYear.Location = New Point(140, 9)
        dtpSummaryYear.Margin = New Padding(2)
        dtpSummaryYear.Name = "dtpSummaryYear"
        dtpSummaryYear.ShowUpDown = True
        dtpSummaryYear.Size = New Size(63, 23)
        dtpSummaryYear.TabIndex = 1
        ' 
        ' Label79
        ' 
        Label79.AutoSize = True
        Label79.Location = New Point(16, 11)
        Label79.Margin = New Padding(2, 0, 2, 0)
        Label79.Name = "Label79"
        Label79.Size = New Size(122, 15)
        Label79.TabIndex = 0
        Label79.Text = "Select Year for Report:"
        ' 
        ' frmESGMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 562)
        Controls.Add(tcMain)
        Controls.Add(pnlSummary)
        Margin = New Padding(2)
        Name = "frmESGMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Data Management System"
        WindowState = FormWindowState.Maximized
        tcMain.ResumeLayout(False)
        tpHSE.ResumeLayout(False)
        grpHSEFilter.ResumeLayout(False)
        grpHSEFilter.PerformLayout()
        CType(dgvHSE, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxHSE.ResumeLayout(False)
        GroupBoxHSE.PerformLayout()
        CType(nudOtherWorkshop, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFireFighting, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFirstAid, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHSECount, ComponentModel.ISupportInitialize).EndInit()
        tpSafety.ResumeLayout(False)
        grpSafetyFilter.ResumeLayout(False)
        grpSafetyFilter.PerformLayout()
        CType(dgvSafety, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxSafety.ResumeLayout(False)
        GroupBoxSafety.PerformLayout()
        CType(nudDeaths, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIllness, ComponentModel.ISupportInitialize).EndInit()
        CType(nudInjuries, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTotalAccidents, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNearMisses, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEnvironmental, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPropertyDamage, ComponentModel.ISupportInitialize).EndInit()
        tpGrievances.ResumeLayout(False)
        grpGrievancesFilter.ResumeLayout(False)
        grpGrievancesFilter.PerformLayout()
        CType(dgvGrievances, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxGrievances.ResumeLayout(False)
        GroupBoxGrievances.PerformLayout()
        CType(nudUnresolvedGrievances, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTotalGrievances, ComponentModel.ISupportInitialize).EndInit()
        tpSocial.ResumeLayout(False)
        grpSocialFilter.ResumeLayout(False)
        grpSocialFilter.PerformLayout()
        CType(dgvSocial, ComponentModel.ISupportInitialize).EndInit()
        MainTabControl.ResumeLayout(False)
        tabBasicInfo.ResumeLayout(False)
        GroupBoxBasic.ResumeLayout(False)
        GroupBoxBasic.PerformLayout()
        CType(nudAgeCount, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFemale, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMale, ComponentModel.ISupportInitialize).EndInit()
        tabSkills.ResumeLayout(False)
        tabSkills.PerformLayout()
        GroupBoxSkills.ResumeLayout(False)
        GroupBoxSkills.PerformLayout()
        CType(nudNewToIndustry, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHiredQualified, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLearntAtNIRU, ComponentModel.ISupportInitialize).EndInit()
        tabPromotions.ResumeLayout(False)
        tabPromotions.PerformLayout()
        GroupBoxPromotions.ResumeLayout(False)
        GroupBoxPromotions.PerformLayout()
        CType(nudSameFamily, ComponentModel.ISupportInitialize).EndInit()
        CType(nudInternalMobility, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPromotions, ComponentModel.ISupportInitialize).EndInit()
        tabManagement.ResumeLayout(False)
        tabManagement.PerformLayout()
        GroupBoxManagement.ResumeLayout(False)
        GroupBoxManagement.PerformLayout()
        CType(nudMenLeadership, ComponentModel.ISupportInitialize).EndInit()
        CType(nudWomenLeadership, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMenUpper, ComponentModel.ISupportInitialize).EndInit()
        CType(nudWomenUpper, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMenMiddle, ComponentModel.ISupportInitialize).EndInit()
        CType(nudWomenMiddle, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMenFirstLine, ComponentModel.ISupportInitialize).EndInit()
        CType(nudWomenFirstLine, ComponentModel.ISupportInitialize).EndInit()
        tabDisabilities.ResumeLayout(False)
        tabDisabilities.PerformLayout()
        GroupBoxDisabilities.ResumeLayout(False)
        GroupBoxDisabilities.PerformLayout()
        CType(nudChronic, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIntellectual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMentalHealth, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSensory, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPhysical, ComponentModel.ISupportInitialize).EndInit()
        tabBehavior.ResumeLayout(False)
        tabBehavior.PerformLayout()
        GroupBoxBehavior.ResumeLayout(False)
        GroupBoxBehavior.PerformLayout()
        CType(nudPansexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAsexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBisexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudGay, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLesbian, ComponentModel.ISupportInitialize).EndInit()
        tabIdentification.ResumeLayout(False)
        tabIdentification.PerformLayout()
        GroupBoxIdentification.ResumeLayout(False)
        GroupBoxIdentification.PerformLayout()
        CType(nudAgender, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNonBinary, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQuestioning, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQueer, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTransgender, ComponentModel.ISupportInitialize).EndInit()
        tabNations.ResumeLayout(False)
        tabNations.PerformLayout()
        GroupBoxNations.ResumeLayout(False)
        GroupBoxNations.PerformLayout()
        CType(nudOtherEthnicity, ComponentModel.ISupportInitialize).EndInit()
        CType(nudEuropean, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPacificIslander, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMiddleEastern, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIndigenous, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHispanic, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAsian, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAfrican, ComponentModel.ISupportInitialize).EndInit()
        tabReligions.ResumeLayout(False)
        tabReligions.PerformLayout()
        GroupBoxReligions.ResumeLayout(False)
        GroupBoxReligions.PerformLayout()
        CType(nudNoReligion, ComponentModel.ISupportInitialize).EndInit()
        CType(nudOtherReligion, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSikhism, ComponentModel.ISupportInitialize).EndInit()
        CType(nudJudaism, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBuddhism, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHinduism, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIslam, ComponentModel.ISupportInitialize).EndInit()
        CType(nudChristianity, ComponentModel.ISupportInitialize).EndInit()
        tabLanguages.ResumeLayout(False)
        tabLanguages.PerformLayout()
        GroupBoxLanguages.ResumeLayout(False)
        GroupBoxLanguages.PerformLayout()
        CType(nudHindi, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFrench, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHebrew, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSinhala, ComponentModel.ISupportInitialize).EndInit()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        ResumeLayout(False)

    End Sub

    ' Main Controls
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpHSE As TabPage
    Friend WithEvents tpSafety As TabPage
    Friend WithEvents tpGrievances As TabPage
    Friend WithEvents tpSocial As TabPage
    Friend WithEvents pnlSummary As Panel
    Friend WithEvents btnGenerateSummary As Button
    Friend WithEvents dtpSummaryYear As DateTimePicker
    Friend WithEvents Label79 As Label

    ' HSE Tab Controls
    Friend WithEvents btnExportHSE As Button
    Friend WithEvents btnLoadHSE As Button
    Friend WithEvents btnSaveHSE As Button
    Friend WithEvents dgvHSE As DataGridView
    Friend WithEvents GroupBoxHSE As GroupBox
    Friend WithEvents txtOtherWorkshopName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nudOtherWorkshop As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nudFireFighting As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents nudFirstAid As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudHSECount As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpHSE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents grpHSEFilter As GroupBox
    Friend WithEvents btnClearHSEFilter As Button
    Friend WithEvents btnApplyHSEFilter As Button
    Friend WithEvents dtpHSEFilterMonth As DateTimePicker
    Friend WithEvents dtpHSEFilterYear As DateTimePicker
    Friend WithEvents Label90 As Label
    Friend WithEvents Label89 As Label

    ' Safety Tab Controls
    Friend WithEvents btnExportSafety As Button
    Friend WithEvents btnLoadSafety As Button
    Friend WithEvents btnSaveSafety As Button
    Friend WithEvents dgvSafety As DataGridView
    Friend WithEvents GroupBoxSafety As GroupBox
    Friend WithEvents nudDeaths As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents nudIllness As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents nudInjuries As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents nudTotalAccidents As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents nudNearMisses As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents nudEnvironmental As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents nudPropertyDamage As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpSafety As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents grpSafetyFilter As GroupBox
    Friend WithEvents btnClearSafetyFilter As Button
    Friend WithEvents btnApplySafetyFilter As Button
    Friend WithEvents dtpSafetyFilterMonth As DateTimePicker
    Friend WithEvents dtpSafetyFilterYear As DateTimePicker
    Friend WithEvents Label92 As Label
    Friend WithEvents Label91 As Label

    ' Grievances Tab Controls
    Friend WithEvents btnExportGrievances As Button
    Friend WithEvents btnLoadGrievances As Button
    Friend WithEvents btnSaveGrievances As Button
    Friend WithEvents dgvGrievances As DataGridView
    Friend WithEvents GroupBoxGrievances As GroupBox
    Friend WithEvents nudUnresolvedGrievances As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents nudTotalGrievances As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpGrievances As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents grpGrievancesFilter As GroupBox
    Friend WithEvents btnClearGrievancesFilter As Button
    Friend WithEvents btnApplyGrievancesFilter As Button
    Friend WithEvents dtpGrievancesFilterMonth As DateTimePicker
    Friend WithEvents dtpGrievancesFilterYear As DateTimePicker
    Friend WithEvents Label94 As Label
    Friend WithEvents Label93 As Label

    ' Social Tab Controls
    Friend WithEvents btnExportSocial As Button
    Friend WithEvents btnLoadSocial As Button
    Friend WithEvents btnSaveSocial As Button
    Friend WithEvents dgvSocial As DataGridView
    Friend WithEvents grpSocialFilter As GroupBox
    Friend WithEvents btnClearSocialFilter As Button
    Friend WithEvents btnApplySocialFilter As Button
    Friend WithEvents dtpSocialFilterMonth As DateTimePicker
    Friend WithEvents dtpSocialFilterYear As DateTimePicker
    Friend WithEvents Label96 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents tabBasicInfo As TabPage
    Friend WithEvents GroupBoxBasic As GroupBox
    Friend WithEvents btnDeleteAgeCategory As Button
    Friend WithEvents lstAgeCategories As ListBox
    Friend WithEvents btnAddAge As Button
    Friend WithEvents nudAgeCount As NumericUpDown
    Friend WithEvents cboAgeCategory As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents nudFemale As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents nudMale As NumericUpDown
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpSocial As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents tabSkills As TabPage
    Friend WithEvents btnSaveSkills As Button
    Friend WithEvents dtpSkills As DateTimePicker
    Friend WithEvents Label80 As Label
    Friend WithEvents GroupBoxSkills As GroupBox
    Friend WithEvents nudNewToIndustry As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents nudHiredQualified As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents nudLearntAtNIRU As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents tabPromotions As TabPage
    Friend WithEvents btnSavePromotions As Button
    Friend WithEvents dtpPromotions As DateTimePicker
    Friend WithEvents Label81 As Label
    Friend WithEvents GroupBoxPromotions As GroupBox
    Friend WithEvents nudSameFamily As NumericUpDown
    Friend WithEvents Label29 As Label
    Friend WithEvents nudInternalMobility As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents nudPromotions As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents tabManagement As TabPage
    Friend WithEvents btnSaveManagement As Button
    Friend WithEvents dtpManagement As DateTimePicker
    Friend WithEvents Label82 As Label
    Friend WithEvents GroupBoxManagement As GroupBox
    Friend WithEvents nudMenLeadership As NumericUpDown
    Friend WithEvents Label39 As Label
    Friend WithEvents nudWomenLeadership As NumericUpDown
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents nudMenUpper As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents nudWomenUpper As NumericUpDown
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents nudMenMiddle As NumericUpDown
    Friend WithEvents Label33 As Label
    Friend WithEvents nudWomenMiddle As NumericUpDown
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents nudMenFirstLine As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents nudWomenFirstLine As NumericUpDown
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents tabDisabilities As TabPage
    Friend WithEvents btnSaveDisabilities As Button
    Friend WithEvents dtpDisabilities As DateTimePicker
    Friend WithEvents Label83 As Label
    Friend WithEvents GroupBoxDisabilities As GroupBox
    Friend WithEvents nudChronic As NumericUpDown
    Friend WithEvents Label46 As Label
    Friend WithEvents nudIntellectual As NumericUpDown
    Friend WithEvents Label45 As Label
    Friend WithEvents nudMentalHealth As NumericUpDown
    Friend WithEvents Label44 As Label
    Friend WithEvents nudSensory As NumericUpDown
    Friend WithEvents Label43 As Label
    Friend WithEvents nudPhysical As NumericUpDown
    Friend WithEvents Label42 As Label
    Friend WithEvents tabBehavior As TabPage
    Friend WithEvents btnSaveBehavior As Button
    Friend WithEvents dtpBehavior As DateTimePicker
    Friend WithEvents Label84 As Label
    Friend WithEvents GroupBoxBehavior As GroupBox
    Friend WithEvents nudPansexual As NumericUpDown
    Friend WithEvents Label51 As Label
    Friend WithEvents nudAsexual As NumericUpDown
    Friend WithEvents Label50 As Label
    Friend WithEvents nudBisexual As NumericUpDown
    Friend WithEvents Label49 As Label
    Friend WithEvents nudGay As NumericUpDown
    Friend WithEvents Label48 As Label
    Friend WithEvents nudLesbian As NumericUpDown
    Friend WithEvents Label47 As Label
    Friend WithEvents tabIdentification As TabPage
    Friend WithEvents btnSaveIdentification As Button
    Friend WithEvents dtpIdentification As DateTimePicker
    Friend WithEvents Label85 As Label
    Friend WithEvents GroupBoxIdentification As GroupBox
    Friend WithEvents nudAgender As NumericUpDown
    Friend WithEvents Label56 As Label
    Friend WithEvents nudNonBinary As NumericUpDown
    Friend WithEvents Label55 As Label
    Friend WithEvents nudQuestioning As NumericUpDown
    Friend WithEvents Label54 As Label
    Friend WithEvents nudQueer As NumericUpDown
    Friend WithEvents Label53 As Label
    Friend WithEvents nudTransgender As NumericUpDown
    Friend WithEvents Label52 As Label
    Friend WithEvents tabNations As TabPage
    Friend WithEvents btnSaveNations As Button
    Friend WithEvents dtpNations As DateTimePicker
    Friend WithEvents Label86 As Label
    Friend WithEvents GroupBoxNations As GroupBox
    Friend WithEvents txtOtherEthnicitySpecify As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents nudOtherEthnicity As NumericUpDown
    Friend WithEvents Label62 As Label
    Friend WithEvents nudEuropean As NumericUpDown
    Friend WithEvents Label61 As Label
    Friend WithEvents nudPacificIslander As NumericUpDown
    Friend WithEvents Label60 As Label
    Friend WithEvents nudMiddleEastern As NumericUpDown
    Friend WithEvents Label59 As Label
    Friend WithEvents nudIndigenous As NumericUpDown
    Friend WithEvents Label58 As Label
    Friend WithEvents nudHispanic As NumericUpDown
    Friend WithEvents Label64 As Label
    Friend WithEvents nudAsian As NumericUpDown
    Friend WithEvents Label57 As Label
    Friend WithEvents nudAfrican As NumericUpDown
    Friend WithEvents Label65 As Label
    Friend WithEvents tabReligions As TabPage
    Friend WithEvents btnSaveReligions As Button
    Friend WithEvents dtpReligions As DateTimePicker
    Friend WithEvents Label87 As Label
    Friend WithEvents GroupBoxReligions As GroupBox
    Friend WithEvents nudNoReligion As NumericUpDown
    Friend WithEvents Label74 As Label
    Friend WithEvents txtOtherReligionSpecify As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents nudOtherReligion As NumericUpDown
    Friend WithEvents Label72 As Label
    Friend WithEvents nudSikhism As NumericUpDown
    Friend WithEvents Label71 As Label
    Friend WithEvents nudJudaism As NumericUpDown
    Friend WithEvents Label70 As Label
    Friend WithEvents nudBuddhism As NumericUpDown
    Friend WithEvents Label69 As Label
    Friend WithEvents nudHinduism As NumericUpDown
    Friend WithEvents Label68 As Label
    Friend WithEvents nudIslam As NumericUpDown
    Friend WithEvents Label67 As Label
    Friend WithEvents nudChristianity As NumericUpDown
    Friend WithEvents Label66 As Label
    Friend WithEvents tabLanguages As TabPage
    Friend WithEvents btnSaveLanguages As Button
    Friend WithEvents dtpLanguages As DateTimePicker
    Friend WithEvents Label88 As Label
    Friend WithEvents GroupBoxLanguages As GroupBox
    Friend WithEvents nudHindi As NumericUpDown
    Friend WithEvents Label78 As Label
    Friend WithEvents nudFrench As NumericUpDown
    Friend WithEvents Label77 As Label
    Friend WithEvents nudHebrew As NumericUpDown
    Friend WithEvents Label76 As Label
    Friend WithEvents nudSinhala As NumericUpDown
    Friend WithEvents Label75 As Label

End Class