Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Drawing.Drawing2D

Module ModShared
    Public connString As String = "Data Source='DCL-ICT-007\DEVELOPER';Initial Catalog=ESG;Integrated Security=True"
    Public baseFolderPath As String = "\\DCL-ICT-007\Environment project\Upload"
    Public PBReportPath As String = "\\DCL-ICT-007\Production_Reports\"
    Public mReportName, mRecordSelectionFormula, mPara As String
    Public objForm As New frm_ESGReportViewer
    Public strReportPath As String


    ' Style configuration
    Public Property TopBarColor As Color = Color.FromArgb(43, 108, 43)
    Public Property BottomBarColor As Color = Color.FromArgb(43, 108, 43)
    Public Property BarHeight As Integer = 40
    Public Property SmokeIntensity As Integer = 150 ' 0-255, higher = more smoke effect

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

    ' Custom Panel with smoke gradient effect
    Public Class SmokeGradientPanel
        Inherits Panel
        Public Property GradientStartColor As Color = Color.FromArgb(52, 73, 94)
        Public Property GradientEndColor As Color = Color.FromArgb(52, 73, 94)
        Public Property IsTopBar As Boolean = True
        Public Property SmokeOpacity As Integer = 150

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim gradientRect As New Rectangle(0, 0, Me.Width, Me.Height)
            Dim gradientBrush As LinearGradientBrush

            If IsTopBar Then
                ' Top bar: Solid color at top, fading to transparent/smoke at bottom
                Dim startColor = GradientStartColor
                Dim endColor = Color.FromArgb(SmokeOpacity, GradientEndColor)
                gradientBrush = New LinearGradientBrush(gradientRect, startColor, endColor, LinearGradientMode.Vertical)
            Else
                ' Bottom bar: Transparent/smoke at top, solid color at bottom
                Dim startColor = Color.FromArgb(SmokeOpacity, GradientStartColor)
                Dim endColor = GradientEndColor
                gradientBrush = New LinearGradientBrush(gradientRect, startColor, endColor, LinearGradientMode.Vertical)
            End If

            e.Graphics.FillRectangle(gradientBrush, gradientRect)
            gradientBrush.Dispose()
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Me.Invalidate() ' Redraw on resize
        End Sub
    End Class

    ' Apply the modern style with top and bottom bars as base layer
    Public Sub ApplyModernStyle(form As Form)
        Try
            ' Remove existing style panels if any
            RemoveStylePanels(form)

            ' Create a container panel that will hold the content (components)
            Dim contentContainer As Panel
            Dim existingContainer As Control = Nothing

            ' Check if form already has a content container
            For Each ctrl As Control In form.Controls
                If ctrl.Name = "StyleContentContainer" Then
                    contentContainer = TryCast(ctrl, Panel)
                    If contentContainer IsNot Nothing Then
                        existingContainer = contentContainer
                        Exit For
                    End If
                End If
            Next

            If existingContainer Is Nothing Then
                ' Create new content container
                contentContainer = New Panel()
                contentContainer.Name = "StyleContentContainer"
                contentContainer.Dock = DockStyle.Fill
                contentContainer.BackColor = Color.Transparent

                ' Move all existing controls to the content container
                Dim existingControls As New List(Of Control)
                For Each ctrl As Control In form.Controls
                    existingControls.Add(ctrl)
                Next

                form.Controls.Clear()
                form.Controls.Add(contentContainer)

                For Each ctrl As Control In existingControls
                    contentContainer.Controls.Add(ctrl)
                Next
            Else
                contentContainer = TryCast(existingContainer, Panel)
            End If

            ' Create top bar panel with smoke gradient
            Dim topPanel As New SmokeGradientPanel()
            topPanel.Name = "StyleTopPanel"
            topPanel.Height = BarHeight
            topPanel.Dock = DockStyle.Top
            topPanel.GradientStartColor = TopBarColor
            topPanel.GradientEndColor = TopBarColor
            topPanel.IsTopBar = True
            topPanel.SmokeOpacity = SmokeIntensity
            topPanel.BackColor = Color.Transparent

            ' Create bottom bar panel with smoke gradient
            Dim bottomPanel As New SmokeGradientPanel()
            bottomPanel.Name = "StyleBottomPanel"
            bottomPanel.Height = BarHeight
            bottomPanel.Dock = DockStyle.Bottom
            bottomPanel.GradientStartColor = BottomBarColor
            bottomPanel.GradientEndColor = BottomBarColor
            bottomPanel.IsTopBar = False
            bottomPanel.SmokeOpacity = SmokeIntensity
            bottomPanel.BackColor = Color.Transparent

            ' Add bars to form (these will be at the bottom layer)
            form.Controls.Add(topPanel)
            form.Controls.Add(bottomPanel)

            ' Ensure content container is on top of bars
            contentContainer.BringToFront()

            ' Make bars stay at bottom layer
            topPanel.SendToBack()
            bottomPanel.SendToBack()

            ' Add padding to content container to prevent content overlap
            contentContainer.Padding = New Padding(0, BarHeight + -40, -40, BarHeight + -60)

            ' Set form background to white
            form.BackColor = Color.White

            ' Handle form resize to redraw gradients
            AddHandler form.Resize, Sub(sender As Object, e As EventArgs)
                                        topPanel.Invalidate()
                                        bottomPanel.Invalidate()
                                    End Sub

        Catch ex As Exception
            MessageBox.Show($"Error applying style: {ex.Message}", "Style Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Apply style with custom colors
    Public Sub ApplyModernStyle(form As Form, topColor As Color, bottomColor As Color, Optional barHeight As Integer = 40, Optional smokeIntensity As Integer = 150)
        TopBarColor = topColor
        BottomBarColor = bottomColor
        barHeight = barHeight
        smokeIntensity = smokeIntensity
        ApplyModernStyle(form)
    End Sub

    ' Remove existing style panels
    Private Sub RemoveStylePanels(form As Form)
        Dim toRemove As New List(Of Control)
        For Each ctrl As Control In form.Controls
            If ctrl.Name = "StyleTopPanel" OrElse ctrl.Name = "StyleBottomPanel" OrElse ctrl.Name = "StyleContentContainer" Then
                toRemove.Add(ctrl)
            End If
        Next

        For Each ctrl As Control In toRemove
            If ctrl IsNot Nothing Then
                ' Move child controls back to form if it's the content container
                If ctrl.Name = "StyleContentContainer" AndAlso TypeOf ctrl Is Panel Then
                    Dim container As Panel = TryCast(ctrl, Panel)
                    If container IsNot Nothing Then
                        Dim childControls As New List(Of Control)
                        For Each child As Control In container.Controls
                            childControls.Add(child)
                        Next
                        For Each child As Control In childControls
                            form.Controls.Add(child)
                        Next
                    End If
                End If

                form.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next
    End Sub

    ' Update smoke effect intensity dynamically
    Public Sub UpdateSmokeIntensity(form As Form, intensity As Integer)
        SmokeIntensity = Math.Max(0, Math.Min(255, intensity))

        ' Update the smoke panels
        For Each ctrl As Control In form.Controls
            If ctrl.Name = "StyleTopPanel" AndAlso TypeOf ctrl Is SmokeGradientPanel Then
                DirectCast(ctrl, SmokeGradientPanel).SmokeOpacity = SmokeIntensity
                ctrl.Invalidate()
            ElseIf ctrl.Name = "StyleBottomPanel" AndAlso TypeOf ctrl Is SmokeGradientPanel Then
                DirectCast(ctrl, SmokeGradientPanel).SmokeOpacity = SmokeIntensity
                ctrl.Invalidate()
            End If
        Next

        form.Refresh()
    End Sub

    ' Update bar colors dynamically
    Public Sub UpdateBarColors(form As Form, topColor As Color, bottomColor As Color)
        TopBarColor = topColor
        BottomBarColor = bottomColor

        For Each ctrl As Control In form.Controls
            If ctrl.Name = "StyleTopPanel" AndAlso TypeOf ctrl Is SmokeGradientPanel Then
                DirectCast(ctrl, SmokeGradientPanel).GradientStartColor = topColor
                DirectCast(ctrl, SmokeGradientPanel).GradientEndColor = topColor
                ctrl.Invalidate()
            ElseIf ctrl.Name = "StyleBottomPanel" AndAlso TypeOf ctrl Is SmokeGradientPanel Then
                DirectCast(ctrl, SmokeGradientPanel).GradientStartColor = bottomColor
                DirectCast(ctrl, SmokeGradientPanel).GradientEndColor = bottomColor
                ctrl.Invalidate()
            End If
        Next

        form.Refresh()
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