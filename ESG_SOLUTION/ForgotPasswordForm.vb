Imports System.Windows.Forms

Namespace ESG_SOLUTION
    Public Class ForgotPasswordForm
        Inherits Form

        Private currentEmpId As String = ""
        Private currentOTP As String = ""
        Private securityAnswerControls As New Dictionary(Of Integer, TextBox)()

        Private Sub btnSearchUser_Click(sender As Object, e As EventArgs)
            Dim username As String = txtUsername.Text.Trim()

            If String.IsNullOrEmpty(username) Then
                lblInfo.Text = "Please enter a username."
                lblInfo.ForeColor = Color.FromArgb(239, 68, 68)
                Return
            End If

            Dim dt As DataTable = GetUserByUserName(username)

            If dt.Rows.Count = 0 Then
                lblInfo.Text = "Username not found."
                lblInfo.ForeColor = Color.FromArgb(239, 68, 68)
                Return
            End If

            currentEmpId = dt.Rows(0)("EmpId").ToString()

            If Not Convert.ToBoolean(dt.Rows(0)("IsActive")) Then
                lblInfo.Text = "Account is deactivated. Please contact administrator."
                lblInfo.ForeColor = Color.FromArgb(239, 68, 68)
                Return
            End If

            lblInfo.Text = "User found. Please select a reset method below."
            lblInfo.ForeColor = Color.FromArgb(16, 185, 129)

            ' Load security questions for the user
            LoadSecurityQuestions()

            ' Enable OTP option
            btnSendOTP.Enabled = True
        End Sub

        Private Sub LoadSecurityQuestions()
            pnlSecurityQuestions.Controls.Clear()
            securityAnswerControls.Clear()

            Dim questions As DataTable = GetUserSecurityQuestions(currentEmpId)

            If questions.Rows.Count = 0 Then
                lblSecurityError.Text = "No security questions found for this user."
                Return
            End If

            Dim yOffset As Integer = 10

            For Each row As DataRow In questions.Rows
                Dim questionId As Integer = Convert.ToInt32(row("QuestionID"))
                Dim questionText As String = row("QuestionText").ToString()

                Dim lblQuestion As New Label()
                lblQuestion.Text = questionText
                lblQuestion.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                lblQuestion.Location = New Point(10, yOffset)
                lblQuestion.Size = New Size(430, 25)

                Dim txtAnswer As New TextBox()
                txtAnswer.Name = $"answer_{questionId}"
                txtAnswer.Font = New Font("Segoe UI", 10.0F)
                txtAnswer.Location = New Point(10, yOffset + 25)
                txtAnswer.Size = New Size(430, 30)
                txtAnswer.PasswordChar = "●"c

                pnlSecurityQuestions.Controls.Add(lblQuestion)
                pnlSecurityQuestions.Controls.Add(txtAnswer)

                securityAnswerControls.Add(questionId, txtAnswer)

                yOffset += 70
            Next

            pnlSecurityQuestions.AutoScrollMinSize = New Size(0, yOffset + 10)
        End Sub

        Private Sub btnVerifyAnswers_Click(sender As Object, e As EventArgs)
            If String.IsNullOrEmpty(currentEmpId) Then
                lblSecurityError.Text = "Please search for a user first."
                Return
            End If

            Dim answers As New Dictionary(Of Integer, String)()

            For Each kvp As KeyValuePair(Of Integer, TextBox) In securityAnswerControls
                If String.IsNullOrEmpty(kvp.Value.Text.Trim()) Then
                    lblSecurityError.Text = "Please answer all security questions."
                    Return
                End If
                answers.Add(kvp.Key, kvp.Value.Text.Trim())
            Next

            If VerifySecurityAnswers(currentEmpId, answers) Then
                ' Show password reset form
                Dim changePwdForm As New ChangePasswordForm(currentEmpId, False)
                If changePwdForm.ShowDialog() = DialogResult.OK Then
                    MessageBox.Show("Password has been reset successfully! Please login with your new password.",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Else
                lblSecurityError.Text = "One or more answers are incorrect. Please try again."
            End If
        End Sub

        Private Sub btnSendOTP_Click(sender As Object, e As EventArgs)
            If String.IsNullOrEmpty(currentEmpId) Then
                lblOTPError.Text = "Please search for a user first."
                Return
            End If

            ' Generate OTP
            currentOTP = New Random().Next(100000, 999999).ToString()

            ' Store OTP in database
            GenerateResetToken(currentEmpId)

            ' Get user email (you would need to add email field to user table)
            ' For now, we'll use username as email or you can add email field
            Dim userEmail As String = txtUsername.Text.Trim() & "@yourdomain.com"

            If SendOTPEmail(userEmail, currentOTP) Then
                btnVerifyOTP.Enabled = True
                lblOTPError.Text = "OTP sent successfully! Please check your email."
                lblOTPError.ForeColor = Color.FromArgb(16, 185, 129)
                txtOTP.Enabled = True
                txtOTP.Focus()
            Else
                lblOTPError.Text = "Failed to send OTP. Please contact administrator."
                lblOTPError.ForeColor = Color.FromArgb(239, 68, 68)
            End If
        End Sub

        Private Sub btnVerifyOTP_Click(sender As Object, e As EventArgs)
            Dim enteredOTP As String = txtOTP.Text.Trim()

            If String.IsNullOrEmpty(enteredOTP) Then
                lblOTPError.Text = "Please enter the OTP."
                Return
            End If

            If enteredOTP = currentOTP Then
                If VerifyResetToken(currentEmpId, enteredOTP) Then
                    ' Show password reset form
                    Dim changePwdForm As New ChangePasswordForm(currentEmpId, False)
                    If changePwdForm.ShowDialog() = DialogResult.OK Then
                        ClearResetToken(currentEmpId)
                        MessageBox.Show("Password has been reset successfully! Please login with your new password.",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    End If
                Else
                    lblOTPError.Text = "Invalid or expired OTP. Please request a new one."
                End If
            Else
                lblOTPError.Text = "Invalid OTP. Please try again."
            End If
        End Sub
    End Class
End Namespace