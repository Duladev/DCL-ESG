Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class frmESGMain
    Private ageCategories As New Dictionary(Of String, Integer)
    Private currentSocialID As Integer = 0
    Private currentEditMode As Boolean = False
    Private currentEditTable As String = ""
    Private currentEditRecordID As Integer = 0

    ' Filter variables
    Private hseFilterYear As Integer? = Nothing
    Private hseFilterMonth As Integer? = Nothing
    Private safetyFilterYear As Integer? = Nothing
    Private safetyFilterMonth As Integer? = Nothing
    Private grievancesFilterYear As Integer? = Nothing
    Private grievancesFilterMonth As Integer? = Nothing

    ' Social filter variables
    Private socialFilterYear As Integer? = Nothing
    Private socialFilterMonth As Integer? = Nothing
    Private skillsFilterYear As Integer? = Nothing
    Private skillsFilterMonth As Integer? = Nothing
    Private promotionsFilterYear As Integer? = Nothing
    Private promotionsFilterMonth As Integer? = Nothing
    Private managementFilterYear As Integer? = Nothing
    Private managementFilterMonth As Integer? = Nothing
    Private disabilitiesFilterYear As Integer? = Nothing
    Private disabilitiesFilterMonth As Integer? = Nothing
    Private behaviorFilterYear As Integer? = Nothing
    Private behaviorFilterMonth As Integer? = Nothing
    Private identificationFilterYear As Integer? = Nothing
    Private identificationFilterMonth As Integer? = Nothing
    Private nationsFilterYear As Integer? = Nothing
    Private nationsFilterMonth As Integer? = Nothing
    Private religionsFilterYear As Integer? = Nothing
    Private religionsFilterMonth As Integer? = Nothing
    Private languagesFilterYear As Integer? = Nothing
    Private languagesFilterMonth As Integer? = Nothing

    Private Sub frmESGMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyModernStyle(Me)
        ClearAllGrids()
        SetupAgeComboBox()
        SetupDataGridViews()
        LoadAllData()
        SetupFilters()
        LoadAgeCategoriesList()
        SetupContextMenus()
        SetupDeleteButtons()
    End Sub

    Private Sub SetupDataGridViews()
        ' Set row height for all grids
        Dim grids As DataGridView() = {dgvHSE, dgvSafety, dgvGrievances, dgvSocialBasic, dgvSocialSkills, dgvSocialPromotions,
                                       dgvSocialManagement, dgvSocialDisabilities, dgvSocialBehavior, dgvSocialIdentification,
                                       dgvSocialNations, dgvSocialReligions, dgvSocialLanguages}
        For Each grid As DataGridView In grids
            If grid IsNot Nothing Then
                grid.RowTemplate.Height = 20
                grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                grid.AllowUserToResizeRows = False
                grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                grid.MultiSelect = False
            End If
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
        dgvSocialBasic.DataSource = Nothing
        dgvSocialSkills.DataSource = Nothing
        dgvSocialPromotions.DataSource = Nothing
        dgvSocialManagement.DataSource = Nothing
        dgvSocialDisabilities.DataSource = Nothing
        dgvSocialBehavior.DataSource = Nothing
        dgvSocialIdentification.DataSource = Nothing
        dgvSocialNations.DataSource = Nothing
        dgvSocialReligions.DataSource = Nothing
        dgvSocialLanguages.DataSource = Nothing
    End Sub

    Private Sub LoadAllData()
        LoadHSEData()
        LoadSafetyData()
        LoadGrievancesData()
        LoadAllSocialData()
    End Sub

    Private Sub LoadAgeCategoriesList()
        lstAgeCategories.Items.Clear()
        For Each kvp As KeyValuePair(Of String, Integer) In ageCategories
            lstAgeCategories.Items.Add($"{kvp.Key}: {kvp.Value}")
        Next
    End Sub

    ' ==================== DELETE METHODS ====================

    Private Sub SetupContextMenus()
        ' HSE Grid
        cmsHSE = New ContextMenuStrip()
        Dim deleteHSEMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteHSEMenuItem.Click, AddressOf DeleteHSERecord
        cmsHSE.Items.Add(deleteHSEMenuItem)
        dgvHSE.ContextMenuStrip = cmsHSE

        ' Safety Grid
        cmsSafety = New ContextMenuStrip()
        Dim deleteSafetyMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSafetyMenuItem.Click, AddressOf DeleteSafetyRecord
        cmsSafety.Items.Add(deleteSafetyMenuItem)
        dgvSafety.ContextMenuStrip = cmsSafety

        ' Grievances Grid
        cmsGrievances = New ContextMenuStrip()
        Dim deleteGrievancesMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteGrievancesMenuItem.Click, AddressOf DeleteGrievancesRecord
        cmsGrievances.Items.Add(deleteGrievancesMenuItem)
        dgvGrievances.ContextMenuStrip = cmsGrievances

        ' Social Basic Grid
        cmsSocialBasic = New ContextMenuStrip()
        Dim deleteSocialBasicMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialBasicMenuItem.Click, AddressOf DeleteSocialBasicRecord
        cmsSocialBasic.Items.Add(deleteSocialBasicMenuItem)
        dgvSocialBasic.ContextMenuStrip = cmsSocialBasic

        ' Social Skills Grid
        cmsSocialSkills = New ContextMenuStrip()
        Dim deleteSocialSkillsMenuItem As New ToolStripMenuItem("Clear Skills Data")
        AddHandler deleteSocialSkillsMenuItem.Click, AddressOf DeleteSocialSkillsRecord
        cmsSocialSkills.Items.Add(deleteSocialSkillsMenuItem)
        dgvSocialSkills.ContextMenuStrip = cmsSocialSkills

        ' Social Promotions Grid
        cmsSocialPromotions = New ContextMenuStrip()
        Dim deleteSocialPromotionsMenuItem As New ToolStripMenuItem("Clear Promotions Data")
        AddHandler deleteSocialPromotionsMenuItem.Click, AddressOf DeleteSocialPromotionsRecord
        cmsSocialPromotions.Items.Add(deleteSocialPromotionsMenuItem)
        dgvSocialPromotions.ContextMenuStrip = cmsSocialPromotions

        ' Social Management Grid
        cmsSocialManagement = New ContextMenuStrip()
        Dim deleteSocialManagementMenuItem As New ToolStripMenuItem("Clear Management Data")
        AddHandler deleteSocialManagementMenuItem.Click, AddressOf DeleteSocialManagementRecord
        cmsSocialManagement.Items.Add(deleteSocialManagementMenuItem)
        dgvSocialManagement.ContextMenuStrip = cmsSocialManagement

        ' Social Disabilities Grid
        cmsSocialDisabilities = New ContextMenuStrip()
        Dim deleteSocialDisabilitiesMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialDisabilitiesMenuItem.Click, AddressOf DeleteSocialDisabilitiesRecord
        cmsSocialDisabilities.Items.Add(deleteSocialDisabilitiesMenuItem)
        dgvSocialDisabilities.ContextMenuStrip = cmsSocialDisabilities

        ' Social Behavior Grid
        cmsSocialBehavior = New ContextMenuStrip()
        Dim deleteSocialBehaviorMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialBehaviorMenuItem.Click, AddressOf DeleteSocialBehaviorRecord
        cmsSocialBehavior.Items.Add(deleteSocialBehaviorMenuItem)
        dgvSocialBehavior.ContextMenuStrip = cmsSocialBehavior

        ' Social Identification Grid
        cmsSocialIdentification = New ContextMenuStrip()
        Dim deleteSocialIdentificationMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialIdentificationMenuItem.Click, AddressOf DeleteSocialIdentificationRecord
        cmsSocialIdentification.Items.Add(deleteSocialIdentificationMenuItem)
        dgvSocialIdentification.ContextMenuStrip = cmsSocialIdentification

        ' Social Nations Grid
        cmsSocialNations = New ContextMenuStrip()
        Dim deleteSocialNationsMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialNationsMenuItem.Click, AddressOf DeleteSocialNationsRecord
        cmsSocialNations.Items.Add(deleteSocialNationsMenuItem)
        dgvSocialNations.ContextMenuStrip = cmsSocialNations

        ' Social Religions Grid
        cmsSocialReligions = New ContextMenuStrip()
        Dim deleteSocialReligionsMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialReligionsMenuItem.Click, AddressOf DeleteSocialReligionsRecord
        cmsSocialReligions.Items.Add(deleteSocialReligionsMenuItem)
        dgvSocialReligions.ContextMenuStrip = cmsSocialReligions

        ' Social Languages Grid
        cmsSocialLanguages = New ContextMenuStrip()
        Dim deleteSocialLanguagesMenuItem As New ToolStripMenuItem("Delete Record")
        AddHandler deleteSocialLanguagesMenuItem.Click, AddressOf DeleteSocialLanguagesRecord
        cmsSocialLanguages.Items.Add(deleteSocialLanguagesMenuItem)
        dgvSocialLanguages.ContextMenuStrip = cmsSocialLanguages
    End Sub

    Private Sub SetupDeleteButtons()
        ' Hook up delete button events
        AddHandler btnDeleteHSE.Click, AddressOf btnDeleteHSE_Click
        AddHandler btnDeleteSafety.Click, AddressOf btnDeleteSafety_Click
        AddHandler btnDeleteGrievances.Click, AddressOf btnDeleteGrievances_Click
    End Sub

    Private Sub DeleteRecord(ByVal tableName As String, ByVal idFieldName As String, ByVal idValue As Integer)
        Try
            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.No Then
                Return
            End If

            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = $"DELETE FROM {tableName} WHERE {idFieldName} = @ID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", idValue)
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh the appropriate grid based on table name
                        Select Case tableName
                            Case "tbl_ESG_HSE_Training"
                                LoadHSEData()
                            Case "tbl_ESG_Safety_Incidents"
                                LoadSafetyData()
                            Case "tbl_ESG_Grievances"
                                LoadGrievancesData()
                            Case "tbl_ESG_Social_Data"
                                LoadAllSocialData()
                            Case "tbl_ESG_Disabilities"
                                LoadSocialDisabilitiesData()
                            Case "tbl_ESG_Behavior"
                                LoadSocialBehaviorData()
                            Case "tbl_ESG_Identification"
                                LoadSocialIdentificationData()
                            Case "tbl_ESG_Nations"
                                LoadSocialNationsData()
                            Case "tbl_ESG_Religions"
                                LoadSocialReligionsData()
                            Case "tbl_ESG_Languages"
                                LoadSocialLanguagesData()
                        End Select
                    Else
                        MessageBox.Show("No record found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' HSE Delete Handlers
    Private Sub DeleteHSERecord(sender As Object, e As EventArgs)
        If dgvHSE.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvHSE.CurrentRow.Cells("TrainingID").Value)
            DeleteRecord("tbl_ESG_HSE_Training", "TrainingID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDeleteHSE_Click(sender As Object, e As EventArgs)
        DeleteHSERecord(sender, e)
    End Sub

    ' Safety Delete Handlers
    Private Sub DeleteSafetyRecord(sender As Object, e As EventArgs)
        If dgvSafety.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSafety.CurrentRow.Cells("IncidentID").Value)
            DeleteRecord("tbl_ESG_Safety_Incidents", "IncidentID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDeleteSafety_Click(sender As Object, e As EventArgs)
        DeleteSafetyRecord(sender, e)
    End Sub

    ' Grievances Delete Handlers
    Private Sub DeleteGrievancesRecord(sender As Object, e As EventArgs)
        If dgvGrievances.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvGrievances.CurrentRow.Cells("GrievanceID").Value)
            DeleteRecord("tbl_ESG_Grievances", "GrievanceID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDeleteGrievances_Click(sender As Object, e As EventArgs)
        DeleteGrievancesRecord(sender, e)
    End Sub

    ' Social Basic Delete Handler
    Private Sub DeleteSocialBasicRecord(sender As Object, e As EventArgs)
        If dgvSocialBasic.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialBasic.CurrentRow.Cells("SocialID").Value)

            ' First delete related records from child tables
            Dim result As DialogResult = MessageBox.Show("This will also delete all related records (Skills, Promotions, Management, Disabilities, Behavior, Identification, Nations, Religions, Languages). Continue?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Using conn As SqlConnection = ModShared.GetConnection()
                        conn.Open()
                        Dim transaction = conn.BeginTransaction()

                        Try
                            ' Delete from child tables
                            Dim childTables As String() = {"tbl_ESG_Disabilities", "tbl_ESG_Behavior", "tbl_ESG_Identification",
                                                           "tbl_ESG_Nations", "tbl_ESG_Religions", "tbl_ESG_Languages"}

                            For Each table In childTables
                                Dim cmd As New SqlCommand($"DELETE FROM {table} WHERE SocialID = @ID", conn, transaction)
                                cmd.Parameters.AddWithValue("@ID", id)
                                cmd.ExecuteNonQuery()
                            Next

                            ' Delete from main table
                            Dim mainCmd As New SqlCommand("DELETE FROM tbl_ESG_Social_Data WHERE SocialID = @ID", conn, transaction)
                            mainCmd.Parameters.AddWithValue("@ID", id)
                            mainCmd.ExecuteNonQuery()

                            transaction.Commit()
                            MessageBox.Show("Record and all related data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LoadAllSocialData()
                        Catch
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Skills Delete Handler (clears data, doesn't delete)
    Private Sub DeleteSocialSkillsRecord(sender As Object, e As EventArgs)
        If dgvSocialSkills.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialSkills.CurrentRow.Cells("SocialID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the skills data for this record?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Using conn As SqlConnection = ModShared.GetConnection()
                        Dim query As String = "UPDATE tbl_ESG_Social_Data SET LearntSkillsAtNIRU = 0, HiredQualified = 0, NewToIndustry = 0, ModifiedDate = GETDATE() WHERE SocialID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@ID", id)
                            conn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Skills data cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadSocialSkillsData()
                Catch ex As Exception
                    MessageBox.Show("Error clearing skills data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to clear.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Promotions Delete Handler (clears data, doesn't delete)
    Private Sub DeleteSocialPromotionsRecord(sender As Object, e As EventArgs)
        If dgvSocialPromotions.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialPromotions.CurrentRow.Cells("SocialID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the promotions data for this record?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Using conn As SqlConnection = ModShared.GetConnection()
                        Dim query As String = "UPDATE tbl_ESG_Social_Data SET Promotions = 0, InternalMobility = 0, SameFamilyCount = 0, ModifiedDate = GETDATE() WHERE SocialID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@ID", id)
                            conn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Promotions data cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadSocialPromotionsData()
                Catch ex As Exception
                    MessageBox.Show("Error clearing promotions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to clear.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Management Delete Handler (clears data, doesn't delete)
    Private Sub DeleteSocialManagementRecord(sender As Object, e As EventArgs)
        If dgvSocialManagement.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialManagement.CurrentRow.Cells("SocialID").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the management data for this record?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    Using conn As SqlConnection = ModShared.GetConnection()
                        Dim query As String = "UPDATE tbl_ESG_Social_Data SET WomenFirstLineMgmt = 0, MenFirstLineMgmt = 0, WomenMiddleMgmt = 0, MenMiddleMgmt = 0, WomenUpperMgmt = 0, MenUpperMgmt = 0, WomenLeadershipTeam = 0, MenLeadershipTeam = 0, ModifiedDate = GETDATE() WHERE SocialID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@ID", id)
                            conn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Management data cleared successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadSocialManagementData()
                Catch ex As Exception
                    MessageBox.Show("Error clearing management data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to clear.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Disabilities Delete Handler
    Private Sub DeleteSocialDisabilitiesRecord(sender As Object, e As EventArgs)
        If dgvSocialDisabilities.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialDisabilities.CurrentRow.Cells("DisabilityID").Value)
            DeleteRecord("tbl_ESG_Disabilities", "DisabilityID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Behavior Delete Handler
    Private Sub DeleteSocialBehaviorRecord(sender As Object, e As EventArgs)
        If dgvSocialBehavior.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialBehavior.CurrentRow.Cells("BehaviorID").Value)
            DeleteRecord("tbl_ESG_Behavior", "BehaviorID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Identification Delete Handler
    Private Sub DeleteSocialIdentificationRecord(sender As Object, e As EventArgs)
        If dgvSocialIdentification.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialIdentification.CurrentRow.Cells("IdentificationID").Value)
            DeleteRecord("tbl_ESG_Identification", "IdentificationID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Nations Delete Handler
    Private Sub DeleteSocialNationsRecord(sender As Object, e As EventArgs)
        If dgvSocialNations.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialNations.CurrentRow.Cells("NationID").Value)
            DeleteRecord("tbl_ESG_Nations", "NationID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Religions Delete Handler
    Private Sub DeleteSocialReligionsRecord(sender As Object, e As EventArgs)
        If dgvSocialReligions.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialReligions.CurrentRow.Cells("ReligionID").Value)
            DeleteRecord("tbl_ESG_Religions", "ReligionID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Social Languages Delete Handler
    Private Sub DeleteSocialLanguagesRecord(sender As Object, e As EventArgs)
        If dgvSocialLanguages.CurrentRow IsNot Nothing Then
            Dim id As Integer = Convert.ToInt32(dgvSocialLanguages.CurrentRow.Cells("LanguageID").Value)
            DeleteRecord("tbl_ESG_Languages", "LanguageID", id)
        Else
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ==================== HSE TRAINING TAB ====================

    Private Sub btnSaveHSE_Click(sender As Object, e As EventArgs) Handles btnSaveHSE.Click
        Try
            If nudHSECount.Value = 0 And nudFirstAid.Value = 0 And nudFireFighting.Value = 0 And nudOtherWorkshop.Value = 0 Then
                MessageBox.Show("Please enter at least one training count", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using conn As SqlConnection = ModShared.GetConnection()
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
        ModShared.ExportToExcel(dgvHSE, "HSE_Training_Report")
    End Sub

    ' ==================== SAFETY INCIDENTS TAB ====================

    Private Sub btnSaveSafety_Click(sender As Object, e As EventArgs) Handles btnSaveSafety.Click
        Try
            Dim totalIncidents As Integer = CInt(nudPropertyDamage.Value + nudEnvironmental.Value + nudNearMisses.Value + nudTotalAccidents.Value)

            Using conn As SqlConnection = ModShared.GetConnection()
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
        ModShared.ExportToExcel(dgvSafety, "Safety_Incidents_Report")
    End Sub

    ' ==================== GRIEVANCES TAB ====================

    Private Sub btnSaveGrievances_Click(sender As Object, e As EventArgs) Handles btnSaveGrievances.Click
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
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
        ModShared.ExportToExcel(dgvGrievances, "Grievances_Report")
    End Sub

    ' ==================== SOCIAL DATA TAB ====================

    ' Load all social data grids
    Private Sub LoadAllSocialData()
        LoadSocialBasicData()
        LoadSocialSkillsData()
        LoadSocialPromotionsData()
        LoadSocialManagementData()
        LoadSocialDisabilitiesData()
        LoadSocialBehaviorData()
        LoadSocialIdentificationData()
        LoadSocialNationsData()
        LoadSocialReligionsData()
        LoadSocialLanguagesData()
    End Sub

    ' Basic Info Grid
    Private Sub LoadSocialBasicData()
        Try
            Dim query As String = "SELECT SocialID, ReportMonth, ReportYear, MaleCount as 'Male', FemaleCount as 'Female', AgeUnder18 as 'Under 18', Age18To30 as '18-30', Age31To50 as '31-50', AgeOver50 as 'Over 50' FROM tbl_ESG_Social_Data WHERE 1=1"

            If socialFilterYear.HasValue Then
                query &= " AND ReportYear = " & socialFilterYear.Value
            End If
            If socialFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & socialFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialBasic.DataSource = dt
            dgvSocialBasic.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading basic data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Skills Grid
    Private Sub LoadSocialSkillsData()
        Try
            Dim query As String = "SELECT SocialID, ReportMonth, ReportYear, LearntSkillsAtNIRU as 'Learnt at NIRU', HiredQualified as 'Hired Qualified', NewToIndustry as 'New to Industry' FROM tbl_ESG_Social_Data WHERE 1=1"

            If skillsFilterYear.HasValue Then
                query &= " AND ReportYear = " & skillsFilterYear.Value
            End If
            If skillsFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & skillsFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialSkills.DataSource = dt
            dgvSocialSkills.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading skills data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Promotions Grid
    Private Sub LoadSocialPromotionsData()
        Try
            Dim query As String = "SELECT SocialID, ReportMonth, ReportYear, Promotions, InternalMobility as 'Internal Mobility', SameFamilyCount as 'Same Family' FROM tbl_ESG_Social_Data WHERE 1=1"

            If promotionsFilterYear.HasValue Then
                query &= " AND ReportYear = " & promotionsFilterYear.Value
            End If
            If promotionsFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & promotionsFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialPromotions.DataSource = dt
            dgvSocialPromotions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading promotions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Management Grid
    Private Sub LoadSocialManagementData()
        Try
            Dim query As String = "SELECT SocialID, ReportMonth, ReportYear, WomenFirstLineMgmt as 'Women First Line', MenFirstLineMgmt as 'Men First Line', WomenMiddleMgmt as 'Women Middle', MenMiddleMgmt as 'Men Middle', WomenUpperMgmt as 'Women Upper', MenUpperMgmt as 'Men Upper', WomenLeadershipTeam as 'Women Leadership', MenLeadershipTeam as 'Men Leadership' FROM tbl_ESG_Social_Data WHERE 1=1"

            If managementFilterYear.HasValue Then
                query &= " AND ReportYear = " & managementFilterYear.Value
            End If
            If managementFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & managementFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialManagement.DataSource = dt
            dgvSocialManagement.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading management data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Disabilities Grid
    Private Sub LoadSocialDisabilitiesData()
        Try
            Dim query As String = "SELECT DisabilityID, SocialID, ReportMonth, ReportYear, PhysicalDisabilities as 'Physical', SensoryDisabilities as 'Sensory', MentalHealthConditions as 'Mental Health', IntellectualDisabilities as 'Intellectual', ChronicHealthConditions as 'Chronic' FROM tbl_ESG_Disabilities WHERE 1=1"

            If disabilitiesFilterYear.HasValue Then
                query &= " AND ReportYear = " & disabilitiesFilterYear.Value
            End If
            If disabilitiesFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & disabilitiesFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialDisabilities.DataSource = dt
            dgvSocialDisabilities.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading disabilities data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Behavior Grid
    Private Sub LoadSocialBehaviorData()
        Try
            Dim query As String = "SELECT BehaviorID, SocialID, ReportMonth, ReportYear, Lesbian, Gay, Bisexual, Asexual, Pansexual FROM tbl_ESG_Behavior WHERE 1=1"

            If behaviorFilterYear.HasValue Then
                query &= " AND ReportYear = " & behaviorFilterYear.Value
            End If
            If behaviorFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & behaviorFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialBehavior.DataSource = dt
            dgvSocialBehavior.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading behavior data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Identification Grid
    Private Sub LoadSocialIdentificationData()
        Try
            Dim query As String = "SELECT IdentificationID, SocialID, ReportMonth, ReportYear, Transgender, Queer, Questioning, NonBinary, Agender FROM tbl_ESG_Identification WHERE 1=1"

            If identificationFilterYear.HasValue Then
                query &= " AND ReportYear = " & identificationFilterYear.Value
            End If
            If identificationFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & identificationFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialIdentification.DataSource = dt
            dgvSocialIdentification.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading identification data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Nations Grid
    Private Sub LoadSocialNationsData()
        Try
            Dim query As String = "SELECT NationID, SocialID, ReportMonth, ReportYear, African, Asian, HispanicLatino as 'Hispanic/Latino', Indigenous, MiddleEastern as 'Middle Eastern', PacificIslander as 'Pacific Islander', European, OtherEthnicity as 'Other', OtherEthnicitySpecify as 'Other Specify' FROM tbl_ESG_Nations WHERE 1=1"

            If nationsFilterYear.HasValue Then
                query &= " AND ReportYear = " & nationsFilterYear.Value
            End If
            If nationsFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & nationsFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialNations.DataSource = dt
            dgvSocialNations.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading nations data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Religions Grid
    Private Sub LoadSocialReligionsData()
        Try
            Dim query As String = "SELECT ReligionID, SocialID, ReportMonth, ReportYear, Christianity, Islam, Hinduism, Buddhism, Judaism, Sikhism, OtherReligion as 'Other', OtherReligionSpecify as 'Other Specify', NoReligion as 'No Religion' FROM tbl_ESG_Religions WHERE 1=1"

            If religionsFilterYear.HasValue Then
                query &= " AND ReportYear = " & religionsFilterYear.Value
            End If
            If religionsFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & religionsFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialReligions.DataSource = dt
            dgvSocialReligions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading religions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Languages Grid
    Private Sub LoadSocialLanguagesData()
        Try
            Dim query As String = "SELECT LanguageID, SocialID, ReportMonth, ReportYear, Sinhala, Hebrew, French, Hindi FROM tbl_ESG_Languages WHERE 1=1"

            If languagesFilterYear.HasValue Then
                query &= " AND ReportYear = " & languagesFilterYear.Value
            End If
            If languagesFilterMonth.HasValue Then
                query &= " AND ReportMonth = " & languagesFilterMonth.Value
            End If

            query &= " ORDER BY ReportYear DESC, ReportMonth DESC"

            Dim dt As DataTable = DatabaseHelper.GetDataTable(query, Nothing)
            dgvSocialLanguages.DataSource = dt
            dgvSocialLanguages.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MessageBox.Show("Error loading languages data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ==================== BASIC INFO TAB ====================

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

    Private Sub dgvSocialBasic_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialBasic.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialBasic.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("SocialID").Value)
            currentEditTable = "Basic"
            LoadBasicDataForEditing(currentEditRecordID)
            EnterBasicEditMode()
        End If
    End Sub

    Private Sub LoadBasicDataForEditing(socialID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Social_Data WHERE SocialID = @SocialID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SocialID", socialID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpSocial.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudMale.Value = Convert.ToInt32(reader("MaleCount"))
                    nudFemale.Value = Convert.ToInt32(reader("FemaleCount"))

                    ' Load age categories
                    ageCategories.Clear()
                    If Convert.ToInt32(reader("AgeUnder18")) > 0 Then
                        ageCategories.Add("17 years old or less", Convert.ToInt32(reader("AgeUnder18")))
                    End If
                    If Convert.ToInt32(reader("Age18To30")) > 0 Then
                        ageCategories.Add("Between 18 and 30 years old", Convert.ToInt32(reader("Age18To30")))
                    End If
                    If Convert.ToInt32(reader("Age31To50")) > 0 Then
                        ageCategories.Add("Between 31 and 50 years old", Convert.ToInt32(reader("Age31To50")))
                    End If
                    If Convert.ToInt32(reader("AgeOver50")) > 0 Then
                        ageCategories.Add("50 years old or above", Convert.ToInt32(reader("AgeOver50")))
                    End If
                    LoadAgeCategoriesList()
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data for editing: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterBasicEditMode()
        currentEditMode = True
        btnSaveBasic.Visible = False
        btnUpdateBasic.Visible = True
        btnCancelBasic.Visible = True
    End Sub

    Private Sub ExitBasicEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        currentEditTable = ""
        btnSaveBasic.Visible = True
        btnUpdateBasic.Visible = False
        btnCancelBasic.Visible = False
        ClearBasicControls()
    End Sub

    Private Sub btnSaveBasic_Click(sender As Object, e As EventArgs) Handles btnSaveBasic.Click
        SaveBasicData()
    End Sub

    Private Sub SaveBasicData()
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Social_Data (ReportMonth, ReportYear, MaleCount, FemaleCount, AgeUnder18, Age18To30, Age31To50, AgeOver50, CreatedDate) VALUES (@Month, @Year, @Male, @Female, @AgeUnder18, @Age18To30, @Age31To50, @AgeOver50, GETDATE()); SELECT SCOPE_IDENTITY();"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpSocial.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpSocial.Value.Year)
                    cmd.Parameters.AddWithValue("@Male", nudMale.Value)
                    cmd.Parameters.AddWithValue("@Female", nudFemale.Value)

                    Dim ageUnder18 As Integer = If(ageCategories.ContainsKey("17 years old or less"), ageCategories("17 years old or less"), 0)
                    Dim age18To30 As Integer = If(ageCategories.ContainsKey("Between 18 and 30 years old"), ageCategories("Between 18 and 30 years old"), 0)
                    Dim age31To50 As Integer = If(ageCategories.ContainsKey("Between 31 and 50 years old"), ageCategories("Between 31 and 50 years old"), 0)
                    Dim ageOver50 As Integer = If(ageCategories.ContainsKey("50 years old or above"), ageCategories("50 years old or above"), 0)

                    cmd.Parameters.AddWithValue("@AgeUnder18", ageUnder18)
                    cmd.Parameters.AddWithValue("@Age18To30", age18To30)
                    cmd.Parameters.AddWithValue("@Age31To50", age31To50)
                    cmd.Parameters.AddWithValue("@AgeOver50", ageOver50)

                    conn.Open()
                    currentSocialID = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            MessageBox.Show("Basic Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialBasicData()
            ClearBasicControls()
        Catch ex As Exception
            MessageBox.Show("Error saving basic data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateBasic_Click(sender As Object, e As EventArgs) Handles btnUpdateBasic.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, MaleCount = @Male, FemaleCount = @Female, AgeUnder18 = @AgeUnder18, Age18To30 = @Age18To30, Age31To50 = @Age31To50, AgeOver50 = @AgeOver50, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpSocial.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpSocial.Value.Year)
                    cmd.Parameters.AddWithValue("@Male", nudMale.Value)
                    cmd.Parameters.AddWithValue("@Female", nudFemale.Value)

                    Dim ageUnder18 As Integer = If(ageCategories.ContainsKey("17 years old or less"), ageCategories("17 years old or less"), 0)
                    Dim age18To30 As Integer = If(ageCategories.ContainsKey("Between 18 and 30 years old"), ageCategories("Between 18 and 30 years old"), 0)
                    Dim age31To50 As Integer = If(ageCategories.ContainsKey("Between 31 and 50 years old"), ageCategories("Between 31 and 50 years old"), 0)
                    Dim ageOver50 As Integer = If(ageCategories.ContainsKey("50 years old or above"), ageCategories("50 years old or above"), 0)

                    cmd.Parameters.AddWithValue("@AgeUnder18", ageUnder18)
                    cmd.Parameters.AddWithValue("@Age18To30", age18To30)
                    cmd.Parameters.AddWithValue("@Age31To50", age31To50)
                    cmd.Parameters.AddWithValue("@AgeOver50", ageOver50)
                    cmd.Parameters.AddWithValue("@SocialID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Basic Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialBasicData()
            ExitBasicEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating basic data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelBasic_Click(sender As Object, e As EventArgs) Handles btnCancelBasic.Click
        ExitBasicEditMode()
        ClearBasicControls()
    End Sub

    Private Sub ClearBasicControls()
        nudMale.Value = 0
        nudFemale.Value = 0
        ageCategories.Clear()
        LoadAgeCategoriesList()
        dtpSocial.Value = DateTime.Now
    End Sub

    Private Sub btnApplySocialFilter_Click(sender As Object, e As EventArgs) Handles btnApplySocialFilter.Click
        socialFilterYear = dtpSocialFilterYear.Value.Year
        socialFilterMonth = dtpSocialFilterMonth.Value.Month
        LoadSocialBasicData()
    End Sub

    Private Sub btnClearSocialFilter_Click(sender As Object, e As EventArgs) Handles btnClearSocialFilter.Click
        socialFilterYear = Nothing
        socialFilterMonth = Nothing
        dtpSocialFilterYear.Value = DateTime.Now
        dtpSocialFilterMonth.Value = DateTime.Now
        LoadSocialBasicData()
    End Sub

    ' ==================== SKILLS TAB ====================

    Private Sub dgvSocialSkills_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialSkills.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialSkills.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("SocialID").Value)
            currentEditTable = "Skills"
            LoadSkillsDataForEditing(currentEditRecordID)
            EnterSkillsEditMode()
        End If
    End Sub

    Private Sub LoadSkillsDataForEditing(socialID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Social_Data WHERE SocialID = @SocialID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SocialID", socialID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpSkills.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudLearntAtNIRU.Value = Convert.ToInt32(reader("LearntSkillsAtNIRU"))
                    nudHiredQualified.Value = Convert.ToInt32(reader("HiredQualified"))
                    nudNewToIndustry.Value = Convert.ToInt32(reader("NewToIndustry"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading skills data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterSkillsEditMode()
        currentEditMode = True
        btnSaveSkills.Visible = False
        btnUpdateSkills.Visible = True
        btnCancelSkills.Visible = True
    End Sub

    Private Sub ExitSkillsEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveSkills.Visible = True
        btnUpdateSkills.Visible = False
        btnCancelSkills.Visible = False
        ClearSkillsControls()
    End Sub

    Private Sub btnSaveSkills_Click(sender As Object, e As EventArgs) Handles btnSaveSkills.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, LearntSkillsAtNIRU = @Learnt, HiredQualified = @Qualified, NewToIndustry = @NewIndustry, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpSkills.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpSkills.Value.Year)
                    cmd.Parameters.AddWithValue("@Learnt", nudLearntAtNIRU.Value)
                    cmd.Parameters.AddWithValue("@Qualified", nudHiredQualified.Value)
                    cmd.Parameters.AddWithValue("@NewIndustry", nudNewToIndustry.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Skills Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialSkillsData()
            ClearSkillsControls()
        Catch ex As Exception
            MessageBox.Show("Error saving skills data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateSkills_Click(sender As Object, e As EventArgs) Handles btnUpdateSkills.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, LearntSkillsAtNIRU = @Learnt, HiredQualified = @Qualified, NewToIndustry = @NewIndustry, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpSkills.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpSkills.Value.Year)
                    cmd.Parameters.AddWithValue("@Learnt", nudLearntAtNIRU.Value)
                    cmd.Parameters.AddWithValue("@Qualified", nudHiredQualified.Value)
                    cmd.Parameters.AddWithValue("@NewIndustry", nudNewToIndustry.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Skills Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialSkillsData()
            ExitSkillsEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating skills data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelSkills_Click(sender As Object, e As EventArgs) Handles btnCancelSkills.Click
        ExitSkillsEditMode()
        ClearSkillsControls()
    End Sub

    Private Sub ClearSkillsControls()
        nudLearntAtNIRU.Value = 0
        nudHiredQualified.Value = 0
        nudNewToIndustry.Value = 0
        dtpSkills.Value = DateTime.Now
    End Sub

    Private Sub btnApplySkillsFilter_Click(sender As Object, e As EventArgs) Handles btnApplySkillsFilter.Click
        skillsFilterYear = dtpSkillsFilterYear.Value.Year
        skillsFilterMonth = dtpSkillsFilterMonth.Value.Month
        LoadSocialSkillsData()
    End Sub

    Private Sub btnClearSkillsFilter_Click(sender As Object, e As EventArgs) Handles btnClearSkillsFilter.Click
        skillsFilterYear = Nothing
        skillsFilterMonth = Nothing
        dtpSkillsFilterYear.Value = DateTime.Now
        dtpSkillsFilterMonth.Value = DateTime.Now
        LoadSocialSkillsData()
    End Sub

    ' ==================== PROMOTIONS TAB ====================

    Private Sub dgvSocialPromotions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialPromotions.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialPromotions.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("SocialID").Value)
            currentEditTable = "Promotions"
            LoadPromotionsDataForEditing(currentEditRecordID)
            EnterPromotionsEditMode()
        End If
    End Sub

    Private Sub LoadPromotionsDataForEditing(socialID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Social_Data WHERE SocialID = @SocialID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SocialID", socialID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpPromotions.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudPromotions.Value = Convert.ToInt32(reader("Promotions"))
                    nudInternalMobility.Value = Convert.ToInt32(reader("InternalMobility"))
                    nudSameFamily.Value = Convert.ToInt32(reader("SameFamilyCount"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading promotions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterPromotionsEditMode()
        currentEditMode = True
        btnSavePromotions.Visible = False
        btnUpdatePromotions.Visible = True
        btnCancelPromotions.Visible = True
    End Sub

    Private Sub ExitPromotionsEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSavePromotions.Visible = True
        btnUpdatePromotions.Visible = False
        btnCancelPromotions.Visible = False
        ClearPromotionsControls()
    End Sub

    Private Sub btnSavePromotions_Click(sender As Object, e As EventArgs) Handles btnSavePromotions.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, Promotions = @Promotions, InternalMobility = @Mobility, SameFamilyCount = @Family, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpPromotions.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpPromotions.Value.Year)
                    cmd.Parameters.AddWithValue("@Promotions", nudPromotions.Value)
                    cmd.Parameters.AddWithValue("@Mobility", nudInternalMobility.Value)
                    cmd.Parameters.AddWithValue("@Family", nudSameFamily.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Promotions Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialPromotionsData()
            ClearPromotionsControls()
        Catch ex As Exception
            MessageBox.Show("Error saving promotions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdatePromotions_Click(sender As Object, e As EventArgs) Handles btnUpdatePromotions.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, Promotions = @Promotions, InternalMobility = @Mobility, SameFamilyCount = @Family, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpPromotions.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpPromotions.Value.Year)
                    cmd.Parameters.AddWithValue("@Promotions", nudPromotions.Value)
                    cmd.Parameters.AddWithValue("@Mobility", nudInternalMobility.Value)
                    cmd.Parameters.AddWithValue("@Family", nudSameFamily.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Promotions Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialPromotionsData()
            ExitPromotionsEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating promotions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelPromotions_Click(sender As Object, e As EventArgs) Handles btnCancelPromotions.Click
        ExitPromotionsEditMode()
        ClearPromotionsControls()
    End Sub

    Private Sub ClearPromotionsControls()
        nudPromotions.Value = 0
        nudInternalMobility.Value = 0
        nudSameFamily.Value = 0
        dtpPromotions.Value = DateTime.Now
    End Sub

    Private Sub btnApplyPromotionsFilter_Click(sender As Object, e As EventArgs) Handles btnApplyPromotionsFilter.Click
        promotionsFilterYear = dtpPromotionsFilterYear.Value.Year
        promotionsFilterMonth = dtpPromotionsFilterMonth.Value.Month
        LoadSocialPromotionsData()
    End Sub

    Private Sub btnClearPromotionsFilter_Click(sender As Object, e As EventArgs) Handles btnClearPromotionsFilter.Click
        promotionsFilterYear = Nothing
        promotionsFilterMonth = Nothing
        dtpPromotionsFilterYear.Value = DateTime.Now
        dtpPromotionsFilterMonth.Value = DateTime.Now
        LoadSocialPromotionsData()
    End Sub

    ' ==================== MANAGEMENT TAB ====================

    Private Sub dgvSocialManagement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialManagement.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialManagement.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("SocialID").Value)
            currentEditTable = "Management"
            LoadManagementDataForEditing(currentEditRecordID)
            EnterManagementEditMode()
        End If
    End Sub

    Private Sub LoadManagementDataForEditing(socialID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Social_Data WHERE SocialID = @SocialID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@SocialID", socialID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpManagement.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudWomenFirstLine.Value = Convert.ToInt32(reader("WomenFirstLineMgmt"))
                    nudMenFirstLine.Value = Convert.ToInt32(reader("MenFirstLineMgmt"))
                    nudWomenMiddle.Value = Convert.ToInt32(reader("WomenMiddleMgmt"))
                    nudMenMiddle.Value = Convert.ToInt32(reader("MenMiddleMgmt"))
                    nudWomenUpper.Value = Convert.ToInt32(reader("WomenUpperMgmt"))
                    nudMenUpper.Value = Convert.ToInt32(reader("MenUpperMgmt"))
                    nudWomenLeadership.Value = Convert.ToInt32(reader("WomenLeadershipTeam"))
                    nudMenLeadership.Value = Convert.ToInt32(reader("MenLeadershipTeam"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading management data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterManagementEditMode()
        currentEditMode = True
        btnSaveManagement.Visible = False
        btnUpdateManagement.Visible = True
        btnCancelManagement.Visible = True
    End Sub

    Private Sub ExitManagementEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveManagement.Visible = True
        btnUpdateManagement.Visible = False
        btnCancelManagement.Visible = False
        ClearManagementControls()
    End Sub

    Private Sub btnSaveManagement_Click(sender As Object, e As EventArgs) Handles btnSaveManagement.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, WomenFirstLineMgmt = @WFirst, MenFirstLineMgmt = @MFirst, WomenMiddleMgmt = @WMiddle, MenMiddleMgmt = @MMiddle, WomenUpperMgmt = @WUpper, MenUpperMgmt = @MUpper, WomenLeadershipTeam = @WLeadership, MenLeadershipTeam = @MLeadership, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpManagement.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpManagement.Value.Year)
                    cmd.Parameters.AddWithValue("@WFirst", nudWomenFirstLine.Value)
                    cmd.Parameters.AddWithValue("@MFirst", nudMenFirstLine.Value)
                    cmd.Parameters.AddWithValue("@WMiddle", nudWomenMiddle.Value)
                    cmd.Parameters.AddWithValue("@MMiddle", nudMenMiddle.Value)
                    cmd.Parameters.AddWithValue("@WUpper", nudWomenUpper.Value)
                    cmd.Parameters.AddWithValue("@MUpper", nudMenUpper.Value)
                    cmd.Parameters.AddWithValue("@WLeadership", nudWomenLeadership.Value)
                    cmd.Parameters.AddWithValue("@MLeadership", nudMenLeadership.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Management Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialManagementData()
            ClearManagementControls()
        Catch ex As Exception
            MessageBox.Show("Error saving management data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateManagement_Click(sender As Object, e As EventArgs) Handles btnUpdateManagement.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Social_Data SET ReportMonth = @Month, ReportYear = @Year, WomenFirstLineMgmt = @WFirst, MenFirstLineMgmt = @MFirst, WomenMiddleMgmt = @WMiddle, MenMiddleMgmt = @MMiddle, WomenUpperMgmt = @WUpper, MenUpperMgmt = @MUpper, WomenLeadershipTeam = @WLeadership, MenLeadershipTeam = @MLeadership, ModifiedDate = GETDATE() WHERE SocialID = @SocialID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpManagement.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpManagement.Value.Year)
                    cmd.Parameters.AddWithValue("@WFirst", nudWomenFirstLine.Value)
                    cmd.Parameters.AddWithValue("@MFirst", nudMenFirstLine.Value)
                    cmd.Parameters.AddWithValue("@WMiddle", nudWomenMiddle.Value)
                    cmd.Parameters.AddWithValue("@MMiddle", nudMenMiddle.Value)
                    cmd.Parameters.AddWithValue("@WUpper", nudWomenUpper.Value)
                    cmd.Parameters.AddWithValue("@MUpper", nudMenUpper.Value)
                    cmd.Parameters.AddWithValue("@WLeadership", nudWomenLeadership.Value)
                    cmd.Parameters.AddWithValue("@MLeadership", nudMenLeadership.Value)
                    cmd.Parameters.AddWithValue("@SocialID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Management Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialManagementData()
            ExitManagementEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating management data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelManagement_Click(sender As Object, e As EventArgs) Handles btnCancelManagement.Click
        ExitManagementEditMode()
        ClearManagementControls()
    End Sub

    Private Sub ClearManagementControls()
        nudWomenFirstLine.Value = 0
        nudMenFirstLine.Value = 0
        nudWomenMiddle.Value = 0
        nudMenMiddle.Value = 0
        nudWomenUpper.Value = 0
        nudMenUpper.Value = 0
        nudWomenLeadership.Value = 0
        nudMenLeadership.Value = 0
        dtpManagement.Value = DateTime.Now
    End Sub

    Private Sub btnApplyManagementFilter_Click(sender As Object, e As EventArgs) Handles btnApplyManagementFilter.Click
        managementFilterYear = dtpManagementFilterYear.Value.Year
        managementFilterMonth = dtpManagementFilterMonth.Value.Month
        LoadSocialManagementData()
    End Sub

    Private Sub btnClearManagementFilter_Click(sender As Object, e As EventArgs) Handles btnClearManagementFilter.Click
        managementFilterYear = Nothing
        managementFilterMonth = Nothing
        dtpManagementFilterYear.Value = DateTime.Now
        dtpManagementFilterMonth.Value = DateTime.Now
        LoadSocialManagementData()
    End Sub

    ' ==================== DISABILITIES TAB ====================

    Private Sub dgvSocialDisabilities_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialDisabilities.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialDisabilities.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("DisabilityID").Value)
            currentEditTable = "Disabilities"
            LoadDisabilitiesDataForEditing(currentEditRecordID)
            EnterDisabilitiesEditMode()
        End If
    End Sub

    Private Sub LoadDisabilitiesDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Disabilities WHERE DisabilityID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpDisabilities.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudPhysical.Value = Convert.ToInt32(reader("PhysicalDisabilities"))
                    nudSensory.Value = Convert.ToInt32(reader("SensoryDisabilities"))
                    nudMentalHealth.Value = Convert.ToInt32(reader("MentalHealthConditions"))
                    nudIntellectual.Value = Convert.ToInt32(reader("IntellectualDisabilities"))
                    nudChronic.Value = Convert.ToInt32(reader("ChronicHealthConditions"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading disabilities data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterDisabilitiesEditMode()
        currentEditMode = True
        btnSaveDisabilities.Visible = False
        btnUpdateDisabilities.Visible = True
        btnCancelDisabilities.Visible = True
    End Sub

    Private Sub ExitDisabilitiesEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveDisabilities.Visible = True
        btnUpdateDisabilities.Visible = False
        btnCancelDisabilities.Visible = False
        ClearDisabilitiesControls()
    End Sub

    Private Sub btnSaveDisabilities_Click(sender As Object, e As EventArgs) Handles btnSaveDisabilities.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Disabilities (SocialID, ReportMonth, ReportYear, PhysicalDisabilities, SensoryDisabilities, MentalHealthConditions, IntellectualDisabilities, ChronicHealthConditions, CreatedDate) VALUES (@SocialID, @Month, @Year, @Physical, @Sensory, @Mental, @Intellectual, @Chronic, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpDisabilities.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpDisabilities.Value.Year)
                    cmd.Parameters.AddWithValue("@Physical", nudPhysical.Value)
                    cmd.Parameters.AddWithValue("@Sensory", nudSensory.Value)
                    cmd.Parameters.AddWithValue("@Mental", nudMentalHealth.Value)
                    cmd.Parameters.AddWithValue("@Intellectual", nudIntellectual.Value)
                    cmd.Parameters.AddWithValue("@Chronic", nudChronic.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Disabilities Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialDisabilitiesData()
            ClearDisabilitiesControls()
        Catch ex As Exception
            MessageBox.Show("Error saving disabilities data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateDisabilities_Click(sender As Object, e As EventArgs) Handles btnUpdateDisabilities.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Disabilities SET ReportMonth = @Month, ReportYear = @Year, PhysicalDisabilities = @Physical, SensoryDisabilities = @Sensory, MentalHealthConditions = @Mental, IntellectualDisabilities = @Intellectual, ChronicHealthConditions = @Chronic, ModifiedDate = GETDATE() WHERE DisabilityID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpDisabilities.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpDisabilities.Value.Year)
                    cmd.Parameters.AddWithValue("@Physical", nudPhysical.Value)
                    cmd.Parameters.AddWithValue("@Sensory", nudSensory.Value)
                    cmd.Parameters.AddWithValue("@Mental", nudMentalHealth.Value)
                    cmd.Parameters.AddWithValue("@Intellectual", nudIntellectual.Value)
                    cmd.Parameters.AddWithValue("@Chronic", nudChronic.Value)
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Disabilities Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialDisabilitiesData()
            ExitDisabilitiesEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating disabilities data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelDisabilities_Click(sender As Object, e As EventArgs) Handles btnCancelDisabilities.Click
        ExitDisabilitiesEditMode()
        ClearDisabilitiesControls()
    End Sub

    Private Sub ClearDisabilitiesControls()
        nudPhysical.Value = 0
        nudSensory.Value = 0
        nudMentalHealth.Value = 0
        nudIntellectual.Value = 0
        nudChronic.Value = 0
        dtpDisabilities.Value = DateTime.Now
    End Sub

    Private Sub btnApplyDisabilitiesFilter_Click(sender As Object, e As EventArgs) Handles btnApplyDisabilitiesFilter.Click
        disabilitiesFilterYear = dtpDisabilitiesFilterYear.Value.Year
        disabilitiesFilterMonth = dtpDisabilitiesFilterMonth.Value.Month
        LoadSocialDisabilitiesData()
    End Sub

    Private Sub btnClearDisabilitiesFilter_Click(sender As Object, e As EventArgs) Handles btnClearDisabilitiesFilter.Click
        disabilitiesFilterYear = Nothing
        disabilitiesFilterMonth = Nothing
        dtpDisabilitiesFilterYear.Value = DateTime.Now
        dtpDisabilitiesFilterMonth.Value = DateTime.Now
        LoadSocialDisabilitiesData()
    End Sub

    ' ==================== BEHAVIOR TAB ====================

    Private Sub dgvSocialBehavior_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialBehavior.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialBehavior.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("BehaviorID").Value)
            currentEditTable = "Behavior"
            LoadBehaviorDataForEditing(currentEditRecordID)
            EnterBehaviorEditMode()
        End If
    End Sub

    Private Sub LoadBehaviorDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Behavior WHERE BehaviorID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpBehavior.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudLesbian.Value = Convert.ToInt32(reader("Lesbian"))
                    nudGay.Value = Convert.ToInt32(reader("Gay"))
                    nudBisexual.Value = Convert.ToInt32(reader("Bisexual"))
                    nudAsexual.Value = Convert.ToInt32(reader("Asexual"))
                    nudPansexual.Value = Convert.ToInt32(reader("Pansexual"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading behavior data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterBehaviorEditMode()
        currentEditMode = True
        btnSaveBehavior.Visible = False
        btnUpdateBehavior.Visible = True
        btnCancelBehavior.Visible = True
    End Sub

    Private Sub ExitBehaviorEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveBehavior.Visible = True
        btnUpdateBehavior.Visible = False
        btnCancelBehavior.Visible = False
        ClearBehaviorControls()
    End Sub

    Private Sub btnSaveBehavior_Click(sender As Object, e As EventArgs) Handles btnSaveBehavior.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Behavior (SocialID, ReportMonth, ReportYear, Lesbian, Gay, Bisexual, Asexual, Pansexual, CreatedDate) VALUES (@SocialID, @Month, @Year, @Lesbian, @Gay, @Bisexual, @Asexual, @Pansexual, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpBehavior.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpBehavior.Value.Year)
                    cmd.Parameters.AddWithValue("@Lesbian", nudLesbian.Value)
                    cmd.Parameters.AddWithValue("@Gay", nudGay.Value)
                    cmd.Parameters.AddWithValue("@Bisexual", nudBisexual.Value)
                    cmd.Parameters.AddWithValue("@Asexual", nudAsexual.Value)
                    cmd.Parameters.AddWithValue("@Pansexual", nudPansexual.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Behavior Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialBehaviorData()
            ClearBehaviorControls()
        Catch ex As Exception
            MessageBox.Show("Error saving behavior data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateBehavior_Click(sender As Object, e As EventArgs) Handles btnUpdateBehavior.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Behavior SET ReportMonth = @Month, ReportYear = @Year, Lesbian = @Lesbian, Gay = @Gay, Bisexual = @Bisexual, Asexual = @Asexual, Pansexual = @Pansexual, ModifiedDate = GETDATE() WHERE BehaviorID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpBehavior.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpBehavior.Value.Year)
                    cmd.Parameters.AddWithValue("@Lesbian", nudLesbian.Value)
                    cmd.Parameters.AddWithValue("@Gay", nudGay.Value)
                    cmd.Parameters.AddWithValue("@Bisexual", nudBisexual.Value)
                    cmd.Parameters.AddWithValue("@Asexual", nudAsexual.Value)
                    cmd.Parameters.AddWithValue("@Pansexual", nudPansexual.Value)
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Behavior Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialBehaviorData()
            ExitBehaviorEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating behavior data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelBehavior_Click(sender As Object, e As EventArgs) Handles btnCancelBehavior.Click
        ExitBehaviorEditMode()
        ClearBehaviorControls()
    End Sub

    Private Sub ClearBehaviorControls()
        nudLesbian.Value = 0
        nudGay.Value = 0
        nudBisexual.Value = 0
        nudAsexual.Value = 0
        nudPansexual.Value = 0
        dtpBehavior.Value = DateTime.Now
    End Sub

    Private Sub btnApplyBehaviorFilter_Click(sender As Object, e As EventArgs) Handles btnApplyBehaviorFilter.Click
        behaviorFilterYear = dtpBehaviorFilterYear.Value.Year
        behaviorFilterMonth = dtpBehaviorFilterMonth.Value.Month
        LoadSocialBehaviorData()
    End Sub

    Private Sub btnClearBehaviorFilter_Click(sender As Object, e As EventArgs) Handles btnClearBehaviorFilter.Click
        behaviorFilterYear = Nothing
        behaviorFilterMonth = Nothing
        dtpBehaviorFilterYear.Value = DateTime.Now
        dtpBehaviorFilterMonth.Value = DateTime.Now
        LoadSocialBehaviorData()
    End Sub

    ' ==================== IDENTIFICATION TAB ====================

    Private Sub dgvSocialIdentification_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialIdentification.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialIdentification.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("IdentificationID").Value)
            currentEditTable = "Identification"
            LoadIdentificationDataForEditing(currentEditRecordID)
            EnterIdentificationEditMode()
        End If
    End Sub

    Private Sub LoadIdentificationDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Identification WHERE IdentificationID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpIdentification.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudTransgender.Value = Convert.ToInt32(reader("Transgender"))
                    nudQueer.Value = Convert.ToInt32(reader("Queer"))
                    nudQuestioning.Value = Convert.ToInt32(reader("Questioning"))
                    nudNonBinary.Value = Convert.ToInt32(reader("NonBinary"))
                    nudAgender.Value = Convert.ToInt32(reader("Agender"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading identification data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterIdentificationEditMode()
        currentEditMode = True
        btnSaveIdentification.Visible = False
        btnUpdateIdentification.Visible = True
        btnCancelIdentification.Visible = True
    End Sub

    Private Sub ExitIdentificationEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveIdentification.Visible = True
        btnUpdateIdentification.Visible = False
        btnCancelIdentification.Visible = False
        ClearIdentificationControls()
    End Sub

    Private Sub btnSaveIdentification_Click(sender As Object, e As EventArgs) Handles btnSaveIdentification.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Identification (SocialID, ReportMonth, ReportYear, Transgender, Queer, Questioning, NonBinary, Agender, CreatedDate) VALUES (@SocialID, @Month, @Year, @Transgender, @Queer, @Questioning, @NonBinary, @Agender, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpIdentification.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpIdentification.Value.Year)
                    cmd.Parameters.AddWithValue("@Transgender", nudTransgender.Value)
                    cmd.Parameters.AddWithValue("@Queer", nudQueer.Value)
                    cmd.Parameters.AddWithValue("@Questioning", nudQuestioning.Value)
                    cmd.Parameters.AddWithValue("@NonBinary", nudNonBinary.Value)
                    cmd.Parameters.AddWithValue("@Agender", nudAgender.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Identification Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialIdentificationData()
            ClearIdentificationControls()
        Catch ex As Exception
            MessageBox.Show("Error saving identification data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateIdentification_Click(sender As Object, e As EventArgs) Handles btnUpdateIdentification.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Identification SET ReportMonth = @Month, ReportYear = @Year, Transgender = @Transgender, Queer = @Queer, Questioning = @Questioning, NonBinary = @NonBinary, Agender = @Agender, ModifiedDate = GETDATE() WHERE IdentificationID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpIdentification.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpIdentification.Value.Year)
                    cmd.Parameters.AddWithValue("@Transgender", nudTransgender.Value)
                    cmd.Parameters.AddWithValue("@Queer", nudQueer.Value)
                    cmd.Parameters.AddWithValue("@Questioning", nudQuestioning.Value)
                    cmd.Parameters.AddWithValue("@NonBinary", nudNonBinary.Value)
                    cmd.Parameters.AddWithValue("@Agender", nudAgender.Value)
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Identification Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialIdentificationData()
            ExitIdentificationEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating identification data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelIdentification_Click(sender As Object, e As EventArgs) Handles btnCancelIdentification.Click
        ExitIdentificationEditMode()
        ClearIdentificationControls()
    End Sub

    Private Sub ClearIdentificationControls()
        nudTransgender.Value = 0
        nudQueer.Value = 0
        nudQuestioning.Value = 0
        nudNonBinary.Value = 0
        nudAgender.Value = 0
        dtpIdentification.Value = DateTime.Now
    End Sub

    Private Sub btnApplyIdentificationFilter_Click(sender As Object, e As EventArgs) Handles btnApplyIdentificationFilter.Click
        identificationFilterYear = dtpIdentificationFilterYear.Value.Year
        identificationFilterMonth = dtpIdentificationFilterMonth.Value.Month
        LoadSocialIdentificationData()
    End Sub

    Private Sub btnClearIdentificationFilter_Click(sender As Object, e As EventArgs) Handles btnClearIdentificationFilter.Click
        identificationFilterYear = Nothing
        identificationFilterMonth = Nothing
        dtpIdentificationFilterYear.Value = DateTime.Now
        dtpIdentificationFilterMonth.Value = DateTime.Now
        LoadSocialIdentificationData()
    End Sub

    ' ==================== NATIONS TAB ====================

    Private Sub dgvSocialNations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialNations.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialNations.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("NationID").Value)
            currentEditTable = "Nations"
            LoadNationsDataForEditing(currentEditRecordID)
            EnterNationsEditMode()
        End If
    End Sub

    Private Sub LoadNationsDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Nations WHERE NationID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpNations.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudAfrican.Value = Convert.ToInt32(reader("African"))
                    nudAsian.Value = Convert.ToInt32(reader("Asian"))
                    nudHispanic.Value = Convert.ToInt32(reader("HispanicLatino"))
                    nudIndigenous.Value = Convert.ToInt32(reader("Indigenous"))
                    nudMiddleEastern.Value = Convert.ToInt32(reader("MiddleEastern"))
                    nudPacificIslander.Value = Convert.ToInt32(reader("PacificIslander"))
                    nudEuropean.Value = Convert.ToInt32(reader("European"))
                    nudOtherEthnicity.Value = Convert.ToInt32(reader("OtherEthnicity"))
                    txtOtherEthnicitySpecify.Text = If(IsDBNull(reader("OtherEthnicitySpecify")), "", reader("OtherEthnicitySpecify").ToString())
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading nations data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterNationsEditMode()
        currentEditMode = True
        btnSaveNations.Visible = False
        btnUpdateNations.Visible = True
        btnCancelNations.Visible = True
    End Sub

    Private Sub ExitNationsEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveNations.Visible = True
        btnUpdateNations.Visible = False
        btnCancelNations.Visible = False
        ClearNationsControls()
    End Sub

    Private Sub btnSaveNations_Click(sender As Object, e As EventArgs) Handles btnSaveNations.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Nations (SocialID, ReportMonth, ReportYear, African, Asian, HispanicLatino, Indigenous, MiddleEastern, PacificIslander, European, OtherEthnicity, OtherEthnicitySpecify, CreatedDate) VALUES (@SocialID, @Month, @Year, @African, @Asian, @Hispanic, @Indigenous, @MiddleEastern, @PacificIslander, @European, @OtherEthnicity, @OtherSpecify, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpNations.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpNations.Value.Year)
                    cmd.Parameters.AddWithValue("@African", nudAfrican.Value)
                    cmd.Parameters.AddWithValue("@Asian", nudAsian.Value)
                    cmd.Parameters.AddWithValue("@Hispanic", nudHispanic.Value)
                    cmd.Parameters.AddWithValue("@Indigenous", nudIndigenous.Value)
                    cmd.Parameters.AddWithValue("@MiddleEastern", nudMiddleEastern.Value)
                    cmd.Parameters.AddWithValue("@PacificIslander", nudPacificIslander.Value)
                    cmd.Parameters.AddWithValue("@European", nudEuropean.Value)
                    cmd.Parameters.AddWithValue("@OtherEthnicity", nudOtherEthnicity.Value)
                    cmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherEthnicitySpecify.Text), DBNull.Value, txtOtherEthnicitySpecify.Text))

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Nations Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialNationsData()
            ClearNationsControls()
        Catch ex As Exception
            MessageBox.Show("Error saving nations data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateNations_Click(sender As Object, e As EventArgs) Handles btnUpdateNations.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Nations SET ReportMonth = @Month, ReportYear = @Year, African = @African, Asian = @Asian, HispanicLatino = @Hispanic, Indigenous = @Indigenous, MiddleEastern = @MiddleEastern, PacificIslander = @PacificIslander, European = @European, OtherEthnicity = @OtherEthnicity, OtherEthnicitySpecify = @OtherSpecify, ModifiedDate = GETDATE() WHERE NationID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpNations.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpNations.Value.Year)
                    cmd.Parameters.AddWithValue("@African", nudAfrican.Value)
                    cmd.Parameters.AddWithValue("@Asian", nudAsian.Value)
                    cmd.Parameters.AddWithValue("@Hispanic", nudHispanic.Value)
                    cmd.Parameters.AddWithValue("@Indigenous", nudIndigenous.Value)
                    cmd.Parameters.AddWithValue("@MiddleEastern", nudMiddleEastern.Value)
                    cmd.Parameters.AddWithValue("@PacificIslander", nudPacificIslander.Value)
                    cmd.Parameters.AddWithValue("@European", nudEuropean.Value)
                    cmd.Parameters.AddWithValue("@OtherEthnicity", nudOtherEthnicity.Value)
                    cmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherEthnicitySpecify.Text), DBNull.Value, txtOtherEthnicitySpecify.Text))
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Nations Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialNationsData()
            ExitNationsEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating nations data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelNations_Click(sender As Object, e As EventArgs) Handles btnCancelNations.Click
        ExitNationsEditMode()
        ClearNationsControls()
    End Sub

    Private Sub ClearNationsControls()
        nudAfrican.Value = 0
        nudAsian.Value = 0
        nudHispanic.Value = 0
        nudIndigenous.Value = 0
        nudMiddleEastern.Value = 0
        nudPacificIslander.Value = 0
        nudEuropean.Value = 0
        nudOtherEthnicity.Value = 0
        txtOtherEthnicitySpecify.Clear()
        dtpNations.Value = DateTime.Now
    End Sub

    Private Sub btnApplyNationsFilter_Click(sender As Object, e As EventArgs) Handles btnApplyNationsFilter.Click
        nationsFilterYear = dtpNationsFilterYear.Value.Year
        nationsFilterMonth = dtpNationsFilterMonth.Value.Month
        LoadSocialNationsData()
    End Sub

    Private Sub btnClearNationsFilter_Click(sender As Object, e As EventArgs) Handles btnClearNationsFilter.Click
        nationsFilterYear = Nothing
        nationsFilterMonth = Nothing
        dtpNationsFilterYear.Value = DateTime.Now
        dtpNationsFilterMonth.Value = DateTime.Now
        LoadSocialNationsData()
    End Sub

    ' ==================== RELIGIONS TAB ====================

    Private Sub dgvSocialReligions_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialReligions.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialReligions.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("ReligionID").Value)
            currentEditTable = "Religions"
            LoadReligionsDataForEditing(currentEditRecordID)
            EnterReligionsEditMode()
        End If
    End Sub

    Private Sub LoadReligionsDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Religions WHERE ReligionID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpReligions.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudChristianity.Value = Convert.ToInt32(reader("Christianity"))
                    nudIslam.Value = Convert.ToInt32(reader("Islam"))
                    nudHinduism.Value = Convert.ToInt32(reader("Hinduism"))
                    nudBuddhism.Value = Convert.ToInt32(reader("Buddhism"))
                    nudJudaism.Value = Convert.ToInt32(reader("Judaism"))
                    nudSikhism.Value = Convert.ToInt32(reader("Sikhism"))
                    nudOtherReligion.Value = Convert.ToInt32(reader("OtherReligion"))
                    txtOtherReligionSpecify.Text = If(IsDBNull(reader("OtherReligionSpecify")), "", reader("OtherReligionSpecify").ToString())
                    nudNoReligion.Value = Convert.ToInt32(reader("NoReligion"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading religions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterReligionsEditMode()
        currentEditMode = True
        btnSaveReligions.Visible = False
        btnUpdateReligions.Visible = True
        btnCancelReligions.Visible = True
    End Sub

    Private Sub ExitReligionsEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveReligions.Visible = True
        btnUpdateReligions.Visible = False
        btnCancelReligions.Visible = False
        ClearReligionsControls()
    End Sub

    Private Sub btnSaveReligions_Click(sender As Object, e As EventArgs) Handles btnSaveReligions.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Religions (SocialID, ReportMonth, ReportYear, Christianity, Islam, Hinduism, Buddhism, Judaism, Sikhism, OtherReligion, OtherReligionSpecify, NoReligion, CreatedDate) VALUES (@SocialID, @Month, @Year, @Christianity, @Islam, @Hinduism, @Buddhism, @Judaism, @Sikhism, @OtherReligion, @OtherSpecify, @NoReligion, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpReligions.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpReligions.Value.Year)
                    cmd.Parameters.AddWithValue("@Christianity", nudChristianity.Value)
                    cmd.Parameters.AddWithValue("@Islam", nudIslam.Value)
                    cmd.Parameters.AddWithValue("@Hinduism", nudHinduism.Value)
                    cmd.Parameters.AddWithValue("@Buddhism", nudBuddhism.Value)
                    cmd.Parameters.AddWithValue("@Judaism", nudJudaism.Value)
                    cmd.Parameters.AddWithValue("@Sikhism", nudSikhism.Value)
                    cmd.Parameters.AddWithValue("@OtherReligion", nudOtherReligion.Value)
                    cmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherReligionSpecify.Text), DBNull.Value, txtOtherReligionSpecify.Text))
                    cmd.Parameters.AddWithValue("@NoReligion", nudNoReligion.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Religions Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialReligionsData()
            ClearReligionsControls()
        Catch ex As Exception
            MessageBox.Show("Error saving religions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateReligions_Click(sender As Object, e As EventArgs) Handles btnUpdateReligions.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Religions SET ReportMonth = @Month, ReportYear = @Year, Christianity = @Christianity, Islam = @Islam, Hinduism = @Hinduism, Buddhism = @Buddhism, Judaism = @Judaism, Sikhism = @Sikhism, OtherReligion = @OtherReligion, OtherReligionSpecify = @OtherSpecify, NoReligion = @NoReligion, ModifiedDate = GETDATE() WHERE ReligionID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpReligions.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpReligions.Value.Year)
                    cmd.Parameters.AddWithValue("@Christianity", nudChristianity.Value)
                    cmd.Parameters.AddWithValue("@Islam", nudIslam.Value)
                    cmd.Parameters.AddWithValue("@Hinduism", nudHinduism.Value)
                    cmd.Parameters.AddWithValue("@Buddhism", nudBuddhism.Value)
                    cmd.Parameters.AddWithValue("@Judaism", nudJudaism.Value)
                    cmd.Parameters.AddWithValue("@Sikhism", nudSikhism.Value)
                    cmd.Parameters.AddWithValue("@OtherReligion", nudOtherReligion.Value)
                    cmd.Parameters.AddWithValue("@OtherSpecify", If(String.IsNullOrEmpty(txtOtherReligionSpecify.Text), DBNull.Value, txtOtherReligionSpecify.Text))
                    cmd.Parameters.AddWithValue("@NoReligion", nudNoReligion.Value)
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Religions Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialReligionsData()
            ExitReligionsEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating religions data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelReligions_Click(sender As Object, e As EventArgs) Handles btnCancelReligions.Click
        ExitReligionsEditMode()
        ClearReligionsControls()
    End Sub

    Private Sub ClearReligionsControls()
        nudChristianity.Value = 0
        nudIslam.Value = 0
        nudHinduism.Value = 0
        nudBuddhism.Value = 0
        nudJudaism.Value = 0
        nudSikhism.Value = 0
        nudOtherReligion.Value = 0
        txtOtherReligionSpecify.Clear()
        nudNoReligion.Value = 0
        dtpReligions.Value = DateTime.Now
    End Sub

    Private Sub btnApplyReligionsFilter_Click(sender As Object, e As EventArgs) Handles btnApplyReligionsFilter.Click
        religionsFilterYear = dtpReligionsFilterYear.Value.Year
        religionsFilterMonth = dtpReligionsFilterMonth.Value.Month
        LoadSocialReligionsData()
    End Sub

    Private Sub btnClearReligionsFilter_Click(sender As Object, e As EventArgs) Handles btnClearReligionsFilter.Click
        religionsFilterYear = Nothing
        religionsFilterMonth = Nothing
        dtpReligionsFilterYear.Value = DateTime.Now
        dtpReligionsFilterMonth.Value = DateTime.Now
        LoadSocialReligionsData()
    End Sub

    ' ==================== LANGUAGES TAB ====================

    Private Sub dgvSocialLanguages_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocialLanguages.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSocialLanguages.Rows(e.RowIndex)
            currentEditRecordID = Convert.ToInt32(row.Cells("LanguageID").Value)
            currentEditTable = "Languages"
            LoadLanguagesDataForEditing(currentEditRecordID)
            EnterLanguagesEditMode()
        End If
    End Sub

    Private Sub LoadLanguagesDataForEditing(recordID As Integer)
        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "SELECT * FROM tbl_ESG_Languages WHERE LanguageID = @RecordID"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    dtpLanguages.Value = New Date(reader("ReportYear"), reader("ReportMonth"), 1)
                    nudSinhala.Value = Convert.ToInt32(reader("Sinhala"))
                    nudHebrew.Value = Convert.ToInt32(reader("Hebrew"))
                    nudFrench.Value = Convert.ToInt32(reader("French"))
                    nudHindi.Value = Convert.ToInt32(reader("Hindi"))
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading languages data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnterLanguagesEditMode()
        currentEditMode = True
        btnSaveLanguages.Visible = False
        btnUpdateLanguages.Visible = True
        btnCancelLanguages.Visible = True
    End Sub

    Private Sub ExitLanguagesEditMode()
        currentEditMode = False
        currentEditRecordID = 0
        btnSaveLanguages.Visible = True
        btnUpdateLanguages.Visible = False
        btnCancelLanguages.Visible = False
        ClearLanguagesControls()
    End Sub

    Private Sub btnSaveLanguages_Click(sender As Object, e As EventArgs) Handles btnSaveLanguages.Click
        If currentSocialID = 0 Then
            MessageBox.Show("Please save Basic Information first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "INSERT INTO tbl_ESG_Languages (SocialID, ReportMonth, ReportYear, Sinhala, Hebrew, French, Hindi, CreatedDate) VALUES (@SocialID, @Month, @Year, @Sinhala, @Hebrew, @French, @Hindi, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@SocialID", currentSocialID)
                    cmd.Parameters.AddWithValue("@Month", dtpLanguages.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpLanguages.Value.Year)
                    cmd.Parameters.AddWithValue("@Sinhala", nudSinhala.Value)
                    cmd.Parameters.AddWithValue("@Hebrew", nudHebrew.Value)
                    cmd.Parameters.AddWithValue("@French", nudFrench.Value)
                    cmd.Parameters.AddWithValue("@Hindi", nudHindi.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Languages Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialLanguagesData()
            ClearLanguagesControls()
        Catch ex As Exception
            MessageBox.Show("Error saving languages data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateLanguages_Click(sender As Object, e As EventArgs) Handles btnUpdateLanguages.Click
        If currentEditRecordID = 0 Then
            MessageBox.Show("No record selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As SqlConnection = ModShared.GetConnection()
                Dim query As String = "UPDATE tbl_ESG_Languages SET ReportMonth = @Month, ReportYear = @Year, Sinhala = @Sinhala, Hebrew = @Hebrew, French = @French, Hindi = @Hindi, ModifiedDate = GETDATE() WHERE LanguageID = @RecordID"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Month", dtpLanguages.Value.Month)
                    cmd.Parameters.AddWithValue("@Year", dtpLanguages.Value.Year)
                    cmd.Parameters.AddWithValue("@Sinhala", nudSinhala.Value)
                    cmd.Parameters.AddWithValue("@Hebrew", nudHebrew.Value)
                    cmd.Parameters.AddWithValue("@French", nudFrench.Value)
                    cmd.Parameters.AddWithValue("@Hindi", nudHindi.Value)
                    cmd.Parameters.AddWithValue("@RecordID", currentEditRecordID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Languages Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSocialLanguagesData()
            ExitLanguagesEditMode()
        Catch ex As Exception
            MessageBox.Show("Error updating languages data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelLanguages_Click(sender As Object, e As EventArgs) Handles btnCancelLanguages.Click
        ExitLanguagesEditMode()
        ClearLanguagesControls()
    End Sub

    Private Sub ClearLanguagesControls()
        nudSinhala.Value = 0
        nudHebrew.Value = 0
        nudFrench.Value = 0
        nudHindi.Value = 0
        dtpLanguages.Value = DateTime.Now
    End Sub

    Private Sub btnApplyLanguagesFilter_Click(sender As Object, e As EventArgs) Handles btnApplyLanguagesFilter.Click
        languagesFilterYear = dtpLanguagesFilterYear.Value.Year
        languagesFilterMonth = dtpLanguagesFilterMonth.Value.Month
        LoadSocialLanguagesData()
    End Sub

    Private Sub btnClearLanguagesFilter_Click(sender As Object, e As EventArgs) Handles btnClearLanguagesFilter.Click
        languagesFilterYear = Nothing
        languagesFilterMonth = Nothing
        dtpLanguagesFilterYear.Value = DateTime.Now
        dtpLanguagesFilterMonth.Value = DateTime.Now
        LoadSocialLanguagesData()
    End Sub

    ' ==================== EXPORT ====================

    Private Sub btnExportSocial_Click(sender As Object, e As EventArgs) Handles btnExportSocial.Click
        If dgvSocialBasic.Rows.Count = 0 Then
            MessageBox.Show("No data to export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ModShared.ExportToExcel(dgvSocialBasic, "Social_Data_Report")
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        frmDashboard.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmDashboard.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDashboard.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmDashboard.Show()
    End Sub
End Class