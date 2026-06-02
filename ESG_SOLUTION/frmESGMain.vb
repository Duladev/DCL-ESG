Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class frmESGMain
    Private ageCategories As New Dictionary(Of String, Integer)
    Private currentSocialID As Integer = 0

    ' Filter variables
    Private hseFilterYear As Integer? = Nothing
    Private hseFilterMonth As Integer? = Nothing
    Private safetyFilterYear As Integer? = Nothing
    Private safetyFilterMonth As Integer? = Nothing
    Private grievancesFilterYear As Integer? = Nothing
    Private grievancesFilterMonth As Integer? = Nothing
    Private socialFilterYear As Integer? = Nothing
    Private socialFilterMonth As Integer? = Nothing

    Private Sub frmESGMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearAllGrids()
        SetupAgeComboBox()
        SetupDataGridViews()
        LoadAllData()
        SetupFilters()
        SetupSubTabDatePickers()
        LoadAgeCategoriesList()
    End Sub

    Private Sub SetupDataGridViews()
        ' Set row height for all grids
        Dim grids As DataGridView() = {dgvHSE, dgvSafety, dgvGrievances, dgvSocial}
        For Each grid As DataGridView In grids
            grid.RowTemplate.Height = 25
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            grid.AllowUserToResizeRows = False
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Next
    End Sub

    Private Sub SetupFilters()
        ' Setup HSE Filter
        dtpHSEFilterYear.CustomFormat = "yyyy"
        dtpHSEFilterYear.Format = DateTimePickerFormat.Custom
        dtpHSEFilterYear.ShowUpDown = True

        dtpHSEFilterMonth.CustomFormat = "MMMM"
        dtpHSEFilterMonth.Format = DateTimePickerFormat.Custom
        dtpHSEFilterMonth.ShowUpDown = False

        ' Setup Safety Filter
        dtpSafetyFilterYear.CustomFormat = "yyyy"
        dtpSafetyFilterYear.Format = DateTimePickerFormat.Custom
        dtpSafetyFilterYear.ShowUpDown = True

        dtpSafetyFilterMonth.CustomFormat = "MMMM"
        dtpSafetyFilterMonth.Format = DateTimePickerFormat.Custom

        ' Setup Grievances Filter
        dtpGrievancesFilterYear.CustomFormat = "yyyy"
        dtpGrievancesFilterYear.Format = DateTimePickerFormat.Custom
        dtpGrievancesFilterYear.ShowUpDown = True

        dtpGrievancesFilterMonth.CustomFormat = "MMMM"
        dtpGrievancesFilterMonth.Format = DateTimePickerFormat.Custom

        ' Setup Social Filter
        dtpSocialFilterYear.CustomFormat = "yyyy"
        dtpSocialFilterYear.Format = DateTimePickerFormat.Custom
        dtpSocialFilterYear.ShowUpDown = True

        dtpSocialFilterMonth.CustomFormat = "MMMM"
        dtpSocialFilterMonth.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub SetupSubTabDatePickers()
        ' Set all sub-tab date pickers to current date
        dtpSkills.Value = DateTime.Now
        dtpPromotions.Value = DateTime.Now
        dtpManagement.Value = DateTime.Now
        dtpDisabilities.Value = DateTime.Now
        dtpBehavior.Value = DateTime.Now
        dtpIdentification.Value = DateTime.Now
        dtpNations.Value = DateTime.Now
        dtpReligions.Value = DateTime.Now
        dtpLanguages.Value = DateTime.Now
    End Sub

    Private Sub SetupAgeComboBox()
        cboAgeCategory.Items.Clear()
        cboAgeCategory.Items.Add("17 years old or less")
        cboAgeCategory.Items.Add("Between 18 and 30 years old")
        cboAgeCategory.Items.Add("Between 31 and 50 years old")
        cboAgeCategory.Items.Add("50 years old or above")
        If cboAgeCategory.Items.Count > 0 Then
            cboAgeCategory.SelectedIndex = 0
        End If
    End Sub

    Private Sub ClearAllGrids()
        dgvHSE.DataSource = Nothing
        dgvSafety.DataSource = Nothing
        dgvGrievances.DataSource = Nothing
        dgvSocial.DataSource = Nothing
    End Sub

    Private Sub LoadAllData()
        LoadHSEData()
        LoadSafetyData()
        LoadGrievancesData()
        LoadSocialData()
    End Sub

    Private Sub LoadAgeCategoriesList()
        lstAgeCategories.Items.Clear()
        For Each kvp As KeyValuePair(Of String, Integer) In ageCategories
            lstAgeCategories.Items.Add($"{kvp.Key}: {kvp.Value}")
        Next

        ' Update summary label
        'Dim summary As String = "Age Summary: "
        'For Each kvp As KeyValuePair(Of String, Integer) In ageCategories
        '    summary &= $"{kvp.Key}:{kvp.Value} "
        'Next
        'lblAgeSummary.Text = summary
    End Sub

    ' ==================== HSE TRAINING TAB ====================

    Private Sub btnSaveHSE_Click(sender As Object, e As EventArgs) Handles btnSaveHSE.Click
        Try
            If nudHSECount.Value = 0 And nudFirstAid.Value = 0 And nudFireFighting.Value = 0 And nudOtherWorkshop.Value = 0 Then
                MessageBox.Show("Please enter at least one training count", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As SqlConnection = modShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_HSE_Training (ReportMonth, ReportYear, AttendedHealthSafety, AttendedFirstAid, AttendedFireFighting, AttendedOtherWorkshop, OtherWorkshopName, CreatedDate) VALUES (@Month, @Year, @HSE, @FirstAid, @Fire, @Other, @OtherName, @CreatedDate)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpHSE.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpHSE.Value.Year)
                    cmd.Parameters.AddWithValue("@HSE", nudHSECount.Value)
                    cmd.Parameters.AddWithValue("@FirstAid", nudFirstAid.Value)
                    cmd.Parameters.AddWithValue("@Fire", nudFireFighting.Value)
                    cmd.Parameters.AddWithValue("@Other", nudOtherWorkshop.Value)
                    cmd.Parameters.AddWithValue("@OtherName", If(String.IsNullOrEmpty(txtOtherWorkshopName.Text), DBNull.Value, txtOtherWorkshopName.Text))
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("HSE Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadHSEData()
            ClearHSEControls()
        Catch ex As Exception
            MessageBox.Show("Error saving HSE data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadHSE_Click(sender As Object, e As EventArgs) Handles btnLoadHSE.Click
        LoadHSEData()
    End Sub

    Private Sub LoadHSEData()
        Try
            Dim query As String = "SELECT TrainingID, ReportMonth, ReportYear, AttendedHealthSafety as 'Health & Safety', AttendedFirstAid as 'First Aid', AttendedFireFighting as 'Fire Fighting', AttendedOtherWorkshop as 'Other Workshop', OtherWorkshopName as 'Workshop Name', CreatedDate as 'Created Date' FROM tbl_ESG_HSE_Training WHERE 1=1"

            If hseFilterYear.HasValue Then
                query &= " AND ReportYear = " & hseFilterYear.Value
            End If
            If hseFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & hseFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvHSE.DataSource = dt
            dgvHSE.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading HSE data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApplyHSEFilter_Click(sender As Object, e As EventArgs) Handles btnApplyHSEFilter.Click
        hseFilterYear = dtpHSEFilterYear.Value.Year
        hseFilterMonth = dtpHSEFilterMonth.Value.Month
        LoadHSEData()
    End Sub

    Private Sub btnClearHSEFilter_Click(sender As Object, e As EventArgs) Handles btnClearHSEFilter.Click
        hseFilterYear = Nothing
        hseFilterMonth = Nothing
        dtpHSEFilterYear.Value = DateTime.Now
        dtpHSEFilterMonth.Value = DateTime.Now
        LoadHSEData()
    End Sub

    Private Sub ClearHSEControls()
        nudHSECount.Value = 0
        nudFirstAid.Value = 0
        nudFireFighting.Value = 0
        nudOtherWorkshop.Value = 0
        txtOtherWorkshopName.Clear()
        dtpHSE.Value = DateTime.Now
    End Sub

    Private Sub btnExportHSE_Click(sender As Object, e As EventArgs) Handles btnExportHSE.Click
        If dgvHSE.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        modShared.ExportToExcel(dgvHSE, "HSE_Training_Report")
    End Sub

    ' ==================== SAFETY INCIDENTS TAB ====================

    Private Sub btnSaveSafety_Click(sender As Object, e As EventArgs) Handles btnSaveSafety.Click
        Try
            Dim totalIncidents As Integer = CInt(nudPropertyDamage.Value + nudEnvironmental.Value + nudNearMisses.Value + nudTotalAccidents.Value)

            Using conn As SqlConnection = modShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Safety_Incidents (ReportMonth, ReportYear, PropertyDamageIncidents, EnvironmentalIncidents, NearMisses, TotalAccidents, AccidentsWithInjuries, AccidentsWithIllness, AccidentsWithDeath, TotalIncidentCounter, CreatedDate) VALUES (@Month, @Year, @Property, @Environment, @NearMiss, @TotalAcc, @Injuries, @Illness, @Deaths, @TotalIncidents, @CreatedDate)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpSafety.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpSafety.Value.Year)
                    cmd.Parameters.AddWithValue("@Property", nudPropertyDamage.Value)
                    cmd.Parameters.AddWithValue("@Environment", nudEnvironmental.Value)
                    cmd.Parameters.AddWithValue("@NearMiss", nudNearMisses.Value)
                    cmd.Parameters.AddWithValue("@TotalAcc", nudTotalAccidents.Value)
                    cmd.Parameters.AddWithValue("@Injuries", nudInjuries.Value)
                    cmd.Parameters.AddWithValue("@Illness", nudIllness.Value)
                    cmd.Parameters.AddWithValue("@Deaths", nudDeaths.Value)
                    cmd.Parameters.AddWithValue("@TotalIncidents", totalIncidents)
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Safety Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSafetyData()
            ClearSafetyControls()
        Catch ex As Exception
            MessageBox.Show("Error saving safety data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadSafety_Click(sender As Object, e As EventArgs) Handles btnLoadSafety.Click
        LoadSafetyData()
    End Sub

    Private Sub LoadSafetyData()
        Try
            Dim query As String = "SELECT IncidentID, ReportMonth, ReportYear, PropertyDamageIncidents as 'Property Damage', EnvironmentalIncidents as 'Environmental', NearMisses as 'Near Misses', TotalAccidents as 'Total Accidents', AccidentsWithInjuries as 'Injuries', AccidentsWithIllness as 'Illness', AccidentsWithDeath as 'Deaths', TotalIncidentCounter as 'Total Incidents' FROM tbl_ESG_Safety_Incidents WHERE 1=1"

            If safetyFilterYear.HasValue Then
                query &= " AND ReportYear = " & safetyFilterYear.Value
            End If
            If safetyFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & safetyFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSafety.DataSource = dt
            dgvSafety.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading safety data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApplySafetyFilter_Click(sender As Object, e As EventArgs) Handles btnApplySafetyFilter.Click
        safetyFilterYear = dtpSafetyFilterYear.Value.Year
        safetyFilterMonth = dtpSafetyFilterMonth.Value.Month
        LoadSafetyData()
    End Sub

    Private Sub btnClearSafetyFilter_Click(sender As Object, e As EventArgs) Handles btnClearSafetyFilter.Click
        safetyFilterYear = Nothing
        safetyFilterMonth = Nothing
        dtpSafetyFilterYear.Value = DateTime.Now
        dtpSafetyFilterMonth.Value = DateTime.Now
        LoadSafetyData()
    End Sub

    Private Sub ClearSafetyControls()
        nudPropertyDamage.Value = 0
        nudEnvironmental.Value = 0
        nudNearMisses.Value = 0
        nudTotalAccidents.Value = 0
        nudInjuries.Value = 0
        nudIllness.Value = 0
        nudDeaths.Value = 0
        dtpSafety.Value = DateTime.Now
    End Sub

    Private Sub btnExportSafety_Click(sender As Object, e As EventArgs) Handles btnExportSafety.Click
        If dgvSafety.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        modShared.ExportToExcel(dgvSafety, "Safety_Incidents_Report")
    End Sub

    ' ==================== GRIEVANCES TAB ====================

    Private Sub btnSaveGrievances_Click(sender As Object, e As EventArgs) Handles btnSaveGrievances.Click
        Try
            Using conn As SqlConnection = modShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Grievances (ReportMonth, ReportYear, TotalEmployeeGrievances, UnresolvedEmployeeGrievances, CreatedDate) VALUES (@Month, @Year, @Total, @Unresolved, @CreatedDate)"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpGrievances.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpGrievances.Value.Year)
                    cmd.Parameters.AddWithValue("@Total", nudTotalGrievances.Value)
                    cmd.Parameters.AddWithValue("@Unresolved", nudUnresolvedGrievances.Value)
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Grievances Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGrievancesData()
            ClearGrievancesControls()
        Catch ex As Exception
            MessageBox.Show("Error saving grievances data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadGrievances_Click(sender As Object, e As EventArgs) Handles btnLoadGrievances.Click
        LoadGrievancesData()
    End Sub

    Private Sub LoadGrievancesData()
        Try
            Dim query As String = "SELECT GrievanceID, ReportMonth, ReportYear, TotalEmployeeGrievances as 'Total Grievances', UnresolvedEmployeeGrievances as 'Unresolved Grievances', CreatedDate as 'Created Date' FROM tbl_ESG_Grievances WHERE 1=1"

            If grievancesFilterYear.HasValue Then
                query &= " AND ReportYear = " & grievancesFilterYear.Value
            End If
            If grievancesFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & grievancesFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvGrievances.DataSource = dt
            dgvGrievances.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading grievances data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApplyGrievancesFilter_Click(sender As Object, e As EventArgs) Handles btnApplyGrievancesFilter.Click
        grievancesFilterYear = dtpGrievancesFilterYear.Value.Year
        grievancesFilterMonth = dtpGrievancesFilterMonth.Value.Month
        LoadGrievancesData()
    End Sub

    Private Sub btnClearGrievancesFilter_Click(sender As Object, e As EventArgs) Handles btnClearGrievancesFilter.Click
        grievancesFilterYear = Nothing
        grievancesFilterMonth = Nothing
        dtpGrievancesFilterYear.Value = DateTime.Now
        dtpGrievancesFilterMonth.Value = DateTime.Now
        LoadGrievancesData()
    End Sub

    Private Sub ClearGrievancesControls()
        nudTotalGrievances.Value = 0
        nudUnresolvedGrievances.Value = 0
        dtpGrievances.Value = DateTime.Now
    End Sub

    Private Sub btnExportGrievances_Click(sender As Object, e As EventArgs) Handles btnExportGrievances.Click
        If dgvGrievances.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        modShared.ExportToExcel(dgvGrievances, "Grievances_Report")
    End Sub

    ' ==================== SOCIAL DATA TAB ====================

    Private Sub btnAddAge_Click(sender As Object, e As EventArgs) Handles btnAddAge.Click
        If cboAgeCategory.SelectedItem IsNot Nothing Then
            Dim selectedCategory As String = cboAgeCategory.SelectedItem.ToString()
            Dim count As Integer = CInt(nudAgeCount.Value)

            If count > 0 Then
                If ageCategories.ContainsKey(selectedCategory) Then
                    ageCategories(selectedCategory) += count
                Else
                    ageCategories.Add(selectedCategory, count)
                End If

                LoadAgeCategoriesList()
                nudAgeCount.Value = 0
            Else
                MessageBox.Show("Please enter a count greater than 0", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btnDeleteAgeCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteAgeCategory.Click
        If lstAgeCategories.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = lstAgeCategories.SelectedItem.ToString()
            Dim category As String = selectedItem.Substring(0, selectedItem.IndexOf(":"))

            If ageCategories.ContainsKey(category) Then
                ageCategories.Remove(category)
                LoadAgeCategoriesList()
                MessageBox.Show($"Removed {category} from age categories", "Category Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please select a category to delete", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Individual Save buttons for each sub tab
    Private Sub btnSaveSkills_Click(sender As Object, e As EventArgs) Handles btnSaveSkills.Click
        ' Save Skills data - will be saved with main social data
        MessageBox.Show("Skills data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSavePromotions_Click(sender As Object, e As EventArgs) Handles btnSavePromotions.Click
        MessageBox.Show("Promotions data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveManagement_Click(sender As Object, e As EventArgs) Handles btnSaveManagement.Click
        MessageBox.Show("Management data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveDisabilities_Click(sender As Object, e As EventArgs) Handles btnSaveDisabilities.Click
        MessageBox.Show("Disabilities data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveBehavior_Click(sender As Object, e As EventArgs) Handles btnSaveBehavior.Click
        MessageBox.Show("Behavior data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveIdentification_Click(sender As Object, e As EventArgs) Handles btnSaveIdentification.Click
        MessageBox.Show("Identification data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveNations_Click(sender As Object, e As EventArgs) Handles btnSaveNations.Click
        MessageBox.Show("Nations data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveReligions_Click(sender As Object, e As EventArgs) Handles btnSaveReligions.Click
        MessageBox.Show("Religions data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveLanguages_Click(sender As Object, e As EventArgs) Handles btnSaveLanguages.Click
        MessageBox.Show("Languages data will be saved with the main Social Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnSaveSocial_Click(sender As Object, e As EventArgs) Handles btnSaveSocial.Click
        Try
            Using conn As SqlConnection = modShared.GetConnection()
                conn.Open()
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' Insert main social data
                        Dim mainQuery As String = "INSERT INTO tbl_ESG_Social_Data (ReportMonth, ReportYear, MaleCount, FemaleCount, AgeUnder18, Age18To30, Age31To50, AgeOver50, LearntSkillsAtNIRU, HiredQualified, NewToIndustry, Promotions, InternalMobility, SameFamilyCount, WomenFirstLineMgmt, MenFirstLineMgmt, WomenMiddleMgmt, MenMiddleMgmt, WomenUpperMgmt, MenUpperMgmt, WomenLeadershipTeam, MenLeadershipTeam, CreatedDate) VALUES (@Month, @Year, @Male, @Female, @AgeUnder18, @Age18To30, @Age31To50, @AgeOver50, @Learnt, @Qualified, @NewIndustry, @Promotions, @Mobility, @Family, @WFirst, @MFirst, @WMiddle, @MMiddle, @WUpper, @MUpper, @WLeadership, @MLeadership, @CreatedDate); SELECT SCOPE_IDENTITY();"

                        Dim mainCmd As New SqlCommand(mainQuery, conn, transaction)
                        mainCmd.Parameters.AddWithValue("@Month", dtpSocial.Value.Month)
                        mainCmd.Parameters.AddWithValue("@Year", dtpSocial.Value.Year)
                        mainCmd.Parameters.AddWithValue("@Male", nudMale.Value)
                        mainCmd.Parameters.AddWithValue("@Female", nudFemale.Value)

                        ' Get age counts from dictionary
                        Dim ageUnder18 As Integer = If(ageCategories.ContainsKey("17 years old or less"), ageCategories("17 years old or less"), 0)
                        Dim age18To30 As Integer = If(ageCategories.ContainsKey("Between 18 and 30 years old"), ageCategories("Between 18 and 30 years old"), 0)
                        Dim age31To50 As Integer = If(ageCategories.ContainsKey("Between 31 and 50 years old"), ageCategories("Between 31 and 50 years old"), 0)
                        Dim ageOver50 As Integer = If(ageCategories.ContainsKey("50 years old or above"), ageCategories("50 years old or above"), 0)

                        mainCmd.Parameters.AddWithValue("@AgeUnder18", ageUnder18)
                        mainCmd.Parameters.AddWithValue("@Age18To30", age18To30)
                        mainCmd.Parameters.AddWithValue("@Age31To50", age31To50)
                        mainCmd.Parameters.AddWithValue("@AgeOver50", ageOver50)
                        mainCmd.Parameters.AddWithValue("@Learnt", nudLearntAtNIRU.Value)
                        mainCmd.Parameters.AddWithValue("@Qualified", nudHiredQualified.Value)
                        mainCmd.Parameters.AddWithValue("@NewIndustry", nudNewToIndustry.Value)
                        mainCmd.Parameters.AddWithValue("@Promotions", nudPromotions.Value)
                        mainCmd.Parameters.AddWithValue("@Mobility", nudInternalMobility.Value)
                        mainCmd.Parameters.AddWithValue("@Family", nudSameFamily.Value)
                        mainCmd.Parameters.AddWithValue("@WFirst", nudWomenFirstLine.Value)
                        mainCmd.Parameters.AddWithValue("@MFirst", nudMenFirstLine.Value)
                        mainCmd.Parameters.AddWithValue("@WMiddle", nudWomenMiddle.Value)
                        mainCmd.Parameters.AddWithValue("@MMiddle", nudMenMiddle.Value)
                        mainCmd.Parameters.AddWithValue("@WUpper", nudWomenUpper.Value)
                        mainCmd.Parameters.AddWithValue("@MUpper", nudMenUpper.Value)
                        mainCmd.Parameters.AddWithValue("@WLeadership", nudWomenLeadership.Value)
                        mainCmd.Parameters.AddWithValue("@MLeadership", nudMenLeadership.Value)
                        mainCmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now)

                        currentSocialID = Convert.ToInt32(mainCmd.ExecuteScalar())

                        ' Insert disabilities
                        Dim disabilityQuery As String = "INSERT INTO tbl_ESG_Disabilities (SocialID, PhysicalDisabilities, SensoryDisabilities, MentalHealthConditions, IntellectualDisabilities, ChronicHealthConditions) VALUES (@SocialID, @Physical, @Sensory, @Mental, @Intellectual, @Chronic)"
                        Dim disabilityCmd As New SqlCommand(disabilityQuery, conn, transaction)
                        disabilityCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        disabilityCmd.Parameters.AddWithValue("@Physical", nudPhysical.Value)
                        disabilityCmd.Parameters.AddWithValue("@Sensory", nudSensory.Value)
                        disabilityCmd.Parameters.AddWithValue("@Mental", nudMentalHealth.Value)
                        disabilityCmd.Parameters.AddWithValue("@Intellectual", nudIntellectual.Value)
                        disabilityCmd.Parameters.AddWithValue("@Chronic", nudChronic.Value)
                        disabilityCmd.ExecuteNonQuery()

                        ' Insert behavior
                        Dim behaviorQuery As String = "INSERT INTO tbl_ESG_Behavior (SocialID, Lesbian, Gay, Bisexual, Asexual, Pansexual) VALUES (@SocialID, @Lesbian, @Gay, @Bisexual, @Asexual, @Pansexual)"
                        Dim behaviorCmd As New SqlCommand(behaviorQuery, conn, transaction)
                        behaviorCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        behaviorCmd.Parameters.AddWithValue("@Lesbian", nudLesbian.Value)
                        behaviorCmd.Parameters.AddWithValue("@Gay", nudGay.Value)
                        behaviorCmd.Parameters.AddWithValue("@Bisexual", nudBisexual.Value)
                        behaviorCmd.Parameters.AddWithValue("@Asexual", nudAsexual.Value)
                        behaviorCmd.Parameters.AddWithValue("@Pansexual", nudPansexual.Value)
                        behaviorCmd.ExecuteNonQuery()

                        ' Insert identification
                        Dim identQuery As String = "INSERT INTO tbl_ESG_Identification (SocialID, Transgender, Queer, Questioning, NonBinary, Agender) VALUES (@SocialID, @Transgender, @Queer, @Questioning, @NonBinary, @Agender)"
                        Dim identCmd As New SqlCommand(identQuery, conn, transaction)
                        identCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        identCmd.Parameters.AddWithValue("@Transgender", nudTransgender.Value)
                        identCmd.Parameters.AddWithValue("@Queer", nudQueer.Value)
                        identCmd.Parameters.AddWithValue("@Questioning", nudQuestioning.Value)
                        identCmd.Parameters.AddWithValue("@NonBinary", nudNonBinary.Value)
                        identCmd.Parameters.AddWithValue("@Agender", nudAgender.Value)
                        identCmd.ExecuteNonQuery()

                        ' Insert nations
                        Dim nationsQuery As String = "INSERT INTO tbl_ESG_Nations (SocialID, African, Asian, HispanicLatino, Indigenous, MiddleEastern, PacificIslander, European, OtherEthnicity, OtherEthnicitySpecify) VALUES (@SocialID, @African, @Asian, @Hispanic, @Indigenous, @MiddleEastern, @PacificIslander, @European, @OtherEthnicity, @OtherSpecify)"
                        Dim nationsCmd As New SqlCommand(nationsQuery, conn, transaction)
                        nationsCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        nationsCmd.Parameters.AddWithValue("@African", nudAfrican.Value)
                        nationsCmd.Parameters.AddWithValue("@Asian", nudAsian.Value)
                        nationsCmd.Parameters.AddWithValue("@Hispanic", nudHispanic.Value)
                        nationsCmd.Parameters.AddWithValue("@Indigenous", nudIndigenous.Value)
                        nationsCmd.Parameters.AddWithValue("@MiddleEastern", nudMiddleEastern.Value)
                        nationsCmd.Parameters.AddWithValue("@PacificIslander", nudPacificIslander.Value)
                        nationsCmd.Parameters.AddWithValue("@European", nudEuropean.Value)
                        nationsCmd.Parameters.AddWithValue("@OtherEthnicity", nudOtherEthnicity.Value)
                        nationsCmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherEthnicitySpecify.Text), DBNull.Value, txtOtherEthnicitySpecify.Text))
                        nationsCmd.ExecuteNonQuery()

                        ' Insert religions
                        Dim religionsQuery As String = "INSERT INTO tbl_ESG_Religions (SocialID, Christianity, Islam, Hinduism, Buddhism, Judaism, Sikhism, OtherReligion, OtherReligionSpecify, NoReligion) VALUES (@SocialID, @Christianity, @Islam, @Hinduism, @Buddhism, @Judaism, @Sikhism, @OtherReligion, @OtherSpecify, @NoReligion)"
                        Dim religionsCmd As New SqlCommand(religionsQuery, conn, transaction)
                        religionsCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        religionsCmd.Parameters.AddWithValue("@Christianity", nudChristianity.Value)
                        religionsCmd.Parameters.AddWithValue("@Islam", nudIslam.Value)
                        religionsCmd.Parameters.AddWithValue("@Hinduism", nudHinduism.Value)
                        religionsCmd.Parameters.AddWithValue("@Buddhism", nudBuddhism.Value)
                        religionsCmd.Parameters.AddWithValue("@Judaism", nudJudaism.Value)
                        religionsCmd.Parameters.AddWithValue("@Sikhism", nudSikhism.Value)
                        religionsCmd.Parameters.AddWithValue("@OtherReligion", nudOtherReligion.Value)
                        religionsCmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherReligionSpecify.Text), DBNull.Value, txtOtherReligionSpecify.Text))
                        religionsCmd.Parameters.AddWithValue("@NoReligion", nudNoReligion.Value)
                        religionsCmd.ExecuteNonQuery()

                        ' Insert languages
                        Dim languagesQuery As String = "INSERT INTO tbl_ESG_Languages (SocialID, Sinhala, Hebrew, French, Hindi) VALUES (@SocialID, @Sinhala, @Hebrew, @French, @Hindi)"
                        Dim languagesCmd As New SqlCommand(languagesQuery, conn, transaction)
                        languagesCmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                        languagesCmd.Parameters.AddWithValue("@Sinhala", nudSinhala.Value)
                        languagesCmd.Parameters.AddWithValue("@Hebrew", nudHebrew.Value)
                        languagesCmd.Parameters.AddWithValue("@French", nudFrench.Value)
                        languagesCmd.Parameters.AddWithValue("@Hindi", nudHindi.Value)
                        languagesCmd.ExecuteNonQuery()

                        transaction.Commit()
                        MessageBox.Show("All Social Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadSocialData()
                        ClearSocialControls()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving social data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadSocial_Click(sender As Object, e As EventArgs) Handles btnLoadSocial.Click
        LoadSocialData()
    End Sub

    Private Sub LoadSocialData()
        Try
            Dim query As String = "SELECT s.SocialID, s.ReportMonth, s.ReportYear, s.MaleCount, s.FemaleCount, s.AgeUnder18, s.Age18To30, s.Age31To50, s.AgeOver50, s.LearntSkillsAtNIRU, s.HiredQualified, s.NewToIndustry, s.Promotions, s.InternalMobility, s.SameFamilyCount FROM tbl_ESG_Social_Data s WHERE 1=1"

            If socialFilterYear.HasValue Then
                query &= " AND s.ReportYear = " & socialFilterYear.Value
            End If
            If socialFilterMonth.HasValue Then
                query &= " AND s.ReportMonth = " & socialFilterMonth.Value
            End If

            query &= " ORDER BY s.ReportYear DESC, s.ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocial.DataSource = dt
            dgvSocial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading social data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnApplySocialFilter_Click(sender As Object, e As EventArgs) Handles btnApplySocialFilter.Click
        socialFilterYear = dtpSocialFilterYear.Value.Year
        socialFilterMonth = dtpSocialFilterMonth.Value.Month
        LoadSocialData()
    End Sub

    Private Sub btnClearSocialFilter_Click(sender As Object, e As EventArgs) Handles btnClearSocialFilter.Click
        socialFilterYear = Nothing
        socialFilterMonth = Nothing
        dtpSocialFilterYear.Value = DateTime.Now
        dtpSocialFilterMonth.Value = DateTime.Now
        LoadSocialData()
    End Sub

    Private Sub ClearSocialControls()
        nudMale.Value = 0
        nudFemale.Value = 0
        ageCategories.Clear()
        LoadAgeCategoriesList()
        nudLearntAtNIRU.Value = 0
        nudHiredQualified.Value = 0
        nudNewToIndustry.Value = 0
        nudPromotions.Value = 0
        nudInternalMobility.Value = 0
        nudSameFamily.Value = 0
        nudWomenFirstLine.Value = 0
        nudMenFirstLine.Value = 0
        nudWomenMiddle.Value = 0
        nudMenMiddle.Value = 0
        nudWomenUpper.Value = 0
        nudMenUpper.Value = 0
        nudWomenLeadership.Value = 0
        nudMenLeadership.Value = 0

        ' Clear minorities
        nudPhysical.Value = 0
        nudSensory.Value = 0
        nudMentalHealth.Value = 0
        nudIntellectual.Value = 0
        nudChronic.Value = 0
        nudLesbian.Value = 0
        nudGay.Value = 0
        nudBisexual.Value = 0
        nudAsexual.Value = 0
        nudPansexual.Value = 0
        nudTransgender.Value = 0
        nudQueer.Value = 0
        nudQuestioning.Value = 0
        nudNonBinary.Value = 0
        nudAgender.Value = 0
        nudAfrican.Value = 0
        nudAsian.Value = 0
        nudHispanic.Value = 0
        nudIndigenous.Value = 0
        nudMiddleEastern.Value = 0
        nudPacificIslander.Value = 0
        nudEuropean.Value = 0
        nudOtherEthnicity.Value = 0
        txtOtherEthnicitySpecify.Clear()
        nudChristianity.Value = 0
        nudIslam.Value = 0
        nudHinduism.Value = 0
        nudBuddhism.Value = 0
        nudJudaism.Value = 0
        nudSikhism.Value = 0
        nudOtherReligion.Value = 0
        txtOtherReligionSpecify.Clear()
        nudNoReligion.Value = 0
        nudSinhala.Value = 0
        nudHebrew.Value = 0
        nudFrench.Value = 0
        nudHindi.Value = 0
        dtpSocial.Value = DateTime.Now
    End Sub

    Private Sub btnExportSocial_Click(sender As Object, e As EventArgs) Handles btnExportSocial.Click
        If dgvSocial.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        modShared.ExportToExcel(dgvSocial, "Social_Data_Report")
    End Sub

    '' ==================== SUMMARIZED REPORT ====================

    Private Sub btnGenerateSummary_Click(sender As Object, e As EventArgs) Handles btnGenerateSummary.Click
        '    Try
        '        Dim selectedYear As Integer = dtpSummaryYear.Value.Year

        '        Dim summaryForm As New Form()
        '        summaryForm.Text = $"ESG Summary Report - {selectedYear}"
        '        summaryForm.Size = New Size(1200, 700)
        '        summaryForm.StartPosition = FormStartPosition.CenterParent

        '        Dim tabControl As New TabControl()
        '        tabControl.Dock = DockStyle.Fill

        '        ' Create summary tabs
        '        Dim hseTab As New TabPage("HSE Training Summary")
        '        Dim dgvHSESummary As New DataGridView()
        '        dgvHSESummary.Dock = DockStyle.Fill
        '        dgvHSESummary.RowTemplate.Height = 25
        '        hseTab.Controls.Add(dgvHSESummary)

        '        Dim safetyTab As New TabPage("Safety Incidents Summary")
        '        Dim dgvSafetySummary As New DataGridView()
        '        dgvSafetySummary.Dock = DockStyle.Fill
        '        dgvSafetySummary.RowTemplate.Height = 25
        '        safetyTab.Controls.Add(dgvSafetySummary)

        '        Dim grievancesTab As New TabPage("Grievances Summary")
        '        Dim dgvGrievancesSummary As New DataGridView()
        '        dgvGrievancesSummary.Dock = DockStyle.Fill
        '        dgvGrievancesSummary.RowTemplate.Height = 25
        '        grievancesTab.Controls.Add(dgvGrievancesSummary)

        '        Dim socialTab As New TabPage("Social Data Summary")
        '        Dim dgvSocialSummary As New DataGridView()
        '        dgvSocialSummary.Dock = DockStyle.Fill
        '        dgvSocialSummary.RowTemplate.Height = 25
        '        socialTab.Controls.Add(dgvSocialSummary)

        '        Dim overallTab As New TabPage("Overall Summary")
        '        Dim txtOverallSummary As New TextBox()
        '        txtOverallSummary.Dock = DockStyle.Fill
        '        txtOverallSummary.Multiline = True
        '        txtOverallSummary.ScrollBars = ScrollBars.Both
        '        txtOverallSummary.Font = New Font("Consolas", 10)
        '        overallTab.Controls.Add(txtOverallSummary)

        '        tabControl.TabPages.Add(hseTab)
        '        tabControl.TabPages.Add(safetyTab)
        '        tabControl.TabPages.Add(grievancesTab)
        '        tabControl.TabPages.Add(socialTab)
        '        tabControl.TabPages.Add(overallTab)

        '        summaryForm.Controls.Add(tabControl)

        '        ' Load HSE Summary
        '        Dim hseQuery As String = $"SELECT ReportMonth, SUM(AttendedHealthSafety) as 'Health & Safety', SUM(AttendedFirstAid) as 'First Aid', SUM(AttendedFireFighting) as 'Fire Fighting', SUM(AttendedOtherWorkshop) as 'Other Workshops' FROM tbl_ESG_HSE_Training WHERE ReportYear = {selectedYear} GROUP BY ReportMonth ORDER BY ReportMonth"
        '        dgvHSESummary.DataSource = DatabaseHelper.GetDataTable(hseQuery, Nothing)

        '        ' Load Safety Summary
        '        Dim safetyQuery As String = $"SELECT ReportMonth, SUM(PropertyDamageIncidents) as 'Property Damage', SUM(EnvironmentalIncidents) as 'Environmental', SUM(NearMisses) as 'Near Misses', SUM(TotalAccidents) as 'Total Accidents', SUM(AccidentsWithInjuries) as 'Injuries', SUM(AccidentsWithDeath) as 'Deaths' FROM tbl_ESG_Safety_Incidents WHERE ReportYear = {selectedYear} GROUP BY ReportMonth ORDER BY ReportMonth"
        '        dgvSafetySummary.DataSource = DatabaseHelper.GetDataTable(safetyQuery, Nothing)

        '        ' Load Grievances Summary
        '        Dim grievancesQuery As String = $"SELECT ReportMonth, SUM(TotalEmployeeGrievances) as 'Total Grievances', SUM(UnresolvedEmployeeGrievances) as 'Unresolved Grievances' FROM tbl_ESG_Grievances WHERE ReportYear = {selectedYear} GROUP BY ReportMonth ORDER BY ReportMonth"
        '        dgvGrievancesSummary.DataSource = DatabaseHelper.GetDataTable(grievancesQuery, Nothing)

        '        ' Load Social Summary
        '        Dim socialQuery As String = $"SELECT ReportMonth, SUM(MaleCount) as 'Male', SUM(FemaleCount) as 'Female', SUM(Promotions) as 'Promotions', SUM(InternalMobility) as 'Internal Mobility' FROM tbl_ESG_Social_Data WHERE ReportYear = {selectedYear} GROUP BY ReportMonth ORDER BY ReportMonth"
        '        dgvSocialSummary.DataSource = DatabaseHelper.GetDataTable(socialQuery, Nothing)

        '        ' Generate Overall Summary Text
        '        Dim overallText As New System.Text.StringBuilder()
        '        overallText.AppendLine("=" & New String("=", 78))
        '        overallText.AppendLine($"ESG SUMMARY REPORT FOR YEAR {selectedYear}")
        '        overallText.AppendLine("=" & New String("=", 78))
        '        overallText.AppendLine()

        '        ' HSE Summary
        '        overallText.AppendLine("HSE TRAINING SUMMARY:")
        '        overallText.AppendLine("-" & New String("-", 50))
        '        Dim hseDT As DataTable = DatabaseHelper.GetDataTable($"SELECT SUM(AttendedHealthSafety) as TotalHSE, SUM(AttendedFirstAid) as TotalFirstAid, SUM(AttendedFireFighting) as TotalFire, SUM(AttendedOtherWorkshop) as TotalOther FROM tbl_ESG_HSE_Training WHERE ReportYear = {selectedYear}", Nothing)
        '        If hseDT.Rows.Count > 0 Then
        '            overallText.AppendLine($"  Total Health & Safety Training: {hseDT.Rows(0)("TotalHSE")}")
        '            overallText.AppendLine($"  Total First Aid Training: {hseDT.Rows(0)("TotalFirstAid")}")
        '            overallText.AppendLine($"  Total Fire Fighting Training: {hseDT.Rows(0)("TotalFire")}")
        '            overallText.AppendLine($"  Total Other Workshops: {hseDT.Rows(0)("TotalOther")}")
        '        End If
        '        overallText.AppendLine()

        '        ' Safety Summary
        '        overallText.AppendLine("SAFETY INCIDENTS SUMMARY:")
        '        overallText.AppendLine("-" & New String("-", 50))
        '        Dim safetyDT As DataTable = DatabaseHelper.GetDataTable($"SELECT SUM(TotalIncidentCounter) as TotalIncidents, SUM(AccidentsWithDeath) as TotalDeaths, SUM(AccidentsWithInjuries) as TotalInjuries FROM tbl_ESG_Safety_Incidents WHERE ReportYear = {selectedYear}", Nothing)
        '        If safetyDT.Rows.Count > 0 Then
        '            overallText.AppendLine($"  Total Incidents: {safetyDT.Rows(0)("TotalIncidents")}")
        '            overallText.AppendLine($"  Total Injuries: {safetyDT.Rows(0)("TotalInjuries")}")
        '            overallText.AppendLine($"  Total Fatalities: {safetyDT.Rows(0)("TotalDeaths")}")
        '        End If
        '        overallText.AppendLine()

        '        ' Grievances Summary
        '        overallText.AppendLine("GRIEVANCES SUMMARY:")
        '        overallText.AppendLine("-" & New String("-", 50))
        '        Dim grievancesDT As DataTable = DatabaseHelper.GetDataTable($"SELECT SUM(TotalEmployeeGrievances) as TotalGrievances, SUM(UnresolvedEmployeeGrievances) as Unresolved FROM tbl_ESG_Grievances WHERE ReportYear = {selectedYear}", Nothing)
        '        If grievancesDT.Rows.Count > 0 Then
        '            overallText.AppendLine($"  Total Grievances Filed: {grievancesDT.Rows(0)("TotalGrievances")}")
        '            overallText.AppendLine($"  Unresolved Grievances: {grievancesDT.Rows(0)("Unresolved")}")
        '        End If
        '        overallText.AppendLine()

        '        ' Social Summary
        '        overallText.AppendLine("SOCIAL DATA SUMMARY:")
        '        overallText.AppendLine("-" & New String("-", 50))
        '        Dim socialDT As DataTable = DatabaseHelper.GetDataTable($"SELECT SUM(MaleCount) as TotalMale, SUM(FemaleCount) as TotalFemale, SUM(Promotions) as TotalPromotions, SUM(InternalMobility) as TotalMobility FROM tbl_ESG_Social_Data WHERE ReportYear = {selectedYear}", Nothing)
        '        If socialDT.Rows.Count > 0 Then
        '            overallText.AppendLine($"  Total Male Employees: {socialDT.Rows(0)("TotalMale")}")
        '            overallText.AppendLine($"  Total Female Employees: {socialDT.Rows(0)("TotalFemale")}")
        '            overallText.AppendLine($"  Total Promotions: {socialDT.Rows(0)("TotalPromotions")}")
        '            overallText.AppendLine($"  Internal Mobility: {socialDT.Rows(0)("TotalMobility")}")
        '        End If
        '        overallText.AppendLine()
        '        overallText.AppendLine("=" & New String("=", 78))
        '        overallText.AppendLine($"Report Generated on: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}")
        '        overallText.AppendLine("=" & New String("=", 78))

        '        txtOverallSummary.Text = overallText.ToString()

        '        summaryForm.ShowDialog()

        '    Catch ex As Exception
        '        MessageBox.Show("Error generating summary report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End Try
    End Sub

    Private Sub MainTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainTabControl.SelectedIndexChanged

    End Sub
End Class