<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreenRights
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
        cmbscreen = New ComboBox()
        dgvscreensrights = New DataGridView()
        txtemployeeno = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(dgvscreensrights, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbscreen
        ' 
        cmbscreen.FormattingEnabled = True
        cmbscreen.Location = New Point(387, 65)
        cmbscreen.Name = "cmbscreen"
        cmbscreen.Size = New Size(121, 23)
        cmbscreen.TabIndex = 0
        ' 
        ' dgvscreensrights
        ' 
        dgvscreensrights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvscreensrights.Location = New Point(92, 194)
        dgvscreensrights.Name = "dgvscreensrights"
        dgvscreensrights.Size = New Size(612, 212)
        dgvscreensrights.TabIndex = 1
        ' 
        ' txtemployeeno
        ' 
        txtemployeeno.Location = New Point(163, 62)
        txtemployeeno.Name = "txtemployeeno"
        txtemployeeno.Size = New Size(100, 23)
        txtemployeeno.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 3
        Label1.Text = "Employee"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(288, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 15)
        Label2.TabIndex = 4
        Label2.Text = "Screen Names"
        ' 
        ' frmScreenRights
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtemployeeno)
        Controls.Add(dgvscreensrights)
        Controls.Add(cmbscreen)
        Name = "frmScreenRights"
        Text = "frmScreenRights"
        CType(dgvscreensrights, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbscreen As ComboBox
    Friend WithEvents dgvscreensrights As DataGridView
    Friend WithEvents txtemployeeno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
