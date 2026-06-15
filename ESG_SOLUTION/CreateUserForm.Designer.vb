<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateUserForm
    Inherits Form

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

    Private components As System.ComponentModel.IContainer = Nothing

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpUserDetails = New GroupBox()
        Me.txtEmpId = New TextBox()
        Me.lblEmpId = New Label()
        Me.txtUserName = New TextBox()
        Me.lblUserName = New Label()
        Me.txtPassword = New TextBox()
        Me.lblPassword = New Label()
        Me.grpSecurityQuestions = New GroupBox()
        Me.pnlSecurityQuestions = New Panel()
        Me.grpAccessRights = New GroupBox()
        Me.clbForms = New CheckedListBox()
        Me.btnCreate = New RoundedButton()
        Me.btnCancel = New RoundedButton()
        Me.lblError = New Label()
        Me.grpUserDetails.SuspendLayout()
        Me.grpSecurityQuestions.SuspendLayout()
        Me.grpAccessRights.SuspendLayout()
        Me.SuspendLayout()

        ' grpUserDetails
        Me.grpUserDetails.Controls.Add(Me.txtEmpId)
        Me.grpUserDetails.Controls.Add(Me.lblEmpId)
        Me.grpUserDetails.Controls.Add(Me.txtUserName)
        Me.grpUserDetails.Controls.Add(Me.lblUserName)
        Me.grpUserDetails.Controls.Add(Me.txtPassword)
        Me.grpUserDetails.Controls.Add(Me.lblPassword)
        Me.grpUserDetails.Location = New Point(20, 20)
        Me.grpUserDetails.Name = "grpUserDetails"
        Me.grpUserDetails.Size = New Size(400, 160)
        Me.grpUserDetails.TabIndex = 0
        Me.grpUserDetails.TabStop = False
        Me.grpUserDetails.Text = "User Details"

        ' txtEmpId
        Me.txtEmpId.Font = New Font("Segoe UI", 10.0F)
        Me.txtEmpId.Location = New Point(150, 35)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New Size(220, 30)
        Me.txtEmpId.TabIndex = 5

        ' lblEmpId
        Me.lblEmpId.AutoSize = True
        Me.lblEmpId.Font = New Font("Segoe UI", 9.0F)
        Me.lblEmpId.Location = New Point(30, 40)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New Size(80, 20)
        Me.lblEmpId.TabIndex = 4
        Me.lblEmpId.Text = "Employee ID:"

        ' txtUserName
        Me.txtUserName.Font = New Font("Segoe UI", 10.0F)
        Me.txtUserName.Location = New Point(150, 75)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New Size(220, 30)
        Me.txtUserName.TabIndex = 3

        ' lblUserName
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New Font("Segoe UI", 9.0F)
        Me.lblUserName.Location = New Point(30, 80)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New Size(83, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Username:"

        ' txtPassword
        Me.txtPassword.Font = New Font("Segoe UI", 10.0F)
        Me.txtPassword.Location = New Point(150, 115)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New Size(220, 30)
        Me.txtPassword.TabIndex = 1

        ' lblPassword
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New Font("Segoe UI", 9.0F)
        Me.lblPassword.Location = New Point(30, 120)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New Size(73, 20)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password:"

        ' grpSecurityQuestions
        Me.grpSecurityQuestions.Controls.Add(Me.pnlSecurityQuestions)
        Me.grpSecurityQuestions.Location = New Point(20, 195)
        Me.grpSecurityQuestions.Name = "grpSecurityQuestions"
        Me.grpSecurityQuestions.Size = New Size(400, 250)
        Me.grpSecurityQuestions.TabIndex = 1
        Me.grpSecurityQuestions.TabStop = False
        Me.grpSecurityQuestions.Text = "Security Questions (for password recovery)"

        ' pnlSecurityQuestions
        Me.pnlSecurityQuestions.AutoScroll = True
        Me.pnlSecurityQuestions.Location = New Point(20, 25)
        Me.pnlSecurityQuestions.Name = "pnlSecurityQuestions"
        Me.pnlSecurityQuestions.Size = New Size(360, 210)
        Me.pnlSecurityQuestions.TabIndex = 0

        ' grpAccessRights
        Me.grpAccessRights.Controls.Add(Me.clbForms)
        Me.grpAccessRights.Location = New Point(440, 20)
        Me.grpAccessRights.Name = "grpAccessRights"
        Me.grpAccessRights.Size = New Size(320, 425)
        Me.grpAccessRights.TabIndex = 2
        Me.grpAccessRights.TabStop = False
        Me.grpAccessRights.Text = "Access Rights"

        ' clbForms
        Me.clbForms.CheckOnClick = True
        Me.clbForms.Font = New Font("Segoe UI", 10.0F)
        Me.clbForms.FormattingEnabled = True
        Me.clbForms.Location = New Point(20, 30)
        Me.clbForms.Name = "clbForms"
        Me.clbForms.Size = New Size(280, 370)
        Me.clbForms.TabIndex = 0

        ' btnCreate
        Me.btnCreate.BackColor = Color.FromArgb(16, 185, 129)
        Me.btnCreate.CornerRadius = 8
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = FlatStyle.Flat
        Me.btnCreate.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        Me.btnCreate.ForeColor = Color.White
        Me.btnCreate.Location = New Point(180, 465)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New Size(120, 40)
        Me.btnCreate.TabIndex = 3
        Me.btnCreate.Text = "Create User"
        Me.btnCreate.UseVisualStyleBackColor = False
        'AddHandler btnCreate.Click, AddressOf btnCreate_Click

        ' btnCancel
        Me.btnCancel.BackColor = Color.FromArgb(100, 116, 139)
        Me.btnCancel.CornerRadius = 8
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.Font = New Font("Segoe UI", 10.0F)
        Me.btnCancel.ForeColor = Color.White
        Me.btnCancel.Location = New Point(480, 465)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New Size(120, 40)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        'AddHandler btnCancel.Click, AddressOf btnCancel_Click

        ' lblError
        Me.lblError.AutoSize = True
        Me.lblError.Font = New Font("Segoe UI", 8.0F)
        Me.lblError.ForeColor = Color.FromArgb(239, 68, 68)
        Me.lblError.Location = New Point(20, 475)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New Size(0, 19)
        Me.lblError.TabIndex = 5

        ' CreateUserForm
        Me.AutoScaleMode = AutoScaleMode.None
        Me.ClientSize = New Size(800, 530)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.grpAccessRights)
        Me.Controls.Add(Me.grpSecurityQuestions)
        Me.Controls.Add(Me.grpUserDetails)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateUserForm"
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "Create New User"
        Me.grpUserDetails.ResumeLayout(False)
        Me.grpUserDetails.PerformLayout()
        Me.grpSecurityQuestions.ResumeLayout(False)
        Me.grpAccessRights.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents grpUserDetails As GroupBox
    Private WithEvents txtEmpId As TextBox
    Private WithEvents lblEmpId As Label
    Private WithEvents txtUserName As TextBox
    Private WithEvents lblUserName As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents lblPassword As Label
    Private WithEvents grpSecurityQuestions As GroupBox
    Private WithEvents pnlSecurityQuestions As Panel
    Private WithEvents grpAccessRights As GroupBox
    Private WithEvents clbForms As CheckedListBox
    Private WithEvents btnCreate As RoundedButton
    Private WithEvents btnCancel As RoundedButton
    Private WithEvents lblError As Label
End Class