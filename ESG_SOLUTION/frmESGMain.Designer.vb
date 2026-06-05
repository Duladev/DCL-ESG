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
        btnExportHSE = New Button()
        btnApplyHSEFilter = New Button()
        dtpHSEFilterMonth = New DateTimePicker()
        dtpHSEFilterYear = New DateTimePicker()
        Label90 = New Label()
        Label89 = New Label()
        dgvHSE = New DataGridView()
        GroupBoxHSE = New GroupBox()
        txtOtherWorkshopName = New TextBox()
        Label6 = New Label()
        btnLoadHSE = New Button()
        nudOtherWorkshop = New NumericUpDown()
        btnSaveHSE = New Button()
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
        btnExportSafety = New Button()
        btnApplySafetyFilter = New Button()
        btnLoadSafety = New Button()
        dtpSafetyFilterMonth = New DateTimePicker()
        dtpSafetyFilterYear = New DateTimePicker()
        Label92 = New Label()
        Label91 = New Label()
        dgvSafety = New DataGridView()
        GroupBoxSafety = New GroupBox()
        nudDeaths = New NumericUpDown()
        Label14 = New Label()
        nudIllness = New NumericUpDown()
        btnSaveSafety = New Button()
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
        btnExportGrievances = New Button()
        btnApplyGrievancesFilter = New Button()
        btnLoadGrievances = New Button()
        dtpGrievancesFilterMonth = New DateTimePicker()
        dtpGrievancesFilterYear = New DateTimePicker()
        Label94 = New Label()
        Label93 = New Label()
        dgvGrievances = New DataGridView()
        GroupBoxGrievances = New GroupBox()
        nudUnresolvedGrievances = New NumericUpDown()
        Label16 = New Label()
        nudTotalGrievances = New NumericUpDown()
        btnSaveGrievances = New Button()
        Label15 = New Label()
        dtpGrievances = New DateTimePicker()
        Label17 = New Label()
        tpSocial = New TabPage()
        tcSocialCategories = New TabControl()
        tabBasicInfo = New TabPage()
        pnlBasic = New Panel()
        dgvSocialBasic = New DataGridView()
        grpSocialFilter = New GroupBox()
        btnClearSocialFilter = New Button()
        btnApplySocialFilter = New Button()
        dtpSocialFilterMonth = New DateTimePicker()
        dtpSocialFilterYear = New DateTimePicker()
        Label96 = New Label()
        Label95 = New Label()
        GroupBoxBasic = New GroupBox()
        btnDeleteAgeCategory = New Button()
        lstAgeCategories = New ListBox()
        btnAddAge = New Button()
        btnSaveBasic = New Button()
        nudAgeCount = New NumericUpDown()
        btnUpdateBasic = New Button()
        cboAgeCategory = New ComboBox()
        btnCancelBasic = New Button()
        Label23 = New Label()
        Label22 = New Label()
        nudFemale = New NumericUpDown()
        Label21 = New Label()
        nudMale = New NumericUpDown()
        Label20 = New Label()
        dtpSocial = New DateTimePicker()
        Label19 = New Label()
        tabSkills = New TabPage()
        pnlSkills = New Panel()
        dgvSocialSkills = New DataGridView()
        grpSkillsFilter = New GroupBox()
        btnClearSkillsFilter = New Button()
        btnApplySkillsFilter = New Button()
        dtpSkillsFilterMonth = New DateTimePicker()
        dtpSkillsFilterYear = New DateTimePicker()
        Label97 = New Label()
        Label98 = New Label()
        GroupBoxSkills = New GroupBox()
        nudNewToIndustry = New NumericUpDown()
        Label26 = New Label()
        nudHiredQualified = New NumericUpDown()
        btnSaveSkills = New Button()
        Label25 = New Label()
        btnUpdateSkills = New Button()
        nudLearntAtNIRU = New NumericUpDown()
        btnCancelSkills = New Button()
        Label24 = New Label()
        dtpSkills = New DateTimePicker()
        Label80 = New Label()
        tabPromotions = New TabPage()
        pnlPromotions = New Panel()
        dgvSocialPromotions = New DataGridView()
        grpPromotionsFilter = New GroupBox()
        btnClearPromotionsFilter = New Button()
        btnApplyPromotionsFilter = New Button()
        dtpPromotionsFilterMonth = New DateTimePicker()
        dtpPromotionsFilterYear = New DateTimePicker()
        Label99 = New Label()
        Label100 = New Label()
        GroupBoxPromotions = New GroupBox()
        nudSameFamily = New NumericUpDown()
        Label29 = New Label()
        nudInternalMobility = New NumericUpDown()
        btnSavePromotions = New Button()
        Label28 = New Label()
        btnUpdatePromotions = New Button()
        nudPromotions = New NumericUpDown()
        btnCancelPromotions = New Button()
        Label27 = New Label()
        dtpPromotions = New DateTimePicker()
        Label81 = New Label()
        tabManagement = New TabPage()
        pnlManagement = New Panel()
        dgvSocialManagement = New DataGridView()
        grpManagementFilter = New GroupBox()
        btnClearManagementFilter = New Button()
        btnApplyManagementFilter = New Button()
        dtpManagementFilterMonth = New DateTimePicker()
        dtpManagementFilterYear = New DateTimePicker()
        Label101 = New Label()
        Label102 = New Label()
        GroupBoxManagement = New GroupBox()
        nudMenLeadership = New NumericUpDown()
        Label39 = New Label()
        nudWomenLeadership = New NumericUpDown()
        btnSaveManagement = New Button()
        Label40 = New Label()
        btnUpdateManagement = New Button()
        Label41 = New Label()
        btnCancelManagement = New Button()
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
        dtpManagement = New DateTimePicker()
        Label82 = New Label()
        tabDisabilities = New TabPage()
        pnlDisabilities = New Panel()
        dgvSocialDisabilities = New DataGridView()
        grpDisabilitiesFilter = New GroupBox()
        btnClearDisabilitiesFilter = New Button()
        btnApplyDisabilitiesFilter = New Button()
        dtpDisabilitiesFilterMonth = New DateTimePicker()
        dtpDisabilitiesFilterYear = New DateTimePicker()
        Label103 = New Label()
        Label104 = New Label()
        GroupBoxDisabilities = New GroupBox()
        nudChronic = New NumericUpDown()
        Label46 = New Label()
        nudIntellectual = New NumericUpDown()
        btnSaveDisabilities = New Button()
        Label45 = New Label()
        btnUpdateDisabilities = New Button()
        nudMentalHealth = New NumericUpDown()
        btnCancelDisabilities = New Button()
        Label44 = New Label()
        nudSensory = New NumericUpDown()
        Label43 = New Label()
        nudPhysical = New NumericUpDown()
        Label42 = New Label()
        dtpDisabilities = New DateTimePicker()
        Label83 = New Label()
        tabBehavior = New TabPage()
        pnlBehavior = New Panel()
        dgvSocialBehavior = New DataGridView()
        grpBehaviorFilter = New GroupBox()
        btnClearBehaviorFilter = New Button()
        btnApplyBehaviorFilter = New Button()
        dtpBehaviorFilterMonth = New DateTimePicker()
        dtpBehaviorFilterYear = New DateTimePicker()
        Label105 = New Label()
        Label106 = New Label()
        GroupBoxBehavior = New GroupBox()
        nudPansexual = New NumericUpDown()
        Label51 = New Label()
        nudAsexual = New NumericUpDown()
        btnSaveBehavior = New Button()
        Label50 = New Label()
        btnUpdateBehavior = New Button()
        nudBisexual = New NumericUpDown()
        btnCancelBehavior = New Button()
        Label49 = New Label()
        nudGay = New NumericUpDown()
        Label48 = New Label()
        nudLesbian = New NumericUpDown()
        Label47 = New Label()
        dtpBehavior = New DateTimePicker()
        Label84 = New Label()
        tabIdentification = New TabPage()
        pnlIdentification = New Panel()
        dgvSocialIdentification = New DataGridView()
        grpIdentificationFilter = New GroupBox()
        btnClearIdentificationFilter = New Button()
        btnApplyIdentificationFilter = New Button()
        dtpIdentificationFilterMonth = New DateTimePicker()
        dtpIdentificationFilterYear = New DateTimePicker()
        Label107 = New Label()
        Label108 = New Label()
        GroupBoxIdentification = New GroupBox()
        nudAgender = New NumericUpDown()
        Label56 = New Label()
        nudNonBinary = New NumericUpDown()
        btnSaveIdentification = New Button()
        Label55 = New Label()
        btnUpdateIdentification = New Button()
        nudQuestioning = New NumericUpDown()
        btnCancelIdentification = New Button()
        Label54 = New Label()
        nudQueer = New NumericUpDown()
        Label53 = New Label()
        nudTransgender = New NumericUpDown()
        Label52 = New Label()
        dtpIdentification = New DateTimePicker()
        Label85 = New Label()
        tabNations = New TabPage()
        pnlNations = New Panel()
        dgvSocialNations = New DataGridView()
        grpNationsFilter = New GroupBox()
        btnClearNationsFilter = New Button()
        btnApplyNationsFilter = New Button()
        dtpNationsFilterMonth = New DateTimePicker()
        dtpNationsFilterYear = New DateTimePicker()
        Label109 = New Label()
        Label110 = New Label()
        GroupBoxNations = New GroupBox()
        txtOtherEthnicitySpecify = New TextBox()
        Label63 = New Label()
        nudOtherEthnicity = New NumericUpDown()
        btnSaveNations = New Button()
        Label62 = New Label()
        btnUpdateNations = New Button()
        nudEuropean = New NumericUpDown()
        btnCancelNations = New Button()
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
        dtpNations = New DateTimePicker()
        Label86 = New Label()
        tabReligions = New TabPage()
        pnlReligions = New Panel()
        dgvSocialReligions = New DataGridView()
        grpReligionsFilter = New GroupBox()
        btnClearReligionsFilter = New Button()
        btnApplyReligionsFilter = New Button()
        dtpReligionsFilterMonth = New DateTimePicker()
        dtpReligionsFilterYear = New DateTimePicker()
        Label111 = New Label()
        Label112 = New Label()
        GroupBoxReligions = New GroupBox()
        nudNoReligion = New NumericUpDown()
        Label74 = New Label()
        txtOtherReligionSpecify = New TextBox()
        btnSaveReligions = New Button()
        Label73 = New Label()
        btnUpdateReligions = New Button()
        nudOtherReligion = New NumericUpDown()
        btnCancelReligions = New Button()
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
        dtpReligions = New DateTimePicker()
        Label87 = New Label()
        tabLanguages = New TabPage()
        pnlLanguages = New Panel()
        dgvSocialLanguages = New DataGridView()
        grpLanguagesFilter = New GroupBox()
        btnClearLanguagesFilter = New Button()
        btnApplyLanguagesFilter = New Button()
        dtpLanguagesFilterMonth = New DateTimePicker()
        dtpLanguagesFilterYear = New DateTimePicker()
        Label113 = New Label()
        Label114 = New Label()
        GroupBoxLanguages = New GroupBox()
        nudHindi = New NumericUpDown()
        Label78 = New Label()
        nudFrench = New NumericUpDown()
        btnSaveLanguages = New Button()
        Label77 = New Label()
        btnUpdateLanguages = New Button()
        nudHebrew = New NumericUpDown()
        btnCancelLanguages = New Button()
        Label76 = New Label()
        nudSinhala = New NumericUpDown()
        Label75 = New Label()
        dtpLanguages = New DateTimePicker()
        Label88 = New Label()
        btnExportSocial = New Button()
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
        tcSocialCategories.SuspendLayout()
        tabBasicInfo.SuspendLayout()
        pnlBasic.SuspendLayout()
        CType(dgvSocialBasic, ComponentModel.ISupportInitialize).BeginInit()
        grpSocialFilter.SuspendLayout()
        GroupBoxBasic.SuspendLayout()
        CType(nudAgeCount, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFemale, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMale, ComponentModel.ISupportInitialize).BeginInit()
        tabSkills.SuspendLayout()
        pnlSkills.SuspendLayout()
        CType(dgvSocialSkills, ComponentModel.ISupportInitialize).BeginInit()
        grpSkillsFilter.SuspendLayout()
        GroupBoxSkills.SuspendLayout()
        CType(nudNewToIndustry, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHiredQualified, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLearntAtNIRU, ComponentModel.ISupportInitialize).BeginInit()
        tabPromotions.SuspendLayout()
        pnlPromotions.SuspendLayout()
        CType(dgvSocialPromotions, ComponentModel.ISupportInitialize).BeginInit()
        grpPromotionsFilter.SuspendLayout()
        GroupBoxPromotions.SuspendLayout()
        CType(nudSameFamily, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudInternalMobility, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPromotions, ComponentModel.ISupportInitialize).BeginInit()
        tabManagement.SuspendLayout()
        pnlManagement.SuspendLayout()
        CType(dgvSocialManagement, ComponentModel.ISupportInitialize).BeginInit()
        grpManagementFilter.SuspendLayout()
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
        pnlDisabilities.SuspendLayout()
        CType(dgvSocialDisabilities, ComponentModel.ISupportInitialize).BeginInit()
        grpDisabilitiesFilter.SuspendLayout()
        GroupBoxDisabilities.SuspendLayout()
        CType(nudChronic, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudIntellectual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMentalHealth, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSensory, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPhysical, ComponentModel.ISupportInitialize).BeginInit()
        tabBehavior.SuspendLayout()
        pnlBehavior.SuspendLayout()
        CType(dgvSocialBehavior, ComponentModel.ISupportInitialize).BeginInit()
        grpBehaviorFilter.SuspendLayout()
        GroupBoxBehavior.SuspendLayout()
        CType(nudPansexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudAsexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBisexual, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudGay, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudLesbian, ComponentModel.ISupportInitialize).BeginInit()
        tabIdentification.SuspendLayout()
        pnlIdentification.SuspendLayout()
        CType(dgvSocialIdentification, ComponentModel.ISupportInitialize).BeginInit()
        grpIdentificationFilter.SuspendLayout()
        GroupBoxIdentification.SuspendLayout()
        CType(nudAgender, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudNonBinary, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQuestioning, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQueer, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTransgender, ComponentModel.ISupportInitialize).BeginInit()
        tabNations.SuspendLayout()
        pnlNations.SuspendLayout()
        CType(dgvSocialNations, ComponentModel.ISupportInitialize).BeginInit()
        grpNationsFilter.SuspendLayout()
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
        pnlReligions.SuspendLayout()
        CType(dgvSocialReligions, ComponentModel.ISupportInitialize).BeginInit()
        grpReligionsFilter.SuspendLayout()
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
        pnlLanguages.SuspendLayout()
        CType(dgvSocialLanguages, ComponentModel.ISupportInitialize).BeginInit()
        grpLanguagesFilter.SuspendLayout()
        GroupBoxLanguages.SuspendLayout()
        CType(nudHindi, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudFrench, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudHebrew, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSinhala, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tcMain
        ' 
        tcMain.Controls.Add(tpHSE)
        tcMain.Controls.Add(tpSafety)
        tcMain.Controls.Add(tpGrievances)
        tcMain.Controls.Add(tpSocial)
        tcMain.Dock = DockStyle.Fill
        tcMain.Location = New Point(0, 0)
        tcMain.Margin = New Padding(3, 2, 3, 2)
        tcMain.Name = "tcMain"
        tcMain.SelectedIndex = 0
        tcMain.Size = New Size(815, 525)
        tcMain.TabIndex = 0
        ' 
        ' tpHSE
        ' 
        tpHSE.Controls.Add(grpHSEFilter)
        tpHSE.Controls.Add(dgvHSE)
        tpHSE.Controls.Add(GroupBoxHSE)
        tpHSE.Location = New Point(4, 24)
        tpHSE.Margin = New Padding(3, 2, 3, 2)
        tpHSE.Name = "tpHSE"
        tpHSE.Padding = New Padding(3, 2, 3, 2)
        tpHSE.Size = New Size(807, 497)
        tpHSE.TabIndex = 0
        tpHSE.Text = "HSE Training"
        tpHSE.UseVisualStyleBackColor = True
        ' 
        ' grpHSEFilter
        ' 
        grpHSEFilter.Controls.Add(btnClearHSEFilter)
        grpHSEFilter.Controls.Add(btnExportHSE)
        grpHSEFilter.Controls.Add(btnApplyHSEFilter)
        grpHSEFilter.Controls.Add(dtpHSEFilterMonth)
        grpHSEFilter.Controls.Add(dtpHSEFilterYear)
        grpHSEFilter.Controls.Add(Label90)
        grpHSEFilter.Controls.Add(Label89)
        grpHSEFilter.Location = New Point(7, 210)
        grpHSEFilter.Margin = New Padding(3, 2, 3, 2)
        grpHSEFilter.Name = "grpHSEFilter"
        grpHSEFilter.Padding = New Padding(3, 2, 3, 2)
        grpHSEFilter.Size = New Size(779, 60)
        grpHSEFilter.TabIndex = 6
        grpHSEFilter.TabStop = False
        grpHSEFilter.Text = "Filter Data"
        ' 
        ' btnClearHSEFilter
        ' 
        btnClearHSEFilter.Location = New Point(484, 20)
        btnClearHSEFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearHSEFilter.Name = "btnClearHSEFilter"
        btnClearHSEFilter.Size = New Size(88, 28)
        btnClearHSEFilter.TabIndex = 5
        btnClearHSEFilter.Text = "Clear Filter"
        btnClearHSEFilter.UseVisualStyleBackColor = True
        ' 
        ' btnExportHSE
        ' 
        btnExportHSE.BackColor = Color.LightBlue
        btnExportHSE.Location = New Point(581, 20)
        btnExportHSE.Margin = New Padding(3, 2, 3, 2)
        btnExportHSE.Name = "btnExportHSE"
        btnExportHSE.Size = New Size(88, 28)
        btnExportHSE.TabIndex = 5
        btnExportHSE.Text = "Export Excel"
        btnExportHSE.UseVisualStyleBackColor = False
        ' 
        ' btnApplyHSEFilter
        ' 
        btnApplyHSEFilter.BackColor = Color.LightBlue
        btnApplyHSEFilter.Location = New Point(388, 20)
        btnApplyHSEFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyHSEFilter.Name = "btnApplyHSEFilter"
        btnApplyHSEFilter.Size = New Size(88, 28)
        btnApplyHSEFilter.TabIndex = 4
        btnApplyHSEFilter.Text = "Apply Filter"
        btnApplyHSEFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpHSEFilterMonth
        ' 
        dtpHSEFilterMonth.CustomFormat = "MMMM"
        dtpHSEFilterMonth.Format = DateTimePickerFormat.Custom
        dtpHSEFilterMonth.Location = New Point(262, 15)
        dtpHSEFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpHSEFilterMonth.Name = "dtpHSEFilterMonth"
        dtpHSEFilterMonth.Size = New Size(114, 23)
        dtpHSEFilterMonth.TabIndex = 3
        ' 
        ' dtpHSEFilterYear
        ' 
        dtpHSEFilterYear.CustomFormat = "yyyy"
        dtpHSEFilterYear.Format = DateTimePickerFormat.Custom
        dtpHSEFilterYear.Location = New Point(114, 15)
        dtpHSEFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpHSEFilterYear.Name = "dtpHSEFilterYear"
        dtpHSEFilterYear.ShowUpDown = True
        dtpHSEFilterYear.Size = New Size(75, 23)
        dtpHSEFilterYear.TabIndex = 2
        ' 
        ' Label90
        ' 
        Label90.AutoSize = True
        Label90.Location = New Point(219, 19)
        Label90.Name = "Label90"
        Label90.Size = New Size(46, 15)
        Label90.TabIndex = 1
        Label90.Text = "Month:"
        ' 
        ' Label89
        ' 
        Label89.AutoSize = True
        Label89.Location = New Point(79, 19)
        Label89.Name = "Label89"
        Label89.Size = New Size(32, 15)
        Label89.TabIndex = 0
        Label89.Text = "Year:"
        ' 
        ' dgvHSE
        ' 
        dgvHSE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHSE.Location = New Point(7, 278)
        dgvHSE.Margin = New Padding(3, 2, 3, 2)
        dgvHSE.Name = "dgvHSE"
        dgvHSE.RowHeadersWidth = 51
        dgvHSE.Size = New Size(779, 188)
        dgvHSE.TabIndex = 2
        ' 
        ' GroupBoxHSE
        ' 
        GroupBoxHSE.Controls.Add(txtOtherWorkshopName)
        GroupBoxHSE.Controls.Add(Label6)
        GroupBoxHSE.Controls.Add(btnLoadHSE)
        GroupBoxHSE.Controls.Add(nudOtherWorkshop)
        GroupBoxHSE.Controls.Add(btnSaveHSE)
        GroupBoxHSE.Controls.Add(Label5)
        GroupBoxHSE.Controls.Add(nudFireFighting)
        GroupBoxHSE.Controls.Add(Label4)
        GroupBoxHSE.Controls.Add(nudFirstAid)
        GroupBoxHSE.Controls.Add(Label3)
        GroupBoxHSE.Controls.Add(nudHSECount)
        GroupBoxHSE.Controls.Add(Label2)
        GroupBoxHSE.Controls.Add(dtpHSE)
        GroupBoxHSE.Controls.Add(Label1)
        GroupBoxHSE.Location = New Point(7, 8)
        GroupBoxHSE.Margin = New Padding(3, 2, 3, 2)
        GroupBoxHSE.Name = "GroupBoxHSE"
        GroupBoxHSE.Padding = New Padding(3, 2, 3, 2)
        GroupBoxHSE.Size = New Size(779, 188)
        GroupBoxHSE.TabIndex = 1
        GroupBoxHSE.TabStop = False
        GroupBoxHSE.Text = "HSE Training Data Entry"
        ' 
        ' txtOtherWorkshopName
        ' 
        txtOtherWorkshopName.Location = New Point(420, 79)
        txtOtherWorkshopName.Margin = New Padding(3, 2, 3, 2)
        txtOtherWorkshopName.Name = "txtOtherWorkshopName"
        txtOtherWorkshopName.Size = New Size(114, 23)
        txtOtherWorkshopName.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(263, 81)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 15)
        Label6.TabIndex = 10
        Label6.Text = "Other Workshop Name:"
        ' 
        ' btnLoadHSE
        ' 
        btnLoadHSE.Location = New Point(464, 141)
        btnLoadHSE.Margin = New Padding(3, 2, 3, 2)
        btnLoadHSE.Name = "btnLoadHSE"
        btnLoadHSE.Size = New Size(88, 27)
        btnLoadHSE.TabIndex = 4
        btnLoadHSE.Text = "Load Data"
        btnLoadHSE.UseVisualStyleBackColor = True
        btnLoadHSE.Visible = False
        ' 
        ' nudOtherWorkshop
        ' 
        nudOtherWorkshop.Location = New Point(420, 53)
        nudOtherWorkshop.Margin = New Padding(3, 2, 3, 2)
        nudOtherWorkshop.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherWorkshop.Name = "nudOtherWorkshop"
        nudOtherWorkshop.Size = New Size(114, 23)
        nudOtherWorkshop.TabIndex = 9
        ' 
        ' btnSaveHSE
        ' 
        btnSaveHSE.BackColor = Color.LightGreen
        btnSaveHSE.Location = New Point(370, 141)
        btnSaveHSE.Margin = New Padding(3, 2, 3, 2)
        btnSaveHSE.Name = "btnSaveHSE"
        btnSaveHSE.Size = New Size(88, 27)
        btnSaveHSE.TabIndex = 3
        btnSaveHSE.Text = "Save Data"
        btnSaveHSE.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(263, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 15)
        Label5.TabIndex = 8
        Label5.Text = "Other Workshop Count:"
        ' 
        ' nudFireFighting
        ' 
        nudFireFighting.Location = New Point(420, 26)
        nudFireFighting.Margin = New Padding(3, 2, 3, 2)
        nudFireFighting.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFireFighting.Name = "nudFireFighting"
        nudFireFighting.Size = New Size(114, 23)
        nudFireFighting.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(263, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 15)
        Label4.TabIndex = 6
        Label4.Text = "Fire Fighting Workshop:"
        ' 
        ' nudFirstAid
        ' 
        nudFirstAid.Location = New Point(105, 79)
        nudFirstAid.Margin = New Padding(3, 2, 3, 2)
        nudFirstAid.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFirstAid.Name = "nudFirstAid"
        nudFirstAid.Size = New Size(114, 23)
        nudFirstAid.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 4
        Label3.Text = "First-Aid Class:"
        ' 
        ' nudHSECount
        ' 
        nudHSECount.Location = New Point(105, 52)
        nudHSECount.Margin = New Padding(3, 2, 3, 2)
        nudHSECount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHSECount.Name = "nudHSECount"
        nudHSECount.Size = New Size(114, 23)
        nudHSECount.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 15)
        Label2.TabIndex = 2
        Label2.Text = "HSE Training:"
        ' 
        ' dtpHSE
        ' 
        dtpHSE.CustomFormat = "MMMM yyyy"
        dtpHSE.Format = DateTimePickerFormat.Custom
        dtpHSE.Location = New Point(105, 25)
        dtpHSE.Margin = New Padding(3, 2, 3, 2)
        dtpHSE.Name = "dtpHSE"
        dtpHSE.Size = New Size(114, 23)
        dtpHSE.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 15)
        Label1.TabIndex = 0
        Label1.Text = "Reporting Date:"
        ' 
        ' tpSafety
        ' 
        tpSafety.Controls.Add(grpSafetyFilter)
        tpSafety.Controls.Add(dgvSafety)
        tpSafety.Controls.Add(GroupBoxSafety)
        tpSafety.Location = New Point(4, 24)
        tpSafety.Margin = New Padding(3, 2, 3, 2)
        tpSafety.Name = "tpSafety"
        tpSafety.Padding = New Padding(3, 2, 3, 2)
        tpSafety.Size = New Size(807, 497)
        tpSafety.TabIndex = 1
        tpSafety.Text = "Safety Incidents"
        tpSafety.UseVisualStyleBackColor = True
        ' 
        ' grpSafetyFilter
        ' 
        grpSafetyFilter.Controls.Add(btnClearSafetyFilter)
        grpSafetyFilter.Controls.Add(btnExportSafety)
        grpSafetyFilter.Controls.Add(btnApplySafetyFilter)
        grpSafetyFilter.Controls.Add(btnLoadSafety)
        grpSafetyFilter.Controls.Add(dtpSafetyFilterMonth)
        grpSafetyFilter.Controls.Add(dtpSafetyFilterYear)
        grpSafetyFilter.Controls.Add(Label92)
        grpSafetyFilter.Controls.Add(Label91)
        grpSafetyFilter.Location = New Point(8, 177)
        grpSafetyFilter.Margin = New Padding(3, 2, 3, 2)
        grpSafetyFilter.Name = "grpSafetyFilter"
        grpSafetyFilter.Padding = New Padding(3, 2, 3, 2)
        grpSafetyFilter.Size = New Size(776, 59)
        grpSafetyFilter.TabIndex = 6
        grpSafetyFilter.TabStop = False
        grpSafetyFilter.Text = "Filter Data"
        ' 
        ' btnClearSafetyFilter
        ' 
        btnClearSafetyFilter.Location = New Point(556, 16)
        btnClearSafetyFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearSafetyFilter.Name = "btnClearSafetyFilter"
        btnClearSafetyFilter.Size = New Size(88, 25)
        btnClearSafetyFilter.TabIndex = 5
        btnClearSafetyFilter.Text = "Clear Filter"
        btnClearSafetyFilter.UseVisualStyleBackColor = True
        ' 
        ' btnExportSafety
        ' 
        btnExportSafety.BackColor = Color.LightBlue
        btnExportSafety.Location = New Point(653, 16)
        btnExportSafety.Margin = New Padding(3, 2, 3, 2)
        btnExportSafety.Name = "btnExportSafety"
        btnExportSafety.Size = New Size(88, 25)
        btnExportSafety.TabIndex = 5
        btnExportSafety.Text = "Export to Excel"
        btnExportSafety.UseVisualStyleBackColor = False
        ' 
        ' btnApplySafetyFilter
        ' 
        btnApplySafetyFilter.BackColor = Color.LightBlue
        btnApplySafetyFilter.Location = New Point(460, 16)
        btnApplySafetyFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplySafetyFilter.Name = "btnApplySafetyFilter"
        btnApplySafetyFilter.Size = New Size(88, 25)
        btnApplySafetyFilter.TabIndex = 4
        btnApplySafetyFilter.Text = "Apply Filter"
        btnApplySafetyFilter.UseVisualStyleBackColor = False
        ' 
        ' btnLoadSafety
        ' 
        btnLoadSafety.Location = New Point(805, 16)
        btnLoadSafety.Margin = New Padding(3, 2, 3, 2)
        btnLoadSafety.Name = "btnLoadSafety"
        btnLoadSafety.Size = New Size(88, 19)
        btnLoadSafety.TabIndex = 4
        btnLoadSafety.Text = "Load Data"
        btnLoadSafety.UseVisualStyleBackColor = True
        btnLoadSafety.Visible = False
        ' 
        ' dtpSafetyFilterMonth
        ' 
        dtpSafetyFilterMonth.CustomFormat = "MMMM"
        dtpSafetyFilterMonth.Format = DateTimePickerFormat.Custom
        dtpSafetyFilterMonth.Location = New Point(324, 14)
        dtpSafetyFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpSafetyFilterMonth.Name = "dtpSafetyFilterMonth"
        dtpSafetyFilterMonth.Size = New Size(114, 23)
        dtpSafetyFilterMonth.TabIndex = 3
        ' 
        ' dtpSafetyFilterYear
        ' 
        dtpSafetyFilterYear.CustomFormat = "yyyy"
        dtpSafetyFilterYear.Format = DateTimePickerFormat.Custom
        dtpSafetyFilterYear.Location = New Point(149, 14)
        dtpSafetyFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpSafetyFilterYear.Name = "dtpSafetyFilterYear"
        dtpSafetyFilterYear.ShowUpDown = True
        dtpSafetyFilterYear.Size = New Size(75, 23)
        dtpSafetyFilterYear.TabIndex = 2
        ' 
        ' Label92
        ' 
        Label92.AutoSize = True
        Label92.Location = New Point(262, 16)
        Label92.Name = "Label92"
        Label92.Size = New Size(46, 15)
        Label92.TabIndex = 1
        Label92.Text = "Month:"
        ' 
        ' Label91
        ' 
        Label91.AutoSize = True
        Label91.Location = New Point(79, 16)
        Label91.Name = "Label91"
        Label91.Size = New Size(32, 15)
        Label91.TabIndex = 0
        Label91.Text = "Year:"
        ' 
        ' dgvSafety
        ' 
        dgvSafety.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSafety.Location = New Point(7, 247)
        dgvSafety.Margin = New Padding(3, 2, 3, 2)
        dgvSafety.Name = "dgvSafety"
        dgvSafety.RowHeadersWidth = 51
        dgvSafety.Size = New Size(777, 203)
        dgvSafety.TabIndex = 2
        ' 
        ' GroupBoxSafety
        ' 
        GroupBoxSafety.Controls.Add(nudDeaths)
        GroupBoxSafety.Controls.Add(Label14)
        GroupBoxSafety.Controls.Add(nudIllness)
        GroupBoxSafety.Controls.Add(btnSaveSafety)
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
        GroupBoxSafety.Location = New Point(8, 4)
        GroupBoxSafety.Margin = New Padding(3, 2, 3, 2)
        GroupBoxSafety.Name = "GroupBoxSafety"
        GroupBoxSafety.Padding = New Padding(3, 2, 3, 2)
        GroupBoxSafety.Size = New Size(776, 165)
        GroupBoxSafety.TabIndex = 1
        GroupBoxSafety.TabStop = False
        GroupBoxSafety.Text = "Safety Incidents Data Entry"
        ' 
        ' nudDeaths
        ' 
        nudDeaths.Location = New Point(521, 116)
        nudDeaths.Margin = New Padding(3, 2, 3, 2)
        nudDeaths.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudDeaths.Name = "nudDeaths"
        nudDeaths.Size = New Size(114, 23)
        nudDeaths.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(354, 118)
        Label14.Name = "Label14"
        Label14.Size = New Size(157, 15)
        Label14.TabIndex = 14
        Label14.Text = "Accidents Resulted in Death:"
        ' 
        ' nudIllness
        ' 
        nudIllness.Location = New Point(521, 86)
        nudIllness.Margin = New Padding(3, 2, 3, 2)
        nudIllness.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIllness.Name = "nudIllness"
        nudIllness.Size = New Size(114, 23)
        nudIllness.TabIndex = 13
        ' 
        ' btnSaveSafety
        ' 
        btnSaveSafety.BackColor = Color.LightGreen
        btnSaveSafety.Location = New Point(664, 114)
        btnSaveSafety.Margin = New Padding(3, 2, 3, 2)
        btnSaveSafety.Name = "btnSaveSafety"
        btnSaveSafety.Size = New Size(88, 23)
        btnSaveSafety.TabIndex = 3
        btnSaveSafety.Text = "Save Data"
        btnSaveSafety.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(354, 88)
        Label13.Name = "Label13"
        Label13.Size = New Size(158, 15)
        Label13.TabIndex = 12
        Label13.Text = "Accidents Resulted in Illness:"
        ' 
        ' nudInjuries
        ' 
        nudInjuries.Location = New Point(521, 56)
        nudInjuries.Margin = New Padding(3, 2, 3, 2)
        nudInjuries.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudInjuries.Name = "nudInjuries"
        nudInjuries.Size = New Size(114, 23)
        nudInjuries.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(354, 58)
        Label12.Name = "Label12"
        Label12.Size = New Size(164, 15)
        Label12.TabIndex = 10
        Label12.Text = "Accidents Resulted in Injuries:"
        ' 
        ' nudTotalAccidents
        ' 
        nudTotalAccidents.Location = New Point(521, 26)
        nudTotalAccidents.Margin = New Padding(3, 2, 3, 2)
        nudTotalAccidents.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTotalAccidents.Name = "nudTotalAccidents"
        nudTotalAccidents.Size = New Size(114, 23)
        nudTotalAccidents.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(354, 28)
        Label11.Name = "Label11"
        Label11.Size = New Size(91, 15)
        Label11.TabIndex = 8
        Label11.Text = "Total Accidents:"
        ' 
        ' nudNearMisses
        ' 
        nudNearMisses.Location = New Point(219, 120)
        nudNearMisses.Margin = New Padding(3, 2, 3, 2)
        nudNearMisses.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNearMisses.Name = "nudNearMisses"
        nudNearMisses.Size = New Size(114, 23)
        nudNearMisses.TabIndex = 7
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(70, 122)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 15)
        Label10.TabIndex = 6
        Label10.Text = "Near Misses:"
        ' 
        ' nudEnvironmental
        ' 
        nudEnvironmental.Location = New Point(219, 90)
        nudEnvironmental.Margin = New Padding(3, 2, 3, 2)
        nudEnvironmental.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudEnvironmental.Name = "nudEnvironmental"
        nudEnvironmental.Size = New Size(114, 23)
        nudEnvironmental.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(70, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 15)
        Label9.TabIndex = 4
        Label9.Text = "Environmental Incidents:"
        ' 
        ' nudPropertyDamage
        ' 
        nudPropertyDamage.Location = New Point(219, 60)
        nudPropertyDamage.Margin = New Padding(3, 2, 3, 2)
        nudPropertyDamage.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPropertyDamage.Name = "nudPropertyDamage"
        nudPropertyDamage.Size = New Size(114, 23)
        nudPropertyDamage.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(70, 62)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 15)
        Label8.TabIndex = 2
        Label8.Text = "Property Damage Incidents:"
        ' 
        ' dtpSafety
        ' 
        dtpSafety.CustomFormat = "MMMM yyyy"
        dtpSafety.Format = DateTimePickerFormat.Custom
        dtpSafety.Location = New Point(105, 22)
        dtpSafety.Margin = New Padding(3, 2, 3, 2)
        dtpSafety.Name = "dtpSafety"
        dtpSafety.Size = New Size(158, 23)
        dtpSafety.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 15)
        Label7.TabIndex = 0
        Label7.Text = "Reporting Date:"
        ' 
        ' tpGrievances
        ' 
        tpGrievances.Controls.Add(grpGrievancesFilter)
        tpGrievances.Controls.Add(dgvGrievances)
        tpGrievances.Controls.Add(GroupBoxGrievances)
        tpGrievances.Location = New Point(4, 24)
        tpGrievances.Margin = New Padding(3, 2, 3, 2)
        tpGrievances.Name = "tpGrievances"
        tpGrievances.Size = New Size(807, 497)
        tpGrievances.TabIndex = 2
        tpGrievances.Text = "Grievances"
        tpGrievances.UseVisualStyleBackColor = True
        ' 
        ' grpGrievancesFilter
        ' 
        grpGrievancesFilter.Controls.Add(btnClearGrievancesFilter)
        grpGrievancesFilter.Controls.Add(btnExportGrievances)
        grpGrievancesFilter.Controls.Add(btnApplyGrievancesFilter)
        grpGrievancesFilter.Controls.Add(btnLoadGrievances)
        grpGrievancesFilter.Controls.Add(dtpGrievancesFilterMonth)
        grpGrievancesFilter.Controls.Add(dtpGrievancesFilterYear)
        grpGrievancesFilter.Controls.Add(Label94)
        grpGrievancesFilter.Controls.Add(Label93)
        grpGrievancesFilter.Location = New Point(7, 150)
        grpGrievancesFilter.Margin = New Padding(3, 2, 3, 2)
        grpGrievancesFilter.Name = "grpGrievancesFilter"
        grpGrievancesFilter.Padding = New Padding(3, 2, 3, 2)
        grpGrievancesFilter.Size = New Size(788, 56)
        grpGrievancesFilter.TabIndex = 6
        grpGrievancesFilter.TabStop = False
        grpGrievancesFilter.Text = "Filter Data"
        ' 
        ' btnClearGrievancesFilter
        ' 
        btnClearGrievancesFilter.Location = New Point(496, 20)
        btnClearGrievancesFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearGrievancesFilter.Name = "btnClearGrievancesFilter"
        btnClearGrievancesFilter.Size = New Size(88, 23)
        btnClearGrievancesFilter.TabIndex = 5
        btnClearGrievancesFilter.Text = "Clear Filter"
        btnClearGrievancesFilter.UseVisualStyleBackColor = True
        ' 
        ' btnExportGrievances
        ' 
        btnExportGrievances.BackColor = Color.LightBlue
        btnExportGrievances.Location = New Point(593, 20)
        btnExportGrievances.Margin = New Padding(3, 2, 3, 2)
        btnExportGrievances.Name = "btnExportGrievances"
        btnExportGrievances.Size = New Size(88, 23)
        btnExportGrievances.TabIndex = 5
        btnExportGrievances.Text = "Export to Excel"
        btnExportGrievances.UseVisualStyleBackColor = False
        ' 
        ' btnApplyGrievancesFilter
        ' 
        btnApplyGrievancesFilter.BackColor = Color.LightBlue
        btnApplyGrievancesFilter.Location = New Point(400, 20)
        btnApplyGrievancesFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyGrievancesFilter.Name = "btnApplyGrievancesFilter"
        btnApplyGrievancesFilter.Size = New Size(88, 23)
        btnApplyGrievancesFilter.TabIndex = 4
        btnApplyGrievancesFilter.Text = "Apply Filter"
        btnApplyGrievancesFilter.UseVisualStyleBackColor = False
        ' 
        ' btnLoadGrievances
        ' 
        btnLoadGrievances.Location = New Point(689, 20)
        btnLoadGrievances.Margin = New Padding(3, 2, 3, 2)
        btnLoadGrievances.Name = "btnLoadGrievances"
        btnLoadGrievances.Size = New Size(88, 23)
        btnLoadGrievances.TabIndex = 4
        btnLoadGrievances.Text = "Load Data"
        btnLoadGrievances.UseVisualStyleBackColor = True
        btnLoadGrievances.Visible = False
        ' 
        ' dtpGrievancesFilterMonth
        ' 
        dtpGrievancesFilterMonth.CustomFormat = "MMMM"
        dtpGrievancesFilterMonth.Format = DateTimePickerFormat.Custom
        dtpGrievancesFilterMonth.Location = New Point(241, 14)
        dtpGrievancesFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpGrievancesFilterMonth.Name = "dtpGrievancesFilterMonth"
        dtpGrievancesFilterMonth.Size = New Size(114, 23)
        dtpGrievancesFilterMonth.TabIndex = 3
        ' 
        ' dtpGrievancesFilterYear
        ' 
        dtpGrievancesFilterYear.CustomFormat = "yyyy"
        dtpGrievancesFilterYear.Format = DateTimePickerFormat.Custom
        dtpGrievancesFilterYear.Location = New Point(111, 14)
        dtpGrievancesFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpGrievancesFilterYear.Name = "dtpGrievancesFilterYear"
        dtpGrievancesFilterYear.ShowUpDown = True
        dtpGrievancesFilterYear.Size = New Size(75, 23)
        dtpGrievancesFilterYear.TabIndex = 2
        ' 
        ' Label94
        ' 
        Label94.AutoSize = True
        Label94.Location = New Point(196, 16)
        Label94.Name = "Label94"
        Label94.Size = New Size(46, 15)
        Label94.TabIndex = 1
        Label94.Text = "Month:"
        ' 
        ' Label93
        ' 
        Label93.AutoSize = True
        Label93.Location = New Point(79, 16)
        Label93.Name = "Label93"
        Label93.Size = New Size(32, 15)
        Label93.TabIndex = 0
        Label93.Text = "Year:"
        ' 
        ' dgvGrievances
        ' 
        dgvGrievances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGrievances.Location = New Point(7, 218)
        dgvGrievances.Margin = New Padding(3, 2, 3, 2)
        dgvGrievances.Name = "dgvGrievances"
        dgvGrievances.RowHeadersWidth = 51
        dgvGrievances.Size = New Size(788, 248)
        dgvGrievances.TabIndex = 2
        ' 
        ' GroupBoxGrievances
        ' 
        GroupBoxGrievances.Controls.Add(nudUnresolvedGrievances)
        GroupBoxGrievances.Controls.Add(Label16)
        GroupBoxGrievances.Controls.Add(nudTotalGrievances)
        GroupBoxGrievances.Controls.Add(btnSaveGrievances)
        GroupBoxGrievances.Controls.Add(Label15)
        GroupBoxGrievances.Controls.Add(dtpGrievances)
        GroupBoxGrievances.Controls.Add(Label17)
        GroupBoxGrievances.Location = New Point(7, 8)
        GroupBoxGrievances.Margin = New Padding(3, 2, 3, 2)
        GroupBoxGrievances.Name = "GroupBoxGrievances"
        GroupBoxGrievances.Padding = New Padding(3, 2, 3, 2)
        GroupBoxGrievances.Size = New Size(788, 138)
        GroupBoxGrievances.TabIndex = 1
        GroupBoxGrievances.TabStop = False
        GroupBoxGrievances.Text = "Grievances Data Entry"
        ' 
        ' nudUnresolvedGrievances
        ' 
        nudUnresolvedGrievances.Location = New Point(225, 82)
        nudUnresolvedGrievances.Margin = New Padding(3, 2, 3, 2)
        nudUnresolvedGrievances.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudUnresolvedGrievances.Name = "nudUnresolvedGrievances"
        nudUnresolvedGrievances.Size = New Size(158, 23)
        nudUnresolvedGrievances.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(35, 84)
        Label16.Name = "Label16"
        Label16.Size = New Size(184, 15)
        Label16.TabIndex = 4
        Label16.Text = "Unresolved Employee Grievances:"
        ' 
        ' nudTotalGrievances
        ' 
        nudTotalGrievances.Location = New Point(225, 52)
        nudTotalGrievances.Margin = New Padding(3, 2, 3, 2)
        nudTotalGrievances.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTotalGrievances.Name = "nudTotalGrievances"
        nudTotalGrievances.Size = New Size(158, 23)
        nudTotalGrievances.TabIndex = 3
        ' 
        ' btnSaveGrievances
        ' 
        btnSaveGrievances.BackColor = Color.LightGreen
        btnSaveGrievances.Location = New Point(430, 82)
        btnSaveGrievances.Margin = New Padding(3, 2, 3, 2)
        btnSaveGrievances.Name = "btnSaveGrievances"
        btnSaveGrievances.Size = New Size(88, 23)
        btnSaveGrievances.TabIndex = 3
        btnSaveGrievances.Text = "Save Data"
        btnSaveGrievances.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(35, 54)
        Label15.Name = "Label15"
        Label15.Size = New Size(151, 15)
        Label15.TabIndex = 2
        Label15.Text = "Total Employee Grievances:"
        ' 
        ' dtpGrievances
        ' 
        dtpGrievances.CustomFormat = "MMMM yyyy"
        dtpGrievances.Format = DateTimePickerFormat.Custom
        dtpGrievances.Location = New Point(105, 22)
        dtpGrievances.Margin = New Padding(3, 2, 3, 2)
        dtpGrievances.Name = "dtpGrievances"
        dtpGrievances.Size = New Size(158, 23)
        dtpGrievances.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(18, 26)
        Label17.Name = "Label17"
        Label17.Size = New Size(89, 15)
        Label17.TabIndex = 0
        Label17.Text = "Reporting Date:"
        ' 
        ' tpSocial
        ' 
        tpSocial.Controls.Add(tcSocialCategories)
        tpSocial.Controls.Add(btnExportSocial)
        tpSocial.Location = New Point(4, 24)
        tpSocial.Margin = New Padding(3, 2, 3, 2)
        tpSocial.Name = "tpSocial"
        tpSocial.Size = New Size(807, 497)
        tpSocial.TabIndex = 3
        tpSocial.Text = "Social Data"
        tpSocial.UseVisualStyleBackColor = True
        ' 
        ' tcSocialCategories
        ' 
        tcSocialCategories.Controls.Add(tabBasicInfo)
        tcSocialCategories.Controls.Add(tabSkills)
        tcSocialCategories.Controls.Add(tabPromotions)
        tcSocialCategories.Controls.Add(tabManagement)
        tcSocialCategories.Controls.Add(tabDisabilities)
        tcSocialCategories.Controls.Add(tabBehavior)
        tcSocialCategories.Controls.Add(tabIdentification)
        tcSocialCategories.Controls.Add(tabNations)
        tcSocialCategories.Controls.Add(tabReligions)
        tcSocialCategories.Controls.Add(tabLanguages)
        tcSocialCategories.Dock = DockStyle.Fill
        tcSocialCategories.Location = New Point(0, 0)
        tcSocialCategories.Margin = New Padding(3, 2, 3, 2)
        tcSocialCategories.Name = "tcSocialCategories"
        tcSocialCategories.SelectedIndex = 0
        tcSocialCategories.Size = New Size(807, 497)
        tcSocialCategories.TabIndex = 10
        ' 
        ' tabBasicInfo
        ' 
        tabBasicInfo.Controls.Add(pnlBasic)
        tabBasicInfo.Location = New Point(4, 24)
        tabBasicInfo.Margin = New Padding(3, 2, 3, 2)
        tabBasicInfo.Name = "tabBasicInfo"
        tabBasicInfo.Padding = New Padding(3, 2, 3, 2)
        tabBasicInfo.Size = New Size(799, 469)
        tabBasicInfo.TabIndex = 0
        tabBasicInfo.Text = "Basic Info & Age"
        tabBasicInfo.UseVisualStyleBackColor = True
        ' 
        ' pnlBasic
        ' 
        pnlBasic.Controls.Add(dgvSocialBasic)
        pnlBasic.Controls.Add(grpSocialFilter)
        pnlBasic.Controls.Add(GroupBoxBasic)
        pnlBasic.Dock = DockStyle.Fill
        pnlBasic.Location = New Point(3, 2)
        pnlBasic.Margin = New Padding(3, 2, 3, 2)
        pnlBasic.Name = "pnlBasic"
        pnlBasic.Size = New Size(793, 465)
        pnlBasic.TabIndex = 0
        ' 
        ' dgvSocialBasic
        ' 
        dgvSocialBasic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialBasic.Location = New Point(11, 316)
        dgvSocialBasic.Margin = New Padding(3, 2, 3, 2)
        dgvSocialBasic.Name = "dgvSocialBasic"
        dgvSocialBasic.RowHeadersWidth = 51
        dgvSocialBasic.Size = New Size(764, 140)
        dgvSocialBasic.TabIndex = 11
        ' 
        ' grpSocialFilter
        ' 
        grpSocialFilter.Controls.Add(btnClearSocialFilter)
        grpSocialFilter.Controls.Add(btnApplySocialFilter)
        grpSocialFilter.Controls.Add(dtpSocialFilterMonth)
        grpSocialFilter.Controls.Add(dtpSocialFilterYear)
        grpSocialFilter.Controls.Add(Label96)
        grpSocialFilter.Controls.Add(Label95)
        grpSocialFilter.Location = New Point(11, 265)
        grpSocialFilter.Margin = New Padding(3, 2, 3, 2)
        grpSocialFilter.Name = "grpSocialFilter"
        grpSocialFilter.Padding = New Padding(3, 2, 3, 2)
        grpSocialFilter.Size = New Size(764, 47)
        grpSocialFilter.TabIndex = 10
        grpSocialFilter.TabStop = False
        grpSocialFilter.Text = "Filter Data"
        ' 
        ' btnClearSocialFilter
        ' 
        btnClearSocialFilter.Location = New Point(350, 14)
        btnClearSocialFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearSocialFilter.Name = "btnClearSocialFilter"
        btnClearSocialFilter.Size = New Size(75, 23)
        btnClearSocialFilter.TabIndex = 5
        btnClearSocialFilter.Text = "Clear"
        btnClearSocialFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplySocialFilter
        ' 
        btnApplySocialFilter.BackColor = SystemColors.Control
        btnApplySocialFilter.Location = New Point(271, 14)
        btnApplySocialFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplySocialFilter.Name = "btnApplySocialFilter"
        btnApplySocialFilter.Size = New Size(75, 23)
        btnApplySocialFilter.TabIndex = 4
        btnApplySocialFilter.Text = "Apply"
        btnApplySocialFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpSocialFilterMonth
        ' 
        dtpSocialFilterMonth.CustomFormat = "MMMM"
        dtpSocialFilterMonth.Format = DateTimePickerFormat.Custom
        dtpSocialFilterMonth.Location = New Point(175, 12)
        dtpSocialFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpSocialFilterMonth.Name = "dtpSocialFilterMonth"
        dtpSocialFilterMonth.Size = New Size(79, 23)
        dtpSocialFilterMonth.TabIndex = 3
        ' 
        ' dtpSocialFilterYear
        ' 
        dtpSocialFilterYear.CustomFormat = "yyyy"
        dtpSocialFilterYear.Format = DateTimePickerFormat.Custom
        dtpSocialFilterYear.Location = New Point(78, 12)
        dtpSocialFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpSocialFilterYear.Name = "dtpSocialFilterYear"
        dtpSocialFilterYear.ShowUpDown = True
        dtpSocialFilterYear.Size = New Size(62, 23)
        dtpSocialFilterYear.TabIndex = 2
        ' 
        ' Label96
        ' 
        Label96.AutoSize = True
        Label96.Location = New Point(158, 15)
        Label96.Name = "Label96"
        Label96.Size = New Size(21, 15)
        Label96.TabIndex = 1
        Label96.Text = "M:"
        ' 
        ' Label95
        ' 
        Label95.AutoSize = True
        Label95.Location = New Point(65, 15)
        Label95.Name = "Label95"
        Label95.Size = New Size(17, 15)
        Label95.TabIndex = 0
        Label95.Text = "Y:"
        ' 
        ' GroupBoxBasic
        ' 
        GroupBoxBasic.Controls.Add(btnDeleteAgeCategory)
        GroupBoxBasic.Controls.Add(lstAgeCategories)
        GroupBoxBasic.Controls.Add(btnAddAge)
        GroupBoxBasic.Controls.Add(btnSaveBasic)
        GroupBoxBasic.Controls.Add(nudAgeCount)
        GroupBoxBasic.Controls.Add(btnUpdateBasic)
        GroupBoxBasic.Controls.Add(cboAgeCategory)
        GroupBoxBasic.Controls.Add(btnCancelBasic)
        GroupBoxBasic.Controls.Add(Label23)
        GroupBoxBasic.Controls.Add(Label22)
        GroupBoxBasic.Controls.Add(nudFemale)
        GroupBoxBasic.Controls.Add(Label21)
        GroupBoxBasic.Controls.Add(nudMale)
        GroupBoxBasic.Controls.Add(Label20)
        GroupBoxBasic.Controls.Add(dtpSocial)
        GroupBoxBasic.Controls.Add(Label19)
        GroupBoxBasic.Location = New Point(18, 15)
        GroupBoxBasic.Margin = New Padding(3, 2, 3, 2)
        GroupBoxBasic.Name = "GroupBoxBasic"
        GroupBoxBasic.Padding = New Padding(3, 2, 3, 2)
        GroupBoxBasic.Size = New Size(757, 246)
        GroupBoxBasic.TabIndex = 9
        GroupBoxBasic.TabStop = False
        GroupBoxBasic.Text = "Basic Information"
        ' 
        ' btnDeleteAgeCategory
        ' 
        btnDeleteAgeCategory.BackColor = SystemColors.Control
        btnDeleteAgeCategory.Location = New Point(298, 163)
        btnDeleteAgeCategory.Margin = New Padding(3, 2, 3, 2)
        btnDeleteAgeCategory.Name = "btnDeleteAgeCategory"
        btnDeleteAgeCategory.Size = New Size(105, 26)
        btnDeleteAgeCategory.TabIndex = 16
        btnDeleteAgeCategory.Text = "Delete Selected"
        btnDeleteAgeCategory.UseVisualStyleBackColor = False
        ' 
        ' lstAgeCategories
        ' 
        lstAgeCategories.FormattingEnabled = True
        lstAgeCategories.ItemHeight = 15
        lstAgeCategories.Location = New Point(105, 140)
        lstAgeCategories.Margin = New Padding(3, 2, 3, 2)
        lstAgeCategories.Name = "lstAgeCategories"
        lstAgeCategories.Size = New Size(187, 79)
        lstAgeCategories.TabIndex = 15
        ' 
        ' btnAddAge
        ' 
        btnAddAge.Location = New Point(420, 111)
        btnAddAge.Margin = New Padding(3, 2, 3, 2)
        btnAddAge.Name = "btnAddAge"
        btnAddAge.Size = New Size(79, 23)
        btnAddAge.TabIndex = 14
        btnAddAge.Text = "Add"
        btnAddAge.UseVisualStyleBackColor = True
        ' 
        ' btnSaveBasic
        ' 
        btnSaveBasic.BackColor = SystemColors.Control
        btnSaveBasic.Location = New Point(423, 209)
        btnSaveBasic.Margin = New Padding(3, 2, 3, 2)
        btnSaveBasic.Name = "btnSaveBasic"
        btnSaveBasic.Size = New Size(88, 33)
        btnSaveBasic.TabIndex = 12
        btnSaveBasic.Text = "Save"
        btnSaveBasic.UseVisualStyleBackColor = False
        ' 
        ' nudAgeCount
        ' 
        nudAgeCount.Location = New Point(298, 111)
        nudAgeCount.Margin = New Padding(3, 2, 3, 2)
        nudAgeCount.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAgeCount.Name = "nudAgeCount"
        nudAgeCount.Size = New Size(59, 23)
        nudAgeCount.TabIndex = 13
        ' 
        ' btnUpdateBasic
        ' 
        btnUpdateBasic.BackColor = SystemColors.Control
        btnUpdateBasic.Location = New Point(519, 209)
        btnUpdateBasic.Margin = New Padding(3, 2, 3, 2)
        btnUpdateBasic.Name = "btnUpdateBasic"
        btnUpdateBasic.Size = New Size(88, 33)
        btnUpdateBasic.TabIndex = 13
        btnUpdateBasic.Text = "Update"
        btnUpdateBasic.UseVisualStyleBackColor = False
        btnUpdateBasic.Visible = False
        ' 
        ' cboAgeCategory
        ' 
        cboAgeCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboAgeCategory.FormattingEnabled = True
        cboAgeCategory.Items.AddRange(New Object() {"17 years old or less", "Between 18 and 30 years old", "Between 31 and 50 years old", "50 years old or above"})
        cboAgeCategory.Location = New Point(105, 111)
        cboAgeCategory.Margin = New Padding(3, 2, 3, 2)
        cboAgeCategory.Name = "cboAgeCategory"
        cboAgeCategory.Size = New Size(187, 23)
        cboAgeCategory.TabIndex = 12
        ' 
        ' btnCancelBasic
        ' 
        btnCancelBasic.BackColor = SystemColors.Control
        btnCancelBasic.Location = New Point(615, 209)
        btnCancelBasic.Margin = New Padding(3, 2, 3, 2)
        btnCancelBasic.Name = "btnCancelBasic"
        btnCancelBasic.Size = New Size(88, 33)
        btnCancelBasic.TabIndex = 14
        btnCancelBasic.Text = "Cancel"
        btnCancelBasic.UseVisualStyleBackColor = False
        btnCancelBasic.Visible = False
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(18, 113)
        Label23.Name = "Label23"
        Label23.Size = New Size(82, 15)
        Label23.TabIndex = 11
        Label23.Text = "Age Category:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(26, 84)
        Label22.Name = "Label22"
        Label22.Size = New Size(48, 15)
        Label22.TabIndex = 10
        Label22.Text = "Female:"
        ' 
        ' nudFemale
        ' 
        nudFemale.Location = New Point(105, 83)
        nudFemale.Margin = New Padding(3, 2, 3, 2)
        nudFemale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFemale.Name = "nudFemale"
        nudFemale.Size = New Size(122, 23)
        nudFemale.TabIndex = 9
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(26, 59)
        Label21.Name = "Label21"
        Label21.Size = New Size(36, 15)
        Label21.TabIndex = 8
        Label21.Text = "Male:"
        ' 
        ' nudMale
        ' 
        nudMale.Location = New Point(105, 58)
        nudMale.Margin = New Padding(3, 2, 3, 2)
        nudMale.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMale.Name = "nudMale"
        nudMale.Size = New Size(122, 23)
        nudMale.TabIndex = 7
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(18, 44)
        Label20.Name = "Label20"
        Label20.Size = New Size(48, 15)
        Label20.TabIndex = 6
        Label20.Text = "Counts:"
        ' 
        ' dtpSocial
        ' 
        dtpSocial.CustomFormat = "MMMM yyyy"
        dtpSocial.Format = DateTimePickerFormat.Custom
        dtpSocial.Location = New Point(105, 19)
        dtpSocial.Margin = New Padding(3, 2, 3, 2)
        dtpSocial.Name = "dtpSocial"
        dtpSocial.Size = New Size(158, 23)
        dtpSocial.TabIndex = 4
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(18, 22)
        Label19.Name = "Label19"
        Label19.Size = New Size(89, 15)
        Label19.TabIndex = 3
        Label19.Text = "Reporting Date:"
        ' 
        ' tabSkills
        ' 
        tabSkills.Controls.Add(pnlSkills)
        tabSkills.Location = New Point(4, 24)
        tabSkills.Margin = New Padding(3, 2, 3, 2)
        tabSkills.Name = "tabSkills"
        tabSkills.Padding = New Padding(3, 2, 3, 2)
        tabSkills.Size = New Size(799, 469)
        tabSkills.TabIndex = 1
        tabSkills.Text = "Skills"
        tabSkills.UseVisualStyleBackColor = True
        ' 
        ' pnlSkills
        ' 
        pnlSkills.Controls.Add(dgvSocialSkills)
        pnlSkills.Controls.Add(grpSkillsFilter)
        pnlSkills.Controls.Add(GroupBoxSkills)
        pnlSkills.Dock = DockStyle.Fill
        pnlSkills.Location = New Point(3, 2)
        pnlSkills.Margin = New Padding(3, 2, 3, 2)
        pnlSkills.Name = "pnlSkills"
        pnlSkills.Size = New Size(793, 465)
        pnlSkills.TabIndex = 1
        ' 
        ' dgvSocialSkills
        ' 
        dgvSocialSkills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialSkills.Location = New Point(18, 310)
        dgvSocialSkills.Margin = New Padding(3, 2, 3, 2)
        dgvSocialSkills.Name = "dgvSocialSkills"
        dgvSocialSkills.RowHeadersWidth = 51
        dgvSocialSkills.Size = New Size(757, 153)
        dgvSocialSkills.TabIndex = 19
        ' 
        ' grpSkillsFilter
        ' 
        grpSkillsFilter.Controls.Add(btnClearSkillsFilter)
        grpSkillsFilter.Controls.Add(btnApplySkillsFilter)
        grpSkillsFilter.Controls.Add(dtpSkillsFilterMonth)
        grpSkillsFilter.Controls.Add(dtpSkillsFilterYear)
        grpSkillsFilter.Controls.Add(Label97)
        grpSkillsFilter.Controls.Add(Label98)
        grpSkillsFilter.Location = New Point(18, 257)
        grpSkillsFilter.Margin = New Padding(3, 2, 3, 2)
        grpSkillsFilter.Name = "grpSkillsFilter"
        grpSkillsFilter.Padding = New Padding(3, 2, 3, 2)
        grpSkillsFilter.Size = New Size(757, 49)
        grpSkillsFilter.TabIndex = 18
        grpSkillsFilter.TabStop = False
        grpSkillsFilter.Text = "Filter Data"
        ' 
        ' btnClearSkillsFilter
        ' 
        btnClearSkillsFilter.Location = New Point(350, 14)
        btnClearSkillsFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearSkillsFilter.Name = "btnClearSkillsFilter"
        btnClearSkillsFilter.Size = New Size(76, 23)
        btnClearSkillsFilter.TabIndex = 5
        btnClearSkillsFilter.Text = "Clear"
        btnClearSkillsFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplySkillsFilter
        ' 
        btnApplySkillsFilter.BackColor = SystemColors.Control
        btnApplySkillsFilter.Location = New Point(271, 14)
        btnApplySkillsFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplySkillsFilter.Name = "btnApplySkillsFilter"
        btnApplySkillsFilter.Size = New Size(76, 23)
        btnApplySkillsFilter.TabIndex = 4
        btnApplySkillsFilter.Text = "Apply"
        btnApplySkillsFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpSkillsFilterMonth
        ' 
        dtpSkillsFilterMonth.CustomFormat = "MMMM"
        dtpSkillsFilterMonth.Format = DateTimePickerFormat.Custom
        dtpSkillsFilterMonth.Location = New Point(175, 14)
        dtpSkillsFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpSkillsFilterMonth.Name = "dtpSkillsFilterMonth"
        dtpSkillsFilterMonth.Size = New Size(79, 23)
        dtpSkillsFilterMonth.TabIndex = 3
        ' 
        ' dtpSkillsFilterYear
        ' 
        dtpSkillsFilterYear.CustomFormat = "yyyy"
        dtpSkillsFilterYear.Format = DateTimePickerFormat.Custom
        dtpSkillsFilterYear.Location = New Point(88, 14)
        dtpSkillsFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpSkillsFilterYear.Name = "dtpSkillsFilterYear"
        dtpSkillsFilterYear.ShowUpDown = True
        dtpSkillsFilterYear.Size = New Size(62, 23)
        dtpSkillsFilterYear.TabIndex = 2
        ' 
        ' Label97
        ' 
        Label97.AutoSize = True
        Label97.Location = New Point(158, 15)
        Label97.Name = "Label97"
        Label97.Size = New Size(21, 15)
        Label97.TabIndex = 1
        Label97.Text = "M:"
        ' 
        ' Label98
        ' 
        Label98.AutoSize = True
        Label98.Location = New Point(52, 15)
        Label98.Name = "Label98"
        Label98.Size = New Size(33, 15)
        Label98.TabIndex = 0
        Label98.Text = "Y/M:"
        ' 
        ' GroupBoxSkills
        ' 
        GroupBoxSkills.Controls.Add(nudNewToIndustry)
        GroupBoxSkills.Controls.Add(Label26)
        GroupBoxSkills.Controls.Add(nudHiredQualified)
        GroupBoxSkills.Controls.Add(btnSaveSkills)
        GroupBoxSkills.Controls.Add(Label25)
        GroupBoxSkills.Controls.Add(btnUpdateSkills)
        GroupBoxSkills.Controls.Add(nudLearntAtNIRU)
        GroupBoxSkills.Controls.Add(btnCancelSkills)
        GroupBoxSkills.Controls.Add(Label24)
        GroupBoxSkills.Controls.Add(dtpSkills)
        GroupBoxSkills.Controls.Add(Label80)
        GroupBoxSkills.Location = New Point(18, 15)
        GroupBoxSkills.Margin = New Padding(3, 2, 3, 2)
        GroupBoxSkills.Name = "GroupBoxSkills"
        GroupBoxSkills.Padding = New Padding(3, 2, 3, 2)
        GroupBoxSkills.Size = New Size(757, 228)
        GroupBoxSkills.TabIndex = 17
        GroupBoxSkills.TabStop = False
        GroupBoxSkills.Text = "Skills Information"
        ' 
        ' nudNewToIndustry
        ' 
        nudNewToIndustry.Location = New Point(349, 139)
        nudNewToIndustry.Margin = New Padding(3, 2, 3, 2)
        nudNewToIndustry.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNewToIndustry.Name = "nudNewToIndustry"
        nudNewToIndustry.Size = New Size(158, 23)
        nudNewToIndustry.TabIndex = 17
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(25, 141)
        Label26.Name = "Label26"
        Label26.Size = New Size(250, 15)
        Label26.TabIndex = 16
        Label26.Text = "People that didn't work in our industry before:"
        ' 
        ' nudHiredQualified
        ' 
        nudHiredQualified.Location = New Point(349, 109)
        nudHiredQualified.Margin = New Padding(3, 2, 3, 2)
        nudHiredQualified.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHiredQualified.Name = "nudHiredQualified"
        nudHiredQualified.Size = New Size(158, 23)
        nudHiredQualified.TabIndex = 15
        ' 
        ' btnSaveSkills
        ' 
        btnSaveSkills.BackColor = SystemColors.Control
        btnSaveSkills.Location = New Point(349, 196)
        btnSaveSkills.Margin = New Padding(3, 2, 3, 2)
        btnSaveSkills.Name = "btnSaveSkills"
        btnSaveSkills.Size = New Size(88, 28)
        btnSaveSkills.TabIndex = 15
        btnSaveSkills.Text = "Save"
        btnSaveSkills.UseVisualStyleBackColor = False
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(25, 111)
        Label25.Name = "Label25"
        Label25.Size = New Size(210, 15)
        Label25.TabIndex = 14
        Label25.Text = "People hired already qualified (skilled):"
        ' 
        ' btnUpdateSkills
        ' 
        btnUpdateSkills.BackColor = SystemColors.Control
        btnUpdateSkills.Location = New Point(445, 196)
        btnUpdateSkills.Margin = New Padding(3, 2, 3, 2)
        btnUpdateSkills.Name = "btnUpdateSkills"
        btnUpdateSkills.Size = New Size(88, 28)
        btnUpdateSkills.TabIndex = 16
        btnUpdateSkills.Text = "Update"
        btnUpdateSkills.UseVisualStyleBackColor = False
        btnUpdateSkills.Visible = False
        ' 
        ' nudLearntAtNIRU
        ' 
        nudLearntAtNIRU.Location = New Point(349, 79)
        nudLearntAtNIRU.Margin = New Padding(3, 2, 3, 2)
        nudLearntAtNIRU.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudLearntAtNIRU.Name = "nudLearntAtNIRU"
        nudLearntAtNIRU.Size = New Size(158, 23)
        nudLearntAtNIRU.TabIndex = 13
        ' 
        ' btnCancelSkills
        ' 
        btnCancelSkills.BackColor = SystemColors.Control
        btnCancelSkills.Location = New Point(541, 196)
        btnCancelSkills.Margin = New Padding(3, 2, 3, 2)
        btnCancelSkills.Name = "btnCancelSkills"
        btnCancelSkills.Size = New Size(88, 28)
        btnCancelSkills.TabIndex = 17
        btnCancelSkills.Text = "Cancel"
        btnCancelSkills.UseVisualStyleBackColor = False
        btnCancelSkills.Visible = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(25, 81)
        Label24.Name = "Label24"
        Label24.Size = New Size(298, 15)
        Label24.TabIndex = 12
        Label24.Text = "People that learnt the job's skills at NIRU (current/past):"
        ' 
        ' dtpSkills
        ' 
        dtpSkills.CustomFormat = "MMMM yyyy"
        dtpSkills.Format = DateTimePickerFormat.Custom
        dtpSkills.Location = New Point(123, 33)
        dtpSkills.Margin = New Padding(3, 2, 3, 2)
        dtpSkills.Name = "dtpSkills"
        dtpSkills.Size = New Size(112, 23)
        dtpSkills.TabIndex = 11
        ' 
        ' Label80
        ' 
        Label80.AutoSize = True
        Label80.Location = New Point(18, 22)
        Label80.Name = "Label80"
        Label80.Size = New Size(89, 15)
        Label80.TabIndex = 10
        Label80.Text = "Reporting Date:"
        ' 
        ' tabPromotions
        ' 
        tabPromotions.Controls.Add(pnlPromotions)
        tabPromotions.Location = New Point(4, 24)
        tabPromotions.Margin = New Padding(3, 2, 3, 2)
        tabPromotions.Name = "tabPromotions"
        tabPromotions.Size = New Size(799, 469)
        tabPromotions.TabIndex = 2
        tabPromotions.Text = "Promotions & Mobility"
        tabPromotions.UseVisualStyleBackColor = True
        ' 
        ' pnlPromotions
        ' 
        pnlPromotions.Controls.Add(dgvSocialPromotions)
        pnlPromotions.Controls.Add(grpPromotionsFilter)
        pnlPromotions.Controls.Add(GroupBoxPromotions)
        pnlPromotions.Dock = DockStyle.Fill
        pnlPromotions.Location = New Point(0, 0)
        pnlPromotions.Margin = New Padding(3, 2, 3, 2)
        pnlPromotions.Name = "pnlPromotions"
        pnlPromotions.Size = New Size(799, 469)
        pnlPromotions.TabIndex = 2
        ' 
        ' dgvSocialPromotions
        ' 
        dgvSocialPromotions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialPromotions.Location = New Point(18, 288)
        dgvSocialPromotions.Margin = New Padding(3, 2, 3, 2)
        dgvSocialPromotions.Name = "dgvSocialPromotions"
        dgvSocialPromotions.RowHeadersWidth = 51
        dgvSocialPromotions.Size = New Size(763, 140)
        dgvSocialPromotions.TabIndex = 19
        ' 
        ' grpPromotionsFilter
        ' 
        grpPromotionsFilter.Controls.Add(btnClearPromotionsFilter)
        grpPromotionsFilter.Controls.Add(btnApplyPromotionsFilter)
        grpPromotionsFilter.Controls.Add(dtpPromotionsFilterMonth)
        grpPromotionsFilter.Controls.Add(dtpPromotionsFilterYear)
        grpPromotionsFilter.Controls.Add(Label99)
        grpPromotionsFilter.Controls.Add(Label100)
        grpPromotionsFilter.Location = New Point(18, 235)
        grpPromotionsFilter.Margin = New Padding(3, 2, 3, 2)
        grpPromotionsFilter.Name = "grpPromotionsFilter"
        grpPromotionsFilter.Padding = New Padding(3, 2, 3, 2)
        grpPromotionsFilter.Size = New Size(763, 49)
        grpPromotionsFilter.TabIndex = 18
        grpPromotionsFilter.TabStop = False
        grpPromotionsFilter.Text = "Filter Data"
        ' 
        ' btnClearPromotionsFilter
        ' 
        btnClearPromotionsFilter.Location = New Point(350, 14)
        btnClearPromotionsFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearPromotionsFilter.Name = "btnClearPromotionsFilter"
        btnClearPromotionsFilter.Size = New Size(78, 23)
        btnClearPromotionsFilter.TabIndex = 5
        btnClearPromotionsFilter.Text = "Clear"
        btnClearPromotionsFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyPromotionsFilter
        ' 
        btnApplyPromotionsFilter.BackColor = SystemColors.Control
        btnApplyPromotionsFilter.Location = New Point(271, 14)
        btnApplyPromotionsFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyPromotionsFilter.Name = "btnApplyPromotionsFilter"
        btnApplyPromotionsFilter.Size = New Size(78, 23)
        btnApplyPromotionsFilter.TabIndex = 4
        btnApplyPromotionsFilter.Text = "Apply"
        btnApplyPromotionsFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpPromotionsFilterMonth
        ' 
        dtpPromotionsFilterMonth.CustomFormat = "MMMM"
        dtpPromotionsFilterMonth.Format = DateTimePickerFormat.Custom
        dtpPromotionsFilterMonth.Location = New Point(175, 14)
        dtpPromotionsFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpPromotionsFilterMonth.Name = "dtpPromotionsFilterMonth"
        dtpPromotionsFilterMonth.Size = New Size(79, 23)
        dtpPromotionsFilterMonth.TabIndex = 3
        ' 
        ' dtpPromotionsFilterYear
        ' 
        dtpPromotionsFilterYear.CustomFormat = "yyyy"
        dtpPromotionsFilterYear.Format = DateTimePickerFormat.Custom
        dtpPromotionsFilterYear.Location = New Point(88, 14)
        dtpPromotionsFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpPromotionsFilterYear.Name = "dtpPromotionsFilterYear"
        dtpPromotionsFilterYear.ShowUpDown = True
        dtpPromotionsFilterYear.Size = New Size(62, 23)
        dtpPromotionsFilterYear.TabIndex = 2
        ' 
        ' Label99
        ' 
        Label99.AutoSize = True
        Label99.Location = New Point(158, 15)
        Label99.Name = "Label99"
        Label99.Size = New Size(21, 15)
        Label99.TabIndex = 1
        Label99.Text = "M:"
        ' 
        ' Label100
        ' 
        Label100.AutoSize = True
        Label100.Location = New Point(52, 15)
        Label100.Name = "Label100"
        Label100.Size = New Size(33, 15)
        Label100.TabIndex = 0
        Label100.Text = "Y/M:"
        ' 
        ' GroupBoxPromotions
        ' 
        GroupBoxPromotions.Controls.Add(nudSameFamily)
        GroupBoxPromotions.Controls.Add(Label29)
        GroupBoxPromotions.Controls.Add(nudInternalMobility)
        GroupBoxPromotions.Controls.Add(btnSavePromotions)
        GroupBoxPromotions.Controls.Add(Label28)
        GroupBoxPromotions.Controls.Add(btnUpdatePromotions)
        GroupBoxPromotions.Controls.Add(nudPromotions)
        GroupBoxPromotions.Controls.Add(btnCancelPromotions)
        GroupBoxPromotions.Controls.Add(Label27)
        GroupBoxPromotions.Controls.Add(dtpPromotions)
        GroupBoxPromotions.Controls.Add(Label81)
        GroupBoxPromotions.Location = New Point(18, 15)
        GroupBoxPromotions.Margin = New Padding(3, 2, 3, 2)
        GroupBoxPromotions.Name = "GroupBoxPromotions"
        GroupBoxPromotions.Padding = New Padding(3, 2, 3, 2)
        GroupBoxPromotions.Size = New Size(763, 216)
        GroupBoxPromotions.TabIndex = 17
        GroupBoxPromotions.TabStop = False
        GroupBoxPromotions.Text = "Promotions, Mobility & Family"
        ' 
        ' nudSameFamily
        ' 
        nudSameFamily.Location = New Point(350, 112)
        nudSameFamily.Margin = New Padding(3, 2, 3, 2)
        nudSameFamily.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSameFamily.Name = "nudSameFamily"
        nudSameFamily.Size = New Size(158, 23)
        nudSameFamily.TabIndex = 17
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(26, 114)
        Label29.Name = "Label29"
        Label29.Size = New Size(208, 15)
        Label29.TabIndex = 16
        Label29.Text = "Number of people of the same family:"
        ' 
        ' nudInternalMobility
        ' 
        nudInternalMobility.Location = New Point(350, 82)
        nudInternalMobility.Margin = New Padding(3, 2, 3, 2)
        nudInternalMobility.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudInternalMobility.Name = "nudInternalMobility"
        nudInternalMobility.Size = New Size(158, 23)
        nudInternalMobility.TabIndex = 15
        ' 
        ' btnSavePromotions
        ' 
        btnSavePromotions.BackColor = SystemColors.Control
        btnSavePromotions.Location = New Point(387, 165)
        btnSavePromotions.Margin = New Padding(3, 2, 3, 2)
        btnSavePromotions.Name = "btnSavePromotions"
        btnSavePromotions.Size = New Size(88, 31)
        btnSavePromotions.TabIndex = 15
        btnSavePromotions.Text = "Save"
        btnSavePromotions.UseVisualStyleBackColor = False
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(26, 84)
        Label28.Name = "Label28"
        Label28.Size = New Size(267, 15)
        Label28.TabIndex = 14
        Label28.Text = "Employees who experienced internal role change:"
        ' 
        ' btnUpdatePromotions
        ' 
        btnUpdatePromotions.BackColor = SystemColors.Control
        btnUpdatePromotions.Location = New Point(483, 165)
        btnUpdatePromotions.Margin = New Padding(3, 2, 3, 2)
        btnUpdatePromotions.Name = "btnUpdatePromotions"
        btnUpdatePromotions.Size = New Size(88, 31)
        btnUpdatePromotions.TabIndex = 16
        btnUpdatePromotions.Text = "Update"
        btnUpdatePromotions.UseVisualStyleBackColor = False
        btnUpdatePromotions.Visible = False
        ' 
        ' nudPromotions
        ' 
        nudPromotions.Location = New Point(350, 52)
        nudPromotions.Margin = New Padding(3, 2, 3, 2)
        nudPromotions.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPromotions.Name = "nudPromotions"
        nudPromotions.Size = New Size(158, 23)
        nudPromotions.TabIndex = 13
        ' 
        ' btnCancelPromotions
        ' 
        btnCancelPromotions.BackColor = SystemColors.Control
        btnCancelPromotions.Location = New Point(579, 165)
        btnCancelPromotions.Margin = New Padding(3, 2, 3, 2)
        btnCancelPromotions.Name = "btnCancelPromotions"
        btnCancelPromotions.Size = New Size(88, 31)
        btnCancelPromotions.TabIndex = 17
        btnCancelPromotions.Text = "Cancel"
        btnCancelPromotions.UseVisualStyleBackColor = False
        btnCancelPromotions.Visible = False
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(26, 54)
        Label27.Name = "Label27"
        Label27.Size = New Size(209, 15)
        Label27.TabIndex = 12
        Label27.Text = "Employees who received a promotion:"
        ' 
        ' dtpPromotions
        ' 
        dtpPromotions.CustomFormat = "MMMM yyyy"
        dtpPromotions.Format = DateTimePickerFormat.Custom
        dtpPromotions.Location = New Point(116, 20)
        dtpPromotions.Margin = New Padding(3, 2, 3, 2)
        dtpPromotions.Name = "dtpPromotions"
        dtpPromotions.Size = New Size(119, 23)
        dtpPromotions.TabIndex = 11
        ' 
        ' Label81
        ' 
        Label81.AutoSize = True
        Label81.Location = New Point(18, 22)
        Label81.Name = "Label81"
        Label81.Size = New Size(89, 15)
        Label81.TabIndex = 10
        Label81.Text = "Reporting Date:"
        ' 
        ' tabManagement
        ' 
        tabManagement.Controls.Add(pnlManagement)
        tabManagement.Location = New Point(4, 24)
        tabManagement.Margin = New Padding(3, 2, 3, 2)
        tabManagement.Name = "tabManagement"
        tabManagement.Size = New Size(799, 469)
        tabManagement.TabIndex = 3
        tabManagement.Text = "Management"
        tabManagement.UseVisualStyleBackColor = True
        ' 
        ' pnlManagement
        ' 
        pnlManagement.Controls.Add(dgvSocialManagement)
        pnlManagement.Controls.Add(grpManagementFilter)
        pnlManagement.Controls.Add(GroupBoxManagement)
        pnlManagement.Dock = DockStyle.Fill
        pnlManagement.Location = New Point(0, 0)
        pnlManagement.Margin = New Padding(3, 2, 3, 2)
        pnlManagement.Name = "pnlManagement"
        pnlManagement.Size = New Size(799, 469)
        pnlManagement.TabIndex = 2
        ' 
        ' dgvSocialManagement
        ' 
        dgvSocialManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialManagement.Location = New Point(18, 353)
        dgvSocialManagement.Margin = New Padding(3, 2, 3, 2)
        dgvSocialManagement.Name = "dgvSocialManagement"
        dgvSocialManagement.RowHeadersWidth = 51
        dgvSocialManagement.Size = New Size(762, 113)
        dgvSocialManagement.TabIndex = 19
        ' 
        ' grpManagementFilter
        ' 
        grpManagementFilter.Controls.Add(btnClearManagementFilter)
        grpManagementFilter.Controls.Add(btnApplyManagementFilter)
        grpManagementFilter.Controls.Add(dtpManagementFilterMonth)
        grpManagementFilter.Controls.Add(dtpManagementFilterYear)
        grpManagementFilter.Controls.Add(Label101)
        grpManagementFilter.Controls.Add(Label102)
        grpManagementFilter.Location = New Point(18, 297)
        grpManagementFilter.Margin = New Padding(3, 2, 3, 2)
        grpManagementFilter.Name = "grpManagementFilter"
        grpManagementFilter.Padding = New Padding(3, 2, 3, 2)
        grpManagementFilter.Size = New Size(762, 52)
        grpManagementFilter.TabIndex = 18
        grpManagementFilter.TabStop = False
        grpManagementFilter.Text = "Filter Data"
        ' 
        ' btnClearManagementFilter
        ' 
        btnClearManagementFilter.Location = New Point(369, 14)
        btnClearManagementFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearManagementFilter.Name = "btnClearManagementFilter"
        btnClearManagementFilter.Size = New Size(81, 23)
        btnClearManagementFilter.TabIndex = 5
        btnClearManagementFilter.Text = "Clear"
        btnClearManagementFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyManagementFilter
        ' 
        btnApplyManagementFilter.BackColor = SystemColors.Control
        btnApplyManagementFilter.Location = New Point(271, 14)
        btnApplyManagementFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyManagementFilter.Name = "btnApplyManagementFilter"
        btnApplyManagementFilter.Size = New Size(81, 23)
        btnApplyManagementFilter.TabIndex = 4
        btnApplyManagementFilter.Text = "Apply"
        btnApplyManagementFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpManagementFilterMonth
        ' 
        dtpManagementFilterMonth.CustomFormat = "MMMM"
        dtpManagementFilterMonth.Format = DateTimePickerFormat.Custom
        dtpManagementFilterMonth.Location = New Point(175, 14)
        dtpManagementFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpManagementFilterMonth.Name = "dtpManagementFilterMonth"
        dtpManagementFilterMonth.Size = New Size(79, 23)
        dtpManagementFilterMonth.TabIndex = 3
        ' 
        ' dtpManagementFilterYear
        ' 
        dtpManagementFilterYear.CustomFormat = "yyyy"
        dtpManagementFilterYear.Format = DateTimePickerFormat.Custom
        dtpManagementFilterYear.Location = New Point(88, 14)
        dtpManagementFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpManagementFilterYear.Name = "dtpManagementFilterYear"
        dtpManagementFilterYear.ShowUpDown = True
        dtpManagementFilterYear.Size = New Size(62, 23)
        dtpManagementFilterYear.TabIndex = 2
        ' 
        ' Label101
        ' 
        Label101.AutoSize = True
        Label101.Location = New Point(158, 15)
        Label101.Name = "Label101"
        Label101.Size = New Size(21, 15)
        Label101.TabIndex = 1
        Label101.Text = "M:"
        ' 
        ' Label102
        ' 
        Label102.AutoSize = True
        Label102.Location = New Point(52, 15)
        Label102.Name = "Label102"
        Label102.Size = New Size(33, 15)
        Label102.TabIndex = 0
        Label102.Text = "Y/M:"
        ' 
        ' GroupBoxManagement
        ' 
        GroupBoxManagement.Controls.Add(nudMenLeadership)
        GroupBoxManagement.Controls.Add(Label39)
        GroupBoxManagement.Controls.Add(nudWomenLeadership)
        GroupBoxManagement.Controls.Add(btnSaveManagement)
        GroupBoxManagement.Controls.Add(Label40)
        GroupBoxManagement.Controls.Add(btnUpdateManagement)
        GroupBoxManagement.Controls.Add(Label41)
        GroupBoxManagement.Controls.Add(btnCancelManagement)
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
        GroupBoxManagement.Controls.Add(dtpManagement)
        GroupBoxManagement.Controls.Add(Label82)
        GroupBoxManagement.Location = New Point(14, 2)
        GroupBoxManagement.Margin = New Padding(3, 2, 3, 2)
        GroupBoxManagement.Name = "GroupBoxManagement"
        GroupBoxManagement.Padding = New Padding(3, 2, 3, 2)
        GroupBoxManagement.Size = New Size(766, 291)
        GroupBoxManagement.TabIndex = 17
        GroupBoxManagement.TabStop = False
        GroupBoxManagement.Text = "Management Structure"
        ' 
        ' nudMenLeadership
        ' 
        nudMenLeadership.Location = New Point(618, 197)
        nudMenLeadership.Margin = New Padding(3, 2, 3, 2)
        nudMenLeadership.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudMenLeadership.Name = "nudMenLeadership"
        nudMenLeadership.Size = New Size(114, 23)
        nudMenLeadership.TabIndex = 35
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Location = New Point(461, 198)
        Label39.Name = "Label39"
        Label39.Size = New Size(139, 15)
        Label39.TabIndex = 34
        Label39.Text = "Men in Leadership Team:"
        ' 
        ' nudWomenLeadership
        ' 
        nudWomenLeadership.Location = New Point(618, 170)
        nudWomenLeadership.Margin = New Padding(3, 2, 3, 2)
        nudWomenLeadership.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        nudWomenLeadership.Name = "nudWomenLeadership"
        nudWomenLeadership.Size = New Size(114, 23)
        nudWomenLeadership.TabIndex = 33
        ' 
        ' btnSaveManagement
        ' 
        btnSaveManagement.BackColor = SystemColors.Control
        btnSaveManagement.Location = New Point(369, 243)
        btnSaveManagement.Margin = New Padding(3, 2, 3, 2)
        btnSaveManagement.Name = "btnSaveManagement"
        btnSaveManagement.Size = New Size(88, 31)
        btnSaveManagement.TabIndex = 15
        btnSaveManagement.Text = "Save"
        btnSaveManagement.UseVisualStyleBackColor = False
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Location = New Point(443, 172)
        Label40.Name = "Label40"
        Label40.Size = New Size(157, 15)
        Label40.TabIndex = 32
        Label40.Text = "Women in Leadership Team:"
        ' 
        ' btnUpdateManagement
        ' 
        btnUpdateManagement.BackColor = SystemColors.Control
        btnUpdateManagement.Location = New Point(465, 243)
        btnUpdateManagement.Margin = New Padding(3, 2, 3, 2)
        btnUpdateManagement.Name = "btnUpdateManagement"
        btnUpdateManagement.Size = New Size(88, 31)
        btnUpdateManagement.TabIndex = 16
        btnUpdateManagement.Text = "Update"
        btnUpdateManagement.UseVisualStyleBackColor = False
        btnUpdateManagement.Visible = False
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label41.Location = New Point(443, 151)
        Label41.Name = "Label41"
        Label41.Size = New Size(184, 17)
        Label41.TabIndex = 31
        Label41.Text = "Group Leadership Team"
        ' 
        ' btnCancelManagement
        ' 
        btnCancelManagement.BackColor = SystemColors.Control
        btnCancelManagement.Location = New Point(561, 243)
        btnCancelManagement.Margin = New Padding(3, 2, 3, 2)
        btnCancelManagement.Name = "btnCancelManagement"
        btnCancelManagement.Size = New Size(88, 31)
        btnCancelManagement.TabIndex = 17
        btnCancelManagement.Text = "Cancel"
        btnCancelManagement.UseVisualStyleBackColor = False
        btnCancelManagement.Visible = False
        ' 
        ' nudMenUpper
        ' 
        nudMenUpper.Location = New Point(618, 108)
        nudMenUpper.Margin = New Padding(3, 2, 3, 2)
        nudMenUpper.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenUpper.Name = "nudMenUpper"
        nudMenUpper.Size = New Size(114, 23)
        nudMenUpper.TabIndex = 30
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Location = New Point(488, 108)
        Label36.Name = "Label36"
        Label36.Size = New Size(112, 15)
        Label36.TabIndex = 29
        Label36.Text = "Men at Upper Level:"
        ' 
        ' nudWomenUpper
        ' 
        nudWomenUpper.Location = New Point(618, 81)
        nudWomenUpper.Margin = New Padding(3, 2, 3, 2)
        nudWomenUpper.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenUpper.Name = "nudWomenUpper"
        nudWomenUpper.Size = New Size(114, 23)
        nudWomenUpper.TabIndex = 28
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Location = New Point(470, 83)
        Label37.Name = "Label37"
        Label37.Size = New Size(130, 15)
        Label37.TabIndex = 27
        Label37.Text = "Women at Upper Level:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(443, 62)
        Label38.Name = "Label38"
        Label38.Size = New Size(193, 17)
        Label38.TabIndex = 26
        Label38.Text = "Upper Level Management"
        ' 
        ' nudMenMiddle
        ' 
        nudMenMiddle.Location = New Point(284, 192)
        nudMenMiddle.Margin = New Padding(3, 2, 3, 2)
        nudMenMiddle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenMiddle.Name = "nudMenMiddle"
        nudMenMiddle.Size = New Size(114, 23)
        nudMenMiddle.TabIndex = 25
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(127, 193)
        Label33.Name = "Label33"
        Label33.Size = New Size(117, 15)
        Label33.TabIndex = 24
        Label33.Text = "Men at Middle Level:"
        ' 
        ' nudWomenMiddle
        ' 
        nudWomenMiddle.Location = New Point(284, 165)
        nudWomenMiddle.Margin = New Padding(3, 2, 3, 2)
        nudWomenMiddle.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenMiddle.Name = "nudWomenMiddle"
        nudWomenMiddle.Size = New Size(114, 23)
        nudWomenMiddle.TabIndex = 23
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Location = New Point(127, 167)
        Label34.Name = "Label34"
        Label34.Size = New Size(135, 15)
        Label34.TabIndex = 22
        Label34.Text = "Women at Middle Level:"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(6, 145)
        Label35.Name = "Label35"
        Label35.Size = New Size(196, 17)
        Label35.TabIndex = 21
        Label35.Text = "Middle Level Management"
        ' 
        ' nudMenFirstLine
        ' 
        nudMenFirstLine.Location = New Point(284, 108)
        nudMenFirstLine.Margin = New Padding(3, 2, 3, 2)
        nudMenFirstLine.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMenFirstLine.Name = "nudMenFirstLine"
        nudMenFirstLine.Size = New Size(114, 23)
        nudMenFirstLine.TabIndex = 20
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(6, 62)
        Label30.Name = "Label30"
        Label30.Size = New Size(173, 17)
        Label30.TabIndex = 19
        Label30.Text = "First Line Management"
        ' 
        ' nudWomenFirstLine
        ' 
        nudWomenFirstLine.Location = New Point(284, 75)
        nudWomenFirstLine.Margin = New Padding(3, 2, 3, 2)
        nudWomenFirstLine.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudWomenFirstLine.Name = "nudWomenFirstLine"
        nudWomenFirstLine.Size = New Size(114, 23)
        nudWomenFirstLine.TabIndex = 18
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Location = New Point(117, 83)
        Label31.Name = "Label31"
        Label31.Size = New Size(151, 15)
        Label31.TabIndex = 17
        Label31.Text = "Women in First Line Mgmt:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Location = New Point(135, 110)
        Label32.Name = "Label32"
        Label32.Size = New Size(133, 15)
        Label32.TabIndex = 16
        Label32.Text = "Men in First Line Mgmt:"
        ' 
        ' dtpManagement
        ' 
        dtpManagement.CustomFormat = "MMMM yyyy"
        dtpManagement.Format = DateTimePickerFormat.Custom
        dtpManagement.Location = New Point(113, 22)
        dtpManagement.Margin = New Padding(3, 2, 3, 2)
        dtpManagement.Name = "dtpManagement"
        dtpManagement.Size = New Size(122, 23)
        dtpManagement.TabIndex = 12
        ' 
        ' Label82
        ' 
        Label82.AutoSize = True
        Label82.Location = New Point(18, 22)
        Label82.Name = "Label82"
        Label82.Size = New Size(89, 15)
        Label82.TabIndex = 11
        Label82.Text = "Reporting Date:"
        ' 
        ' tabDisabilities
        ' 
        tabDisabilities.Controls.Add(pnlDisabilities)
        tabDisabilities.Location = New Point(4, 24)
        tabDisabilities.Margin = New Padding(3, 2, 3, 2)
        tabDisabilities.Name = "tabDisabilities"
        tabDisabilities.Size = New Size(799, 469)
        tabDisabilities.TabIndex = 4
        tabDisabilities.Text = "Disabilities"
        tabDisabilities.UseVisualStyleBackColor = True
        ' 
        ' pnlDisabilities
        ' 
        pnlDisabilities.Controls.Add(dgvSocialDisabilities)
        pnlDisabilities.Controls.Add(grpDisabilitiesFilter)
        pnlDisabilities.Controls.Add(GroupBoxDisabilities)
        pnlDisabilities.Dock = DockStyle.Fill
        pnlDisabilities.Location = New Point(0, 0)
        pnlDisabilities.Margin = New Padding(3, 2, 3, 2)
        pnlDisabilities.Name = "pnlDisabilities"
        pnlDisabilities.Size = New Size(799, 469)
        pnlDisabilities.TabIndex = 2
        ' 
        ' dgvSocialDisabilities
        ' 
        dgvSocialDisabilities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialDisabilities.Location = New Point(18, 312)
        dgvSocialDisabilities.Margin = New Padding(3, 2, 3, 2)
        dgvSocialDisabilities.Name = "dgvSocialDisabilities"
        dgvSocialDisabilities.RowHeadersWidth = 51
        dgvSocialDisabilities.Size = New Size(762, 146)
        dgvSocialDisabilities.TabIndex = 19
        ' 
        ' grpDisabilitiesFilter
        ' 
        grpDisabilitiesFilter.Controls.Add(btnClearDisabilitiesFilter)
        grpDisabilitiesFilter.Controls.Add(btnApplyDisabilitiesFilter)
        grpDisabilitiesFilter.Controls.Add(dtpDisabilitiesFilterMonth)
        grpDisabilitiesFilter.Controls.Add(dtpDisabilitiesFilterYear)
        grpDisabilitiesFilter.Controls.Add(Label103)
        grpDisabilitiesFilter.Controls.Add(Label104)
        grpDisabilitiesFilter.Location = New Point(18, 259)
        grpDisabilitiesFilter.Margin = New Padding(3, 2, 3, 2)
        grpDisabilitiesFilter.Name = "grpDisabilitiesFilter"
        grpDisabilitiesFilter.Padding = New Padding(3, 2, 3, 2)
        grpDisabilitiesFilter.Size = New Size(762, 49)
        grpDisabilitiesFilter.TabIndex = 18
        grpDisabilitiesFilter.TabStop = False
        grpDisabilitiesFilter.Text = "Filter Data"
        ' 
        ' btnClearDisabilitiesFilter
        ' 
        btnClearDisabilitiesFilter.Location = New Point(350, 14)
        btnClearDisabilitiesFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearDisabilitiesFilter.Name = "btnClearDisabilitiesFilter"
        btnClearDisabilitiesFilter.Size = New Size(74, 23)
        btnClearDisabilitiesFilter.TabIndex = 5
        btnClearDisabilitiesFilter.Text = "Clear"
        btnClearDisabilitiesFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyDisabilitiesFilter
        ' 
        btnApplyDisabilitiesFilter.BackColor = SystemColors.Control
        btnApplyDisabilitiesFilter.Location = New Point(271, 14)
        btnApplyDisabilitiesFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyDisabilitiesFilter.Name = "btnApplyDisabilitiesFilter"
        btnApplyDisabilitiesFilter.Size = New Size(74, 23)
        btnApplyDisabilitiesFilter.TabIndex = 4
        btnApplyDisabilitiesFilter.Text = "Apply"
        btnApplyDisabilitiesFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpDisabilitiesFilterMonth
        ' 
        dtpDisabilitiesFilterMonth.CustomFormat = "MMMM"
        dtpDisabilitiesFilterMonth.Format = DateTimePickerFormat.Custom
        dtpDisabilitiesFilterMonth.Location = New Point(175, 14)
        dtpDisabilitiesFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpDisabilitiesFilterMonth.Name = "dtpDisabilitiesFilterMonth"
        dtpDisabilitiesFilterMonth.Size = New Size(79, 23)
        dtpDisabilitiesFilterMonth.TabIndex = 3
        ' 
        ' dtpDisabilitiesFilterYear
        ' 
        dtpDisabilitiesFilterYear.CustomFormat = "yyyy"
        dtpDisabilitiesFilterYear.Format = DateTimePickerFormat.Custom
        dtpDisabilitiesFilterYear.Location = New Point(88, 14)
        dtpDisabilitiesFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpDisabilitiesFilterYear.Name = "dtpDisabilitiesFilterYear"
        dtpDisabilitiesFilterYear.ShowUpDown = True
        dtpDisabilitiesFilterYear.Size = New Size(62, 23)
        dtpDisabilitiesFilterYear.TabIndex = 2
        ' 
        ' Label103
        ' 
        Label103.AutoSize = True
        Label103.Location = New Point(158, 15)
        Label103.Name = "Label103"
        Label103.Size = New Size(21, 15)
        Label103.TabIndex = 1
        Label103.Text = "M:"
        ' 
        ' Label104
        ' 
        Label104.AutoSize = True
        Label104.Location = New Point(52, 15)
        Label104.Name = "Label104"
        Label104.Size = New Size(33, 15)
        Label104.TabIndex = 0
        Label104.Text = "Y/M:"
        ' 
        ' GroupBoxDisabilities
        ' 
        GroupBoxDisabilities.Controls.Add(nudChronic)
        GroupBoxDisabilities.Controls.Add(Label46)
        GroupBoxDisabilities.Controls.Add(nudIntellectual)
        GroupBoxDisabilities.Controls.Add(btnSaveDisabilities)
        GroupBoxDisabilities.Controls.Add(Label45)
        GroupBoxDisabilities.Controls.Add(btnUpdateDisabilities)
        GroupBoxDisabilities.Controls.Add(nudMentalHealth)
        GroupBoxDisabilities.Controls.Add(btnCancelDisabilities)
        GroupBoxDisabilities.Controls.Add(Label44)
        GroupBoxDisabilities.Controls.Add(nudSensory)
        GroupBoxDisabilities.Controls.Add(Label43)
        GroupBoxDisabilities.Controls.Add(nudPhysical)
        GroupBoxDisabilities.Controls.Add(Label42)
        GroupBoxDisabilities.Controls.Add(dtpDisabilities)
        GroupBoxDisabilities.Controls.Add(Label83)
        GroupBoxDisabilities.Location = New Point(18, 15)
        GroupBoxDisabilities.Margin = New Padding(3, 2, 3, 2)
        GroupBoxDisabilities.Name = "GroupBoxDisabilities"
        GroupBoxDisabilities.Padding = New Padding(3, 2, 3, 2)
        GroupBoxDisabilities.Size = New Size(762, 240)
        GroupBoxDisabilities.TabIndex = 17
        GroupBoxDisabilities.TabStop = False
        GroupBoxDisabilities.Text = "Disabilities Counts"
        ' 
        ' nudChronic
        ' 
        nudChronic.Location = New Point(506, 116)
        nudChronic.Margin = New Padding(3, 2, 3, 2)
        nudChronic.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudChronic.Name = "nudChronic"
        nudChronic.Size = New Size(114, 23)
        nudChronic.TabIndex = 23
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Location = New Point(349, 116)
        Label46.Name = "Label46"
        Label46.Size = New Size(151, 15)
        Label46.TabIndex = 22
        Label46.Text = "Chronic Health Conditions:"
        ' 
        ' nudIntellectual
        ' 
        nudIntellectual.Location = New Point(506, 87)
        nudIntellectual.Margin = New Padding(3, 2, 3, 2)
        nudIntellectual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIntellectual.Name = "nudIntellectual"
        nudIntellectual.Size = New Size(114, 23)
        nudIntellectual.TabIndex = 21
        ' 
        ' btnSaveDisabilities
        ' 
        btnSaveDisabilities.BackColor = SystemColors.Control
        btnSaveDisabilities.Location = New Point(340, 186)
        btnSaveDisabilities.Margin = New Padding(3, 2, 3, 2)
        btnSaveDisabilities.Name = "btnSaveDisabilities"
        btnSaveDisabilities.Size = New Size(88, 31)
        btnSaveDisabilities.TabIndex = 15
        btnSaveDisabilities.Text = "Save"
        btnSaveDisabilities.UseVisualStyleBackColor = False
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Location = New Point(267, 89)
        Label45.Name = "Label45"
        Label45.Size = New Size(233, 15)
        Label45.TabIndex = 20
        Label45.Text = "Intellectual and Developmental Disabilities:"
        ' 
        ' btnUpdateDisabilities
        ' 
        btnUpdateDisabilities.BackColor = SystemColors.Control
        btnUpdateDisabilities.Location = New Point(436, 186)
        btnUpdateDisabilities.Margin = New Padding(3, 2, 3, 2)
        btnUpdateDisabilities.Name = "btnUpdateDisabilities"
        btnUpdateDisabilities.Size = New Size(88, 31)
        btnUpdateDisabilities.TabIndex = 16
        btnUpdateDisabilities.Text = "Update"
        btnUpdateDisabilities.UseVisualStyleBackColor = False
        btnUpdateDisabilities.Visible = False
        ' 
        ' nudMentalHealth
        ' 
        nudMentalHealth.Location = New Point(506, 57)
        nudMentalHealth.Margin = New Padding(3, 2, 3, 2)
        nudMentalHealth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMentalHealth.Name = "nudMentalHealth"
        nudMentalHealth.Size = New Size(114, 23)
        nudMentalHealth.TabIndex = 19
        ' 
        ' btnCancelDisabilities
        ' 
        btnCancelDisabilities.BackColor = SystemColors.Control
        btnCancelDisabilities.Location = New Point(532, 186)
        btnCancelDisabilities.Margin = New Padding(3, 2, 3, 2)
        btnCancelDisabilities.Name = "btnCancelDisabilities"
        btnCancelDisabilities.Size = New Size(88, 31)
        btnCancelDisabilities.TabIndex = 17
        btnCancelDisabilities.Text = "Cancel"
        btnCancelDisabilities.UseVisualStyleBackColor = False
        btnCancelDisabilities.Visible = False
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Location = New Point(354, 59)
        Label44.Name = "Label44"
        Label44.Size = New Size(146, 15)
        Label44.TabIndex = 18
        Label44.Text = "Mental Health Conditions:"
        ' 
        ' nudSensory
        ' 
        nudSensory.Location = New Point(140, 87)
        nudSensory.Margin = New Padding(3, 2, 3, 2)
        nudSensory.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSensory.Name = "nudSensory"
        nudSensory.Size = New Size(114, 23)
        nudSensory.TabIndex = 17
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Location = New Point(18, 89)
        Label43.Name = "Label43"
        Label43.Size = New Size(110, 15)
        Label43.TabIndex = 16
        Label43.Text = "Sensory Disabilities:"
        ' 
        ' nudPhysical
        ' 
        nudPhysical.Location = New Point(140, 57)
        nudPhysical.Margin = New Padding(3, 2, 3, 2)
        nudPhysical.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPhysical.Name = "nudPhysical"
        nudPhysical.Size = New Size(114, 23)
        nudPhysical.TabIndex = 15
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Location = New Point(18, 59)
        Label42.Name = "Label42"
        Label42.Size = New Size(112, 15)
        Label42.TabIndex = 14
        Label42.Text = "Physical Disabilities:"
        ' 
        ' dtpDisabilities
        ' 
        dtpDisabilities.CustomFormat = "MMMM yyyy"
        dtpDisabilities.Format = DateTimePickerFormat.Custom
        dtpDisabilities.Location = New Point(140, 22)
        dtpDisabilities.Margin = New Padding(3, 2, 3, 2)
        dtpDisabilities.Name = "dtpDisabilities"
        dtpDisabilities.Size = New Size(114, 23)
        dtpDisabilities.TabIndex = 13
        ' 
        ' Label83
        ' 
        Label83.AutoSize = True
        Label83.Location = New Point(18, 22)
        Label83.Name = "Label83"
        Label83.Size = New Size(89, 15)
        Label83.TabIndex = 12
        Label83.Text = "Reporting Date:"
        ' 
        ' tabBehavior
        ' 
        tabBehavior.Controls.Add(pnlBehavior)
        tabBehavior.Location = New Point(4, 24)
        tabBehavior.Margin = New Padding(3, 2, 3, 2)
        tabBehavior.Name = "tabBehavior"
        tabBehavior.Size = New Size(799, 469)
        tabBehavior.TabIndex = 5
        tabBehavior.Text = "Behavior"
        tabBehavior.UseVisualStyleBackColor = True
        ' 
        ' pnlBehavior
        ' 
        pnlBehavior.Controls.Add(dgvSocialBehavior)
        pnlBehavior.Controls.Add(grpBehaviorFilter)
        pnlBehavior.Controls.Add(GroupBoxBehavior)
        pnlBehavior.Dock = DockStyle.Fill
        pnlBehavior.Location = New Point(0, 0)
        pnlBehavior.Margin = New Padding(3, 2, 3, 2)
        pnlBehavior.Name = "pnlBehavior"
        pnlBehavior.Size = New Size(799, 469)
        pnlBehavior.TabIndex = 2
        ' 
        ' dgvSocialBehavior
        ' 
        dgvSocialBehavior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialBehavior.Location = New Point(18, 274)
        dgvSocialBehavior.Margin = New Padding(3, 2, 3, 2)
        dgvSocialBehavior.Name = "dgvSocialBehavior"
        dgvSocialBehavior.RowHeadersWidth = 51
        dgvSocialBehavior.Size = New Size(762, 184)
        dgvSocialBehavior.TabIndex = 19
        ' 
        ' grpBehaviorFilter
        ' 
        grpBehaviorFilter.Controls.Add(btnClearBehaviorFilter)
        grpBehaviorFilter.Controls.Add(btnApplyBehaviorFilter)
        grpBehaviorFilter.Controls.Add(dtpBehaviorFilterMonth)
        grpBehaviorFilter.Controls.Add(dtpBehaviorFilterYear)
        grpBehaviorFilter.Controls.Add(Label105)
        grpBehaviorFilter.Controls.Add(Label106)
        grpBehaviorFilter.Location = New Point(18, 221)
        grpBehaviorFilter.Margin = New Padding(3, 2, 3, 2)
        grpBehaviorFilter.Name = "grpBehaviorFilter"
        grpBehaviorFilter.Padding = New Padding(3, 2, 3, 2)
        grpBehaviorFilter.Size = New Size(762, 49)
        grpBehaviorFilter.TabIndex = 18
        grpBehaviorFilter.TabStop = False
        grpBehaviorFilter.Text = "Filter Data"
        ' 
        ' btnClearBehaviorFilter
        ' 
        btnClearBehaviorFilter.Location = New Point(350, 14)
        btnClearBehaviorFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearBehaviorFilter.Name = "btnClearBehaviorFilter"
        btnClearBehaviorFilter.Size = New Size(71, 23)
        btnClearBehaviorFilter.TabIndex = 5
        btnClearBehaviorFilter.Text = "Clear"
        btnClearBehaviorFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyBehaviorFilter
        ' 
        btnApplyBehaviorFilter.BackColor = SystemColors.Control
        btnApplyBehaviorFilter.Location = New Point(271, 14)
        btnApplyBehaviorFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyBehaviorFilter.Name = "btnApplyBehaviorFilter"
        btnApplyBehaviorFilter.Size = New Size(71, 23)
        btnApplyBehaviorFilter.TabIndex = 4
        btnApplyBehaviorFilter.Text = "Apply"
        btnApplyBehaviorFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpBehaviorFilterMonth
        ' 
        dtpBehaviorFilterMonth.CustomFormat = "MMMM"
        dtpBehaviorFilterMonth.Format = DateTimePickerFormat.Custom
        dtpBehaviorFilterMonth.Location = New Point(175, 15)
        dtpBehaviorFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpBehaviorFilterMonth.Name = "dtpBehaviorFilterMonth"
        dtpBehaviorFilterMonth.Size = New Size(79, 23)
        dtpBehaviorFilterMonth.TabIndex = 3
        ' 
        ' dtpBehaviorFilterYear
        ' 
        dtpBehaviorFilterYear.CustomFormat = "yyyy"
        dtpBehaviorFilterYear.Format = DateTimePickerFormat.Custom
        dtpBehaviorFilterYear.Location = New Point(88, 14)
        dtpBehaviorFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpBehaviorFilterYear.Name = "dtpBehaviorFilterYear"
        dtpBehaviorFilterYear.ShowUpDown = True
        dtpBehaviorFilterYear.Size = New Size(62, 23)
        dtpBehaviorFilterYear.TabIndex = 2
        ' 
        ' Label105
        ' 
        Label105.AutoSize = True
        Label105.Location = New Point(158, 15)
        Label105.Name = "Label105"
        Label105.Size = New Size(21, 15)
        Label105.TabIndex = 1
        Label105.Text = "M:"
        ' 
        ' Label106
        ' 
        Label106.AutoSize = True
        Label106.Location = New Point(52, 15)
        Label106.Name = "Label106"
        Label106.Size = New Size(33, 15)
        Label106.TabIndex = 0
        Label106.Text = "Y/M:"
        ' 
        ' GroupBoxBehavior
        ' 
        GroupBoxBehavior.Controls.Add(nudPansexual)
        GroupBoxBehavior.Controls.Add(Label51)
        GroupBoxBehavior.Controls.Add(nudAsexual)
        GroupBoxBehavior.Controls.Add(btnSaveBehavior)
        GroupBoxBehavior.Controls.Add(Label50)
        GroupBoxBehavior.Controls.Add(btnUpdateBehavior)
        GroupBoxBehavior.Controls.Add(nudBisexual)
        GroupBoxBehavior.Controls.Add(btnCancelBehavior)
        GroupBoxBehavior.Controls.Add(Label49)
        GroupBoxBehavior.Controls.Add(nudGay)
        GroupBoxBehavior.Controls.Add(Label48)
        GroupBoxBehavior.Controls.Add(nudLesbian)
        GroupBoxBehavior.Controls.Add(Label47)
        GroupBoxBehavior.Controls.Add(dtpBehavior)
        GroupBoxBehavior.Controls.Add(Label84)
        GroupBoxBehavior.Location = New Point(18, 15)
        GroupBoxBehavior.Margin = New Padding(3, 2, 3, 2)
        GroupBoxBehavior.Name = "GroupBoxBehavior"
        GroupBoxBehavior.Padding = New Padding(3, 2, 3, 2)
        GroupBoxBehavior.Size = New Size(762, 202)
        GroupBoxBehavior.TabIndex = 17
        GroupBoxBehavior.TabStop = False
        GroupBoxBehavior.Text = "Sexual Orientation Counts"
        ' 
        ' nudPansexual
        ' 
        nudPansexual.Location = New Point(140, 119)
        nudPansexual.Margin = New Padding(3, 2, 3, 2)
        nudPansexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPansexual.Name = "nudPansexual"
        nudPansexual.Size = New Size(114, 23)
        nudPansexual.TabIndex = 23
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Location = New Point(44, 121)
        Label51.Name = "Label51"
        Label51.Size = New Size(62, 15)
        Label51.TabIndex = 22
        Label51.Text = "Pansexual:"
        ' 
        ' nudAsexual
        ' 
        nudAsexual.Location = New Point(407, 84)
        nudAsexual.Margin = New Padding(3, 2, 3, 2)
        nudAsexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAsexual.Name = "nudAsexual"
        nudAsexual.Size = New Size(114, 23)
        nudAsexual.TabIndex = 21
        ' 
        ' btnSaveBehavior
        ' 
        btnSaveBehavior.BackColor = SystemColors.Control
        btnSaveBehavior.Location = New Point(337, 140)
        btnSaveBehavior.Margin = New Padding(3, 2, 3, 2)
        btnSaveBehavior.Name = "btnSaveBehavior"
        btnSaveBehavior.Size = New Size(88, 28)
        btnSaveBehavior.TabIndex = 15
        btnSaveBehavior.Text = "Save"
        btnSaveBehavior.UseVisualStyleBackColor = False
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Location = New Point(337, 86)
        Label50.Name = "Label50"
        Label50.Size = New Size(50, 15)
        Label50.TabIndex = 20
        Label50.Text = "Asexual:"
        ' 
        ' btnUpdateBehavior
        ' 
        btnUpdateBehavior.BackColor = SystemColors.Control
        btnUpdateBehavior.Location = New Point(433, 140)
        btnUpdateBehavior.Margin = New Padding(3, 2, 3, 2)
        btnUpdateBehavior.Name = "btnUpdateBehavior"
        btnUpdateBehavior.Size = New Size(88, 28)
        btnUpdateBehavior.TabIndex = 16
        btnUpdateBehavior.Text = "Update"
        btnUpdateBehavior.UseVisualStyleBackColor = False
        btnUpdateBehavior.Visible = False
        ' 
        ' nudBisexual
        ' 
        nudBisexual.Location = New Point(407, 54)
        nudBisexual.Margin = New Padding(3, 2, 3, 2)
        nudBisexual.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudBisexual.Name = "nudBisexual"
        nudBisexual.Size = New Size(114, 23)
        nudBisexual.TabIndex = 19
        ' 
        ' btnCancelBehavior
        ' 
        btnCancelBehavior.BackColor = SystemColors.Control
        btnCancelBehavior.Location = New Point(529, 140)
        btnCancelBehavior.Margin = New Padding(3, 2, 3, 2)
        btnCancelBehavior.Name = "btnCancelBehavior"
        btnCancelBehavior.Size = New Size(88, 28)
        btnCancelBehavior.TabIndex = 17
        btnCancelBehavior.Text = "Cancel"
        btnCancelBehavior.UseVisualStyleBackColor = False
        btnCancelBehavior.Visible = False
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Location = New Point(335, 56)
        Label49.Name = "Label49"
        Label49.Size = New Size(52, 15)
        Label49.TabIndex = 18
        Label49.Text = "Bisexual:"
        ' 
        ' nudGay
        ' 
        nudGay.Location = New Point(140, 84)
        nudGay.Margin = New Padding(3, 2, 3, 2)
        nudGay.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudGay.Name = "nudGay"
        nudGay.Size = New Size(114, 23)
        nudGay.TabIndex = 17
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Location = New Point(44, 86)
        Label48.Name = "Label48"
        Label48.Size = New Size(30, 15)
        Label48.TabIndex = 16
        Label48.Text = "Gay:"
        ' 
        ' nudLesbian
        ' 
        nudLesbian.Location = New Point(140, 54)
        nudLesbian.Margin = New Padding(3, 2, 3, 2)
        nudLesbian.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudLesbian.Name = "nudLesbian"
        nudLesbian.Size = New Size(114, 23)
        nudLesbian.TabIndex = 15
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Location = New Point(44, 56)
        Label47.Name = "Label47"
        Label47.Size = New Size(50, 15)
        Label47.TabIndex = 14
        Label47.Text = "Lesbian:"
        ' 
        ' dtpBehavior
        ' 
        dtpBehavior.CustomFormat = "MMMM yyyy"
        dtpBehavior.Format = DateTimePickerFormat.Custom
        dtpBehavior.Location = New Point(105, 19)
        dtpBehavior.Margin = New Padding(3, 2, 3, 2)
        dtpBehavior.Name = "dtpBehavior"
        dtpBehavior.Size = New Size(158, 23)
        dtpBehavior.TabIndex = 13
        ' 
        ' Label84
        ' 
        Label84.AutoSize = True
        Label84.Location = New Point(18, 22)
        Label84.Name = "Label84"
        Label84.Size = New Size(89, 15)
        Label84.TabIndex = 12
        Label84.Text = "Reporting Date:"
        ' 
        ' tabIdentification
        ' 
        tabIdentification.Controls.Add(pnlIdentification)
        tabIdentification.Location = New Point(4, 24)
        tabIdentification.Margin = New Padding(3, 2, 3, 2)
        tabIdentification.Name = "tabIdentification"
        tabIdentification.Size = New Size(799, 469)
        tabIdentification.TabIndex = 6
        tabIdentification.Text = "Gender Identification"
        tabIdentification.UseVisualStyleBackColor = True
        ' 
        ' pnlIdentification
        ' 
        pnlIdentification.Controls.Add(dgvSocialIdentification)
        pnlIdentification.Controls.Add(grpIdentificationFilter)
        pnlIdentification.Controls.Add(GroupBoxIdentification)
        pnlIdentification.Dock = DockStyle.Fill
        pnlIdentification.Location = New Point(0, 0)
        pnlIdentification.Margin = New Padding(3, 2, 3, 2)
        pnlIdentification.Name = "pnlIdentification"
        pnlIdentification.Size = New Size(799, 469)
        pnlIdentification.TabIndex = 2
        ' 
        ' dgvSocialIdentification
        ' 
        dgvSocialIdentification.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialIdentification.Location = New Point(18, 290)
        dgvSocialIdentification.Margin = New Padding(3, 2, 3, 2)
        dgvSocialIdentification.Name = "dgvSocialIdentification"
        dgvSocialIdentification.RowHeadersWidth = 51
        dgvSocialIdentification.Size = New Size(762, 168)
        dgvSocialIdentification.TabIndex = 19
        ' 
        ' grpIdentificationFilter
        ' 
        grpIdentificationFilter.Controls.Add(btnClearIdentificationFilter)
        grpIdentificationFilter.Controls.Add(btnApplyIdentificationFilter)
        grpIdentificationFilter.Controls.Add(dtpIdentificationFilterMonth)
        grpIdentificationFilter.Controls.Add(dtpIdentificationFilterYear)
        grpIdentificationFilter.Controls.Add(Label107)
        grpIdentificationFilter.Controls.Add(Label108)
        grpIdentificationFilter.Location = New Point(18, 237)
        grpIdentificationFilter.Margin = New Padding(3, 2, 3, 2)
        grpIdentificationFilter.Name = "grpIdentificationFilter"
        grpIdentificationFilter.Padding = New Padding(3, 2, 3, 2)
        grpIdentificationFilter.Size = New Size(762, 49)
        grpIdentificationFilter.TabIndex = 18
        grpIdentificationFilter.TabStop = False
        grpIdentificationFilter.Text = "Filter Data"
        ' 
        ' btnClearIdentificationFilter
        ' 
        btnClearIdentificationFilter.Location = New Point(350, 14)
        btnClearIdentificationFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearIdentificationFilter.Name = "btnClearIdentificationFilter"
        btnClearIdentificationFilter.Size = New Size(78, 23)
        btnClearIdentificationFilter.TabIndex = 5
        btnClearIdentificationFilter.Text = "Clear"
        btnClearIdentificationFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyIdentificationFilter
        ' 
        btnApplyIdentificationFilter.BackColor = SystemColors.Control
        btnApplyIdentificationFilter.Location = New Point(271, 14)
        btnApplyIdentificationFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyIdentificationFilter.Name = "btnApplyIdentificationFilter"
        btnApplyIdentificationFilter.Size = New Size(78, 23)
        btnApplyIdentificationFilter.TabIndex = 4
        btnApplyIdentificationFilter.Text = "Apply"
        btnApplyIdentificationFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpIdentificationFilterMonth
        ' 
        dtpIdentificationFilterMonth.CustomFormat = "MMMM"
        dtpIdentificationFilterMonth.Format = DateTimePickerFormat.Custom
        dtpIdentificationFilterMonth.Location = New Point(175, 14)
        dtpIdentificationFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpIdentificationFilterMonth.Name = "dtpIdentificationFilterMonth"
        dtpIdentificationFilterMonth.Size = New Size(79, 23)
        dtpIdentificationFilterMonth.TabIndex = 3
        ' 
        ' dtpIdentificationFilterYear
        ' 
        dtpIdentificationFilterYear.CustomFormat = "yyyy"
        dtpIdentificationFilterYear.Format = DateTimePickerFormat.Custom
        dtpIdentificationFilterYear.Location = New Point(88, 14)
        dtpIdentificationFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpIdentificationFilterYear.Name = "dtpIdentificationFilterYear"
        dtpIdentificationFilterYear.ShowUpDown = True
        dtpIdentificationFilterYear.Size = New Size(62, 23)
        dtpIdentificationFilterYear.TabIndex = 2
        ' 
        ' Label107
        ' 
        Label107.AutoSize = True
        Label107.Location = New Point(158, 15)
        Label107.Name = "Label107"
        Label107.Size = New Size(21, 15)
        Label107.TabIndex = 1
        Label107.Text = "M:"
        ' 
        ' Label108
        ' 
        Label108.AutoSize = True
        Label108.Location = New Point(52, 15)
        Label108.Name = "Label108"
        Label108.Size = New Size(33, 15)
        Label108.TabIndex = 0
        Label108.Text = "Y/M:"
        ' 
        ' GroupBoxIdentification
        ' 
        GroupBoxIdentification.Controls.Add(nudAgender)
        GroupBoxIdentification.Controls.Add(Label56)
        GroupBoxIdentification.Controls.Add(nudNonBinary)
        GroupBoxIdentification.Controls.Add(btnSaveIdentification)
        GroupBoxIdentification.Controls.Add(Label55)
        GroupBoxIdentification.Controls.Add(btnUpdateIdentification)
        GroupBoxIdentification.Controls.Add(nudQuestioning)
        GroupBoxIdentification.Controls.Add(btnCancelIdentification)
        GroupBoxIdentification.Controls.Add(Label54)
        GroupBoxIdentification.Controls.Add(nudQueer)
        GroupBoxIdentification.Controls.Add(Label53)
        GroupBoxIdentification.Controls.Add(nudTransgender)
        GroupBoxIdentification.Controls.Add(Label52)
        GroupBoxIdentification.Controls.Add(dtpIdentification)
        GroupBoxIdentification.Controls.Add(Label85)
        GroupBoxIdentification.Location = New Point(18, 15)
        GroupBoxIdentification.Margin = New Padding(3, 2, 3, 2)
        GroupBoxIdentification.Name = "GroupBoxIdentification"
        GroupBoxIdentification.Padding = New Padding(3, 2, 3, 2)
        GroupBoxIdentification.Size = New Size(762, 202)
        GroupBoxIdentification.TabIndex = 17
        GroupBoxIdentification.TabStop = False
        GroupBoxIdentification.Text = "Gender Identity Counts"
        ' 
        ' nudAgender
        ' 
        nudAgender.Location = New Point(405, 112)
        nudAgender.Margin = New Padding(3, 2, 3, 2)
        nudAgender.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAgender.Name = "nudAgender"
        nudAgender.Size = New Size(114, 23)
        nudAgender.TabIndex = 23
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Location = New Point(342, 114)
        Label56.Name = "Label56"
        Label56.Size = New Size(55, 15)
        Label56.TabIndex = 22
        Label56.Text = "Agender:"
        ' 
        ' nudNonBinary
        ' 
        nudNonBinary.Location = New Point(405, 82)
        nudNonBinary.Margin = New Padding(3, 2, 3, 2)
        nudNonBinary.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNonBinary.Name = "nudNonBinary"
        nudNonBinary.Size = New Size(114, 23)
        nudNonBinary.TabIndex = 21
        ' 
        ' btnSaveIdentification
        ' 
        btnSaveIdentification.BackColor = SystemColors.Control
        btnSaveIdentification.Location = New Point(350, 160)
        btnSaveIdentification.Margin = New Padding(3, 2, 3, 2)
        btnSaveIdentification.Name = "btnSaveIdentification"
        btnSaveIdentification.Size = New Size(88, 26)
        btnSaveIdentification.TabIndex = 15
        btnSaveIdentification.Text = "Save"
        btnSaveIdentification.UseVisualStyleBackColor = False
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Location = New Point(326, 84)
        Label55.Name = "Label55"
        Label55.Size = New Size(71, 15)
        Label55.TabIndex = 20
        Label55.Text = "Non-binary:"
        ' 
        ' btnUpdateIdentification
        ' 
        btnUpdateIdentification.BackColor = SystemColors.Control
        btnUpdateIdentification.Location = New Point(446, 160)
        btnUpdateIdentification.Margin = New Padding(3, 2, 3, 2)
        btnUpdateIdentification.Name = "btnUpdateIdentification"
        btnUpdateIdentification.Size = New Size(88, 26)
        btnUpdateIdentification.TabIndex = 16
        btnUpdateIdentification.Text = "Update"
        btnUpdateIdentification.UseVisualStyleBackColor = False
        btnUpdateIdentification.Visible = False
        ' 
        ' nudQuestioning
        ' 
        nudQuestioning.Location = New Point(405, 52)
        nudQuestioning.Margin = New Padding(3, 2, 3, 2)
        nudQuestioning.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudQuestioning.Name = "nudQuestioning"
        nudQuestioning.Size = New Size(114, 23)
        nudQuestioning.TabIndex = 19
        ' 
        ' btnCancelIdentification
        ' 
        btnCancelIdentification.BackColor = SystemColors.Control
        btnCancelIdentification.Location = New Point(542, 160)
        btnCancelIdentification.Margin = New Padding(3, 2, 3, 2)
        btnCancelIdentification.Name = "btnCancelIdentification"
        btnCancelIdentification.Size = New Size(88, 26)
        btnCancelIdentification.TabIndex = 17
        btnCancelIdentification.Text = "Cancel"
        btnCancelIdentification.UseVisualStyleBackColor = False
        btnCancelIdentification.Visible = False
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Location = New Point(326, 54)
        Label54.Name = "Label54"
        Label54.Size = New Size(75, 15)
        Label54.TabIndex = 18
        Label54.Text = "Questioning:"
        ' 
        ' nudQueer
        ' 
        nudQueer.Location = New Point(120, 82)
        nudQueer.Margin = New Padding(3, 2, 3, 2)
        nudQueer.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudQueer.Name = "nudQueer"
        nudQueer.Size = New Size(114, 23)
        nudQueer.TabIndex = 17
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Location = New Point(24, 84)
        Label53.Name = "Label53"
        Label53.Size = New Size(42, 15)
        Label53.TabIndex = 16
        Label53.Text = "Queer:"
        ' 
        ' nudTransgender
        ' 
        nudTransgender.Location = New Point(120, 52)
        nudTransgender.Margin = New Padding(3, 2, 3, 2)
        nudTransgender.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudTransgender.Name = "nudTransgender"
        nudTransgender.Size = New Size(114, 23)
        nudTransgender.TabIndex = 15
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Location = New Point(24, 54)
        Label52.Name = "Label52"
        Label52.Size = New Size(75, 15)
        Label52.TabIndex = 14
        Label52.Text = "Transgender:"
        ' 
        ' dtpIdentification
        ' 
        dtpIdentification.CustomFormat = "MMMM yyyy"
        dtpIdentification.Format = DateTimePickerFormat.Custom
        dtpIdentification.Location = New Point(120, 20)
        dtpIdentification.Margin = New Padding(3, 2, 3, 2)
        dtpIdentification.Name = "dtpIdentification"
        dtpIdentification.Size = New Size(114, 23)
        dtpIdentification.TabIndex = 13
        ' 
        ' Label85
        ' 
        Label85.AutoSize = True
        Label85.Location = New Point(18, 22)
        Label85.Name = "Label85"
        Label85.Size = New Size(89, 15)
        Label85.TabIndex = 12
        Label85.Text = "Reporting Date:"
        ' 
        ' tabNations
        ' 
        tabNations.Controls.Add(pnlNations)
        tabNations.Location = New Point(4, 24)
        tabNations.Margin = New Padding(3, 2, 3, 2)
        tabNations.Name = "tabNations"
        tabNations.Size = New Size(799, 469)
        tabNations.TabIndex = 7
        tabNations.Text = "Nations"
        tabNations.UseVisualStyleBackColor = True
        ' 
        ' pnlNations
        ' 
        pnlNations.Controls.Add(dgvSocialNations)
        pnlNations.Controls.Add(grpNationsFilter)
        pnlNations.Controls.Add(GroupBoxNations)
        pnlNations.Dock = DockStyle.Fill
        pnlNations.Location = New Point(0, 0)
        pnlNations.Margin = New Padding(3, 2, 3, 2)
        pnlNations.Name = "pnlNations"
        pnlNations.Size = New Size(799, 469)
        pnlNations.TabIndex = 2
        ' 
        ' dgvSocialNations
        ' 
        dgvSocialNations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialNations.Location = New Point(23, 289)
        dgvSocialNations.Margin = New Padding(3, 2, 3, 2)
        dgvSocialNations.Name = "dgvSocialNations"
        dgvSocialNations.RowHeadersWidth = 51
        dgvSocialNations.Size = New Size(748, 177)
        dgvSocialNations.TabIndex = 19
        ' 
        ' grpNationsFilter
        ' 
        grpNationsFilter.Controls.Add(btnClearNationsFilter)
        grpNationsFilter.Controls.Add(btnApplyNationsFilter)
        grpNationsFilter.Controls.Add(dtpNationsFilterMonth)
        grpNationsFilter.Controls.Add(dtpNationsFilterYear)
        grpNationsFilter.Controls.Add(Label109)
        grpNationsFilter.Controls.Add(Label110)
        grpNationsFilter.Location = New Point(18, 234)
        grpNationsFilter.Margin = New Padding(3, 2, 3, 2)
        grpNationsFilter.Name = "grpNationsFilter"
        grpNationsFilter.Padding = New Padding(3, 2, 3, 2)
        grpNationsFilter.Size = New Size(753, 51)
        grpNationsFilter.TabIndex = 18
        grpNationsFilter.TabStop = False
        grpNationsFilter.Text = "Filter Data"
        ' 
        ' btnClearNationsFilter
        ' 
        btnClearNationsFilter.Location = New Point(350, 14)
        btnClearNationsFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearNationsFilter.Name = "btnClearNationsFilter"
        btnClearNationsFilter.Size = New Size(70, 23)
        btnClearNationsFilter.TabIndex = 5
        btnClearNationsFilter.Text = "Clear"
        btnClearNationsFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyNationsFilter
        ' 
        btnApplyNationsFilter.BackColor = SystemColors.Control
        btnApplyNationsFilter.Location = New Point(271, 14)
        btnApplyNationsFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyNationsFilter.Name = "btnApplyNationsFilter"
        btnApplyNationsFilter.Size = New Size(70, 23)
        btnApplyNationsFilter.TabIndex = 4
        btnApplyNationsFilter.Text = "Apply"
        btnApplyNationsFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpNationsFilterMonth
        ' 
        dtpNationsFilterMonth.CustomFormat = "MMMM"
        dtpNationsFilterMonth.Format = DateTimePickerFormat.Custom
        dtpNationsFilterMonth.Location = New Point(174, 12)
        dtpNationsFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpNationsFilterMonth.Name = "dtpNationsFilterMonth"
        dtpNationsFilterMonth.Size = New Size(79, 23)
        dtpNationsFilterMonth.TabIndex = 3
        ' 
        ' dtpNationsFilterYear
        ' 
        dtpNationsFilterYear.CustomFormat = "yyyy"
        dtpNationsFilterYear.Format = DateTimePickerFormat.Custom
        dtpNationsFilterYear.Location = New Point(88, 14)
        dtpNationsFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpNationsFilterYear.Name = "dtpNationsFilterYear"
        dtpNationsFilterYear.ShowUpDown = True
        dtpNationsFilterYear.Size = New Size(62, 23)
        dtpNationsFilterYear.TabIndex = 2
        ' 
        ' Label109
        ' 
        Label109.AutoSize = True
        Label109.Location = New Point(158, 15)
        Label109.Name = "Label109"
        Label109.Size = New Size(21, 15)
        Label109.TabIndex = 1
        Label109.Text = "M:"
        ' 
        ' Label110
        ' 
        Label110.AutoSize = True
        Label110.Location = New Point(52, 15)
        Label110.Name = "Label110"
        Label110.Size = New Size(33, 15)
        Label110.TabIndex = 0
        Label110.Text = "Y/M:"
        ' 
        ' GroupBoxNations
        ' 
        GroupBoxNations.Controls.Add(txtOtherEthnicitySpecify)
        GroupBoxNations.Controls.Add(Label63)
        GroupBoxNations.Controls.Add(nudOtherEthnicity)
        GroupBoxNations.Controls.Add(btnSaveNations)
        GroupBoxNations.Controls.Add(Label62)
        GroupBoxNations.Controls.Add(btnUpdateNations)
        GroupBoxNations.Controls.Add(nudEuropean)
        GroupBoxNations.Controls.Add(btnCancelNations)
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
        GroupBoxNations.Controls.Add(dtpNations)
        GroupBoxNations.Controls.Add(Label86)
        GroupBoxNations.Location = New Point(18, 15)
        GroupBoxNations.Margin = New Padding(3, 2, 3, 2)
        GroupBoxNations.Name = "GroupBoxNations"
        GroupBoxNations.Padding = New Padding(3, 2, 3, 2)
        GroupBoxNations.Size = New Size(753, 215)
        GroupBoxNations.TabIndex = 17
        GroupBoxNations.TabStop = False
        GroupBoxNations.Text = "Ethnicity/Nations Counts"
        ' 
        ' txtOtherEthnicitySpecify
        ' 
        txtOtherEthnicitySpecify.Location = New Point(505, 141)
        txtOtherEthnicitySpecify.Margin = New Padding(3, 2, 3, 2)
        txtOtherEthnicitySpecify.Name = "txtOtherEthnicitySpecify"
        txtOtherEthnicitySpecify.Size = New Size(114, 23)
        txtOtherEthnicitySpecify.TabIndex = 31
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Location = New Point(409, 144)
        Label63.Name = "Label63"
        Label63.Size = New Size(88, 15)
        Label63.TabIndex = 30
        Label63.Text = "Other (specify):"
        ' 
        ' nudOtherEthnicity
        ' 
        nudOtherEthnicity.Location = New Point(505, 111)
        nudOtherEthnicity.Margin = New Padding(3, 2, 3, 2)
        nudOtherEthnicity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherEthnicity.Name = "nudOtherEthnicity"
        nudOtherEthnicity.Size = New Size(114, 23)
        nudOtherEthnicity.TabIndex = 29
        ' 
        ' btnSaveNations
        ' 
        btnSaveNations.BackColor = SystemColors.Control
        btnSaveNations.Location = New Point(464, 174)
        btnSaveNations.Margin = New Padding(3, 2, 3, 2)
        btnSaveNations.Name = "btnSaveNations"
        btnSaveNations.Size = New Size(88, 31)
        btnSaveNations.TabIndex = 15
        btnSaveNations.Text = "Save"
        btnSaveNations.UseVisualStyleBackColor = False
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Location = New Point(409, 113)
        Label62.Name = "Label62"
        Label62.Size = New Size(89, 15)
        Label62.TabIndex = 28
        Label62.Text = "Other Ethnicity:"
        ' 
        ' btnUpdateNations
        ' 
        btnUpdateNations.BackColor = SystemColors.Control
        btnUpdateNations.Location = New Point(558, 174)
        btnUpdateNations.Margin = New Padding(3, 2, 3, 2)
        btnUpdateNations.Name = "btnUpdateNations"
        btnUpdateNations.Size = New Size(88, 31)
        btnUpdateNations.TabIndex = 16
        btnUpdateNations.Text = "Update"
        btnUpdateNations.UseVisualStyleBackColor = False
        btnUpdateNations.Visible = False
        ' 
        ' nudEuropean
        ' 
        nudEuropean.Location = New Point(505, 81)
        nudEuropean.Margin = New Padding(3, 2, 3, 2)
        nudEuropean.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudEuropean.Name = "nudEuropean"
        nudEuropean.Size = New Size(114, 23)
        nudEuropean.TabIndex = 27
        ' 
        ' btnCancelNations
        ' 
        btnCancelNations.BackColor = SystemColors.Control
        btnCancelNations.Location = New Point(654, 174)
        btnCancelNations.Margin = New Padding(3, 2, 3, 2)
        btnCancelNations.Name = "btnCancelNations"
        btnCancelNations.Size = New Size(88, 31)
        btnCancelNations.TabIndex = 17
        btnCancelNations.Text = "Cancel"
        btnCancelNations.UseVisualStyleBackColor = False
        btnCancelNations.Visible = False
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Location = New Point(437, 83)
        Label61.Name = "Label61"
        Label61.Size = New Size(60, 15)
        Label61.TabIndex = 26
        Label61.Text = "European:"
        ' 
        ' nudPacificIslander
        ' 
        nudPacificIslander.Location = New Point(505, 51)
        nudPacificIslander.Margin = New Padding(3, 2, 3, 2)
        nudPacificIslander.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudPacificIslander.Name = "nudPacificIslander"
        nudPacificIslander.Size = New Size(114, 23)
        nudPacificIslander.TabIndex = 25
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Location = New Point(408, 56)
        Label60.Name = "Label60"
        Label60.Size = New Size(89, 15)
        Label60.TabIndex = 24
        Label60.Text = "Pacific Islander:"
        ' 
        ' nudMiddleEastern
        ' 
        nudMiddleEastern.Location = New Point(227, 165)
        nudMiddleEastern.Margin = New Padding(3, 2, 3, 2)
        nudMiddleEastern.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudMiddleEastern.Name = "nudMiddleEastern"
        nudMiddleEastern.Size = New Size(114, 23)
        nudMiddleEastern.TabIndex = 23
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Location = New Point(114, 167)
        Label59.Name = "Label59"
        Label59.Size = New Size(88, 15)
        Label59.TabIndex = 22
        Label59.Text = "Middle Eastern:"
        ' 
        ' nudIndigenous
        ' 
        nudIndigenous.Location = New Point(227, 135)
        nudIndigenous.Margin = New Padding(3, 2, 3, 2)
        nudIndigenous.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIndigenous.Name = "nudIndigenous"
        nudIndigenous.Size = New Size(114, 23)
        nudIndigenous.TabIndex = 21
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Location = New Point(114, 137)
        Label58.Name = "Label58"
        Label58.Size = New Size(69, 15)
        Label58.TabIndex = 20
        Label58.Text = "Indigenous:"
        ' 
        ' nudHispanic
        ' 
        nudHispanic.Location = New Point(227, 105)
        nudHispanic.Margin = New Padding(3, 2, 3, 2)
        nudHispanic.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHispanic.Name = "nudHispanic"
        nudHispanic.Size = New Size(114, 23)
        nudHispanic.TabIndex = 19
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Location = New Point(114, 107)
        Label64.Name = "Label64"
        Label64.Size = New Size(94, 15)
        Label64.TabIndex = 18
        Label64.Text = "Hispanic/Latino:"
        ' 
        ' nudAsian
        ' 
        nudAsian.Location = New Point(227, 75)
        nudAsian.Margin = New Padding(3, 2, 3, 2)
        nudAsian.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAsian.Name = "nudAsian"
        nudAsian.Size = New Size(114, 23)
        nudAsian.TabIndex = 17
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Location = New Point(114, 80)
        Label57.Name = "Label57"
        Label57.Size = New Size(39, 15)
        Label57.TabIndex = 16
        Label57.Text = "Asian:"
        ' 
        ' nudAfrican
        ' 
        nudAfrican.Location = New Point(227, 48)
        nudAfrican.Margin = New Padding(3, 2, 3, 2)
        nudAfrican.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudAfrican.Name = "nudAfrican"
        nudAfrican.Size = New Size(114, 23)
        nudAfrican.TabIndex = 15
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Location = New Point(114, 59)
        Label65.Name = "Label65"
        Label65.Size = New Size(48, 15)
        Label65.TabIndex = 14
        Label65.Text = "African:"
        ' 
        ' dtpNations
        ' 
        dtpNations.CustomFormat = "MMMM yyyy"
        dtpNations.Format = DateTimePickerFormat.Custom
        dtpNations.Location = New Point(113, 20)
        dtpNations.Margin = New Padding(3, 2, 3, 2)
        dtpNations.Name = "dtpNations"
        dtpNations.Size = New Size(119, 23)
        dtpNations.TabIndex = 13
        ' 
        ' Label86
        ' 
        Label86.AutoSize = True
        Label86.Location = New Point(18, 22)
        Label86.Name = "Label86"
        Label86.Size = New Size(89, 15)
        Label86.TabIndex = 12
        Label86.Text = "Reporting Date:"
        ' 
        ' tabReligions
        ' 
        tabReligions.Controls.Add(pnlReligions)
        tabReligions.Location = New Point(4, 24)
        tabReligions.Margin = New Padding(3, 2, 3, 2)
        tabReligions.Name = "tabReligions"
        tabReligions.Size = New Size(799, 469)
        tabReligions.TabIndex = 8
        tabReligions.Text = "Religions"
        tabReligions.UseVisualStyleBackColor = True
        ' 
        ' pnlReligions
        ' 
        pnlReligions.Controls.Add(dgvSocialReligions)
        pnlReligions.Controls.Add(grpReligionsFilter)
        pnlReligions.Controls.Add(GroupBoxReligions)
        pnlReligions.Dock = DockStyle.Fill
        pnlReligions.Location = New Point(0, 0)
        pnlReligions.Margin = New Padding(3, 2, 3, 2)
        pnlReligions.Name = "pnlReligions"
        pnlReligions.Size = New Size(799, 469)
        pnlReligions.TabIndex = 2
        ' 
        ' dgvSocialReligions
        ' 
        dgvSocialReligions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialReligions.Location = New Point(18, 313)
        dgvSocialReligions.Margin = New Padding(3, 2, 3, 2)
        dgvSocialReligions.Name = "dgvSocialReligions"
        dgvSocialReligions.RowHeadersWidth = 51
        dgvSocialReligions.Size = New Size(763, 153)
        dgvSocialReligions.TabIndex = 19
        ' 
        ' grpReligionsFilter
        ' 
        grpReligionsFilter.Controls.Add(btnClearReligionsFilter)
        grpReligionsFilter.Controls.Add(btnApplyReligionsFilter)
        grpReligionsFilter.Controls.Add(dtpReligionsFilterMonth)
        grpReligionsFilter.Controls.Add(dtpReligionsFilterYear)
        grpReligionsFilter.Controls.Add(Label111)
        grpReligionsFilter.Controls.Add(Label112)
        grpReligionsFilter.Location = New Point(18, 259)
        grpReligionsFilter.Margin = New Padding(3, 2, 3, 2)
        grpReligionsFilter.Name = "grpReligionsFilter"
        grpReligionsFilter.Padding = New Padding(3, 2, 3, 2)
        grpReligionsFilter.Size = New Size(766, 50)
        grpReligionsFilter.TabIndex = 18
        grpReligionsFilter.TabStop = False
        grpReligionsFilter.Text = "Filter Data"
        ' 
        ' btnClearReligionsFilter
        ' 
        btnClearReligionsFilter.Location = New Point(415, 11)
        btnClearReligionsFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearReligionsFilter.Name = "btnClearReligionsFilter"
        btnClearReligionsFilter.Size = New Size(70, 23)
        btnClearReligionsFilter.TabIndex = 5
        btnClearReligionsFilter.Text = "Clear"
        btnClearReligionsFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyReligionsFilter
        ' 
        btnApplyReligionsFilter.BackColor = SystemColors.Control
        btnApplyReligionsFilter.Location = New Point(336, 11)
        btnApplyReligionsFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyReligionsFilter.Name = "btnApplyReligionsFilter"
        btnApplyReligionsFilter.Size = New Size(70, 23)
        btnApplyReligionsFilter.TabIndex = 4
        btnApplyReligionsFilter.Text = "Apply"
        btnApplyReligionsFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpReligionsFilterMonth
        ' 
        dtpReligionsFilterMonth.CustomFormat = "MMMM"
        dtpReligionsFilterMonth.Format = DateTimePickerFormat.Custom
        dtpReligionsFilterMonth.Location = New Point(175, 14)
        dtpReligionsFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpReligionsFilterMonth.Name = "dtpReligionsFilterMonth"
        dtpReligionsFilterMonth.Size = New Size(79, 23)
        dtpReligionsFilterMonth.TabIndex = 3
        ' 
        ' dtpReligionsFilterYear
        ' 
        dtpReligionsFilterYear.CustomFormat = "yyyy"
        dtpReligionsFilterYear.Format = DateTimePickerFormat.Custom
        dtpReligionsFilterYear.Location = New Point(88, 14)
        dtpReligionsFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpReligionsFilterYear.Name = "dtpReligionsFilterYear"
        dtpReligionsFilterYear.ShowUpDown = True
        dtpReligionsFilterYear.Size = New Size(62, 23)
        dtpReligionsFilterYear.TabIndex = 2
        ' 
        ' Label111
        ' 
        Label111.AutoSize = True
        Label111.Location = New Point(158, 15)
        Label111.Name = "Label111"
        Label111.Size = New Size(21, 15)
        Label111.TabIndex = 1
        Label111.Text = "M:"
        ' 
        ' Label112
        ' 
        Label112.AutoSize = True
        Label112.Location = New Point(52, 15)
        Label112.Name = "Label112"
        Label112.Size = New Size(33, 15)
        Label112.TabIndex = 0
        Label112.Text = "Y/M:"
        ' 
        ' GroupBoxReligions
        ' 
        GroupBoxReligions.Controls.Add(nudNoReligion)
        GroupBoxReligions.Controls.Add(Label74)
        GroupBoxReligions.Controls.Add(txtOtherReligionSpecify)
        GroupBoxReligions.Controls.Add(btnSaveReligions)
        GroupBoxReligions.Controls.Add(Label73)
        GroupBoxReligions.Controls.Add(btnUpdateReligions)
        GroupBoxReligions.Controls.Add(nudOtherReligion)
        GroupBoxReligions.Controls.Add(btnCancelReligions)
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
        GroupBoxReligions.Controls.Add(dtpReligions)
        GroupBoxReligions.Controls.Add(Label87)
        GroupBoxReligions.Location = New Point(18, 15)
        GroupBoxReligions.Margin = New Padding(3, 2, 3, 2)
        GroupBoxReligions.Name = "GroupBoxReligions"
        GroupBoxReligions.Padding = New Padding(3, 2, 3, 2)
        GroupBoxReligions.Size = New Size(766, 240)
        GroupBoxReligions.TabIndex = 17
        GroupBoxReligions.TabStop = False
        GroupBoxReligions.Text = "Religious Counts"
        ' 
        ' nudNoReligion
        ' 
        nudNoReligion.Location = New Point(405, 142)
        nudNoReligion.Margin = New Padding(3, 2, 3, 2)
        nudNoReligion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudNoReligion.Name = "nudNoReligion"
        nudNoReligion.Size = New Size(114, 23)
        nudNoReligion.TabIndex = 33
        ' 
        ' Label74
        ' 
        Label74.AutoSize = True
        Label74.Location = New Point(318, 144)
        Label74.Name = "Label74"
        Label74.Size = New Size(72, 15)
        Label74.TabIndex = 32
        Label74.Text = "No Religion:"
        ' 
        ' txtOtherReligionSpecify
        ' 
        txtOtherReligionSpecify.Location = New Point(405, 112)
        txtOtherReligionSpecify.Margin = New Padding(3, 2, 3, 2)
        txtOtherReligionSpecify.Name = "txtOtherReligionSpecify"
        txtOtherReligionSpecify.Size = New Size(114, 23)
        txtOtherReligionSpecify.TabIndex = 31
        ' 
        ' btnSaveReligions
        ' 
        btnSaveReligions.BackColor = SystemColors.Control
        btnSaveReligions.Location = New Point(360, 202)
        btnSaveReligions.Margin = New Padding(3, 2, 3, 2)
        btnSaveReligions.Name = "btnSaveReligions"
        btnSaveReligions.Size = New Size(88, 27)
        btnSaveReligions.TabIndex = 15
        btnSaveReligions.Text = "Save"
        btnSaveReligions.UseVisualStyleBackColor = False
        ' 
        ' Label73
        ' 
        Label73.AutoSize = True
        Label73.Location = New Point(302, 115)
        Label73.Name = "Label73"
        Label73.Size = New Size(88, 15)
        Label73.TabIndex = 30
        Label73.Text = "Other (specify):"
        ' 
        ' btnUpdateReligions
        ' 
        btnUpdateReligions.BackColor = SystemColors.Control
        btnUpdateReligions.Location = New Point(456, 202)
        btnUpdateReligions.Margin = New Padding(3, 2, 3, 2)
        btnUpdateReligions.Name = "btnUpdateReligions"
        btnUpdateReligions.Size = New Size(88, 27)
        btnUpdateReligions.TabIndex = 16
        btnUpdateReligions.Text = "Update"
        btnUpdateReligions.UseVisualStyleBackColor = False
        btnUpdateReligions.Visible = False
        ' 
        ' nudOtherReligion
        ' 
        nudOtherReligion.Location = New Point(405, 82)
        nudOtherReligion.Margin = New Padding(3, 2, 3, 2)
        nudOtherReligion.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudOtherReligion.Name = "nudOtherReligion"
        nudOtherReligion.Size = New Size(114, 23)
        nudOtherReligion.TabIndex = 29
        ' 
        ' btnCancelReligions
        ' 
        btnCancelReligions.BackColor = SystemColors.Control
        btnCancelReligions.Location = New Point(552, 202)
        btnCancelReligions.Margin = New Padding(3, 2, 3, 2)
        btnCancelReligions.Name = "btnCancelReligions"
        btnCancelReligions.Size = New Size(88, 27)
        btnCancelReligions.TabIndex = 17
        btnCancelReligions.Text = "Cancel"
        btnCancelReligions.UseVisualStyleBackColor = False
        btnCancelReligions.Visible = False
        ' 
        ' Label72
        ' 
        Label72.AutoSize = True
        Label72.Location = New Point(299, 84)
        Label72.Name = "Label72"
        Label72.Size = New Size(91, 15)
        Label72.TabIndex = 28
        Label72.Text = "Other Religions:"
        ' 
        ' nudSikhism
        ' 
        nudSikhism.Location = New Point(405, 52)
        nudSikhism.Margin = New Padding(3, 2, 3, 2)
        nudSikhism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSikhism.Name = "nudSikhism"
        nudSikhism.Size = New Size(114, 23)
        nudSikhism.TabIndex = 27
        ' 
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Location = New Point(339, 58)
        Label71.Name = "Label71"
        Label71.Size = New Size(51, 15)
        Label71.TabIndex = 26
        Label71.Text = "Sikhism:"
        ' 
        ' nudJudaism
        ' 
        nudJudaism.Location = New Point(139, 142)
        nudJudaism.Margin = New Padding(3, 2, 3, 2)
        nudJudaism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudJudaism.Name = "nudJudaism"
        nudJudaism.Size = New Size(114, 23)
        nudJudaism.TabIndex = 25
        ' 
        ' Label70
        ' 
        Label70.AutoSize = True
        Label70.Location = New Point(52, 144)
        Label70.Name = "Label70"
        Label70.Size = New Size(53, 15)
        Label70.TabIndex = 24
        Label70.Text = "Judaism:"
        ' 
        ' nudBuddhism
        ' 
        nudBuddhism.Location = New Point(139, 112)
        nudBuddhism.Margin = New Padding(3, 2, 3, 2)
        nudBuddhism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudBuddhism.Name = "nudBuddhism"
        nudBuddhism.Size = New Size(114, 23)
        nudBuddhism.TabIndex = 23
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Location = New Point(52, 114)
        Label69.Name = "Label69"
        Label69.Size = New Size(64, 15)
        Label69.TabIndex = 22
        Label69.Text = "Buddhism:"
        ' 
        ' nudHinduism
        ' 
        nudHinduism.Location = New Point(139, 82)
        nudHinduism.Margin = New Padding(3, 2, 3, 2)
        nudHinduism.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHinduism.Name = "nudHinduism"
        nudHinduism.Size = New Size(114, 23)
        nudHinduism.TabIndex = 21
        ' 
        ' Label68
        ' 
        Label68.AutoSize = True
        Label68.Location = New Point(52, 84)
        Label68.Name = "Label68"
        Label68.Size = New Size(62, 15)
        Label68.TabIndex = 20
        Label68.Text = "Hinduism:"
        ' 
        ' nudIslam
        ' 
        nudIslam.Location = New Point(139, 52)
        nudIslam.Margin = New Padding(3, 2, 3, 2)
        nudIslam.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudIslam.Name = "nudIslam"
        nudIslam.Size = New Size(114, 23)
        nudIslam.TabIndex = 19
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Location = New Point(69, 54)
        Label67.Name = "Label67"
        Label67.Size = New Size(38, 15)
        Label67.TabIndex = 18
        Label67.Text = "Islam:"
        ' 
        ' nudChristianity
        ' 
        nudChristianity.Location = New Point(139, 169)
        nudChristianity.Margin = New Padding(3, 2, 3, 2)
        nudChristianity.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudChristianity.Name = "nudChristianity"
        nudChristianity.Size = New Size(114, 23)
        nudChristianity.TabIndex = 17
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Location = New Point(43, 171)
        Label66.Name = "Label66"
        Label66.Size = New Size(70, 15)
        Label66.TabIndex = 16
        Label66.Text = "Christianity:"
        ' 
        ' dtpReligions
        ' 
        dtpReligions.CustomFormat = "MMMM yyyy"
        dtpReligions.Format = DateTimePickerFormat.Custom
        dtpReligions.Location = New Point(113, 19)
        dtpReligions.Margin = New Padding(3, 2, 3, 2)
        dtpReligions.Name = "dtpReligions"
        dtpReligions.Size = New Size(115, 23)
        dtpReligions.TabIndex = 13
        ' 
        ' Label87
        ' 
        Label87.AutoSize = True
        Label87.Location = New Point(18, 22)
        Label87.Name = "Label87"
        Label87.Size = New Size(89, 15)
        Label87.TabIndex = 12
        Label87.Text = "Reporting Date:"
        ' 
        ' tabLanguages
        ' 
        tabLanguages.Controls.Add(pnlLanguages)
        tabLanguages.Location = New Point(4, 24)
        tabLanguages.Margin = New Padding(3, 2, 3, 2)
        tabLanguages.Name = "tabLanguages"
        tabLanguages.Size = New Size(799, 469)
        tabLanguages.TabIndex = 9
        tabLanguages.Text = "Languages"
        tabLanguages.UseVisualStyleBackColor = True
        ' 
        ' pnlLanguages
        ' 
        pnlLanguages.Controls.Add(dgvSocialLanguages)
        pnlLanguages.Controls.Add(grpLanguagesFilter)
        pnlLanguages.Controls.Add(GroupBoxLanguages)
        pnlLanguages.Dock = DockStyle.Fill
        pnlLanguages.Location = New Point(0, 0)
        pnlLanguages.Margin = New Padding(3, 2, 3, 2)
        pnlLanguages.Name = "pnlLanguages"
        pnlLanguages.Size = New Size(799, 469)
        pnlLanguages.TabIndex = 2
        ' 
        ' dgvSocialLanguages
        ' 
        dgvSocialLanguages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSocialLanguages.Location = New Point(18, 288)
        dgvSocialLanguages.Margin = New Padding(3, 2, 3, 2)
        dgvSocialLanguages.Name = "dgvSocialLanguages"
        dgvSocialLanguages.RowHeadersWidth = 51
        dgvSocialLanguages.Size = New Size(765, 178)
        dgvSocialLanguages.TabIndex = 19
        ' 
        ' grpLanguagesFilter
        ' 
        grpLanguagesFilter.Controls.Add(btnClearLanguagesFilter)
        grpLanguagesFilter.Controls.Add(btnApplyLanguagesFilter)
        grpLanguagesFilter.Controls.Add(dtpLanguagesFilterMonth)
        grpLanguagesFilter.Controls.Add(dtpLanguagesFilterYear)
        grpLanguagesFilter.Controls.Add(Label113)
        grpLanguagesFilter.Controls.Add(Label114)
        grpLanguagesFilter.Location = New Point(18, 220)
        grpLanguagesFilter.Margin = New Padding(3, 2, 3, 2)
        grpLanguagesFilter.Name = "grpLanguagesFilter"
        grpLanguagesFilter.Padding = New Padding(3, 2, 3, 2)
        grpLanguagesFilter.Size = New Size(765, 64)
        grpLanguagesFilter.TabIndex = 18
        grpLanguagesFilter.TabStop = False
        grpLanguagesFilter.Text = "Filter Data"
        ' 
        ' btnClearLanguagesFilter
        ' 
        btnClearLanguagesFilter.Location = New Point(350, 14)
        btnClearLanguagesFilter.Margin = New Padding(3, 2, 3, 2)
        btnClearLanguagesFilter.Name = "btnClearLanguagesFilter"
        btnClearLanguagesFilter.Size = New Size(70, 23)
        btnClearLanguagesFilter.TabIndex = 5
        btnClearLanguagesFilter.Text = "Clear"
        btnClearLanguagesFilter.UseVisualStyleBackColor = True
        ' 
        ' btnApplyLanguagesFilter
        ' 
        btnApplyLanguagesFilter.BackColor = SystemColors.Control
        btnApplyLanguagesFilter.Location = New Point(271, 14)
        btnApplyLanguagesFilter.Margin = New Padding(3, 2, 3, 2)
        btnApplyLanguagesFilter.Name = "btnApplyLanguagesFilter"
        btnApplyLanguagesFilter.Size = New Size(70, 23)
        btnApplyLanguagesFilter.TabIndex = 4
        btnApplyLanguagesFilter.Text = "Apply"
        btnApplyLanguagesFilter.UseVisualStyleBackColor = False
        ' 
        ' dtpLanguagesFilterMonth
        ' 
        dtpLanguagesFilterMonth.CustomFormat = "MMMM"
        dtpLanguagesFilterMonth.Format = DateTimePickerFormat.Custom
        dtpLanguagesFilterMonth.Location = New Point(175, 14)
        dtpLanguagesFilterMonth.Margin = New Padding(3, 2, 3, 2)
        dtpLanguagesFilterMonth.Name = "dtpLanguagesFilterMonth"
        dtpLanguagesFilterMonth.Size = New Size(79, 23)
        dtpLanguagesFilterMonth.TabIndex = 3
        ' 
        ' dtpLanguagesFilterYear
        ' 
        dtpLanguagesFilterYear.CustomFormat = "yyyy"
        dtpLanguagesFilterYear.Format = DateTimePickerFormat.Custom
        dtpLanguagesFilterYear.Location = New Point(88, 14)
        dtpLanguagesFilterYear.Margin = New Padding(3, 2, 3, 2)
        dtpLanguagesFilterYear.Name = "dtpLanguagesFilterYear"
        dtpLanguagesFilterYear.ShowUpDown = True
        dtpLanguagesFilterYear.Size = New Size(62, 23)
        dtpLanguagesFilterYear.TabIndex = 2
        ' 
        ' Label113
        ' 
        Label113.AutoSize = True
        Label113.Location = New Point(158, 15)
        Label113.Name = "Label113"
        Label113.Size = New Size(21, 15)
        Label113.TabIndex = 1
        Label113.Text = "M:"
        ' 
        ' Label114
        ' 
        Label114.AutoSize = True
        Label114.Location = New Point(52, 15)
        Label114.Name = "Label114"
        Label114.Size = New Size(33, 15)
        Label114.TabIndex = 0
        Label114.Text = "Y/M:"
        ' 
        ' GroupBoxLanguages
        ' 
        GroupBoxLanguages.Controls.Add(nudHindi)
        GroupBoxLanguages.Controls.Add(Label78)
        GroupBoxLanguages.Controls.Add(nudFrench)
        GroupBoxLanguages.Controls.Add(btnSaveLanguages)
        GroupBoxLanguages.Controls.Add(Label77)
        GroupBoxLanguages.Controls.Add(btnUpdateLanguages)
        GroupBoxLanguages.Controls.Add(nudHebrew)
        GroupBoxLanguages.Controls.Add(btnCancelLanguages)
        GroupBoxLanguages.Controls.Add(Label76)
        GroupBoxLanguages.Controls.Add(nudSinhala)
        GroupBoxLanguages.Controls.Add(Label75)
        GroupBoxLanguages.Controls.Add(dtpLanguages)
        GroupBoxLanguages.Controls.Add(Label88)
        GroupBoxLanguages.Location = New Point(18, 15)
        GroupBoxLanguages.Margin = New Padding(3, 2, 3, 2)
        GroupBoxLanguages.Name = "GroupBoxLanguages"
        GroupBoxLanguages.Padding = New Padding(3, 2, 3, 2)
        GroupBoxLanguages.Size = New Size(765, 201)
        GroupBoxLanguages.TabIndex = 17
        GroupBoxLanguages.TabStop = False
        GroupBoxLanguages.Text = "Language Counts"
        ' 
        ' nudHindi
        ' 
        nudHindi.Location = New Point(350, 112)
        nudHindi.Margin = New Padding(3, 2, 3, 2)
        nudHindi.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHindi.Name = "nudHindi"
        nudHindi.Size = New Size(114, 23)
        nudHindi.TabIndex = 23
        ' 
        ' Label78
        ' 
        Label78.AutoSize = True
        Label78.Location = New Point(298, 114)
        Label78.Name = "Label78"
        Label78.Size = New Size(39, 15)
        Label78.TabIndex = 22
        Label78.Text = "Hindi:"
        ' 
        ' nudFrench
        ' 
        nudFrench.Location = New Point(350, 82)
        nudFrench.Margin = New Padding(3, 2, 3, 2)
        nudFrench.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudFrench.Name = "nudFrench"
        nudFrench.Size = New Size(114, 23)
        nudFrench.TabIndex = 21
        ' 
        ' btnSaveLanguages
        ' 
        btnSaveLanguages.BackColor = SystemColors.Control
        btnSaveLanguages.Location = New Point(447, 154)
        btnSaveLanguages.Margin = New Padding(3, 2, 3, 2)
        btnSaveLanguages.Name = "btnSaveLanguages"
        btnSaveLanguages.Size = New Size(88, 31)
        btnSaveLanguages.TabIndex = 15
        btnSaveLanguages.Text = "Save"
        btnSaveLanguages.UseVisualStyleBackColor = False
        ' 
        ' Label77
        ' 
        Label77.AutoSize = True
        Label77.Location = New Point(289, 84)
        Label77.Name = "Label77"
        Label77.Size = New Size(46, 15)
        Label77.TabIndex = 20
        Label77.Text = "French:"
        ' 
        ' btnUpdateLanguages
        ' 
        btnUpdateLanguages.BackColor = SystemColors.Control
        btnUpdateLanguages.Location = New Point(543, 154)
        btnUpdateLanguages.Margin = New Padding(3, 2, 3, 2)
        btnUpdateLanguages.Name = "btnUpdateLanguages"
        btnUpdateLanguages.Size = New Size(88, 31)
        btnUpdateLanguages.TabIndex = 16
        btnUpdateLanguages.Text = "Update"
        btnUpdateLanguages.UseVisualStyleBackColor = False
        btnUpdateLanguages.Visible = False
        ' 
        ' nudHebrew
        ' 
        nudHebrew.Location = New Point(350, 52)
        nudHebrew.Margin = New Padding(3, 2, 3, 2)
        nudHebrew.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudHebrew.Name = "nudHebrew"
        nudHebrew.Size = New Size(114, 23)
        nudHebrew.TabIndex = 19
        ' 
        ' btnCancelLanguages
        ' 
        btnCancelLanguages.BackColor = SystemColors.Control
        btnCancelLanguages.Location = New Point(639, 154)
        btnCancelLanguages.Margin = New Padding(3, 2, 3, 2)
        btnCancelLanguages.Name = "btnCancelLanguages"
        btnCancelLanguages.Size = New Size(88, 31)
        btnCancelLanguages.TabIndex = 17
        btnCancelLanguages.Text = "Cancel"
        btnCancelLanguages.UseVisualStyleBackColor = False
        btnCancelLanguages.Visible = False
        ' 
        ' Label76
        ' 
        Label76.AutoSize = True
        Label76.Location = New Point(280, 54)
        Label76.Name = "Label76"
        Label76.Size = New Size(51, 15)
        Label76.TabIndex = 18
        Label76.Text = "Hebrew:"
        ' 
        ' nudSinhala
        ' 
        nudSinhala.Location = New Point(350, 22)
        nudSinhala.Margin = New Padding(3, 2, 3, 2)
        nudSinhala.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudSinhala.Name = "nudSinhala"
        nudSinhala.Size = New Size(114, 23)
        nudSinhala.TabIndex = 17
        ' 
        ' Label75
        ' 
        Label75.AutoSize = True
        Label75.Location = New Point(280, 24)
        Label75.Name = "Label75"
        Label75.Size = New Size(48, 15)
        Label75.TabIndex = 16
        Label75.Text = "Sinhala:"
        ' 
        ' dtpLanguages
        ' 
        dtpLanguages.CustomFormat = "MMMM yyyy"
        dtpLanguages.Format = DateTimePickerFormat.Custom
        dtpLanguages.Location = New Point(105, 19)
        dtpLanguages.Margin = New Padding(3, 2, 3, 2)
        dtpLanguages.Name = "dtpLanguages"
        dtpLanguages.Size = New Size(158, 23)
        dtpLanguages.TabIndex = 13
        ' 
        ' Label88
        ' 
        Label88.AutoSize = True
        Label88.Location = New Point(18, 22)
        Label88.Name = "Label88"
        Label88.Size = New Size(89, 15)
        Label88.TabIndex = 12
        Label88.Text = "Reporting Date:"
        ' 
        ' btnExportSocial
        ' 
        btnExportSocial.BackColor = Color.LightBlue
        btnExportSocial.Location = New Point(18, 486)
        btnExportSocial.Margin = New Padding(3, 2, 3, 2)
        btnExportSocial.Name = "btnExportSocial"
        btnExportSocial.Size = New Size(105, 22)
        btnExportSocial.TabIndex = 9
        btnExportSocial.Text = "Export to Excel"
        btnExportSocial.UseVisualStyleBackColor = False
        ' 
        ' frmESGMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(815, 525)
        Controls.Add(tcMain)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmESGMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ESG Data Management System"
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
        tcSocialCategories.ResumeLayout(False)
        tabBasicInfo.ResumeLayout(False)
        pnlBasic.ResumeLayout(False)
        CType(dgvSocialBasic, ComponentModel.ISupportInitialize).EndInit()
        grpSocialFilter.ResumeLayout(False)
        grpSocialFilter.PerformLayout()
        GroupBoxBasic.ResumeLayout(False)
        GroupBoxBasic.PerformLayout()
        CType(nudAgeCount, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFemale, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMale, ComponentModel.ISupportInitialize).EndInit()
        tabSkills.ResumeLayout(False)
        pnlSkills.ResumeLayout(False)
        CType(dgvSocialSkills, ComponentModel.ISupportInitialize).EndInit()
        grpSkillsFilter.ResumeLayout(False)
        grpSkillsFilter.PerformLayout()
        GroupBoxSkills.ResumeLayout(False)
        GroupBoxSkills.PerformLayout()
        CType(nudNewToIndustry, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHiredQualified, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLearntAtNIRU, ComponentModel.ISupportInitialize).EndInit()
        tabPromotions.ResumeLayout(False)
        pnlPromotions.ResumeLayout(False)
        CType(dgvSocialPromotions, ComponentModel.ISupportInitialize).EndInit()
        grpPromotionsFilter.ResumeLayout(False)
        grpPromotionsFilter.PerformLayout()
        GroupBoxPromotions.ResumeLayout(False)
        GroupBoxPromotions.PerformLayout()
        CType(nudSameFamily, ComponentModel.ISupportInitialize).EndInit()
        CType(nudInternalMobility, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPromotions, ComponentModel.ISupportInitialize).EndInit()
        tabManagement.ResumeLayout(False)
        pnlManagement.ResumeLayout(False)
        CType(dgvSocialManagement, ComponentModel.ISupportInitialize).EndInit()
        grpManagementFilter.ResumeLayout(False)
        grpManagementFilter.PerformLayout()
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
        pnlDisabilities.ResumeLayout(False)
        CType(dgvSocialDisabilities, ComponentModel.ISupportInitialize).EndInit()
        grpDisabilitiesFilter.ResumeLayout(False)
        grpDisabilitiesFilter.PerformLayout()
        GroupBoxDisabilities.ResumeLayout(False)
        GroupBoxDisabilities.PerformLayout()
        CType(nudChronic, ComponentModel.ISupportInitialize).EndInit()
        CType(nudIntellectual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMentalHealth, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSensory, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPhysical, ComponentModel.ISupportInitialize).EndInit()
        tabBehavior.ResumeLayout(False)
        pnlBehavior.ResumeLayout(False)
        CType(dgvSocialBehavior, ComponentModel.ISupportInitialize).EndInit()
        grpBehaviorFilter.ResumeLayout(False)
        grpBehaviorFilter.PerformLayout()
        GroupBoxBehavior.ResumeLayout(False)
        GroupBoxBehavior.PerformLayout()
        CType(nudPansexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudAsexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBisexual, ComponentModel.ISupportInitialize).EndInit()
        CType(nudGay, ComponentModel.ISupportInitialize).EndInit()
        CType(nudLesbian, ComponentModel.ISupportInitialize).EndInit()
        tabIdentification.ResumeLayout(False)
        pnlIdentification.ResumeLayout(False)
        CType(dgvSocialIdentification, ComponentModel.ISupportInitialize).EndInit()
        grpIdentificationFilter.ResumeLayout(False)
        grpIdentificationFilter.PerformLayout()
        GroupBoxIdentification.ResumeLayout(False)
        GroupBoxIdentification.PerformLayout()
        CType(nudAgender, ComponentModel.ISupportInitialize).EndInit()
        CType(nudNonBinary, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQuestioning, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQueer, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTransgender, ComponentModel.ISupportInitialize).EndInit()
        tabNations.ResumeLayout(False)
        pnlNations.ResumeLayout(False)
        CType(dgvSocialNations, ComponentModel.ISupportInitialize).EndInit()
        grpNationsFilter.ResumeLayout(False)
        grpNationsFilter.PerformLayout()
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
        pnlReligions.ResumeLayout(False)
        CType(dgvSocialReligions, ComponentModel.ISupportInitialize).EndInit()
        grpReligionsFilter.ResumeLayout(False)
        grpReligionsFilter.PerformLayout()
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
        pnlLanguages.ResumeLayout(False)
        CType(dgvSocialLanguages, ComponentModel.ISupportInitialize).EndInit()
        grpLanguagesFilter.ResumeLayout(False)
        grpLanguagesFilter.PerformLayout()
        GroupBoxLanguages.ResumeLayout(False)
        GroupBoxLanguages.PerformLayout()
        CType(nudHindi, ComponentModel.ISupportInitialize).EndInit()
        CType(nudFrench, ComponentModel.ISupportInitialize).EndInit()
        CType(nudHebrew, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSinhala, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' Main Controls
    Friend WithEvents tcMain As TabControl
    Friend WithEvents tpHSE As TabPage
    Friend WithEvents tpSafety As TabPage
    Friend WithEvents tpGrievances As TabPage
    Friend WithEvents tpSocial As TabPage

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
    Friend WithEvents tcSocialCategories As TabControl
    Friend WithEvents tabBasicInfo As TabPage
    Friend WithEvents pnlBasic As Panel
    Friend WithEvents dgvSocialBasic As DataGridView
    Friend WithEvents grpSocialFilter As GroupBox
    Friend WithEvents btnClearSocialFilter As Button
    Friend WithEvents btnApplySocialFilter As Button
    Friend WithEvents dtpSocialFilterMonth As DateTimePicker
    Friend WithEvents dtpSocialFilterYear As DateTimePicker
    Friend WithEvents Label96 As Label
    Friend WithEvents Label95 As Label
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
    Friend WithEvents btnSaveBasic As Button
    Friend WithEvents btnUpdateBasic As Button
    Friend WithEvents btnCancelBasic As Button
    Friend WithEvents tabSkills As TabPage
    Friend WithEvents pnlSkills As Panel
    Friend WithEvents dgvSocialSkills As DataGridView
    Friend WithEvents grpSkillsFilter As GroupBox
    Friend WithEvents btnClearSkillsFilter As Button
    Friend WithEvents btnApplySkillsFilter As Button
    Friend WithEvents dtpSkillsFilterMonth As DateTimePicker
    Friend WithEvents dtpSkillsFilterYear As DateTimePicker
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents GroupBoxSkills As GroupBox
    Friend WithEvents nudNewToIndustry As NumericUpDown
    Friend WithEvents Label26 As Label
    Friend WithEvents nudHiredQualified As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents nudLearntAtNIRU As NumericUpDown
    Friend WithEvents Label24 As Label
    Friend WithEvents dtpSkills As DateTimePicker
    Friend WithEvents Label80 As Label
    Friend WithEvents btnSaveSkills As Button
    Friend WithEvents btnUpdateSkills As Button
    Friend WithEvents btnCancelSkills As Button
    Friend WithEvents tabPromotions As TabPage
    Friend WithEvents pnlPromotions As Panel
    Friend WithEvents dgvSocialPromotions As DataGridView
    Friend WithEvents grpPromotionsFilter As GroupBox
    Friend WithEvents btnClearPromotionsFilter As Button
    Friend WithEvents btnApplyPromotionsFilter As Button
    Friend WithEvents dtpPromotionsFilterMonth As DateTimePicker
    Friend WithEvents dtpPromotionsFilterYear As DateTimePicker
    Friend WithEvents Label99 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents GroupBoxPromotions As GroupBox
    Friend WithEvents nudSameFamily As NumericUpDown
    Friend WithEvents Label29 As Label
    Friend WithEvents nudInternalMobility As NumericUpDown
    Friend WithEvents Label28 As Label
    Friend WithEvents nudPromotions As NumericUpDown
    Friend WithEvents Label27 As Label
    Friend WithEvents dtpPromotions As DateTimePicker
    Friend WithEvents Label81 As Label
    Friend WithEvents btnSavePromotions As Button
    Friend WithEvents btnUpdatePromotions As Button
    Friend WithEvents btnCancelPromotions As Button
    Friend WithEvents tabManagement As TabPage
    Friend WithEvents pnlManagement As Panel
    Friend WithEvents dgvSocialManagement As DataGridView
    Friend WithEvents grpManagementFilter As GroupBox
    Friend WithEvents btnClearManagementFilter As Button
    Friend WithEvents btnApplyManagementFilter As Button
    Friend WithEvents dtpManagementFilterMonth As DateTimePicker
    Friend WithEvents dtpManagementFilterYear As DateTimePicker
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
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
    Friend WithEvents dtpManagement As DateTimePicker
    Friend WithEvents Label82 As Label
    Friend WithEvents btnSaveManagement As Button
    Friend WithEvents btnUpdateManagement As Button
    Friend WithEvents btnCancelManagement As Button
    Friend WithEvents tabDisabilities As TabPage
    Friend WithEvents pnlDisabilities As Panel
    Friend WithEvents dgvSocialDisabilities As DataGridView
    Friend WithEvents grpDisabilitiesFilter As GroupBox
    Friend WithEvents btnClearDisabilitiesFilter As Button
    Friend WithEvents btnApplyDisabilitiesFilter As Button
    Friend WithEvents dtpDisabilitiesFilterMonth As DateTimePicker
    Friend WithEvents dtpDisabilitiesFilterYear As DateTimePicker
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
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
    Friend WithEvents dtpDisabilities As DateTimePicker
    Friend WithEvents Label83 As Label
    Friend WithEvents btnSaveDisabilities As Button
    Friend WithEvents btnUpdateDisabilities As Button
    Friend WithEvents btnCancelDisabilities As Button
    Friend WithEvents tabBehavior As TabPage
    Friend WithEvents pnlBehavior As Panel
    Friend WithEvents dgvSocialBehavior As DataGridView
    Friend WithEvents grpBehaviorFilter As GroupBox
    Friend WithEvents btnClearBehaviorFilter As Button
    Friend WithEvents btnApplyBehaviorFilter As Button
    Friend WithEvents dtpBehaviorFilterMonth As DateTimePicker
    Friend WithEvents dtpBehaviorFilterYear As DateTimePicker
    Friend WithEvents Label105 As Label
    Friend WithEvents Label106 As Label
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
    Friend WithEvents dtpBehavior As DateTimePicker
    Friend WithEvents Label84 As Label
    Friend WithEvents btnSaveBehavior As Button
    Friend WithEvents btnUpdateBehavior As Button
    Friend WithEvents btnCancelBehavior As Button
    Friend WithEvents tabIdentification As TabPage
    Friend WithEvents pnlIdentification As Panel
    Friend WithEvents dgvSocialIdentification As DataGridView
    Friend WithEvents grpIdentificationFilter As GroupBox
    Friend WithEvents btnClearIdentificationFilter As Button
    Friend WithEvents btnApplyIdentificationFilter As Button
    Friend WithEvents dtpIdentificationFilterMonth As DateTimePicker
    Friend WithEvents dtpIdentificationFilterYear As DateTimePicker
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
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
    Friend WithEvents dtpIdentification As DateTimePicker
    Friend WithEvents Label85 As Label
    Friend WithEvents btnSaveIdentification As Button
    Friend WithEvents btnUpdateIdentification As Button
    Friend WithEvents btnCancelIdentification As Button
    Friend WithEvents tabNations As TabPage
    Friend WithEvents pnlNations As Panel
    Friend WithEvents dgvSocialNations As DataGridView
    Friend WithEvents grpNationsFilter As GroupBox
    Friend WithEvents btnClearNationsFilter As Button
    Friend WithEvents btnApplyNationsFilter As Button
    Friend WithEvents dtpNationsFilterMonth As DateTimePicker
    Friend WithEvents dtpNationsFilterYear As DateTimePicker
    Friend WithEvents Label109 As Label
    Friend WithEvents Label110 As Label
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
    Friend WithEvents dtpNations As DateTimePicker
    Friend WithEvents Label86 As Label
    Friend WithEvents btnSaveNations As Button
    Friend WithEvents btnUpdateNations As Button
    Friend WithEvents btnCancelNations As Button
    Friend WithEvents tabReligions As TabPage
    Friend WithEvents pnlReligions As Panel
    Friend WithEvents dgvSocialReligions As DataGridView
    Friend WithEvents grpReligionsFilter As GroupBox
    Friend WithEvents btnClearReligionsFilter As Button
    Friend WithEvents btnApplyReligionsFilter As Button
    Friend WithEvents dtpReligionsFilterMonth As DateTimePicker
    Friend WithEvents dtpReligionsFilterYear As DateTimePicker
    Friend WithEvents Label111 As Label
    Friend WithEvents Label112 As Label
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
    Friend WithEvents dtpReligions As DateTimePicker
    Friend WithEvents Label87 As Label
    Friend WithEvents btnSaveReligions As Button
    Friend WithEvents btnUpdateReligions As Button
    Friend WithEvents btnCancelReligions As Button
    Friend WithEvents tabLanguages As TabPage
    Friend WithEvents pnlLanguages As Panel
    Friend WithEvents dgvSocialLanguages As DataGridView
    Friend WithEvents grpLanguagesFilter As GroupBox
    Friend WithEvents btnClearLanguagesFilter As Button
    Friend WithEvents btnApplyLanguagesFilter As Button
    Friend WithEvents dtpLanguagesFilterMonth As DateTimePicker
    Friend WithEvents dtpLanguagesFilterYear As DateTimePicker
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents GroupBoxLanguages As GroupBox
    Friend WithEvents nudHindi As NumericUpDown
    Friend WithEvents Label78 As Label
    Friend WithEvents nudFrench As NumericUpDown
    Friend WithEvents Label77 As Label
    Friend WithEvents nudHebrew As NumericUpDown
    Friend WithEvents Label76 As Label
    Friend WithEvents nudSinhala As NumericUpDown
    Friend WithEvents Label75 As Label
    Friend WithEvents dtpLanguages As DateTimePicker
    Friend WithEvents Label88 As Label
    Friend WithEvents btnSaveLanguages As Button
    Friend WithEvents btnUpdateLanguages As Button
    Friend WithEvents btnCancelLanguages As Button
    Friend WithEvents btnExportSocial As Button
End Class