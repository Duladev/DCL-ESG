<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        btnCSR = New Button()
        btnWaste = New Button()
        btnEmp = New Button()
        btnInvetory = New Button()
        btnMinorities = New Button()
        SuspendLayout()
        ' 
        ' btnCSR
        ' 
        btnCSR.Location = New Point(63, 132)
        btnCSR.Name = "btnCSR"
        btnCSR.Size = New Size(98, 40)
        btnCSR.TabIndex = 0
        btnCSR.Text = "CSR"
        btnCSR.UseVisualStyleBackColor = True
        ' 
        ' btnWaste
        ' 
        btnWaste.Location = New Point(167, 132)
        btnWaste.Name = "btnWaste"
        btnWaste.Size = New Size(107, 40)
        btnWaste.TabIndex = 0
        btnWaste.Text = "Waste Management"
        btnWaste.UseVisualStyleBackColor = True
        ' 
        ' btnEmp
        ' 
        btnEmp.Location = New Point(280, 132)
        btnEmp.Name = "btnEmp"
        btnEmp.Size = New Size(107, 40)
        btnEmp.TabIndex = 0
        btnEmp.Text = "Employee"
        btnEmp.UseVisualStyleBackColor = True
        ' 
        ' btnInvetory
        ' 
        btnInvetory.Location = New Point(393, 132)
        btnInvetory.Name = "btnInvetory"
        btnInvetory.Size = New Size(107, 40)
        btnInvetory.TabIndex = 0
        btnInvetory.Text = "Inventory"
        btnInvetory.UseVisualStyleBackColor = True
        ' 
        ' btnMinorities
        ' 
        btnMinorities.Location = New Point(506, 132)
        btnMinorities.Name = "btnMinorities"
        btnMinorities.Size = New Size(107, 40)
        btnMinorities.TabIndex = 0
        btnMinorities.Text = "Minorities"
        btnMinorities.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMinorities)
        Controls.Add(btnInvetory)
        Controls.Add(btnEmp)
        Controls.Add(btnWaste)
        Controls.Add(btnCSR)
        Name = "frmDashboard"
        Text = "Dashboard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnCSR As Button
    Friend WithEvents btnWaste As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents btnInvetory As Button
    Friend WithEvents btnMinorities As Button
End Class
