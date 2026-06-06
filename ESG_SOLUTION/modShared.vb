Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Module ModShared
    Public connString As String = "Data Source=DCL-ICT-007\DEVELOPER;Initial Catalog=ESG;Integrated Security=True"
    Public baseFolderPath As String = "D:\Environment project\Upload"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connString)
    End Function

    Public Function SaveSingleFile(sourceFilePath As String, recordId As String, category As String) As String
        If String.IsNullOrEmpty(sourceFilePath) OrElse Not File.Exists(sourceFilePath) Then
            Return ""
        End If

        Try
            Dim categoryFolder As String = Path.Combine(baseFolderPath, category)
            If Not Directory.Exists(categoryFolder) Then
                Directory.CreateDirectory(categoryFolder)
            End If

            Dim recordFolder As String = Path.Combine(categoryFolder, recordId)
            If Not Directory.Exists(recordFolder) Then
                Directory.CreateDirectory(recordFolder)
            End If

            Dim fileName As String = Path.GetFileName(sourceFilePath)
            Dim destPath As String = Path.Combine(recordFolder, fileName)
            Dim counter As Integer = 1

            While File.Exists(destPath)
                Dim nameWithoutExt As String = Path.GetFileNameWithoutExtension(fileName)
                Dim ext As String = Path.GetExtension(fileName)
                destPath = Path.Combine(recordFolder, $"{nameWithoutExt}_{counter}{ext}")
                counter += 1
            End While

            File.Copy(sourceFilePath, destPath, False)
            Return destPath
        Catch ex As Exception
            MessageBox.Show($"Error saving file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

    Public Function SaveMultipleFiles(files As List(Of String), recordId As String, category As String) As String
        If files Is Nothing OrElse files.Count = 0 Then
            Return ""
        End If

        Dim savedPaths As New List(Of String)
        For Each filePath As String In files
            Dim savedPath As String = SaveSingleFile(filePath, recordId, category)
            If Not String.IsNullOrEmpty(savedPath) Then
                savedPaths.Add(savedPath)
            End If
        Next

        Return String.Join("|", savedPaths)
    End Function

    Public Function GetSafeDecimal(inputText As String) As Decimal
        Dim result As Decimal = 0
        If Decimal.TryParse(inputText, result) Then
            Return result
        End If
        Return 0
    End Function

    Public Function GetFilesFromPath(paths As String) As List(Of String)
        Dim fileList As New List(Of String)

        If String.IsNullOrEmpty(paths) Then
            Return fileList
        End If

        For Each path As String In paths.Split("|"c)
            If File.Exists(path) Then
                fileList.Add(path)
            End If
        Next

        Return fileList
    End Function

    Public Sub ExportToExcel(grid As DataGridView, fileName As String)
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV Files|*.csv|Excel Files|*.xlsx"
            saveFileDialog.Title = "Export Data"
            saveFileDialog.FileName = $"{fileName}_{DateTime.Now:yyyyMMdd_HHmmss}"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim sb As New StringBuilder()

                ' Add headers
                Dim headers As New List(Of String)
                For col As Integer = 0 To grid.Columns.Count - 1
                    If grid.Columns(col).Visible AndAlso grid.Columns(col).Name <> "ViewDocument" Then
                        headers.Add("""" & grid.Columns(col).HeaderText & """")
                    End If
                Next
                sb.AppendLine(String.Join(",", headers))

                ' Add data rows
                For row As Integer = 0 To grid.Rows.Count - 1
                    Dim rowValues As New List(Of String)
                    For col As Integer = 0 To grid.Columns.Count - 1
                        If grid.Columns(col).Visible AndAlso grid.Columns(col).Name <> "ViewDocument" Then
                            Dim cellValue As String = ""
                            If grid.Rows(row).Cells(col).Value IsNot Nothing Then
                                cellValue = grid.Rows(row).Cells(col).Value.ToString()
                            End If
                            cellValue = cellValue.Replace("""", """""")
                            rowValues.Add("""" & cellValue & """")
                        End If
                    Next
                    sb.AppendLine(String.Join(",", rowValues))
                Next

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8)
                MessageBox.Show($"Data exported successfully to {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ApplyBackground(form As Form, imagePath As String)
        Try
            If File.Exists(imagePath) Then
                form.BackgroundImage = Image.FromFile(imagePath)
                form.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Catch ex As Exception
            ' Silently fail if background image can't be loaded
        End Try
    End Sub

    Public Sub OpenFileWithDefaultProgram(filePath As String)
        Try
            If Not File.Exists(filePath) Then
                MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim psi As New ProcessStartInfo()
            psi.FileName = filePath
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"Error opening file: {ex.Message}{Environment.NewLine}File: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub OpenMultipleFiles(files As List(Of String))
        For Each file As String In files
            OpenFileWithDefaultProgram(file)
        Next
    End Sub

    Public Sub SetupForm(form As Form)
        Try
            Dim method As System.Reflection.MethodInfo = GetType(Control).GetMethod("SetStyle",
                System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)

            If method IsNot Nothing Then
                method.Invoke(form, New Object() {ControlStyles.SupportsTransparentBackColor, True})
            End If

            form.BackColor = Color.Transparent
        Catch ex As Exception
            ' Silently fail
        End Try
    End Sub

    Public Sub AddKeyPressHandlers(container As Control.ControlCollection)
        For Each ctrl As Control In container
            If TypeOf ctrl Is TextBox Then
                RemoveHandler ctrl.KeyPress, AddressOf TextBox_KeyPress
                AddHandler ctrl.KeyPress, AddressOf TextBox_KeyPress
            ElseIf ctrl.HasChildren Then
                AddKeyPressHandlers(ctrl.Controls)
            End If
        Next
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(13) Then ' Enter key
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Public Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Public Function FormatPhoneNumber(phone As String) As String
        If String.IsNullOrWhiteSpace(phone) Then Return ""

        Dim cleaned As String = New String(phone.Where(Function(c) Char.IsDigit(c)).ToArray())

        If cleaned.Length = 10 Then
            Return String.Format("{0:(###) ###-####}", Double.Parse(cleaned))
        ElseIf cleaned.Length = 11 AndAlso cleaned.StartsWith("1") Then
            Return String.Format("{0:# (###) ###-####}", Double.Parse(cleaned))
        End If

        Return phone
    End Function

    Public Function TruncateString(text As String, maxLength As Integer) As String
        If String.IsNullOrEmpty(text) Then Return ""
        If text.Length <= maxLength Then Return text
        Return text.Substring(0, maxLength - 3) & "..."
    End Function
End Module