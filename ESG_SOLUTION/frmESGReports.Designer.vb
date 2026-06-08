<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESGReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        RoundedButton1 = New RoundedButton()
        SuspendLayout()
        ' 
        ' RoundedButton1
        ' 
        RoundedButton1.BackColor = SystemColors.AppWorkspace
        RoundedButton1.CornerRadius = 8
        RoundedButton1.Location = New Point(107, 78)
        RoundedButton1.Name = "RoundedButton1"
        RoundedButton1.Size = New Size(101, 33)
        RoundedButton1.TabIndex = 1
        RoundedButton1.Text = "Daily Waste"
        RoundedButton1.UseVisualStyleBackColor = False
        ' 
        ' frmESGReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RoundedButton1)
        Name = "frmESGReports"
        Text = "ESGReports"
        ResumeLayout(False)
    End Sub

    Friend WithEvents RoundedButton1 As RoundedButton
End Class
