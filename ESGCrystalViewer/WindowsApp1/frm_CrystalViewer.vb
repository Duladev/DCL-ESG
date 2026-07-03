Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_CrystalViewer
    Private objReportDocument As ReportDocument
    Private strReportPath As String = ""
    Private strRecordSelectionFormula As String = ""
    Private strParameterValue As String = ""

    ' Connection string - update this with your actual credentials
    Private connString As String = "Data Source=DCL-ICT-007\DEVELOPER;Initial Catalog=ESG;Integrated Security=True"

    ' Default constructor
    Public Sub New()
        InitializeComponent()
        SetupEventHandlers()
    End Sub

    ' Constructor with report path
    Public Sub New(ByVal reportPath As String)
        InitializeComponent()
        SetupEventHandlers()
        strReportPath = reportPath
        LoadReport()
    End Sub

    ' Constructor with report path and selection formula
    Public Sub New(ByVal reportPath As String, ByVal selectionFormula As String)
        InitializeComponent()
        SetupEventHandlers()
        strReportPath = reportPath
        strRecordSelectionFormula = selectionFormula
        LoadReport()
    End Sub

    ' Constructor with all parameters
    Public Sub New(ByVal reportPath As String, ByVal selectionFormula As String, ByVal paramValue As String)
        InitializeComponent()
        SetupEventHandlers()
        strReportPath = reportPath
        strRecordSelectionFormula = selectionFormula
        strParameterValue = paramValue
        LoadReport()
    End Sub

    Private Sub SetupEventHandlers()
        AddHandler btnExport.Click, AddressOf btnExport_Click
        AddHandler btnPrint.Click, AddressOf btnPrint_Click
        AddHandler btnRefresh.Click, AddressOf btnRefresh_Click
    End Sub

    Private Sub frm_CrystalViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load is handled by constructor now
    End Sub

    Private Sub LoadReport()
        Try
            If String.IsNullOrEmpty(strReportPath) Then
                MessageBox.Show("No report path specified.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not File.Exists(strReportPath) Then
                MessageBox.Show($"Report file not found:{Environment.NewLine}{strReportPath}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Create and load report
            objReportDocument = New ReportDocument()
            objReportDocument.Load(strReportPath)

            ' Apply selection formula if provided
            If Not String.IsNullOrEmpty(strRecordSelectionFormula) Then
                objReportDocument.RecordSelectionFormula = strRecordSelectionFormula
            End If

            ' Apply parameter if provided
            If Not String.IsNullOrEmpty(strParameterValue) Then
                ApplyParameter(strParameterValue)
            End If

            ' Set database connection
            SetDatabaseConnection()

            ' Assign to viewer
            CRViewer1.ReportSource = objReportDocument
            CRViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show($"Error loading report: {ex.Message}",
                          "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyParameter(ByVal paramValue As String)
        Try
            For Each param As ParameterField In objReportDocument.ParameterFields
                param.CurrentValues.Clear()
                Dim val As New ParameterDiscreteValue()
                val.Value = paramValue
                param.CurrentValues.Add(val)
                Exit For
            Next
        Catch ex As Exception
            Debug.WriteLine($"Error applying parameter: {ex.Message}")
        End Try
    End Sub

    Private Sub SetDatabaseConnection()
        Try
            ' Parse connection string
            Dim serverName As String = "DCL-ICT-007\DEVELOPER"
            Dim databaseName As String = "ESG"
            Dim integratedSecurity As Boolean = True
            Dim userName As String = ""
            Dim password As String = ""

            ' Parse the connection string
            Dim parts = connString.Split(";"c)
            For Each part In parts
                Dim keyValue = part.Split("="c)
                If keyValue.Length = 2 Then
                    Select Case keyValue(0).ToLower().Trim()
                        Case "data source", "server", "address", "addr"
                            serverName = keyValue(1).Trim()
                        Case "initial catalog", "database"
                            databaseName = keyValue(1).Trim()
                        Case "user id", "uid"
                            userName = keyValue(1).Trim()
                            integratedSecurity = False
                        Case "password", "pwd"
                            password = keyValue(1).Trim()
                            integratedSecurity = False
                        Case "integrated security"
                            If keyValue(1).ToLower().Trim() = "true" OrElse keyValue(1).ToLower().Trim() = "sspi" Then
                                integratedSecurity = True
                            Else
                                integratedSecurity = False
                            End If
                    End Select
                End If
            Next

            ' Set connection info for each table
            Dim tables As Tables = objReportDocument.Database.Tables
            Dim successCount As Integer = 0

            For Each table As Table In tables
                Try
                    ' Create new logon info
                    Dim logonInfo As New TableLogOnInfo()

                    ' Set connection properties
                    logonInfo.ConnectionInfo.ServerName = serverName
                    logonInfo.ConnectionInfo.DatabaseName = databaseName
                    logonInfo.ConnectionInfo.IntegratedSecurity = integratedSecurity

                    If Not integratedSecurity Then
                        logonInfo.ConnectionInfo.UserID = userName
                        logonInfo.ConnectionInfo.Password = password
                    End If

                    ' Apply the logon info
                    table.ApplyLogOnInfo(logonInfo)
                    successCount += 1

                Catch ex As Exception
                    Debug.WriteLine($"Failed to connect table {table.Name}: {ex.Message}")

                    ' Try alternative approach - set connection via Location
                    Try
                        ' Some reports use Location property for the connection
                        table.Location = $"{serverName}.{databaseName}"
                        successCount += 1
                    Catch ex2 As Exception
                        Debug.WriteLine($"Failed alternative connection for {table.Name}: {ex2.Message}")
                    End Try
                End Try
            Next

            If successCount = 0 AndAlso tables.Count > 0 Then
                MessageBox.Show("Failed to connect to any database tables. Please check your connection settings.",
                              "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Debug.WriteLine($"Successfully connected {successCount} out of {tables.Count} tables")
            End If

        Catch ex As Exception
            MessageBox.Show($"Database connection error: {ex.Message}",
                      "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Diagnostic method to check connection
    Private Sub DiagnosticCheck()
        Try
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("=== DIAGNOSTIC INFO ===")
            sb.AppendLine($"Report Path: {strReportPath}")
            sb.AppendLine($"Report Exists: {File.Exists(strReportPath)}")
            sb.AppendLine($"Connection String: {connString}")

            ' Test database connection
            Try
                Using conn As New SqlConnection(connString)
                    conn.Open()
                    sb.AppendLine("Database Connection: SUCCESS")
                    sb.AppendLine($"Server Version: {conn.ServerVersion}")
                    sb.AppendLine($"Database: {conn.Database}")
                    conn.Close()
                End Using
            Catch ex As Exception
                sb.AppendLine($"Database Connection: FAILED - {ex.Message}")
            End Try

            ' Check if report is loaded
            If objReportDocument IsNot Nothing Then
                sb.AppendLine($"Report Loaded: Yes")
                sb.AppendLine($"Report Name: {objReportDocument.Name}")
                sb.AppendLine($"Tables Count: {objReportDocument.Database.Tables.Count}")

                For Each table As Table In objReportDocument.Database.Tables
                    sb.AppendLine($"  Table: {table.Name}")
                    sb.AppendLine($"    Location: {table.Location}")
                Next
            Else
                sb.AppendLine($"Report Loaded: No")
            End If

            MessageBox.Show(sb.ToString(), "Diagnostic Info",
                      MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Diagnostic error: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Using saveDialog As New SaveFileDialog()
                saveDialog.Filter = "PDF Files|*.pdf|Excel Files|*.xlsx|Word Files|*.docx|CSV Files|*.csv"
                saveDialog.Title = "Export Report"
                saveDialog.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}"

                If saveDialog.ShowDialog() = DialogResult.OK Then
                    Dim exportOptions As New ExportOptions()
                    Dim diskOptions As New DiskFileDestinationOptions()
                    diskOptions.DiskFileName = saveDialog.FileName
                    exportOptions.DestinationOptions = diskOptions
                    exportOptions.ExportDestinationType = ExportDestinationType.DiskFile

                    Select Case Path.GetExtension(saveDialog.FileName).ToLower()
                        Case ".pdf"
                            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                        Case ".xlsx"
                            exportOptions.ExportFormatType = ExportFormatType.ExcelWorkbook
                        Case ".docx"
                            exportOptions.ExportFormatType = ExportFormatType.WordForWindows
                        Case ".csv"
                            exportOptions.ExportFormatType = ExportFormatType.CharacterSeparatedValues
                        Case Else
                            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat
                    End Select

                    objReportDocument.Export(exportOptions)
                    MessageBox.Show($"Report exported successfully to:{Environment.NewLine}{saveDialog.FileName}",
                                  "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error exporting report: {ex.Message}",
                          "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Using printDialog As New PrintDialog()
                printDialog.AllowCurrentPage = True
                printDialog.AllowSelection = True
                printDialog.AllowSomePages = True

                If printDialog.ShowDialog() = DialogResult.OK Then
                    CRViewer1.PrintReport()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error printing: {ex.Message}",
                          "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            CRViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show($"Error refreshing report: {ex.Message}",
                          "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        ' Clean up resources
        If objReportDocument IsNot Nothing Then
            Try
                objReportDocument.Close()
                objReportDocument.Dispose()
                objReportDocument = Nothing
            Catch ex As Exception
                ' Ignore cleanup errors
            End Try
        End If
    End Sub

    Public Sub ReloadReport(ByVal reportPath As String,
                           Optional ByVal selectionFormula As String = "",
                           Optional ByVal paramValue As String = "")
        strReportPath = reportPath
        strRecordSelectionFormula = selectionFormula
        strParameterValue = paramValue
        LoadReport()
    End Sub
End Class