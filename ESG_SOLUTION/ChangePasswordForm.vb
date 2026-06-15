Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace ESG_SOLUTION
    Public Class ChangePasswordForm
        Inherits Form

        Private empId As String
        Private isFirstLoginChange As Boolean

        Public Sub New(empId As String, isFirstLoginChange As Boolean)
            InitializeComponent()
            Me.empId = empId
            Me.isFirstLoginChange = isFirstLoginChange

            If Not isFirstLoginChange Then
                Me.Text = "Reset Password"
                lblTitle.Text = "Reset Password"
                lblMessage.Text = "Please enter your new password."
            End If
        End Sub

        Private Sub btnChangePassword_Click(sender As Object, e As EventArgs)
            Dim newPassword As String = txtNewPassword.Text
            Dim confirmPassword As String = txtConfirmPassword.Text

            lblError.Text = ""

            ' Validate password
            If String.IsNullOrEmpty(newPassword) Then
                lblError.Text = "Please enter a new password."
                txtNewPassword.Focus()
                Return
            End If

            If newPassword <> confirmPassword Then
                lblError.Text = "Passwords do not match."
                txtConfirmPassword.Focus()
                Return
            End If

            If Not IsValidPassword(newPassword) Then
                lblError.Text = "Password must be at least 6 characters and contain uppercase, lowercase, and numbers."
                txtNewPassword.Focus()
                Return
            End If

            Try
                UpdatePassword(empId, newPassword, False)
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                lblError.Text = "Error changing password: " & ex.Message
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs)
            If isFirstLoginChange Then
                If MessageBox.Show("Are you sure you want to exit? You will need to contact administrator to reset your password.",
                                 "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Me.DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            Else
                Me.Close()
            End If
        End Sub
    End Class
End Namespace