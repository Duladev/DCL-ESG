Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Module modShared
    ' existing connection string
    Public connString As String = "Server=DCL-ICT-007\DEVELOPER;Database=ESG;Integrated Security=True;"
    Public uploadFolderPath As String = "C:\ESG_Uploads\"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connString)
    End Function

    Public Sub EnsureUploadFolder()
        If Not Directory.Exists(uploadFolderPath) Then
            Directory.CreateDirectory(uploadFolderPath)
        End If
    End Sub

    Public Function SaveMultipleFiles(files As List(Of String), recordIdentifier As String, category As String) As String
        EnsureUploadFolder()
        Dim savedPaths As New List(Of String)

        For Each filePath As String In files
            Dim fileName As String = $"{category}_{recordIdentifier}_{DateTime.Now.Ticks}_{Path.GetFileName(filePath)}"
            Dim destPath As String = Path.Combine(uploadFolderPath, fileName)
            File.Copy(filePath, destPath, True)
            savedPaths.Add(destPath)
        Next

        Return String.Join("|", savedPaths)
    End Function

    Public Function GetFilesFromPath(pathsString As String) As List(Of String)
        Dim files As New List(Of String)
        If Not String.IsNullOrEmpty(pathsString) Then
            files.AddRange(pathsString.Split("|"c))
        End If
        Return files
    End Function

    Public Sub ExportToExcel(grid As DataGridView, fileName As String)
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excel Files|*.xlsx|CSV Files|*.csv"
            sfd.FileName = $"{fileName}_{DateTime.Now:yyyyMMdd_HHmmss}"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim csvContent As String = ""

                    ' Headers
                    For i As Integer = 0 To grid.Columns.Count - 1
                        If grid.Columns(i).Visible AndAlso grid.Columns(i).Name <> "ViewFiles" Then
                            csvContent &= """" & grid.Columns(i).HeaderText & """"
                            If i < grid.Columns.Count - 1 Then csvContent &= ","
                        End If
                    Next
                    csvContent &= vbCrLf

                    ' Data
                    For Each row As DataGridViewRow In grid.Rows
                        If Not row.IsNewRow Then
                            For i As Integer = 0 To grid.Columns.Count - 1
                                If grid.Columns(i).Visible AndAlso grid.Columns(i).Name <> "ViewFiles" Then
                                    Dim value As String = If(row.Cells(i).Value Is Nothing, "", row.Cells(i).Value.ToString().Replace("""", """"""))
                                    csvContent &= """" & value & """"
                                    If i < grid.Columns.Count - 1 Then csvContent &= ","
                                End If
                            Next
                            csvContent &= vbCrLf
                        End If
                    Next

                    File.WriteAllText(sfd.FileName, csvContent)
                    MessageBox.Show($"Data exported successfully to {sfd.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' Additional helper methods for ESG application

    Public Sub ClearFormControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is NumericUpDown Then
                DirectCast(ctrl, NumericUpDown).Value = 0
            ElseIf TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DateTime.Now
            ElseIf TypeOf ctrl Is ComboBox Then
                If DirectCast(ctrl, ComboBox).Items.Count > 0 Then
                    DirectCast(ctrl, ComboBox).SelectedIndex = 0
                End If
            ElseIf TypeOf ctrl Is GroupBox Then
                ClearFormControls(ctrl)
            ElseIf TypeOf ctrl Is TabPage Then
                ClearFormControls(ctrl)
            ElseIf TypeOf ctrl Is Panel Then
                ClearFormControls(ctrl)
            End If
        Next
    End Sub

    Public Function ValidateDateRange(ByVal startDate As DateTime, ByVal endDate As DateTime) As Boolean
        Return startDate <= endDate
    End Function

    Public Function GetCurrentMonthYear() As String
        Return DateTime.Now.ToString("MMMM yyyy")
    End Function

    Public Function GetMonthName(ByVal month As Integer) As String
        Return New DateTime(DateTime.Now.Year, month, 1).ToString("MMMM")
    End Function
End Module