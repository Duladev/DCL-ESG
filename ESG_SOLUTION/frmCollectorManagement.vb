Imports System.Data.SqlClient
Imports System.IO

Public Class frmCollectorManagement
    Private connString As String
    Private currentCollectorID As Integer = -1
    Private licenseDocumentPath As String = ""

    Public Sub New(connectionString As String)
        InitializeComponent()
        connString = connectionString
    End Sub

    Private Sub frmCollectorManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollectors()
    End Sub

    Private Sub LoadCollectors()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT CollectorID, CollectorName, Address, TelephoneNumber, LicenseNumber, LicenseDocumentPath FROM tbl_ESG_WasteCollectors WHERE IsActive = 1 ORDER BY CollectorName"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                grdCollectors.DataSource = dt

                ' Format DataGridView
                If grdCollectors.Columns.Count > 0 Then
                    grdCollectors.Columns("CollectorID").Visible = False
                    grdCollectors.Columns("LicenseDocumentPath").Visible = False
                    grdCollectors.Columns("CollectorName").HeaderText = "Collector Name"
                    grdCollectors.Columns("Address").HeaderText = "Address"
                    grdCollectors.Columns("TelephoneNumber").HeaderText = "Telephone"
                    grdCollectors.Columns("LicenseNumber").HeaderText = "License Number"
                    grdCollectors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading collectors: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveCollector_Click(sender As Object, e As EventArgs) Handles btnSaveCollector.Click
        If String.IsNullOrWhiteSpace(txtCollectorName.Text) Then
            MessageBox.Show("Please enter collector name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                If currentCollectorID = -1 Then
                    ' Insert new collector
                    Dim query As String = "INSERT INTO tbl_ESG_WasteCollectors (CollectorName, Address, TelephoneNumber, LicenseNumber, LicenseDocumentPath) 
                                          VALUES (@Name, @Address, @Phone, @License, @DocPath)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Name", txtCollectorName.Text)
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                        cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text)
                        cmd.Parameters.AddWithValue("@DocPath", If(String.IsNullOrEmpty(licenseDocumentPath), DBNull.Value, licenseDocumentPath))
                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    ' Update existing collector
                    Dim query As String = "UPDATE tbl_ESG_WasteCollectors SET CollectorName=@Name, Address=@Address, 
                                          TelephoneNumber=@Phone, LicenseNumber=@License, LicenseDocumentPath=@DocPath 
                                          WHERE CollectorID=@ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", currentCollectorID)
                        cmd.Parameters.AddWithValue("@Name", txtCollectorName.Text)
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                        cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text)
                        cmd.Parameters.AddWithValue("@DocPath", If(String.IsNullOrEmpty(licenseDocumentPath), DBNull.Value, licenseDocumentPath))
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Collector saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadCollectors()
        Catch ex As Exception
            MessageBox.Show("Error saving collector: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUploadLicense_Click(sender As Object, e As EventArgs) Handles btnUploadLicense.Click
        If ofdLicense.ShowDialog() = DialogResult.OK Then
            licenseDocumentPath = ofdLicense.FileName
            lblLicenseStatus.Text = "Document selected: " & Path.GetFileName(licenseDocumentPath)
        End If
    End Sub

    Private Sub grdCollectors_SelectionChanged(sender As Object, e As EventArgs) Handles grdCollectors.SelectionChanged
        If grdCollectors.SelectedRows.Count > 0 Then
            currentCollectorID = Convert.ToInt32(grdCollectors.SelectedRows(0).Cells("CollectorID").Value)
            txtCollectorName.Text = grdCollectors.SelectedRows(0).Cells("CollectorName").Value.ToString()
            txtAddress.Text = grdCollectors.SelectedRows(0).Cells("Address").Value.ToString()
            txtPhone.Text = grdCollectors.SelectedRows(0).Cells("TelephoneNumber").Value.ToString()
            txtLicenseNumber.Text = grdCollectors.SelectedRows(0).Cells("LicenseNumber").Value.ToString()

            If grdCollectors.SelectedRows(0).Cells("LicenseDocumentPath").Value IsNot DBNull.Value Then
                licenseDocumentPath = grdCollectors.SelectedRows(0).Cells("LicenseDocumentPath").Value.ToString()
                lblLicenseStatus.Text = "Current document: " & Path.GetFileName(licenseDocumentPath)
            Else
                licenseDocumentPath = ""
                lblLicenseStatus.Text = "No document uploaded"
            End If
        End If
    End Sub

    Private Sub btnDeleteCollector_Click(sender As Object, e As EventArgs) Handles btnDeleteCollector.Click
        If currentCollectorID = -1 Then
            MessageBox.Show("Please select a collector to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this collector?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    ' Soft delete - set IsActive to 0
                    Dim query As String = "UPDATE tbl_ESG_WasteCollectors SET IsActive = 0 WHERE CollectorID = @ID"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@ID", currentCollectorID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Collector deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
                LoadCollectors()
            Catch ex As Exception
                MessageBox.Show("Error deleting collector: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadCollectors()
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtCollectorName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtLicenseNumber.Clear()
        licenseDocumentPath = ""
        lblLicenseStatus.Text = "No document selected"
        currentCollectorID = -1
    End Sub

    Private Sub grpCollectorInfo_Enter(sender As Object, e As EventArgs) Handles grpCollectorInfo.Enter

    End Sub
End Class