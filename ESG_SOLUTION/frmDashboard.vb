Imports System.Drawing

Public Class frmDashboard

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        UpdateDateTime()
        ' Remove button styling with hover effects
        ' ApplyButtonStyling() - Commented out to remove hover effects

        ' To add a background image, uncomment and specify your image path:
        'Me.BackgroundImage = System.Drawing.Image.FromFile("F:\DCL-ESG\ESG_SOLUTION\1.jpg")
        'Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub TimerDateTime_Tick(sender As Object, e As EventArgs) Handles TimerDateTime.Tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        'labelDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss")
    End Sub

    ' This method is completely removed/not called to eliminate hover effects
    Private Sub ApplyButtonStyling()
        ' All hover effect code removed
    End Sub

    Private Sub BtnCSR_Click(sender As Object, e As EventArgs) Handles BtnCSR.Click
        frmCSR.Show()
        ShowMessage("CSR Dashboard loaded.")
    End Sub

    Private Sub BtnEMP_Details_Click(sender As Object, e As EventArgs) Handles BtnEMP_Details.Click
        frmEmployee.Show()
        ShowMessage("Employee Management module loaded.")
    End Sub

    Private Sub BtnINVENTORY_Click(sender As Object, e As EventArgs) Handles BtnINVENTORY.Click
        frmMain.Show()
        ShowMessage("Inventory module loaded.")
    End Sub

    Private Sub BtnWASTE_MANAGEMENT_Click(sender As Object, e As EventArgs) Handles BtnWASTE_MANAGEMENT.Click
        frmWasteManagement.Show()
        ShowMessage("Waste Management module loaded.")
    End Sub

    Private Sub BtnSOCIAL_Click(sender As Object, e As EventArgs) Handles BtnSOCIAL.Click
        frmESGMain.Show()
        ShowMessage("Social module loaded.")
    End Sub

    Private Sub BtnREPORTS_Click(sender As Object, e As EventArgs) Handles BtnREPORTS.Click
        frmESGReports.Show()
        ShowMessage("Reports module loaded.")
    End Sub

    Private Sub UpdateMainContent(moduleName As String)
        For i As Integer = PanelMainContent.Controls.Count - 1 To 0 Step -1
            Dim ctrl As Control = PanelMainContent.Controls(i)
            If ctrl.Name <> "LabelWelcome" AndAlso ctrl.Name <> "LabelDateTime" Then
                PanelMainContent.Controls.Remove(ctrl)
                ctrl.Dispose()
            End If
        Next

        Dim contentPanel As New Panel()
        contentPanel.Location = New Point(20, 100)
        contentPanel.Size = New Size(PanelMainContent.Width - 40, PanelMainContent.Height - 120)
        contentPanel.BackColor = Color.White
        contentPanel.BorderStyle = BorderStyle.FixedSingle

        Dim lblInfo As New Label()
        lblInfo.Text = GetModuleDescription(moduleName)
        lblInfo.Location = New Point(20, 20)
        lblInfo.Size = New Size(contentPanel.Width - 40, 100)
        lblInfo.Font = New Font("Segoe UI", 11)
        lblInfo.ForeColor = Color.FromArgb(64, 64, 64)

        Dim picIcon As New Panel()
        picIcon.Location = New Point(20, 130)
        picIcon.Size = New Size(100, 100)
        picIcon.BackColor = GetModuleColor(moduleName)

        Dim lblIconText As New Label()
        lblIconText.Text = GetModuleShortName(moduleName)
        lblIconText.Location = New Point(0, 35)
        lblIconText.Size = New Size(100, 30)
        lblIconText.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblIconText.ForeColor = Color.White
        lblIconText.TextAlign = ContentAlignment.MiddleCenter
        picIcon.Controls.Add(lblIconText)

        Dim lblFeatures As New Label()
        lblFeatures.Text = GetFeatureList(moduleName)
        lblFeatures.Location = New Point(140, 130)
        lblFeatures.Size = New Size(contentPanel.Width - 160, 200)
        lblFeatures.Font = New Font("Segoe UI", 10)
        lblFeatures.ForeColor = Color.FromArgb(80, 80, 80)

        contentPanel.Controls.AddRange(New Control() {lblInfo, picIcon, lblFeatures})
        PanelMainContent.Controls.Add(contentPanel)

        Dim random As New Random()
        Dim newScore As Integer = random.Next(70, 95)
    End Sub

    Private Function GetModuleDescription(moduleName As String) As String
        Select Case moduleName
            Case "CSR Module"
                Return "Corporate Social Responsibility (CSR) initiatives help organizations align business operations with social values and sustainability goals."
            Case "Employee Details"
                Return "Employee management focuses on creating a positive work environment, ensuring fair labor practices, and promoting diversity and inclusion."
            Case "Inventory Management"
                Return "Sustainable inventory management focuses on reducing environmental impact through efficient resource use and sustainable sourcing."
            Case "Waste Management"
                Return "Environmental stewardship through effective waste reduction, recycling programs, and proper disposal methods."
            Case "Social Impact"
                Return "Measure and improve social impact through community programs, stakeholder engagement, and social responsibility initiatives."
            Case Else
                Return "Generate comprehensive ESG reports, track key performance indicators, and ensure compliance with sustainability standards."
        End Select
    End Function

    Private Function GetModuleShortName(moduleName As String) As String
        Select Case moduleName
            Case "CSR Module" : Return "CSR"
            Case "Employee Details" : Return "EMP"
            Case "Inventory Management" : Return "INV"
            Case "Waste Management" : Return "WST"
            Case "Social Impact" : Return "SOC"
            Case Else : Return "RPT"
        End Select
    End Function

    Private Function GetModuleColor(moduleName As String) As Color
        Select Case moduleName
            Case "CSR Module" : Return Color.FromArgb(52, 152, 219)
            Case "Employee Details" : Return Color.FromArgb(46, 204, 113)
            Case "Inventory Management" : Return Color.FromArgb(241, 196, 15)
            Case "Waste Management" : Return Color.FromArgb(231, 76, 60)
            Case "Social Impact" : Return Color.FromArgb(155, 89, 182)
            Case Else : Return Color.FromArgb(52, 73, 94)
        End Select
    End Function

    Private Function GetFeatureList(moduleName As String) As String
        Select Case moduleName
            Case "CSR Module"
                Return "Key Features:" & vbCrLf & "• Community investment tracking" & vbCrLf & "• Volunteer program management" & vbCrLf & "• CSR initiative planning" & vbCrLf & "• Impact measurement tools"
            Case "Employee Details"
                Return "Key Features:" & vbCrLf & "• Employee demographic dashboard" & vbCrLf & "• Training & development tracking" & vbCrLf & "• Diversity & inclusion metrics" & vbCrLf & "• Health & safety records"
            Case "Inventory Management"
                Return "Key Features:" & vbCrLf & "• Sustainable sourcing tracker" & vbCrLf & "• Material efficiency metrics" & vbCrLf & "• Supply chain carbon footprint" & vbCrLf & "• Real-time stock monitoring"
            Case "Waste Management"
                Return "Key Features:" & vbCrLf & "• Waste reduction progress" & vbCrLf & "• Recycling rate monitoring" & vbCrLf & "• Hazardous waste tracking" & vbCrLf & "• Environmental compliance"
            Case "Social Impact"
                Return "Key Features:" & vbCrLf & "• Community program metrics" & vbCrLf & "• Social ROI calculator" & vbCrLf & "• Stakeholder feedback system" & vbCrLf & "• Impact assessment reports"
            Case Else
                Return "Key Features:" & vbCrLf & "• ESG performance dashboard" & vbCrLf & "• Custom report generator" & vbCrLf & "• Compliance checklist" & vbCrLf & "• Export to PDF/Excel"
        End Select
    End Function

    Private Sub ShowMessage(message As String)
        Dim lblStatus As New Label()
        lblStatus.Text = message
        lblStatus.Location = New Point(20, PanelMainContent.Height - 50)
        lblStatus.Size = New Size(PanelMainContent.Width - 40, 30)
        lblStatus.BackColor = Color.FromArgb(52, 73, 94)
        lblStatus.ForeColor = Color.White
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        lblStatus.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        PanelMainContent.Controls.Add(lblStatus)
        Dim timer As New Timer()
        timer.Interval = 3000
        AddHandler timer.Tick, Sub(senderObj As Object, eObj As EventArgs)
                                   PanelMainContent.Controls.Remove(lblStatus)
                                   lblStatus.Dispose()
                                   timer.Stop()
                                   timer.Dispose()
                               End Sub
        timer.Start()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        For Each ctrl As Control In PanelMainContent.Controls
            If TypeOf ctrl Is Panel Then
                Dim contentPanel As Panel = DirectCast(ctrl, Panel)
                contentPanel.Size = New Size(PanelMainContent.Width - 40, PanelMainContent.Height - 120)
            End If
        Next
    End Sub
End Class