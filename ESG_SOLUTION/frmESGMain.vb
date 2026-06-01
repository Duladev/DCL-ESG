Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmESGMain
    Private ageCategories As New Dictionary(Of String, Integer)

    Private Sub frmESGMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearAllGrids()
        SetupAgeComboBox()
    End Sub

    Private Sub ClearAllGrids()
        dgvHSE.DataSource = Nothing
        dgvSafety.DataSource = Nothing
        dgvGrievances.DataSource = Nothing
        dgvSocial.DataSource = Nothing
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

    ' HSE Methods
    Private Sub btnSaveHSE_Click(sender As Object, e As EventArgs) Handles btnSaveHSE.Click
        Try
            ' Validate inputs
            If nudHSECount.Value < 0 OrElse nudFirstAid.Value < 0 OrElse nudFireFighting.Value < 0 Then
                MessageBox.Show("Please enter valid numbers (0 or greater)", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Insert into database
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

            MessageBox.Show("HSE Data Saved Successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadHSEData()
            ClearHSEControls()
        Catch ex As Exception
            MessageBox.Show("Error saving HSE data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadHSEData()
        Try
            Dim query As String = "SELECT TrainingID, ReportMonth, ReportYear, AttendedHealthSafety, AttendedFirstAid, AttendedFireFighting, AttendedOtherWorkshop, OtherWorkshopName, CreatedDate FROM tbl_ESG_HSE_Training ORDER BY ReportYear DESC, ReportMonth DESC"
            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvHSE.DataSource = dt
            dgvHSE.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading HSE data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearHSEControls()
        nudHSECount.Value = 0
        nudFirstAid.Value = 0
        nudFireFighting.Value = 0
        nudOtherWorkshop.Value = 0
        txtOtherWorkshopName.Clear()
    End Sub

    Private Sub btnLoadHSE_Click(sender As Object, e As EventArgs) Handles btnLoadHSE.Click
        LoadHSEData()
    End Sub

    ' Safety Methods
    Private Sub btnSaveSafety_Click(sender As Object, e As EventArgs) Handles btnSaveSafety.Click
        Try
            Dim totalIncidents As Integer = CInt(nudPropertyDamage.Value + nudEnvironmental.Value +
                                                nudNearMisses.Value + nudTotalAccidents.Value)

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

            MessageBox.Show("Safety Data Saved Successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSafetyData()
            ClearSafetyControls()
        Catch ex As Exception
            MessageBox.Show("Error saving safety data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSafetyData()
        Try
            Dim query As String = "SELECT IncidentID, ReportMonth, ReportYear, PropertyDamageIncidents, EnvironmentalIncidents, NearMisses, TotalAccidents, AccidentsWithInjuries, AccidentsWithIllness, AccidentsWithDeath, TotalIncidentCounter FROM tbl_ESG_Safety_Incidents ORDER BY ReportYear DESC, ReportMonth DESC"
            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSafety.DataSource = dt
            dgvSafety.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading safety data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearSafetyControls()
        nudPropertyDamage.Value = 0
        nudEnvironmental.Value = 0
        nudNearMisses.Value = 0
        nudTotalAccidents.Value = 0
        nudInjuries.Value = 0
        nudIllness.Value = 0
        nudDeaths.Value = 0
    End Sub

    ' Grievances Methods
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

            MessageBox.Show("Grievances Data Saved Successfully!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGrievancesData()
            ClearGrievancesControls()
        Catch ex As Exception
            MessageBox.Show("Error saving grievances data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadGrievancesData()
        Try
            Dim query As String = "SELECT GrievanceID, ReportMonth, ReportYear, TotalEmployeeGrievances, UnresolvedEmployeeGrievances FROM tbl_ESG_Grievances ORDER BY ReportYear DESC, ReportMonth DESC"
            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvGrievances.DataSource = dt
            dgvGrievances.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading grievances data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearGrievancesControls()
        nudTotalGrievances.Value = 0
        nudUnresolvedGrievances.Value = 0
    End Sub

    ' Social Data Methods
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

                MessageBox.Show($"Added {count} to {selectedCategory}", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                nudAgeCount.Value = 0
            Else
                MessageBox.Show("Please enter a count greater than 0", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
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

                        Dim socialID As Integer = Convert.ToInt32(mainCmd.ExecuteScalar())

                        ' Insert disabilities (simplified - add similar for other tables)
                        Dim disabilityQuery As String = "INSERT INTO tbl_ESG_Disabilities (SocialID, PhysicalDisabilities, SensoryDisabilities, MentalHealthConditions, IntellectualDisabilities, ChronicHealthConditions) VALUES (@SocialID, @Physical, @Sensory, @Mental, @Intellectual, @Chronic)"
                        Dim disabilityCmd As New SqlCommand(disabilityQuery, conn, transaction)
                        disabilityCmd.Parameters.AddWithValue("@SocialID", socialID)
                        disabilityCmd.Parameters.AddWithValue("@Physical", nudPhysical.Value)
                        disabilityCmd.Parameters.AddWithValue("@Sensory", nudSensory.Value)
                        disabilityCmd.Parameters.AddWithValue("@Mental", nudMentalHealth.Value)
                        disabilityCmd.Parameters.AddWithValue("@Intellectual", nudIntellectual.Value)
                        disabilityCmd.Parameters.AddWithValue("@Chronic", nudChronic.Value)
                        disabilityCmd.ExecuteNonQuery()

                        ' Add similar code for Behavior, Identification, Nations, Religions, Languages tables
                        ' ... (continue with other insert statements)

                        transaction.Commit()
                        MessageBox.Show("Social Data Saved Successfully!", "Success",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LoadSocialData()
                        ClearSocialControls()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving social data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSocialData()
        Try
            Dim query As String = "SELECT * FROM tbl_ESG_Social_Data ORDER BY ReportYear DESC, ReportMonth DESC"
            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocial.DataSource = dt
            dgvSocial.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error loading social data: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadSocial_Click(sender As Object, e As EventArgs) Handles btnLoadSocial.Click
        LoadSocialData()
    End Sub

    Private Sub ClearSocialControls()
        nudMale.Value = 0
        nudFemale.Value = 0
        ageCategories.Clear()
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
    End Sub

    Private Sub GroupBoxSafety_Enter(sender As Object, e As EventArgs) Handles GroupBoxSafety.Enter

    End Sub
End Class

